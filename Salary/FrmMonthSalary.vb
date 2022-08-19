Public Class FrmMonthSalary
    Public MonthPerYearId As Integer = 0
    'Public MonthId As Integer = 0
    Public Count As Integer
    Public HistoriesMonthPerYearList As List(Of Integer?)
    Public Posted As Boolean = False
    Public Locked As Boolean = False
    Public Edit As Boolean = False
    Dim saved As Boolean = False

    Private Sub FrmMonthSalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel1.BackColor = My.Settings.FormBackgroundColor
        Panel3.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            refreshHistoryList()
            Count = 0
            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
            refreshHistory()
        End Using
    End Sub

    Sub refreshHistoryList()
        Using aMainor As New LqHRDataContext(cnx)
            HistoriesMonthPerYearList = (From ax In aMainor.TblEmployeeSalaryHistories Select ax.MonthPerYearId Distinct).ToList()
            If Not HistoriesMonthPerYearList.Count = 0 Then
                If MonthPerYearId = 0 Then
                    PBAdd.Visible = False
                    MonthPerYearId = HistoriesMonthPerYearList(0)
                Else
                    Dim res = (From ax In aMainor.TblEmployeeSalaryHistories Where ax.MonthPerYearId = MonthPerYearId).ToList
                    If res.Count > 0 Then
                        PBAdd.Visible = False
                    Else
                        PBAdd.Visible = True
                    End If
                End If
            Else
                'addnew 
                PBAdd.Visible = True

            End If
        End Using
    End Sub

    Sub refreshHistory()
        Using aMainor As New LqHRDataContext(cnx)
            If MonthPerYearId = 0 Then
                If Not HistoriesMonthPerYearList.Count = 0 Then
                    MonthPerYearId = HistoriesMonthPerYearList(Count)
                    refreshHistory()
                End If
            Else
                TblEmployeeSalaryHistoryBindingSource.Clear()
                Dim res3 = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)
                Dim MthId As Integer = res3.MonthId
                Dim yerId As Integer = res3.YearId
                Dim MnthName = (From ax In aMainor.TblMonths Where ax.Id = MthId Select ax.Name).ToList(0)
                Dim yearName = (From ax In aMainor.TblYears Where ax.Id = yerId Select ax.Year).ToList(0)
                lblText.Text = MnthName & " " & yearName.ToString

                Dim res = (From ax In aMainor.TblEmployeeSalaryHistories Where ax.MonthPerYearId = MonthPerYearId).ToList()
                If res.Count > 0 Then

                    TblEmployeeSalaryHistoryBindingSource.DataSource = res
                    For i As Integer = 0 To TblEmployeeSalaryHistoryBindingSource.Count - 1
                        TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(NSSFTax.Index).Value = TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(NSSFSalary.Index).Value * 2.5
                    Next

                    Findtotal()
                End If

                'StatusIdLabel1.BackColor = Color.MistyRose
                Dim res1 = (From AX In aMainor.TblMonthsPerYears Where AX.Id = MonthPerYearId).ToList(0)

                Posted = res1.Posted
                Locked = res1.Locked
                If Posted Then
                    pnlPosted.Visible = True
                    PBEdit.Visible = False
                    '  PBDelete.Visible = False
                Else
                    pnlPosted.Visible = False
                    PBEdit.Visible = True
                    ' PBDelete.Visible = True
                End If
                If Locked Then
                    pnlAudited.Visible = True
                Else
                    pnlAudited.Visible = False
                End If
                TblMonthsPerYearBindingSource.DataSource = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)
            End If

        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub PBAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAdd.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblEmployeeSalaryHistories Where ax.MonthPerYearId = MonthPerYearId).ToList
            If res.Count > 0 Then
                MessageBox.Show("Salaries For this month Already Exists", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            Else
                Dim answer = MessageBox.Show("Create Salaries For this month?", "Create", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then

                    aMainor.CreateEmployeeHistory(MonthPerYearId)


                    refreshHistoryList()
                    refreshHistory()

                End If
            End If
           
        End Using
    End Sub

    Private Sub PBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBack.Click
        If HistoriesMonthPerYearList.Count > 0 Then

            ' EnableComponents(False)

            If Count = 0 Then
                Count = HistoriesMonthPerYearList.Count
                MonthPerYearId = HistoriesMonthPerYearList(Count - 1)
                refreshHistory()
            Else
                Count -= 1
                MonthPerYearId = HistoriesMonthPerYearList(Count)
                refreshHistory()
            End If

        End If
    End Sub

    Private Sub PBNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBNext.Click
        If HistoriesMonthPerYearList.Count > 0 Then
            'EnableComponents(False)
            Count += 1

            If Count = HistoriesMonthPerYearList.Count + 1 Or Count = HistoriesMonthPerYearList.Count Then
                Count = 0
                MonthPerYearId = HistoriesMonthPerYearList(Count)
                refreshHistory()
            Else
                MonthPerYearId = HistoriesMonthPerYearList(Count)
                refreshHistory()
            End If
        End If
    End Sub

    Private Sub PBLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLast.Click
        If HistoriesMonthPerYearList.Count > 0 Then


            Count = HistoriesMonthPerYearList.Count
            MonthPerYearId = HistoriesMonthPerYearList(Count - 1)
            refreshHistory()
        End If
    End Sub

    Private Sub PBFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFirst.Click
        If HistoriesMonthPerYearList.Count > 0 Then


            Count = 0
            MonthPerYearId = HistoriesMonthPerYearList(Count)
            refreshHistory()
        End If
    End Sub

    Private Sub PBExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBExit.Click
        Dim answer = MessageBox.Show("Are you Sure you want to close", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            lblClose_Click(sender, e)
        End If

    End Sub

    Private Sub PBEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEdit.Click
        If Posted = False And Locked = False Then
            TblEmployeeSalaryHistoryDataGridView.ReadOnly = False
            Edit = True

            PostNoteTextBox.Enabled = True
            PBSave.Visible = True
            PBBack.Enabled = False
            PBNext.Enabled = False
            PBFirst.Enabled = False
            PBLast.Enabled = False
            PBExit.Enabled = False
            PBSearch.Enabled = False
            PBEdit.Visible = False
        End If
    
    End Sub


    Private Sub BtnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPost.Click
        If Not Locked Then
            If Posted Then
                Posted = False
                'postVisibleComponents(True)
                'BtnAdd.Enabled = True
                PBEdit.Visible = True
                ' PBDelete.Visible = True

                pnlPosted.Visible = False
                Using aMainor As New LqHRDataContext(cnx)
                    Dim result = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)
                    result.Posted = Posted
                    aMainor.SubmitChanges()
                    Edit = False
                End Using
            Else
                PBSave_Click(sender, e)
                If saved Then
                    Posted = True
                    'postVisibleComponents(False)
                    pnlPosted.Visible = True
                    PBEdit.Visible = False
                  ' PBDelete.Visible = False
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim result = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)
                        result.Posted = Posted
                        aMainor.SubmitChanges()
                        Edit = False
                    End Using


                End If


            End If
        Else
            MessageBox.Show("You can't unpost Locked Month!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If




    End Sub

    Private Sub PBSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSave.Click
        saved = False
        Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To TblEmployeeSalaryHistoryBindingSource.Count - 1
                Dim SalaryHis As Integer = TblEmployeeSalaryHistoryBindingSource(i).id
                Using aMainor As New LqHRDataContext(cnx)
                    Dim OldRow = (From aX In aMainor.TblEmployeeSalaryHistories Where aX.Id = SalaryHis).ToList(0)
                    Dim NewRow As TblEmployeeSalaryHistory = TblEmployeeSalaryHistoryBindingSource(i)
                    OldRow.Absence = NewRow.Absence
                    OldRow.BasicSalary = NewRow.BasicSalary
                    OldRow.Bonus = NewRow.Bonus
                    OldRow.ClosedArea = NewRow.ClosedArea
                    OldRow.Credit = NewRow.Credit
                    OldRow.CurrencyId = NewRow.CurrencyId
                    OldRow.Excellence = NewRow.Excellence
                    OldRow.ExperienceIn = NewRow.ExperienceIn
                    OldRow.ExperienceOut = NewRow.ExperienceOut
                    OldRow.FamilySalary = NewRow.FamilySalary
                    OldRow.IsCash = NewRow.IsCash
                    OldRow.Note = NewRow.Note
                    OldRow.NSSFSalary = NewRow.NSSFSalary
                    OldRow.Old = NewRow.Old
                    OldRow.OtherMinus = NewRow.OtherMinus
                    OldRow.OtherPlus = NewRow.OtherPlus
                    OldRow.OvertimeHrs = NewRow.OvertimeHrs
                    OldRow.OvertimeValue = NewRow.OvertimeValue
                    OldRow.Phone = NewRow.Phone
                    OldRow.PositionValue = NewRow.PositionValue
                    OldRow.SchoolValue = NewRow.SchoolValue
                    OldRow.Speciality = NewRow.Speciality
                    OldRow.TransPerDay = NewRow.TransPerDay
                    aMainor.SubmitChanges()
                
                End Using

            Next
            Using aMainor As New LqHRDataContext(cnx)
                Dim oldRw = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)
                oldRw.PostNote = PostNoteTextBox.Text
                aMainor.SubmitChanges()
            End Using

            saved = True
            PBSave.Visible = False
            PBBack.Enabled = True
            PBNext.Enabled = True
            PBFirst.Enabled = True
            PBLast.Enabled = True
            PBExit.Enabled = True
            PBSearch.Enabled = True
            PostNoteTextBox.Enabled = False
            TblEmployeeSalaryHistoryDataGridView.ReadOnly = True
            PBEdit.Visible = True
            refreshHistory()
        End If
        '' after save saved =true 
    End Sub

    Private Sub BtnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLock.Click
        If Posted Then
            If Locked Then
                Locked = False
          
                pnlAudited.Visible = False
            Else
                Locked = True
        
                pnlAudited.Visible = True
            End If
            If Edit Then
                PBSave_Click(sender, e)
            Else
                Using aMainor As New LqHRDataContext(cnx)
                    Dim result = (From ax In aMainor.TblMonthsPerYears Where ax.Id = MonthPerYearId).ToList(0)

                    result.Locked = Locked
       
                    aMainor.SubmitChanges()
                End Using
            End If

        Else
            MessageBox.Show("You can't Lock unposted Month!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSearch.Click
        Dim x As New FrmYearCalendarForSalaries
        x.ShowDialog()
        If x.saved Then
            MonthPerYearId = x.id
            refreshHistory()
        End If
    End Sub

    Private Sub TblEmployeeSalaryHistoryDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeSalaryHistoryDataGridView.CellEndEdit
        Findtotal()
    End Sub
    Sub Findtotal()
        If TblEmployeeSalaryHistoryBindingSource.Count > 0 Then
            For i As Integer = 0 To TblEmployeeSalaryHistoryBindingSource.Count - 1
                TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(Total.Index).Value = TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(TransPerDayCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(ClosedAreaCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(ExpInCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(ExpOutCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(PositionCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(ExcellenceCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(OtherPlusCol.Index).Value - TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(OtherMinusCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(SchoolValueCol.Index).Value - TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(PhoneCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(CreditCol.Index).Value - TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(AbsenceCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(BonusCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(SpecialityCol.Index).Value + TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(OldCol.Index).Value + ((TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(OvertimeValCol.Index).Value) * TblEmployeeSalaryHistoryDataGridView.Rows(i).Cells(OvertimeHrsCol.Index).Value)

            Next
        End If
    End Sub

    Private Sub TblEmployeeSalaryHistoryDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TblEmployeeSalaryHistoryDataGridView.DataError
        If e.ColumnIndex = TransPerDayCol.Index Or e.ColumnIndex = OvertimeValCol.Index Or e.ColumnIndex = ClosedAreaCol.Index Or e.ColumnIndex = ExpInCol.Index Or e.ColumnIndex = ExpOutCol.Index Or e.ColumnIndex = PositionCol.Index Or e.ColumnIndex = ExcellenceCol.Index Or e.ColumnIndex = OvertimeHrsCol.Index Or e.ColumnIndex = OtherPlusCol.Index Or e.ColumnIndex = OtherMinusCol.Index Or e.ColumnIndex = SchoolValueCol.Index Or e.ColumnIndex = PhoneCol.Index Or e.ColumnIndex = CreditCol.Index Or e.ColumnIndex = AbsenceCol.Index Or e.ColumnIndex = BonusCol.Index Or e.ColumnIndex = SpecialityCol.Index Or e.ColumnIndex = OldCol.Index Then
            MessageBox.Show("Please enter a Valid Value!")
            TblEmployeeSalaryHistoryDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = Nothing

        End If
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click

    End Sub
End Class