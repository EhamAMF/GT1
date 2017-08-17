Module ModuleID


    Enum AppCategory
        General = 1
        Food = 2
        Cloths = 3
    End Enum


    Public Const PubAppID As Integer = 1
    Public Const PubAppName As String = "GT1"
    Public PubAppCategory As AppCategory = AppCategory.General


    Public Const PubAppVersion = 4
    Public PubdbVersion As Integer

    Public Function GetdbVersion() As Integer
        Dim sc As New SqlClient.SqlCommand("select max(v.VersoinNumber) VersoinNumber from Version v ", PubCn)

        If PubCn.State <> ConnectionState.Open Then PubCn.Open()
        Return sc.ExecuteScalar
        If PubCn.State <> ConnectionState.Closed Then PubCn.Close()

    End Function


End Module
