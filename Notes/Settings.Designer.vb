<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.button3 = New System.Windows.Forms.Button()
        Me.numericUpDownNotesQ = New System.Windows.Forms.NumericUpDown()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.labelNotesQ = New System.Windows.Forms.Label()
        Me.buttonDefault = New System.Windows.Forms.Button()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.numericUpDownNotesQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.button3, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.numericUpDownNotesQ, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.labelNotesQ, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonDefault, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonSave, 1, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(231, 119)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(118, 33)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(90, 23)
        Me.button3.TabIndex = 12
        Me.button3.Text = "   HotKeys..."
        Me.button3.UseVisualStyleBackColor = True
        '
        'numericUpDownNotesQ
        '
        Me.numericUpDownNotesQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numericUpDownNotesQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numericUpDownNotesQ.Location = New System.Drawing.Point(118, 5)
        Me.numericUpDownNotesQ.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDownNotesQ.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDownNotesQ.Name = "numericUpDownNotesQ"
        Me.numericUpDownNotesQ.Size = New System.Drawing.Size(110, 20)
        Me.numericUpDownNotesQ.TabIndex = 9
        Me.numericUpDownNotesQ.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'buttonSave
        '
        Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSave.Image = CType(resources.GetObject("buttonSave.Image"), System.Drawing.Image)
        Me.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSave.Location = New System.Drawing.Point(126, 93)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(94, 24)
        Me.buttonSave.TabIndex = 7
        Me.buttonSave.Text = "   Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(3, 33)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(90, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Font..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(3, 63)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(90, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Color.."
        Me.button2.UseVisualStyleBackColor = True
        '
        'labelNotesQ
        '
        Me.labelNotesQ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelNotesQ.AutoSize = True
        Me.labelNotesQ.Location = New System.Drawing.Point(3, 8)
        Me.labelNotesQ.Name = "labelNotesQ"
        Me.labelNotesQ.Size = New System.Drawing.Size(90, 13)
        Me.labelNotesQ.TabIndex = 8
        Me.labelNotesQ.Text = "Max q-ty of Notes"
        '
        'buttonDefault
        '
        Me.buttonDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.buttonDefault.AutoSize = True
        Me.buttonDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonDefault.Image = CType(resources.GetObject("buttonDefault.Image"), System.Drawing.Image)
        Me.buttonDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDefault.Location = New System.Drawing.Point(3, 93)
        Me.buttonDefault.Name = "buttonDefault"
        Me.buttonDefault.Size = New System.Drawing.Size(108, 24)
        Me.buttonDefault.TabIndex = 7
        Me.buttonDefault.Text = "     Restore Default"
        Me.buttonDefault.UseVisualStyleBackColor = True
        '
        'fontDialog1
        '
        Me.fontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 119)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        CType(Me.numericUpDownNotesQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents button3 As Button
    Private WithEvents numericUpDownNotesQ As NumericUpDown
    Private WithEvents buttonSave As Button
    Private WithEvents button1 As Button
    Private WithEvents button2 As Button
    Private WithEvents labelNotesQ As Label
    Private WithEvents buttonDefault As Button
    Private WithEvents fontDialog1 As FontDialog
    Private WithEvents colorDialog1 As ColorDialog
End Class
