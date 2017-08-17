Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions
Public Class frm_Backgroudjob


    Public _IsVersionChangeBackup As Boolean = False



    Private Sub frm_Backgroudjob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Select(0, 0)
        bk1.RunWorkerAsync()

    End Sub

    Private Sub bk1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bk1.DoWork
        Try
            Dim Size As Long = MyFunctions.GetFolderSize(My.Application.Info.DirectoryPath & "\per\backup", True)
            Dim AllowedSize As Long = 10000000000
            If Settings.IsDebug = True Then
                AllowedSize = 1000000000
            End If


            Do While Size > AllowedSize
                MyFunctions.DeleteTheOldestFile(My.Application.Info.DirectoryPath & "\per\backup")
                Size = MyFunctions.GetFolderSize(My.Application.Info.DirectoryPath & "\per\backup", True)
            Loop

            If IsSqlLocal() = True Then
                MyDataManagement.Backup(True, _IsVersionChangeBackup)
            End If



        Catch ex As Exception
            HandleMyError(ex, , , Settings.IsDebug)
        End Try
    End Sub

    Private Sub bk1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bk1.RunWorkerCompleted
        Try


            If _IsVersionChangeBackup = True Then
                '  System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\MyUpdater.exe /input=xy")

                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = My.Application.Info.DirectoryPath & "\MyUpdater.exe"
                pHelp.Arguments = "/input=LaunshedByGT1"
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)



            Else

                TextBox1.Text = "تم الانتهاء يمكنك اطفاء الجهاز"
                Me.Refresh()
                System.Threading.Thread.Sleep(2000)


            End If

            Application.Exit()
            End


        Catch ex As Exception
            HandleMyError(ex)
        End Try
    End Sub
End Class