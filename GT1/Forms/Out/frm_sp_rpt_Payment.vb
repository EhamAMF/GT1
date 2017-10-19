'frm_sp_rpt_Payment
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_Payment

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim PaymentID As Object
    Dim IsMoneyIn As Object
    Dim PaymentName As Object
    Dim PaymentNumber As Object
    Dim AgentID As Object
    Dim AgentName As Object
    Dim DistibutorID As Object
    Dim DistributorName As Object
    Dim PaymentAmount As Object
    Dim PaymentDate As Object
    Dim Note As Object
    Dim UserID As Object
    Dim Username As Object



    Private Sub frm_sp_rpt_Payment_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_Payment_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)
            'dtpDateFrm.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
            'dtpDateTo.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 59, 999)

            GetInitialData()
            lblTitle.Text = Me.Text
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub

    Enum RequestType
        dgv = 1
        rdlc = 2
        print = 3
    End Enum
    Enum Column
        Column1

    End Enum

#Region "       Subs and Functions"


    Private Function MyConvert(ByVal var As Object) As Object
        Dim out As Object



        If IsNothing(var) Then
            out = DBNull.Value
        ElseIf IsDBNull(var) Then
            out = DBNull.Value
        ElseIf IsNumeric(var) Then
            If Val(var) <= 0 Then
                out = DBNull.Value
            Else
                out = Val(var)
            End If
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
            '
        End With

        For Each i In TargetDecCols
            dgv.Columns(i.ToString).DefaultCellStyle.Format = "#,##0.000"
        Next
    End Sub
    Private Sub GetTotal()
        Dim DT As DataTable = dgv.DataSource.DataSource



        If DT.Rows.Count > 0 Then

            Dim TargetSumCols As New List(Of Column)

            With TargetSumCols

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

    Private Function fn_sp_rpt_Payment(ByRef PaymentID As Object, ByRef IsMoneyIn As Object, ByRef PaymentName As Object, ByRef PaymentNumber As Object, ByRef AgentID As Object, ByRef AgentName As Object, ByRef DistibutorID As Object, ByRef DistributorName As Object, ByRef PaymentAmount As Object, ByRef PaymentDate As Object, ByRef Note As Object, ByRef UserID As Object, ByRef Username As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Payment", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@PaymentID", PaymentID)
            .Add("@IsMoneyIn", SqlDbType.Bit, 0)
            .Add("@PaymentName", SqlDbType.NVarChar, 200)
            .Add("@PaymentNumber", SqlDbType.BigInt, 0)
            .Add("@AgentID", SqlDbType.BigInt, 0)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@DistibutorID", SqlDbType.BigInt, 0)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .Add("@PaymentAmount", SqlDbType.Decimal, 0)
            .Add("@PaymentDate", SqlDbType.DateTime, 0)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@UserID", SqlDbType.BigInt, 0)
            .Add("@Username", SqlDbType.NVarChar, 50)

        End With

        With da.SelectCommand
            .Parameters("@IsMoneyIn").Direction = ParameterDirection.Output
            .Parameters("@PaymentName").Direction = ParameterDirection.Output
            .Parameters("@PaymentNumber").Direction = ParameterDirection.Output
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistibutorID").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@PaymentAmount").Direction = ParameterDirection.Output
            .Parameters("@PaymentDate").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output


            .Parameters("@IsMoneyIn").Scale = 0
            .Parameters("@PaymentName").Scale = 0
            .Parameters("@PaymentNumber").Scale = 0
            .Parameters("@AgentID").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistibutorID").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@PaymentAmount").Scale = 3
            .Parameters("@PaymentDate").Scale = 0
            .Parameters("@Note").Scale = 0
            .Parameters("@UserID").Scale = 0
            .Parameters("@Username").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            IsMoneyIn = .Parameters("@IsMoneyIn").Value
            PaymentName = .Parameters("@PaymentName").Value
            PaymentNumber = .Parameters("@PaymentNumber").Value
            AgentID = .Parameters("@AgentID").Value
            AgentName = .Parameters("@AgentName").Value
            DistibutorID = .Parameters("@DistibutorID").Value
            DistributorName = .Parameters("@DistributorName").Value
            PaymentAmount = .Parameters("@PaymentAmount").Value
            PaymentDate = .Parameters("@PaymentDate").Value
            Note = .Parameters("@Note").Value
            UserID = .Parameters("@UserID").Value
            Username = .Parameters("@Username").Value

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

        PaymentID = MyConvert(numPaymentID.Text.Trim)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_Payment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub

    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_Payment(PaymentID, IsMoneyIn, PaymentName, PaymentNumber, AgentID, AgentName, DistibutorID, DistributorName, PaymentAmount, PaymentDate, Note, UserID, Username)
            If bw1.CancellationPending = True Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
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

                    'dgv.Columns("IsService").Visible = False
                    'dgv.Columns("IsService").HeaderText = "Service"
                    'dgv.Columns("ItemID").HeaderText = "ر.م"
                    'dgv.Columns("ItemName").HeaderText = "البيان"
                    'dgv.Columns("TotalPurchases").HeaderText = "اجمالي المشتريات"
                    'dgv.Columns("TotalSales").HeaderText = "اجمالي المبيعات"
                    'dgv.Columns("Loss").HeaderText = "الفاقد"
                    'dgv.Columns("Stock").HeaderText = "المخزن"
                    'dgv.Columns("Purchase").HeaderText = "مشتريات"
                    'dgv.Columns("Purchase_R").HeaderText = "استرجاع مشتريات"
                    'dgv.Columns("Sales").HeaderText = "مبيعات"
                    'dgv.Columns("Sales_R").HeaderText = "استرجاع مبيعات"
                    dgv.Columns("Column1").HeaderText = "c1"



                    GetTotal()
                    DgvDecimalFormat()
                    FormatSumRow()
                    lblCount.Text = MyBs.Count - 1

                    For Each c As DataGridViewColumn In dgv.Columns
                        If c.ValueType.ToString = "System.DateTime" Then
                            c.DefaultCellStyle.Format = "yyyy-M-d    H:M  "
                        End If
                    Next

                    dgv.AutoResizeColumns()

                Else

                    Dim ReportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
                    ReportDataSource.Name = "sp_rpt_Payment"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_Payment.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))

                        'If IsDBNull(ItemTypeID) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("ItemTypeID", ItemTypeID.ToString, True))
                        'End If

                        'If IsDBNull(ItemTypeName) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("ItemTypeName", ItemTypeName.ToString, True))
                        'End If

                        'If IsDBNull(AgentID) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("AgentID", AgentID.ToString, True))
                        'End If

                        'If IsDBNull(AgentName) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("AgentName", AgentName.ToString, True))
                        'End If

                        'If IsDBNull(TypeID) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("TypeID", TypeID.ToString, True))
                        'End If

                        'If IsDBNull(TypeName) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("TypeName", TypeName.ToString, True))
                        'End If

                        'If IsDBNull(BrandID) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("BrandID", BrandID.ToString, True))
                        'End If

                        'If IsDBNull(BrandName) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("BrandName", BrandName.ToString, True))
                        'End If

                        'If IsDBNull(DateFrm) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("DateFrm", DateFrm.ToString, True))
                        'End If

                        'If IsDBNull(DateTo) = False Then
                        '    .LocalReport.SetParameters(New ReportParameter("DateTo", DateTo.ToString, True))
                        'End If

                        If IsDBNull(PaymentID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentID", PaymentID.ToString, True))
                        End If

                        If IsDBNull(IsMoneyIn) = False Then
                            .LocalReport.SetParameters(New ReportParameter("IsMoneyIn", IsMoneyIn.ToString, True))
                        End If

                        If IsDBNull(PaymentName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentName", PaymentName.ToString, True))
                        End If

                        If IsDBNull(PaymentNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentNumber", PaymentNumber.ToString, True))
                        End If

                        If IsDBNull(AgentID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentID", AgentID.ToString, True))
                        End If

                        If IsDBNull(AgentName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentName", AgentName.ToString, True))
                        End If

                        If IsDBNull(DistibutorID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DistibutorID", DistibutorID.ToString, True))
                        End If

                        If IsDBNull(DistributorName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DistributorName", DistributorName.ToString, True))
                        End If

                        If IsDBNull(PaymentAmount) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentAmount", PaymentAmount.ToString, True))
                        End If

                        If IsDBNull(PaymentDate) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentDate", PaymentDate.ToString, True))
                        End If

                        If IsDBNull(Note) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Note", Note.ToString, True))
                        End If

                        If IsDBNull(UserID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("UserID", UserID.ToString, True))
                        End If

                        If IsDBNull(Username) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Username", Username.ToString, True))
                        End If

                        Dim PaymentAmountStr As String = CurrencyToString(PaymentAmount)

                        If IsDBNull(PaymentAmountStr) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentAmountStr", PaymentAmountStr.ToString, True))
                        End If

                        '.LocalReport.SetParameters(New ReportParameter("saleID", saleID.ToString, True))
                    End With


                    If req = RequestType.rdlc Then
                        frm.Text = Me.Text
                        FrmMain.AddForm(frm)
                    Else
                        'Dim m As New PrintReport
                        'm.PrintLocalReport(frm.rvReport.LocalReport)

                        print_microsoft_report(frm.rvReport.LocalReport, , , )



                    End If
                End If



            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
#End Region










End Class