Imports System.IO
Public Class UCApplicantInfo
  
    Public Id As Integer = 0
    Dim TraineeId As Integer = 0
    Dim EmployeeId As Integer = 0
    Public Saved As Boolean = False
    Public AddressId As Integer = 0
    Public Count As Integer
    Public KidsCount As Integer = 0
    Public ApplicantsList As List(Of Integer)
    Dim EditAttachachment As Boolean = False
    Dim deleteMotivationPunishmentList As New List(Of Integer)
    Dim deleteAddressList As New List(Of Integer)
    Dim deleteReqJobList As New List(Of Integer)
    Dim deleteAttachmentList As New List(Of Integer)
    Dim deleteWifeList As New List(Of Integer)
    Dim deleteEducationList As New List(Of Integer)
    Dim deleteLanguageList As New List(Of Integer)
    Dim deleteKidList As New List(Of Integer)
    Dim deleteExperienceList As New List(Of Integer)
    Dim deleteRelativeRefList As New List(Of Integer)
    Dim deleteWorkshopList As New List(Of Integer)
    Dim deleteTraineeLecturesList As New List(Of Integer)
    Dim deleteJobList As New List(Of Integer)
    Dim DeleteVacationList As New List(Of Integer)
    Dim DeleteleavePermissionList As New List(Of Integer)
    Public StatusId As Integer = 0
    Public ApplicantFiterList As New List(Of Integer)
    Public jobid As Integer = 0
    Dim selectedDate As Date
    Dim CanAssignHolidays As Boolean = False
    Public FilteredApplicantList As Boolean = False
    Public DontShowExitButton As Boolean = False
    Public FamilySalary As Integer = 0
    Public PicCanceled As Boolean = False
    Public currentEmployee As New TblEmployee


    Private Sub UCApplicantInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabControl1.TabPages.Remove(SalaryTabPage)

        Me.BackColor = My.Settings.FormBackgroundColor

        TabPage6.BackColor = My.Settings.PanelColor
        TabPage3.BackColor = My.Settings.PanelColor
        TabPage7.BackColor = My.Settings.PanelColor
        TabPage2.BackColor = My.Settings.PanelColor
        TabPage5.BackColor = My.Settings.PanelColor
        TabPage4.BackColor = My.Settings.PanelColor

        GroupBox13.BackColor = My.Settings.FormBackgroundColor
        GroupBox2.BackColor = My.Settings.FormBackgroundColor
        GroupBox6.BackColor = My.Settings.FormBackgroundColor
        GroupBox7.BackColor = My.Settings.FormBackgroundColor
        GroupBox3.BackColor = My.Settings.FormBackgroundColor
        GroupBox12.BackColor = My.Settings.FormBackgroundColor
        GroupBox9.BackColor = My.Settings.FormBackgroundColor
        GroupBox4.BackColor = My.Settings.FormBackgroundColor
        GroupBox10.BackColor = My.Settings.FormBackgroundColor
        GroupBox11.BackColor = My.Settings.FormBackgroundColor
        GroupBox5.BackColor = My.Settings.FormBackgroundColor
        GroupBox8.BackColor = My.Settings.FormBackgroundColor
        GroupBox15.BackColor = My.Settings.FormBackgroundColor
        GroupBox16.BackColor = My.Settings.FormBackgroundColor
        GroupBox18.BackColor = My.Settings.FormBackgroundColor
        GroupBox19.BackColor = My.Settings.FormBackgroundColor
        GroupBox22.BackColor = My.Settings.FormBackgroundColor
        GroupBox20.BackColor = My.Settings.FormBackgroundColor
        GroupBox17.BackColor = My.Settings.FormBackgroundColor
        GroupBox21.BackColor = My.Settings.FormBackgroundColor
        Panel45.BackColor = My.Settings.FormBackgroundColor

        BtnAssign.BackColor = My.Settings.PanelColor
        BtnAssignEmployee.BackColor = My.Settings.PanelColor
        'PBApplicantImage.BackColor = My.Settings.PanelColor
        PBApplicantImage.BackColor = My.Settings.FormBackgroundColor

        Panel1.BackColor = My.Settings.FormBackgroundColor
        Panel19.BackColor = My.Settings.PanelColor
        Panel21.BackColor = My.Settings.FormBackgroundColor
        Panel22.BackColor = My.Settings.FormBackgroundColor
        Panel23.BackColor = My.Settings.FormBackgroundColor


        Using aMainor As New LqHRDataContext(cnx)
            refreshApplicantList()
            Count = 0
            TblJobDescriptionBindingSource2.DataSource = aMainor.TblJobDescriptions.ToList
            TblBloodBindingSource.DataSource = aMainor.TblBloods.ToList
            TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList
            TblMedicalIssueBindingSource.DataSource = aMainor.TblMedicalIssues.ToList
            TblPositionBindingSource.DataSource = aMainor.TblPositions.ToList
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
            TblJobDescriptionBindingSource1.DataSource = aMainor.TblJobDescriptions.ToList
            TblDepartmentBindingSource1.DataSource = aMainor.TblDepartments.ToList
            TblContractTypeBindingSource.DataSource = aMainor.TblContractTypes.ToList
            TblCurrencyBindingSource1.DataSource = aMainor.TblCurrencies.ToList
            TblMotivationPunishmentTypeBindingSource.DataSource = aMainor.TblMotivationPunishmentTypes.ToList
            'TblVacationTypeBindingSource.DataSource = aMainOr.TblVacationTypes.ToList
            TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
            TblSkillBindingSource.DataSource = aMainor.TblSkills.ToList
            'TblVacationTypeBindingSource.DataSource = aMainOr.TblVacationTypes.ToList
            TblLectureBindingSource.DataSource = aMainor.TblLectures.ToList
            TblVacationBindingSource.DataSource = aMainor.TblVacations.ToList

            TblHolidayBindingSource.DataSource = aMainor.TblHolidays.ToList
            'TblEmployeeSalary2BindingSource.DataSource = aMainor.TblEmployeeSalary2s.ToList
            TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
            TblDepartmentBindingSource2.DataSource = aMainor.TblDepartments.ToList
            refreshApplicant()
            TblEducationDataGridView.Columns(3).DefaultCellStyle.Format = "yyyy"
            TblEducationDataGridView.Columns(4).DefaultCellStyle.Format = "yyyy"
            If DontShowExitButton = True Then
                PBExit.Visible = False
            Else
                PBExit.Visible = True
            End If



        End Using

    End Sub

    Function getStatus(ByVal id As Integer)
        Using aMainor As New LqHRDataContext(cnx)
            Dim statusName As String = (From ax In aMainor.TblStatus Where ax.Id = StatusId Select ax.Name).ToList(0)

            Return statusName
        End Using
    End Function

    Sub refreshApplicant()

        Using aMainor As New LqHRDataContext(cnx)
            If Id = 0 Then
                If Not ApplicantsList.Count = 0 Then
                    Id = ApplicantsList(Count)
                    refreshApplicant()
                End If
                'BtnAssign.Visible = False

            Else

                Dim res = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                TblApplicantBindingSource.DataSource = res
                MartialStatusComboBox.SelectedItem = res.MaritalStatus
                GenderComboBox.SelectedItem = res.Gender
                NationalityComboBox.SelectedItem = res.Nationality
                MohafazaComboBox.SelectedItem = res.Mohafaza
                KadaaComboBox.SelectedItem = res.Kadaa
                'BloodIdComboBox.SelectedValue = res.BloodId
                countriesCombo.SelectedItem = res.Country

                Dim kidsnb = (From ax In aMainor.TblFamilyMembers Where ax.ApplicantId = Id).ToList()
                TblApplicantBindingSource.Current.numberofkids = kidsnb.Count
                Dim OldApp = (From aX In aMainor.TblApplicants Where aX.Id = Id).ToList(0)
                OldApp.NumberOfKids = kidsnb.Count
                aMainor.SubmitChanges()
                StatusIdLabel1.Text = getStatus(StatusId)
                'StatusIdLabel1.Text = getStatus(TblApplicantBindingSource.Current.statusid)
                StatusIdLabel1.BackColor = Color.DodgerBlue

                refreshAddress()
                refreshEducation()
                refreshFamilyMember()
                refreshlanguages()
                refreshRelativeRef()
                refreshWifeHusband()
                refreshApplicantMedicalIssue()
                refreshExperienceHistory()
                refreshRequiredJob()
                refreshApplicantSkill()
                refreshAttachments()
                refreshWorkshop()
                refreshInvolvedLectures()
                refreshTrainee
                refreshJobs()
                RefreshEmployeePA()
                refreshEmployeeVacations()
                refreshEmployeeHolidays()
                refreshmotivationPunishment()
                RefreshLeavePermission()
                refreshPA()
                refreshSalary()
                refreshEmployeeSalariesList()


                If StatusId = ApplicantStatusId Then
                    BtnAssign.Visible = True
                    BtnAssign.Text = "Assign Trainee"
                    BtnAssignEmployee.Visible = True
                    BtnAssignEmployee.Text = "Assign employee"
                    Label22.Visible = False
                    DateLabel.Visible = False

                ElseIf StatusId = TraineeStatusId Then
                    BtnAssign.Visible = False

                    BtnAssignEmployee.Visible = True
                    BtnAssignEmployee.Text = "Assign Employee"
                    Label22.Visible = True
                    Label22.Text = "Training Date"
                    DateLabel.Visible = True
                    DateLabel.Text = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.StartDate).ToList(0)

                ElseIf StatusId = EmployeeStatusId Then
                    BtnAssign.Visible = True
                    BtnAssign.Text = "Assign Un-Employee"
                    BtnAssignEmployee.Visible = True
                    BtnAssignEmployee.Text = "Assign Retired"

                    Label22.Visible = True
                    Label22.Text = "Employment Date"
                    DateLabel.Visible = True


                    EmployeeId = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    DateLabel.Text = (From ax In aMainor.TblEmployeeJobs Where ax.EmployeeId = EmployeeId Select ax.DateOfEmployment).ToList(0)

                End If

            End If

            If StatusId = EmployeeStatusId Or StatusId = RetiredStatusId Or StatusId = UnemploymentStatusId Then
                PINTextBox.Visible = True
                PINLabel.Visible = True
                If Id > 0 Then
                    EmployeeId = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    PINTextBox.Text = (From ax In aMainor.TblEmployees Where ax.Id = EmployeeId Select ax.PIN).ToList(0)
                End If

            Else
                PINTextBox.Visible = False
                PINLabel.Visible = False
                Panel48.Visible = False
            End If
        End Using
    End Sub

    Sub RefreshEmployeePA()
        If StatusId = EmployeeStatusId Then
            If Id > 0 Then
                Using aMainor As New LqHRDataContext(cnx)
                    EmployeeId = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    AveragePAPerTaskForEmployeeResultBindingSource.DataSource = aMainor.AveragePAPerTaskForEmployee(EmployeeId).ToList
                    Dim res = (From ax In aMainor.TblEmployeePAs Where ax.EmployeeId = EmployeeId).ToList
                    If res.Count > 0 Then


                        For i = 0 To res.Count - 1
                            For j = 0 To AveragePAPerTaskForEmployeeResultBindingSource.Count - 1
                                If AveragePAPerTaskForEmployeeResultBindingSource(j).AvgPAPerTaskId = res(i).AveragePAPerTaskId Then
                                    AveragePAPerTaskForEmployeeResultBindingSource(j).ratio = res(i).Ratio
                                    AveragePAPerTaskForEmployeeResultBindingSource(j).note = res(i).Note

                                End If
                            Next
                        Next
                    End If

                End Using
            End If
        End If


    End Sub

    Sub refreshAddress()
        Using aMainor As New LqHRDataContext(cnx)
            TblAddressBindingSource.DataSource = (From ax In aMainor.TblAddresses Where ax.ApplicantId = Id).ToList()
        End Using
    End Sub

    Sub refreshInvolvedLectures()
        If StatusId = TraineeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblTraineeLectureBindingSource.DataSource = New TblTraineeLecture
                Else
                    TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblTraineeLectureBindingSource.DataSource = (From ax In aMainor.TblTraineeLectures Where ax.TraineeId = TraineeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub RefreshTrainee()
        If StatusId = TraineeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblTraineeBindingSource.DataSource = New TblTrainee
                Else
                    TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblTraineeBindingSource.DataSource = (From ax In aMainor.TblTrainees Where ax.Id = TraineeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub refreshPA()
        If StatusId = TraineeStatusId Then
            Using aMainor As New LqHRDataContext(cnx)
                TblPAForTraineerBindingSource.DataSource = aMainor.TblPAForTraineers.ToList
                If Id > 0 Then
                    TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.Id).ToList(0)

                    TblTraineePerformanceAppraisalBindingSource.DataSource = (From ax In aMainor.TblTraineePerformanceAppraisals Where ax.TrainneId = TraineeId Order By ax.PAforTraineeId).ToList

                End If
            End Using


            For i = 0 To TblPAForTraineerBindingSource.Count - 1
                Dim canAdd As Boolean = True
                For j = 0 To TblTraineePerformanceAppraisalBindingSource.Count - 1
                    If Not TblTraineePerformanceAppraisalBindingSource(j).PAforTraineeId = TblPAForTraineerBindingSource(i).id Then
                        canAdd = True
                    Else
                        canAdd = False
                        Exit For
                    End If
                Next
                If canAdd Then
                    Dim x As New TblTraineePerformanceAppraisal
                    x.PAforTraineeId = TblPAForTraineerBindingSource(i).id

                    TblTraineePerformanceAppraisalBindingSource.Add(x)
                End If

            Next


        End If
    End Sub

    Sub refreshJobs()
        If StatusId = EmployeeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblEmployeeJobBindingSource.DataSource = New TblEmployeeJob
                Else
                    Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblEmployeeJobBindingSource.DataSource = (From ax In aMainor.TblEmployeeJobs Where ax.EmployeeId = employeeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub refreshSalary()
        If StatusId = EmployeeStatusId Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.TblEmployeeSalaries Where ax.EmployeeId = EmployeeId).ToList
                If Id = 0 Then
                    TblEmployeeSalaryBindingSource.DataSource = New TblEmployeeSalary
                Else
                    If res.Count > 0 Then
                        Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                        TblEmployeeSalaryBindingSource.DataSource = res(0)
                    Else
                        TblEmployeeSalaryBindingSource.DataSource = New TblEmployeeSalary
                    End If

                End If
            End Using

        End If
    End Sub

    Sub refreshEmployeeVacations()
        If StatusId = EmployeeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblEmployeeVacationBindingSource.DataSource = New TblEmployeeVacation
                Else
                    Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblEmployeeVacationBindingSource.DataSource = (From ax In aMainor.TblEmployeeVacations Where ax.EmployeeId = employeeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub RefreshLeavePermission()
        If StatusId = EmployeeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblLeavePermissionBindingSource.DataSource = New TblLeavePermission
                Else
                    Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblLeavePermissionBindingSource.DataSource = (From ax In aMainor.TblLeavePermissions Where ax.EmployeeId = employeeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub refreshmotivationPunishment()
        If StatusId = EmployeeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblMotivationPunishmentBindingSource.DataSource = New TblMotivationPunishment
                Else
                    TblMotivationPunishmentBindingSource.Clear()
                    Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblMotivationPunishmentBindingSource.DataSource = (From ax In aMainor.TblMotivationPunishments Where ax.EmployeeId = employeeId).ToList()
                    '  TblMotivationPunishmentDataGridView.DataSource = TblMotivationPunishmentBindingSource.List

                End If
            End Using

        End If
    End Sub

    Sub refreshEmployeeHolidays()
        If StatusId = EmployeeStatusId Then

            Using aMainor As New LqHRDataContext(cnx)
                If Id = 0 Then
                    TblEmployeeHolidayBindingSource.DataSource = New TblEmployeeHoliday
                Else
                    Dim employeeId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    TblEmployeeHolidayBindingSource.DataSource = (From ax In aMainor.TblEmployeeHolidays Where ax.EmployeeId = employeeId).ToList()
                End If
            End Using

        End If
    End Sub

    Sub AddNew()
        Id = 0
        TblApplicantskillDataGridView.DataSource = Nothing
        TblApplicantMedicalIssueDataGridView.DataSource = Nothing
        DataGridViewSalary2.DataSource = Nothing
        TblEmployeeSalary2BindingSource.Clear()
        TblApplicantMedicalIssueBindingSource.Clear()
        TblApplicantSkillBindingSource.Clear()


        TblAddressBindingSource.DataSource = New TblAddress
        TblApplicantBindingSource.DataSource = New TblApplicant
        TblEducationBindingSource.DataSource = New TblEducation
        TblAttachmentBindingSource.DataSource = New TblAttachment
        'TblApplicantMedicalIssueBindingSource.DataSource = New TblApplicantMedicalIssue
        'TblApplicantSkillBindingSource.DataSource = New TblApplicantSkill
        TblFamilyMemberBindingSource.DataSource = New TblFamilyMember
        TblLanguageBindingSource.DataSource = New TblLanguage
        TblRelativeReferenceBindingSource.DataSource = New TblRelativeReference
        TblWifeHusbandBindingSource.DataSource = New TblWifeHusband
        TblWorkShopBindingSource.DataSource = New TblWorkShop
        TblLectureBindingSource.DataSource = New TblTraineeLecture
        TblTraineeBindingSource.DataSource = New TblTrainee
        TblEmployeeJobBindingSource.DataSource = New TblEmployeeJob
        TblEmployeeBindingSource.DataSource = New TblEmployee
        TblEmployeeSalaryBindingSource.DataSource = New TblEmployeeSalary
        TblEmployeeSalary2BindingSource.DataSource = New TblEmployeeSalary2

        TblAddressDataGridView.Rows.Clear()
        TblEducationDataGridView.Rows.Clear()
        TblExperienceHistoryDataGridView.Rows.Clear()
        TblTraineePerformanceAppraisalDataGridView.Rows.Clear()
        'TblVacationDataGridView.Rows.Clear()
        TblFamilyMemberDataGridView.Rows.Clear()
        TblLanguageDataGridView.Rows.Clear()
        TblEmployeeJobDataGridView.Rows.Clear()
        TblRelativeRefernceDataGridView.Rows.Clear()
        TblRequiredJobDataGridView.Rows.Clear()
        TblWifeHusbandDataGridView.Rows.Clear()
        TblAttachmentsDataGridView.Rows.Clear()
        TblLeavePermissionDataGridView.Rows.Clear()
        TblWorkshopDataGridView.Rows.Clear()
        TblTraineeLectureDataGridView.Rows.Clear()
        TblEmployeeJobDataGridView.Rows.Clear()
        TblEmployeeVacationDataGridView.Rows.Clear()
        TblEmployeeHolidayDataGridView.Rows.Clear()
        TblMotivationPunishmentDataGridView.Rows.Clear()
        TblTraineeLectureDataGridView.Rows.Clear()
        ' DataGridViewSalary2.Rows.Clear()

        AveragePAPerTaskForEmployeeResultDataGridView.Rows.Clear()
        EnableComponents(True)
        Using aMainor As New LqHRDataContext(cnx)
            Dim d As Double = Double.Parse(Today.ToString("yyyy"))
            Dim maxNb = (From aX In aMainor.TblApplicants Where Convert.ToString(aX.ApplicantNumber).StartsWith(Convert.ToString(d)) Select aX.ApplicantNumber).Max()

            If IsNothing(maxNb) Then
                TblApplicantBindingSource.Current.applicantNumber = d * 10000000 + 1
            Else
                TblApplicantBindingSource.Current.applicantNumber = maxNb + 1
            End If
            TblApplicantBindingSource.Current.applicationDate = Today
            TblApplicantBindingSource.Current.statusid = ApplicantStatusId
            'StatusIdLabel1.Text = getStatus(1)
            StatusIdLabel1.Text = getStatus(StatusId)
        End Using

        PBApplicantImage.Image = My.Resources.AddEmployee

        PBEdit.Visible = False
        PBAdd.Visible = False
        PBCancel.Visible = True
        PBSave.Visible = True
        BtnAssign.Visible = False
        BtnAssignEmployee.Visible = False
        GenderComboBox.SelectedIndex = -1
        MartialStatusComboBox.SelectedIndex = -1
        NationalityComboBox.SelectedIndex = -1
        MohafazaComboBox.SelectedIndex = -1
        KadaaComboBox.SelectedIndex = -1
        countriesCombo.SelectedIndex = -1

        refreshPA()
    End Sub

    Sub refreshWorkshop()
        Using aMainor As New LqHRDataContext(cnx)
            TblWorkShopBindingSource.DataSource = (From ax In aMainor.TblWorkShops Where ax.ApplicantId = Id).ToList()
        End Using
    End Sub

    Sub refreshAttachments()
        'Using aMainor As New LqHRDataContext(cnx)
        '    Dim r = (From ax In aMainor.TblAttachments Where ax.ApplicantId = Id).ToList()

        '    If r.Count > 0 Then

        '        TblAttachmentBindingSource.DataSource = (From aX In aMainor.TblAttachments Where aX.ApplicantId = Id).ToList()
        '        PBApplicantImage.BackgroundImageLayout = ImageLayout.Zoom
        '        ' If IsNothing(r.ToList(0).Attachmment) = False Then
        '        If r.ToList(0).Type = "Photography" Then

        '            Dim b As Byte() = r.ToList(0).Attachmment.ToArray()
        '            Dim ms As New IO.MemoryStream(b)
        '            Dim img As Image = Image.FromStream(ms)

        '            PBApplicantImage.BackgroundImage = img
        '        End If
        '    Else
        '        TblAttachmentBindingSource.DataSource = New TblAttachment
        '        PBApplicantImage.BackgroundImage = My.Resources.AddEmployee
        '        'TblAttachmentsDataGridView.Rows.Clear()
        '    End If

        'End Using
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = (From ax In aMainor.TblAttachments Where ax.ApplicantId = Id).ToList()
            TblAttachmentBindingSource.DataSource = (From aX In aMainor.TblAttachments Where aX.ApplicantId = Id).ToList()

            If r.Count > 0 Then

                ' If IsNothing(r.ToList(0).Attachmment) = False Then
                For i As Integer = 0 To r.Count - 1
                    If r.ToList(i).Type = "Photography" Then

                        Dim b As Byte() = r.ToList(i).Attachmment.ToArray()
                        Dim ms As New IO.MemoryStream(b)
                        Dim img As Image = Image.FromStream(ms)

                        PBApplicantImage.Image = img

                    End If
                Next

            Else
                'TblAttachmentBindingSource.DataSource = New TblAttachment
                PBApplicantImage.Image = My.Resources.AddEmployee


            End If
        End Using
    End Sub

    Sub refreshEducation()
        Using aMainor As New LqHRDataContext(cnx)
            TblEducationBindingSource.DataSource = (From ax In aMainor.TblEducations Where ax.ApplicantId = Id).ToList()
        End Using
    End Sub

    Sub refreshExperienceHistory()
        Using aMainor As New LqHRDataContext(cnx)
            TblExperienceHistoryBindingSource.DataSource = (From ax In aMainor.TblExperienceHistories Where ax.ApplicantId = Id).ToList()
        End Using
    End Sub

    Sub refreshRequiredJob()
        Using aMainor As New LqHRDataContext(cnx)
            TblRequiredJobBindingSource.DataSource = (From ax In aMainor.TblRequiredJobs Where ax.ApplicantId = Id).ToList()
        End Using
    End Sub

    Sub refreshFamilyMember()
        Using aMainor As New LqHRDataContext(cnx)
            If Id = 0 Then
                TblFamilyMemberBindingSource.DataSource = New TblFamilyMember
            Else
                TblFamilyMemberBindingSource.DataSource = (From ax In aMainor.TblFamilyMembers Where ax.ApplicantId = Id).ToList()
            End If
        End Using
    End Sub

    Sub refreshlanguages()
        Using aMainor As New LqHRDataContext(cnx)
            If Id = 0 Then
                TblLanguageBindingSource.DataSource = New TblLanguage
            Else
                TblLanguageBindingSource.DataSource = (From ax In aMainor.TblLanguages Where ax.ApplicantId = Id).ToList()
            End If
        End Using
    End Sub

    Sub refreshRelativeRef()
        Using aMainor As New LqHRDataContext(cnx)
            If Id = 0 Then
                TblRelativeReferenceBindingSource.DataSource = New TblRelativeReference
            Else
                TblRelativeReferenceBindingSource.DataSource = (From ax In aMainor.TblRelativeReferences Where ax.ApplicantId = Id).ToList()
            End If
        End Using
    End Sub

    Sub refreshApplicantMedicalIssue()

        Using aMainor As New LqHRDataContext(cnx)
            TblApplicantMedicalIssueBindingSource.DataSource = (From ax In aMainor.TblApplicantMedicalIssues Where ax.ApplicantId = Id).ToList()
            TblApplicantMedicalIssueDataGridView.DataSource = TblApplicantMedicalIssueBindingSource.List
        End Using

    End Sub

    Sub refreshEmployeeSalariesList()

        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeSalary2BindingSource.DataSource = (From ax In aMainor.TblEmployeeSalary2s Where ax.EmployeeID = EmployeeId).ToList()
            DataGridViewSalary2.DataSource = TblEmployeeSalary2BindingSource.List
        End Using

    End Sub

    Sub refreshApplicantSkill()

        Using aMainor As New LqHRDataContext(cnx)
            TblApplicantSkillBindingSource.DataSource = (From ax In aMainor.TblApplicantSkills Where ax.ApplicantId = Id).ToList()
            TblApplicantskillDataGridView.DataSource = TblApplicantSkillBindingSource.List
        End Using

    End Sub

    Sub refreshWifeHusband()
        If Id = 0 Then
            'TblWifeHusbandBindingSource.DataSource = New TblWifeHusband
        Else

            Using aMainor As New LqHRDataContext(cnx)
                TblWifeHusbandBindingSource.DataSource = (From ax In aMainor.TblWifeHusbands Where ax.ApplicantId = Id).ToList()
                'Dim c = (From ax In aMainor.TblWifeHusbands Where ax.ApplicantId = Id).ToList().Count
                'If c = 0 Then
                '    TblWifeHusbandBindingSource.DataSource = New TblWifeHusband
                'End If


            End Using
        End If
    End Sub

    Sub refreshApplicantList()
        Using aMainor As New LqHRDataContext(cnx)
            If Not FilteredApplicantList Then
                ApplicantsList = (From ax In aMainor.TblApplicants Where ax.StatusId = StatusId Order By ax.Id Select ax.Id).ToList()
            End If

            If Not ApplicantsList.Count = 0 Then
                If Id = 0 Then
                    Id = ApplicantsList(0)
                End If
            Else
                AddNew()
            End If

            If Not StatusId = TraineeStatusId Then
                TabControl1.TabPages.Remove(LecturesTabPage)
                TabControl1.TabPages.Remove(PATabPage)
            Else
                If Not TabControl1.TabPages.Contains(LecturesTabPage) Then
                    TabControl1.TabPages.Insert(6, LecturesTabPage)
                End If
                If Not TabControl1.TabPages.Contains(PATabPage) Then
                    TabControl1.TabPages.Insert(7, PATabPage)
                End If

            End If

            If Not StatusId = EmployeeStatusId Then
                TabControl1.TabPages.Remove(JobsTabPage)
                TabControl1.TabPages.Remove(EmployeePATabPage)
                TabControl1.TabPages.Remove(VacHolidaysTabPage)
                TabControl1.TabPages.Remove(SalaryTabPage)
                TabControl1.TabPages.Remove(Salary2)
            Else
                If Not TabControl1.TabPages.Contains(JobsTabPage) Then
                    TabControl1.TabPages.Insert(6, JobsTabPage)
                End If


                If Not TabControl1.TabPages.Contains(VacHolidaysTabPage) Then
                    TabControl1.TabPages.Insert(7, VacHolidaysTabPage)

                End If
                If Not TabControl1.TabPages.Contains(EmployeePATabPage) Then
                    TabControl1.TabPages.Insert(8, EmployeePATabPage)
                End If

                'If Not TabControl1.TabPages.Contains(SalaryTabPage) Then
                '    TabControl1.TabPages.Insert(9, SalaryTabPage)
                'End If

                If Not TabControl1.TabPages.Contains(Salary2) Then
                    TabControl1.TabPages.Insert(9, Salary2)
                End If
            End If

        End Using

    End Sub

    Sub EnableComponents(ByVal enable As Boolean)
        FirstNameTextBox.Enabled = enable
        MiddleNameTextBox.Enabled = enable
        LastNameTextBox.Enabled = enable
        MotherNameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        DepComboBox.Enabled = enable
        NationalityComboBox.Enabled = enable
        MartialStatusComboBox.Enabled = enable
        DateOfBirthDateTimePicker.Enabled = enable
        PlaceOfBirthTextBox.Enabled = enable
        RecordNumberTextBox.Enabled = enable
        PINTextBox.Enabled = enable
        RecordPlaceTextBox.Enabled = enable
        MohafazaComboBox.Enabled = enable
        KadaaComboBox.Enabled = enable
        BloodIdComboBox.Enabled = enable
        MobileTextBox.Enabled = enable
        PhoneNumberTextBox.Enabled = enable
        TextBoxAge.Enabled = enable
        countriesCombo.Enabled = enable

        BasicSalaryTextBox.Enabled = enable
        CurrencyIdComboBox.Enabled = enable
        FamilySalaryTextBox.Enabled = enable
        FamilySalaryTextBox.Enabled = enable
        NoteTextBox.Enabled = enable
        ExperienceInTextBox.Enabled = enable
        ExperienceOutTextBox.Enabled = enable
        PositionValueTextBox.Enabled = enable
        ClosedAreaTextBox.Enabled = enable
        OvertimeValueTextBox.Enabled = enable
        TransPerDayTextBox.Enabled = enable
        AccountNumberTextBox.Enabled = enable
        IsCashCheckBox.Enabled = enable
        NSSFSalaryTextBox.Enabled = enable

        BtnNewAddress.Enabled = enable
        BtnNewEducation.Enabled = enable
        BtnNewLeavePermission.Enabled = enable
        BtnNewLanguage.Enabled = enable

        BtnNewJob.Enabled = enable
        BtnAddMotivation.Enabled = enable
        PBAddFamilyMember.Enabled = enable
        NumberOfKidsTextBox.Enabled = enable
        PBApplicantImage.Enabled = enable
        BtnNewAttachment.Enabled = enable
        BtnAddNewVacation.Enabled = enable
        BtnNewWife.Enabled = enable
        BtnNewRequiredJob.Enabled = enable
        BtnNewWorkExperience.Enabled = enable
        BtAddSalaryCat.Enabled = enable
        BtnCaancel.Enabled = enable
        BtnNewRef.Enabled = enable
        BtnNewWorkshop.Enabled = enable

        If TblApplicantMedicalIssueDataGridView.RowCount > 0 Then
            BtnNewMedicalIssue.Enabled = False
        Else
            BtnNewMedicalIssue.Enabled = enable
        End If

        If TblTraineeLectureDataGridView.RowCount > 0 Then
            BtnNewInvolvedLectures.Enabled = False
        Else
            BtnNewInvolvedLectures.Enabled = enable
        End If

        If TblApplicantskillDataGridView.RowCount > 0 Then
            BtnNewSkill.Enabled = False
        Else
            BtnNewSkill.Enabled = enable
        End If

        TblWorkshopDataGridView.Enabled = enable
        TblRelativeRefernceDataGridView.Enabled = enable
        TblApplicantMedicalIssueDataGridView.Enabled = enable
        TblTraineeLectureDataGridView.Enabled = enable
        TblLanguageDataGridView.Enabled = enable
        TblEmployeeJobDataGridView.Enabled = enable
        TblEducationDataGridView.Enabled = enable
        TblAddressDataGridView.Enabled = enable
        TblApplicantskillDataGridView.Enabled = enable
        TblRequiredJobDataGridView.Enabled = enable
        TblWifeHusbandDataGridView.Enabled = enable
        TblExperienceHistoryDataGridView.Enabled = enable
        TblTraineePerformanceAppraisalDataGridView.Enabled = enable
        TblFamilyMemberDataGridView.Enabled = enable
        TblEmployeeVacationDataGridView.Enabled = enable
        TblAttachmentsDataGridView.Enabled = enable
        TblLeavePermissionDataGridView.Enabled = enable
        AveragePAPerTaskForEmployeeResultDataGridView.Enabled = enable
        TblMotivationPunishmentDataGridView.Enabled = enable
        DataGridViewSalary2.Enabled = enable

    End Sub

    Sub AddAttachment(ByVal type As String)

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'PBApplicantImage.Image = Image.FromFile(OpenFileDialog1.FileName)

            If Not OpenFileDialog1.FileName = String.Empty Then
                Dim fi As New FileInfo(OpenFileDialog1.FileName)
                Dim fr As Stream = fi.OpenRead
                Dim nbytes As Integer = fi.Length
                Dim bytearray(nbytes) As Byte
                fr.Read(bytearray, 0, nbytes)
                fr.Close()

                'TblAttachmentBindingSource.Current.attachmment = bytearray
                If EditAttachachment Then
                    TblAttachmentBindingSource.Current.attachmment = bytearray
                    If type = "Photography" Then
                        PBApplicantImage.Image = Image.FromFile(OpenFileDialog1.FileName)
                    End If
                Else
                    Dim X As New TblAttachment
                    X.Attachmment = bytearray
                    X.Type = type
                    X.Name = LastNameTextBox.Text + "_" + X.Type
                    X.UploadedDate = Today
                    TblAttachmentBindingSource.Add(X)
                End If

                EditAttachachment = False


            End If

        End If
    End Sub

    Private Sub PBApplicantImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBApplicantImage.Click
        AddAttachment("Photography")

        If Not OpenFileDialog1.FileName = "OpenFileDialog1" And Not OpenFileDialog1.FileName = String.Empty Then
            Dim image As Image = Image.FromFile(OpenFileDialog1.FileName)
            PBApplicantImage.Image = image

            For i As Integer = 0 To TblAttachmentBindingSource.Count - 1
                If TblAttachmentBindingSource(i).type = "Photography" Then

                    If TblAttachmentBindingSource(i).id > 0 Then
                        deleteAttachmentList.Add(TblAttachmentBindingSource(i).id)
                        TblAttachmentBindingSource.RemoveAt(i)
                        i += 1
                    Else
                        TblAttachmentBindingSource.RemoveAt(i)
                    End If

                End If
            Next
        End If

    End Sub

    Private Sub MartialStatusComboBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MartialStatusComboBox.TextChanged
        If MartialStatusComboBox.Text = "Married" Or MartialStatusComboBox.Text = "Divorced" Or MartialStatusComboBox.Text = "Widowed" Then
            TabPage3.Enabled = True
        Else
            TblWifeHusbandBindingSource.Clear()
            TblFamilyMemberBindingSource.Clear()

            TabPage3.Enabled = False
            FindFamilySalary()

        End If

    End Sub

    Private Sub PBAddFamilyMember_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBAddFamilyMember.Click

        Dim value As Integer = Convert.ToInt32(NumberOfKidsTextBox.Text)
        Id = TblApplicantBindingSource.Current.id

        If KidsCount > 0 Then
            value = KidsCount
        End If

        For i As Integer = 0 To value - 1

            Dim o As New FrmFamilyMember
            o.ApplicantId = Id
            If GenderComboBox.Text = "Male" Then
                o.ApplicantFName = FirstNameTextBox.Text
                o.ApplicantLName = LastNameTextBox.Text
            End If

            value -= value
            o.DateOfBirth = DateOfBirthDateTimePicker.Value
            'If i = value - 1 Then
            '    o.BtnSave.Text = "Save"
            'Else
            '    o.BtnSave.Text = "Next"
            'End If
            o.ShowDialog()
            If o.Saved Then
                TblFamilyMemberBindingSource.Add(o.current)

            End If
        Next
        FindFamilySalary()



        'refreshFamilyMember()

        Dim t = Convert.ToInt32(NumberOfKidsTextBox.Text)
        Using aMainor As New LqHRDataContext(cnx)
            'Dim nbOfKids As Integer = (From aX In aMainOr.TblApplicants Where aX.Id = Id Select aX.NumberOfKids).ToList(0)
            Dim nbOfKids As Integer = TblFamilyMemberBindingSource.List.Count
            KidsCount = t - nbOfKids
            If KidsCount > 0 Then
                PBAddFamilyMember.Visible = True
            Else
                PBAddFamilyMember.Visible = False
            End If
        End Using

    End Sub

    Private Sub NumberOfKidsTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NumberOfKidsTextBox.TextChanged

        Dim t As Integer
        If Not NumberOfKidsTextBox.Text = "" Then
            If Integer.TryParse(NumberOfKidsTextBox.Text, t) Then
                If t = 0 Then
                    PBAddFamilyMember.Visible = False
                Else
                    PBAddFamilyMember.Visible = True
                End If
                If Not Id = 0 Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim nbOfKids = (From aX In aMainor.TblApplicants Where aX.Id = Id Select aX.NumberOfKids).ToList()
                        If nbOfKids.Count > 0 Then

                            If nbOfKids.ToList(0) = t Then
                                PBAddFamilyMember.Visible = False
                            Else
                                KidsCount = t - nbOfKids.ToList(0)
                                If KidsCount > 0 Then
                                    PBAddFamilyMember.Visible = True
                                Else
                                    PBAddFamilyMember.Visible = False
                                End If

                            End If
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Please enter a valid number!")
                NumberOfKidsTextBox.Text = "0"
            End If
        Else
            PBAddFamilyMember.Visible = False
        End If
    End Sub

    Private Sub BtnNewAttachment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewAttachment.Click
        Dim x As New FrmAddAttachment
        x.ShowDialog()

        If x.saved Then
            AddAttachment(x.Type)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewEducation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewEducation.Click
        Dim x As New FrmEducationHistory
        x.applicantId = Id
        x.ShowDialog()
        If x.Saved Then
            TblEducationBindingSource.Add(x.current)

        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewAddress_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewAddress.Click
        Dim x As New FrmAddress
        x.ApplicantId = Id
        x.ShowDialog()
        If x.Saved Then
            TblAddressBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewWorkshop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewWorkshop.Click
        Dim x As New FrmWorkShop
        x.ApplicantId = Id
        x.ShowDialog()
        If x.Saved Then
            TblWorkShopBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewWife_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewWife.Click
        Dim x As New FrmWifeHusbandInfo
        x.ApplicantId = Id
        x.ShowDialog()
        Dim a As Integer = 0
        If x.Saved Then
            TblWifeHusbandBindingSource.Add(x.current)
            FindFamilySalary()
        End If
    End Sub

    Sub FindFamilySalary()
        FamilySalary = 0
        If TblWifeHusbandBindingSource.Count > 0 Then

            If TblWifeHusbandBindingSource(0).NSSFSide = "None" Then
                FamilySalary += 60
                'TblEmployeeSalaryBindingSource.Current.FamilySalary = FamilySalary
            End If
        End If


        Dim NbOfKidsAvailable As Integer = 5

        For i As Integer = 0 To TblFamilyMemberBindingSource.Count - 1
            If NbOfKidsAvailable > 0 Then
                If TblFamilyMemberBindingSource(i).gender = "Male" Then
                    Dim Age As Integer = DateDiff(DateInterval.Year, TblFamilyMemberBindingSource(i).DateOfBirth, Now)
                    If Age < 25 Then
                        NbOfKidsAvailable -= 1
                        FamilySalary += 33

                    End If
                Else
                    If Not TblFamilyMemberBindingSource(i).IsMarried = True Then
                        NbOfKidsAvailable -= 1
                        FamilySalary += 33
                    End If
                End If
            End If
        Next
        'TblEmployeeSalaryBindingSource.Current.FamilySalary = FamilySalary
    End Sub

    Private Sub BtnNewLanguage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewLanguage.Click
        Dim x As New FrmLanguages
        x.ApplicantId = Id
        x.ShowDialog()
        If x.Saved Then
            TblLanguageBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewRef_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewRef.Click
        Dim x As New FrmRelativeReferences
        x.Applicantgender = GenderComboBox.Text
        x.ShowDialog()
        If x.Saved Then
            TblRelativeReferenceBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewMedicalIssue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewMedicalIssue.Click
        Dim x As New FrmApplicantMedicalIssue
        x.ApplicantId = Id
        x.ShowDialog()
        If x.saved Then
            Using aMainor As New LqHRDataContext(cnx)
                TblMedicalIssueBindingSource.DataSource = aMainor.TblMedicalIssues.ToList
            End Using

            TblApplicantMedicalIssueBindingSource = x.current
            TblApplicantMedicalIssueDataGridView.DataSource = TblApplicantMedicalIssueBindingSource.List
        End If
    End Sub

    Private Sub BtAddSalaryCat_Click(sender As Object, e As EventArgs) Handles BtAddSalaryCat.Click
        'Dim x As New FrmEmployeeSalaries2
        'x.EmployeeId = Id
        'x.ShowDialog()
        'If x.saved Then
        '    Using aMainor As New LqHRDataContext(cnx)
        '        TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
        '    End Using

        '    TblEmployeeSalary2BindingSource = x.current
        '    DataGridViewSalary2.DataSource = TblEmployeeSalary2BindingSource.List
        'End If
        Dim x As New FrmEmployeeSalaries2
        If TblEmployeeSalary2BindingSource.Count > 0 Then
            ' If e.ColumnIndex = EditEmpSalary.Index Then


            Dim Id As Integer = TblEmployeeSalary2BindingSource.Current.EmployeeSalaryID


        End If
        x.current = TblEmployeeSalary2BindingSource
        x.EmployeeId = EmployeeId

        x.ForEdit = True
        x.ShowDialog()
        If x.saved Then

            DataGridViewSalary2.DataSource = Nothing
            Using aMainor As New LqHRDataContext(cnx)
                TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
            End Using

            DataGridViewSalary2.DataSource = TblEmployeeSalary2BindingSource.List

        End If

        x.Dispose()
        'End If
    End Sub

    Private Sub BtnNewSkill_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewSkill.Click
        Dim x As New FrmApplicantSkills
        x.ApplicantId = Id
        x.ShowDialog()
        If x.saved Then

            Using aMainor As New LqHRDataContext(cnx)
                TblSkillBindingSource.DataSource = aMainor.TblSkills.ToList
            End Using
            TblApplicantSkillBindingSource = x.current
            TblApplicantskillDataGridView.DataSource = TblApplicantSkillBindingSource.List
        End If


    End Sub

    Private Sub BtnNewWorkExperience_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewWorkExperience.Click
        Dim x As New FrmExperienceHistory

        x.dob = DateOfBirthDateTimePicker.Value
        x.ApplicantId = Id
        x.ShowDialog()
        If x.saved Then
            TblExperienceHistoryBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub BtnNewRequiredJob_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewRequiredJob.Click
        Dim x As New FrmRequiredJob
        x.ApplicantId = Id
        x.ShowDialog()
        If x.saved Then
            TblRequiredJobBindingSource.Add(x.current)
        End If

        x.Dispose()
    End Sub

    Private Sub PBFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBFirst.Click
        If ApplicantsList.Count > 0 Then


            Count = 0
            Id = ApplicantsList(Count)
            refreshApplicant()
        End If
    End Sub

    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBBack.Click
        If ApplicantsList.Count > 0 Then

            EnableComponents(False)

            If Count = 0 Then
                Count = ApplicantsList.Count
                Id = ApplicantsList(Count - 1)
                refreshApplicant()
            Else
                Count -= 1
                Id = ApplicantsList(Count)
                refreshApplicant()
            End If

        End If
    End Sub

    Private Sub BtnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBNext.Click
        If ApplicantsList.Count > 0 Then
            EnableComponents(False)
            Count += 1

            If Count = ApplicantsList.Count + 1 Or Count = ApplicantsList.Count Then
                Count = 0
                Id = ApplicantsList(Count)
                refreshApplicant()
            Else
                Id = ApplicantsList(Count)
                refreshApplicant()
            End If
        End If
    End Sub

    Private Sub PBLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBLast.Click
        If ApplicantsList.Count > 0 Then


            Count = ApplicantsList.Count
            Id = ApplicantsList(Count - 1)
            refreshApplicant()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBEdit.Click
        EnableComponents(True)
        PBEdit.Visible = False
        PBAdd.Visible = False
        PBCancel.Visible = True
        PBSave.Visible = True

        PBBack.Enabled = False
        PBNext.Enabled = False
        PBFirst.Enabled = False
        PBLast.Enabled = False
        PBExit.Enabled = False
        PBSearch.Enabled = False
    End Sub

    Private Sub BtnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBAdd.Click
        'Id = 0
        'TblApplicantskillDataGridView.DataSource = Nothing
        'TblApplicantMedicalIssueDataGridView.DataSource = Nothing

        'TblAddressBindingSource.DataSource = New TblAddress
        'TblApplicantBindingSource.DataSource = New TblApplicant
        'TblEducationBindingSource.DataSource = New TblEducation
        'TblAttachmentBindingSource.DataSource = New TblAttachment
        ''TblApplicantMedicalIssueBindingSource.DataSource = New TblApplicantMedicalIssue
        ''TblApplicantSkillBindingSource.DataSource = New TblApplicantSkill
        'TblFamilyMemberBindingSource.DataSource = New TblFamilyMember
        'TblLanguageBindingSource.DataSource = New TblLanguage
        'TblRelativeReferenceBindingSource.DataSource = New TblRelativeReference
        'TblWifeHusbandBindingSource.DataSource = New TblWifeHusband
        'TblWorkShopBindingSource.DataSource = New TblWorkShop

        'TblAddressDataGridView.Rows.Clear()
        'TblEducationDataGridView.Rows.Clear()
        'TblExperienceHistoryDataGridView.Rows.Clear()
        'TblFamilyMemberDataGridView.Rows.Clear()
        'TblLanguageDataGridView.Rows.Clear()
        'TblRelativeRefernceDataGridView.Rows.Clear()
        'TblRequiredJobDataGridView.Rows.Clear()
        'TblWifeHusbandDataGridView.Rows.Clear()
        'TblAttachmentsDataGridView.Rows.Clear()
        'TblWorkshopDataGridView.Rows.Clear()

        'EnableComponents(True)
        'Using aMainor As New LqHRDataContext(cnx)
        '    Dim d As Double = Double.Parse(Today.ToString("yyyy"))
        '    Dim maxNb = (From aX In aMainOr.TblApplicants Where Convert.ToString(aX.ApplicantNumber).StartsWith(Convert.ToString(d)) Select aX.ApplicantNumber).Max()

        '    If IsNothing(maxNb) Then
        '        TblApplicantBindingSource.Current.applicantNumber = d * 10000000 + 1
        '    Else
        '        TblApplicantBindingSource.Current.applicantNumber = maxNb + 1
        '    End If
        '    TblApplicantBindingSource.Current.applicationDate = Today
        '    TblApplicantBindingSource.Current.statusid = 1
        '    StatusIdLabel1.Text = getStatus(1)
        'End Using

        'PBApplicantImage.Image = My.Resources.AddEmployee

        'PBEdit.Visible = False
        'PBAdd.Visible = False
        'PBCancel.Visible = True
        'PBSave.Visible = True

        AddNew()


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBDelete.Click
        Dim answer
        If StatusId = ApplicantStatusId Then
            answer = MessageBox.Show("Are you sure you want to delete this applicant!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        ElseIf StatusId = EmployeeStatusId Then
            answer = MessageBox.Show("Are you sure you want to delete this employee!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Else
            answer = MessageBox.Show("Are you sure you want to delete this trainee!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        End If


        If answer = Windows.Forms.DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)

                ''''''''delete trainee '''''''''''''''

                Dim res = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)

                If res.TblEmployees.Count > 0 Then
                    MessageBox.Show("Employee cannot be deleted")
                Else

                    If res.TblTrainees.Count > 0 Then
                        Dim RES3 = (From ax In aMainor.TblTraineeLectures Where ax.TraineeId = TraineeId).ToList
                        If RES3.Count > 0 Then
                            aMainor.TblTraineeLectures.DeleteAllOnSubmit(RES3)
                            aMainor.SubmitChanges()
                        End If

                        Dim res4 = (From ax In aMainor.TblTraineePerformanceAppraisals Where ax.TrainneId = TraineeId).ToList
                        If res4.Count > 0 Then
                            aMainor.TblTraineePerformanceAppraisals.DeleteAllOnSubmit(res4)
                            aMainor.SubmitChanges()

                        End If

                        Dim res2 = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id).ToList
                        If res2.Count > 0 Then
                            aMainor.TblTrainees.DeleteAllOnSubmit(res2)
                            aMainor.SubmitChanges()
                        End If

                    End If

                    Dim attachments = (From aX In aMainor.TblAttachments Where aX.ApplicantId = Id).ToList
                    If attachments.Count > 0 Then
                        aMainor.TblAttachments.DeleteAllOnSubmit(attachments)
                        aMainor.SubmitChanges()
                    End If

                    Dim wife = (From aX In aMainor.TblWifeHusbands Where aX.ApplicantId = Id).ToList
                    If wife.Count > 0 Then
                        aMainor.TblWifeHusbands.DeleteAllOnSubmit(wife)
                        aMainor.SubmitChanges()
                    End If

                    Dim kid = (From aX In aMainor.TblFamilyMembers Where aX.ApplicantId = Id).ToList
                    If kid.Count > 0 Then
                        aMainor.TblFamilyMembers.DeleteAllOnSubmit(kid)
                        aMainor.SubmitChanges()
                    End If

                    Dim address = (From aX In aMainor.TblAddresses Where aX.ApplicantId = Id).ToList
                    If address.Count > 0 Then
                        aMainor.TblAddresses.DeleteAllOnSubmit(address)
                        aMainor.SubmitChanges()
                    End If

                    Dim education = (From aX In aMainor.TblEducations Where aX.ApplicantId = Id).ToList
                    If education.Count > 0 Then
                        aMainor.TblEducations.DeleteAllOnSubmit(education)
                        aMainor.SubmitChanges()
                    End If

                    Dim workshop = (From aX In aMainor.TblWorkShops Where aX.ApplicantId = Id).ToList
                    If workshop.Count > 0 Then
                        aMainor.TblWorkShops.DeleteAllOnSubmit(workshop)
                        aMainor.SubmitChanges()
                    End If

                    Dim MedicalIssue = (From aX In aMainor.TblApplicantMedicalIssues Where aX.ApplicantId = Id).ToList
                    If MedicalIssue.Count > 0 Then
                        aMainor.TblApplicantMedicalIssues.DeleteAllOnSubmit(MedicalIssue)
                        aMainor.SubmitChanges()
                    End If

                    'Dim EmployeeSalary = (From aX In aMainor.TblApplicantMedicalIssues Where aX.ApplicantId = Id).ToList
                    'If MedicalIssue.Count > 0 Then
                    '    aMainor.TblApplicantMedicalIssues.DeleteAllOnSubmit(MedicalIssue)
                    '    aMainor.SubmitChanges()
                    'End If

                    Dim skill = (From aX In aMainor.TblApplicantSkills Where aX.ApplicantId = Id).ToList
                    If skill.Count > 0 Then
                        aMainor.TblApplicantSkills.DeleteAllOnSubmit(skill)
                        aMainor.SubmitChanges()
                    End If

                    Dim exp = (From aX In aMainor.TblExperienceHistories Where aX.ApplicantId = Id).ToList
                    If exp.Count > 0 Then
                        aMainor.TblExperienceHistories.DeleteAllOnSubmit(exp)
                        aMainor.SubmitChanges()
                    End If

                    Dim reqJob = (From aX In aMainor.TblRequiredJobs Where aX.ApplicantId = Id).ToList
                    If reqJob.Count > 0 Then
                        aMainor.TblRequiredJobs.DeleteAllOnSubmit(reqJob)
                        aMainor.SubmitChanges()
                    End If

                    Dim lang = (From aX In aMainor.TblLanguages Where aX.ApplicantId = Id).ToList
                    If lang.Count > 0 Then
                        aMainor.TblLanguages.DeleteAllOnSubmit(lang)
                        aMainor.SubmitChanges()
                    End If

                    Dim relRef = (From aX In aMainor.TblRelativeReferences Where aX.ApplicantId = Id).ToList
                    If relRef.Count > 0 Then
                        aMainor.TblRelativeReferences.DeleteAllOnSubmit(relRef)
                        aMainor.SubmitChanges()
                    End If

                    Dim result = (From aX In aMainor.TblApplicants Where aX.Id = Id).ToList(0)
                    aMainor.TblApplicants.DeleteOnSubmit(result)
                    aMainor.SubmitChanges()
                    BtnNext_Click(sender, e)
                    refreshApplicantList()
                    If ApplicantsList.Count > 0 Then
                        refreshApplicant()
                        EnableComponents(False)
                    Else
                        AddNew()
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBSearch.Click
        If StatusId = ApplicantStatusId Then
            Dim x As New FrmApplicantList
            x.statusId = StatusId
            x.ShowDialog()
            Id = x.id
            Count = x.RowIndex
            refreshApplicant()
        ElseIf StatusId = TraineeStatusId Then
            Dim x As New FrmListofPAforTrainee
            x.CloseOnDoubleClick = True
            x.ShowDialog()
            Id = x.appId
            Count = x.RowIndex
            refreshApplicant()
        ElseIf StatusId = EmployeeStatusId Then
            Dim x As New FrmEmployeeList
            x.statusId = StatusId
            x.FromUC = True
            x.ShowDialog()
            Id = x.appId
            Count = x.RowIndex
            refreshApplicant()

        ElseIf StatusId = RetiredStatusId Then
            Dim x As New FrmEmployeeList
            x.statusId = StatusId
            x.FromUC = True
            x.ShowDialog()
            Id = x.appId
            Count = x.RowIndex
            refreshApplicant()


        ElseIf StatusId = UnemploymentStatusId Then
            Dim x As New FrmUnEmployeeList
            x.statusId = StatusId
            x.FromUC = True
            x.ShowDialog()
            Id = x.appId
            Count = x.RowIndex
            refreshApplicant()

        End If

        If StatusId = ApplicantStatusId Then
        ElseIf StatusId = EmployeeStatusId Then

        End If




    End Sub

    Private Sub PBCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBCancel.Click
        Dim answer = MessageBox.Show("Are you sure you want to cancel saving changes!", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            PBSave.Visible = False
            PBCancel.Visible = False
            PBEdit.Visible = True
            PBAdd.Visible = True

            PBBack.Enabled = True
            PBNext.Enabled = True
            PBFirst.Enabled = True
            PBLast.Enabled = True
            PBExit.Enabled = True
            PBSearch.Enabled = True

            EnableComponents(False)
            refreshApplicant()

            deleteAttachmentList.Clear()
            deleteEducationList.Clear()
            deleteExperienceList.Clear()
            deleteLanguageList.Clear()
            deleteRelativeRefList.Clear()
            deleteReqJobList.Clear()
            deleteWifeList.Clear()
            deleteAddressList.Clear()
            deleteKidList.Clear()
            deleteWorkshopList.Clear()
        End If
    End Sub

    Private Sub TblApplicantskillDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblApplicantskillDataGridView.CellContentClick

        If TblApplicantSkillBindingSource.Count > 0 Then

            If e.ColumnIndex = EditSkill.Index Then
                Dim v As New BindingSource
                v = TblApplicantSkillBindingSource

                Dim Id As Integer = TblApplicantSkillBindingSource.Current.Id

                Dim x As New FrmApplicantSkills
                x.current = v
                x.ApplicantId = TblApplicantSkillBindingSource.Current.ApplicantId

                x.ForEdit = True
                x.ShowDialog()
                If x.saved Then

                    TblApplicantskillDataGridView.DataSource = Nothing
                    Using aMainor As New LqHRDataContext(cnx)
                        TblSkillBindingSource.DataSource = aMainor.TblSkills.ToList
                    End Using

                    TblApplicantskillDataGridView.DataSource = v.List

                End If

                x.Dispose()
            End If
        End If

        'If e.ColumnIndex = DeleteSkill.Index Then
        '    Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        '    If answer = Windows.Forms.DialogResult.Yes Then
        '   Using aMainor As New LqHRDataContext(cnx)
        '            Dim Id As Integer = TblApplicantSkillBindingSource.Current.id
        '            If Id = 0 Then
        '                TblApplicantSkillBindingSource.RemoveCurrent()
        '            Else
        '                'TblApplicantSkillBindingSource.RemoveCurrent()
        '                Dim result = (From aX In aMainOR.TblApplicantSkills Where aX.Id = Id).ToList(0)

        '                aMainOR.TblApplicantSkills.DeleteOnSubmit(result)
        '                aMainOR.SubmitChanges()
        '                refreshApplicantSkill()
        '            End If
        '            TblApplicantskillDataGridView.DataSource = TblApplicantSkillBindingSource.List
        '        End Using
        '    End If

        'End If

    End Sub

    Private Sub TblApplicantMedicalIssueDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblApplicantMedicalIssueDataGridView.CellContentClick

        If TblApplicantMedicalIssueBindingSource.Count > 0 Then
            If e.ColumnIndex = EditMedicalIssue.Index Then
                Dim v As New BindingSource
                v = TblApplicantMedicalIssueBindingSource

                Dim Id As Integer = TblApplicantMedicalIssueBindingSource.Current.Id

                Dim x As New FrmApplicantMedicalIssue
                x.current = v
                x.ApplicantId = TblApplicantMedicalIssueBindingSource.Current.ApplicantId

                x.ForEdit = True
                x.ShowDialog()
                If x.saved Then

                    TblApplicantMedicalIssueDataGridView.DataSource = Nothing
                    Using aMainor As New LqHRDataContext(cnx)
                        TblMedicalIssueBindingSource.DataSource = aMainor.TblMedicalIssues.ToList
                    End Using

                    TblApplicantMedicalIssueDataGridView.DataSource = v.List

                End If

                x.Dispose()
            End If
        End If

        'If e.ColumnIndex = DeleteMedicalIssue.Index Then
        '    Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        '    If answer = Windows.Forms.DialogResult.Yes Then
        '   Using aMainor As New LqHRDataContext(cnx)
        '            Dim Id As Integer = TblApplicantMedicalIssueBindingSource.Current.id
        '            If Id = 0 Then
        '                TblApplicantMedicalIssueBindingSource.RemoveCurrent()

        '                TblMedicalIssueBindingSource.DataSource = aMainOr.TblMedicalIssues.ToList

        '            Else
        '                'TblApplicantMedicalIssueBindingSource.RemoveCurrent()
        '                Dim result = (From aX In aMainOR.TblApplicantMedicalIssues Where aX.Id = Id).ToList(0)

        '                aMainOR.TblApplicantMedicalIssues.DeleteOnSubmit(result)
        '                aMainOR.SubmitChanges()
        '                refreshApplicantMedicalIssue()
        '            End If

        '            TblApplicantMedicalIssueDataGridView.DataSource = TblApplicantMedicalIssueBindingSource.List
        '        End Using
        '    End If

        'End If


    End Sub

    Private Sub DataGridViewSalary2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSalary2.CellContentClick

        If TblEmployeeSalary2BindingSource.Count > 0 Then
            If e.ColumnIndex = EditEmpSalary.Index Then

                Dim v As New BindingSource
                v = TblEmployeeSalary2BindingSource

                Dim Id As Integer = TblEmployeeSalary2BindingSource.Current.EmployeeSalaryID

                Dim x As New FrmEmployeeSalaries2
                x.current = v
                x.EmployeeId = TblEmployeeSalary2BindingSource.Current.EmployeeID

                x.ForEdit = True
                x.ShowDialog()
                If x.saved Then

                    DataGridViewSalary2.DataSource = Nothing
                    Using aMainor As New LqHRDataContext(cnx)
                        TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
                    End Using

                    DataGridViewSalary2.DataSource = v.List

                End If

                x.Dispose()
            End If
        End If

        'If e.ColumnIndex = DeleteMedicalIssue.Index Then
        '    Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        '    If answer = Windows.Forms.DialogResult.Yes Then
        '   Using aMainor As New LqHRDataContext(cnx)
        '            Dim Id As Integer = TblApplicantMedicalIssueBindingSource.Current.id
        '            If Id = 0 Then
        '                TblApplicantMedicalIssueBindingSource.RemoveCurrent()

        '                TblMedicalIssueBindingSource.DataSource = aMainOr.TblMedicalIssues.ToList

        '            Else
        '                'TblApplicantMedicalIssueBindingSource.RemoveCurrent()
        '                Dim result = (From aX In aMainOR.TblApplicantMedicalIssues Where aX.Id = Id).ToList(0)

        '                aMainOR.TblApplicantMedicalIssues.DeleteOnSubmit(result)
        '                aMainOR.SubmitChanges()
        '                refreshApplicantMedicalIssue()
        '            End If

        '            TblApplicantMedicalIssueDataGridView.DataSource = TblApplicantMedicalIssueBindingSource.List
        '        End Using
        '    End If

        'End If

    End Sub

    Private Sub TblAddressDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblAddressDataGridView.CellContentClick
        If TblAddressBindingSource.Count > 0 Then
            If e.ColumnIndex = EditAddress.Index Then

                Dim v As New TblAddress
                v = TblAddressBindingSource.Current

                Dim r As New TblAddress
                r.ApplicantId = v.ApplicantId
                r.Building = v.Building
                r.City_Town = v.City_Town
                r.District = v.District
                r.Floor = v.Floor
                r.Id = v.Id
                r.Near = v.Near
                r.PropertyType = v.PropertyType
                r.Street = v.Street

                Dim Id As Integer = TblAddressBindingSource.Current.Id

                Dim x As New FrmAddress
                x.current = r
                x.ForEdit = True
                x.Id = Id

                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.Building = r.Building
                    v.City_Town = r.City_Town
                    v.District = r.District
                    v.Floor = r.Floor
                    v.Id = r.Id
                    v.Near = r.Near
                    v.PropertyType = r.PropertyType
                    v.Street = r.Street
                End If

                x.Dispose()
            End If


            If e.ColumnIndex = DeleteAddress.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblAddressBindingSource.Current.id
                        TblAddressBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteAddressList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblAddresses Where aX.Id = Id).ToList(0)
                            'aMainOR.TblAddresses.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshAddress()
                        End If
                    End Using
                End If
            End If
        End If

    End Sub

    Private Sub TblWorkshopDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblWorkshopDataGridView.CellContentClick
        If TblWorkShopBindingSource.Count > 0 Then
            If e.ColumnIndex = EditWorkshop.Index Then

                Dim v As New TblWorkShop
                v = TblWorkShopBindingSource.Current

                Dim r As New TblWorkShop
                r.ApplicantId = v.ApplicantId
                r.Date = v.Date
                r.Name = v.Name
                r.Organization = v.Organization
                r.Place = v.Place

                Dim Id As Integer = TblWorkShopBindingSource.Current.Id

                Dim x As New FrmWorkShop
                x.current = r
                x.ForEdit = True
                x.Id = Id

                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.Date = r.Date
                    v.Name = r.Name
                    v.Organization = r.Organization
                    v.Place = r.Place
                End If

                x.Dispose()
            End If

            If e.ColumnIndex = DeleteWorkshop.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblWorkShopBindingSource.Current.id
                        TblWorkShopBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteWorkshopList.Add(Id)
                        End If
                    End Using
                End If
            End If
        End If
    End Sub

    Private Sub TblAttachmentsDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblAttachmentsDataGridView.CellContentClick
        If TblAttachmentBindingSource.Count > 0 Then
            If e.ColumnIndex = EditAttach.Index Then

                Dim v As New TblAttachment
                v = TblAttachmentBindingSource.Current

                Dim r As New TblAttachment
                r.ApplicantId = v.ApplicantId
                r.Attachmment = v.Attachmment
                r.ExpiryDate = v.ExpiryDate
                r.Name = v.Name
                r.Type = v.Type

                Dim Id As Integer = TblAttachmentBindingSource.Current.Id
                Dim type As String = TblAttachmentBindingSource.Current.type

                EditAttachachment = True
                AddAttachment(type)

            End If

            If e.ColumnIndex = DeleteAttach.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblAttachmentBindingSource.Current.id
                        TblAttachmentBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteAttachmentList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblAttachments Where aX.Id = Id).ToList(0)
                            'aMainOR.TblAttachments.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshAttachments()
                        End If
                    End Using
                End If

            End If
            If e.ColumnIndex = Show.Index Then
                Dim AttachId As Integer = TblAttachmentBindingSource.Current.id
                Dim Attach = TblAttachmentBindingSource.Current.attachmment

                If Not AttachId = 0 Then
                    Dim x As New FrmShowAttachment
                    x.AttachId = AttachId
                    x.ShowDialog()
                End If

                '************************************************************************************************Opening any type of attachments but attach must be binary not string !!
                'Dim FileName As String = ""
                'If TblAttachmentBindingSource.Current.attachmment Is Nothing Then
                '    FileName = TblAttachmentBindingSource.Current.id.ToString() + ".jpg"
                'Else
                '    FileName = TblAttachmentBindingSource.Current.attachmment
                'End If

                'FileName = FileName
                'Using writer = New BinaryWriter(File.Open(FileName, FileMode.OpenOrCreate))
                '    writer.Write(TblAttachmentBindingSource.Current.document)
                'End Using

                'Dim x1 As New Process()
                'x1.Start(FileName)

            End If
        End If

    End Sub

    Private Sub TblWifeHusbandDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblWifeHusbandDataGridView.CellContentClick
        If TblWifeHusbandBindingSource.Count > 0 Then
            If e.ColumnIndex = EditWife.Index Then

                Dim v As New TblWifeHusband
                v = TblWifeHusbandBindingSource.Current

                Dim r As New TblWifeHusband
                r.ApplicantId = v.ApplicantId
                r.FirstName = v.FirstName
                r.InCompany = v.InCompany
                r.IsNSSF = v.IsNSSF
                r.Job = v.Job
                r.LastName = v.LastName
                r.NSSFSide = v.NSSFSide
                r.MaritalStatus = v.MaritalStatus

                r.WifeHusbandEmployeeId = v.WifeHusbandEmployeeId

                Dim Id As Integer = TblWifeHusbandBindingSource.Current.Id

                Dim x As New FrmWifeHusbandInfo
                x.current = r
                x.ForEdit = True
                x.Id = Id
                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.FirstName = r.FirstName
                    v.InCompany = r.InCompany
                    v.IsNSSF = r.IsNSSF
                    v.Job = r.Job
                    v.LastName = r.LastName
                    v.NSSFSide = r.NSSFSide
                    v.MaritalStatus = r.MaritalStatus
                    v.WifeHusbandEmployeeId = r.WifeHusbandEmployeeId
                End If

                FindFamilySalary()

            End If

            If e.ColumnIndex = DeleteWife.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblWifeHusbandBindingSource.Current.id
                        TblWifeHusbandBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteWifeList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblWifeHusbands Where aX.Id = Id).ToList(0)
                            'aMainOR.TblWifeHusbands.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshWifeHusband()
                        End If

                    End Using
                End If
                FindFamilySalary()
            End If
        End If

    End Sub

    Private Sub TblRequiredJobDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblRequiredJobDataGridView.CellContentClick
        If TblRequiredJobBindingSource.Count > 0 Then
            If e.ColumnIndex = EditRequiredJob.Index Then

                Dim v As New TblRequiredJob
                v = TblRequiredJobBindingSource.Current

                Dim r As New TblRequiredJob
                r.ApplicantId = v.ApplicantId
                r.CurrencyId = v.CurrencyId
                r.DepartmentId = v.DepartmentId
                r.ExpectedSalary = v.ExpectedSalary
                r.JobDescriptionId = v.JobDescriptionId
                r.WayOfWorking = v.WayOfWorking

                Dim Id As Integer = TblRequiredJobBindingSource.Current.Id

                Dim x As New FrmRequiredJob
                x.current = r
                x.ForEdit = True
                x.id = Id

                x.ShowDialog()
                If x.saved Then
                    v.ApplicantId = r.ApplicantId
                    v.CurrencyId = r.CurrencyId
                    v.DepartmentId = r.DepartmentId
                    v.ExpectedSalary = r.ExpectedSalary
                    v.JobDescriptionId = r.JobDescriptionId
                    v.WayOfWorking = r.WayOfWorking
                End If

                x.Dispose()
            End If
        End If

        If e.ColumnIndex = DeleteRequiredJob.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblRequiredJobBindingSource.Current.id
                    TblRequiredJobBindingSource.RemoveCurrent()
                    If Not Id = 0 Then

                        deleteReqJobList.Add(Id)
                        'Dim result = (From aX In aMainOR.TblRequiredJobs Where aX.Id = Id).ToList(0)
                        'aMainOR.TblRequiredJobs.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshRequiredJob()
                    End If


                End Using
            End If

        End If

    End Sub

    Private Sub TblExperienceHistoryDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblExperienceHistoryDataGridView.CellContentClick
        If TblExperienceHistoryBindingSource.Count > 0 Then
            If e.ColumnIndex = EditExperience.Index Then

                Dim v As New TblExperienceHistory
                v = TblExperienceHistoryBindingSource.Current

                Dim r As New TblExperienceHistory
                r.ApplicantId = v.ApplicantId
                r.CanBeLeave = v.CanBeLeave
                r.CompanyName = v.CompanyName
                r.CurrencyId = v.CurrencyId
                r.IsNSSF = v.IsNSSF
                r.LeaveDate = v.LeaveDate
                r.LeaveReason = v.LeaveReason
                r.NSSFNumber = v.NSSFNumber
                r.NSSFSide = v.NSSFSide
                r.PositionId = v.PositionId
                r.Salary = v.Salary
                r.ScheduleNote = v.ScheduleNote
                r.StartDate = v.StartDate
                r.StillWorking = v.StillWorking


                Dim Id As Integer = TblExperienceHistoryBindingSource.Current.Id

                Dim x As New FrmExperienceHistory
                x.current = r
                x.dob = DateOfBirthDateTimePicker.Value
                x.ForEdit = True
                x.id = Id

                x.ShowDialog()
                If x.saved Then
                    v.ApplicantId = r.ApplicantId
                    v.CanBeLeave = r.CanBeLeave
                    v.CompanyName = r.CompanyName
                    v.CurrencyId = r.CurrencyId
                    v.IsNSSF = r.IsNSSF
                    v.LeaveDate = r.LeaveDate
                    v.LeaveReason = r.LeaveReason
                    v.NSSFNumber = r.NSSFNumber
                    v.NSSFSide = r.NSSFSide
                    v.PositionId = r.PositionId
                    v.Salary = r.Salary
                    v.ScheduleNote = r.ScheduleNote
                    v.StartDate = r.StartDate
                    v.StillWorking = r.StillWorking

                End If

                x.Dispose()
            End If
        End If

        If e.ColumnIndex = DeleteExperience.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblExperienceHistoryBindingSource.Current.id
                    TblExperienceHistoryBindingSource.RemoveCurrent()
                    If Not Id = 0 Then
                        deleteExperienceList.Add(Id)
                        'Dim result = (From aX In aMainOR.TblExperienceHistories Where aX.Id = Id).ToList(0)
                        'aMainOR.TblExperienceHistories.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshExperienceHistory()
                    End If
                End Using
            End If
        End If

    End Sub

    Private Sub TblEducationDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblEducationDataGridView.CellContentClick
        If TblEducationBindingSource.Count > 0 Then
            If e.ColumnIndex = EditEducation.Index Then

                Dim v As New TblEducation
                v = TblEducationBindingSource.Current

                Dim r As New TblEducation
                r.ApplicantId = v.ApplicantId
                r.CertificateId = v.CertificateId
                r.GPA = v.GPA
                r.GraduationYear = v.GraduationYear
                r.Id = v.Id
                r.Major = v.Major
                r.Note = v.Note
                r.StartYear = v.StartYear
                r.University = v.University

                Dim Id As Integer = TblEducationBindingSource.Current.Id

                Dim x As New FrmEducationHistory
                x.current = r
                x.ForEdit = True
                x.Id = Id
                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.CertificateId = r.CertificateId
                    v.GPA = r.GPA
                    v.GraduationYear = r.GraduationYear
                    v.Id = r.Id
                    v.Major = r.Major
                    v.Note = r.Note
                    v.StartYear = r.StartYear
                    v.University = r.University
                End If

                x.Dispose()
            End If
        End If
        If e.ColumnIndex = DeleteEducation.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblEducationBindingSource.Current.id
                    TblEducationBindingSource.RemoveCurrent()
                    If Not Id = 0 Then
                        deleteEducationList.Add(Id)
                        'Dim result = (From aX In aMainOR.TblEducations Where aX.Id = Id).ToList(0)
                        'aMainOR.TblEducations.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshEducation()

                    End If
                End Using
            End If

        End If

    End Sub

    Private Sub TblLanguageDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblLanguageDataGridView.CellContentClick

        If TblLanguageBindingSource.Count > 0 Then
            If e.ColumnIndex = EditLang.Index Then

                Dim v As New TblLanguage
                v = TblLanguageBindingSource.Current

                Dim r As New TblLanguage
                r.ApplicantId = v.ApplicantId
                r.CommLevel = v.CommLevel
                r.Language = v.Language
                r.ReadingLevel = v.ReadingLevel
                r.WritingLevel = v.WritingLevel

                Dim Id As Integer = TblLanguageBindingSource.Current.Id

                Dim x As New FrmLanguages
                x.current = r
                x.ForEdit = True
                x.Id = Id
                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.CommLevel = r.CommLevel
                    v.Language = r.Language
                    v.ReadingLevel = r.ReadingLevel
                    v.WritingLevel = r.WritingLevel
                End If

                x.Dispose()
            End If
        End If

        If e.ColumnIndex = DeleteLang.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblLanguageBindingSource.Current.Id
                    TblLanguageBindingSource.RemoveCurrent()
                    If Not Id = 0 Then
                        deleteLanguageList.Add(Id)
                        'Dim result = (From aX In aMainOR.TblLanguages Where aX.Id = Id).ToList(0)
                        'aMainOR.TblLanguages.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshlanguages()
                    End If
                End Using
            End If

        End If

    End Sub

    Private Sub TblRelativeRefernceDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblRelativeRefernceDataGridView.CellContentClick

        If TblRelativeReferenceBindingSource.Count > 0 Then
            If e.ColumnIndex = EditRef.Index Then

                Dim v As New TblRelativeReference
                v = TblRelativeReferenceBindingSource.Current

                Dim r As New TblRelativeReference
                r.ApplicantId = v.ApplicantId
                r.IsInCompany = v.IsInCompany
                r.Job = v.Job
                r.Name = v.Name
                r.Phone = v.Phone
                r.Relation = v.Relation
                r.RelativeReferenceEmployeeId = v.RelativeReferenceEmployeeId


                Dim Id As Integer = TblRelativeReferenceBindingSource.Current.Id

                Dim x As New FrmRelativeReferences
                x.current = r
                x.ForEdit = True
                x.Id = Id

                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.IsInCompany = r.IsInCompany
                    v.Job = r.Job
                    v.Name = r.Name
                    v.Phone = r.Phone
                    v.Relation = r.Relation
                    v.RelativeReferenceEmployeeId = r.RelativeReferenceEmployeeId
                End If

                x.Dispose()
            End If

            If e.ColumnIndex = DeleteRef.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblRelativeReferenceBindingSource.Current.id
                        TblRelativeReferenceBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteRelativeRefList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblRelativeReferences Where aX.Id = Id).ToList(0)
                            'aMainOR.TblRelativeReferences.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshRelativeRef()
                        End If

                    End Using
                End If

            End If
        End If

    End Sub

    Private Sub TblFamilyMemberDataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblFamilyMemberDataGridView.CellContentClick

        If TblFamilyMemberBindingSource.Count > 0 Then
            If e.ColumnIndex = EditKid.Index Then
                Dim v As New TblFamilyMember
                v = TblFamilyMemberBindingSource.Current

                Dim r As New TblFamilyMember
                r.ApplicantId = v.ApplicantId
                r.DateOfBirth = v.DateOfBirth
                r.FirstName = v.FirstName
                r.Gender = v.Gender
                r.IsWorking = v.IsWorking
                r.LastName = v.LastName
                r.MiddleName = v.MiddleName
                r.IsMarried = v.IsMarried

                Dim Id As Integer = TblFamilyMemberBindingSource.Current.Id

                Dim x As New FrmFamilyMember
                x.current = r
                x.ForEdit = True
                x.DateOfBirth = DateOfBirthDateTimePicker.Value
                x.Id = Id
                x.ShowDialog()
                If x.Saved Then
                    v.ApplicantId = r.ApplicantId
                    v.DateOfBirth = r.DateOfBirth
                    v.FirstName = r.FirstName
                    v.Gender = r.Gender
                    v.IsWorking = r.IsWorking
                    v.LastName = r.LastName
                    v.MiddleName = r.MiddleName
                    v.IsMarried = r.IsMarried
                End If

                x.Dispose()
                FindFamilySalary()
            End If

            If e.ColumnIndex = DeleteKid.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)

                        Dim kidId As Integer = TblFamilyMemberBindingSource.Current.id
                        TblFamilyMemberBindingSource.RemoveCurrent()

                        If Not kidId = 0 Then
                            deleteKidList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblFamilyMembers Where aX.Id = kidId).ToList(0)
                            'aMainOR.TblFamilyMembers.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshFamilyMember()

                            'Dim kidsnb = (From ax In aMainOR.TblFamilyMembers Where ax.ApplicantId = Id).ToList()
                            Dim kidsnb = TblFamilyMemberBindingSource.Count
                            TblApplicantBindingSource.Current.numberofkids = kidsnb
                            Dim OldApp = (From aX In aMainor.TblApplicants Where aX.Id = Id).ToList(0)
                            OldApp.NumberOfKids = kidsnb
                            aMainor.SubmitChanges()
                        End If
                    End Using
                End If
                FindFamilySalary()
            End If
        End If
    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellDoubleClick

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs)
        'selectedDate = MonthCalendar1.SelectionStart.Date
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        MonthCalendar1.Visible = False
        TblEmployeeVacationDataGridView.Enabled = True
        ' isDateSelected = True
        TblEmployeeVacationDataGridView.CurrentRow.Cells(DateCol.Index).Value = selectedDate
    End Sub

    Private Sub PBSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBSave.Click
        PBSave.Focus()
        Using aMainor As New LqHRDataContext(cnx)
            If StatusId = EmployeeStatusId Then
                If TblEmployeeJobBindingSource.Count > 0 Then

                    SAVE()

                Else
                    MessageBox.Show("Missing Job Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                SAVE()
            End If
        End Using

        ''''''''''''save applicant''''''''''''
        'If ValidateApplicantInfo() Then

    End Sub

    '''''''''''''''''''''''''''''fuction used to save default image having the image path ''''''''''''''''''''''''

    'Public Function imgToByteArray(ByVal img As Image) As Byte()
    '    Using mStream As New MemoryStream()
    '        img.Save(mStream, img.RawFormat)
    '        Return mStream.ToArray()
    '    End Using
    'End Function

    Sub SAVE()
        Using aMainor As New LqHRDataContext(cnx)
            If FirstNameTextBox.Text = "" Or MiddleNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or GenderComboBox.Text = "" Or MobileTextBox.Text = "" Or        'Or DateOfBirthDateTimePicker.Value.Date = Date.Now.Date
                 MotherNameTextBox.Text = "" Or PlaceOfBirthTextBox.Text = "" Or RecordNumberTextBox.Text = "" Or MartialStatusComboBox.Text = "" Then

                MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If Id = 0 Then
                    If IsNothing(TblApplicantBindingSource.Current.numberOfKids) Then
                        TblApplicantBindingSource.Current.numberOfKids = 0
                    End If
                    TblApplicantBindingSource.Current.MaritalStatus = MartialStatusComboBox.SelectedItem
                    TblApplicantBindingSource.Current.gender = GenderComboBox.SelectedItem
                    TblApplicantBindingSource.Current.Nationality = NationalityComboBox.SelectedItem
                    TblApplicantBindingSource.Current.mohafaza = MohafazaComboBox.SelectedItem
                    TblApplicantBindingSource.Current.kadaa = KadaaComboBox.SelectedItem
                    TblApplicantBindingSource.Current.bloodId = BloodIdComboBox.SelectedValue
                    'TblApplicantBindingSource.Current.age = CInt(TextBoxAge.Text)
                    If Not TextBoxAge.Text = "" Then
                        TblApplicantBindingSource.Current.age = TextBoxAge.Text
                    End If

                    TblApplicantBindingSource.Current.Country = countriesCombo.SelectedItem

                    aMainor.TblApplicants.InsertOnSubmit(TblApplicantBindingSource.Current)

                    'EnableComponents(True)
                    aMainor.SubmitChanges()
                Else
                    TblApplicantBindingSource.Current.MaritalStatus = MartialStatusComboBox.SelectedItem
                    TblApplicantBindingSource.Current.gender = GenderComboBox.SelectedItem
                    TblApplicantBindingSource.Current.Nationality = NationalityComboBox.SelectedItem
                    TblApplicantBindingSource.Current.mohafaza = MohafazaComboBox.SelectedItem
                    TblApplicantBindingSource.Current.kadaa = KadaaComboBox.SelectedItem
                    TblApplicantBindingSource.Current.bloodId = BloodIdComboBox.SelectedValue
                    ' TblApplicantBindingSource.Current.age = CInt(TextBoxAge.Text)
                    TblApplicantBindingSource.Current.age = TextBoxAge.Text
                    TblApplicantBindingSource.Current.Country = countriesCombo.SelectedItem

                    Dim Old = (From aX In aMainor.TblApplicants Where aX.Id = Id).ToList(0)
                    Dim newItem As TblApplicant = TblApplicantBindingSource.Current

                    Old.FirstName = newItem.FirstName
                    Old.MiddleName = newItem.MiddleName
                    Old.LastName = newItem.LastName
                    Old.Gender = newItem.Gender
                    Old.DateOfBirth = newItem.DateOfBirth
                    Old.Age = newItem.Age
                    Old.Nationality = newItem.Nationality
                    Old.BloodId = newItem.BloodId
                    Old.Mobile = newItem.Mobile
                    Old.PhoneNumber = newItem.PhoneNumber
                    Old.MotherName = newItem.MotherName
                    Old.PlaceOfBirth = newItem.PlaceOfBirth
                    Old.RecordNumber = newItem.RecordNumber
                    Old.RecordPlace = newItem.RecordPlace
                    Old.Mohafaza = newItem.Mohafaza
                    Old.Kadaa = newItem.Kadaa
                    Old.Country = newItem.Country
                    Old.MaritalStatus = newItem.MaritalStatus
                    aMainor.SubmitChanges()
                    Dim res2 = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                    Dim res = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id).ToList()
                    If res.Count > 0 Then
                        res.ToList(0).EmployeeName = res2.FirstName + " " + res2.MiddleName + " " + res2.LastName
                        aMainor.SubmitChanges()
                    End If

                End If

                Id = TblApplicantBindingSource.Current.id
                Dim lastname = TblApplicantBindingSource.Current.lastname


                ''''''''''''''''save wife'''''''''''''''

                If deleteWifeList.Count > 0 Then
                    For i As Integer = 0 To deleteWifeList.Count - 1
                        Dim id1 As Integer = deleteWifeList.Item(i)
                        Dim wife = (From aX In aMainor.TblWifeHusbands Where aX.Id = id1).ToList(0)
                        aMainor.TblWifeHusbands.DeleteOnSubmit(wife)
                        aMainor.SubmitChanges()
                    Next
                End If

                If TblWifeHusbandBindingSource.Count > 0 Then


                    For i As Integer = 0 To TblWifeHusbandBindingSource.Count - 1

                        Dim wifeId As Integer = TblWifeHusbandBindingSource(i).Id
                        If wifeId = 0 Then
                            TblWifeHusbandBindingSource(i).applicantId = Id
                            aMainor.TblWifeHusbands.InsertOnSubmit(TblWifeHusbandBindingSource(i))

                        Else
                            Dim Old = (From aX In aMainor.TblWifeHusbands Where aX.Id = wifeId).ToList(0)
                            Dim newItem As TblWifeHusband = TblWifeHusbandBindingSource(i)

                            Old.FirstName = newItem.FirstName
                            Old.InCompany = newItem.InCompany
                            Old.IsNSSF = newItem.IsNSSF
                            Old.Job = newItem.Job
                            Old.LastName = newItem.LastName
                            Old.NSSFSide = newItem.NSSFSide
                            Old.MaritalStatus = newItem.MaritalStatus
                            Old.WifeHusbandEmployeeId = newItem.WifeHusbandEmployeeId
                        End If
                        aMainor.SubmitChanges()

                    Next
                End If

                ''''''''''''''''save kid'''''''''''''''
                If deleteKidList.Count > 0 Then
                    For i As Integer = 0 To deleteKidList.Count - 1
                        Dim id1 As Integer = deleteKidList.Item(i)
                        Dim kid = (From aX In aMainor.TblFamilyMembers Where aX.Id = id1).ToList(0)
                        aMainor.TblFamilyMembers.DeleteOnSubmit(kid)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblFamilyMemberBindingSource.Count - 1

                    Dim kidId As Integer = TblFamilyMemberBindingSource(i).Id
                    If kidId = 0 Then
                        TblFamilyMemberBindingSource(i).applicantId = Id
                        aMainor.TblFamilyMembers.InsertOnSubmit(TblFamilyMemberBindingSource(i))

                    Else
                        Dim Old = (From aX In aMainor.TblFamilyMembers Where aX.Id = kidId).ToList(0)
                        Dim newItem As TblFamilyMember = TblFamilyMemberBindingSource(i)

                        Old.FirstName = newItem.FirstName
                        Old.LastName = newItem.LastName
                        Old.MiddleName = newItem.MiddleName
                        Old.Gender = newItem.Gender
                        Old.DateOfBirth = newItem.DateOfBirth
                    End If
                    aMainor.SubmitChanges()


                Next
                TblApplicantBindingSource.Current.numberofkids = TblFamilyMemberBindingSource.Count


                '''''''''''''''save address''''''''''''''''
                If deleteAddressList.Count > 0 Then
                    For i As Integer = 0 To deleteAddressList.Count - 1
                        Dim id1 As Integer = deleteAddressList.Item(i)
                        Dim address = (From aX In aMainor.TblAddresses Where aX.Id = id1).ToList(0)
                        aMainor.TblAddresses.DeleteOnSubmit(address)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblAddressBindingSource.Count - 1

                    Dim addId As Integer = TblAddressBindingSource(i).Id
                    If addId = 0 Then
                        TblAddressBindingSource(i).applicantId = Id
                        aMainor.TblAddresses.InsertOnSubmit(TblAddressBindingSource(i))

                    Else
                        Dim Old = (From aX In aMainor.TblAddresses Where aX.Id = addId).ToList(0)
                        Dim newItem As TblAddress = TblAddressBindingSource(i)

                        Old.City_Town = newItem.City_Town
                        Old.Building = newItem.Building
                        Old.Floor = newItem.Floor
                        Old.District = newItem.District
                        Old.Street = newItem.Street
                        Old.Near = newItem.Near
                        Old.PropertyType = newItem.PropertyType
                    End If
                    aMainor.SubmitChanges()

                Next


                ''''''''''''''''save Education'''''''''''''''
                If deleteEducationList.Count > 0 Then
                    For i As Integer = 0 To deleteEducationList.Count - 1
                        Dim id1 As Integer = deleteEducationList.Item(i)
                        Dim education = (From aX In aMainor.TblEducations Where aX.Id = id1).ToList(0)
                        aMainor.TblEducations.DeleteOnSubmit(education)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblEducationBindingSource.Count - 1

                    Dim educationId As Integer = TblEducationBindingSource(i).Id
                    If educationId = 0 Then
                        TblEducationBindingSource(i).applicantId = Id
                        aMainor.TblEducations.InsertOnSubmit(TblEducationBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblEducations Where aX.Id = educationId).ToList(0)
                        Dim newItem As TblEducation = TblEducationBindingSource(i)

                        Old.StartYear = newItem.StartYear
                        Old.GraduationYear = newItem.GraduationYear
                        Old.Major = newItem.Major
                        Old.CertificateId = newItem.CertificateId
                        Old.University = newItem.University
                        Old.GPA = newItem.GPA
                        Old.Note = newItem.Note

                    End If
                    aMainor.SubmitChanges()

                Next


                ''''''''''''''''save Workshop'''''''''''''''
                If deleteWorkshopList.Count > 0 Then
                    For i As Integer = 0 To deleteWorkshopList.Count - 1
                        Dim id1 As Integer = deleteWorkshopList.Item(i)
                        Dim workshop = (From aX In aMainor.TblWorkShops Where aX.Id = id1).ToList(0)
                        aMainor.TblWorkShops.DeleteOnSubmit(workshop)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblWorkShopBindingSource.Count - 1

                    Dim workshopId As Integer = TblWorkShopBindingSource(i).Id
                    If workshopId = 0 Then
                        TblWorkShopBindingSource(i).applicantId = Id
                        aMainor.TblWorkShops.InsertOnSubmit(TblWorkShopBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblWorkShops Where aX.Id = workshopId).ToList(0)
                        Dim newItem As TblWorkShop = TblWorkShopBindingSource(i)

                        Old.Date = newItem.Date
                        Old.Name = newItem.Name
                        Old.Organization = newItem.Organization
                        Old.Place = newItem.Place

                    End If
                    aMainor.SubmitChanges()
                Next


                '''''''''''''save Language'''''''''''''''
                If deleteLanguageList.Count > 0 Then
                    For i As Integer = 0 To deleteLanguageList.Count - 1
                        Dim id1 As Integer = deleteLanguageList.Item(i)
                        Dim lang = (From aX In aMainor.TblLanguages Where aX.Id = id1).ToList(0)
                        aMainor.TblLanguages.DeleteOnSubmit(lang)
                        aMainor.SubmitChanges()
                    Next
                End If


                For i As Integer = 0 To TblLanguageBindingSource.Count - 1
                    Dim languageId As Integer = TblLanguageBindingSource(i).Id
                    If languageId = 0 Then
                        TblLanguageBindingSource(i).applicantId = Id
                        aMainor.TblLanguages.InsertOnSubmit(TblLanguageBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblLanguages Where aX.Id = languageId).ToList(0)
                        Dim newItem As TblLanguage = TblLanguageBindingSource(i)
                        Old.Language = newItem.Language
                        Old.CommLevel = newItem.CommLevel
                        Old.ReadingLevel = newItem.ReadingLevel
                        Old.WritingLevel = newItem.WritingLevel

                    End If
                    aMainor.SubmitChanges()

                Next


                '''''''''''''save Experience History'''''''''''''''
                If deleteExperienceList.Count > 0 Then
                    For i As Integer = 0 To deleteExperienceList.Count - 1
                        Dim id1 As Integer = deleteExperienceList.Item(i)
                        Dim exp = (From aX In aMainor.TblExperienceHistories Where aX.Id = id1).ToList(0)
                        aMainor.TblExperienceHistories.DeleteOnSubmit(exp)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblExperienceHistoryBindingSource.Count - 1
                    Dim ExpId As Integer = TblExperienceHistoryBindingSource(i).Id
                    If ExpId = 0 Then
                        TblExperienceHistoryBindingSource(i).applicantId = Id
                        aMainor.TblExperienceHistories.InsertOnSubmit(TblExperienceHistoryBindingSource(i))
                    Else
                        Dim oldTblExp As TblExperienceHistory = (From aX In aMainor.TblExperienceHistories Where aX.Id = ExpId).ToList(0)
                        Dim newTblExp As TblExperienceHistory = TblExperienceHistoryBindingSource(i)
                        oldTblExp.StartDate = newTblExp.StartDate
                        oldTblExp.LeaveDate = newTblExp.LeaveDate
                        oldTblExp.LeaveReason = newTblExp.LeaveReason
                        oldTblExp.Salary = newTblExp.Salary
                        oldTblExp.CurrencyId = newTblExp.CurrencyId
                        oldTblExp.PositionId = newTblExp.PositionId
                        oldTblExp.CompanyName = newTblExp.CompanyName
                        oldTblExp.ScheduleNote = newTblExp.ScheduleNote
                        oldTblExp.NSSFNumber = newTblExp.NSSFNumber
                        oldTblExp.NSSFSide = newTblExp.NSSFSide
                        oldTblExp.StillWorking = newTblExp.StillWorking
                        oldTblExp.CanBeLeave = newTblExp.CanBeLeave
                        oldTblExp.IsNSSF = newTblExp.IsNSSF
                    End If
                    aMainor.SubmitChanges()

                Next

                '''''''''''''save Required Job'''''''''''''''
                If deleteReqJobList.Count > 0 Then
                    For i As Integer = 0 To deleteReqJobList.Count - 1
                        Dim id1 As Integer = deleteReqJobList.Item(i)
                        Dim reqJob = (From aX In aMainor.TblRequiredJobs Where aX.Id = id1).ToList(0)
                        aMainor.TblRequiredJobs.DeleteOnSubmit(reqJob)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblRequiredJobBindingSource.Count - 1
                    Dim reqJobId As Integer = TblRequiredJobBindingSource(i).Id

                    If reqJobId = 0 Then
                        TblRequiredJobBindingSource(i).applicantId = Id
                        aMainor.TblRequiredJobs.InsertOnSubmit(TblRequiredJobBindingSource(i))
                    Else
                        Dim oldTblreq As TblRequiredJob = (From aX In aMainor.TblRequiredJobs Where aX.Id = reqJobId).ToList(0)
                        Dim newTblreq As TblRequiredJob = TblRequiredJobBindingSource(i)
                        oldTblreq.DepartmentId = newTblreq.DepartmentId
                        oldTblreq.JobDescriptionId = newTblreq.JobDescriptionId
                        oldTblreq.WayOfWorking = newTblreq.WayOfWorking
                        oldTblreq.ExpectedSalary = newTblreq.ExpectedSalary
                        oldTblreq.CurrencyId = newTblreq.CurrencyId

                    End If

                    aMainor.SubmitChanges()

                Next


                '''''''''''''save Applicant Medical Issue'''''''''''''''
                Dim result = (From aX In aMainor.TblApplicantMedicalIssues Where aX.ApplicantId = Id).ToList

                If result.Count > 0 Then
                    aMainor.TblApplicantMedicalIssues.DeleteAllOnSubmit(result)
                    aMainor.SubmitChanges()
                End If

                For i As Integer = 0 To TblApplicantMedicalIssueBindingSource.Count - 1
                    Dim applicantMedicalIssueId As Integer = TblApplicantMedicalIssueBindingSource(i).Id

                    Dim X As New TblApplicantMedicalIssue
                    X.ApplicantId = Id
                    X.MedicalIssueId = TblApplicantMedicalIssueBindingSource(i).MedicalIssueId
                    X.Note = TblApplicantMedicalIssueBindingSource(i).note
                    X.Date = TblApplicantMedicalIssueBindingSource(i).date

                    aMainor.TblApplicantMedicalIssues.InsertOnSubmit(X)
                    aMainor.SubmitChanges()

                Next


                '''''''''''''save Applicant SKILLS'''''''''''''''
                Dim result1 = (From aX In aMainor.TblApplicantSkills Where aX.ApplicantId = Id).ToList

                If result1.Count > 0 Then
                    aMainor.TblApplicantSkills.DeleteAllOnSubmit(result1)
                    aMainor.SubmitChanges()
                End If

                For i As Integer = 0 To TblApplicantSkillBindingSource.Count - 1
                    Dim applicantSkillId As Integer = TblApplicantSkillBindingSource(i).Id

                    Dim X As New TblApplicantSkill
                    X.ApplicantId = Id
                    X.SkillId = TblApplicantSkillBindingSource(i).skillId
                    X.SkillLevel = TblApplicantSkillBindingSource(i).skilllevel

                    aMainor.TblApplicantSkills.InsertOnSubmit(X)
                    aMainor.SubmitChanges()


                Next


                ''''''''''save Relative Reference''''''''''''''''
                If deleteRelativeRefList.Count > 0 Then
                    For i As Integer = 0 To deleteRelativeRefList.Count - 1
                        Dim id1 As Integer = deleteRelativeRefList.Item(i)
                        Dim relref = (From aX In aMainor.TblRelativeReferences Where aX.Id = id1).ToList(0)
                        aMainor.TblRelativeReferences.DeleteOnSubmit(relref)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblRelativeReferenceBindingSource.Count - 1

                    Dim refId As Integer = TblRelativeReferenceBindingSource(i).Id
                    If refId = 0 Then
                        TblRelativeReferenceBindingSource(i).applicantId = Id
                        aMainor.TblRelativeReferences.InsertOnSubmit(TblRelativeReferenceBindingSource(i))

                    Else
                        Dim Old = (From aX In aMainor.TblRelativeReferences Where aX.Id = refId).ToList(0)
                        Dim newItem As TblRelativeReference = TblRelativeReferenceBindingSource(i)

                        Old.IsInCompany = newItem.IsInCompany
                        Old.Job = newItem.Job
                        Old.Name = newItem.Name
                        Old.Phone = newItem.Phone
                        Old.Relation = newItem.Relation
                        Old.RelativeReferenceEmployeeId = newItem.RelativeReferenceEmployeeId


                    End If
                    aMainor.SubmitChanges()

                Next


                '''''''''''''save attach'''''''''''''''
                If deleteAttachmentList.Count > 0 Then
                    For i As Integer = 0 To deleteAttachmentList.Count - 1
                        Dim id1 As Integer = deleteAttachmentList.Item(i)
                        Dim attach = (From aX In aMainor.TblAttachments Where aX.Id = id1).ToList(0)
                        aMainor.TblAttachments.DeleteOnSubmit(attach)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblAttachmentBindingSource.Count - 1
                    Dim reqJobId As Integer = TblAttachmentBindingSource(i).Id
                    If reqJobId = 0 Then
                        TblAttachmentBindingSource(i).applicantId = Id
                        TblAttachmentBindingSource(i).name = lastname + "_" + TblAttachmentBindingSource(i).type
                        aMainor.TblAttachments.InsertOnSubmit(TblAttachmentBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblAttachments Where aX.Id = reqJobId).ToList(0)
                        Dim newItem As TblAttachment = TblAttachmentBindingSource(i)

                        Old.Attachmment = newItem.Attachmment
                        Old.ExpiryDate = newItem.ExpiryDate
                        Old.Type = newItem.Type
                        Old.Name = lastname + "_" + newItem.Type
                        Old.UploadedDate = newItem.UploadedDate
                    End If
                    aMainor.SubmitChanges()

                Next
                Dim res8 = (From ax In aMainor.TblAttachments Where ax.ApplicantId = Id Where ax.Type = "Photography").ToList
                If Not res8.Count > 0 Then

                    'Dim img As Image = Image.FromFile(ImagePath)

                    Dim t1 As New TblAttachment
                    t1.Type = "Photography"
                    t1.ApplicantId = Id
                    t1.Name = lastname + "_" + "Photography"
                    t1.UploadedDate = Date.Now
                    't1.Attachmment = imgToByteArray(img)
                    t1.Attachmment = (From ax In aMainor.TblSettings Select ax.DefaultImage).ToList(0)
                    aMainor.TblAttachments.InsertOnSubmit(t1)
                    aMainor.SubmitChanges()

                End If

                '''''''''''''''''' save Trainee''''''''''''''''

                If StatusId = TraineeStatusId Then
                    Dim r As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                    If Not r.StatusId = TraineeStatusId Then
                        r.StatusId = TraineeStatusId
                        aMainor.SubmitChanges()
                        TblTraineeBindingSource.Current.ApplicantId = Id
                        TblTraineeBindingSource.Current.StartDate = Date.Now
                        aMainor.TblTrainees.InsertOnSubmit(TblTraineeBindingSource.Current)
                        aMainor.SubmitChanges()
                        TraineeId = TblTraineeBindingSource.Current.id
                        'Dim Trainee As New TblTrainee
                        'Trainee.ApplicantId = Id
                        'Trainee.StartDate = Date.Now
                        'aMainor.TblTrainees.InsertOnSubmit(Trainee)
                        'aMainor.SubmitChanges()
                        'TraineeId = Trainee.Id
                    Else ''if its already a trainee => update

                        TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                        Dim oldrow = (From ax In aMainor.TblTrainees Where ax.Id = TraineeId).ToList(0)
                        Dim newrow = TblTraineeBindingSource.Current
                        oldrow.DepartmentId = newrow.DepartmentId
                        aMainor.SubmitChanges()

                    End If
                End If


                ' ''''''''''save Trainee Lectures''''''''''''''''
                If deleteTraineeLecturesList.Count > 0 Then
                    For i As Integer = 0 To deleteTraineeLecturesList.Count - 1
                        Dim id1 As Integer = deleteTraineeLecturesList.Item(i)
                        Dim TraineeLec = (From aX In aMainor.TblTraineeLectures Where aX.Id = id1).ToList(0)
                        aMainor.TblTraineeLectures.DeleteOnSubmit(TraineeLec)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblTraineeLectureBindingSource.Count - 1

                    Dim TrId As Integer = TblTraineeLectureBindingSource(i).Id
                    If TrId = 0 Then
                        TblTraineeLectureBindingSource(i).traineeid = TraineeId
                        aMainor.TblTraineeLectures.InsertOnSubmit(TblTraineeLectureBindingSource(i))

                    Else
                        Dim Old = (From aX In aMainor.TblTraineeLectures Where aX.Id = TrId).ToList(0)
                        Dim newItem As TblTraineeLecture = TblTraineeLectureBindingSource(i)

                        Old.Date = newItem.Date
                        Old.LectureId = newItem.LectureId

                    End If
                    aMainor.SubmitChanges()

                Next


                '''''''''''''''''''''''save trainee PA ''''''''''''''''''''''''''''''''''
                If TblTraineePerformanceAppraisalBindingSource.Count > 0 Then
                    TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                    For i As Integer = 0 To TblTraineePerformanceAppraisalBindingSource.Count - 1
                        Dim x As TblTraineePerformanceAppraisal = TblTraineePerformanceAppraisalBindingSource(i)

                        x.TrainneId = TraineeId
                        If x.id = 0 Then

                            If Not x.Grade Is Nothing Then
                                aMainor.TblTraineePerformanceAppraisals.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            End If

                        Else
                            Dim id As Integer = TblTraineePerformanceAppraisalBindingSource(i).id
                            Dim odlRow As TblTraineePerformanceAppraisal = (From ax In aMainor.TblTraineePerformanceAppraisals Where ax.id = id).ToList(0)
                            Dim newRow As TblTraineePerformanceAppraisal = TblTraineePerformanceAppraisalBindingSource(i)
                            odlRow.Grade = newRow.Grade
                            If Not x.Grade Is Nothing Then
                                aMainor.SubmitChanges()
                            End If

                        End If
                    Next

                End If

                '''''''''''''''''' save employee''''''''''''''''

                If StatusId = EmployeeStatusId Then
                    Dim r As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                    If Not r.StatusId = EmployeeStatusId Then

                        r.StatusId = EmployeeStatusId
                        aMainor.SubmitChanges()
                        Dim FullName As String = r.FirstName + " " + r.MiddleName + " " + r.LastName
                        TblEmployeeBindingSource.Current.EmployeeName = FullName
                        TblEmployeeBindingSource.Current.ApplicantId = Id
                        TblEmployeeBindingSource.Current.pin = PINTextBox.Text

                        aMainor.TblEmployees.InsertOnSubmit(TblEmployeeBindingSource.Current)
                        aMainor.SubmitChanges()
                        EmployeeId = TblEmployeeBindingSource.Current.Id
                        CanAssignHolidays = True

                    Else



                        Dim Old = (From aX In aMainor.TblEmployees Where aX.Id = EmployeeId).ToList(0)
                        Dim newE As TblEmployee = currentEmployee
                        Old.EmployeeName = r.FirstName + " " + r.MiddleName + " " + r.LastName
                        Old.PIN = PINTextBox.Text
                        Old.BatchNumber = newE.BatchNumber
                            Old.CardNumber = newE.CardNumber
                           ' Old.EmployeeName = newE.EmployeeName
                            aMainor.SubmitChanges()



                        'EmployeeId = TblEmployeeBindingSource.Current.Id
                        'CanAssignHolidays = True
                    End If

                End If


                ' ''''''''''save Employee job''''''''''''''''
                If StatusId = EmployeeStatusId Then
                    If deleteJobList.Count > 0 Then
                        For i As Integer = 0 To deleteJobList.Count - 1
                            Dim id1 As Integer = deleteJobList.Item(i)
                            Dim EmpJob = (From aX In aMainor.TblEmployeeJobs Where aX.Id = id1).ToList(0)
                            aMainor.TblEmployeeJobs.DeleteOnSubmit(EmpJob)
                            aMainor.SubmitChanges()
                        Next
                    End If

                    For i As Integer = 0 To TblEmployeeJobBindingSource.Count - 1

                        Dim EmpId As Integer = TblEmployeeJobBindingSource(i).Id
                        If EmpId = 0 Then

                            'TblEmployeeJobBindingSource(i).DateOfEmployment = DateTime.Now   '     DateOfEmploymentTimePicker.Value
                            TblEmployeeJobBindingSource(i).employeeid = EmployeeId
                            aMainor.TblEmployeeJobs.InsertOnSubmit(TblEmployeeJobBindingSource(i))
                            aMainor.SubmitChanges()
                        Else
                            Dim Old = (From aX In aMainor.TblEmployeeJobs Where aX.Id = EmpId).ToList(0)
                            Dim newJ As TblEmployeeJob = TblEmployeeJobBindingSource(i)
                            Old.DateOfEmployment = newJ.DateOfEmployment
                            Old.JobId = newJ.JobId
                            Old.DepId = newJ.DepId
                            Old.EmployeeDegreeId = newJ.EmployeeDegreeId
                            aMainor.SubmitChanges()
                        End If
                    Next
                End If

                If StatusId = EmployeeStatusId Then
                    If CanAssignHolidays Then
                        aMainor.AssignHolidaysToEmplyee(EmployeeId)
                    End If
                    CanAssignHolidays = False
                End If


                If StatusId = EmployeeStatusId Then
                    EmployeeId = (From AX In aMainor.TblEmployees Where AX.ApplicantId = Id Select AX.Id).ToList(0)
                    Dim res = (From ax In aMainor.TblEmployeeSalary2s Where ax.EmployeeID = EmployeeId).ToList
                    If res.Count > 0 Then
                        aMainor.TblEmployeeSalary2s.DeleteAllOnSubmit(res)
                        aMainor.SubmitChanges()
                    End If

                    For i = 0 To TblEmployeeSalary2BindingSource.Count - 1
                        '  If Not TblEmployeeSalary2BindingSource(i).Current Is Nothing Then

                        Dim x As New TblEmployeeSalary2

                        x.EmployeeID = EmployeeId
                        x.EmployeeSalaryID = TblEmployeeSalary2BindingSource(i).EmployeeSalaryID
                        x.SalaryCatID = TblEmployeeSalary2BindingSource(i).SalaryCatID
                        x.Value = TblEmployeeSalary2BindingSource(i).Value
                        x.Unit = TblEmployeeSalary2BindingSource(i).Unit
                        x.Note = TblEmployeeSalary2BindingSource(i).Note

                        aMainor.TblEmployeeSalary2s.InsertOnSubmit(x)
                        aMainor.SubmitChanges()
                        '  End If
                    Next


                End If


                ''''''''''''''''''''''''''''''''''''''''''''''''save employee vacation '''''''''''''''''''''''''
                If StatusId = EmployeeStatusId Then
                    EmployeeId = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)

                    If DeleteVacationList.Count > 0 Then
                        For i As Integer = 0 To DeleteVacationList.Count - 1
                            Dim id1 As Integer = DeleteVacationList.Item(i)
                            Dim Vacation = (From aX In aMainor.TblEmployeeVacations Where aX.Id = id1).ToList(0)
                            aMainor.TblEmployeeVacations.DeleteOnSubmit(Vacation)
                            aMainor.SubmitChanges()
                        Next
                    End If




                    For i As Integer = 0 To TblEmployeeVacationBindingSource.Count - 1

                        Dim EmpVacId As Integer = TblEmployeeVacationBindingSource(i).Id
                        TblEmployeeVacationBindingSource(i).Year = selectedDate.Year
                        TblEmployeeVacationBindingSource(i).employeeId = EmployeeId
                        If EmpVacId = 0 Then
                            If Not TblEmployeeVacationBindingSource(i).vacationid = YearlyVacationId Then
                                TblEmployeeVacationBindingSource(i).executedDays = TblEmployeeVacationBindingSource(i).numberofDays
                            Else
                                TblEmployeeVacationBindingSource(i).executedDays = 0
                            End If
                            aMainor.TblEmployeeVacations.InsertOnSubmit(TblEmployeeVacationBindingSource(i))
                            aMainor.SubmitChanges()


                        Else
                            Dim Old = (From aX In aMainor.TblEmployeeVacations Where aX.Id = EmpVacId).ToList(0)
                            Dim newItem As TblEmployeeVacation = TblEmployeeVacationBindingSource(i)

                            Old.Date = newItem.Date
                            Old.VacationId = newItem.VacationId
                            Old.NumberOfDays = newItem.NumberOfDays
                            Old.Year = newItem.Year
                            aMainor.SubmitChanges()
                            'If TblEmployeeVacationBindingSource(i).vacationId = YearlyVacationId Then
                            'Else
                            '    Old.ExecutedDays = newItem.NumberOfDays
                            'End If
                        End If

                    Next
                End If


                '''''''''''''''''''''''''''''''save EmployeePA ''''''''''''''''''''''''''''''''''''''''''''''
                If StatusId = EmployeeStatusId Then
                    EmployeeId = (From AX In aMainor.TblEmployees Where AX.ApplicantId = Id Select AX.Id).ToList(0)
                    Dim res = (From ax In aMainor.TblEmployeePAs Where ax.EmployeeId = EmployeeId).ToList
                    If res.Count > 0 Then
                        aMainor.TblEmployeePAs.DeleteAllOnSubmit(res)
                        aMainor.SubmitChanges()
                    End If

                    For i = 0 To AveragePAPerTaskForEmployeeResultBindingSource.Count - 1
                        If Not AveragePAPerTaskForEmployeeResultBindingSource(i).ratio Is Nothing Then
                            Dim t As Decimal
                            Dim y As Decimal = Decimal.TryParse(AveragePAPerTaskForEmployeeResultBindingSource(i).ratio, t)
                            Dim x As New TblEmployeePA
                            x.EmployeeId = EmployeeId
                            x.AveragePAPerTaskId = AveragePAPerTaskForEmployeeResultBindingSource(i).AvgPAPerTaskId
                            x.Ratio = t
                            x.Note = AveragePAPerTaskForEmployeeResultBindingSource(i).note
                            x.EvaluatedById = MyEmployeeId
                            x.EvaluatedDate = Date.Now
                            aMainor.TblEmployeePAs.InsertOnSubmit(x)
                            aMainor.SubmitChanges()
                        End If
                    Next


                End If

                '''''''''''''''''''''''''''save motivation ''''''''''''''''''''''''''''''''''''''''''''''''''
                If deleteMotivationPunishmentList.Count > 0 Then
                    For i As Integer = 0 To deleteMotivationPunishmentList.Count - 1
                        Dim id1 As Integer = deleteMotivationPunishmentList.Item(i)
                        Dim Mot = (From aX In aMainor.TblMotivationPunishments Where aX.Id = id1).ToList(0)
                        aMainor.TblMotivationPunishments.DeleteOnSubmit(Mot)
                        aMainor.SubmitChanges()
                    Next
                End If

                For i As Integer = 0 To TblMotivationPunishmentBindingSource.Count - 1
                    Dim MotId As Integer = TblMotivationPunishmentBindingSource(i).Id
                    If MotId = 0 Then
                        TblMotivationPunishmentBindingSource(i).EmployeeId = EmployeeId
                        aMainor.TblMotivationPunishments.InsertOnSubmit(TblMotivationPunishmentBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblMotivationPunishments Where aX.Id = MotId).ToList(0)
                        Dim NewMotivationPunsh As TblMotivationPunishment = TblMotivationPunishmentBindingSource(i)
                        Old.EmployeeId = NewMotivationPunsh.EmployeeId
                        Old.IsMotivation = NewMotivationPunsh.IsMotivation
                        Old.MotivationPunishmentTypeId = NewMotivationPunsh.MotivationPunishmentTypeId
                        Old.Note = NewMotivationPunsh.Note
                        Old.Reason = NewMotivationPunsh.Reason
                        Old.Date = NewMotivationPunsh.Date


                    End If
                    aMainor.SubmitChanges()

                Next


                ''''''''''''''''''''''''''''''''''''''''Save Leave Permission ''''''''''''''''''''

                If DeleteleavePermissionList.Count > 0 Then
                    For i As Integer = 0 To DeleteleavePermissionList.Count - 1
                        Dim id1 As Integer = DeleteleavePermissionList.Item(i)
                        Dim Leave = (From aX In aMainor.TblLeavePermissions Where aX.Id = id1).ToList(0)
                        aMainor.TblLeavePermissions.DeleteOnSubmit(Leave)
                        aMainor.SubmitChanges()
                    Next
                End If


                For i As Integer = 0 To TblLeavePermissionBindingSource.Count - 1
                    Dim LeaveId As Integer = TblLeavePermissionBindingSource(i).Id
                    If LeaveId = 0 Then
                        TblLeavePermissionBindingSource(i).EmployeeId = EmployeeId
                        aMainor.TblLeavePermissions.InsertOnSubmit(TblLeavePermissionBindingSource(i))
                    Else
                        Dim Old = (From aX In aMainor.TblLeavePermissions Where aX.Id = LeaveId).ToList(0)
                        Dim NewLeave As TblLeavePermission = TblLeavePermissionBindingSource(i)
                        Old.Date = NewLeave.Date
                        Old.EndTime = NewLeave.EndTime
                        Old.StartTime = NewLeave.StartTime
                        Old.Reason = NewLeave.Reason
                        Old.isBusiness = NewLeave.isBusiness

                    End If
                    aMainor.SubmitChanges()

                Next

                ''''''''''''''''''''''''''save ExecutedDateVacation ''''''''''''''
                'If TblExecuteDateFromVacationBindingSource.Count > 0 Then
                '    aMainor.TblExecuteDateFromVacations.InsertOnSubmit(TblExecuteDateFromVacationBindingSource.Current)
                '    aMainor.SubmitChanges()
                '    Dim vacationId As Integer = TblExecuteDateFromVacationBindingSource.Current.VacationId
                '    Dim NumberOfDays As Integer = TblExecuteDateFromVacationBindingSource.Current.NumberOfDays

                '    Dim oldV As TblVacation = (From ax In aMainor.TblVacations Where ax.Id = vacationId).ToList(0)
                '    oldV.ExecutedDays = oldV.ExecutedDays + NumberOfDays
                '    aMainor.SubmitChanges()
                'End If

                ''''''''''''''''''''''''''save Vacation ''''''''''''''

                'For i As Integer = 0 To TblVacationBindingSource.Count - 1
                '    Dim VacId As Integer = TblVacationBindingSource(i).Id
                '    If VacId = 0 Then

                '        Dim EmpId As Integer = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id Select ax.Id).ToList(0)
                '        TblVacationBindingSource(i).EmployeeId = EmpId
                '        aMainor.TblVacations.InsertOnSubmit(TblVacationBindingSource(i))
                '        'Else
                '        '    Dim Old As TblVacation = (From aX In aMainor.TblVacations Where aX.Id = VacId).ToList(0)
                '        '    Dim NEWVac As TblVacation = TblVacationBindingSource(i)
                '        '    Old.EmployeeId = NEWVac.EmployeeId
                '        '    Old.Description = NEWVac.Description
                '        '    Old.ExecutedDays = NEWVac.ExecutedDays
                '        '    Old.NumberOfDays = NEWVac.NumberOfDays
                '        '    Old.VacationDate = NEWVac.VacationDate
                '        '    Old.VacationTypeId = NEWVac.VacationTypeId

                '    End If
                '    aMainor.SubmitChanges()

                'Next
                'If StatusId = EmployeeStatusId Then


                '    Dim x As New FrmAssignEmployee
                '    x.ApplicantId = Id
                '    x.ShowDialog()
                '    If x.saved Then
                '        StatusId = EmployeeStatusId

                '        refreshApplicantList()
                '        refreshApplicant()
                '    End If
                'Else

                'End If
                If Not ApplicantsList.Contains(Id) Then
                    ApplicantsList.Add(Id)
                    Count = ApplicantsList.Count - 1
                End If


                PBSave.Visible = False
                PBCancel.Visible = False
                PBEdit.Visible = True
                PBAdd.Visible = True

                PBBack.Enabled = True
                PBNext.Enabled = True
                PBFirst.Enabled = True
                PBLast.Enabled = True
                PBExit.Enabled = True
                PBSearch.Enabled = True

                EnableComponents(False)

                refreshApplicant()


                'Else
                '    MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                deleteAttachmentList.Clear()
                deleteEducationList.Clear()
                deleteExperienceList.Clear()
                deleteLanguageList.Clear()
                deleteRelativeRefList.Clear()
                deleteReqJobList.Clear()
                deleteWifeList.Clear()
                deleteAddressList.Clear()
                deleteKidList.Clear()
                deleteWorkshopList.Clear()
                deleteTraineeLecturesList.Clear()
                deleteMotivationPunishmentList.Clear()
                deleteJobList.Clear()
                DeleteVacationList.Clear()
                DeleteleavePermissionList.Clear()

            End If

        End Using
    End Sub

    Private Sub TblApplicantMedicalIssueDataGridView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
        BtnNewMedicalIssue.Enabled = False
    End Sub

    Private Sub TblApplicantMedicalIssueDataGridView_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs)
        If TblApplicantMedicalIssueBindingSource.Count = 0 Then
            BtnNewMedicalIssue.Enabled = True
        End If
    End Sub

    Private Sub TblApplicantskillDataGridView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
        BtnNewSkill.Enabled = False
    End Sub

    Private Sub TblApplicantskillDataGridView_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs)
        If TblApplicantSkillBindingSource.Count = 0 Then
            BtnNewSkill.Enabled = True
        End If
    End Sub

    Private Sub PBExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBExit.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblUsers Where ax.EmployeeId = MyEmployeeId).ToList(0)
            res.LastSeen = Date.Now
            res.ComputerName = System.Windows.Forms.SystemInformation.ComputerName
            aMainor.SubmitChanges()
        End Using


        Application.Exit()


    End Sub

    'Private Sub MohafazaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MohafazaComboBox.SelectedIndexChanged, FirstNameTextBox.TextChanged, MiddleNameTextBox.TextChanged, LastNameTextBox.TextChanged,
    '                                                                                            MotherNameTextBox.TextChanged, GenderComboBox.SelectedIndexChanged, MartialStatusComboBox.SelectedIndexChanged, DateOfBirthDateTimePicker.ValueChanged,
    '                                                                                            PlaceOfBirthTextBox.TextChanged, MobileTextBox.TextChanged, NationalityComboBox.SelectedIndexChanged, RecordNumberTextBox.TextChanged,
    '                                                                                            RecordPlaceTextBox.TextChanged, KadaaComboBox.SelectedIndexChanged

    '    'ValidateApplicantInfo()
    'End Sub

    Private Sub BtnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If jobid = 0 Then
        '    Dim x As New FrmSelectJobForNewEmployee
        '    x.applicantId = Id
        '    x.ShowDialog()

        '    'Dim x As New FrmHomePage

        '    'x.PanelHome.Controls.Clear()

        '    'Dim dep As New UCDepartmentTree
        '    'dep.employees = True
        '    'dep.Size = x.PanelHome.Size
        '    'x.PanelHome.Controls.Add(dep)

        '    'x.ShowDialog()


        'Else
        '    Using aMainor As New LqHRDataContext(cnx)


        '        Dim res = (From ax In aMainOr.TblJobDescriptions Where ax.Id = jobid And ax.StillPosted = True).ToList
        '        If res.Count > 0 Then
        '            Dim y As New FrmEmp
        '            y.applicantid = Id
        '            y.jobid = jobid
        '            y.ShowDialog()
        '        Else
        '            MessageBox.Show("No more employees needed")
        '        End If

        '    End Using
        'End If

    End Sub

    Private Sub BtnNewInvolvedLectures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvolvedLectures.Click
        Dim x As New FrmTraineeLectures
        x.ApplicantId = Id
        x.fromUc = True
        x.ShowDialog()

        If x.saved Then
            TblTraineeLectureBindingSource = x.current
            TblTraineeLectureDataGridView.DataSource = TblTraineeLectureBindingSource.List
        End If


    End Sub

    Private Sub TblTraineeLectureDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTraineeLectureDataGridView.CellContentClick
        If TblTraineeLectureBindingSource.Count > 0 Then
            If e.ColumnIndex = EditLecture.Index Then
                Dim v As New BindingSource
                v = TblTraineeLectureBindingSource

                Dim x As New FrmTraineeLectures
                x.current = v
                x.ApplicantId = Id

                x.forEdit = True
                x.fromUc = True
                x.ShowDialog()
                If x.saved Then
                    TblTraineeLectureDataGridView.DataSource = Nothing
                    TblTraineeLectureDataGridView.DataSource = v.List
                End If


            End If

            If e.ColumnIndex = DeleteLecture.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblTraineeLectureBindingSource.Current.id
                        TblTraineeLectureBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteTraineeLecturesList.Add(Id)
                        End If
                    End Using
                End If
            End If
        End If
    End Sub

    Private Sub TblTraineeLectureDataGridView_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)
        BtnNewInvolvedLectures.Enabled = False
    End Sub

    Private Sub BtnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAssign.Click
        If Id > 0 Then

            If StatusId = ApplicantStatusId Then
                Dim answer = MessageBox.Show("Are you sure you want to Assign This Applicant To Trainee?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    Dim x As New FrmTraineeLectures
                    x.ApplicantId = Id
                    x.ForAssigning = True
                    x.ShowDialog()
                    If x.saved Then
                        'StatusId = TraineeStatusId

                        refreshApplicantList()
                        If ApplicantsList.Count > 0 Then
                            Id = ApplicantsList(0)
                            refreshApplicant()
                        Else
                            AddNew()
                        End If
                    End If

                    x.Dispose()

                End If

            ElseIf StatusId = EmployeeStatusId
                Dim answer = MessageBox.Show("Are you sureyou want to unemployment this employee?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim res = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                        res.StatusId = UnemploymentStatusId
                        aMainor.SubmitChanges()
                        'StatusId = RetiredStatusId
                        refreshApplicantList()
                        If ApplicantsList.Count > 0 Then
                            Id = ApplicantsList(0)
                            refreshApplicant()
                        Else
                            AddNew()
                        End If
                    End Using


                End If
            End If

        End If
    End Sub

    Private Sub BtnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewJob.Click
        Dim x As New FrmAssignAsEmployee
        If Id > 0 Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                If res.StatusId = EmployeeStatusId Then
                    Dim Res2 = (From ax In aMainor.TblEmployees Where ax.ApplicantId = Id).ToList(0)
                    x.currentEmployee = Res2
                    x.currentEmployeeJob = TblEmployeeJobBindingSource.Current
                    ' x.currentEmployeeSalary = TblEmployeeSalaryBindingSource.Current
                    'boolean to show the employee if already exists
                End If
            End Using
        Else
            If TblEmployeeJobBindingSource.Count > 0 Then
                x.ExstRow = True
                x.currentEmployee = TblEmployeeBindingSource.Current
                x.currentEmployeeJob = TblEmployeeJobBindingSource.Current
                '  x.currentEmployeeSalary = TblEmployeeSalaryBindingSource.Current
            End If


        End If
        x.fromuc = True
        x.ApplicantId = Id
        x.ShowDialog()

        If x.saved Then
            Using aMainor As New LqHRDataContext(cnx)
                TblJobDescriptionBindingSource1.DataSource = aMainor.TblJobDescriptions.ToList
                TblDepartmentBindingSource1.DataSource = aMainor.TblDepartments.ToList
                TblContractTypeBindingSource.DataSource = aMainor.TblContractTypes.ToList
            End Using

            TblEmployeeBindingSource.DataSource = x.currentEmployee
            'Add(x.currentEmployee)
            TblEmployeeJobBindingSource.Add(x.currentEmployeeJob)
            '  TblEmployeeSalaryBindingSource.DataSource = x.currentEmployeeSalary
            ' TblEmployeeJobDataGridView.DataSource = TblEmployeeJobBindingSource.List

        End If

        x.Dispose()
    End Sub

    Private Sub BtnAssignEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAssignEmployee.Click
        If Id > 0 Then

            If StatusId = ApplicantStatusId Or StatusId = TraineeStatusId Then
                Dim answer = MessageBox.Show("Are You Sure You Want To Assign This To Employee?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then

                    Dim x As New FrmAssignAsEmployee
                    x.ApplicantId = Id
                    'x.fromuc = True
                    x.ShowDialog()
                    If x.saved Then
                        ' StatusId = EmployeeStatusId

                        refreshApplicantList()
                        If ApplicantsList.Count > 0 Then
                            Id = ApplicantsList(0)
                            refreshApplicant()
                        Else
                            AddNew()
                        End If


                    End If

                    x.Dispose()
                End If
            ElseIf StatusId = EmployeeStatusId Then
                Dim answer = MessageBox.Show("Are You Sure You Want To Retire This Employee?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim res = (From ax In aMainor.TblApplicants Where ax.Id = Id).ToList(0)
                        res.StatusId = RetiredStatusId
                        aMainor.SubmitChanges()
                        'StatusId = RetiredStatusId
                        refreshApplicantList()
                        If ApplicantsList.Count > 0 Then
                            Id = ApplicantsList(0)
                            refreshApplicant()
                        Else
                            AddNew()
                        End If
                    End Using


                End If

            End If
        End If


    End Sub

    Private Sub TblEmployeeJobDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeJobDataGridView.CellContentClick
        If TblEmployeeJobBindingSource.Count > 0 Then
            Dim ApplId = Id
            If e.ColumnIndex = EditJob.Index Then

                Dim v As New TblEmployee
                If ApplId > 0 Then
                    Using aMainor As New LqHRDataContext(cnx)
                        v = (From ax In aMainor.TblEmployees Where ax.ApplicantId = ApplId).ToList(0)
                    End Using
                Else
                    v = TblEmployeeBindingSource.Current
                End If


                Dim r As New TblEmployee
                r.ApplicantId = v.ApplicantId
                r.BatchNumber = v.BatchNumber
                r.CardLabelName = v.CardLabelName
                r.CardNumber = v.CardNumber
                ' r.PIN = v.PIN

                Dim v1 As New TblEmployeeJob
                v1 = TblEmployeeJobBindingSource.Current

                Dim r1 As New TblEmployeeJob
                r1.JobId = v1.JobId
                r1.DepId = v1.DepId
                r1.ContractTypeId = v1.ContractTypeId
                r1.Note = v1.Note
                r1.EmployeeDegreeId = v1.EmployeeDegreeId
                r1.DateOfEmployment = v1.DateOfEmployment
                Dim Id As Integer = TblEmployeeJobBindingSource.Current.Id
                Dim x As New FrmAssignAsEmployee
                x.currentEmployee = r
                x.currentEmployeeJob = r1

                x.ForEdit = True
                x.fromuc = True
                x.ShowDialog()
                If x.saved Then
                    v.ApplicantId = r.ApplicantId

                    v.BatchNumber = r.BatchNumber
                    v.CardLabelName = r.CardLabelName
                    v.CardNumber = r.CardNumber
                    'v.PIN = r.PIN
                    v1.JobId = r1.JobId
                    v1.DepId = r1.DepId
                    v1.ContractTypeId = r1.ContractTypeId
                    v1.Note = r1.Note
                    v1.EmployeeDegreeId = r1.EmployeeDegreeId
                    v1.DateOfEmployment = r1.DateOfEmployment
                    currentEmployee = v
                End If

                x.Dispose()
            End If
        End If
        If e.ColumnIndex = DeleteJob.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblEmployeeJobBindingSource.Current.id
                    TblEmployeeJobBindingSource.RemoveCurrent()
                    TblEmployeeJobDataGridView.DataSource = TblEmployeeJobBindingSource
                    If Not Id = 0 Then
                        deleteJobList.Add(Id)
                        'Dim result = (From aX In aMainOR.TblEducations Where aX.Id = Id).ToList(0)
                        'aMainOR.TblEducations.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshEducation()

                    End If
                End Using
            End If

        End If

    End Sub

    Private Sub BtnAddMotivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMotivation.Click
        Dim x As New FrmMotivationPunishment
        x.fromUc = True
        x.applicantId = Id
        x.DateOfBirth = DateOfBirthDateTimePicker.Value
        x.ShowDialog()

        If x.saved Then
            TblMotivationPunishmentBindingSource.Add(x.current)

            ' TblMotivationPunishmentDataGridView.DataSource = TblMotivationPunishmentBindingSource.List

        End If

        x.Dispose()
    End Sub

    Private Sub TblMotivationPunishmentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMotivationPunishmentDataGridView.CellContentClick


        If TblMotivationPunishmentBindingSource.Count > 0 Then
            Dim ApplId As Integer = Id
            If e.ColumnIndex = EditMotivation.Index Then

                Dim v As New TblMotivationPunishment
                'If ApplId > 0 Then
                '    Using aMainor As New LqHRDataContext(cnx)
                '        Dim res = (From ax In aMainor.TblEmployees Where ax.ApplicantId = ApplId).ToList(0)
                '        Dim EmpId As Integer = res.Id
                '        v = (From ax In aMainor.TblMotivationPunishments Where ax.EmployeeId = EmpId).ToList(0)
                '    End Using
                'Else
                v = TblMotivationPunishmentBindingSource.Current
                'End If


                Dim r As New TblMotivationPunishment
                r.Date = v.Date
                r.IsMotivation = v.IsMotivation
                r.MotivationPunishmentTypeId = v.MotivationPunishmentTypeId
                r.Note = v.Note
                r.Reason = v.Reason
                r.EmployeeId = v.EmployeeId


                Dim Id As Integer = TblMotivationPunishmentBindingSource.Current.Id

                Dim x As New FrmMotivationPunishment
                x.foredit = True
                x.fromUc = True
                x.current = r
                x.DateOfBirth = DateOfBirthDateTimePicker.Value
                x.ShowDialog()
                If x.saved Then


                    v.IsMotivation = r.IsMotivation
                    v.MotivationPunishmentTypeId = r.MotivationPunishmentTypeId
                    v.Note = r.Note
                    v.Reason = r.Reason
                    v.EmployeeId = r.EmployeeId
                    v.Date = r.Date
                    TblMotivationPunishmentDataGridView.Refresh()
                End If


            End If
            If e.ColumnIndex = DeleteMotivation.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblMotivationPunishmentBindingSource.Current.id
                        TblMotivationPunishmentBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            deleteMotivationPunishmentList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblEducations Where aX.Id = Id).ToList(0)
                            'aMainOR.TblEducations.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshEducation()

                        End If
                    End Using
                End If

            End If

        End If
    End Sub

    Private Sub TblVacationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.ColumnIndex = AddVac.Index Then

        '    Dim VacationId As Integer = TblVacationBindingSource.Current.id
        '    Dim RemainingDays As Integer = TblVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).Value - TblVacationDataGridView.CurrentRow.Cells(ExecutedDays.Index).Value

        '    If RemainingDays > 0 Then
        '        Dim x As New FrmExecutedDateFromVacation
        '        x.VacationId = VacationId
        '        x.NumberOfdays = RemainingDays
        '        x.fromUc = True
        '        x.ShowDialog()

        '        If x.saved Then

        '            TblExecuteDateFromVacationBindingSource.Add(x.current)
        '            Dim executeDy = x.ExecuteDays
        '            TblVacationDataGridView.CurrentRow.Cells(Remaining.Index).Value = TblVacationDataGridView.CurrentRow.Cells(NumberOfDays.Index).Value - TblVacationDataGridView.CurrentRow.Cells(ExecutedDays.Index).Value - executeDy


        '        End If

        '        x.Dispose()
        '    Else
        '        MessageBox.Show("No more remaining Days")
        '    End If

        'End If
    End Sub

    Private Sub BloodIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub AveragePAPerTaskForEmployeeResultDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AveragePAPerTaskForEmployeeResultDataGridView.CellEndEdit
        If e.ColumnIndex = Ratio.Index Then


            Dim y As Decimal
            If AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio IsNot Nothing Then

                If Not Decimal.TryParse(AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio, y) Then
                    MessageBox.Show("enter a valid number ")
                    AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio = Nothing
                Else

                    If AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio > AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(AverageCol.Index).Value Then
                        MessageBox.Show("Ration is impossible")
                        AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio = Nothing

                    End If
                End If


            End If
        End If
    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellContentClick
        If e.ColumnIndex = Details.Index Then
            If TblEmployeeVacationBindingSource.Count > 0 Then
                Dim id As Integer = TblEmployeeVacationBindingSource.Current.id
                Using aMainor As New LqHRDataContext(cnx)

                    'Dim res = (From ax In aMainor.TblExecuteVacationsDays Where ax.EmployeeVacationId = id).ToList
                    'If res.Count > 0 Then
                    Dim RestNumberOfDays As Integer = TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDaysCol.Index).Value - TblEmployeeVacationDataGridView.CurrentRow.Cells(ExecutedDaysCol.Index).Value
                    If id = 0 Then
                        MessageBox.Show("There Is No Details")
                    Else

                        Dim x As New FrmExecuteDaysFromVacationList
                        x.EmployeeVacId = id
                        x.restNumberOfDays = RestNumberOfDays
                        x.DateExecuted = TblEmployeeVacationDataGridView.CurrentRow.Cells(DateCol.Index).Value
                        x.ShowDialog()
                        refreshEmployeeVacations()
                    End If


                End Using


            End If
        End If
        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblEmployeeVacationBindingSource.Current.id
                    Dim vacId As Integer = TblEmployeeVacationBindingSource.Current.vacationId
                    If vacId = YearlyVacationId Then
                        MessageBox.Show("This vacation Cannot be deleted") 'if we clear yearly vacations must clear executedDaysFromThis Vacation
                    Else
                        TblEmployeeVacationBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            DeleteVacationList.Add(Id)
                        End If


                        'Dim result = (From aX In aMainOR.TblEducations Where aX.Id = Id).ToList(0)
                        'aMainOR.TblEducations.DeleteOnSubmit(result)
                        'aMainOR.SubmitChanges()
                        'refreshEducation()

                    End If
                End Using
            End If
        End If

    End Sub

    Private Sub BtnAddNewVacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewVacation.Click
        TblEmployeeVacationBindingSource.AddNew()

    End Sub

    Private Sub TblEmployeeVacationDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeVacationDataGridView.CellEndEdit
        Using aMainor As New LqHRDataContext(cnx)
            If e.ColumnIndex = VacationCol.Index Then


                Dim x As Integer = TblEmployeeVacationBindingSource.Current.vacationId
                If Not x = 0 Then
                    Dim r As TblVacation = (From ax In aMainor.TblVacations Where ax.Id = x).ToList(0)
                    If Not r.NumberOfDays = 0 Then
                        TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDaysCol.Index).ReadOnly = True
                        TblEmployeeVacationBindingSource.Current.NumberOfDays = r.NumberOfDays
                    Else
                        TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDaysCol.Index).ReadOnly = False
                    End If
                End If

            End If

        End Using
    End Sub

    Private Sub AveragePAPerTaskForEmployeeResultDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        If e.ColumnIndex = Ratio.Index Then
            MessageBox.Show("enter a valid number")
            AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value = Nothing

        End If
    End Sub

    Private Sub BtnNewLeavePermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLeavePermission.Click
        Dim x As New FrmLeavePermission
        x.FromUc = True
        x.ShowDialog()
        If x.saved Then
            TblLeavePermissionBindingSource.Add(x.current)

        End If

        x.Dispose()
    End Sub

    Private Sub TblLeavePermissionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblLeavePermissionDataGridView.CellContentClick
        If TblLeavePermissionBindingSource.Count > 0 Then
            Dim ApplId As Integer = Id
            If e.ColumnIndex = EditLeave.Index Then

                Dim v As New TblLeavePermission
                'If ApplId > 0 Then
                '    Using aMainor As New LqHRDataContext(cnx)
                '        Dim res = (From ax In aMainor.TblEmployees Where ax.ApplicantId = ApplId).ToList(0)
                '        Dim EmpId As Integer = res.Id
                '        v = (From ax In aMainor.TblMotivationPunishments Where ax.EmployeeId = EmpId).ToList(0)
                '    End Using
                'Else
                v = TblLeavePermissionBindingSource.Current
                'End If


                Dim r As New TblLeavePermission
                r.Date = v.Date
                r.Accepted = v.Accepted
                r.EndTime = v.EndTime
                r.StartTime = v.StartTime
                r.isBusiness = v.isBusiness
                r.Note = v.Note
                r.Reason = v.Reason
                r.EmployeeId = v.EmployeeId


                Dim Id As Integer = TblLeavePermissionBindingSource.Current.Id
                Dim x As New FrmLeavePermission
                x.current = r
                x.forEdit = True
                x.FromUc = True
                x.ShowDialog()
                If x.saved Then
                    v.Date = r.Date
                    v.Accepted = r.Accepted
                    v.EndTime = r.EndTime
                    v.StartTime = r.StartTime
                    v.isBusiness = r.isBusiness
                    v.Note = r.Note
                    v.Reason = r.Reason
                    v.EmployeeId = r.EmployeeId
                End If

            End If
            If e.ColumnIndex = DeleteLeave.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblLeavePermissionBindingSource.Current.id
                        TblLeavePermissionBindingSource.RemoveCurrent()
                        If Not Id = 0 Then
                            DeleteleavePermissionList.Add(Id)
                            'Dim result = (From aX In aMainOR.TblEducations Where aX.Id = Id).ToList(0)
                            'aMainOR.TblEducations.DeleteOnSubmit(result)
                            'aMainOR.SubmitChanges()
                            'refreshEducation()

                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub TblTraineePerformanceAppraisalDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTraineePerformanceAppraisalDataGridView.CellEndEdit
        If e.ColumnIndex = GradeCol.Index Then


            Dim y As Decimal
            If TblTraineePerformanceAppraisalBindingSource.Current.Grade IsNot Nothing Then

                If Not Decimal.TryParse(TblTraineePerformanceAppraisalBindingSource.Current.grade, y) Then
                    MessageBox.Show("enter a valid number ")
                    TblTraineePerformanceAppraisalBindingSource.Current.grade = ""
                Else
                    Using aMainOr As New LqHRDataContext(cnx)
                        Dim PAforTraineeId As Integer = TblTraineePerformanceAppraisalBindingSource.Current.PAForTraineeId
                        Dim avg = (From ax In aMainOr.TblPAForTraineers Where ax.id = PAforTraineeId Select ax.Average).ToList(0)
                        If TblTraineePerformanceAppraisalBindingSource.Current.grade > avg Then
                            MessageBox.Show("Invalid Ratio Value")
                            TblTraineePerformanceAppraisalDataGridView.CurrentRow.Cells(GradeCol.Index).Value = Nothing


                        End If
                    End Using


                End If


            End If

        End If
    End Sub

    Private Sub TblAttachmentsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblAttachmentsDataGridView.CellContentDoubleClick
        If TblAttachmentBindingSource.Count > 0 Then
            If e.ColumnIndex = ExpiryDateCol.Index Then
                Dim Id As Integer = TblAttachmentBindingSource.Current.id
                TblEmployeeVacationDataGridView.Enabled = False
                MonthCalendar2.Visible = True

            End If
        End If
    End Sub

    Private Sub MonthCalendar2_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

        selectedDate = MonthCalendar2.SelectionRange.Start.ToShortDateString()
        MonthCalendar2.Visible = False
        TblAttachmentsDataGridView.Enabled = True
        ' isDateSelected = True
        TblAttachmentsDataGridView.CurrentRow.Cells(ExpiryDateCol.Index).Value = selectedDate

    End Sub

    Private Sub CurrencyIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmCurrencyList
            x.ShowDialog()
            'If x.saved Then
            Using aMainor As New LqHRDataContext(cnx)
                TblCurrencyBindingSource1.DataSource = aMainor.TblCurrencies.ToList
            End Using

            'End If

            x.Dispose()
        End If
    End Sub

    Private Sub IsCashCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsCashCheckBox.Checked = True Then
            AccountNumberTextBox.Visible = False
            AccountNumberLabel.Visible = False
        Else
            AccountNumberTextBox.Visible = True
            AccountNumberLabel.Visible = True
        End If
    End Sub

    Private Sub BtAgeCalculate_Click(sender As Object, e As EventArgs) Handles BtAgeCalculate.Click
        'Dim CurrentAge As Integer = DateTime.Today.Year - DateOfBirthDateTimePicker.Value.Year
        'TextBoxAge.Text = CurrentAge.ToString()
        'TblApplicantBindingSource.Current.age = CInt(TextBoxAge.Text)

        Dim dob As DateTime
        dob = New DateTime(DateOfBirthDateTimePicker.Value.Year, DateOfBirthDateTimePicker.Value.Month, DateOfBirthDateTimePicker.Value.Day)
        Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
        Dim years As Integer, months As Integer, days As Integer
        months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

        If DateTime.Now.Day < dob.Day Then
            months -= 1
            days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
        Else
            days = DateTime.Now.Day - dob.Day
        End If
        years = Math.Floor(months / 12)
        months -= years * 12
        'MsgBox("Your age as on " & Format(Now, "dd-MMM-yyyy") & vbCrLf & years & " Years, " & months & " Months and " & days & " Days")

        TextBoxAge.Text = years.ToString + "Years" + "," + months.ToString + "Months" + "," + days.ToString + "Days"



        TblApplicantBindingSource.Current.age = TextBoxAge.Text
    End Sub

    Private Sub MohafazaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MohafazaComboBox.SelectedIndexChanged
        If MohafazaComboBox.SelectedIndex = 0 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Akkar")
        ElseIf MohafazaComboBox.SelectedIndex = 1 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Baalbek")
            KadaaComboBox.Items.Add("Hermel")
        ElseIf MohafazaComboBox.SelectedIndex = 2 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Beirut")
        ElseIf MohafazaComboBox.SelectedIndex = 3 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Rachaiya")
            KadaaComboBox.Items.Add("Western Beqaa")
            KadaaComboBox.Items.Add("Zahleh")
        ElseIf MohafazaComboBox.SelectedIndex = 4 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Aley")
            KadaaComboBox.Items.Add("Baabda")
            KadaaComboBox.Items.Add("Chouf")
            KadaaComboBox.Items.Add("Jbeil(Byblos)")
            KadaaComboBox.Items.Add("Keserwan")
            KadaaComboBox.Items.Add("Matn")
        ElseIf MohafazaComboBox.SelectedIndex = 5 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Bint Jbeil")
            KadaaComboBox.Items.Add("Hasbaya")
            KadaaComboBox.Items.Add("Marjeyoun")
            KadaaComboBox.Items.Add("Nabatiyeh")
        ElseIf MohafazaComboBox.SelectedIndex = 6 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Batroun")
            KadaaComboBox.Items.Add("Bsharri")
            KadaaComboBox.Items.Add("Koura")
            KadaaComboBox.Items.Add("Miniyeh-Danniyeh")
            KadaaComboBox.Items.Add("Tripoli")
            KadaaComboBox.Items.Add("Zgharta")
        ElseIf MohafazaComboBox.SelectedIndex = 7 Then
            KadaaComboBox.Items.Clear()
            KadaaComboBox.Items.Add("Jezzine")
            KadaaComboBox.Items.Add("Saida(Sidon)")
            KadaaComboBox.Items.Add("Tyre")
        End If
    End Sub

    Private Sub BtnCaancel_Click(sender As Object, e As EventArgs) Handles BtnCaancel.Click

        PicCanceled = True


            Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblSettings Select ax.DefaultImage).ToList(0)
            Dim stream As New MemoryStream()

            ' Dim res = (From ax In aMainor.TblAttachments Where ax.Id = AttachId Select ax.Attachmment).ToList(0)
            Dim image As Byte() = CType(res.ToArray, Byte())
            'RichTextBox1.Text = System.Text.Encoding.Default.GetString(image)
            stream.Write(image, 0, image.Length)
            Dim bitmap As New Bitmap(stream)
            PBApplicantImage.Image = bitmap
            PBApplicantImage.BackgroundImageLayout = ImageLayout.Zoom

            For i As Integer = 0 To TblAttachmentBindingSource.Count - 1
                If TblAttachmentBindingSource(i).type = "Photography" Then

                    If TblAttachmentBindingSource(i).id > 0 Then
                        deleteAttachmentList.Add(TblAttachmentBindingSource(i).id)
                        TblAttachmentBindingSource.RemoveAt(i)
                        i += 1
                    Else
                        TblAttachmentBindingSource.RemoveAt(i)
                    End If

                End If
            Next


        End Using
    End Sub

    Private Sub KadaaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KadaaComboBox.SelectedIndexChanged
        If MohafazaComboBox.SelectedIndex = 0 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Abboudieh")
            countriesCombo.Items.Add("Aidamoun – Chikhalar")
            countriesCombo.Items.Add(" Akkar el Atika")
            countriesCombo.Items.Add("Andket")
            countriesCombo.Items.Add("Ayat")
            countriesCombo.Items.Add("Bayno – Kaboula")
            countriesCombo.Items.Add("Bazbina")
            countriesCombo.Items.Add("Bebnine")
            countriesCombo.Items.Add(" Beit Mallat")
            countriesCombo.Items.Add("Berkayel")
            countriesCombo.Items.Add("Bireh")
            countriesCombo.Items.Add("Bkerezla")
            countriesCombo.Items.Add("Bourj el Arab")
            countriesCombo.Items.Add("Bourj")
            countriesCombo.Items.Add("Bzal")
            countriesCombo.Items.Add("Chadra")
            countriesCombo.Items.Add("Charbila")
            countriesCombo.Items.Add("Cheikh Mohammad")
            countriesCombo.Items.Add("Cheikh Ayyash")
            countriesCombo.Items.Add("Cheikh Taba")
            countriesCombo.Items.Add("Daher el Laysine")
            countriesCombo.Items.Add(" Deir Jennine")
            countriesCombo.Items.Add("Endkit")
            countriesCombo.Items.Add("Fnaydek")
            countriesCombo.Items.Add("Hakour")
            countriesCombo.Items.Add("Halba")
            countriesCombo.Items.Add("Hayssa")
            countriesCombo.Items.Add("Hmayra")
            countriesCombo.Items.Add(" Jdeidet el Joumeh")
            countriesCombo.Items.Add("Jdeidet el Kaiteh")
            countriesCombo.Items.Add("Jebrayel")
            countriesCombo.Items.Add("Karem Asfour – Beit Ghattas")
            countriesCombo.Items.Add("Kobayat")
            countriesCombo.Items.Add("Kobbat el Chamrat")
            countriesCombo.Items.Add("Koucha")
            countriesCombo.Items.Add("kouraybet el jindi")
            countriesCombo.Items.Add("Machta Hassan")
            countriesCombo.Items.Add("Majdla")
            countriesCombo.Items.Add("Mashha")
            countriesCombo.Items.Add(" Mazraat Baldeh")
            countriesCombo.Items.Add("Mechmech")
            countriesCombo.Items.Add("Minyara")
            countriesCombo.Items.Add("Nfaiseh")
            countriesCombo.Items.Add("Rahbeh")
            countriesCombo.Items.Add("Saysouk")
            countriesCombo.Items.Add("Sfainet el Dreib")
            countriesCombo.Items.Add("Tal Maayan")
            countriesCombo.Items.Add("Tel Abbas el Gharby")
            countriesCombo.Items.Add("Telbireh")
            countriesCombo.Items.Add("Zawarib")
            countriesCombo.Items.Add("Zouk el Hosnyeh")
            'KadaaComboBox.Items.Add("Akkar")
        ElseIf MohafazaComboBox.SelectedIndex = 1 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain")
            countriesCombo.Items.Add("Ainata")
            countriesCombo.Items.Add("Al Khodr")
            countriesCombo.Items.Add(" Al Nabi Sheet")
            countriesCombo.Items.Add("  Baalbeck")
            countriesCombo.Items.Add("Barka")
            countriesCombo.Items.Add("Bechwat")
            countriesCombo.Items.Add("Bednayel")
            countriesCombo.Items.Add("Brital")
            countriesCombo.Items.Add("Btadhi")
            countriesCombo.Items.Add("Bodai")
            countriesCombo.Items.Add("Chaat")
            countriesCombo.Items.Add("Chmestar - Gharbi Baalbeck")
            countriesCombo.Items.Add("Deir el Ahmar")
            countriesCombo.Items.Add("Douris")
            countriesCombo.Items.Add(" Fakiha – Jdeydeh")
            countriesCombo.Items.Add("  Flaoui (Fleweh)")
            countriesCombo.Items.Add("Hadath Baalbeck")
            countriesCombo.Items.Add("Harbata")
            countriesCombo.Items.Add("Hizzine")
            countriesCombo.Items.Add("Hlabta")
            countriesCombo.Items.Add("  Hosh Barada")
            countriesCombo.Items.Add("  Hosh el Rafika")
            countriesCombo.Items.Add("Hosh Snid")
            countriesCombo.Items.Add(" Hosh Tal Safiya")
            countriesCombo.Items.Add("Iaat")
            countriesCombo.Items.Add("Jabbouleh")
            countriesCombo.Items.Add("Janta")
            countriesCombo.Items.Add("Khraibeh")
            countriesCombo.Items.Add("Ksarnaba")
            countriesCombo.Items.Add("Labweh")
            countriesCombo.Items.Add("Majdloun")
            countriesCombo.Items.Add("Makneh")
            countriesCombo.Items.Add("  Nabi Othman")
            countriesCombo.Items.Add("Qaa")
            countriesCombo.Items.Add("Qarha")
            countriesCombo.Items.Add("  Ram – Jbenniyeh")
            countriesCombo.Items.Add("Ras Baalbeck")
            countriesCombo.Items.Add("Saayde")
            countriesCombo.Items.Add("Seriine el Fawka")
            countriesCombo.Items.Add("Seriine el Tahta")
            countriesCombo.Items.Add("Shleefa")
            countriesCombo.Items.Add("Talya")
            countriesCombo.Items.Add("Taraya")
            countriesCombo.Items.Add("Tayba")
            countriesCombo.Items.Add("Temnin el Fawka")
            countriesCombo.Items.Add("Temnin el Tahta")
            countriesCombo.Items.Add(" Wadi Faara")
            countriesCombo.Items.Add("Yammouneh")
            countriesCombo.Items.Add("Younine")
            'KadaaComboBox.Items.Add("Baalbek")

        ElseIf MohafazaComboBox.SelectedIndex = 1 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Chawaghir el Fawka Wal Tahta")
            countriesCombo.Items.Add("Hermel")
            countriesCombo.Items.Add("Jouar el Hachich")
            countriesCombo.Items.Add("Kasser – Fisane")
            countriesCombo.Items.Add("Kouakh")

            ' KadaaComboBox.Items.Add("Hermel")

        ElseIf MohafazaComboBox.SelectedIndex = 2 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Beirut")

            'KadaaComboBox.Items.Add("Beirut")

        ElseIf MohafazaComboBox.SelectedIndex = 3 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain Arab")
            countriesCombo.Items.Add("Ain Ata")
            countriesCombo.Items.Add("Ain Harcha")
            countriesCombo.Items.Add("Akabeh")
            countriesCombo.Items.Add("Ayha")
            countriesCombo.Items.Add("Ayta el Fekhar")
            countriesCombo.Items.Add("Bakifa")
            countriesCombo.Items.Add("Bakka")
            countriesCombo.Items.Add("Beit Lahya")
            countriesCombo.Items.Add("Bireh")
            countriesCombo.Items.Add("Daher el Ahmar")
            countriesCombo.Items.Add("Deir el Achayer")
            countriesCombo.Items.Add("Helwa")
            countriesCombo.Items.Add("Hoch")
            countriesCombo.Items.Add("Kawkaba")
            countriesCombo.Items.Add("Kfar Danis")
            countriesCombo.Items.Add("Kfarfouk")
            countriesCombo.Items.Add("Kfarmechki")
            countriesCombo.Items.Add("Kherbet Rouha")
            countriesCombo.Items.Add("Majdel Balhiss")
            countriesCombo.Items.Add("Mdoukha")
            countriesCombo.Items.Add("Mhaydseh")
            countriesCombo.Items.Add("Rachaya")
            countriesCombo.Items.Add("Rafid")
            countriesCombo.Items.Add("Tannoura")
            countriesCombo.Items.Add("Yanta")

            'KadaaComboBox.Items.Add("Rachaiya")


        ElseIf MohafazaComboBox.SelectedIndex = 3 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain el Tineh")
            countriesCombo.Items.Add(" Ain Zebdeh")
            countriesCombo.Items.Add("Ammik")
            countriesCombo.Items.Add("Ana")
            countriesCombo.Items.Add("Aytanit")
            countriesCombo.Items.Add("Baaloul")
            countriesCombo.Items.Add(" Bab Mareh")
            countriesCombo.Items.Add("Ghaza")
            countriesCombo.Items.Add("Jeb Jennine")
            countriesCombo.Items.Add("Kamed el Laouz")
            countriesCombo.Items.Add("Karaoun")
            countriesCombo.Items.Add("Kefraya")
            countriesCombo.Items.Add("Kelya")
            countriesCombo.Items.Add("Kherbet Kanafar")
            countriesCombo.Items.Add("Lala")
            countriesCombo.Items.Add("Lebbaya")
            countriesCombo.Items.Add("Machghara")
            countriesCombo.Items.Add("Manara")
            countriesCombo.Items.Add("Mansoura")
            countriesCombo.Items.Add("Marej")
            countriesCombo.Items.Add("Maydoun")
            countriesCombo.Items.Add("Saghbine")
            countriesCombo.Items.Add("Sohmor")
            countriesCombo.Items.Add("Souairy")
            countriesCombo.Items.Add("Sultan Yaakoub")
            countriesCombo.Items.Add("Yehmor")

            'KadaaComboBox.Items.Add("Western Beqaa")

        ElseIf MohafazaComboBox.SelectedIndex = 3 And KadaaComboBox.SelectedIndex = 2 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ablah")
            countriesCombo.Items.Add("Ain Kfarzabad")
            countriesCombo.Items.Add("Ali el Nahri")
            countriesCombo.Items.Add("Bar Elias")
            countriesCombo.Items.Add("Bouarej")
            countriesCombo.Items.Add("Chtaura")
            countriesCombo.Items.Add("Deir el Ghazal")
            countriesCombo.Items.Add("Ferzol")
            countriesCombo.Items.Add("Hay el Fikany")
            countriesCombo.Items.Add("Hezerta")
            countriesCombo.Items.Add("Hoch Moussa – Anjar")
            countriesCombo.Items.Add("Jdita")
            countriesCombo.Items.Add("Kaah el Rim")
            countriesCombo.Items.Add("Kab Elias – Wadi el Deloum")
            countriesCombo.Items.Add("Kfarzabad")
            countriesCombo.Items.Add("Kousaya")
            countriesCombo.Items.Add(" Majdel Anjar")
            countriesCombo.Items.Add("Massa")
            countriesCombo.Items.Add("Mekssi")
            countriesCombo.Items.Add("Mrayjat")
            countriesCombo.Items.Add("Nabi Ayla")
            countriesCombo.Items.Add(" Niha Bekaa")
            countriesCombo.Items.Add("Rhit")
            countriesCombo.Items.Add("Riyak – Hoch Hala")
            countriesCombo.Items.Add("Saadnayel")
            countriesCombo.Items.Add("Taalabaya")
            countriesCombo.Items.Add("Taanayel")
            countriesCombo.Items.Add("Terbol")
            countriesCombo.Items.Add("Zahlé – Maalaka")

            ' KadaaComboBox.Items.Add("Zahleh")

        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Abey – Ain Drafil")
            countriesCombo.Items.Add("Aghmid")
            countriesCombo.Items.Add("Ain Dara")
            countriesCombo.Items.Add("Ain el Remmaneh")
            countriesCombo.Items.Add("Ain el Saydeh")
            countriesCombo.Items.Add("Ain Jedideh")
            countriesCombo.Items.Add("Ain Ksour")
            countriesCombo.Items.Add("Aïn Onoub")
            countriesCombo.Items.Add("Ainab")
            countriesCombo.Items.Add("Aley")
            countriesCombo.Items.Add("Aramoun")
            countriesCombo.Items.Add("Baawerta")
            countriesCombo.Items.Add("Badghan")
            countriesCombo.Items.Add("Bassatine")
            countriesCombo.Items.Add("Bayssour")
            countriesCombo.Items.Add("Bchamoun")
            countriesCombo.Items.Add("Bdadoun")
            countriesCombo.Items.Add("Bennay")
            countriesCombo.Items.Add("Bhamdoun el Balda")
            countriesCombo.Items.Add("Bhamdoun el Mhatta")
            countriesCombo.Items.Add("Bkhechtey")
            countriesCombo.Items.Add("Bleibel")
            countriesCombo.Items.Add("Bmakkine")
            countriesCombo.Items.Add("Bmahray")
            countriesCombo.Items.Add("Bsouss")
            countriesCombo.Items.Add("Btalloun")
            countriesCombo.Items.Add("Btater")
            countriesCombo.Items.Add("Chanay")
            countriesCombo.Items.Add("Charoun")
            countriesCombo.Items.Add("Chartoun")
            countriesCombo.Items.Add("Chemlan")
            countriesCombo.Items.Add("Choueifat")
            countriesCombo.Items.Add("Deir Koubel")
            countriesCombo.Items.Add("Dfoun")
            countriesCombo.Items.Add("Eitat")
            countriesCombo.Items.Add("Houmal")
            countriesCombo.Items.Add("Kehaleh")
            countriesCombo.Items.Add("Keyfoun")
            countriesCombo.Items.Add("Kfaraamey")
            countriesCombo.Items.Add("Kfar Matta")
            countriesCombo.Items.Add("Kommatyeh")
            countriesCombo.Items.Add("Majdelbaana")
            countriesCombo.Items.Add("Mansourieh, Aley – Ain el Marej")
            countriesCombo.Items.Add("Mecherfeh")
            countriesCombo.Items.Add("Mejdlaya, Aley")
            countriesCombo.Items.Add("Ramlieh")
            countriesCombo.Items.Add("Ras el jabal")
            countriesCombo.Items.Add("Rechmaya")
            countriesCombo.Items.Add("Rejmeh")
            countriesCombo.Items.Add("Remhala")
            countriesCombo.Items.Add("Rouaysset el Neeman")
            countriesCombo.Items.Add("Saoufar")
            countriesCombo.Items.Add("Souk el Ghareb")
            countriesCombo.Items.Add("Taazanieh")
            countriesCombo.Items.Add("Wadi Chahrour")


            'KadaaComboBox.Items.Add("Aley")

        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Abadiyeh")
            countriesCombo.Items.Add("Araya")
            countriesCombo.Items.Add("Arbaniyeh – Dlaybeh")
            countriesCombo.Items.Add("Arsoun")
            countriesCombo.Items.Add("Baabda")
            countriesCombo.Items.Add("Baalchmay")
            countriesCombo.Items.Add(" Betchay – Al Mardacha")
            countriesCombo.Items.Add("Bmaryam")
            countriesCombo.Items.Add("Bourj el-Barajneh")
            countriesCombo.Items.Add("Bsaba, Baabda")
            countriesCombo.Items.Add("Btekhney")
            countriesCombo.Items.Add("Bzebdine")
            countriesCombo.Items.Add("Chbeniyeh")
            countriesCombo.Items.Add("Chiyah")
            countriesCombo.Items.Add("Chouit")
            countriesCombo.Items.Add("Deir el Haref")
            countriesCombo.Items.Add("Falougha")
            countriesCombo.Items.Add("Furn el Chebbak")
            countriesCombo.Items.Add("Ghbeireh")
            countriesCombo.Items.Add("Hadath")
            countriesCombo.Items.Add("Hammana")
            countriesCombo.Items.Add("Haret el Sett")
            countriesCombo.Items.Add("Haret Hreik")
            countriesCombo.Items.Add("Hasbaya, Baabda")
            countriesCombo.Items.Add("Hazmieh")
            countriesCombo.Items.Add("Jouar al Hoz")
            countriesCombo.Items.Add("Jouret Arsoun")
            countriesCombo.Items.Add("Kfarchima")
            countriesCombo.Items.Add("Kfarselwan")
            countriesCombo.Items.Add("Khraybe")
            countriesCombo.Items.Add("Knayseh")
            countriesCombo.Items.Add("Kobeih")
            countriesCombo.Items.Add("Kornayel")
            countriesCombo.Items.Add("Kortada")
            countriesCombo.Items.Add("Krayeh")
            countriesCombo.Items.Add("Ksaybeh")
            countriesCombo.Items.Add("Mreijeh – Tehwitat el Ghadir – Al Laylakeh")
            countriesCombo.Items.Add("Ras el Haref")
            countriesCombo.Items.Add("Ras el Metn")
            countriesCombo.Items.Add("Rouayset el Ballout")
            countriesCombo.Items.Add("Salima")
            countriesCombo.Items.Add("Tarchich")

            'KadaaComboBox.Items.Add("Baabda")

        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 2 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain Kani")
            countriesCombo.Items.Add("Ain Wzein")
            countriesCombo.Items.Add("Ain Zhalta")
            countriesCombo.Items.Add("Ainbal")
            countriesCombo.Items.Add("Amatour")
            countriesCombo.Items.Add("Ammik")
            countriesCombo.Items.Add("Anout")
            countriesCombo.Items.Add("Atrine")
            countriesCombo.Items.Add("Baakline")
            countriesCombo.Items.Add("Baasir")
            countriesCombo.Items.Add("Baatharan")
            countriesCombo.Items.Add("Barja")
            countriesCombo.Items.Add("Barouk – Freydiss")
            countriesCombo.Items.Add("Bater")
            countriesCombo.Items.Add("Batloun")
            countriesCombo.Items.Add("Bchetfine")
            countriesCombo.Items.Add("Beiteddine")
            countriesCombo.Items.Add("Berjein & Mreyjat")
            countriesCombo.Items.Add("Bireh")
            countriesCombo.Items.Add("Botme")
            countriesCombo.Items.Add("Bsaba El Chouf")
            countriesCombo.Items.Add("Chehim")
            countriesCombo.Items.Add("Daher el Mghara")
            countriesCombo.Items.Add("Dalhoun")
            countriesCombo.Items.Add("Damour")
            countriesCombo.Items.Add("Daraya")
            countriesCombo.Items.Add("Debbieh")
            countriesCombo.Items.Add("Deir Dourit")
            countriesCombo.Items.Add("Deir el Kamar")
            countriesCombo.Items.Add("Deir Kouche")
            countriesCombo.Items.Add("Dmit")
            countriesCombo.Items.Add("Fouara")
            countriesCombo.Items.Add("Gharife")
            countriesCombo.Items.Add("Haret Jandal")
            countriesCombo.Items.Add("Hasrout")
            countriesCombo.Items.Add("Jadra")
            countriesCombo.Items.Add("Jahlieh")
            countriesCombo.Items.Add("Jbeih")
            countriesCombo.Items.Add("Jdeidet el Chouf")
            countriesCombo.Items.Add("Jiyeh")
            countriesCombo.Items.Add("Joun")
            countriesCombo.Items.Add("Kahlounie")
            countriesCombo.Items.Add("Ketermaya")
            countriesCombo.Items.Add("Kfarfakoud")
            countriesCombo.Items.Add("Kfarhim")
            countriesCombo.Items.Add("Kfarkatra")
            countriesCombo.Items.Add("Kfarnabrakh")
            countriesCombo.Items.Add("Kfarniss")
            countriesCombo.Items.Add("Khraybeh")
            countriesCombo.Items.Add("Knayse")
            countriesCombo.Items.Add("Maasser Beiteddine")
            countriesCombo.Items.Add("Maasser el Chouf")
            countriesCombo.Items.Add("Majdel Meouch")
            countriesCombo.Items.Add("Mazboud")
            countriesCombo.Items.Add("Mazraat el Chouf")
            countriesCombo.Items.Add("Mazraat el Daher")
            countriesCombo.Items.Add("Mechref")
            countriesCombo.Items.Add("Mghayrie")
            countriesCombo.Items.Add("Mokhtara")
            countriesCombo.Items.Add("Mristeh")
            countriesCombo.Items.Add("Naameh")
            countriesCombo.Items.Add("Niha Chouf")
            countriesCombo.Items.Add("Rmayle")
            countriesCombo.Items.Add("Sebline")
            countriesCombo.Items.Add("Semkanieh")
            countriesCombo.Items.Add("Serjbeil")
            countriesCombo.Items.Add("Wadi Sit")
            countriesCombo.Items.Add("Warhanieh")
            countriesCombo.Items.Add("Werdanieh")
            countriesCombo.Items.Add("Zaarourieh")


            'KadaaComboBox.Items.Add("Chouf")

        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 3 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Afqa")
            countriesCombo.Items.Add("Ain el-Ghouaybeh")
            countriesCombo.Items.Add("Aqoura")
            countriesCombo.Items.Add("")
            countriesCombo.Items.Add("Almat – Souaneh")
            countriesCombo.Items.Add("Amsheet")
            countriesCombo.Items.Add("Kfar Baal")
            countriesCombo.Items.Add("Bechtlida – Fidar")
            countriesCombo.Items.Add("Bejjeh")
            countriesCombo.Items.Add("Berbara")
            countriesCombo.Items.Add("Blat")
            countriesCombo.Items.Add("Byblos")
            countriesCombo.Items.Add("Eddeh")
            countriesCombo.Items.Add("Ehmej")
            countriesCombo.Items.Add("Fatreh")
            countriesCombo.Items.Add("Halat")
            countriesCombo.Items.Add("Hjoula")
            countriesCombo.Items.Add("Hosrayel")
            countriesCombo.Items.Add("Hsoun")
            countriesCombo.Items.Add("Jaj")
            countriesCombo.Items.Add("Laqlouq")
            countriesCombo.Items.Add("Lassa")
            countriesCombo.Items.Add("Lehfed")
            countriesCombo.Items.Add("Mayfouk - Qattara")
            countriesCombo.Items.Add("Mazraat es-Siyad")
            countriesCombo.Items.Add("Mechmech")
            countriesCombo.Items.Add("Mejdel")
            countriesCombo.Items.Add("Mghayreh")
            countriesCombo.Items.Add("Mounsef")
            countriesCombo.Items.Add("Nahr Ibrahim")
            countriesCombo.Items.Add("Qartaba")
            countriesCombo.Items.Add("Ras Osta")
            countriesCombo.Items.Add("Tartej")
            countriesCombo.Items.Add("Yanouh")


            'KadaaComboBox.Items.Add("Jbeil(Byblos)")

        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 4 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Achkout")
            countriesCombo.Items.Add("Ain el Rihaneh")
            countriesCombo.Items.Add("Aintoura")
            countriesCombo.Items.Add("Ajaltoun")
            countriesCombo.Items.Add("Akaybeh")
            countriesCombo.Items.Add("Aramoun")
            countriesCombo.Items.Add("Azra & Ozor")
            countriesCombo.Items.Add("Ballouneh")
            countriesCombo.Items.Add("Batha")
            countriesCombo.Items.Add("Bekaatat Kenaan")
            countriesCombo.Items.Add("Bekaatat Achkout")
            countriesCombo.Items.Add("Bouar")
            countriesCombo.Items.Add("Chahtoul & Jouret Mehad")
            countriesCombo.Items.Add("Chnaniir")
            countriesCombo.Items.Add("Daraya")
            countriesCombo.Items.Add("Darooun Harissa")
            countriesCombo.Items.Add("Dlebta")
            countriesCombo.Items.Add("Faraya")
            countriesCombo.Items.Add("Fatqa")
            countriesCombo.Items.Add("Feytroun")
            countriesCombo.Items.Add("Ghazir")
            countriesCombo.Items.Add("Ghbaleh")
            countriesCombo.Items.Add("Ghedrass")
            countriesCombo.Items.Add("Ghosta")
            countriesCombo.Items.Add("Ghyneh")
            countriesCombo.Items.Add("Hiyata")
            countriesCombo.Items.Add("Hosein")
            countriesCombo.Items.Add("Hrajel")
            countriesCombo.Items.Add("Jdeideh, Keserouan – Harharaya – Kattine")
            countriesCombo.Items.Add("Jeita")
            countriesCombo.Items.Add("Jounieh")
            countriesCombo.Items.Add("Jouret Termos")
            countriesCombo.Items.Add("Kfardebiane")
            countriesCombo.Items.Add("Kfartay")
            countriesCombo.Items.Add("Kfour")
            countriesCombo.Items.Add("Kleiat")
            countriesCombo.Items.Add("Maaysra")
            countriesCombo.Items.Add("Mayrouba")
            countriesCombo.Items.Add("Raachine")
            countriesCombo.Items.Add("Rayfoun")
            countriesCombo.Items.Add("Safra")
            countriesCombo.Items.Add("Shayle")
            countriesCombo.Items.Add("Tabarja – Adma – Dafne – Kfaryassine")
            countriesCombo.Items.Add("Wata el Jawz")
            countriesCombo.Items.Add("Yahchouch")
            countriesCombo.Items.Add("Zaaytre")
            countriesCombo.Items.Add("Zeytoun")
            countriesCombo.Items.Add("Zouk Mikael")
            countriesCombo.Items.Add("Zouk Mosbeh")


            'KadaaComboBox.Items.Add("Keserwan")


        ElseIf MohafazaComboBox.SelectedIndex = 4 And KadaaComboBox.SelectedIndex = 5 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain el Safssaf – Mar Michael Bnabil")
            countriesCombo.Items.Add("Ain Saade – Beit Mery")
            countriesCombo.Items.Add("Aintoura, Metn")
            countriesCombo.Items.Add("Antelias – Naccache")
            countriesCombo.Items.Add("Ayroun")
            countriesCombo.Items.Add("Baabdat")
            countriesCombo.Items.Add("Baskinta")
            countriesCombo.Items.Add("Beit Chabab – Chaouiye & Konaytra")
            countriesCombo.Items.Add("Beit el Chaar & Hadirat")
            countriesCombo.Items.Add("Biakout")
            countriesCombo.Items.Add("Bikfaya – Mhaydseh")
            countriesCombo.Items.Add("Bourj Hammoud")
            countriesCombo.Items.Add("Broummana")
            countriesCombo.Items.Add("Bsalim – Mezher – Majzoub")
            countriesCombo.Items.Add("Bteghrine")
            countriesCombo.Items.Add("Choueir – Ain el Sendianeh")
            countriesCombo.Items.Add("Dahr el Sawan")
            countriesCombo.Items.Add("Dbayeh – Zouk al Khrab – Haret al Ballaneh – Aoukar")
            countriesCombo.Items.Add("Dekwaneh – Marroukouz – Daher al Hosein")
            countriesCombo.Items.Add("Dik El Mehdi")
            countriesCombo.Items.Add("Douar")
            countriesCombo.Items.Add("Fanar")
            countriesCombo.Items.Add("Ghabeh")
            countriesCombo.Items.Add("Ghabet Bologna – Wata el Mrouj")
            countriesCombo.Items.Add("Jal el Dib – Bkenneya")
            countriesCombo.Items.Add("Jdeideh – Bouchrieh – Sadd Bouchrieh")
            countriesCombo.Items.Add("Kaakour")
            countriesCombo.Items.Add("Kfarakab")
            countriesCombo.Items.Add("Kfertay")
            countriesCombo.Items.Add("Khenchara & Jouar")
            countriesCombo.Items.Add("Konnabat Broummana")
            countriesCombo.Items.Add("Kornet Chehwan – Ain Aar – Beit El Kekko & Hbous")
            countriesCombo.Items.Add("Majdel Tarchich")
            countriesCombo.Items.Add("Mansourieh – Mkalles – Daychounieh")
            countriesCombo.Items.Add("Mar Chaaya & Mzekke")
            countriesCombo.Items.Add("Mar Moussa – Douar")
            countriesCombo.Items.Add("Marjaba")
            countriesCombo.Items.Add("Mazraat Yachouh")
            countriesCombo.Items.Add("Mrouj")
            countriesCombo.Items.Add("Mtein & Mchikha")
            countriesCombo.Items.Add("Nabay")
            countriesCombo.Items.Add("Ouyoun")
            countriesCombo.Items.Add("Rabieh")
            countriesCombo.Items.Add("Roumieh")
            countriesCombo.Items.Add("Sakiyat al Mesek – Bhersaf")
            countriesCombo.Items.Add("Sin el Fil")
            countriesCombo.Items.Add("Zalka – Amaret Chalhoub")
            countriesCombo.Items.Add("Zarooun")
            countriesCombo.Items.Add("Zekrite")

            'KadaaComboBox.Items.Add("Matn")

        ElseIf MohafazaComboBox.SelectedIndex = 5 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ain Ebel")
            countriesCombo.Items.Add("Aynata")
            countriesCombo.Items.Add("Ayta el Chaeb")
            countriesCombo.Items.Add("Ayta el Jabal")
            countriesCombo.Items.Add("Aytaroun")
            countriesCombo.Items.Add("Beit Lif")
            countriesCombo.Items.Add("Beit Yahoun")
            countriesCombo.Items.Add("Bint Jbeil")
            countriesCombo.Items.Add("Borj Kalaway")
            countriesCombo.Items.Add("Braachit")
            countriesCombo.Items.Add("Chakra wa Doubeih")
            countriesCombo.Items.Add("Debel")
            countriesCombo.Items.Add("Deir Antar")
            countriesCombo.Items.Add("Froun")
            countriesCombo.Items.Add("Ghandouriyeh")
            countriesCombo.Items.Add("Hanine")
            countriesCombo.Items.Add("Hariss")
            countriesCombo.Items.Add("Hdatha")
            countriesCombo.Items.Add("Jmeyjmeh")
            countriesCombo.Items.Add("Kafra")
            countriesCombo.Items.Add("Kalaway")
            countriesCombo.Items.Add("Kawzah")
            countriesCombo.Items.Add("Kfardounine")
            countriesCombo.Items.Add("Khirbet Selm")
            countriesCombo.Items.Add("Kounine")
            countriesCombo.Items.Add("Maroun el Ras")
            countriesCombo.Items.Add("Ramyah")
            countriesCombo.Items.Add("Rchaf")
            countriesCombo.Items.Add("Rmeich")
            countriesCombo.Items.Add("Serbine")
            countriesCombo.Items.Add("Sultanieh")
            countriesCombo.Items.Add("Tebnine")
            countriesCombo.Items.Add("Tiri")
            countriesCombo.Items.Add("Yaroun")
            countriesCombo.Items.Add("Yater")

            ' KadaaComboBox.Items.Add("Bint Jbeil")

        ElseIf MohafazaComboBox.SelectedIndex = 5 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add(" Ain Kanya")
            countriesCombo.Items.Add("Chebaa")
            countriesCombo.Items.Add("Chwayya")
            countriesCombo.Items.Add("Fardiss")
            countriesCombo.Items.Add("Hasbaya")
            countriesCombo.Items.Add("Hbariyeh")
            countriesCombo.Items.Add("Kawkaba")
            countriesCombo.Items.Add("Kfarchouba")
            countriesCombo.Items.Add("Kfarhamam")
            countriesCombo.Items.Add("Kfeir")
            countriesCombo.Items.Add("Khalwat")
            countriesCombo.Items.Add("Mari")
            countriesCombo.Items.Add("Marj el Zhour")
            countriesCombo.Items.Add("Mimass")
            countriesCombo.Items.Add("Rachaya el Fokhar")

            'KadaaComboBox.Items.Add("Hasbaya")

        ElseIf MohafazaComboBox.SelectedIndex = 5 And KadaaComboBox.SelectedIndex = 2 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Adayseh")
            countriesCombo.Items.Add("Adchit")
            countriesCombo.Items.Add("Bani Hayann")
            countriesCombo.Items.Add("Blatt")
            countriesCombo.Items.Add("Blida")
            countriesCombo.Items.Add("Debbine")
            countriesCombo.Items.Add("Deir Mimass")
            countriesCombo.Items.Add("Deir Syriane")
            countriesCombo.Items.Add("Ebel el Saky")
            countriesCombo.Items.Add("Houla")
            countriesCombo.Items.Add("Jdeidet Marjeeyoun")
            countriesCombo.Items.Add("Kabrikha")
            countriesCombo.Items.Add("Kantara")
            countriesCombo.Items.Add("Kfarkila")
            countriesCombo.Items.Add("Khiam")
            countriesCombo.Items.Add("Klayaa")
            countriesCombo.Items.Add("Majdel Selem")
            countriesCombo.Items.Add("Markaba")
            countriesCombo.Items.Add("Mays el Jabal")
            countriesCombo.Items.Add("Rab Thalathine")
            countriesCombo.Items.Add("Sawaneh")
            countriesCombo.Items.Add("Tallousseh")
            countriesCombo.Items.Add("Taybeh")
            countriesCombo.Items.Add("Wazzany")

            ' KadaaComboBox.Items.Add("Marjeyoun")

        ElseIf MohafazaComboBox.SelectedIndex = 5 And KadaaComboBox.SelectedIndex = 3 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Adchit")
            countriesCombo.Items.Add("Ain Kana")
            countriesCombo.Items.Add("Ansar")
            countriesCombo.Items.Add("Arabsalim")
            countriesCombo.Items.Add("Arnoun")
            countriesCombo.Items.Add("Breykaah")
            countriesCombo.Items.Add("Charkiyeh")
            countriesCombo.Items.Add("Choukine")
            countriesCombo.Items.Add("Deir el Zahrani")
            countriesCombo.Items.Add("Doueir")
            countriesCombo.Items.Add("Ebba")
            countriesCombo.Items.Add("Habbouch")
            countriesCombo.Items.Add("Harouf")
            countriesCombo.Items.Add("Houmin el Fawka")
            countriesCombo.Items.Add("Houmin el Tahta")
            countriesCombo.Items.Add("Jarjouh")
            countriesCombo.Items.Add("Jbaah – Ain Bouswar")
            countriesCombo.Items.Add("Jebchit")
            countriesCombo.Items.Add("Kaakaiyet el Jisr")
            countriesCombo.Items.Add("Kfarfila")
            countriesCombo.Items.Add("Kfarremane")
            countriesCombo.Items.Add("Kfarsir")
            countriesCombo.Items.Add("Kfartebnit")
            countriesCombo.Items.Add("Kfour")
            countriesCombo.Items.Add("Kossaybeh")
            countriesCombo.Items.Add("Mayfadoun")
            countriesCombo.Items.Add("Nabatieh el Fawka")
            countriesCombo.Items.Add("Nabatieh el Tahta")
            countriesCombo.Items.Add("Namiriyeh")
            countriesCombo.Items.Add("Roumine")
            countriesCombo.Items.Add("Sarba")
            countriesCombo.Items.Add("Siney")
            countriesCombo.Items.Add("Sir el Gharbiyeh")
            countriesCombo.Items.Add("Yehmor el Chekif")
            countriesCombo.Items.Add("Zawtar el Charkiyeh")
            countriesCombo.Items.Add("Zawtar el Gharbiyeh")
            countriesCombo.Items.Add("Zebdine")
            countriesCombo.Items.Add("Zefta")


            '  KadaaComboBox.Items.Add("Nabatiyeh")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Ajdabra")
            countriesCombo.Items.Add("Assia")
            countriesCombo.Items.Add("Batroun")
            countriesCombo.Items.Add("Bcheeleh")
            countriesCombo.Items.Add("Bkesmaya")
            countriesCombo.Items.Add("Chatine")
            countriesCombo.Items.Add("Chebtine")
            countriesCombo.Items.Add("Chekka")
            countriesCombo.Items.Add("Douma")
            countriesCombo.Items.Add("Eddeh")
            countriesCombo.Items.Add("Hamat")
            countriesCombo.Items.Add("Hardine – Beit Kassab")
            countriesCombo.Items.Add("Hery")
            countriesCombo.Items.Add("Ibrine")
            countriesCombo.Items.Add("Kfarabida")
            countriesCombo.Items.Add("Kfarhalda")
            countriesCombo.Items.Add("Kfour el Arabi")
            countriesCombo.Items.Add("Kobba")
            countriesCombo.Items.Add("Ras Nahhache")
            countriesCombo.Items.Add("Selaata")
            countriesCombo.Items.Add("Tannourine")
            countriesCombo.Items.Add("Zan")

            'KadaaComboBox.Items.Add("Batroun")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Abdine")
            countriesCombo.Items.Add("Barhelyoun")
            countriesCombo.Items.Add("Bazooun")
            countriesCombo.Items.Add("Becharre")
            countriesCombo.Items.Add("Bkaakafra")
            countriesCombo.Items.Add("Bkerkacha")
            countriesCombo.Items.Add("Hadath el Jobbeh")
            countriesCombo.Items.Add("Hadchit")
            countriesCombo.Items.Add("Hasroun")
            countriesCombo.Items.Add("Kanat")
            countriesCombo.Items.Add("Tourza")

            'KadaaComboBox.Items.Add("Bsharri")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 2 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Afsaddik")
            countriesCombo.Items.Add(" Ain Ekrine")
            countriesCombo.Items.Add("Ajed Ibrine")
            countriesCombo.Items.Add("Amioun")
            countriesCombo.Items.Add("Anfeh")
            countriesCombo.Items.Add("Barsa")
            countriesCombo.Items.Add("Batroumine")
            countriesCombo.Items.Add("Bdebba")
            countriesCombo.Items.Add("Bishmizzine")
            countriesCombo.Items.Add("Bednayel")
            countriesCombo.Items.Add("Bkeftine")
            countriesCombo.Items.Add("Bsarma")
            countriesCombo.Items.Add("Bterram")
            countriesCombo.Items.Add("Btouratij")
            countriesCombo.Items.Add("Bziza")
            countriesCombo.Items.Add("Dar Beechtar")
            countriesCombo.Items.Add("Dar Chmezzine")
            countriesCombo.Items.Add("Deddeh")
            countriesCombo.Items.Add("Fih")
            countriesCombo.Items.Add("Kaftoun")
            countriesCombo.Items.Add("Kalhat")
            countriesCombo.Items.Add("Kifraya")
            countriesCombo.Items.Add("Kfarakka")
            countriesCombo.Items.Add("Kfarhata")
            countriesCombo.Items.Add("Kfarhazir")
            countriesCombo.Items.Add("Kfarkahel")
            countriesCombo.Items.Add("Kfarsaroun")
            countriesCombo.Items.Add("Kosba")
            countriesCombo.Items.Add("Mejdel – Zakzouk – Wata Fares")
            countriesCombo.Items.Add("Metrite")
            countriesCombo.Items.Add("Nakhleh")
            countriesCombo.Items.Add("Rasmaska")
            countriesCombo.Items.Add("Rechdebbine")

            'KadaaComboBox.Items.Add("Koura")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 3 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Asoun")
            countriesCombo.Items.Add("Bakhoun")
            countriesCombo.Items.Add("Beddawi – Wadi Nahleh")
            countriesCombo.Items.Add("Beit el Fokss")
            countriesCombo.Items.Add("Bekaasafrine")
            countriesCombo.Items.Add("Bhannine & Artousa")
            countriesCombo.Items.Add("Bkarsouna – Kattine")
            countriesCombo.Items.Add("Deir Ammar")
            countriesCombo.Items.Add("Deir Nbouh")
            countriesCombo.Items.Add("Karm el Moher")
            countriesCombo.Items.Add("Kfarchalane")
            countriesCombo.Items.Add("Kfarhabou")
            countriesCombo.Items.Add("Minyeh")
            countriesCombo.Items.Add("Mrah Sraj")
            countriesCombo.Items.Add("Nemrine & Bkaouza")
            countriesCombo.Items.Add("Sfireh")
            countriesCombo.Items.Add("Sir")
            countriesCombo.Items.Add("Tarane")

            'KadaaComboBox.Items.Add("Miniyeh-Danniyeh")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 4 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Al-Qalamoun")
            countriesCombo.Items.Add("Mina")
            countriesCombo.Items.Add("Tripoli")

            'KadaaComboBox.Items.Add("Tripoli")

        ElseIf MohafazaComboBox.SelectedIndex = 6 And KadaaComboBox.SelectedIndex = 5 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Achache")
            countriesCombo.Items.Add("Aintourine")
            countriesCombo.Items.Add("Alma")
            countriesCombo.Items.Add("Arabet Kozhaya")
            countriesCombo.Items.Add("Arde")
            countriesCombo.Items.Add("Arjess")
            countriesCombo.Items.Add("Ayto")
            countriesCombo.Items.Add("Basloukit")
            countriesCombo.Items.Add("Bheyra")
            countriesCombo.Items.Add("Bnachee")
            countriesCombo.Items.Add("Daraya – Bechnine")
            countriesCombo.Items.Add("Haret el Fouar")
            countriesCombo.Items.Add("Iaal")
            countriesCombo.Items.Add("Karem Saddeh")
            countriesCombo.Items.Add("Kfard Lakouss")
            countriesCombo.Items.Add("Kfaresghab – El Mareh")
            countriesCombo.Items.Add("Kfarfou")
            countriesCombo.Items.Add("Kfarhata")
            countriesCombo.Items.Add("Kfaryachit – Besebhel")
            countriesCombo.Items.Add("Kfarzayna")
            countriesCombo.Items.Add("Korah Bach")
            countriesCombo.Items.Add("Mazraat el Teffah")
            countriesCombo.Items.Add("Mejdlaya")
            countriesCombo.Items.Add("Mezyara – Haref – Hmayss – Sakhra")
            countriesCombo.Items.Add("Miryata – Kadrieh")
            countriesCombo.Items.Add("Rachiine")
            countriesCombo.Items.Add("Raskifa")
            countriesCombo.Items.Add("Sebhel")
            countriesCombo.Items.Add("Serhel")
            countriesCombo.Items.Add("Toula – Aslout")
            countriesCombo.Items.Add("Zgharta – Ehden")

            'KadaaComboBox.Items.Add("Zgharta")

        ElseIf MohafazaComboBox.SelectedIndex = 7 And KadaaComboBox.SelectedIndex = 0 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("")
            countriesCombo.Items.Add("Aaray")
            countriesCombo.Items.Add("Aitouleh")
            countriesCombo.Items.Add("Aramta")
            countriesCombo.Items.Add("Aychieh")
            countriesCombo.Items.Add("Azour")
            countriesCombo.Items.Add("Benweteh")
            countriesCombo.Items.Add("Bkassine")
            countriesCombo.Items.Add(" Bteddine el Lekech")
            countriesCombo.Items.Add("Haytoura")
            countriesCombo.Items.Add("Homsiyeh")
            countriesCombo.Items.Add("Jarmak")
            countriesCombo.Items.Add("Jernaya")
            countriesCombo.Items.Add("Jezzine – Ain Majdaleyn")
            countriesCombo.Items.Add("Karkha")
            countriesCombo.Items.Add("Kattine – Hidab")
            countriesCombo.Items.Add("Kfarfalous")
            countriesCombo.Items.Add("Kfarhouna")
            countriesCombo.Items.Add("Kfarjarrah")
            countriesCombo.Items.Add("Lebaa")
            countriesCombo.Items.Add("Louaizeh")
            countriesCombo.Items.Add("Machmouche")
            countriesCombo.Items.Add("Maknounieh")
            countriesCombo.Items.Add("Midane")
            countriesCombo.Items.Add("Mjeydel")
            countriesCombo.Items.Add("Mlikh")
            countriesCombo.Items.Add("Rihane")
            countriesCombo.Items.Add("Rimat – Chkadif")
            countriesCombo.Items.Add("Roum")
            countriesCombo.Items.Add("Sabbah")
            countriesCombo.Items.Add("Saydoun")
            countriesCombo.Items.Add("Sfaray")
            countriesCombo.Items.Add("Snaya")
            countriesCombo.Items.Add("Sojod")
            countriesCombo.Items.Add("Wadi Jezzine")
            countriesCombo.Items.Add("Zhalta")

            'KadaaComboBox.Items.Add("Jezzine")

        ElseIf MohafazaComboBox.SelectedIndex = 7 And KadaaComboBox.SelectedIndex = 1 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Abra")
            countriesCombo.Items.Add("Adloun")
            countriesCombo.Items.Add("Adousieh")
            countriesCombo.Items.Add("Ain el Deleb")
            countriesCombo.Items.Add("Ankoun")
            countriesCombo.Items.Add("Bablieh")
            countriesCombo.Items.Add("Barty")
            countriesCombo.Items.Add("Bayssarieh")
            countriesCombo.Items.Add("Bkosta")
            countriesCombo.Items.Add("Bnaafoul")
            countriesCombo.Items.Add("Bramieh")
            countriesCombo.Items.Add("Dareb el Sim")
            countriesCombo.Items.Add("Erkay")
            countriesCombo.Items.Add("Ghazieh")
            countriesCombo.Items.Add("Ghessanieh")
            countriesCombo.Items.Add("Haret Saida")
            countriesCombo.Items.Add("Hlalyeh")
            countriesCombo.Items.Add("Insariat")
            countriesCombo.Items.Add("Irzay")
            countriesCombo.Items.Add("Kaakaiyat el Snaoubar")
            countriesCombo.Items.Add("Kawthariyet el Siyyad")
            countriesCombo.Items.Add("Kfarhatta")
            countriesCombo.Items.Add("Kfarmilke")
            countriesCombo.Items.Add("Khartoum")
            countriesCombo.Items.Add("Khrayeb")
            countriesCombo.Items.Add("Knarite")
            countriesCombo.Items.Add("Krayeh")
            countriesCombo.Items.Add("Loubieh")
            countriesCombo.Items.Add("Maghdouche")
            countriesCombo.Items.Add("Majdelyoun")
            countriesCombo.Items.Add("Meemarieh")
            countriesCombo.Items.Add("Merwanieh")
            countriesCombo.Items.Add("Mieh Mieh")
            countriesCombo.Items.Add("Najjarieh")
            countriesCombo.Items.Add("Sidon")
            countriesCombo.Items.Add("Saksakieh")
            countriesCombo.Items.Add("Salhieh")
            countriesCombo.Items.Add("Sarafand")
            countriesCombo.Items.Add("Tafahta")
            countriesCombo.Items.Add("Tanbourit")
            countriesCombo.Items.Add("Zeita")
            countriesCombo.Items.Add("Zrariyeh")

            'KadaaComboBox.Items.Add("Saida(Sidon)")

        ElseIf MohafazaComboBox.SelectedIndex = 7 And KadaaComboBox.SelectedIndex = 2 Then
            countriesCombo.Items.Clear()
            countriesCombo.Items.Add("Aaytit")
            countriesCombo.Items.Add("Abbassieh")
            countriesCombo.Items.Add("Ain Baal")
            countriesCombo.Items.Add("Alma el Chaab")
            countriesCombo.Items.Add("Arzoun")
            countriesCombo.Items.Add("Baflay")
            countriesCombo.Items.Add("Barich")
            countriesCombo.Items.Add("Batoulieh")
            countriesCombo.Items.Add("Bayyad")
            countriesCombo.Items.Add("Bazourieh")
            countriesCombo.Items.Add("Bedyass")
            countriesCombo.Items.Add("Borj el Chamali")
            countriesCombo.Items.Add("Borj Rahal")
            countriesCombo.Items.Add("Bourghlieh")
            countriesCombo.Items.Add("Boustane")
            countriesCombo.Items.Add("Chameh")
            countriesCombo.Items.Add("Chehabie")
            countriesCombo.Items.Add("Chehour")
            countriesCombo.Items.Add("Chihine")
            countriesCombo.Items.Add("Debaal")
            countriesCombo.Items.Add("Deir Amess")
            countriesCombo.Items.Add("Deir Kanoun – Ras el Ain")
            countriesCombo.Items.Add("Deir Kanoun Naher")
            countriesCombo.Items.Add("Derdghaya")
            countriesCombo.Items.Add("Halloussieh")
            countriesCombo.Items.Add("Hanawey")
            countriesCombo.Items.Add("Henniye")
            countriesCombo.Items.Add("Hmayri")
            countriesCombo.Items.Add("Jebbine")
            countriesCombo.Items.Add("Jwaya")
            countriesCombo.Items.Add("Kana")
            countriesCombo.Items.Add("Kolayleh")
            countriesCombo.Items.Add("Maarake")
            countriesCombo.Items.Add("Maaroub")
            countriesCombo.Items.Add("Mahroune")
            countriesCombo.Items.Add("Majadel")
            countriesCombo.Items.Add("Majdalzoun")
            countriesCombo.Items.Add("Mansouri")
            countriesCombo.Items.Add("Marwahine")
            countriesCombo.Items.Add("Mazraat Mechref")
            countriesCombo.Items.Add("Nakoura")
            countriesCombo.Items.Add("Ramadiye")
            countriesCombo.Items.Add("Rechknanay")
            countriesCombo.Items.Add("Selha")
            countriesCombo.Items.Add("Siddikine")
            countriesCombo.Items.Add("Srifa")
            countriesCombo.Items.Add("Tayrdebba")
            countriesCombo.Items.Add("Tayrfelsay")
            countriesCombo.Items.Add("Tayrharfa")
            countriesCombo.Items.Add("Toura")
            countriesCombo.Items.Add("Tyre")
            countriesCombo.Items.Add("Yanouh")
            countriesCombo.Items.Add("Yarine")
            countriesCombo.Items.Add("Zebkine")

            'KadaaComboBox.Items.Add("Tyre")
        End If
    End Sub


End Class
