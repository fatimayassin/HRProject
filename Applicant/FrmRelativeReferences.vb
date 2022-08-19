Public Class FrmRelativeReferences
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public Applicantgender As String = ""
    Public current As New TblRelativeReference
    Public ForEdit As Boolean = False
    Public first As Boolean = True
    Public RelativeReferenceApplicantId As Integer = 0
    Public EmployeeId As Integer = 0
    Public ApplicantId As Integer = 0
    Private Sub FrmRelativeReferences_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If Not ForEdit Then
            If Id = 0 Then
                TblRelativeReferenceBindingSource.DataSource = New TblRelativeReference
                'TblRelativeReferenceBindingSource.Current.isincompany = False
                Me.IsInCompanyCheckBox.CheckState = 0
            End If
        Else
            TblRelativeReferenceBindingSource.DataSource = current
        End If
        first = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If NameTextBox.Text = "" Or JobTextBox.Text = "" Or PhoneTextBox.Text = "" Or RelationTextBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Using aMainor As New LqHRDataContext(cnx)()
            '    If Id = 0 Then
            '        TblRelativeReferenceBindingSource.Current.applicantId = ApplicantId
            '        aMainOr.TblRelativeReferences.InsertOnSubmit(TblRelativeReferenceBindingSource.Current)
            '    Else
            '        Dim Old = (From aX In aMainOr.TblRelativeReferences Where aX.Id = Id).ToList(0)
            '        Dim newItem As TblRelativeReference = TblRelativeReferenceBindingSource.Current

            '        Old.Name = newItem.Name
            '        Old.Phone = newItem.Phone
            '        Old.Job = newItem.Job
            '        Old.Relation = newItem.Relation
            '        Old.IsInCompany = newItem.IsInCompany

            '    End If
            '    aMainOr.SubmitChanges()

            current = TblRelativeReferenceBindingSource.Current
            Saved = True
            Me.Close()

            ' End Using
        End If
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub IsInCompanyCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles IsInCompanyCheckBox.CheckedChanged
        If first = False Then

            If IsInCompanyCheckBox.Checked = True Then
                Dim x As New FrmEmployeeList
                x.SelectRelativeReference = True
                x.statusId = EmployeeStatusId
                x.ShowDialog()
                If x.Saved Then
                    Using aMainor As New LqHRDataContext(cnx)
                        EmployeeId = x.EmpId
                        ApplicantId = x.appId
                        TblRelativeReferenceBindingSource.Current.isincompany = True
                        TblRelativeReferenceBindingSource.Current.relation = ""

                        Dim res = (From ax In aMainor.TblApplicants Where ax.Id = ApplicantId).ToList(0)
                        Dim jobId1 As Integer = (From ax In aMainor.TblEmployeeJobs Where ax.EmployeeId = EmployeeId Select ax.JobId).ToList(0)

                        TblRelativeReferenceBindingSource.Current.Name = res.FirstName + " " + res.MiddleName + " " + res.LastName
                        TblRelativeReferenceBindingSource.Current.Job = (From ax In aMainor.TblJobDescriptions Where ax.Id = jobId1 Select ax.Name).ToList(0)
                        TblRelativeReferenceBindingSource.Current.phone = res.Mobile

                        'Dim employeeId As Integer = (From ax In aMainOr.TblEmployees Where ax.ApplicantId = res.Id Select ax.Id).ToList(0)


                        'Dim job = (From ax In aMainOr.TblCurrentJobs Where ax.EmployeeId = employeeId Select ax.JobId).ToList(0)

                        'TblRelativeReferenceBindingSource.Current.job = (From ax In aMainOr.TblJobDescriptions Where ax.Id = Job Select ax.Name).ToList(0)

                    End Using
                Else
                    IsInCompanyCheckBox.Checked = False
                End If

                x.Dispose()
            Else

                first = True
                TblRelativeReferenceBindingSource.Current.name = ""
                TblRelativeReferenceBindingSource.Current.phone = ""
                TblRelativeReferenceBindingSource.Current.job = ""
                TblRelativeReferenceBindingSource.Current.relation = ""
                TblRelativeReferenceBindingSource.Current.isincompany = False

                first = False

            End If
        End If
    End Sub

End Class