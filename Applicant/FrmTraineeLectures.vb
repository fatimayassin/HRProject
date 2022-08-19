Public Class FrmTraineeLectures
    Public current As BindingSource
    Public ApplicantId As Integer
    Public saved As Boolean = False
    Dim selectedDate As Date
    Public forEdit As Boolean = False
    Public ForAssigning As Boolean = False
    Public TraineeId As Integer = 0
    Public fromUc As Boolean = False

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmTraineeLectures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)

            TblLectureBindingSource.DataSource = aMainor.TblLectures.ToList
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList

            If fromUc Then
                DepComboBox.Visible = False
                Label1.Visible = False
            Else
                DepComboBox.Visible = True
                Label1.Visible = True
            End If
            If forEdit Then
                TblTraineeLectureBindingSource = current
                Dim Idlist As New List(Of Integer)
                Dim DateList As New List(Of Date)

                For i As Integer = 0 To TblTraineeLectureBindingSource.Count - 1
                    Dim LecId As Integer = TblTraineeLectureBindingSource(i).LectureId
                    Idlist.Add(LecId)
                    DateList.Add(TblTraineeLectureBindingSource(i).date)

                Next

                For i As Integer = 0 To TblLectureDataGridView.Rows.Count() - 1
                    Dim row As DataGridViewRow = TblLectureDataGridView.Rows(i)
                    If Idlist.Contains(row.Cells(0).Value) Then
                        TblLectureDataGridView.Rows(i).Cells(1).Value = True
                        TblLectureDataGridView.Rows(i).Cells(5).Value = DateList.Item(Idlist.IndexOf(row.Cells(0).Value))
                    End If
                Next
            End If

        End Using



    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'selectedDate = MonthCalendar1.SelectionStart.Date
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        MonthCalendar1.Visible = False
        TblLectureDataGridView.Enabled = True
        ' isDateSelected = True
        TblLectureDataGridView.CurrentRow.Cells(5).Value = selectedDate
    End Sub

    Private Sub TblMedicalIssueDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TblLectureDataGridView.CellDoubleClick
        If TblLectureBindingSource.Count > 0 Then
            If e.ColumnIndex = LectureDate.Index Then
                Dim Id As Integer = TblLectureBindingSource.Current.id
                TblLectureDataGridView.Enabled = False
                MonthCalendar1.Visible = True

            End If
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)

            If ForAssigning Then
                Dim r As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = ApplicantId).ToList(0)
                r.StatusId = TraineeStatusId
                aMainor.SubmitChanges()

                Dim Trainee As New TblTrainee
                Trainee.ApplicantId = ApplicantId
                Trainee.StartDate = Date.Now
                Trainee.DepartmentId = DepComboBox.SelectedValue
                aMainor.TblTrainees.InsertOnSubmit(Trainee)
                aMainor.SubmitChanges()
                TraineeId = Trainee.Id

            End If

            Dim res = (From ax In aMainor.TblTrainees Where ax.ApplicantId = ApplicantId).ToList
            If res.Count > 0 Then
                Dim traineeId As Integer = res.ToList(0).Id
                Dim res22 = (From aX In aMainor.TblTraineeLectures Where aX.TraineeId = traineeId).ToList
                If res22.Count > 0 Then
                    TblTraineeLectureBindingSource.List.Clear()
                End If
            End If
            If TblTraineeLectureBindingSource.Count > 0 Then
                TblTraineeLectureBindingSource.List.Clear()
            End If



            For i As Integer = 0 To TblLectureBindingSource.Count - 1
                Dim c As Boolean = TblLectureDataGridView.Rows(i).Cells(1).Value
                Dim row As DataGridViewRow = TblLectureDataGridView.Rows(i)
                If c Then
                    Dim Lec As New TblTraineeLecture


                    Lec.LectureId = row.Cells(0).Value
                    Lec.Date = row.Cells(5).Value
                    If TraineeId > 0 Then
                        Lec.TraineeId = TraineeId
                    End If
                    If ForAssigning Then
                        Lec.TraineeId = TraineeId
                        aMainor.TblTraineeLectures.InsertOnSubmit(Lec)
                        aMainor.SubmitChanges()
                    End If
                    TblTraineeLectureBindingSource.Add(Lec)

                End If
            Next
        End Using
        current = TblTraineeLectureBindingSource
        saved = True
        Me.Close()
    End Sub


End Class