Public Class FrmAssigndDepsToJob
    Public DepartmentId As Integer = 0
    Public id As Integer = 0
    Public fromhome As Boolean = False
    Public saved As Boolean = False
    Public loaded As Boolean = False
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmAssignJobsToDep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        Label1.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblJobCategoryBindingSource.DataSource = aMainor.TblJobCategories.ToList
            TblJobDescriptionBindingSource1.DataSource = aMainor.TblJobDescriptions.ToList
            TblDepartmentBindingSource1.DataSource = aMainor.TblDepartments.ToList
            TblJobDescriptionBindingSource2.DataSource = aMainor.TblJobDescriptions.ToList
            TblJobCategoryBindingSource1.DataSource = aMainor.TblJobCategories.ToList
            TblRequiredHoursForJobBindingSource1.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            TblRequiredHoursForJobBindingSource.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
            TblJobDescriptionBindingSource2.Insert(0, New TblJobDescription)
            TblJobCategoryBindingSource1.Insert(0, New TblJobCategory)
            TblDepartmentBindingSource1.Insert(0, New TblDepartment)
            TblRequiredHoursForJobBindingSource1.Insert(0, New TblRequiredHoursForJob)
            SupervidorIdComboBox.SelectedIndex = 0
            CatIdComboBox.SelectedIndex = 0
            ScheduleIdComboBox.SelectedIndex = 0
            ReqHrsIdComboBox.SelectedIndex = 0
            Dim res = (From ax In aMainor.TblJobsPerDepartments Where ax.DepartmentId = DepartmentId Select ax.JobId).ToList
            For i As Integer = 0 To TblJobDescriptionBindingSource.Count - 1
                Dim Jobid As Integer = TblJobDescriptionBindingSource(i).id
                If res.Contains(Jobid) Then
                    TblJobDescriptionDataGridView.Rows(i).Cells(check.Index).Value = True
                End If
                If DepartmentId > 0 Then
                    AddDepartments.Visible = False
                Else
                    AddDepartments.Visible = True

                End If

            Next
            If fromhome Then

                TblJobDescriptionDataGridView.Columns(check.Index).Visible = False
            Else
                TblJobDescriptionDataGridView.Columns(check.Index).Visible = True
            End If
        End Using
        loaded = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles  BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblJobsPerDepartments Where ax.DepartmentId = DepartmentId).ToList
            aMainor.TblJobsPerDepartments.DeleteAllOnSubmit(res)
            aMainor.SubmitChanges()
        End Using
        For j As Integer = 0 To TblJobDescriptionBindingSource.Count - 1
            If TblJobDescriptionDataGridView.Rows(j).Cells(check.Index).Value = True Then
                Dim JobsPerDep As New TblJobsPerDepartment
                JobsPerDep.DepartmentId = DepartmentId
                JobsPerDep.JobId = TblJobDescriptionBindingSource(j).id
                Using aMainor As New LqHRDataContext(cnx)
                    aMainOr.TblJobsPerDepartments.InsertOnSubmit(JobsPerDep)
                    aMainOr.SubmitChanges()

                End Using
            End If
        Next

        Me.Close()
    End Sub

    Private Sub TblJobDescriptionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobDescriptionDataGridView.CellContentClick

        If e.ColumnIndex = AddDepartments.Index Then
            Dim x As New FrmDepartmentTree
            x.jobid = TblJobDescriptionBindingSource.Current.ID
            x.ShowDialog()

            x.Dispose()
        End If
        'If e.ColumnIndex = PA.Index Then
        '    Dim X As New FrmAddPAForJob
        '    X.JobId = TblJobDescriptionBindingSource.Current.ID
        '    X.showDialog()

        'End If

        If e.ColumnIndex = PA.Index Then
            Dim X As New FrmPAForEmployee
            X.jobid = TblJobDescriptionBindingSource.Current.ID
            X.AddPAForJob = True
            X.ShowDialog()

            X.Dispose()
        End If

        If e.ColumnIndex = A.Index Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim jobid As Integer = TblJobDescriptionBindingSource.Current.ID
                Dim Res = (From ax In aMainor.TblPAPerJobs Where ax.JobId = jobid).ToList
                If Res.Count > 0 Then
                    Dim X As New FrmAveragePAPerJobPerTask
                    X.jobid = jobid
                    X.SingleJob = True
                    X.ShowDialog()

                    X.Dispose()
                Else
                    MessageBox.Show("Add PA For This Job First")
                End If
            End Using

        End If
    End Sub

    Private Sub TblJobDescriptionDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobDescriptionDataGridView.CellDoubleClick
        If Not fromhome Then
            id = TblJobDescriptionBindingSource.Current.id
            saved = True
            Me.Close()
        Else
            Dim x As New FrmJobDescription
            x.id = TblJobDescriptionBindingSource.Current.id
            x.ShowDialog()
        End If

    End Sub

    Private Sub JobNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobNumberTextBox.TextChanged, SupervidorIdComboBox.TextChanged, ScheduleIdComboBox.TextChanged, ReqHrsIdComboBox.TextChanged, NameTextBox.TextChanged, CatIdComboBox.TextChanged, ArabicNameTextBox.TextChanged
        If loaded Then
            Dim t As Integer
            Dim nbjob As Integer? = Nothing
            Dim canfilter As Boolean = True

            Dim superId As Integer = 0
            If SupervidorIdComboBox.SelectedIndex > 0 Then
                superId = SupervidorIdComboBox.SelectedValue
            End If

            Dim catgId As Integer = 0
            If CatIdComboBox.SelectedIndex > 0 Then
                catgId = CatIdComboBox.SelectedValue
            End If


            Dim scheId As Integer = 0
            If ScheduleIdComboBox.SelectedIndex > 0 Then
                scheId = ScheduleIdComboBox.SelectedValue
            End If


            Dim ReqId As Integer = 0
            If ReqHrsIdComboBox.SelectedIndex > 0 Then
                ReqId = ReqHrsIdComboBox.SelectedValue
            End If
            If Not JobNumberTextBox.Text = "" Then
                If Integer.TryParse(JobNumberTextBox.Text, t) Then
                    nbjob = Integer.Parse(JobNumberTextBox.Text)
                Else
                    MessageBox.Show("Please enter a valid number")
                    JobNumberTextBox.Clear()
                    canfilter = False
                End If
            End If
            If canfilter Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblJobDescriptionBindingSource.DataSource = aMainor.Filter_AssigndDepsToJob(nbjob, NameTextBox.Text, ArabicNameTextBox.Text, superId, catgId, scheId, ReqId).ToList

                End Using
            End If
        End If
    End Sub
End Class