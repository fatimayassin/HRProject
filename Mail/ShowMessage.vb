Imports System.IO
Imports System.Windows.Forms
Imports Email.Net.Common
Imports Email.Net.Common.MessageParts
Imports Message = Email.Net.Imap.ImapMessage


Public Class ShowMessage
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal message As Message)

        InitializeComponent()

        For Each addr As EmailAddress In message.Header.[To]
            txtTo.Text += addr.DisplayName & " (" + addr.Address & "); "
        Next

        For Each addr As EmailAddress In message.Header.CarbonCopies
            txtCopy.Text += addr.DisplayName & " (" + addr.Address & "); "
        Next

        For Each addr As EmailAddress In message.Header.BlindedCarbonCopies
            txtBlCopy.Text += addr.DisplayName & " (" + addr.Address & "); "
        Next

        txtFrom.Text = message.Header.From.DisplayName & " (" + message.Header.From.Address & "); "

        For Each addr As EmailAddress In message.Header.ReplyTo
            txtReplTo.Text += addr.DisplayName & " (" + addr.Address & "); "
        Next

        txtInReplTo.Text = message.Header.InReplyTo
        lbKeywords.Items.Clear()

        For Each kw As String In message.Header.Keywords
            lbKeywords.Items.Add(kw)
        Next

        txtSubject.Text = message.Header.Subject
        lblDate.Text = "Date: " & message.Header.Date.ToLongDateString() & " " + message.Header.Date.ToShortTimeString()
        lblEnc.Text = "Encoding: " & message.Header.ContentTransferEncoding
        lblRecieved.Text = "Recieved: " & message.Header.Received
        lblMultiPart.Text = "MultiPart: " & "unknown"
        lblComm.Text = "Comment: " & message.Header.Comments
        lblTextType.Text = "Text: " & message.Header.ContentType.ToString()
        wbText.DocumentText = message.Text
        txtText.Text = message.PlainText

        attachmentList.Items.Clear()

        ' for each attachment of the message populate item in attachment list
        ' and show name of the attachment and it size
        For Each attachment As Attachment In message.Attachments
            File.Copy(attachment.FullFilename, Path.Combine(FrmSignInAccount._attachmentDir, attachment.TransferFilename))
            Dim attachmentInfo As FileInfo = New FileInfo(Path.Combine(FrmSignInAccount._attachmentDir, attachment.TransferFilename))
            'MessageBox.Show("Attachment Is Saved in Your Selected Directory")
            Dim itm As ListViewItem = New ListViewItem()
            itm.Text = attachmentInfo.Name
            itm.SubItems.Add(attachmentInfo.Extension)
            itm.SubItems.Add(attachmentInfo.Length.ToString())
            itm.Tag = attachment

            attachmentList.Items.Add(itm)
        Next

    End Sub



    Private Sub attachmentList_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles attachmentList.MouseDoubleClick
        If attachmentList.SelectedItems.Count > 0 Then
            ' handle double click on attachment in attachment list
            ' try to open file with default application
            Dim attachment As Attachment = attachmentList.SelectedItems(0).Tag
            System.Diagnostics.Process.Start(Path.Combine(FrmSignInAccount._attachmentDir, attachment.TransferFilename))
        End If
    End Sub

    Private Sub ShowMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        tableLayoutPanel1.BackColor = My.Settings.FormBackgroundColor
    End Sub
End Class