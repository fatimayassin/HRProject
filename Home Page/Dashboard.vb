Public Class Dashboard
    Private Sub BtMailPanel_Click(sender As Object, e As EventArgs) Handles BtMailPanel.Click
        RadPanelMail.Visible = True
        RadPanelCalendar.Visible = False
        RadPanelTasks.Visible = False
        RadPanelNotes.Visible = False
        RadPanelMail.Dock = DockStyle.Fill
    End Sub

    Private Sub BtCalendarPanel_Click(sender As Object, e As EventArgs) Handles BtCalendarPanel.Click
        RadPanelMail.Visible = False
        RadPanelCalendar.Visible = True
        RadPanelTasks.Visible = False
        RadPanelNotes.Visible = False
        RadPanelCalendar.Dock = DockStyle.Fill
    End Sub

    Private Sub BtTasksPanel_Click(sender As Object, e As EventArgs) Handles BtTasksPanel.Click
        RadPanelMail.Visible = False
        RadPanelCalendar.Visible = False
        RadPanelTasks.Visible = True
        RadPanelNotes.Visible = False
        RadPanelTasks.Dock = DockStyle.Fill
    End Sub

    Private Sub BtNotesPanel_Click(sender As Object, e As EventArgs) Handles BtNotesPanel.Click
        RadPanelMail.Visible = False
        RadPanelCalendar.Visible = False
        RadPanelTasks.Visible = False
        RadPanelNotes.Visible = True
        RadPanelNotes.Dock = DockStyle.Fill
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadPanelMail.Dock = DockStyle.Fill

        'RadPanelMail.BackColor = My.Settings.PanelColor
        'RadPanelCalendar.BackColor = My.Settings.PanelColor
        'RadPanelTasks.BackColor = My.Settings.PanelColor
        'RadPanelNotes.BackColor = My.Settings.PanelColor

        BtMailPanel.BackColor = My.Settings.PanelColor
        BtCalendarPanel.BackColor = My.Settings.PanelColor
        BtTasksPanel.BackColor = My.Settings.PanelColor
        BtNotesPanel.BackColor = My.Settings.PanelColor

        'BtCalendar.BackColor = My.Settings.PanelColor
        'BtNotes.BackColor = My.Settings.PanelColor
        'Button1.BackColor = My.Settings.PanelColor
        'Button2.BackColor = My.Settings.PanelColor
        'Button3.BackColor = My.Settings.PanelColor
        'Button4.BackColor = My.Settings.PanelColor
        'Button5.BackColor = My.Settings.PanelColor
        'Button6.BackColor = My.Settings.PanelColor
    End Sub

End Class
