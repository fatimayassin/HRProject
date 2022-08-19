Public Class FrmDepartmentType
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblDepartmentTypeBindingSource.DataSource = aMainor.TblDepartmentTypes.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblDepartmentTypeBindingSource.Count - 1

            Dim x As TblDepartmentType = TblDepartmentTypeBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmDepartmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblDepartmentTypeDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblDepartmentTypeDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblDepartmentTypeDataGridView.ReadOnly = False
            TblDepartmentTypeBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblDepartmentTypeBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblDepartmentTypeBindingSource.Count - 1
                        Dim x As TblDepartmentType = TblDepartmentTypeBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblDepartmentTypes.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblDepartmentTypeBindingSource.RemoveCurrent()
                                TblDepartmentTypeDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim departmentTypeId As Integer = TblDepartmentTypeBindingSource(i).id
                                Dim oldDepType = (From ax In aMainor.TblDepartmentTypes Where ax.Id = departmentTypeId).ToList(0)
                                Dim NewDepType As TblDepartmentType = TblDepartmentTypeBindingSource(i)
                                oldDepType.Name = NewDepType.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblDepartmentTypeDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
    End Sub

    Private Sub TblDepartmentTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblDepartmentTypeDataGridView.CellContentClick
        If TblDepartmentTypeBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblDepartmentTypeBindingSource.Current.id
                        If Id = 0 Then
                            TblDepartmentTypeBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblDepartmentTypes Where aX.Id = Id).ToList(0)

                            If result.TblDepartments.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblDepartment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblDepartmentTypes.DeleteOnSubmit(result)
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