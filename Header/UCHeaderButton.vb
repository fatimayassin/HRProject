Public Class UCHeaderButton
    Public Event Myclick(ByVal MyIndex As Integer)
    ' Public Property MainBackColor As Color
    ' Public Property MainBackColorLight As Color
    ' Public Property MainBackColorDark As Color
    ' Public Property MainFontColor As Color
    '   Public Property Maincolor2 As Color






    Public Property MyTag As String
    Public Property myIndex As Integer
    Public Property Caption As String = False
    Dim SelectedStatus As Boolean

    Public Sub InitControl(ByVal myMyTag As String, ByVal mymyIndex As Integer, ByVal myCaption As String)
        ' MainBackColor = MyMainBackColor
        'MainBackColorLight = MyMainBackColorLight
        ' MainBackColorDark = MyMainBackColorDark
        '  MainFontColor = MyMainFontColor
        ' Maincolor2 = myMaincolor2

        Caption = myCaption
        myIndex = mymyIndex
        Caption = myCaption
        Label1.Text = Caption
        Label1.BackColor = MainColor
        Label1.ForeColor = MainColorTextLight


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RaiseEvent Myclick(myIndex)
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        If SelectedStatus = True Then
            Label1.BackColor = Maincolor2
            Label1.ForeColor = MainColor
        Else
            Label1.BackColor = MainColorLight
            Label1.ForeColor = Nothing
        End If
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        If SelectedStatus = True Then
            Label1.BackColor = Maincolor2
            Label1.ForeColor = MainColor
        Else
            Label1.BackColor = Nothing
            Label1.ForeColor = Nothing
        End If
    End Sub

    Public Sub SelectedTab(ByVal selectedID As Integer)
        If selectedID = myIndex Then
            SelectedStatus = True
            Label1.BackColor = Maincolor2
            Label1.ForeColor = MainColor
        Else
            SelectedStatus = False
            Label1.BackColor = Nothing
            Label1.ForeColor = Nothing
        End If
    End Sub
End Class
