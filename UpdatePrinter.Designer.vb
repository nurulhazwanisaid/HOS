<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePrinter
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModelComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.IpAddTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.DeptTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNoTextBox = New System.Windows.Forms.TextBox()
        Me.UniversalConnectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.UniversalConnectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 31)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Update Printer Detail"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ExitButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 44)
        Me.Panel1.TabIndex = 34
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExitButton.Location = New System.Drawing.Point(1208, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(33, 30)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "X"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(300, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 28)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Remarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(296, 399)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 28)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(296, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 28)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Company"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(296, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 28)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(296, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(296, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Serial No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(296, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 28)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Model"
        '
        'ModelComboBox
        '
        Me.ModelComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ModelComboBox.FormattingEnabled = True
        Me.ModelComboBox.Location = New System.Drawing.Point(455, 111)
        Me.ModelComboBox.Name = "ModelComboBox"
        Me.ModelComboBox.Size = New System.Drawing.Size(436, 36)
        Me.ModelComboBox.TabIndex = 26
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RemarksTextBox.Location = New System.Drawing.Point(455, 518)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(436, 44)
        Me.RemarksTextBox.TabIndex = 25
        '
        'IpAddTextBox
        '
        Me.IpAddTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IpAddTextBox.Location = New System.Drawing.Point(455, 231)
        Me.IpAddTextBox.Name = "IpAddTextBox"
        Me.IpAddTextBox.Size = New System.Drawing.Size(436, 34)
        Me.IpAddTextBox.TabIndex = 24
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LocationTextBox.Location = New System.Drawing.Point(455, 399)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(436, 34)
        Me.LocationTextBox.TabIndex = 23
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CompanyTextBox.Location = New System.Drawing.Point(455, 343)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(436, 34)
        Me.CompanyTextBox.TabIndex = 22
        '
        'DeptTextBox
        '
        Me.DeptTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeptTextBox.Location = New System.Drawing.Point(455, 287)
        Me.DeptTextBox.Name = "DeptTextBox"
        Me.DeptTextBox.Size = New System.Drawing.Size(436, 34)
        Me.DeptTextBox.TabIndex = 21
        '
        'SerialNoTextBox
        '
        Me.SerialNoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SerialNoTextBox.Location = New System.Drawing.Point(455, 175)
        Me.SerialNoTextBox.Name = "SerialNoTextBox"
        Me.SerialNoTextBox.Size = New System.Drawing.Size(436, 34)
        Me.SerialNoTextBox.TabIndex = 20
        '
        'UniversalConnectorBindingSource
        '
        Me.UniversalConnectorBindingSource.DataSource = GetType(HOS.UniversalConnector)
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(555, 593)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(186, 50)
        Me.UpdateButton.TabIndex = 19
        Me.UpdateButton.Text = "Save Changes"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(296, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 28)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "User"
        '
        'UserTextBox
        '
        Me.UserTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserTextBox.Location = New System.Drawing.Point(455, 460)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(436, 34)
        Me.UserTextBox.TabIndex = 36
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IDTextBox.Location = New System.Drawing.Point(927, 114)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(42, 31)
        Me.IDTextBox.TabIndex = 38
        Me.IDTextBox.Visible = False
        '
        'UpdatePrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 655)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ModelComboBox)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.IpAddTextBox)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(Me.DeptTextBox)
        Me.Controls.Add(Me.SerialNoTextBox)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Button1)
        Me.Name = "UpdatePrinter"
        Me.Text = "UpdatePrinter"
        Me.Panel1.ResumeLayout(False)
        CType(Me.UniversalConnectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ModelComboBox As ComboBox
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents IpAddTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents DeptTextBox As TextBox
    Friend WithEvents SerialNoTextBox As TextBox
    Friend WithEvents UniversalConnectorBindingSource As BindingSource
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
End Class
