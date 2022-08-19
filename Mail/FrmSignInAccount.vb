Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Email.Net.Common.Configurations

Public Class FrmSignInAccount
    Private accounts As List(Of MailAccount)
    Public selAccount As MailAccount
    Private Path As String = Application.StartupPath + "\AccountsData.xml"
    Private serializer As MyXmlSerializer22 = New MyXmlSerializer22()
    Public _attachmentDir As String

    Public Sub New()
        InitializeComponent()
        accounts = New List(Of MailAccount)()
        _attachmentDir = ".\\"
        'selAccount = accounts(0)
        'label14.Text = selAccount.AccountName
        'lbAcc.Items.AddRange(accounts.ToArray())
    End Sub

    Private Sub WriteTasksList()
        serializer.Serialize(Of List(Of MailAccount))(Path, Me.accounts)
    End Sub

    Private Sub ReadTasksList()
        Me.accounts = serializer.Deserialize(Of List(Of MailAccount))(Path)
    End Sub

    Private Sub tbhostname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbhostname.SelectedIndexChanged
        If tbhostname.Text = "" Then
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
        ElseIf tbhostname.Text = "imap.live.com" Then
            'TextBox1.Hide()
            ComboBox2.Show()
            arrow.Show()
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
            'tbuser.Clear()
            'tbPassword.Clear()
            tbLogin.Clear()
        ElseIf tbhostname.Text = "imap.mail.yahoo.com" Then
            'TextBox1.Hide()
            ComboBox2.Hide()
            arrow.Hide()
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
            tbuser.Clear()
            tbLogin.Clear()
            tbPassword.Clear()
            tbLogin.Text = "@yahoo.com"
        ElseIf tbhostname.Text = "imap.gmail.com" Then
            'TextBox1.Hide()
            ComboBox2.Hide()
            arrow.Hide()
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
            'tbLogin.Clear()
            'tbuser.Clear()
            'tbPassword.Clear()
            tbLogin.Text = "@gmail.com"
        ElseIf tbhostname.Text = "Other" Then
            tbhostname.Height = 24
            tbhostname.Width = 125
            TextOtherHost.Show()
            'TextOtherHost.Location = New Point(318, 27)
            TextOtherHost.Height = 23
            TextOtherHost.Width = 130
            ComboBox2.Hide()
            arrow.Hide()
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
            tbLogin.Clear()
            tbLogin.ReadOnly = False
            tbuser.Clear()
            tbPassword.Clear()
            tbLogin.Text = ""
            'If CheckBoxRemember.Checked = True Then
            '    CheckBoxRemember.Checked = False
            'Else
            '    CheckBoxRemember.Checked = False
            'End If
            'If CheckBoxKeepSigned.Checked = True Then
            '    CheckBoxKeepSigned.Checked = False
            'Else
            '    CheckBoxKeepSigned.Checked = False
            'End If
        Else
            'TextBox1.Hide()
            ComboBox2.Hide()
            arrow.Hide()
            tbPassword.Clear()
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
            'tbPassword.Enabled = True
        End If
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Live" Then
            tbLogin.Text = "@live.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Live" Then
            tbLogin.Text = "@live.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        ElseIf ComboBox2.Text = "Live" Then
            tbLogin.Text = "@live.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        Else
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
        End If
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "imap.live.com" And ComboBox2.Text = "Live" Then
            tbLogin.Text = "@live.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
    End Sub

    Private Sub BtShowHidePass_Click(sender As Object, e As EventArgs) Handles BtShowHidePass.Click
        If tbPassword.UseSystemPasswordChar = True Then
            tbPassword.UseSystemPasswordChar = False
            BtShowHidePass.BackgroundImage = My.Resources.icons8_eye_20
        Else
            tbPassword.UseSystemPasswordChar = True
            BtShowHidePass.BackgroundImage = My.Resources.icons8_hide_20
        End If
    End Sub

    Private Sub NewBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewBtn.Click
        If cbSecType.SelectedIndex = -1 Then cbSecType.SelectedIndex = 0
        Dim ma As MailAccount = New MailAccount()
        ma.AccountName = txtAccName.Text
        If tbhostname.Text = "Other" Then
            ma.InServerOther = TextOtherHost.Text
            ma.InServer = tbhostname.Text
        Else
            ma.InServer = tbhostname.Text
        End If
        ma.Password = tbPassword.Text
        ma.LoginName = tbuser.Text
        ma.LoginHost = tbLogin.Text
        ma.EmailType = CType(ComboBox2.SelectedIndex, Integer)
        ma.IMAPPort = Int32.Parse(ComboIMAPPort.Text)
        ma.POPPort = Int32.Parse(ComboPop3Port.Text)
        ma.STMPPort = Int32.Parse(ComboSMTPPort.Text)
        ma.SecType = CType(cbSecType.SelectedIndex, EInteractionType)
        ma.attachemtnSaveDirectory = attachemtnSaveDirectory.Text

        accounts.Add(ma)
        Me.FillList()
        Me.WriteTasksList()
    End Sub

    Private Sub SetBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetBtn.Click
        Dim ma As MailAccount = CType(lbAcc.SelectedItem, MailAccount)
        If ma Is Nothing Then Return
        If cbSecType.SelectedIndex = -1 Then cbSecType.SelectedIndex = 0
        ma.AccountName = txtAccName.Text
        If tbhostname.Text = "Other" Then
            'If tbhostname.SelectedIndex = 3 Then
            ma.InServerOther = TextOtherHost.Text
            ma.InServer = tbhostname.Text
        Else
            ma.InServer = tbhostname.Text
        End If
        ma.IMAPPort = Int32.Parse(ComboIMAPPort.Text)
        ma.POPPort = Int32.Parse(ComboPop3Port.Text)
        ma.STMPPort = Int32.Parse(ComboSMTPPort.Text)
        ma.LoginName = tbuser.Text
        ma.LoginHost = tbLogin.Text
        ma.EmailType = CType(ComboBox2.SelectedIndex, Integer)
        ma.Password = tbPassword.Text
        ma.SecType = CType(cbSecType.SelectedIndex, EInteractionType)
        ma.attachemtnSaveDirectory = attachemtnSaveDirectory.Text
        Me.FillList()
        Me.WriteTasksList()
    End Sub

    Private Sub SelAccbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SelAccbtn.Click
        If lbAcc.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Account From List First !")
            Return
        End If
        selAccount = CType(lbAcc.SelectedItem, MailAccount)
        label14.Text = selAccount.AccountName
    End Sub

    Private Sub DelAccBtn_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles DelAccBtn.Click
        If lbAcc.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Account To Delete")
            Return
        End If
        Me.accounts.Remove(lbAcc.SelectedItem)
        Me.FillList()
        Me.WriteTasksList()
    End Sub

    Private Sub FillList()
        Me.lbAcc.Items.Clear()
        If accounts Is Nothing Then
            Return
        Else
            For Each acc As MailAccount In accounts
                Me.lbAcc.Items.Add(acc)
            Next
        End If
    End Sub

    Private Sub FrmSignInAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel1.BackColor = My.Settings.FormBackgroundColor
        SelAccbtn.BackColor = My.Settings.PanelColor
        DelAccBtn.BackColor = My.Settings.PanelColor
        NewBtn.BackColor = My.Settings.PanelColor
        SetBtn.BackColor = My.Settings.PanelColor
        bPickPath.BackColor = My.Settings.PanelColor
        Button1.BackColor = My.Settings.PanelColor


        If System.IO.File.Exists(Path) Then
            Me.ReadTasksList()
        End If
        Me.FillList()
        If System.IO.File.Exists(Path) Then
            If My.Settings.SelectedAccount = String.Empty Then
                label14.Text = ""
                CheckBoxRemember.Checked = False
                CheckBoxRemember.CheckState = CheckState.Unchecked
            Else
                label14.Text = My.Settings.SelectedAccount
                Dim Index As Integer = lbAcc.FindString(label14.Text)
                If Not Index = -1 Then
                    selAccount = accounts(Index)
                    txtAccName.Text = selAccount.AccountName
                    TextOtherHost.Text = selAccount.InServerOther
                    tbhostname.Text = selAccount.InServer
                    ComboIMAPPort.Text = selAccount.IMAPPort
                    ComboPop3Port.Text = selAccount.POPPort
                    ComboSMTPPort.Text = selAccount.STMPPort
                    ComboBox2.SelectedIndex = CInt(selAccount.EmailType)
                    tbuser.Text = selAccount.LoginName
                    tbLogin.Text = selAccount.LoginHost
                    tbPassword.Text = selAccount.Password
                    cbSecType.SelectedIndex = CInt(selAccount.SecType)
                    attachemtnSaveDirectory.Text = selAccount.attachemtnSaveDirectory
                    CheckBoxRemember.Checked = True
                    CheckBoxRemember.CheckState = CheckState.Checked
                End If
            End If
        End If
    End Sub

    Private Sub lbAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAcc.SelectedIndexChanged
        If lbAcc.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Account From List First !")
            Return
        End If

        Dim Accnt As MailAccount = CType(lbAcc.SelectedItem, MailAccount)
        txtAccName.Text = Accnt.AccountName
        TextOtherHost.Text = Accnt.InServerOther
        tbhostname.Text = Accnt.InServer
        ComboIMAPPort.Text = Accnt.IMAPPort
        ComboPop3Port.Text = Accnt.POPPort
        ComboSMTPPort.Text = Accnt.STMPPort
        ComboBox2.SelectedIndex = CInt(Accnt.EmailType)
        tbuser.Text = Accnt.LoginName
        tbLogin.Text = Accnt.LoginHost
        tbPassword.Text = Accnt.Password
        cbSecType.SelectedIndex = CInt(Accnt.SecType)
        attachemtnSaveDirectory.Text = Accnt.attachemtnSaveDirectory
    End Sub

    Private Sub CheckBoxRemember_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRemember.CheckedChanged
        If CheckBoxRemember.Checked = True Then
            If label14.Text = "" Then
                MessageBox.Show("Please Select An Account From List First !")
                CheckBoxRemember.Checked = False
            Else
                My.Settings.SelectedAccount = label14.Text
            End If
        Else
            My.Settings.SelectedAccount = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbhostname.Text = "Other" Then
            Dim x As FrmOtherMail = New FrmOtherMail()
            If attachemtnSaveDirectory.Text = ".\" Then
                MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
            Else
                x.ShowDialog()
            End If
        Else
            Dim x As FrmMail = New FrmMail()
            If attachemtnSaveDirectory.Text = ".\" Then
                MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
            Else
                x.ShowDialog()
            End If
        End If

    End Sub

    Private Sub bPickPath_Click(sender As Object, e As EventArgs) Handles bPickPath.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' save picked directory as a directory to store attachment
            _attachmentDir = FolderBrowserDialog1.SelectedPath
            attachemtnSaveDirectory.Text = _attachmentDir
        End If
    End Sub

End Class