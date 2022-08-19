Public Class FrmLeavePermission
    Public Id As Integer = 0
    Dim selectedDate As Date
    Public first As Boolean = True
    Public FromUc As Boolean = False
    Public saved As Boolean = False
    Public forEdit As Boolean = False
    Public current As New TblLeavePermission

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmLeavePermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)

            If FromUc Then
                EmployeeIdLabel.Visible = False
                EmployeeNameTextBox.Visible = False
                If Not forEdit Then
                    If Id = 0 Then
                        TblLeavePermissionBindingSource.DataSource = New TblLeavePermission
                    End If
                Else
                    TblLeavePermissionBindingSource.DataSource = current

                End If


            Else
                EmployeeIdLabel.Visible = True
                EmployeeNameTextBox.Visible = True
                If Id = 0 Then
                    TblLeavePermissionBindingSource.DataSource = New TblLeavePermission
                    TblLeavePermissionBindingSource.Current.isBusiness = False
                Else
                    TblLeavePermissionBindingSource.DataSource = (From ax In aMainor.TblLeavePermissions Where ax.Id = Id).ToList(0)

                End If
            End If




        End Using
        first = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        BtnSave.Focus()


        If Not EndTimeDateTimePicker.Value > StartTimeDateTimePicker.Value Then
            MessageBox.Show("End Time Should Be Greater Than Start Time")
        Else

            Using aMainor As New LqHRDataContext(cnx)
                If FromUc Then
                    TblLeavePermissionBindingSource.Current.StartTime = StartTimeDateTimePicker.Value
                    TblLeavePermissionBindingSource.Current.EndTime = EndTimeDateTimePicker.Value
                    current = TblLeavePermissionBindingSource.Current
                    saved = True
                    Me.Close()
                Else

                    If EmployeeNameTextBox.Text = "" Then
                        MessageBox.Show("Select Employee")
                    Else
                        TblLeavePermissionBindingSource.Current.StartTime = StartTimeDateTimePicker.Value
                        TblLeavePermissionBindingSource.Current.EndTime = EndTimeDateTimePicker.Value
                        If Id = 0 Then


                            aMainor.TblLeavePermissions.InsertOnSubmit(TblLeavePermissionBindingSource.Current)
                            aMainor.SubmitChanges()
                        Else
                            Dim oldLeave As TblLeavePermission = (From ax In aMainor.TblLeavePermissions Where ax.Id = Id).ToList(0)
                            Dim newLeave As TblLeavePermission = TblLeavePermissionBindingSource.Current
                            oldLeave.Date = newLeave.Date
                            oldLeave.StartTime = newLeave.StartTime
                            oldLeave.EndTime = newLeave.EndTime
                            oldLeave.Reason = newLeave.Reason
                            oldLeave.isBusiness = newLeave.isBusiness
                            aMainor.SubmitChanges()
                        End If
                        saved = True
                        Me.Close()
                    End If

                End If
            End Using
            
        End If
        
    End Sub


   
    Private Sub DateDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateDateTimePicker.ValueChanged
        If DateDateTimePicker.Value < Date.Now Then
            MessageBox.Show("Enter a valid date ")
            DateDateTimePicker.Value = Date.Now

        End If
    End Sub

    Private Sub EmployeeNameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmployeeNameTextBox.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim x As New FrmEmployeeList
            x.empName = EmployeeNameTextBox.Text
            x.statusId = EmployeeStatusId
            x.SelectRelativeReference = True ''same case as relative references

            x.ShowDialog()
            If x.saved = True Then
                Dim Employeeid As Integer = x.EmpId
                Using aMainor As New LqHRDataContext(cnx)
                    Dim res = (From ax In aMainor.TblEmployees Where ax.Id = Employeeid).ToList(0)
                    EmployeeNameTextBox.Text = res.EmployeeName
                    TblLeavePermissionBindingSource.Current.employeeid = Employeeid
                End Using
            End If

            x.Dispose()
        End If
    End Sub

 

End Class

