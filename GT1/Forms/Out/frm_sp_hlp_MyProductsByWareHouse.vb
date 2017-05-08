'frm_sp_hlp_MyProductsByWareHouse
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_hlp_MyProductsByWareHouse

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim WareHouseID As Object
    Dim IsEmptyRealAmoutLeft As Object
    Dim WareHouseName As Object

    Public Sub New(Optional WH As Object = 1)

        ' This call is required by the designer.
        InitializeComponent()

        If IsNothing(WH) Then WareHouseID = 1 Else WareHouseID = WH

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_sp_hlp_MyProductsByWareHouse_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_hlp_MyProductsByWareHouse_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
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
        StockID
        StockName
        Barcode
        AmountLeft
        RealAmountLeft

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
            '.Add(Column.AmountLeft)
            .Add(Column.RealAmountLeft)

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
                .Add(Column.AmountLeft)
                .Add(Column.RealAmountLeft)

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

    Private Function fn_sp_hlp_MyProductsByWareHouse(ByRef WareHouseID As Object, ByRef IsEmptyRealAmoutLeft As Object, ByRef WareHouseName As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_hlp_MyProductsByWareHouse", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@WareHouseID", WareHouseID)
            .AddWithValue("@IsEmptyRealAmoutLeft", IsEmptyRealAmoutLeft)
            .Add("@WareHouseName", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@WareHouseName").Direction = ParameterDirection.Output


            .Parameters("@WareHouseName").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            WareHouseName = .Parameters("@WareHouseName").Value

        End With

        Return dt
    End Function

    'xx__subs and Functions__xx

    Private Sub SetInputParameters()

        '    WareHouseID = MyConvert(numWareHouseID.Text.Trim)
        IsEmptyRealAmoutLeft = True
        WareHouseName = Nothing

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_hlp_MyProductsByWareHouse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            MyTable1 = fn_sp_hlp_MyProductsByWareHouse(WareHouseID, IsEmptyRealAmoutLeft, WareHouseName)
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
                    dgv.Columns("StockID").HeaderText = "ر.م"
                    dgv.Columns("StockName").HeaderText = "الصنف"
                    dgv.Columns("Barcode").HeaderText = "باركود"
                    dgv.Columns("AmountLeft").HeaderText = "الكمية"
                    dgv.Columns("RealAmountLeft").HeaderText = "الكمية الفعلية"



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
                    ReportDataSource.Name = "sp_hlp_MyProductsByWareHouse"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_hlp_MyProductsByWareHouse.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(WareHouseID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("WareHouseID", WareHouseID.ToString, True))
                        End If

                        If IsDBNull(IsEmptyRealAmoutLeft) = False Then
                            .LocalReport.SetParameters(New ReportParameter("IsEmptyRealAmoutLeft", IsEmptyRealAmoutLeft.ToString, True))
                        End If

                        If IsDBNull(WareHouseName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("WareHouseName", WareHouseName.ToString, True))
                        End If



                        '.LocalReport.SetParameters(New ReportParameter("saleID", saleID.ToString, True))
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
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
#End Region









End Class