Public Class FrmExecuteDaysFromVacation
    Public EmployeeVacId As Integer = 0
    Public restNumberOfDays As Integer = 0
    Public saved As Boolean = False

    Public id As Integer = 0
    Private Sub FrmExecuteDaysFromVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            'If id = 0 Then
            TblExecuteVacationsDayBindingSource.DataSource = New TblExecuteVacationsDay

            'Else
            '    TblExecuteVacationsDayBindingSource.DataSource = (From ax In aMainor.TblExecuteVacationsDays Where ax.Id = id).ToList

            'End If

        End Using
    End Sub

    Private Sub NumberOfDaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDaysTextBox.TextChanged
        Dim t As Integer
        If Integer.TryParse(NumberOfDaysTextBox.Text, t) Then
            If Integer.Parse(NumberOfDaysTextBox.Text) > restNumberOfDays Then
                MessageBox.Show("enter a valid number")
                NumberOfDaysTextBox.Text = ""
            End If
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                TblExecuteVacationsDayBindingSource.Current.EmployeeVacationId = EmployeeVacId
                'If id = 0 Then
                aMainor.TblExecuteVacationsDays.InsertOnSubmit(TblExecuteVacationsDayBindingSource.Current)
                aMainor.SubmitChanges()
                Dim oldrow As TblEmployeeVacation = (From ax In aMainor.TblEmployeeVacations Where ax.Id = EmployeeVacId).ToList(0)
                oldrow.ExecutedDays += Integer.Parse(NumberOfDaysTextBox.Text)
                aMainor.SubmitChanges()
                restNumberOfDays = restNumberOfDays - Integer.Parse(NumberOfDaysTextBox.Text)
                'Else
                '    Dim oldrow = (From ax In aMainor.TblExecuteVacationsDays Where ax.Id = id).ToList(0)
                '    Dim newRow As TblExecuteVacationsDay = TblExecuteVacationsDayBindingSource.Current
                '    oldrow.Date = newRow.Date
                '    oldrow.NumberOfDays = newRow.NumberOfDays
                '    aMainor.SubmitChanges()


                'End If
            End If
            saved = True
            Me.Close()

        End Using
    End Sub
End Class