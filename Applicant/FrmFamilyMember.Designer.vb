<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFamilyMember
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
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblFamilyMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.IsWorkingCheckBox = New System.Windows.Forms.CheckBox()
        Me.InCompanyCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsMarriedCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DateOfBirthLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        CType(Me.TblFamilyMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(27, 202)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(90, 16)
        DateOfBirthLabel.TabIndex = 34
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddleNameLabel.Location = New System.Drawing.Point(27, 104)
        MiddleNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(90, 16)
        MiddleNameLabel.TabIndex = 29
        MiddleNameLabel.Text = "Middle Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(27, 138)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(74, 16)
        LastNameLabel.TabIndex = 27
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(27, 74)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel.TabIndex = 26
        FirstNameLabel.Text = "First Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(27, 168)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(53, 16)
        GenderLabel.TabIndex = 37
        GenderLabel.Text = "Gender:"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblFamilyMemberBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(138, 195)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(235, 23)
        Me.DateOfBirthDateTimePicker.TabIndex = 4
        '
        'TblFamilyMemberBindingSource
        '
        Me.TblFamilyMemberBindingSource.DataSource = GetType(HR.TblFamilyMember)
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(394, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 6
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
        Me.lblText.Size = New System.Drawing.Size(422, 32)
        Me.lblText.TabIndex = 33
        Me.lblText.Text = "Family Member"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFamilyMemberBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(138, 101)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(235, 23)
        Me.MiddleNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFamilyMemberBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(138, 132)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(235, 23)
        Me.LastNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFamilyMemberBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(138, 70)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(235, 23)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFamilyMemberBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(138, 163)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(235, 24)
        Me.GenderComboBox.TabIndex = 3
        '
        'IsWorkingCheckBox
        '
        Me.IsWorkingCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblFamilyMemberBindingSource, "IsWorking", True))
        Me.IsWorkingCheckBox.Location = New System.Drawing.Point(138, 233)
        Me.IsWorkingCheckBox.Name = "IsWorkingCheckBox"
        Me.IsWorkingCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsWorkingCheckBox.TabIndex = 38
        Me.IsWorkingCheckBox.Text = "Is Working"
        Me.IsWorkingCheckBox.UseVisualStyleBackColor = True
        '
        'InCompanyCheckBox
        '
        Me.InCompanyCheckBox.AutoSize = True
        Me.InCompanyCheckBox.Location = New System.Drawing.Point(138, 43)
        Me.InCompanyCheckBox.Name = "InCompanyCheckBox"
        Me.InCompanyCheckBox.Size = New System.Drawing.Size(96, 20)
        Me.InCompanyCheckBox.TabIndex = 39
        Me.InCompanyCheckBox.Text = "In Company"
        Me.InCompanyCheckBox.UseVisualStyleBackColor = True
        '
        'IsMarriedCheckBox
        '
        Me.IsMarriedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblFamilyMemberBindingSource, "IsMarried", True))
        Me.IsMarriedCheckBox.Location = New System.Drawing.Point(138, 263)
        Me.IsMarriedCheckBox.Name = "IsMarriedCheckBox"
        Me.IsMarriedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsMarriedCheckBox.TabIndex = 40
        Me.IsMarriedCheckBox.Text = "Is Married"
        Me.IsMarriedCheckBox.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(360, 276)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmFamilyMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.IsMarriedCheckBox)
        Me.Controls.Add(Me.InCompanyCheckBox)
        Me.Controls.Add(Me.IsWorkingCheckBox)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(MiddleNameLabel)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFamilyMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblFamilyMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents TblFamilyMemberBindingSource As BindingSource
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents IsWorkingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InCompanyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsMarriedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
