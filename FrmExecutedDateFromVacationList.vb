Public Class FrmExecutedDateFromVacationList
    Public vacationId As Integer = 0

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FrmExecutedDateFromVacationList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext(cnx)
            TblExecuteDateFromVacationBindingSource.DataSource = (From ax In aMainor.TblExecuteDateFromVacations Where ax.VacationId = vacationId).tolist

        End Using
    End Sub
End Class