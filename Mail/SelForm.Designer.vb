<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelForm
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.trFolders = New System.Windows.Forms.TreeView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(149, 308)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 27)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(139, 15)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Select destination folder:"
        '
        'trFolders
        '
        Me.trFolders.Location = New System.Drawing.Point(26, 23)
        Me.trFolders.Name = "trFolders"
        Me.trFolders.Size = New System.Drawing.Size(202, 279)
        Me.trFolders.TabIndex = 13
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(44, 308)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(59, 27)
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "Copy"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'SelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 338)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.trFolders)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SelForm"
        Me.Text = "SelForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCancel As Button
    Private WithEvents label1 As Label
    Private WithEvents trFolders As TreeView
    Private WithEvents btnOk As Button
End Class
