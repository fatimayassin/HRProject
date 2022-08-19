Public Class UCMyButton
    Public Property mybackcolor As Color
    Public Property mybackcolorDark As Color
    Public Property mybackcolorlight As Color
    Public Property mycolor2 As Color
    Dim varmyimage As Image


    Public Event OnClinck()
    Dim varMyLable As String

    Public Property mylable As String
        Set(value As String)
            varMyLable = value
            Label1.Text = mylable
        End Set
        Get
            Return varMyLable
        End Get
    End Property
    Public Property myimage As Image
        Set(value As Image)
            varmyimage = value
            Panel1.BackgroundImage = varmyimage
        End Set
        Get
            Return varmyimage
        End Get
    End Property



    'Public Sub initBtn(ByVal bMyLable As String, ByVal bmyimage As Image, ByVal bmybackcolor As Color, ByVal bmybackcolorDark As Color, ByVal bmybackcolorlight As Color, ByVal bmycolor2 As Color)
    '    mybackcolor = bmybackcolor
    '    mybackcolorDark = bmybackcolorDark
    '    mybackcolorlight = bmybackcolorlight
    '    mycolor2 = bmycolor2

    '    myimage = bmyimage
    '    Label1.Text = bMyLable
    '    Panel1.BackgroundImage = myimage


    '    Panel1.BackColor = mybackcolor

    '    Label1.BackColor = mycolor2
    '    Label1.ForeColor = mybackcolor
    'End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label1.MouseEnter, Panel1.MouseUp, Label1.MouseUp
        Panel1.BackColor = mybackcolorlight
    End Sub

    Private Sub Panel1_mouseleave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave, Label1.MouseLeave
        Panel1.BackColor = mybackcolor
    End Sub

    Private Sub Panel1_Mousedown(sender As Object, e As EventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        Panel1.BackColor = mybackcolorDark
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Label1.Click
        RaiseEvent OnClinck()
    End Sub

    Private Sub UCMyButton_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = mylable
        Panel1.BackgroundImage = myimage

        Panel1.BackColor = mybackcolor

        Label1.BackColor = mycolor2
        Label1.ForeColor = mybackcolor
        BackColor = mycolor2
    End Sub
End Class
