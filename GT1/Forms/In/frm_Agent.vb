Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_Agent
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Private Sub frm_Agent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            lblTitle.Text = Me.Text
            daInitialize()

            GetDataTable()
            bs.MoveLast()
            EnableDisableControls(False)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub daInitialize()



        da.SelectCommand = New SqlCommand
        With da.SelectCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Agent_Select"
            .CommandType = CommandType.StoredProcedure
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_Agent_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()
            .Parameters.Add("@AgentID", SqlDbType.BigInt, 0, "AgentID")
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters.Add("@AgentName", SqlDbType.NVarChar, 200, "AgentName")
            .Parameters.Add("@Phone", SqlDbType.NVarChar, 200, "Phone")
            .Parameters.Add("@address", SqlDbType.NVarChar, 200, "address")
            .Parameters.Add("@Note", SqlDbType.NVarChar, 200, "Note")
            .Parameters.Add("@IniBalanceDebit", SqlDbType.Decimal, 0, "IniBalanceDebit")
            .Parameters.Add("@IniBalanceCredit", SqlDbType.Decimal, 0, "IniBalanceCredit")
            .Parameters.Add("@IniBalance", SqlDbType.Decimal, 0, "IniBalance")
            .Parameters("@IniBalance").Direction = ParameterDirection.Output
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Agent_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@AgentID", SqlDbType.BigInt, 0, "AgentID")
            .Parameters.Add("@AgentName", SqlDbType.NVarChar, 200, "AgentName")
            .Parameters.Add("@Phone", SqlDbType.NVarChar, 200, "Phone")
            .Parameters.Add("@address", SqlDbType.NVarChar, 200, "address")
            .Parameters.Add("@Note", SqlDbType.NVarChar, 200, "Note")
            .Parameters.Add("@IniBalanceDebit", SqlDbType.Decimal, 0, "IniBalanceDebit")
            .Parameters.Add("@IniBalanceCredit", SqlDbType.Decimal, 0, "IniBalanceCredit")
            .Parameters.Add("@IniBalance", SqlDbType.Decimal, 0, "IniBalance")
            .Parameters("@IniBalance").Direction = ParameterDirection.Output
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Agent_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@AgentID", SqlDbType.BigInt, 0, "AgentID")
            .Parameters("@AgentID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters("@UserID").SourceVersion = DataRowVersion.Original

        End With



    End Sub

    Private Sub GetDataTable()

        dt.Clear()
        'da.FillSchema(dt, SchemaType.Source)
        da.Fill(dt)

        bs.DataSource = dt
        dgv.DataSource = bs





        With dgv
            .Columns("IniBalanceDebit").Visible = False
            .Columns("IniBalanceCredit").Visible = False



            .Columns("AgentID").HeaderText = "ر.م"
            .Columns("AgentName").HeaderText = "العميل"
            .Columns("Phone").HeaderText = "هاتف"
            .Columns("address").HeaderText = "عنوان"
            .Columns("Note").HeaderText = "ملاحظة"
            .Columns("IniBalanceDebit").HeaderText = "عليه"
            .Columns("IniBalanceCredit").HeaderText = "له"
            .Columns("IniBalance").HeaderText = "رصيد مبدئي"
            .Columns("UserID").HeaderText = "ر.م"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.txtAgentName.DataBindings.Clear()
        Me.txtAgentName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AgentName", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtPhone.DataBindings.Clear()
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Phone", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtaddress.DataBindings.Clear()
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "address", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtNote.DataBindings.Clear()
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Note", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numIniBalanceDebit.DataBindings.Clear()
        Me.numIniBalanceDebit.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "IniBalanceDebit", True, DataSourceUpdateMode.OnPropertyChanged, ""))




        Me.numIniBalanceCredit.DataBindings.Clear()
        Me.numIniBalanceCredit.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "IniBalanceCredit", True, DataSourceUpdateMode.OnPropertyChanged, ""))



        dgv.AutoResizeColumns()
        lblCount.Text = bs.Count

    End Sub


    Private Sub EnableDisableControls(ByVal IsEditting As Boolean)
        If IsEditting = True Then
            SplitContainer1.Panel2.Enabled = False
            btnAdd.Enabled = False
            btnCopy.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnDelete.Enabled = False
            txtSearch.Enabled = False
            SplitContainer1.Panel1.Enabled = True
            PIniBalance.Visible = True


        Else
            SplitContainer1.Panel2.Enabled = True
            btnAdd.Enabled = True
            btnCopy.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            SplitContainer1.Panel1.Enabled = False
            txtSearch.Enabled = True

            PIniBalance.Visible = False



        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            bs.AddNew()
            EnableDisableControls(True)

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
            da.Update(dt)
            dgv.AutoResizeColumns()
            EnableDisableControls(False)
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
            lblCount.Text = bs.Count
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




    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
            txtSearch.Text = ""
        End If

    End Sub
    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text.Trim = "" Then
            txtSearch.Text = "بحث"
        End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
            bs.Filter = ""
        Else
            bs.Filter = "AgentName like '%" & txtSearch.Text & "%'"
        End If
    End Sub

    Private Sub numIniBalanceDebit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numIniBalanceDebit.KeyUp
        Try
            numIniBalanceCredit.Text = ""
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub numIniBalanceCredit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numIniBalanceCredit.KeyUp
        Try
            numIniBalanceDebit.Text = ""
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub




End Class