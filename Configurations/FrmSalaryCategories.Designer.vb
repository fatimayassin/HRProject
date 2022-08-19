<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalaryCategories
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TblSalaryCatDataGridView = New System.Windows.Forms.DataGridView()
        Me.SalaryCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblSalaryCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TblSalaryCatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(198, 280)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 67
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
        Me.BtnEdit.Location = New System.Drawing.Point(141, 280)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(45, 47)
        Me.BtnEdit.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseCompatibleTextRendering = True
        Me.BtnEdit.UseMnemonic = False
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = Global.HR.My.Resources.Resources.NewIcon7
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(258, 280)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(45, 47)
        Me.btnNew.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.btnNew, "Add")
        Me.btnNew.UseCompatibleTextRendering = True
        Me.btnNew.UseMnemonic = False
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'TblSalaryCatDataGridView
        '
        Me.TblSalaryCatDataGridView.AllowUserToAddRows = False
        Me.TblSalaryCatDataGridView.AllowUserToDeleteRows = False
        Me.TblSalaryCatDataGridView.AutoGenerateColumns = False
        Me.TblSalaryCatDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblSalaryCatDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblSalaryCatDataGridView.ColumnHeadersHeight = 32
        Me.TblSalaryCatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblSalaryCatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalaryCategoryDataGridViewTextBoxColumn, Me.Delete})
        Me.TblSalaryCatDataGridView.DataSource = Me.TblSalaryCategoryBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblSalaryCatDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.TblSalaryCatDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblSalaryCatDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.TblSalaryCatDataGridView.Name = "TblSalaryCatDataGridView"
        Me.TblSalaryCatDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblSalaryCatDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TblSalaryCatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblSalaryCatDataGridView.Size = New System.Drawing.Size(465, 243)
        Me.TblSalaryCatDataGridView.TabIndex = 63
        '
        'SalaryCategoryDataGridViewTextBoxColumn
        '
        Me.SalaryCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SalaryCategoryDataGridViewTextBoxColumn.DataPropertyName = "SalaryCategory"
        Me.SalaryCategoryDataGridViewTextBoxColumn.HeaderText = "SalaryCategory"
        Me.SalaryCategoryDataGridViewTextBoxColumn.Name = "SalaryCategoryDataGridViewTextBoxColumn"
        Me.SalaryCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.HR.My.Resources.Resources.DeleteIcon7
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 52
        '
        'TblSalaryCategoryBindingSource
        '
        Me.TblSalaryCategoryBindingSource.DataSource = GetType(HR.TblSalaryCategory)
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(436, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 64
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(465, 32)
        Me.lblText.TabIndex = 65
        Me.lblText.Text = "Salary Categories"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSalaryCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 331)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.TblSalaryCatDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSalaryCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSalaryCategories"
        CType(Me.TblSalaryCatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents TblSalaryCatDataGridView As DataGridView
    Friend WithEvents TblSalaryCategoryBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents SalaryCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
