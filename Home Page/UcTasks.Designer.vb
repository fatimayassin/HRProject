<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcTasks
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
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.BtTasks = New System.Windows.Forms.Button()
        Me.BtToDoList = New System.Windows.Forms.Button()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox3.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox3.ForeColor = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox3.TabIndex = 25
        Me.UltraExpandableGroupBox3.Text = "My Tasks"
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.BtTasks)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.BtToDoList)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(205, 418)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'BtTasks
        '
        Me.BtTasks.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtTasks.FlatAppearance.BorderSize = 0
        Me.BtTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtTasks.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTasks.ForeColor = System.Drawing.Color.White
        Me.BtTasks.Image = Global.HR.My.Resources.Resources.icons8_kackstiftaufpapier_24
        Me.BtTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtTasks.Location = New System.Drawing.Point(0, 40)
        Me.BtTasks.Name = "BtTasks"
        Me.BtTasks.Size = New System.Drawing.Size(205, 40)
        Me.BtTasks.TabIndex = 7
        Me.BtTasks.Text = "           Tasks "
        Me.BtTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtTasks.UseVisualStyleBackColor = False
        '
        'BtToDoList
        '
        Me.BtToDoList.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtToDoList.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtToDoList.FlatAppearance.BorderSize = 0
        Me.BtToDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtToDoList.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtToDoList.ForeColor = System.Drawing.Color.White
        Me.BtToDoList.Image = Global.HR.My.Resources.Resources.icons8_add_list_24
        Me.BtToDoList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoList.Location = New System.Drawing.Point(0, 0)
        Me.BtToDoList.Name = "BtToDoList"
        Me.BtToDoList.Size = New System.Drawing.Size(205, 40)
        Me.BtToDoList.TabIndex = 6
        Me.BtToDoList.Text = "           To-Do List"
        Me.BtToDoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoList.UseVisualStyleBackColor = False
        '
        'UcTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.Name = "UcTasks"
        Me.Size = New System.Drawing.Size(211, 441)
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents BtTasks As Button
    Friend WithEvents BtToDoList As Button
End Class
