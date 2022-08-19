Partial Public Class FrmInterface

    Private Sub FrmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uc As New UCInterfaceClock()
        uc.Location = New Point(490, 50)
        Panel1.Controls.Add(uc)
    End Sub
End Class