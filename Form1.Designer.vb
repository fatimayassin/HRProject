<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1Refresh = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSize = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraSplitter3 = New Infragistics.Win.Misc.UltraSplitter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel14 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel15 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel16 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel18 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel19 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel17 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel20 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UltraSplitter2 = New Infragistics.Win.Misc.UltraSplitter()
        Me.UcHeader1 = New HR.UCHeader2()
        Me.UcHeaderTop1 = New HR.UCHeaderTop()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1Refresh
        '
        Me.Timer1Refresh.Interval = 1000
        '
        'TimerSize
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UcHeaderTop1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1130, 30)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UcHeader1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1130, 135)
        Me.Panel2.TabIndex = 14
        '
        'UltraSplitter3
        '
        Me.UltraSplitter3.BackColor = System.Drawing.Color.White
        Me.UltraSplitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraSplitter3.Location = New System.Drawing.Point(0, 175)
        Me.UltraSplitter3.MinExtra = 517
        Me.UltraSplitter3.Name = "UltraSplitter3"
        Me.UltraSplitter3.RestoreExtent = 67
        Me.UltraSplitter3.Size = New System.Drawing.Size(1130, 12)
        Me.UltraSplitter3.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StatusStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 636)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1130, 24)
        Me.Panel3.TabIndex = 16
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Blue
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel11, Me.ToolStripStatusLabel14, Me.ToolStripStatusLabel13, Me.ToolStripStatusLabel15, Me.ToolStripStatusLabel16, Me.ToolStripStatusLabel18, Me.ToolStripStatusLabel19, Me.ToolStripStatusLabel17, Me.ToolStripStatusLabel20, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel12})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1130, 24)
        Me.StatusStrip1.TabIndex = 93
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(35, 19)
        Me.lblUser.Text = "User"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel8.Text = "                                  "
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel9.Text = "                                  "
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel10.Text = "                                  "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(78, 19)
        Me.ToolStripStatusLabel3.Text = "Date - Time"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel2.Text = "                                  "
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel11.Text = "                                  "
        '
        'ToolStripStatusLabel14
        '
        Me.ToolStripStatusLabel14.Name = "ToolStripStatusLabel14"
        Me.ToolStripStatusLabel14.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel15
        '
        Me.ToolStripStatusLabel15.Name = "ToolStripStatusLabel15"
        Me.ToolStripStatusLabel15.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel16
        '
        Me.ToolStripStatusLabel16.Name = "ToolStripStatusLabel16"
        Me.ToolStripStatusLabel16.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel18
        '
        Me.ToolStripStatusLabel18.Name = "ToolStripStatusLabel18"
        Me.ToolStripStatusLabel18.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel19
        '
        Me.ToolStripStatusLabel19.Name = "ToolStripStatusLabel19"
        Me.ToolStripStatusLabel19.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel17
        '
        Me.ToolStripStatusLabel17.Name = "ToolStripStatusLabel17"
        Me.ToolStripStatusLabel17.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel20
        '
        Me.ToolStripStatusLabel20.Name = "ToolStripStatusLabel20"
        Me.ToolStripStatusLabel20.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Enabled = False
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(75, 19)
        Me.ToolStripStatusLabel7.Text = "                                  "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(127, 19)
        Me.ToolStripStatusLabel1.Text = "InfinitySoft - Integra"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel6.Text = "© 2020"
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel12.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(0, 19)
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1130, 449)
        Me.Panel4.TabIndex = 17
        '
        'UltraSplitter2
        '
        Me.UltraSplitter2.BackColor = System.Drawing.Color.White
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraSplitter2.ButtonAppearance = Appearance1
        Me.UltraSplitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraSplitter2.Location = New System.Drawing.Point(0, 30)
        Me.UltraSplitter2.Name = "UltraSplitter2"
        Me.UltraSplitter2.RestoreExtent = 30
        Me.UltraSplitter2.Size = New System.Drawing.Size(1130, 10)
        Me.UltraSplitter2.TabIndex = 13
        Me.UltraSplitter2.Visible = False
        '
        'UcHeader1
        '
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1130, 135)
        Me.UcHeader1.TabIndex = 0
        '
        'UcHeaderTop1
        '
        Me.UcHeaderTop1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcHeaderTop1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeaderTop1.Name = "UcHeaderTop1"
        Me.UcHeaderTop1.Size = New System.Drawing.Size(1130, 30)
        Me.UcHeaderTop1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1130, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UltraSplitter3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.UltraSplitter2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1Refresh As Timer
    Friend WithEvents TimerSize As Timer
    Public WithEvents Panelsize As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UcHeaderTop1 As UCHeaderTop
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UcHeader1 As UCHeader2
    Friend WithEvents UltraSplitter3 As Infragistics.Win.Misc.UltraSplitter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As ToolStripStatusLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStripStatusLabel14 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel15 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel16 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel18 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel19 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel17 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel20 As ToolStripStatusLabel
    Friend WithEvents UltraSplitter2 As Infragistics.Win.Misc.UltraSplitter
End Class
