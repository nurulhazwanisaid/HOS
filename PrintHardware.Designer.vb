<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintHardware
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ZoomInButton = New System.Windows.Forms.Button()
        Me.ZoomOutButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(-3, 57)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(1060, 644)
        Me.PrintPreviewControl1.TabIndex = 0
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 12)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(124, 39)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ZoomInButton
        '
        Me.ZoomInButton.Location = New System.Drawing.Point(158, 12)
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(124, 39)
        Me.ZoomInButton.TabIndex = 2
        Me.ZoomInButton.Text = "Zoom In"
        Me.ZoomInButton.UseVisualStyleBackColor = True
        '
        'ZoomOutButton
        '
        Me.ZoomOutButton.Location = New System.Drawing.Point(304, 12)
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(124, 39)
        Me.ZoomOutButton.TabIndex = 3
        Me.ZoomOutButton.Text = "Zoom Out"
        Me.ZoomOutButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintHardware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 701)
        Me.Controls.Add(Me.ZoomOutButton)
        Me.Controls.Add(Me.ZoomInButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Name = "PrintHardware"
        Me.Text = "PrintHardware"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PrintButton As Button
    Friend WithEvents ZoomInButton As Button
    Friend WithEvents ZoomOutButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
