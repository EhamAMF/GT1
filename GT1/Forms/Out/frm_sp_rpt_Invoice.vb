'frm_sp_rpt_Invoice
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_Invoice

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim InvoiceID As Object
    Dim NextOrPrevInvoiceID As Object
    Dim InvoiceTypeID As Object
    Dim IsPaid As Object
    Dim InvoiceNumber As Object
    Dim InvoiceRealNumber As Object
    Dim OrgInvoiceID As Object
    Dim OrgInvoiceNumber As Object
    Dim InvDate As Object
    Dim AgentID As Object
    Dim DistributorID As Object
    Dim CustomerName As Object
    Dim TotalPrice As Object
    Dim FinalPrice As Object
    Dim Revenue As Object
    Dim Discount As Object
    Dim Note As Object
    Dim UserID As Object
    Dim InvoiceTypeName As Object
    Dim AgentName As Object
    Dim DistributorName As Object
    Dim Username As Object

    Dim AgentBalance As Object
    Dim AmountPaid As Object


    Private Sub frm_sp_rpt_Invoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)
            'dtpDateFrom.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
            'dtpDateTo.Value = dtpDateFrom.Value.AddDays(1)
            numNextOrPrevInvoiceID.Text = "0"
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
        InvDetID
        Sort
        GID
        IsProduct
        PlusOrMinus
        ItemID
        SubAmount
        ItemName
        ItemDetails
        Barcode
        ProductCode
        IsPacket
        Amount
        UnitPrice
        AvgCost
        AmountPacket
        UnitPricePacket
        AvgCostPacket
        Amount_inv
        UnitPrice_inv
        AvgCost_inv
        Total
        TotalCost
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
            .Add(Column.UnitPrice)
            .Add(Column.AvgCost)
            .Add(Column.AmountPacket)
            .Add(Column.UnitPricePacket)
            .Add(Column.AvgCostPacket)
            .Add(Column.Amount_inv)
            .Add(Column.UnitPrice_inv)
            .Add(Column.AvgCost_inv)
            .Add(Column.Total)
            .Add(Column.TotalCost)
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
                .Add(Column.UnitPrice)
                .Add(Column.AvgCost)
                .Add(Column.AmountPacket)
                .Add(Column.UnitPricePacket)
                .Add(Column.AvgCostPacket)
                .Add(Column.Amount_inv)
                .Add(Column.UnitPrice_inv)
                .Add(Column.AvgCost_inv)
                .Add(Column.Total)
                .Add(Column.TotalCost)
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

    End Sub

    Private Function fn_sp_rpt_Invoice(ByRef InvoiceID As Object, ByRef NextOrPrevInvoiceID As Object, ByRef InvoiceTypeID As Object, ByRef IsPaid As Object, ByRef InvoiceNumber As Object, ByRef InvoiceRealNumber As Object, ByRef OrgInvoiceID As Object, ByRef OrgInvoiceNumber As Object, ByRef InvDate As Object, ByRef AgentID As Object, ByRef DistributorID As Object, ByRef CustomerName As Object, ByRef TotalPrice As Object, ByRef FinalPrice As Object, ByRef Revenue As Object, ByRef Discount As Object, ByRef Note As Object, ByRef UserID As Object, ByRef InvoiceTypeName As Object, ByRef AgentName As Object, ByRef DistributorName As Object, ByRef Username As Object, ByRef AgentBalance As Object, ByRef AmountPaid As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Invoice", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .AddWithValue("@NextOrPrevInvoiceID", NextOrPrevInvoiceID)
            .Add("@InvoiceTypeID", SqlDbType.BigInt, 0)
            .Add("@IsPaid", SqlDbType.Bit, 0)
            .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@InvoiceRealNumber", SqlDbType.NVarChar, 200)
            .Add("@OrgInvoiceID", SqlDbType.BigInt, 0)
            .Add("@OrgInvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@InvDate", SqlDbType.DateTime, 0)
            .Add("@AgentID", SqlDbType.BigInt, 0)
            .Add("@DistributorID", SqlDbType.BigInt, 0)
            .Add("@CustomerName", SqlDbType.NVarChar, 200)
            .Add("@TotalPrice", SqlDbType.Decimal, 0)
            .Add("@FinalPrice", SqlDbType.Decimal, 0)
            .Add("@Revenue", SqlDbType.Decimal, 0)
            .Add("@Discount", SqlDbType.Decimal, 0)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@UserID", SqlDbType.BigInt, 0)
            .Add("@InvoiceTypeName", SqlDbType.NVarChar, 200)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .Add("@Username", SqlDbType.NVarChar, 200)

            .Add("@AgentBalance", SqlDbType.Decimal, 0)
            .Add("@AmountPaid", SqlDbType.Decimal, 0)
        End With

        With da.SelectCommand
            .Parameters("@InvoiceTypeID").Direction = ParameterDirection.Output
            .Parameters("@IsPaid").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvoiceRealNumber").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceID").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvDate").Direction = ParameterDirection.Output
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters("@DistributorID").Direction = ParameterDirection.Output
            .Parameters("@CustomerName").Direction = ParameterDirection.Output
            .Parameters("@TotalPrice").Direction = ParameterDirection.Output
            .Parameters("@FinalPrice").Direction = ParameterDirection.Output
            .Parameters("@Revenue").Direction = ParameterDirection.Output
            .Parameters("@Discount").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeName").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output

            .Parameters("@AgentBalance").Direction = ParameterDirection.Output
            .Parameters("@AmountPaid").Direction = ParameterDirection.Output


            .Parameters("@InvoiceTypeID").Scale = 0
            .Parameters("@IsPaid").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@InvoiceRealNumber").Scale = 0
            .Parameters("@OrgInvoiceID").Scale = 0
            .Parameters("@OrgInvoiceNumber").Scale = 0
            .Parameters("@InvDate").Scale = 0
            .Parameters("@AgentID").Scale = 0
            .Parameters("@DistributorID").Scale = 0
            .Parameters("@CustomerName").Scale = 0
            .Parameters("@TotalPrice").Scale = 3
            .Parameters("@FinalPrice").Scale = 3
            .Parameters("@Revenue").Scale = 3
            .Parameters("@Discount").Scale = 4
            .Parameters("@Note").Scale = 0
            .Parameters("@UserID").Scale = 0
            .Parameters("@InvoiceTypeName").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0

            .Parameters("@AgentBalance").Scale = 3
            .Parameters("@AmountPaid").Scale = 3
        End With

        da.Fill(dt)

        With da.SelectCommand
            InvoiceTypeID = .Parameters("@InvoiceTypeID").Value
            IsPaid = .Parameters("@IsPaid").Value
            InvoiceNumber = .Parameters("@InvoiceNumber").Value
            InvoiceRealNumber = .Parameters("@InvoiceRealNumber").Value
            OrgInvoiceID = .Parameters("@OrgInvoiceID").Value
            OrgInvoiceNumber = .Parameters("@OrgInvoiceNumber").Value
            InvDate = .Parameters("@InvDate").Value
            AgentID = .Parameters("@AgentID").Value
            DistributorID = .Parameters("@DistributorID").Value
            CustomerName = .Parameters("@CustomerName").Value
            TotalPrice = .Parameters("@TotalPrice").Value
            FinalPrice = .Parameters("@FinalPrice").Value
            Revenue = .Parameters("@Revenue").Value
            Discount = .Parameters("@Discount").Value
            Note = .Parameters("@Note").Value
            UserID = .Parameters("@UserID").Value
            InvoiceTypeName = .Parameters("@InvoiceTypeName").Value
            AgentName = .Parameters("@AgentName").Value
            DistributorName = .Parameters("@DistributorName").Value
            Username = .Parameters("@Username").Value

            AgentBalance = .Parameters("@AgentBalance").Value
            AmountPaid = .Parameters("@AmountPaid").Value


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

        InvoiceID = MyConvert(numInvoiceID.Text.Trim)
        NextOrPrevInvoiceID = MyConvert(numNextOrPrevInvoiceID.Text.Trim)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_Invoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            HandleMyError(ex, , , Settings.IsDebug)
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
    '    Private Sub chkAllPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllPeriod.CheckedChanged
    '        Try
    '            dtpDateFrom.Enabled = Not chkAllPeriod.Checked
    '            dtpDateTo.Enabled = Not chkAllPeriod.Checked
    '        Catch ex As Exception
    '            HandleMyError(ex, , , Settings.IsDebug)
    '        End Try
    'End Sub




    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_Invoice(InvoiceID, NextOrPrevInvoiceID, InvoiceTypeID, IsPaid, InvoiceNumber, InvoiceRealNumber, OrgInvoiceID, OrgInvoiceNumber, InvDate, AgentID, DistributorID, CustomerName, TotalPrice, FinalPrice, Revenue, Discount, Note, UserID, InvoiceTypeName, AgentName, DistributorName, Username, AgentBalance, AmountPaid)
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


                    dgv.Columns("InvDetID").HeaderText = ""
                    dgv.Columns("Sort").HeaderText = "ترتيب"
                    dgv.Columns("GID").HeaderText = ""
                    dgv.Columns("IsProduct").HeaderText = ""
                    dgv.Columns("PlusOrMinus").HeaderText = ""
                    dgv.Columns("ItemID").HeaderText = ""
                    dgv.Columns("SubAmount").HeaderText = "العبوة"
                    dgv.Columns("ItemName").HeaderText = "البيان"
                    dgv.Columns("ItemDetails").HeaderText = "تفاصيل"
                    dgv.Columns("Barcode").HeaderText = "باركود"
                    dgv.Columns("ProductCode").HeaderText = "كود"
                    dgv.Columns("IsPacket").HeaderText = "صندوق"
                    dgv.Columns("Amount").HeaderText = "الكمية"
                    dgv.Columns("UnitPrice").HeaderText = "سعر الوحدة"
                    dgv.Columns("AvgCost").HeaderText = "متوسط التكلفة"
                    dgv.Columns("AmountPacket").HeaderText = "الكمية صندوق"
                    dgv.Columns("UnitPricePacket").HeaderText = "سعر الصندوق"
                    dgv.Columns("AvgCostPacket").HeaderText = "متوسط تكلفة الصندوق"
                    dgv.Columns("Amount_inv").HeaderText = "الكمية"
                    dgv.Columns("UnitPrice_inv").HeaderText = "السعر"
                    dgv.Columns("AvgCost_inv").HeaderText = "متوسط التكلفة"
                    dgv.Columns("Total").HeaderText = "الاجمالي"
                    dgv.Columns("TotalCost").HeaderText = "اجمالي التكلفة"
                    dgv.Columns("Revenue").HeaderText = "الربح"



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
                    ReportDataSource.Name = "sp_rpt_Invoice"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport

                        Dim HeaderLogoFullName = My.Application.Info.DirectoryPath & "\per\imgHeader.jpg"
                        Select Case Settings.InvoiceLayout

                            Case "rpt_sp_rpt_Invoice_Receipt.rdlc"
                                HeaderLogoFullName = My.Application.Info.DirectoryPath & "\per\imgHeader_Receipt.jpg"
                            Case "rpt_sp_rpt_Invoice_A5.rdlc"
                                HeaderLogoFullName = My.Application.Info.DirectoryPath & "\per\imgHeader.jpg"
                            Case "rpt_sp_rpt_Invoice_A4.rdlc"
                                HeaderLogoFullName = My.Application.Info.DirectoryPath & "\per\imgHeader.jpg"
                        End Select


                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & "." & Settings.InvoiceLayout

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & HeaderLogoFullName, True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(InvoiceID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceID", InvoiceID.ToString, True))
                        End If

                        If IsDBNull(NextOrPrevInvoiceID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("NextOrPrevInvoiceID", NextOrPrevInvoiceID.ToString, True))
                        End If

                        If IsDBNull(InvoiceTypeID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceTypeID", InvoiceTypeID.ToString, True))
                        End If

                        If IsDBNull(IsPaid) = False Then
                            .LocalReport.SetParameters(New ReportParameter("IsPaid", IsPaid.ToString, True))
                        End If

                        If IsDBNull(InvoiceNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceNumber", InvoiceNumber.ToString, True))
                        End If

                        If IsDBNull(InvoiceRealNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceRealNumber", InvoiceRealNumber.ToString, True))
                        End If

                        If IsDBNull(OrgInvoiceID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("OrgInvoiceID", OrgInvoiceID.ToString, True))
                        End If

                        If IsDBNull(OrgInvoiceNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("OrgInvoiceNumber", OrgInvoiceNumber.ToString, True))
                        End If

                        If IsDBNull(InvDate) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvDate", InvDate.ToString, True))
                        End If

                        If IsDBNull(AgentID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentID", AgentID.ToString, True))
                        End If

                        If IsDBNull(DistributorID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DistributorID", DistributorID.ToString, True))
                        End If

                        If IsDBNull(CustomerName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("CustomerName", CustomerName.ToString, True))
                        End If

                        If IsDBNull(TotalPrice) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TotalPrice", TotalPrice.ToString, True))
                        End If

                        If IsDBNull(FinalPrice) = False Then
                            .LocalReport.SetParameters(New ReportParameter("FinalPrice", FinalPrice.ToString, True))
                        End If

                        If IsDBNull(Revenue) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Revenue", Revenue.ToString, True))
                        End If

                        If IsDBNull(Discount) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Discount", Discount.ToString, True))
                        End If

                        If IsDBNull(Note) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Note", Note.ToString, True))
                        End If

                        If IsDBNull(UserID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("UserID", UserID.ToString, True))
                        End If

                        If IsDBNull(InvoiceTypeName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceTypeName", InvoiceTypeName.ToString, True))
                        End If

                        If IsDBNull(AgentName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentName", AgentName.ToString, True))
                        End If

                        If IsDBNull(DistributorName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DistributorName", DistributorName.ToString, True))
                        End If

                        If IsDBNull(Username) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Username", Username.ToString, True))
                        End If

                        If IsDBNull(AgentBalance) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentBalance", AgentBalance.ToString, True))
                        End If

                        If IsDBNull(AmountPaid) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AmountPaid", AmountPaid.ToString, True))
                        End If

                        .LocalReport.SetParameters(New ReportParameter("FinalPriceStr", ByteClassLibrary.MyFunctions.CurrencyToString(FinalPrice), True))






                    End With


                    If req = RequestType.rdlc Then

                        'frm.Show()
                        frm.Text = Me.Text
                        FrmMain.AddForm(frm)


                    Else
                        'Dim m As New ByteClassLibrary.PrintReport
                        'm.PrintLocalReport(frm.rvReport.LocalReport)

                        If Settings.InvoiceLayout = "rpt_sp_rpt_Invoice_A4.rdlc" Then
                            print_microsoft_report(frm.rvReport.LocalReport, "A4")
                        ElseIf Settings.InvoiceLayout = "rpt_sp_rpt_Invoice_A5.rdlc" Then
                            print_microsoft_report(frm.rvReport.LocalReport, "A5")
                        End If








                    End If
                End If



            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
#End Region









End Class