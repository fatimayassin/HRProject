Public Class FrmSelectRelativeReferences
    Public Applicantgender As String = ""
    Public selected As Boolean = False
    Public Saved As Boolean = False
    Public RelativeReferenceApplicantId As Integer = 0

    Private Sub FrmSelectRelativeReferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext(cnx)

            'Dim res = (From aX In aMainOr.TblApplicants Where aX.Id = ApplicantId).ToList(0)
            'Dim gender = res.Gender
            TblApplicantBindingSource.DataSource = (From aX In aMainor.TblApplicants Where aX.StatusId = EmployeeStatusId).ToList

        End Using
    End Sub

    Private Sub TblApplicantDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblApplicantDataGridView.CellDoubleClick
        If selected Then

            Saved = True
            RelativeReferenceApplicantId = TblApplicantBindingSource.Current.id
            Me.Close()
        End If
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FirstNameTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles FirstNameTextBox.TextChanged
        Dim CurrentText = FirstNameTextBox.Text
        If Not IsNothing(CurrentText) Then
            Using aMainor As New LqHRDataContext(cnx)
                TblApplicantBindingSource.DataSource = (From aX In aMainOr.TblApplicants Where aX.FirstName.StartsWith(CurrentText)).ToList
            End Using
        End If
    End Sub

    Private Sub LastNameTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LastNameTextBox.TextChanged
        Dim CurrentText = LastNameTextBox.Text
        If Not IsNothing(CurrentText) Then
            Using aMainor As New LqHRDataContext(cnx)
                TblApplicantBindingSource.DataSource = (From aX In aMainOr.TblApplicants Where aX.LastName.StartsWith(CurrentText)).ToList
            End Using
        End If
    End Sub
End Class
