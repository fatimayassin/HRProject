Imports System.IO

Public Class FrmUnEmployeeList
    Public loaded As Boolean = False
    Public statusId As Integer = 0
    Public ApplicantList As New List(Of Integer)
    Public appId As Integer = 0
    Public EmpId As Integer = 0
    Public saved As Boolean = False
    Public SelectRelativeReference As Boolean = False
    Public counter As Integer = 0
    Public VacationHolidays As Boolean = False
    Public empName As String = ""
    Public RowIndex As Integer = 0
    Public FromUC As Boolean = False
    Public existsIdList As New List(Of Integer)

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub FrmUnEmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            If SelectRelativeReference Then
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(AddVacation.Index).Visible = False
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(Holiday.Index).Visible = False
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(InCompanyTrainer.Index).Visible = False
                InCompanytraineeCheckBox.Visible = False
            ElseIf FromUC Then
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(AddVacation.Index).Visible = False
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(Holiday.Index).Visible = False
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(InCompanyTrainer.Index).Visible = True
            Else

                Filter_ApplicantEmployeeJobResultDataGridView.Columns(AddVacation.Index).Visible = True
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(Holiday.Index).Visible = True
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(InCompanyTrainer.Index).Visible = True
                InCompanytraineeCheckBox.Visible = True
            End If
            If statusId = RetiredStatusId Or SelectRelativeReference Or VacationHolidays Then
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(PA.Index).Visible = False
            Else
                Filter_ApplicantEmployeeJobResultDataGridView.Columns(PA.Index).Visible = True
            End If

            DateFromTimePicker.Value = New DateTime(DateTime.Now.Year, 1, 1)
            DateToTimePicker.Value = New DateTime(DateTime.Now.Year, 12, 31)


            If FromUC Then
                Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob("", Nothing, "", "", DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList

                For i As Integer = 0 To res.Count - 1
                    If Not existsIdList.Contains(res(i).EmployeeId) Then
                        Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                        existsIdList.Add(res(i).EmployeeId)
                    End If
                Next
                Label1.Text = Filter_ApplicantEmployeeJobResultBindingSource.Count
                findTrainees()
                AddImage()
            Else
                loaded = True
                NameTextBox.Text = empName

                'refrshfilter()
            End If
        End Using
        loaded = True
    End Sub

    Sub AddImage()

        For i As Integer = 0 To Filter_ApplicantEmployeeJobResultBindingSource.Count - 1
            Dim Attachment = Filter_ApplicantEmployeeJobResultBindingSource(i).Attachmment
            Dim stream As New MemoryStream()
            ' Dim res = (From ax In aMainor.TblAttachments Where ax.Id = AttachId Select ax.Attachmment).ToList(0)
            Dim image As Byte() = CType(Attachment.ToArray, Byte())
            stream.Write(image, 0, image.Length)

            Dim bitmap As New Bitmap(stream)

            Filter_ApplicantEmployeeJobResultDataGridView.Rows(i).Cells(ImageCol.Index).Value = bitmap


        Next
    End Sub
    Sub findTrainees()
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblTrainees Select ax.ApplicantId).ToList
            For I As Integer = 0 To Filter_ApplicantEmployeeJobResultBindingSource.Count - 1

                If res.Contains(Filter_ApplicantEmployeeJobResultBindingSource(I).applicantId) Then
                    Filter_ApplicantEmployeeJobResultDataGridView.Rows(I).Cells(InCompanyTrainer.Index).Value = True
                End If
            Next
        End Using
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If counter >= 4 Then
            Timer1.Stop()
            refrshfilter()
            counter = 0
            AddImage()
        End If
    End Sub
    Sub refrsh()
        counter = 0
        Timer1.Start()
    End Sub

    Sub refrshfilter()
        If loaded Then

            Using aMainor As New LqHRDataContext(cnx)
                If InCompanytraineeCheckBox.CheckState = CheckState.Checked Then
                    Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" And ax.traineeId IsNot Nothing Order By ax.Date Ascending).ToList
                    existsIdList.Clear()
                    Filter_ApplicantEmployeeJobResultBindingSource.Clear()

                    For i As Integer = 0 To res.Count - 1
                        If Not existsIdList.Contains(res(i).EmployeeId) Then
                            Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                            existsIdList.Add(res(i).EmployeeId)
                        End If
                    Next
                    findTrainees()
                ElseIf InCompanytraineeCheckBox.CheckState = CheckState.Unchecked Then
                    Dim RES = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" And ax.traineeId Is Nothing Order By ax.Date Ascending).ToList
                    existsIdList.Clear()
                    Filter_ApplicantEmployeeJobResultBindingSource.Clear()

                    For i As Integer = 0 To RES.Count - 1
                        If Not existsIdList.Contains(RES(i).EmployeeId) Then
                            Filter_ApplicantEmployeeJobResultBindingSource.Add(RES(i))
                            existsIdList.Add(RES(i).EmployeeId)
                        End If
                    Next
                ElseIf InCompanytraineeCheckBox.CheckState = CheckState.Indeterminate Then
                    Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList
                    existsIdList.Clear()
                    Filter_ApplicantEmployeeJobResultBindingSource.Clear()

                    For i As Integer = 0 To res.Count - 1
                        If Not existsIdList.Contains(res(i).EmployeeId) Then
                            Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                            existsIdList.Add(res(i).EmployeeId)
                        End If
                    Next

                    findTrainees()
                End If
            End Using
            Label1.Text = Filter_ApplicantEmployeeJobResultBindingSource.Count

        End If
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged, JobNumberTextBox.TextChanged, JobNameTextBox.TextChanged, DepTextBox.TextChanged, DateFromTimePicker.TextChanged, DateToTimePicker.TextChanged, InCompanytraineeCheckBox.CheckStateChanged, NationalityTextBox.TextChanged, PINTextBox.TextChanged

        refrsh()

    End Sub

    Private Sub Filter_ApplicantEmployeeJobResultDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ApplicantEmployeeJobResultDataGridView.CellContentClick
        Dim EmpId As Integer = Filter_ApplicantEmployeeJobResultBindingSource.Current.EmployeeId
        If e.ColumnIndex = PA.Index Then
            Dim x As New FrmEmployeePA
            x.employeeId = EmpId
            x.ShowDialog()
            x.Dispose()

        End If

        If e.ColumnIndex = AddVacation.Index Then
            Dim x As New FrmEmployeeVacation
            x.employeeId = EmpId
            x.ShowDialog()
            x.Dispose()
        End If

        If e.ColumnIndex = Holiday.Index Then
            Dim x As New FrmEmployeeHolidays
            x.EmployeeId = EmpId
            x.ShowDialog()
            x.Dispose()
        End If
    End Sub

    Private Sub Filter_ApplicantEmployeeJobResultDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ApplicantEmployeeJobResultDataGridView.CellDoubleClick
        appId = Filter_ApplicantEmployeeJobResultBindingSource.Current.applicantid
        EmpId = Filter_ApplicantEmployeeJobResultBindingSource.Current.EmployeeId
        If SelectRelativeReference Or FromUC Then
            RowIndex = Filter_ApplicantEmployeeJobResultDataGridView.CurrentRow.Index

            saved = True
            Me.Close()
        Else
            ApplicantList.Clear()
            For i As Integer = 0 To Filter_ApplicantEmployeeJobResultBindingSource.Count - 1
                ApplicantList.Add(Filter_ApplicantEmployeeJobResultBindingSource(i).ApplicantId)
            Next
            Dim x As New FrmApplicantInfo
            x.id = appId
            x.ApplicantList = ApplicantList
            x.StatusId = UnemploymentStatusId
            x.ShowDialog()

            x.Dispose()
        End If


    End Sub

    'Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click, BtnReport.Click
    '    Using aMainOr As New LqHRDataContext(cnx)

    '        Dim d As New frmEmployeeListReport
    '        Dim username = (From ax In aMainOr.TblEmployees Where ax.Id = MyEmployeeId Select ax.EmployeeName).ToList(0)
    '        ' d.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Username", username))
    '        'd.getItemCardResultBindingSource.DataSource = aMainOr.getItemCardNew(depId, warehouseId, unitId, ItemTextBox.Text, WarehouseIdComboBox.SelectedText).ToList
    '        If InCompanytraineeCheckBox.CheckState = CheckState.Checked Then
    '            d.Filter_ApplicantEmployeeJobResultBindingSource.DataSource = (From ax In aMainOr.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" And ax.traineeId IsNot Nothing Order By ax.Date Ascending).ToList
    '            findTrainees()
    '        ElseIf InCompanytraineeCheckBox.CheckState = CheckState.Unchecked Then
    '            d.Filter_ApplicantEmployeeJobResultBindingSource.DataSource = (From ax In aMainOr.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" And ax.traineeId Is Nothing Order By ax.Date Ascending).ToList
    '        ElseIf InCompanytraineeCheckBox.CheckState = CheckState.Indeterminate Then

    '            d.Filter_ApplicantEmployeeJobResultBindingSource.DataSource = (From ax In aMainOr.Filter_ApplicantEmployeeJob(NameTextBox.Text, Nothing, JobNameTextBox.Text, JobNumberTextBox.Text, DateFromTimePicker.Value, DateToTimePicker.Value, 0, DepTextBox.Text, NationalityTextBox.Text, PINTextBox.Text) Where ax.StatusId = statusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList
    '            findTrainees()
    '        End If
    '        ' d..DataSource = (From ax In aMainOr.Filter_ApplicantIndex(ApplicantNumberTextBox.Text, ApplicantFullNameTextBox.Text, GenderComboBox.SelectedItem, MartialStatusComboBox.SelectedItem, NationalityTextBox.Text, MobileTextBox.Text, MajorTextBox.Text, UniversityTextBox.Text, certid, City_TownTextBox.Text, DistrictTextBox.Text) Where ax.StatusId = ApplicantStatusId Order By ax.fullName).ToList
    '        d.ShowDialog()
    '        d.Dispose()
    '    End Using
    'End Sub

End Class