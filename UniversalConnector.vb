Imports MySql.Data.MySqlClient

Public Class UniversalConnector

    Dim con As New MySqlConnection("host=127.0.0.1; user=root; password=; database=hos")

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Function open() As MySqlConnection
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con

    End Function

    Public Function close() As MySqlConnection
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function

End Class
