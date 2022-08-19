Public Class UCButton
    Public mybackcolor As Color
    Public mybackcolorDark As Color
    Public mybackcolorlight As Color
    Public mycolor2 As Color
    Public DisableColor As Color = Color.LightGray
    Public myimage As Image
    Public MyIndex As Integer
    Public MyTag As String
    Public IsEnable As Boolean = True
    Dim functionToRunOnCLick As String



    Public Sub EnableBtn(ByVal MyEnable As Boolean)
        IsEnable = MyEnable

        If IsEnable = True Then
            Me.BackColor = mybackcolor
        Else
            Me.BackColor = DisableColor
        End If

    End Sub

    Public Sub initBtn(ByVal bMyIndex As Integer, ByVal bMyLable As String, ByVal bMyTag As String, ByVal bmyimage As Image, ByVal bmybackcolor As Color, ByVal bmybackcolorDark As Color, ByVal bmybackcolorlight As Color, ByVal bmycolor2 As Color, ByVal NameActionToRun As String)



        mybackcolor = bmybackcolor

        mybackcolorDark = bmybackcolorDark
        mybackcolorlight = bmybackcolorlight
        mycolor2 = bmycolor2

        myimage = bmyimage
        Label1.Text = bMyLable
        MyIndex = bMyIndex
        MyTag = bMyTag
        Panel1.BackgroundImage = myimage
        functionToRunOnCLick = NameActionToRun

        If IsEnable = True Then
            Me.BackColor = mybackcolor
        Else
            Me.BackColor = DisableColor
        End If

        Me.Label1.ForeColor = mycolor2

    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label1.MouseEnter, Panel1.MouseUp, Label1.MouseUp
        If IsEnable = True Then
            Me.BackColor = mybackcolorlight
            'Panel1.BackColor = mybackcolorlight
            'Label1.ForeColor = ButtonRibonTextColor
            ToolTip1.SetToolTip(Panel1, MyTag)
            ToolTip1.SetToolTip(Label1, MyTag)
        Else
            Me.BackColor = DisableColor
        End If


    End Sub
    Private Sub Panel1_mouseleave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave, Label1.MouseLeave
        If IsEnable = True Then
            Me.BackColor = Nothing
            'Panel1.BackColor = ButtonRibonColor
            'Label1.ForeColor = ButtonRibonTextColor
        Else
            Me.BackColor = DisableColor
        End If


    End Sub
    Private Sub Panel1_Mousedown(sender As Object, e As EventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        If IsEnable = True Then
            Me.BackColor = mybackcolorDark
            'Panel1.BackColor = ButtonRibonColorDark
            'Label1.ForeColor = ButtonRibonTextColorLight
        Else
            Me.BackColor = DisableColor
        End If

    End Sub


    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Label1.Click
        If IsEnable = True Then
            Dim x As New HeaderClassActions
            CallByName(x, functionToRunOnCLick, CallType.Method)
        End If
    End Sub
End Class
