Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Documents

Public Class FrmNewMail

    Public Id As Integer = 0
    Public Property FileN As String

    Private Sub FrmNewMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel4.BackColor = My.Settings.PanelColor
        Panel1.BackColor = My.Settings.FormBackgroundColor
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel21.BackColor = My.Settings.FormBackgroundColor

        TableLayoutPanel1.RowStyles(2).SizeType = SizeType.Absolute
        TableLayoutPanel1.RowStyles(2).Height = 0

        TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Absolute
        TableLayoutPanel1.RowStyles(3).Height = 0

        TableLayoutPanel1.RowStyles(6).SizeType = SizeType.Absolute
        TableLayoutPanel1.RowStyles(6).Height = 0

        TableLayoutPanel1.RowStyles(7).SizeType = SizeType.Absolute
        TableLayoutPanel1.RowStyles(7).Height = 0

        TableLayoutPanel1.RowStyles(8).SizeType = SizeType.Percent = 8.93
        TableLayoutPanel1.RowStyles(8).Height = 38

        If Id = 0 Then
            'Dim x As New TblSentMailAttachment
            'TblSentMailAttachmentsBindingSource.DataSource = x
        Else
            Using aMainOR As New DataClassesEmailDataContext(cnxEmail)
                TblSentMailAttachmentsBindingSource.DataSource = (From aX In aMainOR.TblSentMailAttachments Where aX.SentMessageID = Id).ToList
            End Using
        End If

    End Sub

    Private Sub BtFormatOptions_Click(sender As Object, e As EventArgs) Handles BtFormatOptions.Click
        If TableLayoutPanel1.RowStyles(7).SizeType = SizeType.Absolute And TableLayoutPanel1.RowStyles(7).Height = 0 Then
            TableLayoutPanel1.RowStyles(7).SizeType = SizeType.Percent = 9.11
            TableLayoutPanel1.RowStyles(7).Height = 35
        Else
            TableLayoutPanel1.RowStyles(7).SizeType = SizeType.Absolute
            TableLayoutPanel1.RowStyles(7).Height = 0
        End If
    End Sub

    Private Sub Clear()
        txtTo.Text = ""
        txtSubject.Text = ""
        txtCC.Text = ""
        TxtBcc.Text = ""
        tbBody.Text = ""
        If Not DataGridView1.Rows.Count = 0 Then
            DataGridView1.Rows.Clear()
        End If

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Using mail As New MailMessage()

            mail.From = New MailAddress(FrmMailSignIn.tbuser.Text.Trim() + FrmMailSignIn.tbLogin.Text.Trim())
            mail.To.Add(txtTo.Text.Trim())

            If (txtSubject.Text Is Nothing) Then
                mail.Subject = "n/a"
            Else
                mail.Subject = txtSubject.Text()
            End If

            If txtCC.TextLength > 0 Then
                Dim CC As MailAddress = New MailAddress(txtCC.Text)
                mail.CC.Add(CC)
            End If

            If TxtBcc.TextLength > 0 Then
                Dim BCC As MailAddress = New MailAddress(TxtBcc.Text)
                mail.Bcc.Add(BCC)
            End If

            If (tbBody.Text Is Nothing) Then
                mail.Body = "n/a"
            Else
                mail.Body = tbBody.Rtf
            End If
            'mail.Body = tbBody.Text


            mail.IsBodyHtml = True

            If Not TblSentMailAttachmentsBindingSource.Count = 0 Then
                For i = 0 To TblSentMailAttachmentsBindingSource.Count - 1
                    'Dim File As String = "data.xls"
                    'For j = 0 To OpenFileDialog1.FileNames.Count - 1
                    For Each File In OpenFileDialog1.FileNames
                        ' Create  the file attachment for this email message.
                        Dim Data As Attachment = New Attachment(File, MediaTypeNames.Application.Octet)
                        'Add time stamp information for the file.
                        Dim disposition As ContentDisposition = Data.ContentDisposition
                        disposition.CreationDate = System.IO.File.GetCreationTime(File)
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(File)
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(File)
                        'Add the file attachment to this email message.
                        mail.Attachments.Add(Data)
                    Next
                Next
            End If


            'If Not TblSentMailAttachmentsBindingSource.Count = 0 Then
            '    For i = 0 To TblSentMailAttachmentsBindingSource.Count - 1
            '        mail.Attachments.Add(TblSentMailAttachmentsBindingSource(i))
            '    Next
            'End If


            Using aMainor As New DataClassesEmailDataContext(cnxEmail)

                Dim Sent As New TblSentMessage

                Sent.From = FrmMailSignIn.tbuser.Text.Trim() + FrmMailSignIn.tbLogin.Text.Trim()
                Sent.Subject = txtSubject.Text
                Sent.MailDate = DateTime.Now
                Sent.To = txtTo.Text
                Sent.Cc = txtCC.Text
                Sent.Bcc = TxtBcc.Text
                Sent.wbBody = tbBody.Rtf
                Sent.tbBody = tbBody.Text
                Sent.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text

                aMainor.TblSentMessages.InsertOnSubmit(Sent)
                aMainor.SubmitChanges()

                Dim SentMessageID As Integer = Sent.SentMessageID

                For i = 0 To TblSentMailAttachmentsBindingSource.Count - 1
                    Dim C As TblSentMailAttachment = TblSentMailAttachmentsBindingSource(i)
                    C.SentMessageID = SentMessageID

                    aMainor.TblSentMailAttachments.InsertOnSubmit(C)
                    aMainor.SubmitChanges()
                Next

            End Using

            'Using smtp As New SmtpClient("smtp.gmail.com", FrmMailSignIn.ComboSMTPPort.Text)

            Dim H As String
            If FrmMailSignIn.tbhostname.Text = "Other" Then
                H = FrmMailSignIn.TextOtherHost.Text
            Else
                H = FrmMailSignIn.tbhostname.Text
            End If

            'Dim S = FrmMailSignIn.tbLogin.Text
            'Dim HOST = After(S, "@")
            '"smtp." +

            Using smtp As New SmtpClient(H, FrmMailSignIn.ComboSMTPPort.Text)
                smtp.Credentials = New NetworkCredential(FrmMailSignIn.tbuser.Text.Trim() + FrmMailSignIn.tbLogin.Text.Trim(), FrmMailSignIn.tbPassword.Text.Trim())
                'smtp.UseDefaultCredentials = False
                smtp.EnableSsl = True
                DisableCertificateValidation()
                smtp.Send(mail)
                MessageBox.Show("Email sent.", "Message")
                Clear()
            End Using

    End Using
    End Sub

    Function After(value As String, a As String) As String
        ' Get index of argument and return substring after its position.
        Dim posA As Integer = value.LastIndexOf(a)
        If posA = -1 Then
            Return ""
        End If
        Dim adjustedPosA As Integer = posA + a.Length
        If adjustedPosA >= value.Length Then
            Return ""
        End If
        Return value.Substring(adjustedPosA)
    End Function


    Private Shared Sub DisableCertificateValidation()
        ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
    End Sub
    Private Sub AddAttach_Click(sender As Object, e As EventArgs) Handles BtAttach.Click

        If TableLayoutPanel1.RowStyles(6).SizeType = SizeType.Absolute And TableLayoutPanel1.RowStyles(6).Height = 0 Then
            TableLayoutPanel1.RowStyles(6).SizeType = SizeType.Percent = 25.22
            TableLayoutPanel1.RowStyles(6).Height = 107
        End If

        OpenFileDialog1.ShowDialog()

        For i = 0 To OpenFileDialog1.FileNames.Count - 1
            FileN = OpenFileDialog1.FileName
        Next

        If Not OpenFileDialog1.FileName = String.Empty Then

            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            Dim fr As Stream = fi.OpenRead
            Dim nBytes As Integer = fi.Length
            Dim ByteArray(nBytes) As Byte
            fr.Read(ByteArray, 0, nBytes)
            fr.Close()

            If TblSentMailAttachmentsBindingSource.Count = 0 Then
                TblSentMailAttachmentsBindingSource.DataSource = Nothing
            End If

            Dim SentAtt As New TblSentMailAttachment

            SentAtt.Attachment = ByteArray
            SentAtt.AttachmentName = OpenFileDialog1.FileName
            Dim FileExtension As String = "." + OpenFileDialog1.FileName.Split(".").Last.ToLower
            SentAtt.AttachmentType = ContentType(FileExtension)
            TblSentMailAttachmentsBindingSource.Add(SentAtt)

        End If
    End Sub

    Private Function ContentType(fileExtension As String) As Object
        Dim d As New Dictionary(Of String, String)
        'Images'
        d.Add(".bmp", "image/bmp")
        d.Add(".gif", "image/gif")
        d.Add(".jpeg", "image/jpeg")
        d.Add(".jpg", "image/jpeg")
        d.Add(".png", "image/png")
        d.Add(".tif", "image/tiff")
        d.Add(".tiff", "image/tiff")
        'Documents'
        d.Add(".doc", "application/msword")
        d.Add(".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
        d.Add(".pdf", "application/pdf")
        'Slideshows'
        d.Add(".ppt", "application/vnd.ms-powerpoint")
        d.Add(".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation")
        'Data'
        d.Add(".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        d.Add(".xls", "application/vnd.ms-excel")
        d.Add(".csv", "text/csv")
        d.Add(".xml", "text/xml")
        d.Add(".txt", "text/plain")
        'Compressed Folders'
        d.Add(".zip", "application/zip")
        'Audio'
        d.Add(".ogg", "application/ogg")
        d.Add(".mp3", "audio/mpeg")
        d.Add(".wma", "audio/x-ms-wma")
        d.Add(".wav", "audio/x-wav")
        'Video'
        d.Add(".wmv", "audio/x-ms-wmv")
        d.Add(".swf", "application/x-shockwave-flash")
        d.Add(".avi", "video/avi")
        d.Add(".mp4", "video/mp4")
        d.Add(".mpeg", "video/mpeg")
        d.Add(".mpg", "video/mpeg")
        d.Add(".qt", "video/quicktime")
        Return d(fileExtension)
    End Function

    Private Sub BtnCc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnCc.LinkClicked
        BtnCc.Visible = False
        TableLayoutPanel1.RowStyles(2).SizeType = SizeType.Percent = 7.87
        TableLayoutPanel1.RowStyles(2).Height = 29

        If BtnBcc.Visible = False And BtnBcc.Visible = False Then
            Panel17.Visible = False
        End If

    End Sub

    Private Sub BtnBcc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnBcc.LinkClicked
        BtnBcc.Visible = False
        TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Percent = 7.87
        TableLayoutPanel1.RowStyles(3).Height = 29

        If BtnBcc.Visible = False And BtnBcc.Visible = False Then
            Panel17.Visible = False
        End If

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

        If e.ColumnIndex = 4 Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold.Click
        tbBody.Focus()
        If btnBold.BackColor = Color.Orange Then
            btnBold.BackColor = Color.LightBlue
        Else
            btnBold.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
    End Sub

    Private Sub btnItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItalic.Click
        tbBody.Focus()
        If btnItalic.BackColor = Color.Orange Then
            btnItalic.BackColor = Color.LightBlue
        Else
            btnItalic.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
    End Sub

    Private Sub btnUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnderline.Click
        tbBody.Focus()
        If btnUnderline.BackColor = Color.Orange Then
            btnUnderline.BackColor = Color.LightBlue
        Else
            btnUnderline.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
    End Sub

    Private Sub btnStrickLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrickLine.Click
        tbBody.Focus()
        If btnStrickLine.BackColor = Color.Orange Then
            btnStrickLine.BackColor = Color.LightBlue
        Else
            btnStrickLine.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
    End Sub

    Private Sub cbSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSize.SelectedIndexChanged
        tbBody.Focus()
        refreshTextBoxFont()
    End Sub

    Private Sub cbFontName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFontName.SelectedIndexChanged
        refreshTextBoxFont()
    End Sub

    Private Sub pnlColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlColor.Click
        refreshTextBoxColor()
    End Sub

    Private Sub pnlChangeColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlChangeColor.Click
        Dim x As New ColorDialog
        x.Color = pnlColor.BackColor
        x.ShowDialog()
        pnlColor.BackColor = x.Color
        refreshTextBoxColor()
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndo.Click
        tbBody.Undo()
    End Sub

    Private Sub btnRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRedo.Click
        tbBody.Redo()
    End Sub

    Sub refreshTextBoxColor()
        Try
            tbBody.SelectionColor = pnlColor.BackColor
        Catch
        End Try
    End Sub

    Sub refreshTextBoxFont()
        Try
            Dim x As New FontStyle
            x = FontStyle.Regular
            If btnBold.BackColor = Color.Orange Then x = x Or FontStyle.Bold
            If btnItalic.BackColor = Color.Orange Then x = x Or FontStyle.Italic
            If btnUnderline.BackColor = Color.Orange Then x = x Or FontStyle.Underline
            If btnStrickLine.BackColor = Color.Orange Then x = x Or FontStyle.Strikeout

            tbBody.SelectionFont = New Font(cbFontName.Text, Single.Parse(cbSize.Text), x)
        Catch
        End Try
    End Sub

    Private Sub BtAlignLeft_Click(sender As Object, e As EventArgs) Handles BtAlignLeft.Click
        tbBody.Focus()
        If BtAlignLeft.BackColor = Color.Orange Then
            BtAlignLeft.BackColor = Color.LightBlue
        Else
            BtAlignLeft.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
        tbBody.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub BtAlignCenter_Click(sender As Object, e As EventArgs) Handles BtAlignCenter.Click
        tbBody.Focus()
        If BtAlignCenter.BackColor = Color.Orange Then
            BtAlignCenter.BackColor = Color.LightBlue
        Else
            BtAlignCenter.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
        tbBody.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub BtAlignRight_Click(sender As Object, e As EventArgs) Handles BtAlignRight.Click
        tbBody.Focus()
        If BtAlignRight.BackColor = Color.Orange Then
            BtAlignRight.BackColor = Color.LightBlue
        Else
            BtAlignRight.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
        tbBody.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BtNumbered_Click(sender As Object, e As EventArgs) Handles BtNumbered.Click
        tbBody.Focus()
        If BtNumbered.BackColor = Color.Orange Then
            BtNumbered.BackColor = Color.LightBlue
        Else
            BtNumbered.BackColor = Color.Orange
        End If
        refreshTextBoxFont()

        'txtBody.SelectedText = "• " & txtBody.SelectedText

        Const RTF_NUMSTART As String =
        "{\rtf1\ansi\deff0\deftab720{\fonttbl{\f0\fswiss MS " &
            "Sans Serif;}{\f1\froman\fcharset2 " &
            "Symbol;}{\f2\fnil\fprq2\fcharset2 " &
            "Wingdings;}{\f3\froman\fprq2 Times New " &
            "Roman;}}" & vbCrLf &
        "{\colortbl\red0\green0\blue0;}" & vbCrLf &
        "\deflang1033\pard\li720\fi-360\plain\f3\fs24 " &
            "1.\tab "
        Const RTF_NUMITEM As String =
            "\par @%@.\tab "
        Const RTF_NUMEND As String = "\par }"

        ' Get the current text.
        Dim old_text As String =
            tbBody.SelectedText.Replace(vbCrLf, vbLf)
        Dim lines() As String = Split(old_text, vbLf)

        ' Start the list.
        Dim new_text As String = RTF_NUMSTART & lines(0) &
            vbCrLf

        ' Add the other lines.
        For i As Integer = 1 To lines.Length - 1
            new_text &=
                RTF_NUMITEM.Replace("@%@", (i + 1).ToString()) _
                    &
                lines(i) & vbCrLf
        Next i

        ' Remove the final vbCrLf.
        new_text = new_text.Substring(0, new_text.Length -
            vbCrLf.Length)

        ' End the list.
        new_text &= RTF_NUMEND

        ' Save the result.
        tbBody.SelectedRtf = new_text

        tbBody.Focus()
    End Sub

    Private Sub BtBulleted_Click(sender As Object, e As EventArgs) Handles BtBulleted.Click
        tbBody.Focus()
        If BtBulleted.BackColor = Color.Orange Then
            BtBulleted.BackColor = Color.LightBlue
        Else
            BtBulleted.BackColor = Color.Orange
        End If
        refreshTextBoxFont()
        'txtBody.SelectedText = "• " & txtBody.SelectedText

        Const RTF_BULSTART As String =
        "{\rtf1\ansi\deff0\deftab720{\fonttbl{\f0\fswiss MS " &
            "Sans Serif;}{\f1\froman\fcharset2 " &
            "Symbol;}{\f2\froman\fprq2 Times New " &
            "Roman;}{\f3\fnil\fprq2\fcharset2 Wingdings;}}" _
            & vbCrLf &
        "{\colortbl\red0\green0\blue0;}" & vbCrLf &
        "\deflang1033\pard\li1080\fi-360\tx1080\plain\f3\fs24 " &
            "v\tab \plain\f2\fs24 "
        Const RTF_BULITEM As String =
            "\par \plain\f3\fs24 v\tab \plain\f2\fs24 "
        Const RTF_BULEND As String = "\par }"

        ' Get the current text.
        Dim old_text As String =
            tbBody.SelectedText.Replace(vbCrLf, vbLf)
        Dim lines() As String = Split(old_text, vbLf)

        ' Start the list.
        Dim new_text As String = RTF_BULSTART & lines(0) &
            vbCrLf

        ' Add the other lines.
        For i As Integer = 1 To lines.Length - 1
            new_text &=
                RTF_BULITEM.Replace("@%@", (i + 1).ToString()) _
                    &
                lines(i) & vbCrLf
        Next i

        ' Remove the final vbCrLf.
        new_text = new_text.Substring(0, new_text.Length -
            vbCrLf.Length)

        ' End the list.
        new_text &= RTF_BULEND

        ' Save the result.
        tbBody.SelectedRtf = new_text

        tbBody.Focus()
    End Sub

    Private Sub BtAddImage_Click(sender As Object, e As EventArgs) Handles BtAddImage.Click
        tbBody.Focus()
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = String.Empty Then
            Dim img As Image = Image.FromFile(OpenFileDialog1.FileName)
            Clipboard.SetImage(img)
            tbBody.Paste()
        End If
    End Sub


    Public Sub LoadFont()
        tbBody.Font = My.Settings.LastFont
        cbFontName.Text = My.Settings.LastFont.FontFamily.Name
        cbSize.Text = My.Settings.LastFont.Size.ToString
        If My.Settings.LastFont.Bold Then btnBold.BackColor = Color.Orange
        If My.Settings.LastFont.Italic Then btnItalic.BackColor = Color.Orange
        If My.Settings.LastFont.Underline Then btnUnderline.BackColor = Color.Orange
        If My.Settings.LastFont.Strikeout Then btnStrickLine.BackColor = Color.Orange
    End Sub

    Public Sub SaveFont()
        Dim x As New FontStyle
        x = FontStyle.Regular
        If btnBold.BackColor = Color.Orange Then x = x Or FontStyle.Bold
        If btnItalic.BackColor = Color.Orange Then x = x Or FontStyle.Italic
        If btnUnderline.BackColor = Color.Orange Then x = x Or FontStyle.Underline
        If btnStrickLine.BackColor = Color.Orange Then x = x Or FontStyle.Strikeout

        My.Settings.LastFont = New Font(cbFontName.Text, Single.Parse(cbSize.Text), x)
        My.Settings.Save()
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        Clear()
    End Sub


End Class