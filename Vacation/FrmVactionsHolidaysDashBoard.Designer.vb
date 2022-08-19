<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVactionsHolidaysDashBoard
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblVacationsHolidaysDashBoardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsVacation = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblVacationsHolidaysDashBoardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsVactionCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.VactFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NbOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.VactToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExcutedDaysTextBox = New System.Windows.Forms.TextBox()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.TblVacationsHolidaysDashBoardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationsHolidaysDashBoardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.lblText.Size = New System.Drawing.Size(1122, 30)
        Me.lblText.TabIndex = 60
        Me.lblText.Text = "Vactions Holidays DashBoard"
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
        Me.lblClose.Location = New System.Drawing.Point(1094, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 61
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblVacationsHolidaysDashBoardDataGridView
        '
        Me.TblVacationsHolidaysDashBoardDataGridView.AllowUserToAddRows = False
        Me.TblVacationsHolidaysDashBoardDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TblVacationsHolidaysDashBoardDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblVacationsHolidaysDashBoardDataGridView.AutoGenerateColumns = False
        Me.TblVacationsHolidaysDashBoardDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblVacationsHolidaysDashBoardDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblVacationsHolidaysDashBoardDataGridView.ColumnHeadersHeight = 32
        Me.TblVacationsHolidaysDashBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblVacationsHolidaysDashBoardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.IsVacation})
        Me.TblVacationsHolidaysDashBoardDataGridView.DataSource = Me.TblVacationsHolidaysDashBoardBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblVacationsHolidaysDashBoardDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.TblVacationsHolidaysDashBoardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblVacationsHolidaysDashBoardDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblVacationsHolidaysDashBoardDataGridView.Name = "TblVacationsHolidaysDashBoardDataGridView"
        Me.TblVacationsHolidaysDashBoardDataGridView.ReadOnly = True
        Me.TblVacationsHolidaysDashBoardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblVacationsHolidaysDashBoardDataGridView.Size = New System.Drawing.Size(1122, 391)
        Me.TblVacationsHolidaysDashBoardDataGridView.TabIndex = 62
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Executed Days"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumberOfDays"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "#Of Days"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ExecutionDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Execution Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
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
        'TblVacationsHolidaysDashBoardBindingSource
        '
        Me.TblVacationsHolidaysDashBoardBindingSource.DataSource = GetType(HR.TblVacationsHolidaysDashBoard)
        '
        'IsVactionCheckBox
        '
        Me.IsVactionCheckBox.AutoSize = True
        Me.IsVactionCheckBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsVactionCheckBox.Location = New System.Drawing.Point(1083, 37)
        Me.IsVactionCheckBox.Name = "IsVactionCheckBox"
        Me.IsVactionCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsVactionCheckBox.TabIndex = 63
        Me.IsVactionCheckBox.ThreeState = True
        Me.IsVactionCheckBox.UseVisualStyleBackColor = True
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(41, 35)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(381, 22)
        Me.EmployeeNameTextBox.TabIndex = 64
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(425, 35)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(145, 22)
        Me.DescriptionTextBox.TabIndex = 65
        '
        'YearTextBox
        '
        Me.YearTextBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearTextBox.Location = New System.Drawing.Point(574, 35)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(100, 22)
        Me.YearTextBox.TabIndex = 66
        '
        'VactFromDateTimePicker
        '
        Me.VactFromDateTimePicker.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VactFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VactFromDateTimePicker.Location = New System.Drawing.Point(677, 8)
        Me.VactFromDateTimePicker.Name = "VactFromDateTimePicker"
        Me.VactFromDateTimePicker.Size = New System.Drawing.Size(92, 22)
        Me.VactFromDateTimePicker.TabIndex = 68
        '
        'NbOfDaysTextBox
        '
        Me.NbOfDaysTextBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbOfDaysTextBox.Location = New System.Drawing.Point(876, 34)
        Me.NbOfDaysTextBox.Name = "NbOfDaysTextBox"
        Me.NbOfDaysTextBox.Size = New System.Drawing.Size(95, 22)
        Me.NbOfDaysTextBox.TabIndex = 71
        '
        'VactToDateTimePicker
        '
        Me.VactToDateTimePicker.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VactToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VactToDateTimePicker.Location = New System.Drawing.Point(677, 35)
        Me.VactToDateTimePicker.Name = "VactToDateTimePicker"
        Me.VactToDateTimePicker.Size = New System.Drawing.Size(92, 22)
        Me.VactToDateTimePicker.TabIndex = 67
        '
        'ExcutedDaysTextBox
        '
        Me.ExcutedDaysTextBox.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcutedDaysTextBox.Location = New System.Drawing.Point(773, 34)
        Me.ExcutedDaysTextBox.Name = "ExcutedDaysTextBox"
        Me.ExcutedDaysTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ExcutedDaysTextBox.TabIndex = 72
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EmployeeNameTextBox)
        Me.Panel1.Controls.Add(Me.ExcutedDaysTextBox)
        Me.Panel1.Controls.Add(Me.IsVactionCheckBox)
        Me.Panel1.Controls.Add(Me.NbOfDaysTextBox)
        Me.Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Panel1.Controls.Add(Me.VactFromDateTimePicker)
        Me.Panel1.Controls.Add(Me.YearTextBox)
        Me.Panel1.Controls.Add(Me.VactToDateTimePicker)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1122, 60)
        Me.Panel1.TabIndex = 73
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TblVacationsHolidaysDashBoardDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1122, 391)
        Me.Panel2.TabIndex = 74
        '
        'FrmVactionsHolidaysDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmVactionsHolidaysDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblVacationsHolidaysDashBoardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationsHolidaysDashBoardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblVacationsHolidaysDashBoardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVacationsHolidaysDashBoardDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IsVactionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VactFromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NbOfDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VactToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExcutedDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsVacation As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
