﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.btnAssetMasterListRPT = New System.Windows.Forms.Button()
        Me.btnAssignAsset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAssetMasterListRPT
        '
        Me.btnAssetMasterListRPT.Location = New System.Drawing.Point(136, 102)
        Me.btnAssetMasterListRPT.Name = "btnAssetMasterListRPT"
        Me.btnAssetMasterListRPT.Size = New System.Drawing.Size(185, 44)
        Me.btnAssetMasterListRPT.TabIndex = 0
        Me.btnAssetMasterListRPT.Text = "Asset Master List"
        Me.btnAssetMasterListRPT.UseVisualStyleBackColor = True
        '
        'btnAssignAsset
        '
        Me.btnAssignAsset.Location = New System.Drawing.Point(136, 152)
        Me.btnAssignAsset.Name = "btnAssignAsset"
        Me.btnAssignAsset.Size = New System.Drawing.Size(185, 44)
        Me.btnAssignAsset.TabIndex = 1
        Me.btnAssignAsset.Text = "Asset Assignment"
        Me.btnAssignAsset.UseVisualStyleBackColor = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAssignAsset)
        Me.Controls.Add(Me.btnAssetMasterListRPT)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAssetMasterListRPT As Button
    Friend WithEvents btnAssignAsset As Button
End Class
