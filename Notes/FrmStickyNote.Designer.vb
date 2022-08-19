<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStickyNote
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtFontColor = New System.Windows.Forms.Button()
        Me.BtFontSize = New System.Windows.Forms.Button()
        Me.BtStrikeThrough = New System.Windows.Forms.Button()
        Me.BtUnderline = New System.Windows.Forms.Button()
        Me.BtBullets = New System.Windows.Forms.Button()
        Me.BtItalic = New System.Windows.Forms.Button()
        Me.BtBold = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtAdd = New System.Windows.Forms.Button()
        Me.BtMoreColors = New System.Windows.Forms.Button()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.PanelForUCNote = New System.Windows.Forms.Panel()
        Me.PanelOFColors = New System.Windows.Forms.Panel()
        Me.BtBlue = New System.Windows.Forms.Button()
        Me.BtPink = New System.Windows.Forms.Button()
        Me.BtGreen = New System.Windows.Forms.Button()
        Me.BtYellow = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelForUCNote.SuspendLayout()
        Me.PanelOFColors.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtFontColor)
        Me.Panel2.Controls.Add(Me.BtFontSize)
        Me.Panel2.Controls.Add(Me.BtStrikeThrough)
        Me.Panel2.Controls.Add(Me.BtUnderline)
        Me.Panel2.Controls.Add(Me.BtBullets)
        Me.Panel2.Controls.Add(Me.BtItalic)
        Me.Panel2.Controls.Add(Me.BtBold)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 46)
        Me.Panel2.TabIndex = 3
        '
        'BtFontColor
        '
        Me.BtFontColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtFontColor.FlatAppearance.BorderSize = 0
        Me.BtFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFontColor.Image = Global.HR.My.Resources.Resources.font
        Me.BtFontColor.Location = New System.Drawing.Point(260, 7)
        Me.BtFontColor.Name = "BtFontColor"
        Me.BtFontColor.Size = New System.Drawing.Size(28, 30)
        Me.BtFontColor.TabIndex = 8
        Me.BtFontColor.UseVisualStyleBackColor = True
        '
        'BtFontSize
        '
        Me.BtFontSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtFontSize.FlatAppearance.BorderSize = 0
        Me.BtFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFontSize.Image = Global.HR.My.Resources.Resources.ui
        Me.BtFontSize.Location = New System.Drawing.Point(217, 7)
        Me.BtFontSize.Name = "BtFontSize"
        Me.BtFontSize.Size = New System.Drawing.Size(28, 30)
        Me.BtFontSize.TabIndex = 7
        Me.BtFontSize.UseVisualStyleBackColor = True
        '
        'BtStrikeThrough
        '
        Me.BtStrikeThrough.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtStrikeThrough.FlatAppearance.BorderSize = 0
        Me.BtStrikeThrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtStrikeThrough.Image = Global.HR.My.Resources.Resources.strikethrough
        Me.BtStrikeThrough.Location = New System.Drawing.Point(131, 7)
        Me.BtStrikeThrough.Name = "BtStrikeThrough"
        Me.BtStrikeThrough.Size = New System.Drawing.Size(28, 30)
        Me.BtStrikeThrough.TabIndex = 6
        Me.BtStrikeThrough.UseVisualStyleBackColor = True
        '
        'BtUnderline
        '
        Me.BtUnderline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtUnderline.FlatAppearance.BorderSize = 0
        Me.BtUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtUnderline.Image = Global.HR.My.Resources.Resources.underline
        Me.BtUnderline.Location = New System.Drawing.Point(88, 7)
        Me.BtUnderline.Name = "BtUnderline"
        Me.BtUnderline.Size = New System.Drawing.Size(28, 30)
        Me.BtUnderline.TabIndex = 5
        Me.BtUnderline.UseVisualStyleBackColor = True
        '
        'BtBullets
        '
        Me.BtBullets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBullets.FlatAppearance.BorderSize = 0
        Me.BtBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBullets.Image = Global.HR.My.Resources.Resources.bullet_list
        Me.BtBullets.Location = New System.Drawing.Point(174, 7)
        Me.BtBullets.Name = "BtBullets"
        Me.BtBullets.Size = New System.Drawing.Size(28, 30)
        Me.BtBullets.TabIndex = 4
        Me.BtBullets.UseVisualStyleBackColor = True
        '
        'BtItalic
        '
        Me.BtItalic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtItalic.FlatAppearance.BorderSize = 0
        Me.BtItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtItalic.Image = Global.HR.My.Resources.Resources.edit_tools
        Me.BtItalic.Location = New System.Drawing.Point(45, 7)
        Me.BtItalic.Name = "BtItalic"
        Me.BtItalic.Size = New System.Drawing.Size(28, 30)
        Me.BtItalic.TabIndex = 3
        Me.BtItalic.UseVisualStyleBackColor = True
        '
        'BtBold
        '
        Me.BtBold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBold.FlatAppearance.BorderSize = 0
        Me.BtBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBold.Image = Global.HR.My.Resources.Resources.bold
        Me.BtBold.Location = New System.Drawing.Point(2, 7)
        Me.BtBold.Name = "BtBold"
        Me.BtBold.Size = New System.Drawing.Size(28, 30)
        Me.BtBold.TabIndex = 2
        Me.BtBold.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtAdd)
        Me.Panel1.Controls.Add(Me.BtMoreColors)
        Me.Panel1.Controls.Add(Me.BtClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 39)
        Me.Panel1.TabIndex = 2
        '
        'BtAdd
        '
        Me.BtAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtAdd.FlatAppearance.BorderSize = 0
        Me.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAdd.Image = Global.HR.My.Resources.Resources.plus
        Me.BtAdd.Location = New System.Drawing.Point(2, 4)
        Me.BtAdd.Name = "BtAdd"
        Me.BtAdd.Size = New System.Drawing.Size(28, 30)
        Me.BtAdd.TabIndex = 1
        Me.BtAdd.UseVisualStyleBackColor = True
        Me.BtAdd.Visible = False
        '
        'BtMoreColors
        '
        Me.BtMoreColors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMoreColors.FlatAppearance.BorderSize = 0
        Me.BtMoreColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtMoreColors.Image = Global.HR.My.Resources.Resources.more
        Me.BtMoreColors.Location = New System.Drawing.Point(218, 4)
        Me.BtMoreColors.Name = "BtMoreColors"
        Me.BtMoreColors.Size = New System.Drawing.Size(28, 30)
        Me.BtMoreColors.TabIndex = 1
        Me.BtMoreColors.UseVisualStyleBackColor = True
        '
        'BtClose
        '
        Me.BtClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtClose.FlatAppearance.BorderSize = 0
        Me.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtClose.Image = Global.HR.My.Resources.Resources.close1
        Me.BtClose.Location = New System.Drawing.Point(262, 4)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(28, 30)
        Me.BtClose.TabIndex = 0
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'PanelForUCNote
        '
        Me.PanelForUCNote.Controls.Add(Me.PanelOFColors)
        Me.PanelForUCNote.Controls.Add(Me.RichTextBox1)
        Me.PanelForUCNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForUCNote.Location = New System.Drawing.Point(0, 39)
        Me.PanelForUCNote.Name = "PanelForUCNote"
        Me.PanelForUCNote.Size = New System.Drawing.Size(294, 216)
        Me.PanelForUCNote.TabIndex = 4
        '
        'PanelOFColors
        '
        Me.PanelOFColors.Controls.Add(Me.BtBlue)
        Me.PanelOFColors.Controls.Add(Me.BtPink)
        Me.PanelOFColors.Controls.Add(Me.BtGreen)
        Me.PanelOFColors.Controls.Add(Me.BtYellow)
        Me.PanelOFColors.Location = New System.Drawing.Point(0, 0)
        Me.PanelOFColors.Name = "PanelOFColors"
        Me.PanelOFColors.Size = New System.Drawing.Size(294, 39)
        Me.PanelOFColors.TabIndex = 2
        '
        'BtBlue
        '
        Me.BtBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BtBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBlue.FlatAppearance.BorderSize = 0
        Me.BtBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBlue.Location = New System.Drawing.Point(147, 1)
        Me.BtBlue.Name = "BtBlue"
        Me.BtBlue.Size = New System.Drawing.Size(72, 36)
        Me.BtBlue.TabIndex = 5
        Me.BtBlue.UseVisualStyleBackColor = False
        '
        'BtPink
        '
        Me.BtPink.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BtPink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtPink.FlatAppearance.BorderSize = 0
        Me.BtPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPink.Location = New System.Drawing.Point(219, 1)
        Me.BtPink.Name = "BtPink"
        Me.BtPink.Size = New System.Drawing.Size(72, 36)
        Me.BtPink.TabIndex = 4
        Me.BtPink.UseVisualStyleBackColor = False
        '
        'BtGreen
        '
        Me.BtGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtGreen.FlatAppearance.BorderSize = 0
        Me.BtGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtGreen.Location = New System.Drawing.Point(74, 1)
        Me.BtGreen.Name = "BtGreen"
        Me.BtGreen.Size = New System.Drawing.Size(72, 36)
        Me.BtGreen.TabIndex = 3
        Me.BtGreen.UseVisualStyleBackColor = False
        '
        'BtYellow
        '
        Me.BtYellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtYellow.FlatAppearance.BorderSize = 0
        Me.BtYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtYellow.Location = New System.Drawing.Point(1, 1)
        Me.BtYellow.Name = "BtYellow"
        Me.BtYellow.Size = New System.Drawing.Size(72, 36)
        Me.BtYellow.TabIndex = 2
        Me.BtYellow.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(294, 216)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'FrmStickyNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 301)
        Me.Controls.Add(Me.PanelForUCNote)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStickyNote"
        Me.Text = "FrmStickyNote"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelForUCNote.ResumeLayout(False)
        Me.PanelOFColors.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtBullets As Button
    Friend WithEvents BtItalic As Button
    Friend WithEvents BtBold As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtAdd As Button
    Friend WithEvents BtMoreColors As Button
    Friend WithEvents BtClose As Button
    Friend WithEvents PanelForUCNote As Panel
    Friend WithEvents PanelOFColors As Panel
    Friend WithEvents BtBlue As Button
    Friend WithEvents BtPink As Button
    Friend WithEvents BtGreen As Button
    Friend WithEvents BtYellow As Button
    Friend WithEvents BtStrikeThrough As Button
    Friend WithEvents BtUnderline As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtFontColor As Button
    Friend WithEvents BtFontSize As Button
End Class
