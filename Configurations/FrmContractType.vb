Public Class FrmContractType
    Public isValidate As Boolean = True
    Public SAVED As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub lblText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblText.Click

    End Sub

    Private Sub FrmContractType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblContractTypeDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblContractTypeBindingSource.DataSource = aMainor.TblContractTypes.ToList
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblContractTypeDataGridView.ReadOnly = False
        BtnSave.Enabled = True

    End Sub
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblContractTypeBindingSource.Count - 1

            Dim x As TblContractType = TblContractTypeBindingSource(i)
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
            TblContractTypeDataGridView.ReadOnly = False
            TblContractTypeBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TblContractTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblContractTypeDataGridView.CellContentClick
        If TblContractTypeBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblContractTypeBindingSource.Current.id
                        If Id = 0 Then
                            TblContractTypeBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainor.TblContractTypes Where aX.Id = Id).ToList(0)

                            If result.TblEmployeeJobs.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblEmployeeJobs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainor.TblContractTypes.DeleteOnSubmit(result)
                                aMainor.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblContractTypeBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblContractTypeBindingSource.Count - 1
                        Dim x As TblContractType = TblContractTypeBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblContractTypes.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblContractTypeBindingSource.RemoveCurrent()
                                TblContractTypeDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim ContractTypeId As Integer = TblContractTypeBindingSource(i).id
                                Dim oldContractType = (From ax In aMainor.TblContractTypes Where ax.Id = ContractTypeId).ToList(0)
                                Dim NewContractType As TblContractType = TblContractTypeBindingSource(i)
                                oldContractType.Name = NewContractType.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblContractTypeDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()
                End If
            End If
        End Using
        SAVED = True


    End Sub
End Class