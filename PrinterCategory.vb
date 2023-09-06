Imports MySql.Data.MySqlClient
Imports System.Data.DataTable


Public Class PrinterCategory

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub PrinterCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        'Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM hos.printercat", connection)

        ' adapter.Fill(table)

        'DataGridView1.DataSource = table

        'refresh datagridview
        load_data()

        'search function
        FilterData("")

    End Sub

    Public Sub load_data()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM hos.printercat", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        FilterData(SearchTextBox.Text)
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=hos")
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * From printercat WHERE CONCAT(brand, printermodel, description) like '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `printercat`(`Brand`, `PrinterModel`, `Description`) VALUES (@brand,@printermodel,@description)", connection)

        ' add Parameters to the command
        command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = BrandTextBox.Text
        command.Parameters.Add("@printermodel", MySqlDbType.VarChar).Value = PrinterModelTextBox.Text
        command.Parameters.Add("@description", MySqlDbType.VarChar).Value = DescriptionRichTextBox.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted")

        Else

            MessageBox.Show("ERROR")

        End If

        load_data()
        connection.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim iDelete As DialogResult

        iDelete = MessageBox.Show("Proceed to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iDelete = DialogResult.Yes Then

            Try
                delete("DELETE FROM printercat WHERE id='" & IDTextBox.Text & "'")
                load_data()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        ' now show data from the selected row to textboxes
        IDTextBox.Text = selectedRow.Cells(0).Value.ToString()
        BrandTextBox.Text = selectedRow.Cells(1).Value.ToString()
        PrinterModelTextBox.Text = selectedRow.Cells(2).Value.ToString()
        DescriptionRichTextBox.Text = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            updates("UPDATE printercat SET brand='" & BrandTextBox.Text & "', printermodel='" & PrinterModelTextBox.Text & "', description='" & DescriptionRichTextBox.Text & "' WHERE id='" & IDTextBox.Text & "'")
            load_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        BrandTextBox.Clear()
        PrinterModelTextBox.Clear()
        DescriptionRichTextBox.Clear()
    End Sub
End Class