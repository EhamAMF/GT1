Imports ByteClassLibrary.MyFunctions
Public Class frm_Activation

    Private Sub Picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox1.Click

    End Sub


    Private Sub frm_Activation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Picturebox1.Visible = False

        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub


    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Try




            Picturebox1.Visible = True
            btnActivate.Text = "الرجاء الانتظار قليلا"
            bk1.RunWorkerAsync()





        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
        End Try
    End Sub


    Dim OutXML As String = ""
    Private Sub bk1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bk1.DoWork

        Dim PhoneNumber As String = txtPhoneNumber.Text
        Dim Pwd As String = txtLicense.Text


        Dim ws As New GT1.WebServiceMyActivation.MyActivationSoapClient
        Dim o As Object = ws.Activate(PhoneNumber, AllHardwareInfoMin, IsSqlLocal, PubAppID, Pwd)

        OutXML = o



    End Sub

    Private Sub bk1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bk1.RunWorkerCompleted



        Dim xmlElem = XElement.Parse(OutXML)
        Dim msg = xmlElem.<msg>.Value
        Dim key = xmlElem.<ActivationKey>.Value
        Dim IsSuccess = xmlElem.<IsSuccess>.Value


        Picturebox1.Visible = False
        btnActivate.Text = "تفعيل"

        If IsSuccess = "True" Then
            Dim c As New MyActivattion
            c.AddHWKey(key)
        End If


        msgShow(msg)
    End Sub
End Class