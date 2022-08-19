Public Class FrmAddNewVacation
    Public id As Integer = 0
    Public fromuc As Boolean = False
    Public ApplicantId As Integer = 0
    Public saved As Boolean = False
    Public current As New TblVacation
    Public ForEdit As Boolean = False
    Public PossibleReccurencyDays As Integer = 0

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FrmAddNewVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext(cnx)
            TblVacationTypeBindingSource.DataSource = aMainor.TblVacationTypes.ToList

            If fromuc Then
                EmployeeNameTextBox.Visible = False
                EmployeeIdLabel.visible = False
                If Not ForEdit Then
                    If id = 0 Then
                        TblVacationBindingSource.DataSource = New TblVacation
                    End If
                Else
                    TblVacationBindingSource.DataSource = current
                End If
            Else
                EmployeeNameTextBox.Visible = True
                EmployeeIdLabel.Visible = True
                If id = 0 Then
                    TblVacationBindingSource.DataSource = New TblVacation

                Else
                    TblVacationBindingSource.DataSource = (From ax In aMainor.TblVacations Where ax.Id = id).ToList(0)
                End If
            End If
        End Using
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            If fromuc Then
                TblVacationBindingSource.Current.ExecutedDays = NumberOfDaysNumericUpDown.Value
                current = TblVacationBindingSource.Current
            Else
                If id = 0 Then

                    TblVacationBindingSource.Current.ExecutedDays = NumberOfDaysNumericUpDown.Value
                    aMainor.TblVacations.InsertOnSubmit(TblVacationBindingSource.Current)
                    aMainor.SubmitChanges()
                Else
                    Dim oldrow As TblVacation = (From ax In aMainor.TblVacations Where ax.Id = id).ToList(0)
                    Dim newRow As TblVacation = TblVacationBindingSource.Current
                    oldrow.Description = newRow.Description
                    oldrow.EmployeeId = newRow.EmployeeId
                    oldrow.ExecutedDays = newRow.NumberOfDays 'EXECUTED=NUMBEROFDAYS
                    oldrow.NumberOfDays = newRow.NumberOfDays
                    oldrow.VacationDate = newRow.VacationDate
                    oldrow.VacationTypeId = newRow.VacationTypeId
                    aMainor.SubmitChanges()


                End If

            End If
            saved = True
            Me.Close()
        End Using
    End Sub

    Private Sub VacationTypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VacationTypeIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmPersonalVacType
            x.ShowDialog()
            If x.saved Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblVacationTypeBindingSource.DataSource = aMainor.TblVacationTypes.ToList
                End Using
            End If

            x.Dispose()
        End If
    End Sub

    Private Sub VacationTypeIdComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VacationTypeIdComboBox.TextChanged
        Dim VcTypeId As Integer = VacationTypeIdComboBox.SelectedValue
        NumberOfDaysNumericUpDown.Value = 0
        If VcTypeId > 0 Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.TblVacationTypes Where ax.Id = VcTypeId).ToList(0)
                PossibleReccurencyDays = res.PossibleReccurencyDays
            End Using
        End If
    End Sub

    Private Sub NumberOfDaysNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDaysNumericUpDown.ValueChanged
        If NumberOfDaysNumericUpDown.Value > PossibleReccurencyDays Then
            MessageBox.Show("This number is not possible ")
            NumberOfDaysNumericUpDown.Value = 0
        End If
    End Sub

    Private Sub EmployeeNameTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeNameTextBox.Leave
        Dim x As New FrmApplicantList
        x.empName = EmployeeNameTextBox.Text
        x.statusId = EmployeeStatusId
        x.ShowDialog()
        If x.saved = True Then
            Dim appid As Integer = x.id
            Using aMainor As New LqHRDataContext(cnx)
                Dim name As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = appid).ToList(0)
                EmployeeNameTextBox.Text = name.FirstName
                Dim r = (From ax In aMainor.TblEmployees Where ax.ApplicantId = appid).ToList(0)

                TblVacationBindingSource.Current.employeeid = r.Id
            End Using
        End If

        x.Dispose()
    End Sub
End Class