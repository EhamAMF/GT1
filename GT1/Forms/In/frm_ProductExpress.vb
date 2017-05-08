Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions

Public Class frm_ProductExpress

    Dim _Dt As New DataTable
    Dim _Bs As New BindingSource

    Public _StockID As Int64
    Public _UnitCost As Decimal
    Public _Amount As Decimal
    Public _Barcode As String


    Dim WithEvents bl As New ByteBarcodeListener2(Me, 20)



    Public Sub New(ByVal StockID As Object, ByVal Barcode As Object)

        ' This call is required by the designer.
        InitializeComponent()

        _StockID = StockID
        _Barcode = Barcode

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_ProductExpress_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mf As New MyFonts
        mf.FontMyControl(Me)

        Get_sp_hlp_Brand()
        Get_sp_hlp_ProductType()

        GetStock(_StockID)





        ' _Bs.AddNew()


    End Sub
    Private Sub frm_ProductExpress_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If _StockID = 0 Then
            _Bs.AddNew()
            txtBarcode.Text = _Barcode
            cboTypeID.Focus()
        Else
            numUnitCost.Focus()
        End If
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
    Private Sub GetStock(ByRef StockID As Object)

        Dim da As New SqlDataAdapter("sp_tbl_Stock_Select", PubCn)


        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@StockID", StockID)
        End With

        da.Fill(_Dt)


        _Bs.DataSource = _Dt




        Me.txtBarcode.DataBindings.Clear()
        Me.txtBarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "Barcode", False, DataSourceUpdateMode.OnPropertyChanged))


        Me.cboTypeID.DataBindings.Clear()
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", _Bs, "TypeID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "TypeName", True, DataSourceUpdateMode.OnValidation))



        Me.cboBrandID.DataBindings.Clear()
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Selectedvalue", _Bs, "BrandID", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cboBrandID.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "BrandName", True, DataSourceUpdateMode.OnValidation))



        Me.txtProductName.DataBindings.Clear()
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "ProductName", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.txtProductDetails.DataBindings.Clear()
        Me.txtProductDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "ProductDetails", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numSellPrice.DataBindings.Clear()
        Me.numSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "SellPrice", True, DataSourceUpdateMode.OnPropertyChanged))

        Me.numUnitCost.DataBindings.Clear()
        Me.numUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "LastUnitCost", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numSubAmount.DataBindings.Clear()
        Me.numSubAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "SubAmount", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numPacketSellPrice.DataBindings.Clear()
        Me.numPacketSellPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "PacketSellPrice", True, DataSourceUpdateMode.OnPropertyChanged))


        Me.numAlertAmount.DataBindings.Clear()
        Me.numAlertAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", _Bs, "AlertAmount", True, DataSourceUpdateMode.OnPropertyChanged))





    End Sub

    Private Sub InsertIntoStock()

        Dim Ins As New SqlCommand
        With Ins

            .Connection = PubCn
            .CommandText = "sp_tbl_Stock_Insert"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Clear()





            .Parameters.AddWithValue("@TypeID", _Bs.Current("TypeID"))
            .Parameters.AddWithValue("@BrandID", _Bs.Current("BrandID"))
            .Parameters.AddWithValue("@ProductName", _Bs.Current("ProductName"))
            .Parameters.AddWithValue("@ProductDetails", _Bs.Current("ProductDetails"))
            .Parameters.AddWithValue("@SellPrice", _Bs.Current("SellPrice"))
            .Parameters.AddWithValue("@SubAmount", _Bs.Current("SubAmount"))
            .Parameters.AddWithValue("@PacketSellPrice", _Bs.Current("PacketSellPrice"))
            .Parameters.AddWithValue("@AlertAmount", _Bs.Current("AlertAmount"))
            .Parameters.AddWithValue("@UserID", PubUserID)


            .Parameters.Add("@Barcode", SqlDbType.NVarChar, 200)
            .Parameters("@Barcode").Direction = ParameterDirection.InputOutput

            If IsNothing(_Bs.Current("Barcode")) OrElse IsDBNull(_Bs.Current("Barcode")) Then
                .Parameters("@Barcode").Value = DBNull.Value
            Else
                .Parameters("@Barcode").Value = _Bs.Current("Barcode")
            End If


            .Parameters.Add("@StockID", SqlDbType.BigInt, 0)
            .Parameters("@StockID").Direction = ParameterDirection.Output
            .Parameters.Add("@ProductID", SqlDbType.BigInt, 0)
            .Parameters("@ProductID").Direction = ParameterDirection.Output
            .Parameters.Add("@ProductFullName", SqlDbType.NVarChar, 200)
            .Parameters("@ProductFullName").Direction = ParameterDirection.Output
            .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200)
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200)
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters.Add("@Username", SqlDbType.NVarChar, 200)
            .Parameters("@Username").Direction = ParameterDirection.Output





        End With

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()

        Ins.ExecuteNonQuery()

        _StockID = Ins.Parameters("@StockID").Value
        _Amount = numAmount.Text
        _UnitCost = numUnitCost.Text
        _Barcode = Ins.Parameters("@Barcode").Value

        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()


    End Sub
    Private Sub UpdateStock()


        Dim ChangesDt As New DataTable

        ChangesDt = _Dt.GetChanges(DataRowState.Modified)

        If Not IsNothing(ChangesDt) AndAlso ChangesDt.Rows.Count > 0 Then



            Dim Upt As New SqlCommand



            With Upt
                .Connection = PubCn
                .CommandText = "sp_tbl_Stock_Update"
                .CommandType = CommandType.StoredProcedure

                .Parameters.Clear()

                .Parameters.AddWithValue("@StockID", _StockID)
                .Parameters.AddWithValue("@ProductID", DBNull.Value)
                .Parameters.AddWithValue("@TypeID", _Bs.Current("TypeID"))
                .Parameters.AddWithValue("@BrandID", _Bs.Current("BrandID"))
                .Parameters.AddWithValue("@ProductName", _Bs.Current("ProductName"))
                .Parameters.AddWithValue("@ProductDetails", _Bs.Current("ProductDetails"))
                .Parameters.AddWithValue("@SellPrice", _Bs.Current("SellPrice"))
                .Parameters.AddWithValue("@SubAmount", _Bs.Current("SubAmount"))
                .Parameters.AddWithValue("@PacketSellPrice", _Bs.Current("PacketSellPrice"))
                .Parameters.AddWithValue("@AlertAmount", _Bs.Current("AlertAmount"))
                .Parameters.AddWithValue("@UserID", PubUserID)


                .Parameters.Add("@ProductFullName", SqlDbType.NVarChar, 200)
                .Parameters("@ProductFullName").Direction = ParameterDirection.Output
                .Parameters.Add("@TypeName", SqlDbType.NVarChar, 200)
                .Parameters("@TypeName").Direction = ParameterDirection.Output
                .Parameters.Add("@BrandName", SqlDbType.NVarChar, 200)
                .Parameters("@BrandName").Direction = ParameterDirection.Output
                .Parameters.Add("@Username", SqlDbType.NVarChar, 200)
                .Parameters("@Username").Direction = ParameterDirection.Output

            End With

            If PubCn.State <> ConnectionState.Open Then PubCn.Open()

            Upt.ExecuteNonQuery()



            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End If


        _Amount = numAmount.Text
        _UnitCost = numUnitCost.Text

    End Sub



    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click

        Try
            ErrorProvider1.Clear()
            Dim IsOneOfTheFieldsEmpty As Boolean = False

            If IsNothing(cboBrandID.SelectedValue) OrElse IsDBNull(cboBrandID.SelectedValue) Then
                ErrorProvider1.SetError(cboBrandID, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If

            If IsNothing(cboTypeID.SelectedValue) OrElse IsDBNull(cboTypeID.SelectedValue) Then
                ErrorProvider1.SetError(cboTypeID, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If
            If String.IsNullOrWhiteSpace(txtProductName.Text) Then
                ErrorProvider1.SetError(txtProductName, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If
            If String.IsNullOrWhiteSpace(numUnitCost.Text) OrElse Val(numUnitCost.Text) <= 0 Then
                ErrorProvider1.SetError(numUnitCost, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If
            If String.IsNullOrWhiteSpace(numSellPrice.Text) OrElse Val(numSellPrice.Text) <= 0 Then
                ErrorProvider1.SetError(numSellPrice, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If
            If String.IsNullOrWhiteSpace(numAmount.Text) OrElse Val(numAmount.Text) <= 0 Then
                ErrorProvider1.SetError(numAmount, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If

            If IsOneOfTheFieldsEmpty = True Then Throw New Exception("تأكد من ملء الحقول", New Exception("ByteError"))

            _Bs.EndEdit()






            If _StockID = 0 Then
                InsertIntoStock()
            Else
                UpdateStock()
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK
            '  Me.Close()


        Catch ex As Exception
            msgShow(ex.Message)
        End Try


        '

        '_Bs.EndEdit()
        'Me.Validate()
    End Sub

    Private Sub bl_BarcodeReceived(str As String) Handles bl.BarcodeReceived

        If _StockID = 0 Then
            txtBarcode.Text = str
        End If


    End Sub


End Class