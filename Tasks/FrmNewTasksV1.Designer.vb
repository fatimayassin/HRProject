<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewTasksV1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewTasksV1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtNew = New System.Windows.Forms.ToolStripButton()
        Me.BtEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtDelete = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TodoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CheckedListBoxToDoTasks = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblToDoTasks = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrpNewTask = New System.Windows.Forms.GroupBox()
        Me.TextBoxNewTask = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBoxCompletedTasks = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblCompletedTasks = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GrpNewTask.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtNew, Me.BtEdit, Me.BtDelete, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(515, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtNew
        '
        Me.BtNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtNew.Image = Global.HR.My.Resources.Resources.plus_26
        Me.BtNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtNew.Name = "BtNew"
        Me.BtNew.Size = New System.Drawing.Size(23, 22)
        Me.BtNew.Text = "&New"
        '
        'BtEdit
        '
        Me.BtEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtEdit.Image = Global.HR.My.Resources.Resources.edit_24
        Me.BtEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(23, 22)
        Me.BtEdit.Text = "&Edit"
        '
        'BtDelete
        '
        Me.BtDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtDelete.Image = Global.HR.My.Resources.Resources.trash_24
        Me.BtDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(23, 22)
        Me.BtDelete.Text = "&Delete"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodoMenu, Me.MenuExit1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TodoMenu
        '
        Me.TodoMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemNew, Me.MenuItemEdit, Me.MenuItemDelete})
        Me.TodoMenu.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodoMenu.ForeColor = System.Drawing.Color.White
        Me.TodoMenu.Name = "TodoMenu"
        Me.TodoMenu.Size = New System.Drawing.Size(54, 22)
        Me.TodoMenu.Text = "Todo"
        '
        'MenuItemNew
        '
        Me.MenuItemNew.Image = Global.HR.My.Resources.Resources.plus_26
        Me.MenuItemNew.Name = "MenuItemNew"
        Me.MenuItemNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuItemNew.Size = New System.Drawing.Size(175, 22)
        Me.MenuItemNew.Text = "New"
        '
        'MenuItemEdit
        '
        Me.MenuItemEdit.Image = Global.HR.My.Resources.Resources.edit_24
        Me.MenuItemEdit.Name = "MenuItemEdit"
        Me.MenuItemEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenuItemEdit.Size = New System.Drawing.Size(175, 22)
        Me.MenuItemEdit.Text = "Edit"
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Image = Global.HR.My.Resources.Resources.trash_24
        Me.MenuItemDelete.Name = "MenuItemDelete"
        Me.MenuItemDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuItemDelete.Size = New System.Drawing.Size(175, 22)
        Me.MenuItemDelete.Text = "Delete"
        '
        'MenuExit1
        '
        Me.MenuExit1.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuExit1.ForeColor = System.Drawing.Color.White
        Me.MenuExit1.Name = "MenuExit1"
        Me.MenuExit1.Size = New System.Drawing.Size(47, 22)
        Me.MenuExit1.Text = "Exit"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 51)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckedListBoxToDoTasks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblToDoTasks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrpNewTask)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCompletedTasks)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Size = New System.Drawing.Size(515, 503)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.TabIndex = 2
        '
        'CheckedListBoxToDoTasks
        '
        Me.CheckedListBoxToDoTasks.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CheckedListBoxToDoTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxToDoTasks.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxToDoTasks.ForeColor = System.Drawing.Color.White
        Me.CheckedListBoxToDoTasks.FormattingEnabled = True
        Me.CheckedListBoxToDoTasks.Location = New System.Drawing.Point(5, 174)
        Me.CheckedListBoxToDoTasks.Name = "CheckedListBoxToDoTasks"
        Me.CheckedListBoxToDoTasks.Size = New System.Drawing.Size(231, 324)
        Me.CheckedListBoxToDoTasks.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.HR.My.Resources.Resources.plus_26
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.HR.My.Resources.Resources.edit_24
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.HR.My.Resources.Resources.trash_24
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lblToDoTasks
        '
        Me.lblToDoTasks.AutoSize = True
        Me.lblToDoTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblToDoTasks.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDoTasks.Location = New System.Drawing.Point(5, 148)
        Me.lblToDoTasks.Name = "lblToDoTasks"
        Me.lblToDoTasks.Padding = New System.Windows.Forms.Padding(5)
        Me.lblToDoTasks.Size = New System.Drawing.Size(84, 26)
        Me.lblToDoTasks.TabIndex = 2
        Me.lblToDoTasks.Text = "ToDo Tasks"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 19)
        Me.Panel1.TabIndex = 1
        '
        'GrpNewTask
        '
        Me.GrpNewTask.Controls.Add(Me.TextBoxNewTask)
        Me.GrpNewTask.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpNewTask.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpNewTask.Location = New System.Drawing.Point(5, 5)
        Me.GrpNewTask.Name = "GrpNewTask"
        Me.GrpNewTask.Padding = New System.Windows.Forms.Padding(12)
        Me.GrpNewTask.Size = New System.Drawing.Size(231, 124)
        Me.GrpNewTask.TabIndex = 0
        Me.GrpNewTask.TabStop = False
        Me.GrpNewTask.Text = "New Task"
        '
        'TextBoxNewTask
        '
        Me.TextBoxNewTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNewTask.Location = New System.Drawing.Point(12, 28)
        Me.TextBoxNewTask.MaxLength = 120
        Me.TextBoxNewTask.Multiline = True
        Me.TextBoxNewTask.Name = "TextBoxNewTask"
        Me.TextBoxNewTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNewTask.Size = New System.Drawing.Size(207, 84)
        Me.TextBoxNewTask.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(5, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(260, 467)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBoxCompletedTasks)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(252, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Today"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBoxCompletedTasks
        '
        Me.ListBoxCompletedTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCompletedTasks.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCompletedTasks.ForeColor = System.Drawing.Color.White
        Me.ListBoxCompletedTasks.FormattingEnabled = True
        Me.ListBoxCompletedTasks.ItemHeight = 18
        Me.ListBoxCompletedTasks.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxCompletedTasks.Name = "ListBoxCompletedTasks"
        Me.ListBoxCompletedTasks.Size = New System.Drawing.Size(246, 432)
        Me.ListBoxCompletedTasks.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(252, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Yesterday"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(252, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Previous"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblCompletedTasks
        '
        Me.lblCompletedTasks.AutoSize = True
        Me.lblCompletedTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCompletedTasks.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedTasks.Location = New System.Drawing.Point(5, 5)
        Me.lblCompletedTasks.Name = "lblCompletedTasks"
        Me.lblCompletedTasks.Padding = New System.Windows.Forms.Padding(5)
        Me.lblCompletedTasks.Size = New System.Drawing.Size(117, 26)
        Me.lblCompletedTasks.TabIndex = 3
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
        'FrmNewTasksV1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 554)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "FrmNewTasksV1"
        Me.ShowIcon = False
        Me.Text = "FrmNewTasks"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GrpNewTask.ResumeLayout(False)
        Me.GrpNewTask.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtNew As ToolStripButton
    Friend WithEvents BtEdit As ToolStripButton
    Friend WithEvents BtDelete As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuExit1 As ToolStripMenuItem
    Friend WithEvents TodoMenu As ToolStripMenuItem
    Friend WithEvents MenuItemNew As ToolStripMenuItem
    Friend WithEvents MenuItemEdit As ToolStripMenuItem
    Friend WithEvents MenuItemDelete As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CheckedListBoxToDoTasks As CheckedListBox
    Friend WithEvents lblToDoTasks As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GrpNewTask As GroupBox
    Friend WithEvents TextBoxNewTask As TextBox
    Friend WithEvents ListBoxCompletedTasks As ListBox
    Friend WithEvents lblCompletedTasks As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
