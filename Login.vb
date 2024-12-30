Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text



Public Class Login
    '-----------------------------------------------------------------------------------------------------------'

    Dim connectionString As String = GetConnectionString()
    Public Shared CurrentUserID As Integer
    Public Shared CurrentFirstname As String
    Public Shared CurrentLastname As String

    '-----------------------------------------------------------------------------------------------------------'

    Private Function HashPassword(password As String) As String
        Using hasher As SHA256 = SHA256.Create()
            Dim bytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtLogin.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            ' database connection
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' check username and password logic
                Dim query As String = "SELECT UserID, Password , FirstName, LastName FROM Users WHERE Username = @Username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", txtLogin.Text)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("Password").ToString()
                            If storedHash = HashPassword(txtPassword.Text) Then
                                CurrentUserID = CInt(reader("UserID"))
                                CurrentFirstname = reader("FirstName").ToString()
                                CurrentLastname = reader("LastName").ToString()
                                ' Pass the username and user ID to the Dashboard
                                Dim dashboardForm As New Dashboard()
                                dashboardForm.LoggedInUserID = CurrentUserID
                                dashboardForm.LoggedInUsername = txtLogin.Text
                                dashboardForm.LoggedInFirstName = CurrentFirstname
                                dashboardForm.LoggedInLastName = CurrentLastname
                                dashboardForm.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub RegisterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLink.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub btnSaveAndExitt_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    '-----------------------------------------------------------------------------------------------------------'
End Class
