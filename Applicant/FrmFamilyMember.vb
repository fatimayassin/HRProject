Public Class FrmFamilyMember
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public EmployeeId As Integer = 0
    Public ApplicantFName As String = ""
    Public ApplicantLName As String = ""
    Public current As New TblFamilyMember
    Public ForEdit As Boolean = False
    Public DateOfBirth As Date
    Public loaded As Boolean = False

    Private Sub FamilyMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        DateOfBirthDateTimePicker.MaxDate = Date.Now
        DateOfBirthDateTimePicker.MinDate = DateOfBirth

        If Not ForEdit Then
            If Id = 0 Then
                TblFamilyMemberBindingSource.DataSource = New TblFamilyMember

                If Not ApplicantFName = "" Then
                    TblFamilyMemberBindingSource.Current.MiddleName = ApplicantFName
                    TblFamilyMemberBindingSource.Current.LastName = ApplicantLName
                End If

            End If
        Else
            TblFamilyMemberBindingSource.DataSource = current
        End If


        'TblFamilyMemberBindingSource.Current.applicantid = ApplicantId
        loaded = True
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub



    Private Sub InCompanyCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InCompanyCheckBox.CheckedChanged
        If loaded = True Then

            If InCompanyCheckBox.Checked = True Then
                Dim x As New FrmEmployeeList
                x.SelectRelativeReference = True
                x.statusId = EmployeeStatusId
                x.ShowDialog()
                If x.saved Then

                    Using aMainor As New LqHRDataContext(cnx)
                        '    returnedId = x.WifeHusbandApplicatId
                        ApplicantId = x.appId
                        EmployeeId = x.EmpId

                        TblFamilyMemberBindingSource.Current.isWorking = True


                        Dim res = (From ax In aMainor.TblApplicants Where ax.Id = ApplicantId).ToList(0)
                        TblFamilyMemberBindingSource.Current.FirstName = res.FirstName
                        TblFamilyMemberBindingSource.Current.LastName = res.LastName
                        TblFamilyMemberBindingSource.Current.middleName = res.MiddleName
                        TblFamilyMemberBindingSource.Current.DateOfBirth = res.DateOfBirth
                        GenderComboBox.SelectedItem = res.Gender
                        DateOfBirthDateTimePicker.Value = res.DateOfBirth
                        TblFamilyMemberBindingSource.Current.gender = res.Gender
                        TblFamilyMemberBindingSource.Current.FamilyMemberEmployeeId = EmployeeId

                    

                    End Using
                End If


            Else
                loaded = False
             
                TblFamilyMemberBindingSource.Current.FirstName = ""
                TblFamilyMemberBindingSource.Current.lastName = ""
                TblFamilyMemberBindingSource.Current.middleName = ""
                GenderComboBox.SelectedItem = ""
                TblFamilyMemberBindingSource.Current.DateOfBirth = DateOfBirthDateTimePicker.MaxDate
                TblFamilyMemberBindingSource.Current.isWorking = False

                loaded = True
            End If
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If FirstNameTextBox.Text = "" Or MiddleNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or GenderComboBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Using aMainor As New LqHRDataContext(cnx)
                '    If Id = 0 Then
                '        aMainOr.TblFamilyMembers.InsertOnSubmit(TblFamilyMemberBindingSource.Current)
                '        aMainOr.SubmitChanges()

                '        Dim kidsnb = (From ax In aMainOr.TblFamilyMembers Where ax.ApplicantId = ApplicantId).ToList()
                '        Dim OldApp = (From aX In aMainOr.TblApplicants Where aX.Id = ApplicantId).ToList(0)
                '        OldApp.NumberOfKids = kidsnb.Count

                '    Else
                '        Dim Old = (From aX In aMainOr.TblFamilyMembers Where aX.Id = Id).ToList(0)
                '        Dim newItem As TblFamilyMember = TblFamilyMemberBindingSource.Current

                '        Old.FirstName = newItem.FirstName
                '        Old.LastName = newItem.LastName
                '        Old.MiddleName = newItem.MiddleName
                '        Old.Gender = newItem.Gender
                '        Old.DateOfBirth = newItem.DateOfBirth


                '    End If
                'aMainOr.SubmitChanges()

                current = TblFamilyMemberBindingSource.Current
                Saved = True
                Me.Close()

            End Using
        End If
    End Sub
End Class