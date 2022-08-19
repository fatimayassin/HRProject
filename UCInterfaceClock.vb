Public Class UCInterfaceClock
    Private back, hour1, minute1, dot, second1 As Bitmap

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Now As DateTime = DateTime.Now
        Dim Hour As Integer = Now.Hour
        Dim Minute As Integer = Now.Minute
        Dim Second As Integer = Now.Second
        Dim AngleS As Single = Second * 6
        Dim AngleM As Single = Minute * 6 + AngleS / 60
        Dim AngleH As Single = Hour * 30 + AngleM / 12
        backBox.Image = back
        backBox.Controls.Add(hourBox)
        hourBox.Location = New Point(53, 52)
        hourBox.Image = rotateImage(hour1, AngleH)
        hourBox.Controls.Add(minuteBox)
        minuteBox.Location = New Point(0, 0)
        minuteBox.Image = rotateImage(minute1, AngleM)
        minuteBox.Controls.Add(dotBox)
        dotBox.Location = New Point(0, 0)
        dotBox.Image = dot
        dotBox.Controls.Add(secondBox)
        secondBox.Location = New Point(0, 0)
        secondBox.Image = rotateImage(second1, AngleS)
    End Sub

    Private Sub UCInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        back = New Bitmap(".\ClockFinal.png")
        hour1 = New Bitmap(".\hour1.png")
        minute1 = New Bitmap(".\minute1.png")
        dot = New Bitmap(".\dot1.png")
        second1 = New Bitmap(".\second1.png")
    End Sub

    Private Function rotateImage(ByVal rotateMe As Bitmap, ByVal angle As Single) As Bitmap
        Dim rotatedImage As Bitmap = New Bitmap(rotateMe.Width, rotateMe.Height)

        Using g As Graphics = Graphics.FromImage(rotatedImage)
            g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2)
            g.RotateTransform(angle)
            g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2)
            g.DrawImage(rotateMe, New Point(0, 0))
        End Using

        Return rotatedImage
    End Function

End Class
