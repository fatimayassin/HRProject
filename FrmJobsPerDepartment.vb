Public Class FrmJobsPerDepartment
    Public id As Integer = 0
    Public loaded As Boolean = False
    Dim Departments As New List(Of TblDepartment)
    Dim nodeTag As Integer = 0
    Private Sub FrmJobsPerDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New LqHRDataContext
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblJobCategoryBindingSource.DataSource = aMainor.TblJobCategories.ToList
            TblJobDescriptionBindingSource1.DataSource = aMainor.TblJobDescriptions.ToList
            TblDepartmentBindingSource1.DataSource = aMainor.TblDepartments.ToList
            TblJobDescriptionBindingSource2.DataSource = aMainor.TblJobDescriptions.ToList
            TblJobCategoryBindingSource1.DataSource = aMainor.TblJobCategories.ToList
            TblRequiredHoursForJobBindingSource1.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            TblRequiredHoursForJobBindingSource.DataSource = aMainor.TblRequiredHoursForJobs.ToList
            TblJobDescriptionBindingSource.DataSource = aMainor.TblJobDescriptions.ToList
            TblJobDescriptionBindingSource2.Insert(0, New TblJobDescription)
            TblJobCategoryBindingSource1.Insert(0, New TblJobCategory)
            TblDepartmentBindingSource1.Insert(0, New TblDepartment)
            TblRequiredHoursForJobBindingSource1.Insert(0, New TblRequiredHoursForJob)
            SupervidorIdComboBox.SelectedIndex = 0
            CatIdComboBox.SelectedIndex = 0
            ScheduleIdComboBox.SelectedIndex = 0
            ReqHrsIdComboBox.SelectedIndex = 0
            refreshTree()
            TblJobDescriptionBindingSource_CurrentChanged(Nothing, Nothing)
        End Using
        loaded = True

    End Sub
    Sub refreshTree()
        DepartmentTreeView.Nodes.Clear()
        Using aMainOr As New LqHRDataContext
            Departments = aMainOr.TblDepartments.ToList
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
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If Tag > 0 Then


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

            For i As Integer = 0 To List.Count - 1
                Dim depId As Integer = List.ToList(i)
                For j As Integer = 0 To TblJobDescriptionBindingSource.Count - 1
                    If TblJobDescriptionDataGridView.Rows(j).Cells(0).Value = True Then
                        Dim JobsPerDep As New TblJobsPerDepartment
                        JobsPerDep.DepartmentId = depId
                        JobsPerDep.JobId = TblJobDescriptionBindingSource(j).id
                        Using aMainOr As New LqHRDataContext
                            aMainOr.TblJobsPerDepartments.InsertOnSubmit(JobsPerDep)
                            aMainOr.SubmitChanges()

                        End Using
                    End If
                Next
            Next
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub DepartmentTreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles DepartmentTreeView.AfterSelect
        DepartmentTreeView.SelectedNode = e.Node
        nodeTag = Integer.Parse(DepartmentTreeView.SelectedNode.Tag.ToString)

        For J As Integer = 0 To TblJobDescriptionBindingSource.Count - 1
            TblJobDescriptionDataGridView.Rows(J).Cells(0).Value = False
        Next

        Using aMainor As New LqHRDataContext
            Dim res = (From ax In aMainor.TblJobsPerDepartments Where ax.DepartmentId = nodeTag).ToList
            For I As Integer = 0 To res.Count - 1
                For J As Integer = 0 To TblJobDescriptionBindingSource.Count - 1
                    If TblJobDescriptionBindingSource(J).id = res(I).JobId Then
                        TblJobDescriptionDataGridView.Rows(J).Cells(0).Value = True
                    End If
                Next
            Next



        End Using

    End Sub

    Private Sub TblJobDescriptionBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblJobDescriptionBindingSource.CurrentChanged
        Using aMainor As New LqHRDataContext

            Dim tv As TreeView = DepartmentTreeView
            Dim nodes As TreeNodeCollection = tv.Nodes

            For Each n As TreeNode In nodes
                ClearRecursive(n)
            Next
            For Each n In nodes
                markNode(n)
            Next


            'Dim JobId As Integer = TblJobDescriptionBindingSource.Current.id
            'Dim res As List(Of Integer?) = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = JobId Select ax.DepartmentId).ToList
            'For Each aX As TreeNode In DepartmentTreeView.Nodes
            '    If res.Contains(Integer.Parse(aX.Tag)) Then
            '        aX.BackColor = Color.Blue
            '    End If
            '    For Each aJ As TreeNode In aX.Nodes
            '        If res.Contains(Integer.Parse(aJ.Tag)) Then
            '            aJ.BackColor = Color.Blue
            '        End If
            '        For Each aY As TreeNode In aJ.Nodes
            '            If res.Contains(Integer.Parse(aY.Tag)) Then
            '                aY.BackColor = Color.Blue
            '            End If

            '            For Each aK As TreeNode In aY.Nodes
            '                If res.Contains(Integer.Parse(aK.Tag)) Then
            '                    aK.BackColor = Color.Blue
            '                End If
            '                For Each ap As TreeNode In aK.Nodes
            '                    If res.Contains(Integer.Parse(ap.Tag)) Then
            '                        ap.BackColor = Color.Blue
            '                    End If
            '                    For Each aY1 As TreeNode In ap.Nodes
            '                        If res.Contains(Integer.Parse(aY1.Tag)) Then
            '                            aY1.BackColor = Color.Blue
            '                        End If
            '                        For Each aK1 As TreeNode In aY1.Nodes
            '                            If res.Contains(Integer.Parse(aK1.Tag)) Then
            '                                aK1.BackColor = Color.Blue
            '                            End If
            '                            For Each ap1 As TreeNode In aK1.Nodes
            '                                If res.Contains(Integer.Parse(ap1.Tag)) Then
            '                                    ap1.BackColor = Color.Blue
            '                                End If
            '                            Next
            '                        Next
            '                    Next
            '                Next
            '            Next
            '        Next
            '    Next
            'Next




        End Using
    End Sub

    Private Sub ClearRecursive(ByVal treeNode As TreeNode)

        For Each tn As TreeNode In treeNode.Nodes
            tn.BackColor = Color.White
            ClearRecursive(tn)
        Next
    End Sub

    Private Sub markNode(ByVal treeNode As TreeNode)
        Using aMainor As New LqHRDataContext
            If TblJobDescriptionBindingSource.Count > 0 Then
                Dim JobId As Integer = TblJobDescriptionBindingSource.Current.id
                Dim res As List(Of Integer?) = (From ax In aMainor.TblJobsPerDepartments Where ax.JobId = JobId Select ax.DepartmentId).ToList

                Dim tn As TreeNode
                For Each tn In treeNode.Nodes
                    If res.Contains(Integer.Parse(tn.Tag)) Then
                        tn.BackColor = Color.Blue
                    End If

                Next
            End If
        End Using
    End Sub


    ''''''''''''''''''''''''''''''Seach bar For the tree'''''''''''''''''''''''''''''''''''''
    Private Sub SearchDep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        ClearBackColor(True)
        FindByText()
    End Sub

    Private Sub ClearBackColor(ByVal isTask As Boolean)
        Dim tv As TreeView
        tv = DepartmentTreeView
        Dim nodes As TreeNodeCollection
        nodes = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            ClearRecursive(n)
        Next
    End Sub
    Private Sub FindByText()
        Dim tv As TreeView = DepartmentTreeView
        Dim nodes As TreeNodeCollection = tv.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursive(n)
        Next
    End Sub

    Private Sub FindRecursive(ByVal tNode As TreeNode)
        Dim searchTxt As TextBox
        Dim tv As TreeView = DepartmentTreeView
        searchTxt = SearchTextBox


        If searchTxt.Text = "" Then
            tv.CollapseAll()
            tv.BackColor = Color.White

        Else
            Dim tn As TreeNode
            For Each tn In tNode.Nodes

                If tn.Text.Contains(searchTxt.Text) Then
                    tn.BackColor = Color.Blue
                    tn.EnsureVisible()        'Scroll the control to the item
                End If

                FindRecursive(tn)
            Next

        End If
    End Sub

    Private Sub JobNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobNumberTextBox.TextChanged, SupervidorIdComboBox.TextChanged, ScheduleIdComboBox.TextChanged, ReqHrsIdComboBox.TextChanged, NameTextBox.TextChanged, CatIdComboBox.TextChanged, ArabicNameTextBox.TextChanged
        Dim catId As Integer = 0
        Dim supId As Integer = 0
        Dim ReqHrsId As Integer = 0
        Dim ScheduleDep As Integer = 0
        If CatIdComboBox.SelectedValue > 0 Then
            catId = CatIdComboBox.SelectedValue
        End If
        If SupervidorIdComboBox.SelectedValue > 0 Then
            supId = SupervidorIdComboBox.SelectedValue

        End If
        If ReqHrsIdComboBox.SelectedValue > 0 Then
            ReqHrsId = ReqHrsIdComboBox.SelectedValue

        End If
        If ScheduleIdComboBox.SelectedValue > 0 Then
            ScheduleDep = ScheduleIdComboBox.SelectedValue
        End If
        Using aMainor As New LqHRDataContext
            TblJobDescriptionBindingSource.DataSource = aMainor.Filter_JobsPerDepartment(JobNumberTextBox.Text, NameTextBox.Text, ArabicNameTextBox.Text, supId, catId, ScheduleDep, ReqHrsId).ToList
        End Using

    End Sub
End Class