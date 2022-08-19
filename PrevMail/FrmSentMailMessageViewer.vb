Imports System.IO

Public Class FrmSentMailMessageViewer
    Public ID As Integer

    Private Sub FrmSentMailMessageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SentEmailDataSet.TblSentMailAttachments' table. You can move, or remove it, as needed.
        'Me.TblSentMailAttachmentsTableAdapter.Fill(Me.SentEmailDataSet.TblSentMailAttachments)
        'TODO: This line of code loads data into the 'SentEmailDataSet.TblSentMessages' table. You can move, or remove it, as needed.
        'Me.TblSentMessagesTableAdapter.Fill(Me.SentEmailDataSet.TblSentMessages)

        Using aMainor As New DataClassesEmailDataContext(cnxEmail)


            Dim Mail = (From ax In aMainor.TblSentMessages Where ax.SentMessageID = ID).ToList(0)
            MailDateLabel1.Text = Mail.MailDate
            tbFrom.Text = Mail.From
            tbTo.Text = Mail.[To]
            tbCc.Text = Mail.Cc
            tbBcc.Text = Mail.Bcc
            tbSubject.Text = Mail.Subject
            'wbBody.DocumentText = Mail.wbBody 'HttpUtility.HtmlDecode(Mail.tbBody)
            tbBody.Text = Mail.tbBody
            tbBodyWithFormat.Rtf = Mail.wbBody


            Dim Attachments = (From ax In aMainor.TblSentMailAttachments Where ax.SentMessageID = ID).ToList

            TblSentMailAttachmentsBindingSource.DataSource = (From ax In aMainor.TblSentMailAttachments Where ax.SentMessageID = ID).ToList
            ToolStripStatusLabel1.Text = Attachments.Count()

        End Using

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim FileName As String = ""

            If TblSentMailAttachmentsBindingSource.Current.AttachmentName Is Nothing Then
                FileName = TblSentMailAttachmentsBindingSource.Current.AttachmentID.ToString() + ".jpg"
            Else
                FileName = TblSentMailAttachmentsBindingSource.Current.AttachmentName
            End If

            FileName = FileName

            Using writer = New BinaryWriter(File.Open(FileName, FileMode.OpenOrCreate))
                writer.Write(TblSentMailAttachmentsBindingSource.Current.Attachment)
            End Using

            'Dim x As New Process()
            Process.Start(FileName)
        End If
    End Sub
End Class