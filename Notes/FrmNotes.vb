Imports System.Resources
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinToolbars

Public Class FrmNotes

    Private Sub FrmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UserNote As New UserNote
        'UltraPanel1.Controls.Add(UserNote)
        'UserNote.Dock = DockStyle.Fill

        Dim taskPaneToolbar = New UltraTaskPaneToolbar("TaskPane") With {
         .DockedPosition = DockedPosition.Left
        }

        taskPaneToolbar.DockedContentExtent = 318
        UltraToolbarsManager1.Toolbars.Add(taskPaneToolbar)

        Dim taskPaneTool1 = New TaskPaneTool("UserNote")

        UltraToolbarsManager1.Tools.Add(taskPaneTool1)

        taskPaneToolbar.Tools.AddTool("UserNote")

        taskPaneTool1.AutoActivateControl = DefaultableBoolean.[True]
        taskPaneToolbar.AllowNavigationViaMenu = DefaultableBoolean.[True]

        Controls.Add(UserNote)
        taskPaneTool1.Control = UserNote
        UserNote.Dock = DockStyle.Fill

    End Sub

End Class