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

Public Class PdfDekstopFrom

    Private Sub PdfDekstopFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '    'Create a new PDF document.

    '    Dim document As PdfDocument = New PdfDocument()

    '    'Add a new page to the PDF document.

    '    Dim page As PdfPage = document.Pages.Add()

    '    'Create a textbox field and add the properties.

    '    Dim textBoxField As PdfTextBoxField = New PdfTextBoxField(page, "FirstName")

    'textBoxField.Bounds = New RectangleF(0, 0, 100, 20)

    'textBoxField.ToolTip = "First Name"

    ''Add the form field to the document.

    'document.Form.Fields.Add(textBoxField)

    ''Save the document.

    'document.Save("Form.pdf")

    ''close the document

    'document.Close(True)
End Class