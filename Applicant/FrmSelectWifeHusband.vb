Public Class FrmSelectWifeHusband
    Public ApplicantId As Integer = 0
    Public selected As Boolean = False
    Public Saved As Boolean = False
    Public WifeHusbandApplicatId As Integer
    Public Applicantgender As String = ""


    Private Sub FrmSelectWifeHusband_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext(cnx)


            TblApplicantBindingSource.DataSource = (From aX In aMainor.TblApplicants Where aX.StatusId = EmployeeStatusId).ToList

        End Using

    End Sub

    Private Sub TblApplicantDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblApplicantDataGridView.CellDoubleClick
        If selected Then

            Saved = True
            WifeHusbandApplicatId = TblApplicantBindingSource.Current.id
            Me.Close()
        End If
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub LastNameTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LastNameTextBox.TextChanged
        Dim CurrentText = LastNameTextBox.Text
        If Not IsNothing(CurrentText) Then
            Using aMainor As New LqHRDataContext(cnx)
                TblApplicantBindingSource.DataSource = (From aX In aMainor.TblApplicants Where aX.LastName.StartsWith(CurrentText) And aX.StatusId = EmployeeStatusId).ToList
            End Using
        End If
    End Sub



    Private Sub RecordNumberTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RecordNumberTextBox.TextChanged
        Dim t As Integer
        If Not RecordNumberTextBox.Text = "" Then
            If Integer.TryParse(RecordNumberTextBox.Text, t) Then
                Dim CurrentText = Integer.Parse(RecordNumberTextBox.Text)
                If Not IsNothing(CurrentText) Then
                    Using aMainor As New LqHRDataContext(cnx)
                        TblApplicantBindingSource.DataSource = (From aX In aMainor.TblApplicants Where aX.RecordNumber = CurrentText And aX.StatusId = EmployeeStatusId).ToList
                    End Using
                End If
            Else
                MessageBox.Show("Please enter a valid Record Number!")
                RecordNumberTextBox.Text = ""

            End If
        Else
            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From aX In aMainOr.TblApplicants Where aX.Id = ApplicantId).ToList(0)
                Dim gender = res.Gender
                TblApplicantBindingSource.DataSource = (From aX In aMainor.TblApplicants Where Not aX.Gender = gender And aX.StatusId = EmployeeStatusId).ToList
            End Using

        End If

    End Sub
End Class