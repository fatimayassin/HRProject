<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtOldTemplate = New System.Windows.Forms.Button()
        Me.BtShowHidePass = New System.Windows.Forms.PictureBox()
        Me.CheckBoxRemember = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(127, 110)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(231, 23)
        Me.UsernameTextBox.TabIndex = 0
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataSource = GetType(HR.TblUser)
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(127, 171)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(231, 23)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'BtOldTemplate
        '
        Me.BtOldTemplate.BackColor = System.Drawing.Color.Transparent
        Me.BtOldTemplate.BackgroundImage = Global.HR.My.Resources.Resources.PreviousTemplate8
        Me.BtOldTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOldTemplate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOldTemplate.FlatAppearance.BorderSize = 0
        Me.BtOldTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOldTemplate.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOldTemplate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtOldTemplate.Location = New System.Drawing.Point(-1, 3)
        Me.BtOldTemplate.Name = "BtOldTemplate"
        Me.BtOldTemplate.Size = New System.Drawing.Size(51, 30)
        Me.BtOldTemplate.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.BtOldTemplate, "Previous Template")
        Me.BtOldTemplate.UseVisualStyleBackColor = False
        Me.BtOldTemplate.Visible = False
        '
        'BtShowHidePass
        '
        Me.BtShowHidePass.BackColor = System.Drawing.SystemColors.Window
        Me.BtShowHidePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtShowHidePass.Image = Global.HR.My.Resources.Resources.eye
        Me.BtShowHidePass.Location = New System.Drawing.Point(329, 173)
        Me.BtShowHidePass.Name = "BtShowHidePass"
        Me.BtShowHidePass.Size = New System.Drawing.Size(25, 18)
        Me.BtShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtShowHidePass.TabIndex = 85
        Me.BtShowHidePass.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtShowHidePass, "Show / Hide")
        '
        'CheckBoxRemember
        '
        Me.CheckBoxRemember.AutoSize = True
        Me.CheckBoxRemember.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRemember.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxRemember.Location = New System.Drawing.Point(241, 200)
        Me.CheckBoxRemember.Name = "CheckBoxRemember"
        Me.CheckBoxRemember.Size = New System.Drawing.Size(117, 20)
        Me.CheckBoxRemember.TabIndex = 59
        Me.CheckBoxRemember.Text = "Remember Me?"
        Me.CheckBoxRemember.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(265, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 34)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.bLogin.FlatAppearance.BorderSize = 0
        Me.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogin.ForeColor = System.Drawing.Color.White
        Me.bLogin.Location = New System.Drawing.Point(127, 231)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(93, 34)
        Me.bLogin.TabIndex = 90
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Username:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.bLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtShowHidePass)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.CheckBoxRemember)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 279)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.HR.My.Resources.Resources._44
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtOldTemplate)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtOldTemplate As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxRemember As CheckBox
    Friend WithEvents BtShowHidePass As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bLogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    'Friend WithEvents BtnLogin As Telerik.WinControls.UI.RadButton
    'Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
End Class
