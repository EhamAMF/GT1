'frm_sp_rpt_invoices
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_invoices

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource





    Dim InvoiceTypeID As Object
    Dim InvoiceNumber As Object
    Dim StockID As Object
    Dim InvoiceRealNumber As Object
    Dim orgInvoiceNumber As Object
    Dim AgentID As Object
    Dim UserID As Object
    Dim DateFrom As Object
    Dim DateTo As Object



    Private Sub frm_sp_rpt_invoices_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_invoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
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
        InvoiceID
        InvoiceTypeID
        InvoiceNumber
        InvoiceRealNumber
        orgInvoiceNumber
        InvDate
        IsPaid
        AgentName
        TotalPrice
        Discount
        FinalPrice
        Revenue
        Username

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
            dgv.Rows(MyBs.Find("IsSum", 1)).DefaultCellStyle.BackColor = Color.DarkBlue
            dgv.Rows(MyBs.Find("IsSum", 1)).DefaultCellStyle.ForeColor = Color.White
            Dim f As New Font(dgv.DefaultCellStyle.Font.FontFamily.Name, dgv.DefaultCellStyle.Font.Size, FontStyle.Bold)
            dgv.Rows(MyBs.Find("IsSum", 1)).DefaultCellStyle.Font = f
        End If

    End Sub
    Private Sub DgvDecimalFormat()
        Dim TargetDecCols As New List(Of Column)

        With TargetDecCols
            .Add(Column.TotalPrice)
            .Add(Column.FinalPrice)
            .Add(Column.Revenue)

        End With

        For Each i In TargetDecCols
            dgv.Columns(i.ToString).DefaultCellStyle.Format = "#,##0.00#"
        Next

        dgv.Columns("Discount").DefaultCellStyle.Format = "#,##0.## %"



    End Sub
    Private Sub GetTotal()
        Dim DT As DataTable = dgv.DataSource.DataSource



        If DT.Rows.Count > 0 Then

            Dim TargetSumCols As New List(Of Column)

            With TargetSumCols


                .Add(Column.FinalPrice)
                .Add(Column.Revenue)

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
        Get_sp_hlp_InvoiceType()
        Get_sp_hlp_Stock()
        Get_sp_hlp_Agent()
        Get_sp_hlp_Users()

    End Sub

    Dim WithEvents BsInvoiceType As New BindingSource
    Private Sub Get_sp_hlp_InvoiceType()

        Dim da As New SqlDataAdapter("sp_hlp_InvoiceType", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        BsInvoiceType.DataSource = dt

        With cboInvoiceTypeID
            .MySource = BsInvoiceType
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "InvoiceTypeID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "InvoiceTypeName1", True, "")
            .MyBeginProcess()
        End With


        cboInvoiceTypeID.MySelectedValue = 3


    End Sub
    Private Sub Get_sp_hlp_Stock()

        Dim da As New SqlDataAdapter("sp_hlp_Stock", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboStockID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "StockID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "StockName", True, "")
            .MyBeginProcess()
        End With

        cboStockID.MySelectedValue = DBNull.Value

    End Sub
    Private Sub Get_sp_hlp_Agent()

        Dim da As New SqlDataAdapter("sp_hlp_Agent", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboAgentID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "agentID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AgentName", True, "")
            .MyBeginProcess()
        End With

        cboAgentID.MySelectedValue = DBNull.Value

    End Sub
    Private Sub Get_sp_hlp_Users()

        Dim da As New SqlDataAdapter("sp_hlp_Users", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboUserID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "userID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "Username", True, "")
            .MyBeginProcess()
        End With

        cboUserID.MySelectedValue = DBNull.Value

    End Sub

    Private Function fn_sp_rpt_invoices(ByRef InvoiceTypeID As Object, ByRef InvoiceNumber As Object, ByRef StockID As Object, ByRef InvoiceRealNumber As Object, ByRef orgInvoiceNumber As Object, ByRef AgentID As Object, ByRef UserID As Object, ByRef DateFrom As Object, ByRef DateTo As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_invoices", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@InvoiceTypeID", InvoiceTypeID)
            .AddWithValue("@InvoiceNumber", InvoiceNumber)
            .AddWithValue("@StockID", StockID)
            .AddWithValue("@InvoiceRealNumber", InvoiceRealNumber)
            .AddWithValue("@orgInvoiceNumber", orgInvoiceNumber)
            .AddWithValue("@AgentID", AgentID)
            .AddWithValue("@UserID", UserID)
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

        InvoiceTypeID = MyConvert(cboInvoiceTypeID.MySelectedValue)
        InvoiceNumber = MyConvert(numInvoiceNumber.Text.Trim)
        StockID = MyConvert(cboStockID.MySelectedValue)
        InvoiceRealNumber = MyConvert(txtInvoiceRealNumber.Text.Trim)
        orgInvoiceNumber = MyConvert(numorgInvoiceNumber.Text.Trim)
        AgentID = MyConvert(cboAgentID.MySelectedValue)
        UserID = MyConvert(cboUserID.MySelectedValue)
        DateFrom = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateFrom.Value)
        DateTo = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateTo.Value)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_invoices_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F8
                    '  btnView.PerformClick()
                Case Keys.F9
                    '  btnPrint.PerformClick()
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

    Private Sub BsInvoiceType_CurrentChanged() Handles BsInvoiceType.CurrentChanged
        Try

            If Not IsNothing(BsInvoiceType.Current) AndAlso IsNumeric(BsInvoiceType.Current("InvoiceTypeID")) Then
                Dim InvoiceTypeID As Int64 = BsInvoiceType.Current("InvoiceTypeID")

                PInvoiceRealNumber.Visible = False
                PorgInvoiceNumber.Visible = False

                Select Case InvoiceTypeID

                    Case 1
                        PInvoiceRealNumber.Visible = True
                    Case 4
                        PorgInvoiceNumber.Visible = True
                End Select


            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_invoices(InvoiceTypeID, InvoiceNumber, StockID, InvoiceRealNumber, orgInvoiceNumber, AgentID, UserID, DateFrom, DateTo)
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


                    dgv.Columns("InvoiceID").HeaderText = "ر,م"
                    dgv.Columns("InvoiceTypeID").HeaderText = "نوع الفاتورة"
                    dgv.Columns("InvoiceNumber").HeaderText = "رقم الفاتورة"
                    dgv.Columns("InvoiceRealNumber").HeaderText = "رقم المصدر"
                    dgv.Columns("orgInvoiceNumber").HeaderText = "مسترجعة عن فاتورة رقم"
                    dgv.Columns("InvDate").HeaderText = "التاريخ"
                    dgv.Columns("IsPaid").HeaderText = "الدفع"
                    dgv.Columns("AgentName").HeaderText = "العميل"
                    dgv.Columns("TotalPrice").HeaderText = "الاجمالي"
                    dgv.Columns("Discount").HeaderText = "خصم"
                    dgv.Columns("FinalPrice").HeaderText = "النهائي"
                    dgv.Columns("Revenue").HeaderText = "الربح"
                    dgv.Columns("Username").HeaderText = "المستخدم"


                    dgv.Columns("InvoiceID").Visible = False
                    dgv.Columns("InvoiceTypeID").Visible = False





                    If Not IsNothing(BsInvoiceType.Current) AndAlso IsNumeric(BsInvoiceType.Current("InvoiceTypeID")) Then
                        Dim InvoiceTypeID As Int64 = BsInvoiceType.Current("InvoiceTypeID")

                        dgv.Columns("InvoiceRealNumber").Visible = True
                        dgv.Columns("orgInvoiceNumber").Visible = True
                        dgv.Columns("IsPaid").Visible = True
                        dgv.Columns("AgentName").Visible = True
                        dgv.Columns("Revenue").Visible = True

                        Select Case InvoiceTypeID

                            Case 1
                                dgv.Columns("orgInvoiceNumber").Visible = False
                                dgv.Columns("Revenue").Visible = False
                            Case 2
                                dgv.Columns("Revenue").Visible = False
                            Case 3
                                dgv.Columns("InvoiceRealNumber").Visible = False
                                dgv.Columns("orgInvoiceNumber").Visible = False
                            Case 4
                                dgv.Columns("InvoiceRealNumber").Visible = False
                                dgv.Columns("IsPaid").Visible = False
                                dgv.Columns("AgentName").Visible = False
                            Case 5
                                dgv.Columns("InvoiceRealNumber").Visible = False
                                dgv.Columns("orgInvoiceNumber").Visible = False
                                dgv.Columns("IsPaid").Visible = False
                                dgv.Columns("AgentName").Visible = False
                                dgv.Columns("Revenue").Visible = False
                            Case 7
                                dgv.Columns("InvoiceRealNumber").Visible = False
                                dgv.Columns("orgInvoiceNumber").Visible = False
                                dgv.Columns("IsPaid").Visible = False
                                dgv.Columns("AgentName").Visible = False
                                dgv.Columns("Revenue").Visible = False
                            Case 6
                                dgv.Columns("InvoiceRealNumber").Visible = False
                                dgv.Columns("orgInvoiceNumber").Visible = False
                                dgv.Columns("IsPaid").Visible = False
                                dgv.Columns("AgentName").Visible = False
                                dgv.Columns("Revenue").Visible = False

                                dgv.Columns("TotalPrice").Visible = False
                                dgv.Columns("Discount").Visible = False
                                dgv.Columns("FinalPrice").Visible = False

                        End Select


                    End If








                    GetTotal()
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
                    ReportDataSource.Name = "sp_rpt_invoices"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_invoices.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(InvoiceTypeID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceTypeID", InvoiceTypeID.ToString, True))
                        End If

                        If IsDBNull(InvoiceNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceNumber", InvoiceNumber.ToString, True))
                        End If

                        If IsDBNull(StockID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("StockID", StockID.ToString, True))
                        End If

                        If IsDBNull(InvoiceRealNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceRealNumber", InvoiceRealNumber.ToString, True))
                        End If

                        If IsDBNull(orgInvoiceNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("orgInvoiceNumber", orgInvoiceNumber.ToString, True))
                        End If

                        If IsDBNull(AgentID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentID", AgentID.ToString, True))
                        End If

                        If IsDBNull(UserID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("UserID", UserID.ToString, True))
                        End If

                        If IsDBNull(DateFrom) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateFrom", DateFrom.ToString, True))
                        End If

                        If IsDBNull(DateTo) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateTo", DateTo.ToString, True))
                        End If



                    End With


                    If req = RequestType.rdlc Then
                        frm.Show()
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










    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If Not IsNothing(MyBs.Current) AndAlso IsNumeric(MyBs.Current("InvoiceID")) Then

                Dim ID As Int64 = MyBs.Current("InvoiceID")
                Dim f As New Frm_Invoice(ID)
                f.MdiParent = Me.MdiParent
                f.WindowState = FormWindowState.Maximized
                f.Show()



            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
End Class