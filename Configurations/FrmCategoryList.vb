Public Class FrmCategoryList
    Public isValidate As Boolean = True
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblCategoryBindingSource.DataSource = aMainor.TblCategories.ToList
        End Using
    End Sub
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub FrmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblCategoryDataGridView.ReadOnly = True
        BtnSave.Enabled = False

    End Sub

    Private Sub TblCategoryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCategoryDataGridView.CellContentClick
        If TblCategoryBindingSource.Count > 0 Then
            'If e.ColumnIndex = Edit.Index Then
            '    Dim Id As Integer = TblCategoryBindingSource.Current.id

            '    Dim x As New FrmCategoryInfo
            '    x.Id = Id
            '    x.ShowDialog()
            '    If x.Saved Then
            '        refreshForm()
            '    End If
            'End If
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblCategoryBindingSource.Current.id
                        If Id = 0 Then
                            TblCategoryBindingSource.RemoveCurrent()
                            TblCategoryDataGridView.Refresh()
                        Else
                            Dim result = (From aX In aMainOR.TblCategories Where aX.Id = Id).ToList(0)

                            If result.TblTasks.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblTask!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblCategories.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If

                    End Using
                End If

            End If
        End If
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblCategoryBindingSource.Count - 1
            Dim x As TblCategory = TblCategoryBindingSource(i)
            If x.Name = Nothing Then
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
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'Dim x As New FrmCategoryInfo
        'x.ShowDialog()
        'If x.Saved Then
        '    refreshForm()
        'End If
        checkgridValidate()
        If isValidate Then
            TblCategoryDataGridView.ReadOnly = False
            TblCategoryBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblCategoryDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblCategoryBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblCategoryBindingSource.Count - 1
                        Dim x As TblCategory = TblCategoryBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblCategories.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblCategoryBindingSource.RemoveCurrent()
                                TblCategoryDataGridView.Refresh()
                            End If
                        Else



                            Dim CatId As Integer = TblCategoryBindingSource(i).id
                            Dim oldCat = (From ax In aMainor.TblCategories Where ax.Id = CatId).ToList(0)
                            Dim newCat As TblCategory = TblCategoryBindingSource(i)
                            oldCat.Name = newCat.Name
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblCategoryDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
    End Sub
End Class