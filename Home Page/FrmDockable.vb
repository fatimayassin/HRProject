
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDock

Public Class FrmDockable

    Public Sub New()
        InitializeComponent()

        'Dim dockManager As UltraDockManager = New UltraDockManager()
        UltraDockManager1.HostControl = Me
        UltraDockManager1.ShowCloseButton = False
        UltraDockManager1.ShowPinButton = True
        UltraDockManager1.ShowMenuButton = Infragistics.Win.DefaultableBoolean.True
        '  UltraDockManager1.CaptionStyle = CaptionStyle.Office2007
        UltraDockManager1.WindowStyle = WindowStyle.Office2003

        UltraDockManager1.DefaultPaneSettings.ActiveTabAppearance.BackColor = My.Settings.PanelColor
        UltraDockManager1.DefaultPaneSettings.ActiveTabAppearance.BackColor2 = My.Settings.PanelColor
        UltraDockManager1.DefaultPaneSettings.ActiveCaptionAppearance.BackColor = My.Settings.PanelColor
        UltraDockManager1.DefaultPaneSettings.ActiveCaptionAppearance.BackColor2 = My.Settings.PanelColor

        ' Dim myUC As New Dashboard()
        ' myUC.Dock = DockStyle.Fill
        ' UltraDockManager1.DockAreas.Add(New DockAreaPane(DockedLocation.DockedLeft))
        ' UltraDockManager1.DockControls(New Control() {myUC}, DockedLocation.DockedLeft, ChildPaneStyle.HorizontalSplit)

        ' Create a "Dockable Group Pane".
        Dim dockGroupPane = New DockableGroupPane()


        ' Create a "Dockable Area Pane" and add in the group.
        Dim dockAreaPane = New DockAreaPane(DockedLocation.DockedLeft)

        ' Set the display style for the panes in a group.
        dockGroupPane.ChildPaneStyle = ChildPaneStyle.TabGroup


        ' Create a "Dockable Control Pane" tab with UltraTree.
        Dim dockControlMail = New DockableControlPane() With {
            .MinimumSize = New Size(201, 0)
        }

        Dim dockControlCalendar = New DockableControlPane() With {
            .MinimumSize = New Size(201, 0)
        }

        Dim dockControlTasks = New DockableControlPane() With {
            .MinimumSize = New Size(201, 0)
        }

        Dim dockControlNotes = New DockableControlPane() With {
            .MinimumSize = New Size(201, 0)
        }

        dockControlMail.Settings.Appearance.Image = My.Resources.mail_24
        dockControlCalendar.Settings.Appearance.Image = My.Resources.calendar_24
        dockControlTasks.Settings.Appearance.Image = My.Resources.task_24
        dockControlNotes.Settings.Appearance.Image = My.Resources.note_24

        dockControlMail.Settings.ActiveTabAppearance.BackColor = My.Settings.PanelColor
        dockControlMail.Settings.ActiveTabAppearance.BackColor2 = My.Settings.PanelColor
        dockControlMail.Settings.ActiveCaptionAppearance.BackColor = My.Settings.PanelColor
        dockControlMail.Settings.ActiveCaptionAppearance.BackColor2 = My.Settings.PanelColor

        dockControlCalendar.Settings.ActiveTabAppearance.BackColor = My.Settings.PanelColor
        dockControlCalendar.Settings.ActiveTabAppearance.BackColor2 = My.Settings.PanelColor
        dockControlCalendar.Settings.ActiveCaptionAppearance.BackColor = My.Settings.PanelColor
        dockControlCalendar.Settings.ActiveCaptionAppearance.BackColor2 = My.Settings.PanelColor

        dockControlTasks.Settings.ActiveTabAppearance.BackColor = My.Settings.PanelColor
        dockControlTasks.Settings.ActiveTabAppearance.BackColor2 = My.Settings.PanelColor
        dockControlTasks.Settings.ActiveCaptionAppearance.BackColor = My.Settings.PanelColor
        dockControlTasks.Settings.ActiveCaptionAppearance.BackColor2 = My.Settings.PanelColor

        dockControlNotes.Settings.ActiveTabAppearance.BackColor = My.Settings.PanelColor
        dockControlNotes.Settings.ActiveTabAppearance.BackColor2 = My.Settings.PanelColor
        dockControlNotes.Settings.ActiveCaptionAppearance.BackColor = My.Settings.PanelColor
        dockControlNotes.Settings.ActiveCaptionAppearance.BackColor2 = My.Settings.PanelColor


        Dim UcMail As New UcMail()
        UcMail.Dock = DockStyle.Fill
        AddHandler UcMail.UC_BtSignInAccount, AddressOf BtSignInAccount_Click
        AddHandler UcMail.UC_BtComposeMail, AddressOf BtComposeMail_Click
        AddHandler UcMail.UC_BtnMails, AddressOf BtnMails_Click

        Dim UcCalendar As New UcCalendar()
        UcCalendar.Dock = DockStyle.Fill
        AddHandler UcCalendar.UC_BtCalendar, AddressOf BtCalendar_Click

        Dim UcTasks As New UcTasks()
        UcTasks.Dock = DockStyle.Fill
        AddHandler UcTasks.UC_BtTasks, AddressOf BtTasks_Click
        AddHandler UcTasks.UC_BtToDoList, AddressOf BtToDoList_Click

        Dim UcNotes As New UcNotes()
        UcNotes.Dock = DockStyle.Fill
        AddHandler UcNotes.UC_BtNotes, AddressOf BtNotes_Click

        ' Add the controls to the Dockable Control Panes respectively
        dockControlMail.Control = UcMail
        dockControlCalendar.Control = UcCalendar
        dockControlTasks.Control = UcTasks
        dockControlNotes.Control = UcNotes

        ' Add the DockableControlPanes to the DockableGroupPane
        dockGroupPane.Panes.Add(dockControlMail)
        dockGroupPane.Panes.Add(dockControlCalendar)
        dockGroupPane.Panes.Add(dockControlTasks)
        dockGroupPane.Panes.Add(dockControlNotes)

        ' Add the DockableGroupPane to the DockAreaPane
        dockAreaPane.Panes.Add(dockGroupPane)

        ' Add the newly created DockAreaPane to the UltraDockManager's DockAreas collection
        UltraDockManager1.DockAreas.Add(dockAreaPane)
        UltraDockManager1.ImageSizeTab = New Size(30, 30)
        UltraDockManager1.UnpinnedTabStyle = UltraWinTabs.TabStyle.VisualStudio

        ' Set the size when docked. By default this is too small.
        UltraDockManager1.PaneFromControl(UcMail).DockAreaPane.Size = New Size(201, 0)
        UltraDockManager1.PaneFromControl(UcCalendar).DockAreaPane.Size = New Size(201, 0)
        UltraDockManager1.PaneFromControl(UcTasks).DockAreaPane.Size = New Size(201, 0)
        UltraDockManager1.PaneFromControl(UcNotes).DockAreaPane.Size = New Size(201, 0)

        ' Show Preview Navigation Window (Ctrl + Tab).
        UltraDockManager1.NavigatorSettings.IsPreviewVisible = DefaultableBoolean.True

    End Sub

    Private Sub BtSignInAccount_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmSignInAccount)
        'Dim frm = New FrmSignInAccount
        'frm.Show()
    End Sub

    Private Sub BtComposeMail_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmComposeMail)
        'Dim frm = New FrmComposeMail
        'frm.Show()
    End Sub

    Private Sub BtnMails_Click()
        If FrmSignInAccount.tbhostname.Text = "Other" Then
            ' Dim x As FrmOtherMail = New FrmOtherMail()
            If FrmSignInAccount.attachemtnSaveDirectory.Text = Nothing Then
                MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
            Else
                PublicContainerPanel = Panel1
                MyOpenForm(FrmOtherMail)
                ' x.ShowDialog()
            End If
        Else
            ' Dim x As FrmMail = New FrmMail()
            If FrmSignInAccount.attachemtnSaveDirectory.Text = Nothing Then
                MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
            Else
                '   x.ShowDialog()
                PublicContainerPanel = Panel1
                MyOpenForm(FrmMail)
            End If
        End If
    End Sub

    Private Sub BtCalendar_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmCalendarOfEventsNAppointments)
    End Sub

    Private Sub BtToDoList_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmNewTasksV2)
    End Sub

    Private Sub BtTasks_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmNewTasksV2)
    End Sub

    Private Sub BtNotes_Click()
        PublicContainerPanel = Panel1
        MyOpenForm(FrmStickyNote)
    End Sub


End Class
