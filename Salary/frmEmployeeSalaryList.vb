Public Class frmEmployeeSalaryList
    Public loaded As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub frmEmployeeSalaryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblDegreeBindingSource.DataSource = aMainor.TblDegrees.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList
            TblCurrencyBindingSource.Insert(0, New TblCurrency)
            TblClassificationBindingSource.DataSource = aMainor.TblClassifications.ToList
            Filter_EmployeeJobSalaryDetailsResultBindingSource.DataSource = aMainor.Filter_EmployeeJobSalaryDetails("", "", "", 0).ToList
            CurencyIdComboBox.SelectedIndex = 0
        End Using
        loaded = True
    End Sub

    Private Sub JobNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged, JobNameTextBox.TextChanged, DepTextBox.TextChanged, CurencyIdComboBox.TextChanged
        If loaded Then
            Dim currId As Integer = 0
            If CurencyIdComboBox.SelectedIndex > -1 Then
                currId = CurencyIdComboBox.SelectedValue

            End If
            Using aMainor As New LqHRDataContext(cnx)
                Filter_EmployeeJobSalaryDetailsResultBindingSource.DataSource = (From ax In aMainor.Filter_EmployeeJobSalaryDetails(NameTextBox.Text, DepTextBox.Text, JobNameTextBox.Text, currId)).ToList
            End Using


        End If
    End Sub
End Class