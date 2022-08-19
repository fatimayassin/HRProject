Public Class FrmVacations

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FrmVacations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        refreshform()

    End Sub

    Private Sub TblVacationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblVacationDataGridView.CellContentClick
        If e.ColumnIndex = AddVac.Index Then
            Dim VacationId As Integer = TblVacationBindingSource.Current.id
            Dim EmployeeId As Integer = TblVacationBindingSource.Current.employeeId
            Dim RemainingDays As Integer = TblVacationDataGridView.CurrentRow.Cells(Remaining.Index).Value
            If RemainingDays > 0 Then
                Dim x As New FrmExecutedDateFromVacation
                x.VacationId = VacationId

                x.NumberOfdays = RemainingDays
                x.ShowDialog()
                refreshform()
                x.Dispose()
            Else
                MessageBox.Show("No more Remaining Days")
            End If
          

        End If
        If e.ColumnIndex = Details.Index Then
            Dim VacationId As Integer = TblVacationBindingSource.Current.id
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.TblExecuteDateFromVacations Where ax.VacationId = VacationId).ToList
                If res.Count > 0 Then
                    Dim x As New FrmExecutedDateFromVacationList
                    x.vacationId = VacationId

                    x.ShowDialog()
                    x.Dispose()
                Else
                    MessageBox.Show("No details")
                End If
            End Using



        End If
    End Sub
    Sub refreshform()

        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList

            TblVacationTypeBindingSource.DataSource = aMainor.TblVacationTypes.ToList
            TblVacationBindingSource.DataSource = (From ax In aMainor.TblVacations).ToList ' And ax.ExecutedDays < ax.NumberOfDays

            For i As Integer = 0 To TblVacationBindingSource.Count - 1
                TblVacationDataGridView.Rows(i).Cells(Remaining.Index).Value = TblVacationDataGridView.Rows(i).Cells(NumberOfDays.Index).Value - TblVacationDataGridView.Rows(i).Cells(ExecutedDays.Index).Value
                If TblVacationDataGridView.Rows(i).Cells(Remaining.Index).Value = 0 Then
                    TblVacationDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Beige

                End If


            Next

        End Using
    End Sub

    Private Sub lblText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblText.Click

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim x As New FrmAddNewVacation
        x.showDialog()
        refreshform()
        x.Dispose()
    End Sub
End Class