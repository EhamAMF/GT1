Imports System.Data.SqlClient
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions

Public Class frm_QuickProducts


    Dim _dtButtons As New DataTable
    Dim _bsButtons As New BindingSource
    Dim _FormOwner As Form

    Public Sub New(ByRef frm As Form)

        ' This call is required by the designer.


        InitializeComponent()
        _FormOwner = frm

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frm_QuickProducts_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try

            FontMyControl(Me)


            sp_hlp_Buttons()
            SetButtons()
            addBtnHandler()






        Catch ex As Exception
            HandleMyError(ex)
        End Try







    End Sub

    Private Sub sp_hlp_Buttons()
        Dim da As New SqlDataAdapter("sp_hlp_Buttons", PubCn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure


        _dtButtons.Clear()
        da.Fill(_dtButtons)




        _dtButtons.PrimaryKey = {_dtButtons.Columns("BtnID")}


    End Sub
    Private Sub SetButtons()

        For Each r As DataRow In _dtButtons.Rows
            Dim btnID As Integer = r.Item("BtnID")
            Dim myProductName As String = r.Item("ProductName")

            Dim c As Button = FlowLayoutPanel1.Controls("ByteBtnB" & btnID)

            If IsNothing(c) Then
                c = FlowLayoutPanel2.Controls("ByteBtnB" & btnID)
            End If

            If IsNothing(c) Then
                c = FlowLayoutPanel3.Controls("ByteBtnB" & btnID)
            End If

            If IsNothing(c) Then
                c = FlowLayoutPanel4.Controls("ByteBtnB" & btnID)
            End If


            c.Text = myProductName

        Next





    End Sub
    Private Sub addBtnHandler()

        For Each c As Control In FlowLayoutPanel1.Controls



            If c.GetType Is GetType(ByteMyPictureBox.ByteBtnB) Then
                Dim b As ByteMyPictureBox.ByteBtnB = c

                AddHandler b.Click, AddressOf Me.btnProduct_Click
                AddHandler b.MouseDown, AddressOf Me.btnProduct_MouseDown
                AddHandler b.MouseUp, AddressOf Me.btnProduct_MouseUp



            End If
        Next


        For Each c As Control In FlowLayoutPanel2.Controls
            If c.GetType Is GetType(ByteMyPictureBox.ByteBtnB) Then
                Dim b As ByteMyPictureBox.ByteBtnB = c

                AddHandler b.Click, AddressOf Me.btnProduct_Click
                AddHandler b.MouseDown, AddressOf Me.btnProduct_MouseDown
                AddHandler b.MouseUp, AddressOf Me.btnProduct_MouseUp



            End If
        Next



        For Each c As Control In FlowLayoutPanel3.Controls
            If c.GetType Is GetType(ByteMyPictureBox.ByteBtnB) Then
                Dim b As ByteMyPictureBox.ByteBtnB = c

                AddHandler b.Click, AddressOf Me.btnProduct_Click
                AddHandler b.MouseDown, AddressOf Me.btnProduct_MouseDown
                AddHandler b.MouseUp, AddressOf Me.btnProduct_MouseUp



            End If
        Next

        For Each c As Control In FlowLayoutPanel4.Controls
            If c.GetType Is GetType(ByteMyPictureBox.ByteBtnB) Then
                Dim b As ByteMyPictureBox.ByteBtnB = c

                AddHandler b.Click, AddressOf Me.btnProduct_Click
                AddHandler b.MouseDown, AddressOf Me.btnProduct_MouseDown
                AddHandler b.MouseUp, AddressOf Me.btnProduct_MouseUp



            End If
        Next

    End Sub







    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim btn As ByteMyPictureBox.ByteBtnB = sender


            If IsNothing(_dtButtons.Rows.Find(btn.TabIndex)) = False Then

                Dim StockID As Int64 = _dtButtons.Rows.Find(btn.TabIndex).Item("StockID")

                ' Dim RowNumber As Int64 = DirectCast(_FormOwner, frmInvoice_Touch).fn_GetRowNumber(StockID)

                DirectCast(_FormOwner, Frm_Invoice).cboItem_MyItemSelectedByEnter("1." & StockID.ToString)

 

                Me.Close()
                Me.Dispose()

            End If






        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub

    Dim _btnLongClicked As ByteMyPictureBox.ByteBtnB
    Private Sub btnProduct_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        _btnLongClicked = DirectCast(sender, ByteMyPictureBox.ByteBtnB)
        Timer1.Enabled = True


    End Sub
    Private Sub btnProduct_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _btnLongClicked = Nothing
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs, Optional ByVal BtnNumber As Integer = 0) Handles Timer1.Tick

        Timer1.Enabled = False
        Dim frm As New frm_SelectStock(_btnLongClicked, _dtButtons)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()


    End Sub





    Private Sub ByteBtnA151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByteBtnB151.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            HandleMyError(ex)
        End Try


    End Sub



End Class