Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Public Class FrmComposeMail
    Public Id As Integer = 0
    Private attachmentListstored As List(Of System.Net.Mail.Attachment)

    Private Sub FrmComposeMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        TableLayoutPanel1.BackColor = My.Settings.FormBackgroundColor
        BtnUndo.BackColor = My.Settings.PanelColor
        BtnRedo.BackColor = My.Settings.PanelColor
        btnBold.BackColor = My.Settings.PanelColor
        btnUnderline.BackColor = My.Settings.PanelColor
        btnItalic.BackColor = My.Settings.PanelColor
        btnStrickLine.BackColor = My.Settings.PanelColor
        BtAlignLeft.BackColor = My.Settings.PanelColor
        BtAlignCenter.BackColor = My.Settings.PanelColor
        BtAlignRight.BackColor = My.Settings.PanelColor
        BtNumbered.BackColor = My.Settings.PanelColor
        BtBulleted.BackColor = My.Settings.PanelColor
        btnSend.BackColor = My.Settings.PanelColor
        BtFormatOptions.BackColor = My.Settings.PanelColor
        BtAttach.BackColor = My.Settings.PanelColor
        BtRemove.BackColor = My.Settings.PanelColor
        BtClear.BackColor = My.Settings.PanelColor

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
        If Not attachmentList.Items.Count = 0 Then
            attachmentList.Items.Clear()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Using mail As New MailMessage()

            mail.From = New MailAddress(FrmSignInAccount.tbuser.Text.Trim() + FrmSignInAccount.tbLogin.Text.Trim())
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

            Dim strHTML As String
            If Me.tbBody.Text = Nothing Then
                Me.tbBody.Text = ""
            Else
                strHTML = ConvertToHTML(tbBody)
                tbBody.Text = strHTML.ToString
            End If

            If (tbBody.Text Is Nothing) Then
                mail.Body = "n/a"
            Else
                mail.Body = tbBody.Text
            End If

            mail.IsBodyHtml = True

            If Not attachmentList Is Nothing Then
                For Each attachment As System.Net.Mail.Attachment In attachmentListstored
                    mail.Attachments.Add(attachment)
                Next
            End If

            Dim Host As String
            If FrmSignInAccount.tbhostname.Text = "Other" Then
                Host = FrmSignInAccount.TextOtherHost.Text
            Else
                Host = FrmSignInAccount.tbhostname.Text
            End If

            Using smtp As New SmtpClient(Host, FrmSignInAccount.ComboSMTPPort.Text)
                smtp.Credentials = New NetworkCredential(FrmSignInAccount.tbuser.Text.Trim() + FrmSignInAccount.tbLogin.Text.Trim(), FrmSignInAccount.tbPassword.Text.Trim())
                'smtp.UseDefaultCredentials = False
                smtp.EnableSsl = True
                DisableCertificateValidation()
                smtp.Send(mail)
                MessageBox.Show("Email sent.", "Message")
                Clear()
            End Using

        End Using
    End Sub

    Public Function ConvertToHTML(ByVal Box As RichTextBox) As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer
        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then
            Exit Function
        End If
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters
        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size
        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont &
              "; font-size: " & shtSize & "pt; color: " _
                              & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If

        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += Box.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) =
                       Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Box.SelectionColor.ToKnownColor.ToString <>
                   strColour Or Box.SelectionFont.FontFamily.Name _
                   <> strFont Or Box.SelectionFont.Size <> shtSize _
                   Then
                strHTML += "</span><span style=""font-family: " _
                      & Box.SelectionFont.FontFamily.Name &
                      "; font-size: " & Box.SelectionFont.Size &
                      "pt; color: " &
                      Box.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then
                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)
            ' Update variables with current style
            strColour = Box.SelectionColor.ToKnownColor.ToString
            blnBold = Box.SelectionFont.Bold
            blnItalic = Box.SelectionFont.Italic
            strFont = Box.SelectionFont.FontFamily.Name
            shtSize = Box.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></html>"
        ' Restore original RichTextBox selection
        Box.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
    End Function

    Private Shared Sub DisableCertificateValidation()
        ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
    End Sub

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

        'Dim myLines As New List(Of String)
        'For Each oneline In txtBody.Lines
        '    myLines.Add(oneline)
        'Next
        'txtBody.SuspendLayout()

        'txtBody.Clear()
        'Dim lineindex As Integer = 1
        'For Each oneline In myLines
        '    If oneline <> "" Then
        '        If oneline.Contains(lineindex.ToString & ".") Then
        '            txtBody.AppendText(oneline)
        '        Else
        '            txtBody.AppendText(lineindex & ". " & oneline & vbCrLf)
        '        End If

        '        lineindex += 1
        '    End If
        'Next
        'txtBody.ResumeLayout()

        'Dim theText() As String

        'theText = txtBody.Lines
        'txtBody.Clear()
        'For tt As Integer = 1 To theText.Length
        '    txtBody.AppendText(tt.ToString.PadRight(3, " "c) & theText(tt - 1) & Environment.NewLine)
        'Next

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

    'Private Sub BtAddImage_Click(sender As Object, e As EventArgs) Handles BtAddImage.Click
    '    tbBody.Focus()
    '    OpenFileDialog1.ShowDialog()
    '    If Not OpenFileDialog1.FileName = String.Empty Then
    '        Dim img As Image = Image.FromFile(OpenFileDialog1.FileName)
    '        Clipboard.SetImage(img)
    '        tbBody.Paste()
    '    End If
    'End Sub


    'Public Sub LoadFont()
    '    tbBody.Font = My.Settings.LastFont
    '    cbFontName.Text = My.Settings.LastFont.FontFamily.Name
    '    cbSize.Text = My.Settings.LastFont.Size.ToString
    '    If My.Settings.LastFont.Bold Then btnBold.BackColor = Color.Orange
    '    If My.Settings.LastFont.Italic Then btnItalic.BackColor = Color.Orange
    '    If My.Settings.LastFont.Underline Then btnUnderline.BackColor = Color.Orange
    '    If My.Settings.LastFont.Strikeout Then btnStrickLine.BackColor = Color.Orange
    'End Sub

    'Public Sub SaveFont()
    '    Dim x As New FontStyle
    '    x = FontStyle.Regular
    '    If btnBold.BackColor = Color.Orange Then x = x Or FontStyle.Bold
    '    If btnItalic.BackColor = Color.Orange Then x = x Or FontStyle.Italic
    '    If btnUnderline.BackColor = Color.Orange Then x = x Or FontStyle.Underline
    '    If btnStrickLine.BackColor = Color.Orange Then x = x Or FontStyle.Strikeout

    '    My.Settings.LastFont = New Font(cbFontName.Text, Single.Parse(cbSize.Text), x)
    '    My.Settings.Save()
    'End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        Clear()
    End Sub

    Private Sub BtAttach_Click(sender As Object, e As EventArgs) Handles BtAttach.Click

        If TableLayoutPanel1.RowStyles(6).SizeType = SizeType.Absolute And TableLayoutPanel1.RowStyles(6).Height = 0 Then
            TableLayoutPanel1.RowStyles(6).SizeType = SizeType.Percent = 25.22
            TableLayoutPanel1.RowStyles(6).Height = 107
        End If

        If Not attachmentListstored Is Nothing Then
            If attachmentListstored.Count < 0 Then
                attachmentListstored = New List(Of System.Net.Mail.Attachment)
            End If
        Else
            attachmentListstored = New List(Of System.Net.Mail.Attachment)
        End If

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            For Each item As String In OpenFileDialog1.FileNames

                'Create a new System.NET.Mail.Attachment class instance for each file.
                attachmentListstored.Add(New System.Net.Mail.Attachment(item))

                Dim itm As ListViewItem = New ListViewItem()
                itm.Text = fi.Name
                itm.SubItems.Add(fi.Extension)
                itm.SubItems.Add(fi.Length.ToString())
                itm.Tag = attachmentListstored

                attachmentList.Items.Add(itm)

            Next
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

    Private Sub BtRemove_Click(sender As Object, e As EventArgs) Handles BtRemove.Click
        If attachmentList.SelectedItems.Count > 0 Then
            For Each i As ListViewItem In attachmentList.SelectedItems
                attachmentList.Items.Remove(i)
                MessageBox.Show("Attachment is Removed")
            Next
        Else
            MessageBox.Show("Please Select An Attachment to Remove")
        End If
    End Sub


End Class