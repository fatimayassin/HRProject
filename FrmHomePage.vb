Public Class FrmHomePage
    Dim counter As Integer = 1
    Dim counter2 As Integer = 1
    Dim counter3 As Integer = 1
    Dim counter4 As Integer = 1
    Private clicked As Boolean = True
    Public forInfo As Boolean = False
    Public applicantId As Integer
    Public jobid As Integer = 0
    Dim Today As DateTime = DateTime.Now
    Dim garbagethred As Threading.Thread

    Private Sub pnlClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pnlClose.Click
        Using aMainor As New LqHRDataContext(cnx)
            If Not MyEmployeeId = 0 Then
                Dim res = (From ax In aMainor.TblUsers Where ax.EmployeeId = MyEmployeeId).ToList(0)
                res.LastSeen = Date.Now
                res.ComputerName = System.Windows.Forms.SystemInformation.ComputerName
                aMainor.SubmitChanges()
            End If

        End Using

        Me.Close()
    End Sub

    Private Sub FrmHomePage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TabControl1.TabPages.Remove(PBMonths)
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 42)
        Me.Location = New Point(0, 0)

        garbagethred = New System.Threading.Thread(AddressOf ThreadRunning)
        garbagethred.IsBackground = True
        garbagethred.Start()
        Using aMainor As New LqHRDataContext(cnx)
            Dim user = (From ax In aMainor.TblUsers Where ax.Id = userId Select ax.Username).ToList(0)
            lblUser.Text = user & " " & " Logged in At" & " " & Today
        End Using


        If forInfo Then
            'EmployeeToolStripMenuItem_Click(sender, e)
            PanelHome.Controls.Clear()

            Dim X As New UCApplicantInfo
            X.Size = PanelHome.Size
            X.Id = applicantId
            X.jobid = jobid
            PanelHome.Controls.Add(X)
        End If

    End Sub

    Sub ThreadRunning()
        While (True)
            GC.Collect()
            garbagethred.Sleep(30000)
        End While
    End Sub

    Private Sub PBUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBUser.Click
        If clicked Then
            PanelUser.Visible = True
            clicked = False
        Else
            PanelUser.Visible = False
            clicked = True
        End If

    End Sub

    Private Sub PBCurrencies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCurrencies.Click
        Dim x As New FrmCurrencyList
        x.ShowDialog()
        x.Dispose()
    End Sub


    Private Sub PBCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCategory.Click
        Dim x As New FrmCategoryList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBDepartment.Click
        PanelHome.Controls.Clear()
        counter2 = 1
        counter3 = 1
        counter4 += 1
        counter = 1
        If counter4 Mod 2 = 0 Then
            Dim dep As New UCDepartmentTree
            dep.Dock = DockStyle.Fill
            PanelHome.Controls.Add(dep)
        Else
            PanelHome.Controls.Clear()
        End If

    End Sub

    Private Sub PBCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCertificate.Click
        Dim x As New FrmCertificateList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBMedicalIssues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMedicalIssues.Click
        Dim x As New FrmMedicalIssuesList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBPosition.Click
        Dim x As New FrmPositionList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBSkills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSkills.Click
        Dim x As New FrmSkillsList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBStatus.Click
        Dim x As New FrmStatusList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBApplicant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBApplicant.Click
        PanelHome.Controls.Clear()
        counter2 = 1
        counter3 = 1
        counter4 = 1
        counter += 1
        If counter Mod 2 = 0 Then

            Dim X As New UCApplicantInfo
            X.Dock = DockStyle.Fill
            X.StatusId = ApplicantStatusId
            PanelHome.Controls.Add(X)
        Else
            PanelHome.Controls.Clear()

        End If
    End Sub

    Private Sub PBTrainee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBTrainee.Click
        PanelHome.Controls.Clear()
        counter = 1
        counter3 = 1
        counter4 = 1
        counter2 += 1
        If counter2 Mod 2 = 0 Then
            Dim X As New UCApplicantInfo
            X.StatusId = TraineeStatusId
            X.Dock = DockStyle.Fill
            PanelHome.Controls.Add(X)
        Else
            PanelHome.Controls.Clear()
        End If
    End Sub

    Private Sub PBEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEmployee.Click
        PanelHome.Controls.Clear()
        counter = 1
        counter2 = 1
        counter4 = 1
        counter3 += 1
        If counter3 Mod 2 = 0 Then
            Dim X As New UCApplicantInfo
            X.Dock = DockStyle.Fill
            X.StatusId = EmployeeStatusId
            PanelHome.Controls.Add(X)
        Else
            PanelHome.Controls.Clear()
        End If
    End Sub

    Private Sub PBApplicantIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBApplicantIndex.Click
        Dim x As New FrmApplicantIndex
        x.ShowDialog()
        'If Not x.Id = 0 Then
        '    PanelHome.Controls.Clear()
        '    Dim y As New UCApplicantInfo
        '    y.Dock = DockStyle.Fill
        '    y.StatusId = ApplicantStatusId
        '    y.Id = x.Id
        '    PanelHome.Controls.Add(y)
        'End If
        x.Dispose()
    End Sub

    Private Sub PBSettings_Click(sender As System.Object, e As System.EventArgs) Handles PBSettings.Click
        Dim x As New FrmSettings
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBLectures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLectures.Click
        Dim x As New FrmLecturesList
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBBlood_Click(sender As System.Object, e As System.EventArgs) Handles PBBlood.Click
        Dim x As New FrmBlood
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBContractType_Click(sender As System.Object, e As System.EventArgs) Handles PBContractType.Click
        Dim x As New FrmContractType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBDepCat_Click(sender As System.Object, e As System.EventArgs) Handles PBDepCat.Click
        Dim x As New FrmDepartmentCategory
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBDepType_Click(sender As System.Object, e As System.EventArgs) Handles PBDepType.Click
        Dim x As New FrmDepartmentType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBHoliday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim x As New FrmHoliday
        'x.ShowDialog()
        'x.Dispose()
    End Sub

    Private Sub PBJobCat_Click(sender As System.Object, e As System.EventArgs) Handles PBJobCat.Click
        Dim x As New FrmJobCategory
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBMotivation_Click(sender As System.Object, e As System.EventArgs) Handles PBMotivation.Click
        Dim x As New FrmMotivationPunishmentType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBPresonalVact_Click(sender As System.Object, e As System.EventArgs) Handles PBPresonalVact.Click
        Dim x As New FrmYearlyVacations
        x.ShowDialog()
        x.Dispose()

    End Sub

    Private Sub PBTask_Click(sender As System.Object, e As System.EventArgs) Handles PBTask.Click
        Dim x As New FrmTask
        x.ShowDialog()
        x.Dispose()

    End Sub

 
    Private Sub PBType_Click(sender As System.Object, e As System.EventArgs) Handles PBType.Click
        Dim x As New FrmType
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Dim x As New FrmJobDescription
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBJobsPerDep_Click(sender As System.Object, e As System.EventArgs) Handles PBJobsPerDep.Click
        Dim x As New FrmAssigndDepsToJob
        x.FromHome = True
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBLeavePermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLeavePermission.Click
        Dim x As New FrmLeavePermission
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBPermissions.Click
        Dim x As New FrmUserList

        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBPersonalVacApproval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBHolidays.Click
        Dim x As New FrmHolidays
        x.TextBox1.Text = Date.Now.Year
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBSickVacApproval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim x As New FrmSickVactApproval
        'x.ShowDialog()
    End Sub

    Private Sub PBLeavePermissionApproval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLeavePermissionApproval.Click
        Dim x As New FrmLeavePermApproval
        x.ShowDialog()
        x.Dispose()
    End Sub

   
    Private Sub PBCompanyProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCompanyProfile.Click
        Dim x As New FrmCompanyProfil
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBMotivationPunishment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMotivationPunishment.Click
        Dim x As New FrmMotivationPunishment
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBReqHoursForJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBReqHoursForJob.Click
        Dim x As New FrmReqHoursForJob
        x.ShowDialog()
        x.Dispose()
    End Sub


  

    Private Sub PBVacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBVacation.Click
        Dim x As New FrmVacations
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBPA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBPA.Click
        Dim x As New FrmPAforTrainee
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBTraineeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBTraineeList.Click
        Dim x As New FrmListofPAforTrainee
        x.ShowDialog()
        x.Dispose()
    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim x As New FrmAveragePAPerJobPerTask
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBEmployeeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEmployeeList.Click
        ' Dim x As New FrmApplicantList
        'x.statusId = EmployeeStatusId
        'x.AddPA = True
        'x.lblText.Text = "Employee List"
        'x.ShowDialog()
        'x.Dispose()
        Dim x As New FrmEmployeeList
        x.statusId = EmployeeStatusId
        x.ShowDialog()

    End Sub

    Private Sub PBEmployeePA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEmployeePA.Click
        Dim x As New FrmPAForEmployee
        x.ShowDialog()
        x.Dispose()
    End Sub



    Private Sub PBEmployeeVac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEmployeeVac.Click
        Dim x As New FrmEmployeeList
        x.statusId = EmployeeStatusId
        x.VacationHolidays = True
        x.lblText.Text = "Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub

  
    Private Sub PBEmployeeHolidays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmApplicantList
        x.statusId = EmployeeStatusId
        x.lblText.Text = "Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub


    Private Sub PbDashBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbDashBoard.Click
        Dim X As New FrmVactionsHolidaysDashBoard
        X.ShowDialog()
    End Sub

    Private Sub PBAssignYearlyVacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAssignYearlyVacation.Click
        Dim answer = MessageBox.Show("Assign Yearly Vacations?", "Assign", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)
                aMainor.AssignYearlyVacationsToEmployee(Date.Now)

            End Using
            Dim x As New frmAfterAssignYearlyVacToEmployee
            x.showDialog()
        Else
            'Me.Close()
        End If
    End Sub

 
    Private Sub PBRetiredList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBRetired.Click
        PanelHome.Controls.Clear()
        Dim X As New UCApplicantInfo
        X.Dock = DockStyle.Fill
        X.StatusId = RetiredStatusId
        PanelHome.Controls.Add(X)
    End Sub

    Private Sub PBRetiredEmpList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBRetiredEmpList.Click
        Dim x As New FrmEmployeeList
        x.statusId = RetiredStatusId
        x.lblText.Text = "Retired Employee List"
        x.ShowDialog()
        x.Dispose()
    End Sub

    Private Sub PBAvgPAPerTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAvgPAPerTask.Click

    End Sub


    Private Sub PBMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMonth.Click
        Dim x As New FrmMonths
        x.ShowDialog()

    End Sub


    Private Sub PBClassificationDegree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBClassificationDegree.Click
        Dim x As New frmClassificationDegreeTree
        x.ShowDialog()
    End Sub

    Private Sub PBYearCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBYearCalendar.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim Res = (From ax In aMainor.TblYears Where ax.Year = Date.Now.Year).ToList()
            If Not Res.Count > 0 Then
                Dim yr As New TblYear
                yr.Year = Date.Now.Year
                aMainor.TblYears.InsertOnSubmit(yr)
                aMainor.SubmitChanges()
            End If
            Dim yearId As Integer = (From ax In aMainor.TblYears Where ax.Year = Date.Now.Year Select ax.Id).ToList(0)
            Dim Cnt = (From ax In aMainor.TblMonthsPerYears Where ax.YearId = YearId).ToList.Count
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

    Private Sub PBSalariesHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSalariesHistory.Click
        Dim x As New FrmMonthSalary
        x.ShowDialog()
    End Sub

    Private Sub PBEmployeeSalaryList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEmployeeSalaryList.Click
        Dim x As New frmEmployeeSalaryList
        x.ShowDialog()
    End Sub


    Private Sub PBYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBYear.Click
        Dim x As New FrmYearList
        x.ShowDialog()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub PBComputerSettings_Click(sender As Object, e As EventArgs) Handles PBComputerSettings.Click
        Dim x As New FrmPCSettings
        x.ShowDialog()
    End Sub

End Class