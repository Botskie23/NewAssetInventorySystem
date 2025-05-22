Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class frmAssetMasterListReportViewer

    Private Sub frmAssetMasterListReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load the report
        Dim report As New ReportDocument()
        report.Load("C:\Users\Ryan Oliver\source\repos\AssetInventorySystem\AssetInventorySystem\AssetMasterList.rpt")

        ' Apply global MySQL connection from module
        ApplyMySqlLogin(report)

        ' Set the report source and refresh
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

End Class
