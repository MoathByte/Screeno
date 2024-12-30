Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports LiveCharts
Imports LiveCharts.Wpf
Imports CartesianChart = LiveCharts.WinForms.CartesianChart
Imports Axis = LiveCharts.Wpf.Axis                               ' to not confuse with default windows axis


Public Class Dashboard


    ''
    ' Import necessary Windows API to help us start calculating usage.
    <DllImport("user32.dll")>
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetWindowText(hWnd As IntPtr, lpString As StringBuilder, nMaxCount As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function GetWindowThreadProcessId(hWnd As IntPtr, ByRef lpdwProcessId As UInteger) As UInteger
    End Function


    Public Property LoggedInUserID As Integer
    Public Property LoggedInUsername As String
    Public Property LoggedInFirstName As String
    Public Property LoggedInLastName As String
    Private currentApp As String = ""
    Private focusStartTime As DateTime

    ''
    ' For Timer Mode ' 
    Private focusTimer As New Timer()
    Private elapsedTime As TimeSpan
    Private currentFocusMode As String = "None" ' 


    ''
    ' Timer
    Private Sub FocusTimer_Tick(sender As Object, e As EventArgs)
        ' Increment by 1 second
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))

        ' update lblTimer dynamically
        lblTimer.Text = String.Format("{0}h {1}m {2}s", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds)
    End Sub


    ''


    Private Sub btnFocusMode_CheckedChanged(sender As Object, e As EventArgs) Handles btnNone.CheckedChanged, btnStudying.CheckedChanged, btnGaming.CheckedChanged, btnWork.CheckedChanged
        ' stop the timer when switching focus modes
        If focusTimer.Enabled Then
            focusTimer.Stop()
        End If
        elapsedTime = TimeSpan.Zero
        lblTimer.Text = "Start a timer"
        If btnStudying.Checked Then
            currentFocusMode = "Studying"
            focusTimer.Start()
        ElseIf btnGaming.Checked Then
            currentFocusMode = "Gaming"
            focusTimer.Start()
        ElseIf btnWork.Checked Then
            currentFocusMode = "Work"
            focusTimer.Start()
        Else
            currentFocusMode = "None"
            lblTimer.Text = "Start a timer" ' reset label
        End If
    End Sub
    ''

    Private Sub CheckAppUsageLimits()
        Try
            ' define the database connection string
            Dim connectionString As String = GetConnectionString()

            ' open te database connection
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                SELECT a.AppName, a.MaxTime, 
                       ISNULL(SUM(f.Duration), 0) AS TotalDuration
                FROM AppLimits a
                LEFT JOIN FocusData f 
                ON a.AppName = f.AppName AND a.UserId = f.UserId
                WHERE a.UserId = @UserId
                GROUP BY a.AppName, a.MaxTime"

                ' Execute the query
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", LoggedInUserID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Process each application and its usage data
                        While reader.Read()
                            Dim appName As String = reader("AppName").ToString()
                            Dim maxTime As Integer = Convert.ToInt32(reader("MaxTime")) ' Max allowed time in seconds
                            Dim totalDuration As Integer = Convert.ToInt32(reader("TotalDuration")) ' Total usage time in seconds

                            ' If the application exceeds its limit, terminate it
                            If totalDuration > maxTime Then
                                TerminateApplication(appName)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if an exception occurs
            MessageBox.Show($"Error checking application limits: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TerminateApplication(appName As String)
        Try
            ' Find all processes with the given application name
            Dim processes = Process.GetProcessesByName(appName)

            For Each proc As Process In processes
                proc.Kill()
                proc.WaitForExit()
            Next


        Catch ex As Exception
            ' Log the error or notify the user
            MessageBox.Show($"Error terminating application '{appName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Load the form and start the timer
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblUsername IsNot Nothing Then
            lblUsername.Text = $"{LoggedInFirstName} {LoggedInLastName}"
        End If
        If lblUsername1 IsNot Nothing Then
            lblUsername1.Text = $"{LoggedInUsername}"

        End If


        UpdateAppCards()
        UpdateTotalUsage()
        Timer2.Interval = 5000 ' timer 2
        Timer2.Enabled = True
        Timer2.Start()
        Timer1.Interval = 20000 '  timer 1
        Timer1.Start()

        focusStartTime = DateTime.Now

        ' start the focus timer
        focusTimer.Interval = 1000 ' Timer will tick every second
        AddHandler focusTimer.Tick, AddressOf FocusTimer_Tick '' dynamic implementation
        elapsedTime = TimeSpan.Zero

        ' Set up the initial focus mode to None
        lblTimer.Text = "Start a timer"
    End Sub



    ' Timer tick event to update data and UI
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LogActiveApplication()
        UpdateAppCards()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        CheckAppUsageLimits()
        UpdateTotalUsage()
    End Sub



    ' Log the active application
    Private Sub LogActiveApplication()
        Dim hWnd As IntPtr = GetForegroundWindow()
        Dim processId As UInteger
        GetWindowThreadProcessId(hWnd, processId)

        Dim processName As String = GetProcessName(processId)

        ' Update duration for the current app periodically
        Dim duration As TimeSpan = DateTime.Now - focusStartTime
        If processName = currentApp Then
            ' Save incremental duration
            SaveAppUsageToDatabase(currentApp, focusStartTime, DateTime.Now, duration)
            focusStartTime = DateTime.Now
        Else
            ' Switch to a new app
            If currentApp <> "" Then
                SaveAppUsageToDatabase(currentApp, focusStartTime, DateTime.Now, duration)
            End If
            currentApp = processName
            focusStartTime = DateTime.Now
        End If
    End Sub



    Private Sub UpdateTotalUsage()
        Try
            Dim totalUsage As Integer = 0
            Dim connectionString As String = GetConnectionString()

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ISNULL(SUM(Duration), 0) AS TotalDuration FROM FocusData WHERE UserId = @UserId"
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                    totalUsage = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
            Dim hours As Integer = totalUsage \ 3600
            Dim minutes As Integer = (totalUsage Mod 3600) \ 60
            lblTotalUsage.Text = $"{hours}h {minutes}m"
        Catch ex As Exception
            MessageBox.Show($"Error updating total usage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SaveAppUsageToDatabase(appName As String, startTime As DateTime, stopTime As DateTime, duration As TimeSpan)
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO FocusData (UserId, AppName, StartedDate, StartedTime, StoppedDate, StoppedTime, Duration) 
                                       VALUES (@UserId, @AppName, @StartedDate, @StartedTime, @StoppedDate, @StoppedTime, @Duration)"
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                    command.Parameters.AddWithValue("@AppName", appName)
                    command.Parameters.AddWithValue("@StartedDate", startTime.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@StartedTime", startTime.ToString("HH:mm:ss"))
                    command.Parameters.AddWithValue("@StoppedDate", stopTime.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@StoppedTime", stopTime.ToString("HH:mm:ss"))
                    command.Parameters.AddWithValue("@Duration", duration.TotalSeconds)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving data to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetProcessName(processId As UInteger) As String
        Try
            Dim process As Process = Process.GetProcessById(CInt(processId))
            Return process.ProcessName
        Catch ex As Exception
            Return "Unknown"
        End Try
    End Function


    Private Sub UpdateAppCards()
        Try

            Dim appDurations = GetAppDurations().OrderByDescending(Function(x) x.Value).ToDictionary(Function(x) x.Key, Function(x) x.Value)
            flpAppCards1.Controls.Clear()

            For Each appName As String In appDurations.Keys
                Dim totalSeconds As Integer = appDurations(appName)
                Dim hours As Integer = totalSeconds \ 3600
                Dim minutes As Integer = (totalSeconds Mod 3600) \ 60
                Dim durationFormatted As String = $"{hours}h {minutes}m"



                Dim maxTime As Integer = 28800 '
                Dim gaugePercentage As Integer = Math.Min((totalSeconds / maxTime) * 100, 100)

                '  shadow panel for each app card
                Dim shadowPanel As New Guna.UI2.WinForms.Guna2ShadowPanel With {
                .Padding = New Padding(5),
                .ShadowColor = Color.Gray,
                .ShadowDepth = 3,
                .ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Surrounded,
                .FillColor = Color.Transparent,
                .Size = New Size(150, 100), ' Smaller card size
                .Margin = New Padding(5)
            }

                ' app name label
                Dim lblAppName As New Guna.UI2.WinForms.Guna2HtmlLabel With {
                .Text = appName,
                .Font = New Font("Segoe UI", 8, FontStyle.Bold),
                .ForeColor = Color.White,
                .Dock = DockStyle.Top,
                .AutoSize = False,
                .Size = New Size(140, 20),
                .TextAlignment = ContentAlignment.MiddleCenter
            }

                ' uration gauge
                Dim durationGauge As New Guna.UI2.WinForms.Guna2CircleProgressBar With {
                .Value = CInt(gaugePercentage),
                .FillColor = Color.Purple,
                .FillThickness = 6,
                .ProgressColor = If(gaugePercentage >= 100, Color.Red, Color.Blue),
                .ProgressThickness = 6,
                .Size = New Size(60, 60),
                .Dock = DockStyle.None,
                .Location = New Point(50, 30) ' Adjusts location inside the panel
            }

                ' duration label (inside the gauge, in H and M format)
                Dim lblGaugeDuration As New Label With {
                .Text = durationFormatted,
                .Font = New Font("Segoe UI", 8, FontStyle.Bold),
                .ForeColor = Color.White,
                .TextAlign = ContentAlignment.MiddleCenter,
                .AutoSize = False,
                .Dock = DockStyle.None,
                .Size = New Size(50, 20),
                .Location = New Point(5, 20) ' Adjusts position inside the gauge
            }
                durationGauge.Controls.Add(lblGaugeDuration)

                'add controls to the shadow panel
                shadowPanel.Controls.Add(lblAppName)
                shadowPanel.Controls.Add(durationGauge)

                ' add shaow panel to the flow layout panel
                flpAppCards1.Controls.Add(shadowPanel)
            Next
            UpdateGraph()
            flpAppCards1.Refresh()

        Catch ex As Exception
            MessageBox.Show($"Error updating app cards: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateGraph()
        Try
            Dim usageData = GetDetailedAppUsage()
            If panelGraph1 Is Nothing Then
                MessageBox.Show("panelGraph1 is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            panelGraph1.Controls.Clear()

            'liveCharts cartesia Chart
            Dim chart As New CartesianChart With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.FromArgb(29, 32, 40) ' Custom RGB color
        }

            Dim seriesCollection As New LiveCharts.SeriesCollection()
            Dim labels As New List(Of String)
            Dim appUsageGroups = usageData.AsEnumerable().GroupBy(Function(row) row("AppName").ToString())

            For Each group In appUsageGroups
                Dim appName As String = group.Key
                Dim durations As New ChartValues(Of Integer)()

                For Each row In group
                    Dim startedTime As DateTime = DateTime.Parse(row("StartedTime").ToString())
                    Dim duration As Integer = Convert.ToInt32(row("Duration"))
                    durations.Add(duration)
                    Dim timeLabel As String = startedTime.ToString("hh:mm tt")
                    If Not labels.Contains(timeLabel) Then
                        labels.Add(timeLabel)
                    End If
                Next
                Dim lineSeries As New LineSeries With {
                .Title = appName,
                .Values = durations,
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8,
                .LineSmoothness = 0.5
            }
                seriesCollection.Add(lineSeries)
            Next
            chart.Series = seriesCollection
            chart.AxisX.Add(New Axis With {
            .Title = "Time",
            .Labels = labels
        })
            chart.AxisY.Add(New Axis With {
            .Title = "Duration (seconds)"
        })
            panelGraph1.Controls.Add(chart)
        Catch ex As Exception
            MessageBox.Show($"Error updating the graph: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetAppDurations() As Dictionary(Of String, Integer)
        Dim appDurations As New Dictionary(Of String, Integer)
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT AppName, SUM(Duration) AS TotalDuration 
                                       FROM FocusData 
                                       WHERE UserId = @UserId 
                                       GROUP BY AppName"
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            appDurations(reader("AppName").ToString()) = Convert.ToInt32(reader("TotalDuration"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching app durations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return appDurations
    End Function

    Private Function GetDetailedAppUsage() As DataTable
        Dim usageData As New DataTable()
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT AppName, StartedTime, Duration 
                                       FROM FocusData 
                                       WHERE UserId = @UserId 
                                       ORDER BY StartedTime"
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(usageData)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching detailed usage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return usageData
    End Function

    Private Sub Guna2ControlBox6_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox6.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnSetting_Click_1(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim settingsForm As New Settings()
        settingsForm.UserId = LoggedInUserID
        settingsForm.Show()
    End Sub

    Private Sub ClearUsageButton_Click(sender As Object, e As EventArgs) Handles ClearUsageButton.Click
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all application limits?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM FocusData WHERE UserId = @UserId"
                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        MessageBox.Show($"{rowsAffected} Data have been cleared.", "Data Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using

                End If
                UpdateAppCards()


            End Using


        Catch ex As Exception
            MessageBox.Show($"Error clearing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ClearLimitButton_Click(sender As Object, e As EventArgs) Handles ClearLimitButton.Click

        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all application limits?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM AppLimits WHERE UserId = @UserId"
                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@UserId", LoggedInUserID)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        MessageBox.Show($"{rowsAffected} application limits have been cleared.", "Data Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error clearing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        MessageBox.Show($"We're sorry you're going through an issue, please send an email at moathcareerpath@gmail.com", "Report a problem", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class



