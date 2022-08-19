<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMailSignIn
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
        Dim groupBox1 As System.Windows.Forms.GroupBox
        Dim Label8 As System.Windows.Forms.Label
        Dim label6 As System.Windows.Forms.Label
        Dim label5 As System.Windows.Forms.Label
        Dim label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim groupBox2 As System.Windows.Forms.GroupBox
        Dim Label7 As System.Windows.Forms.Label
        Dim label4 As System.Windows.Forms.Label
        Me.ComboPop3Port = New System.Windows.Forms.ComboBox()
        Me.ComboSMTPPort = New System.Windows.Forms.ComboBox()
        Me.TextOtherHost = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.tbhostname = New System.Windows.Forms.ComboBox()
        Me.arrow = New System.Windows.Forms.Label()
        Me.cbAutentificationType = New System.Windows.Forms.ComboBox()
        Me.cbInteractionType = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.CreateAccount = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.changePass = New System.Windows.Forms.LinkLabel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.CheckBoxRemember = New System.Windows.Forms.CheckBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtShowHidePass = New System.Windows.Forms.PictureBox()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pop3Client = New Email.Net.Pop3.Pop3Client(Me.components)
        Me.CheckBoxKeepSigned = New System.Windows.Forms.CheckBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        groupBox1 = New System.Windows.Forms.GroupBox()
        Label8 = New System.Windows.Forms.Label()
        label6 = New System.Windows.Forms.Label()
        label5 = New System.Windows.Forms.Label()
        label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        groupBox2 = New System.Windows.Forms.GroupBox()
        Label7 = New System.Windows.Forms.Label()
        label4 = New System.Windows.Forms.Label()
        groupBox1.SuspendLayout()
        groupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        groupBox1.Controls.Add(Me.ComboPop3Port)
        groupBox1.Controls.Add(Me.ComboSMTPPort)
        groupBox1.Controls.Add(Label8)
        groupBox1.Controls.Add(Me.TextOtherHost)
        groupBox1.Controls.Add(Me.ComboBox2)
        groupBox1.Controls.Add(Me.tbhostname)
        groupBox1.Controls.Add(Me.arrow)
        groupBox1.Controls.Add(Me.cbAutentificationType)
        groupBox1.Controls.Add(Me.cbInteractionType)
        groupBox1.Controls.Add(label6)
        groupBox1.Controls.Add(label5)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(Label3)
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        groupBox1.Location = New System.Drawing.Point(0, 0)
        groupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        groupBox1.Name = "groupBox1"
        groupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        groupBox1.Size = New System.Drawing.Size(452, 188)
        groupBox1.TabIndex = 16
        groupBox1.TabStop = False
        groupBox1.Text = "Server"
        '
        'ComboPop3Port
        '
        Me.ComboPop3Port.FormattingEnabled = True
        Me.ComboPop3Port.Items.AddRange(New Object() {"995", "110"})
        Me.ComboPop3Port.Location = New System.Drawing.Point(155, 57)
        Me.ComboPop3Port.Name = "ComboPop3Port"
        Me.ComboPop3Port.Size = New System.Drawing.Size(152, 24)
        Me.ComboPop3Port.TabIndex = 25
        '
        'ComboSMTPPort
        '
        Me.ComboSMTPPort.FormattingEnabled = True
        Me.ComboSMTPPort.Items.AddRange(New Object() {"587", "2525", "465"})
        Me.ComboSMTPPort.Location = New System.Drawing.Point(155, 84)
        Me.ComboSMTPPort.Name = "ComboSMTPPort"
        Me.ComboSMTPPort.Size = New System.Drawing.Size(152, 24)
        Me.ComboSMTPPort.TabIndex = 24
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(24, 92)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(88, 16)
        Label8.TabIndex = 23
        Label8.Text = "SMTP Port # :"
        '
        'TextOtherHost
        '
        Me.TextOtherHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextOtherHost.Location = New System.Drawing.Point(317, 27)
        Me.TextOtherHost.Name = "TextOtherHost"
        Me.TextOtherHost.Size = New System.Drawing.Size(131, 23)
        Me.TextOtherHost.TabIndex = 22
        Me.TextOtherHost.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Hotmail", "Live"})
        Me.ComboBox2.Location = New System.Drawing.Point(338, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(110, 24)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.Visible = False
        '
        'tbhostname
        '
        Me.tbhostname.FormattingEnabled = True
        Me.tbhostname.Items.AddRange(New Object() {"pop.gmail.com", "pop3.live.com", "pop.mail.yahoo.com", "Other"})
        Me.tbhostname.Location = New System.Drawing.Point(155, 26)
        Me.tbhostname.Name = "tbhostname"
        Me.tbhostname.Size = New System.Drawing.Size(152, 24)
        Me.tbhostname.TabIndex = 18
        '
        'arrow
        '
        Me.arrow.AutoSize = True
        Me.arrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrow.ForeColor = System.Drawing.Color.Blue
        Me.arrow.Location = New System.Drawing.Point(314, 78)
        Me.arrow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(21, 15)
        Me.arrow.TabIndex = 17
        Me.arrow.Text = ">>"
        Me.arrow.Visible = False
        '
        'cbAutentificationType
        '
        Me.cbAutentificationType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAutentificationType.FormattingEnabled = True
        Me.cbAutentificationType.Items.AddRange(New Object() {"No autentification", "Chosen automatically", "Use PLAIN mechanism of authentication", "Use CRAM-MD5 mechanism of authentication", "Use DIGEST-MD5 method of authentication", "Use LOGIN method of authentication"})
        Me.cbAutentificationType.Location = New System.Drawing.Point(155, 152)
        Me.cbAutentificationType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAutentificationType.Name = "cbAutentificationType"
        Me.cbAutentificationType.Size = New System.Drawing.Size(293, 24)
        Me.cbAutentificationType.TabIndex = 11
        '
        'cbInteractionType
        '
        Me.cbInteractionType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbInteractionType.FormattingEnabled = True
        Me.cbInteractionType.Items.AddRange(New Object() {"With a plain-text", "Initialize SSL when starting a connection", "Switch to SSL during a connection"})
        Me.cbInteractionType.Location = New System.Drawing.Point(155, 118)
        Me.cbInteractionType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbInteractionType.Name = "cbInteractionType"
        Me.cbInteractionType.Size = New System.Drawing.Size(293, 24)
        Me.cbInteractionType.TabIndex = 4
        '
        'label6
        '
        label6.AutoSize = True
        label6.Location = New System.Drawing.Point(24, 160)
        label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label6.Name = "label6"
        label6.Size = New System.Drawing.Size(132, 16)
        label6.TabIndex = 10
        label6.Text = "Authentification type"
        '
        'label5
        '
        label5.AutoSize = True
        label5.Location = New System.Drawing.Point(24, 126)
        label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label5.Name = "label5"
        label5.Size = New System.Drawing.Size(101, 16)
        label5.TabIndex = 9
        label5.Text = "Interaction type"
        '
        'label2
        '
        label2.AutoSize = True
        label2.Location = New System.Drawing.Point(24, 65)
        label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(87, 16)
        label2.TabIndex = 5
        label2.Text = "POP3 Port # :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 34)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(36, 16)
        Label3.TabIndex = 4
        Label3.Text = "Host"
        '
        'groupBox2
        '
        groupBox2.Controls.Add(Me.Panel5)
        groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        groupBox2.Location = New System.Drawing.Point(0, 0)
        groupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        groupBox2.Name = "groupBox2"
        groupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        groupBox2.Size = New System.Drawing.Size(452, 191)
        groupBox2.TabIndex = 16
        groupBox2.TabStop = False
        groupBox2.Text = "User"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(4, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(444, 165)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 85)
        Me.Panel2.TabIndex = 107
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel15, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(444, 24)
        Me.TableLayoutPanel1.TabIndex = 111
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.CreateAccount)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(151, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(142, 18)
        Me.Panel15.TabIndex = 0
        '
        'CreateAccount
        '
        Me.CreateAccount.AutoSize = True
        Me.CreateAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateAccount.Location = New System.Drawing.Point(0, 0)
        Me.CreateAccount.Name = "CreateAccount"
        Me.CreateAccount.Size = New System.Drawing.Size(122, 16)
        Me.CreateAccount.TabIndex = 91
        Me.CreateAccount.TabStop = True
        Me.CreateAccount.Text = "Create An Account?"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel9, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel14, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(444, 24)
        Me.TableLayoutPanel2.TabIndex = 112
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.changePass)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(142, 18)
        Me.Panel8.TabIndex = 0
        '
        'changePass
        '
        Me.changePass.AutoSize = True
        Me.changePass.Dock = System.Windows.Forms.DockStyle.Left
        Me.changePass.Location = New System.Drawing.Point(0, 0)
        Me.changePass.Name = "changePass"
        Me.changePass.Size = New System.Drawing.Size(116, 16)
        Me.changePass.TabIndex = 88
        Me.changePass.TabStop = True
        Me.changePass.Text = "Change Password?"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.CheckBoxRemember)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(299, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(142, 18)
        Me.Panel9.TabIndex = 1
        '
        'CheckBoxRemember
        '
        Me.CheckBoxRemember.AutoSize = True
        Me.CheckBoxRemember.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBoxRemember.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRemember.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxRemember.Location = New System.Drawing.Point(25, 0)
        Me.CheckBoxRemember.Name = "CheckBoxRemember"
        Me.CheckBoxRemember.Size = New System.Drawing.Size(117, 18)
        Me.CheckBoxRemember.TabIndex = 87
        Me.CheckBoxRemember.Text = "Remember Me?"
        Me.CheckBoxRemember.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(151, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(142, 18)
        Me.Panel14.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Label7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.tbLogin)
        Me.Panel3.Controls.Add(label4)
        Me.Panel3.Controls.Add(Me.tbuser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 80)
        Me.Panel3.TabIndex = 108
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(30, 11)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(40, 16)
        Label7.TabIndex = 103
        Label7.Text = "Login"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.tbPassword)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(123, 44)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(297, 28)
        Me.Panel6.TabIndex = 106
        '
        'tbPassword
        '
        Me.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPassword.Location = New System.Drawing.Point(0, 0)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(262, 23)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(262, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(35, 28)
        Me.Panel7.TabIndex = 89
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.BtShowHidePass)
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(35, 23)
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
        Me.BtShowHidePass.Size = New System.Drawing.Size(35, 23)
        Me.BtShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtShowHidePass.TabIndex = 88
        Me.BtShowHidePass.TabStop = False
        '
        'tbLogin
        '
        Me.tbLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLogin.BackColor = System.Drawing.SystemColors.Control
        Me.tbLogin.Location = New System.Drawing.Point(284, 8)
        Me.tbLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.ReadOnly = True
        Me.tbLogin.Size = New System.Drawing.Size(136, 23)
        Me.tbLogin.TabIndex = 102
        Me.tbLogin.Text = "Select Host"
        '
        'label4
        '
        label4.AutoSize = True
        label4.Location = New System.Drawing.Point(30, 56)
        label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(64, 16)
        label4.TabIndex = 104
        label4.Text = "Password"
        '
        'tbuser
        '
        Me.tbuser.BackColor = System.Drawing.SystemColors.Window
        Me.tbuser.Location = New System.Drawing.Point(123, 8)
        Me.tbuser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.ReadOnly = True
        Me.tbuser.Size = New System.Drawing.Size(150, 23)
        Me.tbuser.TabIndex = 105
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(452, 38)
        Me.Panel4.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sign In  :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.HR.My.Resources.Resources.icons8_gmail_100
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(392, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 38)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Pop3Client
        '
        Me.Pop3Client.AttachmentDirectory = ""
        Me.Pop3Client.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.[Auto]
        Me.Pop3Client.Host = "localhost"
        Me.Pop3Client.Password = ""
        Me.Pop3Client.Port = CType(25US, UShort)
        Me.Pop3Client.ProxyHost = ""
        Me.Pop3Client.ProxyPassword = ""
        Me.Pop3Client.ProxyPort = CType(0US, UShort)
        Me.Pop3Client.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.Pop3Client.ProxyUser = ""
        Me.Pop3Client.ReceiveTimeout = 10000
        Me.Pop3Client.SendTimeout = 10000
        Me.Pop3Client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.Pop3Client.Username = ""
        '
        'CheckBoxKeepSigned
        '
        Me.CheckBoxKeepSigned.AutoSize = True
        Me.CheckBoxKeepSigned.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBoxKeepSigned.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxKeepSigned.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxKeepSigned.Location = New System.Drawing.Point(0, 0)
        Me.CheckBoxKeepSigned.Name = "CheckBoxKeepSigned"
        Me.CheckBoxKeepSigned.Size = New System.Drawing.Size(124, 27)
        Me.CheckBoxKeepSigned.TabIndex = 87
        Me.CheckBoxKeepSigned.Text = "Keep me Signed?"
        Me.CheckBoxKeepSigned.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(groupBox1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 38)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(452, 188)
        Me.Panel10.TabIndex = 88
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(groupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 191)
        Me.Panel1.TabIndex = 89
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.bLogin)
        Me.Panel16.Controls.Add(Me.Panel13)
        Me.Panel16.Controls.Add(Me.CheckBoxKeepSigned)
        Me.Panel16.Controls.Add(Me.BtCancel)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 417)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(452, 27)
        Me.Panel16.TabIndex = 90
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.bLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.bLogin.FlatAppearance.BorderSize = 0
        Me.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogin.ForeColor = System.Drawing.Color.White
        Me.bLogin.Location = New System.Drawing.Point(233, 0)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(93, 27)
        Me.bLogin.TabIndex = 89
        Me.bLogin.Text = "Connect"
        Me.bLogin.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(326, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(33, 27)
        Me.Panel13.TabIndex = 90
        '
        'BtCancel
        '
        Me.BtCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtCancel.FlatAppearance.BorderSize = 0
        Me.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCancel.ForeColor = System.Drawing.Color.White
        Me.BtCancel.Location = New System.Drawing.Point(359, 0)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(93, 27)
        Me.BtCancel.TabIndex = 91
        Me.BtCancel.Text = "Disconnect"
        Me.BtCancel.UseVisualStyleBackColor = False
        '
        'ssMain
        '
        Me.ssMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.slStatus})
        Me.ssMain.Location = New System.Drawing.Point(0, 475)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.ssMain.Size = New System.Drawing.Size(452, 22)
        Me.ssMain.TabIndex = 91
        Me.ssMain.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'slStatus
        '
        Me.slStatus.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slStatus.ForeColor = System.Drawing.Color.White
        Me.slStatus.Name = "slStatus"
        Me.slStatus.Size = New System.Drawing.Size(81, 17)
        Me.slStatus.Text = "Disconnected"
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 444)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(452, 31)
        Me.Panel12.TabIndex = 93
        '
        'FrmMailSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 497)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ssMain)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMailSignIn"
        Me.Text = "FrmMailSignIn"
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        groupBox2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.BtShowHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents _client As Email.Net.Pop3.Pop3Client
    Private WithEvents Pop3Client As Email.Net.Pop3.Pop3Client
    Friend WithEvents CheckBoxKeepSigned As CheckBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents tbhostname As ComboBox
    Friend WithEvents arrow As Label
    Public WithEvents cbAutentificationType As ComboBox
    Public WithEvents cbInteractionType As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents bLogin As Button
    '   Friend WithEvents object_b0de6c35_ccb5_4485_9025_faae0fe4872e As Telerik.WinControls.RootRadElement
    Friend WithEvents ssMain As StatusStrip
    Private WithEvents slStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Public WithEvents tbPassword As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BtShowHidePass As PictureBox
    Public WithEvents tbuser As TextBox
    Public WithEvents tbLogin As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtCancel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents changePass As LinkLabel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents CheckBoxRemember As CheckBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CreateAccount As LinkLabel
    Friend WithEvents TextOtherHost As TextBox
    Public WithEvents ComboPop3Port As ComboBox
    Public WithEvents ComboSMTPPort As ComboBox
End Class
