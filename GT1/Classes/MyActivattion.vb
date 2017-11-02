Imports System.IO
Imports ByteClassLibrary.MyFunctions



Public Class MyActivattion







    Public Sub New()

    End Sub




    Public Sub AddHWKey(ByVal Key As String)

        If Not File.Exists(My.Application.Info.DirectoryPath & "\per\HWSTR.config") Then
            Dim NewDT As New DataTable("dtHWKeys")
            NewDT.Columns.Add("Key", GetType(String))
            NewDT.Rows.Add({MySecurity.encryptString("Byte")})
            NewDT.WriteXml(My.Application.Info.DirectoryPath & "\per\HWSTR.config")
        End If

        Dim ds As New DataSet
        ds.ReadXml(My.Application.Info.DirectoryPath & "\per\HWSTR.config")
        Dim dt As DataTable = ds.Tables("dtHWKeys")
        Dim bs As New BindingSource
        bs.DataSource = dt

        If bs.Find("Key", Key) = -1 Then
            dt.Rows.Add({Key})
        End If

        dt.WriteXml(My.Application.Info.DirectoryPath & "\per\HWSTR.config")

    End Sub
    Public Function IsKeyOK() As Boolean

        Try



            Dim o As Boolean = False
            Dim GeratedHWKey = HardwareInfo.AllHardwareInfoMinHashed


            If Not File.Exists(My.Application.Info.DirectoryPath & "\per\HWSTR.config") Then
                o = False
                Return o
            End If


            Dim ds As New DataSet
            ds.ReadXml(My.Application.Info.DirectoryPath & "\per\HWSTR.config")
            Dim dt As DataTable = ds.Tables("dtHWKeys")

            For Each r As DataRow In dt.Rows

                Dim xmlstr As String = MySecurity.decryptString(r.Item("Key"))
                If xmlstr = "byte" Then Continue For


                Dim xml = XElement.Parse(xmlstr)

                Dim AppID As String = xml.<AppID>.Value
                Dim Features As String = xml.<Features>.Value
                Dim IsServer As String = xml.<IsServer>.Value
                Dim HWKey As String = xml.<HWKey>.Value

                If AppID <> PubAppID Or IsServer <> IsSqlLocal.ToString Or HWKey <> GeratedHWKey Then
                    o = False
                Else
                    o = True
                    Exit For
                End If

            Next



            Return o


        Catch ex As Exception
            HandleMyError(ex, , , My.Settings.IsDebug)
            Return False
        End Try



    End Function





End Class
