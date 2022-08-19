Public Class FrmVactionsHolidaysDashBoard
    Public loaded As Boolean = False
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub FrmVactionsHolidaysDashBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            aMainor.UnionAllHolidaysAndVacations()

            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList

            IsVactionCheckBox.CheckState = CheckState.Indeterminate
            VactFromDateTimePicker.Value = New DateTime(DateTime.Now.Year, 1, 1)
            VactToDateTimePicker.Value = New DateTime(DateTime.Now.Year, 12, 31)
            TblVacationsHolidaysDashBoardBindingSource.DataSource = aMainor.TblVacationsHolidaysDashBoards.ToList

        End Using
        loaded = True
    End Sub

    Private Sub EmployeeNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeNameTextBox.TextChanged, YearTextBox.TextChanged, VactFromDateTimePicker.TextChanged, VactToDateTimePicker.TextChanged, NbOfDaysTextBox.TextChanged, IsVactionCheckBox.CheckStateChanged, ExcutedDaysTextBox.TextChanged, DescriptionTextBox.TextChanged
        If loaded Then


            Dim t As Integer
            Dim r As Integer
            Dim n As Integer
            Dim yearcol As Integer? = Nothing
            Dim NbOfDays As Integer? = Nothing
            Dim ExcutedDays As Integer? = Nothing
            Dim chek As Boolean? = Nothing
            Dim canfilter As Boolean = True
            If IsVactionCheckBox.CheckState <> CheckState.Indeterminate Then
                chek = IsVactionCheckBox.Checked
            End If


            If Not YearTextBox.Text = "" Then
                If Not Integer.TryParse(YearTextBox.Text, t) Then
                    MessageBox.Show("Please enter a valid record number!")
                    YearTextBox.Text = ""
                    canfilter = False
                Else
                    yearcol = Integer.Parse(YearTextBox.Text)
                End If
            End If

            If Not NbOfDaysTextBox.Text = "" Then
                If Not Integer.TryParse(NbOfDaysTextBox.Text, r) Then
                    MessageBox.Show("Please enter a valid record number!")
                    NbOfDaysTextBox.Text = ""
                    canfilter = False
                Else
                    NbOfDays = Integer.Parse(NbOfDaysTextBox.Text)
                End If
            End If

            If Not ExcutedDaysTextBox.Text = "" Then
                If Not Integer.TryParse(ExcutedDaysTextBox.Text, n) Then
                    MessageBox.Show("Please enter a valid record number!")
                    ExcutedDaysTextBox.Text = ""
                    canfilter = False
                Else
                    ExcutedDays = Integer.Parse(ExcutedDaysTextBox.Text)
                End If
            End If


            If canfilter Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblVacationsHolidaysDashBoardBindingSource.DataSource = aMainor.Filter_VactionsHolidaysDashBoard(EmployeeNameTextBox.Text, DescriptionTextBox.Text, yearcol, VactToDateTimePicker.Value, VactFromDateTimePicker.Value, ExcutedDays, NbOfDays, chek).ToList


                End Using
            End If
        End If
    End Sub
End Class