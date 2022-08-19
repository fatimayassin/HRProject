Public Class FrmMonths
    Public isValidate As Boolean = True
    Public saved As Boolean = False

    Private Sub FrmMonths_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblMonthDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblMonthBindingSource.DataSource = aMainor.TblMonths.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblMonthBindingSource.Count - 1

            Dim x As TblMonth = TblMonthBindingSource(i)
            If x.Name Is Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

 
  
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblMonthDataGridView.ReadOnly = False
            TblMonthBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblMonthDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblMonthBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblMonthBindingSource.Count - 1
                        Dim x As TblMonth = TblMonthBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name Is Nothing Then
                                aMainor.TblMonths.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblMonthBindingSource.RemoveCurrent()
                                TblMonthDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name Is Nothing Then
                                Dim monthId As Integer = TblMonthBindingSource(i).id
                                Dim oldMonth = (From ax In aMainor.TblMonths Where ax.Id = monthId).ToList(0)
                                Dim newMonth As TblMonth = TblMonthBindingSource(i)
                                oldMonth.Name = newMonth.Name
                                oldMonth.ArabicName = newMonth.ArabicName
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblMonthDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()
                    saved = True
                End If

            End If
        End Using
    End Sub

    Private Sub TblMonthDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMonthDataGridView.CellContentClick
        If TblMonthBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this record!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblMonthBindingSource.Current.id
                        If Id = 0 Then
                            TblMonthBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainor.TblMonths Where aX.Id = Id).ToList(0)

                            If result.TblMonthsPerYears.Count > 0 Then
                                MessageBox.Show("This record cannot be deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainor.TblMonths.DeleteOnSubmit(result)
                                aMainor.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub
End Class