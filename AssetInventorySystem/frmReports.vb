Public Class frmReports
    Private Sub btnAssetMasterListRPT_Click(sender As Object, e As EventArgs) Handles btnAssetMasterListRPT.Click

        Dim reportViewerForm As New frmAssetMasterListReportViewer()
        reportViewerForm.ShowDialog()

    End Sub
End Class