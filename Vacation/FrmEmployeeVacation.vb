Public Class FrmEmployeeVacation
    Public employeeId As Integer = 0

    Public saved As Boolean = False
    Public isValidate As Boolean = True
    Dim selectedDate As Date
    Private Sub FrmEmployeeVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblVacationBindingSource.DataSource = aMainor.TblVacations.ToList
            TblVacationBindingSource1.DataSource = aMainor.TblVacations.ToList
        End Using

        refreshform()

    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellContentClick
        If e.ColumnIndex = Execute.Index Then
            If TblEmployeeVacationBindingSource.Current.vacationId = YearlyVacationId Then
                Dim EmpVacId As Integer = TblEmployeeVacationBindingSource.Current.id
                Dim restNumberOfDays = TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).Value - TblEmployeeVacationDataGridView.CurrentRow.Cells(ExecutedDays.Index).Value
                Dim x As New FrmExecuteDaysFromVacationList
                x.restNumberOfDays = restNumberOfDays
                x.EmployeeVacId = EmpVacId
                x.DateExecuted = TblEmployeeVacationDataGridView.CurrentRow.Cells(DateCol.Index).Value
                x.ShowDialog()
                refreshform()
            Else
                MessageBox.Show("There is no executions for this vacation")
            End If

        End If
    End Sub
    Sub refreshform()
        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeVacationBindingSource.DataSource = (From ax In aMainor.TblEmployeeVacations Where ax.EmployeeId = employeeId).ToList
        End Using
    End Sub



    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        checkgridValidate()
        If isValidate Then
            TblEmployeeVacationDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblEmployeeVacationBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblEmployeeVacationDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblEmployeeVacationBindingSource.Count - 1
            Dim x As TblEmployeeVacation = TblEmployeeVacationBindingSource(i)
            If x.NumberOfDays Is Nothing Or x.VacationId Is Nothing Then
                If i = 0 Then
                    isValidate = False
                Else
                    isValidate = isValidate And False
                End If
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Dim x As TblEmployeeVacation = TblEmployeeVacationBindingSource.Current
                x.EmployeeId = employeeId
                x.Year = selectedDate.Year

                If x.Id = 0 Then
                    If x.VacationId = YearlyVacationId Then
                        x.ExecutedDays = 0
                    Else
                        x.ExecutedDays = TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).Value
                    End If

                    aMainor.TblEmployeeVacations.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                Else
                    'Dim newrow As TblEmployeeVacation = TblEmployeeVacationBindingSource.Current
                    Dim t As Integer = x.Id
                    Dim oldRow = (From ax In aMainor.TblEmployeeVacations Where ax.Id = t).ToList(0)
                    oldRow.VacationId = x.VacationId
                    oldRow.NumberOfDays = x.NumberOfDays
                    If x.VacationId = YearlyVacationId Then
                        oldRow.ExecutedDays = 0
                    Else
                        oldRow.ExecutedDays = x.NumberOfDays
                    End If

                    oldRow.Date = x.Date
                    oldRow.Year = x.Year
                    aMainor.SubmitChanges()


                End If

            End If
            Me.Close()
        End Using
    End Sub

    Private Sub TblEmployeeVacationDataGridView_ReadOnlyChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEmployeeVacationDataGridView.ReadOnlyChanged
        ExecutedDays.ReadOnly = True
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'selectedDate = MonthCalendar1.SelectionStart.Date
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        MonthCalendar1.Visible = False
        TblEmployeeVacationDataGridView.Enabled = True
        ' isDateSelected = True
        TblEmployeeVacationDataGridView.CurrentRow.Cells(DateCol.Index).Value = selectedDate
    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellDoubleClick
        If TblEmployeeVacationBindingSource.Count > 0 Then
            If e.ColumnIndex = DateCol.Index Then
                Dim Id As Integer = TblEmployeeVacationBindingSource.Current.id
                TblEmployeeVacationDataGridView.Enabled = False
                MonthCalendar1.Visible = True

            End If
        End If
    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellEndEdit
        Using aMainor As New LqHRDataContext(cnx)
            If e.ColumnIndex = VacationCol.Index Then


                Dim x As Integer = TblEmployeeVacationBindingSource.Current.vacationId
                Dim r As TblVacation = (From ax In aMainor.TblVacations Where ax.Id = x).ToList(0)
                If Not r.NumberOfDays = 0 Then
                    TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).ReadOnly = True
                    TblEmployeeVacationBindingSource.Current.NumberOfDays = r.NumberOfDays
                Else
                    TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).ReadOnly = False
                End If
            End If

        End Using
    End Sub

   
End Class