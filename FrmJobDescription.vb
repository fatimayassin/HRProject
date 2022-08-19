Public Class FrmJobDescription
    Public id As Integer = 0
    Dim task As New List(Of TblTask)
    Dim nodeTag As Integer = 0
    Dim Requirement As New List(Of TblRequirement)
    Public saved As Boolean = False
    Dim type As String = ""
    Public loaded As Boolean = False
    Dim JobsList As List(Of Integer)
    Dim Edit As Boolean = False
    Public Count As Integer = 0
    Dim Departments As New List(Of TblDepartment)
    Public DepartmentId As Integer = 0
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmJobDescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            refreshJobsList()
            Count = 0

            TblRequiredHoursForJobBindingSource.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblJobDescriptionBindingSource1.DataSource = aMainor.TblJobDescriptions.ToList
            TblJobCategoryBindingSource.DataSource = aMainor.TblJobCategories.ToList
            TblClassificationBindingSource.DataSource = aMainor.TblClassifications.ToList
            refreshTreeTasks()
            refreshTreereq()
            refreshTree()

            If DepartmentId > 0 Then  ''''' if add job is clicked from the tree of departments, this dep should be checked at load '''''
                AddNew()
                Dim tv As TreeView = DepartmentTreeView
                Dim nodes As TreeNodeCollection = tv.Nodes

                For Each n In nodes
                    mar(n)
                Next
            Else
                refreshjobs()

            End If

            'refreshTreeTasks()
            'refreshTreereq()
            'If id = 0 Then
            '    TblJobDescriptionBindingSource.DataSource = New TblJobDescription
            'Else
            '    TblJobDescriptionBindingSource.DataSource = (From ax In aMainor.TblJobDescriptions Where ax.Id = id).ToList(0)
            '    TreeViewChecked(True)
            '    TreeViewChecked(False)
            'End If

        End Using
        loaded = True
    End Sub
    Sub mar(ByVal treeNode As TreeNode)

        Using aMainor As New LqHRDataContext(cnx)


            For Each tn As TreeNode In treeNode.Nodes
                If Integer.Parse(tn.Tag) = DepartmentId Then
                    tn.BackColor = Color.Blue
                    tn.Checked = True
                End If
                mar(tn)
            Next

        End Using

    End Sub


    Sub refreshTree()
        DepartmentTreeView.Nodes.Clear()
        Using aMainor As New LqHRDataContext(cnx)
            Departments = aMainor.TblDepartments.ToList
            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            RootNode.Text = "CompanyName"
            RootNode.Name = "CompanyName"
            RootNode.ImageIndex = 0

            AddNodeReccursive(RootNode, Departments)
            DepartmentTreeView.Nodes.Add(RootNode)
            DepartmentTreeView.Nodes(0).Expand()
        End Using
        DepartmentTreeView.ExpandAll()
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

    Sub DepartmentTreeChecked()
        Using aMainor As New LqHRDataContext(cnx)
            Dim tv As TreeView = DepartmentTreeView
            Dim nodes As TreeNodeCollection = tv.Nodes

            For Each n As TreeNode In nodes
                ClearRecursive1(n)
            Next
            For Each n In nodes
                markNode(n)
            Next
            'If id > 0 Then
            '    Dim JobId As Integer = id
            '    Dim res As List(Of Integer?) = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = JobId Select ax.DepartmentId).ToList

            '    For Each aX As TreeNode In DepartmentTreeView.Nodes
            '        If res.Contains(Integer.Parse(aX.Tag)) Then
            '            aX.BackColor = Color.Blue
            '            aX.Checked = True
            '        End If
            '        For Each aJ As TreeNode In aX.Nodes
            '            If res.Contains(Integer.Parse(aJ.Tag)) Then
            '                aJ.BackColor = Color.Blue
            '                aJ.Checked = True
            '            End If
            '            For Each aY As TreeNode In aJ.Nodes
            '                If res.Contains(Integer.Parse(aY.Tag)) Then
            '                    aY.BackColor = Color.Blue
            '                    aY.Checked = True
            '                End If

            '                For Each aK As TreeNode In aY.Nodes
            '                    If res.Contains(Integer.Parse(aK.Tag)) Then
            '                        aK.BackColor = Color.Blue
            '                        aK.Checked = True
            '                    End If
            '                    For Each ap As TreeNode In aK.Nodes
            '                        If res.Contains(Integer.Parse(ap.Tag)) Then
            '                            ap.BackColor = Color.Blue
            '                            ap.Checked = True
            '                        End If
            '                        For Each aY1 As TreeNode In ap.Nodes
            '                            If res.Contains(Integer.Parse(aY1.Tag)) Then
            '                                aY1.BackColor = Color.Blue
            '                                aY1.Checked = True
            '                            End If
            '                            For Each aK1 As TreeNode In aY1.Nodes
            '                                If res.Contains(Integer.Parse(aK1.Tag)) Then
            '                                    aK1.BackColor = Color.Blue
            '                                    aK1.Checked = True
            '                                End If
            '                                For Each ap1 As TreeNode In aK1.Nodes
            '                                    If res.Contains(Integer.Parse(ap1.Tag)) Then
            '                                        ap1.BackColor = Color.Blue
            '                                        ap1.Checked = True
            '                                    End If
            '                                Next
            '                            Next
            '                        Next
            '                    Next
            '                Next
            '            Next
            '        Next
            '    Next
            'End If

        End Using
    End Sub


    Private Sub ClearRecursive1(ByVal treeNode As TreeNode)

        For Each tn As TreeNode In treeNode.Nodes
            tn.BackColor = Color.White
            tn.Checked = False
            ClearRecursive1(tn)
        Next

        'For Each aX As TreeNode In DepartmentTreeView.Nodes

        '    aX.BackColor = Color.White
        '    aX.Checked = False
        '    For Each aJ As TreeNode In aX.Nodes
        '        aJ.BackColor = Color.White
        '        aJ.Checked = False
        '        For Each aY As TreeNode In aJ.Nodes

        '            aY.BackColor = Color.White
        '            aY.Checked = False


        '            For Each aK As TreeNode In aY.Nodes

        '                aK.BackColor = Color.White
        '                aK.Checked = False

        '                For Each ap As TreeNode In aK.Nodes

        '                    ap.BackColor = Color.White
        '                    ap.Checked = False

        '                    For Each aY1 As TreeNode In ap.Nodes

        '                        aY1.BackColor = Color.White
        '                        aY1.Checked = False

        '                        For Each aK1 As TreeNode In aY1.Nodes

        '                            aK1.BackColor = Color.White
        '                            aK1.Checked = False

        '                            For Each ap1 As TreeNode In aK1.Nodes

        '                                ap1.BackColor = Color.White
        '                                ap1.Checked = False

        '                            Next
        '                        Next
        '                    Next
        '                Next
        '            Next
        '        Next
        '    Next
        'Next
    End Sub



    Private Sub markNode(ByVal treeNode As TreeNode)
        Using aMainor As New LqHRDataContext(cnx)
            If id > 0 Then
                Dim JobId As Integer = id
                Dim res As List(Of Integer?) = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = JobId Select ax.DepartmentId).ToList


                For Each tn As TreeNode In treeNode.Nodes
                    If res.Contains(Integer.Parse(tn.Tag)) Then
                        tn.BackColor = Color.Blue
                        tn.Checked = True
                    End If
                    markNode(tn)
                Next


            End If
        End Using
    End Sub


    Sub refreshTreeTasks()
        TVTasks.Nodes.Clear()

        Using aMainor As New LqHRDataContext(cnx)
            task = aMainOr.TblTasks.ToList

            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            RootNode.Text = "Tasks"
            RootNode.Name = "Tasks"
            RootNode.ImageIndex = 0
            type = "Tasks"
            AddNodeReccursive(RootNode, task)
            TVTasks.Nodes.Add(RootNode)
            TVTasks.Nodes(0).Expand()

        End Using
        TVTasks.ExpandAll()
    End Sub


    Sub refreshTreereq()
        TVRequirement.Nodes.Clear()

        Using aMainor As New LqHRDataContext(cnx)
            Requirement = aMainOr.TblRequirements.ToList

            Dim RootNode As New TreeNode
            RootNode.Tag = "0"
            RootNode.Text = "Requirements"
            RootNode.Name = "Requirements"
            RootNode.ImageIndex = 0
            type = "Requirements"
            AddNodeReccursiveReq(RootNode, Requirement)
            TVRequirement.Nodes.Add(RootNode)
            TVRequirement.Nodes(0).Expand()

        End Using
        TVRequirement.ExpandAll()
    End Sub

    Sub AddNodeReccursive(ByVal Node As TreeNode, ByVal tsk As List(Of TblTask))

        If Node.Tag = "0" Then
            Using aMainor As New LqHRDataContext(cnx)
                For Each aX In (From av In aMainor.TblCategories).ToList

                    Dim parent As New TreeNode
                    parent.Tag = aX.Id
                    parent.Text = aX.Name
                    parent.Name = "Category"
                    AddNodeReccursive(parent, tsk)
                    Node.Nodes.Add(parent)

                    For Each ay In (From av In tsk Where av.CategoryId = aX.Id).ToList

                        Dim Child As New TreeNode
                        Child.Tag = ay.Id
                        Child.Text = ay.Description
                        Child.Name = ay.Description
                        AddNodeReccursive(Child, tsk)
                        parent.Nodes.Add(Child)
                    Next
                Next
            End Using

        End If
    End Sub

    Sub AddNodeReccursiveReq(ByVal Node As TreeNode, ByVal Req As List(Of TblRequirement))

        Using aMainor As New LqHRDataContext(cnx)
            If Node.Tag = "0" Then
                For Each aX In (From av In aMainOr.TblTypes).ToList
                    Dim parent As New TreeNode
                    parent.Tag = aX.Id
                    parent.Text = aX.Name
                    parent.Name = "Type"
                    parent.ImageIndex = 0
                    parent.SelectedImageIndex = 0
                    AddNodeReccursiveReq(parent, Req)
                    Node.Nodes.Add(parent)

                    For Each ay In (From av In Req Where av.TypeId = aX.Id).ToList
                        Dim Child As New TreeNode
                        Child.Tag = ay.Id
                        Child.Text = ay.Description
                        Child.Name = ay.Description
                        Child.ImageIndex = 0
                        Child.SelectedImageIndex = 0
                        AddNodeReccursiveReq(Child, Req)
                        parent.Nodes.Add(Child)

                    Next
                Next
            Else
            End If
        End Using
    End Sub


    Private Sub TVRequirement_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TVRequirement.NodeMouseClick
        TVRequirement.SelectedNode = e.Node
        nodeTag = Integer.Parse(TVRequirement.SelectedNode.Tag.ToString)

        If e.Button = MouseButtons.Right Then
            ContextMenuStripReq.Show(TVRequirement, e.Location)

            If e.Node.Tag = "0" Then
                AddRequirementToolStripMenuItem.Enabled = False
                AddReqTypeToolStripMenuItem.Enabled = True

                IsPrimaryToolStripMenuItem.Enabled = False
            Else
                If e.Node.Name = "Type" Then
                    AddRequirementToolStripMenuItem.Enabled = True
                    AddReqTypeToolStripMenuItem.Enabled = False
                    IsPrimaryToolStripMenuItem.Enabled = False
                Else
                    AddRequirementToolStripMenuItem.Enabled = False
                    AddReqTypeToolStripMenuItem.Enabled = False
                    IsPrimaryToolStripMenuItem.Enabled = True
                End If
            End If
        End If

    End Sub

    Private Sub AddReqTypeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddReqTypeToolStripMenuItem.Click
        Dim x As New FrmType
        x.ShowDialog()
        If x.saved Then
            refreshTreereq()
        End If

        x.Dispose()
    End Sub

    Private Sub AddRequirementToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddRequirementToolStripMenuItem.Click
        nodeTag = Integer.Parse(TVRequirement.SelectedNode.Tag.ToString)
        Dim x As New FrmRequirement
        x.typeId = nodeTag
        x.ShowDialog()
        If x.saved Then
            refreshTreereq()
        End If

        x.Dispose()
    End Sub

    Private Sub IsPrimaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles IsPrimaryToolStripMenuItem.Click

        Dim node As TreeNode = TVRequirement.SelectedNode
        nodeTag = Integer.Parse(TVRequirement.SelectedNode.Tag.ToString)
        If node.ImageIndex = 1 Then
            node.ImageIndex = 0
            node.SelectedImageIndex = 0
        Else
            node.ImageIndex = 1
            node.SelectedImageIndex = 1
            node.Checked = True
        End If

    End Sub


    Private Sub TVTasks_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TVTasks.NodeMouseClick
        TVTasks.SelectedNode = e.Node
        nodeTag = Integer.Parse(TVTasks.SelectedNode.Tag.ToString)

        If e.Button = MouseButtons.Right Then
            ContextMenuStripTasks.Show(TVTasks, e.Location)

            If e.Node.Tag = "0" Then
                AddTaskToolStripMenuItem.Enabled = False
                AddCategoryToolStripMenuItem.Enabled = True
                RequiredForAppraisalToolStripMenuItem.Enabled = False
                RequiredForJobToolStripMenuItem.Enabled = False
                RequiredForBothToolStripMenuItem.Enabled = False

            Else
                If e.Node.Name = "Category" Then
                    AddTaskToolStripMenuItem.Enabled = True
                    AddCategoryToolStripMenuItem.Enabled = True
                    RequiredForAppraisalToolStripMenuItem.Enabled = False
                    RequiredForJobToolStripMenuItem.Enabled = False
                    RequiredForBothToolStripMenuItem.Enabled = False
                Else
                    AddTaskToolStripMenuItem.Enabled = False
                    AddCategoryToolStripMenuItem.Enabled = False
                    RequiredForAppraisalToolStripMenuItem.Enabled = True
                    RequiredForJobToolStripMenuItem.Enabled = True
                    RequiredForBothToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub AddCategoryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddCategoryToolStripMenuItem.Click
        Dim x As New FrmCategoryList
        x.ShowDialog()
        'If x.Saved Then
        refreshTreeTasks()

        x.Dispose()
        'End If
    End Sub

    Private Sub AddTaskToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddTaskToolStripMenuItem.Click
        nodeTag = Integer.Parse(TVTasks.SelectedNode.Tag.ToString)
        Dim x As New FrmTask
        x.categoryId = nodeTag
        x.ShowDialog()
        If x.saved Then
            refreshTreeTasks()
        End If

        x.Dispose()
    End Sub





    Sub TreeViewChecked(ByVal isTask As Boolean)
        Dim tv As New TreeView
        Dim items
        Dim isp
        Dim ReqForJob
        Dim ReqForBoth
        Dim reqForApp
        Using aMainor As New LqHRDataContext(cnx)
            If isTask Then
                tv = TVTasks
                items = (From aX In aMainor.TblJobTasks Where aX.JobId = id Select aX.TaskId).ToList
                ReqForJob = (From aX In aMainor.TblJobTasks Where aX.JobId = id Select aX.RequiredForJob).ToList
                reqForApp = (From aX In aMainor.TblJobTasks Where aX.JobId = id Select aX.RequiredForAppraisal).ToList
            Else
                tv = TVRequirement
                items = (From aX In aMainor.TblJobRequirements Where aX.JobId = id Select aX.RequirementId).ToList
                isp = (From aX In aMainor.TblJobRequirements Where aX.JobId = id Select aX.IsPrimary).ToList
            End If

            For Each aX As TreeNode In tv.Nodes
                aX.Checked = False
                For Each aJ As TreeNode In aX.Nodes
                    aJ.Checked = False
                    For Each aY As TreeNode In aJ.Nodes
                        aY.Checked = False
                    Next
                Next
            Next

            For Each aX As TreeNode In tv.Nodes
                If items.Contains(aX.Tag) Then aX.Checked = True
                For Each aJ As TreeNode In aX.Nodes
                    'If items.Contains(aJ.Tag) Then aJ.Checked = True
                    Dim checkedCount As Integer = 0
                    For Each aY As TreeNode In aJ.Nodes
                        If items.Contains(aY.Tag) Then
                            aY.Checked = True
                            checkedCount += 1
                            If Not isTask Then
                                If isp.item(items.indexof(aY.Tag)) Then
                                    aY.ImageIndex = 1
                                    aY.SelectedImageIndex = 1
                                Else
                                    aY.ImageIndex = 0
                                    aY.SelectedImageIndex = 0
                                End If
                            Else
                                If ReqForJob.item(items.indexof(aY.Tag)) And reqForApp.item(items.indexof(aY.Tag)) Then
                                    aY.ImageIndex = 3
                                    aY.SelectedImageIndex = 3
                                ElseIf ReqForJob.item(items.indexof(aY.Tag)) Then
                                    aY.ImageIndex = 1
                                    aY.SelectedImageIndex = 1
                                ElseIf reqForApp.item(items.indexof(aY.Tag)) Then
                                    aY.ImageIndex = 2
                                    aY.SelectedImageIndex = 2
                                Else
                                    aY.ImageIndex = 0
                                    aY.SelectedImageIndex = 0
                                End If

                            End If
                        End If
                        If checkedCount = aJ.Nodes.Count Then
                            aJ.Checked = True
                        End If
                    Next
                Next
            Next
        End Using
    End Sub


    Sub checkAll(ByVal treeview As TreeView)
        If loaded Then

            Dim tv As TreeView = treeview

            For Each aX As TreeNode In tv.Nodes
                For Each aJ As TreeNode In aX.Nodes
                    If aJ.Checked Then
                        For Each aY As TreeNode In aJ.Nodes
                            If Not aY.Checked Then
                                aY.Checked = True
                            End If
                        Next

                    End If
                Next
            Next
        End If

    End Sub


    Private Sub SearchTask_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchTask.TextChanged
        ClearBackColor(True)
        FindByText(True)

    End Sub

    Private Sub SearchRequirement_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchRequirement.TextChanged
        ClearBackColor(False)
        FindByText(False)
    End Sub


    Private Sub FindByText(ByVal isTask As Boolean)
        Dim tv As TreeView
        If isTask Then
            tv = TVTasks
        Else
            tv = TVRequirement
        End If

        Dim nodes As TreeNodeCollection = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursive(n, isTask)
        Next
    End Sub

    Private Sub FindRecursive(ByVal tNode As TreeNode, ByVal isTask As Boolean)
        Dim searchTxt As TextBox
        Dim tv As TreeView

        If isTask Then
            searchTxt = SearchTask
            tv = TVTasks
        Else
            searchTxt = SearchRequirement
            tv = TVRequirement
        End If

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

                FindRecursive(tn, isTask)
            Next
        End If
    End Sub

    Private Sub ClearBackColor(ByVal isTask As Boolean)
        Dim tv As TreeView
        If isTask Then
            tv = TVTasks
        Else
            tv = TVRequirement
        End If
        Dim nodes As TreeNodeCollection
        nodes = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            ClearRecursive(n)
        Next
    End Sub

    Private Sub ClearRecursive(ByVal treeNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In treeNode.Nodes
            tn.BackColor = Color.White
            ClearRecursive(tn)
        Next
    End Sub


    Private Sub TVTasks_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVTasks.AfterCheck
        'when check/un a node all its children checked/uncheked
        Dim Pnode As TreeNode = e.Node
        For Each cnode As TreeNode In Pnode.Nodes
            cnode.Checked = Pnode.Checked
        Next

        ' when all child nodes are checked/unchecked, the parent should be checked/unchecked
        Dim PPnode As TreeNode = Pnode.Parent
        If PPnode Is Nothing Then
            Exit Sub
        End If
        If Pnode.Checked = True Then
            While PPnode IsNot Nothing
                RemoveHandler PPnode.TreeView.AfterCheck, AddressOf TVTasks_AfterCheck
                PPnode.Checked = True
                AddHandler PPnode.TreeView.AfterCheck, AddressOf TVTasks_AfterCheck
                PPnode = PPnode.Parent
            End While
        Else
            UncheckParentTask(PPnode)
        End If
    End Sub

    Public Sub UncheckParentTask(ByVal PPnode As TreeNode)
        If PPnode Is Nothing Then
            Exit Sub
        End If
        For Each node As TreeNode In PPnode.Nodes
            If node.Checked <> False Then
                'there is a different status node 
                Exit Sub
            End If
        Next
        RemoveHandler PPnode.TreeView.AfterCheck, AddressOf TVTasks_AfterCheck
        PPnode.Checked = False
        AddHandler PPnode.TreeView.AfterCheck, AddressOf TVTasks_AfterCheck
        'check the initial node
        UncheckParentTask(PPnode.Parent)

    End Sub

    Private Sub TVRequirement_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVRequirement.AfterCheck
        'when check/un a node all its children checked/uncheked
        Dim Pnode As TreeNode = e.Node
        For Each cnode As TreeNode In Pnode.Nodes
            cnode.Checked = Pnode.Checked
        Next

        ' when all child nodes are checked/unchecked, the parent should be checked/unchecked
        Dim PPnode As TreeNode = Pnode.Parent
        If PPnode Is Nothing Then
            Exit Sub
        End If
        If Pnode.Checked = True Then
            While PPnode IsNot Nothing
                RemoveHandler PPnode.TreeView.AfterCheck, AddressOf TVRequirement_AfterCheck
                PPnode.Checked = True
                AddHandler PPnode.TreeView.AfterCheck, AddressOf TVRequirement_AfterCheck
                PPnode = PPnode.Parent
            End While
        Else
            UncheckParentReq(PPnode)
        End If
    End Sub

    Public Sub UncheckParentReq(ByVal PPnode As TreeNode)
        If PPnode Is Nothing Then
            Exit Sub
        End If
        For Each node As TreeNode In PPnode.Nodes
            If node.Checked <> False Then
                'there is a different status node 
                Exit Sub
            End If
        Next
        RemoveHandler PPnode.TreeView.AfterCheck, AddressOf TVRequirement_AfterCheck
        PPnode.Checked = False
        AddHandler PPnode.TreeView.AfterCheck, AddressOf TVRequirement_AfterCheck
        'check the initial node
        UncheckParentReq(PPnode.Parent)

    End Sub



    Private Sub RequiredForJobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequiredForJobToolStripMenuItem.Click
        Dim node As TreeNode = TVTasks.SelectedNode
        nodeTag = Integer.Parse(TVTasks.SelectedNode.Tag.ToString)
        If node.ImageIndex = 1 Then
            node.ImageIndex = 0
            node.SelectedImageIndex = 0

        Else
            node.ImageIndex = 1
            node.SelectedImageIndex = 1
            node.Checked = True
        End If
    End Sub

    Private Sub RequiredForAppraisalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequiredForAppraisalToolStripMenuItem.Click
        Dim node As TreeNode = TVTasks.SelectedNode
        nodeTag = Integer.Parse(TVTasks.SelectedNode.Tag.ToString)
        If node.ImageIndex = 2 Then
            node.ImageIndex = 0
            node.SelectedImageIndex = 0
        Else
            node.ImageIndex = 2
            node.SelectedImageIndex = 2
            node.Checked = True
        End If
    End Sub




    Private Sub RequiredForBothToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequiredForBothToolStripMenuItem.Click
        Dim node As TreeNode = TVTasks.SelectedNode
        nodeTag = Integer.Parse(TVTasks.SelectedNode.Tag.ToString)
        If node.ImageIndex = 3 Then
            node.ImageIndex = 0
            node.SelectedImageIndex = 0
        Else
            node.ImageIndex = 3
            node.SelectedImageIndex = 3
            node.Checked = True
        End If
    End Sub

    Private Sub PBSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSave.Click
        PBSave.Focus()

        If NameTextBox.Text = "" Or ClassificantionIdComboBox.SelectedValue = Nothing Then 'Or SupervisorIdComboBox.SelectedValue = Nothing
            MessageBox.Show("missing information", "warning", MessageBoxButtons.OK)
        Else
            Using aMainor As New LqHRDataContext(cnx)

                If id = 0 Then
                    Dim res = aMainor.TblJobDescriptions.ToList
                    If res.Count > 0 Then
                        Dim maxCode As Double = (From ax In aMainor.TblJobDescriptions Select ax.JobNumber).Max
                        TblJobDescriptionBindingSource.Current.JobNumber = maxCode + 1
                    Else
                        Dim year As Integer = Date.Now.Year
                        TblJobDescriptionBindingSource.Current.JobNumber = year * 10000 + 1
                    End If

                    aMainor.TblJobDescriptions.InsertOnSubmit(TblJobDescriptionBindingSource.Current)
                    aMainor.SubmitChanges()
                    id = TblJobDescriptionBindingSource.Current.ID

                    '''''''''save tasks ''''''''''
                    Dim tasks As New List(Of Integer)
                    Dim RequiredForJob As New List(Of Boolean)
                    Dim RequiredForAppraisal As New List(Of Boolean)
                    For Each aX As TreeNode In TVTasks.Nodes
                        'If aX.Checked Then tasks.Add(aX.Tag)
                        For Each aJ As TreeNode In aX.Nodes
                            'If aJ.Checked Then tasks.Add(aJ.Tag)
                            For Each aY As TreeNode In aJ.Nodes
                                If aY.Checked Then
                                    tasks.Add(aY.Tag)
                                    If aY.ImageIndex = 0 Then

                                        RequiredForJob.Add(False)
                                        RequiredForAppraisal.Add(False)

                                    ElseIf aY.ImageIndex = 1 Then
                                        RequiredForJob.Add(True)
                                        RequiredForAppraisal.Add(False)
                                    ElseIf aY.ImageIndex = 2 Then
                                        RequiredForJob.Add(False)
                                        RequiredForAppraisal.Add(True)
                                    ElseIf aY.ImageIndex = 3 Then
                                        RequiredForJob.Add(True)
                                        RequiredForAppraisal.Add(True)

                                    End If
                                End If

                            Next
                        Next
                    Next

                    For Each aX In tasks
                        Dim x As New TblJobTask
                        x.JobId = id
                        x.TaskId = aX
                        If RequiredForJob.Count > 0 Then
                            x.RequiredForJob = RequiredForJob.Item(tasks.IndexOf(aX))
                        End If
                        If RequiredForAppraisal.Count > 0 Then
                            x.RequiredForAppraisal = RequiredForAppraisal.Item(tasks.IndexOf(aX))
                        End If

                        aMainor.TblJobTasks.InsertOnSubmit(x)
                        aMainor.SubmitChanges()
                    Next
                    '''''''''''''''''save requirements'''''''''''''

                    Dim Requirements As New List(Of Integer)
                    Dim Primary As New List(Of Boolean)
                    For Each aX As TreeNode In TVRequirement.Nodes
                        'If aX.Checked Then tasks.Add(aX.Tag)
                        For Each aJ As TreeNode In aX.Nodes
                            'If aJ.Checked Then tasks.Add(aJ.Tag)
                            For Each aY As TreeNode In aJ.Nodes
                                If aY.Checked Then
                                    Requirements.Add(aY.Tag)

                                    If aY.ImageIndex = 0 Then
                                        Primary.Add(False)
                                    Else
                                        Primary.Add(True)
                                    End If
                                End If
                            Next
                        Next
                    Next

                    For Each aX In Requirements
                        Dim x As New TblJobRequirement
                        x.JobId = id
                        x.RequirementId = aX
                        x.IsPrimary = Primary.Item(Requirements.IndexOf(aX))
                        aMainor.TblJobRequirements.InsertOnSubmit(x)
                        aMainor.SubmitChanges()
                    Next




                Else
                    Dim oldrow As TblJobDescription = (From ax In aMainor.TblJobDescriptions Where ax.Id = id).ToList(0)
                    Dim newRow As TblJobDescription = TblJobDescriptionBindingSource.Current
                    oldrow.ArabicName = newRow.ArabicName
                    oldrow.Name = newRow.Name
                    oldrow.DefaultCardLabelName = newRow.DefaultCardLabelName
                    oldrow.DefaultJobNameForCard = newRow.DefaultJobNameForCard
                    oldrow.DefaultJobNameForCardFemale = newRow.DefaultJobNameForCardFemale
                    oldrow.JobCategoryId = newRow.JobCategoryId
                    oldrow.RequiredHoursForJobId = newRow.RequiredHoursForJobId
                    oldrow.ScheduleDepId = newRow.ScheduleDepId
                    oldrow.ClassificantionId = newRow.ClassificantionId
                    oldrow.SupervisorId = newRow.SupervisorId
                    aMainor.SubmitChanges()


                    ''''''''save Tasks'''''''''''
                    aMainor.TblJobTasks.DeleteAllOnSubmit((From aX In aMainor.TblJobTasks Where aX.JobId = id).ToList)
                    aMainor.SubmitChanges()


                    Dim tasks As New List(Of Integer)
                    Dim RequiredForJob As New List(Of Boolean)
                    Dim RequiredForAppraisal As New List(Of Boolean)

                    For Each aX As TreeNode In TVTasks.Nodes
                        'If aX.Checked Then tasks.Add(aX.Tag)
                        For Each aJ As TreeNode In aX.Nodes
                            'If aJ.Checked Then tasks.Add(aJ.Tag)
                            For Each aY As TreeNode In aJ.Nodes
                                If aY.Checked Then
                                    tasks.Add(aY.Tag)
                                    If aY.ImageIndex = 0 Then

                                        RequiredForJob.Add(False)
                                        RequiredForAppraisal.Add(False)

                                    ElseIf aY.ImageIndex = 1 Then
                                        RequiredForJob.Add(True)
                                        RequiredForAppraisal.Add(False)
                                    ElseIf aY.ImageIndex = 2 Then
                                        RequiredForJob.Add(False)
                                        RequiredForAppraisal.Add(True)
                                    ElseIf aY.ImageIndex = 3 Then
                                        RequiredForJob.Add(True)
                                        RequiredForAppraisal.Add(True)

                                    End If
                                End If

                            Next
                        Next
                    Next

                    For Each aX In tasks
                        Dim x As New TblJobTask
                        x.JobId = id
                        x.TaskId = aX
                        If RequiredForJob.Count > 0 Then
                            x.RequiredForJob = RequiredForJob.Item(tasks.IndexOf(aX))
                        End If
                        If RequiredForAppraisal.Count > 0 Then
                            x.RequiredForAppraisal = RequiredForAppraisal.Item(tasks.IndexOf(aX))
                        End If

                        aMainor.TblJobTasks.InsertOnSubmit(x)
                        aMainor.SubmitChanges()
                    Next


                    ''''''''save requirements'''''''''''
                    aMainor.TblJobRequirements.DeleteAllOnSubmit((From aX In aMainor.TblJobRequirements Where aX.JobId = id).ToList)
                    aMainor.SubmitChanges()

                    Dim Requirements As New List(Of Integer)
                    Dim Primary As New List(Of Boolean)
                    For Each aX As TreeNode In TVRequirement.Nodes
                        'If aX.Checked Then tasks.Add(aX.Tag)
                        For Each aJ As TreeNode In aX.Nodes
                            'If aJ.Checked Then tasks.Add(aJ.Tag)
                            For Each aY As TreeNode In aJ.Nodes
                                If aY.Checked Then
                                    Requirements.Add(aY.Tag)

                                    If aY.ImageIndex = 0 Then
                                        Primary.Add(False)
                                    Else
                                        Primary.Add(True)
                                    End If
                                End If
                            Next
                        Next
                    Next


                    For Each aX In Requirements
                        Dim x As New TblJobRequirement
                        x.JobId = id
                        x.RequirementId = aX
                        x.IsPrimary = Primary.Item(Requirements.IndexOf(aX))
                        aMainor.TblJobRequirements.InsertOnSubmit(x)
                        aMainor.SubmitChanges()
                    Next


                End If
                ''''''''''''''''''''''''''''save departments for this job ''''''''''''''''''''''''''''''''''''

                Dim List As New List(Of Integer)

                For Each aX As TreeNode In DepartmentTreeView.Nodes
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
                Dim res1 = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = id).ToList
                If res1.Count > 0 Then
                    aMainor.TblJobsPerDepartments.DeleteAllOnSubmit(res1)
                    aMainor.SubmitChanges()


                End If

                For i As Integer = 0 To List.Count - 1
                    Dim depId As Integer = List.ToList(i)

                    Dim JobsPerDep As New TblJobsPerDepartment
                    JobsPerDep.DepartmentId = depId
                    JobsPerDep.JobId = id

                    aMainor.TblJobsPerDepartments.InsertOnSubmit(JobsPerDep)
                    aMainor.SubmitChanges()


                Next

                saved = True
                saved = True
                id = TblJobDescriptionBindingSource.Current.id
                Edit = False
                PBSave.Visible = False

                PBEdit.Visible = True
                PBAdd.Visible = True

                PBBack.Enabled = True
                PBNext.Enabled = True
                PBFirst.Enabled = True
                PBLast.Enabled = True

                PBSearch.Enabled = True



                refreshJobsList()
                refreshjobs()
                EnableComponents(False)

            End Using
        End If
        Edit = False
    End Sub
    Sub EnableComponents(ByVal enable As Boolean)


        NameTextBox.ReadOnly = Not enable
        ArabicNameTextBox.ReadOnly = Not enable
        JobCategoryIdComboBox.Enabled = enable
        ClassificantionIdComboBox.Enabled = enable
        SupervisorIdComboBox.Enabled = enable
        ScheduleDepIdComboBox.Enabled = enable
        RequiredHoursForJobIdComboBox.Enabled = enable
        DefaultCardLabelNameTextBox.ReadOnly = Not enable
        DefaultJobNameForCardTextBox.ReadOnly = Not enable
        DefaultJobNameForCardFemaleTextBox.ReadOnly = Not enable
        TVRequirement.Enabled = enable
        TVTasks.Enabled = enable
        DepartmentTreeView.Enabled = enable
        PBFirst.Enabled = Not enable
        PBNext.Enabled = Not enable
        PBLast.Enabled = Not enable
        PBBack.Enabled = Not enable
        PBEdit.Enabled = Not enable
        PBDelete.Enabled = Not enable
        PBAdd.Enabled = Not enable
        PBSave.Enabled = enable
        PBSearch.Enabled = Not enable



    End Sub

    Sub refreshJobsList()
        Using aMainor As New LqHRDataContext(cnx)

            JobsList = (From ax In aMainor.TblJobDescriptions Select ax.Id).ToList()
            If JobsList.Count > 0 Then
                If id = 0 Then
                    id = JobsList(0)
                End If
            Else
                AddNew()
            End If

        End Using
    End Sub

    Sub refreshjobs()

        Using aMainor As New LqHRDataContext(cnx)
            TblJobDescriptionBindingSource1.DataSource = (From ax In aMainor.TblJobDescriptions Order By ax.Name).ToList
            If id = 0 Then
                If Not JobsList.Count = 0 Then
                    id = JobsList(Count)
                    refreshjobs()
                End If
                'BtnAssign.Visible = False
            Else
                EnableComponents(False)
                TblJobDescriptionBindingSource.DataSource = (From ax In aMainOr.TblJobDescriptions Where ax.Id = id).ToList(0)
                TreeViewChecked(True)
                TreeViewChecked(False)
                DepartmentTreeChecked()

            End If


        End Using
    End Sub

    Private Sub PBFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFirst.Click
        If JobsList.Count > 0 Then


            Count = 0

            id = JobsList(Count)
            refreshjobs()
        End If
    End Sub

    Private Sub PBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBack.Click

        If JobsList.Count > 0 Then


            'EnableComponents(False)

            Count -= 1
            If Count = 0 Or Count = -1 Then
                Count = JobsList.Count
                id = JobsList(Count - 1)
                refreshjobs()
            Else

                id = JobsList(Count)
                refreshjobs()
            End If
        End If
    End Sub

    Private Sub PBNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBNext.Click

        If JobsList.Count > 0 Then

            ' EnableComponents(False)

            Count += 1

            If Count = JobsList.Count + 1 Or Count = JobsList.Count Then
                Count = 0
                id = JobsList(Count)
                refreshjobs()
            Else
                id = JobsList(Count)
                refreshjobs()
            End If
        End If
    End Sub

    Private Sub PBLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLast.Click


        If JobsList.Count > 0 Then
            Count = JobsList.Count
            id = JobsList(Count - 1)
            refreshjobs()
        End If
    End Sub

    Private Sub PBAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAdd.Click
        AddNew()
    End Sub
    Sub AddNew()
        id = 0
        TblJobDescriptionBindingSource.DataSource = New TblJobDescription
        EnableComponents(True)
        'ClearBackColorDep()

        Using aMainor As New LqHRDataContext(cnx)
            Dim d As Double = Double.Parse(Today.ToString("yyyy"))
            Dim maxNb = (From aX In aMainOr.TblApplicants Where Convert.ToString(aX.ApplicantNumber).StartsWith(Convert.ToString(d)) Select aX.ApplicantNumber).Max()

        End Using
        refreshTree()
        refreshTreeTasks()
        refreshTreereq()

        PBEdit.Visible = False
        PBAdd.Visible = False
        'PBCancel.Visible = True
        PBSave.Visible = True
        'BtnAssign.Visible = False

    End Sub

    Private Sub PBEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEdit.Click
        EnableComponents(True)

        PBEdit.Visible = False
        PBAdd.Visible = False

        PBSave.Visible = True

        PBBack.Enabled = False
        PBNext.Enabled = False
        PBFirst.Enabled = False
        PBLast.Enabled = False
        'PBExit.Enabled = False
        PBSearch.Enabled = False
    End Sub

    Private Sub PBDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBDelete.Click
        Dim answer = MessageBox.Show("Are you sure you want to delete this job!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)

                Dim result = (From aX In aMainOR.TblJobDescriptions Where aX.Id = id).ToList(0)
                If result.TblEmployeeJobs.Count > 0 Then
                    MessageBox.Show("Job taken by employee")
                End If
                Dim res2 = (From ax In aMainOR.TblJobRequirements Where ax.JobId = id).ToList
                aMainOR.TblJobRequirements.DeleteAllOnSubmit(res2)
                aMainOR.SubmitChanges()
                Dim res3 = (From ax In aMainOR.TblJobTasks Where ax.JobId = id).ToList
                aMainOR.TblJobTasks.DeleteAllOnSubmit(res3)
                aMainOR.SubmitChanges()
                Dim res4 = (From ax In aMainOR.TblJobsPerDepartments Where ax.JobId = id).ToList
                aMainOR.TblJobsPerDepartments.DeleteAllOnSubmit(res4)
                aMainOR.SubmitChanges()



                aMainOR.TblJobDescriptions.DeleteOnSubmit(result)
                aMainOR.SubmitChanges()

                PBNext_Click(sender, e)
                refreshJobsList()
                refreshjobs()
                EnableComponents(False)
            End Using
        End If
    End Sub



    Private Sub PBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSearch.Click
        Dim x As New FrmAssigndDepsToJob
        x.ShowDialog()
        If x.saved Then
            id = x.id
            refreshjobs()
        End If

        x.Dispose()
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        ClearBackColorDep()
        FindByTextDep()
    End Sub
    Private Sub ClearBackColorDep()
        Dim tv As TreeView = DepartmentTreeView

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
        Dim tv As TreeView = DepartmentTreeView


        Dim nodes As TreeNodeCollection = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursiveDep(n)
        Next
    End Sub

    Private Sub FindRecursiveDep(ByVal tNode As TreeNode)
        Dim searchTxt As TextBox = SearchTextBox
        Dim tv As TreeView = DepartmentTreeView


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

    Private Sub JobCategoryIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JobCategoryIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmJobCategory
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblJobCategoryBindingSource.DataSource = aMainor.TblJobCategories.ToList
            End Using


            X.Dispose()
        End If
    End Sub

    Private Sub ScheduleDepIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ScheduleDepIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmAddDepartment
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            End Using

            X.Dispose()

        End If
    End Sub

    Private Sub RequiredHoursForJobIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RequiredHoursForJobIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmReqHoursForJob
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblRequiredHoursForJobBindingSource.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            End Using

            X.Dispose()

        End If
    End Sub

    Private Sub ClassificantionIdComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ClassificantionIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New frmClassificationDegreeTree
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblClassificationBindingSource.DataSource = aMainor.TblClassifications.ToList
            End Using


            X.Dispose()
        End If
    End Sub
End Class