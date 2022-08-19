<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApplicantIndex
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
        Me.lblT = New System.Windows.Forms.Label()
        Me.Filter_ApplicantIndexResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblCertificateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Filter_ApplicantIndexResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AgeComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.MartialStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.ApplicantNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicantFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.City_TownTextBox = New System.Windows.Forms.TextBox()
        Me.CertificateIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCertificateBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblText = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Filter_ApplicantIndexResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_ApplicantIndexResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblCertificateBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblText.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.Transparent
        Me.lblT.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.White
        Me.lblT.Location = New System.Drawing.Point(522, 3)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(175, 32)
        Me.lblT.TabIndex = 3
        Me.lblT.Text = "Applicant Index"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Filter_ApplicantIndexResultDataGridView
        '
        Me.Filter_ApplicantIndexResultDataGridView.AllowUserToAddRows = False
        Me.Filter_ApplicantIndexResultDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Filter_ApplicantIndexResultDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Filter_ApplicantIndexResultDataGridView.AutoGenerateColumns = False
        Me.Filter_ApplicantIndexResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Filter_ApplicantIndexResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Filter_ApplicantIndexResultDataGridView.ColumnHeadersHeight = 32
        Me.Filter_ApplicantIndexResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Filter_ApplicantIndexResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.FullName, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DateOfBirth, Me.DataGridViewTextBoxColumn5, Me.Mobile, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Filter_ApplicantIndexResultDataGridView.DataSource = Me.Filter_ApplicantIndexResultBindingSource
        Me.Filter_ApplicantIndexResultDataGridView.Location = New System.Drawing.Point(0, 6)
        Me.Filter_ApplicantIndexResultDataGridView.Name = "Filter_ApplicantIndexResultDataGridView"
        Me.Filter_ApplicantIndexResultDataGridView.ReadOnly = True
        Me.Filter_ApplicantIndexResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_ApplicantIndexResultDataGridView.Size = New System.Drawing.Size(1279, 523)
        Me.Filter_ApplicantIndexResultDataGridView.TabIndex = 1
        '
        'TblCertificateBindingSource
        '
        Me.TblCertificateBindingSource.DataSource = GetType(HR.TblCertificate)
        '
        'Filter_ApplicantIndexResultBindingSource
        '
        Me.Filter_ApplicantIndexResultBindingSource.DataSource = GetType(HR.Filter_ApplicantIndexResult)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AgeComboBox, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GenderComboBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MartialStatusComboBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ApplicantNumberTextBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ApplicantFullNameTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NationalityTextBox, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictTextBox, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.City_TownTextBox, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CertificateIdComboBox, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UniversityTextBox, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MajorTextBox, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MobileTextBox, 6, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1241, 48)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'AgeComboBox
        '
        Me.AgeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgeComboBox.FormattingEnabled = True
        Me.AgeComboBox.Items.AddRange(New Object() {"17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41"})
        Me.AgeComboBox.Location = New System.Drawing.Point(503, 3)
        Me.AgeComboBox.Name = "AgeComboBox"
        Me.AgeComboBox.Size = New System.Drawing.Size(74, 24)
        Me.AgeComboBox.TabIndex = 8
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(323, 3)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(74, 24)
        Me.GenderComboBox.TabIndex = 2
        '
        'MartialStatusComboBox
        '
        Me.MartialStatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MartialStatusComboBox.FormattingEnabled = True
        Me.MartialStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        Me.MartialStatusComboBox.Location = New System.Drawing.Point(403, 3)
        Me.MartialStatusComboBox.Name = "MartialStatusComboBox"
        Me.MartialStatusComboBox.Size = New System.Drawing.Size(94, 24)
        Me.MartialStatusComboBox.TabIndex = 3
        '
        'ApplicantNumberTextBox
        '
        Me.ApplicantNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApplicantNumberTextBox.Location = New System.Drawing.Point(3, 3)
        Me.ApplicantNumberTextBox.Name = "ApplicantNumberTextBox"
        Me.ApplicantNumberTextBox.Size = New System.Drawing.Size(94, 23)
        Me.ApplicantNumberTextBox.TabIndex = 0
        '
        'ApplicantFullNameTextBox
        '
        Me.ApplicantFullNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApplicantFullNameTextBox.Location = New System.Drawing.Point(103, 3)
        Me.ApplicantFullNameTextBox.Name = "ApplicantFullNameTextBox"
        Me.ApplicantFullNameTextBox.Size = New System.Drawing.Size(214, 23)
        Me.ApplicantFullNameTextBox.TabIndex = 1
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NationalityTextBox.Location = New System.Drawing.Point(583, 3)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(74, 23)
        Me.NationalityTextBox.TabIndex = 4
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistrictTextBox.Location = New System.Drawing.Point(1143, 3)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(95, 23)
        Me.DistrictTextBox.TabIndex = 9
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.City_TownTextBox.Location = New System.Drawing.Point(1043, 3)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(94, 23)
        Me.City_TownTextBox.TabIndex = 8
        '
        'CertificateIdComboBox
        '
        Me.CertificateIdComboBox.DataSource = Me.TblCertificateBindingSource1
        Me.CertificateIdComboBox.DisplayMember = "Name"
        Me.CertificateIdComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CertificateIdComboBox.FormattingEnabled = True
        Me.CertificateIdComboBox.Location = New System.Drawing.Point(943, 3)
        Me.CertificateIdComboBox.Name = "CertificateIdComboBox"
        Me.CertificateIdComboBox.Size = New System.Drawing.Size(94, 24)
        Me.CertificateIdComboBox.TabIndex = 7
        Me.CertificateIdComboBox.ValueMember = "Id"
        '
        'TblCertificateBindingSource1
        '
        Me.TblCertificateBindingSource1.DataSource = GetType(HR.TblCertificate)
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UniversityTextBox.Location = New System.Drawing.Point(843, 3)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(94, 23)
        Me.UniversityTextBox.TabIndex = 6
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MajorTextBox.Location = New System.Drawing.Point(743, 3)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(94, 23)
        Me.MajorTextBox.TabIndex = 5
        '
        'MobileTextBox
        '
        Me.MobileTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MobileTextBox.Location = New System.Drawing.Point(663, 3)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(74, 23)
        Me.MobileTextBox.TabIndex = 10
        '
        'Timer1
        '
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImage = Global.HR.My.Resources.Resources.PrintIcon8
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(0, 0)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(52, 38)
        Me.BtnPrint.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnPrint, "Print")
        Me.BtnPrint.UseCompatibleTextRendering = True
        Me.BtnPrint.UseMnemonic = False
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Controls.Add(Me.lblClose)
        Me.lblText.Controls.Add(Me.lblT)
        Me.lblText.Controls.Add(Me.BtnPrint)
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(1279, 38)
        Me.lblText.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1279, 48)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Filter_ApplicantIndexResultDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1279, 555)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "count"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1250, 7)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 9
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ApplicantNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "#"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "FullName"
        Me.FullName.HeaderText = "FullName"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        Me.FullName.Width = 218
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MaritalStatus"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Marital Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DateOfBirth
        '
        Me.DateOfBirth.DataPropertyName = "DateOfBirth"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DateOfBirth.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateOfBirth.HeaderText = "DateOfBirth"
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.ReadOnly = True
        Me.DateOfBirth.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nationality"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nationality"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Mobile
        '
        Me.Mobile.DataPropertyName = "Mobile"
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.ReadOnly = True
        Me.Mobile.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Major"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Major"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "University"
        Me.DataGridViewTextBoxColumn10.HeaderText = "University"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CertificateId"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.TblCertificateBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Certificate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "Id"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "City_Town"
        Me.DataGridViewTextBoxColumn13.HeaderText = "City_Town"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "District"
        Me.DataGridViewTextBoxColumn14.HeaderText = "District"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'FrmApplicantIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1279, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmApplicantIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Filter_ApplicantIndexResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_ApplicantIndexResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TblCertificateBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblText.ResumeLayout(False)
        Me.lblText.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents Filter_ApplicantIndexResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Filter_ApplicantIndexResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ApplicantNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApplicantFullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NationalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MajorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UniversityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistrictTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CertificateIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblCertificateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCertificateBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblText As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AgeComboBox As ComboBox
    Friend WithEvents MartialStatusComboBox As ComboBox
    Friend WithEvents lblClose As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Mobile As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
