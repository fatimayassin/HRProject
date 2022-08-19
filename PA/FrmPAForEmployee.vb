Public Class FrmPAForEmployee
    Dim selectedDate As Date
    Public calendar As Boolean = False
    Public isValidate As Boolean = True
    Public AddPAForJob As Boolean = False
    Dim ListOfPAForJob As New List(Of Integer?)
    Public jobid As Integer = 0
    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1

            Dim x As TblPAForEmployee = TblPAForEmployeeBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblPAForEmployeeBindingSource.DataSource = aMainor.TblPAForEmployees.ToList
            If AddPAForJob Then
                Dim res = (From ax In aMainor.TblPAPerJobs Where ax.JobId = JobId).ToList
                If res.Count > 0 Then
                    ListOfPAForJob = (From ax In aMainor.TblPAPerJobs Where ax.JobId = JobId Select ax.PAId).ToList
                End If
                For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                    Dim PAId As Integer = TblPAForEmployeeBindingSource(i).id
                    If ListOfPAForJob.Contains(PAId) Then
                        TblPAForEmployeeDataGridView.Rows(i).Cells(Check.Index).Value = True

                    End If
                Next


            End If

        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub


    Private Sub FrmPAForEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        MonthCalendar1.Visible = False

        BtnSave.Enabled = False
        If AddPAForJob Then
            BtnSelect.Visible = True
            BtnSave.Visible = False
            TblPAForEmployeeDataGridView.Columns(Check.Index).Visible = True
            'TblPAForEmployeeDataGridView.ReadOnly = False

        Else
            BtnSelect.Visible = False
            BtnSave.Visible = True
            TblPAForEmployeeDataGridView.Columns(Check.Index).Visible = False
            'TblPAForEmployeeDataGridView.ReadOnly = True
        End If
        refreshForm()
    End Sub


    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        If selectedDate >= Date.Now Then

            MonthCalendar1.Visible = False
            TblPAForEmployeeDataGridView.Enabled = True
            If calendar = True Then
                TblPAForEmployeeDataGridView.CurrentRow.Cells(startDate.Index).Value = selectedDate
                TblPAForEmployeeBindingSource.Current.year = selectedDate.Year
            Else
                TblPAForEmployeeDataGridView.CurrentRow.Cells(endDate.Index).Value = selectedDate
            End If
        Else
            MessageBox.Show("Enter a valid date ")
        End If
    End Sub


    Private Sub TblPAForEmployeeDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblPAForEmployeeDataGridView.DataError
        If e.ColumnIndex = c1.Index Or e.ColumnIndex = c2.Index Then
            MessageBox.Show("Please enter a number!")
            TblPAForEmployeeDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing

        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblPAForEmployeeDataGridView.ReadOnly = False
            TblPAForEmployeeBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblPAForEmployeeDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblPAForEmployeeBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                        Dim x = TblPAForEmployeeBindingSource(i)
                        If x.Id = 0 Then
                            If x.name IsNot Nothing And x.version IsNot Nothing Then 'And x.startDate IsNot Nothing And x.EndDate IsNot Nothing
                                aMainor.TblPAForEmployees.InsertOnSubmit(x)
                                aMainor.SubmitChanges()

                            Else
                                TblPAForEmployeeBindingSource.RemoveCurrent()
                                TblPAForEmployeeDataGridView.Refresh()
                            End If
                        Else
                            If x.name IsNot Nothing And x.version IsNot Nothing Then
                                Dim emplId As Integer = TblPAForEmployeeBindingSource(i).id
                                Dim oldRow = (From ax In aMainor.TblPAForEmployees Where ax.Id = emplId).ToList(0)
                                Dim NewRow = TblPAForEmployeeBindingSource(i)
                                oldRow.Name = NewRow.name
                                oldRow.Version = NewRow.version
                                oldRow.Year = NewRow.year
                                oldRow.StartDate = NewRow.startDate
                                oldRow.EndDate = NewRow.EndDate
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next

                    TblPAForEmployeeDataGridView.ReadOnly = True
                    MonthCalendar1.Visible = False
                    TblPAForEmployeeDataGridView.Enabled = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If

            End If
        End Using

    End Sub

    Private Sub TblPAForEmployeeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPAForEmployeeDataGridView.CellClick
        If TblPAForEmployeeBindingSource.Count > 0 Then


            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblPAForEmployeeBindingSource.Current.id
                        If Id = 0 Then
                            TblPAForEmployeeBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainor.TblPAForEmployees Where aX.Id = Id).ToList(0)

                            If result.TblPAPerJobs.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblPAJobs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainor.TblPAForEmployees.DeleteOnSubmit(result)
                                aMainor.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If

    End Sub


    Private Sub FrmPAForEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
        TblPAForEmployeeDataGridView.Enabled = True
    End Sub

    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Using aMainor As New LqHRDataContext(cnx)
            'BtnSave_Click(sender, e)

            ''''''''''''''''''''''''''''''''''save PA'''''''''''''''''''''''''
            For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                Dim x = TblPAForEmployeeBindingSource(i)
                If x.Id = 0 Then
                    If x.name IsNot Nothing And x.version IsNot Nothing Then
                        aMainor.TblPAForEmployees.InsertOnSubmit(x)
                        aMainor.SubmitChanges()

                    Else
                        TblPAForEmployeeBindingSource.RemoveCurrent()
                        TblPAForEmployeeDataGridView.Refresh()
                    End If
                Else
                    If x.name IsNot Nothing And x.version IsNot Nothing Then  'And x.startDate IsNot Nothing And x.EndDate IsNot Nothing
                        Dim emplId As Integer = TblPAForEmployeeBindingSource(i).id
                        Dim oldRow = (From ax In aMainor.TblPAForEmployees Where ax.Id = emplId).ToList(0)
                        Dim NewRow = TblPAForEmployeeBindingSource(i)
                        oldRow.Name = NewRow.name
                        oldRow.Version = NewRow.version
                        oldRow.Year = NewRow.year
                        oldRow.StartDate = NewRow.startDate
                        oldRow.EndDate = NewRow.EndDate
                        aMainor.SubmitChanges()
                    End If
                End If

            Next

            ''''''''''''''''''''''''''save pa for job''''''''''''''''''''
            Dim res = (From ax In aMainor.TblPAPerJobs Where ax.JobId = jobid).ToList
            If res.Count > 0 Then
                aMainor.TblPAPerJobs.DeleteAllOnSubmit(res)
                aMainor.SubmitChanges()

            End If
            For i As Integer = 0 To TblPAForEmployeeBindingSource.Count - 1
                If TblPAForEmployeeDataGridView.Rows(i).Cells(Check.Index).Value = True Then
                    Dim PAPerJob As New TblPAPerJob
                    PAPerJob.JobId = jobid
                    PAPerJob.PAId = TblPAForEmployeeBindingSource(i).Id

                    aMainor.TblPAPerJobs.InsertOnSubmit(PAPerJob)
                    aMainor.SubmitChanges()

                End If
            Next
        End Using
        Me.Close()
    End Sub

    Private Sub TblPAForEmployeeDataGridView_ReadOnlyChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblPAForEmployeeDataGridView.ReadOnlyChanged
        c1.ReadOnly = True

    End Sub



    Private Sub TblPAForEmployeeDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblPAForEmployeeDataGridView.CellDoubleClick
        If TblPAForEmployeeDataGridView.ReadOnly = False Then
            If e.ColumnIndex = startDate.Index Then
                calendar = True
                TblPAForEmployeeDataGridView.Enabled = False
                MonthCalendar1.Visible = True
            End If
            If e.ColumnIndex = endDate.Index Then
                calendar = False
                TblPAForEmployeeDataGridView.Enabled = False
                MonthCalendar1.Visible = True
            End If

        End If
    End Sub
End Class