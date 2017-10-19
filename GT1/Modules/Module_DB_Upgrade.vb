Imports System.Data.SqlClient
Imports ByteClassLibrary.MyFunctions

Module Module_DB_Upgrade

    


    Public Sub CheckUpgradeDB2()
        PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
        Dim LastDBVersion As Integer = 10




        While PubdbVersion <> LastDBVersion
            Select Case PubdbVersion
                Case 6
                    PubdbVersion6()
                Case 7
                    PubdbVersion7()
                Case 8
                    PubdbVersion8()
                Case 9
                    PubdbVersion9()
            End Select
        End While



    End Sub



    
    Private Sub PubdbVersion6()

        Dim cmd As New SqlCommand("", PubCn)
        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
            cmd.Transaction = MyTrans



            cmd.CommandText = My.Resources.a_UpdateVersion
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@VersoinNumber", PubdbVersion + 1)
            cmd.ExecuteNonQuery()

            MyTrans.Commit()

            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try





    End Sub
    Private Sub PubdbVersion7()

        Dim cmd As New SqlCommand("", PubCn)
        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
            cmd.Transaction = MyTrans



            cmd.CommandText = My.Resources.a_UpdateVersion
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@VersoinNumber", PubdbVersion + 1)
            cmd.ExecuteNonQuery()

            MyTrans.Commit()

            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try





    End Sub
    Private Sub PubdbVersion8()

        Dim cmd As New SqlCommand("", PubCn)
        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
            cmd.Transaction = MyTrans

            cmd.CommandText = My.Resources.a08To09_01_Add_ProductSearchName
            cmd.ExecuteNonQuery()

            cmd.CommandText = My.Resources.a08To09_02_Update_ProductSearchName
            cmd.ExecuteNonQuery()


            cmd.CommandText = My.Resources.a08To09_03_UnNull_ProductSearchName
            cmd.ExecuteNonQuery()

            cmd.CommandText = My.Resources.a08To09_04_AddIndex_ProductSearchName
            cmd.ExecuteNonQuery()



 

            cmd.CommandText = My.Resources.a_UpdateVersion
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@VersoinNumber", PubdbVersion + 1)
            cmd.ExecuteNonQuery()

            MyTrans.Commit()

            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try





    End Sub
    Private Sub PubdbVersion9()

        Dim cmd As New SqlCommand("", PubCn)
        Dim MyTrans As SqlTransaction
        Try
            If PubCn.State <> ConnectionState.Open Then PubCn.Open()
            MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
            cmd.Transaction = MyTrans





            cmd.CommandText = My.Resources.a_UpdateVersion
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@VersoinNumber", PubdbVersion + 1)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()










            cmd.CommandText = My.Resources.a_All_Proc_Func
            cmd.ExecuteNonQuery()

            cmd.CommandText = My.Resources.a_Insert_All_Settings
            cmd.ExecuteNonQuery()





            MyTrans.Commit()

            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")

        Catch ex As Exception
            MyTrans.Rollback()
            HandleMyError(ex, , , Settings.IsDebug)
        Finally
            If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
        End Try





    End Sub

End Module
