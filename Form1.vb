Imports MySql.Data.MySqlClient

Public Class Form1

    Dim myconnection As New UniversalConnector
    Dim conAdaptor As MySqlDataAdapter
    Dim dataTable As DataTable


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        conAdaptor = New MySqlDataAdapter("Select * From admin where username= '" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'", myconnection.open)
        dataTable = New DataTable
        dataTable.Clear()
        conAdaptor.Fill(dataTable)
        If dataTable.Rows.Count() <= 0 Then
            MessageBox.Show("username or password are invalid")
            myconnection.close()
        Else
            MessageBox.Show("Login success")
            Me.Hide()
            Home.Show()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check connection
        Try
            myconnection.open()

            MessageBox.Show("Successfully connected to the database")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowPwdCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPwdCheckBox.CheckedChanged
        ' show/hide password text 

        If PasswordTextBox.UseSystemPasswordChar = True Then

            PasswordTextBox.UseSystemPasswordChar = False
            ShowPwdCheckBox.Checked = True

        Else

            PasswordTextBox.UseSystemPasswordChar = True
            ShowPwdCheckBox.Checked = False

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'show password
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub


End Class
