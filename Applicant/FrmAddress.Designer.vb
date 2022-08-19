<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddress
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
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim PropertyTypeLabel As System.Windows.Forms.Label
        Dim NearLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BuildingLabel As System.Windows.Forms.Label
        Dim FloorLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Me.lblText = New System.Windows.Forms.Label()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.TblAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.NearTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BuildingTextBox = New System.Windows.Forms.TextBox()
        Me.FloorTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DistrictLabel = New System.Windows.Forms.Label()
        PropertyTypeLabel = New System.Windows.Forms.Label()
        NearLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BuildingLabel = New System.Windows.Forms.Label()
        FloorLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        CType(Me.TblAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DistrictLabel
        '
        DistrictLabel.AutoSize = True
        DistrictLabel.Location = New System.Drawing.Point(63, 108)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(59, 16)
        DistrictLabel.TabIndex = 49
        DistrictLabel.Text = "District :"
        '
        'PropertyTypeLabel
        '
        PropertyTypeLabel.AutoSize = True
        PropertyTypeLabel.Location = New System.Drawing.Point(17, 268)
        PropertyTypeLabel.Name = "PropertyTypeLabel"
        PropertyTypeLabel.Size = New System.Drawing.Size(96, 16)
        PropertyTypeLabel.TabIndex = 47
        PropertyTypeLabel.Text = "Property Type :"
        '
        'NearLabel
        '
        NearLabel.AutoSize = True
        NearLabel.Location = New System.Drawing.Point(79, 236)
        NearLabel.Name = "NearLabel"
        NearLabel.Size = New System.Drawing.Size(43, 16)
        NearLabel.TabIndex = 46
        NearLabel.Text = "Near :"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(45, 76)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(74, 16)
        AddressLabel.TabIndex = 42
        AddressLabel.Text = "City/Town :"
        '
        'BuildingLabel
        '
        BuildingLabel.AutoSize = True
        BuildingLabel.Location = New System.Drawing.Point(61, 172)
        BuildingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuildingLabel.Name = "BuildingLabel"
        BuildingLabel.Size = New System.Drawing.Size(62, 16)
        BuildingLabel.TabIndex = 43
        BuildingLabel.Text = "Building :"
        '
        'FloorLabel
        '
        FloorLabel.AutoSize = True
        FloorLabel.Location = New System.Drawing.Point(78, 208)
        FloorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FloorLabel.Name = "FloorLabel"
        FloorLabel.Size = New System.Drawing.Size(44, 16)
        FloorLabel.TabIndex = 44
        FloorLabel.Text = "Floor :"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(68, 140)
        StreetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(50, 16)
        StreetLabel.TabIndex = 45
        StreetLabel.Text = "Street :"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(437, 32)
        Me.lblText.TabIndex = 33
        Me.lblText.Text = "Address Info"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "District", True))
        Me.DistrictTextBox.Location = New System.Drawing.Point(131, 105)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(255, 23)
        Me.DistrictTextBox.TabIndex = 1
        '
        'TblAddressBindingSource
        '
        Me.TblAddressBindingSource.DataSource = GetType(HR.TblAddress)
        '
        'PropertyTypeComboBox
        '
        Me.PropertyTypeComboBox.FormattingEnabled = True
        Me.PropertyTypeComboBox.Items.AddRange(New Object() {"Owner", "Renter", "With parents", "Investment"})
        Me.PropertyTypeComboBox.Location = New System.Drawing.Point(131, 265)
        Me.PropertyTypeComboBox.Name = "PropertyTypeComboBox"
        Me.PropertyTypeComboBox.Size = New System.Drawing.Size(255, 24)
        Me.PropertyTypeComboBox.TabIndex = 6
        '
        'NearTextBox
        '
        Me.NearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "Near", True))
        Me.NearTextBox.Location = New System.Drawing.Point(131, 233)
        Me.NearTextBox.Name = "NearTextBox"
        Me.NearTextBox.Size = New System.Drawing.Size(255, 23)
        Me.NearTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "City_Town", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(131, 73)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(255, 23)
        Me.AddressTextBox.TabIndex = 0
        '
        'BuildingTextBox
        '
        Me.BuildingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "Building", True))
        Me.BuildingTextBox.Location = New System.Drawing.Point(131, 169)
        Me.BuildingTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BuildingTextBox.Name = "BuildingTextBox"
        Me.BuildingTextBox.Size = New System.Drawing.Size(255, 23)
        Me.BuildingTextBox.TabIndex = 3
        '
        'FloorTextBox
        '
        Me.FloorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "Floor", True))
        Me.FloorTextBox.Location = New System.Drawing.Point(131, 201)
        Me.FloorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FloorTextBox.Name = "FloorTextBox"
        Me.FloorTextBox.Size = New System.Drawing.Size(255, 23)
        Me.FloorTextBox.TabIndex = 4
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAddressBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(131, 137)
        Me.StreetTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(255, 23)
        Me.StreetTextBox.TabIndex = 2
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(410, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 8
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(375, 304)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(DistrictLabel)
        Me.Controls.Add(Me.DistrictTextBox)
        Me.Controls.Add(PropertyTypeLabel)
        Me.Controls.Add(Me.PropertyTypeComboBox)
        Me.Controls.Add(NearLabel)
        Me.Controls.Add(Me.NearTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(BuildingLabel)
        Me.Controls.Add(FloorLabel)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.BuildingTextBox)
        Me.Controls.Add(Me.FloorTextBox)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As Label
    Friend WithEvents TblAddressBindingSource As BindingSource
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents PropertyTypeComboBox As ComboBox
    Friend WithEvents NearTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents BuildingTextBox As TextBox
    Friend WithEvents FloorTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents lblClose As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
