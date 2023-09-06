Imports System.Data
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Module CRUDDbConnection

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=hos")
    End Function

    Public con As MySqlConnection = connection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'create function 
    Public Sub create(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data is recorded into database", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    'reload the datagridview
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


    'update function
    Public Sub updates(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to update the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data is updated successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'delete function
    Public Sub delete(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to delete the data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data is deleted from the database", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ExportToExcel()
        'Dim cnn As MySqlConnection
        'Dim cnnst As String
        Dim sql As String
        Dim i As Integer
        Dim j As Integer

        'Excel
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim misvalue As Object = Reflection.Missing.Value
        xlapp = New Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("Sheet1")
        'cnnst = "Server=(LocalHost); Database=hos; UID=root; PWD=;"
        'con = New MySqlConnection(cnnst)
        con.Open()
        sql = "SELECT * FROM hardware"
        Dim cmd As New MySqlDataAdapter(sql, con)
        Dim ds As New DataSet
        cmd.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                xlworksheet.Cells(i + 1, j + 1) = ds.Tables(0).Rows(i).Item(j)
            Next
        Next
        xlworksheet.SaveAs2("C:\Report.xlsx")
        xlworkbook.Close()
        xlapp.Quit()

        Myobject(xlapp)
        Myobject(xlworkbook)
        Myobject(xlworksheet)
        con.Close()
        MessageBox.Show("Export to Excel success.", "Export", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

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
End Module
