Imports System.Data.SqlClient
Imports ByteClassLibrary.MyFunctions

Module Module_DB_Upgrade

    Public Sub CheckUpgradeDB()

        PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")

        Dim cmd As New SqlCommand("", PubCn)

        If PubdbVersion = 1 Then

            Dim MyTrans As SqlTransaction
            Try
                If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
                cmd.Transaction = MyTrans



                cmd.CommandText = My.Resources.a02_02_CREATE_TABLE_Settings
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_03_Update_Account
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_04_CREATE_UNIQUE_NONCLUSTERED_INDEX_IX_Settings
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_05_Insert_into_Settings
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_06_All
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_07_Update_Version_Table
                cmd.ExecuteNonQuery()


                MyTrans.Commit()

            Catch ex As Exception
                MyTrans.Rollback()
                HandleMyError(ex, , , Settings.IsDebug)
            Finally
                If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            End Try


            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
            CheckUpgradeDB()




        ElseIf PubdbVersion = 3 Then

            Dim MyTrans As SqlTransaction
            Try
                If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
                cmd.Transaction = MyTrans



                cmd.CommandText = My.Resources.a_UpdateVersion4
                cmd.ExecuteNonQuery()

                MyTrans.Commit()

            Catch ex As Exception
                MyTrans.Rollback()
                HandleMyError(ex, , , Settings.IsDebug)
            Finally
                If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            End Try


            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
            CheckUpgradeDB()

        ElseIf PubdbVersion = 4 Then

            Dim MyTrans As SqlTransaction
            Try
                If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
                cmd.Transaction = MyTrans



                cmd.CommandText = My.Resources.a_UpdateVersion5
                cmd.ExecuteNonQuery()

                MyTrans.Commit()

            Catch ex As Exception
                MyTrans.Rollback()
                HandleMyError(ex, , , Settings.IsDebug)
            Finally
                If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            End Try


            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
            CheckUpgradeDB()


        ElseIf PubdbVersion = 5 Then

            Dim MyTrans As SqlTransaction
            Try
                If PubCn.State <> ConnectionState.Open Then PubCn.Open()
                MyTrans = PubCn.BeginTransaction(IsolationLevel.Serializable)
                cmd.Transaction = MyTrans


                cmd.CommandText = My.Resources.a01_Add_UserID_To_Services
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a02_Add_UserID_Relation_To_Services
                cmd.ExecuteNonQuery()


                cmd.CommandText = My.Resources.a_All_Proc_Func
                cmd.ExecuteNonQuery()

                cmd.CommandText = My.Resources.a_UpdateVersion6
                cmd.ExecuteNonQuery()

                MyTrans.Commit()

            Catch ex As Exception
                MyTrans.Rollback()
                HandleMyError(ex, , , Settings.IsDebug)
            Finally
                If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            End Try


            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
            CheckUpgradeDB()

        End If





    End Sub


    Public Sub CheckUpgradeDB2()
        PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")
        Dim LastDBVersion As Integer = 9




        While PubdbVersion <> LastDBVersion
            Select Case PubdbVersion
                Case 6
                    PubdbVersion6()
                Case 7
                    PubdbVersion7()
                Case 8
                    PubdbVersion8()
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



            cmd.CommandText = My.Resources.a_All_Proc_Func
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

End Module
