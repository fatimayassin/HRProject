<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJobsPerDepartment
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
        Me.DepartmentTreeView = New System.Windows.Forms.TreeView()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobDescriptionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRequiredHoursForJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobDescriptionDataGridView = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ArabicNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupervidorIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobDescriptionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReqHrsIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblRequiredHoursForJobBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredHoursForJobBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(1196, 32)
        Me.lblText.TabIndex = 54
        Me.lblText.Text = "Jobs Per Department"
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
        Me.lblClose.Location = New System.Drawing.Point(1170, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 55
        Me.lblClose.Text = "X"
        '
        'DepartmentTreeView
        '
        Me.DepartmentTreeView.CheckBoxes = True
        Me.DepartmentTreeView.Location = New System.Drawing.Point(0, 101)
        Me.DepartmentTreeView.Name = "DepartmentTreeView"
        Me.DepartmentTreeView.Size = New System.Drawing.Size(246, 583)
        Me.DepartmentTreeView.TabIndex = 56
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'TblJobDescriptionBindingSource1
        '
        Me.TblJobDescriptionBindingSource1.DataSource = GetType(HR.TblJobDescription)
        '
        'TblJobCategoryBindingSource
        '
        Me.TblJobCategoryBindingSource.DataSource = GetType(HR.TblJobCategory)
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'TblRequiredHoursForJobBindingSource
        '
        Me.TblRequiredHoursForJobBindingSource.DataSource = GetType(HR.TblRequiredHoursForJob)
        '
        'TblJobDescriptionDataGridView
        '
        Me.TblJobDescriptionDataGridView.AllowUserToAddRows = False
        Me.TblJobDescriptionDataGridView.AllowUserToDeleteRows = False
        Me.TblJobDescriptionDataGridView.AutoGenerateColumns = False
        Me.TblJobDescriptionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblJobDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblJobDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblJobDescriptionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11})
        Me.TblJobDescriptionDataGridView.DataSource = Me.TblJobDescriptionBindingSource
        Me.TblJobDescriptionDataGridView.Location = New System.Drawing.Point(253, 120)
        Me.TblJobDescriptionDataGridView.Name = "TblJobDescriptionDataGridView"
        Me.TblJobDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblJobDescriptionDataGridView.Size = New System.Drawing.Size(944, 562)
        Me.TblJobDescriptionDataGridView.TabIndex = 56
        '
        'check
        '
        Me.check.HeaderText = ""
        Me.check.Name = "check"
        Me.check.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "JobNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "JobNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ArabicName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ArabicName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SupervisorId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.TblJobDescriptionBindingSource1
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Supervisor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "Id"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "JobCategoryId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.TblJobCategoryBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Id"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ScheduleDepId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.TblDepartmentBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Schedule Dep"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Id"
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RequiredHoursForJobId"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.TblRequiredHoursForJobBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "hoursNumber"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Required Hours"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "Id"
        Me.DataGridViewTextBoxColumn11.Width = 120
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1098, 36)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 47)
        Me.BtnSave.TabIndex = 67
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1170, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "X"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(0, 66)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(246, 23)
        Me.SearchTextBox.TabIndex = 69
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(344, 94)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(97, 23)
        Me.JobNumberTextBox.TabIndex = 70
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(446, 94)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(207, 23)
        Me.NameTextBox.TabIndex = 71
        '
        'ArabicNameTextBox
        '
        Me.ArabicNameTextBox.Location = New System.Drawing.Point(656, 94)
        Me.ArabicNameTextBox.Name = "ArabicNameTextBox"
        Me.ArabicNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ArabicNameTextBox.TabIndex = 72
        '
        'SupervidorIdComboBox
        '
        Me.SupervidorIdComboBox.DataSource = Me.TblJobDescriptionBindingSource2
        Me.SupervidorIdComboBox.DisplayMember = "Name"
        Me.SupervidorIdComboBox.FormattingEnabled = True
        Me.SupervidorIdComboBox.Location = New System.Drawing.Point(762, 93)
        Me.SupervidorIdComboBox.Name = "SupervidorIdComboBox"
        Me.SupervidorIdComboBox.Size = New System.Drawing.Size(91, 24)
        Me.SupervidorIdComboBox.TabIndex = 73
        Me.SupervidorIdComboBox.ValueMember = "Id"
        '
        'TblJobDescriptionBindingSource2
        '
        Me.TblJobDescriptionBindingSource2.DataSource = GetType(HR.TblJobDescription)
        '
        'CatIdComboBox
        '
        Me.CatIdComboBox.DataSource = Me.TblJobCategoryBindingSource1
        Me.CatIdComboBox.DisplayMember = "Name"
        Me.CatIdComboBox.FormattingEnabled = True
        Me.CatIdComboBox.Location = New System.Drawing.Point(856, 93)
        Me.CatIdComboBox.Name = "CatIdComboBox"
        Me.CatIdComboBox.Size = New System.Drawing.Size(100, 24)
        Me.CatIdComboBox.TabIndex = 74
        Me.CatIdComboBox.ValueMember = "Id"
        '
        'TblJobCategoryBindingSource1
        '
        Me.TblJobCategoryBindingSource1.DataSource = GetType(HR.TblJobCategory)
        '
        'ScheduleIdComboBox
        '
        Me.ScheduleIdComboBox.DataSource = Me.TblDepartmentBindingSource1
        Me.ScheduleIdComboBox.DisplayMember = "Name"
        Me.ScheduleIdComboBox.FormattingEnabled = True
        Me.ScheduleIdComboBox.Location = New System.Drawing.Point(957, 93)
        Me.ScheduleIdComboBox.Name = "ScheduleIdComboBox"
        Me.ScheduleIdComboBox.Size = New System.Drawing.Size(118, 24)
        Me.ScheduleIdComboBox.TabIndex = 75
        Me.ScheduleIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentBindingSource1
        '
        Me.TblDepartmentBindingSource1.DataSource = GetType(HR.TblDepartment)
        '
        'ReqHrsIdComboBox
        '
        Me.ReqHrsIdComboBox.DataSource = Me.TblRequiredHoursForJobBindingSource1
        Me.ReqHrsIdComboBox.DisplayMember = "Description"
        Me.ReqHrsIdComboBox.FormattingEnabled = True
        Me.ReqHrsIdComboBox.Location = New System.Drawing.Point(1078, 93)
        Me.ReqHrsIdComboBox.Name = "ReqHrsIdComboBox"
        Me.ReqHrsIdComboBox.Size = New System.Drawing.Size(116, 24)
        Me.ReqHrsIdComboBox.TabIndex = 76
        Me.ReqHrsIdComboBox.ValueMember = "Id"
        '
        'TblRequiredHoursForJobBindingSource1
        '
        Me.TblRequiredHoursForJobBindingSource1.DataSource = GetType(HR.TblRequiredHoursForJob)
        '
        'FrmJobsPerDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReqHrsIdComboBox)
        Me.Controls.Add(Me.ScheduleIdComboBox)
        Me.Controls.Add(Me.CatIdComboBox)
        Me.Controls.Add(Me.SupervidorIdComboBox)
        Me.Controls.Add(Me.ArabicNameTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.JobNumberTextBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DepartmentTreeView)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.TblJobDescriptionDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmJobsPerDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredHoursForJobBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents DepartmentTreeView As System.Windows.Forms.TreeView
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobDescriptionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRequiredHoursForJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobDescriptionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents JobNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArabicNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupervidorIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobDescriptionBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CatIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScheduleIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDepartmentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReqHrsIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblRequiredHoursForJobBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobCategoryBindingSource1 As System.Windows.Forms.BindingSource
End Class
