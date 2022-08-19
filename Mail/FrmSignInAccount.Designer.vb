<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignInAccount
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
        Dim lSavePath As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.attachemtnSaveDirectory = New System.Windows.Forms.TextBox()
        Me.bPickPath = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxRemember = New System.Windows.Forms.CheckBox()
        Me.DelAccBtn = New System.Windows.Forms.Button()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.SelAccbtn = New System.Windows.Forms.Button()
        Me.NewBtn = New System.Windows.Forms.Button()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtShowHidePass = New System.Windows.Forms.PictureBox()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.lbAcc = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSecType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboIMAPPort = New System.Windows.Forms.ComboBox()
        Me.ComboPop3Port = New System.Windows.Forms.ComboBox()
        Me.ComboSMTPPort = New System.Windows.Forms.ComboBox()
        Me.TextOtherHost = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.tbhostname = New System.Windows.Forms.ComboBox()
        Me.arrow = New System.Windows.Forms.Label()
        lSavePath = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lSavePath
        '
        lSavePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lSavePath.AutoSize = True
        lSavePath.Location = New System.Drawing.Point(8, 427)
        lSavePath.Name = "lSavePath"
        lSavePath.Size = New System.Drawing.Size(130, 15)
        lSavePath.TabIndex = 148
        lSavePath.Text = "Attachment Directory:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(225, 180)
        Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(36, 15)
        Label7.TabIndex = 136
        Label7.Text = "Login"
        '
        'label4
        '
        label4.AutoSize = True
        label4.Location = New System.Drawing.Point(225, 213)
        label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(59, 15)
        label4.TabIndex = 137
        label4.Text = "Password"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(225, 87)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 15)
        Label1.TabIndex = 126
        Label1.Text = "IMAP Port # :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(225, 149)
        Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(80, 15)
        Label8.TabIndex = 123
        Label8.Text = "SMTP Port # :"
        '
        'label2
        '
        label2.AutoSize = True
        label2.Location = New System.Drawing.Point(224, 118)
        label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(81, 15)
        label2.TabIndex = 118
        label2.Text = "POP3 Port # :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(225, 53)
        Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(76, 15)
        Label3.TabIndex = 117
        Label3.Text = "Host / Server"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(lSavePath)
        Me.Panel1.Controls.Add(Me.attachemtnSaveDirectory)
        Me.Panel1.Controls.Add(Me.bPickPath)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CheckBoxRemember)
        Me.Panel1.Controls.Add(Me.DelAccBtn)
        Me.Panel1.Controls.Add(Me.label14)
        Me.Panel1.Controls.Add(Me.label13)
        Me.Panel1.Controls.Add(Me.SelAccbtn)
        Me.Panel1.Controls.Add(Me.NewBtn)
        Me.Panel1.Controls.Add(Me.SetBtn)
        Me.Panel1.Controls.Add(Me.txtAccName)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.tbLogin)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tbuser)
        Me.Panel1.Controls.Add(label4)
        Me.Panel1.Controls.Add(Me.lbAcc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbSecType)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboIMAPPort)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.ComboPop3Port)
        Me.Panel1.Controls.Add(Me.ComboSMTPPort)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.TextOtherHost)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.tbhostname)
        Me.Panel1.Controls.Add(Me.arrow)
        Me.Panel1.Controls.Add(label2)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 464)
        Me.Panel1.TabIndex = 0
        '
        'attachemtnSaveDirectory
        '
        Me.attachemtnSaveDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.attachemtnSaveDirectory.Location = New System.Drawing.Point(153, 424)
        Me.attachemtnSaveDirectory.Name = "attachemtnSaveDirectory"
        Me.attachemtnSaveDirectory.ReadOnly = True
        Me.attachemtnSaveDirectory.Size = New System.Drawing.Size(224, 22)
        Me.attachemtnSaveDirectory.TabIndex = 149
        Me.attachemtnSaveDirectory.Text = ".\"
        '
        'bPickPath
        '
        Me.bPickPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPickPath.BackColor = System.Drawing.SystemColors.Highlight
        Me.bPickPath.FlatAppearance.BorderSize = 0
        Me.bPickPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPickPath.ForeColor = System.Drawing.Color.White
        Me.bPickPath.Location = New System.Drawing.Point(382, 421)
        Me.bPickPath.Name = "bPickPath"
        Me.bPickPath.Size = New System.Drawing.Size(38, 27)
        Me.bPickPath.TabIndex = 147
        Me.bPickPath.Text = "..."
        Me.bPickPath.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(435, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 27)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "Go To Mail"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'CheckBoxRemember
        '
        Me.CheckBoxRemember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxRemember.AutoSize = True
        Me.CheckBoxRemember.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRemember.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxRemember.Location = New System.Drawing.Point(489, 323)
        Me.CheckBoxRemember.Name = "CheckBoxRemember"
        Me.CheckBoxRemember.Size = New System.Drawing.Size(170, 19)
        Me.CheckBoxRemember.TabIndex = 134
        Me.CheckBoxRemember.Text = "Remember Using Account?"
        Me.CheckBoxRemember.UseVisualStyleBackColor = True
        '
        'DelAccBtn
        '
        Me.DelAccBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.DelAccBtn.FlatAppearance.BorderSize = 0
        Me.DelAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelAccBtn.ForeColor = System.Drawing.Color.White
        Me.DelAccBtn.Location = New System.Drawing.Point(12, 359)
        Me.DelAccBtn.Name = "DelAccBtn"
        Me.DelAccBtn.Size = New System.Drawing.Size(142, 39)
        Me.DelAccBtn.TabIndex = 145
        Me.DelAccBtn.Text = "Remove Selected Account"
        Me.DelAccBtn.UseVisualStyleBackColor = False
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(250, 323)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(0, 15)
        Me.label14.TabIndex = 144
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(160, 324)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(85, 15)
        Me.label13.TabIndex = 143
        Me.label13.Text = "Used account: "
        '
        'SelAccbtn
        '
        Me.SelAccbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.SelAccbtn.FlatAppearance.BorderSize = 0
        Me.SelAccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelAccbtn.ForeColor = System.Drawing.Color.White
        Me.SelAccbtn.Location = New System.Drawing.Point(12, 318)
        Me.SelAccbtn.Name = "SelAccbtn"
        Me.SelAccbtn.Size = New System.Drawing.Size(142, 27)
        Me.SelAccbtn.TabIndex = 142
        Me.SelAccbtn.Text = "Use Selected Account"
        Me.SelAccbtn.UseVisualStyleBackColor = False
        '
        'NewBtn
        '
        Me.NewBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.NewBtn.FlatAppearance.BorderSize = 0
        Me.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewBtn.ForeColor = System.Drawing.Color.White
        Me.NewBtn.Location = New System.Drawing.Point(369, 278)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(83, 27)
        Me.NewBtn.TabIndex = 141
        Me.NewBtn.Text = "Save as new"
        Me.NewBtn.UseVisualStyleBackColor = False
        '
        'SetBtn
        '
        Me.SetBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.SetBtn.FlatAppearance.BorderSize = 0
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.ForeColor = System.Drawing.Color.White
        Me.SetBtn.Location = New System.Drawing.Point(489, 278)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(91, 27)
        Me.SetBtn.TabIndex = 140
        Me.SetBtn.Text = "Set changes"
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'txtAccName
        '
        Me.txtAccName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccName.Location = New System.Drawing.Point(337, 11)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(315, 22)
        Me.txtAccName.TabIndex = 133
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.tbPassword)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(337, 203)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(316, 32)
        Me.Panel6.TabIndex = 139
        '
        'tbPassword
        '
        Me.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPassword.Location = New System.Drawing.Point(0, 0)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(275, 22)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(275, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(41, 32)
        Me.Panel7.TabIndex = 89
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.BtShowHidePass)
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(41, 27)
        Me.Panel11.TabIndex = 0
        '
        'BtShowHidePass
        '
        Me.BtShowHidePass.BackColor = System.Drawing.Color.Transparent
        Me.BtShowHidePass.BackgroundImage = Global.HR.My.Resources.Resources.icons8_eye_20
        Me.BtShowHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtShowHidePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtShowHidePass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtShowHidePass.Location = New System.Drawing.Point(0, 0)
        Me.BtShowHidePass.Name = "BtShowHidePass"
        Me.BtShowHidePass.Size = New System.Drawing.Size(41, 27)
        Me.BtShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtShowHidePass.TabIndex = 88
        Me.BtShowHidePass.TabStop = False
        '
        'tbLogin
        '
        Me.tbLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLogin.BackColor = System.Drawing.SystemColors.Control
        Me.tbLogin.Location = New System.Drawing.Point(489, 172)
        Me.tbLogin.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.ReadOnly = True
        Me.tbLogin.Size = New System.Drawing.Size(163, 22)
        Me.tbLogin.TabIndex = 135
        Me.tbLogin.Text = "Select Host"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Account Name:"
        '
        'tbuser
        '
        Me.tbuser.BackColor = System.Drawing.SystemColors.Window
        Me.tbuser.Location = New System.Drawing.Point(337, 172)
        Me.tbuser.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.ReadOnly = True
        Me.tbuser.Size = New System.Drawing.Size(131, 22)
        Me.tbuser.TabIndex = 138
        '
        'lbAcc
        '
        Me.lbAcc.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lbAcc.FormattingEnabled = True
        Me.lbAcc.ItemHeight = 15
        Me.lbAcc.Location = New System.Drawing.Point(12, 42)
        Me.lbAcc.Name = "lbAcc"
        Me.lbAcc.Size = New System.Drawing.Size(209, 229)
        Me.lbAcc.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "All accounts:"
        '
        'cbSecType
        '
        Me.cbSecType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSecType.FormattingEnabled = True
        Me.cbSecType.Items.AddRange(New Object() {"Plain", "SSL", "StartTsl"})
        Me.cbSecType.Location = New System.Drawing.Point(337, 244)
        Me.cbSecType.Name = "cbSecType"
        Me.cbSecType.Size = New System.Drawing.Size(315, 23)
        Me.cbSecType.TabIndex = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Security:"
        '
        'ComboIMAPPort
        '
        Me.ComboIMAPPort.FormattingEnabled = True
        Me.ComboIMAPPort.Items.AddRange(New Object() {"993", "143"})
        Me.ComboIMAPPort.Location = New System.Drawing.Point(337, 78)
        Me.ComboIMAPPort.Name = "ComboIMAPPort"
        Me.ComboIMAPPort.Size = New System.Drawing.Size(131, 23)
        Me.ComboIMAPPort.TabIndex = 127
        '
        'ComboPop3Port
        '
        Me.ComboPop3Port.FormattingEnabled = True
        Me.ComboPop3Port.Items.AddRange(New Object() {"995", "110"})
        Me.ComboPop3Port.Location = New System.Drawing.Point(337, 109)
        Me.ComboPop3Port.Name = "ComboPop3Port"
        Me.ComboPop3Port.Size = New System.Drawing.Size(131, 23)
        Me.ComboPop3Port.TabIndex = 125
        '
        'ComboSMTPPort
        '
        Me.ComboSMTPPort.FormattingEnabled = True
        Me.ComboSMTPPort.Items.AddRange(New Object() {"587", "2525", "465"})
        Me.ComboSMTPPort.Location = New System.Drawing.Point(337, 140)
        Me.ComboSMTPPort.Name = "ComboSMTPPort"
        Me.ComboSMTPPort.Size = New System.Drawing.Size(131, 23)
        Me.ComboSMTPPort.TabIndex = 124
        '
        'TextOtherHost
        '
        Me.TextOtherHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextOtherHost.Location = New System.Drawing.Point(489, 45)
        Me.TextOtherHost.Name = "TextOtherHost"
        Me.TextOtherHost.Size = New System.Drawing.Size(165, 22)
        Me.TextOtherHost.TabIndex = 122
        Me.TextOtherHost.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Hotmail", "Live"})
        Me.ComboBox2.Location = New System.Drawing.Point(489, 103)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox2.TabIndex = 121
        Me.ComboBox2.Visible = False
        '
        'tbhostname
        '
        Me.tbhostname.FormattingEnabled = True
        Me.tbhostname.Items.AddRange(New Object() {"imap.gmail.com", "imap.live.com", "imap.mail.yahoo.com", "Other"})
        Me.tbhostname.Location = New System.Drawing.Point(337, 44)
        Me.tbhostname.Name = "tbhostname"
        Me.tbhostname.Size = New System.Drawing.Size(131, 23)
        Me.tbhostname.TabIndex = 120
        '
        'arrow
        '
        Me.arrow.AutoSize = True
        Me.arrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrow.ForeColor = System.Drawing.Color.Blue
        Me.arrow.Location = New System.Drawing.Point(469, 111)
        Me.arrow.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(21, 15)
        Me.arrow.TabIndex = 119
        Me.arrow.Text = ">>"
        Me.arrow.Visible = False
        '
        'FrmSignInAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSignInAccount"
        Me.Text = "FrmSignInAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Public WithEvents attachemtnSaveDirectory As TextBox
    Private WithEvents bPickPath As Button
    Private WithEvents Button1 As Button
    Friend WithEvents CheckBoxRemember As CheckBox
    Private WithEvents DelAccBtn As Button
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents SelAccbtn As Button
    Private WithEvents NewBtn As Button
    Private WithEvents SetBtn As Button
    Private WithEvents txtAccName As TextBox
    Friend WithEvents Panel6 As Panel
    Public WithEvents tbPassword As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BtShowHidePass As PictureBox
    Public WithEvents tbLogin As TextBox
    Private WithEvents Label9 As Label
    Public WithEvents tbuser As TextBox
    Private WithEvents lbAcc As ListBox
    Private WithEvents Label6 As Label
    Private WithEvents cbSecType As ComboBox
    Private WithEvents Label5 As Label
    Public WithEvents ComboIMAPPort As ComboBox
    Public WithEvents ComboPop3Port As ComboBox
    Public WithEvents ComboSMTPPort As ComboBox
    Friend WithEvents TextOtherHost As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents tbhostname As ComboBox
    Friend WithEvents arrow As Label
End Class
