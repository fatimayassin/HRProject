Imports System.IO
Public Class FrmShowAttachment
    Public AttachId As Integer = 0
    Dim d As Byte

    Private Sub FrmShowAttachment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Try
            Dim stream As New MemoryStream()
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.TblAttachments Where ax.Id = AttachId Select ax.Attachmment).ToList(0)
                Dim image As Byte() = CType(res.ToArray, Byte())
                'RichTextBox1.Text = System.Text.Encoding.Default.GetString(image)
                stream.Write(image, 0, image.Length)
                Dim bitmap As New Bitmap(stream)
                PictureBox1.Image = bitmap
                PictureBox1.BackgroundImageLayout = ImageLayout.Zoom

                ''''''''''''


            End Using



        Catch ex As Exception

        End Try


    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class