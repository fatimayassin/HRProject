<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnEmployeeList
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
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.JobNameTextBox = New System.Windows.Forms.TextBox()
        Me.DepTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DateFromTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateToTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InCompanytraineeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Filter_ApplicantEmployeeJobResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Filter_ApplicantEmployeeJobResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Attachmment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageCol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nationality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InCompanyTrainer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddVacation = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Holiday = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PA = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.Filter_ApplicantEmployeeJobResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_ApplicantEmployeeJobResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblText.Size = New System.Drawing.Size(1333, 39)
        Me.lblText.TabIndex = 78
        Me.lblText.Text = "Un-Employee List"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PINTextBox
        '
        Me.PINTextBox.Location = New System.Drawing.Point(94, 78)
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.Size = New System.Drawing.Size(95, 23)
        Me.PINTextBox.TabIndex = 90
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.Location = New System.Drawing.Point(920, 80)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(94, 23)
        Me.NationalityTextBox.TabIndex = 89
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(722, 78)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(95, 23)
        Me.JobNumberTextBox.TabIndex = 88
        '
        'JobNameTextBox
        '
        Me.JobNameTextBox.Location = New System.Drawing.Point(613, 78)
        Me.JobNameTextBox.Name = "JobNameTextBox"
        Me.JobNameTextBox.Size = New System.Drawing.Size(103, 23)
        Me.JobNameTextBox.TabIndex = 87
        '
        'DepTextBox
        '
        Me.DepTextBox.Location = New System.Drawing.Point(465, 78)
        Me.DepTextBox.Name = "DepTextBox"
        Me.DepTextBox.Size = New System.Drawing.Size(142, 23)
        Me.DepTextBox.TabIndex = 86
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(195, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(264, 23)
        Me.NameTextBox.TabIndex = 85
        '
        'DateFromTimePicker
        '
        Me.DateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFromTimePicker.Location = New System.Drawing.Point(819, 51)
        Me.DateFromTimePicker.Name = "DateFromTimePicker"
        Me.DateFromTimePicker.Size = New System.Drawing.Size(95, 23)
        Me.DateFromTimePicker.TabIndex = 84
        '
        'DateToTimePicker
        '
        Me.DateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateToTimePicker.Location = New System.Drawing.Point(819, 80)
        Me.DateToTimePicker.Name = "DateToTimePicker"
        Me.DateToTimePicker.Size = New System.Drawing.Size(95, 23)
        Me.DateToTimePicker.TabIndex = 83
        '
        'InCompanytraineeCheckBox
        '
        Me.InCompanytraineeCheckBox.AutoSize = True
        Me.InCompanytraineeCheckBox.Checked = True
        Me.InCompanytraineeCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.InCompanytraineeCheckBox.Location = New System.Drawing.Point(1057, 87)
        Me.InCompanytraineeCheckBox.Name = "InCompanytraineeCheckBox"
        Me.InCompanytraineeCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.InCompanytraineeCheckBox.TabIndex = 91
        Me.InCompanytraineeCheckBox.ThreeState = True
        Me.InCompanytraineeCheckBox.UseVisualStyleBackColor = True
        '
        'Filter_ApplicantEmployeeJobResultBindingSource
        '
        Me.Filter_ApplicantEmployeeJobResultBindingSource.DataSource = GetType(HR.Filter_ApplicantEmployeeJobResult)
        '
        'Timer1
        '
        '
        'Filter_ApplicantEmployeeJobResultDataGridView
        '
        Me.Filter_ApplicantEmployeeJobResultDataGridView.AllowUserToAddRows = False
        Me.Filter_ApplicantEmployeeJobResultDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Filter_ApplicantEmployeeJobResultDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Filter_ApplicantEmployeeJobResultDataGridView.AutoGenerateColumns = False
        Me.Filter_ApplicantEmployeeJobResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Filter_ApplicantEmployeeJobResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Filter_ApplicantEmployeeJobResultDataGridView.ColumnHeadersHeight = 32
        Me.Filter_ApplicantEmployeeJobResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Attachmment, Me.ImageCol, Me.PIN, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Nationality, Me.InCompanyTrainer, Me.AddVacation, Me.Holiday, Me.PA})
        Me.Filter_ApplicantEmployeeJobResultDataGridView.DataSource = Me.Filter_ApplicantEmployeeJobResultBindingSource
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Location = New System.Drawing.Point(2, 109)
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Name = "Filter_ApplicantEmployeeJobResultDataGridView"
        Me.Filter_ApplicantEmployeeJobResultDataGridView.ReadOnly = True
        Me.Filter_ApplicantEmployeeJobResultDataGridView.RowTemplate.Height = 32
        Me.Filter_ApplicantEmployeeJobResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Size = New System.Drawing.Size(1331, 579)
        Me.Filter_ApplicantEmployeeJobResultDataGridView.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Count"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1304, 6)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 94
        Me.lblClose.Text = "X"
        '
        'Attachmment
        '
        Me.Attachmment.DataPropertyName = "Attachmment"
        Me.Attachmment.HeaderText = "Attachmment"
        Me.Attachmment.Name = "Attachmment"
        Me.Attachmment.ReadOnly = True
        Me.Attachmment.Visible = False
        '
        'ImageCol
        '
        Me.ImageCol.HeaderText = ""
        Me.ImageCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ImageCol.Name = "ImageCol"
        Me.ImageCol.ReadOnly = True
        Me.ImageCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImageCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ImageCol.Width = 50
        '
        'PIN
        '
        Me.PIN.DataPropertyName = "PIN"
        Me.PIN.HeaderText = "PIN"
        Me.PIN.Name = "PIN"
        Me.PIN.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FullName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 270
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DepName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DepName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "JobName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "JobName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "JobNumber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "JobNumber"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Employ. Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Nationality
        '
        Me.Nationality.DataPropertyName = "Nationality"
        Me.Nationality.HeaderText = "Nationality"
        Me.Nationality.Name = "Nationality"
        Me.Nationality.ReadOnly = True
        Me.Nationality.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'InCompanyTrainer
        '
        Me.InCompanyTrainer.HeaderText = "In Company Trainer"
        Me.InCompanyTrainer.Name = "InCompanyTrainer"
        Me.InCompanyTrainer.ReadOnly = True
        Me.InCompanyTrainer.Width = 130
        '
        'AddVacation
        '
        Me.AddVacation.HeaderText = "Vacation"
        Me.AddVacation.Image = Global.HR.My.Resources.Resources.AddVacations8
        Me.AddVacation.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.AddVacation.Name = "AddVacation"
        Me.AddVacation.ReadOnly = True
        Me.AddVacation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddVacation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AddVacation.Width = 70
        '
        'Holiday
        '
        Me.Holiday.HeaderText = "Holiday"
        Me.Holiday.Image = Global.HR.My.Resources.Resources.AddHolidays8
        Me.Holiday.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Holiday.Name = "Holiday"
        Me.Holiday.ReadOnly = True
        Me.Holiday.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Holiday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Holiday.Width = 70
        '
        'PA
        '
        Me.PA.HeaderText = "PA"
        Me.PA.Image = Global.HR.My.Resources.Resources.PAIcon7
        Me.PA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PA.Name = "PA"
        Me.PA.ReadOnly = True
        Me.PA.Width = 50
        '
        'FrmUnEmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1333, 717)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Filter_ApplicantEmployeeJobResultDataGridView)
        Me.Controls.Add(Me.InCompanytraineeCheckBox)
        Me.Controls.Add(Me.PINTextBox)
        Me.Controls.Add(Me.NationalityTextBox)
        Me.Controls.Add(Me.JobNumberTextBox)
        Me.Controls.Add(Me.JobNameTextBox)
        Me.Controls.Add(Me.DepTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DateFromTimePicker)
        Me.Controls.Add(Me.DateToTimePicker)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUnEmployeeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUnEmployeeList"
        CType(Me.Filter_ApplicantEmployeeJobResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_ApplicantEmployeeJobResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As Label
    Friend WithEvents PINTextBox As TextBox
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents JobNumberTextBox As TextBox
    Friend WithEvents JobNameTextBox As TextBox
    Friend WithEvents DepTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DateFromTimePicker As DateTimePicker
    Friend WithEvents DateToTimePicker As DateTimePicker
    Friend WithEvents InCompanytraineeCheckBox As CheckBox
    Friend WithEvents Filter_ApplicantEmployeeJobResultBindingSource As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Filter_ApplicantEmployeeJobResultDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents Attachmment As DataGridViewTextBoxColumn
    Friend WithEvents ImageCol As DataGridViewImageColumn
    Friend WithEvents PIN As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Nationality As DataGridViewTextBoxColumn
    Friend WithEvents InCompanyTrainer As DataGridViewCheckBoxColumn
    Friend WithEvents AddVacation As DataGridViewImageColumn
    Friend WithEvents Holiday As DataGridViewImageColumn
    Friend WithEvents PA As DataGridViewImageColumn
End Class
