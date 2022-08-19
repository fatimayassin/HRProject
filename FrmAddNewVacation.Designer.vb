<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNewVacation
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
        Dim VacationTypeIdLabel As System.Windows.Forms.Label
        Dim VacationDateLabel As System.Windows.Forms.Label
        Dim NumberOfDaysLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacationTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblVacationTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacationDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumberOfDaysNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        VacationTypeIdLabel = New System.Windows.Forms.Label()
        VacationDateLabel = New System.Windows.Forms.Label()
        NumberOfDaysLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfDaysNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VacationTypeIdLabel
        '
        VacationTypeIdLabel.AutoSize = True
        VacationTypeIdLabel.Location = New System.Drawing.Point(12, 101)
        VacationTypeIdLabel.Name = "VacationTypeIdLabel"
        VacationTypeIdLabel.Size = New System.Drawing.Size(94, 16)
        VacationTypeIdLabel.TabIndex = 57
        VacationTypeIdLabel.Text = "Vacation Type:"
        '
        'VacationDateLabel
        '
        VacationDateLabel.AutoSize = True
        VacationDateLabel.Location = New System.Drawing.Point(14, 144)
        VacationDateLabel.Name = "VacationDateLabel"
        VacationDateLabel.Size = New System.Drawing.Size(92, 16)
        VacationDateLabel.TabIndex = 58
        VacationDateLabel.Text = "Vacation Date:"
        '
        'NumberOfDaysLabel
        '
        NumberOfDaysLabel.AutoSize = True
        NumberOfDaysLabel.Location = New System.Drawing.Point(14, 184)
        NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        NumberOfDaysLabel.Size = New System.Drawing.Size(70, 16)
        NumberOfDaysLabel.TabIndex = 59
        NumberOfDaysLabel.Text = "# Of Days:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(14, 226)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(76, 16)
        DescriptionLabel.TabIndex = 60
        DescriptionLabel.Text = "Description:"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(353, 39)
        Me.lblText.TabIndex = 55
        Me.lblText.Text = "Add Vacations"
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
        Me.lblClose.Location = New System.Drawing.Point(327, 7)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "X"
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'VacationTypeIdComboBox
        '
        Me.VacationTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblVacationBindingSource, "VacationTypeId", True))
        Me.VacationTypeIdComboBox.DataSource = Me.TblVacationTypeBindingSource
        Me.VacationTypeIdComboBox.DisplayMember = "Name"
        Me.VacationTypeIdComboBox.FormattingEnabled = True
        Me.VacationTypeIdComboBox.Location = New System.Drawing.Point(110, 98)
        Me.VacationTypeIdComboBox.Name = "VacationTypeIdComboBox"
        Me.VacationTypeIdComboBox.Size = New System.Drawing.Size(206, 24)
        Me.VacationTypeIdComboBox.TabIndex = 1
        Me.VacationTypeIdComboBox.ValueMember = "Id"
        '
        'TblVacationTypeBindingSource
        '
        'Me.TblVacationTypeBindingSource.DataSource = GetType(HR.TblVacationType)
        '
        'VacationDateDateTimePicker
        '
        Me.VacationDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblVacationBindingSource, "VacationDate", True))
        Me.VacationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VacationDateDateTimePicker.Location = New System.Drawing.Point(112, 140)
        Me.VacationDateDateTimePicker.Name = "VacationDateDateTimePicker"
        Me.VacationDateDateTimePicker.Size = New System.Drawing.Size(204, 23)
        Me.VacationDateDateTimePicker.TabIndex = 2
        '
        'NumberOfDaysNumericUpDown
        '
        Me.NumberOfDaysNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblVacationBindingSource, "NumberOfDays", True))
        Me.NumberOfDaysNumericUpDown.Location = New System.Drawing.Point(112, 182)
        Me.NumberOfDaysNumericUpDown.Name = "NumberOfDaysNumericUpDown"
        Me.NumberOfDaysNumericUpDown.Size = New System.Drawing.Size(204, 23)
        Me.NumberOfDaysNumericUpDown.TabIndex = 3
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVacationBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(112, 223)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(204, 23)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.AutoSize = True
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(31, 65)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(72, 16)
        Me.EmployeeIdLabel.TabIndex = 63
        Me.EmployeeIdLabel.Text = "Employee :"
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(110, 58)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(206, 23)
        Me.EmployeeNameTextBox.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.save2
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(271, 269)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmAddNewVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(353, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(NumberOfDaysLabel)
        Me.Controls.Add(Me.NumberOfDaysNumericUpDown)
        Me.Controls.Add(VacationDateLabel)
        Me.Controls.Add(Me.VacationDateDateTimePicker)
        Me.Controls.Add(VacationTypeIdLabel)
        Me.Controls.Add(Me.VacationTypeIdComboBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAddNewVacation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfDaysNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VacationTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VacationDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumberOfDaysNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblVacationTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIdLabel As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
