Imports System.Data.SqlClient

Public Class Settings

    Public Property UserId As Integer
    Public Sub InitializeData(userId As Integer, username As String)
        Me.UserId = userId
    End Sub
    Private Sub btnConfirm_Done(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnLimit_Click(sender As Object, e As EventArgs) Handles btnLimit.Click
        Try
            ' Validate input
            If String.IsNullOrEmpty(txtboxAppName.Text) Then
                MessageBox.Show("Please enter the application name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hours As Integer
            Dim minutes As Integer
            Dim seconds As Integer

            If Not Integer.TryParse(txtboxHour.Text, hours) OrElse hours < 0 Then
                MessageBox.Show("Please enter a valid number for hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(txtboxMinute.Text, minutes) OrElse minutes < 0 OrElse minutes >= 60 Then
                MessageBox.Show("Please enter a valid number for minutes (0-59).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(textboxSecond.Text, seconds) OrElse seconds < 0 OrElse seconds >= 60 Then
                MessageBox.Show("Please enter a valid number for seconds (0-59).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim totalSeconds As Integer = (hours * 3600) + (minutes * 60) + seconds

            If totalSeconds = 0 Then
                MessageBox.Show("The time limit cannot be zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if the application limit already exists for this user
                Dim checkQuery As String = "SELECT MaxTime FROM AppLimits WHERE UserId = @UserId AND AppName = @AppName"
                Using checkCommand As New SqlCommand(checkQuery, conn)
                    checkCommand.Parameters.AddWithValue("@UserId", UserId)
                    checkCommand.Parameters.AddWithValue("@AppName", txtboxAppName.Text)

                    Dim existingMaxTime As Object = checkCommand.ExecuteScalar()

                    If existingMaxTime IsNot Nothing Then
                        ' If the app limit already exists, ask user if they want to replace or add to the existing limit
                        Dim result As DialogResult = MessageBox.Show("This application limit already exists. Do you want to:" & vbCrLf &
                                                               "Yes = Add to the existing time?" & vbCrLf &
                                                               "No  = Replace the existing time?",
                                                               "Application Limit Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                        If result = DialogResult.Cancel Then
                            Return
                        ElseIf result = DialogResult.Yes Then
                            ' Add to existing time
                            Dim newMaxTime As Integer = Convert.ToInt32(existingMaxTime) + totalSeconds
                            Dim updateQuery As String = "UPDATE AppLimits SET MaxTime = @MaxTime WHERE UserId = @UserId AND AppName = @AppName"
                            Using updateCommand As New SqlCommand(updateQuery, conn)
                                updateCommand.Parameters.AddWithValue("@UserId", UserId)
                                updateCommand.Parameters.AddWithValue("@AppName", txtboxAppName.Text)
                                updateCommand.Parameters.AddWithValue("@MaxTime", newMaxTime)

                                updateCommand.ExecuteNonQuery()
                                MessageBox.Show("Application time limit has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Using


                        ElseIf result = DialogResult.No Then
                            ' Replace the existing time with new time
                            Dim updateQuery As String = "UPDATE AppLimits SET MaxTime = @MaxTime WHERE UserId = @UserId AND AppName = @AppName"
                            Using updateCommand As New SqlCommand(updateQuery, conn)
                                updateCommand.Parameters.AddWithValue("@UserId", UserId)
                                updateCommand.Parameters.AddWithValue("@AppName", txtboxAppName.Text)
                                updateCommand.Parameters.AddWithValue("@MaxTime", totalSeconds)

                                updateCommand.ExecuteNonQuery()
                                MessageBox.Show("Application time limit has been replaced successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Using
                        End If
                        ' Clear input fields after update
                        txtboxAppName.Clear()
                        txtboxHour.Clear()
                        txtboxMinute.Clear()
                        textboxSecond.Clear()
                        Return '
                    End If
                End Using

                ' If no existing limit, insert the new limit
                Dim insertQuery As String = "INSERT INTO AppLimits (UserId, AppName, MaxTime) VALUES (@UserId, @AppName, @MaxTime)"
                Using insertCommand As New SqlCommand(insertQuery, conn)
                    insertCommand.Parameters.AddWithValue("@UserId", UserId)
                    insertCommand.Parameters.AddWithValue("@AppName", txtboxAppName.Text)
                    insertCommand.Parameters.AddWithValue("@MaxTime", totalSeconds)

                    insertCommand.ExecuteNonQuery()
                    MessageBox.Show("Application limit has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear input fields
                    txtboxAppName.Clear()
                    txtboxHour.Clear()
                    txtboxMinute.Clear()
                    textboxSecond.Clear()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error adding application limit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnRemoveLimit_Click(sender As Object, e As EventArgs) Handles btnRemoveLimit.Click
        Try
            If String.IsNullOrEmpty(txtboxAppName1.Text) Then
                MessageBox.Show("Please enter the application name to remove the limit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' remove the app limit from the database
                Dim query As String = "DELETE FROM AppLimits WHERE UserId = @UserId AND AppName = @AppName"
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", UserId)
                    command.Parameters.AddWithValue("@AppName", txtboxAppName1.Text)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Application limit has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No limit found for the specified application.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    txtboxAppName.Clear()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error removing application limit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all application limits?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM AppLimits WHERE UserId = @UserId"
                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@UserId", UserId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        MessageBox.Show($"{rowsAffected} application limits have been cleared.", "Data Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error clearing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializeDataGridView()
        dgvLimitedApps.Columns.Clear()
        dgvLimitedApps.Columns.Add("AppName", "Application Name")
        dgvLimitedApps.Columns.Add("MaxTime", "Limit (HH:MM:SS)")
        dgvLimitedApps.Columns("AppName").Width = 200
        dgvLimitedApps.Columns("MaxTime").Width = 100
    End Sub


    Private Sub LoadLimitedApps()
        Try
            dgvLimitedApps.Rows.Clear()
            Dim connectionString As String = GetConnectionString()
            Dim query As String = "SELECT AppName, MaxTime FROM AppLimits WHERE UserId = @UserId"
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", UserId)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim appName As String = reader("AppName").ToString()
                            Dim maxTime As Integer = Convert.ToInt32(reader("MaxTime"))
                            Dim hours As Integer = maxTime \ 3600
                            Dim minutes As Integer = (maxTime Mod 3600) \ 60
                            Dim seconds As Integer = maxTime Mod 60
                            dgvLimitedApps.Rows.Add(appName, $"{hours:D2}:{minutes:D2}:{seconds:D2}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading application limits: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExitToggleSwitch.Checked = True
        InitializeDataGridView()
        LoadLimitedApps()
    End Sub



    Private Sub btnClearData_Click(sender As Object, e As EventArgs)
        Try
            Dim connectionString As String = GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all application limits?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM FocusData WHERE UserId = @UserId"
                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@UserId", UserId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        MessageBox.Show($"{rowsAffected} Data have been cleared.", "Data Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error clearing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
