Public Class UcTasks

    Public Event UC_BtToDoList()
    Public Event UC_BtTasks()

    Private Sub BtToDoList_Click(sender As Object, e As EventArgs) Handles BtToDoList.Click
        RaiseEvent UC_BtToDoList()
    End Sub

    Private Sub BtTasks_Click(sender As Object, e As EventArgs) Handles BtTasks.Click
        RaiseEvent UC_BtTasks()
    End Sub

    Private Sub UcTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtToDoList.BackColor = My.Settings.PanelColor
        BtTasks.BackColor = My.Settings.PanelColor
    End Sub


End Class
