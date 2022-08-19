<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeVacation
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
        Me.TblEmployeeVacationDataGridView = New System.Windows.Forms.DataGridView()
        Me.VacationCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExecutedDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Execute = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblEmployeeVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblVacationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblEmployeeVacationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblClose.Location = New System.Drawing.Point(641, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 68
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
        Me.lblText.Size = New System.Drawing.Size(670, 32)
        Me.lblText.TabIndex = 69
        Me.lblText.Text = "Employee Vacation"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblEmployeeVacationDataGridView
        '
        Me.TblEmployeeVacationDataGridView.AllowUserToAddRows = False
        Me.TblEmployeeVacationDataGridView.AllowUserToDeleteRows = False
        Me.TblEmployeeVacationDataGridView.AutoGenerateColumns = False
        Me.TblEmployeeVacationDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblEmployeeVacationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblEmployeeVacationDataGridView.ColumnHeadersHeight = 32
        Me.TblEmployeeVacationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblEmployeeVacationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VacationCol, Me.DateCol, Me.NumberOfDays, Me.ExecutedDays, Me.Execute})
        Me.TblEmployeeVacationDataGridView.DataSource = Me.TblEmployeeVacationBindingSource
        Me.TblEmployeeVacationDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblEmployeeVacationDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.TblEmployeeVacationDataGridView.Name = "TblEmployeeVacationDataGridView"
        Me.TblEmployeeVacationDataGridView.ReadOnly = True
        Me.TblEmployeeVacationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblEmployeeVacationDataGridView.Size = New System.Drawing.Size(670, 317)
        Me.TblEmployeeVacationDataGridView.TabIndex = 70
        '
        'VacationCol
        '
        Me.VacationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VacationCol.DataPropertyName = "VacationId"
        Me.VacationCol.DataSource = Me.TblVacationBindingSource
        Me.VacationCol.DisplayMember = "Description"
        Me.VacationCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.VacationCol.HeaderText = "Vacation"
        Me.VacationCol.Name = "VacationCol"
        Me.VacationCol.ReadOnly = True
        Me.VacationCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VacationCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VacationCol.ValueMember = "Id"
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'DateCol
        '
        Me.DateCol.DataPropertyName = "Date"
        Me.DateCol.HeaderText = "Date"
        Me.DateCol.Name = "DateCol"
        Me.DateCol.ReadOnly = True
        '
        'NumberOfDays
        '
        Me.NumberOfDays.DataPropertyName = "NumberOfDays"
        Me.NumberOfDays.HeaderText = "#Of Days"
        Me.NumberOfDays.Name = "NumberOfDays"
        Me.NumberOfDays.ReadOnly = True
        '
        'ExecutedDays
        '
        Me.ExecutedDays.DataPropertyName = "ExecutedDays"
        Me.ExecutedDays.HeaderText = "Executed Days"
        Me.ExecutedDays.Name = "ExecutedDays"
        Me.ExecutedDays.ReadOnly = True
        '
        'Execute
        '
        Me.Execute.HeaderText = "Execute"
        Me.Execute.Image = Global.HR.My.Resources.Resources.ExecuteIcon7
        Me.Execute.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Execute.Name = "Execute"
        Me.Execute.ReadOnly = True
        Me.Execute.Width = 60
        '
        'TblEmployeeVacationBindingSource
        '
        Me.TblEmployeeVacationBindingSource.DataSource = GetType(HR.TblEmployeeVacation)
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(307, 67)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 75
        Me.MonthCalendar1.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(302, 354)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 82
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
        Me.BtnEdit.Location = New System.Drawing.Point(245, 354)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(45, 47)
        Me.BtnEdit.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseCompatibleTextRendering = True
        Me.BtnEdit.UseMnemonic = False
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImage = Global.HR.My.Resources.Resources.NewIcon7
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddNew.FlatAppearance.BorderSize = 0
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Location = New System.Drawing.Point(362, 354)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(45, 47)
        Me.BtnAddNew.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.BtnAddNew, "Add")
        Me.BtnAddNew.UseCompatibleTextRendering = True
        Me.BtnAddNew.UseMnemonic = False
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Execute"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.JobListIcon1
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'TblVacationBindingSource1
        '
        Me.TblVacationBindingSource1.DataSource = GetType(HR.TblVacation)
        '
        'FrmEmployeeVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TblEmployeeVacationDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmEmployeeVacation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblEmployeeVacationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblEmployeeVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeeVacationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVacationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents VacationCol As DataGridViewComboBoxColumn
    Friend WithEvents DateCol As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDays As DataGridViewTextBoxColumn
    Friend WithEvents ExecutedDays As DataGridViewTextBoxColumn
    Friend WithEvents Execute As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
