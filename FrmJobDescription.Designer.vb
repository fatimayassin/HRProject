<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJobDescription
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JobNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim ArabicNameLabel As System.Windows.Forms.Label
        Dim DefaultCardLabelNameLabel As System.Windows.Forms.Label
        Dim DefaultJobNameForCardLabel As System.Windows.Forms.Label
        Dim DefaultJobNameForCardFemaleLabel As System.Windows.Forms.Label
        Dim JobCategoryIdLabel As System.Windows.Forms.Label
        Dim RequiredHoursForJobIdLabel As System.Windows.Forms.Label
        Dim ScheduleDepIdLabel As System.Windows.Forms.Label
        Dim SupervisorIdLabel As System.Windows.Forms.Label
        Dim ClassificantionIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJobDescription))
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ArabicNameTextBox = New System.Windows.Forms.TextBox()
        Me.DefaultCardLabelNameTextBox = New System.Windows.Forms.TextBox()
        Me.DefaultJobNameForCardTextBox = New System.Windows.Forms.TextBox()
        Me.DefaultJobNameForCardFemaleTextBox = New System.Windows.Forms.TextBox()
        Me.JobCategoryIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequiredHoursForJobIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblRequiredHoursForJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleDepIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblJobDescriptionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TVRequirement = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TVTasks = New System.Windows.Forms.TreeView()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SearchRequirement = New System.Windows.Forms.TextBox()
        Me.SearchTask = New System.Windows.Forms.TextBox()
        Me.ContextMenuStripTasks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequiredForJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequiredForAppraisalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequiredForBothToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReq = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddReqTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRequirementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsPrimaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBSave = New System.Windows.Forms.PictureBox()
        Me.PBSearch = New System.Windows.Forms.PictureBox()
        Me.PBLast = New System.Windows.Forms.PictureBox()
        Me.PBNext = New System.Windows.Forms.PictureBox()
        Me.PBBack = New System.Windows.Forms.PictureBox()
        Me.PBFirst = New System.Windows.Forms.PictureBox()
        Me.PBEdit = New System.Windows.Forms.PictureBox()
        Me.PBAdd = New System.Windows.Forms.PictureBox()
        Me.PBDelete = New System.Windows.Forms.PictureBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTreeView = New System.Windows.Forms.TreeView()
        Me.ClassificantionIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblClassificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        JobNumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        ArabicNameLabel = New System.Windows.Forms.Label()
        DefaultCardLabelNameLabel = New System.Windows.Forms.Label()
        DefaultJobNameForCardLabel = New System.Windows.Forms.Label()
        DefaultJobNameForCardFemaleLabel = New System.Windows.Forms.Label()
        JobCategoryIdLabel = New System.Windows.Forms.Label()
        RequiredHoursForJobIdLabel = New System.Windows.Forms.Label()
        ScheduleDepIdLabel = New System.Windows.Forms.Label()
        SupervisorIdLabel = New System.Windows.Forms.Label()
        ClassificantionIdLabel = New System.Windows.Forms.Label()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStripTasks.SuspendLayout()
        Me.ContextMenuStripReq.SuspendLayout()
        CType(Me.PBSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFirst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClassificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'JobNumberLabel
        '
        JobNumberLabel.AutoSize = True
        JobNumberLabel.Location = New System.Drawing.Point(6, 16)
        JobNumberLabel.Name = "JobNumberLabel"
        JobNumberLabel.Size = New System.Drawing.Size(81, 16)
        JobNumberLabel.TabIndex = 55
        JobNumberLabel.Text = "Job Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 46)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(46, 16)
        NameLabel.TabIndex = 56
        NameLabel.Text = "Name:"
        '
        'ArabicNameLabel
        '
        ArabicNameLabel.AutoSize = True
        ArabicNameLabel.Location = New System.Drawing.Point(6, 79)
        ArabicNameLabel.Name = "ArabicNameLabel"
        ArabicNameLabel.Size = New System.Drawing.Size(87, 16)
        ArabicNameLabel.TabIndex = 57
        ArabicNameLabel.Text = "Arabic Name:"
        '
        'DefaultCardLabelNameLabel
        '
        DefaultCardLabelNameLabel.AutoSize = True
        DefaultCardLabelNameLabel.Location = New System.Drawing.Point(435, 79)
        DefaultCardLabelNameLabel.Name = "DefaultCardLabelNameLabel"
        DefaultCardLabelNameLabel.Size = New System.Drawing.Size(160, 16)
        DefaultCardLabelNameLabel.TabIndex = 58
        DefaultCardLabelNameLabel.Text = "Default Card Label Name:"
        '
        'DefaultJobNameForCardLabel
        '
        DefaultJobNameForCardLabel.AutoSize = True
        DefaultJobNameForCardLabel.Location = New System.Drawing.Point(435, 113)
        DefaultJobNameForCardLabel.Name = "DefaultJobNameForCardLabel"
        DefaultJobNameForCardLabel.Size = New System.Drawing.Size(170, 16)
        DefaultJobNameForCardLabel.TabIndex = 59
        DefaultJobNameForCardLabel.Text = "Default Job Name For Card:"
        '
        'DefaultJobNameForCardFemaleLabel
        '
        DefaultJobNameForCardFemaleLabel.AutoSize = True
        DefaultJobNameForCardFemaleLabel.Location = New System.Drawing.Point(436, 151)
        DefaultJobNameForCardFemaleLabel.Name = "DefaultJobNameForCardFemaleLabel"
        DefaultJobNameForCardFemaleLabel.Size = New System.Drawing.Size(216, 16)
        DefaultJobNameForCardFemaleLabel.TabIndex = 60
        DefaultJobNameForCardFemaleLabel.Text = "Default Job Name For Card Female:"
        '
        'JobCategoryIdLabel
        '
        JobCategoryIdLabel.AutoSize = True
        JobCategoryIdLabel.Location = New System.Drawing.Point(6, 113)
        JobCategoryIdLabel.Name = "JobCategoryIdLabel"
        JobCategoryIdLabel.Size = New System.Drawing.Size(88, 16)
        JobCategoryIdLabel.TabIndex = 61
        JobCategoryIdLabel.Text = "Job Category:"
        '
        'RequiredHoursForJobIdLabel
        '
        RequiredHoursForJobIdLabel.AutoSize = True
        RequiredHoursForJobIdLabel.Location = New System.Drawing.Point(435, 46)
        RequiredHoursForJobIdLabel.Name = "RequiredHoursForJobIdLabel"
        RequiredHoursForJobIdLabel.Size = New System.Drawing.Size(147, 16)
        RequiredHoursForJobIdLabel.TabIndex = 62
        RequiredHoursForJobIdLabel.Text = "Required Hours For Job:"
        '
        'ScheduleDepIdLabel
        '
        ScheduleDepIdLabel.AutoSize = True
        ScheduleDepIdLabel.Location = New System.Drawing.Point(435, 16)
        ScheduleDepIdLabel.Name = "ScheduleDepIdLabel"
        ScheduleDepIdLabel.Size = New System.Drawing.Size(90, 16)
        ScheduleDepIdLabel.TabIndex = 63
        ScheduleDepIdLabel.Text = "Schedule Dep:"
        '
        'SupervisorIdLabel
        '
        SupervisorIdLabel.AutoSize = True
        SupervisorIdLabel.Location = New System.Drawing.Point(6, 151)
        SupervisorIdLabel.Name = "SupervisorIdLabel"
        SupervisorIdLabel.Size = New System.Drawing.Size(73, 16)
        SupervisorIdLabel.TabIndex = 64
        SupervisorIdLabel.Text = "Supervisor:"
        '
        'ClassificantionIdLabel
        '
        ClassificantionIdLabel.AutoSize = True
        ClassificantionIdLabel.Location = New System.Drawing.Point(20, 197)
        ClassificantionIdLabel.Name = "ClassificantionIdLabel"
        ClassificantionIdLabel.Size = New System.Drawing.Size(98, 16)
        ClassificantionIdLabel.TabIndex = 78
        ClassificantionIdLabel.Text = "Classificantion:"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(1202, 32)
        Me.lblText.TabIndex = 53
        Me.lblText.Text = "Job Description "
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1173, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 14
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'TblJobDescriptionBindingSource
        '
        Me.TblJobDescriptionBindingSource.DataSource = GetType(HR.TblJobDescription)
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.BackColor = System.Drawing.Color.White
        Me.JobNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "JobNumber", True))
        Me.JobNumberTextBox.Location = New System.Drawing.Point(127, 9)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.ReadOnly = True
        Me.JobNumberTextBox.Size = New System.Drawing.Size(299, 23)
        Me.JobNumberTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.White
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(127, 43)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(298, 23)
        Me.NameTextBox.TabIndex = 3
        '
        'ArabicNameTextBox
        '
        Me.ArabicNameTextBox.BackColor = System.Drawing.Color.White
        Me.ArabicNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "ArabicName", True))
        Me.ArabicNameTextBox.Location = New System.Drawing.Point(127, 76)
        Me.ArabicNameTextBox.Name = "ArabicNameTextBox"
        Me.ArabicNameTextBox.Size = New System.Drawing.Size(298, 23)
        Me.ArabicNameTextBox.TabIndex = 4
        '
        'DefaultCardLabelNameTextBox
        '
        Me.DefaultCardLabelNameTextBox.BackColor = System.Drawing.Color.White
        Me.DefaultCardLabelNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "DefaultCardLabelName", True))
        Me.DefaultCardLabelNameTextBox.Location = New System.Drawing.Point(658, 73)
        Me.DefaultCardLabelNameTextBox.Name = "DefaultCardLabelNameTextBox"
        Me.DefaultCardLabelNameTextBox.Size = New System.Drawing.Size(233, 23)
        Me.DefaultCardLabelNameTextBox.TabIndex = 9
        '
        'DefaultJobNameForCardTextBox
        '
        Me.DefaultJobNameForCardTextBox.BackColor = System.Drawing.Color.White
        Me.DefaultJobNameForCardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "DefaultJobNameForCard", True))
        Me.DefaultJobNameForCardTextBox.Location = New System.Drawing.Point(658, 110)
        Me.DefaultJobNameForCardTextBox.Name = "DefaultJobNameForCardTextBox"
        Me.DefaultJobNameForCardTextBox.Size = New System.Drawing.Size(233, 23)
        Me.DefaultJobNameForCardTextBox.TabIndex = 10
        '
        'DefaultJobNameForCardFemaleTextBox
        '
        Me.DefaultJobNameForCardFemaleTextBox.BackColor = System.Drawing.Color.White
        Me.DefaultJobNameForCardFemaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobDescriptionBindingSource, "DefaultJobNameForCardFemale", True))
        Me.DefaultJobNameForCardFemaleTextBox.Location = New System.Drawing.Point(658, 148)
        Me.DefaultJobNameForCardFemaleTextBox.Name = "DefaultJobNameForCardFemaleTextBox"
        Me.DefaultJobNameForCardFemaleTextBox.Size = New System.Drawing.Size(233, 23)
        Me.DefaultJobNameForCardFemaleTextBox.TabIndex = 11
        '
        'JobCategoryIdComboBox
        '
        Me.JobCategoryIdComboBox.BackColor = System.Drawing.Color.White
        Me.JobCategoryIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblJobDescriptionBindingSource, "JobCategoryId", True))
        Me.JobCategoryIdComboBox.DataSource = Me.TblJobCategoryBindingSource
        Me.JobCategoryIdComboBox.DisplayMember = "Name"
        Me.JobCategoryIdComboBox.FormattingEnabled = True
        Me.JobCategoryIdComboBox.Location = New System.Drawing.Point(127, 110)
        Me.JobCategoryIdComboBox.Name = "JobCategoryIdComboBox"
        Me.JobCategoryIdComboBox.Size = New System.Drawing.Size(298, 24)
        Me.JobCategoryIdComboBox.TabIndex = 5
        Me.JobCategoryIdComboBox.ValueMember = "Id"
        '
        'TblJobCategoryBindingSource
        '
        Me.TblJobCategoryBindingSource.DataSource = GetType(HR.TblJobCategory)
        '
        'RequiredHoursForJobIdComboBox
        '
        Me.RequiredHoursForJobIdComboBox.BackColor = System.Drawing.Color.White
        Me.RequiredHoursForJobIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblJobDescriptionBindingSource, "RequiredHoursForJobId", True))
        Me.RequiredHoursForJobIdComboBox.DataSource = Me.TblRequiredHoursForJobBindingSource
        Me.RequiredHoursForJobIdComboBox.DisplayMember = "Description"
        Me.RequiredHoursForJobIdComboBox.FormattingEnabled = True
        Me.RequiredHoursForJobIdComboBox.Location = New System.Drawing.Point(658, 42)
        Me.RequiredHoursForJobIdComboBox.Name = "RequiredHoursForJobIdComboBox"
        Me.RequiredHoursForJobIdComboBox.Size = New System.Drawing.Size(233, 24)
        Me.RequiredHoursForJobIdComboBox.TabIndex = 8
        Me.RequiredHoursForJobIdComboBox.ValueMember = "Id"
        '
        'TblRequiredHoursForJobBindingSource
        '
        Me.TblRequiredHoursForJobBindingSource.DataSource = GetType(HR.TblRequiredHoursForJob)
        '
        'ScheduleDepIdComboBox
        '
        Me.ScheduleDepIdComboBox.BackColor = System.Drawing.Color.White
        Me.ScheduleDepIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblJobDescriptionBindingSource, "ScheduleDepId", True))
        Me.ScheduleDepIdComboBox.DataSource = Me.TblDepartmentBindingSource
        Me.ScheduleDepIdComboBox.DisplayMember = "Name"
        Me.ScheduleDepIdComboBox.FormattingEnabled = True
        Me.ScheduleDepIdComboBox.Location = New System.Drawing.Point(658, 8)
        Me.ScheduleDepIdComboBox.Name = "ScheduleDepIdComboBox"
        Me.ScheduleDepIdComboBox.Size = New System.Drawing.Size(233, 24)
        Me.ScheduleDepIdComboBox.TabIndex = 7
        Me.ScheduleDepIdComboBox.ValueMember = "Id"
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataSource = GetType(HR.TblDepartment)
        '
        'SupervisorIdComboBox
        '
        Me.SupervisorIdComboBox.BackColor = System.Drawing.Color.White
        Me.SupervisorIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblJobDescriptionBindingSource, "SupervisorId", True))
        Me.SupervisorIdComboBox.DataSource = Me.TblJobDescriptionBindingSource1
        Me.SupervisorIdComboBox.DisplayMember = "Name"
        Me.SupervisorIdComboBox.FormattingEnabled = True
        Me.SupervisorIdComboBox.Location = New System.Drawing.Point(127, 148)
        Me.SupervisorIdComboBox.Name = "SupervisorIdComboBox"
        Me.SupervisorIdComboBox.Size = New System.Drawing.Size(298, 24)
        Me.SupervisorIdComboBox.TabIndex = 6
        Me.SupervisorIdComboBox.ValueMember = "Id"
        '
        'TblJobDescriptionBindingSource1
        '
        Me.TblJobDescriptionBindingSource1.DataSource = GetType(HR.TblJobDescription)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(303, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 282)
        Me.Panel1.TabIndex = 67
        '
        'TVRequirement
        '
        Me.TVRequirement.BackColor = System.Drawing.Color.Gainsboro
        Me.TVRequirement.CheckBoxes = True
        Me.TVRequirement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVRequirement.ImageIndex = 0
        Me.TVRequirement.ImageList = Me.ImageList1
        Me.TVRequirement.Location = New System.Drawing.Point(0, 0)
        Me.TVRequirement.Name = "TVRequirement"
        Me.TVRequirement.SelectedImageIndex = 0
        Me.TVRequirement.Size = New System.Drawing.Size(461, 246)
        Me.TVRequirement.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "button-background.png")
        Me.ImageList1.Images.SetKeyName(1, "star.png")
        '
        'TVTasks
        '
        Me.TVTasks.BackColor = System.Drawing.Color.Gainsboro
        Me.TVTasks.CheckBoxes = True
        Me.TVTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVTasks.ImageIndex = 0
        Me.TVTasks.ImageList = Me.ImageList2
        Me.TVTasks.Location = New System.Drawing.Point(0, 0)
        Me.TVTasks.Name = "TVTasks"
        Me.TVTasks.SelectedImageIndex = 0
        Me.TVTasks.Size = New System.Drawing.Size(434, 246)
        Me.TVTasks.TabIndex = 0
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "button-background.png")
        Me.ImageList2.Images.SetKeyName(1, "man-user (2).png")
        Me.ImageList2.Images.SetKeyName(2, "pen_paper_2-5121.png")
        Me.ImageList2.Images.SetKeyName(3, "select.png")
        '
        'SearchRequirement
        '
        Me.SearchRequirement.Location = New System.Drawing.Point(15, 6)
        Me.SearchRequirement.Name = "SearchRequirement"
        Me.SearchRequirement.Size = New System.Drawing.Size(438, 23)
        Me.SearchRequirement.TabIndex = 13
        '
        'SearchTask
        '
        Me.SearchTask.Location = New System.Drawing.Point(6, 7)
        Me.SearchTask.Name = "SearchTask"
        Me.SearchTask.Size = New System.Drawing.Size(420, 23)
        Me.SearchTask.TabIndex = 12
        '
        'ContextMenuStripTasks
        '
        Me.ContextMenuStripTasks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCategoryToolStripMenuItem, Me.AddTaskToolStripMenuItem, Me.RequiredForJobToolStripMenuItem, Me.RequiredForAppraisalToolStripMenuItem, Me.RequiredForBothToolStripMenuItem})
        Me.ContextMenuStripTasks.Name = "ContextMenuStripTasks"
        Me.ContextMenuStripTasks.Size = New System.Drawing.Size(188, 114)
        '
        'AddCategoryToolStripMenuItem
        '
        Me.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem"
        Me.AddCategoryToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AddCategoryToolStripMenuItem.Text = "Add Category"
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AddTaskToolStripMenuItem.Text = "Add Task"
        '
        'RequiredForJobToolStripMenuItem
        '
        Me.RequiredForJobToolStripMenuItem.Name = "RequiredForJobToolStripMenuItem"
        Me.RequiredForJobToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RequiredForJobToolStripMenuItem.Text = "RequiredForJob"
        '
        'RequiredForAppraisalToolStripMenuItem
        '
        Me.RequiredForAppraisalToolStripMenuItem.Name = "RequiredForAppraisalToolStripMenuItem"
        Me.RequiredForAppraisalToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RequiredForAppraisalToolStripMenuItem.Text = "RequiredForAppraisal"
        '
        'RequiredForBothToolStripMenuItem
        '
        Me.RequiredForBothToolStripMenuItem.Name = "RequiredForBothToolStripMenuItem"
        Me.RequiredForBothToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RequiredForBothToolStripMenuItem.Text = "RequiredForBoth"
        '
        'ContextMenuStripReq
        '
        Me.ContextMenuStripReq.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddReqTypeToolStripMenuItem, Me.AddRequirementToolStripMenuItem, Me.IsPrimaryToolStripMenuItem})
        Me.ContextMenuStripReq.Name = "ContextMenuStripReq"
        Me.ContextMenuStripReq.Size = New System.Drawing.Size(168, 70)
        '
        'AddReqTypeToolStripMenuItem
        '
        Me.AddReqTypeToolStripMenuItem.Name = "AddReqTypeToolStripMenuItem"
        Me.AddReqTypeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddReqTypeToolStripMenuItem.Text = "Add Req Type"
        '
        'AddRequirementToolStripMenuItem
        '
        Me.AddRequirementToolStripMenuItem.Name = "AddRequirementToolStripMenuItem"
        Me.AddRequirementToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddRequirementToolStripMenuItem.Text = "Add Requirement"
        '
        'IsPrimaryToolStripMenuItem
        '
        Me.IsPrimaryToolStripMenuItem.Name = "IsPrimaryToolStripMenuItem"
        Me.IsPrimaryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.IsPrimaryToolStripMenuItem.Text = "Is Primary"
        '
        'PBSave
        '
        Me.PBSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBSave.Image = Global.HR.My.Resources.Resources.SaveIcon7
        Me.PBSave.Location = New System.Drawing.Point(889, 3)
        Me.PBSave.Name = "PBSave"
        Me.PBSave.Size = New System.Drawing.Size(73, 42)
        Me.PBSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBSave.TabIndex = 75
        Me.PBSave.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBSave, "Save")
        Me.PBSave.Visible = False
        '
        'PBSearch
        '
        Me.PBSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBSearch.Image = Global.HR.My.Resources.Resources.SearchIcon7
        Me.PBSearch.Location = New System.Drawing.Point(710, 3)
        Me.PBSearch.Name = "PBSearch"
        Me.PBSearch.Size = New System.Drawing.Size(62, 42)
        Me.PBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBSearch.TabIndex = 74
        Me.PBSearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBSearch, "Search")
        '
        'PBLast
        '
        Me.PBLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBLast.Image = Global.HR.My.Resources.Resources.LastIcon7
        Me.PBLast.Location = New System.Drawing.Point(482, 3)
        Me.PBLast.Name = "PBLast"
        Me.PBLast.Size = New System.Drawing.Size(55, 42)
        Me.PBLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLast.TabIndex = 73
        Me.PBLast.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBLast, "Last")
        '
        'PBNext
        '
        Me.PBNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBNext.Image = Global.HR.My.Resources.Resources.GoNextIcon7
        Me.PBNext.Location = New System.Drawing.Point(420, 3)
        Me.PBNext.Name = "PBNext"
        Me.PBNext.Size = New System.Drawing.Size(56, 42)
        Me.PBNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBNext.TabIndex = 72
        Me.PBNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBNext, "Next")
        '
        'PBBack
        '
        Me.PBBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBBack.Image = Global.HR.My.Resources.Resources.GoPrevIcon7
        Me.PBBack.Location = New System.Drawing.Point(360, 3)
        Me.PBBack.Name = "PBBack"
        Me.PBBack.Size = New System.Drawing.Size(54, 42)
        Me.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBack.TabIndex = 71
        Me.PBBack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBBack, "Back")
        '
        'PBFirst
        '
        Me.PBFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBFirst.Image = Global.HR.My.Resources.Resources.FirstIcon7
        Me.PBFirst.Location = New System.Drawing.Point(305, 3)
        Me.PBFirst.Name = "PBFirst"
        Me.PBFirst.Size = New System.Drawing.Size(49, 42)
        Me.PBFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBFirst.TabIndex = 70
        Me.PBFirst.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBFirst, "First")
        '
        'PBEdit
        '
        Me.PBEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBEdit.Image = Global.HR.My.Resources.Resources.EditIcon7
        Me.PBEdit.Location = New System.Drawing.Point(968, 3)
        Me.PBEdit.Name = "PBEdit"
        Me.PBEdit.Size = New System.Drawing.Size(73, 42)
        Me.PBEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBEdit.TabIndex = 76
        Me.PBEdit.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBEdit, "Edit")
        '
        'PBAdd
        '
        Me.PBAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBAdd.Image = Global.HR.My.Resources.Resources.NewIcon7
        Me.PBAdd.Location = New System.Drawing.Point(1126, 3)
        Me.PBAdd.Name = "PBAdd"
        Me.PBAdd.Size = New System.Drawing.Size(73, 42)
        Me.PBAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBAdd.TabIndex = 78
        Me.PBAdd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBAdd, "Add")
        '
        'PBDelete
        '
        Me.PBDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBDelete.Image = Global.HR.My.Resources.Resources.DeleteIcon7
        Me.PBDelete.Location = New System.Drawing.Point(1047, 3)
        Me.PBDelete.Name = "PBDelete"
        Me.PBDelete.Size = New System.Drawing.Size(73, 42)
        Me.PBDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBDelete.TabIndex = 77
        Me.PBDelete.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBDelete, "Delete")
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(256, 23)
        Me.SearchTextBox.TabIndex = 0
        '
        'DepartmentTreeView
        '
        Me.DepartmentTreeView.BackColor = System.Drawing.Color.White
        Me.DepartmentTreeView.CheckBoxes = True
        Me.DepartmentTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DepartmentTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DepartmentTreeView.Name = "DepartmentTreeView"
        Me.DepartmentTreeView.Size = New System.Drawing.Size(303, 439)
        Me.DepartmentTreeView.TabIndex = 1
        '
        'ClassificantionIdComboBox
        '
        Me.ClassificantionIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblJobDescriptionBindingSource, "ClassificantionId", True))
        Me.ClassificantionIdComboBox.DataSource = Me.TblClassificationBindingSource
        Me.ClassificantionIdComboBox.DisplayMember = "Name"
        Me.ClassificantionIdComboBox.FormattingEnabled = True
        Me.ClassificantionIdComboBox.Location = New System.Drawing.Point(141, 191)
        Me.ClassificantionIdComboBox.Name = "ClassificantionIdComboBox"
        Me.ClassificantionIdComboBox.Size = New System.Drawing.Size(285, 24)
        Me.ClassificantionIdComboBox.TabIndex = 79
        Me.ClassificantionIdComboBox.ValueMember = "Id"
        '
        'TblClassificationBindingSource
        '
        Me.TblClassificationBindingSource.DataSource = GetType(HR.TblClassification)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1202, 48)
        Me.Panel2.TabIndex = 80
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.59383!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.40616!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PBFirst, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBBack, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBNext, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBLast, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBAdd, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBDelete, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBSave, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBSearch, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBEdit, 9, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1202, 48)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(303, 471)
        Me.Panel3.TabIndex = 81
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.HR.My.Resources.Resources.SearchIcon7
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(262, 3)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(36, 23)
        Me.BtnSearch.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnSearch, "Search")
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SearchTextBox)
        Me.Panel4.Controls.Add(Me.BtnSearch)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(303, 32)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DepartmentTreeView)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(303, 439)
        Me.Panel5.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(JobNumberLabel)
        Me.Panel6.Controls.Add(Me.JobNumberTextBox)
        Me.Panel6.Controls.Add(Me.NameTextBox)
        Me.Panel6.Controls.Add(NameLabel)
        Me.Panel6.Controls.Add(Me.ArabicNameTextBox)
        Me.Panel6.Controls.Add(ClassificantionIdLabel)
        Me.Panel6.Controls.Add(ArabicNameLabel)
        Me.Panel6.Controls.Add(Me.ClassificantionIdComboBox)
        Me.Panel6.Controls.Add(Me.DefaultCardLabelNameTextBox)
        Me.Panel6.Controls.Add(DefaultCardLabelNameLabel)
        Me.Panel6.Controls.Add(Me.DefaultJobNameForCardTextBox)
        Me.Panel6.Controls.Add(DefaultJobNameForCardLabel)
        Me.Panel6.Controls.Add(SupervisorIdLabel)
        Me.Panel6.Controls.Add(Me.DefaultJobNameForCardFemaleTextBox)
        Me.Panel6.Controls.Add(Me.SupervisorIdComboBox)
        Me.Panel6.Controls.Add(DefaultJobNameForCardFemaleLabel)
        Me.Panel6.Controls.Add(ScheduleDepIdLabel)
        Me.Panel6.Controls.Add(Me.JobCategoryIdComboBox)
        Me.Panel6.Controls.Add(Me.ScheduleDepIdComboBox)
        Me.Panel6.Controls.Add(JobCategoryIdLabel)
        Me.Panel6.Controls.Add(RequiredHoursForJobIdLabel)
        Me.Panel6.Controls.Add(Me.RequiredHoursForJobIdComboBox)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(303, 32)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(899, 189)
        Me.Panel6.TabIndex = 82
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Size = New System.Drawing.Size(899, 282)
        Me.SplitContainer1.SplitterDistance = 434
        Me.SplitContainer1.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.SearchTask)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(434, 36)
        Me.Panel7.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.SearchRequirement)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(461, 36)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.TVTasks)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 36)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(434, 246)
        Me.Panel9.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TVRequirement)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 36)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(461, 246)
        Me.Panel10.TabIndex = 2
        '
        'FrmJobDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1202, 551)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmJobDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredHoursForJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStripTasks.ResumeLayout(False)
        Me.ContextMenuStripReq.ResumeLayout(False)
        CType(Me.PBSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFirst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClassificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents TblJobDescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArabicNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultCardLabelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultJobNameForCardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultJobNameForCardFemaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobCategoryIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RequiredHoursForJobIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScheduleDepIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupervisorIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRequiredHoursForJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TVRequirement As System.Windows.Forms.TreeView
    Friend WithEvents TVTasks As System.Windows.Forms.TreeView
    Friend WithEvents SearchRequirement As System.Windows.Forms.TextBox
    Friend WithEvents SearchTask As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStripTasks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReq As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddReqTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRequirementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IsPrimaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RequiredForJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequiredForAppraisalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents RequiredForBothToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PBSave As System.Windows.Forms.PictureBox
    Friend WithEvents PBSearch As System.Windows.Forms.PictureBox
    Friend WithEvents PBLast As System.Windows.Forms.PictureBox
    Friend WithEvents PBNext As System.Windows.Forms.PictureBox
    Friend WithEvents PBBack As System.Windows.Forms.PictureBox
    Friend WithEvents PBFirst As System.Windows.Forms.PictureBox
    Friend WithEvents PBEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PBAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PBDelete As System.Windows.Forms.PictureBox
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTreeView As System.Windows.Forms.TreeView
    Friend WithEvents ClassificantionIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobDescriptionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblClassificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
End Class
