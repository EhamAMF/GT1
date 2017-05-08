Imports System.Windows.Forms
Imports ByteClassLibrary
Imports ByteClassLibrary.MyFunctions

Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.IO

Module ModuleMain

    Public PubUserID As Int64
    Public PubUserName As String
    Public PubUserFullName As String
    Public PubUserLevel As Integer
    Public PubDtSettings As New DataTable
    Public PubServerIP As String = MyFunctions.GetFileContents(My.Application.Info.DirectoryPath & "\per\ServerIP.dll")
    Public PubCn As New SqlClient.SqlConnection
    Public PubMasterCn As New SqlClient.SqlConnection("")
    Public MF As New ByteClassLibrary.MyFonts

    Public tblUsers As New MyClasses.MySqlTable("Users", PubCn, "UserID", "Password")


    Public Sub FontMyControl(ByVal C As Object, Optional ByVal FSize As Object = Nothing, Optional ByVal FontChildren As Boolean = True)


        Dim fs As Integer = IIf(IsNothing(FSize), C.font.size, FSize)


        C.Font = New Font(MF.F.Families(0), fs)

        If TypeOf (C) Is Label Then
            If DirectCast(C, Label).Cursor = Cursors.Hand Then
                C.font = New Font(MF.F.Families(0), fs, FontStyle.Underline)
                DirectCast(C, Label).ForeColor = Color.Blue
            End If
        End If






        Dim s As String = C.GetType.ToString    'C.GetType.BaseType.Name
        If s = "System.Windows.Forms.ToolStrip" Then
            For Each i As ToolStripItem In DirectCast(C, ToolStrip).Items
                FontMyControl(i, FSize, False)
            Next
        Else


            If FontChildren = True Then
                If C.HasChildren = True Then
                    For Each cc As Control In C.Controls
                        FontMyControl(cc, FSize)
                    Next
                End If
            End If



        End If









        'Dim l As Windows.Forms.Label = DirectCast(C, Windows.Forms.Label)
        'If l.Cursor = Cursors.Hand Then
        '    l.Font = New Font(l.Font.FontFamily, l.Font.Size, FontStyle.Underline)
        'End If


    End Sub


    Public Function GetFileContents(ByVal FullPath As String) As String

        Dim strContents As String
        Dim objReader As StreamReader

        objReader = New StreamReader(FullPath)
        strContents = objReader.ReadToEnd()
        objReader.Close()

        Return strContents
    End Function


End Module
