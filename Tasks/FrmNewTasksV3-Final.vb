Public Class FrmNewTasksV2

    Dim PW As Integer
    Dim Hided As Boolean
    Private TaskList As New List(Of TodoItem)
    Private Path As String = Application.StartupPath + "\data.xml"
    Private serializer As MyXmlSerializer = New MyXmlSerializer()

    Private Sub FillTaskList()

        Me.ListBoxCompletedTasksToday.Items.Clear()
        Me.ListBoxCompletedTasksPrev.Items.Clear()
        Me.CheckedListBoxToDoTasks.Items.Clear()

        For Each Task As TodoItem In TaskList
            If Task.TaskIsDone = False Then
                Me.CheckedListBoxToDoTasks.Items.Add(Task)
            Else
                If Date.Compare(Task.TaskCompletedDate.Date, Date.Now.ToString("dddd, dd MMMM yyyy")) < 0 Then
                    'If Task.TaskCompletedDate.Date = Date.Now Then
                    Me.ListBoxCompletedTasksPrev.Items.Add(Task)
                Else
                    Me.ListBoxCompletedTasksToday.Items.Add(Task)
                End If

            End If
        Next
    End Sub

    Private Sub WriteTasksList()
        serializer.Serialize(Of List(Of TodoItem))(Path, Me.TaskList)
    End Sub

    Private Sub ReadTasksList()
        Me.TaskList = serializer.Deserialize(Of List(Of TodoItem))(Path)
    End Sub

    Private Sub BtHideUnHide_Click(sender As Object, e As EventArgs) Handles BtHideUnHide.Click
        Timer1.Start()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PW = Panel6.Width
        Hided = False

        Panel1.BackColor = My.Settings.PanelColor
        ' Panel4.BackColor = My.Settings.PanelColor

        Panel2.BackColor = My.Settings.FormBackgroundColor
        Panel6.BackColor = My.Settings.FormBackgroundColor
        Me.BackColor = My.Settings.FormBackgroundColor

        TabPage1.BackColor = My.Settings.FormBackgroundColor
        TabPage3.BackColor = My.Settings.FormBackgroundColor

        TextBoxNewTask.Text = String.Empty

        If System.IO.File.Exists(Path) Then
            Me.ReadTasksList()
        End If

        Me.FillTaskList()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Hided Then
            Panel6.Width = Panel6.Width + 20
            If Panel6.Width >= PW Then
                Timer1.Stop()
                Hided = False
                Me.Refresh()
            End If
        Else
            Panel6.Width = Panel6.Width - 20
            If Panel6.Width <= 0 Then
                Timer1.Stop()
                Hided = True
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles BtAdd.Click, NewToolStripMenuItem.Click
        Dim NewTask As TodoItem = New TodoItem() With {
      .Id = Guid.NewGuid(),
      .TaskName = TextBoxNewTask.Text,
      .TaskDate = Date.Now,
      .TaskIsDone = False
        }

        Me.TaskList.Add(NewTask)


        Me.FillTaskList()
        Me.WriteTasksList()
        ' Me.CheckedListBoxToDoTasks.Items.Add(NewTask)
        ' MessageBox.Show("dddd " + TextBoxNewTask.Text)
        Me.NotifyIcon1.BalloonTipText = "New Task Has Been Added" + Environment.NewLine + "Task:" + "  " + NewTask.TaskName + " " + Environment.NewLine + NewTask.TaskDate
        Me.NotifyIcon1.ShowBalloonTip(2000)

        'TextBoxNewTask.Text = String.Empty
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click, EditToolStripMenuItem.Click
        If CheckedListBoxToDoTasks.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Task To Edit")
            Return
        End If
        Dim Task1 As TodoItem = CType(CheckedListBoxToDoTasks.SelectedItem, TodoItem)
        Task1.TaskName = TextBoxNewTask.Text
        Me.FillTaskList()
        Me.WriteTasksList()

        'TextBoxNewTask.Text = String.Empty
    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click, DeleteToolStripMenuItem.Click
        If CheckedListBoxToDoTasks.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Task To Delete")
            Return
        End If
        Me.TaskList.Remove(CheckedListBoxToDoTasks.SelectedItem)
        Me.FillTaskList()
        Me.WriteTasksList()
        'CheckedListBoxToDoTasks.Items.Remove(CheckedListBoxToDoTasks.SelectedItem)

        'TextBoxNewTask.Text = String.Empty
    End Sub

    Private Sub CheckedListBoxToDoTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxToDoTasks.SelectedIndexChanged
        If CheckedListBoxToDoTasks.SelectedIndex = -1 Then
            Return
        End If
        Dim Task As TodoItem = CType(CheckedListBoxToDoTasks.SelectedItem, TodoItem)

        TextBoxNewTask.Text = Task.TaskName
        'Me.TaskList.Clear()
    End Sub

    Private Sub CheckedListBoxToDoTasks_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBoxToDoTasks.ItemCheck
        'If e.Index = -1 Then
        '    Return
        If e.NewValue = CheckState.Checked Then
            Dim Task As TodoItem = CType(CheckedListBoxToDoTasks.SelectedItem, TodoItem)
            Task.TaskIsDone = True
            Task.TaskCompletedDate = Date.Now
            Me.WriteTasksList()

            'CheckedListBoxToDoTasks.Items.Remove(task)
            'ListBoxCompletedTasks.Items.Add(task)

            ''Me.FillTaskList()
        End If
    End Sub

    Private Sub CheckedListBoxToDoTasks_MouseUp(sender As Object, e As MouseEventArgs) Handles CheckedListBoxToDoTasks.MouseUp
        If CheckedListBoxToDoTasks.CheckedItems.Count > 0 Then
            Me.FillTaskList()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If ListBoxCompletedTasksToday.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Completed Task To Delete")
            Return
        End If
        Me.TaskList.Remove(ListBoxCompletedTasksToday.SelectedItem)
        Me.FillTaskList()
        Me.WriteTasksList()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        If ListBoxCompletedTasksPrev.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Completed Task To Delete")
            Return
        End If
        Me.TaskList.Remove(ListBoxCompletedTasksPrev.SelectedItem)
        Me.FillTaskList()
        Me.WriteTasksList()
    End Sub
End Class