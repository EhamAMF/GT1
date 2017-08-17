Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_OtherPayment
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Dim _OtherPaymentID As Object = DBNull.Value
    Dim _MoneyDirection As MoneyDirection = 0


    Enum MoneyDirection
        MoneyIn = 1
        MoneyOut = -1
    End Enum

    Public Sub New(ByVal MDirection As MoneyDirection)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _MoneyDirection = MDirection


    End Sub
    Public Sub New(ByVal opid As Int64)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _OtherPaymentID = opid


    End Sub



    Private Sub frm_OtherPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_OtherPaymentAcount()

            GetDataTable()
            bs.MoveLast()
            EnableDisableControls(False)

            SplitContainer1.Panel2Collapsed = True


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub frm_OtherPayment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try

            If (_MoneyDirection <> 0) Then
                If _MoneyDirection = MoneyDirection.MoneyIn Then
                    lblTitle.Text = "قبض | جديد"
                Else
                    lblTitle.Text = "صرف | جديد"
                End If

            Else

                Dim md As MoneyDirection = bs.Current("MoneyDirectionID")
                Dim tn As Int64 = bs.Current("TreasuryNumber")

                If md = MoneyDirection.MoneyIn Then
                    lblTitle.Text = "قبض | " & tn.ToString
                Else
                    lblTitle.Text = "صرف | " & tn.ToString
                End If


            End If

            Me.Text = lblTitle.Text



            If IsDBNull(_OtherPaymentID) Then
                btnAdd_Click(Me, Nothing)
            Else
                btnEdit_Click(Me, Nothing)
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub daInitialize()



        da.SelectCommand = New SqlCommand
        With da.SelectCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_OtherPayment_Select"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Clear()
            .Parameters.AddWithValue("@OtherPaymentID", _OtherPaymentID)
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_OtherPayment_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()
            .Parameters.Add("@OtherPaymentID", SqlDbType.BigInt, 0, "OtherPaymentID")
            .Parameters("@OtherPaymentID").Direction = ParameterDirection.Output

            .Parameters.Add("@TreasuryNumber", SqlDbType.BigInt, 0, "TreasuryNumber")
            .Parameters("@TreasuryNumber").Direction = ParameterDirection.Output

            .Parameters.Add("@OtherPaymentAcountID", SqlDbType.BigInt, 0, "OtherPaymentAcountID")
            .Parameters.Add("@OtherPaymentAcountName", SqlDbType.NVarChar, 200, "OtherPaymentAcountName")
            .Parameters("@OtherPaymentAcountName").Direction = ParameterDirection.Output

            .Parameters.AddWithValue("@MoneyDirectionID", _MoneyDirection)
            .Parameters("@MoneyDirectionID").Direction = ParameterDirection.InputOutput

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
            .CommandText = "sp_tbl_OtherPayment_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@OtherPaymentID", SqlDbType.BigInt, 0, "OtherPaymentID")
            .Parameters.Add("@OtherPaymentAcountID", SqlDbType.BigInt, 0, "OtherPaymentAcountID")
            .Parameters.Add("@OtherPaymentAcountName", SqlDbType.NVarChar, 200, "OtherPaymentAcountName")
            .Parameters("@OtherPaymentAcountName").Direction = ParameterDirection.Output
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
            .CommandText = "sp_tbl_OtherPayment_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@OtherPaymentID", SqlDbType.BigInt, 0, "OtherPaymentID")
            .Parameters("@OtherPaymentID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters("@UserID").SourceVersion = DataRowVersion.Original

        End With



    End Sub
    Private Sub Get_sp_hlp_OtherPaymentAcount()

        Dim da As New SqlDataAdapter("sp_hlp_OtherPaymentAcount", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        dt.Rows.RemoveAt(0)
        bs.DataSource = dt



        With cboOtherPaymentAcountID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyComboBoxGrid.ColType.ValueMember, "OtherPaymentAcountID", False, "")
            .SetColumn(ByteClassLibrary.MyComboBoxGrid.ColType.DisplayMember, "OtherPaymentAcountName", True, "")
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
            .Columns("OtherPaymentAcountID").Visible = False
            .Columns("MoneyDirectionID").Visible = False
            .Columns("UserID").Visible = False

            .Columns("OtherPaymentID").HeaderText = "ر.م"
            .Columns("OtherPaymentAcountName").HeaderText = "اسم الحساب"
            .Columns("PaymentAmount").HeaderText = "القيمة"
            .Columns("PaymentDate").HeaderText = "التاريخ"
            .Columns("Note").HeaderText = "ملاحظة"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.cboOtherPaymentAcountID.DataBindings.Clear()
        Me.cboOtherPaymentAcountID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "OtherPaymentAcountID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboOtherPaymentAcountID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "OtherPaymentAcountName", True, DataSourceUpdateMode.OnValidation))





        Me.numPaymentAmount.DataBindings.Clear()
        Me.numPaymentAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "PaymentAmount", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.dtpPaymentDate.DataBindings.Clear()
        Me.dtpPaymentDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "PaymentDate", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtNote.DataBindings.Clear()
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Note", True, DataSourceUpdateMode.OnPropertyChanged))



        dgv.AutoResizeColumns()


    End Sub



    Public Sub DeleteEntry(ByVal ID As Int64, ByVal UserID As Int64)
        Try


            If msgShow("هل أنت متأكد من الحدف ؟", ByteClassLibrary.Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then




                Dim cmd As New SqlCommand
                With cmd
                    .Connection = PubCn
                    .CommandText = "sp_tbl_OtherPayment_Delete"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Clear()
                    .Parameters.AddWithValue("@OtherPaymentID", ID)
                    .Parameters.AddWithValue("@UserID", UserID)


                    If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                    cmd.ExecuteNonQuery()
                    If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

                End With


            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try



    End Sub



    Private Sub EnableDisableControls(ByVal IsEditting As Boolean)
        If IsEditting = True Then
            SplitContainer1.Panel2.Enabled = False
            btnAdd.Enabled = False
            btnCopy.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnDelete.Enabled = False


            SplitContainer1.Panel1.Enabled = True

        Else
            SplitContainer1.Panel2.Enabled = True
            btnAdd.Enabled = True
            btnCopy.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            SplitContainer1.Panel1.Enabled = False


        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            bs.AddNew()
            EnableDisableControls(True)
            dtpPaymentDate.Value = Now
            For Each c As Control In SplitContainer1.Panel1.Controls
                If c.GetType.BaseType.Name <> "" Then
                    c.Focus()
                    Exit For
                End If
            Next


            'txtClientName.Focus()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
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
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            EnableDisableControls(True)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            bs.EndEdit()
            Me.Validate()

            Dim o As Object = dt.GetChanges



            da.Update(dt)
            dgv.AutoResizeColumns()
            EnableDisableControls(False)


            Dim md As Object = bs.Current("MoneyDirectionID")
            If IsDBNull(md) Then md = _MoneyDirection



            Dim tn As Int64 = bs.Current("TreasuryNumber")

            If md = MoneyDirection.MoneyIn Then
                lblTitle.Text = "إيداع | " & tn.ToString
            Else
                lblTitle.Text = "سحب | " & tn.ToString
            End If





        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not IsNothing(bs.Current) Then
                If MessageBox.Show("هل أنت متأكد من الحدف ؟", "تحدير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then
                    bs.Remove(bs.Current)
                    da.Update(dt)
                End If
                EnableDisableControls(False)
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            GetDataTable()
            EnableDisableControls(False)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F12
                    If btnAdd.Enabled = True Then btnAdd.PerformClick()
                Case Keys.F11
                    If btnCopy.Enabled = True Then btnCopy.PerformClick()
                Case Keys.F10
                    If btnSave.Enabled = True Then btnSave.PerformClick()
                Case Keys.F5
                    If btnRefresh.Enabled = True Then btnRefresh.PerformClick()
                Case Keys.F2
                    If btnEdit.Enabled = True Then btnEdit.PerformClick()
            End Select
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
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




        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
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
    Private Sub lblOtherPaymentAcountID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOtherPaymentAcountID.Click
        Try
            Dim F As New frm_OtherPaymentAcount
            F.WindowState = FormWindowState.Normal
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
            cboOtherPaymentAcountID.DataBindings.Clear()
            Get_sp_hlp_OtherPaymentAcount()
            Me.cboOtherPaymentAcountID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "OtherPaymentAcountID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub




    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
     
    End Sub






    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(SplitContainer1.Panel2Collapsed.ToString)
        SplitContainer1.Panel2Collapsed = False
    End Sub
End Class