Public Class FrmYearlyVacations
    Public isValidate As Boolean = True
    Public saved As Boolean = False
  
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblYearlyVacationBindingSource.DataSource = aMainor.TblYearlyVacations.ToList
        End Using
    End Sub
    Private Sub FrmYearlyVacations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblYearlyVacationDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblYearlyVacationDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblYearlyVacationDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblYearlyVacationBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub checkgridValidate()
        For i As Integer = 0 To TblYearlyVacationBindingSource.Count - 1
            Dim x As TblYearlyVacation = TblYearlyVacationBindingSource(i)
            If x.MinYear Is Nothing Or x.MaxYear Is Nothing Or x.NumberOfDays Is Nothing Then
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

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblYearlyVacationBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblYearlyVacationBindingSource.Count - 1
                        Dim x As TblYearlyVacation = TblYearlyVacationBindingSource(i)
                        x.VacationId = YearlyVacationId
                        If x.Id = 0 Then
                            If Not x.MinYear Is Nothing Or x.MaxYear Is Nothing Or x.NumberOfDays Is Nothing Then
                                aMainor.TblYearlyVacations.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblYearlyVacationBindingSource.RemoveCurrent()
                                TblYearlyVacationDataGridView.Refresh()
                            End If
                        Else
                            Dim VacId As Integer = TblYearlyVacationBindingSource(i).id
                            Dim oldVac = (From ax In aMainor.TblYearlyVacations Where ax.Id = VacId).ToList(0)
                            Dim newvac As TblYearlyVacation = TblYearlyVacationBindingSource(i)
                            oldVac.MaxYear = newvac.MaxYear
                            oldVac.MinYear = newvac.MinYear
                            oldVac.NumberOfDays = newvac.NumberOfDays
                            aMainor.SubmitChanges()

                        End If
                    Next
                    TblYearlyVacationDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
        saved = True
        Me.Close()
    End Sub
End Class