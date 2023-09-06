<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.ComputerCatButton = New System.Windows.Forms.Button()
        Me.MonitorCatButton = New System.Windows.Forms.Button()
        Me.PrinteCatButton = New System.Windows.Forms.Button()
        Me.DashboardButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MinimizedButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HardwareListButton = New System.Windows.Forms.Button()
        Me.PrinterListButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrinterCountLabel = New System.Windows.Forms.Label()
        Me.PrinterPanel = New System.Windows.Forms.Panel()
        Me.UserPanel = New System.Windows.Forms.Panel()
        Me.UserCountLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HardwarePanel = New System.Windows.Forms.Panel()
        Me.RepairLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.HardwareCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.KlgLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.AicLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SvclLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.FormButton = New System.Windows.Forms.Button()
        Me.ToolTipMinimize = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrinterPanel.SuspendLayout()
        Me.UserPanel.SuspendLayout()
        Me.HardwarePanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EmployeeButton)
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.AboutButton)
        Me.Panel1.Controls.Add(Me.ComputerCatButton)
        Me.Panel1.Controls.Add(Me.MonitorCatButton)
        Me.Panel1.Controls.Add(Me.PrinteCatButton)
        Me.Panel1.Controls.Add(Me.DashboardButton)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 1052)
        Me.Panel1.TabIndex = 3
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
        Me.EmployeeButton.Size = New System.Drawing.Size(339, 55)
        Me.EmployeeButton.TabIndex = 8
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
        Me.LogoutButton.Location = New System.Drawing.Point(0, 993)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LogoutButton.Size = New System.Drawing.Size(339, 59)
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
        Me.AboutButton.Location = New System.Drawing.Point(0, 482)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AboutButton.Size = New System.Drawing.Size(339, 55)
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
        Me.ComputerCatButton.Size = New System.Drawing.Size(339, 55)
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
        Me.MonitorCatButton.Size = New System.Drawing.Size(339, 55)
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
        Me.PrinteCatButton.Size = New System.Drawing.Size(339, 55)
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
        Me.DashboardButton.Size = New System.Drawing.Size(339, 55)
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
        Me.Panel4.Size = New System.Drawing.Size(339, 153)
        Me.Panel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 48)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MinimizedButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(339, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1530, 48)
        Me.Panel3.TabIndex = 4
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
        Me.MinimizedButton.Location = New System.Drawing.Point(1472, 0)
        Me.MinimizedButton.Name = "MinimizedButton"
        Me.MinimizedButton.Size = New System.Drawing.Size(58, 48)
        Me.MinimizedButton.TabIndex = 63
        Me.ToolTipMinimize.SetToolTip(Me.MinimizedButton, "Minimize")
        Me.MinimizedButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TimeLabel.Location = New System.Drawing.Point(1745, 68)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(65, 31)
        Me.TimeLabel.TabIndex = 16
        Me.TimeLabel.Text = "Time"
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateLabel.Location = New System.Drawing.Point(1474, 68)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(63, 31)
        Me.DateLabel.TabIndex = 15
        Me.DateLabel.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(1696, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 57)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(1414, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 57)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'HardwareListButton
        '
        Me.HardwareListButton.BackColor = System.Drawing.Color.Chartreuse
        Me.HardwareListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HardwareListButton.FlatAppearance.BorderSize = 0
        Me.HardwareListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HardwareListButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HardwareListButton.ForeColor = System.Drawing.Color.White
        Me.HardwareListButton.Image = CType(resources.GetObject("HardwareListButton.Image"), System.Drawing.Image)
        Me.HardwareListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HardwareListButton.Location = New System.Drawing.Point(868, 229)
        Me.HardwareListButton.Name = "HardwareListButton"
        Me.HardwareListButton.Size = New System.Drawing.Size(456, 205)
        Me.HardwareListButton.TabIndex = 14
        Me.HardwareListButton.Text = "Hardware List"
        Me.HardwareListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HardwareListButton.UseVisualStyleBackColor = False
        '
        'PrinterListButton
        '
        Me.PrinterListButton.BackColor = System.Drawing.Color.DarkMagenta
        Me.PrinterListButton.FlatAppearance.BorderSize = 0
        Me.PrinterListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrinterListButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PrinterListButton.ForeColor = System.Drawing.Color.White
        Me.PrinterListButton.Image = CType(resources.GetObject("PrinterListButton.Image"), System.Drawing.Image)
        Me.PrinterListButton.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.PrinterListButton.Location = New System.Drawing.Point(382, 229)
        Me.PrinterListButton.Name = "PrinterListButton"
        Me.PrinterListButton.Size = New System.Drawing.Size(456, 205)
        Me.PrinterListButton.TabIndex = 13
        Me.PrinterListButton.Text = "Printer List"
        Me.PrinterListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrinterListButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(94, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 38)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total Printer"
        '
        'PrinterCountLabel
        '
        Me.PrinterCountLabel.AutoSize = True
        Me.PrinterCountLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PrinterCountLabel.ForeColor = System.Drawing.Color.White
        Me.PrinterCountLabel.Location = New System.Drawing.Point(124, -4)
        Me.PrinterCountLabel.Name = "PrinterCountLabel"
        Me.PrinterCountLabel.Size = New System.Drawing.Size(101, 120)
        Me.PrinterCountLabel.TabIndex = 20
        Me.PrinterCountLabel.Text = "0"
        '
        'PrinterPanel
        '
        Me.PrinterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.PrinterPanel.Controls.Add(Me.PrinterCountLabel)
        Me.PrinterPanel.Controls.Add(Me.Label8)
        Me.PrinterPanel.Location = New System.Drawing.Point(758, 523)
        Me.PrinterPanel.Name = "PrinterPanel"
        Me.PrinterPanel.Size = New System.Drawing.Size(359, 197)
        Me.PrinterPanel.TabIndex = 21
        '
        'UserPanel
        '
        Me.UserPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserPanel.Controls.Add(Me.UserCountLabel)
        Me.UserPanel.Controls.Add(Me.Label3)
        Me.UserPanel.Location = New System.Drawing.Point(1510, 523)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(359, 197)
        Me.UserPanel.TabIndex = 23
        '
        'UserCountLabel
        '
        Me.UserCountLabel.AutoSize = True
        Me.UserCountLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserCountLabel.ForeColor = System.Drawing.Color.White
        Me.UserCountLabel.Location = New System.Drawing.Point(102, 0)
        Me.UserCountLabel.Name = "UserCountLabel"
        Me.UserCountLabel.Size = New System.Drawing.Size(101, 120)
        Me.UserCountLabel.TabIndex = 22
        Me.UserCountLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(78, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 38)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total Active User"
        '
        'HardwarePanel
        '
        Me.HardwarePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.HardwarePanel.Controls.Add(Me.RepairLabel)
        Me.HardwarePanel.Controls.Add(Me.Label4)
        Me.HardwarePanel.Location = New System.Drawing.Point(1134, 523)
        Me.HardwarePanel.Name = "HardwarePanel"
        Me.HardwarePanel.Size = New System.Drawing.Size(359, 197)
        Me.HardwarePanel.TabIndex = 22
        '
        'RepairLabel
        '
        Me.RepairLabel.AutoSize = True
        Me.RepairLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RepairLabel.ForeColor = System.Drawing.Color.White
        Me.RepairLabel.Location = New System.Drawing.Point(119, -4)
        Me.RepairLabel.Name = "RepairLabel"
        Me.RepairLabel.Size = New System.Drawing.Size(101, 120)
        Me.RepairLabel.TabIndex = 24
        Me.RepairLabel.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 38)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Total Under Maintenance"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel5.Controls.Add(Me.HardwareCountLabel)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(382, 523)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(359, 197)
        Me.Panel5.TabIndex = 24
        '
        'HardwareCountLabel
        '
        Me.HardwareCountLabel.AutoSize = True
        Me.HardwareCountLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HardwareCountLabel.ForeColor = System.Drawing.Color.White
        Me.HardwareCountLabel.Location = New System.Drawing.Point(96, -4)
        Me.HardwareCountLabel.Name = "HardwareCountLabel"
        Me.HardwareCountLabel.Size = New System.Drawing.Size(101, 120)
        Me.HardwareCountLabel.TabIndex = 24
        Me.HardwareCountLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 38)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Total Hardware"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel6.Controls.Add(Me.KlgLabel)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(382, 813)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(359, 197)
        Me.Panel6.TabIndex = 25
        '
        'KlgLabel
        '
        Me.KlgLabel.AutoSize = True
        Me.KlgLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.KlgLabel.ForeColor = System.Drawing.Color.White
        Me.KlgLabel.Location = New System.Drawing.Point(96, 0)
        Me.KlgLabel.Name = "KlgLabel"
        Me.KlgLabel.Size = New System.Drawing.Size(101, 120)
        Me.KlgLabel.TabIndex = 24
        Me.KlgLabel.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(115, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 38)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "KLUANG"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel7.Controls.Add(Me.AicLabel)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(758, 813)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(359, 197)
        Me.Panel7.TabIndex = 26
        '
        'AicLabel
        '
        Me.AicLabel.AutoSize = True
        Me.AicLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AicLabel.ForeColor = System.Drawing.Color.White
        Me.AicLabel.Location = New System.Drawing.Point(124, 0)
        Me.AicLabel.Name = "AicLabel"
        Me.AicLabel.Size = New System.Drawing.Size(101, 120)
        Me.AicLabel.TabIndex = 24
        Me.AicLabel.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(150, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 38)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "AIC"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel8.Controls.Add(Me.SvclLabel)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(1134, 813)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(359, 197)
        Me.Panel8.TabIndex = 27
        '
        'SvclLabel
        '
        Me.SvclLabel.AutoSize = True
        Me.SvclLabel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SvclLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SvclLabel.Location = New System.Drawing.Point(119, 0)
        Me.SvclLabel.Name = "SvclLabel"
        Me.SvclLabel.Size = New System.Drawing.Size(101, 120)
        Me.SvclLabel.TabIndex = 24
        Me.SvclLabel.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(142, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 38)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "SVCL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(382, 759)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(358, 38)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Hardware Sort by Location"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(382, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 38)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "General"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(382, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 38)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Main Menu"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), System.Drawing.Image)
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(1052, 54)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(356, 99)
        Me.Panel9.TabIndex = 31
        '
        'FormButton
        '
        Me.FormButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.FormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FormButton.FlatAppearance.BorderSize = 0
        Me.FormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormButton.ForeColor = System.Drawing.Color.White
        Me.FormButton.Image = CType(resources.GetObject("FormButton.Image"), System.Drawing.Image)
        Me.FormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FormButton.Location = New System.Drawing.Point(1354, 229)
        Me.FormButton.Name = "FormButton"
        Me.FormButton.Size = New System.Drawing.Size(456, 205)
        Me.FormButton.TabIndex = 32
        Me.FormButton.Text = "Dekstop/Laptop Form"
        Me.FormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FormButton.UseVisualStyleBackColor = False
        Me.FormButton.Visible = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LogoutButton
        Me.ClientSize = New System.Drawing.Size(1869, 1052)
        Me.Controls.Add(Me.FormButton)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.UserPanel)
        Me.Controls.Add(Me.HardwarePanel)
        Me.Controls.Add(Me.PrinterPanel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.HardwareListButton)
        Me.Controls.Add(Me.PrinterListButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrinterPanel.ResumeLayout(False)
        Me.PrinterPanel.PerformLayout()
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        Me.HardwarePanel.ResumeLayout(False)
        Me.HardwarePanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ComputerCatButton As Button
    Friend WithEvents MonitorCatButton As Button
    Friend WithEvents PrinteCatButton As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MinimizedButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HardwareListButton As Button
    Friend WithEvents PrinterListButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PrinterCountLabel As Label
    Friend WithEvents PrinterPanel As Panel
    Friend WithEvents UserPanel As Panel
    Friend WithEvents UserCountLabel As Label
    Friend WithEvents HardwarePanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RepairLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HardwareCountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents KlgLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents AicLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SvclLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents FormButton As Button
    Friend WithEvents ToolTipMinimize As ToolTip
End Class
