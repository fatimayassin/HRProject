<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeList
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
        Me.Filter_ApplicantEmployeeJobResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Filter_ApplicantEmployeeJobResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateFromTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateToTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DepTextBox = New System.Windows.Forms.TextBox()
        Me.JobNameTextBox = New System.Windows.Forms.TextBox()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.InCompanytraineeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        CType(Me.Filter_ApplicantEmployeeJobResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_ApplicantEmployeeJobResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.lblText.ForeColor = System.Drawing.Color.Transparent
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(1331, 39)
        Me.lblText.TabIndex = 55
        Me.lblText.Text = "Employee List"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Name = "Filter_ApplicantEmployeeJobResultDataGridView"
        Me.Filter_ApplicantEmployeeJobResultDataGridView.ReadOnly = True
        Me.Filter_ApplicantEmployeeJobResultDataGridView.RowTemplate.Height = 32
        Me.Filter_ApplicantEmployeeJobResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_ApplicantEmployeeJobResultDataGridView.Size = New System.Drawing.Size(1331, 594)
        Me.Filter_ApplicantEmployeeJobResultDataGridView.TabIndex = 57
        '
        'Filter_ApplicantEmployeeJobResultBindingSource
        '
        Me.Filter_ApplicantEmployeeJobResultBindingSource.DataSource = GetType(HR.Filter_ApplicantEmployeeJobResult)
        '
        'DateFromTimePicker
        '
        Me.DateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFromTimePicker.Location = New System.Drawing.Point(816, 3)
        Me.DateFromTimePicker.Name = "DateFromTimePicker"
        Me.DateFromTimePicker.Size = New System.Drawing.Size(91, 23)
        Me.DateFromTimePicker.TabIndex = 70
        '
        'DateToTimePicker
        '
        Me.DateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateToTimePicker.Location = New System.Drawing.Point(816, 31)
        Me.DateToTimePicker.Name = "DateToTimePicker"
        Me.DateToTimePicker.Size = New System.Drawing.Size(91, 23)
        Me.DateToTimePicker.TabIndex = 69
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(193, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(265, 23)
        Me.NameTextBox.TabIndex = 71
        '
        'DepTextBox
        '
        Me.DepTextBox.Location = New System.Drawing.Point(464, 3)
        Me.DepTextBox.Name = "DepTextBox"
        Me.DepTextBox.Size = New System.Drawing.Size(135, 23)
        Me.DepTextBox.TabIndex = 72
        '
        'JobNameTextBox
        '
        Me.JobNameTextBox.Location = New System.Drawing.Point(613, 3)
        Me.JobNameTextBox.Name = "JobNameTextBox"
        Me.JobNameTextBox.Size = New System.Drawing.Size(94, 23)
        Me.JobNameTextBox.TabIndex = 73
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(713, 3)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(97, 23)
        Me.JobNumberTextBox.TabIndex = 74
        '
        'InCompanytraineeCheckBox
        '
        Me.InCompanytraineeCheckBox.AutoSize = True
        Me.InCompanytraineeCheckBox.Checked = True
        Me.InCompanytraineeCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.InCompanytraineeCheckBox.Location = New System.Drawing.Point(1012, 3)
        Me.InCompanytraineeCheckBox.Name = "InCompanytraineeCheckBox"
        Me.InCompanytraineeCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.InCompanytraineeCheckBox.TabIndex = 75
        Me.InCompanytraineeCheckBox.ThreeState = True
        Me.InCompanytraineeCheckBox.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Vacation"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.AddVacations8
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 70
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Holiday"
        Me.DataGridViewImageColumn2.Image = Global.HR.My.Resources.Resources.AddHolidays8
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 70
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "PA"
        Me.DataGridViewImageColumn3.Image = Global.HR.My.Resources.Resources.PAIcon7
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Width = 50
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImage = Global.HR.My.Resources.Resources.PrintIcon8
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(1400, 53)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(51, 47)
        Me.BtnPrint.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.BtnPrint, "Print")
        Me.BtnPrint.UseCompatibleTextRendering = True
        Me.BtnPrint.UseMnemonic = False
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.BackgroundImage = Global.HR.My.Resources.Resources.PrintIcon8
        Me.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReport.FlatAppearance.BorderSize = 0
        Me.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReport.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.Location = New System.Drawing.Point(0, 0)
        Me.BtnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(52, 38)
        Me.BtnReport.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.BtnReport, "Print")
        Me.BtnReport.UseCompatibleTextRendering = True
        Me.BtnReport.UseMnemonic = False
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1302, 6)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 87
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Count"
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.Location = New System.Drawing.Point(913, 3)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(93, 23)
        Me.NationalityTextBox.TabIndex = 81
        '
        'PINTextBox
        '
        Me.PINTextBox.Location = New System.Drawing.Point(92, 3)
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.Size = New System.Drawing.Size(95, 23)
        Me.PINTextBox.TabIndex = 82
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.59686!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.40314!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DepTextBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.JobNameTextBox, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.JobNumberTextBox, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateFromTimePicker, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateToTimePicker, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NationalityTextBox, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InCompanytraineeCheckBox, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PINTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1331, 55)
        Me.TableLayoutPanel1.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 55)
        Me.Panel1.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Filter_ApplicantEmployeeJobResultDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1331, 594)
        Me.Panel2.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 688)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1331, 27)
        Me.Panel3.TabIndex = 86
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
        Me.InCompanyTrainer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InCompanyTrainer.HeaderText = "In Company Trainer"
        Me.InCompanyTrainer.Name = "InCompanyTrainer"
        Me.InCompanyTrainer.ReadOnly = True
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
        Me.PA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PA.HeaderText = "PA"
        Me.PA.Image = Global.HR.My.Resources.Resources.PAIcon7
        Me.PA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PA.Name = "PA"
        Me.PA.ReadOnly = True
        '
        'FrmEmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1331, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmEmployeeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Filter_ApplicantEmployeeJobResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_ApplicantEmployeeJobResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents Filter_ApplicantEmployeeJobResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Filter_ApplicantEmployeeJobResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DateFromTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateToTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InCompanytraineeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnReport As Button
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents PINTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
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
