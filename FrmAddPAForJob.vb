Public Class FrmAddPAForJob
    Public JobId As Integer = 0
    Public id As Integer = 0
    Dim ListOfPAForJob As New List(Of Integer?)
    Private Sub FrmAddPAForJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext
            TblPAForEmployeeBindingSource.DataSource = aMainor.TblPAForEmployees.ToList
            Dim res = (From ax In aMainor.TblPAPerJobs Where ax.JobId = JobId).ToList
            If res.Count > 0 Then
                ListOfPAForJob = (From ax In aMainor.TblPAPerJobs Where ax.JobId = JobId Select ax.PAId).ToList
            End If
            For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                Dim PAId As Integer = TblPAForEmployeeBindingSource(i).id
                If ListOfPAForJob.Contains(PAId) Then
                    TblPAForEmployeeDataGridView.Rows(i).Cells(check.Index).Value = True

                End If
            Next
        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New LqHRDataContext
            Dim res = (From ax In aMainor.TblPAPerJobs Where ax.JobId = JobId).ToList
            If res.Count > 0 Then
                aMainor.TblPAPerJobs.DeleteAllOnSubmit(res)
                aMainor.SubmitChanges()

            End If
            For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                If TblPAForEmployeeDataGridView.Rows(i).Cells(check.Index).Value = True Then
                    Dim PAPerJob As New TblPAPerJob
                    PAPerJob.JobId = JobId
                    PAPerJob.PAId = TblPAForEmployeeBindingSource(i).Id

                    aMainor.TblPAPerJobs.InsertOnSubmit(PAPerJob)
                    aMainor.SubmitChanges()

                End If
            Next
        End Using
        Me.Close()
    End Sub
End Class