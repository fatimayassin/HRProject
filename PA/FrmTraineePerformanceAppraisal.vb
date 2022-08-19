Public Class FrmTraineePerformanceAppraisal
    Public ApplicantId As Integer = 0
    Dim TraineeId As Integer = 0
    Public saved As Boolean = False


    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub TblTraineePerformanceAppraisalDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblTraineePerformanceAppraisalDataGridView.DataError
        If e.ColumnIndex = c1.Index Then
            MessageBox.Show("Please enter a number !")
            TblTraineePerformanceAppraisalDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing
        End If
    End Sub

    Private Sub FrmTraineePerformanceAppraisal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)

            TraineeId = (From ax In aMainor.TblTrainees Where ax.ApplicantId = ApplicantId Select ax.Id).ToList(0)
            TblPAForTraineerBindingSource.DataSource = aMainor.TblPAForTraineers.ToList

            refreshForm()

            Dim res As TblApplicant = (From ax In aMainor.TblApplicants Where ax.Id = ApplicantId).ToList(0)
            lblText.Text = res.FirstName + " " + res.MiddleName + " " + res.LastName



        End Using
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblPAForTraineerBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblTraineePerformanceAppraisalBindingSource.Count - 1
                        Dim x As TblTraineePerformanceAppraisal = TblTraineePerformanceAppraisalBindingSource(i)
                        If x.id = 0 Then
                            aMainor.TblTraineePerformanceAppraisals.InsertOnSubmit(x)
                            If Not x.Grade Is Nothing Then
                                aMainor.SubmitChanges()
                            End If

                        Else
                            Dim id As Integer = TblTraineePerformanceAppraisalBindingSource(i).id
                            Dim odlRow As TblTraineePerformanceAppraisal = (From ax In aMainor.TblTraineePerformanceAppraisals Where ax.id = id).ToList(0)
                            Dim newRow As TblTraineePerformanceAppraisal = TblTraineePerformanceAppraisalBindingSource(i)
                            odlRow.Grade = newRow.Grade
                            If Not x.Grade Is Nothing Then
                                aMainor.SubmitChanges()
                            End If

                        End If
                    Next
                End If
            End If
        End Using

        saved = True
        refreshForm()

    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblTraineePerformanceAppraisalBindingSource.DataSource = (From ax In aMainor.TblTraineePerformanceAppraisals Where ax.TrainneId = TraineeID).ToList

            For i = 0 To TblPAForTraineerBindingSource.Count - 1
                Dim canAdd As Boolean = True
                For j = 0 To TblTraineePerformanceAppraisalBindingSource.Count - 1
                    If Not TblTraineePerformanceAppraisalBindingSource(j).PAforTraineeId = TblPAForTraineerBindingSource(i).id Then
                        canAdd = True
                    Else
                        canAdd = False
                        Exit For
                    End If
                Next
                If canAdd Then
                    Dim x As New TblTraineePerformanceAppraisal
                    x.PAforTraineeId = TblPAForTraineerBindingSource(i).id
                    x.TrainneId = TraineeId
                    TblTraineePerformanceAppraisalBindingSource.Add(x)
                End If

            Next

        End Using
    End Sub

    Private Sub TblTraineePerformanceAppraisalDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTraineePerformanceAppraisalDataGridView.CellContentClick

        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblTraineePerformanceAppraisalBindingSource.Current.id
                    If Id = 0 Then
                        TblPAForTraineerBindingSource.RemoveCurrent()
                    Else
                        Dim result = (From aX In aMainOR.TblTraineePerformanceAppraisals Where aX.id = Id).ToList(0)
                        aMainOR.TblTraineePerformanceAppraisals.DeleteOnSubmit(result)
                        aMainOR.SubmitChanges()

                    End If
                    refreshForm()
                End Using
            End If
        End If
    End Sub

 
End Class