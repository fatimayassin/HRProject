<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDockable
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ultraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._FrmDockableUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmDockableUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmDockableUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmDockableUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FrmDockableAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        CType(Me.ultraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ultraExplorerBar1
        '
        Me.ultraExplorerBar1.Location = New System.Drawing.Point(324, 116)
        Me.ultraExplorerBar1.Name = "ultraExplorerBar1"
        Me.ultraExplorerBar1.Size = New System.Drawing.Size(175, 230)
        Me.ultraExplorerBar1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(871, 453)
        Me.Panel1.TabIndex = 0
        '
        'UltraDockManager1
        '
        Me.UltraDockManager1.CompressUnpinnedTabs = False
        Me.UltraDockManager1.HostControl = Me
        '
        '_FrmDockableUnpinnedTabAreaLeft
        '
        Me._FrmDockableUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._FrmDockableUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmDockableUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._FrmDockableUnpinnedTabAreaLeft.Name = "_FrmDockableUnpinnedTabAreaLeft"
        Me._FrmDockableUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._FrmDockableUnpinnedTabAreaLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FrmDockableUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 453)
        Me._FrmDockableUnpinnedTabAreaLeft.TabIndex = 1
        '
        '_FrmDockableUnpinnedTabAreaRight
        '
        Me._FrmDockableUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._FrmDockableUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmDockableUnpinnedTabAreaRight.Location = New System.Drawing.Point(871, 0)
        Me._FrmDockableUnpinnedTabAreaRight.Name = "_FrmDockableUnpinnedTabAreaRight"
        Me._FrmDockableUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._FrmDockableUnpinnedTabAreaRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FrmDockableUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 453)
        Me._FrmDockableUnpinnedTabAreaRight.TabIndex = 2
        '
        '_FrmDockableUnpinnedTabAreaTop
        '
        Me._FrmDockableUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._FrmDockableUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmDockableUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._FrmDockableUnpinnedTabAreaTop.Name = "_FrmDockableUnpinnedTabAreaTop"
        Me._FrmDockableUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._FrmDockableUnpinnedTabAreaTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FrmDockableUnpinnedTabAreaTop.Size = New System.Drawing.Size(871, 0)
        Me._FrmDockableUnpinnedTabAreaTop.TabIndex = 3
        '
        '_FrmDockableUnpinnedTabAreaBottom
        '
        Me._FrmDockableUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._FrmDockableUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmDockableUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 453)
        Me._FrmDockableUnpinnedTabAreaBottom.Name = "_FrmDockableUnpinnedTabAreaBottom"
        Me._FrmDockableUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._FrmDockableUnpinnedTabAreaBottom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FrmDockableUnpinnedTabAreaBottom.Size = New System.Drawing.Size(871, 0)
        Me._FrmDockableUnpinnedTabAreaBottom.TabIndex = 4
        '
        '_FrmDockableAutoHideControl
        '
        Me._FrmDockableAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmDockableAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._FrmDockableAutoHideControl.Name = "_FrmDockableAutoHideControl"
        Me._FrmDockableAutoHideControl.Owner = Me.UltraDockManager1
        Me._FrmDockableAutoHideControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._FrmDockableAutoHideControl.Size = New System.Drawing.Size(0, 0)
        Me._FrmDockableAutoHideControl.TabIndex = 5
        '
        'FrmDockable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 453)
        Me.Controls.Add(Me._FrmDockableAutoHideControl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._FrmDockableUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._FrmDockableUnpinnedTabAreaTop)
        Me.Controls.Add(Me._FrmDockableUnpinnedTabAreaRight)
        Me.Controls.Add(Me._FrmDockableUnpinnedTabAreaLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDockable"
        Me.Text = "FrmDockable"
        CType(Me.ultraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private ultraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _FrmDockableAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _FrmDockableUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmDockableUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmDockableUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmDockableUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    '  Dim myUC As New UCmailNav()

End Class
