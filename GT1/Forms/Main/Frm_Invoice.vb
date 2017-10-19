Imports System.Data.SqlClient
Imports ByteClassLibrary.MyFunctions
Imports ByteClassLibrary
Imports System.Text

Public Class Frm_Invoice


#Region "       Dim Things"

    Dim WithEvents BL As New ByteClassLibrary.ByteBarcodeListener2(Me, "cboItem", 10)


    Dim WithEvents _BsAgent As New BindingSource
    Dim WithEvents _BsDistributor As New BindingSource

    Dim WithEvents _DaInvoice As New SqlDataAdapter
    Dim WithEvents _DtInvoice As New DataTable
    Dim WithEvents _BsInvoice As New BindingSource

    Dim _IsInvoiceChanged As Boolean = False


    Dim WithEvents _BsItem As New BindingSource


    Dim _InvoiceType As InvoiceTypes
    Dim _InvoiceID As Object
    Dim _InvoiceTypeID As Object = 0
    Dim _IsPaid As Object
    Dim _InvoiceNumber As Object
    Dim _InvoiceRealNumber As Object
    Dim _OrgInvoiceNumber As Object
    Dim _OrgInvoiceID As Object
    Dim _InvDate As Object
    Dim _AgentID As Object
    Dim _DistributorID As Object
    Dim _CustomerName As Object
    Dim _TotalPrice As Object = 0
    Dim _FinalPrice As Object = 0
    Dim _Revenue As Object = 0
    Dim _Note As Object
    Dim _UserID As Object
    Dim _InvoiceTypeName As Object
    Dim _AgentName As Object
    Dim _DistributorName As Object
    Dim _Username As Object

    Dim _AmountPaid As Object

    Dim _PlusOrMinus As Object

    Dim _InvoiceNumberStrTitle As String

    Dim _TotalCost As Object = 0
    Dim _Discount As Object = 0
    Dim _RevPer As Object = 0

    Public Event InvoiceTypeChanged(ByVal val As Object)
    Public Event InvoiceIDChanged(ByVal val As Object)
    Public Event InvoiceTypeIDChanged(ByVal val As Object)
    Public Event IsPaidChanged(ByVal val As Object)
    Public Event InvoiceNumberChanged(ByVal val As Object)
    Public Event InvoiceRealNumberChanged(ByVal val As Object)
    Public Event OrgInvoiceNumberChanged(ByVal val As Object)
    Public Event OrgInvoiceIDChanged(ByVal val As Object)
    Public Event InvDateChanged(ByVal val As Object)
    Public Event AgentIDChanged(ByVal val As Object)
    Public Event DistributorIDChanged(ByVal val As Object)
    Public Event CustomerNameChanged(ByVal val As Object)
    Public Event TotalPriceChanged(ByVal val As Object)
    Public Event FinalPriceChanged(ByVal val As Object)
    Public Event RevenueChanged(ByVal val As Object)
    Public Event NoteChanged(ByVal val As Object)
    Public Event UserIDChanged(ByVal val As Object)
    Public Event InvoiceTypeNameChanged(ByVal val As Object)
    Public Event AgentNameChanged(ByVal val As Object)
    Public Event DistributorNameChanged(ByVal val As Object)
    Public Event UsernameChanged(ByVal val As Object)
    Public Event PlusOrMinusChanged(ByVal val As Object)
    Public Event InvoiceNumberStrTitleChanged(ByVal val As Object)
    Public Event TotalCostChanged(ByVal val As Object)
    Public Event DiscountChanged(ByVal val As Object)
    Public Event RevPerChanged(ByVal val As Object)

    Public Event AmountPaidChanged(ByVal val As Object)



    Enum InvoiceTypes
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

#End Region
#Region "       Properties"


    Public Property InvoiceType As InvoiceTypes
        Get
            Return _InvoiceType
        End Get
        Set(ByVal value As InvoiceTypes)
            _InvoiceType = value
            RaiseEvent InvoiceTypeChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property InvoiceID As Object
        Get
            Return _InvoiceID
        End Get
        Set(ByVal value As Object)
            _InvoiceID = value
            RaiseEvent InvoiceIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property InvoiceTypeID As Object
        Get
            Return _InvoiceTypeID
        End Get
        Set(ByVal value As Object)
            _InvoiceTypeID = value
            RaiseEvent InvoiceTypeIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property IsPaid As Object
        Get
            Return _IsPaid
        End Get
        Set(ByVal value As Object)
            _IsPaid = value
            RaiseEvent IsPaidChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property InvoiceNumber As Object
        Get
            Return _InvoiceNumber
        End Get
        Set(ByVal value As Object)
            _InvoiceNumber = value
            RaiseEvent InvoiceNumberChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property InvoiceRealNumber As Object
        Get
            Return _InvoiceRealNumber
        End Get
        Set(ByVal value As Object)
            _InvoiceRealNumber = value
            RaiseEvent InvoiceRealNumberChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property OrgInvoiceNumber As Object
        Get
            Return _OrgInvoiceNumber
        End Get
        Set(ByVal value As Object)
            _OrgInvoiceNumber = value
            RaiseEvent OrgInvoiceNumberChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property OrgInvoiceID As Object
        Get
            Return _OrgInvoiceID
        End Get
        Set(ByVal value As Object)
            _OrgInvoiceID = value
            RaiseEvent OrgInvoiceIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property InvDate As Object
        Get
            Return _InvDate
        End Get
        Set(ByVal value As Object)
            _InvDate = value
            RaiseEvent InvDateChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property AgentID As Object
        Get
            Return _AgentID
        End Get
        Set(ByVal value As Object)
            _AgentID = value
            If Not IsNothing(_BsAgent.Current) AndAlso Not IsDBNull(_BsAgent.Current("AgentID")) Then
                AgentName = _BsAgent.Current("AgentName")
            End If
            RaiseEvent AgentIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property DistributorID As Object
        Get
            Return _DistributorID
        End Get
        Set(ByVal value As Object)
            _DistributorID = value
            If Not IsNothing(_BsDistributor.Current) AndAlso Not IsDBNull(_BsDistributor.Current("DistributorID")) Then
                DistributorName = _BsDistributor.Current("DistributorName")
            End If
            RaiseEvent DistributorIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property CustomerName As Object
        Get
            Return _CustomerName
        End Get
        Set(ByVal value As Object)
            _CustomerName = value
            RaiseEvent CustomerNameChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property TotalPrice As Object
        Get
            Return _TotalPrice
        End Get
        Set(ByVal value As Object)
            _TotalPrice = value
            RaiseEvent TotalPriceChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property FinalPrice As Object
        Get
            Return _FinalPrice
        End Get
        Set(ByVal value As Object)
            _FinalPrice = value
            RaiseEvent FinalPriceChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property Revenue As Object
        Get
            Return _Revenue
        End Get
        Set(ByVal value As Object)
            _Revenue = value
            RaiseEvent RevenueChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property Note As Object
        Get
            Return _Note
        End Get
        Set(ByVal value As Object)
            _Note = value
            RaiseEvent NoteChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property
    Public Property UserID As Object
        Get
            Return _UserID
        End Get
        Set(ByVal value As Object)
            _UserID = value
            RaiseEvent UserIDChanged(value)
            _IsInvoiceChanged = True
        End Set
    End Property


    Public Property InvoiceTypeName As Object
        Get
            Return _InvoiceTypeName
        End Get
        Set(ByVal value As Object)
            _InvoiceTypeName = value
            RaiseEvent InvoiceTypeNameChanged(value)
        End Set
    End Property
    Public Property AgentName As Object
        Get
            Return _AgentName
        End Get
        Set(ByVal value As Object)
            _AgentName = value
            RaiseEvent AgentNameChanged(value)
        End Set
    End Property
    Public Property DistributorName As Object
        Get
            Return _DistributorName
        End Get
        Set(ByVal value As Object)
            _DistributorName = value
            RaiseEvent DistributorNameChanged(value)
        End Set
    End Property
    Public Property Username As Object
        Get
            Return _Username
        End Get
        Set(ByVal value As Object)
            _Username = value
            RaiseEvent UsernameChanged(value)
        End Set
    End Property





    Public Property PlusOrMinus As Object
        Get
            Return _PlusOrMinus
        End Get
        Set(ByVal value As Object)
            _PlusOrMinus = value
            RaiseEvent PlusOrMinusChanged(value)
        End Set
    End Property
    Public Property TotalCost As Object
        Get
            Return _TotalCost
        End Get
        Set(ByVal value As Object)
            _TotalCost = value
            RaiseEvent TotalCostChanged(value)
        End Set
    End Property
    Public Property Discount As Object
        Get
            Return _Discount
        End Get
        Set(ByVal value As Object)
            _Discount = value
            RaiseEvent DiscountChanged(value)
        End Set
    End Property
    Public Property RevPer As Object
        Get
            Return _RevPer
        End Get
        Set(ByVal value As Object)
            _RevPer = value
            RaiseEvent RevPerChanged(value)
        End Set
    End Property

    Public Property AmountPaid As Object
        Get
            Return _AmountPaid
        End Get
        Set(ByVal value As Object)
            _AmountPaid = value
            RaiseEvent AmountPaidChanged(value)
        End Set
    End Property



#End Region


    Public Sub New(ByVal myInvoiceID As Int64)

        ' This call is required by the designer.
        InitializeComponent()

        InvoiceID = myInvoiceID

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal myInvoiceType As InvoiceTypes)

        ' This call is required by the designer.
        InitializeComponent()

        InvoiceID = 0
        InvoiceType = myInvoiceType
        InvoiceTypeID = InvoiceType

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal myInvoiceType As InvoiceTypes, ByVal MyOrgInvoiceID As Int64)

        ' This call is required by the designer.
        InitializeComponent()

        InvoiceID = 0
        InvoiceType = myInvoiceType
        InvoiceTypeID = InvoiceType
        OrgInvoiceID = MyOrgInvoiceID


        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Protected Overrides Function ProcessKeyEventArgs(ByRef msg As Message) As Boolean
        If msg.WParam = Keys.PrintScreen Then
            btnSave.PerformClick()
            btnPrint.PerformClick()

        End If

        Return MyBase.ProcessKeyEventArgs(msg)
    End Function





    Private Sub Frm_Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FontMyControl(Me)
            IniDgvInfo()
            IniDgvTotal()
            IniItemType()
            Get_sp_hlp_Agent()
            Get_sp_hlp_Distibutor()



            Ini_Invoice_Det_DataAdapter()
            GetInvoice()
            Get_sp_hlp_Item()





        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Frm_Invoice_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            lblTotal.Font = New Font("Arial", 36, FontStyle.Bold)
            FormConditionalApearance()


            cboItem.dgv.ShowCellToolTips = False
            cboAgent.dgv.ShowCellToolTips = False
            tt.Font = MF.aljazeera
            'tt.Font = New Font("Tahoma", 10)



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Frm_Invoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If _IsInvoiceChanged = True AndAlso msgShow("توجد بيانات غير محفوظة ,هل تريد الحفظ ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then
                btnSave.PerformClick()
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

#Region "       dgvInfo"

    ''' <summary>
    ''' the dgvInfo is a custom datagridview taken from class "ByteDGV" in GT1 Project
    ''' </summary>
    ''' <remarks></remarks>
    ''' 


    Dim WithEvents cboDistributor As New ByteClassLibrary.MyGridTextBox3
    Dim WithEvents cboAgent As New ByteClassLibrary.MyGridTextBox3

    Dim WithEvents numInvoiceNumber As New ByteClassLibrary.MyNumericBox
    Dim WithEvents numInvoiceRealNumber As New ByteClassLibrary.MyNumericBox
    Dim WithEvents numOrgInvoiceNumer As New ByteClassLibrary.MyNumericBox

    Dim WithEvents dtpInvoiceDate As New ByteClassLibrary.MyDateTimePicker

    Dim WithEvents txtCustomerName As New ByteClassLibrary.MyTextBox
    Dim WithEvents txtNote As New ByteClassLibrary.MyTextBox

#Region "       Agent"


    Private Sub Get_sp_hlp_Agent()




        Dim da As New SqlDataAdapter("sp_hlp_Agent", PubCn)
        Dim dt As New DataTable




        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)


        _BsAgent.DataSource = dt
        _BsAgent.RemoveAt(_BsAgent.Find("AgentID", DBNull.Value))


        With cboAgent

            .Name = "Agent"
            .MySource = _BsAgent

            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "AgentID", False, "", "")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "AgentName", True, "الاسم")
            .SetColumn("Sort", False, False)



            .MyBeginProcess()




        End With



    End Sub

    Private Function fn_sp_rpt_AgentInfo(ByRef AgentID As Object, ByRef AgentName As Object, ByRef Balance As Object, ByRef Phone As Object, ByRef address As Object, ByRef Note As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_AgentInfo", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@AgentID", AgentID)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .Add("@Balance", SqlDbType.Decimal, 0)
            .Add("@Phone", SqlDbType.NVarChar, 200)
            .Add("@address", SqlDbType.NVarChar, 200)
            .Add("@Note", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@Balance").Direction = ParameterDirection.Output
            .Parameters("@Phone").Direction = ParameterDirection.Output
            .Parameters("@address").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output


            .Parameters("@AgentName").Scale = 0
            .Parameters("@Balance").Scale = 3
            .Parameters("@Phone").Scale = 0
            .Parameters("@address").Scale = 0
            .Parameters("@Note").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            AgentName = .Parameters("@AgentName").Value
            Balance = .Parameters("@Balance").Value
            Phone = .Parameters("@Phone").Value
            address = .Parameters("@address").Value
            Note = .Parameters("@Note").Value

        End With

        Return dt
    End Function
    Private Function GetAgentInfo(ByVal AgentID As Int64) As String
        Dim str As String = ""

        Dim AgentName As String = ""
        Dim Balance As Decimal = 0
        Dim Phone As Object
        Dim address As Object
        Dim Note As Object

        fn_sp_rpt_AgentInfo(AgentID, AgentName, Balance, Phone, address, Note)


        str = str & "الاسم : " & AgentName & vbNewLine
        str = str & "الرصيد : " & Format(Balance, "#,##0.00#")


        If IsDBNull(Phone) = False Then
            str = str & vbNewLine
            str = str & "هاتف : " & Phone
        End If


        If IsDBNull(address) = False Then
            str = str & vbNewLine
            str = str & "عنوان : " & address
        End If


        If IsDBNull(Note) = False Then
            str = str & vbNewLine
            str = str & "ملاحظة : " & Note
        End If







        Return str
    End Function



    Private Sub cboAgent_DGVChangedCurrenCell(ByVal CurrentID As Object, ByVal CurrentDisplayCellRect As Rectangle) Handles cboAgent.DGVChangedCurrenCell


        Dim ID As Int64 = CurrentID

        tt.Hide(cboAgent.dgv)
        tt.Show(GetAgentInfo(ID), cboAgent.dgv, CurrentDisplayCellRect.X + CurrentDisplayCellRect.Height / 2, CurrentDisplayCellRect.Y + CurrentDisplayCellRect.Height / 2, 10000)



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

        _BsDistributor.RemoveAt(_BsDistributor.Find("DistributorID", DBNull.Value))

        _BsDistributor.Filter = "DistributorID is not null"
        _BsDistributor.Sort = "DistributorName asc"




        With cboDistributor
            .MySource = _BsDistributor
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "DistributorID", False, "ر.م")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "DistributorName", True, "الاسم")
            .SetColumn("Sort", False, False)


            .MyBeginProcess()
        End With





    End Sub




#End Region



    Dim CellDgvInfo_InvoiceNumber As DataGridViewCell
    Dim CellDgvInfo_InvoiceRealNumber As DataGridViewCell
    Dim CellDgvInfo_OrgInvoiceNumber As DataGridViewCell
    Dim CellDgvInfo_InvDate As DataGridViewCell
    Dim CellDgvInfo_AgentName As DataGridViewCell
    Dim CellDgvInfo_CustomerName As DataGridViewCell
    Dim CellDgvInfo_DistributorName As DataGridViewCell
    Dim CellDgvInfo_Note As DataGridViewCell
    Dim CellDgvInfo_WareHouse As DataGridViewCell

    Private Sub IniDgvInfo()
        dgvInfo.Rows.Add({"رقم الفاتورة", ""})
        dgvInfo.Rows.Add({"رقم المصدر", ""})
        dgvInfo.Rows.Add({"الفاتورة الاصلية", ""})
        dgvInfo.Rows.Add({"التاريخ", ""})
        dgvInfo.Rows.Add({"العميل", ""})
        dgvInfo.Rows.Add({"الاسم", ""})
        dgvInfo.Rows.Add({"المسوق", ""})
        dgvInfo.Rows.Add({"المخزن", ""})
        dgvInfo.Rows.Add({"ملاحظة", ""})

        CellDgvInfo_InvoiceNumber = dgvInfo.Rows(0).Cells(1)
        CellDgvInfo_InvoiceRealNumber = dgvInfo.Rows(1).Cells(1)
        CellDgvInfo_OrgInvoiceNumber = dgvInfo.Rows(2).Cells(1)
        CellDgvInfo_InvDate = dgvInfo.Rows(3).Cells(1)
        CellDgvInfo_AgentName = dgvInfo.Rows(4).Cells(1)
        CellDgvInfo_CustomerName = dgvInfo.Rows(5).Cells(1)
        CellDgvInfo_DistributorName = dgvInfo.Rows(6).Cells(1)
        CellDgvInfo_WareHouse = dgvInfo.Rows(7).Cells(1)
        CellDgvInfo_Note = dgvInfo.Rows(8).Cells(1)



        dgvInfo.Columns(0).ReadOnly = True
        'dgvInfo.Columns(1).ReadOnly = True




        dgvInfo(0, 4).Style.Font = New Font(Me.Font.FontFamily.Name, 12, FontStyle.Underline)
        dgvInfo(0, 4).Style.ForeColor = Color.Blue

        dgvInfo(0, 6).Style.Font = New Font(Me.Font.FontFamily.Name, 12, FontStyle.Underline)
        dgvInfo(0, 6).Style.ForeColor = Color.Blue

        dgvInfo(0, 7).Style.Font = New Font(Me.Font.FontFamily.Name, 12, FontStyle.Underline)
        dgvInfo(0, 7).Style.ForeColor = Color.Blue



        dgvInfo.CurrentCell = Nothing
        dgvInfo.BorderStyle = BorderStyle.None

        cboAgent.Visible = False
        cboDistributor.Visible = False
        numInvoiceNumber.Visible = False
        numInvoiceRealNumber.Visible = False
        numOrgInvoiceNumer.Visible = False
        dtpInvoiceDate.Visible = False
        txtCustomerName.Visible = False
        txtNote.Visible = False




        dgvInfo.Controls.Add(cboAgent)
        dgvInfo.Controls.Add(cboDistributor)
        dgvInfo.Controls.Add(numInvoiceNumber)
        dgvInfo.Controls.Add(numInvoiceRealNumber)
        dgvInfo.Controls.Add(numOrgInvoiceNumer)
        dgvInfo.Controls.Add(dtpInvoiceDate)
        dgvInfo.Controls.Add(txtCustomerName)
        dgvInfo.Controls.Add(txtNote)





    End Sub
    Private Sub dgvInfo_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellEnter
        Try
            If dgvInfo.Columns(e.ColumnIndex).Name = "Disc" Then

                Select Case dgvInfo(0, e.RowIndex).Value

                    Case "رقم المصدر"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        numInvoiceRealNumber.Multiline = True
                        numInvoiceRealNumber.BorderStyle = BorderStyle.Fixed3D
                        numInvoiceRealNumber.Size = rect.Size
                        numInvoiceRealNumber.Location = rect.Location
                        numInvoiceRealNumber.Visible = True
                        numInvoiceRealNumber.Focus()


                    Case "التاريخ"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        dtpInvoiceDate.Size = rect.Size
                        dtpInvoiceDate.Format = DateTimePickerFormat.Custom
                        dtpInvoiceDate.CustomFormat = "yyyy-MM-dd  HH:mm"
                        dtpInvoiceDate.Location = rect.Location
                        dtpInvoiceDate.Visible = True
                        dtpInvoiceDate.Focus()



                    Case "العميل"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        cboAgent.Multiline = False
                        cboAgent.BorderStyle = BorderStyle.Fixed3D
                        cboAgent.Size = rect.Size
                        cboAgent.Location = rect.Location
                        cboAgent.Visible = True
                        cboAgent.Focus()




                    Case "الاسم"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        txtCustomerName.Multiline = True
                        txtCustomerName.BorderStyle = BorderStyle.Fixed3D
                        txtCustomerName.Size = rect.Size
                        txtCustomerName.Location = rect.Location
                        txtCustomerName.Visible = True
                        txtCustomerName.Focus()



                    Case "المسوق"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        cboDistributor.Multiline = False
                        cboDistributor.BorderStyle = BorderStyle.Fixed3D
                        cboDistributor.Size = rect.Size
                        cboDistributor.Location = rect.Location
                        cboDistributor.Visible = True
                        cboDistributor.Focus()



                    Case "المخزن"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)





                    Case "ملاحظة"

                        Dim rect As Rectangle = dgvInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                        txtNote.Multiline = True
                        txtNote.BorderStyle = BorderStyle.Fixed3D
                        txtNote.Size = rect.Size
                        txtNote.Location = rect.Location
                        txtNote.Visible = True
                        txtNote.Focus()



                End Select




            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try



    End Sub
    Private Sub dgvInfo_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellLeave
        Try
            If dgvInfo.Columns(e.ColumnIndex).Name = "Disc" Then

                Select Case dgvInfo(0, e.RowIndex).Value

                    Case "رقم المصدر"
                        numInvoiceRealNumber.Visible = False
                    Case "التاريخ"
                        dtpInvoiceDate.Visible = False
                    Case "العميل"
                        cboAgent.Visible = False
                    Case "الاسم"
                        txtCustomerName.Visible = False
                    Case "المسوق"
                        cboDistributor.Visible = False
                    Case "المخزن"

                    Case "ملاحظة"
                        txtNote.Visible = False
                End Select













            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub dgvInfo_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellMouseEnter
        Try
            If e.ColumnIndex = 0 AndAlso (e.RowIndex = 4 Or e.RowIndex = 6 Or e.RowIndex = 7) Then
                dgvInfo.Cursor = Cursors.Hand
            Else
                dgvInfo.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub dgvInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvInfo.KeyDown

    End Sub








    Public Sub MyKeyHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.Keys)


        Dim Cell As DataGridViewCell = dgvInfo.CurrentCell


        If CellDgvInfo_InvDate Is Cell Then

        ElseIf CellDgvInfo_AgentName Is Cell Then


            cboAgent.MyGridTextBox_KeyDown(Me, New System.Windows.Forms.KeyEventArgs(e))






        ElseIf CellDgvInfo_CustomerName Is Cell Then

        ElseIf CellDgvInfo_DistributorName Is Cell Then

        ElseIf CellDgvInfo_InvoiceRealNumber Is Cell Then

        ElseIf CellDgvInfo_Note Is Cell Then

        ElseIf CellDgvInfo_WareHouse Is Cell Then


        End If






        'dgvInfo_KeyDown(Me, New System.Windows.Forms.KeyEventArgs(e))


    End Sub


    'Private Sub cboDistributor_MySelectedValueChanged(sender, e) Handles cboDistributor.MySelectedValueChanged
    '    Try
    '        DistributorID = cboDistributor.MySelectedValue
    '    Catch ex As Exception
    '        HandleMyError(ex, , , Settings.IsDebug)
    '    End Try
    'End Sub
    'Private Sub cboAgent_MySelectedValueChanged(sender, e) Handles cboAgent.MySelectedValueChanged
    '    Try
    '        AgentID = cboAgent.MySelectedValue
    '    Catch ex As Exception
    '        HandleMyError(ex, , , Settings.IsDebug)
    '    End Try
    'End Sub
    Private Sub numInvoiceNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numInvoiceNumber.TextChanged
        Try
            InvoiceNumber = numInvoiceNumber.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub numInvoiceRealNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numInvoiceRealNumber.TextChanged
        Try
            InvoiceRealNumber = numInvoiceRealNumber.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub numOrgInvoiceNumer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numOrgInvoiceNumer.TextChanged
        Try
            OrgInvoiceNumber = numOrgInvoiceNumer.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub dtpInvoiceDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpInvoiceDate.ValueChanged
        Try
            InvDate = dtpInvoiceDate.Value

            If Not IsNothing(_DtInvoice.Rows) AndAlso _DtInvoice.Rows.Count > 0 Then

                For Each dr As DataRow In _DtInvoice.Rows
                    If dr.RowState = DataRowState.Unchanged Then
                        dr.SetModified()
                    End If
                Next


            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub txtCustomerName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged
        Try
            CustomerName = txtCustomerName.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Try
            Note = txtNote.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



    Private Sub cboAgent_MyItemSelectedByEnter(ByVal ID As Object) Handles cboAgent.MyItemSelectedByEnter
        Try
            Me.AgentID = ID


            If IsNumeric(ID) AndAlso ID > 1 Then
                Me.CustomerName = ""

            End If

            If IsNumeric(Me.AgentID) AndAlso Me.AgentID > 1 Then
                CellDgvInfo_CustomerName.OwningRow.Visible = False


                cboPayment.Enabled = True

                If cboAgent.Focused Then
                    cboPayment.SelectedIndex = 1
                End If



            Else
                CellDgvInfo_CustomerName.OwningRow.Visible = True

                cboPayment.Enabled = False
                cboPayment.SelectedIndex = 0

            End If




        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub cboDistributor_MyItemSelectedByEnter(ByVal ID As Object) Handles cboDistributor.MyItemSelectedByEnter
        Try
            Me.DistributorID = ID
            Me.DistributorName = cboDistributor.Text
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



    Private Sub Me_AgentNameChanged(ByVal v As Object) Handles Me.AgentNameChanged
        Try
            CellDgvInfo_AgentName.Value = v
            cboAgent.MySelectedValue = AgentID



            If CellDgvInfo_AgentName.OwningRow.Visible = True Then
                If IsNumeric(Me.AgentID) AndAlso Me.AgentID > 1 Then
                    CellDgvInfo_CustomerName.OwningRow.Visible = False

                    cboPayment.Enabled = True
                    '  cboPayment.SelectedIndex = 1

                Else
                    CellDgvInfo_CustomerName.OwningRow.Visible = True

                    cboPayment.Enabled = False
                    'cboPayment.SelectedIndex = 0


                End If
            End If




        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_DistributorNameChanged(ByVal v As Object) Handles Me.DistributorNameChanged
        Try
            CellDgvInfo_DistributorName.Value = v.ToString
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub


    Private Sub Me_CustomerNameChanged() Handles Me.CustomerNameChanged
        Try
            dgvInfo.Rows(5).Cells(1).Value = Me.CustomerName.ToString
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_NoteChanged() Handles Me.NoteChanged
        Try
            dgvInfo.Rows(8).Cells(1).Value = Note.ToString
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_InvoiceNumberChanged() Handles Me.InvoiceNumberChanged
        Try
            dgvInfo.Rows(0).Cells(1).Value = InvoiceNumber.ToString
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_InvoiceRealNumberChanged() Handles Me.InvoiceRealNumberChanged
        Try
            dgvInfo.Rows(1).Cells(1).Value = InvoiceRealNumber.ToString
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_OrgInvoiceNumberChanged() Handles Me.OrgInvoiceNumberChanged
        Try
            dgvInfo.Rows(2).Cells(1).Value = OrgInvoiceNumber.ToString

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_InvDateChanged(ByVal v As Object) Handles Me.InvDateChanged
        Try
            CellDgvInfo_InvDate.Value = Format(IsNullNothing(v, Now), "yyyy-MM-dd  HH:mm")
            dtpInvoiceDate.Value = IsNullNothing(v, Now)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub






#End Region
#Region "       Items"
    Private Sub IniItemType()

        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))

        dt.Rows.Add(DBNull.Value, "كل الاصناف")
        dt.Rows.Add(1, "أصنافي")
        dt.Rows.Add(2, "الاصناف الموجودة")





        With cboItemType
            .DataSource = dt
            .ValueMember = "ID"
            .DisplayMember = "Name"
        End With






    End Sub
    Private Sub Get_sp_hlp_Item()

        Dim da As New SqlDataAdapter("sp_hlp_Item", PubCn)
        Dim dt As New DataTable

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@Source", cboItemType.SelectedValue)
            .AddWithValue("@InvoiceID", OrgInvoiceID)
            If Me.InvoiceTypeID = InvoiceTypes.StockBalance Then
                .AddWithValue("@ProductsOnly", True)
            Else
                .AddWithValue("@ProductsOnly", False)
            End If

        End With


        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()
        da.Fill(dt)


        _BsItem.DataSource = dt

   


        With cboItem

            .MySource = _BsItem
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "GID", True, "رم")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "ProductName", True, "الصنف")



            .MyIsColumnHeaderVisible = True
            .MyCellBorderStyle = DataGridViewCellBorderStyle.Single
            .MyBeginProcess()


        End With



    End Sub
    Private Sub cboItemType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItemType.SelectedValueChanged
        Try
            If cboItemType.SelectedValue.ToString <> "System.Data.DataRowView" Then
                If Not IsNothing(cboItemType.SelectedValue) Then
                    Get_sp_hlp_Item()
                End If
            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub ادارةالباركودToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالباركودToolStripMenuItem.Click
        Try
            If Not IsNothing(dgvInvoice.CurrentRow) AndAlso dgvInvoice.CurrentRow.Cells("IsProduct").Value = 1 Then

                Dim sid As Int64 = dgvInvoice.CurrentRow.Cells("ItemID").Value

                Dim f As New frm_ProductBarcode(sid)
                f.WindowState = FormWindowState.Normal
                f.StartPosition = FormStartPosition.CenterScreen
                f.ShowDialog()


            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub





    Private Function GetProductInfo(ByVal StockID As Int64) As String
        Dim str As String = ""

        Dim ProductName As Object
        Dim ProductCode As Object
        Dim Barcode As Object
        Dim TypeName As Object
        Dim BrandName As Object
        Dim ProductDetails As Object
        Dim Rack As Object
        Dim ExDate As Object
        Dim SubAmount As Object
        Dim AmountLeft As Object
        Dim AmountLeftPacket As Object
        Dim AvgUnitCost As Object
        Dim AvgUnitCostPacket As Object
        Dim LastUnitCost As Object
        Dim LastUnitCostPacket As Object
        Dim SellPrice As Object
        Dim SellPricePacket As Object

        fn_sp_rpt_ProductInfo(StockID, ProductName, ProductCode, Barcode, TypeName, BrandName, ProductDetails, Rack, ExDate, SubAmount, AmountLeft, AmountLeftPacket, AvgUnitCost, AvgUnitCostPacket, LastUnitCost, LastUnitCostPacket, SellPrice, SellPricePacket)



        If IsNullNothing(ProductName, "") <> "" Then
            str = str & "الصنف : " & ProductName & vbNewLine
        End If
        If IsNullNothing(ProductCode, "") <> "" AndAlso Settings.IsProductCodeShown = True Then
            str = str & "كود :" & ProductCode & vbNewLine
        End If
        If IsNullNothing(Barcode, "") <> "" AndAlso Settings.IsBarcodeShown = True Then
            str = str & "باركود : " & Barcode & vbNewLine
        End If
        If IsNullNothing(TypeName, "") <> "" Then
            str = str & "النوع : " & TypeName & vbNewLine
        End If
        If IsNullNothing(BrandName, "") <> "" Then
            str = str & "الماركة : " & BrandName & vbNewLine
        End If
        If IsNullNothing(ProductDetails, "") <> "" AndAlso Settings.IsProductDetailsShown = True Then
            str = str & "تفاصيل : " & ProductDetails & vbNewLine
        End If
        If IsNullNothing(Rack, "") <> "" AndAlso Settings.IsRackShown = True Then
            str = str & "الموقع : " & Rack & vbNewLine
        End If
        If Settings.IsExDateShown = True Then
            str = str & "الصلاحية : " & ExDate & vbNewLine
        End If


        str = str & vbNewLine

        If Settings.IsPacketSystem = True Then
            If IsNullNothing(SubAmount, 0) <> 0 Then
                str = str & "العبوة : " & Format(SubAmount, "#,##0.###") & vbNewLine
            End If
            str = str & vbNewLine
        End If




        str = str & "---بيانات القطعة---" & vbNewLine
        If IsNumeric(AmountLeft) Then
            str = str & "الكمية المتبقية : " & Format(AmountLeft, "#,##0.###") & vbNewLine
        End If
        If IsNumeric(AvgUnitCost) Then
            str = str & "متوسط التكلفة : " & Format(AvgUnitCost, "#,##0.###") & vbNewLine
        End If
        If IsNumeric(LastUnitCost) Then
            str = str & "اخر تكلفة : " & Format(LastUnitCost, "#,##0.###") & vbNewLine
        End If
        If IsNumeric(SellPrice) Then
            str = str & "سعر البيع :" & Format(SellPrice, "#,##0.###") & vbNewLine
        End If




        If Settings.IsPacketSystem = True Then

            str = str & vbNewLine
            str = str & "---بيانات الصندوق---" + vbNewLine

            If IsNumeric(AmountLeftPacket) Then
                str = str & "الكمية المتبقية  : " & Format(AmountLeftPacket, "#,##0.###") & vbNewLine
            End If
            If IsNumeric(AvgUnitCostPacket) Then
                str = str & "متوسط التكلفة : " & Format(AvgUnitCostPacket, "#,##0.###") & vbNewLine
            End If
            If IsNumeric(LastUnitCostPacket) Then
                str = str & "اخر تكلفة : " & Format(LastUnitCostPacket, "#,##0.###") & vbNewLine
            End If
            If IsNumeric(SellPricePacket) Then
                str = str & "سعر البيع :" & Format(SellPricePacket, "#,##0.###")
            End If


        End If





        Return str
    End Function
    Private Sub fn_sp_rpt_ProductInfo(ByRef StockID As Object, ByRef ProductName As Object, ByRef ProductCode As Object, ByRef Barcode As Object, ByRef TypeName As Object, ByRef BrandName As Object, ByRef ProductDetails As Object, ByRef Rack As Object, ByRef ExDate As Object, ByRef SubAmount As Object, ByRef AmountLeft As Object, ByRef AmountLeftPacket As Object, ByRef AvgUnitCost As Object, ByRef AvgUnitCostPacket As Object, ByRef LastUnitCost As Object, ByRef LastUnitCostPacket As Object, ByRef SellPrice As Object, ByRef SellPricePacket As Object)

        Dim cmd As New SqlCommand("sp_rpt_ProductInfo", PubCn)


        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Clear()
            .AddWithValue("@StockID", StockID)
            .Add("@ProductName", SqlDbType.NVarChar, 200)
            .Add("@ProductCode", SqlDbType.NVarChar, 200)
            .Add("@Barcode", SqlDbType.NVarChar, 200)
            .Add("@TypeName", SqlDbType.NVarChar, 200)
            .Add("@BrandName", SqlDbType.NVarChar, 200)
            .Add("@ProductDetails", SqlDbType.NVarChar, 200)
            .Add("@Rack", SqlDbType.NVarChar, 200)
            .Add("@ExDate", SqlDbType.DateTime, 0)
            .Add("@SubAmount", SqlDbType.Decimal, 0)
            .Add("@AmountLeft", SqlDbType.Decimal, 0)
            .Add("@AmountLeftPacket", SqlDbType.Decimal, 0)
            .Add("@AvgUnitCost", SqlDbType.Decimal, 0)
            .Add("@AvgUnitCostPacket", SqlDbType.Decimal, 0)
            .Add("@LastUnitCost", SqlDbType.Decimal, 0)
            .Add("@LastUnitCostPacket", SqlDbType.Decimal, 0)
            .Add("@SellPrice", SqlDbType.Decimal, 0)
            .Add("@SellPricePacket", SqlDbType.Decimal, 0)

        End With

        With cmd
            .Parameters("@ProductName").Direction = ParameterDirection.Output
            .Parameters("@ProductCode").Direction = ParameterDirection.Output
            .Parameters("@Barcode").Direction = ParameterDirection.Output
            .Parameters("@TypeName").Direction = ParameterDirection.Output
            .Parameters("@BrandName").Direction = ParameterDirection.Output
            .Parameters("@ProductDetails").Direction = ParameterDirection.Output
            .Parameters("@Rack").Direction = ParameterDirection.Output
            .Parameters("@ExDate").Direction = ParameterDirection.Output
            .Parameters("@SubAmount").Direction = ParameterDirection.Output
            .Parameters("@AmountLeft").Direction = ParameterDirection.Output
            .Parameters("@AmountLeftPacket").Direction = ParameterDirection.Output
            .Parameters("@AvgUnitCost").Direction = ParameterDirection.Output
            .Parameters("@AvgUnitCostPacket").Direction = ParameterDirection.Output
            .Parameters("@LastUnitCost").Direction = ParameterDirection.Output
            .Parameters("@LastUnitCostPacket").Direction = ParameterDirection.Output
            .Parameters("@SellPrice").Direction = ParameterDirection.Output
            .Parameters("@SellPricePacket").Direction = ParameterDirection.Output


            .Parameters("@ProductName").Scale = 0
            .Parameters("@ProductCode").Scale = 0
            .Parameters("@Barcode").Scale = 0
            .Parameters("@TypeName").Scale = 0
            .Parameters("@BrandName").Scale = 0
            .Parameters("@ProductDetails").Scale = 0
            .Parameters("@Rack").Scale = 0
            .Parameters("@ExDate").Scale = 0
            .Parameters("@SubAmount").Scale = 3
            .Parameters("@AmountLeft").Scale = 3
            .Parameters("@AmountLeftPacket").Scale = 3
            .Parameters("@AvgUnitCost").Scale = 3
            .Parameters("@AvgUnitCostPacket").Scale = 3
            .Parameters("@LastUnitCost").Scale = 3
            .Parameters("@LastUnitCostPacket").Scale = 3
            .Parameters("@SellPrice").Scale = 3
            .Parameters("@SellPricePacket").Scale = 3


        End With

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        cmd.ExecuteNonQuery()
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()


        With cmd
            ProductName = .Parameters("@ProductName").Value
            ProductCode = .Parameters("@ProductCode").Value
            Barcode = .Parameters("@Barcode").Value
            TypeName = .Parameters("@TypeName").Value
            BrandName = .Parameters("@BrandName").Value
            ProductDetails = .Parameters("@ProductDetails").Value
            Rack = .Parameters("@Rack").Value
            ExDate = .Parameters("@ExDate").Value
            SubAmount = .Parameters("@SubAmount").Value
            AmountLeft = .Parameters("@AmountLeft").Value
            AmountLeftPacket = .Parameters("@AmountLeftPacket").Value
            AvgUnitCost = .Parameters("@AvgUnitCost").Value
            AvgUnitCostPacket = .Parameters("@AvgUnitCostPacket").Value
            LastUnitCost = .Parameters("@LastUnitCost").Value
            LastUnitCostPacket = .Parameters("@LastUnitCostPacket").Value
            SellPrice = .Parameters("@SellPrice").Value
            SellPricePacket = .Parameters("@SellPricePacket").Value

        End With







    End Sub


    Dim tt As New ByteToolTip()
    Private Sub cboItem_DGVChangedCurrenCell(ByVal CurrentID As Object, ByVal CurrentDisplayCellRect As Rectangle) Handles cboItem.DGVChangedCurrenCell


        Dim ItemType As Integer = Mid(CurrentID, 1, 1)

        If ItemType = 2 Then tt.Hide(cboItem.dgv) : Return






        Dim ID As Int64 = Mid(CurrentID, 3)

        '   tt.Hide(cboItem.dgv)





        Dim S As String = GetProductInfo(ID)
        Dim new_size As SizeF = TextRenderer.MeasureText(S, MF.aljazeera)
        Dim TooltipSize As Size = Size.Round(new_size)
        TooltipSize.Height += 10
        TooltipSize.Width += 10

        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim x As Integer = CurrentDisplayCellRect.X
        Dim y As Integer = CurrentDisplayCellRect.Y

        Dim Cell_Y_RefToDGV As Integer = CurrentDisplayCellRect.Y

        Dim cell_Y_RefToScreen As Integer = cboItem.dgv.PointToScreen(New Point(0, 0)).Y + Cell_Y_RefToDGV


        If screenHeight < TooltipSize.Height + cell_Y_RefToScreen Then
            y = screenHeight - TooltipSize.Height
        End If


        ' tt.Show(S, cboItem.dgv, CurrentDisplayCellRect.X + CurrentDisplayCellRect.Height / 2, CurrentDisplayCellRect.Y, 10000)

        tt.Show(S, cboItem.dgv, x, y, 10000)



    End Sub






#End Region
#Region "       dgvTotal"


    Dim CellTotal As DataGridViewCell
    Dim CellDiscount As DataGridViewCell
    Dim CellFinal As DataGridViewCell
    Dim CellAmountPaid As DataGridViewCell


    Dim CellRev As DataGridViewCell
    Dim CellRevPer As DataGridViewCell



    Private Sub IniDgvTotal()
        dgvTotal.Rows.Add({"الاجمالي", ""})
        dgvTotal.Rows.Add({"خصم", ""})
        dgvTotal.Rows.Add({"الصافي", ""})
        dgvTotal.Rows.Add({"المدفوع", ""})



        dgvTotal2.Rows.Add({"+", ""})
        dgvTotal2.Rows.Add({"+%", ""})





        CellTotal = dgvTotal.Rows(0).Cells(1)
        CellDiscount = dgvTotal.Rows(1).Cells(1)
        CellFinal = dgvTotal.Rows(2).Cells(1)
        CellAmountPaid = dgvTotal.Rows(3).Cells(1)


        CellRev = dgvTotal2.Rows(0).Cells(1)
        CellRevPer = dgvTotal2.Rows(1).Cells(1)


        CellTotal.Style.Format = "#,##0.00#"
        CellDiscount.Style.Format = "%#,##0.00"
        CellFinal.Style.Format = "#,##0.00#"
        CellAmountPaid.Style.Format = "#,##0.00#"

        CellRev.Style.Format = "#,##0.00#"
        CellRevPer.Style.Format = "%#,##0.00"

        CellDiscount.Value = 0

        dgvTotal.CurrentCell = Nothing
        dgvTotal.BorderStyle = BorderStyle.None
        dgvTotal.Font = New Font(Me.Font.FontFamily.Name, 14)

        dgvTotal2.CurrentCell = Nothing
        dgvTotal2.BorderStyle = BorderStyle.None
        dgvTotal2.Font = New Font(Me.Font.FontFamily.Name, 14)


        dgvTotal.Columns(0).ReadOnly = True
        dgvTotal2.Columns(0).ReadOnly = True


        For Each R As DataGridViewRow In dgvTotal.Rows
            R.ReadOnly = True
        Next
        For Each R As DataGridViewRow In dgvTotal2.Rows
            R.ReadOnly = True
        Next

        dgvTotal.Rows(1).ReadOnly = False
        dgvTotal.Rows(2).ReadOnly = False
        dgvTotal.Rows(3).ReadOnly = False




        dgvTotal.Columns(1).DefaultCellStyle.Font = New Font("Arial", 14)
        dgvTotal2.Columns(1).DefaultCellStyle.Font = New Font("Arial", 14)


    End Sub

    Private Sub CalculateTotals()

        Dim My_TotalPrice As Decimal = 0
        Dim My_Discount As Decimal = 0
        Dim My_FinalPrice As Decimal = 0
        Dim My_TotalCost As Decimal = 0
        Dim My_Revenue As Decimal = 0
        Dim My_RevPer As Decimal = 0

        For Each r As DataGridViewRow In dgvInvoice.Rows
            My_TotalPrice += r.Cells("Total").Value
            My_TotalCost += r.Cells("TotalCost").Value
        Next

        TotalPrice = My_TotalPrice
        TotalCost = My_TotalCost
        FinalPrice = TotalPrice - (TotalPrice * Discount)


        Revenue = FinalPrice - TotalCost
        If TotalCost > 0 Then
            RevPer = Revenue / TotalCost
        Else
            RevPer = 0
        End If


    End Sub

    Private Sub Me_TotalPriceChanged(ByVal Val As Object) Handles Me.TotalPriceChanged
        Try
            If IsNumeric(Val) Then
                CellTotal.Value = Val
            Else
                CellTotal.Value = 0
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_FinalPriceChanged(ByVal v As Object) Handles Me.FinalPriceChanged
        Try
            If IsNumeric(v) Then
                CellFinal.Value = v
                lblTotal.Text = Format(Val(v), "#,##0.00#")
            Else
                CellFinal.Value = 0
                lblTotal.Text = "0.00"
            End If

            If Me.IsPaid = True Then
                AmountPaid = FinalPrice
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_DiscountChanged(ByVal Val As Object) Handles Me.DiscountChanged
        Try
            If IsNumeric(Val) Then
                CellDiscount.Value = Val
            Else
                CellDiscount.Value = 0
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_RevenueChanged(ByVal Val As Object) Handles Me.RevenueChanged
        Try
            If IsNumeric(Val) Then
                CellRev.Value = Val




            Else
                CellRev.Value = 0
                CellRevPer.Value = 0
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_RevPerChanged(ByVal Val As Object) Handles Me.RevPerChanged
        Try
            If IsNumeric(Val) Then
                CellRevPer.Value = Val
            Else
                CellRevPer.Value = 0
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub Me_IsPaidChanged(ByVal val As Object) Handles Me.IsPaidChanged
        Try

            If IsDBNull(val) Then
                IsPaid = True

                If cboPayment.SelectedIndex <> 0 Then
                    cboPayment.SelectedIndex = 0
                End If

            ElseIf IsPaid = True Then

                cboPayment.SelectedIndex = 0


            Else
                If cboPayment.SelectedIndex <> 1 Then
                    cboPayment.SelectedIndex = 1
                End If
            End If



            If Not IsDBNull(val) AndAlso val = False Then  'آجل
                CellAmountPaid.ReadOnly = False
                CellAmountPaid.Style.ForeColor = Color.Black

            Else ' نقدي
                CellAmountPaid.ReadOnly = True
                CellAmountPaid.Style.ForeColor = Color.RoyalBlue

                AmountPaid = FinalPrice

            End If




        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub Me_AmountPaidChanged(ByVal Val As Object) Handles Me.AmountPaidChanged
        Try
            If IsNumeric(Val) Then
                CellAmountPaid.Value = Val
            Else
                CellAmountPaid.Value = 0
            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub





    Private Sub dgvTotal_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTotal.CellEndEdit
        Try

            If e.ColumnIndex = 1 Then
                Select Case e.RowIndex
                    Case 1 ' Discount
                        If TotalPrice > 0 Then

                            Discount = CellDiscount.Value / 100
                            FinalPrice = TotalPrice - (TotalPrice * Discount)

                            Revenue = FinalPrice - TotalCost
                            RevPer = Revenue / TotalCost
                        End If

                    Case 2 'Final

                        If TotalPrice > 0 Then

                            FinalPrice = Val(CellFinal.Value)
                            Discount = (TotalPrice - FinalPrice) / TotalPrice
                            Revenue = FinalPrice - TotalCost
                            RevPer = Revenue / TotalCost

                        End If

                    Case 3 'Amount Paid

                        AmountPaid = CellAmountPaid.Value

                End Select
            End If

            CellDiscount.Style.Format = "%#,##0.00"
            CellAmountPaid.Style.Format = "#,##0.00#"


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub cboPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPayment.SelectedIndexChanged
        Try



            If cboPayment.Focused = True Then

                If cboPayment.SelectedIndex = 0 Then
                    IsPaid = True


                Else
                    IsPaid = False

                    CellAmountPaid.Value = 0
                    Me.AmountPaid = 0


                End If

            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

#End Region
#Region "       Invoice"


    Private Sub Ini_Invoice_Det_DataAdapter()

        _DaInvoice.SelectCommand = New SqlCommand


        With _DaInvoice.SelectCommand

            .CommandText = "sp_rpt_Invoice"
            .Connection = PubCn
            .CommandType = CommandType.StoredProcedure

            With .Parameters
                .Clear()
                .AddWithValue("@InvoiceID", InvoiceID)
                .AddWithValue("@NextOrPrevInvoiceID", 0)
                .Add("@InvoiceTypeID", SqlDbType.Int, 0)
                .Add("@IsPaid", SqlDbType.Bit, 0)
                .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
                .Add("@InvoiceRealNumber", SqlDbType.NVarChar, 200)
                .Add("@OrgInvoiceID", SqlDbType.BigInt, 0)
                .Add("@OrgInvoiceNumber", SqlDbType.BigInt, 0)
                .Add("@InvDate", SqlDbType.DateTime, 0)
                .Add("@AgentID", SqlDbType.BigInt, 0)
                .Add("@DistributorID", SqlDbType.BigInt, 0)
                .Add("@CustomerName", SqlDbType.NVarChar, 200)
                .Add("@TotalPrice", SqlDbType.Decimal, 0)
                .Add("@FinalPrice", SqlDbType.Decimal, 0)
                .Add("@Discount", SqlDbType.Decimal, 0)
                .Add("@Revenue", SqlDbType.Decimal, 0)
                .Add("@Note", SqlDbType.NVarChar, 200)
                .Add("@UserID", SqlDbType.BigInt, 0)
                .Add("@InvoiceTypeName", SqlDbType.NVarChar, 200)
                .Add("@AgentName", SqlDbType.NVarChar, 200)
                .Add("@DistributorName", SqlDbType.NVarChar, 200)
                .Add("@Username", SqlDbType.NVarChar, 50)

                .Add("@AmountPaid", SqlDbType.Decimal, 0)

            End With

            .Parameters("@InvoiceID").Direction = ParameterDirection.InputOutput
            .Parameters("@InvoiceTypeID").Direction = ParameterDirection.InputOutput
            .Parameters("@IsPaid").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvoiceRealNumber").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceID").Direction = ParameterDirection.InputOutput
            .Parameters("@OrgInvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@InvDate").Direction = ParameterDirection.Output
            .Parameters("@AgentID").Direction = ParameterDirection.Output
            .Parameters("@DistributorID").Direction = ParameterDirection.Output
            .Parameters("@CustomerName").Direction = ParameterDirection.Output
            .Parameters("@TotalPrice").Direction = ParameterDirection.Output
            .Parameters("@FinalPrice").Direction = ParameterDirection.Output
            .Parameters("@Discount").Direction = ParameterDirection.Output
            .Parameters("@Revenue").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@UserID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeName").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output

            .Parameters("@AmountPaid").Direction = ParameterDirection.Output

            .Parameters("@InvoiceID").Scale = 0
            .Parameters("@InvoiceTypeID").Scale = 0
            .Parameters("@IsPaid").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@InvoiceRealNumber").Scale = 0
            .Parameters("@OrgInvoiceID").Scale = 0
            .Parameters("@OrgInvoiceNumber").Scale = 0
            .Parameters("@InvDate").Scale = 0
            .Parameters("@AgentID").Scale = 0
            .Parameters("@DistributorID").Scale = 0
            .Parameters("@CustomerName").Scale = 0
            .Parameters("@TotalPrice").Scale = 3
            .Parameters("@FinalPrice").Scale = 3
            .Parameters("@Discount").Scale = 4
            .Parameters("@Revenue").Scale = 3
            .Parameters("@Note").Scale = 0
            .Parameters("@UserID").Scale = 0
            .Parameters("@InvoiceTypeName").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0

            .Parameters("@AmountPaid").Scale = 3
        End With



        _DaInvoice.InsertCommand = New SqlCommand
        With _DaInvoice.InsertCommand

            .Connection = PubCn
            .CommandText = "sp_tbl_Invoice_Det_Insert"
            .CommandType = CommandType.StoredProcedure

            .CommandTimeout = 0

            .Parameters.Clear()
            .Parameters.Add("@InvDetID", SqlDbType.BigInt, 0, "InvDetID")
            .Parameters("@InvDetID").Direction = ParameterDirection.Output
            .Parameters.AddWithValue("@InvoiceID", InvoiceID)
            .Parameters.Add("@IsProduct", SqlDbType.Bit, 0, "IsProduct")
            .Parameters.Add("@Sort", SqlDbType.Int, 0, "Sort")
            .Parameters.Add("@WareHouseID", SqlDbType.BigInt, 0, "WareHouseID")
            .Parameters.Add("@PlusOrMinus", SqlDbType.Int, 0, "PlusOrMinus")
            .Parameters.Add("@ItemID", SqlDbType.BigInt, 0, "ItemID")
            .Parameters.Add("@IsPacket", SqlDbType.Bit, 0, "IsPacket")
            .Parameters.Add("@Amount", SqlDbType.Decimal, 0, "Amount")
            .Parameters.Add("@UnitPrice", SqlDbType.Decimal, 0, "UnitPrice")
            .Parameters.Add("@AvgCost", SqlDbType.Decimal, 0, "AvgCost")
            .Parameters.Add("@AmountPacket", SqlDbType.Decimal, 0, "AmountPacket")
            .Parameters.Add("@UnitPricePacket", SqlDbType.Decimal, 0, "UnitPricePacket")
            .Parameters.Add("@AvgCostPacket", SqlDbType.Decimal, 0, "AvgCostPacket")
            .Parameters.Add("@Amount_inv", SqlDbType.Decimal, 0, "Amount_inv")
            .Parameters.Add("@UnitPrice_inv", SqlDbType.Decimal, 0, "UnitPrice_inv")
            .Parameters.Add("@AvgCost_inv", SqlDbType.Decimal, 0, "AvgCost_inv")
            .Parameters.Add("@Total", SqlDbType.Decimal, 0, "Total")
            .Parameters.Add("@TotalCost", SqlDbType.Decimal, 0, "TotalCost")
            .Parameters.Add("@Revenue", SqlDbType.Decimal, 0, "Revenue")

        End With

        _DaInvoice.UpdateCommand = New SqlCommand
        With _DaInvoice.UpdateCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Invoice_Det_Update"
            .CommandType = CommandType.StoredProcedure

            .CommandTimeout = 0


            .Parameters.Clear()
            .Parameters.Add("@InvDetID", SqlDbType.BigInt, 0, "InvDetID")
            .Parameters.Add("@IsProduct", SqlDbType.Bit, 0, "IsProduct")
            .Parameters.Add("@Sort", SqlDbType.Int, 0, "Sort")
            .Parameters.Add("@WareHouseID", SqlDbType.BigInt, 0, "WareHouseID")
            .Parameters.Add("@IsPacket", SqlDbType.Bit, 0, "IsPacket")
            .Parameters.Add("@PlusOrMinus", SqlDbType.Int, 0, "PlusOrMinus")
            .Parameters.Add("@Amount", SqlDbType.Decimal, 0, "Amount")
            .Parameters.Add("@UnitPrice", SqlDbType.Decimal, 0, "UnitPrice")
            .Parameters.Add("@AvgCost", SqlDbType.Decimal, 0, "AvgCost")
            .Parameters.Add("@AmountPacket", SqlDbType.Decimal, 0, "AmountPacket")
            .Parameters.Add("@UnitPricePacket", SqlDbType.Decimal, 0, "UnitPricePacket")
            .Parameters.Add("@AvgCostPacket", SqlDbType.Decimal, 0, "AvgCostPacket")
            .Parameters.Add("@Amount_inv", SqlDbType.Decimal, 0, "Amount_inv")
            .Parameters.Add("@UnitPrice_inv", SqlDbType.Decimal, 0, "UnitPrice_inv")
            .Parameters.Add("@AvgCost_inv", SqlDbType.Decimal, 0, "AvgCost_inv")
            .Parameters.Add("@Total", SqlDbType.Decimal, 0, "Total")
            .Parameters.Add("@TotalCost", SqlDbType.Decimal, 0, "TotalCost")
            .Parameters.Add("@Revenue", SqlDbType.Decimal, 0, "Revenue")

        End With

        _DaInvoice.DeleteCommand = New SqlCommand
        With _DaInvoice.DeleteCommand
            .Connection = PubCn
            .CommandText = "sp_tbl_Invoice_Det_Delete"
            .CommandType = CommandType.StoredProcedure

            .CommandTimeout = 0

            .Parameters.Clear()
            .Parameters.Add("@IsProduct", SqlDbType.Bit, 0, "IsProduct")
            .Parameters("@IsProduct").SourceVersion = DataRowVersion.Original
            .Parameters.Add("@InvDetID", SqlDbType.BigInt, 0, "InvDetID")
            .Parameters("@InvDetID").SourceVersion = DataRowVersion.Original

        End With





    End Sub
    Private Sub GetInvoice(Optional ByVal IsNextInvoiceID As Integer = 0)

        '_DtInvoice = frm_sp_rpt_Invoice.fn_sp_rpt_Invoice(InvoiceID, InvoiceTypeID, IsPaid, InvoiceNumber, InvoiceRealNumber, OrgInvoiceID, OrgInvoiceNumber, InvDate, AgentID, DistributorID, CustomerName, TotalPrice, FinalPrice, Revenue, Note, UserID, InvoiceInfo, AgentName, DistributorName, Username, FullName, WareHouseID, WareHouseName)
        _DaInvoice.SelectCommand.Parameters("@InvoiceID").Value = InvoiceID
        _DaInvoice.SelectCommand.Parameters("@InvoiceTypeID").Value = InvoiceTypeID
        _DaInvoice.SelectCommand.Parameters("@NextOrPrevInvoiceID").Value = IsNextInvoiceID
        _DaInvoice.SelectCommand.Parameters("@OrgInvoiceID").Value = OrgInvoiceID
        _DtInvoice.Clear()
        _DaInvoice.Fill(_DtInvoice)
        InvoiceID = _DaInvoice.SelectCommand.Parameters("@InvoiceID").Value
        With _DaInvoice.SelectCommand
            InvoiceTypeID = .Parameters("@InvoiceTypeID").Value
            IsPaid = .Parameters("@IsPaid").Value
            InvoiceNumber = .Parameters("@InvoiceNumber").Value
            InvoiceRealNumber = .Parameters("@InvoiceRealNumber").Value
            OrgInvoiceID = .Parameters("@OrgInvoiceID").Value
            OrgInvoiceNumber = .Parameters("@OrgInvoiceNumber").Value
            InvDate = .Parameters("@InvDate").Value
            AgentID = .Parameters("@AgentID").Value
            DistributorID = .Parameters("@DistributorID").Value
            CustomerName = .Parameters("@CustomerName").Value
            TotalPrice = .Parameters("@TotalPrice").Value
            FinalPrice = .Parameters("@FinalPrice").Value
            Discount = .Parameters("@Discount").Value
            Revenue = .Parameters("@Revenue").Value
            Note = .Parameters("@Note").Value
            UserID = .Parameters("@UserID").Value
            InvoiceTypeName = .Parameters("@InvoiceTypeName").Value
            AgentName = .Parameters("@AgentName").Value
            DistributorName = .Parameters("@DistributorName").Value
            Username = .Parameters("@Username").Value

            AmountPaid = .Parameters("@AmountPaid").Value
        End With


        If InvoiceID = 0 And Not IsNumeric(OrgInvoiceID) Then
            InvDate = Now
            AgentID = 1
            DistributorID = 1

        End If

        Dim InvoiceTitle As String = ""
        Select Case InvoiceType
            Case InvoiceTypes.InitialAmount
                InvoiceTitle = "رصيد أول المدة"
            Case InvoiceTypes.Purchase
                InvoiceTitle = "فاتورة مشتريات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.Sell
                InvoiceTitle = "فاتورة مبيعات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.Sell_R
                InvoiceTitle = "فاتورة استرجاع مبيعات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.PreSale
                InvoiceTitle = "فاتورة مبدئية " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.Purchase_R
                InvoiceTitle = "فاتورة استرجاع مشتريات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.Loss
                InvoiceTitle = "فاتورة تالف " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case InvoiceTypes.StockBalance
                InvoiceTitle = "فاتورة تصحيح جرد " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
            Case Else
                Select Case InvoiceTypeID
                    Case InvoiceTypes.InitialAmount
                        InvoiceTitle = "رصيد أول المدة"
                    Case InvoiceTypes.Purchase
                        InvoiceTitle = "فاتورة مشتريات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.Sell
                        InvoiceTitle = "فاتورة مبيعات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.Sell_R
                        InvoiceTitle = "فاتورة استرجاع مبيعات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.PreSale
                        InvoiceTitle = "فاتورة مبدئية " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.Purchase_R
                        InvoiceTitle = "فاتورة استرجاع مشتريات " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.Loss
                        InvoiceTitle = "فاتورة تالف " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case InvoiceTypes.StockBalance
                        InvoiceTitle = "فاتورة تصحيح جرد " & IIf(InvoiceID = 0, "جديدة", "رقم " & InvoiceNumber.ToString)
                    Case Else
                        InvoiceTitle = ""
                End Select
        End Select
        Me.Text = InvoiceTitle

        _BsInvoice.DataSource = _DtInvoice
        dgvInvoice.DataSource = _BsInvoice


        _DtInvoice.AcceptChanges()
        _IsInvoiceChanged = False

    End Sub

    Private Sub _BsInvoice_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles _BsInvoice.ListChanged
        Try
            _IsInvoiceChanged = True
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub


    Private Sub CheckInvoice()
        If dgvInvoice.RowCount <= 0 Then
            Throw New Exception("تأكد من ملء الفاتورة", New Exception("ByteError"))
        End If
    End Sub




    Private Sub SaveNewInvoice(ByVal Trans As SqlTransaction)


        fn_sp_tbl_Invoice_Insert(Trans, InvoiceID, InvoiceTypeID, InvoiceTypeName, IsPaid, InvoiceNumber, InvoiceRealNumber, OrgInvoiceID, OrgInvoiceNumber, InvDate, AgentID, AgentName, DistributorID, DistributorName, CustomerName, TotalPrice, FinalPrice, Revenue, Note, PubUserID, Username, AmountPaid)

        _DaInvoice.InsertCommand.Parameters("@InvoiceID").Value = InvoiceID
        _DaInvoice.InsertCommand.CommandTimeout = 0
        _DaInvoice.InsertCommand.Transaction = Trans
        _DaInvoice.Update(_DtInvoice)




    End Sub
    Private Sub SaveInvoice(ByVal Trans As SqlTransaction)

        fn_sp_tbl_Invoice_Update(Trans, InvoiceID, IsPaid, InvoiceRealNumber, InvDate, AgentID, AgentName, DistributorID, DistributorName, CustomerName, TotalPrice, FinalPrice, Revenue, Note, PubUserID, Username, AmountPaid)


        _DaInvoice.InsertCommand.Parameters("@InvoiceID").Value = InvoiceID




        _DaInvoice.InsertCommand.CommandTimeout = 0
        _DaInvoice.InsertCommand.Transaction = Trans

        _DaInvoice.UpdateCommand.CommandTimeout = 0
        _DaInvoice.UpdateCommand.Transaction = Trans

        _DaInvoice.DeleteCommand.CommandTimeout = 0
        _DaInvoice.DeleteCommand.Transaction = Trans

        _DaInvoice.Update(_DtInvoice)




    End Sub
    Private Sub DeleteInvoice(ByVal ID As Int64)
        Dim MyTrans As SqlTransaction

        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            Dim Cmd As New SqlCommand("sp_tbl_Invoice_Delete", PubCn, MyTrans)
            Cmd.CommandType = CommandType.StoredProcedure

            Cmd.CommandTimeout = 0

            With Cmd.Parameters
                .Clear()
                .AddWithValue("@InvoiceID", ID)
                .AddWithValue("@UserID", PubUserID)
            End With
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            Cmd.ExecuteNonQuery()

            sp_op_ProcessAll(MyTrans)



            MyTrans.Commit()
        Catch ex As Exception
            MyTrans.Rollback()
            Throw (ex)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try
    End Sub




    Private Sub fn_sp_tbl_Invoice_Insert(ByVal Trans As SqlTransaction, ByRef InvoiceID As Object, ByRef InvoiceTypeID As Object, ByRef InvoiceTypeName As Object, ByRef IsPaid As Object, ByRef InvoiceNumber As Object, ByRef InvoiceRealNumber As Object, ByRef OrgInvoiceID As Object, ByRef OrgInvoiceNumber As Object, ByRef InvDate As Object, ByRef AgentID As Object, ByRef AgentName As Object, ByRef DistributorID As Object, ByRef DistributorName As Object, ByRef CustomerName As Object, ByRef TotalPrice As Object, ByRef FinalPrice As Object, ByRef Revenue As Object, ByRef Note As Object, ByRef UserID As Object, ByRef Username As Object, ByRef AmountPaid As Object)

        Dim cmd As New SqlCommand("sp_tbl_Invoice_Insert", PubCn, Trans)
        cmd.CommandTimeout = 0

        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Clear()
            .Add("@InvoiceID", SqlDbType.BigInt, 0)
            .AddWithValue("@InvoiceTypeID", InvoiceTypeID)
            .Add("@InvoiceTypeName", SqlDbType.NVarChar, 200)
            .AddWithValue("@IsPaid", IsPaid)
            .AddWithValue("@InvoiceNumber", InvoiceNumber)
            .AddWithValue("@InvoiceRealNumber", InvoiceRealNumber)
            .AddWithValue("@OrgInvoiceID", OrgInvoiceID)
            .Add("@OrgInvoiceNumber", SqlDbType.BigInt, 0)
            .AddWithValue("@InvDate", InvDate)
            .AddWithValue("@AgentID", AgentID)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .AddWithValue("@DistributorID", DistributorID)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .AddWithValue("@CustomerName", CustomerName)
            .AddWithValue("@TotalPrice", TotalPrice)
            .AddWithValue("@FinalPrice", FinalPrice)
            .AddWithValue("@Revenue", Revenue)
            .AddWithValue("@Note", Note)
            .AddWithValue("@UserID", UserID)
            .Add("@Username", SqlDbType.NVarChar, 50)

            .AddWithValue("@AmountPaid", AmountPaid)

        End With

        With cmd
            .Parameters("@InvoiceID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeName").Direction = ParameterDirection.Output
            .Parameters("@OrgInvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output


            .Parameters("@InvoiceID").Scale = 0
            .Parameters("@InvoiceTypeName").Scale = 0
            .Parameters("@OrgInvoiceNumber").Scale = 0
            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0


        End With

        cmd.ExecuteNonQuery()


        With cmd
            InvoiceID = .Parameters("@InvoiceID").Value
        End With


    End Sub
    Private Sub fn_sp_tbl_Invoice_Update(ByVal Trans As SqlTransaction, ByRef InvoiceID As Object, ByRef IsPaid As Object, ByRef InvoiceRealNumber As Object, ByRef InvDate As Object, ByRef AgentID As Object, ByRef AgentName As Object, ByRef DistributorID As Object, ByRef DistributorName As Object, ByRef CustomerName As Object, ByRef TotalPrice As Object, ByRef FinalPrice As Object, ByRef Revenue As Object, ByRef Note As Object, ByRef UserID As Object, ByRef Username As Object, ByRef AmountPaid As Object)

        Dim cmd As New SqlCommand("sp_tbl_Invoice_Update", PubCn, Trans)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0


        With cmd.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .AddWithValue("@IsPaid", IsPaid)
            .AddWithValue("@InvoiceRealNumber", InvoiceRealNumber)
            .AddWithValue("@InvDate", InvDate)
            .AddWithValue("@AgentID", AgentID)
            .Add("@AgentName", SqlDbType.NVarChar, 200)
            .AddWithValue("@DistributorID", DistributorID)
            .Add("@DistributorName", SqlDbType.NVarChar, 200)
            .AddWithValue("@CustomerName", CustomerName)
            .AddWithValue("@TotalPrice", TotalPrice)
            .AddWithValue("@FinalPrice", FinalPrice)
            .AddWithValue("@Revenue", Revenue)
            .AddWithValue("@Note", Note)
            .AddWithValue("@UserID", UserID)
            .Add("@Username", SqlDbType.NVarChar, 50)

            .AddWithValue("@AmountPaid", AmountPaid)
        End With

        With cmd
            .Parameters("@AgentName").Direction = ParameterDirection.Output
            .Parameters("@DistributorName").Direction = ParameterDirection.Output
            .Parameters("@Username").Direction = ParameterDirection.Output


            .Parameters("@AgentName").Scale = 0
            .Parameters("@DistributorName").Scale = 0
            .Parameters("@Username").Scale = 0


        End With

        cmd.ExecuteNonQuery()

        With cmd
            AgentName = .Parameters("@AgentName").Value
            DistributorName = .Parameters("@DistributorName").Value
            Username = .Parameters("@Username").Value

        End With


    End Sub

    Private Sub sp_op_ProcessAll(ByVal Trans As SqlTransaction)

        Dim cmd As New SqlCommand("sp_op_ProcessAll", PubCn, Trans)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0

        cmd.ExecuteNonQuery()

    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try

            If _IsInvoiceChanged = True AndAlso msgShow("توجد بيانات غير محفوظة ,هل تريد الحفظ ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then
                btnSave.PerformClick()
            End If

            dgvInvoice.Sort(dgvInvoice.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)
            InvoiceID = 0
            GetInvoice()
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnNextInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextInvoice.Click
        Try
            If _IsInvoiceChanged = True AndAlso msgShow("توجد بيانات غير محفوظة ,هل تريد الحفظ ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then
                btnSave.PerformClick()
            End If

            dgvInvoice.Sort(dgvInvoice.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)
            GetInvoice(1)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnPreviosInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviosInvoice.Click
        Try
            If _IsInvoiceChanged = True AndAlso msgShow("توجد بيانات غير محفوظة ,هل تريد الحفظ ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then
                btnSave.PerformClick()
            End If

            dgvInvoice.Sort(dgvInvoice.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)
            GetInvoice(-1)
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try

    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        _BsInvoice.EndEdit()
        dgvInfo.EndEdit()
        dgvTotal.EndEdit()




        Dim MyTrans As SqlTransaction

        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
            CheckInvoice()
            If Me.InvoiceID <= 0 Then
                SaveNewInvoice(MyTrans)
            Else
                SaveInvoice(MyTrans)
            End If


            sp_op_ProcessAll(MyTrans)


            MyTrans.Commit()
            GetInvoice()
        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try

    End Sub
    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If InvoiceID > 0 Then

                If msgShow("هل انت منأكد من حدف الفاتورة رقم " & InvoiceNumber.ToString & " ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then



                    DeleteInvoice(InvoiceID)

                    msgShow("تم حدف الفاتورة رقم " & InvoiceNumber.ToString, Frm_msg.FormType.msgDone)


                    GetInvoice(-1)

                End If

            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Try

            If DirectCast(_InvoiceTypeID, InvoiceTypes) = InvoiceTypes.Sell AndAlso _InvoiceID > 0 Then

                Dim F As New Frm_Invoice(InvoiceTypes.Sell_R, _InvoiceID)
                FrmMain.AddForm(F)
            End If


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try
            If InvoiceID > 0 Then

                If msgShow("هل انت منأكد من حدف الفاتورة رقم " & InvoiceNumber.ToString & " ؟", Frm_msg.FormType.YesNoWarning) = Windows.Forms.DialogResult.Yes Then



                    DeleteInvoice(InvoiceID)

                    msgShow("تم حدف الفاتورة رقم " & InvoiceNumber.ToString, Frm_msg.FormType.msgDone)


                    GetInvoice(-1)

                End If

            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnCreateSellInvoce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSellInvoce.Click
        Try

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

#End Region
#Region "       Item Invoice"

    Private Sub cboItem_MyItemSelectedByEnter(ByVal ItemID As Object) Handles cboItem.MyItemSelectedByEnter
        Try




            Dim IDstr As String = Mid(ItemID, 3)
            Dim ID As Int64 = IDstr

            Dim StockName As Object
            Dim Barcode As Object
            Dim ProductDetails As Object
            Dim ProductCode As Object



            Dim Amount As Decimal
            Dim UnitCost As Decimal
            Dim AmountPacket As Object
            Dim UnitCostPacket As Object
            Dim Total As Decimal
            Dim IsPacket As Boolean

            Dim SubAmount As Object


            If (InvoiceType = InvoiceTypes.Purchase Or InvoiceType = InvoiceTypes.InitialAmount) _
                And Mid(ItemID, 1, 1) = "1" Then

                Dim F As New frm_ProductStock(ID, , True)

                F.ShowDialog()
                ID = F._StockID
                Amount = F._Amount
                UnitCost = F._UnitCost
                AmountPacket = F._AmountPacket
                UnitCostPacket = F._UnitCostPacket

                Total = F._Total
                StockName = F._StockName
                Barcode = F._Barcode
                ProductDetails = F._ProductDetails
                ProductCode = F._ProductCode
                IsPacket = F._IsPacket
                SubAmount = F._SubAmount


                If ID = 0 Then
                    Exit Sub
                End If




                Dt_Invoice_Add_Item("1." & ID.ToString, True, ID, SubAmount, StockName, ProductDetails, Barcode, Amount, UnitCost, 1, UnitCost, Total, IsPacket, AmountPacket, UnitCostPacket, UnitCostPacket)





            ElseIf InvoiceType = InvoiceTypes.Sell Or InvoiceType = InvoiceTypes.PreSale Or InvoiceType = InvoiceTypes.Loss Then


                Dim dt As DataTable
                If Mid(ItemID, 1, 1) = "1" Then
                    dt = GetItemFromDB(ID, True, DBNull.Value, DBNull.Value)
                Else
                    dt = GetItemFromDB(ID, False, DBNull.Value, DBNull.Value)
                End If

                AnalyzeEntry(dt)

            ElseIf InvoiceType = InvoiceTypes.Sell_R Then


                Dim dt As DataTable
                If Mid(ItemID, 1, 1) = "1" Then
                    dt = GetItemFromDB(ID, True, DBNull.Value, OrgInvoiceID)
                Else
                    dt = GetItemFromDB(ID, False, DBNull.Value, OrgInvoiceID)
                End If

                AnalyzeEntry(dt)


            ElseIf InvoiceType = InvoiceTypes.StockBalance Then

                Dim dt As DataTable
                If Mid(ItemID, 1, 1) = "1" Then
                    dt = GetItemFromDB(ID, True, DBNull.Value, DBNull.Value)
                    AnalyzeEntry(dt)
                End If




            End If




            If Not IsNothing(dgvInvoice.CurrentRow) Then
                dgvInvoice.Focus()
                dgvInvoice.CurrentCell = dgvInvoice.CurrentRow.Cells("Amount_inv")
            End If






        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub BL_BarcodeReceived(ByVal str As String) Handles BL.BarcodeReceived
        Try

            'Dim IDstr As String = Mid(ItemID, 3)
            Dim ID As Int64

            Dim StockName As Object
            Dim Barcode As Object
            Dim ProductDetails As Object
            Dim ProductCode As Object



            Dim Amount As Decimal
            Dim UnitCost As Decimal
            Dim AmountPacket As Object
            Dim UnitCostPacket As Object
            Dim Total As Decimal
            Dim IsPacket As Boolean

            Dim SubAmount As Object





            If (InvoiceType = InvoiceTypes.Purchase Or InvoiceType = InvoiceTypes.InitialAmount) Then

                Dim F As New frm_ProductStock(, str, True)

                F.ShowDialog()
                ID = F._StockID
                Amount = F._Amount
                UnitCost = F._UnitCost
                AmountPacket = F._AmountPacket
                UnitCostPacket = F._UnitCostPacket

                Total = F._Total
                StockName = F._StockName
                Barcode = F._Barcode
                ProductDetails = F._ProductDetails
                ProductCode = F._ProductCode
                IsPacket = F._IsPacket
                SubAmount = F._SubAmount


                If ID = 0 Then
                    Exit Sub
                End If



                Dt_Invoice_Add_Item("1." & ID.ToString, True, ID, SubAmount, StockName, ProductDetails, Barcode, Amount, UnitCost, 1, UnitCost, Total, IsPacket, AmountPacket, UnitCostPacket, UnitCostPacket)




            Else

                Dim dt As DataTable

                dt = GetItemFromDB(DBNull.Value, True, str, DBNull.Value)
                If dt.Rows.Count = 0 Then
                    Throw New Exception("صنف غير موجود", New Exception("ByteError"))
                End If

                AnalyzeEntry(dt, , , , True)

            End If

            If Not IsNothing(dgvInvoice.CurrentRow) Then
                dgvInvoice.Focus()
                dgvInvoice.CurrentCell = dgvInvoice.CurrentRow.Cells("Amount_inv")
            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Try



            Dim ID As Int64 = 0

            Dim StockName As Object
            Dim Barcode As Object
            Dim ProductDetails As Object
            Dim ProductCode As Object



            Dim Amount As Decimal
            Dim UnitCost As Decimal
            Dim AmountPacket As Object
            Dim UnitCostPacket As Object
            Dim Total As Decimal
            Dim IsPacket As Boolean

            Dim SubAmount As Object


            If (InvoiceType = InvoiceTypes.Purchase Or InvoiceType = InvoiceTypes.InitialAmount) Then

                Dim F As New frm_ProductStock(0, , True)

                F.ShowDialog()
                ID = F._StockID
                Amount = F._Amount
                UnitCost = F._UnitCost
                AmountPacket = F._AmountPacket
                UnitCostPacket = F._UnitCostPacket

                Total = F._Total
                StockName = F._StockName
                Barcode = F._Barcode
                ProductDetails = F._ProductDetails
                ProductCode = F._ProductCode
                IsPacket = F._IsPacket
                SubAmount = F._SubAmount


                If ID = 0 Then
                    Exit Sub
                End If




                Dt_Invoice_Add_Item("1." & ID.ToString, True, ID, SubAmount, StockName, ProductDetails, Barcode, Amount, UnitCost, 1, UnitCost, Total, IsPacket, AmountPacket, UnitCostPacket, UnitCostPacket)






            End If











        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Function GetItemFromDB(ByVal ItemID As Object, ByVal IsProduct As Boolean, ByVal Barcode As Object, ByVal Org_InvoiceID As Object) As DataTable
        Dim da As New SqlDataAdapter("sp_v_GetItems", PubCn)
        Dim dt As New DataTable

        With da.SelectCommand
            .CommandType = CommandType.StoredProcedure
            .Parameters.Clear()
            .Parameters.AddWithValue("@ItemID", ItemID)
            .Parameters.AddWithValue("@IsProduct", IsProduct)
            .Parameters.AddWithValue("@Barcode", Barcode)
            .Parameters.AddWithValue("@Org_InvoiceID", Org_InvoiceID)
        End With



        da.Fill(dt)



        Return dt
    End Function


    Private Sub AnalyzeEntry(ByRef dt As DataTable, Optional ByVal MyAmount As Decimal = 1, Optional ByVal MyUnitCost As Decimal = 1, Optional ByVal MyTotal As Decimal = 1, Optional ByVal IsFromBarcodeReader As Boolean = False)






        Dim Sort As Object
        Dim GID As Object
        Dim IsProduct As Object
        Dim PlusOrMinus As Object
        Dim StockID As Object
        Dim StockName As Object
        Dim ProductDetails As Object
        Dim Barcode As Object

        Dim SubAmount As Object

        Dim Amount As Object
        Dim UnitPrice As Object
        Dim AvgCost As Object

        Dim AmountPacket As Object
        Dim UnitPricePacket As Object
        Dim AvgCostPacket As Object



        Dim IsPacket As Object


        Dim AmountLeft As Object
        Dim AlertAmount As Object



        Select Case InvoiceTypeID

            Case InvoiceTypes.Sell, InvoiceTypes.Sell_R, InvoiceTypes.PreSale, InvoiceTypes.Loss

                Dim DR As DataRow
                If dt.Rows.Count = 1 Then
                    DR = dt.Rows(0)
                Else

                    Dim f As New frm_Choise(dt)
                    f.SetCol("Exdate", "الصلاحية", "yyyy-MM-dd")
                    f.SetCol("UnitPrice", "السعر", "#0.00")
                    f.SetCol("AmountLeft", "الكمية المتبقية", "#,##0.###")
                    f.dgv.Font = New Font(Me.Font.Name, 14)
                    f.dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                    f.ShowDialog()

                    DR = f._DR

                End If


                Select Case InvoiceTypeID
                    Case InvoiceTypes.Sell, InvoiceTypes.Loss
                        PlusOrMinus = -1
                    Case InvoiceTypes.Sell_R
                        PlusOrMinus = 1
                    Case InvoiceTypes.PreSale
                        PlusOrMinus = 0
                End Select





                GID = DR.Item("GID")
                IsProduct = DR.Item("IsProduct")
                StockID = DR.Item("ItemID")
                SubAmount = DR.Item("SubAmount")

                StockName = DR.Item("ItemName")
                ProductDetails = DR.Item("ProductDetails")
                Barcode = DR.Item("Barcode")

                UnitPrice = DR.Item("UnitPrice")
                AvgCost = DR.Item("AvgCost")

                UnitPricePacket = DR.Item("UnitPricePacket")
                AvgCostPacket = DR.Item("AvgCostPacket")


                IsPacket = DR.Item("IsPacket")

                If IsDBNull(IsPacket) Then
                    If IsDBNull(SubAmount) OrElse SubAmount <= 1 Then
                        IsPacket = False
                    Else
                        IsPacket = Settings.IsPacketDefault
                        If IsFromBarcodeReader = True Then IsPacket = False
                    End If
                End If

                If IsPacket = True Then
                    AmountPacket = 1
                    Amount = SubAmount
                Else
                    Amount = 1

                    If Not IsDBNull(SubAmount) AndAlso SubAmount > 1 Then
                        AmountPacket = Amount / SubAmount
                    Else
                        AmountPacket = DBNull.Value
                    End If

                End If

                AmountLeft = DR.Item("AmountLeft")
                AlertAmount = DR.Item("AlertAmount")



                Dt_Invoice_Add_Item(GID, IsProduct, StockID, SubAmount, StockName, ProductDetails, Barcode, Amount, AvgCost, PlusOrMinus, UnitPrice, 0, IsPacket, AmountPacket, UnitPricePacket, AvgCostPacket, AmountLeft, AlertAmount)


            Case InvoiceTypes.Purchase, InvoiceTypes.InitialAmount


            Case InvoiceTypes.StockBalance

                Dim DR As DataRow
                If dt.Rows.Count = 1 Then
                    DR = dt.Rows(0)
                Else

                    Dim f As New frm_Choise(dt)
                    f.SetCol("Exdate", "الصلاحية", "yyyy-MM-dd")
                    f.SetCol("UnitPrice", "السعر", "#0.00")
                    f.SetCol("AmountLeft", "الكمية المتبقية", "#,##0.###")
                    f.dgv.Font = New Font(Me.Font.Name, 14)
                    f.dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                    f.ShowDialog()

                    DR = f._DR

                End If





                PlusOrMinus = 1




                GID = DR.Item("GID")
                IsProduct = DR.Item("IsProduct")
                StockID = DR.Item("ItemID")
                SubAmount = DR.Item("SubAmount")

                StockName = DR.Item("ItemName")
                ProductDetails = DR.Item("ProductDetails")
                Barcode = DR.Item("Barcode")

                UnitPrice = DR.Item("AvgCost")
                AvgCost = DR.Item("AvgCost")

                UnitPricePacket = DR.Item("AvgCostPacket")
                AvgCostPacket = DR.Item("AvgCostPacket")


                IsPacket = DR.Item("IsPacket")

                If IsDBNull(IsPacket) Then
                    If IsDBNull(SubAmount) OrElse SubAmount <= 1 Then
                        IsPacket = False
                    Else
                        IsPacket = Settings.IsPacketDefault
                        If IsFromBarcodeReader = True Then IsPacket = False
                    End If
                End If

                If IsPacket = True Then
                    AmountPacket = 1
                    Amount = SubAmount
                Else
                    Amount = 1

                    If Not IsDBNull(SubAmount) AndAlso SubAmount > 1 Then
                        AmountPacket = Amount / SubAmount
                    Else
                        AmountPacket = DBNull.Value
                    End If

                End If




                Dt_Invoice_Add_Item(GID, IsProduct, StockID, SubAmount, StockName, ProductDetails, Barcode, Amount, AvgCost, PlusOrMinus, UnitPrice, 0, IsPacket, AmountPacket, UnitPricePacket, AvgCostPacket)



        End Select




    End Sub



    Private Sub NumberofItems(ByRef Box As Decimal, ByRef Unit As Decimal, ByRef Total As Decimal)

        Box = 0
        Unit = 0
        Total = 0

        For Each R As DataGridViewRow In dgvInvoice.Rows

            If Not IsDBNull(R.Cells("IsPacket").Value) Then

                If R.Cells("IsPacket").Value = True Then
                    Box += R.Cells("Amount_inv").Value
                Else
                    Unit += R.Cells("Amount_inv").Value
                End If

            End If
           
        Next

        Total += Box + Unit
    End Sub
    Private Function NumberofItemsSTR() As String

        Dim box As Decimal
        Dim unit As Decimal
        Dim total As Decimal

        NumberofItems(box, unit, total)

        Dim str As String = ""

        str = "اجمالي عدد الاصناف = " & Format(total, "#,##0.###")

        Return str

    End Function





    Private Sub Dt_Invoice_Add_Item(ByVal GID As Object _
    , ByVal IsProduct As Object, ByVal StockID As Object _
    , ByVal SubAmount As Object, _
    ByVal StockName As Object, ByVal ProductDetails As Object _
    , ByVal Barcode As Object, ByVal Amount As Object, ByVal AvgCost As Object _
    , ByVal PlusOrMinus As Object, ByVal UnitPrice As Object, Optional ByVal Total As Object = 0 _
    , Optional ByVal IsPacket As Boolean = False _
    , Optional ByVal AmountPacket As Object = Nothing, Optional ByVal UnitPricePacket As Object = Nothing, Optional ByVal AvgCostPacket As Object = Nothing _
    , Optional ByVal AmountLeft As Object = Nothing, Optional ByVal AlertAmount As Object = Nothing)


        AmountPacket = IIf(IsNothing(AmountPacket), DBNull.Value, AmountPacket)
        UnitPricePacket = IIf(IsNothing(UnitPricePacket), DBNull.Value, UnitPricePacket)
        AvgCostPacket = IIf(IsNothing(AvgCostPacket), DBNull.Value, AvgCostPacket)





        Dim DR As DataRow


        Dim m As Object = _BsInvoice.Find("GID", GID)

        If _BsInvoice.Find("GID", GID) >= 0 And Settings.IsDuplicateProductInInvoice = False Then

            _BsInvoice.Position = _BsInvoice.Find("GID", GID)
            DR = DirectCast(_BsInvoice.Current, DataRowView).Row

            If InvoiceType <> InvoiceTypes.Purchase AndAlso InvoiceType <> InvoiceTypes.InitialAmount AndAlso InvoiceType <> InvoiceTypes.StockBalance Then
                DR("Amount_inv") = DR("Amount_inv") + 1
            End If

        Else
            DR = _DtInvoice.NewRow
            DR("Sort") = _BsInvoice.Count + 1
            DR("GID") = GID
            DR("IsProduct") = IsProduct
            DR("PlusOrMinus") = PlusOrMinus
            DR("ItemID") = StockID
            DR("SubAmount") = SubAmount

            DR("ItemName") = StockName
            DR("ItemDetails") = ProductDetails
            DR("Barcode") = Barcode
            DR("Amount") = Amount
            DR("UnitPrice") = UnitPrice
            DR("AvgCost") = AvgCost

            DR("AmountPacket") = AmountPacket
            DR("UnitPricePacket") = UnitPricePacket
            DR("AvgCostPacket") = AvgCostPacket

            DR("Total") = Total
            DR("IsPacket") = IsPacket

            If IsPacket = False Then
                DR("Amount_inv") = Amount
                DR("UnitPrice_inv") = UnitPrice
                DR("AvgCost_inv") = AvgCost
            Else
                DR("Amount_inv") = AmountPacket
                DR("UnitPrice_inv") = UnitPricePacket
                DR("AvgCost_inv") = AvgCostPacket
            End If


            DR("AmountLeft") = IIf(IsNothing(AmountLeft), DBNull.Value, AmountLeft)
            DR("AlertAmount") = IIf(IsNothing(AlertAmount), DBNull.Value, AlertAmount)


            _DtInvoice.Rows.Add(DR)

            _BsInvoice.MoveLast()
        End If








        If InvoiceType <> InvoiceTypes.Purchase AndAlso InvoiceType <> InvoiceTypes.InitialAmount Then
            dgvInvoice_CellEndEdit(Me, New DataGridViewCellEventArgs(dgvInvoice.Columns("Amount_inv").Index, dgvInvoice.CurrentRow.Index))
        Else
            dgvInvoice_CellEndEdit(Me, New DataGridViewCellEventArgs(dgvInvoice.Columns("Total").Index, dgvInvoice.CurrentRow.Index))
        End If




    End Sub






    Private Sub dgvInvoice_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInvoice.CellClick
        Try

            If dgvInvoice.Columns(e.ColumnIndex).Name = "IsPacket" Then
                If dgvInvoice(e.ColumnIndex, e.RowIndex).Value = True Then
                    dgvInvoice(e.ColumnIndex, e.RowIndex).Value = False
                Else
                    dgvInvoice(e.ColumnIndex, e.RowIndex).Value = True
                End If
                dgvInvoice.EndEdit()
                dgvInvoice_CellEndEdit(Me, e)
            End If

            If dgvInvoice.Columns(e.ColumnIndex).Name = "ItemName" Then

            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub dgvInvoice_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInvoice.CellEndEdit
        Try

            Dim R As DataGridViewRow = dgvInvoice.Rows(e.RowIndex)
            Dim ColumnName As String = dgvInvoice.Columns(e.ColumnIndex).Name

            If R.Cells("Amount_inv").Value = 0 Then R.Cells("Amount_inv").Value = 1

            Dim PlusOrMinus As DataGridViewCell = R.Cells("PlusOrMinus")

            Dim SubAmount As DataGridViewCell = R.Cells("SubAmount")
            Dim IsPacket As DataGridViewCell = R.Cells("IsPacket")

            Dim Amount As DataGridViewCell = R.Cells("Amount")
            Dim UnitPrice As DataGridViewCell = R.Cells("UnitPrice")
            Dim AvgCost As DataGridViewCell = R.Cells("AvgCost")
            Dim AmountPacket As DataGridViewCell = R.Cells("AmountPacket")
            Dim UnitPricePacket As DataGridViewCell = R.Cells("UnitPricePacket")
            Dim AvgCostPacket As DataGridViewCell = R.Cells("AvgCostPacket")

            Dim Amount_inv As DataGridViewCell = R.Cells("Amount_inv")
            Dim UnitPrice_inv As DataGridViewCell = R.Cells("UnitPrice_inv")
            Dim AvgCost_inv As DataGridViewCell = R.Cells("AvgCost_inv")

            Dim Total As DataGridViewCell = R.Cells("Total")
            Dim TotalCost As DataGridViewCell = R.Cells("TotalCost")
            Dim Revenue As DataGridViewCell = R.Cells("Revenue")





            If ColumnName = "Amount_inv" Then
                If Me.InvoiceType = InvoiceTypes.StockBalance Then
                    If Amount_inv.Value >= 0 Then
                        PlusOrMinus.Value = 1
                    Else
                        PlusOrMinus.Value = -1
                    End If
                End If
                Amount_inv.Value = Math.Abs(Amount_inv.Value)
            End If




            Select Case ColumnName
                Case "IsPacket"

                    If Val(SubAmount.Value.ToString) > 1 Then
                        If IsPacket.Value = True Then
                            AmountPacket.Value = Amount_inv.Value
                            Amount.Value = AmountPacket.Value * Val(SubAmount.Value.ToString)
                            UnitPrice_inv.Value = UnitPricePacket.Value
                            AvgCost_inv.Value = AvgCostPacket.Value
                            Total.Value = Amount_inv.Value * UnitPrice_inv.Value
                        Else
                            Amount.Value = Amount_inv.Value
                            AmountPacket.Value = Amount.Value / Val(SubAmount.Value.ToString)
                            UnitPrice_inv.Value = UnitPrice.Value
                            AvgCost_inv.Value = AvgCost.Value
                            Total.Value = Amount_inv.Value * UnitPrice_inv.Value

                        End If
                    Else

                        IsPacket.Value = False


                    End If

                Case Else

                    If Not IsDBNull(IsPacket.Value) AndAlso IsPacket.Value = True Then

                        Select Case ColumnName

                            Case "Amount_inv"

                                AmountPacket.Value = Amount_inv.Value
                                Amount.Value = Amount_inv.Value * Val(SubAmount.Value.ToString)
                                Total.Value = Amount_inv.Value * UnitPrice_inv.Value

                            Case "UnitPrice_inv"

                                UnitPricePacket.Value = UnitPrice_inv.Value
                                UnitPrice.Value = UnitPricePacket.Value / Val(SubAmount.Value.ToString)
                                Total.Value = Amount_inv.Value * UnitPrice_inv.Value

                            Case "Total"

                                UnitPricePacket.Value = Total.Value / Amount_inv.Value
                                UnitPrice.Value = Total.Value / Amount_inv.Value / Val(SubAmount.Value.ToString)
                                UnitPrice_inv.Value = UnitPricePacket.Value

                        End Select

                    Else

                        Select Case ColumnName

                            Case "Amount_inv"
                                Amount.Value = Amount_inv.Value
                                Total.Value = Amount_inv.Value * UnitPrice_inv.Value
                                If Val(SubAmount.Value.ToString) > 1 Then AmountPacket.Value = Amount.Value / Val(SubAmount.Value.ToString)


                            Case "UnitPrice_inv"

                                UnitPrice.Value = UnitPrice_inv.Value
                                Total.Value = Amount_inv.Value * UnitPrice_inv.Value
                                If Val(SubAmount.Value.ToString) > 1 Then UnitPricePacket.Value = UnitPrice.Value * Val(SubAmount.Value.ToString)

                            Case "Total"

                                UnitPrice.Value = Total.Value / Amount_inv.Value
                                UnitPrice_inv.Value = UnitPrice.Value
                                If Val(Val(SubAmount.Value.ToString).ToString) > 1 Then UnitPricePacket.Value = Total.Value / Amount_inv.Value * Val(SubAmount.Value.ToString)

                        End Select

                    End If


            End Select

            TotalCost.Value = Amount_inv.Value * AvgCost_inv.Value
            Revenue.Value = Total.Value - TotalCost.Value
            CalculateTotals()


        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Function DecimalCeiling(ByVal MyNumber As Decimal) As Decimal





        Dim i As Integer = Math.Truncate(MyNumber)
        Dim d As Decimal
        If i < 1 Then
            d = MyNumber
        Else
            d = MyNumber Mod i
        End If




        If d = 0 Then
            d = 0
        ElseIf d > 0 And d <= 0.25 Then
            d = 0.25
        ElseIf d > 0.25 And d <= 0.5 Then
            d = 0.5
        ElseIf d > 0.5 And d <= 0.75 Then
            d = 0.75
        ElseIf d > 0.75 Then
            d = 1
        End If



        MyNumber = i + d



        Return MyNumber
    End Function


    <DebuggerStepThrough()>
    Private Sub dgvInvoice_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvInvoice.CellFormatting
        Try

            If Me.InvoiceType = InvoiceTypes.StockBalance Then
                If dgvInvoice.Rows(e.RowIndex).Cells("PlusOrMinus").Value = 1 Then
                    dgvInvoice.Rows(e.RowIndex).Cells("Amount_Inv").Style.BackColor = Color.PaleGreen
                Else
                    dgvInvoice.Rows(e.RowIndex).Cells("Amount_Inv").Style.BackColor = Color.PaleVioletRed
                End If
            End If


            Dim CellAmountLeft As DataGridViewCell = dgvInvoice.Rows(e.RowIndex).Cells("AmountLeft")
            Dim CellAlertAmount As DataGridViewCell = dgvInvoice.Rows(e.RowIndex).Cells("AlertAmount")

            Dim CellGID As DataGridViewCell = dgvInvoice.Rows(e.RowIndex).Cells("GID")

            If IsNumeric(CellAmountLeft.Value) Then




                If CellAmountLeft.Value < 0 Then
                    CellGID.Style.BackColor = Color.PaleVioletRed
                ElseIf CellAmountLeft.Value = 0 Then
                    CellGID.Style.BackColor = Color.Gold
                ElseIf IsNumeric(CellAlertAmount.Value) AndAlso CellAlertAmount.Value > CellAmountLeft.Value Then
                    CellGID.Style.BackColor = Color.Gold
                Else
                    CellGID.Style.BackColor = Color.White
                End If





            Else
                CellGID.Style.BackColor = Color.White
            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub dgvInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvInvoice.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If Not IsNothing(dgvInvoice.CurrentRow) AndAlso dgvInvoice.CurrentCell.OwningColumn.Name = "Amount_inv" Then

                    cboItem.Focus()


                End If

            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub dgvInvoice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvInvoice.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                If Not IsNothing(_BsInvoice.Current) Then
                    _BsInvoice.RemoveCurrent()

                    dgvInvoice.Sort(dgvInvoice.Columns("Sort"), System.ComponentModel.ListSortDirection.Ascending)
                    Dim ctr As Integer = 1
                    For Each R As DataGridViewRow In dgvInvoice.Rows
                        R.Cells("Sort").Value = ctr
                        ctr += 1
                    Next



                    CalculateTotals()
                End If


            End If
        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub


    Private Sub StockBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBalanceToolStripMenuItem.Click
        Try
            Dim f As New frm_sp_rpt_StockCorrect
            f.ShowDialog()

            Dim dt As DataTable = f._dt

            For Each R As DataRow In dt.Rows


                Dim GID As Object = "1." & R.Item("StockID")
                Dim IsProduct As Object = True
                Dim StockID As Object = R.Item("StockID")
                Dim SubAmount As Object = R.Item("SubAmount")
                Dim StockName As Object = R.Item("ProductName")
                Dim ProductDetails As Object
                Dim Barcode As Object

                'Dim PlusOrMinus As Object = IIf(R.Item("AmountLeftDiff") > 0, 1, -1)
                Dim PlusOrMinus As Object = 1
                Dim IsPacket As Object = R.Item("IsPacket")

                Dim Amount As Object = R.Item("AmountLeftDiff")
                Dim AvgCost As Object = R.Item("AvgUnitCost")

                Dim UnitPrice As Object = R.Item("AvgUnitCost")


                Dim AmountPacket As Object = (R.Item("AmountLeftPacketDiff"))
                Dim UnitPricePacket As Object = R.Item("AvgUnitCostPacket")
                Dim AvgCostPacket As Object = R.Item("AvgUnitCostPacket")


                Dim Total As Object



                Dt_Invoice_Add_Item(GID, True, StockID, SubAmount, StockName, ProductDetails, Barcode, Amount, AvgCost, PlusOrMinus, UnitPrice, , IsPacket, AmountPacket, UnitPricePacket, AvgCostPacket)





            Next


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

#End Region
#Region "       Apearance and Layout"

    Private Sub DgvInvoiceGeneralApearance()




        For Each C As DataGridViewColumn In dgvInvoice.Columns
            C.Visible = False
        Next

        With dgvInvoice
            .Columns("Sort").Visible = True
            .Columns("GID").Visible = True
            .Columns("ItemName").Visible = True
            .Columns("IsPacket").Visible = True
            .Columns("Amount_inv").Visible = True
            .Columns("UnitPrice_inv").Visible = True
            .Columns("Total").Visible = True
            .Columns("Revenue").Visible = True

            .Columns("Sort").HeaderText = "ر.ت"
            .Columns("GID").HeaderText = "ر.م"
            .Columns("ItemName").HeaderText = "البند"
            .Columns("IsPacket").HeaderText = "صندوق"
            .Columns("Amount_inv").HeaderText = "الكمية"
            .Columns("UnitPrice_inv").HeaderText = "السعر"
            .Columns("Total").HeaderText = "الاجمالي"
            .Columns("Revenue").HeaderText = "+"

            .Columns("Sort").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("GID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("IsPacket").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Amount_inv").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("UnitPrice_inv").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Revenue").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            .Columns("Amount_inv").DefaultCellStyle.Format = "#,##0.##"
            .Columns("UnitPrice_inv").DefaultCellStyle.Format = "#,##0.00"
            .Columns("Total").DefaultCellStyle.Format = "#,##0.00"
            .Columns("Revenue").DefaultCellStyle.Format = "#,##0.00"


            .Columns("Sort").ReadOnly = True
            .Columns("GID").ReadOnly = True
            .Columns("ItemName").ReadOnly = True
            .Columns("Revenue").ReadOnly = True





        End With


        FontMyControl(dgvInvoice, 14)
        'dgvInvoice.Columns("Amount_inv").DefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Regular)
        'dgvInvoice.Columns("UnitPrice_inv").DefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Regular)
        'dgvInvoice.Columns("Total").DefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Regular)
        'dgvInvoice.Columns("Revenue").DefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Regular)

    End Sub
    Private Sub dgvTotalApearanceColor()

        dgvTotal.Rows(0).Cells(0).Style.ForeColor = Color.RoyalBlue
        dgvTotal.Rows(1).Cells(0).Style.ForeColor = Color.RoyalBlue
        dgvTotal.Rows(2).Cells(0).Style.ForeColor = Color.RoyalBlue
        dgvTotal.Rows(3).Cells(0).Style.ForeColor = Color.RoyalBlue

        dgvTotal2.Rows(0).Cells(0).Style.ForeColor = Color.RoyalBlue
        dgvTotal2.Rows(1).Cells(0).Style.ForeColor = Color.RoyalBlue


        CellTotal.Style.ForeColor = Color.RoyalBlue
        CellRev.Style.ForeColor = Color.RoyalBlue
        CellRevPer.Style.ForeColor = Color.RoyalBlue






    End Sub
    Sub FormConditionalApearance()

        DgvInvoiceGeneralApearance()
        dgvTotalApearanceColor()


        btnAddItem.Visible = False
        StockBalanceToolStripMenuItem.Visible = False



        Select Case DirectCast(Me.InvoiceTypeID, InvoiceTypes)
            Case InvoiceTypes.InitialAmount


                btnAddItem.Visible = True
                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = False
                btnPay.Visible = False
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                CellDiscount.OwningRow.Visible = False
                CellFinal.OwningRow.Visible = False
                CellRev.OwningRow.Visible = False
                CellRevPer.OwningRow.Visible = False
                CellAmountPaid.OwningRow.Visible = False



                cboPayment.Visible = False
                dgvInvoice.Columns("Revenue").Visible = False

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = False
                CellDgvInfo_CustomerName.OwningRow.Visible = False
                CellDgvInfo_DistributorName.OwningRow.Visible = False






            Case InvoiceTypes.Loss

                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = False
                btnPay.Visible = False
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                CellDiscount.OwningRow.Visible = False
                CellFinal.OwningRow.Visible = False
                CellRev.OwningRow.Visible = False
                CellRevPer.OwningRow.Visible = False
                CellAmountPaid.OwningRow.Visible = False


                cboPayment.Visible = False
                dgvInvoice.Columns("Revenue").Visible = False


                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = False
                CellDgvInfo_CustomerName.OwningRow.Visible = False
                CellDgvInfo_DistributorName.OwningRow.Visible = False

            Case InvoiceTypes.PreSale

                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = False
                btnPay.Visible = False
                btnCreateSellInvoce.Visible = True
                btnDelete.Visible = True

                cboPayment.Visible = False
                dgvInvoice.Columns("Revenue").Visible = True

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = True
                CellDgvInfo_CustomerName.OwningRow.Visible = True
                CellDgvInfo_DistributorName.OwningRow.Visible = True

            Case InvoiceTypes.Purchase
                btnAddItem.Visible = True
                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = True
                btnPay.Visible = True
                btnCreateSellInvoce.Visible = True
                btnDelete.Visible = True

                CellRev.OwningRow.Visible = False
                CellRevPer.OwningRow.Visible = False

                cboPayment.Visible = True
                dgvInvoice.Columns("Revenue").Visible = False

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = True
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = True
                CellDgvInfo_CustomerName.OwningRow.Visible = True
                CellDgvInfo_DistributorName.OwningRow.Visible = True

            Case InvoiceTypes.Purchase_R

                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = False
                btnPay.Visible = True
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                CellDiscount.Style.ForeColor = Color.RoyalBlue
                CellDiscount.ReadOnly = True

                cboPayment.Visible = True
                dgvInvoice.Columns("Revenue").Visible = False

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = True
                CellDgvInfo_AgentName.OwningRow.Visible = True
                CellDgvInfo_CustomerName.OwningRow.Visible = True
                CellDgvInfo_DistributorName.OwningRow.Visible = True

            Case InvoiceTypes.Sell

                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = True
                btnPay.Visible = True
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                cboPayment.Visible = True
                dgvInvoice.Columns("Revenue").Visible = True

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = True
                CellDgvInfo_CustomerName.OwningRow.Visible = True
                CellDgvInfo_DistributorName.OwningRow.Visible = True


              


            Case InvoiceTypes.Sell_R

                btnView.Visible = True
                btnPrint.Visible = True
                btnReturn.Visible = False
                btnPay.Visible = True
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                CellDiscount.Style.ForeColor = Color.RoyalBlue
                CellDiscount.ReadOnly = True

                cboPayment.Visible = True
                dgvInvoice.Columns("Revenue").Visible = True

                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = True
                CellDgvInfo_AgentName.OwningRow.Visible = True
                CellDgvInfo_CustomerName.OwningRow.Visible = True
                CellDgvInfo_DistributorName.OwningRow.Visible = True

            Case InvoiceTypes.StockBalance

                btnView.Visible = False
                btnPrint.Visible = False
                btnReturn.Visible = False
                btnPay.Visible = False
                btnCreateSellInvoce.Visible = False
                btnDelete.Visible = True

                CellTotal.OwningRow.Visible = False
                CellDiscount.OwningRow.Visible = False
                CellFinal.OwningRow.Visible = False
                CellRev.OwningRow.Visible = False
                CellRevPer.OwningRow.Visible = False
                CellAmountPaid.OwningRow.Visible = False

                cboPayment.Visible = False



                CellDgvInfo_InvoiceRealNumber.OwningRow.Visible = False
                CellDgvInfo_OrgInvoiceNumber.OwningRow.Visible = False
                CellDgvInfo_AgentName.OwningRow.Visible = False
                CellDgvInfo_CustomerName.OwningRow.Visible = False
                CellDgvInfo_DistributorName.OwningRow.Visible = False
             
                dgvInvoice.Columns("Revenue").Visible = False
                dgvInvoice.Columns("Total").Visible = False
                dgvInvoice.Columns("UnitPrice_inv").Visible = False
                'dgvInvoice.Columns("PlusOrMinus").Visible = True

                lblTotal.Visible = False
                ToolStripLabel1.Visible = False

                StockBalanceToolStripMenuItem.Visible = True

        End Select


        CellDgvInfo_DistributorName.OwningRow.Visible = False
        CellDgvInfo_WareHouse.OwningRow.Visible = False



        If PubUserLevel > 1 Then
            dgvInvoice.Columns("Revenue").Visible = False
            CellRev.OwningRow.Visible = False
            CellRevPer.OwningRow.Visible = False
        End If



    End Sub

#End Region
#Region "       KeyPad"

    Private Sub Pb11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb11.Click
        SendKeys.Send("1")
    End Sub
    Private Sub Pb21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb21.Click
        SendKeys.Send("2")
    End Sub
    Private Sub Pb31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb31.Click
        SendKeys.Send("3")
    End Sub
    Private Sub Pb41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb41.Click
        SendKeys.Send("4")
    End Sub
    Private Sub Pb51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb51.Click
        SendKeys.Send("5")
    End Sub
    Private Sub Pb61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb61.Click
        SendKeys.Send("6")
    End Sub
    Private Sub Pb71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb71.Click
        SendKeys.Send("7")
    End Sub
    Private Sub Pb81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb81.Click
        SendKeys.Send("8")
    End Sub
    Private Sub Pb91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb91.Click
        SendKeys.Send("9")
    End Sub
    Private Sub Pb01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb01.Click
        SendKeys.Send("0")
    End Sub
    Private Sub Pbdot1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbdot1.Click
        SendKeys.Send(".")
    End Sub
    Private Sub Pbc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbc1.Click
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub Pbenterbig1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbenterbig1.Click
        SendKeys.Send("{ENTER}")
    End Sub

#End Region
#Region "       Options"


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try

            If IsNumeric(_InvoiceID) AndAlso _InvoiceID > 0 Then

                Dim f As New frm_sp_rpt_Invoice
                f.MdiParent = Me.MdiParent
                f.numInvoiceID.Text = _InvoiceID
                f.btnView.PerformClick()



            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            If IsNumeric(_InvoiceID) AndAlso _InvoiceID > 0 Then

                Dim f As New frm_sp_rpt_Invoice
                f.MdiParent = Me.MdiParent
                f.numInvoiceID.Text = _InvoiceID
                f.btnPrint.PerformClick()



            End If

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub



#End Region






    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    BL_BarcodeReceived("#104")
    'End Sub








    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Try

        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub





    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

        Try

            Dim str As String = NumberofItemsSTR()
            tt.Show(str, ToolStrip1, 10000)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub





    
End Class

