﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCertificateList
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
        Me.components = New System.ComponentModel.Container()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblCertificateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCertificateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCertificateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(518, 30)
        Me.lblText.TabIndex = 45
        Me.lblText.Text = "Certificate List"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(488, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblCertificateBindingSource
        '
        Me.TblCertificateBindingSource.DataSource = GetType(HR.TblCertificate)
        '
        'TblCertificateDataGridView
        '
        Me.TblCertificateDataGridView.AllowUserToAddRows = False
        Me.TblCertificateDataGridView.AllowUserToDeleteRows = False
        Me.TblCertificateDataGridView.AutoGenerateColumns = False
        Me.TblCertificateDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblCertificateDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblCertificateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCertificateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Delete})
        Me.TblCertificateDataGridView.DataSource = Me.TblCertificateBindingSource
        Me.TblCertificateDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblCertificateDataGridView.Location = New System.Drawing.Point(0, 30)
        Me.TblCertificateDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblCertificateDataGridView.Name = "TblCertificateDataGridView"
        Me.TblCertificateDataGridView.ReadOnly = True
        Me.TblCertificateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblCertificateDataGridView.Size = New System.Drawing.Size(518, 256)
        Me.TblCertificateDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.HR.My.Resources.Resources.DeleteIcon71
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Width = 50
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = Global.HR.My.Resources.Resources.NewIcon7
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(293, 300)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 47)
        Me.btnNew.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.btnNew, "Add")
        Me.btnNew.UseCompatibleTextRendering = True
        Me.btnNew.UseMnemonic = False
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(227, 300)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = Global.HR.My.Resources.Resources.EditIcon7
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(160, 300)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(51, 47)
        Me.BtnEdit.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseCompatibleTextRendering = True
        Me.BtnEdit.UseMnemonic = False
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'FrmCertificateList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TblCertificateDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCertificateList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCertificateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblCertificateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCertificateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
