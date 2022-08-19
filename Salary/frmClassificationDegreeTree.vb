Public Class frmClassificationDegreeTree
    Dim degrees As New List(Of TblDegree)
    Dim nodeTag As Integer = 0
    Dim LastNode As New TreeNode
    Public employees As Boolean = False

    Private Sub frmClassificationDegreeTree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        refreshTree()

    End Sub

    Sub refreshTree()
        TreeViewDepartments.Nodes.Clear()
        Using aMainor As New LqHRDataContext(cnx)
            degrees = aMainor.TblDegrees.ToList
            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            RootNode.Text = "CompanyName"
            RootNode.Name = "CompanyName"
            RootNode.ImageIndex = 0
            AddNodeReccursive(RootNode, degrees)
            TreeViewDepartments.Nodes.Add(RootNode)
            TreeViewDepartments.Nodes(0).Expand()
        End Using
        TreeViewDepartments.ExpandAll()
    End Sub



    Sub AddNodeReccursive(ByVal Node As TreeNode, ByVal deg As List(Of TblDegree))
        If Node.Tag = "0" Then
            Using aMainor As New LqHRDataContext(cnx)
                For Each aX In (From av In aMainor.TblClassifications).ToList

                    Dim parent As New TreeNode
                    parent.Tag = aX.Id
                    parent.Text = aX.Name
                    parent.Name = "Classification"
                    AddNodeReccursive(parent, deg)
                    Node.Nodes.Add(parent)

                    For Each ay In (From av In deg Where av.ClassificationId = aX.Id).ToList

                        Dim Child As New TreeNode
                        Child.Tag = ay.Id
                        Child.Text = ay.Name
                        Child.Name = "Child"
                        AddNodeReccursive(Child, deg)
                        parent.Nodes.Add(Child)
                    Next
                Next
            End Using

        End If

    End Sub

    Private Sub AddTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDegreeToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim x As New FrmAddDegree
        x.Classid = nodeTag
        x.ShowDialog()
        If x.saved Then
            refreshTree()
        End If

        x.Dispose()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub TreeViewDepartments_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewDepartments.NodeMouseClick
        TreeViewDepartments.SelectedNode = e.Node
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)

        If e.Button = MouseButtons.Right Then
            ContextMenuStrip.Show(TreeViewDepartments, e.Location)
            If e.Node.Tag = "0" Then
                AddDegreeToolStripMenuItem.Enabled = False
                ToolStripMenuItemAddClass.Enabled = True
                EditToolStripMenuItem.Enabled = False
                DeleteToolStripMenuItem.Enabled = True
            ElseIf e.Node.Name = "Classification" Then

                AddDegreeToolStripMenuItem.Enabled = True
                ToolStripMenuItemAddClass.Enabled = False
                EditToolStripMenuItem.Enabled = True
                DeleteToolStripMenuItem.Enabled = True

            Else
                ToolStripMenuItemAddClass.Enabled = False
                AddDegreeToolStripMenuItem.Enabled = False
                EditToolStripMenuItem.Enabled = True
                DeleteToolStripMenuItem.Enabled = True
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItemAddClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddClass.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim x As New FrmAddClassification
        x.ShowDialog()
        If x.saved Then
            refreshTree()
        End If
        x.Dispose()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        If TreeViewDepartments.SelectedNode.Name = "Classification" Then
            Dim x As New FrmAddClassification
            x.id = nodeTag
            x.ShowDialog()
            If x.saved Then
                refreshTree()
            End If
        Else
            Dim x As New FrmAddDegree
            x.id = nodeTag
            x.ShowDialog()
            If x.saved Then
                refreshTree()
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Using aMainor As New LqHRDataContext(cnx)
            If TreeViewDepartments.SelectedNode.Name = "Classification" Then

                Dim res = (From ax In aMainor.TblDegrees Where ax.ClassificationId = nodeTag).ToList
                If res.Count > 0 Then
                    MessageBox.Show("cannot be deleted")
                Else
                    Dim res2 = (From ax In aMainor.TblClassifications Where ax.Id = nodeTag).ToList(0)
                    aMainor.TblClassifications.DeleteOnSubmit(res2)
                    aMainor.SubmitChanges()
                    refreshTree()
                End If

            Else
                Dim res = (From ax In aMainor.TblDegrees Where ax.Id = nodeTag).ToList(0)
                aMainor.TblDegrees.DeleteOnSubmit(res)
                aMainor.SubmitChanges()
                refreshTree()
            End If
        End Using
    End Sub
End Class