<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowSetFlags
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbFlags2 = New System.Windows.Forms.ListBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lbFlags1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(195, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 27)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSet.FlatAppearance.BorderSize = 0
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Location = New System.Drawing.Point(8, 287)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(140, 27)
        Me.btnSet.TabIndex = 34
        Me.btnSet.Text = "Set flags"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnDelAll
        '
        Me.btnDelAll.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDelAll.FlatAppearance.BorderSize = 0
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.ForeColor = System.Drawing.Color.White
        Me.btnDelAll.Location = New System.Drawing.Point(155, 225)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(33, 27)
        Me.btnDelAll.TabIndex = 33
        Me.btnDelAll.Text = ">>"
        Me.btnDelAll.UseVisualStyleBackColor = False
        '
        'btnAddAll
        '
        Me.btnAddAll.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAddAll.FlatAppearance.BorderSize = 0
        Me.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAll.ForeColor = System.Drawing.Color.White
        Me.btnAddAll.Location = New System.Drawing.Point(155, 143)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(33, 27)
        Me.btnAddAll.TabIndex = 32
        Me.btnAddAll.Text = "<<"
        Me.btnAddAll.UseVisualStyleBackColor = False
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Add Flags", "Delete Flags", "Set Flags"})
        Me.comboBox1.Location = New System.Drawing.Point(67, 15)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(203, 23)
        Me.comboBox1.TabIndex = 31
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(195, 46)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 15)
        Me.label3.TabIndex = 30
        Me.label3.Text = "label3"
        '
        'lbFlags2
        '
        Me.lbFlags2.FormattingEnabled = True
        Me.lbFlags2.ItemHeight = 15
        Me.lbFlags2.Location = New System.Drawing.Point(195, 66)
        Me.lbFlags2.Name = "lbFlags2"
        Me.lbFlags2.Size = New System.Drawing.Size(139, 214)
        Me.lbFlags2.TabIndex = 29
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(155, 191)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(33, 27)
        Me.btnDel.TabIndex = 28
        Me.btnDel.Text = ">"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(155, 110)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(33, 27)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "<"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 15)
        Me.label2.TabIndex = 26
        Me.label2.Text = "Mode: "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 15)
        Me.label1.TabIndex = 25
        Me.label1.Text = "label1"
        '
        'lbFlags1
        '
        Me.lbFlags1.FormattingEnabled = True
        Me.lbFlags1.ItemHeight = 15
        Me.lbFlags1.Location = New System.Drawing.Point(8, 66)
        Me.lbFlags1.Name = "lbFlags1"
        Me.lbFlags1.Size = New System.Drawing.Size(139, 214)
        Me.lbFlags1.TabIndex = 24
        '
        'ShowSetFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 335)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnAddAll)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lbFlags2)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lbFlags1)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ShowSetFlags"
        Me.Text = "ShowSetFlags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCancel As Button
    Private WithEvents btnSet As Button
    Private WithEvents btnDelAll As Button
    Private WithEvents btnAddAll As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents lbFlags2 As ListBox
    Private WithEvents btnDel As Button
    Private WithEvents btnAdd As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents lbFlags1 As ListBox
End Class
