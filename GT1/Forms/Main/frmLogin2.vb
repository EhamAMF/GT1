Imports System.Management

Public Class frmLogin2

    Private Sub frmLogin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try


   





            Dim ServerIP As String = GetFileContents(My.Application.Info.DirectoryPath & "\per\ServerIP.dll")
            PubCn.ConnectionString = "Data Source=" & ServerIP & ";MultipleActiveResultSets=true;Initial Catalog=GT1;User ID=sa;Password=%C@tchM31fY0uC@N%"
            PubMasterCn.ConnectionString = "Data Source=" & ServerIP & ";Initial Catalog=Master;User ID=sa;Password=%C@tchM31fY0uC@N%"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End

        End Try



    End Sub
    Private Sub frmLogin2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        For Each value As Configuration.SettingsPropertyValue In My.Settings.PropertyValues
            MessageBox.Show(value.Name & " - " & value.PropertyValue.ToString)
        Next

        If Settings.IsDebug = True Then
            TbUserName.Text = "admin"
            TbPassword.Text = "admin"
            Dim str As String = ""

            BEnter.PerformClick()
        End If


    End Sub

    Private Sub BEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEnter.Click
        Try
            Dim IsApproved As Boolean = False

            If Trim(TbPassword.Text) = "" Or Trim(TbUserName.Text) = "" Then

            Else
                Dim Sc As New SqlClient.SqlCommand("Select * from Users where UserName = @Username and state = 1", PubCn)
                Sc.Parameters.Clear()
                Sc.Parameters.AddWithValue("@UserName", TbUserName.Text)

                Dim RD As SqlClient.SqlDataReader
                PubCn.Open()
                RD = Sc.ExecuteReader

                If RD.Read = True Then
                    If RD("Password") = TbPassword.Text Then
    
                        PubUserID = RD("UserID")
                        PubUserName = RD("UserName")
                        PubUserLevel = RD("UserLevel")
                        PubdbVersion = GetdbVersion()


                        IsApproved = True
                    End If
                End If
                RD.Close()
                PubCn.Close()
            End If

            If IsApproved = True Then

                CheckUpgradeDB()

                MDIParent1.Show()
                Me.Close()

            Else
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End Try





    End Sub
    Private Sub BExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExit.Click
        End
    End Sub
    Private Sub TbPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbPassword.KeyDown
        If e.KeyCode = Keys.Return Then
            BEnter.PerformClick()
        End If
    End Sub

End Class