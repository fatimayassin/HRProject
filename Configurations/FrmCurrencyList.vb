Public Class FrmCurrencyList
    Public isValidate As Boolean = True
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
        End Using
    End Sub
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub FrmCurrencyList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblCurrencyDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub TblCurrencyDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCurrencyDataGridView.CellContentClick
        If TblCurrencyBindingSource.Count > 0 Then
            'If e.ColumnIndex = Edit.Index Then
            '    Dim Id As Integer = TblCurrencyBindingSource.Current.id

            '    Dim x As New FrmCurrencyInfo
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
                        Dim Id As Integer = TblCurrencyBindingSource.Current.id
                        If Id = 0 Then
                            TblCurrencyBindingSource.RemoveCurrent()
                            TblCurrencyDataGridView.Refresh()
                        Else

                            Dim result = (From aX In aMainOR.TblCurrencies Where aX.Id = Id).ToList(0)

                            If result.TblRequiredJobs.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblRequiredJob!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblCurrencies.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Sub checkgridValidate()
        For i As Integer = 0 To TblCurrencyBindingSource.Count - 1
            Dim x As TblCurrency = TblCurrencyBindingSource(i)
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
            TblCurrencyDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblCurrencyBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblCurrencyDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblCurrencyBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblCurrencyBindingSource.Count - 1
                        Dim x As TblCurrency = TblCurrencyBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing And Not x.Exchange Is Nothing Then
                                aMainor.TblCurrencies.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblCurrencyBindingSource.RemoveCurrent()
                                TblCurrencyDataGridView.Refresh()
                            End If
                        Else



                            Dim currid As Integer = TblCurrencyBindingSource(i).id
                            Dim oldCurr = (From ax In aMainor.TblCurrencies Where ax.Id = currid).ToList(0)
                            Dim newCurr As TblCurrency = TblCurrencyBindingSource(i)
                            oldCurr.Name = newCurr.Name
                            oldCurr.Exchange = newCurr.Exchange
                            aMainor.SubmitChanges()

                        End If

                    Next
                    TblCurrencyDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
    End Sub

    Private Sub TblCurrencyDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblCurrencyDataGridView.DataError
        If e.ColumnIndex = Exchange.Index Then
            MessageBox.Show("Please enter a number!")
            TblCurrencyDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing

        End If
    End Sub
End Class