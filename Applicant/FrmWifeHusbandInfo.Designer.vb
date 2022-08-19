<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWifeHusbandInfo
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
        Dim JobLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.JobTextBox = New System.Windows.Forms.TextBox()
        Me.TblWifeHusbandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NSSFSideComboBox = New System.Windows.Forms.ComboBox()
        Me.InCompanyCheckBox = New System.Windows.Forms.CheckBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        JobLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        CType(Me.TblWifeHusbandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JobLabel
        '
        JobLabel.AutoSize = True
        JobLabel.Location = New System.Drawing.Point(19, 156)
        JobLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        JobLabel.Name = "JobLabel"
        JobLabel.Size = New System.Drawing.Size(31, 16)
        JobLabel.TabIndex = 51
        JobLabel.Text = "Job:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(19, 123)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(74, 16)
        LastNameLabel.TabIndex = 47
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(19, 87)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel.TabIndex = 45
        FirstNameLabel.Text = "First Name:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(18, 182)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(95, 16)
        MaritalStatusLabel.TabIndex = 57
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Guaranator:"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(393, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 7
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
        Me.lblText.Size = New System.Drawing.Size(423, 32)
        Me.lblText.TabIndex = 53
        Me.lblText.Text = "Wife/Husband info "
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'JobTextBox
        '
        Me.JobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWifeHusbandBindingSource, "Job", True))
        Me.JobTextBox.Location = New System.Drawing.Point(129, 149)
        Me.JobTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.JobTextBox.Name = "JobTextBox"
        Me.JobTextBox.Size = New System.Drawing.Size(263, 23)
        Me.JobTextBox.TabIndex = 3
        '
        'TblWifeHusbandBindingSource
        '
        Me.TblWifeHusbandBindingSource.DataSource = GetType(HR.TblWifeHusband)
        '
        'NSSFSideComboBox
        '
        Me.NSSFSideComboBox.FormattingEnabled = True
        Me.NSSFSideComboBox.Items.AddRange(New Object() {"Daman", "Company", "None"})
        Me.NSSFSideComboBox.Location = New System.Drawing.Point(128, 210)
        Me.NSSFSideComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NSSFSideComboBox.Name = "NSSFSideComboBox"
        Me.NSSFSideComboBox.Size = New System.Drawing.Size(263, 24)
        Me.NSSFSideComboBox.TabIndex = 5
        '
        'InCompanyCheckBox
        '
        Me.InCompanyCheckBox.Checked = True
        Me.InCompanyCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.InCompanyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblWifeHusbandBindingSource, "InCompany", True))
        Me.InCompanyCheckBox.Location = New System.Drawing.Point(129, 45)
        Me.InCompanyCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InCompanyCheckBox.Name = "InCompanyCheckBox"
        Me.InCompanyCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.InCompanyCheckBox.TabIndex = 0
        Me.InCompanyCheckBox.Text = "In Company"
        Me.InCompanyCheckBox.UseVisualStyleBackColor = True
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWifeHusbandBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(129, 116)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(263, 23)
        Me.LastNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWifeHusbandBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(129, 83)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(263, 23)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Still Married", "Divorced"})
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(129, 179)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(262, 24)
        Me.MaritalStatusComboBox.TabIndex = 4
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(361, 250)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmWifeHusbandInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(MaritalStatusLabel)
        Me.Controls.Add(Me.MaritalStatusComboBox)
        Me.Controls.Add(JobLabel)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.JobTextBox)
        Me.Controls.Add(Me.NSSFSideComboBox)
        Me.Controls.Add(Me.InCompanyCheckBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmWifeHusbandInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblWifeHusbandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TblWifeHusbandBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents JobTextBox As TextBox
    Friend WithEvents NSSFSideComboBox As ComboBox
    Friend WithEvents InCompanyCheckBox As CheckBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MaritalStatusComboBox As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
