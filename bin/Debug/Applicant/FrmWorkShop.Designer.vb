<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWorkShop
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
        Dim PlaceLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TblWorkShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DateLabel = New System.Windows.Forms.Label()
        PlaceLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.TblWorkShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(13, 161)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 16)
        DateLabel.TabIndex = 49
        DateLabel.Text = "Date:"
        '
        'PlaceLabel
        '
        PlaceLabel.AutoSize = True
        PlaceLabel.Location = New System.Drawing.Point(13, 124)
        PlaceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PlaceLabel.Name = "PlaceLabel"
        PlaceLabel.Size = New System.Drawing.Size(43, 16)
        PlaceLabel.TabIndex = 47
        PlaceLabel.Text = "Place:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.AutoSize = True
        OrganizationLabel.Location = New System.Drawing.Point(13, 86)
        OrganizationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(87, 16)
        OrganizationLabel.TabIndex = 45
        OrganizationLabel.Text = "Organization:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(13, 49)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(46, 16)
        NameLabel.TabIndex = 43
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWorkShopBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(110, 46)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(265, 23)
        Me.NameTextBox.TabIndex = 0
        '
        'TblWorkShopBindingSource
        '
        Me.TblWorkShopBindingSource.DataSource = GetType(HR.TblWorkShop)
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
        Me.lblClose.TabIndex = 5
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
        Me.lblText.Size = New System.Drawing.Size(409, 32)
        Me.lblText.TabIndex = 51
        Me.lblText.Text = "WorkShops"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblWorkShopBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(110, 156)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(265, 23)
        Me.DateDateTimePicker.TabIndex = 3
        '
        'PlaceTextBox
        '
        Me.PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWorkShopBindingSource, "Place", True))
        Me.PlaceTextBox.Location = New System.Drawing.Point(110, 121)
        Me.PlaceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlaceTextBox.Name = "PlaceTextBox"
        Me.PlaceTextBox.Size = New System.Drawing.Size(265, 23)
        Me.PlaceTextBox.TabIndex = 2
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblWorkShopBindingSource, "Organization", True))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(110, 83)
        Me.OrganizationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(265, 23)
        Me.OrganizationTextBox.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(347, 199)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmWorkShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(409, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(PlaceLabel)
        Me.Controls.Add(OrganizationLabel)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.PlaceTextBox)
        Me.Controls.Add(Me.OrganizationTextBox)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmWorkShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblWorkShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TblWorkShopBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents PlaceTextBox As TextBox
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
