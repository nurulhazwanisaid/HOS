<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageEmployee))
        Me.EditButton = New System.Windows.Forms.Button()
        Me.MinimizedButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.ExtNoTextBox = New System.Windows.Forms.TextBox()
        Me.ExtNoLabel = New System.Windows.Forms.Label()
        Me.HpNoLabel = New System.Windows.Forms.Label()
        Me.HpNoTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.DeptTextBox = New System.Windows.Forms.TextBox()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CompanyTextBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTipClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipMinimize = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipClear = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipInsert = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipDelete = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipUpdate = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.White
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.Location = New System.Drawing.Point(153, 507)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(45, 52)
        Me.EditButton.TabIndex = 78
        Me.ToolTipUpdate.SetToolTip(Me.EditButton, "Update selected data")
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'MinimizedButton
        '
        Me.MinimizedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.MinimizedButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizedButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizedButton.FlatAppearance.BorderSize = 0
        Me.MinimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizedButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimizedButton.ForeColor = System.Drawing.Color.White
        Me.MinimizedButton.Image = CType(resources.GetObject("MinimizedButton.Image"), System.Drawing.Image)
        Me.MinimizedButton.Location = New System.Drawing.Point(1334, 0)
        Me.MinimizedButton.Name = "MinimizedButton"
        Me.MinimizedButton.Size = New System.Drawing.Size(52, 42)
        Me.MinimizedButton.TabIndex = 65
        Me.ToolTipMinimize.SetToolTip(Me.MinimizedButton, "Minimize")
        Me.MinimizedButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.Location = New System.Drawing.Point(1386, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(42, 42)
        Me.CloseButton.TabIndex = 64
        Me.ToolTipClose.SetToolTip(Me.CloseButton, "Close")
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.White
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Location = New System.Drawing.Point(204, 507)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(45, 52)
        Me.DeleteButton.TabIndex = 79
        Me.ToolTipDelete.SetToolTip(Me.DeleteButton, "Delete data from record")
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedButton)
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1428, 42)
        Me.Panel1.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(583, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 38)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Add New Employee"
        '
        'LocationComboBox
        '
        Me.LocationComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Items.AddRange(New Object() {"KLG", "AIC", "SVCL"})
        Me.LocationComboBox.Location = New System.Drawing.Point(189, 111)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(202, 33)
        Me.LocationComboBox.TabIndex = 2
        '
        'StatusComboBox
        '
        Me.StatusComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.StatusComboBox.Location = New System.Drawing.Point(189, 70)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(202, 33)
        Me.StatusComboBox.TabIndex = 1
        '
        'ExtNoTextBox
        '
        Me.ExtNoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExtNoTextBox.Location = New System.Drawing.Point(736, 108)
        Me.ExtNoTextBox.Name = "ExtNoTextBox"
        Me.ExtNoTextBox.Size = New System.Drawing.Size(257, 31)
        Me.ExtNoTextBox.TabIndex = 6
        '
        'ExtNoLabel
        '
        Me.ExtNoLabel.AutoSize = True
        Me.ExtNoLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExtNoLabel.Location = New System.Drawing.Point(593, 111)
        Me.ExtNoLabel.Name = "ExtNoLabel"
        Me.ExtNoLabel.Size = New System.Drawing.Size(116, 25)
        Me.ExtNoLabel.TabIndex = 28
        Me.ExtNoLabel.Text = "Extension No"
        '
        'HpNoLabel
        '
        Me.HpNoLabel.AutoSize = True
        Me.HpNoLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HpNoLabel.Location = New System.Drawing.Point(593, 69)
        Me.HpNoLabel.Name = "HpNoLabel"
        Me.HpNoLabel.Size = New System.Drawing.Size(91, 25)
        Me.HpNoLabel.TabIndex = 27
        Me.HpNoLabel.Text = "Phone No"
        '
        'HpNoTextBox
        '
        Me.HpNoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HpNoTextBox.Location = New System.Drawing.Point(736, 63)
        Me.HpNoTextBox.Name = "HpNoTextBox"
        Me.HpNoTextBox.Size = New System.Drawing.Size(257, 31)
        Me.HpNoTextBox.TabIndex = 5
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.BackColor = System.Drawing.Color.White
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Image = CType(resources.GetObject("ClearButton.Image"), System.Drawing.Image)
        Me.ClearButton.Location = New System.Drawing.Point(1233, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(58, 49)
        Me.ClearButton.TabIndex = 76
        Me.ToolTipClear.SetToolTip(Me.ClearButton, "Clear form input")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InsertButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.InsertButton.FlatAppearance.BorderSize = 0
        Me.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InsertButton.ForeColor = System.Drawing.Color.White
        Me.InsertButton.Location = New System.Drawing.Point(657, 406)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(95, 45)
        Me.InsertButton.TabIndex = 74
        Me.InsertButton.Text = "Insert"
        Me.ToolTipInsert.SetToolTip(Me.InsertButton, "Add new data")
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'DeptTextBox
        '
        Me.DeptTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeptTextBox.Location = New System.Drawing.Point(736, 23)
        Me.DeptTextBox.Name = "DeptTextBox"
        Me.DeptTextBox.Size = New System.Drawing.Size(345, 31)
        Me.DeptTextBox.TabIndex = 4
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeptLabel.Location = New System.Drawing.Point(593, 29)
        Me.DeptLabel.Name = "DeptLabel"
        Me.DeptLabel.Size = New System.Drawing.Size(107, 25)
        Me.DeptLabel.TabIndex = 24
        Me.DeptLabel.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(46, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(46, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(46, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User Status"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameTextBox.Location = New System.Drawing.Point(189, 23)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(345, 31)
        Me.UsernameTextBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(46, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "User Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CompanyTextBox)
        Me.GroupBox1.Controls.Add(Me.LocationComboBox)
        Me.GroupBox1.Controls.Add(Me.StatusComboBox)
        Me.GroupBox1.Controls.Add(Me.ExtNoTextBox)
        Me.GroupBox1.Controls.Add(Me.ExtNoLabel)
        Me.GroupBox1.Controls.Add(Me.HpNoLabel)
        Me.GroupBox1.Controls.Add(Me.HpNoTextBox)
        Me.GroupBox1.Controls.Add(Me.DeptTextBox)
        Me.GroupBox1.Controls.Add(Me.DeptLabel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1131, 218)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CompanyTextBox.FormattingEnabled = True
        Me.CompanyTextBox.Items.AddRange(New Object() {"RMSB", "SSB"})
        Me.CompanyTextBox.Location = New System.Drawing.Point(189, 156)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(202, 33)
        Me.CompanyTextBox.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IDTextBox.Location = New System.Drawing.Point(928, 522)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(42, 31)
        Me.IDTextBox.TabIndex = 72
        Me.IDTextBox.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(593, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 38)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "List of Employee"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(148, 565)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1131, 423)
        Me.DataGridView1.TabIndex = 71
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.BackColor = System.Drawing.Color.White
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), System.Drawing.Image)
        Me.SearchButton.Location = New System.Drawing.Point(1227, 515)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(49, 44)
        Me.SearchButton.TabIndex = 70
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(976, 526)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(245, 27)
        Me.SearchTextBox.TabIndex = 0
        '
        'ManageEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1428, 908)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageEmployee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditButton As Button
    Friend WithEvents MinimizedButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents ExtNoTextBox As TextBox
    Friend WithEvents ExtNoLabel As Label
    Friend WithEvents HpNoLabel As Label
    Friend WithEvents HpNoTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents DeptTextBox As TextBox
    Friend WithEvents DeptLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CompanyTextBox As ComboBox
    Friend WithEvents ToolTipUpdate As ToolTip
    Friend WithEvents ToolTipMinimize As ToolTip
    Friend WithEvents ToolTipClose As ToolTip
    Friend WithEvents ToolTipDelete As ToolTip
    Friend WithEvents ToolTipClear As ToolTip
    Friend WithEvents ToolTipInsert As ToolTip
End Class
