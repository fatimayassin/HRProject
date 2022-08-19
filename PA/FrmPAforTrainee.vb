Public Class FrmPAforTrainee
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblPAForTraineerBindingSource.DataSource = aMainor.TblPAForTraineers.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblPAForTraineerBindingSource.Count - 1

            Dim x As TblPAForTraineer = TblPAForTraineerBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmPAforTrainee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        refreshForm()
        TblPAForTraineerDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblPAForTraineerDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblPAForTraineerDataGridView.ReadOnly = False
            TblPAForTraineerBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblPAForTraineerBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblPAForTraineerBindingSource.Count - 1
                        Dim x As TblPAForTraineer = TblPAForTraineerBindingSource(i)
                        If x.id = 0 Then
                            If Not x.Name Is Nothing And Not x.Average Is Nothing Then
                                aMainor.TblPAForTraineers.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblPAForTraineerBindingSource.RemoveCurrent()
                                TblPAForTraineerDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name Is Nothing And Not x.Average Is Nothing Then
                                Dim PAid As Integer = TblPAForTraineerBindingSource(i).id
                                Dim oldRow = (From ax In aMainor.TblPAForTraineers Where ax.id = PAid).ToList(0)
                                Dim NewRow As TblPAForTraineer = TblPAForTraineerBindingSource(i)
                                oldRow.Name = NewRow.Name
                                oldRow.Average = NewRow.Average
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblPAForTraineerDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
        saved = True

    End Sub

    Private Sub TblPAForTraineerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPAForTraineerDataGridView.CellContentClick
        If TblPAForTraineerBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblPAForTraineerBindingSource.Current.id
                        If Id = 0 Then
                            TblPAForTraineerBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblPAForTraineers Where aX.id = Id).ToList(0)

                            If result.TblTraineePerformanceAppraisals.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblTraineePerformanceAppraisals!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblPAForTraineers.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

  
    Private Sub TblPAForTraineerDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblPAForTraineerDataGridView.DataError
        If e.ColumnIndex = c1.Index Then
            MessageBox.Show("Please enter a number !")
            TblPAForTraineerDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing
        End If
    End Sub
End Class