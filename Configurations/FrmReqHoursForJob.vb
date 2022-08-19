Public Class FrmReqHoursForJob
    Public isValidate As Boolean = True
    Private Sub FrmBlood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblRequiredHoursForJobDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblRequiredHoursForJobBindingSource.DataSource = aMainor.TblRequiredHoursForJobs.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblRequiredHoursForJobBindingSource.Count - 1

            Dim x As TblRequiredHoursForJob = TblRequiredHoursForJobBindingSource(i)
            If x.hoursNumber Is Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblRequiredHoursForJobDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblRequiredHoursForJobDataGridView.ReadOnly = False
            TblRequiredHoursForJobBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblRequiredHoursForJobBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblRequiredHoursForJobBindingSource.Count - 1
                        Dim x As TblRequiredHoursForJob = TblRequiredHoursForJobBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.hoursNumber Is Nothing Then
                                aMainor.TblRequiredHoursForJobs.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblRequiredHoursForJobBindingSource.RemoveCurrent()
                                TblRequiredHoursForJobDataGridView.Refresh()
                            End If
                        Else
                            If Not x.hoursNumber Is Nothing Then
                                Dim ReqId As Integer = TblRequiredHoursForJobBindingSource(i).id
                                Dim oldRow = (From ax In aMainor.TblRequiredHoursForJobs Where ax.Id = ReqId).ToList(0)
                                Dim NewRow As TblRequiredHoursForJob = TblRequiredHoursForJobBindingSource(i)
                                oldRow.Description = NewRow.Description
                                oldRow.hoursNumber = NewRow.hoursNumber
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblRequiredHoursForJobDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
    End Sub

    Private Sub TblRequiredHoursForJobDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblRequiredHoursForJobDataGridView.CellContentClick
        If TblRequiredHoursForJobBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblRequiredHoursForJobBindingSource.Current.id
                        If Id = 0 Then
                            TblRequiredHoursForJobBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblRequiredHoursForJobs Where aX.Id = Id).ToList(0)

                            If result.TblJobDescriptions.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblDescriptions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblRequiredHoursForJobs.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub TblRequiredHoursForJobDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblRequiredHoursForJobDataGridView.DataError
        If e.ColumnIndex = c1.Index Then
            MessageBox.Show("Please enter a number!")
            TblRequiredHoursForJobDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing

        End If
    End Sub
End Class