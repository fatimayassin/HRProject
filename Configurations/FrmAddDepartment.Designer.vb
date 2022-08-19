<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddDepartment
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
        Dim ArabicNameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim CompanyProfileIdLabel As System.Windows.Forms.Label
        Dim DepCategoryIdLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TypeIdLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArabicNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyProfileIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCompanyProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepCategoryIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MakeSatisficationCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ArabicNameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        CompanyProfileIdLabel = New System.Windows.Forms.Label()
        DepCategoryIdLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        TypeIdLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCompanyProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArabicNameLabel
        '
        ArabicNameLabel.AutoSize = True
        ArabicNameLabel.Location = New System.Drawing.Point(26, 137)
        ArabicNameLabel.Name = "ArabicNameLabel"
        ArabicNameLabel.Size = New System.Drawing.Size(87, 16)
        ArabicNameLabel.TabIndex = 36
        ArabicNameLabel.Text = "Arabic Name:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(26, 101)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(46, 16)
        NameLabel.TabIndex = 37
        NameLabel.Text = "Name:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(26, 65)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(41, 16)
        CodeLabel.TabIndex = 38
        CodeLabel.Text = "Code:"
        '
        'CompanyProfileIdLabel
        '
        CompanyProfileIdLabel.AutoSize = True
        CompanyProfileIdLabel.Location = New System.Drawing.Point(26, 173)
        CompanyProfileIdLabel.Name = "CompanyProfileIdLabel"
        CompanyProfileIdLabel.Size = New System.Drawing.Size(69, 16)
        CompanyProfileIdLabel.TabIndex = 39
        CompanyProfileIdLabel.Text = "Company :"
        '
        'DepCategoryIdLabel
        '
        DepCategoryIdLabel.AutoSize = True
        DepCategoryIdLabel.Location = New System.Drawing.Point(26, 210)
        DepCategoryIdLabel.Name = "DepCategoryIdLabel"
        DepCategoryIdLabel.Size = New System.Drawing.Size(59, 16)
        DepCategoryIdLabel.TabIndex = 40
        DepCategoryIdLabel.Text = "Dep Cat:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(26, 284)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(79, 16)
        DescriptionLabel.TabIndex = 41
        DescriptionLabel.Text = "Description:"
        '
        'TypeIdLabel
        '
        TypeIdLabel.AutoSize = True
        TypeIdLabel.Location = New System.Drawing.Point(26, 247)
        TypeIdLabel.Name = "TypeIdLabel"
        TypeIdLabel.Size = New System.Drawing.Size(66, 16)
        TypeIdLabel.TabIndex = 42
        TypeIdLabel.Text = "Dep Type:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.HR.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(402, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(425, 32)
        Me.lblText.TabIndex = 34
        Me.lblText.Text = "Department Info"
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
        Me.lblClose.Location = New System.Drawing.Point(395, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 7
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'ArabicNameTextBox
        '
        Me.ArabicNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentBindingSource, "ArabicName", True))
        Me.ArabicNameTextBox.Location = New System.Drawing.Point(123, 134)
        Me.ArabicNameTextBox.Name = "ArabicNameTextBox"
        Me.ArabicNameTextBox.Size = New System.Drawing.Size(246, 23)
        Me.ArabicNameTextBox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(123, 98)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(246, 23)
        Me.NameTextBox.TabIndex = 0
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentBindingSource, "Code", True))
        Me.CodeTextBox.Enabled = False
        Me.CodeTextBox.Location = New System.Drawing.Point(123, 62)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(246, 23)
        Me.CodeTextBox.TabIndex = 39
        '
        'CompanyProfileIdComboBox
        '
        Me.CompanyProfileIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblDepartmentBindingSource, "CompanyProfileId", True))
        Me.CompanyProfileIdComboBox.DataSource = Me.TblCompanyProfileBindingSource
        Me.CompanyProfileIdComboBox.DisplayMember = "Name"
        Me.CompanyProfileIdComboBox.FormattingEnabled = True
        Me.CompanyProfileIdComboBox.Location = New System.Drawing.Point(123, 170)
        Me.CompanyProfileIdComboBox.Name = "CompanyProfileIdComboBox"
        Me.CompanyProfileIdComboBox.Size = New System.Drawing.Size(246, 24)
        Me.CompanyProfileIdComboBox.TabIndex = 2
        Me.CompanyProfileIdComboBox.ValueMember = "Id"
        '
        'TblCompanyProfileBindingSource
        '
        Me.TblCompanyProfileBindingSource.DataSource = GetType(HR.TblCompanyProfile)
        '
        'DepCategoryIdComboBox
        '
        Me.DepCategoryIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblDepartmentBindingSource, "DepCategoryId", True))
        Me.DepCategoryIdComboBox.DataSource = Me.TblDepartmentCategoryBindingSource
        Me.DepCategoryIdComboBox.DisplayMember = "Name"
        Me.DepCategoryIdComboBox.FormattingEnabled = True
        Me.DepCategoryIdComboBox.Location = New System.Drawing.Point(123, 207)
        Me.DepCategoryIdComboBox.Name = "DepCategoryIdComboBox"
        Me.DepCategoryIdComboBox.Size = New System.Drawing.Size(246, 24)
        Me.DepCategoryIdComboBox.TabIndex = 4
        Me.DepCategoryIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentCategoryBindingSource
        '
        Me.TblDepartmentCategoryBindingSource.DataSource = GetType(HR.TblDepartmentCategory)
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(123, 281)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(246, 68)
        Me.DescriptionTextBox.TabIndex = 42
        '
        'MakeSatisficationCheckBox
        '
        Me.MakeSatisficationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblDepartmentBindingSource, "MakeSatisfication", True))
        Me.MakeSatisficationCheckBox.Location = New System.Drawing.Point(123, 358)
        Me.MakeSatisficationCheckBox.Name = "MakeSatisficationCheckBox"
        Me.MakeSatisficationCheckBox.Size = New System.Drawing.Size(151, 24)
        Me.MakeSatisficationCheckBox.TabIndex = 5
        Me.MakeSatisficationCheckBox.Text = "Make Satisfication"
        Me.MakeSatisficationCheckBox.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(375, 396)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TypeIdComboBox
        '
        Me.TypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblDepartmentBindingSource, "TypeId", True))
        Me.TypeIdComboBox.DataSource = Me.TblDepartmentTypeBindingSource
        Me.TypeIdComboBox.DisplayMember = "Name"
        Me.TypeIdComboBox.FormattingEnabled = True
        Me.TypeIdComboBox.Location = New System.Drawing.Point(123, 244)
        Me.TypeIdComboBox.Name = "TypeIdComboBox"
        Me.TypeIdComboBox.Size = New System.Drawing.Size(246, 24)
        Me.TypeIdComboBox.TabIndex = 43
        Me.TypeIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentTypeBindingSource
        '
        Me.TblDepartmentTypeBindingSource.DataSource = GetType(HR.TblDepartmentType)
        '
        'FrmAddDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 454)
        Me.ControlBox = False
        Me.Controls.Add(TypeIdLabel)
        Me.Controls.Add(Me.TypeIdComboBox)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MakeSatisficationCheckBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(DepCategoryIdLabel)
        Me.Controls.Add(Me.DepCategoryIdComboBox)
        Me.Controls.Add(CompanyProfileIdLabel)
        Me.Controls.Add(Me.CompanyProfileIdComboBox)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(ArabicNameLabel)
        Me.Controls.Add(Me.ArabicNameTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCompanyProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArabicNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyProfileIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblCompanyProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepCategoryIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDepartmentCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MakeSatisficationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDepartmentTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As ToolTip
End Class
