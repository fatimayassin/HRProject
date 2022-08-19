Public Class FrmDepartmentCategory
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblDepartmentCategoryBindingSource.DataSource = aMainor.TblDepartmentCategories.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblDepartmentCategoryBindingSource.Count - 1

            Dim x As TblDepartmentCategory = TblDepartmentCategoryBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmDepartmentCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblDepartmentCategoryDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblDepartmentCategoryDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblDepartmentCategoryDataGridView.ReadOnly = False
            TblDepartmentCategoryBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblDepartmentCategoryBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblDepartmentCategoryBindingSource.Count - 1
                        Dim x As TblDepartmentCategory = TblDepartmentCategoryBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblDepartmentCategories.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblDepartmentCategoryBindingSource.RemoveCurrent()
                                TblDepartmentCategoryDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim depCategoryId As Integer = TblDepartmentCategoryBindingSource(i).id
                                Dim oldDepCategory = (From ax In aMainor.TblDepartmentCategories Where ax.Id = depCategoryId).ToList(0)
                                Dim NewDepCaregory As TblDepartmentCategory = TblDepartmentCategoryBindingSource(i)
                                oldDepCategory.Name = NewDepCaregory.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblDepartmentCategoryDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
    End Sub

    Private Sub TblDepartmentCategoryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblDepartmentCategoryDataGridView.CellContentClick
        If TblDepartmentCategoryBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblDepartmentCategoryBindingSource.Current.id
                        If Id = 0 Then
                            TblDepartmentCategoryBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblDepartmentCategories Where aX.Id = Id).ToList(0)

                            If result.TblDepartments.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblDepartment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblDepartmentCategories.DeleteOnSubmit(result)
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