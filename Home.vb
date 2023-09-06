Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging

Public Class Home

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hos")

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to logout", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub HardwareListButton_Click(sender As Object, e As EventArgs) Handles HardwareListButton.Click
        HardwareList.ShowDialog()
    End Sub

    Private Sub PrinterListButton_Click(sender As Object, e As EventArgs) Handles PrinterListButton.Click
        PrinterList.ShowDialog()
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

    'Private Sub MaintenanceButton_Click(sender As Object, e As EventArgs)
    '    Maintenance.ShowDialog()

    'End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub

    Private Sub MinimizedButton_Click(sender As Object, e As EventArgs) Handles MinimizedButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = Date.Now.ToString("dd MMMM yyyy")
        TimeLabel.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        totalPrinter()
        totalUser()
        totalHardware()
        totalRepair()
        totalKlg()
        totalAic()
        totalSvcl()

        'transparent panel
        Panel9.BackColor = Color.FromArgb(50, 255, 255, 255)

    End Sub

    Sub totalPrinter()

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM printerdetail", connection)
            connection.Open()
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            PrinterCountLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalUser()

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM hardware WHERE userStatus = 'Active' ", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            UserCountLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalHardware()
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM hardware", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            HardwareCountLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalRepair()
        ' SELECT
        '(select count(*) from foo1 where ID = '00123244552000258')
        '+
        '(select count(*) from foo2 where ID = '00123244552000258')
        '+
        '(select count(*) from foo3 where ID = '00123244552000258')
        Using cmd As New MySqlCommand("SELECT (SELECT COUNT(*) FROM hardware WHERE status = 'Repair') + (SELECT COUNT(*) FROM printerdetail WHERE status = 'Repair')", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            RepairLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalKlg()

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM hardware WHERE location = 'KLG' OR 'KLUANG' ", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            KlgLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalAic()

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM hardware WHERE location = 'AIC' ", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            AicLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Sub totalSvcl()

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM hardware WHERE location = 'SVCL' ", connection)

            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            SvclLabel.Text = String.Format("{0}", count)

        End Using
    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        ManageEmployee.ShowDialog()
    End Sub



    Private Sub FormButton_Click(sender As Object, e As EventArgs) Handles FormButton.Click
        LaptopDekstopForm.ShowDialog()
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click

    End Sub

End Class