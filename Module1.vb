Module Module1

    Public Property ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\LAPTOP-NI6VB71B\Users\Public\Documents\Screeno\MyFocus.mdf;Integrated Security=True;Connect Timeout=30"

    Public Function GetConnectionString() As String
        Return ConnectionString
    End Function

End Module
