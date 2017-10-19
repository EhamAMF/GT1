'frm_sp_rpt_Payments
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_Payments

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim TreasuryNumber As Object
    Dim AccountID As Object
    Dim MoneyDirectionID As Object
    Dim DateFrom As Object
    Dim DateTo As Object



    Private Sub frm_sp_rpt_Payments_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_Payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)
            dtpDateFrom.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
            dtpDateTo.Value = dtpDateFrom.Value.AddDays(1)

            GetInitialData()
            lblTitle.Text = Me.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try


    End Sub

    Enum RequestType
        dgv = 1
        rdlc = 2
        print = 3
    End Enum
    Enum Column
        TreasuryID
        TreasuryNumber
        PaymentDate
        MoneyDirectionID
        Info
        PaymentAmount
        Note
        InvoiceID
        PaymentID
        ExpenseID
        OtherPaymentID

    End Enum

#Region "       Subs and Functions"


    Private Function MyConvert(ByVal var As Object) As Object
        Dim out As Object



        If IsNothing(var) Then
            out = DBNull.Value
        ElseIf IsDBNull(var) Then
            out = DBNull.Value
        ElseIf IsNumeric(var) Then

            out = Val(var)

        ElseIf TypeOf var Is String Then
            If var.ToString.Trim = "" Then out = DBNull.Value
        Else : out = var
        End If




        Return out
    End Function
    Private Sub FormatSumRow()
        If MyBs.Find("IsSum", 1) >= 0 Then
            dgv.Rows(MyBs.Find("IsSum", 1)).DefaultCellStyle.BackColor = Color.LightGray
            Dim f As New Font(dgv.DefaultCellStyle.Font.FontFamily.Name, dgv.DefaultCellStyle.Font.Size, FontStyle.Bold)
            dgv.Rows(MyBs.Find("IsSum", 1)).DefaultCellStyle.Font = f
        End If

    End Sub
    Private Sub DgvDecimalFormat()
        Dim TargetDecCols As New List(Of Column)

        With TargetDecCols
            '.Add(Column.PaymentAmount)

        End With

        For Each i In TargetDecCols
            dgv.Columns(i.ToString).DefaultCellStyle.Format = "#,##0.00#"
        Next
    End Sub
    Private Sub GetTotal()
        Dim DT As DataTable = dgv.DataSource.DataSource



        If DT.Rows.Count > 0 Then

            Dim TargetSumCols As New List(Of Column)

            With TargetSumCols
                .Add(Column.PaymentAmount)

            End With


            If TargetSumCols.Count > 0 Then
                DT.Rows.Add()

                For Each i In TargetSumCols
                    DT.Rows(DT.Rows.Count - 1).Item(i.ToString) = 0
                Next



                For n = 0 To DT.Rows.Count - 2
                    For Each i In TargetSumCols
                        DT.Rows(DT.Rows.Count - 1).Item(i.ToString) = DT.Rows(DT.Rows.Count - 1).Item(i.ToString) + IIf(IsDBNull(DT.Rows(n).Item(i.ToString)) = True, 0, DT.Rows(n).Item(i.ToString))
                    Next
                Next

                DT.Rows(DT.Rows.Count - 1).Item("IsSum") = 1



                IsSumExist = True
            End If
        End If
    End Sub
    Private Sub GetInitialData()
        Get_sp_hlp_ِAccount()
        Get_sp_hlp_MoneyDirection()

    End Sub
    Private Sub Get_sp_hlp_ِAccount()

        Dim da As New SqlDataAdapter("sp_hlp_ِAccount", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboAccountID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "AccountID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AcountName", True, "")
            .MyBeginProcess()
        End With

    End Sub
    Private Sub Get_sp_hlp_MoneyDirection()

        Dim da As New SqlDataAdapter("sp_hlp_MoneyDirection", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboMoneyDirectionID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "MoneyDirectionID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "MoneyDirectionName", True, "")
            .MyBeginProcess()
        End With

    End Sub

    Private Function fn_sp_rpt_Payments(ByRef TreasuryNumber As Object, ByRef AccountID As Object, ByRef MoneyDirectionID As Object, ByRef DateFrom As Object, ByRef DateTo As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Payments", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@TreasuryNumber", TreasuryNumber)
            .AddWithValue("@AccountID", AccountID)
            .AddWithValue("@MoneyDirectionID", MoneyDirectionID)
            .AddWithValue("@DateFrom", DateFrom)
            .AddWithValue("@DateTo", DateTo)

        End With

        With da.SelectCommand




        End With

        da.Fill(dt)

        With da.SelectCommand

        End With

        Return dt
    End Function

    'xx__subs and Functions__xx

    Private Sub SetInputParameters()
        'ItemTypeID = MyConvert(cboItemTypeID.SelectedValue)
        'AgentID = MyConvert(cboAgentID.SelectedValue)
        'TypeID = MyConvert(cboTypeID.SelectedValue)
        'BrandID = MyConvert(cboBrandID.SelectedValue)
        'DateFrm = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateFrm.Value)
        'DateTo = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateTo.Value)

        TreasuryNumber = MyConvert(numTreasuryNumber.Text.Trim)
        AccountID = MyConvert(cboAccountID.MySelectedValue)
        MoneyDirectionID = MyConvert(cboMoneyDirectionID.MySelectedValue)
        DateFrom = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateFrom.Value)
        DateTo = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateTo.Value)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_Payments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F8
                    'btnView.PerformClick()
                Case Keys.F9
                    'btnPrint.PerformClick()
                Case Keys.F7
                    btnShowHideSearch.PerformClick()
            End Select
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnShowHideSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHideSearch.Click
        Try
            If SplitContainer1.Panel1Collapsed = True Then
                SplitContainer1.Panel1Collapsed = False
                btnShowHideSearch.Image = My.Resources.Resources.SHR
            Else
                SplitContainer1.Panel1Collapsed = True
                btnShowHideSearch.Image = My.Resources.Resources.SHL
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If bw1.IsBusy = False Then
                req = RequestType.print
                'btnSearch.Text = "الرجاء الانتظار قليلا"
                'PictureBox1.Visible = True
                btnSearch.Text = "الرجاء الانتظار قليلا"
                Picturebox1.Visible = True

                SetInputParameters()
                bw1.RunWorkerAsync()
            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If bw1.IsBusy = False Then
                req = RequestType.rdlc
                ' btnSearch.Text = "الرجاء الانتظار قليلا"
                '  PictureBox1.Visible = True
                btnSearch.Text = "الرجاء الانتظار قليلا"
                Picturebox1.Visible = True

                SetInputParameters()
                bw1.RunWorkerAsync()
            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            If bw1.IsBusy = False Then
                req = RequestType.dgv
                'btnSearch.Text = "الرجاء الانتظار قليلا"
                ' PictureBox1.Visible = True
                btnSearch.Text = "الرجاء الانتظار قليلا"
                PictureBox1.Visible = True

                SetInputParameters()
                bw1.RunWorkerAsync()
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub dgv_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Sorted

        Try
            If Not IsNothing(MyBs.Sort) AndAlso MyBs.Sort.Contains(" Asc") = True Then
                MyBs.Sort = "IsSum , " & dgv.SortedColumn.Name & " Desc"
            Else
                MyBs.Sort = "IsSum , " & dgv.SortedColumn.Name & " Asc"
            End If
            FormatSumRow()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try


    End Sub
    Private Sub chkAllPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllPeriod.CheckedChanged
        Try
            dtpDateFrom.Enabled = Not chkAllPeriod.Checked
            dtpDateTo.Enabled = Not chkAllPeriod.Checked
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try


            If Not IsNothing(MyBs.Current) Then



                If IsNumeric(MyBs.Current("PaymentID")) Then

                    Dim ID As Long = MyBs.Current("PaymentID")
                    Dim f As New frm_Payment(ID)
                    'f.MdiParent = Me.MdiParent
                    FrmMain.AddForm(f)





                ElseIf IsNumeric(MyBs.Current("OtherPaymentID")) Then

                    Dim ID As Long = MyBs.Current("OtherPaymentID")
                    Dim f As New frm_OtherPayment(ID)
                    'f.MdiParent = Me.MdiParent
                    FrmMain.AddForm(f)



                ElseIf IsNumeric(MyBs.Current("ExpenseID")) Then

                    Dim ID As Long = MyBs.Current("ExpenseID")
                    Dim f As New frm_Expense(ID)
                    FrmMain.AddForm(f)



                ElseIf IsNumeric(MyBs.Current("InvoiceID")) Then

                    Dim ID As Long = MyBs.Current("InvoiceID")
                    Dim f As New Frm_Invoice(ID)
                    FrmMain.AddForm(f)

                End If





            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub


    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_Payments(TreasuryNumber, AccountID, MoneyDirectionID, DateFrom, DateTo)
            If bw1.CancellationPending = True Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try


    End Sub
    Private Sub bw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw1.RunWorkerCompleted
        Try

            'btnSearch.Text = "عرض"
            'PictureBox1.Visible = False
            btnSearch.Text = "عرض"
            PictureBox1.Visible = False


            If IsBW1Canseled = False Then
                If req = RequestType.dgv Then
                    MyTable1.Columns.Add("IsSum", Type.GetType("System.Int32"))
                    MyTable1.Columns("IsSum").SetOrdinal(0)

                    MyBs.DataSource = MyTable1
                    dgv.DataSource = MyBs

                    dgv.Columns("IsSum").Visible = False


                    dgv.Columns("TreasuryID").HeaderText = ""
                    dgv.Columns("TreasuryNumber").HeaderText = "رقم الايصال"
                    dgv.Columns("PaymentDate").HeaderText = "التاريخ"
                    dgv.Columns("MoneyDirectionID").HeaderText = "المعاملة"
                    dgv.Columns("Info").HeaderText = "البيان"
                    dgv.Columns("PaymentAmount").HeaderText = "القيمة"
                    dgv.Columns("Note").HeaderText = "ملاحظة"
                    dgv.Columns("InvoiceID").HeaderText = "رقم الفاتورة"
                    dgv.Columns("PaymentID").HeaderText = "رقم الايصال"
                    dgv.Columns("ExpenseID").HeaderText = "ر.م"
                    dgv.Columns("OtherPaymentID").HeaderText = "ر.م"

                    dgv.Columns("TreasuryID").Visible = False
                    dgv.Columns("MoneyDirectionID").Visible = False
                    dgv.Columns("PaymentID").Visible = False
                    dgv.Columns("InvoiceID").Visible = False
                    dgv.Columns("ExpenseID").Visible = False
                    dgv.Columns("OtherPaymentID").Visible = False


                    'GetTotal()
                    DgvDecimalFormat()
                    FormatSumRow()
                    lblCount.Text = MyBs.Count - 1

                    For Each c As DataGridViewColumn In dgv.Columns
                        If c.ValueType.ToString = "System.DateTime" Then
                            c.DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm"
                        End If
                    Next

                    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

                Else

                    Dim ReportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
                    ReportDataSource.Name = "sp_rpt_Payments"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_Payments.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(TreasuryNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TreasuryNumber", TreasuryNumber.ToString, True))
                        End If

                        If IsDBNull(AccountID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AccountID", AccountID.ToString, True))
                        End If

                        If IsDBNull(MoneyDirectionID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("MoneyDirectionID", MoneyDirectionID.ToString, True))
                        End If

                        If IsDBNull(DateFrom) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateFrom", DateFrom.ToString, True))
                        End If

                        If IsDBNull(DateTo) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateTo", DateTo.ToString, True))
                        End If



                    End With


                    If req = RequestType.rdlc Then
                        frm.Text = Me.Text
                        FrmMain.AddForm(frm)
                    Else
                        Dim m As New ByteClassLibrary.PrintReport
                        m.PrintLocalReport(frm.rvReport.LocalReport)
                    End If
                End If



            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
#End Region










    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try


            If Not IsNothing(MyBs.Current) Then



                If IsNumeric(MyBs.Current("PaymentID")) Then

                    Dim ID As Long = MyBs.Current("PaymentID")
                    Dim f As New frm_Payment(ID)

                    f.DeleteEntry(ID, PubUserID)


                    btnSearch.PerformClick()





                ElseIf IsNumeric(MyBs.Current("OtherPaymentID")) Then

                    Dim ID As Long = MyBs.Current("OtherPaymentID")
                    Dim f As New frm_OtherPayment(ID)

                    f.DeleteEntry(ID, PubUserID)


                    btnSearch.PerformClick()



                ElseIf IsNumeric(MyBs.Current("ExpenseID")) Then

                    Dim ID As Long = MyBs.Current("ExpenseID")
                    Dim f As New frm_Expense(ID)

                    f.DeleteEntry(ID, PubUserID)


                    btnSearch.PerformClick()


                ElseIf IsNumeric(MyBs.Current("InvoiceID")) Then

                    msgShow("لحدف هذا الايصال يجب حدف الفاتورة", ByteClassLibrary.Frm_msg.FormType.msgNormal)


                End If





            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            If Not IsNothing(MyBs.Current) AndAlso IsNumeric(MyBs.Current("TreasuryID")) Then
                Dim f As New frm_sp_rpt_Treasury
                f.numTreasuryID.Text = MyBs.Current("TreasuryID")
                f.btnView.PerformClick()
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try


    End Sub

    Private Sub btnprint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            If Not IsNothing(MyBs.Current) AndAlso IsNumeric(MyBs.Current("TreasuryID")) Then
                Dim f As New frm_sp_rpt_Treasury
                f.numTreasuryID.Text = MyBs.Current("TreasuryID")
                f.btnPrint.PerformClick()
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
End Class