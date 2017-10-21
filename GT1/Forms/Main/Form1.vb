Imports System.Windows.Forms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions
Imports System.Net
Imports System.IO




Public Class FrmMain

    


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try



            FontMyControl(Me)

            Timer1.Enabled = True
            Timer1_Tick(Me, Nothing)
            lblUserName.Text = PubUserName
            bkHardwareCheck.RunWorkerAsync()

            tbMain_SelectedIndexChanged(Me, Nothing)


            AddLabelHandlers()





        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Dim fBackup As New frm_Backgroudjob()
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs, Optional ByVal IsVersionChangeBackup As Boolean = False) Handles Me.FormClosing
        Try
            Dim ServerIP As String = GetFileContents(My.Application.Info.DirectoryPath & "\per\ServerIP.dll")



            If fBackup.Visible = False Then
                e.Cancel = True
                fBackup._IsVersionChangeBackup = IsVersionChangeBackup
                fBackup.StartPosition = FormStartPosition.CenterScreen
                fBackup.Show()
                Me.Hide()

            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

                Settings.IsDebug = InputBox("IsDebug", "IsDebug", Settings.IsDebug)

                Settings.HeaderSTR = InputBox("اسم الشركة أو المحل", "اسم الشركة أو المحل", Settings.HeaderSTR)
                Settings.FooterSTR = InputBox("عنوان - هاتف", "عنوان - هاتف", Settings.FooterSTR)
                Settings.TreasuryLayout = InputBox("TreasuryLayout", "TreasuryLayout", Settings.TreasuryLayout)
                Settings.ModifyAllowedTime = InputBox("ModifyAllowedTime", "ModifyAllowedTime", Settings.ModifyAllowedTime)

                Settings.IsProductDetailsShown = InputBox("IsProductDetailsShown", "IsProductDetailsShown", Settings.IsProductDetailsShown)
                Settings.IsProductCodeShown = InputBox("IsProductCodeShown", "IsProductCodeShown", Settings.IsProductCodeShown)
                Settings.IsBarcodeShown = InputBox("IsBarcodeShown", "IsBarcodeShown", Settings.IsBarcodeShown)
                Settings.IsRackShown = InputBox("IsRackShown", "IsRackShown", Settings.IsRackShown)

                Settings.IsPacketSystem = InputBox("IsPacketSystem", "IsPacketSystem", Settings.IsPacketSystem)
                Settings.IsPacketDefault = InputBox("IsPacketDefault", "IsPacketDefault", Settings.IsPacketDefault)

                Settings.IsExDateShown = InputBox("IsExDateShown", "IsExDateShown", Settings.IsExDateShown)




            End If









        End If
    End Sub








    Public Sub AddForm(ByVal F As Form)

        tbMain.Visible = True
        Dim page = New TabPage()
        page.RightToLeft = Windows.Forms.RightToLeft.Inherit



        F.TopLevel = False
        F.TopMost = False
        F.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        F.WindowState = FormWindowState.Normal
        F.Dock = DockStyle.Fill
        '  F.StartPosition = FormStartPosition.CenterParent

        page.Controls.Add(F)

        tbMain.TabPages.Add(page)
        tbMain.SelectedTab = page
        F.Show()
        page.Text = F.Text
        AddHandler F.TextChanged, AddressOf F_TextChanged


        tbMain_SelectedIndexChanged(Me, Nothing)


    End Sub
    Private Sub F_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim Form As Form = sender

            Dim TabPage As TabPage = Form.Parent

            TabPage.Text = Form.Text



            TabCloseToolStripMenuItem.Text = "إغلاق " & Form.Text

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try



    End Sub
    Private Sub RemoveTab(ByVal Tab As TabPage)

        If IsNumeric(tbMain.TabPages.IndexOf(Tab)) AndAlso tbMain.TabPages.IndexOf(Tab) = 0 Then
            Return
        End If



        For Each c As Form In Tab.Controls
            Try
                DirectCast(c, Form).Close()
            Catch ex As Exception
            End Try
        Next



        tbMain.TabPages.Remove(Tab)
        Tab.Dispose()

        If tbMain.TabPages.Count = 0 Then
            tbMain.Visible = False
        End If




    End Sub
    Private Sub tbMain_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbMain.Click


        If e.Button = Windows.Forms.MouseButtons.Middle Then
            For n = 0 To tbMain.TabPages.Count - 1

                If (tbMain.GetTabRect(n).Contains(e.Location)) Then

                    RemoveTab(tbMain.TabPages(n))


                    Exit For

                End If
            Next


        End If






    End Sub
    Private Sub tbMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMain.SelectedIndexChanged
        Try


            If IsNumeric(tbMain.SelectedIndex) Then

                TabCloseToolStripMenuItem.Text = "إغلاق " & tbMain.TabPages((tbMain.SelectedIndex)).Text

                If tbMain.SelectedIndex = 0 Then
                    TabCloseToolStripMenuItem.Visible = False
                Else
                    TabCloseToolStripMenuItem.Visible = True
                End If


            End If


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub
    Private Sub TabCloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabCloseToolStripMenuItem.Click
        Try
            If Not IsNothing(tbMain.SelectedTab) Then
                RemoveTab(tbMain.SelectedTab)
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub TabCloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabCloseAllToolStripMenuItem.Click
        Try
            For Each TAB As TabPage In tbMain.TabPages
                RemoveTab(TAB)

            Next
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Private Sub SellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Sell)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub SellRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellRToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Sell_R)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Purchase)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub PurchaseRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseRToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Purchase_R)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub PreSellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreSellToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.PreSale)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub LossToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LossToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.Loss)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub IniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniToolStripMenuItem.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.InitialAmount)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub StockBalanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBalanceToolStripMenuItem1.Click
        Try
            Dim F As New Frm_Invoice(Frm_Invoice.InvoiceTypes.StockBalance)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ShowInvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowInvoicesToolStripMenuItem.Click
        Try
            Dim F As New frm_sp_rpt_invoices
            AddForm(F)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ManageProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageProductsToolStripMenuItem.Click
        Try
            Dim F As New frm_ProductStock
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub ServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesToolStripMenuItem.Click
        Try
            Dim f As New frm_Service
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Try
            Dim F As New frm_sp_rpt_Stock
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsToolStripMenuItem.Click
        Try
            Dim f As New frm_Agent
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentsBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsBalanceToolStripMenuItem.Click
        Dim f As New frm_sp_rpt_Agents_Balance
        AddForm(f)
    End Sub

    Private Sub AgentsLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentsLogToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_AgentLog
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentMoneyINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentMoneyINToolStripMenuItem.Click
        Try
            Dim F As New frm_Payment(frm_Payment.MoneyDirection.MoneyIn)
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentMoneyOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentMoneyOUTToolStripMenuItem.Click
        Try
            Dim F As New frm_Payment(frm_Payment.MoneyDirection.MoneyOut)
            AddForm(F)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem.Click
        Try
            Dim F As New frm_Expense
            AddForm(F)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub OtherPaymentINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherPaymentINToolStripMenuItem.Click
        Try
            Dim F As New frm_OtherPayment(frm_OtherPayment.MoneyDirection.MoneyIn)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub OtherPaymentOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherPaymentOUTToolStripMenuItem.Click
        Try
            Dim F As New frm_OtherPayment(frm_OtherPayment.MoneyDirection.MoneyOut)
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub TreasuryLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreasuryLogToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_TreasuryLog
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_Payments
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub حركةصنفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حركةصنفToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_ProductLog
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentBalanceToolStripMenuItem.Click
        Try
            Dim f As New frm_sp_rpt_Agents_Balance

            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub AgentLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentLogToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_AgentLog
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub TreasuryLogToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreasuryLogToolStripMenuItem1.Click
        Try

            Dim f As New frm_sp_rpt_TreasuryLog
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub SalesCashFlowConcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCashFlowConcToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_SalesCashFlowConc
            AddForm(f)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ProfitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfitsToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_InvoicesRev
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub قيمةالمخزونToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قيمةالمخزونToolStripMenuItem.Click
        Try

            Dim f As New frm_sp_rpt_StockValue
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ExpensesCostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesCostToolStripMenuItem.Click
        Try
            Dim f As New frm_sp_rpt_Expenses
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ExpenseLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenseLogToolStripMenuItem.Click
        Try
            Dim f As New frm_sp_rpt_ExpenseLog
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub NewYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BackupToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        Try
            MyDataManagement.Backup()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        If msgShow("هل أنت متأكد من حدف البيانات الحالية واسترجاع بيانات أخرى", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then


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


    Dim client As WebClient = New WebClient
    Private Sub BtnUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateToolStripMenuItem.Click
        Try


            If My.Settings.IsUpdateReady = True Then
                ReadyUpdateExists()
            Else
                'Dim ws As New WebServiceUpdateUri.wsSoapClient
                Dim ws As New WebServiceMyUpdate.MyUpdateSoapClient
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
            HandleMyError(ex, , , Settings.IsDebug)
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
                Form1_FormClosing(Me, New FormClosingEventArgs(CloseReason.None, False), True)
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub bkHardwareCheck_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkHardwareCheck.DoWork

    End Sub
    Private Sub bkHardwareCheck_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkHardwareCheck.RunWorkerCompleted
        Try

            If My.Settings.IsActivated = True Then
                Me.Text = "byte - GT1"
            Else
                Me.Text = "byte - GT1 [Demo]"
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

            Dim SDateTime = Format(Now, "hh:mm   dd-MM-yyyy ")
            lblDate.Text = SDateTime
            lblDate2.Text = Format(Now, "dd-MM-yyyy ")
            lblTime.Text = Format(Now, "hh:mm")



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    Private Sub AddLabelHandlers()
        AddHandler lblSales.MouseEnter, AddressOf lblSales_Enter
        AddHandler lblPurchase.MouseEnter, AddressOf lblSales_Enter
        AddHandler lblProducts.MouseEnter, AddressOf lblSales_Enter
        AddHandler lblAgents.MouseEnter, AddressOf lblSales_Enter
        AddHandler lblAgentMoneyIn.MouseEnter, AddressOf lblSales_Enter
        AddHandler lblStock.MouseEnter, AddressOf lblSales_Enter

        AddHandler lblSales.MouseLeave, AddressOf lblSales_Leave
        AddHandler lblPurchase.MouseLeave, AddressOf lblSales_Leave
        AddHandler lblProducts.MouseLeave, AddressOf lblSales_Leave
        AddHandler lblAgents.MouseLeave, AddressOf lblSales_Leave
        AddHandler lblAgentMoneyIn.MouseLeave, AddressOf lblSales_Leave
        AddHandler lblStock.MouseLeave, AddressOf lblSales_Leave
    End Sub
    Private Sub lblSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSales.Click
        SellToolStripMenuItem.PerformClick()
    End Sub
    Private Sub lblPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPurchase.Click
        PurchaseToolStripMenuItem.PerformClick()
    End Sub
    Private Sub lblProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProducts.Click
        ManageProductsToolStripMenuItem.PerformClick()
    End Sub
    Private Sub lblAgents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAgents.Click
        AgentsToolStripMenuItem.PerformClick()
    End Sub
    Private Sub lblAgentMoneyIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAgentMoneyIn.Click
        AgentMoneyINToolStripMenuItem.PerformClick()
    End Sub
    Private Sub lblStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStock.Click
        StockToolStripMenuItem.PerformClick()
    End Sub

    Private Sub lblSales_Enter(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim o As Object = ""
        Dim lbl As Label = sender


        lbl.Font = New Font(lbl.Font.Name, lbl.Font.Size + 4)


    End Sub
    Private Sub lblSales_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim o As Object = ""
        Dim lbl As Label = sender


        lbl.Font = New Font(lbl.Font.Name, lbl.Font.Size - 4)


    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Try
            Dim webAddress As String = "http://byte.com.ly/"
            Process.Start(webAddress)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub عنالمنظومةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عنالمنظومةToolStripMenuItem.Click
        Try
            Dim f As New frm_About
            f.ShowDialog()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        Try

            Dim f As New frm_Users
            AddForm(f)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub اعدادتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اعدادتToolStripMenuItem.Click
        Try
            Dim F As New frm_Settings
            ' F.MdiParent = Me
            F.WindowState = FormWindowState.Normal
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



    Private Sub ActivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateToolStripMenuItem.Click
        Try
            Dim f As New frm_Activation
            f.StartPosition = FormStartPosition.CenterParent
            f.WindowState = FormWindowState.Normal
            f.ShowDialog()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub ResestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResestToolStripMenuItem.Click
        If msgShow("هل أنت متأكد من حدف البيانات الحالية وإعدة الضبط ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then


            Try

                TabCloseAllToolStripMenuItem.PerformClick()

                Dim CurrentPassword As String = MyDataManagement.GetAdminPass
                MyDataManagement.Backup(True)
                MyDataManagement.Reset2()
                MyDataManagement.UpdateAdminPass(CurrentPassword)
                msgShow("تم !", Frm_msg.FormType.msgDone)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub


    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ws As New ServiceReference2.MyUpdateSoapClient
        'Dim s As String = ws.mytest()

        'MessageBox.Show(s)

    End Sub


End Class