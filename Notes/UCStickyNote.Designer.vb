<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStickyNote
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCStickyNote))
        Me.notifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuStripStickMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripMenuItemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemHotKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripMenuItemHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerDate = New System.Windows.Forms.Timer(Me.components)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.checkBoxOpen = New System.Windows.Forms.CheckBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.buttonSettings = New System.Windows.Forms.Button()
        Me.buttonSaveNote = New System.Windows.Forms.Button()
        Me.buttonClearNote = New System.Windows.Forms.Button()
        Me.buttonAddNewNote = New System.Windows.Forms.Button()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBoxOnTop = New System.Windows.Forms.CheckBox()
        Me.labelCurrDateTime = New System.Windows.Forms.Label()
        Me.contextMenuStripStickMain.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'notifyIconMain
        '
        Me.notifyIconMain.ContextMenuStrip = Me.contextMenuStripStickMain
        Me.notifyIconMain.Icon = CType(resources.GetObject("notifyIconMain.Icon"), System.Drawing.Icon)
        Me.notifyIconMain.Text = "notifyIconThis"
        Me.notifyIconMain.Visible = True
        '
        'contextMenuStripStickMain
        '
        Me.contextMenuStripStickMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemAbout, Me.toolStripMenuItemHelp, Me.toolStripSeparator3, Me.toolStripMenuItemSettings, Me.toolStripMenuItemHotKey, Me.toolStripSeparator1, Me.toolStripMenuItemHide, Me.toolStripMenuItemShow, Me.toolStripSeparator2, Me.toolStripMenuItemExit})
        Me.contextMenuStripStickMain.Name = "contextMenuStripStickMain"
        Me.contextMenuStripStickMain.Size = New System.Drawing.Size(126, 176)
        '
        'toolStripMenuItemAbout
        '
        Me.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout"
        Me.toolStripMenuItemAbout.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemAbout.Text = "About"
        '
        'toolStripMenuItemHelp
        '
        Me.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp"
        Me.toolStripMenuItemHelp.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemHelp.Text = "Help"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(122, 6)
        '
        'toolStripMenuItemSettings
        '
        Me.toolStripMenuItemSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemFont, Me.toolStripMenuItemColor})
        Me.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings"
        Me.toolStripMenuItemSettings.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemSettings.Text = "Settings..."
        '
        'toolStripMenuItemFont
        '
        Me.toolStripMenuItemFont.Name = "toolStripMenuItemFont"
        Me.toolStripMenuItemFont.Size = New System.Drawing.Size(112, 22)
        Me.toolStripMenuItemFont.Text = "Font..."
        '
        'toolStripMenuItemColor
        '
        Me.toolStripMenuItemColor.Name = "toolStripMenuItemColor"
        Me.toolStripMenuItemColor.Size = New System.Drawing.Size(112, 22)
        Me.toolStripMenuItemColor.Text = "Color..."
        '
        'toolStripMenuItemHotKey
        '
        Me.toolStripMenuItemHotKey.Name = "toolStripMenuItemHotKey"
        Me.toolStripMenuItemHotKey.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemHotKey.Text = "HotKey"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'toolStripMenuItemHide
        '
        Me.toolStripMenuItemHide.Name = "toolStripMenuItemHide"
        Me.toolStripMenuItemHide.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemHide.Text = "Hide"
        '
        'toolStripMenuItemShow
        '
        Me.toolStripMenuItemShow.Name = "toolStripMenuItemShow"
        Me.toolStripMenuItemShow.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemShow.Text = "Show"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(122, 6)
        '
        'toolStripMenuItemExit
        '
        Me.toolStripMenuItemExit.Name = "toolStripMenuItemExit"
        Me.toolStripMenuItemExit.Size = New System.Drawing.Size(125, 22)
        Me.toolStripMenuItemExit.Text = "Exit"
        '
        'timerDate
        '
        Me.timerDate.Interval = 50
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog"
        Me.openFileDialog1.Filter = "Text files |*.txt"
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "txt"
        Me.saveFileDialog1.Filter = "Text files| *.txt"
        '
        'fontDialog1
        '
        Me.fontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.ContextMenuStrip = Me.contextMenuStripStickMain
        Me.splitContainer1.Panel1.Controls.Add(Me.checkBoxOpen)
        Me.splitContainer1.Panel1.Controls.Add(Me.textBox1)
        Me.splitContainer1.Panel1.Controls.Add(Me.buttonSettings)
        Me.splitContainer1.Panel1.Controls.Add(Me.buttonSaveNote)
        Me.splitContainer1.Panel1.Controls.Add(Me.buttonClearNote)
        Me.splitContainer1.Panel1.Controls.Add(Me.buttonAddNewNote)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.ContextMenuStrip = Me.contextMenuStripStickMain
        Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.checkBoxOnTop)
        Me.splitContainer1.Panel2.Controls.Add(Me.labelCurrDateTime)
        Me.splitContainer1.Size = New System.Drawing.Size(350, 320)
        Me.splitContainer1.SplitterDistance = 282
        Me.splitContainer1.TabIndex = 1
        '
        'checkBoxOpen
        '
        Me.checkBoxOpen.AutoSize = True
        Me.checkBoxOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.checkBoxOpen.Location = New System.Drawing.Point(295, 57)
        Me.checkBoxOpen.Name = "checkBoxOpen"
        Me.checkBoxOpen.Size = New System.Drawing.Size(40, 14)
        Me.checkBoxOpen.TabIndex = 3
        Me.checkBoxOpen.Text = "open"
        Me.checkBoxOpen.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.MaxLength = 500
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(291, 282)
        Me.textBox1.TabIndex = 1
        '
        'buttonSettings
        '
        Me.buttonSettings.BackColor = System.Drawing.Color.Transparent
        Me.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSettings.Image = CType(resources.GetObject("buttonSettings.Image"), System.Drawing.Image)
        Me.buttonSettings.Location = New System.Drawing.Point(295, 186)
        Me.buttonSettings.Margin = New System.Windows.Forms.Padding(1)
        Me.buttonSettings.Name = "buttonSettings"
        Me.buttonSettings.Size = New System.Drawing.Size(50, 50)
        Me.buttonSettings.TabIndex = 5
        Me.buttonSettings.UseVisualStyleBackColor = False
        '
        'buttonSaveNote
        '
        Me.buttonSaveNote.BackColor = System.Drawing.Color.Transparent
        Me.buttonSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSaveNote.Image = CType(resources.GetObject("buttonSaveNote.Image"), System.Drawing.Image)
        Me.buttonSaveNote.Location = New System.Drawing.Point(295, 134)
        Me.buttonSaveNote.Margin = New System.Windows.Forms.Padding(1)
        Me.buttonSaveNote.Name = "buttonSaveNote"
        Me.buttonSaveNote.Size = New System.Drawing.Size(50, 50)
        Me.buttonSaveNote.TabIndex = 4
        Me.buttonSaveNote.UseVisualStyleBackColor = False
        '
        'buttonClearNote
        '
        Me.buttonClearNote.BackColor = System.Drawing.Color.Transparent
        Me.buttonClearNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClearNote.Image = CType(resources.GetObject("buttonClearNote.Image"), System.Drawing.Image)
        Me.buttonClearNote.Location = New System.Drawing.Point(295, 82)
        Me.buttonClearNote.Margin = New System.Windows.Forms.Padding(1)
        Me.buttonClearNote.Name = "buttonClearNote"
        Me.buttonClearNote.Size = New System.Drawing.Size(50, 50)
        Me.buttonClearNote.TabIndex = 3
        Me.buttonClearNote.UseVisualStyleBackColor = False
        '
        'buttonAddNewNote
        '
        Me.buttonAddNewNote.BackColor = System.Drawing.Color.Transparent
        Me.buttonAddNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAddNewNote.Image = CType(resources.GetObject("buttonAddNewNote.Image"), System.Drawing.Image)
        Me.buttonAddNewNote.Location = New System.Drawing.Point(295, 3)
        Me.buttonAddNewNote.Margin = New System.Windows.Forms.Padding(1)
        Me.buttonAddNewNote.Name = "buttonAddNewNote"
        Me.buttonAddNewNote.Size = New System.Drawing.Size(50, 50)
        Me.buttonAddNewNote.TabIndex = 2
        Me.buttonAddNewNote.UseVisualStyleBackColor = False
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(227, 17)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(59, 14)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "hide Panel"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'checkBoxOnTop
        '
        Me.checkBoxOnTop.AutoSize = True
        Me.checkBoxOnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.checkBoxOnTop.Location = New System.Drawing.Point(227, 3)
        Me.checkBoxOnTop.Name = "checkBoxOnTop"
        Me.checkBoxOnTop.Size = New System.Drawing.Size(44, 14)
        Me.checkBoxOnTop.TabIndex = 2
        Me.checkBoxOnTop.Text = "on top"
        Me.checkBoxOnTop.UseVisualStyleBackColor = True
        Me.checkBoxOnTop.Visible = False
        '
        'labelCurrDateTime
        '
        Me.labelCurrDateTime.AutoSize = True
        Me.labelCurrDateTime.BackColor = System.Drawing.Color.Transparent
        Me.labelCurrDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelCurrDateTime.Location = New System.Drawing.Point(12, 9)
        Me.labelCurrDateTime.Name = "labelCurrDateTime"
        Me.labelCurrDateTime.Size = New System.Drawing.Size(82, 20)
        Me.labelCurrDateTime.TabIndex = 1
        Me.labelCurrDateTime.Text = "Date Time"
        Me.labelCurrDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UCStickyNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "UCStickyNote"
        Me.Size = New System.Drawing.Size(350, 320)
        Me.contextMenuStripStickMain.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents notifyIconMain As NotifyIcon
    Private WithEvents contextMenuStripStickMain As ContextMenuStrip
    Private WithEvents toolStripMenuItemAbout As ToolStripMenuItem
    Private WithEvents toolStripMenuItemHelp As ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents toolStripMenuItemSettings As ToolStripMenuItem
    Private WithEvents toolStripMenuItemFont As ToolStripMenuItem
    Private WithEvents toolStripMenuItemColor As ToolStripMenuItem
    Private WithEvents toolStripMenuItemHotKey As ToolStripMenuItem
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents toolStripMenuItemHide As ToolStripMenuItem
    Private WithEvents toolStripMenuItemShow As ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As ToolStripSeparator
    Private WithEvents toolStripMenuItemExit As ToolStripMenuItem
    Private WithEvents timerDate As Timer
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents saveFileDialog1 As SaveFileDialog
    Private WithEvents fontDialog1 As FontDialog
    Private WithEvents colorDialog1 As ColorDialog
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents checkBoxOpen As CheckBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents buttonSettings As Button
    Private WithEvents buttonSaveNote As Button
    Private WithEvents buttonClearNote As Button
    Private WithEvents buttonAddNewNote As Button
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents checkBoxOnTop As CheckBox
    Private WithEvents labelCurrDateTime As Label
End Class
