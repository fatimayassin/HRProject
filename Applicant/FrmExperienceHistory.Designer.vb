<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExperienceHistory
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
        Dim NSSFNumberLabel As System.Windows.Forms.Label
        Dim LeaveReasonLabel As System.Windows.Forms.Label
        Dim LeaveDateLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim PositionIdLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim CurrencyIdLabel As System.Windows.Forms.Label
        Dim NSSFSideLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblExperienceHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StillWorkingCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.NSSFGroupBox = New System.Windows.Forms.GroupBox()
        Me.NSSFSideComboBox = New System.Windows.Forms.ComboBox()
        Me.NSSFNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CanBeLeaveCheckBox = New System.Windows.Forms.CheckBox()
        Me.CanBeLeaveGroupBox = New System.Windows.Forms.GroupBox()
        Me.IsNSSFCheckBox = New System.Windows.Forms.CheckBox()
        Me.ScheduleNoteGroupBox = New System.Windows.Forms.GroupBox()
        Me.ScheduleNoteTextBox = New System.Windows.Forms.TextBox()
        Me.LeavingInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.LeaveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LeaveReasonTextBox = New System.Windows.Forms.TextBox()
        Me.TblCurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.CurrencyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NSSFNumberLabel = New System.Windows.Forms.Label()
        LeaveReasonLabel = New System.Windows.Forms.Label()
        LeaveDateLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        PositionIdLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        CurrencyIdLabel = New System.Windows.Forms.Label()
        NSSFSideLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.TblExperienceHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NSSFGroupBox.SuspendLayout()
        Me.CanBeLeaveGroupBox.SuspendLayout()
        Me.ScheduleNoteGroupBox.SuspendLayout()
        Me.LeavingInfoGroupBox.SuspendLayout()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NSSFNumberLabel
        '
        NSSFNumberLabel.AutoSize = True
        NSSFNumberLabel.Location = New System.Drawing.Point(8, 55)
        NSSFNumberLabel.Name = "NSSFNumberLabel"
        NSSFNumberLabel.Size = New System.Drawing.Size(89, 16)
        NSSFNumberLabel.TabIndex = 52
        NSSFNumberLabel.Text = "NSSFNumber:"
        '
        'LeaveReasonLabel
        '
        LeaveReasonLabel.AutoSize = True
        LeaveReasonLabel.Location = New System.Drawing.Point(8, 56)
        LeaveReasonLabel.Name = "LeaveReasonLabel"
        LeaveReasonLabel.Size = New System.Drawing.Size(92, 16)
        LeaveReasonLabel.TabIndex = 42
        LeaveReasonLabel.Text = "Leave Reason:"
        '
        'LeaveDateLabel
        '
        LeaveDateLabel.AutoSize = True
        LeaveDateLabel.Location = New System.Drawing.Point(8, 28)
        LeaveDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LeaveDateLabel.Name = "LeaveDateLabel"
        LeaveDateLabel.Size = New System.Drawing.Size(78, 16)
        LeaveDateLabel.TabIndex = 41
        LeaveDateLabel.Text = "Leave Date:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(22, 54)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(66, 16)
        CompanyNameLabel.TabIndex = 47
        CompanyNameLabel.Text = "Company:"
        '
        'PositionIdLabel
        '
        PositionIdLabel.AutoSize = True
        PositionIdLabel.Location = New System.Drawing.Point(22, 114)
        PositionIdLabel.Name = "PositionIdLabel"
        PositionIdLabel.Size = New System.Drawing.Size(62, 16)
        PositionIdLabel.TabIndex = 45
        PositionIdLabel.Text = "Position :"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(22, 86)
        StartDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(72, 16)
        StartDateLabel.TabIndex = 40
        StartDateLabel.Text = "Start Date:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(22, 144)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(48, 16)
        SalaryLabel.TabIndex = 43
        SalaryLabel.Text = "Salary:"
        '
        'CurrencyIdLabel
        '
        CurrencyIdLabel.AutoSize = True
        CurrencyIdLabel.Location = New System.Drawing.Point(22, 176)
        CurrencyIdLabel.Name = "CurrencyIdLabel"
        CurrencyIdLabel.Size = New System.Drawing.Size(67, 16)
        CurrencyIdLabel.TabIndex = 46
        CurrencyIdLabel.Text = "Currency :"
        '
        'NSSFSideLabel
        '
        NSSFSideLabel.AutoSize = True
        NSSFSideLabel.Location = New System.Drawing.Point(8, 25)
        NSSFSideLabel.Name = "NSSFSideLabel"
        NSSFSideLabel.Size = New System.Drawing.Size(67, 16)
        NSSFSideLabel.TabIndex = 55
        NSSFSideLabel.Text = "NSSFSide:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 16)
        Label1.TabIndex = 53
        Label1.Text = "Note:"
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblExperienceHistoryBindingSource, "StartDate", True))
        Me.StartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(139, 81)
        Me.StartDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(419, 23)
        Me.StartDateDateTimePicker.TabIndex = 1
        '
        'TblExperienceHistoryBindingSource
        '
        Me.TblExperienceHistoryBindingSource.DataSource = GetType(HR.TblExperienceHistory)
        '
        'PositionIdComboBox
        '
        Me.PositionIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblExperienceHistoryBindingSource, "PositionId", True))
        Me.PositionIdComboBox.DataSource = Me.TblPositionBindingSource
        Me.PositionIdComboBox.DisplayMember = "Name"
        Me.PositionIdComboBox.FormattingEnabled = True
        Me.PositionIdComboBox.Location = New System.Drawing.Point(139, 111)
        Me.PositionIdComboBox.Name = "PositionIdComboBox"
        Me.PositionIdComboBox.Size = New System.Drawing.Size(419, 24)
        Me.PositionIdComboBox.TabIndex = 2
        Me.PositionIdComboBox.ValueMember = "Id"
        '
        'TblPositionBindingSource
        '
        Me.TblPositionBindingSource.DataSource = GetType(HR.TblPosition)
        '
        'StillWorkingCheckBox
        '
        Me.StillWorkingCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblExperienceHistoryBindingSource, "StillWorking", True))
        Me.StillWorkingCheckBox.Location = New System.Drawing.Point(25, 313)
        Me.StillWorkingCheckBox.Name = "StillWorkingCheckBox"
        Me.StillWorkingCheckBox.Size = New System.Drawing.Size(82, 24)
        Me.StillWorkingCheckBox.TabIndex = 8
        Me.StillWorkingCheckBox.Text = "Still Working"
        Me.StillWorkingCheckBox.UseVisualStyleBackColor = True
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExperienceHistoryBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(139, 51)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(419, 23)
        Me.CompanyNameTextBox.TabIndex = 0
        '
        'NSSFGroupBox
        '
        Me.NSSFGroupBox.Controls.Add(NSSFSideLabel)
        Me.NSSFGroupBox.Controls.Add(Me.NSSFSideComboBox)
        Me.NSSFGroupBox.Controls.Add(Me.NSSFNumberTextBox)
        Me.NSSFGroupBox.Controls.Add(NSSFNumberLabel)
        Me.NSSFGroupBox.Location = New System.Drawing.Point(6, 3)
        Me.NSSFGroupBox.Name = "NSSFGroupBox"
        Me.NSSFGroupBox.Size = New System.Drawing.Size(410, 82)
        Me.NSSFGroupBox.TabIndex = 53
        Me.NSSFGroupBox.TabStop = False
        Me.NSSFGroupBox.Text = "NSSF"
        '
        'NSSFSideComboBox
        '
        Me.NSSFSideComboBox.FormattingEnabled = True
        Me.NSSFSideComboBox.Items.AddRange(New Object() {"Daman"})
        Me.NSSFSideComboBox.Location = New System.Drawing.Point(106, 22)
        Me.NSSFSideComboBox.Name = "NSSFSideComboBox"
        Me.NSSFSideComboBox.Size = New System.Drawing.Size(301, 24)
        Me.NSSFSideComboBox.TabIndex = 6
        '
        'NSSFNumberTextBox
        '
        Me.NSSFNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExperienceHistoryBindingSource, "NSSFNumber", True))
        Me.NSSFNumberTextBox.Location = New System.Drawing.Point(106, 52)
        Me.NSSFNumberTextBox.Name = "NSSFNumberTextBox"
        Me.NSSFNumberTextBox.Size = New System.Drawing.Size(301, 23)
        Me.NSSFNumberTextBox.TabIndex = 7
        '
        'CanBeLeaveCheckBox
        '
        Me.CanBeLeaveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblExperienceHistoryBindingSource, "CanBeLeave", True))
        Me.CanBeLeaveCheckBox.Location = New System.Drawing.Point(13, 14)
        Me.CanBeLeaveCheckBox.Name = "CanBeLeaveCheckBox"
        Me.CanBeLeaveCheckBox.Size = New System.Drawing.Size(96, 39)
        Me.CanBeLeaveCheckBox.TabIndex = 10
        Me.CanBeLeaveCheckBox.Text = "Can be leave"
        Me.CanBeLeaveCheckBox.UseVisualStyleBackColor = True
        '
        'CanBeLeaveGroupBox
        '
        Me.CanBeLeaveGroupBox.Controls.Add(Me.CanBeLeaveCheckBox)
        Me.CanBeLeaveGroupBox.Location = New System.Drawing.Point(12, 392)
        Me.CanBeLeaveGroupBox.Name = "CanBeLeaveGroupBox"
        Me.CanBeLeaveGroupBox.Size = New System.Drawing.Size(115, 58)
        Me.CanBeLeaveGroupBox.TabIndex = 53
        Me.CanBeLeaveGroupBox.TabStop = False
        '
        'IsNSSFCheckBox
        '
        Me.IsNSSFCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblExperienceHistoryBindingSource, "IsNSSF", True))
        Me.IsNSSFCheckBox.Location = New System.Drawing.Point(25, 231)
        Me.IsNSSFCheckBox.Name = "IsNSSFCheckBox"
        Me.IsNSSFCheckBox.Size = New System.Drawing.Size(77, 24)
        Me.IsNSSFCheckBox.TabIndex = 5
        Me.IsNSSFCheckBox.Text = "Is NSSF"
        Me.IsNSSFCheckBox.UseVisualStyleBackColor = True
        '
        'ScheduleNoteGroupBox
        '
        Me.ScheduleNoteGroupBox.Controls.Add(Label1)
        Me.ScheduleNoteGroupBox.Controls.Add(Me.ScheduleNoteTextBox)
        Me.ScheduleNoteGroupBox.Location = New System.Drawing.Point(6, 91)
        Me.ScheduleNoteGroupBox.Name = "ScheduleNoteGroupBox"
        Me.ScheduleNoteGroupBox.Size = New System.Drawing.Size(410, 78)
        Me.ScheduleNoteGroupBox.TabIndex = 58
        Me.ScheduleNoteGroupBox.TabStop = False
        Me.ScheduleNoteGroupBox.Text = "Schedule Note"
        '
        'ScheduleNoteTextBox
        '
        Me.ScheduleNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExperienceHistoryBindingSource, "ScheduleNote", True))
        Me.ScheduleNoteTextBox.Location = New System.Drawing.Point(106, 19)
        Me.ScheduleNoteTextBox.Multiline = True
        Me.ScheduleNoteTextBox.Name = "ScheduleNoteTextBox"
        Me.ScheduleNoteTextBox.Size = New System.Drawing.Size(298, 53)
        Me.ScheduleNoteTextBox.TabIndex = 9
        '
        'LeavingInfoGroupBox
        '
        Me.LeavingInfoGroupBox.Controls.Add(LeaveReasonLabel)
        Me.LeavingInfoGroupBox.Controls.Add(Me.LeaveDateDateTimePicker)
        Me.LeavingInfoGroupBox.Controls.Add(Me.LeaveReasonTextBox)
        Me.LeavingInfoGroupBox.Controls.Add(LeaveDateLabel)
        Me.LeavingInfoGroupBox.Location = New System.Drawing.Point(6, 175)
        Me.LeavingInfoGroupBox.Name = "LeavingInfoGroupBox"
        Me.LeavingInfoGroupBox.Size = New System.Drawing.Size(410, 82)
        Me.LeavingInfoGroupBox.TabIndex = 56
        Me.LeavingInfoGroupBox.TabStop = False
        Me.LeavingInfoGroupBox.Text = "Leaving Details "
        '
        'LeaveDateDateTimePicker
        '
        Me.LeaveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblExperienceHistoryBindingSource, "LeaveDate", True))
        Me.LeaveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LeaveDateDateTimePicker.Location = New System.Drawing.Point(106, 23)
        Me.LeaveDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.LeaveDateDateTimePicker.Name = "LeaveDateDateTimePicker"
        Me.LeaveDateDateTimePicker.Size = New System.Drawing.Size(298, 23)
        Me.LeaveDateDateTimePicker.TabIndex = 11
        '
        'LeaveReasonTextBox
        '
        Me.LeaveReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExperienceHistoryBindingSource, "LeaveReason", True))
        Me.LeaveReasonTextBox.Location = New System.Drawing.Point(106, 53)
        Me.LeaveReasonTextBox.Name = "LeaveReasonTextBox"
        Me.LeaveReasonTextBox.Size = New System.Drawing.Size(298, 23)
        Me.LeaveReasonTextBox.TabIndex = 12
        '
        'TblCurrencyBindingSource
        '
        Me.TblCurrencyBindingSource.DataSource = GetType(HR.TblCurrency)
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExperienceHistoryBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(139, 141)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(419, 23)
        Me.SalaryTextBox.TabIndex = 3
        '
        'CurrencyIdComboBox
        '
        Me.CurrencyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblExperienceHistoryBindingSource, "CurrencyId", True))
        Me.CurrencyIdComboBox.DataSource = Me.TblCurrencyBindingSource
        Me.CurrencyIdComboBox.DisplayMember = "Name"
        Me.CurrencyIdComboBox.FormattingEnabled = True
        Me.CurrencyIdComboBox.Location = New System.Drawing.Point(139, 173)
        Me.CurrencyIdComboBox.Name = "CurrencyIdComboBox"
        Me.CurrencyIdComboBox.Size = New System.Drawing.Size(419, 24)
        Me.CurrencyIdComboBox.TabIndex = 4
        Me.CurrencyIdComboBox.ValueMember = "Id"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.NSSFGroupBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ScheduleNoteGroupBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.LeavingInfoGroupBox)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(139, 203)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(419, 262)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(548, 4)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 14
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
        Me.lblText.Size = New System.Drawing.Size(576, 32)
        Me.lblText.TabIndex = 60
        Me.lblText.Text = "Work Experience"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(514, 483)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmExperienceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.StartDateDateTimePicker)
        Me.Controls.Add(Me.CanBeLeaveGroupBox)
        Me.Controls.Add(StartDateLabel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PositionIdComboBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(PositionIdLabel)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.StillWorkingCheckBox)
        Me.Controls.Add(Me.CurrencyIdComboBox)
        Me.Controls.Add(Me.IsNSSFCheckBox)
        Me.Controls.Add(CurrencyIdLabel)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmExperienceHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblExperienceHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NSSFGroupBox.ResumeLayout(False)
        Me.NSSFGroupBox.PerformLayout()
        Me.CanBeLeaveGroupBox.ResumeLayout(False)
        Me.ScheduleNoteGroupBox.ResumeLayout(False)
        Me.ScheduleNoteGroupBox.PerformLayout()
        Me.LeavingInfoGroupBox.ResumeLayout(False)
        Me.LeavingInfoGroupBox.PerformLayout()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartDateDateTimePicker As DateTimePicker
    Friend WithEvents TblExperienceHistoryBindingSource As BindingSource
    Friend WithEvents PositionIdComboBox As ComboBox
    Friend WithEvents TblPositionBindingSource As BindingSource
    Friend WithEvents StillWorkingCheckBox As CheckBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents NSSFGroupBox As GroupBox
    Friend WithEvents NSSFNumberTextBox As TextBox
    Friend WithEvents CanBeLeaveCheckBox As CheckBox
    Friend WithEvents CanBeLeaveGroupBox As GroupBox
    Friend WithEvents IsNSSFCheckBox As CheckBox
    Friend WithEvents ScheduleNoteGroupBox As GroupBox
    Friend WithEvents ScheduleNoteTextBox As TextBox
    Friend WithEvents LeavingInfoGroupBox As GroupBox
    Friend WithEvents LeaveDateDateTimePicker As DateTimePicker
    Friend WithEvents LeaveReasonTextBox As TextBox
    Friend WithEvents TblCurrencyBindingSource As BindingSource
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents CurrencyIdComboBox As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents NSSFSideComboBox As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
