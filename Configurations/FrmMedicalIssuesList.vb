Public Class FrmMedicalIssuesList
    Public ISvALIDATE As Boolean = True
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblMedicalIssueBindingSource.DataSource = aMainor.TblMedicalIssues.ToList
        End Using
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblMedicalIssueBindingSource.Count - 1
            Dim x As TblMedicalIssue = TblMedicalIssueBindingSource(i)
            If x.MedicalIssue = Nothing Then
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
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub FrmMedicalIssuesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblMedicalIssueDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub TblMedicalIssueDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMedicalIssueDataGridView.CellContentClick
        If TblMedicalIssueBindingSource.Count > 0 Then
            'If e.ColumnIndex = Edit.Index Then
            '    Dim Id As Integer = TblMedicalIssueBindingSource.Current.id

            '    Dim x As New FrmMedicalIssueInfo
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
                        Dim Id As Integer = TblMedicalIssueBindingSource.Current.id
                        If Id = 0 Then
                            TblMedicalIssueBindingSource.RemoveCurrent()
                            TblMedicalIssueDataGridView.Refresh()
                        Else
                            Dim result = (From aX In aMainOR.TblMedicalIssues Where aX.Id = Id).ToList(0)

                            If result.TblApplicantMedicalIssues.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblApplicantMedicalIssues!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblMedicalIssues.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
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
            TblMedicalIssueDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblMedicalIssueBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblMedicalIssueBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblMedicalIssueBindingSource.Count - 1
                        Dim x As TblMedicalIssue = TblMedicalIssueBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.MedicalIssue = Nothing Then
                                aMainor.TblMedicalIssues.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblMedicalIssueBindingSource.RemoveCurrent()
                                TblMedicalIssueDataGridView.Refresh()
                            End If
                        Else
                            Dim MedId As Integer = TblMedicalIssueBindingSource(i).id
                            Dim oldMed = (From ax In aMainor.TblMedicalIssues Where ax.Id = MedId).ToList(0)
                            Dim newMed As TblMedicalIssue = TblMedicalIssueBindingSource(i)
                            oldMed.MedicalIssue = newMed.MedicalIssue
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblMedicalIssueDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblMedicalIssueDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
End Class