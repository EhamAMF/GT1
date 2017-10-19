Imports System.Data.SqlClient
Imports MyClasses

Module MyDataManagement
    Public MySaveFileDialog As New SaveFileDialog
    Public MyOpenFileDialog As New OpenFileDialog


    Public Sub Backup(Optional ByVal IsSilentBackup As Boolean = False, Optional ByVal IsVersionChangedBackup As Boolean = False)
        Dim FullFileName As String = ""
        Dim FileName As String = PubCn.Database & " " & Format(Now, "yyyy-MM-dd HH.mm.ss ") & " v" & Format(PubdbVersion, "000")

        If IsSilentBackup = True Then
            FullFileName = My.Application.Info.DirectoryPath & "\per\backup\" & FileName & ".bak"
            If IsVersionChangedBackup = True Then
                FileName = PubCn.Database & " v" & Format(PubdbVersion, "000")
                FullFileName = My.Application.Info.DirectoryPath & "\per\backup\VersionChangedBackup\" & FileName & ".bak"
            End If



        Else
            With MySaveFileDialog
                .DefaultExt = ".bak"
                .Title = ("حفظ")
                .Filter = "Backup files (*.bak)|*.bak"
                .CheckPathExists = True

                .OverwritePrompt = True
                .ValidateNames = True
                .FileName = FileName
                .AddExtension = True

                .SupportMultiDottedExtensions = False
                .ShowDialog()
                FullFileName = .FileName
            End With

        End If


        If FullFileName <> "" And FullFileName <> FileName Then
            Dim CMD As New SqlCommand("BACKUP DATABASE [" & PubCn.Database & "] TO  DISK = N'" & FullFileName & "' WITH NOFORMAT, INIT,  NAME = N'" & PubCn.Database & "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", PubCn)

            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            CMD.CommandTimeout = 180
            CMD.ExecuteNonQuery()
            If IsSilentBackup = False Then
                MessageBox.Show("تم حفظ قاعدة البيانات")
            End If
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()


        End If






    End Sub
    Public Sub Restore()

        Dim FullFileName As String
        With MyOpenFileDialog

            .FileName = ""
            .DefaultExt = ".bak"
            .Title = ("ملف قاعدة البيانات")
            .Filter = "Backup files (*.bak)|*.bak"
            .CheckPathExists = True

            .ValidateNames = True
            .AddExtension = True

            .SupportMultiDottedExtensions = False
            .ShowDialog()
            FullFileName = .FileName
        End With

        If FullFileName <> "" Then
            Dim CMD As New SqlCommand("Use Master Alter Database [" & PubCn.Database & "] SET SINGLE_USER With ROLLBACK IMMEDIATE RESTORE DATABASE [" & PubCn.Database & "] FROM  DISK = N'" & FullFileName & "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10", PubMasterCn)

            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            If PubMasterCn.State <> ConnectionState.Open Then PubMasterCn.Open()
            CMD.CommandTimeout = 180
            CMD.ExecuteNonQuery()
            MessageBox.Show("تم استرجاع قاعدة البيانات ")

            CheckUpgradeDB2()


   
            If PubMasterCn.State <> ConnectionState.Closed Then PubMasterCn.Close()
        End If
    End Sub
    Public Sub NewPeriod()
        Dim CMD As New SqlCommand("sp_DeleteFromTables", PubCn)
        CMD.CommandType = CommandType.StoredProcedure

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        CMD.ExecuteNonQuery()

        MessageBox.Show("تم إنشاء سنة مالية جديدة")


        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Sub
    Public Sub Reset()
        Dim FullFileName As String = My.Application.Info.DirectoryPath & "\per\DbBkp.dll"
        Dim CMD As New SqlCommand("Use Master Alter Database [" & PubCn.Database & "] SET SINGLE_USER With ROLLBACK IMMEDIATE RESTORE DATABASE [" & PubCn.Database & "] FROM  DISK = N'" & FullFileName & "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10", PubMasterCn)

        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        If PubMasterCn.State <> ConnectionState.Open Then PubMasterCn.Open()
        CMD.ExecuteNonQuery()
        ' MessageBox.Show("تم إعادة الضبط ")
        If PubMasterCn.State <> ConnectionState.Closed Then PubMasterCn.Close()

    End Sub

    Public Sub Reset2()
        Dim SC As New SqlCommand("sp_zz_DELETE_ALL", PubCn)
        SC.CommandType = CommandType.StoredProcedure

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        SC.ExecuteNonQuery()
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Sub

    Public Sub NewYear()
        Dim SC As New SqlCommand("SP_Begin_New_Year_Full", PubCn)
        SC.CommandType = CommandType.StoredProcedure
        SC.CommandTimeout = 0
        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        SC.ExecuteNonQuery()
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Sub



    Public Function GetAdminPass() As String
        Dim str As String
        str = tblUsers.GetCell(1)
        Return str

    End Function
    Public Sub UpdateAdminPass(ByVal Password As String)
        Dim UpdtCom As New SqlCommand
        UpdtCom.Connection = PubCn
        UpdtCom.CommandText = "Update [Users] set Password = @Password Where UserID = 1"
        With UpdtCom.Parameters
            .Clear()
            .AddWithValue("@Password", Password)
        End With

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        UpdtCom.ExecuteNonQuery()
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Sub


End Module
