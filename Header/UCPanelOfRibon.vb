Public Class UCPanelOfRibon

    Public MyIndex As Integer
    Public MytabId As Integer
    Public mywidth As Decimal = 0
    Public Event MyClick(ByVal sender As UCButton)

    Public Sub EnableBtn(ByVal btnIndex As Integer, ByVal MyEnable As Boolean)

        For Each x In FlowLayoutPanel1.Controls
            If x.myindex = btnIndex Then
                x.EnableBtn(MyEnable)
            End If
        Next

    End Sub
    Public Sub VisibleBtn(ByVal btnIndex As Integer, ByVal MyVisible As Boolean)

        For Each x In FlowLayoutPanel1.Controls
            If x.myindex = btnIndex Then
                x.Visible = MyVisible


                If MyVisible = True Then
                    mywidth = Me.Width + x.Width + 1
                    Me.Width = mywidth
                Else
                    mywidth = Me.Width - x.Width - 1
                    Me.Width = mywidth
                End If
            End If
        Next

    End Sub

    Public Sub initpanel(ByVal LMyIndex As Integer, ByVal LMyLable As String, ByVal LMyTag As String, ByVal Lmybackcolor As Color, ByVal lmainbackcolor As Color)
        MyIndex = LMyIndex

        MytabId = MytabId
        'BackColor = maincolor2
        'Label1.BackColor = MainColor
        'Label1.ForeColor = maincolor2
        'PanelVertical.BackColor = MainColor
        BackColor = Lmybackcolor
        Label1.BackColor = lmainbackcolor
        Label1.ForeColor = Lmybackcolor
        PanelVertical.BackColor = lmainbackcolor

        Label1.Text = LMyLable

    End Sub


    Public Sub addbtn(ByVal x As UCButton)
        FlowLayoutPanel1.Controls.Add(x)
        'mywidth = mywidth + x.Width + 0.4
        'Me.Width = mywidth
    End Sub

End Class
