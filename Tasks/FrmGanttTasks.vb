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

Partial Public Class FrmGanttTasks
    Inherits Form

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

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'FillCombo()
        'DBDataSet.Clear()
        'dbTasksTableAdapter.ClearBeforeFill = True
        'dbProjectsTableAdapter.ClearBeforeFill = True
        'dbProjectsTableAdapter.Fill(DBDataSet.dbProjects)
        'dbTasksTableAdapter.Fill(DBDataSet.dbTasks)
        'ultraCalendarInfo1.DataBindingsForProjects.BindingContextControl = Me
        'ultraCalendarInfo1.DataBindingsForTasks.BindingContextControl = Me
        'ultraCalendarInfo1.DataBindingsForProjects.DataSource = DBDataSet.dbProjects
        'ultraCalendarInfo1.DataBindingsForProjects.IdMember = "ProjectID"
        'ultraCalendarInfo1.DataBindingsForProjects.KeyMember = "ProjectKey"
        'ultraCalendarInfo1.DataBindingsForProjects.NameMember = "ProjectName"
        'ultraCalendarInfo1.DataBindingsForProjects.StartDateMember = "ProjectStartTime"
        'ultraCalendarInfo1.DataBindingsForTasks.DataSource = DBDataSet.dbTasks
        'ultraCalendarInfo1.DataBindingsForTasks.NameMember = "TaskName"
        'ultraCalendarInfo1.DataBindingsForTasks.DurationMember = "TaskDuration3"
        'ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember = "TaskStartTime"
        'ultraCalendarInfo1.DataBindingsForTasks.IdMember = "TaskID"
        'ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember = "ProjectKey"
        'ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember = "ParentTaskID"
        'ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember = "TaskPercentComplete"
        'ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember = "AllProperties"
        'ultraGanttView1.CalendarInfo = ultraCalendarInfo1
        'Dim a As Integer = ultraComboEditor1.SelectedIndex
        ' ultraGanttView1.Project = Me.ultraGanttView1.CalendarInfo.Projects(a)

        ' Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath & "//..//LucidDream.isl")
        'Me.CreateProject()
        '  Me.PopulateTasks()
        Me.PopulateFontSizeValueList()
        '  Me.CreateOwners()
        CType((Me.ultraToolbarsManager1.Tools("FontSize")), ComboBoxTool).SelectedIndex = 0
        CType(Me.ultraToolbarsManager1.Tools("FontList"), FontListTool).SelectedIndex = 0
        Me.ultraGanttView1.GridSettings.ColumnSettings(TaskField.Name).Width = 140
        Me.CreateApplicationMenu2010Tools()
        Me.InitializeApplicationMenu2010()

        'Call the method that creates a DataSet 
        Dim ds As DataSet = getdata()

        ' Set the BindingContextControl property to reference this form 
        Me.ultraCalendarInfo1.DataBindingsForTasks.BindingContextControl = Me
        'ultraCalendarInfo1.DataBindingsForProjects.BindingContextControl = Me

        ' Set the DataBinding members for Projects
        'ultraCalendarInfo1.DataBindingsForProjects.SetDataBinding(ds, "dbProjects")
        ' Set the DataBinding members for Tasks
        Me.ultraCalendarInfo1.DataBindingsForTasks.SetDataBinding(ds, "dbTasks")

        ' Basic Project properties 
        'ultraCalendarInfo1.DataBindingsForProjects.IdMember = "ProjectID"
        'ultraCalendarInfo1.DataBindingsForProjects.KeyMember = "ProjectKey"
        'ultraCalendarInfo1.DataBindingsForProjects.NameMember = "ProjectName"
        'ultraCalendarInfo1.DataBindingsForProjects.StartDateMember = "ProjectStartTime"

        ' Basic Task properties 
        ultraCalendarInfo1.DataBindingsForTasks.NameMember = "TaskName"
        ultraCalendarInfo1.DataBindingsForTasks.DurationMember = "TaskDuration"
        ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember = "TaskStartTime"
        ultraCalendarInfo1.DataBindingsForTasks.IdMember = "TaskID"
        ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember = "ProjectKey"
        ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember = "ParentTaskID"
        ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember = "TaskPercentComplete"
        ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember = "AllProperties"
        Me.ultraGanttView1.CalendarInfo = Me.ultraCalendarInfo1

        'Try
        '    TaskDataSet1.Clear()
        '    dbProjectsTableAdapter.Fill(TaskDataSet1.dbProjects)
        '    dbTasksTableAdapter.Fill(TaskDataSet1.dbTasks)
        '    ultraCalendarInfo1.DataBindingsForProjects.BindingContextControl = Me
        '    ultraCalendarInfo1.DataBindingsForTasks.BindingContextControl = Me
        '    Me.ultraCalendarInfo1.DataBindingsForProjects.DataSource = TaskDataSet1.dbProjects
        '    Me.ultraCalendarInfo1.DataBindingsForProjects.IdMember = "ProjectID"
        '    Me.ultraCalendarInfo1.DataBindingsForProjects.KeyMember = "ProjectKey"
        '    Me.ultraCalendarInfo1.DataBindingsForProjects.NameMember = "ProjectName"
        '    Me.ultraCalendarInfo1.DataBindingsForProjects.StartDateMember = "ProjectStartTime"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.DataSource = TaskDataSet1.dbTasks
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.NameMember = "TaskName"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.DurationMember = "TaskDuration3"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember = "TaskStartTime"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.IdMember = "TaskID"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember = "ProjectKey"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember = "ParentTaskID"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember = "TaskPercentComplete"
        '    Me.ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember = "AllProperties"
        '    Me.ultraGanttView1.CalendarInfo = Me.ultraCalendarInfo1
        '    Me.ultraGanttView1.Project = Me.ultraGanttView1.CalendarInfo.Projects(1)
        '    ' Me.ultraCalendarInfo1.Projects(1).Tasks(0).SetCustomProperty("CustomColumn", DBDataSet.dbTasks(0).CustomColumn)
        '    ' Me.ultraCalendarInfo1.Projects(1).Tasks(1).SetCustomProperty("CustomColumn", DBDataSet.dbTasks(1).CustomColumn)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Function getdata()
        Dim connetionString As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String

        connetionString = "Data Source= .;Initial Catalog=TasksDB;Integrated Security=True"
        sql = "select * from tblTasks"
        connection = New SqlConnection(connetionString)

        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds, "tblTasks")
            adapter.Dispose()
            command.Dispose()
            connection.Close()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
        Return ds
    End Function

    'Private Sub FillCombo()
    '    dbProjectsTableAdapter.Fill(DBDataSet.dbProjects)
    '    ultraComboEditor1.DataSource = DBDataSet.dbProjects
    '    ultraComboEditor1.DisplayMember = "ProjectName"
    '    ultraComboEditor1.ValueMember = "Id"
    '    ultraComboEditor1.SelectedIndex = 0
    '    ' UltraComboEditor1.Items(0).DisplayText = "--- Select ---"
    'End Sub

    'Private Sub UltraComboEditor1_ValueChanged(sender As Object, e As EventArgs) Handles UltraComboEditor1.ValueChanged
    '    Dim a As Integer = UltraComboEditor1.SelectedIndex
    '    ultraGanttView1.Project = Me.ultraGanttView1.CalendarInfo.Projects(a)
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '        dbProjectsTableAdapter.Update(DBDataSet.dbProjects)
    '        dbTasksTableAdapter.Update(DBDataSet.dbTasks)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub ultraGanttView1_CellActivating_1(sender As Object, e As CellActivatingEventArgs) Handles ultraGanttView1.CellActivating
        Me.isToolUpdatedWithCellActivation = True
        Dim activeTask As Task = e.TaskFieldInfo.Task

        If activeTask IsNot Nothing Then
            Dim activeField As TaskField? = e.TaskFieldInfo.TaskField

            If activeField.HasValue Then

                If activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.Bold = DefaultableBoolean.[True] Then
                    CType(Me.ultraToolbarsManager1.Tools("Font_Bold"), StateButtonTool).Checked = True
                Else
                    CType(Me.ultraToolbarsManager1.Tools("Font_Bold"), StateButtonTool).Checked = False
                End If

                If activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.Italic = DefaultableBoolean.[True] Then
                    CType(Me.ultraToolbarsManager1.Tools("Font_Italics"), StateButtonTool).Checked = True
                Else
                    CType(Me.ultraToolbarsManager1.Tools("Font_Italics"), StateButtonTool).Checked = False
                End If

                If activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.Underline = DefaultableBoolean.[True] Then
                    CType(Me.ultraToolbarsManager1.Tools("Font_Underline"), StateButtonTool).Checked = True
                Else
                    CType(Me.ultraToolbarsManager1.Tools("Font_Underline"), StateButtonTool).Checked = False
                End If

                Dim fontName As String = activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.Name

                If fontName IsNot Nothing Then
                    CType(Me.ultraToolbarsManager1.Tools("FontList"), FontListTool).Text = fontName
                Else
                    CType(Me.ultraToolbarsManager1.Tools("FontList"), FontListTool).SelectedIndex = 0
                End If

                Dim fontSize As Single = activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.SizeInPoints

                If fontSize <> 0 Then
                    CType(Me.ultraToolbarsManager1.Tools("FontSize"), ComboBoxTool).Value = fontSize
                Else
                    CType((Me.ultraToolbarsManager1.Tools("FontSize")), ComboBoxTool).SelectedIndex = 0
                End If
            End If
        End If

        Me.isToolUpdatedWithCellActivation = False
    End Sub

    Private Sub ultraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles ultraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Font_Bold"
                If isToolUpdatedWithCellActivation = False Then Me.UpdateFontProperty(FontProperties.Bold)
            Case "Font_Italics"
                If isToolUpdatedWithCellActivation = False Then Me.UpdateFontProperty(FontProperties.Italics)
            Case "Font_Underline"
                If isToolUpdatedWithCellActivation = False Then Me.UpdateFontProperty(FontProperties.Underline)
            Case "FontBGColor"
                Me.SetTextBGColor()
            Case "Font_ForeColor"
                Me.SetTextForeColor()
            Case "FontList"
                Me.UpdateFontName()
            Case "FontSize"
                Me.UpdateFontSize()
            Case "Insert_Task_Task"
                Me.AddNewTask(False)
            Case "Insert_Task_TaskAtSelectedRow"
                Me.AddNewTask(True)
            Case "Task_ZeroPercent"
                Me.SetTaskPercentage(0)
            Case "Task_25Percent"
                Me.SetTaskPercentage(25)
            Case "Task_50Percent"
                Me.SetTaskPercentage(50)
            Case "Task_75Percent"
                Me.SetTaskPercentage(75)
            Case "Task_100Percent"
                Me.SetTaskPercentage(100)
            Case "Task_Outdent"
                Me.PerformIndentOrOutdent(GanttViewAction.OutdentTask)
            Case "Task_Indent"
                Me.PerformIndentOrOutdent(GanttViewAction.IndentTask)
            Case "Schedule_MoveTask_1Day"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.OneDay)
            Case "Schedule_MoveTask_1Week"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.OneWeek)
            Case "Schedule_MoveTask_4Weeks"
                Me.MoveTask(GanttViewAction.MoveTaskDateForward, TimeSpanForMoving.FourWeeks)
            Case "Schedule_MoveTask_MoveTaskBackwards1Day"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.OneDay)
            Case "Schedule_MoveTask_MoveTaskBackwards1Week"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.OneWeek)
            Case "Schedule_MoveTask_MoveTaskBackwards4Weeks"
                Me.MoveTask(GanttViewAction.MoveTaskDateBackward, TimeSpanForMoving.FourWeeks)
            Case "Properties_TaskInformation"
                Me.ultraGanttView1.DisplayTaskDialog(Me.ultraGanttView1.ActiveTask)
            Case "Properties_Notes"
                ' Me.ultraGanttView1.TaskDialogDisplaying += New TaskDialogDisplayingHandler(AddressOf HandleDisplayingTaskDialog)
                Me.ultraGanttView1.DisplayTaskDialog(Me.ultraGanttView1.ActiveTask)
               ' Me.ultraGanttView1.TaskDialogDisplaying -= New TaskDialogDisplayingHandler(AddressOf HandleDisplayingTaskDialog)
            Case "Insert_Milestone"
                Me.ultraGanttView1.ActiveTask.Milestone = Not Me.ultraGanttView1.ActiveTask.Milestone
            Case "Exit"
                Application.[Exit]()
            Case "BlueTheme"
                Office2010ColorTable.ColorScheme = Office2010ColorScheme.Blue
            Case "SilverTheme"
                Office2010ColorTable.ColorScheme = Office2010ColorScheme.Silver
            Case "BlackTheme"
                Office2010ColorTable.ColorScheme = Office2010ColorScheme.Black
            Case "Save"
                dbProjectsTableAdapter.Update(TaskDataSet1.dbProjects)
                dbTasksTableAdapter.Update(TaskDataSet1.dbTasks)
        End Select
    End Sub

    Private Sub ultraToolbarsManager1_ToolValueChanged(ByVal sender As Object, ByVal e As ToolEventArgs) Handles ultraToolbarsManager1.ToolValueChanged
        Select Case e.Tool.Key
            Case "FontBGColor"
                Me.SetTextBGColor()
            Case "Font_ForeColor"
                Me.SetTextForeColor()
            Case "FontList"
                Me.UpdateFontName()
            Case "FontSize"
                Me.UpdateFontSize()
        End Select
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

    Private Sub PopulateFontSizeValueList()
        Dim fontSizeList As List(Of Single) = New List(Of Single)(New Single() {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72})

        For Each i As Single In fontSizeList
            CType((Me.ultraToolbarsManager1.Tools("FontSize")), ComboBoxTool).ValueList.ValueListItems.Add(i)
        Next
    End Sub

    Private Sub UpdateFontName()
        Dim fontName As String = (CType(Me.ultraToolbarsManager1.Tools("FontList"), FontListTool)).Text
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        If activeTask IsNot Nothing Then
            Dim activeField As TaskField? = Me.ultraGanttView1.ActiveField

            If activeField.HasValue Then
                activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.Name = fontName
            End If
        End If
    End Sub

    Private Sub UpdateFontSize()
        Dim item As ValueListItem = CType((CType((Me.ultraToolbarsManager1.Tools("FontSize")), ComboBoxTool)).SelectedItem, ValueListItem)

        If item IsNot Nothing Then
            Dim fontSize As Single = CSng(item.DataValue)
            Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

            If activeTask IsNot Nothing Then
                Dim activeField As TaskField? = Me.ultraGanttView1.ActiveField

                If activeField.HasValue Then
                    activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData.SizeInPoints = fontSize
                End If
            End If
        End If
    End Sub

    Private Sub SetTextBGColor()
        Dim fontBGColor As Color = (CType(Me.ultraToolbarsManager1.Tools("FontBGColor"), PopupColorPickerTool)).SelectedColor
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        If activeTask IsNot Nothing Then
            Dim activeField As TaskField? = Me.ultraGanttView1.ActiveField

            If activeField.HasValue Then
                activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.BackColor = fontBGColor
            End If
        End If
    End Sub

    Private Sub SetTextForeColor()
        Dim fontColor As Color = (CType(Me.ultraToolbarsManager1.Tools("Font_ForeColor"), PopupColorPickerTool)).SelectedColor
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        If activeTask IsNot Nothing Then
            Dim activeField As TaskField? = Me.ultraGanttView1.ActiveField

            If activeField.HasValue Then
                activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.ForeColor = fontColor
            End If
        End If
    End Sub

    Private Sub UpdateFontProperty(ByVal propertyToUpdate As FontProperties)
        Dim activeTask As Task = Me.ultraGanttView1.ActiveTask

        If activeTask IsNot Nothing Then
            Dim activeField As TaskField? = Me.ultraGanttView1.ActiveField

            If activeField.HasValue Then
                Dim activeTaskActiveCellFontData As FontData = activeTask.GridSettings.CellSettings(CType(activeField, TaskField)).Appearance.FontData

                Select Case propertyToUpdate
                    Case FontProperties.Bold
                        activeTaskActiveCellFontData.Bold = Me.ToggleDefaultableBoolean(activeTaskActiveCellFontData.Bold)
                    Case FontProperties.Italics
                        activeTaskActiveCellFontData.Italic = Me.ToggleDefaultableBoolean(activeTaskActiveCellFontData.Italic)
                    Case FontProperties.Underline
                        activeTaskActiveCellFontData.Underline = Me.ToggleDefaultableBoolean(activeTaskActiveCellFontData.Underline)
                End Select
            End If
        End If

        Me.isToolUpdatedWithCellActivation = False
    End Sub

    Private Function ToggleDefaultableBoolean(ByVal value As DefaultableBoolean) As DefaultableBoolean
        If value = Infragistics.Win.DefaultableBoolean.[True] Then
            value = Infragistics.Win.DefaultableBoolean.[False]
        Else
            value = Infragistics.Win.DefaultableBoolean.[True]
        End If

        Return value
    End Function

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
                start = If(parentTask IsNot Nothing, parentTask.StartDateTime, project.StartDate)
                addToRootcollection = False
            Else
                insertionIndex = calendarInfo.Tasks.Count
                start = project.StartDate
            End If
        Else
            parentCollection = calendarInfo.Tasks
            insertionIndex = calendarInfo.Tasks.Count
            start = project.StartDate
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

    Private Sub PopulateTasks()
        Me.CreateSummaryTasks()
        Dim gatherCustomerRequirementTask As Task = requirementsTask.Tasks.Add(DateTime.Today, TimeSpan.FromDays(3), rm.GetString("GatherCustomerRequirementTask"))
        gatherCustomerRequirementTask.StartDateTime = DateTime.Today
        gatherCustomerRequirementTask.PercentComplete = 100
        gatherCustomerRequirementTask.Deadline = DateTime.Today.AddDays(12)
        gatherCustomerRequirementTask.RowHeight = TaskRowHeight
        gatherCustomerRequirementTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        gatherCustomerRequirementTask.TimelineSettings.BarSettings.BarAppearance.ForeColor = Color.Red
        gatherCustomerRequirementTask.Resources.Add("Jon")
        Dim analyzeFunctionalRequirementTask As Task = requirementsTask.Tasks.Add(DateTime.Today.AddDays(2), TimeSpan.FromDays(2), rm.GetString("AnalyzeFunctionalRequirementTask"))
        analyzeFunctionalRequirementTask.StartDateTime = DateTime.Today.AddDays(2)
        analyzeFunctionalRequirementTask.PercentComplete = 100
        analyzeFunctionalRequirementTask.Dependencies.Add(gatherCustomerRequirementTask, TaskDependencyType.FinishToStart)
        analyzeFunctionalRequirementTask.Deadline = DateTime.Today.AddDays(12)
        analyzeFunctionalRequirementTask.RowHeight = TaskRowHeight
        analyzeFunctionalRequirementTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        analyzeFunctionalRequirementTask.Resources.Add("Jim")
        Dim analyzePerformaceRequirementTask As Task = requirementsTask.Tasks.Add(DateTime.Today.AddDays(2), TimeSpan.FromDays(2), rm.GetString("AnalyzePerformaceRequirementTask"))
        analyzePerformaceRequirementTask.StartDateTime = DateTime.Today.AddDays(2)
        analyzePerformaceRequirementTask.PercentComplete = 90
        analyzePerformaceRequirementTask.Dependencies.Add(gatherCustomerRequirementTask, TaskDependencyType.FinishToStart)
        analyzePerformaceRequirementTask.RowHeight = TaskRowHeight
        analyzePerformaceRequirementTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        analyzePerformaceRequirementTask.Resources.Add("Ted")
        Dim budgetTask As Task = requirementsTask.Tasks.Add(DateTime.Today.AddDays(4), TimeSpan.FromDays(2), rm.GetString("BudgetTaskName"))
        budgetTask.StartDateTime = DateTime.Today.AddDays(4)
        budgetTask.PercentComplete = 50
        budgetTask.Dependencies.Add(analyzeFunctionalRequirementTask, TaskDependencyType.FinishToStart)
        budgetTask.RowHeight = TaskRowHeight
        budgetTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        budgetTask.Resources.Add("Kim")
        Dim teamTask As Task = requirementsTask.Tasks.Add(DateTime.Today.AddDays(4), TimeSpan.FromDays(2), rm.GetString("TeamTaskName"))
        teamTask.StartDateTime = DateTime.Today.AddDays(4)
        teamTask.PercentComplete = 50
        teamTask.RowHeight = TaskRowHeight
        teamTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        teamTask.Resources.Add("Daniel")
        Dim designDocumentTask As Task = requirementsTask.Tasks.Add(DateTime.Today.AddDays(6), TimeSpan.FromDays(2), rm.GetString("DesignDocumentTask"))
        designDocumentTask.StartDateTime = DateTime.Today.AddDays(6)
        designDocumentTask.PercentComplete = 100
        designDocumentTask.RowHeight = TaskRowHeight
        designDocumentTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        designDocumentTask.Resources.Add("Jun")
        Dim createDesignDocumentTask As Task = designDocumentTask.Tasks.Add(DateTime.Today.AddDays(6), TimeSpan.FromDays(2), rm.GetString("CreateDesignDocumentTask"))
        createDesignDocumentTask.StartDateTime = DateTime.Today.AddDays(6)
        createDesignDocumentTask.PercentComplete = 85
        createDesignDocumentTask.RowHeight = TaskRowHeight
        createDesignDocumentTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        createDesignDocumentTask.Resources.Add("Daniel")
        Dim designDocumentReviewTask As Task = designDocumentTask.Tasks.Add(DateTime.Today.AddDays(8), TimeSpan.FromDays(2), rm.GetString("ReviewDesignDocumentTask"))
        designDocumentReviewTask.StartDateTime = DateTime.Today.AddDays(8)
        designDocumentReviewTask.PercentComplete = 50
        designDocumentReviewTask.RowHeight = TaskRowHeight
        designDocumentReviewTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        designDocumentReviewTask.Resources.Add("Tom")
        designDocumentReviewTask.Resources.Add("Jane")
        Dim redesign As Task = visualDesignTask.Tasks.Add(DateTime.Today, TimeSpan.FromDays(3), rm.GetString("RedesignWebsiteTaskName"))
        redesign.StartDateTime = DateTime.Today.AddDays(3)
        redesign.PercentComplete = 85
        redesign.RowHeight = TaskRowHeight
        redesign.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        redesign.Resources.Add("Ted")
        Dim mockUp As Task = visualDesignTask.Tasks.Add(DateTime.Today.AddDays(3), TimeSpan.FromDays(3), rm.GetString("MockUpTaskName"))
        mockUp.StartDateTime = DateTime.Today.AddDays(6)
        mockUp.PercentComplete = 80
        mockUp.RowHeight = TaskRowHeight
        mockUp.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        mockUp.Resources.Add("Tom")
        Dim meetEngineer As Task = mockUp.Tasks.Add(DateTime.Today.AddDays(3), TimeSpan.FromDays(1), rm.GetString("MeetEngTaskName"))
        meetEngineer.StartDateTime = DateTime.Today.AddDays(6)
        meetEngineer.PercentComplete = 75
        meetEngineer.Deadline = DateTime.Today.AddDays(9)
        meetEngineer.RowHeight = TaskRowHeight
        meetEngineer.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        meetEngineer.Resources.Add("Kim")
        Dim specReview As Task = mockUp.Tasks.Add(DateTime.Today.AddDays(4), TimeSpan.FromDays(1), rm.GetString("SpecReviewTaskName"))
        specReview.StartDateTime = DateTime.Today.AddDays(7)
        specReview.PercentComplete = 25
        specReview.Deadline = DateTime.Today.AddDays(10)
        specReview.RowHeight = TaskRowHeight
        specReview.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        specReview.Resources.Add("Daniel")
        Dim featureDevelopmentTask As Task = codeDevelopmentTask.Tasks.Add(DateTime.Today, TimeSpan.FromDays(3), rm.GetString("FeatureDevelopmentTaskName"))
        featureDevelopmentTask.StartDateTime = DateTime.Today.AddDays(9)
        featureDevelopmentTask.PercentComplete = 25
        featureDevelopmentTask.RowHeight = TaskRowHeight
        featureDevelopmentTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        featureDevelopmentTask.Resources.Add("Jon")
        Dim unitTestDevelopmentTask As Task = codeDevelopmentTask.Tasks.Add(DateTime.Today.AddDays(3), TimeSpan.FromDays(2), rm.GetString("UnitTestTaskName"))
        unitTestDevelopmentTask.StartDateTime = DateTime.Today.AddDays(12)
        unitTestDevelopmentTask.PercentComplete = 20
        unitTestDevelopmentTask.Dependencies.Add(featureDevelopmentTask, TaskDependencyType.FinishToStart)
        unitTestDevelopmentTask.RowHeight = TaskRowHeight
        unitTestDevelopmentTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        unitTestDevelopmentTask.Resources.Add("Jun")
        Dim fixBugsTask As Task = codeDevelopmentTask.Tasks.Add(DateTime.Today.AddDays(4), TimeSpan.FromDays(2), rm.GetString("FixBugsTaskName"))
        fixBugsTask.StartDateTime = DateTime.Today.AddDays(13)
        fixBugsTask.PercentComplete = 10
        fixBugsTask.Dependencies.Add(featureDevelopmentTask, TaskDependencyType.FinishToStart)
        fixBugsTask.RowHeight = TaskRowHeight
        fixBugsTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        fixBugsTask.Resources.Add("Kim")
        Dim testGrid As Task = qualityAssurance.Tasks.Add(DateTime.Today, TimeSpan.FromDays(5), rm.GetString("TestGridTaskName"))
        testGrid.StartDateTime = DateTime.Today.AddDays(13)
        testGrid.PercentComplete = 5
        testGrid.RowHeight = TaskRowHeight
        testGrid.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        testGrid.Resources.Add("Jane")
        Dim testSamplesTask As Task = qualityAssurance.Tasks.Add(DateTime.Today, TimeSpan.FromDays(5), rm.GetString("TestSamplesTaskName"))
        testSamplesTask.StartDateTime = DateTime.Today.AddDays(13)
        testSamplesTask.PercentComplete = 50
        testSamplesTask.RowHeight = TaskRowHeight
        testSamplesTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        testSamplesTask.Resources.Add("Kathey")
        Dim regressionTestingTask As Task = qualityAssurance.Tasks.Add(DateTime.Today.AddDays(3), TimeSpan.FromDays(4), rm.GetString("RegressionTestTaskName"))
        regressionTestingTask.StartDateTime = DateTime.Today.AddDays(16)
        regressionTestingTask.PercentComplete = 40
        regressionTestingTask.RowHeight = TaskRowHeight
        regressionTestingTask.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        regressionTestingTask.Resources.Add("Daniel")
        Dim proofRead As Task = qualityAssurance.Tasks.Add(DateTime.Today.AddDays(6), TimeSpan.FromDays(1), rm.GetString("ProofReadTaskName"))
        proofRead.StartDateTime = DateTime.Today.AddDays(19)
        proofRead.PercentComplete = 75
        proofRead.Dependencies.Add(designDocumentReviewTask, TaskDependencyType.StartToStart)
        proofRead.RowHeight = TaskRowHeight
        proofRead.TimelineSettings.BarSettings.BarHeight = TaskBarHeight
        proofRead.Resources.Add("Jane")
    End Sub

    Private Sub CreateSummaryTasks()
        requirementsTask = Me.ultraCalendarInfo1.Tasks.Add(TimeSpan.FromDays(10), rm.GetString("RequirementsTaskName"), sampleProject.Key)
        visualDesignTask = Me.ultraCalendarInfo1.Tasks.Add(TimeSpan.FromDays(5), rm.GetString("VisualDesignTaskName"), sampleProject.Key)
        codeDevelopmentTask = Me.ultraCalendarInfo1.Tasks.Add(TimeSpan.FromDays(6), rm.GetString("CodeDevelopmentTaskName"), sampleProject.Key)
        qualityAssurance = Me.ultraCalendarInfo1.Tasks.Add(TimeSpan.FromDays(7), rm.GetString("QualityAssuranceTaskName"), sampleProject.Key)
        Dim summaryTaskColor As Color = Color.FromArgb(0, 209, 251)
        requirementsTask.RowHeight = TaskRowHeight
        requirementsTask.GridSettings.RowAppearance.ForeColor = summaryTaskColor
        visualDesignTask.RowHeight = TaskRowHeight
        visualDesignTask.GridSettings.RowAppearance.ForeColor = summaryTaskColor
        codeDevelopmentTask.RowHeight = TaskRowHeight
        codeDevelopmentTask.GridSettings.RowAppearance.ForeColor = summaryTaskColor
        qualityAssurance.RowHeight = TaskRowHeight
        qualityAssurance.GridSettings.RowAppearance.ForeColor = summaryTaskColor
    End Sub

    Private Sub CreateProject()
        sampleProject = New Project()
        sampleProject.Key = "Project1"
        sampleProject.Name = "Sample Project"
        sampleProject.StartDate = DateTime.Today
        Me.ultraCalendarInfo1.Projects.Add(sampleProject)
        Me.ultraGanttView1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraGanttView1.Project = Me.ultraGanttView1.CalendarInfo.Projects(1)
    End Sub

    Private Sub CreateOwners()
        Me.ultraCalendarInfo1.Owners.Add("Jon")
        Me.ultraCalendarInfo1.Owners.Add("Jim")
        Me.ultraCalendarInfo1.Owners.Add("Tom")
        Me.ultraCalendarInfo1.Owners.Add("Kim")
        Me.ultraCalendarInfo1.Owners.Add("Ted")
        Me.ultraCalendarInfo1.Owners.Add("Jun")
        Me.ultraCalendarInfo1.Owners.Add("Daniel")
        Me.ultraCalendarInfo1.Owners.Add("Kathey")
        Me.ultraCalendarInfo1.Owners.Add("Jane")
    End Sub

    Private Sub CreateApplicationMenu2010Tools()
        Dim newBtnTool As ButtonTool = New ButtonTool("NewBtnTool")
        Me.ultraToolbarsManager1.Tools.Add(newBtnTool)
        newBtnTool.SharedProps.AppearancesSmall.Appearance.Image = imageList1.Images(52)
        newBtnTool.SharedProps.Caption = rm.GetString("New")
        Dim copyBtnTool As ButtonTool = New ButtonTool("CopyBtnTool")
        Me.ultraToolbarsManager1.Tools.Add(copyBtnTool)
        copyBtnTool.SharedProps.AppearancesSmall.Appearance.Image = imageList1.Images(51)
        copyBtnTool.SharedProps.Caption = rm.GetString("Copy")
        Dim themelblTool As LabelTool = New LabelTool("themeLabelTool")
        Me.ultraToolbarsManager1.Tools.Add(themelblTool)
        themelblTool.SharedProps.Caption = rm.GetString("ColorScheme")
        Dim blueThemeTool As ButtonTool = New ButtonTool("BlueTheme")
        Me.ultraToolbarsManager1.Tools.Add(blueThemeTool)
        blueThemeTool.SharedProps.Caption = rm.GetString("BlueScheme")
        Dim silverThemeTool As ButtonTool = New ButtonTool("SilverTheme")
        Me.ultraToolbarsManager1.Tools.Add(silverThemeTool)
        silverThemeTool.SharedProps.Caption = rm.GetString("SilverScheme")
        Dim blackThemeTool As ButtonTool = New ButtonTool("BlackTheme")
        Me.ultraToolbarsManager1.Tools.Add(blackThemeTool)
        blackThemeTool.SharedProps.Caption = rm.GetString("BlackScheme")
        Dim popupMenu1 As PopupMenuTool = New PopupMenuTool("PopupTheme")
        popupMenu1.Settings.PopupStyle = PopupStyle.Menu
        popupMenu1.SharedProps.Caption = rm.GetString("Office2010Themes")
        popupMenu1.SharedProps.DescriptionOnMenu = rm.GetString("ChooseColorScheme")
        Me.ultraToolbarsManager1.Tools.Add(popupMenu1)
        popupMenu1.Tools.AddTool("themeLabelTool")
        popupMenu1.Tools.AddTool("BlueTheme")
        popupMenu1.Tools.AddTool("SilverTheme")
        popupMenu1.Tools.AddTool("BlackTheme")
        Dim recentlyUsedlblTool As LabelTool = New LabelTool("RecentlyUsedLabelTool")
        Me.ultraToolbarsManager1.Tools.Add(recentlyUsedlblTool)
        recentlyUsedlblTool.SharedProps.Caption = rm.GetString("RecentlyUsed")
        Dim recentTool As ListTool = New ListTool("Recent1")
        recentTool.DisplayCheckmark = False
        recentTool.ListToolItems.Add("doc1", rm.GetString("Document1"))
        recentTool.ListToolItems("doc1").Appearance.Image = ilLarge.Images(0)
        recentTool.ListToolItems.Add("doc2", rm.GetString("Document2"))
        recentTool.ListToolItems("doc2").Appearance.Image = ilLarge.Images(0)
        recentTool.ListToolItems.Add("doc3", rm.GetString("Document3"))
        recentTool.ListToolItems("doc3").Appearance.Image = ilLarge.Images(0)
        Me.ultraToolbarsManager1.Tools.Add(recentTool)
        Dim popupMenu2 As PopupMenuTool = New PopupMenuTool("PopupRecent")
        popupMenu2.Settings.PopupStyle = PopupStyle.Menu
        popupMenu2.SharedProps.Caption = rm.GetString("Recent")
        Me.ultraToolbarsManager1.Tools.Add(popupMenu2)
        popupMenu2.Tools.AddTool("RecentlyUsedLabelTool")
        popupMenu2.Tools.AddTool("Recent1")
        Dim formatList As ListTool = New ListTool("DocFormatTool")
        formatList.ListToolItems.Add("ExcelTool", rm.GetString("Excel"))
        formatList.ListToolItems(0).Appearance.Image = imageList1.Images(3)
        formatList.ListToolItems.Add("WordTool", rm.GetString("Word"))
        formatList.ListToolItems.Add("PowerpointTool", rm.GetString("Powerpoint"))
        formatList.ListToolItems.Add("PDFTool", rm.GetString("PDF"))
        Me.ultraToolbarsManager1.Tools.Add(formatList)
        ultraListView1 = New UltraListView()
        ultraListView1.Width = 500
        ultraListView1.Height = 500
        ultraListView1.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Icons
        ultraListView1.ViewSettingsIcons.ImageList = Me.ilLarge
        ultraListView1.Items.Add("Excel", rm.GetString("Excel"))
        ultraListView1.Items(0).Appearance.Image = 2
        ultraListView1.Items.Add("Word", rm.GetString("Word"))
        ultraListView1.Items(1).Appearance.Image = 1
        ultraListView1.Items.Add("Powerpoint", rm.GetString("Powerpoint"))
        ultraListView1.Items(2).Appearance.Image = 3
        ultraListView1.Items.Add("PDF", rm.GetString("PDF"))
        ultraListView1.Items(3).Appearance.Image = 4
        Dim listViewTool As PopupControlContainerTool = New PopupControlContainerTool("ListViewTool")
        listViewTool.SharedProps.Caption = rm.GetString("Format")
        Me.ultraToolbarsManager1.Tools.Add(listViewTool)
        listViewTool.Control = ultraListView1
        Dim popupSend As PopupMenuTool = New PopupMenuTool("SendPopupMenu")
        popupSend.Settings.PopupStyle = PopupStyle.Menu
        popupSend.SharedProps.Caption = rm.GetString("Send")
        Me.ultraToolbarsManager1.Tools.Add(popupSend)
        popupSend.Tools.AddTool("listViewTool")
    End Sub

    Private Sub InitializeApplicationMenu2010()
        Dim appMenu2010 As ApplicationMenu2010 = Me.ultraToolbarsManager1.Ribbon.ApplicationMenu2010
        appMenu2010.NavigationMenu.Tools.AddTool("NewBtnTool")
        appMenu2010.NavigationMenu.Tools.AddTool("CopyBtnTool")
        appMenu2010.NavigationMenu.Tools.AddTool("PopupTheme")
        appMenu2010.NavigationMenu.Tools.AddTool("PopupRecent")
        appMenu2010.NavigationMenu.Tools.AddTool("SendPopupMenu")
    End Sub

    Private Function GetImage(ByVal resourceName As String) As Image
        Dim type As Type = GetType(FrmGanttTasks)
        Dim stream As System.IO.Stream = type.[Module].Assembly.GetManifestResourceStream(type, resourceName)
        Return Image.FromStream(stream)
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'dbProjectsTableAdapter.Update(TaskDataSet1.dbProjects)
        'dbTasksTableAdapter.Update(TaskDataSet1.dbTasks)

        'Dim connetionString As String
        'Dim connection As SqlConnection
        'Dim command As SqlCommand
        'Dim adapter As New SqlDataAdapter
        'Dim ds As New DataSet

        'connetionString = "Data Source= .;Initial Catalog=TasksDB;Integrated Security=True"
        'connection = New SqlConnection(connetionString)

        'command = New SqlCommand("INSERT into dbTasks  (TaskID,ProjectKey,TaskName,TaskStartTime,TaskDuration,ParentTaskID,TaskPercentComplete,AllProperties,Milestone,TaskDuration3) values(@TaskID,@ProjectKey,@TaskName,@TaskStartTime,@TaskDuration,@ParentTaskID,@TaskPercentComplete,@AllProperties,@Milestone,@TaskDuration3)", connection)
        'command.Parameters.Add("@TaskID", SqlDbType.Int).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.IdMember
        'command.Parameters.Add("@ProjectKey", SqlDbType.NVarChar, 100).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.ProjectKeyMember
        'command.Parameters.Add("@TaskName", SqlDbType.NVarChar, 100).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.NameMember
        'command.Parameters.Add("@TaskStartTime", SqlDbType.DateTime).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.StartDateTimeMember
        'command.Parameters.Add("@TaskDuration", SqlDbType.NVarChar, 50).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.DurationMember
        'command.Parameters.Add("@ParentTaskID", SqlDbType.Int).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.ParentTaskIdMember
        'command.Parameters.Add("@TaskPercentComplete", SqlDbType.Int).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.PercentCompleteMember
        'command.Parameters.Add("@AllProperties", SqlDbType.Binary, 1024).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.AllPropertiesMember
        'command.Parameters.Add("@Milestone", SqlDbType.Bit).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.MilestoneMember
        ''command.Parameters.Add("@Resources", SqlDbType.NVarChar).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.r
        'command.Parameters.Add("@TaskDuration3", SqlDbType.NVarChar, 50).Value = Me.ultraCalendarInfo1.DataBindingsForTasks.DurationMember
        '' Try
        'connection.Open()
        'Dim myReader As SqlDataReader = command.ExecuteReader()
        'MessageBox.Show("Task is Saved ! ")
        'myReader.Dispose()
        'command.Dispose()
        'connection.Close()
        '' Catch ex As Exception
        '' MsgBox("Can Not open connection ! ")
        ''  End Try

    End Sub

    Private Sub ultraGanttView1_TaskAdded(sender As Object, e As TaskAddedEventArgs) Handles ultraGanttView1.TaskAdded

        Dim connetionString As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet

        connetionString = "Data Source= .;Initial Catalog=TasksDB;Integrated Security=True"
        connection = New SqlConnection(connetionString)

        command = New SqlCommand("INSERT into tblTasks  (TaskID,ProjectKey,TaskName,TaskStartTime,TaskPercentComplete) values(@TaskID,@ProjectKey,@TaskName,@TaskStartTime,@TaskPercentComplete)", connection)
        command.Parameters.Add("@TaskID", SqlDbType.UniqueIdentifier).Value = e.Task.Id
        command.Parameters.Add("@ProjectKey", SqlDbType.VarChar, 50).Value = e.Task.ProjectKey
        command.Parameters.Add("@TaskName", SqlDbType.VarChar, 50).Value = e.Task.Name
        command.Parameters.Add("@TaskStartTime", SqlDbType.DateTime).Value = e.Task.StartDateTime
        'command.Parameters.Add("@TaskDuration", SqlDbType.DateTimeOffset).Value = e.Task.Duration
        'command.Parameters.Add("@ParentTaskID", SqlDbType.Int).Value = e.Task.Parent
        command.Parameters.Add("@TaskPercentComplete", SqlDbType.Int).Value = e.Task.PercentComplete
        'command.Parameters.Add("@AllProperties", SqlDbType.Binary, 1024).Value = e.Task
        ' Try
        connection.Open()
        Dim myReader As SqlDataReader = command.ExecuteReader()
        MessageBox.Show("Task is Saved !")
        myReader.Dispose()
        command.Dispose()
        connection.Close()
        ' Catch ex As Exception
        ' MsgBox("Can Not open connection ! ")
        '  End Try

    End Sub
End Class

