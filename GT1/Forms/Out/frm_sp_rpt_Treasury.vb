'frm_sp_rpt_Treasury
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_Treasury

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim TreasuryID As Object
    Dim MoneyDirectionID As Object
    Dim TreasuryNumber As Object
    Dim PaymentDate As Object
    Dim PaymentAmount As Object
    Dim AcountName As Object
    Dim InvoiceNumber As Object
    Dim AgentName As Object
    Dim ExpenseType As Object
    Dim OtherPaymentAcountName As Object
    Dim Note As Object
    Dim AgentBalance As Object
    Dim AccountID As Object
    Dim InvoiceTypeName As Object
    Dim DateFetched As Object
    Dim UserName As Object



    Private Sub frm_sp_rpt_Treasury_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_Treasury_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)

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
        t

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
            '
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

    Private Function fn_sp_rpt_Treasury(ByRef TreasuryID As Object, ByRef MoneyDirectionID As Object, ByRef TreasuryNumber As Object, ByRef PaymentDate As Object, ByRef PaymentAmount As Object, ByRef AcountName As Object, ByRef InvoiceNumber As Object, ByRef AgentName As Object, ByRef ExpenseType As Object, ByRef OtherPaymentAcountName As Object, ByRef Note As Object, ByRef AgentBalance As Object, ByRef AccountID As Object, ByRef InvoiceTypeName As Object, ByRef DateFetched As Object, ByRef UserName As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Treasury", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@TreasuryID", TreasuryID)
            .Add("@MoneyDirectionID", SqlDbType.Int, 0)
            .Add("@TreasuryNumber", SqlDbType.BigInt, 0)
            .Add("@PaymentDate", SqlDbType.DateTime, 0)
            .Add("@PaymentAmount", SqlDbType.Decimal, 0)
            .Add("@AcountName", SqlDbType.NVarChar, 200)
            .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@ExpenseType", SqlDbType.NVarChar, 200)
            .Add("@OtherPaymentAcountName", SqlDbType.NVarChar, 200)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@AgentBalance", SqlDbType.Decimal, 0)
            .Add("@AccountID", SqlDbType.BigInt, 0)
            .Add("@InvoiceTypeName", SqlDbType.NVarChar, 200)
            .Add("@DateFetched", SqlDbType.DateTime, 0)
            .Add("@UserName", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@MoneyDirectionID").Direction = ParameterDirection.Output
            .Parameters("@TreasuryNumber").Direction = ParameterDirection.Output
            .Parameters("@PaymentDate").Direction = ParameterDirection.Output
            .Parameters("@PaymentAmount").Direction = ParameterDirection.Output
            .Parameters("@AcountName").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@ExpenseType").Direction = ParameterDirection.Output
            .Parameters("@OtherPaymentAcountName").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@AgentBalance").Direction = ParameterDirection.Output
            .Parameters("@AccountID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeName").Direction = ParameterDirection.Output
            .Parameters("@DateFetched").Direction = ParameterDirection.Output
            .Parameters("@UserName").Direction = ParameterDirection.Output


            .Parameters("@MoneyDirectionID").Scale = 0
            .Parameters("@TreasuryNumber").Scale = 0
            .Parameters("@PaymentDate").Scale = 0
            .Parameters("@PaymentAmount").Scale = 3
            .Parameters("@AcountName").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@ExpenseType").Scale = 0
            .Parameters("@OtherPaymentAcountName").Scale = 0
            .Parameters("@Note").Scale = 0
            .Parameters("@AgentBalance").Scale = 3
            .Parameters("@AccountID").Scale = 0
            .Parameters("@InvoiceTypeName").Scale = 0
            .Parameters("@DateFetched").Scale = 0
            .Parameters("@UserName").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            MoneyDirectionID = .Parameters("@MoneyDirectionID").Value
            TreasuryNumber = .Parameters("@TreasuryNumber").Value
            PaymentDate = .Parameters("@PaymentDate").Value
            PaymentAmount = .Parameters("@PaymentAmount").Value
            AcountName = .Parameters("@AcountName").Value
            InvoiceNumber = .Parameters("@InvoiceNumber").Value
            AgentName = .Parameters("@AgentName").Value
            ExpenseType = .Parameters("@ExpenseType").Value
            OtherPaymentAcountName = .Parameters("@OtherPaymentAcountName").Value
            Note = .Parameters("@Note").Value
            AgentBalance = .Parameters("@AgentBalance").Value
            AccountID = .Parameters("@AccountID").Value
            InvoiceTypeName = .Parameters("@InvoiceTypeName").Value
            DateFetched = .Parameters("@DateFetched").Value
            UserName = .Parameters("@UserName").Value

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

        TreasuryID = MyConvert(numTreasuryID.Text.Trim)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_Treasury_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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





    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_Treasury(TreasuryID, MoneyDirectionID, TreasuryNumber, PaymentDate, PaymentAmount, AcountName, InvoiceNumber, AgentName, ExpenseType, OtherPaymentAcountName, Note, AgentBalance, AccountID, InvoiceTypeName, DateFetched, UserName)
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


                    dgv.Columns("t").HeaderText = ""



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
                    ReportDataSource.Name = "sp_rpt_Treasury"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & "." & Settings.TreasuryLayout

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(TreasuryID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TreasuryID", TreasuryID.ToString, True))
                        End If

                        If IsDBNull(MoneyDirectionID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("MoneyDirectionID", MoneyDirectionID.ToString, True))
                        End If

                        If IsDBNull(TreasuryNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TreasuryNumber", TreasuryNumber.ToString, True))
                        End If

                        If IsDBNull(PaymentDate) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentDate", PaymentDate.ToString, True))
                        End If

                        If IsDBNull(PaymentAmount) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentAmount", PaymentAmount.ToString, True))
                        End If

                        If IsDBNull(AcountName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AcountName", AcountName.ToString, True))
                        End If

                        If IsDBNull(InvoiceNumber) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceNumber", InvoiceNumber.ToString, True))
                        End If

                        If IsDBNull(AgentName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentName", AgentName.ToString, True))
                        End If

                        If IsDBNull(ExpenseType) = False Then
                            .LocalReport.SetParameters(New ReportParameter("ExpenseType", ExpenseType.ToString, True))
                        End If

                        If IsDBNull(OtherPaymentAcountName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("OtherPaymentAcountName", OtherPaymentAcountName.ToString, True))
                        End If

                        If IsDBNull(Note) = False Then
                            .LocalReport.SetParameters(New ReportParameter("Note", Note.ToString, True))
                        End If

                        If IsDBNull(AgentBalance) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentBalance", AgentBalance.ToString, True))
                        End If

                        If IsDBNull(AccountID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AccountID", AccountID.ToString, True))
                        End If

                        If IsDBNull(InvoiceTypeName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("InvoiceTypeName", InvoiceTypeName.ToString, True))
                        End If

                        If IsDBNull(DateFetched) = False Then
                            .LocalReport.SetParameters(New ReportParameter("DateFetched", DateFetched.ToString, True))
                        End If

                        If IsDBNull(UserName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("UserName", UserName.ToString, True))
                        End If


                        Dim PaymentAmountSTR As String = ByteClassLibrary.MyFunctions.CurrencyToString(PaymentAmount)
                        If IsDBNull(PaymentAmountSTR) = False Then
                            .LocalReport.SetParameters(New ReportParameter("PaymentAmountSTR", PaymentAmountSTR.ToString, True))
                        End If


                        .LocalReport.SetParameters(New ReportParameter("Header", Settings.HeaderSTR, True))
                        .LocalReport.SetParameters(New ReportParameter("Footer", Settings.FooterSTR, True))

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
            HandleMyError(ex)
        End Try
    End Sub
#End Region









End Class