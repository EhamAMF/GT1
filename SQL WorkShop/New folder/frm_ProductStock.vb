Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary.MyFunctions
Public Class frm_ProductStock
    Dim WithEvents da As New SqlDataAdapter
    Dim WithEvents dt As New DataTable
    Dim WithEvents bs As New BindingSource

    Dim WithEvents BL As New ByteClassLibrary.ByteBarcodeListener2(Me, "txtBarcode")



    Public _StockID As Object
    Public _Amount As Decimal

    Dim _Barcode As Object
    Dim _FrmType As FrmType = FrmType.Normal

    Enum FrmType
        Normal = 0
        Express = 1
    End Enum

    Public Sub New(Optional ByVal FrmType As FrmType = FrmType.Normal, Optional Barcode As Object = Nothing, Optional Stock As Object = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _FrmType = FrmType
        _Barcode = Barcode
        _StockID = Stock


        If _FrmType = frm_ProductStock.FrmType.Normal Then
            pAmount.Visible = False
            PPacketAmount.Visible = False

            PLastUnitCost.Enabled = False
            PPacketCost.Enabled = False


        Else


            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(425, 648)
            '   Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

            Me.StartPosition = FormStartPosition.CenterScreen



            pAmount.Visible = True
            PPacketAmount.Visible = True

            PLastUnitCost.Enabled = True
            PPacketCost.Enabled = True

        End If


    End Sub

    Private Sub frm_ProductStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            lblTitle.Text = Me.Text
            daInitialize()
            Get_sp_hlp_ProductType()
            Get_sp_hlp_Brand()

            GetDataTable()



            bs.MoveLast()



            EnableDisableControls(False)

       

            If _FrmType = FrmType.Express Then



                ToolStrip1.Hide()
                SplitContainer1.Panel2Collapsed = True
                Me.Width = 387
                lblLastUnitCost.Text = "التكلفة"


                'If _Barcode Is DBNull.Value Then
                '    btnAdd.PerformClick()
                'ElseIf bs.Find("Barcode", _Barcode) < 0 Then
                '    btnAdd.PerformClick()
                '    txtBarcode.Text = _Barcode
                '    bs.Current("Barcode") = _Barcode
                '    bs.EndEdit()

                'Else
                '    bs.Position = bs.Find("Barcode", _Barcode)
                '    btnEdit.PerformClick()
                'End If

                If bs.Count < 0 Then
                    btnAdd.PerformClick()
                    txtBarcode.Text = _Barcode
                    bs.Current("Barcode") = _Barcode
                    bs.EndEdit()
                Else
                    btnEdit.PerformClick()
                End If




              

            Else
                Pbtn.Visible = False
                pAmount.Visible = False
            End If

         

        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub frm_ProductStock_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try
            If _FrmType = FrmType.Express Then
                Me.Size = New Size(425, 648)
            End If
        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub


    Private Sub daInitialize()



        da.SelectCommand = New SqlCommand
        With da.SelectCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Select"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.AddWithValue("@StockID", _StockID)
            .Parameters.AddWithValue("@Barcode", _Barcode)

        End With

        da.InsertCommand = New SqlCommand
        With da.InsertCommand

            .CommandTimeout = 0

            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Insert"
            .CommandType = CommandType.StoredProcedure


            .Parameters.Clear()

            .Parameters.AddWithValue("@IsExpress", _FrmType)
            '   .Parameters.AddWithValue("@IsMultiExDateAllowed", My.Settings.is)

            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")
            .Parameters.Add("@ProductCode", SqlDbType.NVarChar, 200, "ProductCode")
            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 500, "ProductDetails")
            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@ExDate", SqlDbType.Date, 0, "ExDate")
            .Parameters.Add("@SubAmount", SqlDbType.Int, 0, "SubAmount")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@PacketSellPrice", SqlDbType.Decimal, 0, "PacketSellPrice")
            .Parameters.Add("@Rack", SqlDbType.NVarChar, 200, "Rack")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters("@StockID").Direction = ParameterDirection.Output
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters("@ProductID").Direction = ParameterDirection.Output
            .Parameters.Add("@Barcode", SqlDbType.NVarChar, 200, "Barcode")
            .Parameters("@Barcode").Direction = ParameterDirection.InputOutput
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@UserName", SqlDbType.NVarChar, 50, "UserName")
            .Parameters("@UserName").Direction = ParameterDirection.Output




        End With

        da.UpdateCommand = New SqlCommand
        With da.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Update"
            .CommandType = CommandType.StoredProcedure

            .CommandTimeout = 0

            .Parameters.Clear()


            .Parameters.AddWithValue("@IsExpress", _FrmType)
            '       .Parameters.AddWithValue("@IsMultiExDateAllowed", My.Settings.IsMultiExDateAllowed)

            .Parameters.Add("@TypeID", SqlDbType.BigInt, 0, "TypeID")
            .Parameters.Add("@BrandID", SqlDbType.BigInt, 0, "BrandID")
            .Parameters.Add("@ProductName", SqlDbType.NVarChar, 200, "ProductName")

            .Parameters.Add("@ProductCode", SqlDbType.NVarChar, 200, "ProductCode")
            .Parameters.Add("@Barcode", SqlDbType.NVarChar, 200, "Barcode")

            .Parameters.Add("@ProductDetails", SqlDbType.NVarChar, 500, "ProductDetails")
            .Parameters.Add("@AlertAmount", SqlDbType.Decimal, 0, "AlertAmount")
            .Parameters.Add("@ExDate", SqlDbType.Date, 0, "ExDate")
            .Parameters.Add("@SubAmount", SqlDbType.Int, 0, "SubAmount")
            .Parameters.Add("@SellPrice", SqlDbType.Decimal, 0, "SellPrice")
            .Parameters.Add("@PacketSellPrice", SqlDbType.Decimal, 0, "PacketSellPrice")

            .Parameters.Add("@Rack", SqlDbType.NVarChar, 200, "Rack")
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200, "TypeName")
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200, "BrandName")
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@UserName", SqlDbType.NVarChar, 50, "UserName")
            .Parameters("@UserName").Direction = ParameterDirection.Output

        End With

        da.DeleteCommand = New SqlCommand
        With da.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_ProductStock_Delete"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Clear()
            .Parameters.Add("@StockID", SqlDbType.BigInt, 0, "StockID")
            .Parameters("@StockID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0, "ProductID")
            .Parameters("@ProductID").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@UserID", SqlDbType.BigInt, 0, "UserID")
        End With



    End Sub
    Private Sub Get_sp_hlp_ProductType()

        Dim da As New SqlDataAdapter("sp_hlp_ProductType", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        dt.Rows.RemoveAt(0)
        bs.DataSource = dt


        With cboTypeID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "TypeID", False, "")
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
        dt.Rows.RemoveAt(0)
        bs.DataSource = dt


        With cboBrandID
            .MySource = bs
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "brandID", False, "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "BrandName", True, "")
            .MyBeginProcess()
        End With


    End Sub

    Private Sub GetDataTable()


        '  dtpExDate.DataBindings.Clear()
        dt.Clear()
        'da.FillSchema(dt, SchemaType.Source)
        da.Fill(dt)
        'dt.PrimaryKey = {dt.Columns("StockID")}

        bs.DataSource = dt
        dgv.DataSource = bs

        With dgv
            .Columns("ProductID").Visible = False
            .Columns("TypeID").Visible = True
            .Columns("BrandID").Visible = False
            .Columns("UserID").Visible = False

            '  .Columns("StockID").HeaderText = "ر.م"
            .Columns("Barcode").HeaderText = "باركود"
            .Columns("TypeName").HeaderText = "النوع"
            .Columns("BrandName").HeaderText = "الماركة"
            .Columns("ProductName").HeaderText = "الصنف"
            .Columns("ExDate").HeaderText = "الصلاحية"
            .Columns("Rack").HeaderText = "الرف"
            .Columns("ProductDetails").HeaderText = "التفاصيل"
            .Columns("LastUnitCost").HeaderText = "أخر تكلفة"
            .Columns("AvgUnitCost").HeaderText = "متوسط التكلفة"
            .Columns("SellPrice").HeaderText = "سعر البيع"
            .Columns("SubAmount").HeaderText = "العبوة"
            .Columns("PacketSellPrice").HeaderText = "سعر الصندوق"
            .Columns("AlertAmount").HeaderText = "الكمية الحرجة"
            .Columns("Username").HeaderText = "المستخدم"

        End With




        Me.txtBarcode.DataBindings.Clear()
        Me.txtBarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Barcode", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.cboTypeID.DataBindings.Clear()
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedValue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.cboBrandID.DataBindings.Clear()
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))



        Me.txtProductName.DataBindings.Clear()
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductName", True, DataSourceUpdateMode.OnPropertyChanged))

        'Me.txtProductCode.DataBindings.Clear()
        'Me.txtProductCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged))



        Me.dtpExDate.DataBindings.Clear()
        Me.dtpExDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "ExDate", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtRack.DataBindings.Clear()
        Me.txtRack.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "Rack", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.txtProductDetails.DataBindings.Clear()
        Me.txtProductDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "ProductDetails", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numLastUnitCost.DataBindings.Clear()
        Me.numLastUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "LastUnitCost", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numAvgUnitCost.DataBindings.Clear()
        Me.numAvgUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AvgUnitCost", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numSellPrice.DataBindings.Clear()
        Me.numSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SellPrice", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numSubAmount.DataBindings.Clear()
        Me.numSubAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "SubAmount", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numPacketSellPrice.DataBindings.Clear()
        Me.numPacketSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "PacketSellPrice", True, DataSourceUpdateMode.OnPropertyChanged))




        Me.numAlertAmount.DataBindings.Clear()
        Me.numAlertAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "AlertAmount", True, DataSourceUpdateMode.OnPropertyChanged))

        dt.AcceptChanges()


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
            dtpExDate.Value = "2000/1/1"
            bs.Current("ExDate") = dtpExDate.Value

            EnableDisableControls(True)

            For Each c As Control In SplitContainer1.Panel1.Controls
                If c.GetType.BaseType.Name <> "" Then
                    c.Focus()
                    Exit For
                End If
            Next


            'txtClientName.Focus()
        Catch ex As Exception
            HandleMyError(ex)
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
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try




            EnableDisableControls(True)



        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If _FrmType = FrmType.Express Then
                If Val(numAmount.Text) <= 0 Then
                    Throw New Exception("تأكد من الكمية", New Exception("Byte Error"))
                End If
            End If



            bs.EndEdit()
            Me.Validate()




            da.Update(dt)
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
            EnableDisableControls(False)

            If _FrmType = FrmType.Express Then
                _StockID = bs.Current("StockID")
                _Amount = Val(numAmount.Text)
                _Barcode = bs.Current("StockID")

                Me.Dispose()
                Me.Close()

            End If



        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click

        btnSave.PerformClick()


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
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            GetDataTable()
            EnableDisableControls(False)





        Catch ex As Exception
            HandleMyError(ex)
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
            HandleMyError(ex)
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
            HandleMyError(ex)
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


            MessageBox.Show(cboTypeID.MySelectedValue.ToString)
            MessageBox.Show(cboTypeID.DataBindings(0).DataSourceUpdateMode.ToString)



            'Dim F As New frm_ProductType
            'F.WindowState = FormWindowState.Normal
            'F.StartPosition = FormStartPosition.CenterScreen
            'F.ShowDialog()
            'cboTypeID.DataBindings.Clear()
            'Get_sp_hlp_ProductType()
            'Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("MySelectedvalue", bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))



        Catch ex As Exception
            HandleMyError(ex)
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
            HandleMyError(ex)
        End Try
    End Sub

    Private Sub BL_BarcodeReceived(ByVal str As String) Handles BL.BarcodeReceived
        Try

            If SplitContainer1.Panel2.Enabled = True Then
                Dim indx As Integer = bs.Find("Barcode", str)
                If indx >= 0 Then
                    bs.Position = indx
                Else
                    btnAdd.PerformClick()
                    txtBarcode.Text = str
                    bs.Current("Barcode") = str
                    bs.EndEdit()
                End If
            End If











        Catch ex As Exception
            HandleMyError(ex)
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
            bs.Filter = "ProductFullName like '%" & txtSearch.Text & "%'"
        End If
    End Sub










    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        msgShow(Me.Size.ToString)



    End Sub

    Private Sub numAmount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAmount.KeyUp
        Try

            If Val(numAmount.Text) > 0 AndAlso Val(numSubAmount.Text) > 0 Then
                numPacketAmount.Text = Format(Val(numAmount.Text) / Val(numSubAmount.Text), "#0.###")
                'numPacketCost.Text = Val(numUnitCost.Text) * Val(numSubAmount.Text)
            Else
                numPacketAmount.Text = String.Empty
                numPacketCost.Text = String.Empty
            End If


        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub

    Private Sub numLastUnitCost_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numLastUnitCost.KeyUp
        Try
            If e.KeyCode <> Keys.Enter Then


                If Val(numLastUnitCost.Text) > 0 AndAlso Val(numSubAmount.Text) > 0 Then
                    numPacketCost.Text = Val(numLastUnitCost.Text) * Val(numSubAmount.Text)
                Else
                    numPacketCost.Text = String.Empty
                End If

            End If

        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
    Private Sub numSellPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numSellPrice.KeyUp
        Try
            If Val(numSellPrice.Text) > 0 AndAlso Val(numSubAmount.Text) > 0 Then
                numPacketSellPrice.Text = Val(numSellPrice.Text) * Val(numSubAmount.Text)
            Else
                numPacketSellPrice.Text = String.Empty
            End If
        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub

    Private Sub numPacketAmount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numPacketAmount.KeyUp
        Try
            If Val(numPacketAmount.Text) > 0 AndAlso Val(numSubAmount.Text) > 0 Then
                numAmount.Text = Val(numPacketAmount.Text) * Val(numSubAmount.Text)
            End If
        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub

    Private Sub numPacketCost_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numPacketCost.KeyUp
        Try
            If Val(numPacketCost.Text) > 0 AndAlso Val(numSubAmount.Text) > 0 Then
                numLastUnitCost.Text = Format(Val(numPacketCost.Text) / Val(numSubAmount.Text), "#,##0.###")
            End If
        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub

    Private Sub numSubAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles numSubAmount.Leave
        Try
            If Val(numSubAmount.Text) <= 0 Then
                numPacketAmount.Text = String.Empty
                numPacketCost.Text = String.Empty
                numPacketSellPrice.Text = String.Empty

                numPacketAmount.Enabled = False
                numPacketCost.Enabled = False
                numPacketSellPrice.Enabled = False
            Else
                numPacketAmount.Enabled = True
                numPacketCost.Enabled = True
                numPacketSellPrice.Enabled = True
            End If

        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
    




    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        dt.AcceptChanges()

    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click

        If dt.GetChanges Is Nothing Then
            msgShow(0)

        Else
            msgShow(dt.GetChanges.Rows.Count)

        End If


    End Sub
End Class