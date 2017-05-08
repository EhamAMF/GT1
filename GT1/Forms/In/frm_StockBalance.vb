Imports System.Data.SqlClient
Imports ByteClassLibrary.MyFunctions


Public Class frm_StockBalance
    Dim WithEvents _bl As New ByteClassLibrary.ByteBarcodeListener2(Me, 20)


    Dim WithEvents _BsWareHouse As New BindingSource


    Dim _dtProductMine As New DataTable
    Dim WithEvents _BsProductMine As New BindingSource

    Dim _Dt_Invoice As New DataTable

    Dim _InvoiceID As Int64
    Dim _InvDate As Object
    Dim _InvoiceTypeID As Object
    Dim _InvoiceTypeName As Object
    Dim _InvoiceNumber As Object
    Dim _Note As Object
    Dim _WareHouseID As Object
    Dim _WareHouseName As Object



#Region "       Initialize"


    Public Sub New(Optional InvoiceID As Int64 = 0)

        ' This call is required by the designer.
        InitializeComponent()


        dgv.ShowCellToolTips = False
        dgvAll.ShowCellToolTips = False

        _InvoiceID = InvoiceID


        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frm_StockBalance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Get_sp_hlp_WareHouse()
            Get_sp_hlp_Product_Mine()
            GetInvoice()
            GetProductsAmountsByWareHouse()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try

    End Sub
    Private Sub frm_StockBalance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            FontMyControl(Me)
            dgvAll.AutoResizeColumns()
            dgv.AutoResizeColumns()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
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

        Try
            If Not IsNothing(_BsWareHouse.Current) AndAlso Not IsDBNull(_BsWareHouse.Current("WareHouseID")) AndAlso Not IsNothing(_WareHouseID) Then
                _WareHouseID = _BsWareHouse.Current("WareHouseID")
                GetProductsAmountsByWareHouse()
                _Dt_Invoice.Clear()
            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try






    End Sub



#End Region
#Region "       Product"

    Private Sub Get_sp_hlp_Product_Mine()

        Dim da As New SqlDataAdapter("sp_hlp_Product", PubCn)
        da.SelectCommand.Parameters.Clear()
        da.SelectCommand.Parameters.AddWithValue("@Service", 0)



        da.SelectCommand.CommandType = CommandType.StoredProcedure

        _dtProductMine.Clear()

        _dtProductMine.PrimaryKey = Nothing
        _dtProductMine.Constraints.Clear()
        For Each c As DataColumn In _dtProductMine.Columns
            c.AllowDBNull = True
        Next


        da.Fill(_dtProductMine)

        _dtProductMine.Rows.RemoveAt(0)

        _dtProductMine.PrimaryKey = {_dtProductMine.Columns("IsProduct"), _dtProductMine.Columns("StockID")}



        _BsProductMine.DataSource = _dtProductMine




        With cboProduct
            .DataSource = _BsProductMine
            .DisplayMember = "StockFullName"
            .ValueMember = "StockID"

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


    End Sub

    Private Sub _bl_BarcodeReceived(ByVal str As String) Handles _bl.BarcodeReceived
        Try
            If _InvoiceID = 0 Then
                Dim RowIndex As Object = _BsProductMine.Find("Barcode", str)

                If RowIndex >= 0 Then
                    dgvAll.Focus()
                    dgvAll.CurrentCell = dgvAll(4, RowIndex)
                End If
            Else

            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try





    End Sub

    Private Sub GetProductsAmountsByWareHouse()
        Dim da As New SqlDataAdapter("sp_hlp_MyProductsByWareHouse", PubCn)
        Dim dt As New DataTable
        Dim bs As New BindingSource

        dt.Clear()

        da.SelectCommand.Parameters.Clear()
        da.SelectCommand.Parameters.AddWithValue("@WareHouseID", _WareHouseID)



        da.SelectCommand.CommandType = CommandType.StoredProcedure

        dt.Clear()

        dt.PrimaryKey = Nothing
        dt.Constraints.Clear()

        da.Fill(dt)



        dt.PrimaryKey = {dt.Columns("StockID")}



        bs.DataSource = dt




        With dgvAll
            .DataSource = bs

            .Columns("StockID").Visible = False

            .Columns("StockName").HeaderText = "الصنف"
            .Columns("Barcode").HeaderText = "باركود"
            .Columns("AmountLeft").HeaderText = "الكمية"
            .Columns("RealAmountLeft").HeaderText = "الكمية الفعلية"

            .Columns("AmountLeft").DefaultCellStyle.Format = "#,###.###"
            .Columns("RealAmountLeft").DefaultCellStyle.Format = "#,###.###"

            For Each C As DataGridViewColumn In dgvAll.Columns
                C.ReadOnly = True
            Next

            If _InvoiceID = 0 Then .Columns("RealAmountLeft").ReadOnly = False


        End With





    End Sub


    Private Sub dgvAll_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAll.CellEndEdit

        Try
            If dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Value > dgvAll.Rows(e.RowIndex).Cells("AmountLeft").Value Then
                dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Style.BackColor = Color.PaleGreen
            ElseIf dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Value < dgvAll.Rows(e.RowIndex).Cells("AmountLeft").Value Then
                dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Style.BackColor = Color.LightPink
            ElseIf dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Value = dgvAll.Rows(e.RowIndex).Cells("AmountLeft").Value Then
                dgvAll.Rows(e.RowIndex).Cells("RealAmountLeft").Style.BackColor = Color.White

            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try



    End Sub
    Private Sub dgvAll_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAll.Sorted

        Try
            For Each R As DataGridViewRow In dgvAll.Rows
                If R.Cells("RealAmountLeft").Value > R.Cells("AmountLeft").Value Then
                    R.Cells("RealAmountLeft").Style.BackColor = Color.PaleGreen
                ElseIf R.Cells("RealAmountLeft").Value < R.Cells("AmountLeft").Value Then
                    R.Cells("RealAmountLeft").Style.BackColor = Color.LightPink
                ElseIf R.Cells("RealAmountLeft").Value = R.Cells("AmountLeft").Value Then
                    R.Cells("RealAmountLeft").Style.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try


    End Sub
#End Region

#Region "       Invoice"

    Private Sub GetInvoice()

        _Dt_Invoice.Clear()

        _Dt_Invoice = fn_sp_rpt_StockBalance(_InvoiceID, _InvDate, _InvoiceTypeID, _InvoiceTypeName, _InvoiceNumber, _Note, _WareHouseID, _WareHouseName)

        dgv.DataSource = _Dt_Invoice

        dgv.Columns("sort").Visible = True
        dgv.Columns("StockID").Visible = False
        dgv.Columns("StockName").Visible = True
        dgv.Columns("Barcode").Visible = True
        dgv.Columns("Amount").Visible = True
        dgv.Columns("UnitPrice").Visible = False
        dgv.Columns("AvgCost").Visible = False
        dgv.Columns("Note").Visible = True


        dgv.Columns("sort").HeaderText = "ر.ت"
        dgv.Columns("StockName").HeaderText = "الصنف"
        dgv.Columns("Barcode").HeaderText = "باركود"
        dgv.Columns("Amount").HeaderText = "الكمية"
        dgv.Columns("Note").HeaderText = "ملاحظة"

        dgv.Columns("Amount").DefaultCellStyle.Format = "#,###.###"


        For Each C As DataGridViewColumn In dgv.Columns
            C.ReadOnly = True
        Next

        dgv.Columns("Amount").ReadOnly = False
        dgv.Columns("note").ReadOnly = False



        If _InvoiceID = 0 Then
            numInvoiceID.Text = "فاتورة جديدة"
            lblTitle.Text = "فاتورة تصحيح جرد جديدة"
            dtpInvoiceDate.Value = Now
            cboWareHouse.SelectedValue = 1
            _WareHouseID = 1
            cboWareHouse.Enabled = True
        Else
            numInvoiceID.Text = _InvoiceNumber
            lblTitle.Text = "فاتورة تصحيح جرد رقم " & _InvoiceNumber
            dtpInvoiceDate.Value = _InvDate
            cboWareHouse.SelectedValue = _WareHouseID
            cboWareHouse.Enabled = False
        End If


        ColorInvoiceAmounts()


    End Sub

    Private Function fn_sp_rpt_StockBalance(ByRef InvoiceID As Object, ByRef InvDate As Object, ByRef InvoiceTypeID As Object, ByRef InvoiceTypeName As Object, ByRef InvoiceNumber As Object, ByRef Note As Object, ByRef WareHouseID As Object, ByRef WareHouseName As Object) As DataTable

        Dim da As New SqlDataAdapter("sp_rpt_StockBalance", PubCn)
        Dim dt As New DataTable

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        With da.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@InvoiceID", InvoiceID)
            .Add("@InvDate", SqlDbType.DateTime, 0)
            .Add("@InvoiceTypeID", SqlDbType.BigInt, 0)
            .Add("@InvoiceTypeName", SqlDbType.NVarChar, 200)
            .Add("@InvoiceNumber", SqlDbType.BigInt, 0)
            .Add("@Note", SqlDbType.NVarChar, 200)
            .Add("@WareHouseID", SqlDbType.BigInt, 0)
            .Add("@WareHouseName", SqlDbType.NVarChar, 200)

        End With

        With da.SelectCommand
            .Parameters("@InvDate").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeID").Direction = ParameterDirection.Output
            .Parameters("@InvoiceTypeName").Direction = ParameterDirection.Output
            .Parameters("@InvoiceNumber").Direction = ParameterDirection.Output
            .Parameters("@Note").Direction = ParameterDirection.Output
            .Parameters("@WareHouseID").Direction = ParameterDirection.Output
            .Parameters("@WareHouseName").Direction = ParameterDirection.Output


            .Parameters("@InvDate").Scale = 0
            .Parameters("@InvoiceTypeID").Scale = 0
            .Parameters("@InvoiceTypeName").Scale = 0
            .Parameters("@InvoiceNumber").Scale = 0
            .Parameters("@Note").Scale = 0
            .Parameters("@WareHouseID").Scale = 0
            .Parameters("@WareHouseName").Scale = 0


        End With

        da.Fill(dt)

        With da.SelectCommand
            InvDate = .Parameters("@InvDate").Value
            InvoiceTypeID = .Parameters("@InvoiceTypeID").Value
            InvoiceTypeName = .Parameters("@InvoiceTypeName").Value
            InvoiceNumber = .Parameters("@InvoiceNumber").Value
            Note = .Parameters("@Note").Value
            WareHouseID = .Parameters("@WareHouseID").Value
            WareHouseName = .Parameters("@WareHouseName").Value

        End With

        Return dt
    End Function

    Private Sub ColorInvoiceAmounts()
        For Each R As DataGridViewRow In dgv.Rows
            If R.Cells("Amount").Value > 0 Then
                R.Cells("Amount").Style.BackColor = Color.PaleGreen
            Else
                R.Cells("Amount").Style.BackColor = Color.LightPink
            End If
        Next
    End Sub

    Private Sub dgv_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Sorted
        Try
            ColorInvoiceAmounts()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    Private Sub btnProductsForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductsForm.Click
        Try
            Dim m As New frm_sp_hlp_MyProductsByWareHouse(cboWareHouse.SelectedValue)
            m.MdiParent = MDIParent1
            m.WindowState = FormWindowState.Maximized

            m.Show()
            m.btnView.PerformClick()
            m.Close()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnViewInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewInvoice.Click
        Try
            Dim m As New frm_sp_rpt_StockBalance(_InvoiceID)
            m.MdiParent = MDIParent1
            m.WindowState = FormWindowState.Maximized

            m.Show()
            m.btnView.PerformClick()
            m.Close()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try



    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSave2.PerformClick()
    End Sub





#End Region

#Region "       Save"

    Private Sub SaveNew()
        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            Dim InvoiceID As Int64

            InvoiceID = frmInvoice.InsertIntoInvoice(MyTrans, 6, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, dtpInvoiceDate.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, PubUserID)
            For Each R As DataGridViewRow In dgv.Rows

                Dim sort As Object = R.Cells("Sort").Value
                Dim StockID As Object = R.Cells("StockID").Value
                Dim Amount As Object = Math.Abs(R.Cells("Amount").Value)
                Dim PlusOrMinus As Object = IIf(R.Cells("Amount").Value >= 0, 1, -1)
                Dim UnitPrice As Object = R.Cells("UnitPrice").Value
                Dim AvgCost As Object = R.Cells("AvgCost").Value
                Dim Note As Object = R.Cells("Note").Value


                frmInvoice.InsertIntoInvoice_prd(MyTrans, InvoiceID, sort, _WareHouseID, PlusOrMinus, StockID, Amount, UnitPrice, AvgCost, Note)


            Next




            MyTrans.Commit()
            msgShow("تم حفظ الفاتورة بنجاح", ByteClassLibrary.Frm_msg.FormType.msgDone)



            _InvoiceID = InvoiceID
            GetInvoice()
            GetProductsAmountsByWareHouse()

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , My.Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try
    End Sub
    Private Sub Save()

        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)

            frmInvoice.UpdateInvoice(MyTrans, _InvoiceID, DBNull.Value, DBNull.Value, dtpInvoiceDate.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, PubUserID)

            If Not IsNothing(_Dt_Invoice.GetChanges) Then

                frmInvoice.DeleteInvoice_prd(MyTrans, _InvoiceID)

                For Each R As DataGridViewRow In dgv.Rows

                    Dim sort As Object = R.Cells("Sort").Value
                    Dim StockID As Object = R.Cells("StockID").Value
                    Dim Amount As Object = Math.Abs(R.Cells("Amount").Value)
                    Dim PlusOrMinus As Object = IIf(R.Cells("Amount").Value >= 0, 1, -1)
                    Dim UnitPrice As Object = R.Cells("UnitPrice").Value
                    Dim AvgCost As Object = R.Cells("AvgCost").Value
                    Dim Note As Object = R.Cells("Note").Value


                    frmInvoice.InsertIntoInvoice_prd(MyTrans, _InvoiceID, sort, _WareHouseID, PlusOrMinus, StockID, Amount, UnitPrice, AvgCost, Note)


                Next

            End If








            MyTrans.Commit()
            msgShow("تم حفظ الفاتورة بنجاح", ByteClassLibrary.Frm_msg.FormType.msgDone)


            GetInvoice()
            GetProductsAmountsByWareHouse()



        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , My.Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try

    End Sub


    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        Try
            If _Dt_Invoice.Rows.Count <= 0 Then Throw New Exception("الفاتورة فارغة تأكد من المدخلات !", New Exception("ByteError"))

            If _InvoiceID = 0 Then

                SaveNew()

            Else

                Save()
            End If



        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Try
            For Each R As DataGridViewRow In dgvAll.Rows
                If R.Cells("RealAmountLeft").Value > R.Cells("AmountLeft").Value Or R.Cells("RealAmountLeft").Value < R.Cells("AmountLeft").Value Then
                    _Dt_Invoice.Clear()
                    Exit For
                End If
            Next

            Dim ct As Integer = 1
            For Each R As DataGridViewRow In dgvAll.Rows
                If R.Cells("RealAmountLeft").Value <> R.Cells("AmountLeft").Value Then
                    Dim NewRow As DataRow = _Dt_Invoice.NewRow
                    NewRow.Item("sort") = ct
                    NewRow.Item("StockID") = R.Cells("StockID").Value
                    NewRow.Item("StockName") = R.Cells("StockName").Value
                    NewRow.Item("Barcode") = R.Cells("Barcode").Value
                    NewRow.Item("Amount") = R.Cells("RealAmountLeft").Value - R.Cells("AmountLeft").Value
                    NewRow.Item("UnitPrice") = 0
                    NewRow.Item("AvgCost") = 0
                    NewRow.Item("Note") = DBNull.Value
                    _Dt_Invoice.Rows.Add(NewRow)



                End If

                ct += 1
            Next

            dgv.AutoResizeColumns()


            ColorInvoiceAmounts()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try




    End Sub
#End Region


















End Class