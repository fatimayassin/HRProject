<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRequirement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim LanguageLabel As System.Windows.Forms.Label
        Dim MinAgeLabel As System.Windows.Forms.Label
        Dim MaxAgeLabel As System.Windows.Forms.Label
        Dim ExperienceYearsLabel As System.Windows.Forms.Label
        Dim CertificateIdLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim MajorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.TblRequirementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.TblCertificateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinAgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MaxAgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ExperienceYearsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CertificateIdComboBox = New System.Windows.Forms.ComboBox()
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.isGeneral = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DescriptionLabel = New System.Windows.Forms.Label()
        LanguageLabel = New System.Windows.Forms.Label()
        MinAgeLabel = New System.Windows.Forms.Label()
        MaxAgeLabel = New System.Windows.Forms.Label()
        ExperienceYearsLabel = New System.Windows.Forms.Label()
        CertificateIdLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        MajorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.TblRequirementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinAgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxAgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExperienceYearsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(11, 21)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 0
        DescriptionLabel.Text = "Description:"
        '
        'LanguageLabel
        '
        LanguageLabel.AutoSize = True
        LanguageLabel.Location = New System.Drawing.Point(132, 76)
        LanguageLabel.Name = "LanguageLabel"
        LanguageLabel.Size = New System.Drawing.Size(58, 13)
        LanguageLabel.TabIndex = 17
        LanguageLabel.Text = "Language:"
        '
        'MinAgeLabel
        '
        MinAgeLabel.AutoSize = True
        MinAgeLabel.Location = New System.Drawing.Point(132, 140)
        MinAgeLabel.Name = "MinAgeLabel"
        MinAgeLabel.Size = New System.Drawing.Size(49, 13)
        MinAgeLabel.TabIndex = 16
        MinAgeLabel.Text = "Min Age:"
        '
        'MaxAgeLabel
        '
        MaxAgeLabel.AutoSize = True
        MaxAgeLabel.Location = New System.Drawing.Point(132, 169)
        MaxAgeLabel.Name = "MaxAgeLabel"
        MaxAgeLabel.Size = New System.Drawing.Size(52, 13)
        MaxAgeLabel.TabIndex = 15
        MaxAgeLabel.Text = "Max Age:"
        '
        'ExperienceYearsLabel
        '
        ExperienceYearsLabel.AutoSize = True
        ExperienceYearsLabel.Location = New System.Drawing.Point(132, 109)
        ExperienceYearsLabel.Name = "ExperienceYearsLabel"
        ExperienceYearsLabel.Size = New System.Drawing.Size(93, 13)
        ExperienceYearsLabel.TabIndex = 14
        ExperienceYearsLabel.Text = "Experience Years:"
        '
        'CertificateIdLabel
        '
        CertificateIdLabel.AutoSize = True
        CertificateIdLabel.Location = New System.Drawing.Point(132, 17)
        CertificateIdLabel.Name = "CertificateIdLabel"
        CertificateIdLabel.Size = New System.Drawing.Size(57, 13)
        CertificateIdLabel.TabIndex = 13
        CertificateIdLabel.Text = "Certificate:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(132, 199)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 12
        NoteLabel.Text = "Note:"
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(132, 47)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(36, 13)
        MajorLabel.TabIndex = 6
        MajorLabel.Text = "Major:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 16)
        Label1.TabIndex = 0
        Label1.Text = "Description:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(25, 73)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(67, 16)
        Label2.TabIndex = 17
        Label2.Text = "Language:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(25, 137)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 16)
        Label3.TabIndex = 16
        Label3.Text = "Min Age:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(25, 166)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 16)
        Label4.TabIndex = 15
        Label4.Text = "Max Age:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(25, 106)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(111, 16)
        Label5.TabIndex = 14
        Label5.Text = "Experience Years:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(25, 14)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(74, 16)
        Label6.TabIndex = 13
        Label6.Text = "Certificate:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(25, 196)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(40, 16)
        Label7.TabIndex = 12
        Label7.Text = "Note:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(25, 44)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(46, 16)
        Label8.TabIndex = 6
        Label8.Text = "Major:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.DescriptionTextBox)
        Me.Panel2.Location = New System.Drawing.Point(10, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 78)
        Me.Panel2.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRequirementBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(103, 13)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(278, 57)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'TblRequirementBindingSource
        '
        Me.TblRequirementBindingSource.DataSource = GetType(HR.TblRequirement)
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRequirementBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(156, 193)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(239, 49)
        Me.NoteTextBox.TabIndex = 6
        '
        'MajorTextBox
        '
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRequirementBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(156, 41)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(239, 23)
        Me.MajorTextBox.TabIndex = 1
        '
        'TblCertificateBindingSource
        '
        Me.TblCertificateBindingSource.DataSource = GetType(HR.TblCertificate)
        '
        'MinAgeNumericUpDown
        '
        Me.MinAgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRequirementBindingSource, "MinAge", True))
        Me.MinAgeNumericUpDown.Location = New System.Drawing.Point(156, 135)
        Me.MinAgeNumericUpDown.Name = "MinAgeNumericUpDown"
        Me.MinAgeNumericUpDown.Size = New System.Drawing.Size(239, 23)
        Me.MinAgeNumericUpDown.TabIndex = 4
        '
        'MaxAgeNumericUpDown
        '
        Me.MaxAgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRequirementBindingSource, "MaxAge", True))
        Me.MaxAgeNumericUpDown.Location = New System.Drawing.Point(156, 164)
        Me.MaxAgeNumericUpDown.Name = "MaxAgeNumericUpDown"
        Me.MaxAgeNumericUpDown.Size = New System.Drawing.Size(239, 23)
        Me.MaxAgeNumericUpDown.TabIndex = 5
        '
        'ExperienceYearsNumericUpDown
        '
        Me.ExperienceYearsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRequirementBindingSource, "ExperienceYears", True))
        Me.ExperienceYearsNumericUpDown.Location = New System.Drawing.Point(156, 104)
        Me.ExperienceYearsNumericUpDown.Name = "ExperienceYearsNumericUpDown"
        Me.ExperienceYearsNumericUpDown.Size = New System.Drawing.Size(239, 23)
        Me.ExperienceYearsNumericUpDown.TabIndex = 3
        '
        'CertificateIdComboBox
        '
        Me.CertificateIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRequirementBindingSource, "CertificateId", True))
        Me.CertificateIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblRequirementBindingSource, "CertificateId", True))
        Me.CertificateIdComboBox.DataSource = Me.TblCertificateBindingSource
        Me.CertificateIdComboBox.DisplayMember = "Name"
        Me.CertificateIdComboBox.FormattingEnabled = True
        Me.CertificateIdComboBox.Location = New System.Drawing.Point(156, 11)
        Me.CertificateIdComboBox.Name = "CertificateIdComboBox"
        Me.CertificateIdComboBox.Size = New System.Drawing.Size(239, 24)
        Me.CertificateIdComboBox.TabIndex = 0
        Me.CertificateIdComboBox.ValueMember = "Id"
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRequirementBindingSource, "Language", True))
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Items.AddRange(New Object() {"Afrikaans", "Akan", "Albanian", "Amharic", "Arabic", "Armenian", "ASL", "Assamese", "Assyrian", "Azerbaijani", "Bahdini", "Bambara", "Bashkir", "Basque", "Belarusian", "Bengali", "Bosnian", "Bravanese", "Bulgarian", "Burmese", "Cambodian", "Cantonese", "Catalan", "Cebuano", "Chaldean", "Chamorro", "Chaozhou", "Chavacano", "Chin", "Chuukese", "Cree", "Croatian", "Czech", "Dakota", "Danish", "Dari", "Dinka", "Dioula", "Dutch", "Dzongkha", "English", "Estonian", "Ewe", "Fante", "Faroese", "Farsi", "Fijian Hindi", "Finnish", "Flemish", "French", "French Canadian", "Frisian", "Fujianese", "Fukienese", "Fula", "Fulani", "Fuzhou", "Ga", "Gaelic", "Galician", "Ganda", "Georgian", "German", "Gorani", "Greek", "Gujarati", "Haitian Creole", "Hakka", "Hassaniyya", "Hausa", "Hebrew", "Hiligaynon", "Hindi"})
        Me.LanguageComboBox.Location = New System.Drawing.Point(156, 70)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(239, 24)
        Me.LanguageComboBox.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSave)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 38)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(464, 444)
        Me.FlowLayoutPanel1.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.LanguageComboBox)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.MinAgeNumericUpDown)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.MaxAgeNumericUpDown)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.ExperienceYearsNumericUpDown)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.CertificateIdComboBox)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.MajorTextBox)
        Me.Panel1.Location = New System.Drawing.Point(10, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 257)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.isGeneral)
        Me.Panel3.Location = New System.Drawing.Point(10, 354)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 28)
        Me.Panel3.TabIndex = 59
        '
        'isGeneral
        '
        Me.isGeneral.AutoSize = True
        Me.isGeneral.Location = New System.Drawing.Point(312, 3)
        Me.isGeneral.Name = "isGeneral"
        Me.isGeneral.Size = New System.Drawing.Size(78, 20)
        Me.isGeneral.TabIndex = 8
        Me.isGeneral.Text = "General?"
        Me.isGeneral.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(409, 387)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(455, 2)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 10
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(483, 32)
        Me.lblText.TabIndex = 58
        Me.lblText.Text = "Requirement"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmRequirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(483, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRequirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblRequirementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinAgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxAgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExperienceYearsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents TblRequirementBindingSource As BindingSource
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents TblCertificateBindingSource As BindingSource
    Friend WithEvents MinAgeNumericUpDown As NumericUpDown
    Friend WithEvents MaxAgeNumericUpDown As NumericUpDown
    Friend WithEvents ExperienceYearsNumericUpDown As NumericUpDown
    Friend WithEvents CertificateIdComboBox As ComboBox
    Friend WithEvents LanguageComboBox As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents isGeneral As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
