Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmAssetList

    ' Form Load - Populate DataGridView with asset data
    Private Sub frmAssetList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssets()
    End Sub

    ' Load assets into DataGridView
    Public Sub LoadAssets()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT AssetID, AssetCode, AssetName, AssetBrand, AvailabilityStatus " &
                                      "FROM ITAssetTable"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvAssets.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Search functionality to filter assets
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT AssetID, AssetCode, AssetName, AssetBrand, AvailabilityStatus " &
                                      "FROM ITAssetTable " &
                                      "WHERE AssetName LIKE @searchTerm OR AssetCode LIKE @searchTerm OR AssetBrand LIKE @searchTerm OR AvailabilityStatus LIKE @searchTerm"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchTerm", "%" & txtSearch.Text & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvAssets.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display QR Code when an asset is selected
    Private Sub dgvAssets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssets.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedAssetID As Integer = dgvAssets.Rows(e.RowIndex).Cells("AssetID").Value
            GenerateQRCode(selectedAssetID)
        End If
    End Sub

    ' Generate QR Code for the selected asset
    Private Sub GenerateQRCode(assetID As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT AssetCode, AssetName FROM ITAssetTable WHERE AssetID = @assetID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@assetID", assetID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim assetCode As String = reader("AssetCode").ToString()
                    Dim assetName As String = reader("AssetName").ToString()

                    If String.IsNullOrWhiteSpace(assetCode) OrElse String.IsNullOrWhiteSpace(assetName) Then
                        MessageBox.Show("AssetCode or AssetName is empty.")
                        Return
                    End If

                    Dim qrCodeData As String = assetCode & "|" & assetName
                    Dim qrCode As New ZXing.BarcodeWriter()
                    qrCode.Format = ZXing.BarcodeFormat.QR_CODE
                    qrCode.Options = New ZXing.Common.EncodingOptions With {
                        .Width = 200,
                        .Height = 200
                    }

                    picQRCode.Image = qrCode.Write(qrCodeData)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAssets()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim printDoc As New PrintDocument()

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If picQRCode.Image IsNot Nothing Then
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            printDoc.Print()
        Else
            MessageBox.Show("No QR code to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            Dim qrImage As Image = picQRCode.Image
            If qrImage Is Nothing Then
                MessageBox.Show("No QR code image to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim x As Integer = 100
            Dim y As Integer = 100
            Dim printWidth As Integer = 200
            Dim printHeight As Integer = 200

            e.Graphics.DrawImage(qrImage, x, y, printWidth, printHeight)
        Catch ex As Exception
            MessageBox.Show("Error printing QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnOpenITAssetAddForm_Click(sender As Object, e As EventArgs) Handles btnOpenITAssetAddForm.Click
        Dim assetForm As New ITAssetAddForm()
        assetForm.ShowDialog()
    End Sub

End Class
