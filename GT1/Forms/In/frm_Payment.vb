Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_Payment
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Dim _PaymentID As Object  ' dbnull for new
    Dim _MoneyDirectionID As Integer


    Dim _AgentID As Object
    Dim _DistibutorID As Object
    Dim _Amount As Object
    Dim _Note As Object




    Public Enum MoneyDirection
        MoneyIn = 1
        MoneyOut = -1
    End Enum

    Public Sub New(ByVal MoneyDirection As MoneyDirection, Optional ByVal AgentID As Object = Nothing, Optional ByVal DistibutorID As Object = Nothing, Optional ByVal Amount As Object = Nothing, Optional ByVal Note As Object = Nothing)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _PaymentID = DBNull.Value

        _MoneyDirectionID = MoneyDirection

        _AgentID = AgentID
        _DistibutorID = DistibutorID
        _Amount = Amount
        _Note = Note



    End Sub
    Public Sub New(ByVal PaymentID As Int64)

        ' This call is required by the designer.
        InitializeComponent()
        _PaymentID = PaymentID
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_Agent()
            Get_sp_hlp_distributor()

            GetDataTable()
            bs.MoveLast()
            EnableDisableControls(False)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub frm_Payment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try



            If IsDBNull(_PaymentID) Then

                btnAdd_Click(Me, Nothing)
                If Not IsNothing(_AgentID) Then cboAgentID.MySelectedValue = _AgentID : numPaymentAmount.Focus()
                If Not IsNothing(_DistibutorID) Then cboDistributorID.MySelectedValue = _AgentID
                If Not IsNothing(_Amount) Then numPaymentAmount.Text = _Amount
                If Not IsNothing(_Note) Then txtNote.Text = _Note

                lblTitle.Text = IIf(_MoneyDirectionID = 1, "إيصال قبض جديد", "إذن صرف جديد")
                Me.Text = lblTitle.Text


            Else

                btnEdit_Click(Me, Nothing)
                PAgentID.Enabled = False
                PDistributorID.Enabled = False

                lblTitle.Text = IIf(bs.Current("MoneyDirectionID") = 1, "إيصال قبض رقم ", "إذن صرف رقم ")
                lblTitle.Text = lblTitle.Text & bs.Current("TreasuryNumber")
                Me.Text = lblTitle.Text

            End If





            cboDistributorID.MySelectedValue = 1
            PDistributorID.Visible = False
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub daInitialize()



        da.SelectCommand = New SqlCommand
        With da.SelectCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Payment_Select"
            .CommandType = CommandType.StoredProcedure

            .Parameters.AddWithValue("@PaymentID", _PaymentID)
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_Payment_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()
            .Parameters.Add("@PaymentID", SqlDbType.BigInt, 0, "PaymentID")
            .Parameters("@PaymentID").Direction = ParameterDirection.Output
            .Parameters.Add("@TreasuryNumber", SqlDbType.BigInt, 0, "TreasuryNumber")
            .Parameters("@TreasuryNumber").Direction = ParameterDirection.Output

            .Parameters.Add("@TreasuryID", SqlDbType.BigInt, 0, "TreasuryID")
            .Parameters("@TreasuryID").Direction = ParameterDirection.Output

            .Parameters.AddWithValue("@MoneyDirectionID", _MoneyDirectionID)
            .Parameters.Add("@AgentID", SqlDbType.BigInt, 0, "AgentID")
            .Parameters.Add("@AgentName", SqlDbType.NVarChar, 200, "AgentName")
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters.Add("@DistributorID", SqlDbType.BigInt, 0, "DistributorID")
            .Parameters.Add("@DistributorName", SqlDbType.NVarChar, 200, "DistributorName")
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters.Add("@PaymentAmount", SqlDbType.Decimal, 0, "PaymentAmount")
            .Parameters.Add("@PaymentDate", SqlDbType.DateTime, 0, "PaymentDate")
            .Parameters.Add("@Note", SqlDbType.NVarChar, 200, "Note")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Payment_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@PaymentID", SqlDbType.BigInt, 0, "PaymentID")
            .Parameters.Add("@PaymentAmount", SqlDbType.Decimal, 0, "PaymentAmount")
            .Parameters.Add("@PaymentDate", SqlDbType.DateTime, 0, "PaymentDate")
            .Parameters.Add("@Note", SqlDbType.NVarChar, 200, "Note")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Payment_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@PaymentID", SqlDbType.BigInt, 0, "PaymentID")
            .Parameters("@PaymentID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters("@UserID").SourceVersion = DataRowVersion.Original

        End With



    End Sub
    Private Sub Get_sp_hlp_Agent()

        Dim da As New SqlDataAdapter("sp_hlp_Agent", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure



        dt.Clear()
        da.Fill(dt)

        bs.DataSource = dt

        bs.RemoveAt(bs.Find("AgentID", DBNull.Value))
        bs.RemoveAt(bs.Find("AgentID", 1))


        With cboAgentID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "agentID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AgentName", True, "")
            .MyBeginProcess()
        End With


    End Sub
    Private Sub Get_sp_hlp_distributor()

        Dim da As New SqlDataAdapter("sp_hlp_distributor", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        bs.DataSource = dt


        bs.RemoveAt(bs.Find("DistributorID", DBNull.Value))


        With cboDistributorID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "distributorID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "DistributorName", True, "")
            .MyBeginProcess()
        End With


    End Sub

    Private Sub GetDataTable()

        dt.Clear()
        'da.FillSchema(dt, SchemaType.Source)
        da.Fill(dt)

        bs.DataSource = dt
        dgv.DataSource = bs

        With dgv
            .Columns("PaymentID").Visible = False
            .Columns("MoneyDirectionID").Visible = False
            .Columns("AgentID").Visible = False
            .Columns("DistributorID").Visible = False
            .Columns("UserID").Visible = False

            .Columns("TreasuryNumber").HeaderText = "رقم الايصال"
            .Columns("MoneyDirectionName").HeaderText = "المعاملة"
            .Columns("AgentName").HeaderText = "العميل"
            .Columns("DistributorName").HeaderText = "المسوق"
            .Columns("PaymentAmount").HeaderText = "القيمة"
            .Columns("PaymentDate").HeaderText = "التاريخ"
            .Columns("Note").HeaderText = "ملاحظة"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.cboAgentID.DataBindings.Clear()
        Me.cboAgentID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "AgentID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboAgentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AgentName", True, DataSourceUpdateMode.OnValidation))





        Me.cboDistributorID.DataBindings.Clear()
        Me.cboDistributorID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "DistributorID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboDistributorID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "DistributorName", True, DataSourceUpdateMode.OnValidation))





        Me.numPaymentAmount.DataBindings.Clear()
        Me.numPaymentAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "PaymentAmount", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.dtpPaymentDate.DataBindings.Clear()
        Me.dtpPaymentDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "PaymentDate", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtNote.DataBindings.Clear()
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Note", True, DataSourceUpdateMode.OnPropertyChanged))



        dgv.AutoResizeColumns()
        ' lblCount.Text = bs.Count

    End Sub



    Public Sub DeleteEntry(ByVal ID As Int64, ByVal UserID As Int64)
        Try


            If msgShow("هل أنت متأكد من الحدف ؟", ByteClassLibrary.Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then




                Dim cmd As New SqlCommand
                With cmd
                    .Connection = PubCn
                    .CommandText = "sp_tbl_Payment_Delete"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Clear()
                    .Parameters.AddWithValue("@PaymentID", ID)
                    .Parameters.AddWithValue("@UserID", UserID)


                    If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                    cmd.ExecuteNonQuery()
                    If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

                End With


            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try



    End Sub


    Private Sub EnableDisableControls(ByVal IsEditting As Boolean)
        If IsEditting = True Then
            SplitContainer1.Panel2.Enabled = False
            btnAdd.Enabled = False
            'btnCopy.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnDelete.Enabled = False
            ' txtSearch.Enabled = False

            SplitContainer1.Panel1.Enabled = True

        Else
            SplitContainer1.Panel2.Enabled = True
            btnAdd.Enabled = True
            '  btnCopy.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            SplitContainer1.Panel1.Enabled = False
            ' txtSearch.Enabled = True

        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            bs.AddNew()
            EnableDisableControls(True)
            dtpPaymentDate.Value = Now

            cboAgentID.Focus()

            bs.Current("DistributorID") = 1


            'txtClientName.Focus()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs.Current) Then
                Dim newrow As DataRow = dt.NewRow
                newrow.ItemArray = bs.Current.row.ItemArray



                bs.AddNew()
                Dim NewIncrementVal As Int64 = 0

                For Each c As DataColumn In dt.Columns
                    If c.AutoIncrement = True Then
                        NewIncrementVal = bs.Current(c.ColumnName) + 1
                    End If
                Next

                bs.Current.row.ItemArray = newrow.ItemArray
                For Each c As DataColumn In dt.Columns
                    If c.AutoIncrement = True Then
                        bs.Current(c.ColumnName) = NewIncrementVal
                    ElseIf c.Unique = True Then
                        bs.Current(c.ColumnName) = DBNull.Value
                    ElseIf c.ColumnName = "UserID" Then
                        bs.Current(c.ColumnName) = PubUserID
                    ElseIf c.ColumnName = "Username" Then
                        bs.Current(c.ColumnName) = PubUserName
                    End If
                Next

                bs.ResetBindings(False)
                EnableDisableControls(True)
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            EnableDisableControls(True)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            bs.EndEdit()
            Me.Validate()
            da.Update(dt)
            dgv.AutoResizeColumns()
            EnableDisableControls(False)

            _PaymentID = bs.Current("PaymentID")


            lblTitle.Text = IIf(_MoneyDirectionID = 1, "إيصال قبض رقم ", "إذن صرف رقم ")
            lblTitle.Text = lblTitle.Text & bs.Current("TreasuryNumber")
            Me.Text = lblTitle.Text



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Public Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not IsNothing(bs.Current) Then
                If MessageBox.Show("هل أنت متأكد من الحدف ؟", "تحدير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then
                    bs.Remove(bs.Current)
                    da.Update(dt)
                End If
                EnableDisableControls(False)
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            GetDataTable()
            EnableDisableControls(False)

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F12
                    If btnAdd.Enabled = True Then btnAdd.PerformClick()
                Case Keys.F11
                    '  If btnCopy.Enabled = True Then btnCopy.PerformClick()
                Case Keys.F10
                    If btnSave.Enabled = True Then btnSave.PerformClick()
                Case Keys.F5
                    If btnRefresh.Enabled = True Then btnRefresh.PerformClick()
                Case Keys.F2
                    If btnEdit.Enabled = True Then btnEdit.PerformClick()
            End Select
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                btnDelete.PerformClick()
        End Select
    End Sub
    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        HandleMyError(e.Exception)
    End Sub
    Private Sub bs_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs.CurrentChanged
        Try
            '    lblCount.Text = bs.Count
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub bs_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles bs.ListChanged
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged Then
            bs.Current("UserID") = PubUserID
            bs.Current("Username") = PubUserName
            bs.EndEdit()
        End If
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemAdded Then
            bs.Item(e.NewIndex)("UserID") = PubUserID
            bs.Item(e.NewIndex)("Username") = PubUserName
        End If
    End Sub
    Private Sub lblAgentID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAgentID.Click
        Try
            'Dim F As New frm_Agent
            'F.WindowState = FormWindowState.Normal
            'F.StartPosition = FormStartPosition.CenterScreen
            'F.ShowDialog()
            'cboAgentID.DataBindings.Clear()
            'Get_sp_hlp_Agent()
            'Me.cboAgentID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "AgentID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub lblDistributorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDistributorID.Click
        Try
            'Dim F As New frm_Distributor
            'F.WindowState = FormWindowState.Normal
            'F.StartPosition = FormStartPosition.CenterScreen
            'F.ShowDialog()
            'cboDistributorID.DataBindings.Clear()
            'Get_sp_hlp_Distributor()
            'Me.cboDistributorID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "DistributorID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
        '  txtSearch.Text = ""
       '
    End Sub
    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtSearch.Text.Trim = "" Then
        '    txtSearch.Text = "بحث"
        'End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
        '    bs.Filter = ""
        'Else
        '    bs.Filter = "ProductFullName like '%" & txtSearch.Text & "%'"
        'End If
    End Sub








    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try


            If Not IsNothing(bs.Current) AndAlso IsNumeric(bs.Current("TreasuryID")) Then
                Dim f As New frm_sp_rpt_Treasury
                f.numTreasuryID.Text = bs.Current("TreasuryID")
                f.btnView.PerformClick()
            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            If Not IsNothing(bs.Current) AndAlso IsNumeric(bs.Current("TreasuryID")) Then
                Dim f As New frm_sp_rpt_Treasury
                f.numTreasuryID.Text = bs.Current("TreasuryID")
                f.btnPrint.PerformClick()
            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class