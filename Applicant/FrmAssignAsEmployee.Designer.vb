<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssignAsEmployee
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
        Dim DepIdLabel As System.Windows.Forms.Label
        Dim JobIdLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim ContractTypeIdLabel As System.Windows.Forms.Label
        Dim CardNumberLabel As System.Windows.Forms.Label
        Dim BatchNumberLabel As System.Windows.Forms.Label
        Dim EmployeeDegreeIdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PINLabel = New System.Windows.Forms.Label()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblEmployeeJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobIdComboBox = New System.Windows.Forms.ComboBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ContractTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblContractTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.BatchNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TblCurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDegreeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDegreeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateOfEmploymentTimePicker = New System.Windows.Forms.DateTimePicker()
        DepIdLabel = New System.Windows.Forms.Label()
        JobIdLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        ContractTypeIdLabel = New System.Windows.Forms.Label()
        CardNumberLabel = New System.Windows.Forms.Label()
        BatchNumberLabel = New System.Windows.Forms.Label()
        EmployeeDegreeIdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContractTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDegreeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepIdLabel
        '
        DepIdLabel.AutoSize = True
        DepIdLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepIdLabel.Location = New System.Drawing.Point(352, 67)
        DepIdLabel.Name = "DepIdLabel"
        DepIdLabel.Size = New System.Drawing.Size(35, 16)
        DepIdLabel.TabIndex = 69
        DepIdLabel.Text = "Dep:"
        '
        'JobIdLabel
        '
        JobIdLabel.AutoSize = True
        JobIdLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JobIdLabel.Location = New System.Drawing.Point(352, 107)
        JobIdLabel.Name = "JobIdLabel"
        JobIdLabel.Size = New System.Drawing.Size(31, 16)
        JobIdLabel.TabIndex = 68
        JobIdLabel.Text = "Job:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(12, 242)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(40, 16)
        NoteLabel.TabIndex = 67
        NoteLabel.Text = "Note:"
        '
        'ContractTypeIdLabel
        '
        ContractTypeIdLabel.AutoSize = True
        ContractTypeIdLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContractTypeIdLabel.Location = New System.Drawing.Point(352, 187)
        ContractTypeIdLabel.Name = "ContractTypeIdLabel"
        ContractTypeIdLabel.Size = New System.Drawing.Size(62, 16)
        ContractTypeIdLabel.TabIndex = 66
        ContractTypeIdLabel.Text = "Contract:"
        '
        'CardNumberLabel
        '
        CardNumberLabel.AutoSize = True
        CardNumberLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNumberLabel.Location = New System.Drawing.Point(12, 188)
        CardNumberLabel.Name = "CardNumberLabel"
        CardNumberLabel.Size = New System.Drawing.Size(89, 16)
        CardNumberLabel.TabIndex = 64
        CardNumberLabel.Text = "Card Number:"
        '
        'BatchNumberLabel
        '
        BatchNumberLabel.AutoSize = True
        BatchNumberLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BatchNumberLabel.Location = New System.Drawing.Point(12, 146)
        BatchNumberLabel.Name = "BatchNumberLabel"
        BatchNumberLabel.Size = New System.Drawing.Size(94, 16)
        BatchNumberLabel.TabIndex = 63
        BatchNumberLabel.Text = "Batch Number:"
        '
        'EmployeeDegreeIdLabel
        '
        EmployeeDegreeIdLabel.AutoSize = True
        EmployeeDegreeIdLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeDegreeIdLabel.Location = New System.Drawing.Point(352, 149)
        EmployeeDegreeIdLabel.Name = "EmployeeDegreeIdLabel"
        EmployeeDegreeIdLabel.Size = New System.Drawing.Size(57, 16)
        EmployeeDegreeIdLabel.TabIndex = 69
        EmployeeDegreeIdLabel.Text = " Degree:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 67)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(89, 16)
        Label1.TabIndex = 73
        Label1.Text = "Date Of Emp.:"
        '
        'PINLabel
        '
        Me.PINLabel.AutoSize = True
        Me.PINLabel.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINLabel.Location = New System.Drawing.Point(12, 107)
        Me.PINLabel.Name = "PINLabel"
        Me.PINLabel.Size = New System.Drawing.Size(33, 16)
        Me.PINLabel.TabIndex = 65
        Me.PINLabel.Text = "PIN:"
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'DepIdComboBox
        '
        Me.DepIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "DepId", True))
        Me.DepIdComboBox.DataSource = Me.TblDepartmentBindingSource
        Me.DepIdComboBox.DisplayMember = "Name"
        Me.DepIdComboBox.FormattingEnabled = True
        Me.DepIdComboBox.Location = New System.Drawing.Point(428, 64)
        Me.DepIdComboBox.Name = "DepIdComboBox"
        Me.DepIdComboBox.Size = New System.Drawing.Size(193, 24)
        Me.DepIdComboBox.TabIndex = 57
        Me.DepIdComboBox.ValueMember = "Id"
        '
        'TblEmployeeJobBindingSource
        '
        Me.TblEmployeeJobBindingSource.DataSource = GetType(HR.TblEmployeeJob)
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'JobIdComboBox
        '
        Me.JobIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "JobId", True))
        Me.JobIdComboBox.DataSource = Me.TblJobDescriptionBindingSource
        Me.JobIdComboBox.DisplayMember = "Name"
        Me.JobIdComboBox.FormattingEnabled = True
        Me.JobIdComboBox.Location = New System.Drawing.Point(428, 102)
        Me.JobIdComboBox.Name = "JobIdComboBox"
        Me.JobIdComboBox.Size = New System.Drawing.Size(193, 24)
        Me.JobIdComboBox.TabIndex = 58
        Me.JobIdComboBox.ValueMember = "Id"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeJobBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(125, 235)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(496, 23)
        Me.NoteTextBox.TabIndex = 56
        '
        'PINTextBox
        '
        Me.PINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "PIN", True))
        Me.PINTextBox.Location = New System.Drawing.Point(125, 102)
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.Size = New System.Drawing.Size(193, 23)
        Me.PINTextBox.TabIndex = 53
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataSource = GetType(HR.TblEmployee)
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "CardNumber", True))
        Me.CardNumberTextBox.Location = New System.Drawing.Point(125, 183)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(193, 23)
        Me.CardNumberTextBox.TabIndex = 55
        '
        'ContractTypeIdComboBox
        '
        Me.ContractTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "ContractTypeId", True))
        Me.ContractTypeIdComboBox.DataSource = Me.TblContractTypeBindingSource
        Me.ContractTypeIdComboBox.DisplayMember = "Name"
        Me.ContractTypeIdComboBox.FormattingEnabled = True
        Me.ContractTypeIdComboBox.Location = New System.Drawing.Point(428, 184)
        Me.ContractTypeIdComboBox.Name = "ContractTypeIdComboBox"
        Me.ContractTypeIdComboBox.Size = New System.Drawing.Size(193, 24)
        Me.ContractTypeIdComboBox.TabIndex = 59
        Me.ContractTypeIdComboBox.ValueMember = "Id"
        '
        'TblContractTypeBindingSource
        '
        Me.TblContractTypeBindingSource.DataSource = GetType(HR.TblContractType)
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(629, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 61
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
        Me.lblText.Size = New System.Drawing.Size(659, 32)
        Me.lblText.TabIndex = 62
        Me.lblText.Text = "Assign as Employee"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BatchNumberTextBox
        '
        Me.BatchNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "BatchNumber", True))
        Me.BatchNumberTextBox.Location = New System.Drawing.Point(125, 142)
        Me.BatchNumberTextBox.Name = "BatchNumberTextBox"
        Me.BatchNumberTextBox.Size = New System.Drawing.Size(193, 23)
        Me.BatchNumberTextBox.TabIndex = 54
        '
        'TblCurrencyBindingSource
        '
        Me.TblCurrencyBindingSource.DataSource = GetType(HR.TblCurrency)
        '
        'EmployeeDegreeIdComboBox
        '
        Me.EmployeeDegreeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "EmployeeDegreeId", True))
        Me.EmployeeDegreeIdComboBox.DataSource = Me.TblDegreeBindingSource
        Me.EmployeeDegreeIdComboBox.DisplayMember = "Name"
        Me.EmployeeDegreeIdComboBox.FormattingEnabled = True
        Me.EmployeeDegreeIdComboBox.Location = New System.Drawing.Point(428, 143)
        Me.EmployeeDegreeIdComboBox.Name = "EmployeeDegreeIdComboBox"
        Me.EmployeeDegreeIdComboBox.Size = New System.Drawing.Size(193, 24)
        Me.EmployeeDegreeIdComboBox.TabIndex = 70
        Me.EmployeeDegreeIdComboBox.ValueMember = "Id"
        '
        'TblDegreeBindingSource
        '
        Me.TblDegreeBindingSource.DataSource = GetType(HR.TblDegree)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(597, 275)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DateOfEmploymentTimePicker
        '
        Me.DateOfEmploymentTimePicker.CalendarFont = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfEmploymentTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblEmployeeJobBindingSource, "DateOfEmployment", True))
        Me.DateOfEmploymentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfEmploymentTimePicker.Location = New System.Drawing.Point(125, 65)
        Me.DateOfEmploymentTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateOfEmploymentTimePicker.Name = "DateOfEmploymentTimePicker"
        Me.DateOfEmploymentTimePicker.Size = New System.Drawing.Size(193, 23)
        Me.DateOfEmploymentTimePicker.TabIndex = 74
        '
        'FrmAssignAsEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateOfEmploymentTimePicker)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(EmployeeDegreeIdLabel)
        Me.Controls.Add(Me.EmployeeDegreeIdComboBox)
        Me.Controls.Add(Me.DepIdComboBox)
        Me.Controls.Add(Me.JobIdComboBox)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.PINTextBox)
        Me.Controls.Add(Me.CardNumberTextBox)
        Me.Controls.Add(DepIdLabel)
        Me.Controls.Add(JobIdLabel)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(ContractTypeIdLabel)
        Me.Controls.Add(Me.ContractTypeIdComboBox)
        Me.Controls.Add(Me.PINLabel)
        Me.Controls.Add(CardNumberLabel)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(BatchNumberLabel)
        Me.Controls.Add(Me.BatchNumberTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAssignAsEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContractTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDegreeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContractTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblContractTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents BatchNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblCurrencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeDegreeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDegreeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TblEmployeeJobBindingSource As BindingSource
    Friend WithEvents PINLabel As Label
    Friend WithEvents DateOfEmploymentTimePicker As DateTimePicker
End Class
