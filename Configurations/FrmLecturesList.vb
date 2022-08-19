Public Class FrmLecturesList
    Public isValidate As Boolean = True

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblLectureBindingSource.DataSource = aMainOr.TblLectures.ToList
        End Using
    End Sub

    Private Sub FrmLectures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblLectureDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblLectureDataGridView.ReadOnly = False
            TblLectureBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblLectureBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblLectureBindingSource.Count - 1
                        Dim x As TblLecture = TblLectureBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblLectures.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblLectureBindingSource.RemoveCurrent()
                                TblLectureDataGridView.Refresh()
                            End If
                        Else

                            Dim lectureId As Integer = TblLectureBindingSource(i).id
                            Dim oldLecture = (From ax In aMainor.TblLectures Where ax.Id = lectureId).ToList(0)
                            Dim NewLecture As TblLecture = TblLectureBindingSource(i)
                            oldLecture.Name = NewLecture.Name
                            oldLecture.ArabicName = NewLecture.ArabicName
                            oldLecture.Duration = NewLecture.Duration
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblLectureDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                End If
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblLectureDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblLectureBindingSource.Count - 1
            Dim x As TblLecture = TblLectureBindingSource(i)
            If x.Name = Nothing Then
                'If i = 0 Then
                '    isValidate = False
                'Else
                '    isValidate = isValidate And False
                'End If
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub


    Private Sub TblLectureDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblLectureDataGridView.CellContentClick
        If TblLectureBindingSource.Count > 0 Then
            If e.ColumnIndex = delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblLectureBindingSource.Current.id
                        If Id = 0 Then
                            TblLectureBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblLectures Where aX.Id = Id).ToList(0)

                            If result.TblTraineeLectures.Count > 0 Then
                                MessageBox.Show("This Place is related to some Tables", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblLectures.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub TblLectureDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblLectureDataGridView.DataError
        If e.ColumnIndex = Duration.Index Then
            MessageBox.Show("Please enter a number!")
            TblLectureDataGridView.CurrentRow.Cells(Duration.Index).Value = Nothing

        End If
    End Sub
End Class