<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrinterList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrinterList))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.ComputerCatButton = New System.Windows.Forms.Button()
        Me.MonitorCatButton = New System.Windows.Forms.Button()
        Me.PrinteCatButton = New System.Windows.Forms.Button()
        Me.DashboardButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimizedButton = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ModelComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.IpAddTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.DeptTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNoTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PdfButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ExcelButton = New System.Windows.Forms.Button()
        Me.ToolTipMinimize = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipClear = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipInsert = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipUpdate = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipDelete = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipPdf = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipExcel = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel3.Controls.Add(Me.EmployeeButton)
        Me.Panel3.Controls.Add(Me.LogoutButton)
        Me.Panel3.Controls.Add(Me.AboutButton)
        Me.Panel3.Controls.Add(Me.ComputerCatButton)
        Me.Panel3.Controls.Add(Me.MonitorCatButton)
        Me.Panel3.Controls.Add(Me.PrinteCatButton)
        Me.Panel3.Controls.Add(Me.DashboardButton)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 914)
        Me.Panel3.TabIndex = 17
        '
        'EmployeeButton
        '
        Me.EmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.EmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeButton.FlatAppearance.BorderSize = 0
        Me.EmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeButton.Image = CType(resources.GetObject("EmployeeButton.Image"), System.Drawing.Image)
        Me.EmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeButton.Location = New System.Drawing.Point(0, 421)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.EmployeeButton.Size = New System.Drawing.Size(281, 55)
        Me.EmployeeButton.TabIndex = 10
        Me.EmployeeButton.Text = "       Manage User"
        Me.EmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeButton.UseVisualStyleBackColor = False
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutButton.FlatAppearance.BorderSize = 0
        Me.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(0, 855)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LogoutButton.Size = New System.Drawing.Size(281, 59)
        Me.LogoutButton.TabIndex = 7
        Me.LogoutButton.Text = "       Logout"
        Me.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.UseVisualStyleBackColor = False
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutButton.FlatAppearance.BorderSize = 0
        Me.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.ForeColor = System.Drawing.Color.White
        Me.AboutButton.Image = CType(resources.GetObject("AboutButton.Image"), System.Drawing.Image)
        Me.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutButton.Location = New System.Drawing.Point(0, 476)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AboutButton.Size = New System.Drawing.Size(281, 55)
        Me.AboutButton.TabIndex = 6
        Me.AboutButton.Text = "        About"
        Me.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'ComputerCatButton
        '
        Me.ComputerCatButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComputerCatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComputerCatButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComputerCatButton.FlatAppearance.BorderSize = 0
        Me.ComputerCatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ComputerCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComputerCatButton.ForeColor = System.Drawing.Color.White
        Me.ComputerCatButton.Image = CType(resources.GetObject("ComputerCatButton.Image"), System.Drawing.Image)
        Me.ComputerCatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComputerCatButton.Location = New System.Drawing.Point(0, 366)
        Me.ComputerCatButton.Name = "ComputerCatButton"
        Me.ComputerCatButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ComputerCatButton.Size = New System.Drawing.Size(281, 55)
        Me.ComputerCatButton.TabIndex = 5
        Me.ComputerCatButton.Text = "       Computer Category"
        Me.ComputerCatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComputerCatButton.UseVisualStyleBackColor = False
        '
        'MonitorCatButton
        '
        Me.MonitorCatButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.MonitorCatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonitorCatButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MonitorCatButton.FlatAppearance.BorderSize = 0
        Me.MonitorCatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.MonitorCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonitorCatButton.ForeColor = System.Drawing.Color.White
        Me.MonitorCatButton.Image = CType(resources.GetObject("MonitorCatButton.Image"), System.Drawing.Image)
        Me.MonitorCatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonitorCatButton.Location = New System.Drawing.Point(0, 311)
        Me.MonitorCatButton.Name = "MonitorCatButton"
        Me.MonitorCatButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.MonitorCatButton.Size = New System.Drawing.Size(281, 55)
        Me.MonitorCatButton.TabIndex = 4
        Me.MonitorCatButton.Text = "        Monitor Category"
        Me.MonitorCatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonitorCatButton.UseVisualStyleBackColor = False
        '
        'PrinteCatButton
        '
        Me.PrinteCatButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PrinteCatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrinteCatButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrinteCatButton.FlatAppearance.BorderSize = 0
        Me.PrinteCatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PrinteCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrinteCatButton.ForeColor = System.Drawing.Color.White
        Me.PrinteCatButton.Image = CType(resources.GetObject("PrinteCatButton.Image"), System.Drawing.Image)
        Me.PrinteCatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrinteCatButton.Location = New System.Drawing.Point(0, 256)
        Me.PrinteCatButton.Name = "PrinteCatButton"
        Me.PrinteCatButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.PrinteCatButton.Size = New System.Drawing.Size(281, 55)
        Me.PrinteCatButton.TabIndex = 3
        Me.PrinteCatButton.Text = "        Printer Category"
        Me.PrinteCatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrinteCatButton.UseVisualStyleBackColor = False
        '
        'DashboardButton
        '
        Me.DashboardButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.DashboardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardButton.FlatAppearance.BorderSize = 0
        Me.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardButton.ForeColor = System.Drawing.Color.White
        Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
        Me.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.Location = New System.Drawing.Point(0, 201)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DashboardButton.Size = New System.Drawing.Size(281, 55)
        Me.DashboardButton.TabIndex = 2
        Me.DashboardButton.Text = "        Dashboard"
        Me.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 153)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 48)
        Me.Panel5.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1369, 403)
        Me.DataGridView1.TabIndex = 24
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.White
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), System.Drawing.Image)
        Me.SearchButton.Location = New System.Drawing.Point(1646, 435)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(50, 44)
        Me.SearchButton.TabIndex = 23
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(1395, 446)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(245, 27)
        Me.SearchTextBox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(327, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 31)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "List of Printer and etc"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.White
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Location = New System.Drawing.Point(442, 430)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(58, 49)
        Me.DeleteButton.TabIndex = 10
        Me.ToolTipDelete.SetToolTip(Me.DeleteButton, "Delete data from record")
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.White
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.Location = New System.Drawing.Point(384, 430)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(58, 49)
        Me.EditButton.TabIndex = 11
        Me.ToolTipUpdate.SetToolTip(Me.EditButton, "Update selected data")
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.White
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
        Me.AddButton.Location = New System.Drawing.Point(326, 430)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(58, 49)
        Me.AddButton.TabIndex = 12
        Me.ToolTipInsert.SetToolTip(Me.AddButton, "Add new data")
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(281, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1458, 48)
        Me.Panel1.TabIndex = 9
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
        Me.MinimizedButton.Location = New System.Drawing.Point(1400, 0)
        Me.MinimizedButton.Name = "MinimizedButton"
        Me.MinimizedButton.Size = New System.Drawing.Size(58, 48)
        Me.MinimizedButton.TabIndex = 63
        Me.ToolTipMinimize.SetToolTip(Me.MinimizedButton, "Minimize")
        Me.MinimizedButton.UseVisualStyleBackColor = False
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IDTextBox.Location = New System.Drawing.Point(1511, 336)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(42, 31)
        Me.IDTextBox.TabIndex = 33
        Me.IDTextBox.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(994, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 28)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "User"
        '
        'UserTextBox
        '
        Me.UserTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserTextBox.Location = New System.Drawing.Point(1153, 277)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(327, 34)
        Me.UserTextBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(994, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 28)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Remarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(994, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(994, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Company"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(465, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(465, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(465, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serial No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(465, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Model"
        '
        'ModelComboBox
        '
        Me.ModelComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ModelComboBox.FormattingEnabled = True
        Me.ModelComboBox.Location = New System.Drawing.Point(624, 157)
        Me.ModelComboBox.Name = "ModelComboBox"
        Me.ModelComboBox.Size = New System.Drawing.Size(306, 36)
        Me.ModelComboBox.TabIndex = 0
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RemarksTextBox.Location = New System.Drawing.Point(1153, 331)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(327, 44)
        Me.RemarksTextBox.TabIndex = 8
        '
        'IpAddTextBox
        '
        Me.IpAddTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IpAddTextBox.Location = New System.Drawing.Point(624, 277)
        Me.IpAddTextBox.Name = "IpAddTextBox"
        Me.IpAddTextBox.Size = New System.Drawing.Size(306, 34)
        Me.IpAddTextBox.TabIndex = 2
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LocationTextBox.Location = New System.Drawing.Point(1153, 213)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(327, 34)
        Me.LocationTextBox.TabIndex = 6
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CompanyTextBox.Location = New System.Drawing.Point(1153, 160)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(327, 34)
        Me.CompanyTextBox.TabIndex = 5
        '
        'DeptTextBox
        '
        Me.DeptTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeptTextBox.Location = New System.Drawing.Point(624, 333)
        Me.DeptTextBox.Name = "DeptTextBox"
        Me.DeptTextBox.Size = New System.Drawing.Size(306, 34)
        Me.DeptTextBox.TabIndex = 3
        '
        'SerialNoTextBox
        '
        Me.SerialNoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SerialNoTextBox.Location = New System.Drawing.Point(624, 221)
        Me.SerialNoTextBox.Name = "SerialNoTextBox"
        Me.SerialNoTextBox.Size = New System.Drawing.Size(306, 34)
        Me.SerialNoTextBox.TabIndex = 1
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.White
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Image = CType(resources.GetObject("ClearButton.Image"), System.Drawing.Image)
        Me.ClearButton.Location = New System.Drawing.Point(1422, 105)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(58, 49)
        Me.ClearButton.TabIndex = 51
        Me.ToolTipClear.SetToolTip(Me.ClearButton, "Clear form input")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'PdfButton
        '
        Me.PdfButton.BackColor = System.Drawing.Color.White
        Me.PdfButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PdfButton.FlatAppearance.BorderSize = 0
        Me.PdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PdfButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PdfButton.ForeColor = System.Drawing.Color.White
        Me.PdfButton.Image = CType(resources.GetObject("PdfButton.Image"), System.Drawing.Image)
        Me.PdfButton.Location = New System.Drawing.Point(1340, 435)
        Me.PdfButton.Name = "PdfButton"
        Me.PdfButton.Size = New System.Drawing.Size(49, 44)
        Me.PdfButton.TabIndex = 61
        Me.ToolTipPdf.SetToolTip(Me.PdfButton, "Export to Pdf")
        Me.PdfButton.UseVisualStyleBackColor = False
        '
        'StatComboBox
        '
        Me.StatComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatComboBox.FormattingEnabled = True
        Me.StatComboBox.Items.AddRange(New Object() {"Good", "Repair"})
        Me.StatComboBox.Location = New System.Drawing.Point(624, 385)
        Me.StatComboBox.Name = "StatComboBox"
        Me.StatComboBox.Size = New System.Drawing.Size(177, 36)
        Me.StatComboBox.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(465, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 28)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Status"
        '
        'ExcelButton
        '
        Me.ExcelButton.BackColor = System.Drawing.Color.White
        Me.ExcelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExcelButton.FlatAppearance.BorderSize = 0
        Me.ExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExcelButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExcelButton.ForeColor = System.Drawing.Color.White
        Me.ExcelButton.Image = CType(resources.GetObject("ExcelButton.Image"), System.Drawing.Image)
        Me.ExcelButton.Location = New System.Drawing.Point(1285, 435)
        Me.ExcelButton.Name = "ExcelButton"
        Me.ExcelButton.Size = New System.Drawing.Size(49, 44)
        Me.ExcelButton.TabIndex = 65
        Me.ToolTipExcel.SetToolTip(Me.ExcelButton, "Export to Excel")
        Me.ExcelButton.UseVisualStyleBackColor = False
        '
        'PrinterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1739, 914)
        Me.Controls.Add(Me.ExcelButton)
        Me.Controls.Add(Me.StatComboBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PdfButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ModelComboBox)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.IpAddTextBox)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(Me.DeptTextBox)
        Me.Controls.Add(Me.SerialNoTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrinterList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrinterList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ComputerCatButton As Button
    Friend WithEvents MonitorCatButton As Button
    Friend WithEvents PrinteCatButton As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ModelComboBox As ComboBox
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents IpAddTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents DeptTextBox As TextBox
    Friend WithEvents SerialNoTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents MinimizedButton As Button
    Friend WithEvents PdfButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CountLabel As Label
    Friend WithEvents StatComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents ExcelButton As Button
    Friend WithEvents ToolTipDelete As ToolTip
    Friend WithEvents ToolTipUpdate As ToolTip
    Friend WithEvents ToolTipInsert As ToolTip
    Friend WithEvents ToolTipMinimize As ToolTip
    Friend WithEvents ToolTipClear As ToolTip
    Friend WithEvents ToolTipPdf As ToolTip
    Friend WithEvents ToolTipExcel As ToolTip
End Class
