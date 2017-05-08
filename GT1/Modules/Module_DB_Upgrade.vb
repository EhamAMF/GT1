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
                HandleMyError(ex, , , My.Settings.IsDebug)
            Finally
                If PubCn.State <> ConnectionState.Closed Then PubCn.Close()
            End Try


            PubdbVersion = ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Version", "VersoinNumber", "1 = 1")


        End If





    End Sub



End Module
