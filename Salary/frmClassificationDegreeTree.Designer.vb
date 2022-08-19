<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassificationDegreeTree
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TreeViewDepartments = New System.Windows.Forms.TreeView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemAddClass = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDegreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(440, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 54
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(468, 32)
        Me.lblText.TabIndex = 53
        Me.lblText.Text = "Classifications"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeViewDepartments
        '
        Me.TreeViewDepartments.Location = New System.Drawing.Point(6, 99)
        Me.TreeViewDepartments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeViewDepartments.Name = "TreeViewDepartments"
        Me.TreeViewDepartments.Size = New System.Drawing.Size(456, 377)
        Me.TreeViewDepartments.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 58)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(301, 23)
        Me.TextBox1.TabIndex = 56
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAddClass, Me.AddDegreeToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStripTasks"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(170, 92)
        '
        'ToolStripMenuItemAddClass
        '
        Me.ToolStripMenuItemAddClass.Name = "ToolStripMenuItemAddClass"
        Me.ToolStripMenuItemAddClass.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItemAddClass.Text = "Add Classification"
        '
        'AddDegreeToolStripMenuItem
        '
        Me.AddDegreeToolStripMenuItem.Name = "AddDegreeToolStripMenuItem"
        Me.AddDegreeToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddDegreeToolStripMenuItem.Text = "Add Degree"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(411, 482)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
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
        Me.BtnSearch.Location = New System.Drawing.Point(307, 56)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(46, 25)
        Me.BtnSearch.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.BtnSearch, "Search")
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'frmClassificationDegreeTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TreeViewDepartments)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClassificationDegreeTree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TreeViewDepartments As System.Windows.Forms.TreeView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddDegreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAddClass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
