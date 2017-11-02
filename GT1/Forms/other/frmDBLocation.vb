Public Class frmDBLocation

    Private Sub frmDBLocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbIP.Text = My.Settings.LsServerIP


    End Sub

    Private Sub cboServerLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServerLocation.SelectedIndexChanged
        If cboServerLocation.SelectedIndex = 0 Then
            tbIP.Text = "."
        ElseIf cboServerLocation.SelectedIndex = 1 Then
            tbIP.Text = "192.168.100.1"
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        My.Settings.LsServerIP = tbIP.Text.Trim
        My.Settings.Save()
        Me.Close()
        Me.Dispose()




    End Sub
End Class