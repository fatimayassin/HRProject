Public Class FrmSalaryCategories
    Public ISvALIDATE As Boolean = True

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        For i As Integer = 0 To TblSalaryCategoryBindingSource.Count - 1
            Dim x As TblSalaryCategory = TblSalaryCategoryBindingSource(i)
            If x.SalaryCategory = Nothing Then
                If i = 0 Then
                    ISvALIDATE = False
                Else
                    ISvALIDATE = ISvALIDATE And False
                End If
            Else
                ISvALIDATE = True
            End If
        Next
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSalaryCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblSalaryCatDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub TblSalaryCatDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSalaryCatDataGridView.CellContentClick
        If TblSalaryCategoryBindingSource.Count > 0 Then

            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblSalaryCategoryBindingSource.Current.SalaryCatID
                        If Id = 0 Then
                            TblSalaryCategoryBindingSource.RemoveCurrent()
                            TblSalaryCatDataGridView.Refresh()
                        Else
                            Dim result = (From aX In aMainor.TblSalaryCategories Where aX.SalaryCatID = Id).ToList(0)

                            If result.TblEmployeeSalary2s.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblSalaryCategories!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainor.TblSalaryCategories.DeleteOnSubmit(result)
                                aMainor.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If ISvALIDATE Then
            TblSalaryCatDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblSalaryCategoryBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblSalaryCategoryBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblSalaryCategoryBindingSource.Count - 1
                        Dim x As TblSalaryCategory = TblSalaryCategoryBindingSource(i)
                        If x.SalaryCatID = 0 Then
                            If Not x.SalaryCategory = Nothing Then
                                aMainor.TblSalaryCategories.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblSalaryCategoryBindingSource.RemoveCurrent()
                                TblSalaryCatDataGridView.Refresh()
                            End If
                        Else
                            Dim MedId As Integer = TblSalaryCategoryBindingSource(i).SalaryCatID
                            Dim oldMed = (From ax In aMainor.TblSalaryCategories Where ax.SalaryCatID = MedId).ToList(0)
                            Dim newMed As TblSalaryCategory = TblSalaryCategoryBindingSource(i)
                            oldMed.SalaryCategory = newMed.SalaryCategory
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblSalaryCatDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblSalaryCatDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

End Class