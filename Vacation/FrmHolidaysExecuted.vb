Public Class FrmHolidaysExecuted
    Public HolId As Integer = 0
    Public ExecutedDays As Integer = 0
    Public dateHol As DateTime
    Public loaded As Boolean = False

    Private Sub FrmHolidaysExecuted_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshform()
        loaded = True
    End Sub

    
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 0 To Filter_EmployeeExecutedHolidaysResultBindingSource.Count - 1
                Filter_EmployeeExecutedHolidaysResultDataGridView.Rows(i).Cells(Check.Index).Value = True
            Next
        Else
            For i As Integer = 0 To Filter_EmployeeExecutedHolidaysResultBindingSource.Count - 1
                Filter_EmployeeExecutedHolidaysResultDataGridView.Rows(i).Cells(Check.Index).Value = False
            Next
        End If
    End Sub

    
   

   
    'Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
    '    For i = 0 To TblEmployeeHolidaysBindingSource.Count - 1
    '        If TblEmployeeHolidaysDataGridView.Rows(i).Cells(CHECK.Index).Value = True Then
    '            TblEmployeeHolidaysBindingSource(i).executionDate = DateTimePicker1.Value

    '        End If
    '    Next
    '    TblEmployeeHolidaysDataGridView.Refresh()

    'End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            For i = 0 To Filter_EmployeeExecutedHolidaysResultBindingSource.Count - 1
                If Filter_EmployeeExecutedHolidaysResultDataGridView.Rows(i).Cells(Check.Index).Value = True Then
                    Filter_EmployeeExecutedHolidaysResultBindingSource(i).executionDate = DateTimePicker1.Value
                    Dim ID As Integer = Filter_EmployeeExecutedHolidaysResultBindingSource(i).id
                    Dim oldRow As TblEmployeeHoliday = (From ax In aMainor.TblEmployeeHolidays Where ax.Id = ID).ToList(0)
                    Dim newRow As Filter_EmployeeExecutedHolidaysResult = Filter_EmployeeExecutedHolidaysResultBindingSource(i)
                    oldRow.ExecutionDate = newRow.ExecutionDate
                    oldRow.ExecutedDays = ExecutedDays
                    aMainor.SubmitChanges()
                End If
            Next
        End Using
        refreshform()

    End Sub
    Sub refreshform()
        Using aMainor As New LqHRDataContext(cnx)

            DateTimePicker1.Value = New DateTime(dateHol.Year, dateHol.Month, dateHol.Day)

            Filter_EmployeeExecutedHolidaysResultBindingSource.DataSource = (From ax In aMainor.Filter_EmployeeExecutedHolidays("") Where ax.StatusId = EmployeeStatusId And ax.HolidayId = HolId).ToList

            ExecutedCheck()
        End Using
    End Sub


    Sub executedCheck()
        For i = 0 To Filter_EmployeeExecutedHolidaysResultBindingSource.Count - 1

            If Filter_EmployeeExecutedHolidaysResultBindingSource(i).executionDate Is Nothing Then
                Filter_EmployeeExecutedHolidaysResultDataGridView.Rows(i).Cells(CheckExecute.Index).Value = False
            Else
                Filter_EmployeeExecutedHolidaysResultDataGridView.Rows(i).Cells(CheckExecute.Index).Value = True
            End If
        Next
    End Sub

    Private Sub ExecutedCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ExecutedCheckBox.CheckStateChanged, NameTextBox.TextChanged

        Using aMainor As New LqHRDataContext(cnx)
            If ExecutedCheckBox.CheckState = CheckState.Checked Then
                Filter_EmployeeExecutedHolidaysResultBindingSource.DataSource = (From ax In aMainor.Filter_EmployeeExecutedHolidays(NameTextBox.Text) Where ax.StatusId = EmployeeStatusId And ax.HolidayId = HolId And Not ax.ExecutionDate Is Nothing).ToList
                'executedC
                executedCheck()
            ElseIf ExecutedCheckBox.CheckState = CheckState.Unchecked Then
                Filter_EmployeeExecutedHolidaysResultBindingSource.DataSource = (From ax In aMainor.Filter_EmployeeExecutedHolidays(NameTextBox.Text) Where ax.StatusId = EmployeeStatusId And ax.HolidayId = HolId And ax.ExecutionDate Is Nothing).ToList
                executedCheck()
            ElseIf ExecutedCheckBox.CheckState = CheckState.Indeterminate Then
                Filter_EmployeeExecutedHolidaysResultBindingSource.DataSource = (From ax In aMainor.Filter_EmployeeExecutedHolidays(NameTextBox.Text) Where ax.StatusId = EmployeeStatusId And ax.HolidayId = HolId).ToList
                executedCheck()
            End If
        End Using

    End Sub
End Class