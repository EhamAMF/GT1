'frm_sp_rpt_Agents_Balance
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
'Form_temp
Public Class frm_sp_rpt_Agents_Balance

    Dim IsSumExist As Boolean = False

    Dim IsBW1Canseled As Boolean = False
    Dim req As RequestType = RequestType.dgv
    Dim IsRDLCRequest As Boolean = False

    Dim Myda1 As New SqlDataAdapter("sp_rpt_Product_Money", PubCn)
    Dim MyTable1 As New DataTable
    Dim MyBs As New BindingSource

    Dim AgentID As Object
    Dim AgentAmountTypeID As Object
    Dim AgentName As Object
    Dim AgentAmountTypename As Object



    Private Sub frm_sp_rpt_Agents_Balance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bw1.IsBusy = True AndAlso bw1.CancellationPending = False Then
            bw1.CancelAsync()
        End If
    End Sub
    Private Sub frm_sp_rpt_Agents_Balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FontMyControl(Me)

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
        AgentID
        AgentName
        Balance

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
            .Add(Column.Balance)

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
                .Add(Column.Balance)

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
        Get_sp_hlp_Agent()
        Get_sp_hlp_AgentAmountType()

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
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "AgentID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AgentName", True, "")
            .MyBeginProcess()
        End With

    End Sub
    Private Sub Get_sp_hlp_AgentAmountType()

        Dim da As New SqlDataAdapter("sp_hlp_AgentAmountType", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt

        With cboAgentAmountTypeID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "AgentAmountTypeID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AgentAmountTypeName", True, "")
            .MyBeginProcess()
        End With

    End Sub

    Private Function fn_sp_rpt_Agents_Balance(ByRef AgentID As Object, ByRef AgentAmountTypeID As Object, ByRef AgentName As Object, ByRef AgentAmountTypename As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Agents_Balance", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@AgentID", AgentID)
            .AddWithValue("@AgentAmountTypeID", AgentAmountTypeID)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@AgentAmountTypename", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@AgentAmountTypename").Direction = ParameterDirection.Output


            .Parameters("@AgentName").Scale = 0
            .Parameters("@AgentAmountTypename").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            AgentName = .Parameters("@AgentName").Value
            AgentAmountTypename = .Parameters("@AgentAmountTypename").Value

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

        AgentID = MyConvert(cboAgentID.MySelectedValue)
        AgentAmountTypeID = MyConvert(cboAgentAmountTypeID.MySelectedValue)

        MyTable1.Clear()
    End Sub


#End Region
#Region "       Events"

    Private Sub frm_sp_rpt_Agents_Balance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub bw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork

        Try
            MyTable1.Clear()
            'MyTable1 = fn_sp_rpt_Product_Money(ItemTypeID, ItemTypeName, AgentID, AgentName, TypeID, TypeName, BrandID, BrandName, DateFrm, DateTo)
            MyTable1 = fn_sp_rpt_Agents_Balance(AgentID, AgentAmountTypeID, AgentName, AgentAmountTypename)
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


                    dgv.Columns("AgentID").HeaderText = "ر.م"
                    dgv.Columns("AgentName").HeaderText = "العميل"
                    dgv.Columns("Balance").HeaderText = "الرصيد"



                    GetTotal()
                    DgvDecimalFormat()
                    FormatSumRow()
                    lblCount.Text = MyBs.Count - 1

                    For Each c As DataGridViewColumn In dgv.Columns
                        If c.ValueType.ToString = "System.DateTime" Then
                            c.DefaultCellStyle.Format = "yyyy-M-d    H:M  "
                        End If
                    Next

                    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

                Else

                    Dim ReportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
                    ReportDataSource.Name = "sp_rpt_Agents_Balance"
                    ReportDataSource.Value = MyTable1

                    Dim frm As New frmReportViewer

                    With frm.rvReport
                        .LocalReport.ReportEmbeddedResource = My.Application.Info.AssemblyName & ".rpt_sp_rpt_Agents_Balance.rdlc"

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

                        If IsDBNull(AgentID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentID", AgentID.ToString, True))
                        End If

                        If IsDBNull(AgentAmountTypeID) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentAmountTypeID", AgentAmountTypeID.ToString, True))
                        End If

                        If IsDBNull(AgentName) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentName", AgentName.ToString, True))
                        End If

                        If IsDBNull(AgentAmountTypename) = False Then
                            .LocalReport.SetParameters(New ReportParameter("AgentAmountTypename", AgentAmountTypename.ToString, True))
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
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
#End Region









End Class