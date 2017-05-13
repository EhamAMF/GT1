Imports System.Windows.Forms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions
Imports System.Net
Imports System.IO




Public Class MDIParent1
    Private m_ChildFormNumber As Integer


    Dim fBackup As New frm_Backgroudjob()
    Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs, Optional ByVal IsVersionChangeBackup As Boolean = False) Handles Me.FormClosing
        Try
            Dim ServerIP As String = GetFileContents(My.Application.Info.DirectoryPath & "\per\ServerIP.dll")

            If ServerIP.Trim = "(local)" Or ServerIP.Trim = "." Then

                If fBackup.Visible = False Then
                    e.Cancel = True
                    fBackup._IsVersionChangeBackup = IsVersionChangeBackup
                    fBackup.StartPosition = FormStartPosition.CenterScreen
                    fBackup.Show()
                    Me.Hide()
                End If
            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            FontMyControl(Me)

            lblUserFullName.Text = PubUserFullName
            lblDate.Text = Format(Now.Date, "yyyy-MM-dd")

            bkHardwareCheck.RunWorkerAsync()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub
    Private Sub MDIParent1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        FontMyControl(Me)
        '  XxxToolStripMenuItem.PerformClick()

    End Sub

    Private Sub bkHardwareCheck_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkHardwareCheck.DoWork
        Try

            Dim Key As String = GetFileContents(My.Application.Info.DirectoryPath & "\per\midhc.dll")
            Dim CurrentHardareID = HardwareID()

            If Key = CurrentHardareID Then
                My.Settings.IsActivated = True
            Else
                My.Settings.IsActivated = False
            End If
            My.Settings.Save()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub bkHardwareCheck_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkHardwareCheck.RunWorkerCompleted
        Try

            If My.Settings.IsActivated = True Then
                Me.Text = "byte - GT1"
            Else
                Me.Text = "byte - GT1 [Demo]"
            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub






    Private Sub Frm_MDI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                SellToolStripMenuItem.PerformClick()
            Case Keys.F8

        End Select

        If e.Modifiers = Keys.Alt + Keys.Shift + Keys.Control Then
            If e.KeyCode = Keys.D AndAlso InputBox("", "") = "byte" Then

            End If

            If e.KeyCode = Keys.B Then


                Settings.InvoiceLayout = InputBox("InvoiceLayout", "InvoiceLayout", Settings.InvoiceLayout)
                Settings.IsPacketDefault = InputBox("IsPacketDefault", "IsPacketDefault", Settings.IsPacketDefault)
                Settings.IsDebug = InputBox("IsDebug", "IsDebug", Settings.IsDebug)

                Settings.HeaderSTR = InputBox("اسم الشركة أو المحل", "اسم الشركة أو المحل", Settings.HeaderSTR)
                Settings.FooterSTR = InputBox("عنوان - هاتف", "عنوان - هاتف", Settings.FooterSTR)
                Settings.TreasuryLayout = InputBox("TreasuryLayout", "TreasuryLayout", Settings.TreasuryLayout)



            End If









        End If


    End Sub






    Private Sub SellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Sell)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub SellRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellRToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Sell_R)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Purchase)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub PurchaseRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseRToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Purchase_R)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub PreSellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreSellToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.PreSale)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub LossToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LossToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Loss)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub IniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.InitialAmount)
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub ShowInvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowInvoicesToolStripMenuItem.Click
        Try
            Dim F As New frm_sp_rpt_invoices
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub ManageProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageProductsToolStripMenuItem.Click
        Try
            Dim F As New frm_ProductStock
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Try
            Dim F As New frm_sp_rpt_Stock
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentMoneyINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentMoneyINToolStripMenuItem.Click

        Try
            Dim F As New frm_Payment(frm_Payment.MoneyDirection.MoneyIn)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub AgentMoneyOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentMoneyOUTToolStripMenuItem.Click
        Try
            Dim F As New frm_Payment(frm_Payment.MoneyDirection.MoneyOut)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub OtherPaymentINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherPaymentINToolStripMenuItem.Click
        Try
            Dim F As New frm_OtherPayment(frm_OtherPayment.MoneyDirection.MoneyIn)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub OtherPaymentOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherPaymentOUTToolStripMenuItem.Click
        Try
            Dim F As New frm_OtherPayment(frm_OtherPayment.MoneyDirection.MoneyIn)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub ExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem.Click

        Try
            Dim F As New frm_Expense
            F.MdiParent = Me
            F.WindowState = FormWindowState.Maximized
            F.Show()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub


    Private Sub AgentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsToolStripMenuItem.Click
        Try
            Dim f As New frm_Agent
            f.MdiParent = Me
            f.Show()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    Private Sub BtnUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateToolStripMenuItem.Click
        Try


            If My.Settings.IsUpdateReady = True Then
                ReadyUpdateExists()
            Else
                Dim ws As New WebServiceUpdateUri.wsSoapClient
                Dim s As String = ws.GetUpdateUrl(PubAppID, PubAppVersion, "")

                If s = "Last Version" Then
                    msgShow("لا يوجد تحديثات لديك اخر اصدار")
                    Exit Sub
                End If

                pb1.Visible = True

                If client.IsBusy = False Then
                    AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                    AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                    If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Update\")) Then
                        System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Update\")
                    End If
                    client.DownloadFileAsync(New Uri(s), My.Application.Info.DirectoryPath & "\Update\Update.zip")
                End If
            End If


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        pb1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            My.Settings.IsUpdateReady = True
            My.Settings.Save()
            ReadyUpdateExists()
        Else
            DeleteFilesFromFolder(My.Application.Info.DirectoryPath & "\Update")
            My.Settings.IsUpdateReady = False
            My.Settings.Save()

        End If

        pb1.Visible = False
    End Sub
    Sub DeleteFilesFromFolder(ByVal Folder As String)
        If Directory.Exists(Folder) Then
            For Each _file As String In Directory.GetFiles(Folder)
                File.Delete(_file)
            Next
            For Each _folder As String In Directory.GetDirectories(Folder)

                DeleteFilesFromFolder(_folder)
            Next

        End If

    End Sub
    Private Sub ReadyUpdateExists()
        Try



            If msgShow("يوجد تحديث جاهز، هل تريد تثبيت التحديث ؟ سوف يتم اعادة تشغيل المنظومة ", Frm_msg.FormType.YesNoNormal) = Windows.Forms.DialogResult.Yes Then
                My.Settings.IsUpdateReady = False
                My.Settings.Save()
                MDIParent1_FormClosing(Me, New FormClosingEventArgs(CloseReason.None, False), True)
            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub











    Private Sub AgentsBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsBalanceToolStripMenuItem.Click
        Try
            Dim f As New frm_sp_rpt_Agents_Balance

            f.MdiParent = Me
            f.Show()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentsLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsLogToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_AgentLog
            f.MdiParent = Me
            f.Show()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub TreasuryLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreasuryLogToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_TreasuryLog
            f.MdiParent = Me
            f.Show()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_Payments
            f.MdiParent = Me
            f.Show()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim f As New frm_sp_rpt_Invoice
            f.MdiParent = Me
            f.Show()
            f.numInvoiceID.Text = "63"

            f.btnView.PerformClick()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        Try
            MyDataManagement.Backup()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub


    Private Sub XxxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



     


    End Sub

    Private Sub XxxToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim F As New frm_ProductBarcode(3878)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Dim client As WebClient = New WebClient





    Private Sub YyyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(HardwareID)

    End Sub




    Private Sub XxxToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frm_sp_rpt_Treasury
        f.Show()

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        If MessageBox.Show("هل أنت متأكد من حدف البيانات الحالية واسترجاع بيانات أخرى", "تحدير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then

            Try
                For Each frm In Me.MdiChildren
                    frm.Close()
                Next
                Dim CurrentPassword As String = MyDataManagement.GetAdminPass
                MyDataManagement.Backup(True)
                MyDataManagement.Restore()
                MyDataManagement.UpdateAdminPass(CurrentPassword)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub

    Private Sub عنالمنظومةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عنالمنظومةToolStripMenuItem.Click
        Dim f As New frm_About
        f.ShowDialog()

    End Sub

    Private Sub XxxToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As String

        s = AllHardwareInfo()

        MessageBox.Show(s)



    End Sub

    Private Sub HWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HWToolStripMenuItem.Click
        Dim s As String

        s = AllHardwareInfo()

        MessageBox.Show(s)
    End Sub
End Class
