Public Class UCSkills
    Event Checked(ByVal sender As UCSkills)
    Public t As Integer = 0
    Event clicked(ByVal sender As UCSkills)
    Event TextChange(ByVal sender As UCSkills)

    Public Property level As Integer
        Set(value As Integer)
            t = value
        End Set
        Get
            Return t
        End Get
    End Property

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        RaiseEvent Checked(Me)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        RaiseEvent clicked(Me)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        RaiseEvent TextChange(Me)
    End Sub
End Class

