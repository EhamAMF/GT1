Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Reflection
Imports System.Reflection.Emit
Imports ByteClassLibrary.MyFunctions

Public Class frm_SelectStock

    Dim daItemes As New SqlDataAdapter("sp_hlp_item", PubCn)
    Dim dtItems As New DataTable
    Dim WithEvents bsItems As New BindingSource

    Dim _btn As ByteMyPictureBox.ByteBtnB
    Dim _dtButtons As DataTable



    Public Sub New(ByRef btn As ByteMyPictureBox.ByteBtnB, ByRef dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        _btn = btn
        _dtButtons = dt
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_SelectStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cboProductsToGet.SelectedIndex = 1
            GetItems()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    Private Sub sp_hlp_Buttons()
        Dim da As New SqlDataAdapter("sp_hlp_Buttons", PubCn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure


        _dtButtons.Clear()
        da.Fill(_dtButtons)




        _dtButtons.PrimaryKey = {_dtButtons.Columns("BtnID")}


    End Sub
    Private Sub GetItems()



        dtItems.Clear()
        With daItemes.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@Source", cboProductsToGet.SelectedValue)
            .AddWithValue("@ProductsOnly", True)


        End With


        daItemes.SelectCommand.CommandType = CommandType.StoredProcedure
        daItemes.Fill(dtItems)


        bsItems.DataSource = dtItems




        With cboItem

            .MySource = bsItems
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.ValueMember, "GID", True, "رم")
            .SetColumn(ByteClassLibrary.MyGridTextBox3.ColType.DisplayMember, "ProductName", True, "الصنف")



            .MyIsColumnHeaderVisible = True
            .MyCellBorderStyle = DataGridViewCellBorderStyle.Single
            .MyBeginProcess()


        End With





    End Sub
    Private Sub cboProductsToGet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProductsToGet.SelectedIndexChanged
        Try
            If IsNothing(cboProductsToGet.SelectedIndex) = False Then

                With daItemes.SelectCommand.Parameters

                    .Clear()
                    .AddWithValue("@Source", cboProductsToGet.SelectedIndex)
                    .AddWithValue("@ProductsOnly", True)
                End With



                dtItems.Clear()
                daItemes.Fill(dtItems)



                cboItem.IsDgvLocationHeightSet = False


            End If
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub cboItem_MyItemSelectedByEnter(ByVal ID As Object) Handles cboItem.MyItemSelectedByEnter
        Try

            Dim StockID As Object = bsItems.Item(bsItems.Find("GID", ID))("StockID")

            sp_tbl_button_InsertUpdateDelete(_btn.TabIndex, StockID, 1)

            _btn.Text = bsItems.Item(bsItems.Find("GID", ID))("ProductName")
            sp_hlp_Buttons()

            Me.Close()
            Me.Dispose()


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try



    End Sub

    Private Sub sp_tbl_button_InsertUpdateDelete(ByVal BtnID As Int64, ByVal StockID As Object, ByVal ColorID As Int64)
        Dim SC As New SqlCommand("sp_tbl_button_InsertUpdateDelete", PubCn)
        With SC
            .CommandType = CommandType.StoredProcedure
            .Parameters.Clear()
            .Parameters.AddWithValue("@btnID", BtnID)
            .Parameters.AddWithValue("@StockID", StockID)
            .Parameters.AddWithValue("@ColorID", ColorID)
            .Parameters.AddWithValue("@UserID", PubUserID)

        End With

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        SC.ExecuteNonQuery()
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
    End Sub

    Private Sub ByteBtnB151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByteBtnB151.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub btnEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpty.Click
        Try



            sp_tbl_button_InsertUpdateDelete(_btn.TabIndex, DBNull.Value, 1)

            _btn.Text = ""
            sp_hlp_Buttons()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class