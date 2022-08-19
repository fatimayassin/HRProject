Public Class FrmExecutedDateFromVacation
    Public VacationId As Integer = 0
    Public ID As Integer = 0
    Public NumberOfdays As Integer = 0
    Public fromUc As Boolean = False
    Public saved As Boolean = False
    Public current As New TblExecuteDateFromVacation
    Public ExecuteDays As Integer = 0
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FrmExecutedDateFromVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fromUc Then
            TblExecuteDateFromVacationBindingSource.DataSource = current
        Else

            If ID = 0 Then
                TblExecuteDateFromVacationBindingSource.DataSource = New TblExecuteDateFromVacation
            Else
                Using aMainor As New LqHRDataContext(cnx)
                    TblExecuteDateFromVacationBindingSource.DataSource = (From ax In aMainor.TblExecuteDateFromVacations Where ax.Id = ID).ToList(0)

                End Using

            End If
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If fromUc Then
            ExecuteDays = Integer.Parse(NumberOfDaysTextBox.Text)
            TblExecuteDateFromVacationBindingSource.Current.vacationId = VacationId
            current = TblExecuteDateFromVacationBindingSource.Current
        Else
            If ID = 0 Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblExecuteDateFromVacationBindingSource.Current.vacationid = VacationId
                    aMainor.TblExecuteDateFromVacations.InsertOnSubmit(TblExecuteDateFromVacationBindingSource.Current)
                    aMainor.SubmitChanges()
                    Dim oldrow As TblVacation = (From ax In aMainor.TblVacations Where ax.Id = VacationId).ToList(0)
                    oldrow.ExecutedDays += Integer.Parse(NumberOfDaysTextBox.Text)
                    aMainor.SubmitChanges()
                End Using
            Else



            End If
        End If

        Me.Close()
        saved = True
    End Sub



    Private Sub NumberOfDaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDaysTextBox.TextChanged
        Dim t As Integer
        If Integer.TryParse(NumberOfDaysTextBox.Text, t) Then
            If Integer.Parse(NumberOfDaysTextBox.Text) > NumberOfdays Then
                MessageBox.Show("enter a valid number")
                NumberOfDaysTextBox.Text = ""
            End If
        End If

    End Sub
End Class