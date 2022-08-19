Public Class FrmApplicantIndex
    Public Id As Integer = 0
    Public Applicantlist As New List(Of Integer)
    Public counter As Integer = 0

    Private Sub FrmApplicantIndex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList

            TblCertificateBindingSource1.DataSource = (From ax In aMainor.TblCertificates Order By ax.Name).ToList
            TblCertificateBindingSource1.Insert(0, New TblCertificate)
            CertificateIdComboBox.SelectedIndex = 0
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            Filter_ApplicantIndexResultBindingSource.DataSource = (From ax In aMainor.Filter_ApplicantIndex("", "", Nothing, Nothing, "", "", "", "", 0, "", "", AgeDate) Where ax.StatusId = ApplicantStatusId Order By ax.FullName).ToList
            ScrollBar()
            Label1.Text = Filter_ApplicantIndexResultBindingSource.Count
        End Using
    End Sub

    'Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
    '    'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    '    'If answer = DialogResult.Yes Then
    '    Me.Close()

    '    'End If
    'End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Sub ScrollBar()
        For Each c In Filter_ApplicantIndexResultDataGridView.Controls
            If c.GetType() Is GetType(VScrollBar) Then
                Dim vbar As VScrollBar = DirectCast(c, VScrollBar)
                If vbar.Visible = True Then
                    TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, vbar.Width))
                    TableLayoutPanel1.ColumnCount = 12
                Else
                    Try
                        TableLayoutPanel1.ColumnStyles.RemoveAt(11)
                        TableLayoutPanel1.ColumnCount = 11
                    Catch ex As Exception

                    End Try
                End If

            End If
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If counter >= 4 Then
            Timer1.Stop()
            refrshfilter()
            counter = 0
        End If
    End Sub

    Sub refrsh()
        counter = 0
        Timer1.Start()
    End Sub

    Sub refrshfilter()
        Dim certid As Integer = 0
        If CertificateIdComboBox.SelectedIndex > -1 Then
            certid = CertificateIdComboBox.SelectedValue
        End If
        Using aMainor As New LqHRDataContext(cnx)
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            Filter_ApplicantIndexResultBindingSource.DataSource = (From ax In aMainor.Filter_ApplicantIndex(ApplicantNumberTextBox.Text, ApplicantFullNameTextBox.Text, GenderComboBox.SelectedItem, MartialStatusComboBox.SelectedItem, NationalityTextBox.Text, MobileTextBox.Text, MajorTextBox.Text, UniversityTextBox.Text, certid, City_TownTextBox.Text, DistrictTextBox.Text, ageDate) Where ax.StatusId = ApplicantStatusId Order By ax.FullName).ToList
        End Using
        ScrollBar()
        Label1.Text = Filter_ApplicantIndexResultBindingSource.Count
    End Sub

    Private Sub ApplicantNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicantNumberTextBox.TextChanged, UniversityTextBox.TextChanged, NationalityTextBox.TextChanged, MartialStatusComboBox.TextChanged, MajorTextBox.TextChanged, GenderComboBox.TextChanged, DistrictTextBox.TextChanged, City_TownTextBox.TextChanged, CertificateIdComboBox.TextChanged, ApplicantFullNameTextBox.TextChanged, MobileTextBox.TextChanged, AgeComboBox.TextChanged
        refrsh()


    End Sub


    Private Sub Filter_ApplicantIndexResultDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ApplicantIndexResultDataGridView.CellDoubleClick
        Id = Filter_ApplicantIndexResultBindingSource.Current.ApplicantId
        Applicantlist.Clear()
        For i As Integer = 0 To Filter_ApplicantIndexResultBindingSource.Count - 1
            Applicantlist.Add(Filter_ApplicantIndexResultBindingSource(i).ApplicantId)
        Next

        Dim x As New FrmApplicantInfo
        x.id = Id
        x.ApplicantList = Applicantlist
        x.StatusId = ApplicantStatusId
        x.ShowDialog()

        x.Dispose()


    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        'If Permission.Contains("3621") Then
        Using aMainOr As New LqHRDataContext(cnx)
         Dim certid As Integer = 0
            If CertificateIdComboBox.SelectedIndex > -1 Then
                certid = CertificateIdComboBox.SelectedValue
            End If
            Dim d As New FrmApplicantIndexReport
            Dim username = (From ax In aMainOr.TblEmployees Where ax.Id = MyEmployeeId Select ax.EmployeeName).ToList(0)
            '  d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Username", username))
            'd.getItemCardResultBindingSource.DataSource = aMainOr.getItemCardNew(depId, warehouseId, unitId, ItemTextBox.Text, WarehouseIdComboBox.SelectedText).ToList
            Dim CompanyAddress = (From ax In aMainOr.TblCompanyProfiles Select ax.Address).ToList(0)
            Dim CompanyName = (From ax In aMainOr.TblCompanyProfiles Select ax.Name).ToList(0)
            Dim CompanyPhoneNumber = (From ax In aMainOr.TblCompanyProfiles Select ax.Phone).ToList(0)
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyName", CompanyName))
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress", CompanyAddress))
            d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CompanyPhoneNumber", CompanyPhoneNumber))

            ' d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("DateFrom", DateFromTimePicker.Value))
            ' d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("DateTo", DateToTimePicker.Value))
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            d.Filter_ApplicantIndexResultBindingSource.DataSource = (From ax In aMainOr.Filter_ApplicantIndex(ApplicantNumberTextBox.Text, ApplicantFullNameTextBox.Text, GenderComboBox.SelectedItem, MartialStatusComboBox.SelectedItem, NationalityTextBox.Text, MobileTextBox.Text, MajorTextBox.Text, UniversityTextBox.Text, certid, City_TownTextBox.Text, DistrictTextBox.Text, AgeDate) Where ax.StatusId = ApplicantStatusId Order By ax.FullName).ToList
            d.ShowDialog()
            d.Dispose()
        End Using
        'Else
        'MessageBox.Show("You dont have permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub


End Class