Imports ByteClassLibrary.MyFunctions
Imports System.Data.SqlClient
Public Class frm_Settings


    Private Sub frm_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Picturebox1.Visible = False
            GetSettings()

            Me.MaximumSize = Me.Size

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Picturebox1.Visible = True
            btnSave.Text = "الرجاء الانتظار قليلا"
            bw.RunWorkerAsync()

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub



    Private Sub GetSettings()
        txtHeaderSTR.Text = Settings.HeaderSTR
        txtFooterSTR.Text = Settings.FooterSTR

        chkIsPacketSystem.Checked = Settings.IsPacketSystem
        chkIsPacketDefault.Checked = Settings.IsPacketDefault

        chkIsProductCodeShown.Checked = Settings.IsProductCodeShown
        chkIsProductDetailsShown.Checked = Settings.IsProductDetailsShown
        chkIsBarcodeShown.Checked = Settings.IsBarcodeShown
        chkIsRackShown.Checked = Settings.IsRackShown
        chkIsExDateShown.Checked = Settings.IsExDateShown
    End Sub


    Private Sub UpdateAllProductsSearchName()


        Dim sqlcmd As New SqlCommand("sp_op_UpdateAllProductsSearchName")
        sqlcmd.Connection = PubCn

        sqlcmd.CommandType = CommandType.StoredProcedure
        If PubCn.State <> ConnectionState.Open Then PubCn.Open()

        sqlcmd.ExecuteNonQuery()


        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Sub




    Private Sub bw_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork


        Settings.HeaderSTR = txtHeaderSTR.Text
        Settings.FooterSTR = txtFooterSTR.Text

        Settings.IsPacketSystem = chkIsPacketSystem.Checked.ToString.ToLower
        Settings.IsPacketDefault = chkIsPacketDefault.Checked.ToString.ToLower

        If chkIsProductCodeShown.Checked <> Settings.IsProductCodeShown _
       Or chkIsProductDetailsShown.Checked <> Settings.IsProductDetailsShown _
       Or chkIsBarcodeShown.Checked <> Settings.IsBarcodeShown _
       Or chkIsRackShown.Checked <> Settings.IsRackShown _
       Or chkIsExDateShown.Checked <> Settings.IsExDateShown Then



            Settings.IsProductCodeShown = chkIsProductCodeShown.Checked
            Settings.IsProductDetailsShown = chkIsProductDetailsShown.Checked
            Settings.IsBarcodeShown = chkIsBarcodeShown.Checked
            Settings.IsRackShown = chkIsRackShown.Checked
            Settings.IsExDateShown = chkIsExDateShown.Checked

            UpdateAllProductsSearchName()

        End If





    End Sub


    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        Try
            Picturebox1.Visible = False
            btnSave.Text = "حفظ"
            ByteClassLibrary.MyFunctions.msgShow("تم حفظ الاعدادت", ByteClassLibrary.Frm_msg.FormType.msgDone)
        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub
End Class