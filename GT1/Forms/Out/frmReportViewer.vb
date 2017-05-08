Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReportViewer

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = MDIParent1




    End Sub

    
    



    Private Sub frmReportViewer_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        Me.rvReport.RefreshReport()
    End Sub
End Class