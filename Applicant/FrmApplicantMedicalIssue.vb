Public Class FrmApplicantMedicalIssue
    Public Id1 As Integer = 0
    Public saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public count As Integer = 0
    Public current As BindingSource
    Public ForEdit As Boolean = False
    Dim selectedDate As Date
    Dim isDateSelected As Boolean = False

    Private Sub FrmMedicalIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblMedicalIssueBindingSource.DataSource = aMainor.TblMedicalIssues.ToList
            If ForEdit = False Then
                If Id1 = 0 Then
                End If
                '
                'TblMedicalIssueDataGridView.Rows(i).Cells(3).Value = DateList.Item(Idlist.IndexOf(row.Cells(0).Value))
            Else
                TblApplicantMedicalIssueBindingSource = current
                Dim Idlist As New List(Of Integer)
                Dim NoteList As New List(Of String)
                Dim DateList As New List(Of Date)

                'TblApplicantMedicalIssueBindingSource.MoveFirst()
                For i As Integer = 0 To TblApplicantMedicalIssueBindingSource.Count - 1
                    Dim medicalIssueId As Integer = TblApplicantMedicalIssueBindingSource(i).MedicalIssueId
                    Idlist.Add(medicalIssueId)
                    NoteList.Add(TblApplicantMedicalIssueBindingSource(i).note)
                    DateList.Add(TblApplicantMedicalIssueBindingSource(i).date)
                    'TblApplicantMedicalIssueBindingSource.MoveNext()
                Next
                For i As Integer = 0 To TblMedicalIssueDataGridView.Rows.Count() - 1
                    Dim row As DataGridViewRow = TblMedicalIssueDataGridView.Rows(i)
                    If Idlist.Contains(row.Cells(0).Value) Then
                        TblMedicalIssueDataGridView.Rows(i).Cells(1).Value = True
                        TblMedicalIssueDataGridView.Rows(i).Cells(3).Value = NoteList.Item(Idlist.IndexOf(row.Cells(0).Value))
                        TblMedicalIssueDataGridView.Rows(i).Cells(3).Value = DateList.Item(Idlist.IndexOf(row.Cells(0).Value))

                    End If
                Next
            End If
            count = TblMedicalIssueDataGridView.Rows.Count() - 1
        End Using
    End Sub



    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'selectedDate = MonthCalendar1.SelectionStart.Date
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        MonthCalendar1.Visible = False
        TblMedicalIssueDataGridView.Enabled = True
        ' isDateSelected = True
        TblMedicalIssueDataGridView.CurrentRow.Cells(3).Value = selectedDate
    End Sub

    Private Sub TblMedicalIssueDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblMedicalIssueDataGridView.CellDoubleClick

        If TblMedicalIssueBindingSource.Count > 0 Then
            If e.ColumnIndex = IssueDate.Index Then
                Dim Id As Integer = TblMedicalIssueBindingSource.Current.id
                TblMedicalIssueDataGridView.Enabled = False
                MonthCalendar1.Visible = True

            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res22 = (From aX In aMainor.TblApplicantMedicalIssues Where aX.ApplicantId = ApplicantId).ToList
            If res22.Count > 0 Then
                TblApplicantMedicalIssueBindingSource.List.Clear()
            End If
            If TblApplicantMedicalIssueBindingSource.Count > 0 Then
                TblApplicantMedicalIssueBindingSource.List.Clear()
            End If


            ' TblMedicalIssueBindingSource.Current.applicantId = ApplicantId

            'IF ADDING OTHER MEDICAL ISSUES

            Dim count2 As Integer = TblMedicalIssueDataGridView.Rows.Count() - 1
            'If count = count2 Then
            '    'NONE ADDED

            For i As Integer = 0 To TblMedicalIssueDataGridView.Rows.Count() - 1 Step +1

                Dim c As Boolean = TblMedicalIssueDataGridView.Rows(i).Cells(1).Value
                If c Then
                    Dim MIId As Integer
                    If i >= count Then
                        For j As Integer = count To count2 - 1
                            Dim row1 As DataGridViewRow = TblMedicalIssueDataGridView.Rows(j)
                            Dim MI As New TblMedicalIssue
                            MI.MedicalIssue = row1.Cells(2).Value
                            aMainor.TblMedicalIssues.InsertOnSubmit(MI)
                            aMainor.SubmitChanges()
                            MIId = MI.Id
                        Next

                    End If

                    Dim row As DataGridViewRow = TblMedicalIssueDataGridView.Rows(i)

                    Dim AMI1 As New TblApplicantMedicalIssue
                    If i >= count Then
                        AMI1.MedicalIssueId = MIId
                    Else
                        AMI1.MedicalIssueId = row.Cells(0).Value
                    End If

                    AMI1.ApplicantId = ApplicantId
                    AMI1.Note = row.Cells(4).Value
                    AMI1.Date = row.Cells(3).Value
                    TblApplicantMedicalIssueBindingSource.Add(AMI1)


                End If
            Next
            current = TblApplicantMedicalIssueBindingSource
            saved = True
            Me.Close()
        End Using
    End Sub
End Class