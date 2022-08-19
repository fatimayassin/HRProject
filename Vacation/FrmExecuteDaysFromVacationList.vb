Public Class FrmExecuteDaysFromVacationList
    Public restNumberOfDays As Integer = 0
    Public EmployeeVacId As Integer = 0
    Public DateExecuted As Date

    Dim selectedDate As Date
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmExecuteDaysFromVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        refreshfrom()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If restNumberOfDays = 0 Then
            MessageBox.Show("invalid")
        Else
            TblExecuteVacationsDayBindingSource.AddNew()
            For i = 0 To TblExecuteVacationsDayBindingSource.Count - 1
                If TblExecuteVacationsDayBindingSource(i).id = 0 Then
                    TblExecuteVacationsDayDataGridView.Rows(i).ReadOnly = False
                Else
                    TblExecuteVacationsDayDataGridView.Rows(i).ReadOnly = True


                End If
            Next


        End If

    End Sub

    Private Sub TblExecuteVacationsDayDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblExecuteVacationsDayDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                Dim id As Integer = TblExecuteVacationsDayBindingSource.Current.employeeVacationId
                Dim NumberOfDays As Integer = TblExecuteVacationsDayBindingSource.Current.numberofdays
                Dim ExecutedDaysId As Integer = TblExecuteVacationsDayBindingSource.Current.id
                Using aMainor As New LqHRDataContext(cnx)
                    Dim oldrow As TblEmployeeVacation = (From ax In aMainor.TblEmployeeVacations Where ax.Id = EmployeeVacId).ToList(0)
                    oldrow.ExecutedDays -= NumberOfDays
                    aMainor.SubmitChanges()
                    Dim res = (From ax In aMainor.TblExecuteVacationsDays Where ax.Id = ExecutedDaysId).ToList(0)
                    aMainor.TblExecuteVacationsDays.DeleteOnSubmit(res)
                    aMainor.SubmitChanges()
                End Using


            End If
        End If
        refreshfrom()

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        MonthCalendar1.Visible = False
        If DateExecuted > selectedDate Then
            MessageBox.Show("Enter a valid date !")
        Else
            TblExecuteVacationsDayDataGridView.CurrentRow.Cells(DateCol.Index).Value = selectedDate
        End If


    End Sub

    Private Sub TblExecuteVacationsDayDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblExecuteVacationsDayDataGridView.CellEndEdit
        'If e.ColumnIndex = NbOfDays.Index Then


        '    If TblExecuteVacationsDayDataGridView.CurrentRow.Cells(NbOfDays.Index).Value > restNumberOfDays Then
        '        MessageBox.Show("enter a valid number")
        '        TblExecuteVacationsDayDataGridView.CurrentRow.Cells(NbOfDays.Index).Value = ""

        '    End If

        'End If
    End Sub

    Private Sub TblExecuteVacationsDayDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblExecuteVacationsDayDataGridView.CellDoubleClick
        If TblExecuteVacationsDayBindingSource.Count > 0 Then
            If e.ColumnIndex = DateCol.Index Then

                MonthCalendar1.Visible = True

            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                total()

                'For i = 0 To TblExecuteVacationsDayBindingSource.Count - 1
                '    If TblExecuteVacationsDayBindingSource(i).id = 0 Then
                '        TblExecuteVacationsDayBindingSource(i).EmployeeVacationId = EmployeeVacId
                '        aMainor.TblExecuteVacationsDays.InsertOnSubmit(TblExecuteVacationsDayBindingSource(i))
                '        aMainor.SubmitChanges()
                '        Dim oldrow As TblEmployeeVacation = (From ax In aMainor.TblEmployeeVacations Where ax.Id = EmployeeVacId).ToList(0)
                '        oldrow.ExecutedDays += TblExecuteVacationsDayDataGridView.Rows(i).Cells(NbOfDays.Index).Value
                '        aMainor.SubmitChanges()
                '        restNumberOfDays = restNumberOfDays - TblExecuteVacationsDayDataGridView.Rows(i).Cells(NbOfDays.Index).Value
                '    End If
                'Next






                'TblExecuteVacationsDayBindingSource.Current.EmployeeVacationId = EmployeeVacId
                'aMainor.TblExecuteVacationsDays.InsertOnSubmit(TblExecuteVacationsDayBindingSource.Current)
                'aMainor.SubmitChanges()
                'Dim oldrow As TblEmployeeVacation = (From ax In aMainor.TblEmployeeVacations Where ax.Id = EmployeeVacId).ToList(0)
                'oldrow.ExecutedDays += TblExecuteVacationsDayDataGridView.CurrentRow.Cells(NbOfDays.Index).Value
                'aMainor.SubmitChanges()
                'restNumberOfDays = restNumberOfDays - TblExecuteVacationsDayDataGridView.CurrentRow.Cells(NbOfDays.Index).Value

            End If


        End Using
        ' TblExecuteVacationsDayDataGridView.ReadOnly = True
        refreshfrom()

    End Sub

    Private Sub TblExecuteVacationsDayDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblExecuteVacationsDayDataGridView.DataError
        If e.ColumnIndex = NbOfDays.Index Then
            MessageBox.Show("enter a valid number")
            TblExecuteVacationsDayDataGridView.CurrentRow.Cells(NbOfDays.Index).Value = ""

        End If
    End Sub
    Sub refreshfrom()
        Using aMainor As New LqHRDataContext(cnx)
            TblExecuteVacationsDayBindingSource.DataSource = (From ax In aMainor.TblExecuteVacationsDays Where ax.EmployeeVacationId = EmployeeVacId).ToList
            'TblExecuteVacationsDayDataGridView.ReadOnly = True
            For i = 0 To TblExecuteVacationsDayBindingSource.Count - 1
                If TblExecuteVacationsDayBindingSource(i).id = 0 Then
                    TblExecuteVacationsDayDataGridView.Rows(i).ReadOnly = False
                Else
                    TblExecuteVacationsDayDataGridView.Rows(i).ReadOnly = True


                End If
            Next
        End Using
        Label1.Text = "Remained Nb of Days : " + restNumberOfDays.ToString

    End Sub

  
    Private Sub FrmExecuteDaysFromVacationList_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
        TblExecuteVacationsDayDataGridView.Enabled = True

    End Sub
    Sub total()
        Dim NbOfdaysss As Integer = 0

        For i As Integer = 0 To TblExecuteVacationsDayBindingSource.Count - 1
            If TblExecuteVacationsDayBindingSource(i).id = 0 Then
                NbOfdaysss += TblExecuteVacationsDayBindingSource(i).numberofdays
            End If

        Next
        If NbOfdaysss > restNumberOfDays Then
            MessageBox.Show("Please Enter A Valid Number Of Days")
        Else
            Using aMainor As New LqHRDataContext(cnx)


                For i = 0 To TblExecuteVacationsDayBindingSource.Count - 1
                    If TblExecuteVacationsDayBindingSource(i).id = 0 Then
                        TblExecuteVacationsDayBindingSource(i).EmployeeVacationId = EmployeeVacId
                        aMainor.TblExecuteVacationsDays.InsertOnSubmit(TblExecuteVacationsDayBindingSource(i))
                        aMainor.SubmitChanges()
                        Dim oldrow As TblEmployeeVacation = (From ax In aMainor.TblEmployeeVacations Where ax.Id = EmployeeVacId).ToList(0)
                        oldrow.ExecutedDays += TblExecuteVacationsDayDataGridView.Rows(i).Cells(NbOfDays.Index).Value
                        aMainor.SubmitChanges()
                        restNumberOfDays = restNumberOfDays - TblExecuteVacationsDayDataGridView.Rows(i).Cells(NbOfDays.Index).Value
                    End If
                Next
            End Using
        End If
    End Sub

End Class