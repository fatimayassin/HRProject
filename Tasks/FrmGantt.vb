Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Partial Public Class FrmGantt
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ultraButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ultraButton1.Click
        'Try
        TaskDataSet1.Clear()
        dbProjectsTableAdapter.Fill(TaskDataSet1.dbProjects)
        dbTasksTableAdapter.Fill(TaskDataSet1.dbTasks)
        'ultraCalendarInfo1.DataBindingsForProjects.BindingContextControl = Me
        ultraCalendarInfo1.DataBindingsForTasks.BindingContextControl = Me
        'Me.ultraCalendarInfo1.DataBindingsForProjects.DataSource = TaskDataSet1.dbProjects
        'Me.ultraCalendarInfo1.DataBindingsForProjects.IdMember = "ProjectID"
        'Me.ultraCalendarInfo1.DataBindingsForProjects.KeyMember = "ProjectKey"
        'Me.ultraCalendarInfo1.DataBindingsForProjects.NameMember = "ProjectName"
        'Me.ultraCalendarInfo1.DataBindingsForProjects.StartDateMember = "ProjectStartTime"

        Me.ultraCalendarInfo1.DataBindingsForTasks.DataSource = TaskDataSet1.dbTasks
            Me.ultraCalendarInfo1.DataBindingsForTasks.NameMember = "TaskName"
            Me.ultraCalendarInfo1.DataBindingsForTasks.DurationMember = "TaskDuration"
            Me.ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember = "TaskStartTime"
            Me.ultraCalendarInfo1.DataBindingsForTasks.IdMember = "TaskID"
            Me.ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember = "ProjectKey"
            Me.ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember = "ParentTaskID"
            Me.ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember = "TaskPercentComplete"
            Me.ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember = "AllProperties"

            Me.ultraGanttView1.CalendarInfo = Me.ultraCalendarInfo1
            Me.ultraGanttView1.Project = Me.ultraGanttView1.CalendarInfo.Projects(1)
            Me.ultraCalendarInfo1.Projects(1).Tasks(0).SetCustomProperty("CustomColumn", TaskDataSet1.dbTasks(0).CustomColumn)
            Me.ultraCalendarInfo1.Projects(1).Tasks(1).SetCustomProperty("CustomColumn", TaskDataSet1.dbTasks(1).CustomColumn)
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try
    End Sub

    Private Sub ultraButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ultraButton2.Click
        dbProjectsTableAdapter.Update(TaskDataSet1.dbProjects)
        dbTasksTableAdapter.Update(TaskDataSet1.dbTasks)
    End Sub
End Class
