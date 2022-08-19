Public Class FrmHolidays
    Dim selectedDate As Date
    Public calendar As Boolean = False
    Public isValidate As Boolean = True

    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If

    End Sub


    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TextBox1.Text = ""
            TblHolidayBindingSource.DataSource = aMainor.TblHolidays.ToList

        End Using

    End Sub


    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblHolidayBindingSource.Count - 1

            Dim x As TblHoliday = TblHolidayBindingSource(i)
            If x.Description Is Nothing Or x.Date Is Nothing Or x.Year Is Nothing Or x.NumberOfDays Is Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub



    Private Sub FrmHolidays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)

            TblHolidayBindingSource.DataSource = (From ax In aMainor.TblHolidays Where ax.Year = TextBox1.Text).ToList

        End Using
        MonthCalendar1.Visible = False
        TblHolidayDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        selectedDate = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        If selectedDate >= Date.Now Then

            MonthCalendar1.Visible = False
            TblHolidayDataGridView.Enabled = True

            TblHolidayDataGridView.CurrentRow.Cells(DateColumn.Index).Value = selectedDate



            TblHolidayDataGridView.CurrentRow.Cells(yearcolumn.Index).Value = selectedDate.Year

        Else
            MessageBox.Show("Enter a valid date ")
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblHolidayDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblHolidayDataGridView.ReadOnly = False
            TblHolidayBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TblHolidayDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblHolidayDataGridView.CellClick
        If TblHolidayBindingSource.Count > 0 Then
            If TblHolidayDataGridView.ReadOnly = False Then
                If e.ColumnIndex = DateColumn.Index Then

                    TblHolidayDataGridView.Enabled = False
                    MonthCalendar1.Visible = True
                End If


            End If

            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblHolidayBindingSource.Current.id
                        If Id = 0 Then
                            TblHolidayBindingSource.RemoveCurrent()
                        Else
                            Dim res = (From ax In aMainor.TblEmployeeHolidays Where ax.HolidayId = Id And Not ax.ExecutionDate Is Nothing).ToList
                            If res.Count > 0 Then
                                MessageBox.Show("You cannot delete this Holiday ")
                            Else

                                Dim res1 = (From ax In aMainor.TblEmployeeHolidays Where ax.HolidayId = Id).ToList
                                aMainor.TblEmployeeHolidays.DeleteAllOnSubmit(res1)
                                aMainor.SubmitChanges()


                                Dim result = (From aX In aMainor.TblHolidays Where aX.Id = Id).ToList(0)

                                aMainor.TblHolidays.DeleteOnSubmit(result)
                                aMainor.SubmitChanges()
                                refreshForm()
                            End If

                           

                        End If
                    End Using
                End If

            End If
            If e.ColumnIndex = Execute.Index Then
                Dim x As New FrmHolidaysExecuted
                x.HolId = TblHolidayBindingSource.Current.id
                x.ExecutedDays = TblHolidayBindingSource.Current.NumberOfDays
                x.dateHol = TblHolidayBindingSource.Current.date
                x.ShowDialog()


            End If
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblHolidayBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblHolidayBindingSource.Count - 1
                        Dim x As TblHoliday = TblHolidayBindingSource(i)
                        If x.Id = 0 Then
                            If x.Description IsNot Nothing And x.Date IsNot Nothing And x.Year IsNot Nothing And x.NumberOfDays IsNot Nothing Then
                                aMainor.TblHolidays.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblHolidayBindingSource.RemoveCurrent()
                                TblHolidayDataGridView.Refresh()
                            End If
                        Else
                            If x.Description IsNot Nothing And x.Date IsNot Nothing And x.NumberOfDays IsNot Nothing And x.Year IsNot Nothing Then
                                Dim holId As Integer = TblHolidayBindingSource(i).id
                                Dim oldRow = (From ax In aMainor.TblHolidays Where ax.Id = holId).ToList(0)
                                Dim NewRow As TblHoliday = TblHolidayBindingSource(i)
                                oldRow.Date = NewRow.Date
                                oldRow.Description = NewRow.Description
                                oldRow.NumberOfDays = NewRow.NumberOfDays
                                oldRow.Year = NewRow.Year

                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblHolidayDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
    End Sub

    Private Sub TblHolidayDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblHolidayDataGridView.DataError
        If e.ColumnIndex = yearcolumn.Index Or e.ColumnIndex = NumberOfDaysColumn.Index Then
            MessageBox.Show("Please enter a number!")
            TblHolidayDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing

        End If
    End Sub

    Private Sub FrmHolidaysPerYears_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
        TblHolidayDataGridView.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim x As Integer? = Nothing
        Dim t As Integer
        Dim canfilter As Boolean = True
        If Not TextBox1.Text = "" Then

            If Integer.TryParse(TextBox1.Text, t) Then
                x = Integer.Parse(TextBox1.Text)
                canfilter = True
            Else
                MessageBox.Show("please enter a valid number")
                TextBox1.Clear()
                canfilter = False
            End If

        End If
        Using aMainor As New LqHRDataContext(cnx)
            If canfilter Then
                If Not TextBox1.Text = "" Then
                    TblHolidayBindingSource.DataSource = (From ax In aMainor.TblHolidays Where ax.Year = TextBox1.Text).ToList

                Else
                    TblHolidayBindingSource.DataSource = aMainor.TblHolidays.ToList
                End If
            End If


        End Using
    End Sub

    Private Sub TblHolidayDataGridView_ReadOnlyChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblHolidayDataGridView.ReadOnlyChanged
        yearcolumn.ReadOnly = True
    End Sub


End Class