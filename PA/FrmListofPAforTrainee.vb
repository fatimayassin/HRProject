Public Class FrmListofPAforTrainee
    Public RowIndex As Integer = 0
    Public ApplicantList As New List(Of Integer)
    Public appId As Integer = 0
    Public CloseOnDoubleClick As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmListofPAforTrainee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            FromDateTimePicker.Value = New DateTime(DateTime.Now.Year, 1, 1)
            ToDateTimePicker.Value = New DateTime(DateTime.Now.Year, 12, 31)
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            Filter_ListOfPAforTraineeResultBindingSource.DataSource = (From ax In aMainor.Filter_ListOfPAforTrainee(FullNameTextBox.Text, FromDateTimePicker.Value, ToDateTimePicker.Value, GenderComboBox.SelectedItem, MaritalStatusComboBox.SelectedItem, ageDate, ApplicantNumberTextBox.Text, NationalityTextBox.Text, ProvinceTextBox.Text, DistrictTextBox.Text, CountryTextBox.Text, DepNameTextBox.Text) Where ax.StatusId = TraineeStatusId Order By ax.ApplicantId).ToList
            Label1.Text = Filter_ListOfPAforTraineeResultBindingSource.Count
        End Using
    End Sub

    Private Sub Filter_ListOfPAforTraineeResultDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ListOfPAforTraineeResultDataGridView.CellContentClick
        Dim t = Filter_ListOfPAforTraineeResultBindingSource.Current


        If e.ColumnIndex = Grade.Index Then
            Dim x As New FrmTraineePerformanceAppraisal
            x.ApplicantId = t.applicantId

            x.ShowDialog()
            x.Dispose()
        End If

    End Sub

    Private Sub FullNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullNameTextBox.TextChanged, ToDateTimePicker.ValueChanged, FromDateTimePicker.ValueChanged, ProvinceTextBox.TextChanged, NationalityTextBox.TextChanged, MaritalStatusComboBox.TextChanged, GenderComboBox.TextChanged, DistrictTextBox.TextChanged, CountryTextBox.TextChanged, ApplicantNumberTextBox.TextChanged, AgeComboBox.TextChanged, DepNameTextBox.TextChanged
        Using aMainor As New LqHRDataContext(cnx)
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            Filter_ListOfPAforTraineeResultBindingSource.DataSource = (From ax In aMainor.Filter_ListOfPAforTrainee(FullNameTextBox.Text, FromDateTimePicker.Value, ToDateTimePicker.Value, GenderComboBox.SelectedItem, MaritalStatusComboBox.SelectedItem, ageDate, ApplicantNumberTextBox.Text, NationalityTextBox.Text, ProvinceTextBox.Text, DistrictTextBox.Text, CountryTextBox.Text, DepNameTextBox.Text) Where ax.StatusId = TraineeStatusId Order By ax.ApplicantId).ToList
        End Using
        Label1.Text = Filter_ListOfPAforTraineeResultBindingSource.Count
    End Sub


    Private Sub Filter_ListOfPAforTraineeResultDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ListOfPAforTraineeResultDataGridView.CellDoubleClick
        appId = Filter_ListOfPAforTraineeResultBindingSource.Current.ApplicantId

        If CloseOnDoubleClick Then
            RowIndex = Filter_ListOfPAforTraineeResultDataGridView.CurrentRow.Index
            Me.Close()

        Else
            For i As Integer = 0 To Filter_ListOfPAforTraineeResultBindingSource.Count - 1
                ApplicantList.Add(Filter_ListOfPAforTraineeResultBindingSource(i).ApplicantId)
            Next
            Dim x As New FrmApplicantInfo
            x.id = appId
            x.ApplicantList = ApplicantList
            x.StatusId = TraineeStatusId
            x.ShowDialog()

            x.Dispose()
        End If
        
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Using aMainOr As New LqHRDataContext(cnx)

            Dim d As New FrmTraineeListReport
            'Dim username = (From ax In aMainOr.TblEmployees Where ax.Id = MyEmployeeId Select ax.EmployeeName).ToList(0)
            'd.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Username", username))
            Dim username = (From ax In aMainOr.TblEmployees Where ax.Id = MyEmployeeId Select ax.EmployeeName).ToList(0)
            Dim CompanyAddress = (From ax In aMainOr.TblCompanyProfiles Select ax.Address).ToList(0)
            Dim CompanyName = (From ax In aMainOr.TblCompanyProfiles Select ax.Name).ToList(0)
            Dim CompanyPhoneNumber = (From ax In aMainOr.TblCompanyProfiles Select ax.Phone).ToList(0)

            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyName", CompanyName))
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress", CompanyAddress))
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyPhoneNumber", CompanyPhoneNumber))

            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("DateFrom", FromDateTimePicker.Value))
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("DateTo", ToDateTimePicker.Value))

            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            d.Filter_ListOfPAforTraineeResultBindingSource.DataSource = (From ax In aMainOr.Filter_ListOfPAforTrainee(FullNameTextBox.Text, FromDateTimePicker.Value, ToDateTimePicker.Value, GenderComboBox.SelectedItem, MaritalStatusComboBox.SelectedItem, ageDate, ApplicantNumberTextBox.Text, NationalityTextBox.Text, ProvinceTextBox.Text, DistrictTextBox.Text, CountryTextBox.Text, DepNameTextBox.Text) Where ax.StatusId = TraineeStatusId Order By ax.ApplicantId).ToList
            d.ShowDialog()
            d.Dispose()
        End Using
    End Sub
End Class