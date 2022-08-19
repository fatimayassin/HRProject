Imports System.IO

Public Class FrmMailMessageViewer
    Public ID As Integer

    Private Sub FrmMailMessageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmailDataSet.TblRfc822Message' table. You can move, or remove it, as needed.
        'Me.TblRfc822MessageTableAdapter.Fill(Me.EmailDataSet.TblRfc822Message)
        'TODO: This line of code loads data into the 'EmailDataSet.TblMailAttachments' table. You can move, or remove it, as needed.
        'Me.TblMailAttachmentsTableAdapter.Fill(Me.EmailDataSet.TblMailAttachments)


        Using aMainor As New DataClassesEmailDataContext(cnxEmail)


            Dim Mail = (From ax In aMainor.TblRfc822Messages Where ax.MessageID = ID).ToList(0)
            MailDateLabel1.Text = Mail.MailDate
            tbFrom.Text = Mail.From
            tbTo.Text = Mail.[To]
            tbCc.Text = Mail.Cc
            tbBcc.Text = Mail.Bcc
            tbSubject.Text = Mail.Subject


            If Mail.From.Contains(Mail.EmailUsername) Then
                wbBody.Visible = False
                tbBody.Rtf = Mail.wbBody
                tbBody.Text = Mail.tbBody
            Else
                wbBody.Visible = True
                wbBody.DocumentText = Mail.wbBody
                tbBody.Text = Mail.tbBody
            End If

            Dim Attachments = (From ax In aMainor.TblMailAttachments Where ax.MessageID = ID).ToList

            TblMailAttachmentsBindingSource.DataSource = (From ax In aMainor.TblMailAttachments Where ax.MessageID = ID).ToList
            ToolStripStatusLabel1.Text = Attachments.Count()

        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim FileName As String = ""

            If TblMailAttachmentsBindingSource.Current.AttachmentName Is Nothing Then
                FileName = TblMailAttachmentsBindingSource.Current.AttachmentID.ToString() + ".jpg"
            Else
                FileName = TblMailAttachmentsBindingSource.Current.AttachmentName
            End If

            FileName = FileName.Split("_").Last

            Using writer = New BinaryWriter(File.Open(FileName, FileMode.OpenOrCreate))
                writer.Write(TblMailAttachmentsBindingSource.Current.Attachment)
            End Using

            'Dim x As New Process()
            Process.Start(FileName)
        End If
    End Sub
End Class