Public Class UcCalendar

    Public Event UC_BtCalendar()

    Private Sub BtCalendar_Click(sender As Object, e As EventArgs) Handles BtCalendar.Click
        RaiseEvent UC_BtCalendar()
    End Sub

    Private Sub UcCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtCalendar.BackColor = My.Settings.PanelColor
    End Sub
End Class
