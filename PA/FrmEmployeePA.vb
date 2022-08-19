Public Class FrmEmployeePA
    Public employeeId As Integer = 0
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub FrmEmployeePA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Using aMainor As New LqHRDataContext(cnx)
        '    AveragePAPerTaskForEmployeeResultBindingSource.DataSource = aMainor.AveragePAPerTaskForEmployee(employeeId).ToList
        'End Using
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        refreshform()

    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)

            Dim res = (From ax In aMainor.TblEmployeePAs Where ax.EmployeeId = employeeId).ToList
            If res.Count > 0 Then
                aMainor.TblEmployeePAs.DeleteAllOnSubmit(res)
                aMainor.SubmitChanges()
            End If

            For i = 0 To AveragePAPerTaskForEmployeeResultBindingSource.Count - 1
                If Not AveragePAPerTaskForEmployeeResultBindingSource(i).ratio Is Nothing Then
                    Dim t As Decimal

                    Dim y As Decimal = Decimal.TryParse(AveragePAPerTaskForEmployeeResultBindingSource(i).ratio, t)
                    Dim x As New TblEmployeePA
                    x.EmployeeId = employeeId
                    x.AveragePAPerTaskId = AveragePAPerTaskForEmployeeResultBindingSource(i).AvgPAPerTaskId
                    x.Ratio = t
                    x.Note = AveragePAPerTaskForEmployeeResultBindingSource(i).note
                    x.EvaluatedById = MyEmployeeId
                    x.EvaluatedDate = Date.Now
                    aMainor.TblEmployeePAs.InsertOnSubmit(x)
                    aMainor.SubmitChanges()

                End If

            Next


            Me.Close()

        End Using
    End Sub

    'Private Sub AveragePAPerTaskForEmployeeResultDataGridView_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AveragePAPerTaskForEmployeeResultDataGridView.CellLeave
    '    If e.ColumnIndex = Ratio.Index Then

    '        Dim y As Decimal
    '        Dim n = AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value
    '        If Not Decimal.TryParse(AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value, y) Then
    '            AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value = ""
    '            MessageBox.Show("enter a valid number ")

    '        End If

    '    End If
    'End Sub

    Sub refreshform()
        Using aMainor As New LqHRDataContext(cnx)
            AveragePAPerTaskForEmployeeResultBindingSource.DataSource = aMainor.AveragePAPerTaskForEmployee(employeeId).ToList
            Dim res = (From ax In aMainor.TblEmployeePAs Where ax.EmployeeId = employeeId).ToList
            If res.Count > 0 Then


                For i = 0 To res.Count - 1
                    For j = 0 To AveragePAPerTaskForEmployeeResultBindingSource.Count - 1
                        If AveragePAPerTaskForEmployeeResultBindingSource(j).AvgPAPerTaskId = res(i).AveragePAPerTaskId Then
                            AveragePAPerTaskForEmployeeResultBindingSource(j).ratio = res(i).Ratio
                            AveragePAPerTaskForEmployeeResultBindingSource(j).note = res(i).Note

                        End If




                    Next
                Next
            End If

        End Using
    End Sub

    
  
    
    'Private Sub AveragePAPerTaskForEmployeeResultDataGridView_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AveragePAPerTaskForEmployeeResultDataGridView.CellLeave
    '    If e.ColumnIndex = Ratio.Index Then


    '        Dim y As Decimal
    '        If Not Decimal.TryParse(AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value, y) Then
    '            MessageBox.Show("enter a valid number ")
    '            AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value = ""
    '        End If
    '    End If
    'End Sub

    Private Sub AveragePAPerTaskForEmployeeResultDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AveragePAPerTaskForEmployeeResultDataGridView.CellEndEdit
        If e.ColumnIndex = Ratio.Index Then


            Dim y As Decimal
            If AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio IsNot Nothing Then

                If Not Decimal.TryParse(AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio, y) Then
                    MessageBox.Show("enter a valid number ")
                    AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio = ""
                Else

                    If AveragePAPerTaskForEmployeeResultBindingSource.Current.ratio > AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(AverageColumn.Index).Value Then
                        MessageBox.Show("Invalid Ratio Value")
                        AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value = Nothing

                   
                    End If
                End If

                
            End If

        End If
    End Sub

    Private Sub AveragePAPerTaskForEmployeeResultDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles AveragePAPerTaskForEmployeeResultDataGridView.DataError
        If e.ColumnIndex = Ratio.Index Then
            MessageBox.Show("enter a valid number")
            AveragePAPerTaskForEmployeeResultDataGridView.CurrentRow.Cells(Ratio.Index).Value = Nothing
        End If
    End Sub
End Class