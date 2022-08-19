Public Class FrmAssignAsEmployee

    Public TraineeId As Integer = 0
    Public ApplicantId As Integer = 0
    Public saved As Boolean = False
    Public fromuc As Boolean = False
    Public ForEdit As Boolean = False
    Public currentEmployee As New TblEmployee
    Public currentEmployeeJob As New TblEmployeeJob


    Public id As Integer = 0
    Public ExstRow As Boolean = False
    Dim jobsList As New List(Of Integer?)
    Dim DgreesList As New List(Of Integer)

    Private Sub FrmAssignEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        DateOfEmploymentTimePicker.Value = New DateTime(DateTime.Now.Year, 1, 1)
        Using aMainor As New LqHRDataContext(cnx)
            TblContractTypeBindingSource.DataSource = (From ax In aMainor.TblContractTypes Order By ax.Name).ToList
            TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
            TblDegreeBindingSource.DataSource = aMainor.TblDegrees.ToList

            If fromuc Then
                PINLabel.Visible = False
                PINTextBox.Visible = False
                If Not ForEdit Then

                    If ApplicantId > 0 Then

                        TblEmployeeBindingSource.DataSource = currentEmployee
                        TblEmployeeJobBindingSource.DataSource = New TblEmployeeJob

                    Else
                        If ExstRow Then
                            TblEmployeeBindingSource.DataSource = currentEmployee
                        Else
                            TblEmployeeBindingSource.DataSource = New TblEmployee

                        End If

                        TblEmployeeJobBindingSource.DataSource = New TblEmployeeJob

                    End If
                Else

                    TblEmployeeBindingSource.DataSource = currentEmployee
                    TblEmployeeJobBindingSource.DataSource = currentEmployeeJob



                End If
            Else ''''' when click assign a employee
                PINLabel.Visible = True
                PINTextBox.Visible = True

                TblEmployeeBindingSource.DataSource = New TblEmployee
                TblEmployeeJobBindingSource.DataSource = New TblEmployeeJob


            End If

        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If BatchNumberTextBox.Text = "" Or CardNumberTextBox.Text = "" Or JobIdComboBox.SelectedIndex = -1 Or ContractTypeIdComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Missing some Info!")
        Else
            If fromuc Then
                'TblEmployeeJobBindingSource.Current.DATE = Date.Now
                'TblEmployeeJobBindingSource.Current.dateOfEmployment = Date.Now
                currentEmployee = TblEmployeeBindingSource.Current
                currentEmployeeJob = TblEmployeeJobBindingSource.Current


            Else


                Using aMainor As New LqHRDataContext(cnx)
                    Dim r As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = ApplicantId).ToList(0)
                    r.StatusId = EmployeeStatusId
                    aMainor.SubmitChanges()
                    ''''''''save in employee table''''''''''''''''
                    Dim FullName As String = r.FirstName + " " + r.MiddleName + " " + r.LastName

                    Dim current As TblEmployee = TblEmployeeBindingSource.Current
                    current.ApplicantId = ApplicantId
                    current.EmployeeName = FullName
                    aMainor.TblEmployees.InsertOnSubmit(current)
                    aMainor.SubmitChanges()

                    Dim EmpId As Integer = current.Id

                    ''''''''''''''save in employee jobs ''''''''''''''''''
                    Dim currentEmpJob As TblEmployeeJob = TblEmployeeJobBindingSource.Current
                    currentEmpJob.EmployeeId = EmpId
                    'currentEmpJob.DateOfEmployment = DateTime.Now
                    'currentEmpJob.DeligatedOn = DateTime.Now
                    'currentEmpJob.Deligated = True
                    'currentEmpJob.DeligatedBy = MyEmployeeId
                    currentEmpJob.Active = True
                    aMainor.TblEmployeeJobs.InsertOnSubmit(currentEmpJob)
                    aMainor.SubmitChanges()
                    Dim EmployeeJobId As Integer = currentEmpJob.Id





                    ''''''''''''''''''''''''''''''Save Experience If He Is A Trainee ''''''''''''''''''''''

                    Dim res = (From ax In aMainor.TblTrainees Where ax.ApplicantId = ApplicantId).ToList()
                    If res.Count > 0 Then
                        TraineeId = res.ToList(0).Id
                        res.ToList(0).EndDate = Date.Now
                        aMainor.SubmitChanges()
                        Dim wrkExp As New TblExperienceHistory
                        wrkExp.ApplicantId = ApplicantId
                        wrkExp.CompanyName = (From ax In aMainor.TblCompanyProfiles Select ax.Name).ToList(0)
                        wrkExp.StartDate = res.ToList(0).StartDate
                        wrkExp.LeaveDate = res.ToList(0).EndDate
                        wrkExp.PositionId = traineePositionId
                        aMainor.TblExperienceHistories.InsertOnSubmit(wrkExp)
                        aMainor.SubmitChanges()
                    End If






                    ''''''''''''''''''''''''''''''''Assign Holidays to employee'''''''''''

                    aMainor.AssignHolidaysToEmplyee(EmpId)

                End Using
            End If
            saved = True
            Me.Close()
        End If
    End Sub

    Private Sub DepIdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepIdComboBox.SelectedIndexChanged, DepIdComboBox.Click
        Dim Depid As Integer = DepIdComboBox.SelectedValue
        Using aMainor As New LqHRDataContext(cnx)
            jobsList = (From ax In aMainor.TblJobsPerDepartments Where ax.DepartmentId = Depid Select ax.JobId).ToList
            TblJobDescriptionBindingSource.DataSource = (From AX In aMainor.TblJobDescriptions Where jobsList.Contains(AX.Id)).ToList

        End Using
    End Sub

    Private Sub DepIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DepIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmAddDepartment
            X.ShowDialog()
            If X.Saved Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
                End Using

            End If

            X.Dispose()
        End If
    End Sub

    Private Sub JobIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JobIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmJobDescription
            X.ShowDialog()
            If X.saved Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
                End Using

            End If

            X.Dispose()
        End If
    End Sub

    Private Sub ContractTypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContractTypeIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmContractType
            X.ShowDialog()
            If X.SAVED Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblContractTypeBindingSource.DataSource = aMainor.TblContractTypes.ToList
                End Using

            End If

            X.Dispose()
        End If
    End Sub


    Private Sub CurrencyIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmCurrencyList
            X.ShowDialog()
            'If X.saved Then
            Using aMainor As New LqHRDataContext(cnx)
                TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
            End Using

            'End If

            X.Dispose()
        End If
    End Sub

    Private Sub JobIdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobIdComboBox.SelectedIndexChanged
        Dim Jobid As Integer = JobIdComboBox.SelectedValue
        If Jobid > 0 Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim ClasId As Integer = (From ax In aMainor.TblJobDescriptions Where ax.Id = Jobid Select ax.ClassificantionId).ToList(0)

                DgreesList = (From ax In aMainor.TblDegrees Where ax.ClassificationId = ClasId Select ax.Id).ToList
                TblDegreeBindingSource.DataSource = (From AX In aMainor.TblDegrees Where DgreesList.Contains(AX.Id)).ToList

            End Using
        End If

    End Sub
End Class