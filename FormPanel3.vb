Public Class FormPanel3
    Dim PW As Integer
    Dim Hided As Boolean

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelNav.BackColor = My.Settings.PanelColor
        PanelNavRight.BackColor = My.Settings.PanelColor
        PanelNavBtm.BackColor = My.Settings.PanelColor
        PanelMyMail.BackColor = My.Settings.PanelColor
        PanelMyFolders.BackColor = My.Settings.PanelColor
        PanelMyNotes.BackColor = My.Settings.PanelColor
        PanelMyTasks.BackColor = My.Settings.PanelColor
        PanelMyCalendar.BackColor = My.Settings.PanelColor
        PanelMyMailTitle.BackColor = My.Settings.PanelColor
        PanelMyMailButtons.BackColor = My.Settings.PanelColor
        SplitContainer1.BackColor = My.Settings.FormBackgroundColor

        BtHideNavPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtExpandNavPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtMailPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCalendarPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtTasksPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtNotesPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtFoldersPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtOpenMailPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCloseMailPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtComposeMail.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtInbox.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtSent.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtOpenCalendarPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCloseCalendarPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCalendar.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtOpenTasksPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCloseTasksPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtToDoList.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtTasks.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtOpenNotesPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCloseNotesPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtNotes.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor

        BtOpenFoldersPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCloseFoldersPanel.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtMailInboxFolder.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtCalendarFolder.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtNotesFolder.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor
        BtToDoFolder.FlatAppearance.MouseOverBackColor = My.Settings.FormBackgroundColor


        BtExpandNavPanel.Visible = False
        BtHideNavPanel.Visible = True
        BtPinPanel.Visible = False

        PW = PanelNav.Width
        Hided = False

        If My.Settings.IsOpenMailPanel = False Then
            BtCloseMailPanel.Visible = False
            PanelMyMailButtons.Visible = False
        Else
            BtOpenMailPanel.Visible = False
        End If

        If My.Settings.IsOpenCalendarPanel = False Then
            BtCloseCalendarPanel.Visible = False
            PaneMyCalendarButtons.Visible = False
        End If

        If My.Settings.IsOpenTasksPanel = False Then
            BtCloseTasksPanel.Visible = False
            PanelMyTasksButtons.Visible = False
        End If

        If My.Settings.IsOpenNotesPanel = False Then
            BtCloseNotesPanel.Visible = False
            PanelMyNotesButtons.Visible = False
        End If

        If My.Settings.IsOpenFoldersPanel = False Then
            BtCloseFoldersPanel.Visible = False
            PanelMyFoldersButtons.Visible = False
        End If

        PanelMyCalendar.Visible = False
        PanelMyTasks.Visible = False
        PanelMyNotes.Visible = False
        PanelMyFolders.Visible = False

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Hided Then
            BtExpandNavPanel.Visible = False
            BtHideNavPanel.Visible = True
            BtPinPanel.Visible = False
            PanelNav.Dock = DockStyle.Fill
            PanelNavRight.Dock = DockStyle.Right
            PanelNav.Width = PanelNav.Width + 20
            SplitContainer1.SplitterDistance = 266
            If PanelNav.Width >= PW Then
                Timer1.Stop()
                Hided = False
                Me.Refresh()
            End If
        Else
            BtHideNavPanel.Visible = False
            BtExpandNavPanel.Visible = True
            BtPinPanel.Visible = False
            PanelNav.Dock = DockStyle.None
            PanelNavRight.Dock = DockStyle.Left
            PanelNav.Width = PanelNav.Width - 20

            If PanelNav.Width <= 0 Then
                SplitContainer1.SplitterDistance = 51
                Timer1.Stop()
                Hided = True
                Me.Refresh()
            End If
        End If
    End Sub



    Private Sub BtHideNavPanel_Click(sender As Object, e As EventArgs) Handles BtHideNavPanel.Click

        Timer1.Start()

        PanelNavRight.Controls.Add(BtMailPanel)
        PanelNavRight.Controls.Add(BtCalendarPanel)
        PanelNavRight.Controls.Add(BtTasksPanel)
        PanelNavRight.Controls.Add(BtNotesPanel)
        PanelNavRight.Controls.Add(BtFoldersPanel)
        BtMailPanel.Dock = DockStyle.Bottom
        BtCalendarPanel.Dock = DockStyle.Bottom
        BtTasksPanel.Dock = DockStyle.Bottom
        BtNotesPanel.Dock = DockStyle.Bottom
        BtFoldersPanel.Dock = DockStyle.Bottom
    End Sub

    Private Sub BtExpandNavPanel_Click(sender As Object, e As EventArgs) Handles BtExpandNavPanel.Click

        BtExpandNavPanel.Visible = False
        BtHideNavPanel.Visible = False
        BtPinPanel.Visible = True

        SplitContainer1.SplitterDistance = 0
        SplitContainer1.Panel1MinSize = 0
        SplitContainer1.Panel2MinSize = 0
        SplitContainer1.Panel1.Location = New Point(0, 0)
        SplitContainer1.Dock = DockStyle.Fill
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelNav)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelNavRight)
        PanelNav.Width = PanelNav.Width + 215
        'PanelNav.Location = New Point(0, 0)
        PanelNav.Dock = DockStyle.Left
        PanelNavRight.Dock = DockStyle.Left
        PanelNavRight.BringToFront()


        PanelNavBtm.Controls.Add(BtMailPanel)
        PanelNavBtm.Controls.Add(BtCalendarPanel)
        PanelNavBtm.Controls.Add(BtTasksPanel)
        PanelNavBtm.Controls.Add(BtNotesPanel)
        PanelNavBtm.Controls.Add(BtFoldersPanel)

        BtMailPanel.Dock = DockStyle.Left
        BtMailPanel.BringToFront()
        BtCalendarPanel.Dock = DockStyle.Left
        BtCalendarPanel.BringToFront()
        BtTasksPanel.Dock = DockStyle.Left
        BtTasksPanel.BringToFront()
        BtNotesPanel.Dock = DockStyle.Left
        BtNotesPanel.BringToFront()
        BtFoldersPanel.Dock = DockStyle.Left
        BtFoldersPanel.BringToFront()
    End Sub

    Private Sub BtPinPanel_Click(sender As Object, e As EventArgs) Handles BtPinPanel.Click


        Timer1.Start()

        BtExpandNavPanel.Visible = False
        BtHideNavPanel.Visible = True
        BtPinPanel.Visible = False

        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelNav)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelNavRight)
        PanelNav.Dock = DockStyle.Left
        PanelNav.Width = PanelNav.Width + 215
        PanelNavRight.Dock = DockStyle.Left
        PanelNavRight.BringToFront()

        PanelNavBtm.Controls.Add(BtMailPanel)
        PanelNavBtm.Controls.Add(BtCalendarPanel)
        PanelNavBtm.Controls.Add(BtTasksPanel)
        PanelNavBtm.Controls.Add(BtNotesPanel)
        PanelNavBtm.Controls.Add(BtFoldersPanel)

        BtMailPanel.Dock = DockStyle.Left
        BtMailPanel.BringToFront()
        BtCalendarPanel.Dock = DockStyle.Left
        BtCalendarPanel.BringToFront()
        BtTasksPanel.Dock = DockStyle.Left
        BtTasksPanel.BringToFront()
        BtNotesPanel.Dock = DockStyle.Left
        BtNotesPanel.BringToFront()
        BtFoldersPanel.Dock = DockStyle.Left
        BtFoldersPanel.BringToFront()
    End Sub

    Private Sub BtMailPanel_Click(sender As Object, e As EventArgs) Handles BtMailPanel.Click
        If My.Settings.IsOpenMailPanel = True Then
            BtOpenMailPanel.Visible = False
            BtCloseMailPanel.Visible = True
        End If

        PanelMyMail.Visible = True
        PanelMyCalendar.Visible = False
        PanelMyTasks.Visible = False
        PanelMyNotes.Visible = False
        PanelMyFolders.Visible = False
    End Sub

    Private Sub BtCalendarPanel_Click(sender As Object, e As EventArgs) Handles BtCalendarPanel.Click
        If My.Settings.IsOpenCalendarPanel = True Then
            BtOpenCalendarPanel.Visible = False
            BtCloseCalendarPanel.Visible = True
        End If

        PanelMyCalendar.Visible = True
        PanelMyMail.Visible = False
        PanelMyTasks.Visible = False
        PanelMyNotes.Visible = False
        PanelMyFolders.Visible = False
    End Sub

    Private Sub BtTasksPanel_Click(sender As Object, e As EventArgs) Handles BtTasksPanel.Click
        If My.Settings.IsOpenTasksPanel = True Then
            BtOpenTasksPanel.Visible = False
            BtCloseTasksPanel.Visible = True
        End If

        PanelMyTasks.Visible = True
        PanelMyMail.Visible = False
        PanelMyCalendar.Visible = False
        PanelMyNotes.Visible = False
        PanelMyFolders.Visible = False
    End Sub

    Private Sub BtNotesPanel_Click(sender As Object, e As EventArgs) Handles BtNotesPanel.Click

        If My.Settings.IsOpenNotesPanel = True Then
            BtOpenNotesPanel.Visible = False
            BtCloseNotesPanel.Visible = True
        End If

        PanelMyNotes.Visible = True
        PanelMyMail.Visible = False
        PanelMyCalendar.Visible = False
        PanelMyTasks.Visible = False
        PanelMyFolders.Visible = False
    End Sub

    Private Sub BtFoldersPanel_Click(sender As Object, e As EventArgs) Handles BtFoldersPanel.Click
        If My.Settings.IsOpenFoldersPanel = True Then
            BtOpenFoldersPanel.Visible = False
            BtCloseFoldersPanel.Visible = True
        End If

        PanelMyFolders.Visible = True
        PanelMyMail.Visible = False
        PanelMyCalendar.Visible = False
        PanelMyTasks.Visible = False
        PanelMyNotes.Visible = False
    End Sub

    Private Sub BtOpenMailPanel_Click(sender As Object, e As EventArgs) Handles BtOpenMailPanel.Click
        My.Settings.IsOpenMailPanel = True
        BtOpenMailPanel.Visible = False
        BtCloseMailPanel.Visible = True
        PanelMyMailButtons.Visible = True
    End Sub

    Private Sub BtCloseMailPanel_Click(sender As Object, e As EventArgs) Handles BtCloseMailPanel.Click
        My.Settings.IsOpenMailPanel = False
        BtOpenMailPanel.Visible = True
        BtCloseMailPanel.Visible = False
        PanelMyMailButtons.Visible = False
    End Sub

    Private Sub BtOpenCalendarPanel_Click(sender As Object, e As EventArgs) Handles BtOpenCalendarPanel.Click
        My.Settings.IsOpenCalendarPanel = True
        BtOpenCalendarPanel.Visible = False
        BtCloseCalendarPanel.Visible = True
        PaneMyCalendarButtons.Visible = True
    End Sub

    Private Sub BtCloseCalendarPanel_Click(sender As Object, e As EventArgs) Handles BtCloseCalendarPanel.Click
        My.Settings.IsOpenCalendarPanel = False
        BtOpenCalendarPanel.Visible = True
        BtCloseCalendarPanel.Visible = False
        PaneMyCalendarButtons.Visible = False
    End Sub

    Private Sub BtOpenTasksPanel_Click(sender As Object, e As EventArgs) Handles BtOpenTasksPanel.Click
        My.Settings.IsOpenTasksPanel = True
        BtOpenTasksPanel.Visible = False
        BtCloseTasksPanel.Visible = True
        PanelMyTasksButtons.Visible = True
    End Sub

    Private Sub BtCloseTasksPanel_Click(sender As Object, e As EventArgs) Handles BtCloseTasksPanel.Click
        My.Settings.IsOpenTasksPanel = False
        BtOpenTasksPanel.Visible = True
        BtCloseTasksPanel.Visible = False
        PanelMyTasksButtons.Visible = False
    End Sub


    Private Sub BtOpenNotesPanel_Click(sender As Object, e As EventArgs) Handles BtOpenNotesPanel.Click
        My.Settings.IsOpenNotesPanel = True
        BtOpenNotesPanel.Visible = False
        BtCloseNotesPanel.Visible = True
        PanelMyNotesButtons.Visible = True
    End Sub

    Private Sub BtCloseNotesPanel_Click(sender As Object, e As EventArgs) Handles BtCloseNotesPanel.Click
        My.Settings.IsOpenNotesPanel = False
        BtOpenNotesPanel.Visible = True
        BtCloseNotesPanel.Visible = False
        PanelMyNotesButtons.Visible = False
    End Sub


    Private Sub BtOpenFoldersPanel_Click(sender As Object, e As EventArgs) Handles BtOpenFoldersPanel.Click
        My.Settings.IsOpenFoldersPanel = True
        BtOpenFoldersPanel.Visible = False
        BtCloseFoldersPanel.Visible = True
        PanelMyFoldersButtons.Visible = True
    End Sub

    Private Sub BtCloseFoldersPanel_Click(sender As Object, e As EventArgs) Handles BtCloseFoldersPanel.Click
        My.Settings.IsOpenFoldersPanel = False
        BtOpenFoldersPanel.Visible = True
        BtCloseFoldersPanel.Visible = False
        PanelMyFoldersButtons.Visible = False
    End Sub

    Private Sub BtToDoFolder_Click(sender As Object, e As EventArgs) Handles BtToDoFolder.Click
        'FrmNewTasksV2.TopLevel = False
        'Me.Splitter1.Controls.Add(FrmNewTasksV2)
        PublicContainerPanel2 = Me.SplitContainer2.Panel1
        MyOpenForm2(FrmNewTasksV2)
    End Sub

    Private Sub BtComposeMail_Click(sender As Object, e As EventArgs) Handles BtComposeMail.Click
        ' PublicContainerPanel2 = Me.SplitContainer2.Panel1
        ' MyOpenForm2(FrmNewMail)
    End Sub

    Private Sub BtInbox_Click(sender As Object, e As EventArgs) Handles BtInbox.Click
        ' PublicContainerPanel2 = Me.SplitContainer2.Panel1
        ' MyOpenForm2(FrmMailInbox2)
    End Sub

    Private Sub BtSignInAccount_Click(sender As Object, e As EventArgs) Handles BtSignInAccount.Click
        'PublicContainerPanel2 = Me.SplitContainer2.Panel1
        'MyOpenForm2(FrmMailSignIn)
    End Sub

    Private Sub BtSent_Click(sender As Object, e As EventArgs) Handles BtSent.Click
        ' PublicContainerPanel2 = Me.SplitContainer2.Panel1
        ' MyOpenForm2(FrmSentMail)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'PublicContainerPanel2 = Me.SplitContainer2.Panel1
        'MyOpenForm2(FrmNewTasksV2)
    End Sub
End Class