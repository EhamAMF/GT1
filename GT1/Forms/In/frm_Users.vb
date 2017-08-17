Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_Users
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Private Sub frm_Users_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_UserType()

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
            .CommandText = "sp_tbl_Users_Select"
            .CommandType = CommandType.StoredProcedure
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_Users_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters.Add("@Password", SqlDbType.NVarChar, 200, "Password")
            .Parameters.Add("@UserLevel", SqlDbType.TinyInt, 0, "UserLevel")
            .Parameters.Add("@IUserID", SqlDbType.BigInt, 0, "IUserID")
            .Parameters.Add("@IUsername", SqlDbType.NVarChar, 50, "IUsername")
            .Parameters("@IUsername").Direction = ParameterDirection.Output

        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Users_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Password", SqlDbType.NVarChar, 200, "Password")
            .Parameters.Add("@UserLevel", SqlDbType.TinyInt, 0, "UserLevel")
            .Parameters.Add("@IUserID", SqlDbType.BigInt, 0, "IUserID")
            .Parameters.Add("@IUsername", SqlDbType.NVarChar, 50, "IUsername")
            .Parameters("@IUsername").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Users_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            ' .Parameters("@UserID").SourceVersion = DataRowVersion.Original

        End With



    End Sub
    Private Sub Get_sp_hlp_UserType()

        Dim da As New SqlDataAdapter("sp_hlp_UserType", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        'dt.Rows.RemoveAt(0)

        With cboUserLevel
            .DataSource = dt
            .DisplayMember = "UserTypeName"
            .ValueMember = "UserTypeID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


    End Sub

    Private Sub GetDataTable()

        dt.Clear()
        'da.FillSchema(dt, SchemaType.Source)
        da.Fill(dt)

        bs.DataSource = dt
        dgv.DataSource = bs

        With dgv
            .Columns("Password").Visible = False
            .Columns("IUserID").Visible = False

            .Columns("UserID").HeaderText = "رقم المستخدم"
            .Columns("Username").HeaderText = "المستخدم"
            .Columns("UserLevel").HeaderText = "المستوى"
            .Columns("IUsername").HeaderText = "المستخدم"

        End With




        Me.txtUsername.DataBindings.Clear()
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Username", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.txtPassword.DataBindings.Clear()
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Password", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.cboUserLevel.DataBindings.Clear()
        Me.cboUserLevel.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", bs, "UserLevel", True, DataSourceUpdateMode.OnPropertyChanged))
        '  Me.cboUserLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "UserTypeName", True, DataSourceUpdateMode.OnValidation))


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

        Else
            SplitContainer1.Panel2.Enabled = True
            btnAdd.Enabled = True
            btnCopy.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            SplitContainer1.Panel1.Enabled = False
            txtSearch.Enabled = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
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
    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
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
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            EnableDisableControls(True)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
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
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
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
    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try
            GetDataTable()
            EnableDisableControls(False)

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
    Private Sub dgv_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                btnDelete.PerformClick()
        End Select
    End Sub
    Private Sub dgv_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        HandleMyError(e.Exception)
    End Sub
    Private Sub bs_CurrentChanged(sender As Object, e As System.EventArgs) Handles bs.CurrentChanged
        Try
            lblCount.Text = bs.Count
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub bs_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bs.ListChanged
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged Then
            bs.Current("iUserID") = PubUserID
            bs.Current("iUsername") = PubUserName
            bs.EndEdit()
        End If
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemAdded Then
            bs.Item(e.NewIndex)("iUserID") = PubUserID
            bs.Item(e.NewIndex)("iUsername") = PubUserName
        End If
    End Sub





    Private Sub txtSearch_GotFocus(sender As Object, e As System.EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
            txtSearch.Text = ""
        End If

    End Sub
    Private Sub txtSearch_LostFocus(sender As Object, e As System.EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text.Trim = "" Then
            txtSearch.Text = "بحث"
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim = "بحث" Then
            bs.Filter = ""
        Else
            bs.Filter = "ProductFullName like '%" & txtSearch.Text & "%'"
        End If
    End Sub





End Class