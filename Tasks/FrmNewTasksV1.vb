Public Class FrmNewTasksV1

    Private TaskList As New List(Of TodoItem)

    Private Path As String = Application.StartupPath + "\data.xml"

    Private serializer As MyXmlSerializer = New MyXmlSerializer()

    Private Sub FillTaskList()

        Me.ListBoxCompletedTasks.Items.Clear()
        Me.CheckedListBoxToDoTasks.Items.Clear()

        For Each Task As TodoItem In TaskList
            If Task.TaskIsDone = False Then
                Me.CheckedListBoxToDoTasks.Items.Add(Task)
            Else
                Me.ListBoxCompletedTasks.Items.Add(Task)
            End If
        Next
    End Sub

    Private Sub WriteTasksList()
        serializer.Serialize(Of List(Of TodoItem))(Path, Me.TaskList)
    End Sub

    Private Sub ReadTasksList()
        Me.TaskList = serializer.Deserialize(Of List(Of TodoItem))(Path)
    End Sub

    Private Sub BtNew_Click(sender As Object, e As EventArgs) Handles BtNew.Click, MenuItemNew.Click, NewToolStripMenuItem.Click

        Dim NewTask As TodoItem = New TodoItem() With {
      .Id = Guid.NewGuid(),
      .TaskName = TextBoxNewTask.Text,
      .TaskIsDone = False
        }
        Me.TaskList.Add(NewTask)
        Me.FillTaskList()
        Me.WriteTasksList()
        ' Me.CheckedListBoxToDoTasks.Items.Add(NewTask)

        Me.NotifyIcon1.BalloonTipText = "New Task Has Been Added"
        Me.NotifyIcon1.ShowBalloonTip(2000)

        'TextBoxNewTask.Text = String.Empty
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click, MenuItemEdit.Click, EditToolStripMenuItem.Click
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

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click, MenuItemDelete.Click, DeleteToolStripMenuItem.Click
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
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        TextBoxNewTask.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        TextBoxNewTask.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        TextBoxNewTask.Paste()
    End Sub

    Private Sub FrmNewTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuStrip1.BackColor = My.Settings.PanelColor
        'ToolStrip1.BackColor = My.Settings.FormBackgroundColor
        SplitContainer1.BackColor = My.Settings.FormBackgroundColor
        CheckedListBoxToDoTasks.BackColor = My.Settings.PanelColor
        ListBoxCompletedTasks.BackColor = My.Settings.PanelColor


        TextBoxNewTask.Text = String.Empty

        If System.IO.File.Exists(Path) Then
            Me.ReadTasksList()
        End If
        Me.FillTaskList()
    End Sub

    Private Sub CheckedListBoxToDoTasks_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBoxToDoTasks.ItemCheck
        'If e.Index = -1 Then
        '    Return
        If e.NewValue = CheckState.Checked Then
            Dim Task As TodoItem = CType(CheckedListBoxToDoTasks.SelectedItem, TodoItem)
            Task.TaskIsDone = True
            Task.TaskCompletedDate = DateTime.Now
            Me.WriteTasksList()

            'CheckedListBoxToDoTasks.Items.Remove(task)
            'ListBoxCompletedTasks.Items.Add(task)

            'Me.FillTaskList()
        End If
    End Sub

    Private Sub CheckedListBoxToDoTasks_MouseUp(sender As Object, e As MouseEventArgs) Handles CheckedListBoxToDoTasks.MouseUp
        If CheckedListBoxToDoTasks.CheckedItems.Count > 0 Then
            Me.FillTaskList()
        End If
    End Sub

    Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuExit1.Click
        Me.Close()
    End Sub
End Class