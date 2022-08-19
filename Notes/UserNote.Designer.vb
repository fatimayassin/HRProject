<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserNote
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.PanelForUCNote = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtBullets = New System.Windows.Forms.Button()
        Me.BtBold = New System.Windows.Forms.Button()
        Me.BtFontColor = New System.Windows.Forms.Button()
        Me.BtItalic = New System.Windows.Forms.Button()
        Me.BtUnderline = New System.Windows.Forms.Button()
        Me.BtStrikeThrough = New System.Windows.Forms.Button()
        Me.BtFontSize = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelForUCNote.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 33)
        Me.Panel1.TabIndex = 3
        '
        'BtClose
        '
        Me.BtClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtClose.FlatAppearance.BorderSize = 0
        Me.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtClose.Image = Global.HR.My.Resources.Resources.close1
        Me.BtClose.Location = New System.Drawing.Point(273, 0)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(45, 33)
        Me.BtClose.TabIndex = 0
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'PanelForUCNote
        '
        Me.PanelForUCNote.Controls.Add(Me.RichTextBox1)
        Me.PanelForUCNote.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelForUCNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForUCNote.Location = New System.Drawing.Point(0, 33)
        Me.PanelForUCNote.Name = "PanelForUCNote"
        Me.PanelForUCNote.Size = New System.Drawing.Size(318, 284)
        Me.PanelForUCNote.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(318, 243)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtBullets, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtBold, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtFontColor, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtItalic, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtUnderline, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtStrikeThrough, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtFontSize, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 243)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(318, 41)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'BtBullets
        '
        Me.BtBullets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBullets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtBullets.FlatAppearance.BorderSize = 0
        Me.BtBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBullets.Image = Global.HR.My.Resources.Resources.bullet_list
        Me.BtBullets.Location = New System.Drawing.Point(273, 3)
        Me.BtBullets.Name = "BtBullets"
        Me.BtBullets.Size = New System.Drawing.Size(42, 35)
        Me.BtBullets.TabIndex = 8
        Me.BtBullets.UseVisualStyleBackColor = True
        '
        'BtBold
        '
        Me.BtBold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtBold.FlatAppearance.BorderSize = 0
        Me.BtBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBold.Image = Global.HR.My.Resources.Resources.bold
        Me.BtBold.Location = New System.Drawing.Point(3, 3)
        Me.BtBold.Name = "BtBold"
        Me.BtBold.Size = New System.Drawing.Size(39, 35)
        Me.BtBold.TabIndex = 3
        Me.BtBold.UseVisualStyleBackColor = True
        '
        'BtFontColor
        '
        Me.BtFontColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtFontColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtFontColor.FlatAppearance.BorderSize = 0
        Me.BtFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFontColor.Image = Global.HR.My.Resources.Resources.font
        Me.BtFontColor.Location = New System.Drawing.Point(228, 3)
        Me.BtFontColor.Name = "BtFontColor"
        Me.BtFontColor.Size = New System.Drawing.Size(39, 35)
        Me.BtFontColor.TabIndex = 10
        Me.BtFontColor.UseVisualStyleBackColor = True
        '
        'BtItalic
        '
        Me.BtItalic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtItalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtItalic.FlatAppearance.BorderSize = 0
        Me.BtItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtItalic.Image = Global.HR.My.Resources.Resources.edit_tools
        Me.BtItalic.Location = New System.Drawing.Point(48, 3)
        Me.BtItalic.Name = "BtItalic"
        Me.BtItalic.Size = New System.Drawing.Size(39, 35)
        Me.BtItalic.TabIndex = 4
        Me.BtItalic.UseVisualStyleBackColor = True
        '
        'BtUnderline
        '
        Me.BtUnderline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtUnderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtUnderline.FlatAppearance.BorderSize = 0
        Me.BtUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtUnderline.Image = Global.HR.My.Resources.Resources.underline
        Me.BtUnderline.Location = New System.Drawing.Point(93, 3)
        Me.BtUnderline.Name = "BtUnderline"
        Me.BtUnderline.Size = New System.Drawing.Size(39, 35)
        Me.BtUnderline.TabIndex = 6
        Me.BtUnderline.UseVisualStyleBackColor = True
        '
        'BtStrikeThrough
        '
        Me.BtStrikeThrough.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtStrikeThrough.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtStrikeThrough.FlatAppearance.BorderSize = 0
        Me.BtStrikeThrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtStrikeThrough.Image = Global.HR.My.Resources.Resources.strikethrough
        Me.BtStrikeThrough.Location = New System.Drawing.Point(138, 3)
        Me.BtStrikeThrough.Name = "BtStrikeThrough"
        Me.BtStrikeThrough.Size = New System.Drawing.Size(39, 35)
        Me.BtStrikeThrough.TabIndex = 7
        Me.BtStrikeThrough.UseVisualStyleBackColor = True
        '
        'BtFontSize
        '
        Me.BtFontSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtFontSize.FlatAppearance.BorderSize = 0
        Me.BtFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFontSize.Image = Global.HR.My.Resources.Resources.ui
        Me.BtFontSize.Location = New System.Drawing.Point(183, 3)
        Me.BtFontSize.Name = "BtFontSize"
        Me.BtFontSize.Size = New System.Drawing.Size(39, 35)
        Me.BtFontSize.TabIndex = 9
        Me.BtFontSize.UseVisualStyleBackColor = True
        '
        'UserNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelForUCNote)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserNote"
        Me.Size = New System.Drawing.Size(318, 317)
        Me.Panel1.ResumeLayout(False)
        Me.PanelForUCNote.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents PanelForUCNote As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtBullets As Button
    Friend WithEvents BtBold As Button
    Friend WithEvents BtFontColor As Button
    Friend WithEvents BtItalic As Button
    Friend WithEvents BtUnderline As Button
    Friend WithEvents BtStrikeThrough As Button
    Friend WithEvents BtFontSize As Button
End Class
