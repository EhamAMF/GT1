Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions

Public Class frm_Stock
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Dim _StockID As Object
    Dim _UnitCost As Object
    Dim _Amount As Object




    Private Sub frm_Stock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim mf As New MyFonts
            mf.FontMyControl(Me)

            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_ProductType()
            Get_sp_hlp_Brand()

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
            .CommandText = "sp_tbl_Stock_Select"
            .CommandType = CommandType.StoredProcedure
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_Stock_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()
            .Parameters.Add("@Barcode", SqlDbType.NVarChar, 200, "Barcode")
            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")
            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 500, "ProductDetails")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@SubAmount", SqlDbType.Int, 0, "SubAmount")
            .Parameters.Add("@PacketSellPrice", SqlDbType.Decimal, 0, "PacketSellPrice")
            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters("@StockID").Direction = ParameterDirection.Output
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters("@ProductID").Direction = ParameterDirection.Output
            .Parameters.Add("@ProductFullName", SqlDbType.NVarChar, 200, "ProductFullName")
            .Parameters("@ProductFullName").Direction = ParameterDirection.Output
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@Username", SqlDbType.NVarChar, 200, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Stock_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")
            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 500, "ProductDetails")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@SubAmount", SqlDbType.Int, 0, "SubAmount")
            .Parameters.Add("@PacketSellPrice", SqlDbType.Decimal, 0, "PacketSellPrice")
            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@ProductFullName", SqlDbType.NVarChar, 200, "ProductFullName")
            .Parameters("@ProductFullName").Direction = ParameterDirection.Output
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@Username", SqlDbType.NVarChar, 200, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Stock_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "@StockID")
            .Parameters("@StockID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "@ProductID")
            .Parameters("@ProductID").SourceVersion = DataRowVersion.Original

        End With



    End Sub
    Private Sub Get_sp_hlp_ProductType()

        Dim da As New SqlDataAdapter("sp_hlp_ProductType", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        dt.Rows.RemoveAt(0)

        With cboTypeID
            .DataSource = dt
            .DisplayMember = "TypeName"
            .ValueMember = "TypeID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


    End Sub
    Private Sub Get_sp_hlp_Brand()

        Dim da As New SqlDataAdapter("sp_hlp_Brand", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        dt.Rows.RemoveAt(0)

        With cboBrandID
            .DataSource = dt
            .DisplayMember = "BrandName"
            .ValueMember = "BrandID"

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
            .Columns("ProductID").Visible = False
            .Columns("TypeID").Visible = False
            .Columns("BrandID").Visible = False
            .Columns("UserID").Visible = False

            .Columns("StockID").HeaderText = "ر.م"
            .Columns("Barcode").HeaderText = "باركود"
            .Columns("ProductFullName").HeaderText = "الاسم"
            .Columns("TypeName").HeaderText = "النوع"
            .Columns("BrandName").HeaderText = "الماركة"
            .Columns("ProductName").HeaderText = "الاسم"
            .Columns("ProductDetails").HeaderText = "التفاصيل"
            .Columns("UnitCost").HeaderText = "التكلفة"
            .Columns("SellPrice").HeaderText = "سعر البيع"
            .Columns("SubAmount").HeaderText = "الوحدات"
            .Columns("PacketSellPrice").HeaderText = "سعر الصندوق"
            .Columns("AlertAmount").HeaderText = "الكمية الحرجة"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.txtBarcode.DataBindings.Clear()
        Me.txtBarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Barcode", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.cboTypeID.DataBindings.Clear()
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "TypeName", True, DataSourceUpdateMode.OnValidation))



        Me.cboBrandID.DataBindings.Clear()
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "BrandName", True, DataSourceUpdateMode.OnValidation))



        Me.txtProductName.DataBindings.Clear()
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductName", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.txtProductDetails.DataBindings.Clear()
        Me.txtProductDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductDetails", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numSellPrice.DataBindings.Clear()
        Me.numSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SellPrice", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numSubAmount.DataBindings.Clear()
        Me.numSubAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SubAmount", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numPacketSellPrice.DataBindings.Clear()
        Me.numPacketSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "PacketSellPrice", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numAlertAmount.DataBindings.Clear()
        Me.numAlertAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AlertAmount", True, DataSourceUpdateMode.OnPropertyChanged))

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
    Private Sub lblTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTypeID.Click
        Try
            'Dim F As New frm_Type
            'F.WindowState = FormWindowState.Normal
            'F.StartPosition = FormStartPosition.CenterScreen
            'F.ShowDialog()
            'cboTypeID.DataBindings.Clear()
            'Get_sp_hlp_Type()
            'Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub lblBrandID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBrandID.Click
        Try
            'Dim F As New frm_Brand
            'F.WindowState = FormWindowState.Normal
            'F.StartPosition = FormStartPosition.CenterScreen
            'F.ShowDialog()
            'cboBrandID.DataBindings.Clear()
            'Get_sp_hlp_Brand()
            'Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
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