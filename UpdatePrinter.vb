Imports MySql.Data.MySqlClient

Public Class UpdatePrinter

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'UPDATE student3_total INNER JOIN student3 ON s_id=id SET  
        'mark = (Math + social + science)
        Try
            updates("UPDATE printerdetail, printercat SET printercat.printermodel='" & ModelComboBox.Text & "', printerdetail.serialNo='" & SerialNoTextBox.Text & "', printerdetail.ipAdd='" & IpAddTextBox.Text & "', printerdetail.dept='" & DeptTextBox.Text & "', printerdetail.location='" & LocationTextBox.Text & "', printerdetail.user='" & UserTextBox.Text & "', printerdetail.company='" & CompanyTextBox.Text & "', printerdetail.remarks='" & RemarksTextBox.Text & "' WHERE printerdetail.id='" & IDTextBox.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdatePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter("SELECT `id`, `brand`, `printermodel`, `description` FROM printercat", connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        'combo box display data from db
        ModelComboBox.DataSource = table

        ModelComboBox.ValueMember = "id"
        ModelComboBox.DisplayMember = "printermodel"

    End Sub
End Class