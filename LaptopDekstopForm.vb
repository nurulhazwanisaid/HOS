Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Xml
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.Security
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Parsing
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Grid

Public Class LaptopDekstopForm

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to logout", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
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

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Hide()
    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        ManageEmployee.ShowDialog()
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

    Private Sub LaptopDekstopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'username combo box
        username_option()

        'dependent combo box with combo box
        Using sda1 As MySqlDataAdapter = New MySqlDataAdapter("SELECT DISTINCTROW location FROM hardware ORDER BY location", connection)


            Dim dt As DataTable = New DataTable

            sda1.Fill(dt)


            Dim row As DataRow = dt.NewRow()

            row(0) = "Select"



            dt.Rows.InsertAt(row, 0)

            LocationComboBox.DataSource = dt

            LocationComboBox.DisplayMember = "location"

            LocationComboBox.ValueMember = "location"


        End Using

    End Sub

    Private Sub LocationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LocationComboBox.SelectedIndexChanged

        connection.Open()
        Dim strsql As String
        strsql = "Select username from hardware where location='" + LocationComboBox.Text + "'"

        Dim cmd As New MySqlCommand(strsql, connection)

        Dim myreader As MySqlDataReader

        myreader = cmd.ExecuteReader

        UsernameComboBox.Items.Clear()
        While myreader.Read

            UsernameComboBox.Items.Add(myreader("username"))

        End While
        connection.Close()
    End Sub

    'dependent combo box / autofill textbox when select username in the combo box
    Private Sub UsernameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsernameComboBox.SelectedIndexChanged
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT hardware.username, hardware.dept, hardware.company, hardware.location, hardware.pcmodel, hardware.pcName, hardware.prodNo, hardware.serialNo, hardware.monitormodel, hardware.monitorSn, compcat.type, compcat.ram, compcat.hdd, compcat.processor, compcat.osVer, compcat.osBit, monitor.size, user.extNo, user.hpNo FROM compcat INNER JOIN hardware ON compcat.id = hardware.compid INNER JOIN monitor ON monitor.id = hardware.monitorid INNER JOIN user ON user.id = hardware.userid WHERE hardware.username='" & UsernameComboBox.Text & "'"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            While READER.Read
                'hardware
                UsernameTextBox.Text = READER.GetString("username")
                DeptTextBox.Text = READER.GetString("dept")
                CompanyTextBox.Text = READER.GetString("company")
                LocationTextBox.Text = READER.GetString("location")
                PcModelTextBox.Text = READER.GetString("pcmodel")
                PcNameTextBox.Text = READER.GetString("pcName")
                ProdNoTextBox.Text = READER.GetString("prodNo")
                PcSnTextBox.Text = READER.GetString("serialNo")
                MonitorModelTextBox.Text = READER.GetString("monitormodel")
                MonitorSnTextBox.Text = READER.GetString("monitorSn")

                'compcat
                TypeTextBox.Text = READER.GetString("type")
                RamTextBox.Text = READER.GetString("ram")
                HddTextBox.Text = READER.GetString("hdd")
                CpuSpeedTextBox.Text = READER.GetString("processor")
                OsVerTextBox.Text = READER.GetString("osVer")
                OsBitTextBox.Text = READER.GetString("osBit")

                'monitor
                SizeTextBox.Text = READER.GetString("size")

                'user
                ExtTextBox.Text = READER.GetString("extNo")
                HpNoTextBox.Text = READER.GetString("hpNo")

            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Dim myImage As New Bitmap(Me.Width, Me.Height)
        'Dim PrintSize As Size = e.MarginBounds.Size
        'Dim scale As Double = 1

        'Me.DrawToBitmap(myImage, New Rectangle(Point.Empty, Me.Size))

        'PrintSize.Width *= 0.96 'convert to pixels
        'PrintSize.Height *= 0.96

        'If myImage.Width > PrintSize.Width Then
        '    'Form is to big. Scale it down.
        '    scale = PrintSize.Width / myImage.Width
        '    e.Graphics.ScaleTransform(scale, scale)
        'End If

        'If (myImage.Height * scale) > PrintSize.Height Then
        '    'The form is still to big. Scale it again.
        '    scale = PrintSize.Height / (myImage.Height * scale)
        '    e.Graphics.ScaleTransform(scale, scale)
        'End If

        'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        'e.Graphics.DrawImage(myImage, e.MarginBounds.Location)

        'myImage.Dispose()

        'Loads the PDF form.
        Dim loadedDocument As New PdfLoadedDocument("JobApplication.pdf")
        'Load the form
        Dim form As PdfLoadedForm = loadedDocument.Form
        'Fills the textbox field by using index
        TryCast(form.Fields(0), PdfLoadedTextBoxField).Text = "John"
        'Fills the textbox fields by using field name
        TryCast(form.Fields("LastName"), PdfLoadedTextBoxField).Text = "Doe"
        TryCast(form.Fields("Address"), PdfLoadedTextBoxField).Text = " John Doe " & vbLf & " 123 Main St " & vbLf & " Anytown, USA"
        'Load the radio button group
        Dim radioButtonCollection As PdfLoadedRadioButtonItemCollection = TryCast(form.Fields("Gender"), PdfLoadedRadioButtonListField).Items
        'Checks the 'Male' option
        radioButtonCollection(0).Checked = True
        'Checks the 'business' checkbox field
        TryCast(form.Fields("Business"), PdfLoadedCheckBoxField).Checked = True
        'Checks the 'retiree' checkbox field
        TryCast(form.Fields("Retiree"), PdfLoadedCheckBoxField).Checked = True
        'Saves and closes the document
        loadedDocument.Save("output.pdf")
        loadedDocument.Close(True)

    End Sub

    Private Sub LaptopDekstopForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'If e.KeyCode = Keys.P AndAlso (e.Control AndAlso e.Alt) Then
        '    If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        PrintDocument1.Print()
        '    End If
        'End If

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.ShowDialog()
        'xmltopdf()
    End Sub

    'Private Sub xmltopdf()
    '    Dim pdfTemp As String = "C:\ExampleTemplate.pdf" ' ---> It's the original pdf form you want to fill
    '    Dim newFile As String = "C:\NewFile.Pdf" ' ---> It will generate new pdf that you have filled from your program

    '    ' ------ READING -------

    '    Dim pdfReader As New PdfReader(pdfTemp)

    '    ' ------ WRITING -------

    '    ' If you don’t specify version and append flag (last 2 params) in below line then you may receive “Extended Features” error when you open generated PDF
    '    Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newFile, FileMode.Create), "\6c", True)

    '    Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

    '    ' ------ SET YOUR FORM FIELDS ------

    '    pdfFormFields.SetField("Company", "Parth Dave & Co.")
    '    pdfFormFields.SetField("SalesOrder", "1234456")
    '    pdfFormFields.SetField("InstallAddress", "Lorimer Street")
    '    pdfFormFields.SetField("Suburb", "Port Melbourne")
    '    pdfFormFields.SetField("Post_Code", "3207")
    '    pdfFormFields.SetField("ClientContact", "Parth")
    '    pdfFormFields.SetField("ClientPhone", "0402020202")

    '    pdfStamper.FormFlattening = False

    '    ' close the pdf
    '    pdfStamper.Close()
    '    ' pdfReader.close() ---> DON"T EVER CLOSE READER IF YOU'RE GENERATING LOTS OF PDF FILES IN LOOP
    'End Sub

    'Public Sub ExportFormToPdf()
    '    Dim doc As New Document(iTextSharp.text.PageSize.A4, 30, 30, 30, 10)
    '    Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))

    '    Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
    '    Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
    '    Dim font12Title As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

    '    Dim p1 As New Phrase
    '    p1 = New Phrase(New Chunk("LAPTOP/DESKTOP FORM       ", font12Title))

    '    doc.Open()
    '    doc.Add(p1)

    '    'Create a new PDF document.

    '    Dim document As PdfDocument = New PdfDocument()

    '    'Add a new page to the PDF document.

    '    Dim page As PdfPage = document.Pages.Add()

    '    'Create a textbox field and add the properties.

    '    Dim textBoxField As PdfTextBoxField = New PdfTextBoxField(page, "FirstName")

    '    textBoxField.Bounds = New RectangleF(0, 0, 100, 20)

    '    textBoxField.ToolTip = "First Name"

    '    'Add the form field to the document.

    '    document.Form.Fields.Add(textBoxField)

    '    'Save the document.

    '    document.Save("Form.pdf")

    '    'close the document

    '    document.Close(True)
    'End Sub

End Class