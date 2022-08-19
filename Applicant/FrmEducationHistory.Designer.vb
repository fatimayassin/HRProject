<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEducationHistory
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
        Dim GraduationYearLabel As System.Windows.Forms.Label
        Dim StartYearLabel As System.Windows.Forms.Label
        Dim UniversityLabel As System.Windows.Forms.Label
        Dim MajorLabel As System.Windows.Forms.Label
        Dim GPALabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim CertificateIdLabel As System.Windows.Forms.Label
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.TblEducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.GraduationYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.CertificateIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCertificateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        GraduationYearLabel = New System.Windows.Forms.Label()
        StartYearLabel = New System.Windows.Forms.Label()
        UniversityLabel = New System.Windows.Forms.Label()
        MajorLabel = New System.Windows.Forms.Label()
        GPALabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CertificateIdLabel = New System.Windows.Forms.Label()
        CType(Me.TblEducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraduationYearLabel
        '
        GraduationYearLabel.AutoSize = True
        GraduationYearLabel.Location = New System.Drawing.Point(32, 97)
        GraduationYearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GraduationYearLabel.Name = "GraduationYearLabel"
        GraduationYearLabel.Size = New System.Drawing.Size(106, 16)
        GraduationYearLabel.TabIndex = 28
        GraduationYearLabel.Text = "Graduation Year:"
        '
        'StartYearLabel
        '
        StartYearLabel.AutoSize = True
        StartYearLabel.Location = New System.Drawing.Point(32, 65)
        StartYearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StartYearLabel.Name = "StartYearLabel"
        StartYearLabel.Size = New System.Drawing.Size(70, 16)
        StartYearLabel.TabIndex = 31
        StartYearLabel.Text = "Start Year:"
        '
        'UniversityLabel
        '
        UniversityLabel.AutoSize = True
        UniversityLabel.Location = New System.Drawing.Point(32, 192)
        UniversityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UniversityLabel.Name = "UniversityLabel"
        UniversityLabel.Size = New System.Drawing.Size(72, 16)
        UniversityLabel.TabIndex = 32
        UniversityLabel.Text = "University:"
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(32, 127)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(46, 16)
        MajorLabel.TabIndex = 33
        MajorLabel.Text = "Major:"
        '
        'GPALabel
        '
        GPALabel.AutoSize = True
        GPALabel.Location = New System.Drawing.Point(32, 224)
        GPALabel.Name = "GPALabel"
        GPALabel.Size = New System.Drawing.Size(36, 16)
        GPALabel.TabIndex = 34
        GPALabel.Text = "GPA:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(32, 256)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(40, 16)
        NoteLabel.TabIndex = 35
        NoteLabel.Text = "Note:"
        '
        'CertificateIdLabel
        '
        CertificateIdLabel.AutoSize = True
        CertificateIdLabel.Location = New System.Drawing.Point(32, 159)
        CertificateIdLabel.Name = "CertificateIdLabel"
        CertificateIdLabel.Size = New System.Drawing.Size(74, 16)
        CertificateIdLabel.TabIndex = 35
        CertificateIdLabel.Text = "Certificate:"
        '
        'MajorTextBox
        '
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEducationBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(159, 124)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(265, 23)
        Me.MajorTextBox.TabIndex = 2
        '
        'TblEducationBindingSource
        '
        Me.TblEducationBindingSource.DataSource = GetType(HR.TblEducation)
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(452, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 8
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
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(480, 32)
        Me.lblText.TabIndex = 34
        Me.lblText.Text = "Education History Info"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GraduationYearDateTimePicker
        '
        Me.GraduationYearDateTimePicker.CustomFormat = "yyyy"
        Me.GraduationYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblEducationBindingSource, "GraduationYear", True))
        Me.GraduationYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GraduationYearDateTimePicker.Location = New System.Drawing.Point(159, 92)
        Me.GraduationYearDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.GraduationYearDateTimePicker.Name = "GraduationYearDateTimePicker"
        Me.GraduationYearDateTimePicker.Size = New System.Drawing.Size(265, 23)
        Me.GraduationYearDateTimePicker.TabIndex = 1
        '
        'StartYearDateTimePicker
        '
        Me.StartYearDateTimePicker.CustomFormat = "yyyy"
        Me.StartYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblEducationBindingSource, "StartYear", True))
        Me.StartYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartYearDateTimePicker.Location = New System.Drawing.Point(159, 60)
        Me.StartYearDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.StartYearDateTimePicker.Name = "StartYearDateTimePicker"
        Me.StartYearDateTimePicker.Size = New System.Drawing.Size(265, 23)
        Me.StartYearDateTimePicker.TabIndex = 0
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEducationBindingSource, "University", True))
        Me.UniversityTextBox.Location = New System.Drawing.Point(159, 189)
        Me.UniversityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(265, 23)
        Me.UniversityTextBox.TabIndex = 4
        '
        'GPATextBox
        '
        Me.GPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEducationBindingSource, "GPA", True))
        Me.GPATextBox.Location = New System.Drawing.Point(159, 221)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(265, 23)
        Me.GPATextBox.TabIndex = 5
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEducationBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(159, 253)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(265, 57)
        Me.NoteTextBox.TabIndex = 6
        '
        'CertificateIdComboBox
        '
        Me.CertificateIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEducationBindingSource, "CertificateId", True))
        Me.CertificateIdComboBox.DataSource = Me.TblCertificateBindingSource
        Me.CertificateIdComboBox.DisplayMember = "Name"
        Me.CertificateIdComboBox.FormattingEnabled = True
        Me.CertificateIdComboBox.Location = New System.Drawing.Point(159, 156)
        Me.CertificateIdComboBox.Name = "CertificateIdComboBox"
        Me.CertificateIdComboBox.Size = New System.Drawing.Size(265, 24)
        Me.CertificateIdComboBox.TabIndex = 3
        Me.CertificateIdComboBox.ValueMember = "Id"
        '
        'TblCertificateBindingSource
        '
        Me.TblCertificateBindingSource.DataSource = GetType(HR.TblCertificate)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(418, 334)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmEducationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(CertificateIdLabel)
        Me.Controls.Add(Me.CertificateIdComboBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(GPALabel)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(GraduationYearLabel)
        Me.Controls.Add(StartYearLabel)
        Me.Controls.Add(UniversityLabel)
        Me.Controls.Add(MajorLabel)
        Me.Controls.Add(Me.MajorTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.GraduationYearDateTimePicker)
        Me.Controls.Add(Me.StartYearDateTimePicker)
        Me.Controls.Add(Me.UniversityTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEducationHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblEducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCertificateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents GraduationYearDateTimePicker As DateTimePicker
    Friend WithEvents StartYearDateTimePicker As DateTimePicker
    Friend WithEvents UniversityTextBox As TextBox
    Friend WithEvents TblEducationBindingSource As BindingSource
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents CertificateIdComboBox As ComboBox
    Friend WithEvents TblCertificateBindingSource As BindingSource
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
