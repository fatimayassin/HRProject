Public Class UCHeader


    Dim f As Form
    Public mycaption As String

    Dim MyWindiwsState As String = "."

    Public Event ClickBtnRefresh()
    Public Event CloseForm()

    Dim ViewSettingButton As Boolean = True
    Dim ViewRefreshButton As Boolean = True
    Dim ViewCounter As Boolean = True
    Dim ViewMinimizeButton As Boolean = True
    Dim ViewMaximizeButton As Boolean = True
    Dim ViewCloseButton As Boolean = True
    Dim ViewLogoutButton As Boolean = True
    Dim ViewLogedInName As Boolean = True
    Dim FClick As Point
    Public IsMaximized As Boolean = False
    Dim Fwidth As Integer = 1280
    Dim fHeight As Integer = 786
    Dim garbagethred As Threading.Thread
    Dim lastx As Integer

    Sub ThreadRunning()

        While (True)
            GC.Collect()
            garbagethred.Sleep(10000)
        End While
    End Sub

    Public Sub ChangeWindowsState()
        If Not IsMaximized = True Then
            MyWindiwsState = "-"
        Else
            MyWindiwsState = "."
        End If
        lblWindowsState.Text = MyWindiwsState
    End Sub

    Public Sub EnableBtn(ByVal ribonIndex As Integer, ByVal btnIndex As Integer, ByVal MyEnable As Boolean)

        For Each x In Panel2.Controls
            If x.myindex = ribonIndex Then
                x.EnableBtn(ribonIndex, btnIndex, MyEnable)
            End If
        Next

    End Sub
    Public Sub visubleBtn(ByVal ribonIndex As Integer, ByVal btnIndex As Integer, ByVal Myvisible As Boolean)

        For Each x In Panel2.Controls
            If x.myindex = ribonIndex Then
                x.visibleBtn(ribonIndex, btnIndex, Myvisible)
            End If
        Next

    End Sub
    Public Sub InitHeader(ByVal caption As String, ByVal ParentForm As Form, ByVal mMainColor As Color, ByVal mMainColorLight As Color, ByVal mMaincolorDark As Color, ByVal mMainColorText As Color, ByVal mmaincolor2 As Color, ByVal mmaincolor2dark As Color, ByVal mmaincolor2light As Color, ByVal mTextColor2 As Color, ByVal mViewSettingButton As Boolean, ByVal mViewRefreshButton As Boolean, ByVal mViewCounter As Boolean, ByVal mViewMinimizeButton As Boolean, ByVal mViewMaximizeButton As Boolean, ByVal mViewCloseButton As Boolean, ByVal mViewLogoutButton As Boolean, ByVal mViewLogedInName As Boolean)



        f = ParentForm
        mycaption = caption
        MainColor = mMainColor
        MainColorLight = mMainColorLight
        MaincolorDark = mMaincolorDark
        MainColorText = mMainColorText

        maincolor2 = mmaincolor2
        maincolor2dark = mmaincolor2dark
        maincolor2light = mmaincolor2light
        'TextColor2 = mTextColor2

        ViewSettingButton = mViewSettingButton
        ViewRefreshButton = mViewRefreshButton
        ViewCounter = mViewCounter
        ViewMinimizeButton = mViewMinimizeButton
        ViewMaximizeButton = mViewMaximizeButton
        ViewCloseButton = mViewCloseButton
        ViewLogoutButton = mViewLogoutButton
        ViewLogedInName = mViewLogedInName

        TableLayoutPanel1.BackColor = MainColor
        TableLayoutPanel1.ForeColor = MainColorTextLight
        lblHeaderText.BackColor = MainColor
        lblHeaderText.ForeColor = MainColorTextLight
        changeLoginLogout()
        LblUserFullName.Text = FullNameLogedIn
        Panel2.BackColor = maincolor2
        lblHeaderText.Text = mycaption

        lblLeft1Setting.Visible = ViewSettingButton
        lblLeft2Ref.Visible = ViewRefreshButton
        lblLeft3Timer.Visible = ViewCounter
        lblMinimize.Visible = ViewMinimizeButton
        lblWindowsState.Visible = ViewMaximizeButton
        lblClose.Visible = ViewCloseButton
        lblLogINLogOUT.Visible = ViewLogoutButton
        LblUserFullName.Visible = ViewLogedInName
        Using aMainor As New LqHRDataContext(cnx)
            Dim user = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.Username).ToList(0)
            LblUserFullName.Text = user
        End Using


        garbagethred = New System.Threading.Thread(AddressOf ThreadRunning)
        garbagethred.IsBackground = True
        garbagethred.Start()
        Fwidth = 1000
        fHeight = 800

        MyMaximize()
    End Sub
    Public Sub changeLoginLogout()
        If UserIDLogedIN = 0 Then
            lblLogINLogOUT.Text = "Login"
        Else
            lblLogINLogOUT.Text = "Logout"
        End If
    End Sub
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Using aMainor As New LqHRDataContext(cnx)
            If Not MyEmployeeId = 0 Then
                Dim res = (From ax In aMainor.TblUsers Where ax.EmployeeId = MyEmployeeId).ToList(0)
                res.LastSeen = Date.Now
                res.ComputerName = System.Windows.Forms.SystemInformation.ComputerName
                aMainor.SubmitChanges()
            End If
        End Using
        f.Close()
    End Sub

    Private Sub lbl_MouseEnter_1(sender As Object, e As EventArgs) Handles lblWindowsState.MouseEnter
        sender.BackColor = MainColorLight
        ToolTip1.Show("Maximize", lblWindowsState)

    End Sub

    Private Sub lbl_MouseLeave_1(sender As Object, e As EventArgs) Handles lblWindowsState.MouseLeave, lblMinimize.MouseLeave, lblLeft1Setting.MouseLeave
        sender.BackColor = Nothing
        sender.ForeColor = Nothing
        ToolTip1.Hide(sender)
    End Sub

    Private Sub lblMinimize_MouseEnter_2(sender As Object, e As EventArgs) Handles lblMinimize.MouseEnter
        sender.BackColor = MainColorLight
        ToolTip1.Show("Minimize", lblMinimize)
    End Sub

    Private Sub lblsetting_MouseEnter_2(sender As Object, e As EventArgs) Handles lblLeft1Setting.MouseEnter
        sender.BackColor = Color.Yellow
        sender.ForeColor = MainColor

        ToolTip1.Show("Setting", lblLeft1Setting)
    End Sub

    Private Sub lblLeft2Ref_MouseEnter_1(sender As Object, e As EventArgs) Handles lblLeft2Ref.MouseEnter
        sender.BackColor = Color.Green
        ToolTip1.Show("Refresh", lblLeft2Ref)
    End Sub

    Private Sub lblLeft2Ref_MouseLeave_1(sender As Object, e As EventArgs) Handles lblLeft2Ref.MouseLeave
        sender.BackColor = Nothing
        ToolTip1.Hide(sender)
    End Sub
    Private Sub lblnavi_MouseEnter_1(sender As Object, e As EventArgs) Handles lblLogINLogOUT.MouseEnter
        sender.BackColor = MaincolorDark
    End Sub

    Private Sub lblnavi_MouseLeave_1(sender As Object, e As EventArgs) Handles lblLogINLogOUT.MouseLeave
        sender.BackColor = Nothing
        ToolTip1.Hide(sender)
    End Sub

    Private Sub lblClose_MouseEnter_1(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        sender.BackColor = Color.Red
        ToolTip1.Show("Close", lblClose)
    End Sub

    Private Sub lblClose_MouseLeave_1(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        sender.BackColor = Nothing
        ToolTip1.Hide(sender)
    End Sub
    Private Sub lblWindowsState_Click(sender As Object, e As EventArgs) Handles lblWindowsState.Click
        'If f.WindowState = FormWindowState.Normal Then
        '    f.WindowState = FormWindowState.Maximized
        'Else
        '    f.WindowState = FormWindowState.Normal
        'End If
        If IsMaximized = False Then
            MyMaximize()
        Else
            MyNormal()
        End If
        ChangeWindowsState()
    End Sub
    Private Sub MyMaximize()
        Fwidth = f.Width
        fHeight = f.Height
        f.WindowState = FormWindowState.Normal
        f.Width = My.Computer.Screen.WorkingArea.Size.Width
        f.Height = My.Computer.Screen.WorkingArea.Size.Height '- 100
        f.Location = New Point(0, 0)
        IsMaximized = True
        ChangeWindowsState()
    End Sub
    Private Sub MyNormal()

        f.WindowState = FormWindowState.Normal
        f.Width = Fwidth
        f.Height = fHeight
        IsMaximized = False
        'If b = 1 Then
        '    Dim myX As Integer
        '    myX = MousePosition.X - (Me.Width / 2)
        '    If myX <= 0 Then
        '        myX = 0
        '    ElseIf myX > My.Computer.Screen.Bounds.Width + Me.Width Then
        '        myX = My.Computer.Screen.Bounds.Width - Me.Width
        '    End If
        '    f.Location = New Point(myX, MousePosition.Y)
        'Else
        cscreen = MyLocation
        f.Location = cscreen
        'End If


    End Sub
    Private Sub lblHeaderText_MouseDown(sender As Object, e As MouseEventArgs) Handles lblHeaderText.MouseDown
        FClick = New Point(e.X, e.Y)
        lastx = e.X
        '  If f.WindowState = FormWindowState.Normal Then
        Timer1.Enabled = True
        '  Else
        '   Timer1.Enabled = False
        '   End If
    End Sub

    Private Sub lblHeaderText_MouseUp(sender As Object, e As MouseEventArgs) Handles lblHeaderText.MouseUp
        ' If f.WindowState = FormWindowState.Normal Then
        Timer1.Enabled = False
        ' End If
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        f.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblLeft2Ref_Click(sender As Object, e As EventArgs) Handles lblLeft2Ref.Click
        RaiseEvent ClickBtnRefresh()
    End Sub

    Public Sub reftimer(ByVal vall As String)
        lblLeft3Timer.Text = vall
    End Sub

    Public Sub addTab(ByVal idTab As String, ByVal captionTab As String, ByVal tagtab As String)

        Dim newtabHeader As New UCHeaderButton
        newtabHeader.InitControl(tagtab, idTab, captionTab)
        AddHandler newtabHeader.Myclick, Sub(ByVal myindex As Integer)
                                             For Each x In Panel1.Controls
                                                 x.SelectedTab(myindex)
                                             Next

                                             For Each x In Panel2.Controls
                                                 x.SelectedTab(myindex)

                                             Next

                                         End Sub

        Panel1.Controls.Add(newtabHeader)

        Dim newTab As New UCRibon
        newTab.initRibon(idTab, tagtab)

        newTab.Dock = DockStyle.Fill
        Panel2.Controls.Add(newTab)
    End Sub

    Public Sub addPanel(ByVal idTab As Integer, ByVal idpanel As Integer, ByVal captionRibon As String, ByVal mytag As String)

        For Each x In Panel2.Controls
            If x.MyIndex = idTab Then

                Dim newpanel As New UCPanelOfRibon
                newpanel.initpanel(idpanel, captionRibon, mytag, maincolor2, MainColor)
                newpanel.Width = 0
                x.addPanel(newpanel)
                x.FlowLayoutPanel1.Width = x.FlowLayoutPanel1.Width
            End If
        Next


    End Sub
    Public Sub addbtn(ByVal idpanel As Integer, ByVal idBtn As Integer, ByVal captionbtn As String, ByVal mytag As String, ByVal myimage As Image, ByVal NameActionToRun As String)

        For Each x In Panel2.Controls
            For Each p In x.FlowLayoutPanel1.controls

                If p.MyIndex = idpanel Then

                    Dim newbtn As New UCButton
                    newbtn.initBtn(idBtn, captionbtn, mytag, myimage, maincolor2, maincolor2dark, maincolor2light, MainColor, NameActionToRun)
                    p.addbtn(newbtn)

                    p.tag = p.tag + 1

                    If p.tag = 4 Then
                        p.Width = p.width + newbtn.Width - 2
                        p.tag = 0
                    Else
                        p.Width = p.width + newbtn.Width + 1
                    End If

                    x.FlowLayoutPanel1.Width = x.FlowLayoutPanel1.Width + newbtn.Width + 1

                End If

            Next
        Next

    End Sub

    Private Sub lblLeft1Setting_Click(sender As Object, e As EventArgs) Handles lblLeft1Setting.Click
        Dim x As New FrmPCSettings
        x.ShowDialog()
    End Sub

    Public Sub isLoaded(ByVal SelectedTabIndex As Integer)
        For Each x In Panel1.Controls
            x.SelectedTab(SelectedTabIndex)
        Next
        For Each x In Panel2.Controls
            x.SelectedTab(SelectedTabIndex)

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'If MousePosition <> FClick Then
        '    If IsMaximized = True Then
        '        '  f.Location = New Point(MousePosition.X - FClick.X - 123, MousePosition.Y - FClick.Y)
        '        MyNormal(1)
        '        ChangeWindowsState()
        '        '   FClick.X = f.Location.X
        '    Else

        If IsMaximized = False Then
            'Dim mspx As Integer = MousePosition.X
            'f.Location = New Point(f.Location.X - (lastx - mspx), MousePosition.Y - FClick.Y)
            'lastx = mspx
            ''End If
            '

            f.Location = New Point(MousePosition.X - FClick.X - 123, MousePosition.Y - FClick.Y)
            cscreen = f.Location
            MyLocation = cscreen
        End If


    End Sub

    Private Sub lblHeaderText_DoubleClick(sender As Object, e As EventArgs) Handles lblHeaderText.DoubleClick

        'If f.WindowState = FormWindowState.Normal Then
        '    f.WindowState = FormWindowState.Maximized
        '    f.Location = New Point(0, 0)
        'Else
        '    f.WindowState = FormWindowState.Normal
        'End If

        If IsMaximized = False Then
            MyMaximize()
        Else
            MyNormal()
        End If

    End Sub


End Class
