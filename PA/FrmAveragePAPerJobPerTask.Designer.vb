<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAveragePAPerJobPerTask
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TblPAPerJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPAPerJobDataGridView = New System.Windows.Forms.DataGridView()
        Me.JobCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblPAForEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTaskDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.TblPAPerJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPAPerJobDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPAForEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTaskDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1088, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 2
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
        Me.lblText.Size = New System.Drawing.Size(1116, 32)
        Me.lblText.TabIndex = 52
        Me.lblText.Text = "PA Per Job Per Task"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblPAPerJobBindingSource
        '
        Me.TblPAPerJobBindingSource.DataSource = GetType(HR.TblPAPerJob)
        '
        'TblPAPerJobDataGridView
        '
        Me.TblPAPerJobDataGridView.AllowUserToAddRows = False
        Me.TblPAPerJobDataGridView.AllowUserToDeleteRows = False
        Me.TblPAPerJobDataGridView.AutoGenerateColumns = False
        Me.TblPAPerJobDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblPAPerJobDataGridView.ColumnHeadersHeight = 32
        Me.TblPAPerJobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblPAPerJobDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobCol, Me.DataGridViewTextBoxColumn2})
        Me.TblPAPerJobDataGridView.DataSource = Me.TblPAPerJobBindingSource
        Me.TblPAPerJobDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.TblPAPerJobDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblPAPerJobDataGridView.Name = "TblPAPerJobDataGridView"
        Me.TblPAPerJobDataGridView.ReadOnly = True
        Me.TblPAPerJobDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblPAPerJobDataGridView.Size = New System.Drawing.Size(459, 496)
        Me.TblPAPerJobDataGridView.TabIndex = 0
        '
        'JobCol
        '
        Me.JobCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JobCol.DataPropertyName = "JobId"
        Me.JobCol.DataSource = Me.TblJobDescriptionBindingSource
        Me.JobCol.DisplayMember = "Name"
        Me.JobCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.JobCol.HeaderText = "Job"
        Me.JobCol.Name = "JobCol"
        Me.JobCol.ReadOnly = True
        Me.JobCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JobCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.JobCol.ValueMember = "Id"
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PAId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TblPAForEmployeeBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "PA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Id"
        '
        'TblPAForEmployeeBindingSource
        '
        Me.TblPAForEmployeeBindingSource.DataSource = GetType(HR.TblPAForEmployee)
        '
        'TblTaskBindingSource
        '
        Me.TblTaskBindingSource.DataSource = GetType(HR.TblTask)
        '
        'TblTaskDataGridView
        '
        Me.TblTaskDataGridView.AllowUserToAddRows = False
        Me.TblTaskDataGridView.AllowUserToDeleteRows = False
        Me.TblTaskDataGridView.AutoGenerateColumns = False
        Me.TblTaskDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblTaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTaskDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Average})
        Me.TblTaskDataGridView.DataSource = Me.TblTaskBindingSource
        Me.TblTaskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblTaskDataGridView.Location = New System.Drawing.Point(459, 0)
        Me.TblTaskDataGridView.Name = "TblTaskDataGridView"
        Me.TblTaskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblTaskDataGridView.Size = New System.Drawing.Size(657, 496)
        Me.TblTaskDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CategoryId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.TblCategoryBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "Id"
        '
        'TblCategoryBindingSource
        '
        Me.TblCategoryBindingSource.DataSource = GetType(HR.TblCategory)
        '
        'Average
        '
        Me.Average.HeaderText = "Average"
        Me.Average.Name = "Average"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TblTaskDataGridView)
        Me.Panel2.Controls.Add(Me.TblPAPerJobDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 496)
        Me.Panel2.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1071, 0)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 48)
        Me.BtnSave.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 528)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 48)
        Me.Panel1.TabIndex = 78
        '
        'FrmAveragePAPerJobPerTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1116, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAveragePAPerJobPerTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblPAPerJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPAPerJobDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPAForEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTaskDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblPAPerJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPAPerJobDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPAForEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTaskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTaskDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Average As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCol As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
End Class
