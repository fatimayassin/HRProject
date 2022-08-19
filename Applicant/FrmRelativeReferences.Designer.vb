<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelativeReferences
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
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim RelationLabel As System.Windows.Forms.Label
        Dim JobLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.IsInCompanyCheckBox = New System.Windows.Forms.CheckBox()
        Me.TblRelativeReferenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RelationTextBox = New System.Windows.Forms.TextBox()
        Me.JobTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        PhoneLabel = New System.Windows.Forms.Label()
        RelationLabel = New System.Windows.Forms.Label()
        JobLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.TblRelativeReferenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(20, 185)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(47, 16)
        PhoneLabel.TabIndex = 60
        PhoneLabel.Text = "Phone:"
        '
        'RelationLabel
        '
        RelationLabel.AutoSize = True
        RelationLabel.Location = New System.Drawing.Point(20, 154)
        RelationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RelationLabel.Name = "RelationLabel"
        RelationLabel.Size = New System.Drawing.Size(61, 16)
        RelationLabel.TabIndex = 59
        RelationLabel.Text = "Relation:"
        '
        'JobLabel
        '
        JobLabel.AutoSize = True
        JobLabel.Location = New System.Drawing.Point(20, 123)
        JobLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        JobLabel.Name = "JobLabel"
        JobLabel.Size = New System.Drawing.Size(31, 16)
        JobLabel.TabIndex = 58
        JobLabel.Text = "Job:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(20, 92)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(46, 16)
        NameLabel.TabIndex = 57
        NameLabel.Text = "Name:"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(380, 4)
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
        Me.lblText.Size = New System.Drawing.Size(408, 32)
        Me.lblText.TabIndex = 61
        Me.lblText.Text = "Relative References"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsInCompanyCheckBox
        '
        Me.IsInCompanyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblRelativeReferenceBindingSource, "IsInCompany", True))
        Me.IsInCompanyCheckBox.Location = New System.Drawing.Point(96, 51)
        Me.IsInCompanyCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IsInCompanyCheckBox.Name = "IsInCompanyCheckBox"
        Me.IsInCompanyCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.IsInCompanyCheckBox.TabIndex = 0
        Me.IsInCompanyCheckBox.Text = "Is in company"
        Me.IsInCompanyCheckBox.UseVisualStyleBackColor = True
        '
        'TblRelativeReferenceBindingSource
        '
        Me.TblRelativeReferenceBindingSource.DataSource = GetType(HR.TblRelativeReference)
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRelativeReferenceBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(96, 182)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(279, 23)
        Me.PhoneTextBox.TabIndex = 4
        '
        'RelationTextBox
        '
        Me.RelationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRelativeReferenceBindingSource, "Relation", True))
        Me.RelationTextBox.Location = New System.Drawing.Point(96, 151)
        Me.RelationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RelationTextBox.Name = "RelationTextBox"
        Me.RelationTextBox.Size = New System.Drawing.Size(279, 23)
        Me.RelationTextBox.TabIndex = 3
        '
        'JobTextBox
        '
        Me.JobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRelativeReferenceBindingSource, "Job", True))
        Me.JobTextBox.Location = New System.Drawing.Point(96, 120)
        Me.JobTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.JobTextBox.Name = "JobTextBox"
        Me.JobTextBox.Size = New System.Drawing.Size(279, 23)
        Me.JobTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRelativeReferenceBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(96, 89)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(279, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(346, 227)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmRelativeReferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(408, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(RelationLabel)
        Me.Controls.Add(JobLabel)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.IsInCompanyCheckBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.RelationTextBox)
        Me.Controls.Add(Me.JobTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRelativeReferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblRelativeReferenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TblRelativeReferenceBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents IsInCompanyCheckBox As CheckBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RelationTextBox As TextBox
    Friend WithEvents JobTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
