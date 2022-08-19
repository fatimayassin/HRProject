Public Class FrmNotifications
    Private TaskList As New List(Of TodoItem)
    Private Path As String = Application.StartupPath + "\data.xml"
    Private serializer As MyXmlSerializer = New MyXmlSerializer()

    Private Sub WriteTasksList()
        serializer.Serialize(Of List(Of TodoItem))(Path, Me.TaskList)
    End Sub

    Private Sub ReadTasksList()
        Me.TaskList = serializer.Deserialize(Of List(Of TodoItem))(Path)
    End Sub

    Private Sub FillTaskList()
        Me.ListBox1.Items.Clear()
        For Each Task As TodoItem In TaskList
            If Task.TaskIsDone = False Then
                Dim s As String = "New Task Is Added" + "  " + Task.TaskName + "  " + "@" + Task.TaskDate
                Me.ListBox1.Items.Add(s)
            End If
        Next
    End Sub

    Private Sub FrmNotifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel1.BackColor = My.Settings.PanelColor

        If System.IO.File.Exists(Path) Then
            Me.ReadTasksList()
        End If

        Me.FillTaskList()
    End Sub

    'Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
    '    If ListBox1.SelectedIndex = -1 Then
    '        MessageBox.Show("Please Select a Notify To Clear")
    '        Return
    '    End If
    '    Me.TaskList.Remove(ListBox1.SelectedItem)
    '    Me.FillTaskList()
    '    Me.WriteTasksList()
    'End Sub
End Class