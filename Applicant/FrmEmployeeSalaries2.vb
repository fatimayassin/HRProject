Public Class FrmEmployeeSalaries2
    Public Id1 As Integer = 0
    Public saved As Boolean = False
    Public EmployeeId As Integer = 0
    Public count As Integer = 0
    Public current As BindingSource
    Public ForEdit As Boolean = False
    Dim selectedDate As Date
    Dim isDateSelected As Boolean = False

    Private Sub FrmEmployeeSalaries2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblSalaryCategoryBindingSource.DataSource = aMainor.TblSalaryCategories.ToList
            If ForEdit = False Then
                If Id1 = 0 Then
                End If
            Else
                '  If current Is Nothing Then current.DataSource = New List(Of TblEmployeeSalary2)
                TblEmployeeSalary2BindingSource = current
                Dim Idlist As New List(Of Integer)
                Dim NoteList As New List(Of String)
                Dim UnitList As New List(Of String)
                Dim ValueList As New List(Of String)

                For i As Integer = 0 To TblEmployeeSalary2BindingSource.Count - 1
                    Dim SalaryCatId As Integer = TblEmployeeSalary2BindingSource(i).SalaryCatId
                    Idlist.Add(SalaryCatId)
                    ValueList.Add(TblEmployeeSalary2BindingSource(i).Value)
                    UnitList.Add(TblEmployeeSalary2BindingSource(i).Unit)
                    NoteList.Add(TblEmployeeSalary2BindingSource(i).Note)

                Next

                For i As Integer = 0 To TblEmployeeSalaryDataGridView.Rows.Count() - 1
                    Dim row As DataGridViewRow = TblEmployeeSalaryDataGridView.Rows(i)
                    If Idlist.Contains(row.Cells(0).Value) Then
                        TblEmployeeSalaryDataGridView.Rows(i).Cells(1).Value = True
                        TblEmployeeSalaryDataGridView.Rows(i).Cells(3).Value = UnitList.Item(Idlist.IndexOf(row.Cells(0).Value))
                        TblEmployeeSalaryDataGridView.Rows(i).Cells(4).Value = ValueList.Item(Idlist.IndexOf(row.Cells(0).Value))
                        TblEmployeeSalaryDataGridView.Rows(i).Cells(5).Value = NoteList.Item(Idlist.IndexOf(row.Cells(0).Value))

                    End If
                Next
            End If
            count = TblEmployeeSalaryDataGridView.Rows.Count() - 1
        End Using



    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res22 = (From aX In aMainor.TblEmployeeSalary2s Where aX.EmployeeID = EmployeeId).ToList
            If res22.Count > 0 Then
                TblEmployeeSalary2BindingSource.List.Clear()
            End If
            If TblEmployeeSalary2BindingSource.Count > 0 Then
                TblEmployeeSalary2BindingSource.List.Clear()
            End If


            Dim count2 As Integer = TblEmployeeSalaryDataGridView.Rows.Count() - 1

            For i As Integer = 0 To TblEmployeeSalaryDataGridView.Rows.Count() - 1 Step +1

                Dim c As Boolean = TblEmployeeSalaryDataGridView.Rows(i).Cells(1).Value
                If c Then
                    Dim MIId As Integer
                    If i >= count Then
                        For j As Integer = count To count2 - 1
                            Dim row1 As DataGridViewRow = TblEmployeeSalaryDataGridView.Rows(j)
                            Dim MI As New TblSalaryCategory
                            MI.SalaryCategory = row1.Cells(2).Value
                            aMainor.TblSalaryCategories.InsertOnSubmit(MI)
                            aMainor.SubmitChanges()
                            MIId = MI.SalaryCatID
                        Next

                    End If

                    Dim row As DataGridViewRow = TblEmployeeSalaryDataGridView.Rows(i)

                    Dim AMI1 As New TblEmployeeSalary2
                    If i >= count Then
                        AMI1.SalaryCatID = MIId
                    Else
                        AMI1.SalaryCatID = row.Cells(0).Value
                    End If

                    AMI1.EmployeeID = EmployeeId
                    AMI1.Unit = row.Cells(3).Value
                    AMI1.Value = CDec(row.Cells(4).Value)
                    AMI1.Note = row.Cells(5).Value

                    TblEmployeeSalary2BindingSource.Add(AMI1)


                End If
            Next
            current = TblEmployeeSalary2BindingSource
            saved = True
            Me.Close()
        End Using
    End Sub

    Private Sub TblEmployeeSalaryDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblEmployeeSalaryDataGridView.DataError

    End Sub

    'Private Sub TblEmployeeSalaryDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TblEmployeeSalaryDataGridView.CellEndEdit
    '    Using aMainor As New LqHRDataContext(cnx)
    '        If e.ColumnIndex = UnitColumn.Index Then


    '            Dim x As Integer = TblEmployeeSalary2BindingSource.Current.UnitID
    '            If Not x = 0 Then
    '                Dim r As TblUnit = (From ax In aMainor.TblUnits Where ax.UnitID = x).ToList(0)
    '                'If Not r.NumberOfDays = 0 Then
    '                '    TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDaysCol.Index).ReadOnly = True
    '                '    TblEmployeeVacationBindingSource.Current.NumberOfDays = r.NumberOfDays
    '                'Else
    '                '    TblEmployeeVacationDataGridView.CurrentRow.Cells(NumberOfDaysCol.Index).ReadOnly = False
    '                'End If
    '            End If

    '        End If

    '    End Using
    'End Sub
End Class