Public Class FrmYearCalendarForSalaries
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public Count As Integer
    Public YearsList As New List(Of Integer)
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub FrmYearCalendarForSalaries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            refreshYearsList()
            Count = 0
            'TblYearBindingSource.DataSource = aMainor.TblYears.ToList
            refreshyear()
        End Using
        '  refreshFrm()
    End Sub

    Sub refreshYearsList()
        Using aMainor As New LqHRDataContext(cnx)
            YearsList = (From ax In aMainor.TblYears Select ax.Id).ToList()
            If Not YearsList.Count = 0 Then
                If Id = 0 Then
                    Id = YearsList(0)
                End If
            Else
                '  AddNew()
            End If
        End Using
    End Sub
    Sub refreshyear()

        Using aMainor As New LqHRDataContext(cnx)
            If Id = 0 Then
                If Not YearsList.Count = 0 Then
                    Id = YearsList(Count)
                    refreshyear()
                End If
                'BtnAssign.Visible = False
            Else
                Dim Cnt = (From ax In aMainor.Filter_MonthPerYearCalendar("", "", Id)).ToList.Count
                If Not Cnt = 12 Then

                    aMainor.MonthsPerYear(Id)

                End If


                Dim res = (From ax In aMainor.Filter_MonthPerYearCalendar("", "", Nothing) Where ax.YearId = Id).ToList()

                Filter_MonthPerYearCalendarResultBindingSource.DataSource = res
                Dim YearName = res.ToList(0).Year
                lblText.Text = "Calendar For " & " " & YearName.ToString

            End If
               End Using

    End Sub



    Private Sub TblMonthsPerYearDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_MonthPerYearCalendarResultDataGridView.CellContentClick
        If e.ColumnIndex = View.Index Then
            Using aMainor As New LqHRDataContext(cnx)
                Dim x As New FrmMonthSalary
                'Dim yerId As Integer = TblMonthsPerYearBindingSource.Current.Year
                x.MonthPerYearId = Filter_MonthPerYearCalendarResultBindingSource.Current.Id
                x.ShowDialog()

            End Using
        End If
    End Sub

    Private Sub TblMonthsPerYearDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_MonthPerYearCalendarResultDataGridView.CellDoubleClick
        Id = Filter_MonthPerYearCalendarResultBindingSource.Current.id
        Saved = True
        Me.Close()
    End Sub



    'Private Sub YearTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearTextBox.TextChanged, MonthTextBox.TextChanged, ArabicMonthTextBox.TextChanged
    '    Dim x As Integer? = Nothing
    '    Dim t As Integer
    '    Dim canfilter As Boolean = True
    '    If Not YearTextBox.Text = "" Then

    '        If Integer.TryParse(YearTextBox.Text, t) Then
    '            x = Integer.Parse(YearTextBox.Text)
    '            canfilter = True
    '        Else
    '            MessageBox.Show("please enter a valid number")
    '            YearTextBox.Clear()
    '            canfilter = False
    '        End If

    '    End If
    '    Using aMainor As New LqHRDataContext(cnx)


    '        If canfilter Then
    '            If Not YearTextBox.Text = "" Then

    '                Filter_MonthPerYearCalendarResultBindingSource.DataSource = (From ax In aMainor.Filter_MonthPerYearCalendar(MonthTextBox.Text, ArabicMonthTextBox.Text, Nothing) Where ax.Year = YearTextBox.Text).ToList

    '            Else
    '                Filter_MonthPerYearCalendarResultBindingSource.DataSource = aMainor.Filter_MonthPerYearCalendar(MonthTextBox.Text, ArabicMonthTextBox.Text, Nothing).ToList
    '            End If
    '        End If
    '    End Using
    'End Sub


    Private Sub PBFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFirst.Click
        If YearsList.Count > 0 Then
            Count = 0
            Id = YearsList(Count)
            refreshyear()
        End If
    End Sub

    Private Sub PBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBack.Click
        If YearsList.Count > 0 Then


            If Count = 0 Then
                Count = YearsList.Count
                Id = YearsList(Count - 1)
                refreshyear()
            Else
                Count -= 1
                Id = YearsList(Count)
                refreshyear()
            End If

        End If
    End Sub

    Private Sub PBNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBNext.Click
        If YearsList.Count > 0 Then

            Count += 1

            If Count = YearsList.Count + 1 Or Count = YearsList.Count Then
                Count = 0
                Id = YearsList(Count)
                refreshyear()
            Else
                Id = YearsList(Count)
                refreshyear()
            End If
        End If
    End Sub

    Private Sub PBLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLast.Click
        If YearsList.Count > 0 Then

            Count = YearsList.Count
            Id = YearsList(Count - 1)
            refreshyear()
        End If
    End Sub
End Class