Public Class UcNotes

    Public Event UC_BtNotes()

    Private Sub BtNotes_Click(sender As Object, e As EventArgs) Handles BtNotes.Click
        RaiseEvent UC_BtNotes()
    End Sub

    Private Sub UcNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtNotes.BackColor = My.Settings.PanelColor
    End Sub
End Class
