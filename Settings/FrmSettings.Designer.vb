<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ApplicantStatusIdLabel As System.Windows.Forms.Label
        Dim EmployeeStatusIdLabel As System.Windows.Forms.Label
        Dim RetiredStatusIdLabel As System.Windows.Forms.Label
        Dim TraineeStatutsIdLabel As System.Windows.Forms.Label
        Dim YearlyVacationTypeIdLabel As System.Windows.Forms.Label
        Dim TraineePositionIdLabel As System.Windows.Forms.Label
        Dim UnemploymentStatusIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TblSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApplicantStatusIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeStatusIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetiredStatusIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStatusBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraineeStatutsIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStatusBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearlyVacationTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TraineePositionIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PBApplicantImage = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UnemploymentStatusIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStatusBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSettingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ApplicantStatusIdLabel = New System.Windows.Forms.Label()
        EmployeeStatusIdLabel = New System.Windows.Forms.Label()
        RetiredStatusIdLabel = New System.Windows.Forms.Label()
        TraineeStatutsIdLabel = New System.Windows.Forms.Label()
        YearlyVacationTypeIdLabel = New System.Windows.Forms.Label()
        TraineePositionIdLabel = New System.Windows.Forms.Label()
        UnemploymentStatusIdLabel = New System.Windows.Forms.Label()
        CType(Me.TblSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatusBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatusBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBApplicantImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatusBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSettingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicantStatusIdLabel
        '
        ApplicantStatusIdLabel.AutoSize = True
        ApplicantStatusIdLabel.Location = New System.Drawing.Point(12, 56)
        ApplicantStatusIdLabel.Name = "ApplicantStatusIdLabel"
        ApplicantStatusIdLabel.Size = New System.Drawing.Size(110, 16)
        ApplicantStatusIdLabel.TabIndex = 38
        ApplicantStatusIdLabel.Text = "Applicant Status :"
        '
        'EmployeeStatusIdLabel
        '
        EmployeeStatusIdLabel.AutoSize = True
        EmployeeStatusIdLabel.Location = New System.Drawing.Point(12, 131)
        EmployeeStatusIdLabel.Name = "EmployeeStatusIdLabel"
        EmployeeStatusIdLabel.Size = New System.Drawing.Size(111, 16)
        EmployeeStatusIdLabel.TabIndex = 39
        EmployeeStatusIdLabel.Text = "Employee Status :"
        '
        'RetiredStatusIdLabel
        '
        RetiredStatusIdLabel.AutoSize = True
        RetiredStatusIdLabel.Location = New System.Drawing.Point(12, 208)
        RetiredStatusIdLabel.Name = "RetiredStatusIdLabel"
        RetiredStatusIdLabel.Size = New System.Drawing.Size(98, 16)
        RetiredStatusIdLabel.TabIndex = 40
        RetiredStatusIdLabel.Text = "Retired Status :"
        '
        'TraineeStatutsIdLabel
        '
        TraineeStatutsIdLabel.AutoSize = True
        TraineeStatutsIdLabel.Location = New System.Drawing.Point(12, 93)
        TraineeStatutsIdLabel.Name = "TraineeStatutsIdLabel"
        TraineeStatutsIdLabel.Size = New System.Drawing.Size(103, 16)
        TraineeStatutsIdLabel.TabIndex = 41
        TraineeStatutsIdLabel.Text = "Trainee Statuts :"
        '
        'YearlyVacationTypeIdLabel
        '
        YearlyVacationTypeIdLabel.AutoSize = True
        YearlyVacationTypeIdLabel.Location = New System.Drawing.Point(12, 247)
        YearlyVacationTypeIdLabel.Name = "YearlyVacationTypeIdLabel"
        YearlyVacationTypeIdLabel.Size = New System.Drawing.Size(103, 16)
        YearlyVacationTypeIdLabel.TabIndex = 43
        YearlyVacationTypeIdLabel.Text = "Yearly Vacation:"
        '
        'TraineePositionIdLabel
        '
        TraineePositionIdLabel.AutoSize = True
        TraineePositionIdLabel.Location = New System.Drawing.Point(12, 280)
        TraineePositionIdLabel.Name = "TraineePositionIdLabel"
        TraineePositionIdLabel.Size = New System.Drawing.Size(106, 16)
        TraineePositionIdLabel.TabIndex = 43
        TraineePositionIdLabel.Text = "Trainee Position:"
        '
        'UnemploymentStatusIdLabel
        '
        UnemploymentStatusIdLabel.AutoSize = True
        UnemploymentStatusIdLabel.Location = New System.Drawing.Point(12, 171)
        UnemploymentStatusIdLabel.Name = "UnemploymentStatusIdLabel"
        UnemploymentStatusIdLabel.Size = New System.Drawing.Size(140, 16)
        UnemploymentStatusIdLabel.TabIndex = 45
        UnemploymentStatusIdLabel.Text = "Unemployment Status:"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(449, 3)
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
        Me.lblText.Size = New System.Drawing.Size(477, 32)
        Me.lblText.TabIndex = 36
        Me.lblText.Text = "Settings"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblSettingBindingSource
        '
        Me.TblSettingBindingSource.DataSource = GetType(HR.TblSetting)
        '
        'ApplicantStatusIdComboBox
        '
        Me.ApplicantStatusIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "ApplicantStatusId", True))
        Me.ApplicantStatusIdComboBox.DataSource = Me.TblStatusBindingSource
        Me.ApplicantStatusIdComboBox.DisplayMember = "Name"
        Me.ApplicantStatusIdComboBox.FormattingEnabled = True
        Me.ApplicantStatusIdComboBox.Location = New System.Drawing.Point(158, 48)
        Me.ApplicantStatusIdComboBox.Name = "ApplicantStatusIdComboBox"
        Me.ApplicantStatusIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ApplicantStatusIdComboBox.TabIndex = 0
        Me.ApplicantStatusIdComboBox.ValueMember = "Id"
        '
        'TblStatusBindingSource
        '
        Me.TblStatusBindingSource.DataSource = GetType(HR.TblStatus)
        '
        'EmployeeStatusIdComboBox
        '
        Me.EmployeeStatusIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "EmployeeStatusId", True))
        Me.EmployeeStatusIdComboBox.DataSource = Me.TblStatusBindingSource1
        Me.EmployeeStatusIdComboBox.DisplayMember = "Name"
        Me.EmployeeStatusIdComboBox.FormattingEnabled = True
        Me.EmployeeStatusIdComboBox.Location = New System.Drawing.Point(158, 123)
        Me.EmployeeStatusIdComboBox.Name = "EmployeeStatusIdComboBox"
        Me.EmployeeStatusIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.EmployeeStatusIdComboBox.TabIndex = 2
        Me.EmployeeStatusIdComboBox.ValueMember = "Id"
        '
        'TblStatusBindingSource1
        '
        Me.TblStatusBindingSource1.DataSource = GetType(HR.TblStatus)
        '
        'RetiredStatusIdComboBox
        '
        Me.RetiredStatusIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "RetiredStatusId", True))
        Me.RetiredStatusIdComboBox.DataSource = Me.TblStatusBindingSource2
        Me.RetiredStatusIdComboBox.DisplayMember = "Name"
        Me.RetiredStatusIdComboBox.FormattingEnabled = True
        Me.RetiredStatusIdComboBox.Location = New System.Drawing.Point(158, 200)
        Me.RetiredStatusIdComboBox.Name = "RetiredStatusIdComboBox"
        Me.RetiredStatusIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.RetiredStatusIdComboBox.TabIndex = 3
        Me.RetiredStatusIdComboBox.ValueMember = "Id"
        '
        'TblStatusBindingSource2
        '
        Me.TblStatusBindingSource2.DataSource = GetType(HR.TblStatus)
        '
        'TraineeStatutsIdComboBox
        '
        Me.TraineeStatutsIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "TraineeStatutsId", True))
        Me.TraineeStatutsIdComboBox.DataSource = Me.TblStatusBindingSource3
        Me.TraineeStatutsIdComboBox.DisplayMember = "Name"
        Me.TraineeStatutsIdComboBox.FormattingEnabled = True
        Me.TraineeStatutsIdComboBox.Location = New System.Drawing.Point(158, 85)
        Me.TraineeStatutsIdComboBox.Name = "TraineeStatutsIdComboBox"
        Me.TraineeStatutsIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TraineeStatutsIdComboBox.TabIndex = 1
        Me.TraineeStatutsIdComboBox.ValueMember = "Id"
        '
        'TblStatusBindingSource3
        '
        Me.TblStatusBindingSource3.DataSource = GetType(HR.TblStatus)
        '
        'YearlyVacationTypeIdComboBox
        '
        Me.YearlyVacationTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "YearlyVacationId", True))
        Me.YearlyVacationTypeIdComboBox.DataSource = Me.TblVacationBindingSource
        Me.YearlyVacationTypeIdComboBox.DisplayMember = "Description"
        Me.YearlyVacationTypeIdComboBox.FormattingEnabled = True
        Me.YearlyVacationTypeIdComboBox.Location = New System.Drawing.Point(158, 239)
        Me.YearlyVacationTypeIdComboBox.Name = "YearlyVacationTypeIdComboBox"
        Me.YearlyVacationTypeIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.YearlyVacationTypeIdComboBox.TabIndex = 4
        Me.YearlyVacationTypeIdComboBox.ValueMember = "Id"
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(418, 249)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TraineePositionIdComboBox
        '
        Me.TraineePositionIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "TraineePositionId", True))
        Me.TraineePositionIdComboBox.DataSource = Me.TblPositionBindingSource
        Me.TraineePositionIdComboBox.DisplayMember = "Name"
        Me.TraineePositionIdComboBox.FormattingEnabled = True
        Me.TraineePositionIdComboBox.Location = New System.Drawing.Point(158, 272)
        Me.TraineePositionIdComboBox.Name = "TraineePositionIdComboBox"
        Me.TraineePositionIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TraineePositionIdComboBox.TabIndex = 44
        Me.TraineePositionIdComboBox.ValueMember = "Id"
        '
        'TblPositionBindingSource
        '
        Me.TblPositionBindingSource.DataSource = GetType(HR.TblPosition)
        '
        'PBApplicantImage
        '
        Me.PBApplicantImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBApplicantImage.Image = CType(resources.GetObject("PBApplicantImage.Image"), System.Drawing.Image)
        Me.PBApplicantImage.Location = New System.Drawing.Point(316, 48)
        Me.PBApplicantImage.Name = "PBApplicantImage"
        Me.PBApplicantImage.Size = New System.Drawing.Size(147, 152)
        Me.PBApplicantImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBApplicantImage.TabIndex = 45
        Me.PBApplicantImage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBApplicantImage, "Add Default Image For Applicant")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UnemploymentStatusIdComboBox
        '
        Me.UnemploymentStatusIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSettingBindingSource, "UnemploymentStatusId", True))
        Me.UnemploymentStatusIdComboBox.DataSource = Me.TblStatusBindingSource4
        Me.UnemploymentStatusIdComboBox.DisplayMember = "Name"
        Me.UnemploymentStatusIdComboBox.FormattingEnabled = True
        Me.UnemploymentStatusIdComboBox.Location = New System.Drawing.Point(158, 163)
        Me.UnemploymentStatusIdComboBox.Name = "UnemploymentStatusIdComboBox"
        Me.UnemploymentStatusIdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.UnemploymentStatusIdComboBox.TabIndex = 46
        Me.UnemploymentStatusIdComboBox.ValueMember = "Id"
        '
        'TblStatusBindingSource4
        '
        Me.TblStatusBindingSource4.DataSource = GetType(HR.TblStatus)
        '
        'TblSettingBindingSource1
        '
        Me.TblSettingBindingSource1.DataSource = GetType(HR.TblSetting)
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 309)
        Me.ControlBox = False
        Me.Controls.Add(UnemploymentStatusIdLabel)
        Me.Controls.Add(Me.UnemploymentStatusIdComboBox)
        Me.Controls.Add(Me.PBApplicantImage)
        Me.Controls.Add(TraineePositionIdLabel)
        Me.Controls.Add(Me.TraineePositionIdComboBox)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(YearlyVacationTypeIdLabel)
        Me.Controls.Add(Me.YearlyVacationTypeIdComboBox)
        Me.Controls.Add(TraineeStatutsIdLabel)
        Me.Controls.Add(Me.TraineeStatutsIdComboBox)
        Me.Controls.Add(RetiredStatusIdLabel)
        Me.Controls.Add(Me.RetiredStatusIdComboBox)
        Me.Controls.Add(EmployeeStatusIdLabel)
        Me.Controls.Add(Me.EmployeeStatusIdComboBox)
        Me.Controls.Add(ApplicantStatusIdLabel)
        Me.Controls.Add(Me.ApplicantStatusIdComboBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblSettingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatusBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatusBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBApplicantImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatusBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSettingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblSettingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantStatusIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeStatusIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RetiredStatusIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TraineeStatutsIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStatusBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblStatusBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblStatusBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents YearlyVacationTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TraineePositionIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblPositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PBApplicantImage As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UnemploymentStatusIdComboBox As ComboBox
    Friend WithEvents TblStatusBindingSource4 As BindingSource
    Friend WithEvents TblSettingBindingSource1 As BindingSource
End Class
