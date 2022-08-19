<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblVacationsHolidaysDashBoardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExcutedDaysTextBox = New System.Windows.Forms.TextBox()
        Me.NbOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.VactFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VactToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.IsVacation = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsVactionCheckBox = New System.Windows.Forms.CheckBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblVacationsHolidaysDashBoardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblVacationsHolidaysDashBoardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationsHolidaysDashBoardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblVacationsHolidaysDashBoardBindingSource
        '
        Me.TblVacationsHolidaysDashBoardBindingSource.DataSource = GetType(HR.TblVacationsHolidaysDashBoard)
        '
        'ExcutedDaysTextBox
        '
        Me.ExcutedDaysTextBox.Location = New System.Drawing.Point(371, 227)
        Me.ExcutedDaysTextBox.Name = "ExcutedDaysTextBox"
        Me.ExcutedDaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExcutedDaysTextBox.TabIndex = 83
        '
        'NbOfDaysTextBox
        '
        Me.NbOfDaysTextBox.Location = New System.Drawing.Point(475, 227)
        Me.NbOfDaysTextBox.Name = "NbOfDaysTextBox"
        Me.NbOfDaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NbOfDaysTextBox.TabIndex = 82
        '
        'VactFromDateTimePicker
        '
        Me.VactFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VactFromDateTimePicker.Location = New System.Drawing.Point(277, 199)
        Me.VactFromDateTimePicker.Name = "VactFromDateTimePicker"
        Me.VactFromDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.VactFromDateTimePicker.TabIndex = 81
        '
        'VactToDateTimePicker
        '
        Me.VactToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VactToDateTimePicker.Location = New System.Drawing.Point(277, 228)
        Me.VactToDateTimePicker.Name = "VactToDateTimePicker"
        Me.VactToDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.VactToDateTimePicker.TabIndex = 80
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(172, 177)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearTextBox.TabIndex = 79
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(24, 228)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(144, 20)
        Me.DescriptionTextBox.TabIndex = 78
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(-393, 228)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(411, 20)
        Me.EmployeeNameTextBox.TabIndex = 77
        '
        'IsVacation
        '
        Me.IsVacation.DataPropertyName = "IsVacation"
        Me.IsVacation.FalseValue = "false"
        Me.IsVacation.HeaderText = "IsVac."
        Me.IsVacation.Name = "IsVacation"
        Me.IsVacation.ReadOnly = True
        Me.IsVacation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsVacation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IsVacation.ThreeState = True
        Me.IsVacation.TrueValue = "true"
        Me.IsVacation.Width = 50
        '
        'IsVactionCheckBox
        '
        Me.IsVactionCheckBox.AutoSize = True
        Me.IsVactionCheckBox.Location = New System.Drawing.Point(696, 230)
        Me.IsVactionCheckBox.Name = "IsVactionCheckBox"
        Me.IsVactionCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsVactionCheckBox.TabIndex = 76
        Me.IsVactionCheckBox.ThreeState = True
        Me.IsVactionCheckBox.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(907, 32)
        Me.lblText.TabIndex = 73
        Me.lblText.Text = "Vactions Holidays DashBoard"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EmployeeId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.TblEmployeeBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "EmployeeName"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Id"
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataSource = GetType(HR.TblEmployee)
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ExecutionDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Execution Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'TblVacationsHolidaysDashBoardDataGridView
        '
        Me.TblVacationsHolidaysDashBoardDataGridView.AllowUserToAddRows = False
        Me.TblVacationsHolidaysDashBoardDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TblVacationsHolidaysDashBoardDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TblVacationsHolidaysDashBoardDataGridView.AutoGenerateColumns = False
        Me.TblVacationsHolidaysDashBoardDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblVacationsHolidaysDashBoardDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblVacationsHolidaysDashBoardDataGridView.ColumnHeadersHeight = 32
        Me.TblVacationsHolidaysDashBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblVacationsHolidaysDashBoardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.IsVacation})
        Me.TblVacationsHolidaysDashBoardDataGridView.DataSource = Me.TblVacationsHolidaysDashBoardBindingSource
        Me.TblVacationsHolidaysDashBoardDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblVacationsHolidaysDashBoardDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.TblVacationsHolidaysDashBoardDataGridView.Name = "TblVacationsHolidaysDashBoardDataGridView"
        Me.TblVacationsHolidaysDashBoardDataGridView.ReadOnly = True
        Me.TblVacationsHolidaysDashBoardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblVacationsHolidaysDashBoardDataGridView.Size = New System.Drawing.Size(907, 550)
        Me.TblVacationsHolidaysDashBoardDataGridView.TabIndex = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VacationDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Vacation Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ExecutedDays"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Executed Days"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumberOfDays"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn4.HeaderText = "#Of Days"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1318, 148)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 74
        Me.lblClose.Text = "X"
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 600)
        Me.Controls.Add(Me.ExcutedDaysTextBox)
        Me.Controls.Add(Me.NbOfDaysTextBox)
        Me.Controls.Add(Me.VactFromDateTimePicker)
        Me.Controls.Add(Me.VactToDateTimePicker)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.IsVactionCheckBox)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.TblVacationsHolidaysDashBoardDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.TblVacationsHolidaysDashBoardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationsHolidaysDashBoardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblVacationsHolidaysDashBoardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExcutedDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NbOfDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VactFromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VactToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsVacation As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsVactionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblVacationsHolidaysDashBoardDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
End Class
