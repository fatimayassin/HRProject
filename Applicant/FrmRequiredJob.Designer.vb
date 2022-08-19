<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequiredJob
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
        Dim ExpectedSalaryLabel As System.Windows.Forms.Label
        Dim WayOfWorkingLabel As System.Windows.Forms.Label
        Dim JobDescriptionIdLabel As System.Windows.Forms.Label
        Dim DepartmentIdLabel As System.Windows.Forms.Label
        Dim CurrencyIdLabel As System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.ExpectedSalaryNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TblRequiredJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WayOfWorkingComboBox = New System.Windows.Forms.ComboBox()
        Me.JobDescriptionIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ExpectedSalaryLabel = New System.Windows.Forms.Label()
        WayOfWorkingLabel = New System.Windows.Forms.Label()
        JobDescriptionIdLabel = New System.Windows.Forms.Label()
        DepartmentIdLabel = New System.Windows.Forms.Label()
        CurrencyIdLabel = New System.Windows.Forms.Label()
        CType(Me.ExpectedSalaryNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpectedSalaryLabel
        '
        ExpectedSalaryLabel.AutoSize = True
        ExpectedSalaryLabel.Location = New System.Drawing.Point(34, 158)
        ExpectedSalaryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExpectedSalaryLabel.Name = "ExpectedSalaryLabel"
        ExpectedSalaryLabel.Size = New System.Drawing.Size(104, 16)
        ExpectedSalaryLabel.TabIndex = 44
        ExpectedSalaryLabel.Text = "Expected Salary:"
        '
        'WayOfWorkingLabel
        '
        WayOfWorkingLabel.AutoSize = True
        WayOfWorkingLabel.Location = New System.Drawing.Point(33, 128)
        WayOfWorkingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WayOfWorkingLabel.Name = "WayOfWorkingLabel"
        WayOfWorkingLabel.Size = New System.Drawing.Size(110, 16)
        WayOfWorkingLabel.TabIndex = 43
        WayOfWorkingLabel.Text = "Way Of Working:"
        '
        'JobDescriptionIdLabel
        '
        JobDescriptionIdLabel.AutoSize = True
        JobDescriptionIdLabel.Location = New System.Drawing.Point(34, 93)
        JobDescriptionIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        JobDescriptionIdLabel.Name = "JobDescriptionIdLabel"
        JobDescriptionIdLabel.Size = New System.Drawing.Size(105, 16)
        JobDescriptionIdLabel.TabIndex = 41
        JobDescriptionIdLabel.Text = "Job Description :"
        '
        'DepartmentIdLabel
        '
        DepartmentIdLabel.AutoSize = True
        DepartmentIdLabel.Location = New System.Drawing.Point(33, 62)
        DepartmentIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartmentIdLabel.Name = "DepartmentIdLabel"
        DepartmentIdLabel.Size = New System.Drawing.Size(85, 16)
        DepartmentIdLabel.TabIndex = 39
        DepartmentIdLabel.Text = "Department :"
        '
        'CurrencyIdLabel
        '
        CurrencyIdLabel.AutoSize = True
        CurrencyIdLabel.Location = New System.Drawing.Point(34, 194)
        CurrencyIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CurrencyIdLabel.Name = "CurrencyIdLabel"
        CurrencyIdLabel.Size = New System.Drawing.Size(67, 16)
        CurrencyIdLabel.TabIndex = 37
        CurrencyIdLabel.Text = "Currency :"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(419, 4)
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
        Me.lblText.Size = New System.Drawing.Size(447, 32)
        Me.lblText.TabIndex = 47
        Me.lblText.Text = "Required Job"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExpectedSalaryNumericUpDown
        '
        Me.ExpectedSalaryNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRequiredJobBindingSource, "ExpectedSalary", True))
        Me.ExpectedSalaryNumericUpDown.Location = New System.Drawing.Point(163, 156)
        Me.ExpectedSalaryNumericUpDown.Margin = New System.Windows.Forms.Padding(4)
        Me.ExpectedSalaryNumericUpDown.Maximum = New Decimal(New Integer() {-402653185, -1613725636, 54210108, 0})
        Me.ExpectedSalaryNumericUpDown.Name = "ExpectedSalaryNumericUpDown"
        Me.ExpectedSalaryNumericUpDown.Size = New System.Drawing.Size(230, 23)
        Me.ExpectedSalaryNumericUpDown.TabIndex = 3
        '
        'TblRequiredJobBindingSource
        '
        Me.TblRequiredJobBindingSource.DataSource = GetType(HR.TblRequiredJob)
        '
        'WayOfWorkingComboBox
        '
        Me.WayOfWorkingComboBox.FormattingEnabled = True
        Me.WayOfWorkingComboBox.Items.AddRange(New Object() {"contractor", "employee", "retired"})
        Me.WayOfWorkingComboBox.Location = New System.Drawing.Point(163, 125)
        Me.WayOfWorkingComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.WayOfWorkingComboBox.Name = "WayOfWorkingComboBox"
        Me.WayOfWorkingComboBox.Size = New System.Drawing.Size(230, 24)
        Me.WayOfWorkingComboBox.TabIndex = 2
        '
        'JobDescriptionIdComboBox
        '
        Me.JobDescriptionIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblRequiredJobBindingSource, "JobDescriptionId", True))
        Me.JobDescriptionIdComboBox.DataSource = Me.TblJobDescriptionBindingSource
        Me.JobDescriptionIdComboBox.DisplayMember = "Name"
        Me.JobDescriptionIdComboBox.FormattingEnabled = True
        Me.JobDescriptionIdComboBox.Location = New System.Drawing.Point(163, 90)
        Me.JobDescriptionIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.JobDescriptionIdComboBox.Name = "JobDescriptionIdComboBox"
        Me.JobDescriptionIdComboBox.Size = New System.Drawing.Size(230, 24)
        Me.JobDescriptionIdComboBox.TabIndex = 1
        Me.JobDescriptionIdComboBox.ValueMember = "Id"
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'DepartmentIdComboBox
        '
        Me.DepartmentIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblRequiredJobBindingSource, "DepartmentId", True))
        Me.DepartmentIdComboBox.DataSource = Me.TblDepartmentBindingSource
        Me.DepartmentIdComboBox.DisplayMember = "Name"
        Me.DepartmentIdComboBox.FormattingEnabled = True
        Me.DepartmentIdComboBox.Location = New System.Drawing.Point(163, 59)
        Me.DepartmentIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DepartmentIdComboBox.Name = "DepartmentIdComboBox"
        Me.DepartmentIdComboBox.Size = New System.Drawing.Size(230, 24)
        Me.DepartmentIdComboBox.TabIndex = 0
        Me.DepartmentIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'TblCurrencyBindingSource
        '
        Me.TblCurrencyBindingSource.DataSource = GetType(HR.TblCurrency)
        '
        'CurrencyIdComboBox
        '
        Me.CurrencyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblRequiredJobBindingSource, "CurrencyId", True))
        Me.CurrencyIdComboBox.DataSource = Me.TblCurrencyBindingSource
        Me.CurrencyIdComboBox.DisplayMember = "Name"
        Me.CurrencyIdComboBox.FormattingEnabled = True
        Me.CurrencyIdComboBox.Location = New System.Drawing.Point(163, 191)
        Me.CurrencyIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrencyIdComboBox.Name = "CurrencyIdComboBox"
        Me.CurrencyIdComboBox.Size = New System.Drawing.Size(230, 24)
        Me.CurrencyIdComboBox.TabIndex = 4
        Me.CurrencyIdComboBox.ValueMember = "Id"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(385, 233)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmRequiredJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(ExpectedSalaryLabel)
        Me.Controls.Add(Me.ExpectedSalaryNumericUpDown)
        Me.Controls.Add(WayOfWorkingLabel)
        Me.Controls.Add(Me.WayOfWorkingComboBox)
        Me.Controls.Add(JobDescriptionIdLabel)
        Me.Controls.Add(DepartmentIdLabel)
        Me.Controls.Add(Me.JobDescriptionIdComboBox)
        Me.Controls.Add(Me.DepartmentIdComboBox)
        Me.Controls.Add(Me.CurrencyIdComboBox)
        Me.Controls.Add(CurrencyIdLabel)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRequiredJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ExpectedSalaryNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents ExpectedSalaryNumericUpDown As NumericUpDown
    Friend WithEvents TblRequiredJobBindingSource As BindingSource
    Friend WithEvents WayOfWorkingComboBox As ComboBox
    Friend WithEvents JobDescriptionIdComboBox As ComboBox
    Friend WithEvents DepartmentIdComboBox As ComboBox
    Friend WithEvents TblDepartmentBindingSource As BindingSource
    Friend WithEvents TblCurrencyBindingSource As BindingSource
    Friend WithEvents CurrencyIdComboBox As ComboBox
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
