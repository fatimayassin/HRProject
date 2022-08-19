<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcNotes
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
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.BtNotes = New System.Windows.Forms.Button()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExpandableGroupBox4
        '
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox4.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox4.ForeColor = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox4.TabIndex = 25
        Me.UltraExpandableGroupBox4.Text = "My Notes"
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.BtNotes)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(205, 418)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'BtNotes
        '
        Me.BtNotes.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtNotes.FlatAppearance.BorderSize = 0
        Me.BtNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNotes.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNotes.ForeColor = System.Drawing.Color.White
        Me.BtNotes.Image = Global.HR.My.Resources.Resources.icons8_create_document_24
        Me.BtNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotes.Location = New System.Drawing.Point(0, 0)
        Me.BtNotes.Name = "BtNotes"
        Me.BtNotes.Size = New System.Drawing.Size(205, 40)
        Me.BtNotes.TabIndex = 4
        Me.BtNotes.Text = "           Notes "
        Me.BtNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotes.UseVisualStyleBackColor = False
        '
        'UcNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.Name = "UcNotes"
        Me.Size = New System.Drawing.Size(211, 441)
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents BtNotes As Button
End Class
