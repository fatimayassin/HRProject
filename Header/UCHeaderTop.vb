Public Class UCHeaderTop
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

        'TableLayoutPanel1.BackColor = MainColor
        'TableLayoutPanel1.ForeColor = MainColorTextLight
        lblHeaderText.BackColor = MainColor
        lblHeaderText.ForeColor = MainColorTextLight
        'changeLoginLogout()
        'LblUserFullName.Text = FullNameLogedIn
        'Panel2.BackColor = maincolor2
        lblHeaderText.Text = mycaption

        lblLeft1Setting.Visible = ViewSettingButton
        lblLeft2Ref.Visible = ViewRefreshButton
        lblLeft3Timer.Visible = ViewCounter
        lblMinimize.Visible = ViewMinimizeButton
        lblWindowsState.Visible = ViewMaximizeButton
        lblClose.Visible = ViewCloseButton
        'lblLogINLogOUT.Visible = ViewLogoutButton
        'LblUserFullName.Visible = ViewLogedInName
        ' Using aMainor As New LqHRDataContext(cnx)
        'Dim user = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.Username).ToList(0)
        'LblUserFullName.Text = user
        'End Using


        garbagethred = New System.Threading.Thread(AddressOf ThreadRunning)
        garbagethred.IsBackground = True
        garbagethred.Start()
        Fwidth = 1000
        fHeight = 800

        MyMaximize()
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

    Private Sub lblClose_MouseEnter_1(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        sender.BackColor = Color.Red
        ToolTip1.Show("Close", lblClose)
    End Sub

    Private Sub lblClose_MouseLeave_1(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        sender.BackColor = Nothing
        ToolTip1.Hide(sender)
    End Sub

    Private Sub lblWindowsState_Click(sender As Object, e As EventArgs) Handles lblWindowsState.Click
        If IsMaximized = False Then
            MyMaximize()
            ' TableLayoutPanel2.Location = New Point(0, 0)
        Else
            MyNormal()
            ' TableLayoutPanel2.Location = New Point(0, 0)
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

        cscreen = MyLocation
        f.Location = cscreen

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
        ' TableLayoutPanel2.Location = New Point(0, 0)
        'Dim f1 As New FrmLogin
        'f1.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblLeft2Ref_Click(sender As Object, e As EventArgs) Handles lblLeft2Ref.Click
        RaiseEvent ClickBtnRefresh()
    End Sub

    Public Sub reftimer(ByVal vall As String)
        lblLeft3Timer.Text = vall
    End Sub

    Private Sub lblLeft1Setting_Click(sender As Object, e As EventArgs) Handles lblLeft1Setting.Click
        Dim x As New FrmPCSettings
        x.ShowDialog()
    End Sub



    Private Sub lblHeaderText_DoubleClick(sender As Object, e As EventArgs) Handles lblHeaderText.DoubleClick
        If IsMaximized = False Then
            MyMaximize()
        Else
            MyNormal()
        End If

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

End Class
