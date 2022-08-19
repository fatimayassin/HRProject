Imports System.IO
Imports System.Linq
Imports Email.Net.Common
Imports Email.Net.Common.Collections
Imports Email.Net.Common.Configurations
Imports Email.Net.Pop3


Public Class FrmMailSignIn
    Private Sub FrmMailSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.BackColor = My.Settings.PanelColor
        'groupBox1.BackColor = My.Settings.FormBackgroundColor
        Me.BackColor = My.Settings.FormBackgroundColor
        'groupBox2.BackColor = My.Settings.FormBackgroundColor
        ssMain.BackColor = My.Settings.PanelColor
        bLogin.BackColor = My.Settings.PanelColor

        If tbhostname.Text = "" Then
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
        Else
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If

        If My.Settings.EmailUsername = String.Empty Then
            tbhostname.SelectedIndex = 0
            TextOtherHost.Text = ""
            ComboPop3Port.Text = 0
            ComboSMTPPort.Text = 0
            ComboBox2.Text = ""
            cbAutentificationType.SelectedIndex = 1
            cbInteractionType.SelectedIndex = 1
            tbuser.Text = ""
            tbLogin.Text = ""
            tbPassword.Text = ""
            CheckBoxRemember.Checked = False
            CheckBoxRemember.CheckState = CheckState.Unchecked
        Else
            tbhostname.Text = My.Settings.Emailhostname
            TextOtherHost.Text = My.Settings.EmailOtherhostname
            ComboPop3Port.Text = My.Settings.EmailPop3PortNbr
            ComboSMTPPort.Text = My.Settings.EmailSMTPPortNbr
            ComboBox2.Text = My.Settings.EmailType
            cbAutentificationType.Text = My.Settings.EmailAutenticationType
            cbInteractionType.Text = My.Settings.EmailInteractionType
            tbuser.Text = My.Settings.EmailUsername
            tbLogin.Text = My.Settings.EmailLogin
            tbPassword.Text = My.Settings.EmailPassword
            CheckBoxRemember.Checked = True
            CheckBoxRemember.CheckState = CheckState.Checked

        End If

        If My.Settings.SignedIn = True Then
            'AddHandler bLogin.Click, AddressOf bLogin_Click
            Login()
            CheckBoxKeepSigned.Checked = True
            CheckBoxKeepSigned.CheckState = CheckState.Checked
        Else
            'RemoveHandler bLogin.Click, AddressOf bLogin_Click
            CheckBoxKeepSigned.Checked = False
            CheckBoxKeepSigned.CheckState = CheckState.Unchecked
        End If

    End Sub

    Public Sub New()
        InitializeComponent()
        cbAutentificationType.SelectedIndex = 1
        cbInteractionType.SelectedIndex = 1
        tbhostname.SelectedIndex = 0
        Pop3Client.AttachmentDirectory = "."
    End Sub

    Private Sub Login()

        If Not tbuser.Text + tbLogin.Text + tbPassword.Text = "" Then

            'Create POP3 client with parameters needed
            'URL of host to connect to
            If tbhostname.Text = "Other" Then
                Pop3Client.Host = TextOtherHost.Text
            Else
                Pop3Client.Host = tbhostname.Text
            End If
            'Pop3Client.Port = CUShort(Math.Truncate(ComboPop3Port.Text))
            Pop3Client.Port = CUShort(ComboPop3Port.Text)
            'Username to login to the POP3 server
            Pop3Client.Username = tbuser.Text + tbLogin.Text
            'Password to login to the POP3 server
            Pop3Client.Password = tbPassword.Text
            'Interaction type for connection
            Pop3Client.SSLInteractionType = CType(cbInteractionType.SelectedIndex, EInteractionType)
            'Authentification type for authentification
            Pop3Client.AuthenticationType = CType(cbAutentificationType.SelectedIndex, EAuthenticationType)

            'TCP port for connection
            If tbhostname.Text = "Other" Then
                Pop3Client.SSLInteractionType = EInteractionType.StartTLS
            End If

            'Try
            'Login to the server
            Dim response As Pop3Response = Pop3Client.Login()

            If response.Type = EPop3ResponseType.OK Then
                slStatus.Text = "Connected"
                FrmMailInbox2.ToolStatus.Text = "Connected"
                FrmSentMail.ToolStatus.Text = "Connected"
            Else
                MessageBox.Show("Error", [String].Format("Connection error:" & vbLf & " {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.[Error])
                slStatus.Text = "Connection error"
                FrmMailInbox2.ToolStatus.Text = "Connection error"
                FrmSentMail.ToolStatus.Text = "Connection error"
            End If

            'Get messages for the server
            Dim messages As Rfc822MessageCollection = Pop3Client.GetAllMessages()

            If Not tbhostname.Text = "Other" Then
                FrmMailInbox2.ReadMailList()
            End If

            FrmMailInbox2.FillMessageSList(messages)

                FrmSentMail.FillMessageSList()

                Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                    'ToolStripStatusLabel1.Text = aMainor.TblRfc822Messages.Count
                    FrmMailInbox2.ToolMailCountNbr.Text = (From ax In aMainor.TblRfc822Messages Where ax.EmailUsername = tbuser.Text + tbLogin.Text).Count
                    FrmSentMail.ToolMailCountNbr.Text = (From ax In aMainor.TblSentMessages Where ax.EmailUsername = tbuser.Text + tbLogin.Text).Count
                End Using

                'Catch
                '    MsgBox("Error , Incorrect User Details", MsgBoxStyle.Critical, "Error While Logining in")
                '    slStatus.Text = "Error: Please Check Your User Information"
                'End Try

                Try
                    'Logout from the server
                    Pop3Client.Logout()
                Catch
                End Try
                'End If
            Else
                MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If

    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Login()
    End Sub


    Private Sub tbhostname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbhostname.SelectedIndexChanged
        If tbhostname.Text = "" Then
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
        ElseIf tbhostname.Text = "pop3.live.com" Then
            'TextBox1.Hide()
            ComboBox2.Show()
            arrow.Show()
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
            'tbuser.Clear()
            'tbPassword.Clear()
            tbLogin.Clear()
        ElseIf tbhostname.Text = "pop.mail.yahoo.com" Then
            'TextBox1.Hide()
            ComboBox2.Hide()
            arrow.Hide()
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
            tbuser.Clear()
            tbLogin.Clear()
            tbPassword.Clear()
            tbLogin.Text = "@yahoo.com"
        ElseIf tbhostname.Text = "pop.gmail.com" Then
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
            TextOtherHost.Location = New Point(318, 27)
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
            If CheckBoxRemember.Checked = True Then
                CheckBoxRemember.Checked = False
            Else
                CheckBoxRemember.Checked = False
            End If
            If CheckBoxKeepSigned.Checked = True Then
                CheckBoxKeepSigned.Checked = False
            Else
                CheckBoxKeepSigned.Checked = False
            End If
        Else
            'TextBox1.Hide()
            ComboBox2.Hide()
            arrow.Hide()
            tbPassword.Clear()
            tbuser.ReadOnly = True
            tbPassword.ReadOnly = True
            'tbPassword.Enabled = True
        End If
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Live" Then
            tbLogin.Text = "@live.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Live" Then
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
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Hotmail" Then
            tbLogin.Text = "@hotmail.com"
            tbuser.ReadOnly = False
            tbPassword.ReadOnly = False
        End If
        If tbhostname.Text = "pop3.live.com" And ComboBox2.Text = "Live" Then
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

    Private Sub CheckBoxRemember_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRemember.CheckedChanged
        If CheckBoxRemember.Checked = True Then
            My.Settings.Emailhostname = tbhostname.Text
            My.Settings.EmailOtherhostname = TextOtherHost.Text
            My.Settings.EmailPop3PortNbr = ComboPop3Port.Text
            My.Settings.EmailSMTPPortNbr = ComboSMTPPort.Text
            My.Settings.EmailType = ComboBox2.Text
            My.Settings.EmailInteractionType = cbInteractionType.Text
            My.Settings.EmailAutenticationType = cbAutentificationType.Text
            My.Settings.EmailUsername = tbuser.Text
            My.Settings.EmailLogin = tbLogin.Text
            My.Settings.EmailPassword = tbPassword.Text
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.Emailhostname = ""
            My.Settings.EmailOtherhostname = ""
            My.Settings.EmailPop3PortNbr = 0
            My.Settings.EmailSMTPPortNbr = 0
            My.Settings.EmailType = ""
            My.Settings.EmailInteractionType = ""
            My.Settings.EmailAutenticationType = ""
            My.Settings.EmailUsername = ""
            My.Settings.EmailLogin = ""
            My.Settings.EmailPassword = ""
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub CheckBoxKeepSigned_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKeepSigned.CheckedChanged
        If CheckBoxKeepSigned.Checked = True Then
            My.Settings.SignedIn = True
            'AddHandler bLogin.Click, AddressOf bLogin_Click
            Login()
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.SignedIn = False
            'RemoveHandler bLogin.Click, AddressOf bLogin_Click
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub changePass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles changePass.LinkClicked
        If tbhostname.Text = "pop.gmail.com" Then
            Dim frm As New FrmChangingEmailPassBrowser
            'frm.WebBrowser1.Navigate(New Uri("http://www.google.com"))
            frm.WebBrowser1.Navigate(New Uri("https://accounts.google.com/signin/v2/sl/pwd?service=accountsettings&passive=1209600&osid=1&continue=https%3A%2F%2Fmyaccount.google.com%2Fsigninoptions%2Fpassword%3Fpli%3D1&followup=https%3A%2F%2Fmyaccount.google.com%2Fsigninoptions%2Fpassword%3Fpli%3D1&emr=1&mrp=security&rart=ANgoxcc8lJs9VN8imMgpjiFDtgyzvEP4xcJ9kx3mHlsHn7HM2t5Zr6J6SI54E-ytnwiJENTnJKlTEzop5K3nrAd2PWZZj4LJQg&authuser=0&csig=AF-SEnZ5QqDREWxGQCsS%3A1583926005&flowName=GlifWebSignIn&flowEntry=AddSession&cid=0&navigationDirection=forward"))
            frm.ShowDialog()

            'Dim url As String = "https://accounts.google.com/signin/v2/sl/pwd?service=accountsettings&passive=1209600&osid=1&continue=https%3A%2F%2Fmyaccount.google.com%2Fsigninoptions%2Fpassword%3Fpli%3D1&followup=https%3A%2F%2Fmyaccount.google.com%2Fsigninoptions%2Fpassword%3Fpli%3D1&emr=1&mrp=security&rart=ANgoxcc8lJs9VN8imMgpjiFDtgyzvEP4xcJ9kx3mHlsHn7HM2t5Zr6J6SI54E-ytnwiJENTnJKlTEzop5K3nrAd2PWZZj4LJQg&authuser=0&csig=AF-SEnZ5QqDREWxGQCsS%3A1583926005&flowName=GlifWebSignIn&flowEntry=AddSession&cid=0&navigationDirection=forward"
            'Process.Start(url)
        End If

        If tbhostname.Text = "pop3.live.com" Then
            Dim frm As New FrmChangingEmailPassBrowser
            frm.WebBrowser1.Navigate(New Uri("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1583926780&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d76c319b7-6f4b-061c-a577-2fa721f78ac5&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015"))
            frm.ShowDialog()
            'Dim url As String = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1583926780&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d76c319b7-6f4b-061c-a577-2fa721f78ac5&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015"
            'Process.Start(url)
        End If

        If tbhostname.Text = "pop.mail.yahoo.com" Then
            Dim frm As New FrmChangingEmailPassBrowser
            frm.WebBrowser1.Navigate(New Uri("https://login.yahoo.com/?.src=ym&.lang=en-US&.intl=us&.done=https%3A%2F%2Fmail.yahoo.com%2Fd"))
            frm.ShowDialog()
            'Dim url As String = "https://login.yahoo.com/?.src=ym&.lang=en-US&.intl=us&.done=https%3A%2F%2Fmail.yahoo.com%2Fd"
            'Process.Start(url)
        End If
    End Sub

    Private Sub CreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccount.LinkClicked
        If tbhostname.Text = "pop.gmail.com" Then
            Dim frm As New FrmCreateNewEmailAccountBrowser
            frm.WebBrowser1.Navigate(New Uri("https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Faccounts.google.com%2FManageAccount&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp"))
            frm.ShowDialog()
            'Dim url As String = "https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Faccounts.google.com%2FManageAccount&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp"
            'Process.Start(url)
        End If

        If tbhostname.Text = "pop3.live.com" Then
            Dim frm As New FrmCreateNewEmailAccountBrowser
            frm.WebBrowser1.Navigate(New Uri("https://signup.live.com/signup?wa=wsignin1.0&rpsnv=13&ct=1583926780&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d76c319b7-6f4b-061c-a577-2fa721f78ac5&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015&contextid=5E0027AE24BB8F09&bk=1583927488&uiflavor=web&lic=1&mkt=EN-US&lc=1033&uaid=bd6306510efe4c8e21444c4075574dd0"))
            frm.ShowDialog()
            'Dim url As String = "https://signup.live.com/signup?wa=wsignin1.0&rpsnv=13&ct=1583926780&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d76c319b7-6f4b-061c-a577-2fa721f78ac5&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015&contextid=5E0027AE24BB8F09&bk=1583927488&uiflavor=web&lic=1&mkt=EN-US&lc=1033&uaid=bd6306510efe4c8e21444c4075574dd0"
            'Process.Start(url)
        End If

        If tbhostname.Text = "pop.mail.yahoo.com" Then
            Dim frm As New FrmCreateNewEmailAccountBrowser
            frm.WebBrowser1.Navigate(New Uri("https://login.yahoo.com/account/create?.lang=en-US&.intl=us&.done=https%3A%2F%2Fmail.yahoo.com%2Fd&src=ym&specId=yidReg"))
            frm.ShowDialog()
            'Dim url As String = "https://login.yahoo.com/account/create?.lang=en-US&.intl=us&.done=https%3A%2F%2Fmail.yahoo.com%2Fd&src=ym&specId=yidReg"
            'Process.Start(url)
        End If
    End Sub

    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        Dim Noresponse As Pop3Response = Pop3Client.Logout()

        If Noresponse.Type = EPop3ResponseType.OK Then
            slStatus.Text = "Disconnected"
            FrmMailInbox2.ToolStatus.Text = "Disconnected"
            FrmSentMail.ToolStatus.Text = "Disconnected"
            If Not FrmMailInbox2.DataGridView1.Rows.Count = 0 Then
                FrmMailInbox2.DataGridView1.Rows.Clear()
            End If
            If Not FrmSentMail.DataGridView2.Rows.Count = 0 Then
                FrmSentMail.DataGridView2.Rows.Clear()
            End If
            FrmMailInbox2.ToolMailCountNbr.Text = FrmMailInbox2.DataGridView1.Rows.Count
            FrmSentMail.ToolMailCountNbr.Text = FrmSentMail.DataGridView2.Rows.Count
            tbuser.Text = ""
            tbLogin.Text = ""
            tbPassword.Text = ""
            CheckBoxKeepSigned.Checked = False
            CheckBoxRemember.Checked = False
        End If

    End Sub
End Class