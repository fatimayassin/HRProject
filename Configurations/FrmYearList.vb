Public Class FrmYearList
    Public Saved As Boolean = False
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub FrmYearList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblYearDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblYearBindingSource.DataSource = aMainor.TblYears.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblYearBindingSource.Count - 1

            Dim x As TblYear = TblYearBindingSource(i)
            If x.Year Is Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblYearDataGridView.ReadOnly = False
            TblYearBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblYearDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblYearBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblYearBindingSource.Count - 1
                        Dim x As TblYear = TblYearBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Year Is Nothing Then
                                aMainor.TblYears.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblYearBindingSource.RemoveCurrent()
                                TblYearDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Year Is Nothing Then
                                Dim YearId As Integer = TblYearBindingSource(i).id
                                Dim oldyear = (From ax In aMainor.TblYears Where ax.Id = YearId).ToList(0)
                                Dim NewYear As TblYear = TblYearBindingSource(i)
                                oldyear.Year = NewYear.Year
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblYearDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()
                    Saved = True
                End If

            End If
        End Using
    End Sub

    Private Sub TblYearDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblYearDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim YearId As Integer = TblYearBindingSource.Current.ID
                Dim res = (From ax In aMainor.TblYears Where ax.Id = YearId).ToList(0)
                If res.TblMonthsPerYears.Count > 0 Then
                    MessageBox.Show("Cannot be Deleted ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else

                    aMainor.TblYears.DeleteOnSubmit(res)
                    aMainor.SubmitChanges()
                    refreshForm()
                End If
            End Using

        End If
    End Sub
End Class