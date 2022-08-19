Public Class FrmType
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblTypeBindingSource.DataSource = aMainor.TblTypes.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblTypeBindingSource.Count - 1

            Dim x As TblType = TblTypeBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblTypeDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblTypeDataGridView.ReadOnly = False
            TblTypeBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblTypeDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblTypeBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblTypeBindingSource.Count - 1
                        Dim x As TblType = TblTypeBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblTypes.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblTypeBindingSource.RemoveCurrent()
                                TblTypeDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim TypeID As Integer = TblTypeBindingSource(i).id
                                Dim oldType = (From ax In aMainor.TblTypes Where ax.Id = TypeID).ToList(0)
                                Dim NewType As TblType = TblTypeBindingSource(i)
                                oldType.Name = NewType.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblTypeDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
                saved = True
            End If
        End Using
    End Sub

    Private Sub TblTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTypeDataGridView.CellContentClick
        If TblTypeBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblTypeBindingSource.Current.id
                        If Id = 0 Then
                            TblTypeBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblTypes Where aX.Id = Id).ToList(0)

                            If result.TblRequirements.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblRequirements!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblTypes.DeleteOnSubmit(result)
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