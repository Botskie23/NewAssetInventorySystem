<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvAssets = New System.Windows.Forms.DataGridView()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnOpenITAssetAddForm = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(116, 140)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(467, 32)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(27, 149)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(83, 23)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search:"
        '
        'dgvAssets
        '
        Me.dgvAssets.AllowUserToAddRows = False
        Me.dgvAssets.AllowUserToDeleteRows = False
        Me.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssets.Location = New System.Drawing.Point(27, 178)
        Me.dgvAssets.Name = "dgvAssets"
        Me.dgvAssets.RowHeadersWidth = 51
        Me.dgvAssets.RowTemplate.Height = 24
        Me.dgvAssets.Size = New System.Drawing.Size(1171, 407)
        Me.dgvAssets.TabIndex = 2
        Me.dgvAssets.TabStop = False
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(749, 73)
        Me.picQRCode.Margin = New System.Windows.Forms.Padding(0)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(325, 290)
        Me.picQRCode.TabIndex = 3
        Me.picQRCode.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(891, 600)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 41)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(977, 601)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 41)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(805, 601)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 41)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print QR Code"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnOpenITAssetAddForm
        '
        Me.btnOpenITAssetAddForm.CheckedState.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.CustomImages.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOpenITAssetAddForm.ForeColor = System.Drawing.Color.White
        Me.btnOpenITAssetAddForm.HoverState.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Location = New System.Drawing.Point(684, 601)
        Me.btnOpenITAssetAddForm.Name = "btnOpenITAssetAddForm"
        Me.btnOpenITAssetAddForm.ShadowDecoration.Parent = Me.btnOpenITAssetAddForm
        Me.btnOpenITAssetAddForm.Size = New System.Drawing.Size(97, 32)
        Me.btnOpenITAssetAddForm.TabIndex = 11
        Me.btnOpenITAssetAddForm.Text = "Add Asset"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Asset List"
        '
        'frmAssetList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 901)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpenITAssetAddForm)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.dgvAssets)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAssetList"
        Me.Text = "frmAssetList"
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvAssets As DataGridView
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnOpenITAssetAddForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
