Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub

    Private Function GenKey(ByVal AppID As Integer, ByVal Features As Integer, ByVal IsServer As Boolean, ByVal HWstr As String) As String

        Dim HWKey As String = MySecurity.HashStringOf(HWstr)

        Dim outstr As String


        outstr = "<ActivationKey>" & vbCrLf &
        "  <AppID>" & AppID.ToString & "</AppID>" & vbCrLf &
        "  <Features>" & Features.ToString & "</Features>" & vbCrLf &
        "  <IsServer>" & IsServer.ToString & "</IsServer> " & vbCrLf &
         "  <HWKey>" & HWKey.ToString & "</HWKey> " & vbCrLf &
        "</ActivationKey>"


        outstr = MySecurity.encryptString(outstr)

        Return outstr


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim s As String = GenKey(numAppID.Text, NumFeaturea.Text, cboIsServer.SelectedItem, HardwareInfo.AllHardwareInfoMin)



        Dim c As New MyActivattion
        c.AddHWKey(s)

    End Sub
End Class
