<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewTasksV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewTasksV2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.BtAdd = New System.Windows.Forms.Button()
        Me.BtHideUnHide = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrpNewTask = New System.Windows.Forms.GroupBox()
        Me.TextBoxNewTask = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBoxCompletedTasksToday = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListBoxCompletedTasksPrev = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCompletedTasks = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxToDoTasks = New System.Windows.Forms.CheckedListBox()
        Me.Panel1.SuspendLayout()
        Me.GrpNewTask.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.BtDelete)
        Me.Panel1.Controls.Add(Me.BtEdit)
        Me.Panel1.Controls.Add(Me.BtAdd)
        Me.Panel1.Controls.Add(Me.BtHideUnHide)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 355)
        Me.Panel1.TabIndex = 2
        '
        'BtDelete
        '
        Me.BtDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtDelete.FlatAppearance.BorderSize = 0
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDelete.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDelete.Image = Global.HR.My.Resources.Resources.icons8_trash_24
        Me.BtDelete.Location = New System.Drawing.Point(0, 256)
        Me.BtDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(44, 33)
        Me.BtDelete.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.BtDelete, "Delete Task")
        Me.BtDelete.UseCompatibleTextRendering = True
        Me.BtDelete.UseMnemonic = False
        Me.BtDelete.UseVisualStyleBackColor = True
        '
        'BtEdit
        '
        Me.BtEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtEdit.FlatAppearance.BorderSize = 0
        Me.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEdit.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEdit.Image = Global.HR.My.Resources.Resources.icons8_pencil_30
        Me.BtEdit.Location = New System.Drawing.Point(0, 289)
        Me.BtEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(44, 33)
        Me.BtEdit.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.BtEdit, "Edit Task")
        Me.BtEdit.UseCompatibleTextRendering = True
        Me.BtEdit.UseMnemonic = False
        Me.BtEdit.UseVisualStyleBackColor = True
        '
        'BtAdd
        '
        Me.BtAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtAdd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtAdd.FlatAppearance.BorderSize = 0
        Me.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAdd.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAdd.Image = Global.HR.My.Resources.Resources.icons8_plus_math_26
        Me.BtAdd.Location = New System.Drawing.Point(0, 322)
        Me.BtAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtAdd.Name = "BtAdd"
        Me.BtAdd.Size = New System.Drawing.Size(44, 33)
        Me.BtAdd.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.BtAdd, "Add Task")
        Me.BtAdd.UseCompatibleTextRendering = True
        Me.BtAdd.UseMnemonic = False
        Me.BtAdd.UseVisualStyleBackColor = True
        '
        'BtHideUnHide
        '
        Me.BtHideUnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtHideUnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtHideUnHide.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtHideUnHide.FlatAppearance.BorderSize = 0
        Me.BtHideUnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtHideUnHide.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtHideUnHide.Image = Global.HR.My.Resources.Resources.icons8_menu_vertical_30
        Me.BtHideUnHide.Location = New System.Drawing.Point(0, 0)
        Me.BtHideUnHide.Margin = New System.Windows.Forms.Padding(2)
        Me.BtHideUnHide.Name = "BtHideUnHide"
        Me.BtHideUnHide.Size = New System.Drawing.Size(44, 41)
        Me.BtHideUnHide.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.BtHideUnHide, "Hide/Show Completed Tasks")
        Me.BtHideUnHide.UseCompatibleTextRendering = True
        Me.BtHideUnHide.UseMnemonic = False
        Me.BtHideUnHide.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(44, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 355)
        Me.Panel2.TabIndex = 3
        '
        'Timer1
        '
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(58, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 10)
        Me.Panel3.TabIndex = 10
        '
        'GrpNewTask
        '
        Me.GrpNewTask.Controls.Add(Me.TextBoxNewTask)
        Me.GrpNewTask.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpNewTask.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpNewTask.ForeColor = System.Drawing.Color.White
        Me.GrpNewTask.Location = New System.Drawing.Point(329, 160)
        Me.GrpNewTask.Name = "GrpNewTask"
        Me.GrpNewTask.Padding = New System.Windows.Forms.Padding(12)
        Me.GrpNewTask.Size = New System.Drawing.Size(328, 185)
        Me.GrpNewTask.TabIndex = 23
        Me.GrpNewTask.TabStop = False
        Me.GrpNewTask.Text = "New Task"
        '
        'TextBoxNewTask
        '
        Me.TextBoxNewTask.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxNewTask.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxNewTask.Location = New System.Drawing.Point(12, 28)
        Me.TextBoxNewTask.MaxLength = 120
        Me.TextBoxNewTask.Multiline = True
        Me.TextBoxNewTask.Name = "TextBoxNewTask"
        Me.TextBoxNewTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNewTask.Size = New System.Drawing.Size(304, 138)
        Me.TextBoxNewTask.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.HR.My.Resources.Resources.plus_26
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR.My.Resources.Resources.edit_24
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.HR.My.Resources.Resources.trash_24
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(319, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 345)
        Me.Panel5.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Thistle
        Me.Panel6.Controls.Add(Me.TabControl1)
        Me.Panel6.Controls.Add(Me.lblCompletedTasks)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(58, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(261, 345)
        Me.Panel6.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(261, 319)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBoxCompletedTasksToday)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(253, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Today"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBoxCompletedTasksToday
        '
        Me.ListBoxCompletedTasksToday.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListBoxCompletedTasksToday.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListBoxCompletedTasksToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCompletedTasksToday.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCompletedTasksToday.ForeColor = System.Drawing.Color.Black
        Me.ListBoxCompletedTasksToday.FormattingEnabled = True
        Me.ListBoxCompletedTasksToday.HorizontalScrollbar = True
        Me.ListBoxCompletedTasksToday.ItemHeight = 18
        Me.ListBoxCompletedTasksToday.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxCompletedTasksToday.Name = "ListBoxCompletedTasksToday"
        Me.ListBoxCompletedTasksToday.ScrollAlwaysVisible = True
        Me.ListBoxCompletedTasksToday.Size = New System.Drawing.Size(247, 284)
        Me.ListBoxCompletedTasksToday.TabIndex = 4
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(117, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Image = Global.HR.My.Resources.Resources.trash_24
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBoxCompletedTasksPrev)
        Me.TabPage3.ForeColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(253, 290)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Previous"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBoxCompletedTasksPrev
        '
        Me.ListBoxCompletedTasksPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListBoxCompletedTasksPrev.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ListBoxCompletedTasksPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCompletedTasksPrev.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCompletedTasksPrev.ForeColor = System.Drawing.Color.Black
        Me.ListBoxCompletedTasksPrev.FormattingEnabled = True
        Me.ListBoxCompletedTasksPrev.HorizontalScrollbar = True
        Me.ListBoxCompletedTasksPrev.ItemHeight = 18
        Me.ListBoxCompletedTasksPrev.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxCompletedTasksPrev.Name = "ListBoxCompletedTasksPrev"
        Me.ListBoxCompletedTasksPrev.ScrollAlwaysVisible = True
        Me.ListBoxCompletedTasksPrev.Size = New System.Drawing.Size(253, 290)
        Me.ListBoxCompletedTasksPrev.TabIndex = 5
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem2})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(117, 26)
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Image = Global.HR.My.Resources.Resources.trash_24
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'lblCompletedTasks
        '
        Me.lblCompletedTasks.AutoSize = True
        Me.lblCompletedTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCompletedTasks.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedTasks.ForeColor = System.Drawing.Color.White
        Me.lblCompletedTasks.Location = New System.Drawing.Point(0, 0)
        Me.lblCompletedTasks.Name = "lblCompletedTasks"
        Me.lblCompletedTasks.Padding = New System.Windows.Forms.Padding(5)
        Me.lblCompletedTasks.Size = New System.Drawing.Size(117, 26)
        Me.lblCompletedTasks.TabIndex = 8
        Me.lblCompletedTasks.Text = "Completed Tasks"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipTitle = "Reminder"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ToDo List - HR"
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckedListBoxToDoTasks)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(329, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 160)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ToDo Tasks"
        '
        'CheckedListBoxToDoTasks
        '
        Me.CheckedListBoxToDoTasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CheckedListBoxToDoTasks.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CheckedListBoxToDoTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxToDoTasks.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxToDoTasks.ForeColor = System.Drawing.Color.Black
        Me.CheckedListBoxToDoTasks.FormattingEnabled = True
        Me.CheckedListBoxToDoTasks.Location = New System.Drawing.Point(3, 19)
        Me.CheckedListBoxToDoTasks.Name = "CheckedListBoxToDoTasks"
        Me.CheckedListBoxToDoTasks.Size = New System.Drawing.Size(322, 138)
        Me.CheckedListBoxToDoTasks.TabIndex = 23
        '
        'FrmNewTasksV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpNewTask)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNewTasksV2"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.GrpNewTask.ResumeLayout(False)
        Me.GrpNewTask.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtDelete As Button
    Friend WithEvents BtEdit As Button
    Friend WithEvents BtAdd As Button
    Friend WithEvents BtHideUnHide As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GrpNewTask As GroupBox
    Friend WithEvents TextBoxNewTask As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListBoxCompletedTasksToday As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ListBoxCompletedTasksPrev As ListBox
    Friend WithEvents lblCompletedTasks As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckedListBoxToDoTasks As CheckedListBox
End Class
