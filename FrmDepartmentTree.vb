Public Class FrmDepartmentTree
    Dim Departments As New List(Of TblDepartment)
    Dim nodeTag As Integer = 0
    Dim LastNode As New TreeNode
    Public jobid As Integer = 0

    Private Sub FrmDepartmentTree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        refreshTree()
        DepartmentTreeChecked()
    End Sub
    Sub refreshTree()

        TreeViewDepartments.Nodes.Clear()

        Using aMainor As New LqHRDataContext(cnx)


            Departments = aMainOr.TblDepartments.ToList

            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            RootNode.Text = "CompanyName"
            RootNode.Name = "CompanyName"
            RootNode.ImageIndex = 0

            AddNodeReccursive(RootNode, Departments)
            TreeViewDepartments.Nodes.Add(RootNode)
            TreeViewDepartments.Nodes(0).Expand()

        End Using
        TreeViewDepartments.ExpandAll()
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

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
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


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim List As New List(Of Integer)
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = jobid).ToList
            aMainor.TblJobsPerDepartments.DeleteAllOnSubmit(res)
            aMainor.SubmitChanges()


        End Using
        For Each aX As TreeNode In TreeViewDepartments.Nodes
            If aX.Checked Then List.Add(aX.Tag)
            For Each aJ As TreeNode In aX.Nodes
                If aJ.Checked Then List.Add(aJ.Tag)
                For Each aY As TreeNode In aJ.Nodes
                    If aY.Checked Then List.Add(aY.Tag)
                    For Each aK As TreeNode In aY.Nodes
                        If aK.Checked Then List.Add(aK.Tag)
                        For Each ap As TreeNode In aK.Nodes
                            If ap.Checked Then List.Add(ap.Tag)
                            For Each aY1 As TreeNode In ap.Nodes
                                If aY1.Checked Then List.Add(aY1.Tag)
                                For Each aK1 As TreeNode In aY1.Nodes
                                    If aK1.Checked Then List.Add(aK1.Tag)
                                    For Each ap1 As TreeNode In aK1.Nodes
                                        If ap1.Checked Then List.Add(ap1.Tag)
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next
        For i As Integer = 0 To List.Count - 1
            Dim jobPerDeps As New TblJobsPerDepartment
            jobPerDeps.JobId = jobid
            jobPerDeps.DepartmentId = List.ToList(i)
            Using aMainor As New LqHRDataContext(cnx)
                aMainor.TblJobsPerDepartments.InsertOnSubmit(jobPerDeps)
                aMainor.SubmitChanges()

            End Using
        Next
        Me.Close()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
    Sub DepartmentTreeChecked()
        Using aMainor As New LqHRDataContext(cnx)
            Dim tv As TreeView = TreeViewDepartments
            Dim nodes As TreeNodeCollection = tv.Nodes

            For Each n As TreeNode In nodes
                ClearRecursive(n)
            Next
            For Each n In nodes
                markNode(n)
            Next
        End Using
    End Sub

    Private Sub ClearRecursive(ByVal treeNode As TreeNode)

        For Each tn As TreeNode In treeNode.Nodes
            tn.BackColor = Color.White
            tn.Checked = False
            ClearRecursive(tn)
        Next
    End Sub
    Private Sub markNode(ByVal treeNode As TreeNode)
        Using aMainor As New LqHRDataContext(cnx)

            Dim res As List(Of Integer?) = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = JobId Select ax.DepartmentId).ToList

            For Each tn As TreeNode In treeNode.Nodes
                If res.Contains(Integer.Parse(tn.Tag)) Then
                    tn.BackColor = Color.Blue
                    tn.Checked = True
                End If
                markNode(tn)
            Next



        End Using
    End Sub
End Class