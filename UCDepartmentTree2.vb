Public Class UCDepartmentTree2
    Dim Departments As New List(Of TblDepartment)
    Dim nodeTag As Integer = 0
    Dim LastNode As New TreeNode
    Public employees As Boolean = False

    Sub refreshTree()

        TreeViewDepartments.Nodes.Clear()

        Using aMainor As New LqHRDataContext(cnx)


            Departments = aMainor.TblDepartments.ToList

            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            Dim res = (From ax In aMainor.TblCompanyProfiles).ToList()
            If res.Count > 0 Then
                RootNode.Text = res.ToList(0).Name
            Else
                RootNode.Text = "CompanyName"
            End If

            RootNode.Name = "CompanyName"
            RootNode.ImageIndex = 0

            AddNodeReccursive(RootNode, Departments)
            TreeViewDepartments.Nodes.Add(RootNode)
            TreeViewDepartments.Nodes(0).Expand()

        End Using
        TreeViewDepartments.ExpandAll()
    End Sub

    Private Sub UCDepartmentTree2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = True

        TreeViewDepartments.ContextMenuStrip = ContextMenuStrip1
        For Each ay As TreeNode In TreeViewDepartments.Nodes
            ay.ContextMenuStrip = ContextMenuStrip1
        Next

        refreshTree()
        BtnSearch.BackgroundImageLayout = ImageLayout.Zoom
        If employees = True Then
            'Dim j As New UCEmplyeesPerDepList
            'Panel1.Controls.Add(j)
        Else
            Dim j As New UCEmployeeList
            j.Dock = DockStyle.Fill
            Panel2.Controls.Add(j)
            'Dim f As New UCScheduleForJob
            'Panel2.Controls.Add(f)
        End If
    End Sub


    Sub AddNodeReccursive(ByVal Node As TreeNode, ByVal depart As List(Of TblDepartment))
        If Node.Tag = "0" Then
            For Each aX In (From av In depart Where av.ParentId Is Nothing).ToList
                Dim Child As New TreeNode
                Child.Tag = aX.Id
                Child.Text = aX.Name
                Child.Name = aX.Name
                Child.ImageIndex = 0
                Child.SelectedImageIndex = 0
                AddNodeReccursive(Child, depart)
                Node.Nodes.Add(Child)
            Next
        Else
            For Each aX In (From av In depart Where av.ParentId.ToString = Node.Tag.ToString).ToList
                Dim Child As New TreeNode
                Child.Tag = aX.Id
                Child.Text = aX.Name
                Child.Name = aX.Name
                Child.ImageIndex = 0
                Child.SelectedImageIndex = 0
                AddNodeReccursive(Child, depart)
                Node.Nodes.Add(Child)
            Next
        End If

    End Sub

    Private Sub TreeViewDepartments_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs)
        If e.Button = MouseButtons.Right Then
            TreeViewDepartments.SelectedNode = e.Node
            nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
            ContextMenuStrip1.Show(TreeViewDepartments, e.Location)

            If e.Node.Tag = "0" Then
                AddToolStripMenuItem.Enabled = True
                EditToolStripMenuItem.Enabled = False
                DeleteToolStripMenuItem.Enabled = False
                AddJobToolStripMenuItem.Enabled = False
                AssignJobsToolStripMenuItem.Enabled = False
            Else
                EditToolStripMenuItem.Enabled = True
                AddJobToolStripMenuItem.Enabled = True
                If e.Node.Nodes.Count > 0 Then
                    DeleteToolStripMenuItem.Enabled = False
                    AddToolStripMenuItem.Enabled = True
                    AssignJobsToolStripMenuItem.Enabled = True
                Else
                    DeleteToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim x As New FrmAddDepartment
        x.parentId = nodeTag
        x.ShowDialog()
        If x.Saved Then
            refreshTree()
        End If
        x.Dispose()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim x As New FrmAddDepartment
        x.Id = nodeTag
        x.ShowDialog()
        If x.Saved Then
            refreshTree()
        End If
        x.Dispose()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblJobsPerDepartments Where ax.DepartmentId = nodeTag).ToList
            If res.Count > 0 Then
                MessageBox.Show("This Department Cannot Be Deleted")
            Else
                Dim answer = MessageBox.Show("Do you want to delete this Department?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Dim result = (From ax In aMainor.TblDepartments Where ax.Id = nodeTag).ToList(0)
                    aMainor.TblDepartments.DeleteOnSubmit(result)
                    aMainor.SubmitChanges()
                End If
            End If

        End Using
        refreshTree()
    End Sub

    Private Sub AddJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddJobToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim x As New FrmJobDescription
        x.DepartmentId = nodeTag
        x.ShowDialog()
        If x.saved Then
            refreshJobList()
        End If
        x.Dispose()
    End Sub

    Private Sub AssignJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignJobsToolStripMenuItem.Click
        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim X As New FrmAssigndDepsToJob
        X.DepartmentId = nodeTag
        X.ShowDialog()
        X.Dispose()
    End Sub

    Sub refreshJobList()
        'Panel1.Controls.Clear()
        'Using aMainor As New LqHRDataContext(cnx)
        '    nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)

        '    Dim j As New UCJobDescriptionList
        '    j.DepartmentId = nodeTag

        '    Panel1.Controls.Add(j)
        'End Using
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        ClearBackColor()
        Try
            Dim tn() As TreeNode =
                TreeViewDepartments.Nodes.Find(TextBox1.Text, True)

            Dim i As Integer = 0

            For i = 0 To tn.Length
                LastNode = tn(i)
                TreeViewDepartments.SelectedNode = tn(i)
                TreeViewDepartments.SelectedNode.BackColor = Color.Blue
            Next i
        Catch
            'do nothing
        End Try

    End Sub


    Private Sub ClearBackColor()
        LastNode.BackColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        ClearBackColorDep()
        FindByTextDep()

        'Try
        '    Dim tn() As TreeNode = TreeViewDepartments.Nodes.Find(TextBox1.Text, True)

        '    Dim i As Integer = 0

        '    For i = 0 To tn.Length
        '        LastNode = tn(i)
        '        TreeViewDepartments.SelectedNode = tn(i)
        '        TreeViewDepartments.SelectedNode.BackColor = Color.Blue
        '    Next i

        'Catch
        '    'do nothing
        'End Try


    End Sub

    Private Sub ClearBackColorDep()
        Dim tv As TreeView = TreeViewDepartments

        Dim nodes As TreeNodeCollection
        nodes = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            ClearRecursiveDep(n)
        Next
    End Sub

    Private Sub ClearRecursiveDep(ByVal treeNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In treeNode.Nodes
            tn.BackColor = Color.White
            ClearRecursiveDep(tn)
        Next
    End Sub

    Private Sub FindByTextDep()
        Dim tv As TreeView = TreeViewDepartments


        Dim nodes As TreeNodeCollection = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursiveDep(n)
        Next
    End Sub

    Private Sub FindRecursiveDep(ByVal tNode As TreeNode)
        Dim searchTxt As TextBox = TextBox1
        Dim tv As TreeView = TreeViewDepartments


        If searchTxt.Text = "" Then
            tv.CollapseAll()
            tv.BackColor = Color.White
            'ExpandToLevel(TVTasks.Nodes, 1)
        Else
            Dim tn As TreeNode
            For Each tn In tNode.Nodes
                ' if the text properties match, color the item
                If tn.Text.ToLower.Contains(searchTxt.Text.ToLower) Then
                    tn.BackColor = Color.Blue
                    tn.EnsureVisible()        'Scroll the control to the item
                End If

                FindRecursiveDep(tn)
            Next
        End If
    End Sub


    Private Sub TreeViewDepartments_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewDepartments.AfterSelect
        Panel2.Controls.Clear()
        TreeViewDepartments.SelectedNode = e.Node

        nodeTag = Integer.Parse(TreeViewDepartments.SelectedNode.Tag.ToString)
        Dim j As New UCEmployeeList
        j.Dock = DockStyle.Fill
        j.DepartmentId = nodeTag
        j.listOfStringNodes = GetChildren(e.Node)
        Panel2.Controls.Add(j)
    End Sub

    Function GetChildren(parentNode As TreeNode) As List(Of String)
        Dim nodes As List(Of String) = New List(Of String)
        GetAllChildren(parentNode, nodes)
        Return nodes
    End Function

    Sub GetAllChildren(parentNode As TreeNode, nodes As List(Of String))
        For Each childNode As TreeNode In parentNode.Nodes
            nodes.Add(childNode.Text)
            GetAllChildren(childNode, nodes)
        Next
    End Sub


End Class
