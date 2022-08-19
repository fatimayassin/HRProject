<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMotivationPunishment
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
        Dim NoteLabel As System.Windows.Forms.Label
        Dim IsMotivationLabel As System.Windows.Forms.Label
        Dim MotivationPunishmentTypeIdLabel As System.Windows.Forms.Label
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblMotivationPunishmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReasonTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.IsMotivationCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.MotivationPunishmentTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblMotivationPunishmentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmMotivationPunishmentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DateLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        IsMotivationLabel = New System.Windows.Forms.Label()
        MotivationPunishmentTypeIdLabel = New System.Windows.Forms.Label()
        CType(Me.TblMotivationPunishmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMotivationPunishmentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmMotivationPunishmentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(40, 105)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 16)
        DateLabel.TabIndex = 53
        DateLabel.Text = "Date:"
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.Location = New System.Drawing.Point(40, 218)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(54, 16)
        ReasonLabel.TabIndex = 54
        ReasonLabel.Text = "Reason:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(40, 180)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(40, 16)
        NoteLabel.TabIndex = 55
        NoteLabel.Text = "Note:"
        '
        'IsMotivationLabel
        '
        IsMotivationLabel.AutoSize = True
        IsMotivationLabel.Location = New System.Drawing.Point(40, 253)
        IsMotivationLabel.Name = "IsMotivationLabel"
        IsMotivationLabel.Size = New System.Drawing.Size(89, 16)
        IsMotivationLabel.TabIndex = 57
        IsMotivationLabel.Text = "Is Motivation:"
        '
        'MotivationPunishmentTypeIdLabel
        '
        MotivationPunishmentTypeIdLabel.AutoSize = True
        MotivationPunishmentTypeIdLabel.Location = New System.Drawing.Point(40, 141)
        MotivationPunishmentTypeIdLabel.Name = "MotivationPunishmentTypeIdLabel"
        MotivationPunishmentTypeIdLabel.Size = New System.Drawing.Size(42, 16)
        MotivationPunishmentTypeIdLabel.TabIndex = 59
        MotivationPunishmentTypeIdLabel.Text = "Type :"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(415, 32)
        Me.lblText.TabIndex = 51
        Me.lblText.Text = "Motivation Punishments"
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
        Me.lblClose.Location = New System.Drawing.Point(386, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 7
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblMotivationPunishmentBindingSource
        '
        Me.TblMotivationPunishmentBindingSource.DataSource = GetType(HR.TblMotivationPunishment)
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblMotivationPunishmentBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(145, 98)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(227, 23)
        Me.DateDateTimePicker.TabIndex = 0
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMotivationPunishmentBindingSource, "Reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(144, 211)
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(228, 23)
        Me.ReasonTextBox.TabIndex = 4
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMotivationPunishmentBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(144, 173)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(228, 23)
        Me.NoteTextBox.TabIndex = 3
        '
        'IsMotivationCheckBox
        '
        Me.IsMotivationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblMotivationPunishmentBindingSource, "IsMotivation", True))
        Me.IsMotivationCheckBox.Location = New System.Drawing.Point(144, 250)
        Me.IsMotivationCheckBox.Name = "IsMotivationCheckBox"
        Me.IsMotivationCheckBox.Size = New System.Drawing.Size(119, 24)
        Me.IsMotivationCheckBox.TabIndex = 5
        Me.IsMotivationCheckBox.UseVisualStyleBackColor = True
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(144, 58)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(228, 23)
        Me.EmployeeNameTextBox.TabIndex = 1
        '
        'MotivationPunishmentTypeIdComboBox
        '
        Me.MotivationPunishmentTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblMotivationPunishmentBindingSource, "MotivationPunishmentTypeId", True))
        Me.MotivationPunishmentTypeIdComboBox.DataSource = Me.TblMotivationPunishmentTypeBindingSource
        Me.MotivationPunishmentTypeIdComboBox.DisplayMember = "Name"
        Me.MotivationPunishmentTypeIdComboBox.FormattingEnabled = True
        Me.MotivationPunishmentTypeIdComboBox.Location = New System.Drawing.Point(145, 133)
        Me.MotivationPunishmentTypeIdComboBox.Name = "MotivationPunishmentTypeIdComboBox"
        Me.MotivationPunishmentTypeIdComboBox.Size = New System.Drawing.Size(227, 24)
        Me.MotivationPunishmentTypeIdComboBox.TabIndex = 2
        Me.MotivationPunishmentTypeIdComboBox.ValueMember = "Id"
        '
        'TblMotivationPunishmentTypeBindingSource
        '
        Me.TblMotivationPunishmentTypeBindingSource.DataSource = GetType(HR.TblMotivationPunishmentType)
        '
        'FrmMotivationPunishmentTypeBindingSource
        '
        Me.FrmMotivationPunishmentTypeBindingSource.DataSource = GetType(HR.FrmMotivationPunishmentType)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(353, 262)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.AutoSize = True
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(40, 65)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(71, 16)
        Me.EmployeeIdLabel.TabIndex = 58
        Me.EmployeeIdLabel.Text = "Employee :"
        '
        'FrmMotivationPunishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(415, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(MotivationPunishmentTypeIdLabel)
        Me.Controls.Add(Me.MotivationPunishmentTypeIdComboBox)
        Me.Controls.Add(Me.EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(IsMotivationLabel)
        Me.Controls.Add(Me.IsMotivationCheckBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(ReasonLabel)
        Me.Controls.Add(Me.ReasonTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMotivationPunishment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblMotivationPunishmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMotivationPunishmentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmMotivationPunishmentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblMotivationPunishmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReasonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsMotivationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotivationPunishmentTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblMotivationPunishmentTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrmMotivationPunishmentTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents EmployeeIdLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
