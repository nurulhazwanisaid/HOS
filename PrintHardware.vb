Public Class PrintHardware

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = 170
        Dim y As Integer = 360
        Dim xwidth As Integer = 190
        Dim yheight As Integer = 20
        Dim cellwidth As Integer = 300
        Dim cellheight As Integer = 370

        Dim fon As New Font(FontFamily.GenericSerif, 12, FontStyle.Regular)
        Dim rect As New Rectangle(x, 10, xwidth, yheight)
        Dim strings As New StringFormat

        strings.Alignment = StringAlignment.Center
        strings.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        'e.Graphics.DrawString(vbTab & vbTab & "LIST OF HARDWARE" & vbNewLine & vbNewLine _
        '  & "_____________________________________________________" & vbNewLine & vbNewLine _
        '   & "Order date : " + OrderDateDateTimePicker.Text & vbNewLine & vbNewLine _
        '    & "Order Status : " + OrderStatusTextBox.Text & vbNewLine & vbNewLine _
        '    & "Vendor ID : " + VendorIDTextBox.Text & vbNewLine & vbNewLine _
        '   & "Product Code : " + ProductNameTextBox.Text & vbNewLine & vbNewLine _
        '   & "Order Quantity : " + OrderQtyTextBox.Text & vbNewLine & vbNewLine _
        '   & "Subtotal : RM " + SubtotalTextBox.Text & vbNewLine & vbNewLine _
        '  & "Shipping Cost : RM " + ShippingCostTextBox.Text & vbNewLine & vbNewLine _
        '   & "Tax : " + TaxTextBox.Text + "%" & vbNewLine & vbNewLine _
        '  & "Grandtotal : RM " + GrandTotalTextBox.Text, font1, Brushes.Black, 100, 100)


    End Sub

    Private Sub PrintHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class