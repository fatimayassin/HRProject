<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssignEmployee
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
        Dim BatchNumberLabel As System.Windows.Forms.Label
        Dim CardNumberLabel As System.Windows.Forms.Label
        Dim PINLabel As System.Windows.Forms.Label
        Dim ContractTypeIdLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim JobIdLabel As System.Windows.Forms.Label
        Dim DepIdLabel As System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.TblEmployeeJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContractTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblContractTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.JobIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        BatchNumberLabel = New System.Windows.Forms.Label()
        CardNumberLabel = New System.Windows.Forms.Label()
        PINLabel = New System.Windows.Forms.Label()
        ContractTypeIdLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        JobIdLabel = New System.Windows.Forms.Label()
        DepIdLabel = New System.Windows.Forms.Label()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContractTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatchNumberLabel
        '
        BatchNumberLabel.AutoSize = True
        BatchNumberLabel.Location = New System.Drawing.Point(14, 100)
        BatchNumberLabel.Name = "BatchNumberLabel"
        BatchNumberLabel.Size = New System.Drawing.Size(93, 16)
        BatchNumberLabel.TabIndex = 36
        BatchNumberLabel.Text = "Batch Number:"
        '
        'CardNumberLabel
        '
        CardNumberLabel.AutoSize = True
        CardNumberLabel.Location = New System.Drawing.Point(14, 142)
        CardNumberLabel.Name = "CardNumberLabel"
        CardNumberLabel.Size = New System.Drawing.Size(89, 16)
        CardNumberLabel.TabIndex = 38
        CardNumberLabel.Text = "Card Number:"
        '
        'PINLabel
        '
        PINLabel.AutoSize = True
        PINLabel.Location = New System.Drawing.Point(14, 57)
        PINLabel.Name = "PINLabel"
        PINLabel.Size = New System.Drawing.Size(32, 16)
        PINLabel.TabIndex = 39
        PINLabel.Text = "PIN:"
        '
        'ContractTypeIdLabel
        '
        ContractTypeIdLabel.AutoSize = True
        ContractTypeIdLabel.Location = New System.Drawing.Point(328, 143)
        ContractTypeIdLabel.Name = "ContractTypeIdLabel"
        ContractTypeIdLabel.Size = New System.Drawing.Size(61, 16)
        ContractTypeIdLabel.TabIndex = 41
        ContractTypeIdLabel.Text = "Contract:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(14, 184)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(39, 16)
        NoteLabel.TabIndex = 49
        NoteLabel.Text = "Note:"
        '
        'JobIdLabel
        '
        JobIdLabel.AutoSize = True
        JobIdLabel.Location = New System.Drawing.Point(328, 100)
        JobIdLabel.Name = "JobIdLabel"
        JobIdLabel.Size = New System.Drawing.Size(32, 16)
        JobIdLabel.TabIndex = 50
        JobIdLabel.Text = "Job:"
        '
        'DepIdLabel
        '
        DepIdLabel.AutoSize = True
        DepIdLabel.Location = New System.Drawing.Point(328, 57)
        DepIdLabel.Name = "DepIdLabel"
        DepIdLabel.Size = New System.Drawing.Size(35, 16)
        DepIdLabel.TabIndex = 52
        DepIdLabel.Text = "Dep:"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(554, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 8
        Me.lblClose.Text = "X"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(580, 32)
        Me.lblText.TabIndex = 35
        Me.lblText.Text = "Assign as Employee"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataSource = GetType(HR.TblEmployee)
        '
        'BatchNumberTextBox
        '
        Me.BatchNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "BatchNumber", True))
        Me.BatchNumberTextBox.Location = New System.Drawing.Point(113, 97)
        Me.BatchNumberTextBox.Name = "BatchNumberTextBox"
        Me.BatchNumberTextBox.Size = New System.Drawing.Size(160, 23)
        Me.BatchNumberTextBox.TabIndex = 1
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "CardNumber", True))
        Me.CardNumberTextBox.Location = New System.Drawing.Point(113, 139)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(160, 23)
        Me.CardNumberTextBox.TabIndex = 2
        '
        'PINTextBox
        '
        Me.PINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "PIN", True))
        Me.PINTextBox.Location = New System.Drawing.Point(113, 54)
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.Size = New System.Drawing.Size(160, 23)
        Me.PINTextBox.TabIndex = 0
        '
        'TblEmployeeJobBindingSource
        '
        Me.TblEmployeeJobBindingSource.DataSource = GetType(HR.TblEmployeeJob)
        '
        'ContractTypeIdComboBox
        '
        Me.ContractTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "ContractTypeId", True))
        Me.ContractTypeIdComboBox.DataSource = Me.TblContractTypeBindingSource
        Me.ContractTypeIdComboBox.DisplayMember = "Name"
        Me.ContractTypeIdComboBox.FormattingEnabled = True
        Me.ContractTypeIdComboBox.Location = New System.Drawing.Point(395, 139)
        Me.ContractTypeIdComboBox.Name = "ContractTypeIdComboBox"
        Me.ContractTypeIdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.ContractTypeIdComboBox.TabIndex = 6
        Me.ContractTypeIdComboBox.ValueMember = "Id"
        '
        'TblContractTypeBindingSource
        '
        Me.TblContractTypeBindingSource.DataSource = GetType(HR.TblContractType)
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeJobBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(113, 181)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(442, 23)
        Me.NoteTextBox.TabIndex = 3
        '
        'JobIdComboBox
        '
        Me.JobIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmployeeJobBindingSource, "JobId", True))
        Me.JobIdComboBox.DataSource = Me.TblJobDescriptionBindingSource
        Me.JobIdComboBox.DisplayMember = "Name"
        Me.JobIdComboBox.FormattingEnabled = True
        Me.JobIdComboBox.Location = New System.Drawing.Point(395, 97)
        Me.JobIdComboBox.Name = "JobIdComboBox"
        Me.JobIdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.JobIdComboBox.TabIndex = 5
        Me.JobIdComboBox.ValueMember = "Id"
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
        Me.DepIdComboBox.Location = New System.Drawing.Point(395, 54)
        Me.DepIdComboBox.Name = "DepIdComboBox"
        Me.DepIdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.DepIdComboBox.TabIndex = 4
        Me.DepIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.save2
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(510, 223)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmAssignEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(DepIdLabel)
        Me.Controls.Add(Me.DepIdComboBox)
        Me.Controls.Add(JobIdLabel)
        Me.Controls.Add(Me.JobIdComboBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(ContractTypeIdLabel)
        Me.Controls.Add(Me.ContractTypeIdComboBox)
        Me.Controls.Add(PINLabel)
        Me.Controls.Add(Me.PINTextBox)
        Me.Controls.Add(CardNumberLabel)
        Me.Controls.Add(Me.CardNumberTextBox)
        Me.Controls.Add(BatchNumberLabel)
        Me.Controls.Add(Me.BatchNumberTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAssignEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContractTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblEmployeeJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContractTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblContractTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
