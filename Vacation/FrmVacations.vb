Public Class FrmVacations
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblVacationBindingSource.DataSource = aMainor.TblVacations.ToList
        End Using
    End Sub
    Private Sub FrmVacations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblVacationDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblVacationDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblVacationDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblVacationBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblVacationBindingSource.Count - 1
            Dim x As TblVacation = TblVacationBindingSource(i)
            If x.Description = Nothing Then
                If i = 0 Then
                    isValidate = False
                Else
                    isValidate = isValidate And False
                End If
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblVacationBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblVacationBindingSource.Count - 1
                        Dim x As TblVacation = TblVacationBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Description = Nothing Then
                                aMainor.TblVacations.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblVacationBindingSource.RemoveCurrent()
                                TblVacationDataGridView.Refresh()
                            End If
                        Else
                            Dim VacId As Integer = TblVacationBindingSource(i).id
                            Dim oldVac = (From ax In aMainor.TblVacations Where ax.Id = VacId).ToList(0)
                            Dim newvac As TblVacation = TblVacationBindingSource(i)
                            oldVac.Description = newvac.Description
                            oldVac.NumberOfDays = newvac.NumberOfDays
                            aMainor.SubmitChanges()

                        End If
                    Next
                    TblVacationDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
        saved = True
        Me.Close()
    End Sub

    Private Sub TblVacationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblVacationDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this !", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblVacationBindingSource.Current.id
                    If Id = 0 Then
                        TblVacationBindingSource.RemoveCurrent()
                        TblVacationDataGridView.Refresh()
                    Else
                        Dim result = (From aX In aMainor.TblVacations Where aX.Id = Id).ToList(0)

                        If result.TblEmployeeVacations.Count > 0 Or result.TblYearlyVacations.Count > 0 Then

                            MessageBox.Show("cannot be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            aMainor.TblVacations.DeleteOnSubmit(result)
                            aMainor.SubmitChanges()
                            refreshForm()
                        End If
                    End If
                End Using
            End If

        End If

    End Sub

    Private Sub lblText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblText.Click

    End Sub
End Class