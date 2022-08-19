Public Class FrmTask
    Public isValidate As Boolean = True
    Public categoryId As Integer = 0
    Public saved As Boolean = False

    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblTaskBindingSource.DataSource = aMainor.TblTasks.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblTaskBindingSource.Count - 1

            Dim x As TblTask = TblTaskBindingSource(i)
            If x.CategoryId Is Nothing Or x.Description Is Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            TblCategoryBindingSource.DataSource = aMainor.TblCategories.ToList
        End Using
        refreshForm()
        TblTaskDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblTaskDataGridView.ReadOnly = False
            TblTaskBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblTaskDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblTaskBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblTaskBindingSource.Count - 1
                        Dim x As TblTask = TblTaskBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.CategoryId Is Nothing And x.Description IsNot Nothing Then
                                aMainor.TblTasks.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblTaskBindingSource.RemoveCurrent()
                                TblTaskDataGridView.Refresh()
                            End If
                        Else
                            If Not x.CategoryId Is Nothing And x.Description IsNot Nothing Then
                                Dim TaskID As Integer = TblTaskBindingSource(i).id
                                Dim oldTask = (From ax In aMainor.TblTasks Where ax.Id = TaskID).ToList(0)
                                Dim NewTask As TblTask = TblTaskBindingSource(i)
                                oldTask.CategoryId = NewTask.CategoryId
                                oldTask.Description = NewTask.Description
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblTaskDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()
                    saved = True
                End If

            End If
        End Using
    End Sub

    Private Sub TblTaskDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTaskDataGridView.CellContentClick
        If TblTaskBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblTaskBindingSource.Current.id
                        If Id = 0 Then
                            TblTaskBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblTasks Where aX.Id = Id).ToList(0)

                            If result.TblAveragePAPerTasks.Count > 0 And result.TblJobTasks.Count > 0 Then
                                MessageBox.Show("This Place is related to some Table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblTasks.DeleteOnSubmit(result)
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