<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssigndDepsToJob
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobDescriptionDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblJobDescriptionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRequiredHoursForJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobDescriptionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRequiredHoursForJobBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReqHrsIdComboBox = New System.Windows.Forms.ComboBox()
        Me.ScheduleIdComboBox = New System.Windows.Forms.ComboBox()
        Me.CatIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervidorIdComboBox = New System.Windows.Forms.ComboBox()
        Me.ArabicNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AddDepartments = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PA = New System.Windows.Forms.DataGridViewImageColumn()
        Me.A = New System.Windows.Forms.DataGridViewImageColumn()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredHoursForJobBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblText.Size = New System.Drawing.Size(1076, 29)
        Me.lblText.TabIndex = 55
        Me.lblText.Text = "Jobs"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1048, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Label1, "Close")
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'TblJobDescriptionDataGridView
        '
        Me.TblJobDescriptionDataGridView.AllowUserToAddRows = False
        Me.TblJobDescriptionDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TblJobDescriptionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblJobDescriptionDataGridView.AutoGenerateColumns = False
        Me.TblJobDescriptionDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblJobDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblJobDescriptionDataGridView.ColumnHeadersHeight = 32
        Me.TblJobDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblJobDescriptionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.AddDepartments, Me.PA, Me.A, Me.check})
        Me.TblJobDescriptionDataGridView.DataSource = Me.TblJobDescriptionBindingSource
        Me.TblJobDescriptionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblJobDescriptionDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblJobDescriptionDataGridView.Name = "TblJobDescriptionDataGridView"
        Me.TblJobDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblJobDescriptionDataGridView.Size = New System.Drawing.Size(1076, 573)
        Me.TblJobDescriptionDataGridView.TabIndex = 7
        '
        'TblJobDescriptionBindingSource1
        '
        Me.TblJobDescriptionBindingSource1.DataSource = GetType(HR.TblJobDescription)
        '
        'TblJobCategoryBindingSource
        '
        Me.TblJobCategoryBindingSource.DataSource = GetType(HR.TblJobCategory)
        '
        'TblRequiredHoursForJobBindingSource
        '
        Me.TblRequiredHoursForJobBindingSource.DataSource = GetType(HR.TblRequiredHoursForJob)
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'TblJobDescriptionBindingSource2
        '
        Me.TblJobDescriptionBindingSource2.DataSource = GetType(HR.TblJobDescription)
        '
        'TblDepartmentBindingSource1
        '
        Me.TblDepartmentBindingSource1.DataSource = GetType(HR.TblDepartment)
        '
        'TblRequiredHoursForJobBindingSource1
        '
        Me.TblRequiredHoursForJobBindingSource1.DataSource = GetType(HR.TblRequiredHoursForJob)
        '
        'ReqHrsIdComboBox
        '
        Me.ReqHrsIdComboBox.DataSource = Me.TblRequiredHoursForJobBindingSource1
        Me.ReqHrsIdComboBox.DisplayMember = "Description"
        Me.ReqHrsIdComboBox.FormattingEnabled = True
        Me.ReqHrsIdComboBox.Location = New System.Drawing.Point(679, 5)
        Me.ReqHrsIdComboBox.Name = "ReqHrsIdComboBox"
        Me.ReqHrsIdComboBox.Size = New System.Drawing.Size(113, 23)
        Me.ReqHrsIdComboBox.TabIndex = 6
        Me.ReqHrsIdComboBox.ValueMember = "Id"
        '
        'ScheduleIdComboBox
        '
        Me.ScheduleIdComboBox.DataSource = Me.TblDepartmentBindingSource1
        Me.ScheduleIdComboBox.DisplayMember = "Name"
        Me.ScheduleIdComboBox.FormattingEnabled = True
        Me.ScheduleIdComboBox.Location = New System.Drawing.Point(560, 5)
        Me.ScheduleIdComboBox.Name = "ScheduleIdComboBox"
        Me.ScheduleIdComboBox.Size = New System.Drawing.Size(114, 23)
        Me.ScheduleIdComboBox.TabIndex = 5
        Me.ScheduleIdComboBox.ValueMember = "Id"
        '
        'CatIdComboBox
        '
        Me.CatIdComboBox.DataSource = Me.TblJobCategoryBindingSource1
        Me.CatIdComboBox.DisplayMember = "Name"
        Me.CatIdComboBox.FormattingEnabled = True
        Me.CatIdComboBox.Location = New System.Drawing.Point(460, 5)
        Me.CatIdComboBox.Name = "CatIdComboBox"
        Me.CatIdComboBox.Size = New System.Drawing.Size(96, 23)
        Me.CatIdComboBox.TabIndex = 4
        Me.CatIdComboBox.ValueMember = "Id"
        '
        'TblJobCategoryBindingSource1
        '
        Me.TblJobCategoryBindingSource1.DataSource = GetType(HR.TblJobCategory)
        '
        'SupervidorIdComboBox
        '
        Me.SupervidorIdComboBox.DataSource = Me.TblJobDescriptionBindingSource2
        Me.SupervidorIdComboBox.DisplayMember = "Name"
        Me.SupervidorIdComboBox.FormattingEnabled = True
        Me.SupervidorIdComboBox.Location = New System.Drawing.Point(358, 5)
        Me.SupervidorIdComboBox.Name = "SupervidorIdComboBox"
        Me.SupervidorIdComboBox.Size = New System.Drawing.Size(99, 23)
        Me.SupervidorIdComboBox.TabIndex = 3
        Me.SupervidorIdComboBox.ValueMember = "Id"
        '
        'ArabicNameTextBox
        '
        Me.ArabicNameTextBox.Location = New System.Drawing.Point(259, 6)
        Me.ArabicNameTextBox.Name = "ArabicNameTextBox"
        Me.ArabicNameTextBox.Size = New System.Drawing.Size(96, 22)
        Me.ArabicNameTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(145, 6)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(112, 22)
        Me.NameTextBox.TabIndex = 1
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(40, 6)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(103, 22)
        Me.JobNumberTextBox.TabIndex = 0
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
        Me.BtnSave.Location = New System.Drawing.Point(1025, 0)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 636)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 47)
        Me.Panel1.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.JobNumberTextBox)
        Me.Panel2.Controls.Add(Me.NameTextBox)
        Me.Panel2.Controls.Add(Me.ArabicNameTextBox)
        Me.Panel2.Controls.Add(Me.ReqHrsIdComboBox)
        Me.Panel2.Controls.Add(Me.SupervidorIdComboBox)
        Me.Panel2.Controls.Add(Me.ScheduleIdComboBox)
        Me.Panel2.Controls.Add(Me.CatIdComboBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 34)
        Me.Panel2.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TblJobDescriptionDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1076, 573)
        Me.Panel3.TabIndex = 73
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 115
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
        'AddDepartments
        '
        Me.AddDepartments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddDepartments.HeaderText = "Deps"
        Me.AddDepartments.Image = Global.HR.My.Resources.Resources.NewIcon7
        Me.AddDepartments.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.AddDepartments.Name = "AddDepartments"
        '
        'PA
        '
        Me.PA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PA.HeaderText = "PA"
        Me.PA.Image = Global.HR.My.Resources.Resources.PAIcon7
        Me.PA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PA.Name = "PA"
        '
        'A
        '
        Me.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.A.HeaderText = "PA Per Task"
        Me.A.Image = Global.HR.My.Resources.Resources.ExecuteIcon7
        Me.A.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.A.Name = "A"
        '
        'check
        '
        Me.check.HeaderText = "Assign Jobs"
        Me.check.Name = "check"
        Me.check.Width = 80
        '
        'FrmAssigndDepsToJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAssigndDepsToJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredHoursForJobBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobDescriptionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblJobDescriptionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRequiredHoursForJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobDescriptionBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblDepartmentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblRequiredHoursForJobBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReqHrsIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScheduleIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CatIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SupervidorIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArabicNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewComboBoxColumn
    Friend WithEvents AddDepartments As DataGridViewImageColumn
    Friend WithEvents PA As DataGridViewImageColumn
    Friend WithEvents A As DataGridViewImageColumn
    Friend WithEvents check As DataGridViewCheckBoxColumn
End Class
