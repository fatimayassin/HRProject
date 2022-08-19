<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeavePermission
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim StartTimeLabel As System.Windows.Forms.Label
        Dim IsBusinessLabel As System.Windows.Forms.Label
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblLeavePermissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReasonTextBox = New System.Windows.Forms.TextBox()
        Me.EndTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsBusinessCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.minTimeSpanEditor = New Infragistics.Win.UltraWinEditors.UltraTimeSpanEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        StartTimeLabel = New System.Windows.Forms.Label()
        IsBusinessLabel = New System.Windows.Forms.Label()
        CType(Me.TblLeavePermissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minTimeSpanEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(11, 94)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 16)
        DateLabel.TabIndex = 59
        DateLabel.Text = "Date:"
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.Location = New System.Drawing.Point(11, 200)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(54, 16)
        ReasonLabel.TabIndex = 62
        ReasonLabel.Text = "Reason:"
        '
        'EndTimeLabel
        '
        EndTimeLabel.AutoSize = True
        EndTimeLabel.Location = New System.Drawing.Point(11, 166)
        EndTimeLabel.Name = "EndTimeLabel"
        EndTimeLabel.Size = New System.Drawing.Size(65, 16)
        EndTimeLabel.TabIndex = 64
        EndTimeLabel.Text = "End Time:"
        '
        'StartTimeLabel
        '
        StartTimeLabel.AutoSize = True
        StartTimeLabel.Location = New System.Drawing.Point(11, 130)
        StartTimeLabel.Name = "StartTimeLabel"
        StartTimeLabel.Size = New System.Drawing.Size(73, 16)
        StartTimeLabel.TabIndex = 65
        StartTimeLabel.Text = "Start Time:"
        '
        'IsBusinessLabel
        '
        IsBusinessLabel.AutoSize = True
        IsBusinessLabel.Location = New System.Drawing.Point(129, 315)
        IsBusinessLabel.Name = "IsBusinessLabel"
        IsBusinessLabel.Size = New System.Drawing.Size(72, 16)
        IsBusinessLabel.TabIndex = 66
        IsBusinessLabel.Text = "is Business"
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.AutoSize = True
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(11, 60)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(71, 16)
        Me.EmployeeIdLabel.TabIndex = 68
        Me.EmployeeIdLabel.Text = "Employee :"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(393, 32)
        Me.lblText.TabIndex = 57
        Me.lblText.Text = "Leave Permission"
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
        Me.lblClose.Location = New System.Drawing.Point(364, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblLeavePermissionBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(102, 89)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(266, 23)
        Me.DateDateTimePicker.TabIndex = 0
        '
        'TblLeavePermissionBindingSource
        '
        Me.TblLeavePermissionBindingSource.DataSource = GetType(HR.TblLeavePermission)
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLeavePermissionBindingSource, "Reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(102, 197)
        Me.ReasonTextBox.Multiline = True
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(266, 99)
        Me.ReasonTextBox.TabIndex = 3
        '
        'EndTimeDateTimePicker
        '
        Me.EndTimeDateTimePicker.CustomFormat = "HH:MM"
        Me.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.EndTimeDateTimePicker.Location = New System.Drawing.Point(102, 161)
        Me.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker"
        Me.EndTimeDateTimePicker.Size = New System.Drawing.Size(266, 23)
        Me.EndTimeDateTimePicker.TabIndex = 2
        '
        'StartTimeDateTimePicker
        '
        Me.StartTimeDateTimePicker.CustomFormat = "HH:MM"
        Me.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.StartTimeDateTimePicker.Location = New System.Drawing.Point(102, 125)
        Me.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker"
        Me.StartTimeDateTimePicker.Size = New System.Drawing.Size(266, 23)
        Me.StartTimeDateTimePicker.TabIndex = 1
        '
        'IsBusinessCheckBox
        '
        Me.IsBusinessCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblLeavePermissionBindingSource, "isBusiness", True))
        Me.IsBusinessCheckBox.Location = New System.Drawing.Point(102, 312)
        Me.IsBusinessCheckBox.Name = "IsBusinessCheckBox"
        Me.IsBusinessCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.IsBusinessCheckBox.TabIndex = 4
        Me.IsBusinessCheckBox.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(317, 346)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(102, 53)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(266, 23)
        Me.EmployeeNameTextBox.TabIndex = 67
        '
        'minTimeSpanEditor
        '
        Me.minTimeSpanEditor.Location = New System.Drawing.Point(24, 358)
        Me.minTimeSpanEditor.MinValue = System.TimeSpan.Parse("1.00:00:00")
        Me.minTimeSpanEditor.Name = "minTimeSpanEditor"
        Me.minTimeSpanEditor.Size = New System.Drawing.Size(197, 25)
        Me.minTimeSpanEditor.TabIndex = 69
        Me.minTimeSpanEditor.TimeSpan = System.TimeSpan.Parse("1.00:00:00")
        Me.minTimeSpanEditor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Check this"
        Me.Label1.Visible = False
        '
        'FrmLeavePermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(393, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.minTimeSpanEditor)
        Me.Controls.Add(Me.EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(IsBusinessLabel)
        Me.Controls.Add(Me.IsBusinessCheckBox)
        Me.Controls.Add(StartTimeLabel)
        Me.Controls.Add(Me.StartTimeDateTimePicker)
        Me.Controls.Add(EndTimeLabel)
        Me.Controls.Add(Me.EndTimeDateTimePicker)
        Me.Controls.Add(ReasonLabel)
        Me.Controls.Add(Me.ReasonTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmLeavePermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblLeavePermissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minTimeSpanEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblLeavePermissionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReasonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IsBusinessCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIdLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents minTimeSpanEditor As Infragistics.Win.UltraWinEditors.UltraTimeSpanEditor
    Friend WithEvents Label1 As Label
End Class
