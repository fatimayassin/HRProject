Public Class FrmBlood
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Private Sub FrmBlood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblBloodDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If

    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblBloodBindingSource.DataSource = aMainor.TblBloods.ToList
        End Using

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblBloodDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblBloodBindingSource.Count - 1

            Dim x As TblBlood = TblBloodBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblBloodDataGridView.ReadOnly = False
            TblBloodBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblBloodBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblBloodBindingSource.Count - 1
                        Dim x As TblBlood = TblBloodBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblBloods.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblBloodBindingSource.RemoveCurrent()
                                TblBloodDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim BloodId As Integer = TblBloodBindingSource(i).id
                                Dim oldBlood = (From ax In aMainor.TblBloods Where ax.Id = BloodId).ToList(0)
                                Dim NewBlood As TblBlood = TblBloodBindingSource(i)
                                oldBlood.Name = NewBlood.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblBloodDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
        saved = True

    End Sub

    Private Sub TblBloodDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblBloodDataGridView.CellContentClick
        If TblBloodBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblBloodBindingSource.Current.id
                        If Id = 0 Then
                            TblBloodBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblBloods Where aX.Id = Id).ToList(0)

                            If result.TblApplicants.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblApplicants!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblBloods.DeleteOnSubmit(result)
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