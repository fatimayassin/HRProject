Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Resources
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinSchedule
Imports Infragistics.Win.UltraWinGanttView.Grid
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGanttView.Internal
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinSchedule.TaskUI
Imports Infragistics.Win.UltraWinGanttView
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinListView
Imports System.Data.SqlClient

Public Class Form3
    Private Enum GanttViewAction
        IndentTask = 1
        OutdentTask = 2
        MoveTaskDateForward = 3
        MoveTaskDateBackward = 4
    End Enum

    Private Enum TimeSpanForMoving
        OneDay = 1
        OneWeek = 2
        FourWeeks = 3
    End Enum

    Private Enum FontProperties
        Bold = 1
        Italics = 2
        Underline = 3
    End Enum

    Private sampleProject As Project
    Private isToolUpdatedWithCellActivation As Boolean = False
    Private rm As ResourceManager = My.Resources.ResourceManager
    Private requirementsTask As Task
    Private visualDesignTask As Task
    Private codeDevelopmentTask As Task
    Private qualityAssurance As Task
    Private Const TaskRowHeight As Integer = 30
    Private Const TaskBarHeight As Integer = 20
    Private ultraListView1 As UltraListView


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        Me.UltraToolbarsManager1.Office2007UICompatibility = False
        Me.UltraToolbarsManager1.Ribbon.FileMenuStyle = Infragistics.Win.UltraWinToolbars.FileMenuStyle.None
        Me.ShowIcon = False
        ' Me.UltraToolbarsManager1.Ribbon.ApplicationMenuButtonImage = GetImage("IGLogo16.PNG")
        Me.ultraGanttViewPrintDocument1.GanttView = Me.ultraGanttView1
        Me.UltraPrintPreviewDialog1.Document = Me.ultraGanttViewPrintDocument1

        Me.TasksTableAdapter.Fill(Me.DataSetGanttTasks.Tasks)
        Me.DbProjectsTableAdapter.Fill(Me.DataSetGanttTasks.dbProjects)
        Me.ultraCalendarInfo1.DataBindingsForTasks.BindingContextControl = Me
        Me.ultraCalendarInfo1.DataBindingsForProjects.BindingContextControl = Me
        Me.ultraCalendarInfo1.DataBindingsForProjects.SetDataBinding(Me.DataSetGanttTasks, "dbProjects")
        Me.ultraCalendarInfo1.DataBindingsForProjects.IdMember = "ProjectID"
        Me.ultraCalendarInfo1.DataBindingsForProjects.KeyMember = "ProjectKey"
        Me.ultraCalendarInfo1.DataBindingsForProjects.NameMember = "ProjectName"
        Me.ultraCalendarInfo1.DataBindingsForProjects.StartDateMember = "ProjectStartTime"
        Me.ultraCalendarInfo1.DataBindingsForTasks.SetDataBinding(Me.DataSetGanttTasks, "Tasks")
        Me.ultraCalendarInfo1.DataBindingsForTasks.NameMember = "TaskName"
        Me.ultraCalendarInfo1.DataBindingsForTasks.DurationMember = "TaskDuration"
        Me.ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember = "TaskStartTime"
        Me.ultraCalendarInfo1.DataBindingsForTasks.IdMember = "TaskID"
        Me.ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember = "ProjectKey"
        Me.ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember = "ParentTaskID"
        Me.ultraCalendarInfo1.DataBindingsForTasks.ConstraintMember = "Constraint"
        Me.ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember = "TaskPercentComplete"
        Me.ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember = "AllProperties"
        Me.ultraGanttView1.CalendarInfo = Me.ultraCalendarInfo1
        DataSetGanttTasks.AcceptChanges()
        AddHandler DataSetGanttTasks.Tasks.RowChanging, New DataRowChangeEventHandler(AddressOf Tasks_RowChanging)

    End Sub

    Private Sub Tasks_RowChanging(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        'Try
        '    listBox1.Items.Add(String.Format("Action:{0}", e.Action))
        '    listBox1.Items.Add(String.Format("TaskID:{0}", e.Row.ItemArray(0)))
        '    listBox1.Items.Add(String.Format("Row Position at database:{0}", e.Row.Table.Rows.IndexOf(e.Row)))
        'Catch
        '    listBox1.Items.Add("Commit deleted Row")
        'End Try
    End Sub

    Private Sub dataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.Cancel = True
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key

            Case "0%"
                Me.SetTaskPercentage(0)
            Case "25%"
                Me.SetTaskPercentage(25)
            Case "50%"
                Me.SetTaskPercentage(50)
            Case "75%"
                Me.SetTaskPercentage(75)
            Case "100%"
                Me.SetTaskPercentage(100)

            Case "Move Left"
                Me.PerformIndentOrOutdent(GanttViewAction.OutdentTask)
            Case "Move Right"
                Me.PerformIndentOrOutdent(GanttViewAction.IndentTask)

            Case "1 Day"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.OneDay)
            Case "1 Week"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.OneWeek)
            Case "4 Weeks"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.FourWeeks)

            Case "1 Day Back"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.OneDay)
            Case "1 Week B"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.OneWeek)
            Case "4 Weeks B"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.FourWeeks)

            Case "Add Task At Bottom"
                Me.AddNewTask(False)
            Case "Add Task At Selected Row"
                Me.AddNewTask(True)

            Case "Milestone"
                Me.ultraGanttView1.ActiveTask.Milestone = Not Me.ultraGanttView1.ActiveTask.Milestone

            Case "Save"
                Me.TasksTableAdapter.Update(Me.DataSetGanttTasks.Tasks)

            Case "Task Information"
                Me.ultraGanttView1.DisplayTaskDialog(Me.ultraGanttView1.ActiveTask)

            Case "Notes"
                AddHandler Me.ultraGanttView1.TaskDialogDisplaying, New TaskDialogDisplayingHandler(AddressOf HandleDisplayingTaskDialog)
                Me.ultraGanttView1.DisplayTaskDialog(Me.ultraGanttView1.ActiveTask)

            Case "Print Preview"
                Me.UltraPrintPreviewDialog1.ShowDialog(Me)

            Case "Exit"
                Me.Close()

                'Case "BlueTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Blue
                'Case "SilverTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Silver
                'Case "BlackTheme"
                '    Office2010ColorTable.ColorScheme = Office2010ColorScheme.Black

        End Select
    End Sub

    Private Sub SetTaskPercentage(ByVal percent As Single)
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        Try

            If activeTask IsNot Nothing Then
                activeTask.PercentComplete = percent
            End If

        Catch ex As TaskException
            UltraMessageBoxManager.Show(ex.Message, rm.GetString("MessageBox_Error"))
        End Try
    End Sub

    Private Sub PerformIndentOrOutdent(ByVal action As GanttViewAction)
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        Try

            If activeTask IsNot Nothing Then

                Select Case action
                    Case GanttViewAction.IndentTask
                        activeTask.Indent()
                    Case GanttViewAction.OutdentTask
                        activeTask.Outdent()
                End Select
            End If

        Catch ex As Exception
            UltraMessageBoxManager.Show(ex.Message, rm.GetString("MessageBox_Error"))
        End Try
    End Sub

    Private Sub AddNewTask(ByVal addAtSelectedRow As Boolean)
        Dim parentCollection As TasksCollection = Nothing
        Dim calendarInfo As UltraCalendarInfo = Me.ultraGanttView1.CalendarInfo
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask
        Dim project As Project = Me.sampleProject
        Dim insertionIndex As Integer
        Dim start As DateTime
        Dim addToRootcollection As Boolean = True

        If addAtSelectedRow = True Then

            If activeTask IsNot Nothing Then
                Dim parentTask As Task = activeTask.Parent
                parentCollection = If(parentTask IsNot Nothing, parentTask.Tasks, calendarInfo.Tasks)
                insertionIndex = parentCollection.IndexOf(activeTask)
                ' start = If(parentTask IsNot Nothing, parentTask.StartDateTime, project.StartDate)
                addToRootcollection = False
            Else
                insertionIndex = calendarInfo.Tasks.Count
                ' start = project.StartDate
            End If
        Else
            parentCollection = calendarInfo.Tasks
            insertionIndex = calendarInfo.Tasks.Count
            ' start = project.StartDate
        End If

        If parentCollection IsNot Nothing Then
            Dim taskName As String = rm.GetString("NewTaskName")
            Dim newTask As Task

            If addToRootcollection = False AndAlso activeTask IsNot Nothing AndAlso activeTask.Parent IsNot Nothing Then
                newTask = activeTask.Parent.Tasks.Insert(insertionIndex, start, TimeSpan.FromDays(1), taskName)
            Else
                newTask = calendarInfo.Tasks.Insert(insertionIndex, start, TimeSpan.FromDays(1), taskName)
            End If

            newTask.Project = sampleProject
            newTask.RowHeight = TaskRowHeight
        End If
    End Sub

    Private Sub HandleDisplayingTaskDialog(ByVal sender As Object, ByVal e As TaskDialogDisplayingEventArgs)
        e.Dialog.SelectPage(TaskDialogPage.Notes)
    End Sub

    Private Sub MoveTask(ByVal action As GanttViewAction, ByVal moveTimeSpan As TimeSpanForMoving)
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        If activeTask IsNot Nothing AndAlso activeTask.IsSummary = False Then

            Select Case action
                Case GanttViewAction.MoveTaskDateForward

                    Select Case moveTimeSpan
                        Case TimeSpanForMoving.OneDay
                            activeTask.StartDateTime = activeTask.StartDateTime.AddDays(1)
                        Case TimeSpanForMoving.OneWeek
                            activeTask.StartDateTime = activeTask.StartDateTime.AddDays(7)
                        Case TimeSpanForMoving.FourWeeks
                            activeTask.StartDateTime = activeTask.StartDateTime.AddDays(28)
                    End Select

                Case GanttViewAction.MoveTaskDateBackward

                    Select Case moveTimeSpan
                        Case TimeSpanForMoving.OneDay
                            activeTask.StartDateTime = activeTask.StartDateTime.Subtract(TimeSpan.FromDays(1))
                        Case TimeSpanForMoving.OneWeek
                            activeTask.StartDateTime = activeTask.StartDateTime.Subtract(TimeSpan.FromDays(7))
                        Case TimeSpanForMoving.FourWeeks
                            activeTask.StartDateTime = activeTask.StartDateTime.Subtract(TimeSpan.FromDays(28))
                    End Select
            End Select
        End If
    End Sub

    Private Sub ultraGanttViewPrintDocument1_InitializeGanttView(sender As Object, e As UltraWinGanttView.Printing.InitializeGanttViewEventArgs) Handles ultraGanttViewPrintDocument1.InitializeGanttView
        e.Control.GridSettings.ColumnSettings(TaskField.Duration).Visible = DefaultableBoolean.[False]
        e.Control.GridSettings.ColumnSettings(TaskField.Resources).VisiblePosition = 1
    End Sub

End Class