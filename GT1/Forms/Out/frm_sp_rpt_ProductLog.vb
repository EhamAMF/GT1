'frm_sp_rpt_ProductLog
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_ProductLog

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim StockID As Object
    Dim DateFrom As Object
    Dim DateTo As Object
    Dim StockName As Object



    Private Sub frm_sp_rpt_ProductLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_ProductLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)
            dtpDateFrom.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
            dtpDateTo.Value = dtpDateFrom.Value.AddDays(1)

            GetInitialData()
            lblTitle.Text = Me.Text
        Catch ex As Exception
            HandleMyError(ex)
        End Try


    End Sub

    Enum RequestType
        dgv = 1
        rdlc = 2
        print = 3
    End Enum
    Enum Column
        InvDate
        InvoiceID
        InvoiceTypeName1
        InvoiceNumber
        PlusOrMinus
        IsPacket
        SubAmount
        Amount
        NetPrice
        AvgCost
        Total
        AmountLeft
        AmountPacket
        NetPricePacket
        AvgCostPacket
        TotalPacket
        AmountLeftPacket
        Revenue

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
            '.Add(Column.SubAmount)
            .Add(Column.Amount)
            .Add(Column.NetPrice)
            .Add(Column.AvgCost)
            .Add(Column.Total)
            .Add(Column.AmountLeft)
            .Add(Column.AmountPacket)
            .Add(Column.NetPricePacket)
            .Add(Column.AvgCostPacket)
            .Add(Column.TotalPacket)
            .Add(Column.AmountLeftPacket)
            .Add(Column.Revenue)

        End With

        For Each i In TargetDecCols
            dgv.Columns(i.ToString).DefaultCellStyle.Format = "#,##0.###"
        Next
    End Sub
    Private Sub GetTotal()
        Dim DT As DataTable = dgv.DataSource.DataSource



        If DT.Rows.Count > 0 Then

            Dim TargetSumCols As New List(Of Column)

            With TargetSumCols
                .Add(Column.SubAmount)
                .Add(Column.Amount)
                .Add(Column.NetPrice)
                .Add(Column.AvgCost)
                .Add(Column.Total)
                .Add(Column.AmountLeft)
                .Add(Column.AmountPacket)
                .Add(Column.NetPricePacket)
                .Add(Column.AvgCostPacket)
                .Add(Column.TotalPacket)
                .Add(Column.AmountLeftPacket)
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
        Get_sp_hlp_Item()

    End Sub
    Private Sub Get_sp_hlp_Item()

        Dim da As New SqlDataAdapter("sp_hlp_Item", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboStockID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "StockID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "ProductName", True, "")

            .SetColumn("GID", False, False)
            .SetColumn("IsProduct", False, False)


            .MyBeginProcess()
        End With

    End Sub

    Private Function fn_sp_rpt_ProductLog(ByRef StockID As Object, ByRef DateFrom As Object, ByRef DateTo As Object, ByRef StockName As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_ProductLog", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@StockID", StockID)
            .AddWithValue("@DateFrom", DateFrom)
            .AddWithValue("@DateTo", DateTo)
            .Add("@StockName", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@StockName").Direction = ParameterDirection.Output


            .Parameters("@StockName").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            StockName = .Parameters("@StockName").Value

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

        StockID = MyConvert(cboStockID.MySelectedValue)
        DateFrom = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateFrom.Value)
        DateTo = IIf(chkAllPeriod.Checked, DBNull.Value, dtpDateTo.Value)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_ProductLog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F8
                    btnView.PerformClick()
                Case Keys.F9
                    btnPrint.PerformClick()
                Case Keys.F7
                    btnShowHideSearch.PerformClick()
            End Select
        Catch ex As Exception
            HandleMyError(ex)
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
            HandleMyError(ex)
        End Try

    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            If bw1.IsBusy = False Then
                req = RequestType.print
                'btnSearch.Text = "الرجاء الانتظار قليلا"
                'PictureBox1.Visible = True
                btnSearch.Text = "الرجاء الانتظار قليلا"
                PictureBox1.Visible = True

                SetInputParameters()
                bw1.RunWorkerAsync()
            End If



        Catch ex As Exception
            HandleMyError(ex)
        End Try

    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try

            If bw1.IsBusy = False Then
                req = RequestType.rdlc
                ' btnSearch.Text = "الرجاء الانتظار قليلا"
                '  PictureBox1.Visible = True
                btnSearch.Text = "الرجاء الانتظار قليلا"
                PictureBox1.Visible = True

                SetInputParameters()
                bw1.RunWorkerAsync()
            End If



        Catch ex As Exception
            HandleMyError(ex)
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
            HandleMyError(ex)
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
            HandleMyError(ex)
        End Try


    End Sub
    Private Sub chkAllPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllPeriod.CheckedChanged
        Try
            dtpDateFrom.Enabled = Not chkAllPeriod.Checked
            dtpDateTo.Enabled = Not chkAllPeriod.Checked
        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub




    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_ProductLog(StockID, DateFrom, DateTo, StockName)
            If bw1.CancellationPending = True Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            HandleMyError(ex)
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


                    dgv.Columns("InvDate").HeaderText = "التاريخ"
                    dgv.Columns("InvoiceID").HeaderText = "ر,م"
                    dgv.Columns("InvoiceTypeName1").HeaderText = "المعاملة"
                    dgv.Columns("InvoiceNumber").HeaderText = "رقم الفاتورة"
                    dgv.Columns("PlusOrMinus").HeaderText = ""
                    dgv.Columns("IsPacket").HeaderText = "صندوق"
                    dgv.Columns("SubAmount").HeaderText = "العبوة"
                    dgv.Columns("Amount").HeaderText = "الكمية"
                    dgv.Columns("NetPrice").HeaderText = "صافي السعر"
                    dgv.Columns("AvgCost").HeaderText = "متوسط التكلفة"
                    dgv.Columns("Total").HeaderText = "الاجمالي"
                    dgv.Columns("AmountLeft").HeaderText = "الكمية المتبقية"
                    dgv.Columns("AmountPacket").HeaderText = "الكمية صندوق"
                    dgv.Columns("NetPricePacket").HeaderText = "صافي السعر ص"
                    dgv.Columns("AvgCostPacket").HeaderText = "متوسط تكلفة الصندوق"
                    dgv.Columns("TotalPacket").HeaderText = "الاجمالي"
                    dgv.Columns("AmountLeftPacket").HeaderText = "الكمية المتبقية ص"
                    dgv.Columns("Revenue").HeaderText = "الربح"

                    dgv.Columns("InvoiceID").Visible = False
                    dgv.Columns("PlusOrMinus").Visible = False
                    dgv.Columns("SubAmount").Visible = False


                    'GetTotal()
                    DgvDecimalFormat()
                    FormatSumRow()
                    lblCount.Text = MyBs.Count - 1

                    For Each c As DataGridViewColumn In dgv.Columns
                        If c.ValueType.ToString = "System.DateTime" Then
                            c.DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm"
                        End If
                    Next


                    dgv.Columns("Amount").DefaultCellStyle.BackColor = Color.LightBlue
                    dgv.Columns("NetPrice").DefaultCellStyle.BackColor = Color.LightBlue
                    dgv.Columns("AvgCost").DefaultCellStyle.BackColor = Color.LightBlue
                    dgv.Columns("Total").DefaultCellStyle.BackColor = Color.LightBlue
                    dgv.Columns("AmountLeft").DefaultCellStyle.BackColor = Color.LightBlue

 


                    For Each r As DataGridViewRow In dgv.Rows
                        If r.Cells("PlusOrMinus").Value = 1 Then
                            r.DefaultCellStyle.BackColor = Color.PaleGreen
                        End If
                    Next



                    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

                Else

                    Dim ReportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
                    ReportDataSource.Name = "sp_rpt_ProductLog"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_ProductLog.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(StockID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("StockID", StockID.ToString, True))
                        End If

                        If IsDBNull(DateFrom) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateFrom", DateFrom.ToString, True))
                        End If

                        If IsDBNull(DateTo) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateTo", DateTo.ToString, True))
                        End If

                        If IsDBNull(StockName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("StockName", StockName.ToString, True))
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
            HandleMyError(ex)
        End Try
    End Sub
#End Region









    Private Sub اخفاءبياناتالقطعةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخفاءبياناتالقطعةToolStripMenuItem.Click
        Try
            If dgv.ColumnCount > 0 Then

                dgv.Columns("Amount").Visible = False
                dgv.Columns("NetPrice").Visible = False
                dgv.Columns("AvgCost").Visible = False
                dgv.Columns("Total").Visible = False
                dgv.Columns("AmountLeft").Visible = False

            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub اخفاءبياناتالصندوقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخفاءبياناتالصندوقToolStripMenuItem.Click
        Try
            If dgv.ColumnCount > 0 Then

                dgv.Columns("AmountPacket").Visible = False
                dgv.Columns("NetPricePacket").Visible = False
                dgv.Columns("AvgCostPacket").Visible = False
                dgv.Columns("TotalPacket").Visible = False
                dgv.Columns("AmountLeftPacket").Visible = False

            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub اظهارالكلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اظهارالكلToolStripMenuItem.Click
        Try
            If dgv.ColumnCount > 0 Then

                dgv.Columns("Amount").Visible = True
                dgv.Columns("NetPrice").Visible = True
                dgv.Columns("AvgCost").Visible = True
                dgv.Columns("Total").Visible = True
                dgv.Columns("AmountLeft").Visible = True

                dgv.Columns("AmountPacket").Visible = True
                dgv.Columns("NetPricePacket").Visible = True
                dgv.Columns("AvgCostPacket").Visible = True
                dgv.Columns("TotalPacket").Visible = True
                dgv.Columns("AmountLeftPacket").Visible = True

            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class