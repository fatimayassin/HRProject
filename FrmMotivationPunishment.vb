Public Class FrmMotivationPunishment
    Public id As Integer = 0
    Public fromUc As Boolean = False
    Public saved As Boolean = False
    Public applicantId As Integer = 0
    Public current As New TblMotivationPunishment
    Public foredit As Boolean = False
    Public DateOfBirth As Date

    Private Sub FrmMotivationPunishment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblMotivationPunishmentTypeBindingSource.DataSource = aMainor.TblMotivationPunishmentTypes.ToList
            DateDateTimePicker.MinDate = DateOfBirth
            If fromUc Then
                EmployeeIdLabel.Visible = False
                EmployeeNameTextBox.Visible = False
                If Not foredit Then
                    If id = 0 Then
                        TblMotivationPunishmentBindingSource.DataSource = New TblMotivationPunishment
                    End If
                Else
                    TblMotivationPunishmentBindingSource.DataSource = current
                    'Dim empId As Integer = current.EmployeeId
                    'Dim res = (From ax In aMainor.TblEmployees Where ax.Id = empId).ToList(0)
                    'Dim Appid As Integer = res.ApplicantId
                    'EmployeeNameTextBox.Text = (From ax In aMainor.TblApplicants Where ax.Id = Appid Select ax.FirstName).ToList(0)

                End If
            Else
                EmployeeIdLabel.Visible = True
                EmployeeNameTextBox.Visible = True
                If id = 0 Then
                    TblMotivationPunishmentBindingSource.DataSource = New TblMotivationPunishment
                Else
                    TblMotivationPunishmentBindingSource.DataSource = (From ax In aMainor.TblMotivationPunishments Where ax.Id = id).ToList(0)



                End If
            End If

        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub EmployeeIdTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmployeeNameTextBox.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim x As New FrmEmployeeList
            x.empName = EmployeeNameTextBox.Text
            x.statusId = EmployeeStatusId
            x.SelectRelativeReference = True 'SAME CASE AS RELATIVE REFERENCES
            x.ShowDialog()
            If x.saved = True Then
                Dim Employeeid As Integer = x.EmpId
                Using aMainor As New LqHRDataContext(cnx)
                    Dim res = (From ax In aMainor.TblEmployees Where ax.Id = Employeeid).ToList(0)
                    EmployeeNameTextBox.Text = res.EmployeeName
                    TblMotivationPunishmentBindingSource.Current.employeeid = Employeeid
                End Using
            End If

            x.Dispose()
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        BtnSave.Focus()
        If fromUc Then
            current = TblMotivationPunishmentBindingSource.Current

        Else
            Using aMainor As New LqHRDataContext(cnx)
                If id = 0 Then
                    aMainor.TblMotivationPunishments.InsertOnSubmit(TblMotivationPunishmentBindingSource.Current)
                    aMainor.SubmitChanges()
                Else
                    Dim oldRow As TblMotivationPunishment = (From ax In aMainor.TblMotivationPunishments Where ax.Id = id).ToList(0)
                    Dim newRow As TblMotivationPunishment = TblMotivationPunishmentBindingSource.Current
                    oldRow.Date = newRow.Date
                    oldRow.EmployeeId = newRow.EmployeeId
                    oldRow.IsMotivation = newRow.IsMotivation
                    oldRow.Note = newRow.Note
                    oldRow.Reason = newRow.Reason
                    oldRow.MotivationPunishmentTypeId = newRow.MotivationPunishmentTypeId
                    aMainor.SubmitChanges()
                End If
            End Using
        End If
        saved = True
        Me.Close()
    End Sub

    Private Sub EmployeeNameTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeNameTextBox.Leave
        'Dim x As New FrmApplicantList
        'x.empName = EmployeeNameTextBox.Text
        'x.statusId = EmployeeStatusId

        'x.ShowDialog()
        'If x.saved = True Then
        '    Dim appid As Integer = x.id
        '    Using aMainor As New LqHRDataContext(cnx)
        '        Dim name As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = appid).ToList(0)
        '        EmployeeNameTextBox.Text = name.FirstName
        '        Dim r = (From ax In aMainor.TblEmployees Where ax.ApplicantId = appid).ToList(0)

        '        TblMotivationPunishmentBindingSource.Current.employeeid = r.Id
        '    End Using
        'End If
    End Sub

    Private Sub MotivationPunishmentTypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MotivationPunishmentTypeIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmMotivationPunishmentType
            x.ShowDialog()
            If x.saved Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblMotivationPunishmentTypeBindingSource.DataSource = aMainor.TblMotivationPunishmentTypes.ToList
                End Using

            End If

            x.Dispose()
        End If
    End Sub
End Class