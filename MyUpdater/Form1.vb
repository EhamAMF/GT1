Imports System.IO
Imports System.IO.Compression

Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("GT1")

        For Each p As Process In pProcess
            p.Kill()
        Next



        ParseCommandLineArgs()
        BackgroundWorker1.RunWorkerAsync()
        UnZip()

    End Sub
    Private Sub ParseCommandLineArgs()
        Dim inputArgument As String = "/input="
        Dim inputName As String = ""

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith(inputArgument) Then
                inputName = s.Remove(0, inputArgument.Length)
            End If
        Next

        If inputName <> "LaunshedByGT1" Then
            Application.Exit()
            End
        End If
    End Sub



    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim sSource As String = My.Application.Info.DirectoryPath & "\GT1.exe"
        Dim sTarget As String = My.Application.Info.DirectoryPath & "\per\Backup\VersionChangedBackup\GT1.exe"
        File.Copy(sSource, sTarget, True)


        UnZip()


        System.Threading.Thread.Sleep(2000)


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\GT1.exe")
        Application.Exit()

    End Sub




    Dim inputZip As String = My.Application.Info.DirectoryPath & "\Update\Update.zip"
    Dim outputFolder As String = My.Application.Info.DirectoryPath
    Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))

    Sub UnZip()



        'Create directory in which you will unzip your items.
        IO.Directory.CreateDirectory(outputFolder)

        'Declare the folder where the items will be extracted.
        Dim output As Object = shObj.NameSpace((outputFolder))

        'Declare the input zip file.
        Dim input As Object = shObj.NameSpace((inputZip))



        'Extract the items from the zip file.
        output.CopyHere((input.Items), 16)



    End Sub




End Class
