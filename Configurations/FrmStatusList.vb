Public Class FrmStatusList
    Public isValidate As Boolean = True
    Public saved As Boolean = False

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblStatusBindingSource.DataSource = aMainor.TblStatus.ToList
        End Using
    End Sub

    Private Sub FrmStatusList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblStatusDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub TblStatusDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblStatusDataGridView.CellContentClick
        If TblStatusBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblStatusBindingSource.Current.id
                        If Id = 0 Then
                            TblStatusBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblStatus Where aX.Id = Id).ToList(0)

                            If result.TblApplicants.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblApplicant!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblStatus.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblStatusBindingSource.Count - 1
            Dim x As TblStatus = TblStatusBindingSource(i)
            If x.Name = Nothing Then
                'If i = 0 Then
                '    isValidate = False
                'Else
                '    isValidate = isValidate And False
                'End If
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblStatusDataGridView.ReadOnly = False
            TblStatusBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblStatusBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblStatusBindingSource.Count - 1
                        Dim x As TblStatus = TblStatusBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblStatus.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblStatusBindingSource.RemoveCurrent()
                                TblStatusDataGridView.Refresh()
                            End If
                        Else



                            Dim StatusId As Integer = TblStatusBindingSource(i).id
                            Dim oldStatus = (From ax In aMainor.TblStatus Where ax.Id = StatusId).ToList(0)
                            Dim NewStatus As TblStatus = TblStatusBindingSource(i)
                            oldStatus.Name = NewStatus.Name
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblStatusDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                End If
            End If
        End Using
        saved = True
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblStatusDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
End Class