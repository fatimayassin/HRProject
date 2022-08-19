<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofPAforTrainee
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Filter_ListOfPAforTraineeResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nationality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mohafaza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kadaa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Filter_ListOfPAforTraineeResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ApplicantNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeComboBox = New System.Windows.Forms.ComboBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.DepNameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Filter_ListOfPAforTraineeResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_ListOfPAforTraineeResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblText.Size = New System.Drawing.Size(1312, 32)
        Me.lblText.TabIndex = 49
        Me.lblText.Text = "List PA For Trainee"
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
        Me.lblClose.Location = New System.Drawing.Point(1283, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'Filter_ListOfPAforTraineeResultDataGridView
        '
        Me.Filter_ListOfPAforTraineeResultDataGridView.AllowUserToAddRows = False
        Me.Filter_ListOfPAforTraineeResultDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Filter_ListOfPAforTraineeResultDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Filter_ListOfPAforTraineeResultDataGridView.AutoGenerateColumns = False
        Me.Filter_ListOfPAforTraineeResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Filter_ListOfPAforTraineeResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Filter_ListOfPAforTraineeResultDataGridView.ColumnHeadersHeight = 32
        Me.Filter_ListOfPAforTraineeResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Filter_ListOfPAforTraineeResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DepName, Me.DataGridViewTextBoxColumn3, Me.Gender, Me.MaritalStatus, Me.Age, Me.Nationality, Me.Mohafaza, Me.Kadaa, Me.Country, Me.Grade})
        Me.Filter_ListOfPAforTraineeResultDataGridView.DataSource = Me.Filter_ListOfPAforTraineeResultBindingSource
        Me.Filter_ListOfPAforTraineeResultDataGridView.Location = New System.Drawing.Point(0, 93)
        Me.Filter_ListOfPAforTraineeResultDataGridView.Name = "Filter_ListOfPAforTraineeResultDataGridView"
        Me.Filter_ListOfPAforTraineeResultDataGridView.ReadOnly = True
        Me.Filter_ListOfPAforTraineeResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_ListOfPAforTraineeResultDataGridView.Size = New System.Drawing.Size(1312, 469)
        Me.Filter_ListOfPAforTraineeResultDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ApplicantNumber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Applicant Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DepName
        '
        Me.DepName.DataPropertyName = "DepName"
        Me.DepName.HeaderText = "DepName"
        Me.DepName.Name = "DepName"
        Me.DepName.ReadOnly = True
        Me.DepName.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Start Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'MaritalStatus
        '
        Me.MaritalStatus.DataPropertyName = "MaritalStatus"
        Me.MaritalStatus.HeaderText = "MaritalStatus"
        Me.MaritalStatus.Name = "MaritalStatus"
        Me.MaritalStatus.ReadOnly = True
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Nationality
        '
        Me.Nationality.DataPropertyName = "Nationality"
        Me.Nationality.HeaderText = "Nationality"
        Me.Nationality.Name = "Nationality"
        Me.Nationality.ReadOnly = True
        '
        'Mohafaza
        '
        Me.Mohafaza.DataPropertyName = "Mohafaza"
        Me.Mohafaza.HeaderText = "Province"
        Me.Mohafaza.Name = "Mohafaza"
        Me.Mohafaza.ReadOnly = True
        '
        'Kadaa
        '
        Me.Kadaa.DataPropertyName = "Kadaa"
        Me.Kadaa.HeaderText = "District"
        Me.Kadaa.Name = "Kadaa"
        Me.Kadaa.ReadOnly = True
        '
        'Country
        '
        Me.Country.DataPropertyName = "Country"
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        Me.Country.ReadOnly = True
        '
        'Grade
        '
        Me.Grade.HeaderText = "PA"
        Me.Grade.Image = Global.HR.My.Resources.Resources.PAIcon7
        Me.Grade.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Width = 75
        '
        'Filter_ListOfPAforTraineeResultBindingSource
        '
        Me.Filter_ListOfPAforTraineeResultBindingSource.DataSource = GetType(HR.Filter_ListOfPAforTraineeResult)
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDateTimePicker.Location = New System.Drawing.Point(446, 35)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(87, 23)
        Me.FromDateTimePicker.TabIndex = 1
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ToDateTimePicker.Location = New System.Drawing.Point(446, 64)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(87, 23)
        Me.ToDateTimePicker.TabIndex = 2
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(47, 63)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(148, 23)
        Me.FullNameTextBox.TabIndex = 0
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImage = Global.HR.My.Resources.Resources.PrintIcon8
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(1255, 35)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(51, 47)
        Me.BtnPrint.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.BtnPrint, "Print")
        Me.BtnPrint.UseCompatibleTextRendering = True
        Me.BtnPrint.UseMnemonic = False
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "PA"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.PAIcon4
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "count"
        '
        'ApplicantNumberTextBox
        '
        Me.ApplicantNumberTextBox.Location = New System.Drawing.Point(201, 63)
        Me.ApplicantNumberTextBox.Name = "ApplicantNumberTextBox"
        Me.ApplicantNumberTextBox.Size = New System.Drawing.Size(114, 23)
        Me.ApplicantNumberTextBox.TabIndex = 79
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widow"})
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(639, 63)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(97, 24)
        Me.MaritalStatusComboBox.TabIndex = 80
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(539, 63)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(94, 24)
        Me.GenderComboBox.TabIndex = 81
        '
        'AgeComboBox
        '
        Me.AgeComboBox.FormattingEnabled = True
        Me.AgeComboBox.Items.AddRange(New Object() {"17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41"})
        Me.AgeComboBox.Location = New System.Drawing.Point(742, 63)
        Me.AgeComboBox.Name = "AgeComboBox"
        Me.AgeComboBox.Size = New System.Drawing.Size(96, 24)
        Me.AgeComboBox.TabIndex = 82
        Me.AgeComboBox.Visible = False
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.Location = New System.Drawing.Point(844, 64)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(94, 23)
        Me.NationalityTextBox.TabIndex = 83
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.Location = New System.Drawing.Point(944, 64)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(94, 23)
        Me.ProvinceTextBox.TabIndex = 84
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Location = New System.Drawing.Point(1044, 64)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(94, 23)
        Me.DistrictTextBox.TabIndex = 85
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(1144, 64)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(90, 23)
        Me.CountryTextBox.TabIndex = 86
        '
        'DepNameTextBox
        '
        Me.DepNameTextBox.Location = New System.Drawing.Point(321, 64)
        Me.DepNameTextBox.Name = "DepNameTextBox"
        Me.DepNameTextBox.Size = New System.Drawing.Size(119, 23)
        Me.DepNameTextBox.TabIndex = 87
        '
        'FrmListofPAforTrainee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1312, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.DepNameTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.DistrictTextBox)
        Me.Controls.Add(Me.ProvinceTextBox)
        Me.Controls.Add(Me.NationalityTextBox)
        Me.Controls.Add(Me.AgeComboBox)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.MaritalStatusComboBox)
        Me.Controls.Add(Me.ApplicantNumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Filter_ListOfPAforTraineeResultDataGridView)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmListofPAforTrainee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Filter_ListOfPAforTraineeResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_ListOfPAforTraineeResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents Filter_ListOfPAforTraineeResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Filter_ListOfPAforTraineeResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents ApplicantNumberTextBox As TextBox
    Friend WithEvents MaritalStatusComboBox As ComboBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents AgeComboBox As ComboBox
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DepName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatus As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Nationality As DataGridViewTextBoxColumn
    Friend WithEvents Mohafaza As DataGridViewTextBoxColumn
    Friend WithEvents Kadaa As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewImageColumn
    Friend WithEvents DepNameTextBox As TextBox
End Class
