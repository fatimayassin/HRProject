Public Class UserNote
    Private Sub BtAdd_Click(sender As Object, e As EventArgs)
        ShowForm(New FrmNotes)
    End Sub

    Private Sub ShowForm(WhichForm As Form)
        With WhichForm
            .Show()
            .BringToFront()
        End With
    End Sub

End Class
