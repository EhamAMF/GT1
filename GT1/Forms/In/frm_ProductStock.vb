Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_ProductStock
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource


    Public _StockID As Object = DBNull.Value
    Public _Barcode As Object = DBNull.Value

    Public _StockName As Object
    Public _ProductDetails As Object
    Public _ProductCode As Object

    Public _IsExpress As Boolean = False

    Public _Amount As Object
    Public _UnitCost As Object
    Public _AmountPacket As Object
    Public _UnitCostPacket As Object
    Public _Total As Object
    Public _IsPacket As Object
    Public _SubAmount As Object

    Dim WithEvents BL As New ByteClassLibrary.ByteBarcodeListener2(Me, "txtProductName", 5)





    Public Sub New(Optional ByVal StockID As Object = Nothing, Optional ByVal Barcode As Object = Nothing, Optional ByVal IsExpress As Boolean = False)


        ' This call is required by the designer.
        InitializeComponent()


        _StockID = StockID
        _Barcode = Barcode
        _IsExpress = IsExpress

        Me.StartPosition = FormStartPosition.CenterScreen
        If _IsExpress = False Then
            PAvgUnitCost.Enabled = False
            PAvgUnitCostPacket.Enabled = False
            PLastUnitCost.Enabled = False
            PLastUnitCostPacket.Enabled = False


            numAmountLeft.Visible = False
            lblAmountLeft.Visible = False

            numAmountLeftPacket.Visible = False
            lblAmountLeftPacket.Visible = False

            PExpressButtons.Visible = False


        Else
            Me.StartPosition = FormStartPosition.CenterScreen
            ToolStrip1.Visible = False
            SplitContainer1.Panel2Collapsed = True
            '508, 528
            Me.Width = 500
            Me.Height = 570


        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_ProductStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_ProductType()
            Get_sp_hlp_Brand()

            GetDataTable()
            bs.MoveLast()
            EnableDisableControls(False)





           






        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub frm_ProductStock_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try

            numSubAmount_TextChanged(Me, Nothing)



            If _IsExpress = True Then
                lblAmountLeft.Text = "الكمية"
                lblAmountLeftPacket.Text = "الكمية"
                lblLastUnitCost.Text = "التكلفة"
                lblLastUnitCostPacket.Text = "التكلفة"


                If bs.Count <= 0 Then
                    btnAdd.PerformClick()
                    If Not IsNothing(_Barcode) Then
                        txtBarcode.Text = _Barcode.ToString
                    End If

                    txtProductName.Focus()

                Else
                    btnCopy.PerformClick()

                    If Val(numSubAmount.Text) > 1 Then
                        numAmountLeftPacket.Focus()
                    Else
                        numAmountLeft.Focus()
                    End If


                End If


                _StockID = 0

            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub daInitialize()



        da.SelectCommand = New SqlCommand
        With da.SelectCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Select"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@StockID", _StockID)
            .Parameters.AddWithValue("@Barcode", _Barcode)
        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Insert"
            .CommandType = CommandType.StoredProcedure

            .CommandTimeout = 0


            .Parameters.Clear()
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters("@StockID").Direction = ParameterDirection.InputOutput
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")
            .Parameters.Add("@ExDate", SqlDbType.DateTime, 0, "ExDate")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@SellPricePacket", SqlDbType.Decimal, 0, "SellPricePacket")
            .Parameters.Add("@Barcode", SqlDbType.NVarChar, 200, "Barcode")
            .Parameters("@Barcode").Direction = ParameterDirection.InputOutput
            .Parameters.Add("@ProductCode", SqlDbType.NVarChar, 200, "ProductCode")
            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 200, "ProductDetails")
            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@Rack", SqlDbType.NVarChar, 200, "Rack")
            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@AlertAmountPacket", SqlDbType.Decimal, 0, "AlertAmountPacket")
            .Parameters.Add("@SubAmount", SqlDbType.Decimal, 0, "SubAmount")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

            .Parameters.AddWithValue("@IsExpress", True)
            .Parameters.AddWithValue("@IsMultiExDateAllowed", Settings.IsMultiExDateAllowed)

        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Update"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")
            .Parameters.Add("@ProductCode", SqlDbType.NVarChar, 200, "ProductCode")
            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 200, "ProductDetails")
            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@Rack", SqlDbType.NVarChar, 200, "Rack")

            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@AlertAmountPacket", SqlDbType.Decimal, 0, "AlertAmountPacket")

            .Parameters.Add("@ExDate", SqlDbType.DateTime, 0, "ExDate")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@SellPricePacket", SqlDbType.Decimal, 0, "SellPricePacket")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@Username", SqlDbType.NVarChar, 50, "Username")
            .Parameters("@Username").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters("@ProductID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters("@StockID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters("@UserID").SourceVersion = DataRowVersion.Original

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
        bs.RemoveAt(bs.Find("sort", 0))


        With cboTypeID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "typeID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "TypeName", True, "")
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
        bs.RemoveAt(bs.Find("sort", 0))


        With cboBrandID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "brandID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "BrandName", True, "")

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
            .Columns("ProductID").Visible = False
            .Columns("TypeID").Visible = False
            .Columns("BrandID").Visible = False
            .Columns("UserID").Visible = False

            .Columns("StockID").HeaderText = "ر.م"
            .Columns("ProductName").HeaderText = "اسم الصنف"
            .Columns("ProductCode").HeaderText = "كود"
            .Columns("Barcode").HeaderText = "باركود"
            .Columns("ExDate").HeaderText = "الصلاحية"
            .Columns("Rack").HeaderText = "الرف"
            .Columns("TypeName").HeaderText = "النوع"
            .Columns("BrandName").HeaderText = "الماركة"
            .Columns("AlertAmount").HeaderText = "الكمية الحرجة"
            .Columns("AlertAmountPacket").HeaderText = "الكمية الحرجة ص"
            .Columns("SubAmount").HeaderText = "العبوة"
            .Columns("AvgUnitCost").HeaderText = "متوسط التكلفة"
            .Columns("LastUnitCost").HeaderText = "اخر تكلفة"
            .Columns("SellPrice").HeaderText = "سعر البيع"
            .Columns("AmountLeft").HeaderText = "الكمية المتبقية"
            .Columns("AvgUnitCostPacket").HeaderText = "متوسط التكلفة ص"
            .Columns("LastUnitCostPacket").HeaderText = "اخر تكلفة ص"
            .Columns("SellPricePacket").HeaderText = "سعر البيع ص"
            .Columns("AmountLeftPacket").HeaderText = "الكمية المتبقية ص"
            .Columns("ProductDetails").HeaderText = "تفاصيل"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.txtProductName.DataBindings.Clear()
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductName", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtProductCode.DataBindings.Clear()
        Me.txtProductCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtBarcode.DataBindings.Clear()
        Me.txtBarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Barcode", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.dtpExDate.DataBindings.Clear()
        Me.dtpExDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "ExDate", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtRack.DataBindings.Clear()
        Me.txtRack.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Rack", True, DataSourceUpdateMode.OnPropertyChanged, ""))




        Me.cboTypeID.DataBindings.Clear()
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "TypeName", True, DataSourceUpdateMode.OnValidation))





        Me.cboBrandID.DataBindings.Clear()
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "BrandName", True, DataSourceUpdateMode.OnValidation))





        Me.numAlertAmount.DataBindings.Clear()
        Me.numAlertAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AlertAmount", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))


        Me.numAlertAmountPacket.DataBindings.Clear()
        Me.numAlertAmountPacket.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AlertAmountPacket", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numSubAmount.DataBindings.Clear()
        Me.numSubAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SubAmount", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numAvgUnitCost.DataBindings.Clear()
        Me.numAvgUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AvgUnitCost", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numLastUnitCost.DataBindings.Clear()
        Me.numLastUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "LastUnitCost", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numSellPrice.DataBindings.Clear()
        Me.numSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SellPrice", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numAmountLeft.DataBindings.Clear()
        Me.numAmountLeft.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AmountLeft", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numAvgUnitCostPacket.DataBindings.Clear()
        Me.numAvgUnitCostPacket.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AvgUnitCostPacket", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numLastUnitCostPacket.DataBindings.Clear()
        Me.numLastUnitCostPacket.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "LastUnitCostPacket", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numSellPricePacket.DataBindings.Clear()
        Me.numSellPricePacket.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SellPricePacket", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.numAmountLeftPacket.DataBindings.Clear()
        Me.numAmountLeftPacket.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AmountLeftPacket", True, DataSourceUpdateMode.OnPropertyChanged, "", "#0.##"))




        Me.txtProductDetails.DataBindings.Clear()
        Me.txtProductDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductDetails", True, DataSourceUpdateMode.OnPropertyChanged, ""))



        dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
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
            PSubAmount.Enabled = True




            dtpExDate.Value = "1/1/2050"

            For Each c As Control In SplitContainer1.Panel1.Controls
                If c.GetType.BaseType.Name <> "" Then
                    c.Focus()
                    Exit For
                End If
            Next


            'txtClientName.Focus()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
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
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            EnableDisableControls(True)
            PSubAmount.Enabled = False
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            bs.EndEdit()
            Me.Validate()

            _SellType = Nothing

            da.Update(dt)
            dgv.AutoResizeColumns()
            EnableDisableControls(False)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
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
                    If btnCopy.Enabled = True Then btnCopy.PerformClick()
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
            lblCount.Text = bs.Count
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
    Private Sub lblTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTypeID.Click
        Try
            Dim F As New frm_ProductType
            F.WindowState = FormWindowState.Normal
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
            cboTypeID.DataBindings.Clear()
            Get_sp_hlp_ProductType()
            Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub lblBrandID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBrandID.Click
        Try
            Dim F As New frm_Brand
            F.WindowState = FormWindowState.Normal
            F.StartPosition = FormStartPosition.CenterScreen
            F.ShowDialog()
            cboBrandID.DataBindings.Clear()
            Get_sp_hlp_Brand()
            Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub BL_BarcodeReceived(ByVal strBarcode As String) Handles BL.BarcodeReceived
        Try
            If _IsExpress = False Then

                Dim indx = bs.Find("Barcode", strBarcode)

                If indx >= 0 Then
                    bs.Position = indx
                Else
                    btnAdd.PerformClick()
                    txtBarcode.Text = strBarcode

                End If



            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
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

            Dim ID As Int64 = Val(txtSearch.Text)

            bs.Filter = "ProductName like '%" & txtSearch.Text & "%' or Barcode like '%" & txtSearch.Text & "%' or StockID = " & ID & ""
        End If
    End Sub

    Private Sub ادارةالباركودToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالباركودToolStripMenuItem.Click
        Try
            If Not IsNothing(dgv.CurrentRow) AndAlso IsNumeric(dgv.CurrentRow.Cells("StockID").Value) Then

                Dim sid As Int64 = dgv.CurrentRow.Cells("StockID").Value

                Dim f As New frm_ProductBarcode(sid)
                f.WindowState = FormWindowState.Normal
                f.StartPosition = FormStartPosition.CenterScreen
                f.ShowDialog()


            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    'Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

    '    PProductCode.Visible = False
    '    dt.TableName = "Products"
    '    dt.WriteXml("C:\Users\Ehab\Desktop\Desktop Files\New folder (10)\dt.xml")

    'End Sub


    Enum AmountType
        Unit = 1
        Packet = 2
    End Enum
    Enum SellType
        Calculated_PacketSellPrice = 1
        Calculated_UnitSellPrice = 2
    End Enum



    Dim _AmountType As AmountType = AmountType.Unit
    Dim _SellType As SellType = Nothing



    Private Sub numSubAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSubAmount.TextChanged
        Try
            If Val(numSubAmount.Text) <= 1 Then
                PAlertAmountPacket.Visible = False
                PAvgUnitCostPacket.Visible = False
                PLastUnitCostPacket.Visible = False
                PAmountLeftPacket.Visible = False
                PSellPricePacket.Visible = False
                Label2.Visible = False
            Else
                PAlertAmountPacket.Visible = True
                PAvgUnitCostPacket.Visible = True
                PLastUnitCostPacket.Visible = True
                PAmountLeftPacket.Visible = True
                PSellPricePacket.Visible = True
                Label2.Visible = True
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub


    Private Sub numAlertAmountPacket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAlertAmountPacket.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If Val(numSubAmount.Text) > 1 AndAlso Val(numAlertAmountPacket.Text) > 0 Then
                    numAlertAmount.Text = Val(numAlertAmountPacket.Text) * Val(numSubAmount.Text)
                Else
                    numAlertAmount.Text = ""
                End If

            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub numAlertAmount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAlertAmount.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If Val(numSubAmount.Text) > 1 AndAlso Val(numAlertAmount.Text) > 0 Then
                    numAlertAmountPacket.Text = Format(Val(numAlertAmount.Text) / Val(numSubAmount.Text), "#0.##")
                Else
                    numAlertAmountPacket.Text = ""
                End If

            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub numAmountLeftPacket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAmountLeftPacket.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If Val(numSubAmount.Text) > 1 AndAlso Val(numAmountLeftPacket.Text) > 0 Then
                    numAmountLeft.Text = Val(numAmountLeftPacket.Text) * Val(numSubAmount.Text)
                Else
                    numAmountLeft.Text = ""
                End If


                _AmountType = AmountType.Packet


            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub numAmountLeft_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAmountLeft.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If Val(numSubAmount.Text) > 1 AndAlso Val(numAmountLeft.Text) > 0 Then
                    numAmountLeftPacket.Text = Format(Val(numAmountLeft.Text) / Val(numSubAmount.Text), "#0.##")
                Else
                    numAmountLeftPacket.Text = ""
                End If


                _AmountType = AmountType.Unit

            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub numLastUnitCostPacket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numLastUnitCostPacket.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If Val(numSubAmount.Text) > 1 AndAlso Val(numLastUnitCostPacket.Text) > 0 Then
                    numLastUnitCost.Text = Format(Val(numLastUnitCostPacket.Text) / Val(numSubAmount.Text), "#0.##")
                Else
                    numLastUnitCost.Text = ""
                End If

            End If




        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub numLastUnitCost_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numLastUnitCost.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then
                If Val(numSubAmount.Text) > 1 AndAlso Val(numLastUnitCost.Text) > 0 Then
                    numLastUnitCostPacket.Text = Val(numLastUnitCost.Text) * Val(numSubAmount.Text)
                Else
                    numLastUnitCostPacket.Text = ""
                End If
            End If


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Private Sub numSellPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numSellPrice.KeyUp
        Try

            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If _SellType = Nothing Then
                    _SellType = SellType.Calculated_PacketSellPrice
                End If


                If _SellType = SellType.Calculated_PacketSellPrice Then
                    If Val(numSubAmount.Text) > 1 AndAlso Val(numSellPrice.Text) > 0 Then
                        numSellPricePacket.Text = Val(numSellPrice.Text) * Val(numSubAmount.Text)
                    Else
                        numSellPricePacket.Text = ""
                    End If
                End If






            End If

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub numSellPricePacket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numSellPricePacket.KeyUp
        Try
            If e.KeyCode <> Keys.Tab And e.KeyCode <> Keys.Enter Then

                If _SellType = Nothing Then
                    _SellType = SellType.Calculated_UnitSellPrice
                End If


                If _SellType = SellType.Calculated_UnitSellPrice Then
                    If Val(numSubAmount.Text) > 1 AndAlso Val(numSellPricePacket.Text) > 0 Then
                        numSellPrice.Text = Format(Val(numSellPricePacket.Text) / Val(numSubAmount.Text), "#0.##")
                    Else
                        numSellPrice.Text = ""
                    End If
                End If


            End If


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub




    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click


        Try


            If Val(numAmountLeft.Text) <= 0 Then
                Throw New Exception("تأكد من الكمية", New Exception("ByteError"))
            End If

            If Val(numLastUnitCost.Text) <= 0 Then
                Throw New Exception("تأكد من التكلفة", New Exception("ByteError"))
            End If

            If Val(numSubAmount.Text) > 1 Then
                If Val(numAmountLeftPacket.Text) <= 0 Then
                    Throw New Exception("تأكد من الكمية", New Exception("ByteError"))
                End If
                If Val(numLastUnitCostPacket.Text) <= 0 Then
                    Throw New Exception("تأكد من التكلفة", New Exception("ByteError"))
                End If
            End If



            btnSave.PerformClick()

            _StockID = bs.Current("StockID")
            _Amount = Val(numAmountLeft.Text)
            _UnitCost = Val(numLastUnitCost.Text)
            _AmountPacket = IIf(Val(numAmountLeftPacket.Text) <= 0, DBNull.Value, Val(numAmountLeftPacket.Text))
            _UnitCostPacket = IIf(Val(numLastUnitCostPacket.Text) <= 0, DBNull.Value, Val(numLastUnitCostPacket.Text))
            _Total = _Amount * _UnitCost

            _StockName = bs.Current("ProductName")
            _Barcode = bs.Current("Barcode")
            _ProductDetails = bs.Current("ProductDetails")
            _ProductCode = bs.Current("ProductCode")

            _SubAmount = bs.Current("SubAmount")


            If Val(numSubAmount.Text) > 1 Then
                If Int(Val(numAmountLeftPacket.Text)) = Val(numAmountLeftPacket.Text) Then
                    _Total = Val(numLastUnitCostPacket.Text) * Val(numAmountLeftPacket.Text)
                End If
            End If


            If _AmountType = AmountType.Packet Then
                _IsPacket = True
            Else
                _IsPacket = False
            End If

            Me.Close()






        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try

            Me.Close()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class