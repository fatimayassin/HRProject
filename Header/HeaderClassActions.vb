Public Class HeaderClassActions

    Dim counter As Integer = 1
    Dim counter2 As Integer = 1
    Dim counter3 As Integer = 1
    Dim counter4 As Integer = 1

    'Public Sub ClickBtnDISABLE()
    '    MessageBox.Show("ssssss")


    'End Sub

    'Public Sub ClickBtnEnable()
    '    MessageBox.Show("aaaaa")
    'End Sub

    'Public Sub ClickBtn1()
    '    Dim x As New Form3
    '    x.ShowDialog()
    'End Sub

    Public Sub initheader(ByVal MyForm As Form, ByVal h As UCHeader, ByVal ref As Integer)
        h.Visible = False
        h.InitHeader("Human Resourses Management System", MyForm, My.Settings.PanelColor, Color.LightSteelBlue, Color.FromArgb(50, 100, 130), Color.White, Color.WhiteSmoke, Color.LightSteelBlue, Color.White, Color.Black, True, True, True, True, True, True, False, True)
        FillHeader(h, ref)
        h.Visible = True
    End Sub

    'Public Sub initheader(ByVal MyForm As Form, ByVal h As UCHeaderTop, ByVal ref As Integer)
    '    h.Visible = False
    '    h.InitHeader("Human Resourses Management System", MyForm, My.Settings.PanelColor, Color.LightSteelBlue, Color.FromArgb(50, 100, 130), Color.White, Color.WhiteSmoke, Color.LightSteelBlue, Color.White, Color.Black, True, True, True, True, True, True, False, True)
    '    ' FillHeader(h, ref)
    '    h.Visible = True
    'End Sub

    'Public Sub initheaderBody(ByVal MyForm As Form, ByVal h As UCHeader2, ByVal ref As Integer)
    '    h.Visible = False
    '    h.InitHeaderBody(MyForm, My.Settings.PanelColor, Color.LightSteelBlue, Color.FromArgb(50, 100, 130), Color.White, Color.WhiteSmoke, Color.LightSteelBlue, Color.White, Color.Black, True, True, True, True, True, True, False, True)
    '    FillHeader(h, ref)
    '    h.Visible = True
    'End Sub

    'Public Sub PBTEST_Click()
    '    Dim x As New FrmCalendarEvents
    '    x.ShowDialog()
    '    x.Dispose()
    'End Sub

    Public Sub PBCompanyProfile_Click()
        Dim x As New FrmCompanyProfil
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBCurrencies_Click()
        Dim x As New FrmCurrencyList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBDepCat_Click()
        Dim x As New FrmDepartmentCategory
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBDepType_Click()
        Dim x As New FrmDepartmentType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBDepartment_Click()
        'Form1.Panel1.Controls.Clear()
        'PanelHome.Controls.Clear()
        counter2 = 1
        counter3 = 1
        counter4 += 1
        counter = 1
        If counter4 Mod 2 = 0 Then
            'Dim dep As New UCDepartmentTree
            'dep.Dock = DockStyle.Fill
            'PanelHome.Controls.Add(dep)
            Dim x As New FrmUCDepartmentTree
            x.TopLevel = False
            MyOpenForm(x)
            x.Dock = DockStyle.Fill
            x.Show()
        Else
            '  Form1.Panel1.Controls.Clear()
            'PanelHome.Controls.Clear()
        End If
    End Sub

    Public Sub PBCategory_Click()
        Dim x As New FrmCategoryList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBTask_Click()
        Dim x As New FrmTask
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBCertificate_Click()
        Dim x As New FrmCertificateList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBMedicalIssues_Click()
        Dim x As New FrmMedicalIssuesList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBSalaryCategory_Click()
        Dim x As New FrmSalaryCategories
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBPosition_Click()
        Dim x As New FrmPositionList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBSkills_Click()
        Dim x As New FrmSkillsList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBStatus_Click()
        Dim x As New FrmStatusList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBLectures_Click()
        Dim x As New FrmLecturesList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBBlood_Click()
        Dim x As New FrmBlood
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBContractType_Click()
        Dim x As New FrmContractType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBJobCat_Click()
        Dim x As New FrmJobCategory
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBMotivation_Click()
        Dim x As New FrmMotivationPunishmentType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBType_Click()
        Dim x As New FrmType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBReqHoursForJob_Click()
        Dim x As New FrmReqHoursForJob
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBApplicant_Click()
        'PanelHome.Controls.Clear()
        counter2 = 1
        counter3 = 1
        counter4 = 1
        counter += 1
        If counter Mod 2 = 0 Then
            'Dim X As New UCApplicantInfo
            'X.Dock = DockStyle.Fill
            'X.StatusId = ApplicantStatusId
            'PanelHome.Controls.Add(X)
            Dim x As New FrmUCApplicantInfo
            x.TopLevel = False
            x.StatusId = ApplicantStatusId
            x.Dock = DockStyle.Fill
            MyOpenForm(x)
            x.Show()
        Else
            'PanelHome.Controls.Clear()
        End If
    End Sub

    Public Sub PBApplicantIndex_Click()
        Dim x As New FrmApplicantIndex
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBTrainee_Click()
        'PanelHome.Controls.Clear()
        counter = 1
        counter3 = 1
        counter4 = 1
        counter2 += 1
        If counter2 Mod 2 = 0 Then
            'Dim X As New UCApplicantInfo
            'X.StatusId = TraineeStatusId
            'X.Dock = DockStyle.Fill
            '   PanelHome.Controls.Add(X)
            Dim x As New FrmUCTraineeInfo
            x.TopLevel = False
            x.StatusId = TraineeStatusId
            x.Dock = DockStyle.Fill
            MyOpenForm(x)
            x.Show()
        Else
            '  PanelHome.Controls.Clear()
        End If
    End Sub

    Public Sub PBPA_Click()
        Dim x As New FrmPAforTrainee
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBTraineeList_Click()
        Dim x As New FrmListofPAforTrainee
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBEmployee_Click()
        'PanelHome.Controls.Clear()
        counter = 1
        counter2 = 1
        counter4 = 1
        counter3 += 1
        If counter3 Mod 2 = 0 Then
            'Dim X As New UCApplicantInfo
            'X.Dock = DockStyle.Fill
            'X.StatusId = EmployeeStatusId
            'PanelHome.Controls.Add(X)
            Dim x As New FrmUCEmployeeInfo
            x.TopLevel = False
            x.StatusId = EmployeeStatusId
            x.Dock = DockStyle.Fill
            MyOpenForm(x)
            x.Show()
        Else
            'PanelHome.Controls.Clear()
        End If
    End Sub

    Public Sub PBEmployeePA_Click()
        Dim x As New FrmPAForEmployee
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBEmployeeList_Click()
        Dim x As New FrmEmployeeList
        x.statusId = EmployeeStatusId
        x.ShowDialog()
    End Sub

    Public Sub PBRetiredList_Click()
        'PanelHome.Controls.Clear()
        'Dim X As New UCApplicantInfo
        'X.Dock = DockStyle.Fill
        'X.StatusId = RetiredStatusId
        'PanelHome.Controls.Add(X)
        Dim x As New FrmUCRetiredInfo
        x.TopLevel = False
        x.StatusId = RetiredStatusId
        x.Dock = DockStyle.Fill
        MyOpenForm(x)
        x.Show()
    End Sub

    Public Sub PBRetiredEmpList_Click()
        Dim x As New FrmEmployeeList
        x.statusId = RetiredStatusId
        x.lblText.Text = "Retired Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBUnEmployee_Click()
        Dim x As New FrmUCUnEmployeeInfo
        x.TopLevel = False
        x.StatusId = UnemploymentStatusId
        x.Dock = DockStyle.Fill
        MyOpenForm(x)
        x.Show()
    End Sub

    Public Sub PBUnEmployeeList_Click()
        Dim x As New FrmUnEmployeeList
        x.statusId = UnemploymentStatusId
        x.lblText.Text = "Un-Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub


    Public Sub PBJobsPerDep_Click()
        Dim x As New FrmAssigndDepsToJob
        x.fromhome = True
        x.ShowDialog()
        x.Dispose()

    End Sub

    Public Sub PAPerTask_Click()
        Dim x As New FrmAveragePAPerJobPerTask
        x.ShowDialog()
        x.Dispose()
    End Sub


    Public Sub JobDesc_Click()
        Dim x As New FrmJobDescription
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBMotivationPunishment_Click()
        Dim x As New FrmMotivationPunishment
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBPersonalVacApproval_Click()
        Dim x As New FrmHolidays
        x.TextBox1.Text = Date.Now.Year
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBLeavePermission_Click()
        Dim x As New FrmLeavePermission
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBLeavePermissionApproval_Click()
        Dim x As New FrmLeavePermApproval
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBVacation_Click()
        Dim x As New FrmVacations
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBPresonalVact_Click()
        Dim x As New FrmYearlyVacations
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PbDashBoard_Click()
        Dim X As New FrmVactionsHolidaysDashBoard
        X.ShowDialog()
    End Sub

    Public Sub PBEmployeeVac_Click()
        Dim x As New FrmEmployeeList
        x.statusId = EmployeeStatusId
        x.VacationHolidays = True
        x.lblText.Text = "Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBAssignYearlyVacation_Click()
        Dim answer = MessageBox.Show("Assign Yearly Vacations?", "Assign", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)
                aMainor.AssignYearlyVacationsToEmployee(Date.Now)
            End Using
            Dim x As New frmAfterAssignYearlyVacToEmployee
            x.ShowDialog()
        Else
            'Me.Close()
        End If
    End Sub

    Public Sub PBMonth_Click()
        Dim x As New FrmMonths
        x.ShowDialog()
    End Sub

    Public Sub PBYear_Click()
        Dim x As New FrmYearList
        x.ShowDialog()
    End Sub

    Public Sub PBClassificationDegree_Click()
        Dim x As New frmClassificationDegreeTree
        x.ShowDialog()
    End Sub

    Public Sub PBYearCalendar_Click()
        Using aMainor As New LqHRDataContext(cnx)
            Dim Res = (From ax In aMainor.TblYears Where ax.Year = Date.Now.Year).ToList()
            If Not Res.Count > 0 Then
                Dim yr As New TblYear
                yr.Year = Date.Now.Year
                aMainor.TblYears.InsertOnSubmit(yr)
                aMainor.SubmitChanges()
            End If
            Dim yearId As Integer = (From ax In aMainor.TblYears Where ax.Year = Date.Now.Year Select ax.Id).ToList(0)
            Dim Cnt = (From ax In aMainor.TblMonthsPerYears Where ax.YearId = yearId).ToList.Count
            If Cnt = 12 Then
                Dim x As New FrmYearCalendarForSalaries
                x.Id = yearId
                x.ShowDialog()
            Else
                aMainor.MonthsPerYear(yearId)
                Dim x As New FrmYearCalendarForSalaries
                x.Id = yearId
                x.ShowDialog()
            End If
        End Using
    End Sub

    Public Sub PBSalariesHistory_Click()
        Dim x As New FrmMonthSalary
        x.ShowDialog()
    End Sub

    Public Sub PBEmployeeSalaryList_Click()
        Dim x As New frmEmployeeSalaryList
        x.ShowDialog()
    End Sub

    Public Sub PBSettings_Click()
        Dim x As New FrmSettings
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBPermissions_Click()
        Dim x As New FrmUserList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Public Sub PBComputerSettings_Click()
        Dim x As New FrmPCSettings
        x.ShowDialog()
        x.Dispose()
    End Sub

    'Public Sub PBs_Click()
    '    Dim x As New FrmInterface
    '    x.ShowDialog()
    '    x.Dispose()
    'End Sub

    Sub FillHeader(ByVal h As UCHeader, ByVal ref As Integer)

        h.addTab(1, "Profile", "")
        h.addPanel(1, 1, "Profile Panel", "")
        h.addbtn(1, 1, "Company Profile", "Company Profile", My.Resources.CompanyProfileNEW, "PBCompanyProfile_Click")
        h.addbtn(1, 2, "Currency", "Currency", My.Resources.CurrencyNEW, "PBCurrencies_Click")
        h.addbtn(1, 3, "Dep.Category", "Department Category", My.Resources.DepCategoryNEW, "PBDepCat_Click")
        h.addbtn(1, 4, "Dep.Type", "Department Type", My.Resources.DepTypeNEW, "PBDepType_Click")
        h.addbtn(1, 5, "Departments", "Departments", My.Resources.DepartmentsNEW, "PBDepartment_Click")
        h.addbtn(1, 6, "Task Category", "Task Category", My.Resources.TaskCategoryNEW, "PBCategory_Click")
        h.addbtn(1, 7, "Task", "Task", My.Resources.TaskNEWW, "PBTask_Click")
        h.addbtn(1, 8, "Certificate", "Certificate", My.Resources.CertificateNEW, "PBCertificate_Click")
        h.addbtn(1, 9, "Medical Issue", "Medical Issue", My.Resources.MedicalIssueNEW, "PBMedicalIssues_Click")
        h.addbtn(1, 10, "Salary Category", "Salary Category", My.Resources.Salarycategory, "PBSalaryCategory_Click")
        h.addbtn(1, 11, "Position", "Position", My.Resources.PositionNEW, "PBPosition_Click")
        h.addbtn(1, 12, "Skills", "Skills", My.Resources.SkillsNEW, "PBSkills_Click")
        h.addbtn(1, 13, "Status", "Status", My.Resources.StatusNEW, "PBStatus_Click")
        h.addbtn(1, 14, "Lectures", "Lectures", My.Resources.LecturesNEW, "PBLectures_Click")
        h.addbtn(1, 15, "Blood Type", "Blood Type", My.Resources.BloodTypesNEWNEW, "PBBlood_Click")
        h.addbtn(1, 16, "Contract Type", "Contract Type", My.Resources.ContractTypeNEW, "PBContractType_Click")
        h.addbtn(1, 17, "Job Cat.", "Job Category", My.Resources.JobCatNEW, "PBJobCat_Click")
        h.addbtn(1, 18, "Motiv.Type", "Motivation Type", My.Resources.MotivationTypeNEW, "PBMotivation_Click")
        h.addbtn(1, 19, "Req.Type", "Requirement Type", My.Resources.RequirementTypeNEW, "PBType_Click")
        h.addbtn(1, 20, "Job.Hours", "Job.Hours", My.Resources.HoursForJObNEW, "PBReqHoursForJob_Click")


        h.addTab(2, "Personal", "")
        h.addPanel(2, 2, "Personal Panel", "2")
        h.addbtn(2, 1, "Applicant", "Applicant", My.Resources.ApplicantNEW, "PBApplicant_Click")
        h.addbtn(2, 2, "App.Index", "Applicant List/Index", My.Resources.AppIndexNEW, "PBApplicantIndex_Click")
        h.addbtn(2, 3, "Trainee", "Trainee", My.Resources.TraineeNEW, "PBTrainee_Click")
        h.addbtn(2, 4, "Trainee PA", "Trainee PA", My.Resources.TraineePA, "PBPA_Click")
        h.addbtn(2, 5, "Trainee List", "Trainee List", My.Resources.TraineeListNEW, "PBTraineeList_Click")
        h.addbtn(2, 6, "Employee", "Employee", My.Resources.EmployeeNEW, "PBEmployee_Click")
        h.addbtn(2, 7, "Employee PA", "Employee PA", My.Resources.EmployeePANEW, "PBEmployeePA_Click")
        h.addbtn(2, 8, "Employee List", "Employee List", My.Resources.EmployeeList, "PBEmployeeList_Click")
        h.addbtn(2, 9, "Retired Employee", "Retired Employee", My.Resources.RetiredEmpNEW, "PBRetiredList_Click")
        h.addbtn(2, 10, "Retired List", "Retired List", My.Resources.RetiredListNEW, "PBRetiredEmpList_Click")

        h.addbtn(2, 11, "Un-Employee", "Un-Employee", My.Resources.UnEmployeeNEW, "PBUnEmployee_Click")
        h.addbtn(2, 12, "Un-Emp.List", "Un-Employee List", My.Resources.UnEmployeeListNEW, "PBUnEmployeeList_Click")

        h.addbtn(2, 13, "Jobs List", "Jobs List", My.Resources.JobListNEW, "PBJobsPerDep_Click")
        h.addbtn(2, 14, "PA Per Task", "PA Per Task", My.Resources.PAPerTaskNEW, "PAPerTask_Click")
        h.addbtn(2, 15, "Job Description", "Job Description", My.Resources.JobDesNEW, "JobDesc_Click")
        h.addbtn(2, 16, "Motiv VS. Punish.", "Motivation VS. Punishment", My.Resources.MotivVSPunNEW, "PBMotivationPunishment_Click")


        h.addTab(3, "Vacations", "")
        h.addPanel(3, 3, "Vacations Panel", "3")
        h.addbtn(3, 1, "Holidays", "Holidays", My.Resources.HolidaysNEW, "PBPersonalVacApproval_Click")
        h.addbtn(3, 2, "Leave", "Leave", My.Resources.LeaveNEW, "PBLeavePermission_Click")
        h.addbtn(3, 3, "Leave Approval", "Leave Approval", My.Resources.LeaveApprovalNEW, "PBLeavePermissionApproval_Click")
        h.addbtn(3, 4, "Vacations", "Vacations", My.Resources.VacationsNEW, "PBVacation_Click")
        h.addbtn(3, 5, "Year.Vacat.", "Yearly Vacations", My.Resources.YearlyVacationsNEW, "PBPresonalVact_Click")
        h.addbtn(3, 6, "Dashboard", "Dashboard", My.Resources.DashboardNEW, "PbDashBoard_Click")
        h.addbtn(3, 7, "Vacat.Holidays", "Vacation / Holidays", My.Resources.VacationHolidaysNEW, "PBEmployeeVac_Click")
        h.addbtn(3, 8, "Assign Yearl...", "Assign Yearly Vacations", My.Resources.AssignNEW2, "PBAssignYearlyVacation_Click")



        h.addTab(4, "Salary ", "")
        h.addPanel(4, 4, "Salary Panel", "4")
        h.addbtn(4, 1, "Months", "Months", My.Resources.MonthsNEW, "PBMonth_Click")
        h.addbtn(4, 2, "Years", "Years", My.Resources.YearsNEW, "PBYear_Click")
        h.addbtn(4, 3, "Class/Degree", "Class/Degree", My.Resources.ClassDegreeNEW, "PBClassificationDegree_Click")
        h.addbtn(4, 4, "Year.Calendar", "Yearly Calendar", My.Resources.YearlyCalendarNEW, "PBYearCalendar_Click")
        h.addbtn(4, 5, "Salaries History", "Salaries History", My.Resources.SalariesHistoryNEW, "PBSalariesHistory_Click")
        h.addbtn(4, 6, "Employee List", "Employee List", My.Resources.EmployeeListNEW, "PBEmployeeSalaryList_Click")


        h.addTab(5, "Tools", "")
        h.addPanel(5, 5, "Tools Panel", "5")
        h.addbtn(5, 1, "Settings", "Settings", My.Resources.SettingsNEW, "PBSettings_Click")
        h.addbtn(5, 2, "Users", "Users", My.Resources.UsersNEW, "PBPermissions_Click")
        'h.addbtn(5, 3, "PC Settings", "PC Settings", My.Resources.PCsettingsNEW, "PBComputerSettings_Click")


        h.isLoaded(1)

    End Sub

End Class
