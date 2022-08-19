<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPanel
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
        Me.PanelBack1 = New System.Windows.Forms.Panel()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.PanelCenterTasks = New System.Windows.Forms.Panel()
        Me.PanelCenterLeft = New System.Windows.Forms.Panel()
        Me.PanelCenterRight = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelLeftTop = New System.Windows.Forms.Panel()
        Me.PanelLeftBottom = New System.Windows.Forms.Panel()
        Me.PanelLeftLeft = New System.Windows.Forms.Panel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelRightBottom = New System.Windows.Forms.Panel()
        Me.PanelRightTop = New System.Windows.Forms.Panel()
        Me.PanelRightRight = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.PanelBack1.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.PanelRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBack1
        '
        Me.PanelBack1.Controls.Add(Me.PanelCenter)
        Me.PanelBack1.Controls.Add(Me.PanelLeft)
        Me.PanelBack1.Controls.Add(Me.PanelRight)
        Me.PanelBack1.Controls.Add(Me.PanelTop)
        Me.PanelBack1.Controls.Add(Me.PanelBottom)
        Me.PanelBack1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBack1.Location = New System.Drawing.Point(0, 0)
        Me.PanelBack1.Name = "PanelBack1"
        Me.PanelBack1.Size = New System.Drawing.Size(1098, 678)
        Me.PanelBack1.TabIndex = 0
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.PanelCenterTasks)
        Me.PanelCenter.Controls.Add(Me.PanelCenterLeft)
        Me.PanelCenter.Controls.Add(Me.PanelCenterRight)
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(327, 21)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(444, 636)
        Me.PanelCenter.TabIndex = 4
        '
        'PanelCenterTasks
        '
        Me.PanelCenterTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenterTasks.Location = New System.Drawing.Point(130, 0)
        Me.PanelCenterTasks.Name = "PanelCenterTasks"
        Me.PanelCenterTasks.Size = New System.Drawing.Size(184, 636)
        Me.PanelCenterTasks.TabIndex = 2
        '
        'PanelCenterLeft
        '
        Me.PanelCenterLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelCenterLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelCenterLeft.Name = "PanelCenterLeft"
        Me.PanelCenterLeft.Size = New System.Drawing.Size(130, 636)
        Me.PanelCenterLeft.TabIndex = 1
        '
        'PanelCenterRight
        '
        Me.PanelCenterRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCenterRight.Location = New System.Drawing.Point(314, 0)
        Me.PanelCenterRight.Name = "PanelCenterRight"
        Me.PanelCenterRight.Size = New System.Drawing.Size(130, 636)
        Me.PanelCenterRight.TabIndex = 0
        '
        'PanelLeft
        '
        Me.PanelLeft.Controls.Add(Me.PanelLeftTop)
        Me.PanelLeft.Controls.Add(Me.PanelLeftBottom)
        Me.PanelLeft.Controls.Add(Me.PanelLeftLeft)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 21)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(327, 636)
        Me.PanelLeft.TabIndex = 1
        '
        'PanelLeftTop
        '
        Me.PanelLeftTop.BackColor = System.Drawing.Color.Transparent
        Me.PanelLeftTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeftTop.Location = New System.Drawing.Point(17, 0)
        Me.PanelLeftTop.Name = "PanelLeftTop"
        Me.PanelLeftTop.Size = New System.Drawing.Size(310, 278)
        Me.PanelLeftTop.TabIndex = 3
        '
        'PanelLeftBottom
        '
        Me.PanelLeftBottom.BackColor = System.Drawing.Color.Transparent
        Me.PanelLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelLeftBottom.Location = New System.Drawing.Point(17, 317)
        Me.PanelLeftBottom.Name = "PanelLeftBottom"
        Me.PanelLeftBottom.Size = New System.Drawing.Size(310, 319)
        Me.PanelLeftBottom.TabIndex = 1
        '
        'PanelLeftLeft
        '
        Me.PanelLeftLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeftLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeftLeft.Name = "PanelLeftLeft"
        Me.PanelLeftLeft.Size = New System.Drawing.Size(17, 636)
        Me.PanelLeftLeft.TabIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.PanelRightBottom)
        Me.PanelRight.Controls.Add(Me.PanelRightTop)
        Me.PanelRight.Controls.Add(Me.PanelRightRight)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(771, 21)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(327, 636)
        Me.PanelRight.TabIndex = 0
        '
        'PanelRightBottom
        '
        Me.PanelRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelRightBottom.Location = New System.Drawing.Point(0, 317)
        Me.PanelRightBottom.Name = "PanelRightBottom"
        Me.PanelRightBottom.Size = New System.Drawing.Size(310, 319)
        Me.PanelRightBottom.TabIndex = 1
        '
        'PanelRightTop
        '
        Me.PanelRightTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRightTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelRightTop.Name = "PanelRightTop"
        Me.PanelRightTop.Size = New System.Drawing.Size(310, 299)
        Me.PanelRightTop.TabIndex = 2
        '
        'PanelRightRight
        '
        Me.PanelRightRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRightRight.Location = New System.Drawing.Point(310, 0)
        Me.PanelRightRight.Name = "PanelRightRight"
        Me.PanelRightRight.Size = New System.Drawing.Size(17, 636)
        Me.PanelRightRight.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1098, 21)
        Me.PanelTop.TabIndex = 2
        '
        'PanelBottom
        '
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 657)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1098, 21)
        Me.PanelBottom.TabIndex = 3
        '
        'FrmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 678)
        Me.Controls.Add(Me.PanelBack1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPanel"
        Me.Text = "Form3"
        Me.PanelBack1.ResumeLayout(False)
        Me.PanelCenter.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBack1 As Panel
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents PanelRightBottom As Panel
    Friend WithEvents PanelRightRight As Panel
    Friend WithEvents PanelCenterTasks As Panel
    Friend WithEvents PanelCenterLeft As Panel
    Friend WithEvents PanelCenterRight As Panel
    Friend WithEvents PanelLeftBottom As Panel
    Friend WithEvents PanelLeftLeft As Panel
    Friend WithEvents PanelRightTop As Panel
    Friend WithEvents PanelLeftTop As Panel
End Class
