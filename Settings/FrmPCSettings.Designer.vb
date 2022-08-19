<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPCSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtSaveChanges = New System.Windows.Forms.Button()
        Me.BtBackgroundCol = New System.Windows.Forms.Button()
        Me.BtPanelCol = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(585, 31)
        Me.lblText.TabIndex = 38
        Me.lblText.Text = "PC Settings"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(556, 3)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 39
        Me.lblClose.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(224, 74)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 33)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(224, 22)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 33)
        Me.Panel1.TabIndex = 44
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 227)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(577, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Theme"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BtSaveChanges)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.BtBackgroundCol)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.BtPanelCol)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 177)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Theme Colors"
        '
        'BtSaveChanges
        '
        Me.BtSaveChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtSaveChanges.FlatAppearance.BorderSize = 0
        Me.BtSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSaveChanges.ForeColor = System.Drawing.Color.White
        Me.BtSaveChanges.Location = New System.Drawing.Point(187, 136)
        Me.BtSaveChanges.Name = "BtSaveChanges"
        Me.BtSaveChanges.Size = New System.Drawing.Size(134, 27)
        Me.BtSaveChanges.TabIndex = 92
        Me.BtSaveChanges.Text = "Save Changes"
        Me.BtSaveChanges.UseVisualStyleBackColor = False
        '
        'BtBackgroundCol
        '
        Me.BtBackgroundCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtBackgroundCol.FlatAppearance.BorderSize = 0
        Me.BtBackgroundCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBackgroundCol.ForeColor = System.Drawing.Color.White
        Me.BtBackgroundCol.Location = New System.Drawing.Point(15, 80)
        Me.BtBackgroundCol.Name = "BtBackgroundCol"
        Me.BtBackgroundCol.Size = New System.Drawing.Size(193, 27)
        Me.BtBackgroundCol.TabIndex = 91
        Me.BtBackgroundCol.Text = "Change background Color"
        Me.BtBackgroundCol.UseVisualStyleBackColor = False
        '
        'BtPanelCol
        '
        Me.BtPanelCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtPanelCol.FlatAppearance.BorderSize = 0
        Me.BtPanelCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPanelCol.ForeColor = System.Drawing.Color.White
        Me.BtPanelCol.Location = New System.Drawing.Point(15, 28)
        Me.BtPanelCol.Name = "BtPanelCol"
        Me.BtPanelCol.Size = New System.Drawing.Size(193, 27)
        Me.BtPanelCol.TabIndex = 90
        Me.BtPanelCol.Text = "Change Panel's Color"
        Me.BtPanelCol.UseVisualStyleBackColor = False
        '
        'FrmPCSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPCSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtSaveChanges As Button
    Friend WithEvents BtBackgroundCol As Button
    Friend WithEvents BtPanelCol As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
