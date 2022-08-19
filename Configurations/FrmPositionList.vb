Public Class FrmPositionList
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblPositionBindingSource.DataSource = aMainor.TblPositions.ToList
        End Using
    End Sub
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub



    Private Sub FrmPositionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblPositionDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub TblPositionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPositionDataGridView.CellContentClick
        If TblPositionBindingSource.Count > 0 Then
            'If e.ColumnIndex = Edit.Index Then
            '    Dim Id As Integer = TblPositionBindingSource.Current.id

            '    Dim x As New FrmPositionInfo
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
                        Dim Id As Integer = TblPositionBindingSource.Current.id
                        If Id = 0 Then
                            TblPositionBindingSource.RemoveCurrent()
                            TblPositionDataGridView.Refresh()
                        Else
                            Dim result = (From aX In aMainOR.TblPositions Where aX.Id = Id).ToList(0)

                            'If result.TblJobDescriptions.Count > 0 Then
                            '    MessageBox.Show("This Place is related to some TblJobDescriptions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            'Else
                            aMainOR.TblPositions.DeleteOnSubmit(result)
                            aMainOR.SubmitChanges()
                            refreshForm()
                        End If
                    End Using
                End If

            End If
        End If
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblPositionBindingSource.Count - 1
            Dim x As TblPosition = TblPositionBindingSource(i)
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
            TblPositionDataGridView.ReadOnly = False
            TblPositionBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblPositionBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblPositionBindingSource.Count - 1
                        Dim x As TblPosition = TblPositionBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblPositions.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblPositionBindingSource.RemoveCurrent()
                                TblPositionDataGridView.Refresh()
                            End If
                        Else



                            Dim PosId As Integer = TblPositionBindingSource(i).id
                            Dim OldPos = (From ax In aMainor.TblPositions Where ax.Id = PosId).ToList(0)
                            Dim newPos As TblPosition = TblPositionBindingSource(i)
                            OldPos.Name = newPos.Name
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblPositionDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                End If
            End If
        End Using
        saved = True
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblPositionDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
End Class