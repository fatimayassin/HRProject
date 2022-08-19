Public Class FrmAveragePAPerJobPerTask
    Public jobid As Integer = 0
    Dim PAPerJobIdlist As New List(Of Integer)
    Dim TaskList As New List(Of Integer?)
    Dim UsedAvgPAPerTask As New List(Of Integer?)
    Dim usedTaskIds As New List(Of Integer?)
    Public SingleJob As Boolean = False
    Dim JobTasks As New List(Of Integer?)
    Private Sub FrmAveragePAPerJobPerTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)

            '  PAPerJobIdlist = (From ax In aMainor.TblPAPerJobs Where ax.JobId = jobid Select ax.Id).ToList
            TblCategoryBindingSource.DataSource = aMainor.TblCategories.ToList
            TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
            TblPAForEmployeeBindingSource.DataSource = aMainor.TblPAForEmployees.ToList
            If SingleJob Then
                TblPAPerJobBindingSource.DataSource = (From ax In aMainor.TblPAPerJobs Where ax.JobId = jobid).ToList
                TblPAPerJobDataGridView.Columns(JobCol.Index).Visible = False
            Else

                TblPAPerJobBindingSource.DataSource = aMainor.TblPAPerJobs.ToList
                TblPAPerJobDataGridView.Columns(JobCol.Index).Visible = True
            End If

            ' Using aMainor As New LqHRDataContext(cnx)
            Dim jbId As Integer = TblPAPerJobBindingSource.Current.jobid
                JobTasks = (From ax In aMainor.TblJobTasks Where ax.JobId = jbId Select ax.TaskId).ToList
                TblTaskBindingSource.DataSource = (From ax In aMainor.TblTasks Where JobTasks.Contains(ax.Id)).ToList


                refreshform()
        End Using

    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub TblPAPerJobBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblPAPerJobBindingSource.CurrentChanged

        refreshform()
    End Sub

    Sub refreshform()
        usedTaskIds.Clear()
        UsedAvgPAPerTask.Clear()


        For I As Integer = 0 To TblTaskBindingSource.Count - 1
            TblTaskDataGridView.Rows(I).Cells(Average.Index).Value = Nothing
        Next
        If TblPAPerJobBindingSource.Count > 0 Then
            Dim PAPerJobId As Integer = TblPAPerJobBindingSource.Current.ID
            Using aMainor As New LqHRDataContext(cnx)
                TaskList = (From ax In aMainor.TblAveragePAPerTasks Where ax.PAPerJobId = PAPerJobId Select ax.TaskId).ToList
                If TaskList.Count > 0 Then
                    For i As Integer = 0 To TblTaskBindingSource.Count - 1

                        Dim tskId As Integer = TblTaskBindingSource(i).id
                        If TaskList.Contains(tskId) Then
                            Dim res = (From ax In aMainor.TblAveragePAPerTasks Where ax.TaskId = tskId And ax.PAPerJobId = PAPerJobId).ToList(0)
                            TblTaskDataGridView.Rows(i).Cells(Average.Index).Value = res.Average
                        End If

                    Next
                End If
                ''iza l employee ken mkayam abl 
                Dim res1 = (From ax In aMainor.TblAveragePAPerTasks Where ax.PAPerJobId = PAPerJobId Select ax.Id).ToList

                UsedAvgPAPerTask = (From ax In aMainor.TblEmployeePAs Where res1.Contains(ax.AveragePAPerTaskId) Select ax.AveragePAPerTaskId).ToList
                usedTaskIds = (From ax In aMainor.TblAveragePAPerTasks Where ax.PAPerJobId = PAPerJobId And UsedAvgPAPerTask.Contains(ax.Id) Select ax.TaskId).ToList
                For i As Integer = 0 To TblTaskBindingSource.Count - 1
                    If usedTaskIds.Contains(TblTaskBindingSource(i).id) Then
                        TblTaskDataGridView.Rows(i).Cells(Average.Index).ReadOnly = True
                    Else
                        TblTaskDataGridView.Rows(i).Cells(Average.Index).ReadOnly = False
                    End If
                Next
            End Using

        End If

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim PAPerJobId As Integer = TblPAPerJobBindingSource.Current.ID



            Dim res = (From ax In aMainor.TblAveragePAPerTasks Where ax.PAPerJobId = PAPerJobId And Not UsedAvgPAPerTask.Contains(ax.Id)).ToList


            If res.Count > 0 Then
                aMainor.TblAveragePAPerTasks.DeleteAllOnSubmit(res)
                aMainor.SubmitChanges()

            End If

            For i As Integer = 0 To TblTaskBindingSource.Count - 1
                If Not usedTaskIds.Contains(TblTaskBindingSource(i).id) Then
                    If Not TblTaskDataGridView.Rows(i).Cells(Average.Index).Value Is Nothing Then
                        Dim avg As Decimal = TblTaskDataGridView.Rows(i).Cells(Average.Index).Value
                        Dim TBL As New TblAveragePAPerTask
                        TBL.PAPerJobId = PAPerJobId
                        TBL.TaskId = TblTaskBindingSource(i).ID
                        TBL.Average = avg
                        aMainor.TblAveragePAPerTasks.InsertOnSubmit(TBL)
                        aMainor.SubmitChanges()
                    End If
                End If

                'End If
            Next

            Me.Close()

        End Using
    End Sub
End Class