<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraineePerformanceAppraisal
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblTraineePerformanceAppraisalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTraineePerformanceAppraisalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblPAForTraineerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAforTraineeId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TblTraineePerformanceAppraisalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTraineePerformanceAppraisalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPAForTraineerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblText.Size = New System.Drawing.Size(573, 32)
        Me.lblText.TabIndex = 48
        Me.lblText.Text = "Trainee Performance Appraisal"
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
        Me.lblClose.Location = New System.Drawing.Point(544, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblTraineePerformanceAppraisalBindingSource
        '
        Me.TblTraineePerformanceAppraisalBindingSource.DataSource = GetType(HR.TblTraineePerformanceAppraisal)
        '
        'TblTraineePerformanceAppraisalDataGridView
        '
        Me.TblTraineePerformanceAppraisalDataGridView.AllowUserToAddRows = False
        Me.TblTraineePerformanceAppraisalDataGridView.AllowUserToDeleteRows = False
        Me.TblTraineePerformanceAppraisalDataGridView.AutoGenerateColumns = False
        Me.TblTraineePerformanceAppraisalDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblTraineePerformanceAppraisalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblTraineePerformanceAppraisalDataGridView.ColumnHeadersHeight = 32
        Me.TblTraineePerformanceAppraisalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblTraineePerformanceAppraisalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.PAforTraineeId, Me.c1, Me.Delete})
        Me.TblTraineePerformanceAppraisalDataGridView.DataSource = Me.TblTraineePerformanceAppraisalBindingSource
        Me.TblTraineePerformanceAppraisalDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblTraineePerformanceAppraisalDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.TblTraineePerformanceAppraisalDataGridView.Name = "TblTraineePerformanceAppraisalDataGridView"
        Me.TblTraineePerformanceAppraisalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblTraineePerformanceAppraisalDataGridView.Size = New System.Drawing.Size(573, 249)
        Me.TblTraineePerformanceAppraisalDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PAforTraineeId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.TblPAForTraineerBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "PA Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        '
        'TblPAForTraineerBindingSource
        '
        Me.TblPAForTraineerBindingSource.DataSource = GetType(HR.TblPAForTraineer)
        '
        'PAforTraineeId
        '
        Me.PAforTraineeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PAforTraineeId.DataPropertyName = "PAforTraineeId"
        Me.PAforTraineeId.DataSource = Me.TblPAForTraineerBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PAforTraineeId.DefaultCellStyle = DataGridViewCellStyle1
        Me.PAforTraineeId.DisplayMember = "Average"
        Me.PAforTraineeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PAforTraineeId.HeaderText = "PA Average"
        Me.PAforTraineeId.Name = "PAforTraineeId"
        Me.PAforTraineeId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PAforTraineeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PAforTraineeId.ValueMember = "id"
        '
        'c1
        '
        Me.c1.DataPropertyName = "Grade"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.c1.DefaultCellStyle = DataGridViewCellStyle2
        Me.c1.HeaderText = "Grade"
        Me.c1.Name = "c1"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.HR.My.Resources.Resources.DeleteIcon71
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.Width = 50
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(523, 286)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmTraineePerformanceAppraisal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TblTraineePerformanceAppraisalDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmTraineePerformanceAppraisal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblTraineePerformanceAppraisalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTraineePerformanceAppraisalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPAForTraineerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblTraineePerformanceAppraisalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTraineePerformanceAppraisalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblPAForTraineerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents PAforTraineeId As DataGridViewComboBoxColumn
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
