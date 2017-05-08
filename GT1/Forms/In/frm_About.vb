Public Class frm_About



    Private Sub frm_About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt.Columns.Add("Name")
        dt.Columns.Add("Value")

        dt.Rows.Add({"App ID", PubAppID.ToString})
        dt.Rows.Add({"App Name", PubAppName.ToString})
        dt.Rows.Add({"App Category", PubAppCategory.ToString})
        dt.Rows.Add({"App Version", PubAppVersion.ToString})
        dt.Rows.Add({"DB Version", PubdbVersion.ToString})


        dgv.DataSource = dt



    End Sub


End Class