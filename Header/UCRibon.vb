Public Class UCRibon

    Public MyIndex As Integer
    Public MyTag As String
    Dim isvisible As Boolean
    Public Event MyClick(ByVal sender As UCButton)

    Public Sub initRibon(ByVal RMyIndex As Integer, ByVal RMyTag As String)

        MyIndex = RMyIndex
        MyTag = RMyTag

        Me.BackColor = maincolor2

        setVisible(True)
        Label1.BackColor = MainColor
        Label2.BackColor = MainColor
    End Sub

    Public Sub VisibleBtn(ByVal ribonIndex As Integer, ByVal btnIndex As Integer, ByVal MyVisible As Boolean)

        For Each x In FlowLayoutPanel1.Controls
            If x.myindex = ribonIndex Then
                x.VisibleBtn(btnIndex, MyVisible)
            End If
        Next

    End Sub
    Public Sub EnableBtn(ByVal ribonIndex As Integer, ByVal btnIndex As Integer, ByVal MyEnable As Boolean)

        For Each x In FlowLayoutPanel1.Controls
            If x.myindex = ribonIndex Then
                x.EnableBtn(btnIndex, MyEnable)
            End If
        Next

    End Sub

    Public Sub setVisible(ByVal v As Boolean)
        If v = True Then
            Me.Visible = True
        Else
            Me.Visible = False
        End If

    End Sub

    Public Sub SelectedTab(ByVal selectedID As Integer)
        If selectedID = MyIndex Then
            setVisible(True)
        Else
            setVisible(False)
        End If
    End Sub

    Public Sub addPanel(ByVal newpanel As UCPanelOfRibon)
        FlowLayoutPanel1.Controls.Add(newpanel)

        'MessageBox.Show(newpanel.Width)
        'Panel1.Width = newpanel.Width
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TableLayoutPanel5.ColumnStyles(0).Width = 0 Then
        Else
            If FlowLayoutPanel1.Location.X < 0 Then
                TableLayoutPanel5.ColumnStyles(2).Width = 20
            End If

            If FlowLayoutPanel1.Location.X <= Me.Width - FlowLayoutPanel1.Width Then
                TableLayoutPanel5.ColumnStyles(0).Width = 0
                Timer1.Enabled = False
                FlowLayoutPanel1.Location = New Point(Me.Width - FlowLayoutPanel1.Width, 0)
            Else
                FlowLayoutPanel1.Location = New Point(FlowLayoutPanel1.Location.X - 10, 0)
            End If

        End If

    End Sub

    'Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
    '    Label1.ForeColor = Color.Black
    '    Timer1.Enabled = True
    'End Sub

    'Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp

    '    Label1.ForeColor = Color.White
    '    Timer1.Enabled = False
    'End Sub

    'Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
    '    Label2.ForeColor = Color.Black
    '    Timer2.Enabled = True
    'End Sub

    'Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
    '    Label2.ForeColor = Color.White
    '    Timer2.Enabled = False
    'End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If TableLayoutPanel5.ColumnStyles(2).Width = 0 Then
        Else
            If FlowLayoutPanel1.Location.X >= 0 Then
                FlowLayoutPanel1.Location = New Point(0, 0)
                TableLayoutPanel5.ColumnStyles(2).Width = 0
            Else
                FlowLayoutPanel1.Location = New Point(FlowLayoutPanel1.Location.X + 10, 0)
            End If

            If FlowLayoutPanel1.Location.X >= Me.Width - FlowLayoutPanel1.Width Then
                TableLayoutPanel5.ColumnStyles(0).Width = 20
            End If
        End If


    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.BackColor = MainColorLight
        Label1.ForeColor = Color.Black
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = MainColor
        Label1.ForeColor = Color.White
        Timer1.Enabled = False
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.BackColor = MainColorLight
        Label2.ForeColor = Color.Black
        Timer2.Enabled = True
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = MainColor
        Label2.ForeColor = Color.White
        Timer2.Enabled = False
    End Sub

    Private Sub UCRibon_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        If FlowLayoutPanel1.Width > Me.Width Then
            TableLayoutPanel5.ColumnStyles(0).Width = 0
            TableLayoutPanel5.ColumnStyles(2).Width = 20
        Else
            TableLayoutPanel5.ColumnStyles(0).Width = 0
            TableLayoutPanel5.ColumnStyles(2).Width = 0
        End If
        Panel1.Location = New Point(0, 0)
    End Sub
End Class
