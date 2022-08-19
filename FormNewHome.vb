Public Class FormNewHome
    Dim counter As Integer = 0
    Dim Isloaded = False
    Public mypoint As Point
    Dim clickLoc As Point

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const WS_SYSMENU As Int32 = &H80000
            Const WS_MAXIMIZEBOX As Int32 = &H10000
            Const WS_MINIMIZEBOX As Int32 = &H20000
            cp.Style = cp.Style Or WS_SYSMENU Or WS_MINIMIZEBOX
            cp.Style = cp.Style And Not WS_MAXIMIZEBOX
            Return cp
        End Get
    End Property

    Private Sub FormNewHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        Me.Panel1.BackColor = My.Settings.FormBackgroundColor
        StatusStrip1.BackColor = My.Settings.PanelColor
        'UltraSplitter3.ButtonAppearance.BackColor = My.Settings.PanelColor
        'UltraSplitter3.ButtonAppearance.BackColor2 = My.Settings.PanelColor

        Dim x As New HeaderClassActions
        x.initheader(Me, UcHeader1, 0)
        'x.initheaderBody(Me, UcHeader1, 0)
        PublicContainerPanel = Me.Panel1
        'MyOpenForm(New FrmInterface)
        'MyOpenForm(New FormPanel3)
        ' MyOpenForm(New FrmDockable)
        ' MyOpenForm(New FrmPanels)
        MyOpenForm(New Form6)

        Timer1Refresh.Start()

        Isloaded = True
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)


        cscreen = New Point((My.Computer.Screen.Bounds.Width - Me.Width) / 2, (My.Computer.Screen.Bounds.Height - Me.Height) / 2)
        'Me.Location = cscreen
        applocation = New Point(0, 0)

        Using aMainor As New LqHRDataContext(cnx)
            Dim user = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.Username).ToList(0)
            lblUser.Text = " Logged in as " & " " & user
            ToolStripStatusLabel3.Text = " Logged in At" & " " & Today & " " & TimeOfDay
        End Using

    End Sub

    Private Sub Timer1Refresh_Tick(sender As Object, e As EventArgs) Handles Timer1Refresh.Tick
        counter += 1
        If counter = 60 Then
            For Each x In Panel1.Controls
                If x.visible = True Then
                    Try
                        '  x.refreshdata
                    Catch
                    End Try
                    counter = 0
                End If
            Next
        End If
        UcHeader1.reftimer(counter.ToString)
    End Sub

    Private Sub UcHeader1_ClickBtnRefresh()
        For Each x In Panel1.Controls
            If x.visible = True Then
                x.refreshdata
                counter = 0
                UcHeader1.reftimer(counter.ToString)
            End If
        Next
    End Sub

    Private Sub UcHeaderTop1_SizeChanged(sender As Object, e As EventArgs)

        For Each x In Panel1.Controls
            If x.visible = True Then

                x.Size = Panel1.Size
                x.Location = New Point(cscreen.X, cscreen.Y)

                UcHeader1.reftimer(counter.ToString)
            End If
        Next


    End Sub

    'Private Sub Panelsize_MouseDown(sender As Object, e As MouseEventArgs) Handles Panelsize.MouseDown
    '    If UcHeader1.IsMaximized = False Then
    '        TimerSize.Enabled = True
    '        clickLoc = e.Location
    '    End If
    'End Sub

    'Private Sub Panelsize_MouseUp(sender As Object, e As MouseEventArgs) Handles Panelsize.MouseUp
    '    TimerSize.Enabled = False
    'End Sub

    Private Sub TimerSize_Tick(sender As Object, e As EventArgs) Handles TimerSize.Tick
        '    MessageBox.Show(MousePosition.X & " " & mypoint.X & " " & MousePosition.X)
        If MousePosition.X > mypoint.X Then
            Width = Width + (MousePosition.X - mypoint.X) - 5
        Else
            Me.Width = Width + (MousePosition.X - mypoint.X) - 5
        End If
        If MousePosition.Y > mypoint.Y Then
            Height = Height + (MousePosition.Y - mypoint.Y) - 5
        Else
            Height = Height + (MousePosition.Y - mypoint.Y) - 5
        End If
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)

    End Sub
    Private Sub frmMainForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)
        cscreen = New Point((My.Computer.Screen.Bounds.Width - Me.Width) / 2, (My.Computer.Screen.Bounds.Height - Me.Height) / 2)
        ' Me.Location = cscreen
        applocation = Me.Location
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        applocation = Me.Location
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        For Each x In Panel1.Controls
            If x.Name = "frm1" Then
                Exit For
            Else

                '  End If
                x.close
                '    isopen = True
            End If
            Exit For
        Next
    End Sub

End Class