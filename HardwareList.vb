Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices

Public Class HardwareList

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    'Dim con As MySqlConnection
    'Dim command As New MySqlCommand
    ' Dim mycon As String = "server=localhost;user id=root;password=aaaa;database=hos"

    Private Sub HardwareList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM hardware", connection)

        DataGridView1.DataSource = table

        adapter.Fill(table)

        'add checkbox column
        Dim checkboxcolumn As New DataGridViewCheckBoxColumn
        checkboxcolumn.Width = 40
        checkboxcolumn.HeaderText = "Check"
        checkboxcolumn.Name = "checkboxcolumn"
        DataGridView1.Columns.Insert(0, checkboxcolumn)

        'send value from one dgv to another dgv
        Dim table1 As New DataTable
        table1.Columns.Add("id", Type.GetType("System.Int32"))
        table1.Columns.Add("username", Type.GetType("System.String"))
        table1.Columns.Add("userStatus", Type.GetType("System.String"))
        table1.Columns.Add("dept", Type.GetType("System.String"))
        table1.Columns.Add("company", Type.GetType("System.String"))
        table1.Columns.Add("location", Type.GetType("System.String"))
        table1.Columns.Add("pcmodel", Type.GetType("System.String"))
        table1.Columns.Add("pcName", Type.GetType("System.String"))
        table1.Columns.Add("prodNo", Type.GetType("System.String"))
        table1.Columns.Add("serialNo", Type.GetType("System.String"))
        table1.Columns.Add("monitormodel", Type.GetType("System.String"))
        table1.Columns.Add("monitorSn", Type.GetType("System.String"))
        table1.Columns.Add("remark", Type.GetType("System.String"))
        table1.Columns.Add("status", Type.GetType("System.String"))

        'color datagridview with condition
        DataGridView1.DataSource = table1
        DataGridView1.AllowUserToAddRows = False
        'DataGridView1.DefaultCellStyle.BackColor = Color.LightGreen
        'RowsColor()
        'For i = 0 To DataGridView1.Rows.Count - 1

        '    If DataGridView1.Rows(i).Cells(14).Value = "Repair" Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
        '    End If

        '    If DataGridView1.Rows(i).Cells(14).Value = "Good" Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
        '    End If

        '    If DataGridView1.Rows(i).Cells(3).Value = "Inactive" Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkGray
        '    End If


        'Next



        'search function
        FilterData("")

        'load datagridview
        load_data()

        'pcmodel option from db
        pcmodel_option()

        'monitor option from db
        monitormodel_option()

        'username option from db
        username_option()




    End Sub

    'Public Sub RowsColor()

    '    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
    '        Dim status As String
    '        Dim userStatus As String

    '        status = DataGridView1.Rows(i).Cells(3).Value
    '        If status = "Repair" Then
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
    '        Else
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
    '        End If

    '        userStatus = DataGridView1.Rows(i).Cells(14).Value
    '        If userStatus = "Inactive" Then
    '                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkGray
    '            Else
    '                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
    '        End If
    '    Next
    'End Sub

    Public Sub pcmodel_option()

        Dim adapter1 As New MySqlDataAdapter("SELECT `id`, `brand`, `pcmodel`, `type` FROM compcat", connection)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        'combo box display data from db
        PCModelComboBox.DataSource = table1

        PCModelComboBox.ValueMember = "id"
        PCModelComboBox.DisplayMember = "pcmodel"
    End Sub

    Public Sub monitormodel_option()

        Dim adapter1 As New MySqlDataAdapter("SELECT `id`, `monitormodel`, `size` FROM monitor", connection)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        'combo box display data from db
        MonitorModelComboBox.DataSource = table1

        MonitorModelComboBox.ValueMember = "id"
        MonitorModelComboBox.DisplayMember = "monitormodel"
    End Sub

    Public Sub username_option()
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM user"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("username")
                UsernameComboBox.Items.Add(sName)
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub LogoutButton_Click_1(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to logout", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DashboardButton_Click_1(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Close()
    End Sub

    Public Sub load_data()
        'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT id, username, userStatus, dept, company, location, pcmodel, pcName, prodNo, serialNo, monitormodel, monitorSn, remark, status FROM hardware", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Public Sub FilterData(valueToSearch As String)
        ' Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=hos")
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT id, username , userStatus, dept, company, location, pcmodel, pcName, prodNo, serialNo, monitormodel, monitorSn, remark, status FROM hardware  WHERE CONCAT(id, username, userStatus, dept, company, location, pcmodel, pcName, prodNo, serialNo, monitormodel, monitorSn, remark, status) like '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        FilterData(SearchTextBox.Text)
    End Sub

    'multi delete function
    Public Function DeleteData(ByVal sql As String)
        Try
            connection.Open()
            cmd = New MySqlCommand

            With cmd
                .Connection = connection
                .CommandText = sql
            End With

            result = cmd.ExecuteNonQuery

            If result = 0 Then
                result = 0
            Else
                result = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
        Return result
    End Function

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim iDelete As DialogResult
        Dim sql As String
        iDelete = MessageBox.Show("Proceed to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iDelete = DialogResult.Yes Then

            Try
                '    delete("DELETE FROM hardware WHERE id='" & IDTextBox.Text & "'")
                '    load_data()
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).FormattedValue = True Then
                        sql = "DELETE FROM hardware WHERE id='" & CStr(row.Cells(1).FormattedValue) & "'"
                        DeleteData(sql)
                    End If
                Next
                If result = 0 Then
                MessageBox.Show("Error")
            Else
                MessageBox.Show("The data has been deleted")
                load_data()
            End If
            Catch ex As Exception
            MessageBox.Show(ex.Message)
            End Try


        End If

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'INSERT INTO table4 ( name, age, sex, city, id, number, nationality)
        'SELECT name, age, sex, city, p.id, number, n.nationality
        'From table1 p
        'INNER Join table2 c ON c.Id = p.Id
        'INNER Join table3 n ON p.Id = n.Id

        'user.uid,compcat.cid,hardware.pcName,hardware.prodNo,hardware.serialNo,monitor.mid,hardware.monitorSn,hardware.remark

        Try
            create("INSERT INTO hardware(username, userStatus, dept, company, location, pcmodel, pcName, serialNo, prodNo, monitormodel, monitorSn, remark, status) VALUES('" & UsernameComboBox.Text & "','" & StatusComboBox.Text & "','" & DeptTextBox.Text & "','" & CompanyComboBox.Text & "','" & LocationTextBox.Text & "','" & PCModelComboBox.Text & "','" & PCNameTextBox.Text & "','" & ProdNoTextBox.Text & "','" & SerialNoTextBox.Text & "','" & MonitorModelComboBox.Text & "','" & MonitorSNTextBox.Text & "','" & RemarkTextBox.Text & "','" & StatComboBox.Text & "')")
            load_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            updates("UPDATE hardware SET username='" & UsernameComboBox.Text & "', userStatus='" & StatusComboBox.Text & "', dept='" & DeptTextBox.Text & "', company='" & CompanyComboBox.Text & "', location='" & LocationTextBox.Text & "', pcmodel='" & PCModelComboBox.Text & "', pcName='" & PCNameTextBox.Text & "', prodNo='" & ProdNoTextBox.Text & "', serialNo='" & SerialNoTextBox.Text & "', monitormodel='" & MonitorModelComboBox.Text & "', monitorSn='" & MonitorSNTextBox.Text & "', remark='" & RemarkTextBox.Text & "', status='" & StatComboBox.Text & "' WHERE id='" & IDTextBox.Text & "'")
            load_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UsernameComboBox.Text = ""
        StatusComboBox.Text = ""
        DeptTextBox.Clear()
        CompanyComboBox.Text = ""
        LocationTextBox.Text = ""
        PCModelComboBox.Text = ""
        PCNameTextBox.Clear()
        SerialNoTextBox.Clear()
        ProdNoTextBox.Clear()
        MonitorModelComboBox.Text = ""
        MonitorSNTextBox.Clear()
        RemarkTextBox.Clear()
        StatComboBox.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        ' now show data from the selected row to textboxes
        IDTextBox.Text = selectedRow.Cells(1).Value.ToString()
        UsernameComboBox.Text = selectedRow.Cells(2).Value.ToString()
        StatusComboBox.Text = selectedRow.Cells(3).Value.ToString()
        DeptTextBox.Text = selectedRow.Cells(4).Value.ToString()
        CompanyComboBox.Text = selectedRow.Cells(5).Value.ToString()
        LocationTextBox.Text = selectedRow.Cells(6).Value.ToString()
        PCModelComboBox.Text = selectedRow.Cells(7).Value.ToString()
        PCNameTextBox.Text = selectedRow.Cells(8).Value.ToString()
        ProdNoTextBox.Text = selectedRow.Cells(9).Value.ToString()
        SerialNoTextBox.Text = selectedRow.Cells(10).Value.ToString()
        MonitorModelComboBox.Text = selectedRow.Cells(11).Value.ToString()
        MonitorSNTextBox.Text = selectedRow.Cells(12).Value.ToString()
        RemarkTextBox.Text = selectedRow.Cells(13).Value.ToString()
        StatComboBox.Text = selectedRow.Cells(14).Value.ToString()
    End Sub

    Private Sub PrinteCatButton_Click(sender As Object, e As EventArgs) Handles PrinteCatButton.Click
        PrinterCategory.ShowDialog()
    End Sub

    Private Sub MonitorCatButton_Click(sender As Object, e As EventArgs) Handles MonitorCatButton.Click
        MonitorCategory.ShowDialog()
    End Sub

    Private Sub ComputerCatButton_Click(sender As Object, e As EventArgs) Handles ComputerCatButton.Click
        ComputerCategory.ShowDialog()
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim strings As New StringFormat
        'strings.Alignment = StringAlignment.Center
        'Strings.LineAlignment = StringAlignment.Center
        'Dim font1 As New Font("arial", 12, FontStyle.Regular)
        ''e.Graphics.DrawString(vbTab & vbTab & vbTab & "HARDWARE DETAILS FOR USERS" & vbNewLine & vbNewLine _
        '   ' & "_______________________________________________________________" & vbNewLine & vbNewLine _
        '   ' & "USER DETAILS" & vbNewLine _
        '   ' & "Username : " + UsernameTextBox.Text & vbNewLine _
        '  '  & "User Status : " + StatusComboBox.Text & vbNewLine _
        '  ''  & "Department : " + DeptTextBox.Text & vbNewLine _
        '  '  & "Company : " + CompanyComboBox.Text & vbNewLine _
        '  '  & "Location : " + LocationTextBox.Text & vbNewLine _
        '  '  & "---------------------------------------------------------" & vbNewLine _
        '  '  & "PC DETAILS " & vbNewLine _
        '  '  & "PC Model : " + PCModelComboBox.Text & vbNewLine _
        '    & "PC Name :  " + PCNameTextBox.Text & vbNewLine _
        '    & "Serial No : " + SerialNoTextBox.Text & vbNewLine _
        '    & "Product No : " + ProdNoTextBox.Text & vbNewLine _
        '    & "---------------------------------------------------------" & vbNewLine _
        '    & "MONITOR DETAILS " & vbNewLine _
        '    & "Monitor Model : " + PCModelComboBox.Text & vbNewLine _
        '    & "Monitor Serial No :  " + PCNameTextBox.Text & vbNewLine _
        '     & "---------------------------------------------------------" & vbNewLine _
        '    & "OTHERS " & vbNewLine _
        '    & "Remark: " + RemarkTextBox.Text & vbNewLine _
        '    & "-----------------------------------------------------------------------------------------------------------" & vbNewLine & vbNewLine, font1, Brushes.Black, 100, 100)

        'e.Graphics.DrawString("USER DETAILS" & vbNewLine _
        '    & "Username : " + UsernameTextBox.Text & vbNewLine _
        '    & "User Status : " + StatusComboBox.Text & vbNewLine _
        '    & "Department : " + DeptTextBox.Text & vbNewLine _
        '    & "Company : " + CompanyComboBox.Text & vbNewLine _
        '    & "Location : " + LocationTextBox.Text & vbNewLine _
        '    & "---------------------------------------------------------" & vbNewLine _
        '    & "PC DETAILS " & vbNewLine _
        '    & "PC Model : " + PCModelComboBox.Text & vbNewLine _
        '    & "PC Name :  " + PCNameTextBox.Text & vbNewLine _
        '    & "Serial No : " + SerialNoTextBox.Text & vbNewLine _
        '    & "Product No : " + ProdNoTextBox.Text & vbNewLine _
        '    & "---------------------------------------------------------" & vbNewLine _
        '    & "MONITOR DETAILS " & vbNewLine _
        '    & "Monitor Model : " + PCModelComboBox.Text & vbNewLine _
        '    & "Monitor Serial No :  " + PCNameTextBox.Text & vbNewLine _
        '     & "---------------------------------------------------------" & vbNewLine _
        '    & "OTHERS " & vbNewLine _
        '    & "Remark: " + RemarkTextBox.Text & vbNewLine _
        '    & "-----------------------------------------------------------------------------------------------------------" & vbNewLine, font1, Brushes.Black, 100, 600)

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) 
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PdfButton_Click(sender As Object, e As EventArgs) Handles PdfButton.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter filename to create PDF", vbExclamation)
        Else
            ExportDataToPdf()
            MsgBox("PDF file successfully created!", vbInformation)
        End If
    End Sub

    Private Sub ExportDataToPdf()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 30, 30, 30, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))

        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim font12Title As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("LIST OF HARDWARE       " & Now, font12Title))

        doc.Open()
        doc.Add(p1)

        Dim PdfTable As New PdfPTable(14)
        PdfTable.TotalWidth = 550.0F
        PdfTable.LockedWidth = True

        Dim widths As Single() = New Single() {1.0F, 6.0F, 4.0F, 4.0F, 4.0F, 4.0F, 6.0F, 6.0F, 4.0F, 4.0F, 4.0F, 6.0F, 4.0F, 4.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1
        PdfTable.SpacingBefore = 2.0F

        Dim PdfCell As PdfPCell = Nothing

        PdfCell = New PdfPCell(New Phrase(New Chunk("ID", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("USERNAME", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("STATUS", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("DEPT", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("COMPANY", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("LOCATION", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("PC MODEL", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("PC NAME", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("PROD NO", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("SERIAL NO", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("MONITOR MODEL", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("MONITOR SN", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("REMARK", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase(New Chunk("STATUS", font12Bold)))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
        PdfTable.AddCell(PdfCell)

        Dim dt As DataTable = getDataTable()
        If dt IsNot Nothing Then
            For rows As Integer = 0 To dt.Rows.Count - 1
                For columns As Integer = 0 To dt.Columns.Count - 1
                    PdfCell = New PdfPCell(New Phrase(dt.Rows(rows)(columns).ToString, font12Normal))
                    If columns = 1 Or columns = 3 Then
                        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
                    ElseIf columns = 5 Or columns = 6 Then
                        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
                    Else
                        PdfCell.HorizontalAlignment = HorizontalAlignment.Left
                    End If
                    PdfTable.AddCell(PdfCell)
                Next
            Next
            doc.Add(PdfTable)
        End If
        doc.Close()



    End Sub

    Private Function getDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        Dim dataColumn1 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString, GetType(String))
        Dim dataColumn2 As New DataColumn(DataGridView1.Columns(2).HeaderText.ToString, GetType(String))
        Dim dataColumn3 As New DataColumn(DataGridView1.Columns(3).HeaderText.ToString, GetType(String))
        Dim dataColumn4 As New DataColumn(DataGridView1.Columns(4).HeaderText.ToString, GetType(String))
        Dim dataColumn5 As New DataColumn(DataGridView1.Columns(5).HeaderText.ToString, GetType(String))
        Dim dataColumn6 As New DataColumn(DataGridView1.Columns(6).HeaderText.ToString, GetType(String))
        Dim dataColumn7 As New DataColumn(DataGridView1.Columns(7).HeaderText.ToString, GetType(String))
        Dim dataColumn8 As New DataColumn(DataGridView1.Columns(8).HeaderText.ToString, GetType(String))
        Dim dataColumn9 As New DataColumn(DataGridView1.Columns(9).HeaderText.ToString, GetType(String))
        Dim dataColumn10 As New DataColumn(DataGridView1.Columns(10).HeaderText.ToString, GetType(String))
        Dim dataColumn11 As New DataColumn(DataGridView1.Columns(11).HeaderText.ToString, GetType(String))
        Dim dataColumn12 As New DataColumn(DataGridView1.Columns(12).HeaderText.ToString, GetType(String))
        Dim dataColumn13 As New DataColumn(DataGridView1.Columns(13).HeaderText.ToString, GetType(String))
        Dim dataColumn14 As New DataColumn(DataGridView1.Columns(14).HeaderText.ToString, GetType(String))

        dataTable.Columns.Add(dataColumn1)
        dataTable.Columns.Add(dataColumn2)
        dataTable.Columns.Add(dataColumn3)
        dataTable.Columns.Add(dataColumn4)
        dataTable.Columns.Add(dataColumn5)
        dataTable.Columns.Add(dataColumn6)
        dataTable.Columns.Add(dataColumn7)
        dataTable.Columns.Add(dataColumn8)
        dataTable.Columns.Add(dataColumn9)
        dataTable.Columns.Add(dataColumn10)
        dataTable.Columns.Add(dataColumn11)
        dataTable.Columns.Add(dataColumn12)
        dataTable.Columns.Add(dataColumn13)
        dataTable.Columns.Add(dataColumn14)

        Dim dataRow As DataRow
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            dataRow = dataTable.NewRow
            dataRow(DataGridView1.Columns(1).HeaderText.ToString) = DataGridView1.Rows(i).Cells(1).Value.ToString
            dataRow(DataGridView1.Columns(2).HeaderText.ToString) = DataGridView1.Rows(i).Cells(2).Value.ToString
            dataRow(DataGridView1.Columns(3).HeaderText.ToString) = DataGridView1.Rows(i).Cells(3).Value.ToString
            dataRow(DataGridView1.Columns(4).HeaderText.ToString) = DataGridView1.Rows(i).Cells(4).Value.ToString
            dataRow(DataGridView1.Columns(5).HeaderText.ToString) = DataGridView1.Rows(i).Cells(5).Value.ToString
            dataRow(DataGridView1.Columns(6).HeaderText.ToString) = DataGridView1.Rows(i).Cells(6).Value.ToString
            dataRow(DataGridView1.Columns(7).HeaderText.ToString) = DataGridView1.Rows(i).Cells(7).Value.ToString
            dataRow(DataGridView1.Columns(8).HeaderText.ToString) = DataGridView1.Rows(i).Cells(8).Value.ToString
            dataRow(DataGridView1.Columns(9).HeaderText.ToString) = DataGridView1.Rows(i).Cells(9).Value.ToString
            dataRow(DataGridView1.Columns(10).HeaderText.ToString) = DataGridView1.Rows(i).Cells(10).Value.ToString
            dataRow(DataGridView1.Columns(11).HeaderText.ToString) = DataGridView1.Rows(i).Cells(11).Value.ToString
            dataRow(DataGridView1.Columns(12).HeaderText.ToString) = DataGridView1.Rows(i).Cells(12).Value.ToString
            dataRow(DataGridView1.Columns(13).HeaderText.ToString) = DataGridView1.Rows(i).Cells(13).Value.ToString
            dataRow(DataGridView1.Columns(14).HeaderText.ToString) = DataGridView1.Rows(i).Cells(14).Value.ToString
            dataTable.Rows.Add(dataRow)
        Next

        dataTable.AcceptChanges()
        Return dataTable

    End Function

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).Name = "status" Then

            If e.Value = "Repair" Then
                e.CellStyle.BackColor = Color.LightSalmon
            Else
                e.CellStyle.BackColor = Color.LightGreen
            End If

        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "userStatus" Then

            If e.Value = "Inactive" Then
                e.CellStyle.BackColor = Color.DarkGray
            Else
                e.CellStyle.BackColor = Color.LightGreen
            End If

        End If
    End Sub

    Private Sub ExcelButton_Click(sender As Object, e As EventArgs) Handles ExcelButton.Click

        ExportToExcel()

    End Sub

    Public Sub ExportToExcel()
        'Dim cnn As MySqlConnection
        'Dim cnnst As String
        Dim sql As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        'Excel
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim misvalue As Object = Reflection.Missing.Value
        xlapp = New Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("Sheet1")
        xlworksheet.Columns.AutoFit()

        'cnnst = "Server=(LocalHost); Database=hos; UID=root; PWD=;"
        'con = New MySqlConnection(cnnst)
        con.Open()
        sql = "SELECT id, username, userStatus, dept, company, location, pcmodel, pcName, prodNo, serialNo, monitormodel, monitorSn, remark, status FROM hardware"
        Dim cmd As New MySqlDataAdapter(sql, con)
        Dim ds As New DataSet
        cmd.Fill(ds)
        'For i = 0 To DataGridView1.RowCount - 2
        '    For j = 0 To DataGridView1.ColumnCount - 1
        '        For k = 1 To DataGridView1.Columns.Count
        '            xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        '            xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
        '        Next
        '    Next
        'Next
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                For k = 2 To DataGridView1.Columns.Count
                    xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlworksheet.Cells(i + 2, j + 2) = ds.Tables(0).Rows(i).Item(j)
                Next
            Next
        Next
        Dim fname As String = ""
            Using sfd As New SaveFileDialog
            sfd.Title = "Save As"
            sfd.OverwritePrompt = True
            sfd.FileName = fname
            sfd.DefaultExt = ".xlsx"
            sfd.Filter = "Excel Workbook(*.xlsx) |"
            sfd.AddExtension = True
            If sfd.ShowDialog() = DialogResult.OK Then
                xlworksheet.SaveAs(sfd.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                Myobject(xlapp)
                Myobject(xlworkbook)
                Myobject(xlworksheet)
                'MsgBox("Export to Excel Success", MsgBoxStyle.Information, "== Notification ==")
            End If
        End Using
        'xlworksheet.SaveAs2(FileName)
        'xlworkbook.Close()
        'xlapp.Quit()

        'Myobject(xlapp)
        'Myobject(xlworkbook)
        'Myobject(xlworksheet)
        con.Close()
        MessageBox.Show("Export to Excel success.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Myobject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    'dependent combo box / autofill textbox when select username in the combo box
    Private Sub UsernameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsernameComboBox.SelectedIndexChanged
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM user WHERE username='" & UsernameComboBox.Text & "'"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            While READER.Read
                StatusComboBox.Text = READER.GetString("userStatus")
                LocationTextBox.Text = READER.GetString("location")
                CompanyComboBox.Text = READER.GetString("company")
                DeptTextBox.Text = READER.GetString("dept")

            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        ManageEmployee.ShowDialog()
    End Sub


End Class