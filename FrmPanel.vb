Public Class FrmPanel
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor

        Dim ucClock As New UCInterfaceClock()
        PanelRightBottom.Controls.Add(ucClock)
        ucClock.Location = New Point(0, 0)

        PublicContainerPanel = Me.PanelRightTop
        MyOpenForm(New FrmStickyNote)

        'PublicContainerPanel = Me.PanelCenterTasks
        'MyOpenForm(New FrmNewTasks)

        'PublicContainerPanel = Me.PanelLeftTop
        'MyOpenForm(New FrmCalendarEvents)



        PublicContainerPanel = Me.PanelCenterTasks
        MyOpenForm(New FrmNewTasksV2)

        PublicContainerPanel = Me.PanelLeftBottom
        MyOpenForm(New FrmNotifications)


        PublicContainerPanel = Me.PanelLeftTop
        MyOpenForm(New FrmCalendar)
    End Sub


End Class