Public Class FrmSkillsList
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblSkillBindingSource.DataSource = aMainor.TblSkills.ToList
        End Using
    End Sub
    Private Sub FrmSkillsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblSkillDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Sub checkgridValidate()
        For i As Integer = 0 To TblSkillBindingSource.Count - 1
            Dim x As TblSkill = TblSkillBindingSource(i)
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
        checkgridValidate()
        If isValidate Then
            TblSkillDataGridView.ReadOnly = False
            TblSkillBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblSkillBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblSkillBindingSource.Count - 1
                        Dim x As TblSkill = TblSkillBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblSkills.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblSkillBindingSource.RemoveCurrent()
                                TblSkillDataGridView.Refresh()
                            End If
                        Else



                            Dim SkillId As Integer = TblSkillBindingSource(i).id
                            Dim OldSkill = (From ax In aMainor.TblSkills Where ax.Id = SkillId).ToList(0)
                            Dim NewSkill As TblSkill = TblSkillBindingSource(i)
                            OldSkill.Name = NewSkill.Name
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblSkillDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                End If
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblSkillDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub TblSkillDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSkillDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblSkillBindingSource.Current.id
                    If Id = 0 Then
                        TblSkillBindingSource.RemoveCurrent()
                        TblSkillDataGridView.Refresh()
                    Else
                        Dim result = (From aX In aMainOR.TblSkills Where aX.Id = Id).ToList(0)

                        If result.TblApplicantSkills.Count > 0 Then
                            MessageBox.Show("cannot be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            aMainOR.TblSkills.DeleteOnSubmit(result)
                            aMainOR.SubmitChanges()
                            refreshForm()
                        End If
                    End If
                End Using
            End If

        End If

    End Sub
End Class