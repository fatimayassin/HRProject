Imports System.IO
Imports System.Linq
Imports System.Net
Imports Email.Net.Common
Imports Email.Net.Common.Collections
Imports Email.Net.Common.Configurations
Imports Email.Net.Imap.Collections
Imports Email.Net.Pop3


Public Class FrmMailInbox2

    Private ID As Integer

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
        If ToolStatus.Text Is "Connected" Then
            DataGridView1.Rows.Clear()
            RefreshForm()
            'DataGridView1.Sort(DataGridView1.Columns(3), ListSortDirection.Descending)
            MessageBox.Show("Mail is Refreshed!")
        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If
    End Sub

    Private Sub RefreshForm()

        If Not FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text + FrmMailSignIn.tbPassword.Text = "" Then

            'Create POP3 client with parameters needed
            'URL of host to connect to
            If FrmMailSignIn.tbhostname.Text = "Other" Then
                Pop3Client1.Host = FrmMailSignIn.TextOtherHost.Text
            Else
                Pop3Client1.Host = FrmMailSignIn.tbhostname.Text
            End If

            'TCP port for connection
            'Pop3Client1.Port = CUShort(Math.Truncate(FrmMailSignIn.nPort.Value))
            Pop3Client1.Port = CUShort(FrmMailSignIn.ComboPop3Port.Text)
            'Username to login to the POP3 server
            Pop3Client1.Username = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text
            'Password to login to the POP3 server
            Pop3Client1.Password = FrmMailSignIn.tbPassword.Text
            'Interaction type for connection
            Pop3Client1.SSLInteractionType = CType(FrmMailSignIn.cbInteractionType.SelectedIndex, EInteractionType)
            'Authentification type for authentification
            Pop3Client1.AuthenticationType = CType(FrmMailSignIn.cbAutentificationType.SelectedIndex, EAuthenticationType)
            If FrmMailSignIn.tbhostname.Text = "Other" Then
                Pop3Client1.SSLInteractionType = EInteractionType.StartTLS
            End If
            'Try
            'Login to the server
            Dim response As Pop3Response = Pop3Client1.Login()

            If response.Type = EPop3ResponseType.OK Then
                ToolStatus.Text = "Connected"
            Else
                MessageBox.Show("Error", [String].Format("Connection error:" & vbLf & " {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.[Error])
                ToolStatus.Text = "Connection error"
            End If

            'Get messages for the server
            Dim messages As Rfc822MessageCollection = Pop3Client1.GetAllMessages()


            Me.FillMessageSList(messages)

            Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                'ToolStripStatusLabel1.Text = aMainor.TblRfc822Messages.Count
                ToolMailCountNbr.Text = (From ax In aMainor.TblRfc822Messages Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).Count
            End Using

            MessageBox.Show("Inbox Has Been Refreshed")
            'Catch
            '    MsgBox("Error , Incorrect User Details", MsgBoxStyle.Critical, "Error While Logining in")
            '    ToolStatus.Text = "Error: Please Check Your User Information"
            'End Try

            Try
                'Logout from the server
                Pop3Client1.Logout()

            Catch
            End Try

        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If
    End Sub

    Public Sub FillMessageSList(messages As Rfc822MessageCollection)

        For Each message As Email.Net.Common.Rfc822Message In messages

            Dim subject As String
            If (message.Subject IsNot Nothing) Then
                subject = message.Subject
            Else
                subject = "n/a"
            End If

            Dim [date] As String = message.[Date].ToString("yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)
            Dim zone As TimeZone = TimeZone.CurrentTimeZone
            Dim localDate As DateTime = zone.ToLocalTime([date])

            Dim [To] As String
            If (message.[To].Count > 0) Then
                [To] = message.[To](0).ToString()
            Else
                [To] = ""
            End If

            Dim Cc As String
            If (message.CarbonCopies.Count > 0) Then
                Cc = message.CarbonCopies(0).ToString()
            Else
                Cc = ""
            End If

            Dim Bcc As String
            If (message.BlindedCarbonCopies.Count > 0) Then
                Bcc = message.BlindedCarbonCopies(0).ToString()
            Else
                Bcc = ""
            End If

            Dim wbBody As String
            Dim tbBody As String

            If message.TextContentType = ETextContentType.Html Then
                'filling bodys
                wbBody = message.Text
                tbBody = message.PlainText
            Else
                'if text message
                'filling bodys
                wbBody = ""
                tbBody = message.Text
            End If



            Using aMainor As New DataClassesEmailDataContext(cnxEmail)

                Dim Mail As New TblRfc822Message

                Mail.From = message.From.ToString()
                Mail.Subject = message.Subject.ToString()
                Mail.MailDate = localDate
                Mail.To = [To]
                Mail.Cc = Cc
                Mail.Bcc = Bcc
                Mail.wbBody = wbBody
                Mail.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text


                If Mail.From.Contains(Mail.EmailUsername) Then
                    Dim rBox As New RichTextBox
                    ' rBox.Rtf = wbBody
                    Dim txt() As String = rBox.Lines
                    Mail.tbBody = rBox.Text
                Else
                    Mail.tbBody = tbBody
                End If


                aMainor.TblRfc822Messages.InsertOnSubmit(Mail)
                aMainor.SubmitChanges()

            End Using

            ' If Not FrmMailSignIn.tbhostname.Text = "Other" Then
            ReadMailList()
            ' End If


            Dim AttachmentName As String
            Dim AttachmentType As String
            'Dim AttachmentMain As String

            Dim i As Integer = 0

            For Each attachment As Email.Net.Common.MessageParts.Attachment In message.Attachments

                If (message.Attachments.Count > 0) Then
                    AttachmentName = String.Concat(attachment.DiskFilename, "_", attachment.TransferFilename)
                    AttachmentType = attachment.ContentType.ToString()

                    'If Not attachment.TransferFilename = String.Empty Then
                    Dim fi As New FileInfo(attachment.DiskFilename)
                    Dim fr As Stream = fi.OpenRead
                    Dim nBytes As Integer = fi.Length
                    Dim ByteArray(nBytes) As Byte
                    fr.Read(ByteArray, 0, nBytes)
                    fr.Close()

                    Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                        Dim att As TblMailAttachment = New TblMailAttachment()

                        att.AttachmentName = AttachmentName
                        att.AttachmentType = AttachmentType
                        att.Attachment = ByteArray
                        'att.Attachment = AttachmentMain

                        'att.MessageID = TblRfc822MessageBindingSource(TblRfc822MessageBindingSource.Count - i - 1).MessageID   'For ascending

                        att.MessageID = TblRfc822MessageBindingSource(i).MessageID   'for Descending
                        aMainor.TblMailAttachments.InsertOnSubmit(att)
                        aMainor.SubmitChanges()

                    End Using

                End If
            Next
            ' i = i + 1

        Next

    End Sub


    Public Sub ReadMailList()
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            'TblRfc822MessageBindingSource.DataSource = aMainor.TblRfc822Messages.ToList
            TblRfc822MessageBindingSource.DataSource = (From ax In aMainor.TblRfc822Messages Order By ax.MailDate Descending Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList

        End Using
    End Sub

    Private Sub FrmMailInbox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmailDataSet.TblRfc822Message' table. You can move, or remove it, as needed.
        'Me.TblRfc822MessageTableAdapter.Fill(Me.EmailDataSet.TblRfc822Message)
        Panel4.BackColor = My.Settings.PanelColor
        Me.BackColor = My.Settings.FormBackgroundColor
        ssMain.BackColor = My.Settings.PanelColor

        If ToolStatus.Text Is "Connected" Then
            If Not FrmMailSignIn.tbhostname.Text = "Other" Then
                ReadMailList()
            End If
        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Delete Mail Msg
        If e.ColumnIndex = 4 Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                    Dim Id As Integer = TblRfc822MessageBindingSource.Current.MessageID


                    Dim result = (From aX In aMainor.TblRfc822Messages Where aX.MessageID = Id).ToList(0)


                    If result.TblMailAttachments.Count > 0 Then
                        Dim r = (From ax In aMainor.TblMailAttachments Where ax.MessageID = Id).ToList
                        aMainor.TblMailAttachments.DeleteAllOnSubmit(r)
                        aMainor.SubmitChanges()


                    End If
                    TblRfc822MessageBindingSource.RemoveCurrent()
                    aMainor.TblRfc822Messages.DeleteOnSubmit(result)
                    aMainor.SubmitChanges()
                    ToolMailCountNbr.Text = (From ax In aMainor.TblRfc822Messages Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).Count
                    MessageBox.Show("Mail is Deleted!")

                End Using
            End If
        End If
    End Sub

    Private Sub BtDateUp_Click(sender As Object, e As EventArgs) Handles BtDateUp.Click
        'DataGridView1.Sort(DataGridView1.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            'TblRfc822MessageBindingSource.DataSource = aMainor.TblRfc822Messages.ToList
            TblRfc822MessageBindingSource.DataSource = (From ax In aMainor.TblRfc822Messages Order By ax.MailDate Descending Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList
        End Using
    End Sub

    Private Sub BtDateDown_Click(sender As Object, e As EventArgs) Handles BtDateDown.Click
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            'TblRfc822MessageBindingSource.DataSource = aMainor.TblRfc822Messages.ToList
            TblRfc822MessageBindingSource.DataSource = (From ax In aMainor.TblRfc822Messages Order By ax.MailDate Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList
        End Using
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If TblRfc822MessageBindingSource.Count > 0 Then

            ID = TblRfc822MessageBindingSource.Current.MessageID
            Dim viewer As New FrmMailMessageViewer()
            viewer.ID = ID
            viewer.ShowDialog()
        End If
    End Sub

End Class