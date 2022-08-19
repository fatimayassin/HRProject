Public Class FrmLeavePermApproval
    Public LOADED As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmLeavePermApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList
            TblLeavePermissionBindingSource.DataSource = (From ax In aMainor.TblLeavePermissions).ToList
        End Using
        DateFromDateTimePicker.Value = New DateTime(DateTime.Now.Year, 1, 1)
        DateToDateTimePicker.Value = New DateTime(DateTime.Now.Year, 12, 31)
        AcceptedCheckBox.CheckState = CheckState.Indeterminate
        LOADED = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New LqHRDataContext(cnx)

            For i = 0 To TblLeavePermissionBindingSource.Count - 1

                Dim id As Integer = TblLeavePermissionBindingSource(i).id


                Dim oldRow As TblLeavePermission = (From ax In aMainor.TblLeavePermissions Where ax.Id = id).ToList(0)

                oldRow.Note = TblLeavePermissionBindingSource(i).Note
                oldRow.Accepted = TblLeavePermissionBindingSource(i).Accepted
                oldRow.RespondDate = Date.Now
                oldRow.RespondedById = MyEmployeeId
                aMainor.SubmitChanges()
            Next
            Me.Close()
        End Using
    End Sub
    Private Sub EmpNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpNameTextBox.TextChanged, ReasonTextBox.TextChanged, NoteTextBox.TextChanged, DateFromDateTimePicker.TextChanged, DateToDateTimePicker.TextChanged, AcceptedCheckBox.CheckStateChanged
        If LOADED Then
            Dim chek As Boolean? = Nothing
            If AcceptedCheckBox.CheckState <> CheckState.Indeterminate Then
                chek = AcceptedCheckBox.Checked
            End If
            Using aMainor As New LqHRDataContext(cnx)
                TblLeavePermissionBindingSource.DataSource = aMainor.Filter_LeavePermissionApproval(EmpNameTextBox.Text, DateFromDateTimePicker.Value, DateToDateTimePicker.Value, ReasonTextBox.Text, NoteTextBox.Text, chek).ToList

            End Using
        End If
        'RefreshData()
    End Sub

    'Sub RefreshData()
    '    Dim chek As Boolean? = Nothing
    '    If AcceptedCheckBox.CheckState <> CheckState.Indeterminate Then
    '        chek = AcceptedCheckBox.Checked
    '    End If
    '    Using aMainor As New LqHRDataContext(cnx)
    '        TblLeavePermissionBindingSource.DataSource = aMainor.Filter_LeavePermissionApproval(EmpNameTextBox.Text, DateFromDateTimePicker.Value, DateToDateTimePicker.Value, ReasonTextBox.Text, NoteTextBox.Text, chek).ToList

    '    End Using
    'End Sub

    'Sub valueChanges() Handles DateToDateTimePicker.ValueChanged, DateFromDateTimePicker.ValueChanged
    '    RefreshData()

    'End Sub
End Class