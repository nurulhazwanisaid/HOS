Imports MySql.Data.MySqlClient

Public Class ComputerCategory

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub ComputerCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'retrieve data from db
        'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        'Dim table As New DataTable()
        ' Dim adapter As New MySqlDataAdapter("SELECT * FROM hos.compcat", connection)

        'adapter.Fill(table)

        'DataGridView1.DataSource = table

        'search function
        FilterData("")

        'refresh datagridview
        load_data()

    End Sub

    Public Sub load_data()
        'retrieve data from db
        'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM compcat", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=hos")
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * FROM compcat  WHERE CONCAT(brand, pcmodel, type, ram, hdd, processor, cpuspeed, osVer, osBit, pwModel, pwSn, cddvd, year, remark) like '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchButton_Click_1(sender As Object, e As EventArgs) Handles SearchButton.Click
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        Try
            create("INSERT INTO compcat(brand,pcmodel,type, ram, hdd, processor, cpuspeed, osVer, osBit, pwModel, pwSn, cddvd, year, remark) VALUES('" & BrandTextBox.Text & "','" & PcModelTextBox.Text & "','" & TypeComboBox.SelectedItem & "','" & RamTextBox.Text & "','" & HddTextBox.Text & "','" & ProcessorTextBox.Text & "','" & CpuSpeedTextBox.Text & "','" & OsVerComboBox.Text & "','" & OsBitComboBox.Text & "','" & PowerModelTextBox.Text & "','" & PowerSnTextBox.Text & "','" & CdDvdTextBox.Text & "','" & YearTextBox.Text & "','" & RemarksTextBox.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            updates("UPDATE compcat SET brand='" & BrandTextBox.Text & "', pcmodel='" & PcModelTextBox.Text & "', type='" & TypeComboBox.Text & "', ram='" & RamTextBox.Text & "', hdd='" & HddTextBox.Text & "', processor='" & ProcessorTextBox.Text & "', cpuspeed='" & CpuSpeedTextBox.Text & "', osVer='" & OsVerComboBox.Text & "', osBit='" & OsBitComboBox.Text & "', pwModel='" & PowerModelTextBox.Text & "', pwSn='" & PowerSnTextBox.Text & "', cddvd='" & CdDvdTextBox.Text & "', year='" & YearTextBox.Text & "', remark='" & RemarksTextBox.Text & "' WHERE id='" & IDTextBox.Text & "'")
            load_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        IDTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value
        BrandTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        PcModelTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        TypeComboBox.Text = DataGridView1.CurrentRow.Cells(3).Value
        RamTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value
        HddTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value
        ProcessorTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value
        CpuSpeedTextBox.Text = DataGridView1.CurrentRow.Cells(7).Value
        OsVerComboBox.Text = DataGridView1.CurrentRow.Cells(8).Value
        OsBitComboBox.Text = DataGridView1.CurrentRow.Cells(9).Value
        PowerModelTextBox.Text = DataGridView1.CurrentRow.Cells(10).Value
        PowerSnTextBox.Text = DataGridView1.CurrentRow.Cells(11).Value
        CdDvdTextBox.Text = DataGridView1.CurrentRow.Cells(12).Value
        YearTextBox.Text = DataGridView1.CurrentRow.Cells(13).Value
        RemarksTextBox.Text = DataGridView1.CurrentRow.Cells(14).Value

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click


        Dim iDelete As DialogResult

        iDelete = MessageBox.Show("Proceed to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iDelete = DialogResult.Yes Then

            Try
                delete("DELETE FROM compcat WHERE id='" & IDTextBox.Text & "'")
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
        PcModelTextBox.Text = selectedRow.Cells(2).Value.ToString()
        TypeComboBox.SelectedItem = selectedRow.Cells(3).Value.ToString()
        RamTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        HddTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        ProcessorTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        CpuSpeedTextBox.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        OsVerComboBox.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        OsBitComboBox.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        PowerModelTextBox.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        PowerSnTextBox.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        CdDvdTextBox.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        YearTextBox.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        RemarksTextBox.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()



    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub VScrollBar1_Scroll_1(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        IDTextBox.Clear()
        BrandTextBox.Clear()
        PcModelTextBox.Clear()
        TypeComboBox.Text = ""
        RamTextBox.Clear()
        HddTextBox.Clear()
        ProcessorTextBox.Clear()
        CpuSpeedTextBox.Clear()
        OsVerComboBox.Text = ""
        OsBitComboBox.Text = ""
        CdDvdTextBox.Clear()
        YearTextBox.Clear()
        RemarksTextBox.Clear()

    End Sub
End Class