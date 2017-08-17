Imports System.Data.SqlClient
Imports ByteClassLibrary.MyFunctions

Public Class frmInvoice

    Dim WithEvents _bl As New ByteClassLibrary.ByteBarcodeListener2(Me, 20)

    Dim WithEvents _BsAgent As New BindingSource
    Dim WithEvents _BsDistributor As New BindingSource
    Dim WithEvents _BsWareHouse As New BindingSource




    Dim _dtStock As New DataTable
    Dim WithEvents _BsStock As New BindingSource

    Dim WithEvents _dtInvoiceDet As New DataTable
    Dim WithEvents _bsInvoiceDet As New BindingSource

    Dim WithEvents _dtTotals As New DataTable
    Dim WithEvents _bsTotals As New BindingSource

    Dim WithEvents _bsIsPaid As New BindingSource

    Dim _InvoiceType As InvoiceType
    Dim _InvoiceID As Object
    Dim _InvoiceTypeID As Object
    Dim _IsPaid As Object
    Dim _InvoiceNumber As Object
    Dim _InvoiceRealNumber As Object
    Dim _OrgInvoiceNumber As Object
    Dim _OrgInvoiceID As Object
    Dim _InvDate As Object
    Dim _AgentID As Object
    Dim _DistributorID As Object
    Dim _Name As Object
    Dim _TotalPrice As Object = 0
    Dim _FinalPrice As Object = 0
    Dim _Revenue As Object = 0
    Dim _Note As Object
    Dim _UserID As Object
    Dim _InvoiceInfo As Object
    Dim _AgentName As Object
    Dim _DistributorName As Object
    Dim _Username As Object
    Dim _FullName As Object
    Dim _WareHouseID As Object
    Dim _WareHouseName As Object

    Dim _PlusOrMinus As Object


    Dim _InvoiceNumberStrTitle As String

    Dim _TotalCost As Object = 0
    Dim _Discount As Object = 0
    Dim _RevPer As Object = 0





    Enum InvoiceType
        Purchase = 1
        Purchase_R = 2
        Sell = 3
        Sell_R = 4
        Loss = 5
        StockBalance = 6
        InitialAmount = 7
        WareHouseTransfer = 8
        PreSale = 9
    End Enum


#Region "       Initialize"
    Public Sub New(ByVal InvoiceID As Int64)

        InitializeComponent()

        _InvoiceID = InvoiceID
        _InvoiceType = Nothing

    End Sub
    Public Sub New(ByVal InvoiceType As InvoiceType, Optional ByVal OrgInvoiceID As Object = 0)
        InitializeComponent()

        _InvoiceID = 0
        _InvoiceType = InvoiceType
        _OrgInvoiceID = IIf(OrgInvoiceID = 0, DBNull.Value, OrgInvoiceID)



        '_InvoiceID = 0
        '_InvoiceType = frmInvoice.InvoiceType.Sell
    End Sub
    Private Sub frmInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            GetIniData()
            GetInvoice()
            SetForm()

            dgv.Select()

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub GetIniData()
        Get_sp_hlp_Agent()
        Get_sp_hlp_Distibutor()
        Get_sp_hlp_WareHouse()
        Get_sp_hlp_Stock()
        GetPayment()
        CreateTotalsTable()

        _BsAgent_CurrentChanged()

    End Sub
    Private Sub SetForm()

        cboItem.Text = ""
        SetTotals()

        Select Case _InvoiceType

            Case InvoiceType.Purchase
                lblTitle.Text = "فاتورة مشتريات " & _InvoiceNumberStrTitle
                Me.Text = "فاتورة مشتريات " & _InvoiceNumberStrTitle
                dgv.Columns("Revenue").Visible = False

                pOrgInvoiceNumer.Visible = False
                _PlusOrMinus = 1
                _InvoiceTypeID = 1

                dgvTotals.Rows(3).Visible = False
                dgvTotals.Rows(4).Visible = False

                dgv.Columns("UnitPrice").HeaderText = "سعر الوحدة |التكلفة|"

            Case InvoiceType.Sell
                lblTitle.Text = "فاتورة مبيعات " & _InvoiceNumberStrTitle
                Me.Text = "فاتورة مبيعات " & _InvoiceNumberStrTitle
                pInvoiceRealNumber.Visible = False
                pOrgInvoiceNumer.Visible = False
                _PlusOrMinus = -1
                _InvoiceTypeID = 3


                btnNewProduct.Visible = False




            Case InvoiceType.Sell_R
                lblTitle.Text = "فاتورة استرجاع مبيعات " & _InvoiceNumberStrTitle
                Me.Text = "فاتورة استرجاع مبيعات " & _InvoiceNumberStrTitle
                pInvoiceRealNumber.Visible = False
                _PlusOrMinus = 1
                btnNewProduct.Visible = False
                _InvoiceTypeID = 4



                cboAgent.Enabled = False
                txtName.Enabled = False
                cboWareHouse.Enabled = False
                cboDistributor.Enabled = False
                dtpInvoiceDate.Value = Now

                dgv.Columns("UnitPrice").ReadOnly = True
                dgv.Columns("Amount").HeaderText = "الكمية المسترجعة"
                dgv.Columns("Revenue").HeaderText = "-"
                dgvTotals.Item(0, 3).Value = "-"
                dgvTotals.Item(0, 4).Value = "-%"




                dgvTotals.Rows(1).Cells(1).ReadOnly = True
                dgvTotals.Rows(2).Cells(1).ReadOnly = True



                cboItem.Visible = False

            Case InvoiceType.InitialAmount
                lblTitle.Text = "فاتورة رصيد أول الفترة " & _InvoiceNumberStrTitle
                Me.Text = "فاتورة رصيد أول الفترة " & _InvoiceNumberStrTitle
                pInvoiceRealNumber.Visible = False
                pOrgInvoiceNumer.Visible = False
                _PlusOrMinus = 1
                btnNewProduct.Visible = True
                _InvoiceTypeID = 7
                pPay.Visible = False
                PAgent.Visible = False
                PName.Visible = False
                PDistributor.Visible = False

                dgv.Columns("Revenue").Visible = False
                dgv.Columns("UnitPrice").HeaderText = "سعر الوحدة |التكلفة|"
                dgvTotals.Rows(1).Visible = False
                dgvTotals.Rows(2).Visible = False
                dgvTotals.Rows(3).Visible = False
                dgvTotals.Rows(4).Visible = False


            Case InvoiceType.PreSale
                lblTitle.Text = "فاتورة مبدئية " & _InvoiceNumberStrTitle
                Me.Text = "فاتورة مبدئية " & _InvoiceNumberStrTitle
                pInvoiceRealNumber.Visible = False
                pOrgInvoiceNumer.Visible = False
                _PlusOrMinus = DBNull.Value
                btnNewProduct.Visible = False
                _InvoiceTypeID = 9
                pPay.Visible = False
        End Select
        dgv.AutoResizeColumns()

        If _InvoiceID = 0 OrElse IsDBNull(_IsPaid) OrElse _IsPaid = True Then
            btnPay.Visible = False
        Else
            btnPay.Visible = True
        End If

        If _InvoiceID = 0 Then
            cboAgent.SelectedValue = 1
            cboWareHouse.SelectedValue = 1
            cboDistributor.SelectedValue = 1
        End If


    End Sub
    Private Sub CreateTotalsTable()


        dgvTotals.Columns.Add("Disc", "Disc")
        dgvTotals.Columns.Add("Val", "Val")
        dgvTotals.Columns.Add("xx", "xx")



        dgvTotals.Rows.Add({"الاجمالي", 0})
        dgvTotals.Rows.Add({"النهائي", 0})
        dgvTotals.Rows.Add({"خصم", 0})
        dgvTotals.Rows.Add({"+", 0})
        dgvTotals.Rows.Add({"+%", 0})






    End Sub
    Private Sub FormatDgvTotals()

        For Each R As DataGridViewRow In dgvTotals.Rows
            R.ReadOnly = True
        Next


        dgvTotals.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvTotals.Columns(1).DefaultCellStyle.Format = "#,##0.##"

        Dim Fl As New Font("Arial", 18, FontStyle.Bold)
        Dim Flaj As New Font(Me.Font.Name, 18)

        dgvTotals.Item(0, 0).Style.Font = Flaj
        dgvTotals.Item(0, 1).Style.Font = Flaj

        dgvTotals.Item(1, 0).Style.Font = Fl
        dgvTotals.Item(1, 1).Style.Font = Fl

        dgvTotals.Item(1, 2).Style.Format = "0.##\%"
        dgvTotals.Item(1, 4).Style.Format = "#,##0.##%"


        dgvTotals.Item(1, 1).Style.ForeColor = Color.Black
        dgvTotals.Item(1, 2).Style.ForeColor = Color.Black

        dgvTotals.Item(1, 1).ReadOnly = False
        dgvTotals.Item(1, 2).ReadOnly = False

        dgvTotals.Item(2, 1).ReadOnly = False


        dgvTotals.Columns(1).DefaultCellStyle.Padding = New Padding(20, 0, 0, 0)

        dgvTotals.AutoResizeRows()
        dgvTotals.AutoResizeColumns()


        dgvTotals.CurrentCell = Nothing



    End Sub

    Private Sub GetPayment()
        Dim dt As New DataTable
        dt.Columns.Add("ID", Type.GetType("System.Boolean"))
        dt.Columns.Add("Name")
        dt.Rows.Add({True, "خالص"})
        dt.Rows.Add({False, "آجل"})

        _bsIsPaid.DataSource = dt

        With cboIsPaid
            .DataSource = _bsIsPaid
            .DisplayMember = "Name"
            .ValueMember = "ID"
        End With



    End Sub



    Private Sub frmInvoice_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormatDgvTotals()
        SetForm()

    End Sub
#End Region
#Region "       Agent"

    Private Sub Get_sp_hlp_Agent()

        Dim da As New SqlDataAdapter("sp_hlp_Agent", PubCn)
        Dim dt As New DataTable




        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)


        _BsAgent.DataSource = dt
        _BsAgent.Filter = "AgentID is not null"
        _BsAgent.Sort = "AgentName asc"



        With cboAgent
            .DataSource = _BsAgent
            .DisplayMember = "AgentName"
            .ValueMember = "AgentID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        cboAgent.SelectedItem = Nothing

    End Sub
    Private Sub _BsAgent_CurrentChanged() Handles _BsAgent.CurrentChanged
        If _BsAgent.Current("AgentID") = 1 Then
            PName.Visible = True
            cboIsPaid.SelectedValue = True
            cboIsPaid.Enabled = False
        Else
            PName.Visible = False
            cboIsPaid.Enabled = True
        End If
    End Sub



#End Region
#Region "       Distibutor"

    Private Sub Get_sp_hlp_Distibutor()

        Dim da As New SqlDataAdapter("sp_hlp_Distributor", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource



        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)


        _BsDistributor.DataSource = dt
        _BsDistributor.Filter = "DistributorID is not null"
        _BsDistributor.Sort = "DistributorName asc"




        With cboDistributor
            .DataSource = _BsDistributor
            .DisplayMember = "DistributorName"
            .ValueMember = "DistributorID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


    End Sub




#End Region
#Region "       WareHouse"

    Private Sub Get_sp_hlp_WareHouse()

        Dim da As New SqlDataAdapter("sp_hlp_WareHouse", PubCn)
        Dim dt As New DataTable




        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)
        dt.Rows.RemoveAt(0)

        _BsWareHouse.DataSource = dt





        With cboWareHouse
            .DataSource = _BsWareHouse
            .DisplayMember = "WareHouseName"
            .ValueMember = "WareHouseID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


    End Sub
    Private Sub _BsWareHouse_CurrentChanged() Handles _BsWareHouse.CurrentChanged

        For Each R As DataGridViewRow In dgv.Rows
            R.Cells("WareHouseID").Value = _BsWareHouse.Current("WareHouseID")
            R.Cells("WareHouseName").Value = _BsWareHouse.Current("WareHouseName")
        Next

        _bsInvoiceDet_CurrentChanged()



    End Sub



#End Region
#Region "       Stock Service"


    Private Sub Get_sp_hlp_Stock()

        Dim da As New SqlDataAdapter("sp_hlp_Stock", PubCn)

        da.SelectCommand.Parameters.Clear()
        da.SelectCommand.Parameters.AddWithValue("@Sourse", DBNull.Value)


        da.SelectCommand.CommandType = CommandType.StoredProcedure



        _dtStock.Clear()
        da.Fill(_dtStock)

        _dtStock.PrimaryKey = {_dtStock.Columns("ItemID")}


        _BsStock.DataSource = _dtStock





    End Sub


    Private Sub _bl_BarcodeReceived(ByVal str As String) Handles _bl.BarcodeReceived

        Dim StockID As Int64
        Dim Barcode As String
        Dim Amount As Decimal
        Dim UnitCost As Decimal


        If _InvoiceType = InvoiceType.Purchase Or _InvoiceType = InvoiceType.InitialAmount Then

            If _BsStock.Find("Barcode", str) >= 0 Then
                StockID = _BsStock.Item(_BsStock.Find("Barcode", str))("StockID")
                Barcode = _BsStock.Item(_BsStock.Find("Barcode", str))("Barcode")

                Dim frm As New frm_ProductExpress(StockID, Barcode)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    StockID = frm._StockID
                    Barcode = frm._Barcode
                    Amount = frm._Amount
                    UnitCost = frm._UnitCost



                    Get_sp_hlp_Stock()

                    AddToInvoice(1, StockID, Barcode, Amount, UnitCost)
                End If



            Else
                Dim frm As New frm_ProductExpress(0, str)
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    StockID = frm._StockID
                    Barcode = frm._Barcode
                    Amount = frm._Amount
                    UnitCost = frm._UnitCost

                    Get_sp_hlp_Stock()

                    AddToInvoice(1, StockID, Barcode, Amount, UnitCost)
                End If



            End If

        Else

            'If _BsProductMine.Find("Barcode", str) >= 0 Then
            '    StockID = _BsProductMine.Item(_BsProductMine.Find("Barcode", str))("StockID")
            '    Barcode = _BsProductMine.Item(_BsProductMine.Find("Barcode", str))("Barcode")
            '    AddToInvoice(1, StockID, Barcode, 1)
            '    dgv.Focus()
            'End If

        End If


    End Sub
    Private Sub btnNewProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProduct.Click
        Dim StockID As Int64
        Dim Barcode As String
        Dim Amount As Decimal

        Dim frm As New frm_ProductExpress(0, "")
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            StockID = frm._StockID
            Barcode = frm._Barcode
            Amount = frm._Amount

            Get_sp_hlp_Stock()

            AddToInvoice(1, StockID, Barcode, Amount)
        End If



    End Sub
    Private Sub btnNewProduct_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewProduct.GotFocus
        Me.SelectNextControl(Me, True, True, True, True)
    End Sub



#End Region
#Region "       Invoice"


    Private Sub GetInvoice()


        If _InvoiceType = InvoiceType.Sell_R Then
            _InvoiceID = _OrgInvoiceID
        End If


        _dtInvoiceDet = fn_sp_rpt_Invoice(_InvoiceID, _InvoiceTypeID, _IsPaid, _InvoiceNumber, _InvoiceRealNumber _
                            , _InvDate, _AgentID, _DistributorID, _Name, _TotalPrice _
                            , _FinalPrice, _Revenue, _Note, _UserID _
                            , _InvoiceInfo, _AgentName, _DistributorName _
                            , _Username, _FullName, _WareHouseID, _WareHouseName, _OrgInvoiceID, _OrgInvoiceNumber)


        If _InvoiceType = InvoiceType.Sell_R Then
            _OrgInvoiceID = _InvoiceID
            _OrgInvoiceNumber = _InvoiceNumber
            _InvoiceID = 0
            _InvoiceNumber = DBNull.Value
            '    _dtInvoiceDet.Clear()

            For Each r As DataRow In _dtInvoiceDet.Rows
                r.Item("Amount") = 0
                r.Item("Total") = 0
                r.Item("Revenue") = 0
                r.Item("PlusOrMinus") = 1
            Next


            _TotalPrice = Val(_TotalPrice.ToString)
            _FinalPrice = Val(_FinalPrice.ToString)
            _Revenue = Val(_Revenue.ToString)

            _Discount = IIf(_TotalPrice = 0, 0, (_TotalPrice - _FinalPrice) * 100 / _TotalPrice)
            _Discount = _Discount
            _RevPer = IIf(_TotalPrice = 0, 0, (_Revenue / _TotalPrice))

            _TotalPrice = 0
            _FinalPrice = 0
            _Revenue = 0


        End If






        _dtInvoiceDet.PrimaryKey = {_dtInvoiceDet.Columns("IsProduct"), _dtInvoiceDet.Columns("StockID")}

        cboIsPaid.SelectedValue = IIf(IsDBNull(_IsPaid), True, _IsPaid)
        numInvoiceNumber.Text = _InvoiceNumber.ToString
        numInvoiceRealNumber.Text = _InvoiceRealNumber.ToString
        numOrgInvoiceNumer.Text = _OrgInvoiceNumber.ToString
        dtpInvoiceDate.Value = IIf(IsDBNull(_InvDate), Now, _InvDate)
        cboAgent.SelectedValue = _AgentID
        txtName.Text = _Name.ToString
        cboWareHouse.SelectedValue = _WareHouseID
        cboDistributor.SelectedValue = _DistributorID
        txtNote.Text = _Note.ToString


        _TotalPrice = Val(_TotalPrice.ToString)
        _FinalPrice = Val(_FinalPrice.ToString)
        _Revenue = Val(_Revenue.ToString)

        If _InvoiceType <> InvoiceType.Sell_R Then
            _Discount = IIf(_TotalPrice = 0, 0, (_TotalPrice - _FinalPrice) * 100 / _TotalPrice)
            _RevPer = IIf(_TotalPrice = 0, 0, (_Revenue / _TotalPrice))
        End If


        With dgvTotals
            .Rows(0).Cells(1).Value = _TotalPrice
            .Rows(1).Cells(1).Value = _FinalPrice
            .Rows(2).Cells(1).Value = _Discount
            .Rows(3).Cells(1).Value = _Revenue
            .Rows(4).Cells(1).Value = _RevPer

        End With


        _bsInvoiceDet.DataSource = _dtInvoiceDet
        dgv.DataSource = _bsInvoiceDet

        With dgv
            .Columns("IsProduct").Visible = False
            .Columns("WareHouseID").Visible = False
            .Columns("WareHouseName").Visible = False
            .Columns("PlusOrMinus").Visible = False
            .Columns("StockID").Visible = False
            .Columns("ProductDetails").Visible = False
            .Columns("AvgCost").Visible = False

            .Columns("Sort").HeaderText = "ر.ت"
            .Columns("StockName").HeaderText = "البيــــــــان"
            .Columns("Barcode").HeaderText = "باركود"
            .Columns("Amount").HeaderText = "الكمية"
            .Columns("UnitPrice").HeaderText = "سعر الوحدة"
            .Columns("Total").HeaderText = "الاجمالي"
            .Columns("Revenue").HeaderText = "+"



            .Columns("Amount").DefaultCellStyle.Format = "#0"
            .Columns("UnitPrice").DefaultCellStyle.Format = "#,##0.##"
            .Columns("Total").DefaultCellStyle.Format = "#,##0.##"
            .Columns("Revenue").DefaultCellStyle.Format = "#,##0.##"

            .Columns("Revenue").DefaultCellStyle.BackColor = Color.FromArgb(179, 209, 255)
            .AutoResizeColumns()

        End With

        For Each C As DataGridViewColumn In dgv.Columns
            C.ReadOnly = True
        Next

        dgv.Columns("Amount").ReadOnly = False
        dgv.Columns("UnitPrice").ReadOnly = False







        If _InvoiceID <> 0 Then _InvoiceType = _InvoiceTypeID
        _InvoiceNumberStrTitle = IIf(IsDBNull(_InvoiceNumber) = True, "جديدة", "رقم " & _InvoiceNumber)



        CalculateTotals()









    End Sub
    Private Function fn_sp_rpt_Invoice(ByRef InvoiceID As Object, ByRef InvoiceTypeID As Object _
                                       , ByRef IsPaid As Object, ByRef InvoiceNumber As Object, ByRef InvoiceRealNumber As Object _
                                       , ByRef InvDate As Object, ByRef AgentID As Object _
                                       , ByRef DistributorID As Object, ByRef Name As Object _
                                       , ByRef TotalPrice As Object, ByRef FinalPrice As Object _
                                       , ByRef Revenue As Object, ByRef Note As Object _
                                       , ByRef UserID As Object, ByRef InvoiceInfo As Object _
                                       , ByRef AgentName As Object, ByRef DistributorName As Object _
                                       , ByRef Username As Object, ByRef FullName As Object _
                                       , ByRef WareHouseID As Object, ByRef WareHouseName As Object _
                                       , ByRef OrgInvoiceID As Object, ByRef OrgInvoiceNumber As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Invoice", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .Add("@InvoiceTypeID", SqlDbType.Int, 0)
            .Add("@IsPaid", SqlDbType.Bit, 0)
            .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@InvoiceRealNumber", SqlDbType.NVarChar, 200)
            .Add("@InvDate", SqlDbType.DateTime, 0)
            .Add("@AgentID", SqlDbType.BigInt, 0)
            .Add("@DistributorID", SqlDbType.BigInt, 0)
            .Add("@Name", SqlDbType.NVarChar, 200)
            .Add("@TotalPrice", SqlDbType.Decimal, 0)
            .Add("@FinalPrice", SqlDbType.Decimal, 0)
            .Add("@Revenue", SqlDbType.Decimal, 0)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@UserID", SqlDbType.BigInt, 0)
            .Add("@InvoiceInfo", SqlDbType.NVarChar, 200)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .Add("@Username", SqlDbType.NVarChar, 50)
            .Add("@FullName", SqlDbType.NVarChar, 200)
            .Add("@WareHouseID", SqlDbType.BigInt, 0)
            .Add("@WareHouseName", SqlDbType.NVarChar, 200)

            .Add("@OrgInvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@OrgInvoiceID", SqlDbType.BigInt, 0)
        End With

        With da.SelectCommand
            .Parameters("@InvoiceTypeID").Direction = ParameterDirection.Output
            .Parameters("@IsPaid").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvoiceRealNumber").Direction = ParameterDirection.Output
            .Parameters("@InvDate").Direction = ParameterDirection.Output
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters("@DistributorID").Direction = ParameterDirection.Output
            .Parameters("@Name").Direction = ParameterDirection.Output
            .Parameters("@TotalPrice").Direction = ParameterDirection.Output
            .Parameters("@FinalPrice").Direction = ParameterDirection.Output
            .Parameters("@Revenue").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceInfo").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output
            .Parameters("@FullName").Direction = ParameterDirection.Output
            .Parameters("@WareHouseID").Direction = ParameterDirection.Output
            .Parameters("@WareHouseName").Direction = ParameterDirection.Output

            .Parameters("@OrgInvoiceID").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceNumber").Direction = ParameterDirection.Output


            .Parameters("@InvoiceTypeID").Scale = 0
            .Parameters("@IsPaid").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@InvoiceRealNumber").Scale = 0
            .Parameters("@InvDate").Scale = 0
            .Parameters("@AgentID").Scale = 0
            .Parameters("@DistributorID").Scale = 0
            .Parameters("@Name").Scale = 0
            .Parameters("@TotalPrice").Scale = 3
            .Parameters("@FinalPrice").Scale = 3
            .Parameters("@Revenue").Scale = 3
            .Parameters("@Note").Scale = 0
            .Parameters("@UserID").Scale = 0
            .Parameters("@InvoiceInfo").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0
            .Parameters("@FullName").Scale = 0
            .Parameters("@WareHouseID").Scale = 0
            .Parameters("@WareHouseName").Scale = 0

            .Parameters("@OrgInvoiceID").Scale = 0
            .Parameters("@OrgInvoiceNumber").Scale = 0

        End With

        da.Fill(dt)

        With da.SelectCommand
            InvoiceTypeID = .Parameters("@InvoiceTypeID").Value
            IsPaid = .Parameters("@IsPaid").Value
            InvoiceNumber = .Parameters("@InvoiceNumber").Value
            InvoiceRealNumber = .Parameters("@InvoiceRealNumber").Value
            InvDate = .Parameters("@InvDate").Value
            AgentID = .Parameters("@AgentID").Value
            DistributorID = .Parameters("@DistributorID").Value
            Name = .Parameters("@Name").Value
            TotalPrice = .Parameters("@TotalPrice").Value
            FinalPrice = .Parameters("@FinalPrice").Value
            Revenue = .Parameters("@Revenue").Value
            Note = .Parameters("@Note").Value
            UserID = .Parameters("@UserID").Value
            InvoiceInfo = .Parameters("@InvoiceInfo").Value
            AgentName = .Parameters("@AgentName").Value
            DistributorName = .Parameters("@DistributorName").Value
            Username = .Parameters("@Username").Value
            FullName = .Parameters("@FullName").Value
            WareHouseID = .Parameters("@WareHouseID").Value
            WareHouseName = .Parameters("@WareHouseName").Value

            OrgInvoiceID = .Parameters("@OrgInvoiceID").Value
            OrgInvoiceNumber = .Parameters("@OrgInvoiceNumber").Value

        End With

        Return dt
    End Function
    Private Function fn_sp_rpt_Invoice(ByRef InvoiceID As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_Invoice", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .Add("@InvoiceTypeID", SqlDbType.Int, 0)
            .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@InvoiceRealNumber", SqlDbType.NVarChar, 200)
            .Add("@InvDate", SqlDbType.DateTime, 0)
            .Add("@AgentID", SqlDbType.BigInt, 0)
            .Add("@DistributorID", SqlDbType.BigInt, 0)
            .Add("@Name", SqlDbType.NVarChar, 200)
            .Add("@TotalPrice", SqlDbType.Decimal, 0)
            .Add("@FinalPrice", SqlDbType.Decimal, 0)
            .Add("@Revenue", SqlDbType.Decimal, 0)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@UserID", SqlDbType.BigInt, 0)
            .Add("@InvoiceInfo", SqlDbType.NVarChar, 200)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .Add("@Username", SqlDbType.NVarChar, 50)
            .Add("@FullName", SqlDbType.NVarChar, 200)
            .Add("@WareHouseID", SqlDbType.BigInt, 0)
            .Add("@WareHouseName", SqlDbType.NVarChar, 200)

            .Add("@OrgInvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@OrgInvoiceID", SqlDbType.BigInt, 0)
        End With

        With da.SelectCommand
            .Parameters("@InvoiceTypeID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvoiceRealNumber").Direction = ParameterDirection.Output
            .Parameters("@InvDate").Direction = ParameterDirection.Output
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters("@DistributorID").Direction = ParameterDirection.Output
            .Parameters("@Name").Direction = ParameterDirection.Output
            .Parameters("@TotalPrice").Direction = ParameterDirection.Output
            .Parameters("@FinalPrice").Direction = ParameterDirection.Output
            .Parameters("@Revenue").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceInfo").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output
            .Parameters("@FullName").Direction = ParameterDirection.Output
            .Parameters("@WareHouseID").Direction = ParameterDirection.Output
            .Parameters("@WareHouseName").Direction = ParameterDirection.Output

            .Parameters("@OrgInvoiceID").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceNumber").Direction = ParameterDirection.Output


            .Parameters("@InvoiceTypeID").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@InvoiceRealNumber").Scale = 0
            .Parameters("@InvDate").Scale = 0
            .Parameters("@AgentID").Scale = 0
            .Parameters("@DistributorID").Scale = 0
            .Parameters("@Name").Scale = 0
            .Parameters("@TotalPrice").Scale = 3
            .Parameters("@FinalPrice").Scale = 3
            .Parameters("@Revenue").Scale = 3
            .Parameters("@Note").Scale = 0
            .Parameters("@UserID").Scale = 0
            .Parameters("@InvoiceInfo").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0
            .Parameters("@FullName").Scale = 0
            .Parameters("@WareHouseID").Scale = 0
            .Parameters("@WareHouseName").Scale = 0

            .Parameters("@OrgInvoiceID").Scale = 0
            .Parameters("@OrgInvoiceNumber").Scale = 0

        End With

        da.Fill(dt)

        Return dt
    End Function
    Private Sub _bsInvoiceDet_CurrentChanged() Handles _bsInvoiceDet.CurrentChanged

        If Not IsNothing(_bsInvoiceDet.Current) AndAlso Not IsDBNull(_bsInvoiceDet.Current("StockID")) Then

            If _bsInvoiceDet.Current("IsProduct") = 1 Then
                Using da As New SqlDataAdapter("sp_v_ProductInfo", PubCn)
                    Dim dt As New DataTable
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@StockID", _bsInvoiceDet.Current("StockID"))
                    da.SelectCommand.Parameters.AddWithValue("@WareHouseID", cboWareHouse.SelectedValue)
                    da.Fill(dt)
                    dgvInfo.DataSource = dt

                    dgvInfo.Columns("Sort").Visible = False
                    dgvInfo.AutoResizeColumns()
                    dgvInfo.CurrentCell = dgvInfo.Item(1, 1)
                End Using
            Else
                dgvInfo.DataSource = Nothing
            End If






        End If

    End Sub
    Private Sub AddToInvoice(ByVal IsProduct As Object, ByVal StockID As Object, ByVal Barcode As Object, ByVal Amount As Decimal, Optional ByVal UnitCost As Decimal = Nothing)

        Dim CurrentRow As Integer = 0

        'My.Computer.Audio.Play(My.Resources.beep_08b, AudioPlayMode.Background)

        Dim srt As Integer = -1
        If Not IsNothing(_dtInvoiceDet.Rows.Find({IsProduct, StockID})) Then
            srt = _dtInvoiceDet.Rows.Find({IsProduct, StockID}).Item("Sort")
            _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Amount") += Amount
            _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Total") = _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Amount") * _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("UnitPrice")
            _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Revenue") = _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Total") - (_bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("Amount") * _bsInvoiceDet.Item(_bsInvoiceDet.Find("Sort", srt))("UnitPriceCost"))

            CurrentRow = _bsInvoiceDet.Find("Sort", srt)
        Else

            dgv.Sort(dgv.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)


            If IsNothing(cboWareHouse.SelectedValue) OrElse IsDBNull(cboWareHouse.SelectedValue) Then
            End If

            Dim mySort As Object = dgv.RowCount + 1
            Dim myIsProduct As Object = IsProduct
            Dim myWareHouseID As Object = _BsWareHouse.Current("WareHouseID")
            Dim myWareHouseName As Object = _BsWareHouse.Current("WareHouseName")
            Dim myPlusOrMinus As Object = _PlusOrMinus
            Dim myStockID As Object = StockID
            Dim myStockName As Object = _dtStock.Rows.Find({IsProduct, StockID}).Item("StockName")
            Dim myProductDetails As Object = DBNull.Value
            Dim myBarcode As Object = _dtStock.Rows.Find({IsProduct, StockID}).Item("ProductBarcode")
            Dim myAmount As Object = Amount

            Dim myUnitPrice As Object

            If IsNothing(UnitCost) OrElse UnitCost = 0 Then
                myUnitPrice = _dtStock.Rows.Find({IsProduct, StockID}).Item("SellPrice")
            Else
                myUnitPrice = UnitCost
            End If

            Dim myUnitPriceCost As Object = _dtStock.Rows.Find({IsProduct, StockID}).Item("AvgUnitCost")
            Dim myTotal As Object = myUnitPrice * myAmount
            Dim myRevenue As Object = (myUnitPrice * myAmount) - (myUnitPriceCost * myAmount)

            _bsInvoiceDet.AddNew()




            _bsInvoiceDet.Current("Sort") = mySort
            _bsInvoiceDet.Current("IsProduct") = myIsProduct
            _bsInvoiceDet.Current("WareHouseID") = myWareHouseID
            _bsInvoiceDet.Current("WareHouseName") = myWareHouseName
            _bsInvoiceDet.Current("PlusOrMinus") = myPlusOrMinus
            _bsInvoiceDet.Current("StockID") = myStockID
            _bsInvoiceDet.Current("StockName") = myStockName
            _bsInvoiceDet.Current("ProductDetails") = myProductDetails
            _bsInvoiceDet.Current("Barcode") = myBarcode
            _bsInvoiceDet.Current("Amount") = myAmount
            _bsInvoiceDet.Current("UnitPrice") = myUnitPrice
            _bsInvoiceDet.Current("AvgCost") = myUnitPriceCost
            _bsInvoiceDet.Current("Total") = myTotal
            _bsInvoiceDet.Current("Revenue") = myRevenue


            _bsInvoiceDet_CurrentChanged()

            CurrentRow = dgv.RowCount - 1


        End If




        _bsInvoiceDet.EndEdit()
        Me.Validate()

        CalculateTotals()
        SetTotals()

        dgv.AutoResizeColumns()

        dgv.CurrentCell = dgv.Rows(CurrentRow).Cells("Amount")

    End Sub
    Private Sub DeleteItemFromInvoice()

        If Not IsNothing(_bsInvoiceDet.Current) Then

            _bsInvoiceDet.RemoveCurrent()

            Dim n As Integer = 1
            For Each R As DataGridViewRow In dgv.Rows
                R.Cells("Sort").Value = n
                n += 1
            Next
            CalculateTotals()
            SetTotals()
        End If


    End Sub
    Private Sub CalculateTotals()

        _TotalCost = 0
        _TotalPrice = 0
        For Each R As DataGridViewRow In dgv.Rows
            _TotalPrice += R.Cells("Total").Value
            _TotalCost += R.Cells("avgCost").Value * R.Cells("Amount").Value
        Next

        _FinalPrice = _TotalPrice - (_Discount / 100 * _TotalPrice)
        _Revenue = _FinalPrice - _TotalCost

        If _TotalCost = 0 Then
            _RevPer = DBNull.Value
        Else
            _RevPer = _Revenue / _TotalCost
        End If


    End Sub
    Private Sub SetTotals(Optional ByVal ExeptionControlName As String = "")

        With dgvTotals
            .Rows(0).Cells(1).Value = _TotalPrice
            .Rows(1).Cells(1).Value = _FinalPrice
            .Rows(2).Cells(1).Value = _Discount
            .Rows(3).Cells(1).Value = _Revenue
            .Rows(4).Cells(1).Value = _RevPer
            .AutoResizeColumns()


        End With




    End Sub

    Private Sub SaveNewInvoice()

        Dim InvoiceID As Object

        Dim InvoiceTypeID As Object = _InvoiceTypeID
        Dim InvoiceRealNumber As Object = IIf(numInvoiceRealNumber.Text.Trim = "", DBNull.Value, numInvoiceRealNumber.Text.Trim)
        Dim OrgInvoiceNumber As Object = _OrgInvoiceNumber
        Dim OrgInvoiceID As Object = _OrgInvoiceID
        Dim InvDate As Object = dtpInvoiceDate.Value
        Dim AgentID As Object = IIf(IsNothing(cboAgent.SelectedValue), DBNull.Value, cboAgent.SelectedValue)
        Dim IsPaid As Object = IIf(IsNothing(cboIsPaid.SelectedValue), DBNull.Value, cboIsPaid.SelectedValue)
        Dim DistributorID As Object = IIf(IsNothing(cboDistributor.SelectedValue), DBNull.Value, cboDistributor.SelectedValue)
        Dim Name As Object = txtName.Text
        Dim TotalPrice As Object = _TotalPrice
        Dim FinalPrice As Object = _FinalPrice
        Dim Revenue As Object = _Revenue
        Dim Note As Object = txtNote.Text
        Dim UserID As Object = PubUserID


        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            InvoiceID = InsertIntoInvoice(MyTrans, InvoiceTypeID, IsPaid, numInvoiceNumber, InvoiceRealNumber, OrgInvoiceID, InvDate, AgentID, DistributorID, Name, TotalPrice, FinalPrice, Revenue, Note, UserID)




            _StocksBelowZero = ""
            _StockNotAvailableToReturn = ""
            For Each r As DataGridViewRow In dgv.Rows

                Dim Sort As Object = r.Cells("Sort").Value
                Dim IsProduct As Object = r.Cells("IsProduct").Value
                Dim WareHouseID As Object = r.Cells("WareHouseID").Value
                Dim PlusOrMinus As Object = r.Cells("PlusOrMinus").Value
                Dim StockID As Object = r.Cells("StockID").Value
                Dim Amount As Object = r.Cells("Amount").Value
                Dim UnitPrice As Object = r.Cells("UnitPrice").Value
                Dim AvgCost As Object = r.Cells("AvgCost").Value

                Dim StockName As Object = r.Cells("StockName").Value

                If IsProduct = 1 Then
                    InsertIntoInvoice_prd(MyTrans, InvoiceID, Sort, WareHouseID, PlusOrMinus, StockID, Amount, UnitPrice, AvgCost)

                    CheckIfStocksBelowZero(MyTrans, StockID, WareHouseID, StockName)
                    CheckIfStocksAvailableToReturn(MyTrans, StockID, _OrgInvoiceID, StockName)

                Else
                    InsertIntoInvoice_srv(MyTrans, InvoiceID, Sort, StockID, Amount, UnitPrice, AvgCost)
                End If

            Next


            If _InvoiceType <> InvoiceType.Sell_R Then
                If _StocksBelowZero <> "" Then
                    If msgShow("بعض الاصناف نفدت من المخزن هل تريد الاستمرار ؟" & vbNewLine & _StocksBelowZero, ByteClassLibrary.Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.No Then
                        Throw New Exception("لم تحفظ الفاتورة !", New Exception("Byte Error"))
                    End If
                End If
            Else
                If _StockNotAvailableToReturn <> "" Then
                    msgShow("لا يمكن استرجاع هذه الكميات" & vbNewLine & "الكميات القصوى التي يمكن استرجاعها كالاتي" & vbNewLine & _StockNotAvailableToReturn, ByteClassLibrary.Frm_msg.FormType.msgSorry)
                    Throw New Exception("لم تحفظ الفاتورة !", New Exception("Byte Error"))
                End If
            End If





            MyTrans.Commit()
            msgShow("تم حفظ الفاتورة بنجاح", ByteClassLibrary.Frm_msg.FormType.msgDone)

            _InvoiceID = InvoiceID
            _InvoiceType = 0
            GetInvoice()
            SetForm()

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try
    End Sub
    Private Sub SaveInvoice()

        Dim InvoiceID As Object = _InvoiceID

        Dim InvoiceTypeID As Object = _InvoiceTypeID
        Dim InvoiceRealNumber As Object = Val(numInvoiceRealNumber.Text)
        Dim OrgInvoiceNumber As Object = _OrgInvoiceNumber
        Dim InvDate As Object = dtpInvoiceDate.Value
        Dim AgentID As Object = IIf(IsNothing(cboAgent.SelectedValue), DBNull.Value, cboAgent.SelectedValue)
        Dim IsPaid As Object = IIf(IsNothing(cboIsPaid.SelectedValue), DBNull.Value, cboIsPaid.SelectedValue)
        Dim DistributorID As Object = IIf(IsNothing(cboDistributor.SelectedValue), DBNull.Value, cboDistributor.SelectedValue)
        Dim Name As Object = txtName.Text
        Dim TotalPrice As Object = _TotalPrice
        Dim FinalPrice As Object = _FinalPrice
        Dim Revenue As Object = _Revenue
        Dim Note As Object = txtNote.Text
        Dim UserID As Object = PubUserID

        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            UpdateInvoice(MyTrans, InvoiceID, IsPaid, InvoiceRealNumber, InvDate, AgentID, DistributorID, Name, TotalPrice, FinalPrice, Revenue, Note, UserID)


            If Not IsNothing(_dtInvoiceDet.GetChanges) Then
                DeleteInvoice_prd(MyTrans, InvoiceID)
                DeleteInvoice_srv(MyTrans, InvoiceID)

                _StocksBelowZero = ""
                _StockNotAvailableToReturn = ""
                For Each r As DataGridViewRow In dgv.Rows

                    Dim Sort As Object = r.Cells("Sort").Value
                    Dim IsProduct As Object = r.Cells("IsProduct").Value
                    Dim WareHouseID As Object = r.Cells("WareHouseID").Value
                    Dim PlusOrMinus As Object = r.Cells("PlusOrMinus").Value
                    Dim StockID As Object = r.Cells("StockID").Value
                    Dim Amount As Object = r.Cells("Amount").Value
                    Dim UnitPrice As Object = r.Cells("UnitPrice").Value
                    Dim AvgCost As Object = r.Cells("AvgCost").Value

                    Dim StockName As Object = r.Cells("StockName").Value

                    If IsProduct = 1 Then
                        InsertIntoInvoice_prd(MyTrans, InvoiceID, Sort, WareHouseID, PlusOrMinus, StockID, Amount, UnitPrice, AvgCost)

                        CheckIfStocksBelowZero(MyTrans, StockID, WareHouseID, StockName)
                        CheckIfStocksAvailableToReturn(MyTrans, StockID, _OrgInvoiceID, StockName)
                    Else
                        InsertIntoInvoice_srv(MyTrans, InvoiceID, Sort, StockID, Amount, UnitPrice, AvgCost)
                    End If

                Next
            End If

            If _InvoiceType <> InvoiceType.Sell_R Then

                If _StocksBelowZero <> "" Then
                    If msgShow("بعض الاصناف نفدت من المخزن هل تريد الاستمرار ؟" & vbNewLine & _StocksBelowZero, ByteClassLibrary.Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.No Then
                        Throw New Exception("لم تحفظ الفاتورة !", New Exception("Byte Error"))
                    End If
                End If
            Else
                If _StockNotAvailableToReturn <> "" Then
                    msgShow("لا يمكن استرجاع هذه الكميات" & vbNewLine & "الكميات القصوى التي يمكن استرجاعها كالاتي" & vbNewLine & _StockNotAvailableToReturn, ByteClassLibrary.Frm_msg.FormType.msgSorry)
                    Throw New Exception("لم تحفظ الفاتورة !", New Exception("Byte Error"))
                End If

            End If

            MyTrans.Commit()
            msgShow("تم حفظ الفاتورة بنجاح", ByteClassLibrary.Frm_msg.FormType.msgDone)

            _InvoiceType = 0
            GetInvoice()
            SetForm()



        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try


    End Sub

    Public Shared Sub InvoiceDelete(ByVal InvoiceID As Int64)

        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            DeleteInvoice_prd(MyTrans, InvoiceID)
            DeleteInvoice_srv(MyTrans, InvoiceID)
            DeleteInvoice(MyTrans, InvoiceID)



            MyTrans.Commit()
            msgShow("تم حذف الفاتورة بنجاح", ByteClassLibrary.Frm_msg.FormType.msgDone)

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try
    End Sub



    Public Shared Function InsertIntoInvoice(ByVal Trans As SqlTransaction, ByVal InvoiceTypeID As Object, ByVal IsPaid As Object, ByVal InvoiceNumber As Object, ByVal InvoiceRealNumber As Object, ByVal OrgInvoiceID As Object, ByVal InvDate As Object, ByVal AgentID As Object, ByVal DistributorID As Object, ByVal Name As Object, ByVal TotalPrice As Object, ByVal FinalPrice As Object, ByVal Revenue As Object, ByVal Note As Object, ByVal UserID As Object) As Int64
        Dim InsCom As New SqlCommand
        InsCom.Connection = PubCn
        InsCom.Transaction = Trans
        InsCom.CommandText = "sp_tbl_Invoice_Insert"
        InsCom.CommandType = CommandType.StoredProcedure
        With InsCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceTypeID", InvoiceTypeID)
            .AddWithValue("@IsPaid", IsPaid)
            .AddWithValue("@InvoiceNumber", DBNull.Value)
            .AddWithValue("@InvoiceRealNumber", InvoiceRealNumber)
            .AddWithValue("@OrgInvoiceID", OrgInvoiceID)
            .AddWithValue("@InvDate", InvDate)
            .AddWithValue("@AgentID", AgentID)
            .AddWithValue("@DistributorID", DistributorID)
            .AddWithValue("@Name", Name)
            .AddWithValue("@TotalPrice", TotalPrice)
            .AddWithValue("@FinalPrice", FinalPrice)
            .AddWithValue("@Revenue", Revenue)
            .AddWithValue("@Note", Note)
            .AddWithValue("@UserID", UserID)

        End With
        Return InsCom.ExecuteScalar

    End Function
    Public Shared Sub UpdateInvoice(ByVal Trans As SqlTransaction, ByVal InvoiceID As Int64, ByVal IsPaid As Object, ByVal InvoiceRealNumber As Object, ByVal InvDate As Object, ByVal AgentID As Object, ByVal DistributorID As Object, ByVal Name As Object, ByVal TotalPrice As Object, ByVal FinalPrice As Object, ByVal Revenue As Object, ByVal Note As Object, ByVal UserID As Object)
        Dim UpdtCom As New SqlCommand
        UpdtCom.Connection = PubCn
        UpdtCom.Transaction = Trans
        UpdtCom.CommandText = "sp_tbl_Invoice_Update"
        UpdtCom.CommandType = CommandType.StoredProcedure
        With UpdtCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .AddWithValue("@IsPaid", IsPaid)
            .AddWithValue("@InvoiceRealNumber", InvoiceRealNumber)
            .AddWithValue("@InvDate", InvDate)
            .AddWithValue("@AgentID", AgentID)
            .AddWithValue("@DistributorID", DistributorID)
            .AddWithValue("@Name", Name)
            .AddWithValue("@TotalPrice", TotalPrice)
            .AddWithValue("@FinalPrice", FinalPrice)
            .AddWithValue("@Revenue", Revenue)
            .AddWithValue("@Note", Note)
            .AddWithValue("@UserID", UserID)

        End With
        UpdtCom.ExecuteNonQuery()

    End Sub
    Public Shared Sub DeleteInvoice(ByVal Trans As SqlTransaction, ByVal InvoiceID As Int64)
        Dim DelCom As New SqlCommand
        DelCom.Connection = PubCn
        DelCom.Transaction = Trans
        DelCom.CommandText = "sp_tbl_Invoice_Delete"
        DelCom.CommandType = CommandType.StoredProcedure
        With DelCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
        End With
        DelCom.ExecuteNonQuery()
    End Sub

    Public Shared Function InsertIntoInvoice_prd(ByVal Trans As SqlTransaction, ByVal InvoiceID As Object, ByVal Sort As Object, ByVal WareHouseID As Object, ByVal PlusOrMinus As Object, ByVal StockID As Object, ByVal Amount As Object, ByVal UnitPrice As Object, ByVal avgCost As Object, Optional ByVal Note As Object = Nothing) As Int64
        Dim InsCom As New SqlCommand
        InsCom.Connection = PubCn
        InsCom.Transaction = Trans
        InsCom.CommandText = "sp_tbl_Invoice_prd_Insert"
        InsCom.CommandType = CommandType.StoredProcedure
        With InsCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .AddWithValue("@Sort", Sort)
            .AddWithValue("@WareHouseID", WareHouseID)
            .AddWithValue("@PlusOrMinus", PlusOrMinus)
            .AddWithValue("@StockID", StockID)
            .AddWithValue("@Amount", Amount)
            .AddWithValue("@UnitPrice", UnitPrice)
            .AddWithValue("@AvgCost", avgCost)
            .AddWithValue("@Note", Note)
        End With
        Return InsCom.ExecuteNonQuery()

    End Function
    Public Shared Sub DeleteInvoice_prd(ByVal Trans As SqlTransaction, ByVal InvoiceID As Object)
        Dim DelCom As New SqlCommand
        DelCom.Connection = PubCn
        DelCom.Transaction = Trans
        DelCom.CommandText = "sp_tbl_Invoice_prd_Del"
        DelCom.CommandType = CommandType.StoredProcedure
        With DelCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
        End With
        DelCom.ExecuteNonQuery()
    End Sub
    Private Function InsertIntoInvoice_srv(ByVal Trans As SqlTransaction, ByVal InvoiceID As Object, ByVal Sort As Object, ByVal ServiceID As Object, ByVal Amount As Object, ByVal UnitPrice As Object, ByVal UnitPriceCost As Object) As Int64
        Dim InsCom As New SqlCommand
        InsCom.Connection = PubCn
        InsCom.Transaction = Trans
        InsCom.CommandText = "sp_tbl_Invoice_srv_Insert"
        InsCom.CommandType = CommandType.StoredProcedure
        With InsCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .AddWithValue("@Sort", Sort)
            .AddWithValue("@ServiceID", ServiceID)
            .AddWithValue("@Amount", Amount)
            .AddWithValue("@UnitPrice", UnitPrice)
            .AddWithValue("@UnitPriceCost", UnitPriceCost)

        End With
        Return InsCom.ExecuteNonQuery()

    End Function
    Private Shared Sub DeleteInvoice_srv(ByVal Trans As SqlTransaction, ByVal InvoiceID As Object)
        Dim DelCom As New SqlCommand
        DelCom.Connection = PubCn
        DelCom.Transaction = Trans
        DelCom.CommandText = "sp_tbl_Invoice_srv_Delete"
        DelCom.CommandType = CommandType.StoredProcedure
        With DelCom.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
        End With
        DelCom.ExecuteNonQuery()

    End Sub

    Dim _StocksBelowZero As String = ""
    Private Sub CheckIfStocksBelowZero(ByVal Trans As SqlTransaction, ByVal StockID As Object, ByVal WareHouseID As Object, ByVal StockName As Object)
        Dim sc As New SqlCommand("select dbo.fn_StockAmountByWareHouseToDate(@StockID,@WareHouseID,Null)")
        sc.Connection = PubCn
        sc.Transaction = Trans
        With sc.Parameters
            .Clear()
            .AddWithValue("@StockID", StockID)
            .AddWithValue("@WareHouseID", WareHouseID)
        End With

        Dim out As Decimal = sc.ExecuteScalar

        If out < 0 Then
            _StocksBelowZero = _StocksBelowZero & vbNewLine & StockName & "  ----  " & Format(out, "###.###")
        End If

    End Sub

    Dim _StockNotAvailableToReturn As String = ""
    Private Sub CheckIfStocksAvailableToReturn(ByVal Trans As SqlTransaction, ByVal StockID As Object, ByVal InvoiceID As Object, ByVal StockName As Object)
        Dim sc As New SqlCommand("select dbo.fn_StockAmountAvailableToReturn(@StockID,@InvoiceID)")
        sc.Connection = PubCn
        sc.Transaction = Trans
        With sc.Parameters
            .Clear()
            .AddWithValue("@StockID", StockID)
            .AddWithValue("@InvoiceID", InvoiceID)
        End With

        Dim out As Object = sc.ExecuteScalar

        If IsDBNull(out) = False AndAlso out < 0 Then
            _StockNotAvailableToReturn = _StockNotAvailableToReturn & vbNewLine & StockName
        End If

    End Sub






    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit

        Dim IsProduct As Object = dgv.Rows(e.RowIndex).Cells("IsProduct").Value

        Dim StockID As Int64 = dgv.Rows(e.RowIndex).Cells("StockID").Value
        Dim Amount As Decimal = dgv.Rows(e.RowIndex).Cells("Amount").Value
        Dim SubAmount As Object = _dtStock.Rows.Find({IsProduct, StockID}).Item("SubAmount")
        Dim PacketSellPrice As Object = _dtStock.Rows.Find({IsProduct, StockID}).Item("PacketSellPrice")
        Dim SellPrice As Decimal = _dtStock.Rows.Find({IsProduct, StockID}).Item("SellPrice")







        If (_InvoiceType = InvoiceType.Sell Or _InvoiceType = InvoiceType.PreSale) _
            AndAlso dgv.Rows(e.RowIndex).Cells("IsProduct").Value = 1 _
            AndAlso dgv.Columns(e.ColumnIndex).Name = "Amount" _
            AndAlso IsDBNull(SubAmount) = False _
            AndAlso IsDBNull(PacketSellPrice) = False Then


            Dim JumlaUnitPrice As Decimal = PacketSellPrice / SubAmount

            If Amount = SubAmount Then
                dgv.Rows(e.RowIndex).Cells("Total").Value = PacketSellPrice
                dgv.Rows(e.RowIndex).Cells("UnitPrice").Value = JumlaUnitPrice
            ElseIf Amount < SubAmount Then
                dgv.Rows(e.RowIndex).Cells("UnitPrice").Value = SellPrice
                dgv.Rows(e.RowIndex).Cells("Total").Value = dgv.Rows(e.RowIndex).Cells("UnitPrice").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value

            ElseIf Amount > SubAmount Then
                dgv.Rows(e.RowIndex).Cells("Total").Value = JumlaUnitPrice * dgv.Rows(e.RowIndex).Cells("Amount").Value
                dgv.Rows(e.RowIndex).Cells("UnitPrice").Value = JumlaUnitPrice
            End If

            dgv.Rows(e.RowIndex).Cells("Revenue").Value = dgv.Rows(e.RowIndex).Cells("Total").Value - (dgv.Rows(e.RowIndex).Cells("AvgCost").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value)

        ElseIf IsProduct <> 1 Then
            dgv.Rows(e.RowIndex).Cells("Total").Value = dgv.Rows(e.RowIndex).Cells("UnitPrice").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value
            dgv.Rows(e.RowIndex).Cells("AvgCost").Value = dgv.Rows(e.RowIndex).Cells("UnitPrice").Value
            dgv.Rows(e.RowIndex).Cells("Revenue").Value = dgv.Rows(e.RowIndex).Cells("Total").Value - (dgv.Rows(e.RowIndex).Cells("AvgCost").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value)
        Else
            dgv.Rows(e.RowIndex).Cells("Total").Value = dgv.Rows(e.RowIndex).Cells("UnitPrice").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value
            dgv.Rows(e.RowIndex).Cells("Revenue").Value = dgv.Rows(e.RowIndex).Cells("Total").Value - (dgv.Rows(e.RowIndex).Cells("AvgCost").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value)

        End If




        CalculateTotals()
        SetTotals()


        dgv.AutoResizeColumns()










        'If dgv.Columns(e.ColumnIndex).Name = "Amount" Then

        '    If (_InvoiceType = InvoiceType.Sell Or _InvoiceType = InvoiceType.PreSale) _
        '        AndAlso dgv.Rows(e.RowIndex).Cells("IsProduct").Value = 1 Then
        '        Dim StockID As Int64 = dgv.Rows(e.RowIndex).Cells("IsProduct").Value
        '        Dim Amount As Decimal = dgv.Rows(e.RowIndex).Cells("Amount").Value
        '        Dim SubAmount As Object = _dtProductAll.Rows.Find({1, StockID}).Item("SubAmount")
        '        Dim PacketSellPrice As Object = _dtProductAll.Rows.Find({1, StockID}).Item("PacketSellPrice")
        '        Dim SellPrice As Decimal = _dtProductAll.Rows.Find({1, StockID}).Item("SellPrice")

        '        If Not IsDBNull(SubAmount) AndAlso Amount = SubAmount Then
        '            dgv.Rows(e.RowIndex).Cells("Total").Value = PacketSellPrice
        '            dgv.Rows(e.RowIndex).Cells("Revenue").Value = dgv.Rows(e.RowIndex).Cells("Total").Value - (dgv.Rows(e.RowIndex).Cells("UnitPriceCost").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value)
        '        ElseIf Amount > SubAmount Then


        '        Else


        '        End If


        '    Else
        '        dgv.Rows(e.RowIndex).Cells("Total").Value = dgv.Rows(e.RowIndex).Cells("UnitPrice").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value
        '        dgv.Rows(e.RowIndex).Cells("Revenue").Value = dgv.Rows(e.RowIndex).Cells("Total").Value - (dgv.Rows(e.RowIndex).Cells("UnitPriceCost").Value * dgv.Rows(e.RowIndex).Cells("Amount").Value)
        '    End If

        'End If


        'CalculateTotals()
        'SetTotals()


        'dgv.AutoResizeColumns()



    End Sub
    Private Sub dgvTotals_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTotals.CellEndEdit

        If e.ColumnIndex = 1 Then
            If e.RowIndex = 1 Then
                _FinalPrice = dgvTotals.Item(e.ColumnIndex, e.RowIndex).Value
                If _TotalPrice <> 0 Then _Discount = (_TotalPrice - _FinalPrice) / _TotalPrice * 100 Else _Discount = 0
                ' dgvTotals.Item(1, 2).Value = _Discount
            ElseIf e.RowIndex = 2 Then
                _Discount = dgvTotals.Item(e.ColumnIndex, e.RowIndex).Value
                _FinalPrice = _TotalPrice - (_TotalPrice * _Discount / 100)
                '     dgvTotals.Item(1, 1).Value = _FinalPrice
            End If
        End If
        _Revenue = _FinalPrice - _TotalCost

        If _TotalCost = 0 Then _RevPer = DBNull.Value Else _RevPer = (_Revenue / _TotalCost)

        SetTotals()

        dgvTotals.AutoResizeColumns()



    End Sub
    Private Sub dgv_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyUp
        If e.KeyCode = Keys.Delete Then
            DeleteItemFromInvoice()
        End If
    End Sub
    Private Sub dgv_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Sorted

        If dgv.RowCount > 0 Then

            If dgv.SortedColumn.Name = "Sort" AndAlso dgv.SortOrder = Windows.Forms.SortOrder.Descending Then
                dgv.Sort(dgv.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)
            End If

            Dim n As Integer = 1
            For Each R As DataGridViewRow In dgv.Rows
                R.Cells("Sort").Value = n
                n += 1
            Next
        End If



    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            ErrorProvider1.Clear()
            Dim IsOneOfTheFieldsEmpty As Boolean = False

            If (IsNothing(cboAgent.SelectedValue) OrElse IsDBNull(cboAgent.SelectedValue)) And PAgent.Visible = True Then
                ErrorProvider1.SetError(cboAgent, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If

            If (IsNothing(cboWareHouse.SelectedValue) OrElse IsDBNull(cboWareHouse.SelectedValue)) And PWareHouse.Visible = True Then
                ErrorProvider1.SetError(cboWareHouse, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If

            If (IsNothing(cboDistributor.SelectedValue) OrElse IsDBNull(cboDistributor.SelectedValue)) And PDistributor.Visible = True Then
                ErrorProvider1.SetError(cboDistributor, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If

            If (IsNothing(cboIsPaid.SelectedValue) OrElse IsDBNull(cboIsPaid.SelectedValue)) And pPay.Visible = True Then
                ErrorProvider1.SetError(cboIsPaid, "تأكد من ملء الحقل")
                IsOneOfTheFieldsEmpty = True
            End If


            If IsOneOfTheFieldsEmpty = True Then Throw New Exception("تأكد من ملء الحقول", New Exception("ByteError"))
            If _TotalPrice <= 0 Then Throw New Exception("تأكد من الاجمالي", New Exception("ByteError"))

            Me.Validate()

            For Each R As DataGridViewRow In dgv.Rows
                If R.Cells("Amount").Value = 0 Then dgv.Rows.Remove(R)
            Next


            If _InvoiceID = 0 Then
                SaveNewInvoice()
            Else
                SaveInvoice()
            End If








        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try





    End Sub
    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        btnSave.PerformClick()
    End Sub
#End Region




    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        _bl_BarcodeReceived("001")
    End Sub






End Class