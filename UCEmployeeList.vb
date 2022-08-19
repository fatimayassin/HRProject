Public Class UCEmployeeList
    Public DepartmentId As Integer = 0
    Public applicantid As Integer = 0
    Public forInfo As Boolean = False
    Public jobid As Integer = 0
    Public idlist As List(Of Integer)
    Public loaded As Boolean = False
    Public existsIdList As New List(Of Integer)
    Public listOfStringNodes As New List(Of String)
    Public DepsList As New List(Of Integer)
    ''' <summary>
    ''' 
    ''' </summary>
    Sub refreshfrm()
        Using aMainor As New LqHRDataContext(cnx)


            If DepartmentId = 0 Then

                Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, GenderComboBox.SelectedItem, JobNameTextBox.Text, JobNumberTextBox.Text, DateTimePicker1.Value, DateTimePicker2.Value, 0, "", "", "") Where ax.DepartmentId = DepartmentId Or ax.StatusId = EmployeeStatusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList
                For i As Integer = 0 To res.Count - 1
                    If Not existsIdList.Contains(res(i).EmployeeId) Then
                        Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                        existsIdList.Add(res(i).EmployeeId)
                    End If
                Next

            Else


                '  Dim AllChilds = (From ax In aMainor.TblDepartments Where ax.ParentId)



                Dim DepName = (From ax In aMainor.TblDepartments Where ax.Id = DepartmentId Select ax.Name).ToList(0)

                listOfStringNodes.Add(DepName)

                Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, GenderComboBox.SelectedItem, JobNameTextBox.Text, JobNumberTextBox.Text, DateTimePicker1.Value, DateTimePicker2.Value, 0, "", "", "") Where listOfStringNodes.Contains(ax.DepName) And ax.StatusId = EmployeeStatusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList
                For i As Integer = 0 To res.Count - 1
                    If Not existsIdList.Contains(res(i).EmployeeId) Then
                        Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                        existsIdList.Add(res(i).EmployeeId)
                    End If
                Next
            End If

            Label1.Text = Filter_ApplicantEmployeeJobResultBindingSource.Count
            loaded = True
        End Using
    End Sub


    Private Sub UCJobDescriptionList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = New DateTime(DateTime.Now.Year, 1, 1)
        DateTimePicker2.Value = New DateTime(DateTime.Now.Year, 12, 31)
        refreshfrm()
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged, JobNumberTextBox.TextChanged, JobNameTextBox.TextChanged, GenderComboBox.TextChanged, DateTimePicker1.TextChanged, DateTimePicker2.TextChanged
        If loaded Then
            existsIdList.Clear()
            Filter_ApplicantEmployeeJobResultBindingSource.Clear()

            Using aMainor As New LqHRDataContext(cnx)
                Dim res = (From ax In aMainor.Filter_ApplicantEmployeeJob(NameTextBox.Text, GenderComboBox.SelectedItem, JobNameTextBox.Text, JobNumberTextBox.Text, DateTimePicker1.Value, DateTimePicker2.Value, 0, "", "", "") Where listOfStringNodes.Contains(ax.DepName) And ax.StatusId = EmployeeStatusId And ax.AttachmentType = "Photography" Order By ax.Date Ascending).ToList
                For i As Integer = 0 To res.Count - 1
                    If Not existsIdList.Contains(res(i).EmployeeId) Then
                        Filter_ApplicantEmployeeJobResultBindingSource.Add(res(i))
                        existsIdList.Add(res(i).EmployeeId)
                    End If
                Next
                Label1.Text = Filter_ApplicantEmployeeJobResultBindingSource.Count
            End Using
        End If
    End Sub

    Private Sub Filter_ApplicantEmployeeJobResultDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Filter_ApplicantEmployeeJobResultDataGridView.CellContentClick
        If e.ColumnIndex = Details.Index Then
            Dim thisAppId As Integer = Filter_ApplicantEmployeeJobResultBindingSource.Current.ApplicantId
            Dim x As New FrmApplicantInfo
            x.id = thisAppId

            x.StatusId = EmployeeStatusId
            x.ShowDialog()
            x.Dispose()
        End If
    End Sub
End Class

