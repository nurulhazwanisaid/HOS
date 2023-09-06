Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Maintenance

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'refresh datagridview
        load_data()

        'search function
        FilterData("")

    End Sub

    Public Sub load_data()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM hos.user", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        FilterData(SearchTextBox.Text)
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=hos")
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * From user WHERE CONCAT(username, userStatus, location, company, dept, hpNo, extNo) like '%" & valueToSearch & "%'"

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
        Dim command As New MySqlCommand("INSERT INTO `user`(`Username`, `UserStatus`, `Location`,`Company`, `Dept`, `HpNo`, `ExtNo`) VALUES (@username,@userStatus,@location,@company,@dept,@hpNo,@extNo)", connection)

        ' add Parameters to the command
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@userStatus", MySqlDbType.VarChar).Value = StatusComboBox.Text
        command.Parameters.Add("@location", MySqlDbType.VarChar).Value = LocationComboBox.Text
        command.Parameters.Add("@company", MySqlDbType.VarChar).Value = CompanyTextBox.Text
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = DeptTextBox.Text
        command.Parameters.Add("@hpNo", MySqlDbType.VarChar).Value = HpNoTextBox.Text
        command.Parameters.Add("@extNo", MySqlDbType.VarChar).Value = ExtNoTextBox.Text

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
                delete("DELETE FROM user WHERE id='" & IDTextBox.Text & "'")
                load_data()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            updates("UPDATE user SET username='" & UsernameTextBox.Text & "', userStatus='" & StatusComboBox.Text & "', location='" & LocationComboBox.Text & "',company='" & CompanyTextBox.Text & "', dept='" & DeptTextBox.Text & "', hpNo='" & HpNoTextBox.Text & "', extNo='" & ExtNoTextBox.Text & "' WHERE id='" & IDTextBox.Text & "'")
            load_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        ' now show data from the selected row to textboxes
        IDTextBox.Text = selectedRow.Cells(0).Value.ToString()
        UsernameTextBox.Text = selectedRow.Cells(1).Value.ToString()
        StatusComboBox.Text = selectedRow.Cells(2).Value.ToString()
        LocationComboBox.Text = selectedRow.Cells(3).Value.ToString()
        CompanyTextBox.Text = selectedRow.Cells(4).Value.ToString()
        DeptTextBox.Text = selectedRow.Cells(5).Value.ToString()
        HpNoTextBox.Text = selectedRow.Cells(6).Value.ToString()
        ExtNoTextBox.Text = selectedRow.Cells(7).Value.ToString()


    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UsernameTextBox.Clear()
        StatusComboBox.Text = ""
        LocationComboBox.Text = ""
        CompanyTextBox.Clear()
        DeptTextBox.Clear()
        HpNoTextBox.Clear()
        ExtNoTextBox.Clear()
    End Sub
End Class