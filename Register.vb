Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Register

    '-----------------------------------------------------------------------------------------------------------'
    Dim connectionString As String = GetConnectionString()
    Private Function HashPassword(password As String) As String
        Using hasher As SHA256 = SHA256.Create()
            Dim bytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function

    '-----------------------------------------------------------------------------------------------------------'


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Input
        If txtBoxUsername.Text = "" Or txtBoxPassword.Text = "" Or txtBoxFirstname.Text = "" Or txtBoxLastName.Text = "" Then
            MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            ' connecting to database here
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' insert the new user to the database
                Dim query As String = "INSERT INTO Users (FirstName, LastName, Username, Password) VALUES (@FirstName, @LastName, @Username, @Password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", txtBoxFirstname.Text)
                    command.Parameters.AddWithValue("@LastName", txtBoxLastName.Text)
                    command.Parameters.AddWithValue("@Username", txtBoxUsername.Text)
                    command.Parameters.AddWithValue("@Password", HashPassword(txtBoxPassword.Text)) ' hasing the password before entering into the database, using sha256
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login.Show()
            Me.Hide()
        Catch ex As SqlException When ex.Number = 2627 ' Unique constraint violation
            MessageBox.Show("Username already exists. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub backtologinlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backtologinlink.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '-----------------------------------------------------------------------------------------------------------'
End Class
