Public Class FrmJobCategory
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblJobCategoryBindingSource.DataSource = aMainor.TblJobCategories.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblJobCategoryBindingSource.Count - 1

            Dim x As TblJobCategory = TblJobCategoryBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmJobCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblJobCategoryDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblJobCategoryDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblJobCategoryDataGridView.ReadOnly = False
            TblJobCategoryBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblJobCategoryBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblJobCategoryBindingSource.Count - 1
                        Dim x As TblJobCategory = TblJobCategoryBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblJobCategories.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblJobCategoryBindingSource.RemoveCurrent()
                                TblJobCategoryDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim JobCategoryId As Integer = TblJobCategoryBindingSource(i).id
                                Dim oldJobCategory = (From ax In aMainor.TblJobCategories Where ax.Id = JobCategoryId).ToList(0)
                                Dim NewJobCaregory As TblJobCategory = TblJobCategoryBindingSource(i)
                                oldJobCategory.Name = NewJobCaregory.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblJobCategoryDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
    End Sub

    Private Sub TblJobCategoryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobCategoryDataGridView.CellContentClick
        If TblJobCategoryBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblJobCategoryBindingSource.Current.id
                        If Id = 0 Then
                            TblJobCategoryBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblJobCategories Where aX.Id = Id).ToList(0)

                            If result.TblJobDescriptions.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblJobDescriptions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblJobCategories.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub
End Class