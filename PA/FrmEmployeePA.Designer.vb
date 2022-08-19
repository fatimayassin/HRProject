<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeePA
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.AveragePAPerTaskForEmployeeResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ratio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AveragePAPerTaskForEmployeeResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.AveragePAPerTaskForEmployeeResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AveragePAPerTaskForEmployeeResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblClose.Location = New System.Drawing.Point(1075, 3)
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
        Me.lblText.Size = New System.Drawing.Size(1103, 32)
        Me.lblText.TabIndex = 54
        Me.lblText.Text = "Employee PA"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AveragePAPerTaskForEmployeeResultDataGridView
        '
        Me.AveragePAPerTaskForEmployeeResultDataGridView.AllowUserToAddRows = False
        Me.AveragePAPerTaskForEmployeeResultDataGridView.AllowUserToDeleteRows = False
        Me.AveragePAPerTaskForEmployeeResultDataGridView.AutoGenerateColumns = False
        Me.AveragePAPerTaskForEmployeeResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.AveragePAPerTaskForEmployeeResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AveragePAPerTaskForEmployeeResultDataGridView.ColumnHeadersHeight = 32
        Me.AveragePAPerTaskForEmployeeResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AveragePAPerTaskForEmployeeResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.PAName, Me.DataGridViewTextBoxColumn8, Me.AverageColumn, Me.Ratio, Me.Note})
        Me.AveragePAPerTaskForEmployeeResultDataGridView.DataSource = Me.AveragePAPerTaskForEmployeeResultBindingSource
        Me.AveragePAPerTaskForEmployeeResultDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.AveragePAPerTaskForEmployeeResultDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.AveragePAPerTaskForEmployeeResultDataGridView.Name = "AveragePAPerTaskForEmployeeResultDataGridView"
        Me.AveragePAPerTaskForEmployeeResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AveragePAPerTaskForEmployeeResultDataGridView.Size = New System.Drawing.Size(1103, 571)
        Me.AveragePAPerTaskForEmployeeResultDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "JobName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Job Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PAName
        '
        Me.PAName.DataPropertyName = "PAName"
        Me.PAName.HeaderText = "PA "
        Me.PAName.Name = "PAName"
        Me.PAName.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TaskName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Task Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'AverageColumn
        '
        Me.AverageColumn.DataPropertyName = "Average"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.AverageColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.AverageColumn.HeaderText = "Average"
        Me.AverageColumn.Name = "AverageColumn"
        '
        'Ratio
        '
        Me.Ratio.DataPropertyName = "Ratio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Ratio.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ratio.HeaderText = "Ratio"
        Me.Ratio.Name = "Ratio"
        '
        'Note
        '
        Me.Note.DataPropertyName = "Note"
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.Width = 150
        '
        'AveragePAPerTaskForEmployeeResultBindingSource
        '
        Me.AveragePAPerTaskForEmployeeResultBindingSource.DataSource = GetType(HR.AveragePAPerTaskForEmployeeResult)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1047, 611)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmEmployeePA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.AveragePAPerTaskForEmployeeResultDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmEmployeePA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AveragePAPerTaskForEmployeeResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AveragePAPerTaskForEmployeeResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents AveragePAPerTaskForEmployeeResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AveragePAPerTaskForEmployeeResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ratio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
