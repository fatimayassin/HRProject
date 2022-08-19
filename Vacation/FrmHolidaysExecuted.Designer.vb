<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHolidaysExecuted
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckExecute = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Filter_EmployeeExecutedHolidaysResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ExecutedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.Filter_EmployeeExecutedHolidaysResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_EmployeeExecutedHolidaysResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.lblText.Size = New System.Drawing.Size(724, 32)
        Me.lblText.TabIndex = 59
        Me.lblText.Text = "Holidays Executed"
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
        Me.lblClose.Location = New System.Drawing.Point(695, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 60
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(47, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(443, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 23)
        Me.DateTimePicker1.TabIndex = 64
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
        Me.BtnSave.Location = New System.Drawing.Point(673, 0)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 36)
        Me.BtnSave.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Filter_EmployeeExecutedHolidaysResultDataGridView
        '
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.AllowUserToAddRows = False
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.AutoGenerateColumns = False
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.ColumnHeadersHeight = 32
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.CheckExecute})
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.DataSource = Me.Filter_EmployeeExecutedHolidaysResultBindingSource
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.Name = "Filter_EmployeeExecutedHolidaysResultDataGridView"
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.Size = New System.Drawing.Size(724, 427)
        Me.Filter_EmployeeExecutedHolidaysResultDataGridView.TabIndex = 66
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmployeeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HolidayDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Holiday Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ExecutionDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Execution Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ExecutedDays"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Executed Days"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CheckExecute
        '
        Me.CheckExecute.HeaderText = "Executed"
        Me.CheckExecute.Name = "CheckExecute"
        Me.CheckExecute.ReadOnly = True
        Me.CheckExecute.Width = 70
        '
        'Filter_EmployeeExecutedHolidaysResultBindingSource
        '
        Me.Filter_EmployeeExecutedHolidaysResultBindingSource.DataSource = GetType(HR.Filter_EmployeeExecutedHolidaysResult)
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(76, 4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(254, 23)
        Me.NameTextBox.TabIndex = 67
        '
        'ExecutedCheckBox
        '
        Me.ExecutedCheckBox.AutoSize = True
        Me.ExecutedCheckBox.Checked = True
        Me.ExecutedCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ExecutedCheckBox.Location = New System.Drawing.Point(679, 9)
        Me.ExecutedCheckBox.Name = "ExecutedCheckBox"
        Me.ExecutedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ExecutedCheckBox.TabIndex = 76
        Me.ExecutedCheckBox.ThreeState = True
        Me.ExecutedCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.ExecutedCheckBox)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 32)
        Me.Panel1.TabIndex = 77
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Filter_EmployeeExecutedHolidaysResultDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 427)
        Me.Panel2.TabIndex = 78
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 491)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 36)
        Me.Panel3.TabIndex = 79
        '
        'FrmHolidaysExecuted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmHolidaysExecuted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Filter_EmployeeExecutedHolidaysResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_EmployeeExecutedHolidaysResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents EmpName As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Filter_EmployeeExecutedHolidaysResultBindingSource As BindingSource
    Friend WithEvents Filter_EmployeeExecutedHolidaysResultDataGridView As DataGridView
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ExecutedCheckBox As CheckBox
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CheckExecute As DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
