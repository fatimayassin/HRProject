Public Class FrmApplicantsForCurrentJob
    Public id As Integer = 0
    Public forInfo As Boolean = False
    Public Applicantid As Integer
    Public jobid As Integer = 0

    Private Sub FrmApplicantsForCurrentJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        'Using aMainor As New LqHRDataContext(cnx)
        '    Dim res1 = (From ax In aMainOr.TblJobDescriptions Where ax.Id = id).ToList(0)
        '    Dim a = res1.DepartmentId
        '    Dim res = (From aX In aMainOr.TblRequiredJobs Where aX.JobDescriptionId = id And aX.DepartmentId = a).ToList()
        '    If res.Count = 0 Then
        '        MessageBox.Show("No Applicants applied for this job!")
        '        Me.Close()
        '    Else
        '        TblRequiredJobBindingSource.DataSource = res

        '        TblCurrencyBindingSource.DataSource = aMainOr.TblCurrencies.ToList
        '        TblApplicantBindingSource.DataSource = aMainOr.TblApplicants.ToList
        '    End If
        'End Using

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub TblRequiredJobDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblRequiredJobDataGridView.CellContentClick
        If TblRequiredJobBindingSource.Count > 0 Then
            If e.ColumnIndex = Info.Index Then

                Applicantid = TblRequiredJobBindingSource.Current.Applicantid
                JobId = id
                forInfo = True
                Me.Close()

            End If

        End If
    End Sub
End Class