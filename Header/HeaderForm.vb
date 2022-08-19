Imports Infragistics.Win
Imports Infragistics.Win.UltraWinToolbars

Public Class HeaderForm
    Dim counter As Integer = 1
    Dim counter2 As Integer = 1
    Dim counter3 As Integer = 1
    Dim counter4 As Integer = 1
    Dim Isloaded = False
    Public mypoint As Point
    Dim clickLoc As Point


    Private Sub HeaderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UltraToolbarsManager1.Appearance.BackColor = My.Settings.PanelColor
        Me.UltraToolbarsManager1.DockAreaAppearance.BackColor = My.Settings.PanelColor
        Me.UltraToolbarsManager1.DockAreaAppearance.BackColor2 = My.Settings.PanelColor
        Me.UltraToolbarsManager1.Ribbon.CaptionAreaActiveAppearance.BackColor = My.Settings.PanelColor





        Me.UltraToolbarsManager1.Ribbon.Visible = True
        Me.UltraToolbarsManager1.Office2007UICompatibility = False
        Me.UltraToolbarsManager1.Ribbon.FileMenuStyle = Infragistics.Win.UltraWinToolbars.FileMenuStyle.None
        ' Me.ShowIcon = False
        Me.UltraToolbarsManager1.AlwaysShowMenusExpanded = Infragistics.Win.DefaultableBoolean.True

        Me.BackColor = My.Settings.FormBackgroundColor
        StatusStrip1.BackColor = My.Settings.PanelColor

        PublicContainerPanel = Me.Panel4
        'MyOpenForm(New FrmInterface)
        'MyOpenForm(New FormPanel3)
        ' MyOpenForm(New FrmDockable)
        ' MyOpenForm(New FrmPanels)
        MyOpenForm(New Form6)

        Isloaded = True
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)


        cscreen = New Point((My.Computer.Screen.Bounds.Width - Me.Width) / 2, (My.Computer.Screen.Bounds.Height - Me.Height) / 2)
        '  Me.Location = cscreen
        applocation = New Point(0, 0)

        Using aMainor As New LqHRDataContext(cnx)
            Dim user = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.Username).ToList(0)
            lblUser.Text = " Logged in as " & " " & user
            ToolStripStatusLabel3.Text = " Logged in At" & " " & Today & " " & TimeOfDay
        End Using

    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key

            Case "PBCompanyProfile"
                Dim x As New FrmCompanyProfil
                x.ShowDialog()
                x.Dispose()
            Case "PBCurrencies"
                Dim x As New FrmCurrencyList
                x.ShowDialog()
                x.Dispose()
            Case "PBDepCat"
                Dim x As New FrmDepartmentCategory
                x.ShowDialog()
                x.Dispose()
            Case "PBDepType"
                Dim x As New FrmDepartmentType
                x.ShowDialog()
                x.Dispose()
            Case "PBDepartment"
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
            Case "PBCategory"
                Dim x As New FrmCategoryList
                x.ShowDialog()
                x.Dispose()
            Case "PBTask"
                Dim x As New FrmTask
                x.ShowDialog()
                x.Dispose()
            Case "PBCertificate"
                Dim x As New FrmCertificateList
                x.ShowDialog()
                x.Dispose()
            Case "PBMedicalIssues"
                Dim x As New FrmMedicalIssuesList
                x.ShowDialog()
                x.Dispose()
            Case "PBSalaryCategory"
                Dim x As New FrmSalaryCategories
                x.ShowDialog()
                x.Dispose()
            Case "PBPosition"
                Dim x As New FrmPositionList
                x.ShowDialog()
                x.Dispose()
            Case "PBSkills"
                Dim x As New FrmSkillsList
                x.ShowDialog()
                x.Dispose()
            Case "PBStatus"
                Dim x As New FrmStatusList
                x.ShowDialog()
                x.Dispose()
            Case "PBLectures"
                Dim x As New FrmLecturesList
                x.ShowDialog()
                x.Dispose()
            Case "PBBlood"
                Dim x As New FrmBlood
                x.ShowDialog()
                x.Dispose()
            Case "PBContractType"
                Dim x As New FrmContractType
                x.ShowDialog()
                x.Dispose()
            Case "PBJobCat"
                Dim x As New FrmJobCategory
                x.ShowDialog()
                x.Dispose()
            Case "PBMotivation"
                Dim x As New FrmMotivationPunishmentType
                x.ShowDialog()
                x.Dispose()
            Case "PBType"
                Dim x As New FrmType
                x.ShowDialog()
                x.Dispose()
            Case "PBReqHoursForJob"
                Dim x As New FrmReqHoursForJob
                x.ShowDialog()
                x.Dispose()


            Case "PBApplicant"
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
            Case "PBApplicantIndex"
                Dim x As New FrmApplicantIndex
                x.ShowDialog()
                x.Dispose()
            Case "PBTrainee"
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
            Case "PBPA"
                Dim x As New FrmPAforTrainee
                x.ShowDialog()
                x.Dispose()
            Case "PBTraineeList"
                Dim x As New FrmListofPAforTrainee
                x.ShowDialog()
                x.Dispose()
            Case "PBEmployee"
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
            Case "PBEmployeePA"
                Dim x As New FrmPAForEmployee
                x.ShowDialog()
                x.Dispose()
            Case "PBEmployeeList"
                Dim x As New FrmEmployeeList
                x.statusId = EmployeeStatusId
                x.ShowDialog()
            Case "PBRetiredList"
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
            Case "PBRetiredEmpList"
                Dim x As New FrmEmployeeList
                x.statusId = RetiredStatusId
                x.lblText.Text = "Retired Employee List"
                x.ShowDialog()
                x.Dispose()
            Case "PBUnEmployee"
                Dim x As New FrmUCUnEmployeeInfo
                x.TopLevel = False
                x.StatusId = UnemploymentStatusId
                x.Dock = DockStyle.Fill
                MyOpenForm(x)
                x.Show()
            Case "PBUnEmployeeList"
                Dim x As New FrmUnEmployeeList
                x.statusId = UnemploymentStatusId
                x.lblText.Text = "Un-Employee List"
                x.ShowDialog()
                x.Dispose()


            Case "PBJobsPerDep"
                Dim x As New FrmAssigndDepsToJob
                x.fromhome = True
                x.ShowDialog()
                x.Dispose()
            Case "PAPerTask"
                Dim x As New FrmAveragePAPerJobPerTask
                x.ShowDialog()
                x.Dispose()
            Case "JobDesc"
                Dim x As New FrmJobDescription
                x.ShowDialog()
                x.Dispose()
            Case "PBMotivationPunishment"
                Dim x As New FrmMotivationPunishment
                x.ShowDialog()
                x.Dispose()



            Case "PBPersonalVacApproval"
                Dim x As New FrmHolidays
                x.TextBox1.Text = Date.Now.Year
                x.ShowDialog()
                x.Dispose()
            Case "PBLeavePermission"
                Dim x As New FrmLeavePermission
                x.ShowDialog()
                x.Dispose()
            Case "PBLeavePermissionApproval"
                Dim x As New FrmLeavePermApproval
                x.ShowDialog()
                x.Dispose()
            Case "PBVacation"
                Dim x As New FrmVacations
                x.ShowDialog()
                x.Dispose()
            Case "PBPresonalVact"
                Dim x As New FrmYearlyVacations
                x.ShowDialog()
                x.Dispose()
            Case "PbDashBoard"
                Dim X As New FrmVactionsHolidaysDashBoard
                X.ShowDialog()
            Case "PBEmployeeVac"
                Dim x As New FrmEmployeeList
                x.statusId = EmployeeStatusId
                x.VacationHolidays = True
                x.lblText.Text = "Employee List"
                x.ShowDialog()
                x.Dispose()
            Case "PBAssignYearlyVacation"
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


            Case "PBMonth"
                Dim x As New FrmMonths
                x.ShowDialog()
            Case "PBYear"
                Dim x As New FrmYearList
                x.ShowDialog()
            Case "PBClassificationDegree"
                Dim x As New frmClassificationDegreeTree
                x.ShowDialog()
            Case "PBYearCalendar"
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
            Case "PBSalariesHistory"
                Dim x As New FrmMonthSalary
                x.ShowDialog()
            Case "PBEmployeeSalaryList"
                Dim x As New frmEmployeeSalaryList
                x.ShowDialog()



            Case "PBSettings"
                Dim x As New FrmSettings
                x.ShowDialog()
                x.Dispose()
            Case "PBPermissions"
                Dim x As New FrmUserList
                x.ShowDialog()
                x.Dispose()
            Case "PBPermissions2"
                Dim x As New FrmUserList
                x.ShowDialog()
                x.Dispose()
            Case "PBComputerSettings"
                Dim x As New FrmPCSettings
                x.ShowDialog()
                x.Dispose()

            Case "BtSettings"
                Dim x As New FrmPCSettings
                x.ShowDialog()

            Case "Exit"
                Me.Close()

                'Case "BlueTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Blue
                'Case "SilverTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Silver
                'Case "BlackTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Black

        End Select
    End Sub

    Private Sub HeaderForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)
        cscreen = New Point((My.Computer.Screen.Bounds.Width - Me.Width) / 2, (My.Computer.Screen.Bounds.Height - Me.Height) / 2)
        ' Me.Location = cscreen
        applocation = Me.Location
    End Sub

    Private Sub HeaderForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        applocation = Me.Location
    End Sub
End Class