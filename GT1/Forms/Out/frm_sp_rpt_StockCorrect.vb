'frm_sp_rpt_StockCorrect
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_StockCorrect

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim AmountType As Object
    Dim ExDate As Object
    Dim BrandID As Object
    Dim TypeID As Object
    Dim BrandName As Object
    Dim TypeName As Object


    Public _dt As New DataTable



    Private Sub frm_sp_rpt_StockCorrect_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_StockCorrect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)
          

            GetInitialData()
            lblTitle.Text = Me.Text

            'dtpExDate.Value = "3000-12-31"
            btnSearch.PerformClick()

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
        StockID
        ProductName
        ExDate
        Rack
        TypeName
        BrandName
        AmountLeft
        AmountLeftPacket
        Alert
        SubAmount

        AmountLeftReal
        AmountLeftPacketReal
        AmountLeftDiff
        AmountLeftPacketDiff

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
            .Add(Column.AmountLeft)
            .Add(Column.AmountLeftPacket)
            .Add(Column.SubAmount)

            .Add(Column.AmountLeftReal)
            .Add(Column.AmountLeftPacketReal)
            .Add(Column.AmountLeftDiff)
            .Add(Column.AmountLeftPacketDiff)


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
                .Add(Column.AmountLeft)
                .Add(Column.AmountLeftPacket)
                .Add(Column.SubAmount)

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
        Get_sp_hlp_AmountType()
        Get_sp_hlp_Brand()
        Get_sp_hlp_ProductType()

    End Sub
    Private Sub Get_sp_hlp_AmountType()

        Dim da As New SqlDataAdapter("sp_hlp_AmountType", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboAmountType
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "AmountTypeID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AmountTypeName", True, "")
            .MyBeginProcess()
        End With

    End Sub
    Private Sub Get_sp_hlp_Brand()

        Dim da As New SqlDataAdapter("sp_hlp_Brand", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboBrandID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "BrandID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "BrandName", True, "")
            .MyBeginProcess()
        End With

    End Sub
    Private Sub Get_sp_hlp_ProductType()

        Dim da As New SqlDataAdapter("sp_hlp_ProductType", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboTypeID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "TypeID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "TypeName", True, "")
            .MyBeginProcess()
        End With

    End Sub


    Dim _AmountTypeFilter As String = ""
    Dim _ExDateFilter As String = ""
    Dim _BrandIDFilter As String = ""
    Dim _TypeIDFilter As String = ""

    Private Sub FilterBS()

        MyBs.Filter = ""
        Dim FilterStr As String = ""


        If _AmountTypeFilter <> "" Then
            FilterStr = _AmountTypeFilter
        End If

        If _ExDateFilter <> "" Then
            If FilterStr <> "" Then
                FilterStr = FilterStr & " and " & _ExDateFilter
            Else
                FilterStr = FilterStr & _ExDateFilter
            End If
        End If

        If _BrandIDFilter <> "" Then
            If FilterStr <> "" Then
                FilterStr = FilterStr & " and " & _BrandIDFilter
            Else
                FilterStr = FilterStr & _BrandIDFilter
            End If
        End If

        If _TypeIDFilter <> "" Then
            If FilterStr <> "" Then
                FilterStr = FilterStr & " and " & _TypeIDFilter
            Else
                FilterStr = FilterStr & _TypeIDFilter
            End If
        End If


        MyBs.Filter = FilterStr

    End Sub


    Private Function fn_sp_rpt_StockCorrect(ByRef AmountType As Object, ByRef ExDate As Object, ByRef BrandID As Object, ByRef TypeID As Object, ByRef BrandName As Object, ByRef TypeName As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_StockCorrect", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@AmountType", AmountType)
            .AddWithValue("@ExDate", ExDate)
            .AddWithValue("@BrandID", BrandID)
            .AddWithValue("@TypeID", TypeID)
            .Add("@BrandName", SqlDbType.NVarChar, 200)
            .Add("@TypeName", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters("@TypeName").Direction = ParameterDirection.Output


            .Parameters("@BrandName").Scale = 0
            .Parameters("@TypeName").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            BrandName = .Parameters("@BrandName").Value
            TypeName = .Parameters("@TypeName").Value

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




        AmountType = DBNull.Value
        ExDate = DBNull.Value
        BrandID = DBNull.Value
        TypeID = DBNull.Value

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_StockCorrect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub dgv_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting


        Dim CellAmountLeft As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeft")
        Dim CellAmountLeftPacket As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftPacket")
        Dim CellAmountLeftReal As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftReal")
        Dim CellAmountLeftPacketReal As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftPacketReal")
        Dim SubAmount As Object = dgv.Rows(e.RowIndex).Cells("SubAmount").Value

        If IsDBNull(SubAmount) OrElse SubAmount <= 1 Then
            dgv.Rows(e.RowIndex).Cells("AmountLeftPacketReal").ReadOnly = True
        Else
            dgv.Rows(e.RowIndex).Cells("AmountLeftPacketReal").ReadOnly = False
        End If



        CellAmountLeftReal.ToolTipText = "الكمية قبل التغير = " & CellAmountLeft.Value.ToString
        CellAmountLeftPacketReal.ToolTipText = "الكمية قبل التغير = " & CellAmountLeftPacket.Value.ToString


        If dgv.Rows(e.RowIndex).Cells("AmountLeftDiff").Value > 0 Then
            dgv.Rows(e.RowIndex).Cells("AmountLeftDiff").Style.BackColor = Color.PaleGreen
            dgv.Rows(e.RowIndex).Cells("AmountLeftPacketDiff").Style.BackColor = Color.PaleGreen
        ElseIf dgv.Rows(e.RowIndex).Cells("AmountLeftDiff").Value < 0 Then
            dgv.Rows(e.RowIndex).Cells("AmountLeftDiff").Style.BackColor = Color.PaleVioletRed
            dgv.Rows(e.RowIndex).Cells("AmountLeftPacketDiff").Style.BackColor = Color.PaleVioletRed
        End If

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
    Private Sub chkAllPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub


    Private Sub cboAmountType_MyItemSelectedByEnter(ByVal ItemID As Object) Handles cboAmountType.MyItemSelectedByEnter
        Try


            Dim filterstr As String = ""

            If IsDBNull(cboAmountType.MySelectedValue) Then
                filterstr = ""
            ElseIf cboAmountType.MySelectedValue = -1 Then
                filterstr = "AmountLeft <  0"
            ElseIf cboAmountType.MySelectedValue = 0 Then
                filterstr = "AmountLeft =  0"
            ElseIf cboAmountType.MySelectedValue = 1 Then
                filterstr = "AmountLeft >  0"
            End If

            _AmountTypeFilter = filterstr
            FilterBS()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub dtpExDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpExDate.ValueChanged
        Try



            Dim filterstr As String = ""

            'filterstr = "ExDate < " & """" & Format(dtpExDate.Value, "yyyy-MM-dd") & """"

            filterstr = "ExDate < " & String.Format("#{0:yyyy/MM/dd HH:mm:ss}#", dtpExDate.Value)


            _ExDateFilter = filterstr
            FilterBS()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub cboBrandID_MyItemSelectedByEnter(ByVal ItemID As Object) Handles cboBrandID.MyItemSelectedByEnter
        Try

            Dim filterstr As String = ""
            If Not IsDBNull(cboBrandID.MySelectedValue) Then
                filterstr = "BrandID = " & cboBrandID.MySelectedValue
            End If

            _BrandIDFilter = filterstr
            FilterBS()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub cboTypeID_MyItemSelectedByEnter(ByVal ItemID As Object) Handles cboTypeID.MyItemSelectedByEnter
        Try

            Dim filterstr As String = ""
            If Not IsDBNull(cboTypeID.MySelectedValue) Then
                filterstr = "TypeID = " & cboTypeID.MySelectedValue
            End If

            _TypeIDFilter = filterstr
            FilterBS()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Try

            Dim AmountLeft As Object = dgv.Rows(e.RowIndex).Cells("AmountLeft").Value
            Dim AmountLeftPacket As Object = dgv.Rows(e.RowIndex).Cells("AmountLeftPacket").Value

            Dim SubAmount As Object = dgv.Rows(e.RowIndex).Cells("SubAmount").Value

            Dim AmountLeftReal As Object = dgv.Rows(e.RowIndex).Cells("AmountLeftReal").Value
            Dim AmountLeftPacketReal As Object = dgv.Rows(e.RowIndex).Cells("AmountLeftPacketReal").Value
            Dim AmountLeftDiff As Object = dgv.Rows(e.RowIndex).Cells("AmountLeftDiff").Value
            Dim AmountLeftPacketDiff As Object = dgv.Rows(e.RowIndex).Cells("AmountLeftPacketDiff").Value



            Dim CellAmountLeft As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeft")
            Dim CellAmountLeftPacket As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftPacket")

            Dim CellAmountLeftReal As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftReal")
            Dim CellAmountLeftPacketReal As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftPacketReal")
            Dim CellAmountLeftDiff As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftDiff")
            Dim CellAmountLeftPacketDiff As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("AmountLeftPacketDiff")

            Dim CellIsPacket As DataGridViewCell = dgv.Rows(e.RowIndex).Cells("IsPacket")


            If IsDBNull(SubAmount) OrElse SubAmount <= 1 Then
                SubAmount = 0
            End If


            Select Case dgv.Columns(e.ColumnIndex).Name
                Case "AmountLeftReal"
                    AmountLeftDiff = AmountLeftReal - AmountLeft

                    If SubAmount <> 0 Then
                        AmountLeftPacketReal = AmountLeftReal / SubAmount
                        AmountLeftPacketDiff = AmountLeftPacketReal - AmountLeftPacket
                    End If


                    CellIsPacket.Value = False
                Case "AmountLeftPacketReal"

                    If SubAmount <> 0 Then

                        AmountLeftReal = AmountLeftPacketReal * SubAmount
                        AmountLeftDiff = AmountLeftReal - AmountLeft
                        AmountLeftPacketDiff = AmountLeftPacketReal - AmountLeftPacket

                        CellIsPacket.Value = True
                    Else


                    End If



            End Select


   




            CellAmountLeftReal.Value = AmountLeftReal
            CellAmountLeftPacketReal.Value = AmountLeftPacketReal
            CellAmountLeftDiff.Value = AmountLeftDiff
            CellAmountLeftPacketDiff.Value = AmountLeftPacketDiff





        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_StockCorrect(AmountType, ExDate, BrandID, TypeID, BrandName, TypeName)
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


                    For Each C As DataGridViewColumn In dgv.Columns
                        C.Visible = False
                    Next

      


                    dgv.Columns("StockID").Visible = True
                    dgv.Columns("ProductName").Visible = True
                    dgv.Columns("SubAmount").Visible = True
                    dgv.Columns("ExDate").Visible = True
                    dgv.Columns("AmountLeftReal").Visible = True
                    dgv.Columns("AmountLeftPacketReal").Visible = True
                    dgv.Columns("AmountLeftDiff").Visible = True
                    dgv.Columns("AmountLeftPacketDiff").Visible = True




                    dgv.Columns("StockID").HeaderText = "ر.م"
                    dgv.Columns("ProductName").HeaderText = "اسم الصنف"
                    dgv.Columns("ExDate").HeaderText = "الصلاحية"
                    dgv.Columns("Rack").HeaderText = "الرف"
                    dgv.Columns("TypeName").HeaderText = "النوع"
                    dgv.Columns("BrandName").HeaderText = "الماركة"
                    dgv.Columns("AmountLeftReal").HeaderText = "الكمية المتبقية"
                    dgv.Columns("AmountLeftPacketReal").HeaderText = "الكمية المتبقية ص"
                    dgv.Columns("Alert").HeaderText = ""
                    dgv.Columns("SubAmount").HeaderText = "العبوة"

                    dgv.Columns("AmountLeftDiff").HeaderText = "الفرق"
                    dgv.Columns("AmountLeftPacketDiff").HeaderText = "الفرق ص"

                    For Each C As DataGridViewColumn In dgv.Columns
                        C.ReadOnly = True
                    Next

                    dgv.Columns("AmountLeftReal").ReadOnly = False
                    dgv.Columns("AmountLeftPacketReal").ReadOnly = False
                    dgv.Columns("AmountLeftDiff").ReadOnly = False
                    dgv.Columns("AmountLeftPacketDiff").ReadOnly = False



                    ' GetTotal()
                    DgvDecimalFormat()
                    FormatSumRow()
                    lblCount.Text = MyBs.Count - 1

                    For Each c As DataGridViewColumn In dgv.Columns
                        If c.ValueType.ToString = "System.DateTime" Then
                            c.DefaultCellStyle.Format = "yyyy-MM-dd"
                        End If
                    Next

                    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

                Else

                    Dim ReportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
                    ReportDataSource.Name = "sp_rpt_StockCorrect"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_StockCorrect.rdlc"

                        .LocalReport.DataSources.Add(ReportDataSource)
                        .LocalReport.EnableExternalImages = True

                        .LocalReport.SetParameters(New ReportParameter("imgHeader", "file:///" & My.Application.Info.DirectoryPath & "\per\imgHeader.jpg", True))
                        .LocalReport.SetParameters(New ReportParameter("imgFooter", "file:///" & My.Application.Info.DirectoryPath & "\per\imgFooter.jpg", True))



                        If IsDBNull(AmountType) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AmountType", AmountType.ToString, True))
                        End If

                        If IsDBNull(ExDate) = False Then
                            .LocalReport.SetParameters(New ReportParameter("ExDate", ExDate.ToString, True))
                        End If

                        If IsDBNull(BrandID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("BrandID", BrandID.ToString, True))
                        End If

                        If IsDBNull(TypeID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TypeID", TypeID.ToString, True))
                        End If

                        If IsDBNull(BrandName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("BrandName", BrandName.ToString, True))
                        End If

                        If IsDBNull(TypeName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("TypeName", TypeName.ToString, True))
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
            HandleMyError(ex)
        End Try
    End Sub
#End Region



    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton1.Click
        Try

            _dt.Clear()
            _dt = MyTable1.Clone


            For Each r As DataRow In MyTable1.Rows
                If r.Item("AmountLeftDiff") <> 0 Then
                    _dt.Rows.Add(r.ItemArray)
                End If
            Next

            Me.Close()



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class