Imports System.IO
'Imports System.Net
'Imports System.Net.Mail
'Imports System.Text
'Imports S22.Imap
'Imports System.Net.Sockets
'Imports System.Net.Security

Public Class FrmMailInbox
    '    Dim f As FrmMailInbox
    '    Private MethodInvoke As [Delegate]

    '    Dim Read_Stream As StreamReader
    '    Dim POP3 As New TcpClient
    '    Dim PopHost As String = "pop.gmail.com"
    '    Dim UserName As String = "txtEmail.Text"
    '    Dim Password As String = "txtPassword.Text"
    '    Dim Server_Response As String
    '    Dim response As StreamWriter

    '    Private Sub FrmMailInbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        f = Me

    '        Panel4.BackColor = My.Settings.PanelColor
    '        Panel1.BackColor = My.Settings.PanelColor
    '    End Sub

    '    Private Sub BtRecieveMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRecieveMail.Click

    '        RecieveMail()
    '        Cursor = Cursors.WaitCursor
    '        POP3.Connect(PopHost, 995)
    '        TextBox1.AppendText(Cons("yy ")) 'TextBox Name : TextBox1 to receive response from server using (STAT) command,
    'Note: In the bottom there Is a table with all POP commands And responses.I'm using Cons Function to send commands to POP server.

    '        TextBox1.AppendText("From:  " + .ToString() + "\n" + "Subject: " + m.ToString() + "\n" + "Body: " + m.ToString() + "\n")
    '        Cursor = Cursors.Default

    '        Using imap As New Imap()
    '            imap.ConnectSSL("imap.gmail.com")
    '            imap.UseBestLogin("txtEmail.Text", "txtPassword.Text")

    '            imap.SelectInbox()
    '            Dim uids As List(Of Long) = imap.Search(Flag.Unseen)

    '            For Each uid As Long In uids
    '                Dim eml = imap.GetMessageByUID(uid)
    '                Dim email As IMail = New MailBuilder() _
    '                    .CreateFromEml(eml)
    '                TextBox1.AppendText("From:  " + email.From.ToString() + "\n" + "Subject: " + email.Subject.ToString() + "\n" + "Body: " + email.Date.ToString() + "\n")
    '            Next
    '            imap.Close()
    '        End Using

    '    End Sub

    '    Function Cons(ByVal server_Command As String)
    '        Dim m_buffer() As Byte = System.Text.Encoding.ASCII.GetBytes(server_Command)
    '        Dim m_sslStream = New SslStream(POP3.GetStream(), False)
    '        m_sslStream.AuthenticateAsClient(PopHost)
    '        Dim bytes As Int64 = m_sslStream.Read(m_buffer, 0, m_buffer.Length)
    '        Return (Encoding.ASCII.GetString(m_buffer, 0, bytes))
    '    End Function

    '    Private Sub RecieveMail()
    '        Using client As ImapClient = New ImapClient("imap.gmail.com", 993, txtEmail.Text, txtPassword.Text, AuthMethod.Login, True)

    '            If client.Supports("IDLE") = False Then
    '                MessageBox.Show("Server does not support IMAP IDLE")
    '                Return
    '            End If

    '            Dim uids As IEnumerable(Of UInteger) = client.Search(SearchCondition.Recent())
    '            Dim messages As IEnumerable(Of MailMessage) = client.GetMessages(uids)
    '            f.TextBox1.AppendText(messages.ToString)
    '            Dim m As MailMessage = client.GetMessages(uids, FetchOptions.Normal)
    '            Dim m As IEnumerable(Of MailMessage) = client.GetMessages(uids)
    '            f.TextBox1.AppendText("From:  " + m.ToString() + "\n" + "Subject: " + m.ToString() + "\n" + "Body: " + m.ToString() + "\n")


    '            AddHandler client.NewMessage, AddressOf Me.OnNewMessage

    '            AddHandler client.NewMessage += New EventHandler(Of IdleMessageEventArgs), AddressOf Me.OnNewMessage

    '            client.NewMessage += New EventHandler(Of IdleMessageEventArgs)(OnNewMessage)

    '        End Using
    '    End Sub

    '    Public Sub OnNewMessage(sender As Object, e As IdleMessageEventArgs)
    '        MessageBox.Show("New Message recieved!")

    '        Dim m As MailMessage = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal)
    '        f.Invoke(MethodInvoke, Sub()
    '                                   f.TextBox1.AppendText("From:  " + m.From.ToString() + "\n" + "Subject: " + m.Subject.ToString() + "\n" + "Body: " + m.Body.ToString() + "\n")
    '                               End Sub)

    '    End Sub
End Class