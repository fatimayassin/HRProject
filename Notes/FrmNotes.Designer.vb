<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotes
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
        Me.components = New System.ComponentModel.Container()
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("New")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotes))
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Open")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cut")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Copy")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Paste")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ComboBoxTool2 As Infragistics.Win.UltraWinToolbars.ComboBoxTool = New Infragistics.Win.UltraWinToolbars.ComboBoxTool("ComboBoxTool1")
        Dim ValueList1 As Infragistics.Win.ValueList = New Infragistics.Win.ValueList(0)
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Bold")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Underline")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Italic")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Form1_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraPanel1
        '
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(318, 317)
        Me.UltraPanel1.TabIndex = 6
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UltraToolbarsManager1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance1
        ButtonTool4.SharedPropsInternal.Caption = "New"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        ButtonTool5.SharedPropsInternal.Caption = "Open"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance3
        ButtonTool6.SharedPropsInternal.Caption = "Save"
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        ButtonTool13.SharedPropsInternal.AppearancesSmall.Appearance = Appearance4
        ButtonTool13.SharedPropsInternal.Caption = "Cut"
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        ButtonTool14.SharedPropsInternal.AppearancesSmall.Appearance = Appearance5
        ButtonTool14.SharedPropsInternal.Caption = "Copy"
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance6
        ButtonTool15.SharedPropsInternal.Caption = "Paste"
        ComboBoxTool2.SharedPropsInternal.Caption = "ComboBoxTool1"
        ComboBoxTool2.ValueList = ValueList1
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        ButtonTool16.SharedPropsInternal.AppearancesSmall.Appearance = Appearance7
        ButtonTool16.SharedPropsInternal.Caption = "Bold"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance8
        ButtonTool17.SharedPropsInternal.Caption = "Underline"
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        ButtonTool18.SharedPropsInternal.AppearancesSmall.Appearance = Appearance9
        ButtonTool18.SharedPropsInternal.Caption = "Italic"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool13, ButtonTool14, ButtonTool15, ComboBoxTool2, ButtonTool16, ButtonTool17, ButtonTool18})
        '
        '_Form1_Toolbars_Dock_Area_Top
        '
        Me._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Top.Margin = New System.Windows.Forms.Padding(2)
        Me._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top"
        Me._Form1_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(318, 0)
        Me._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Bottom
        '
        Me._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 317)
        Me._Form1_Toolbars_Dock_Area_Bottom.Margin = New System.Windows.Forms.Padding(2)
        Me._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom"
        Me._Form1_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(318, 0)
        Me._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Left
        '
        Me._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Left.Margin = New System.Windows.Forms.Padding(2)
        Me._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left"
        Me._Form1_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 317)
        Me._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Right
        '
        Me._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(318, 0)
        Me._Form1_Toolbars_Dock_Area_Right.Margin = New System.Windows.Forms.Padding(2)
        Me._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right"
        Me._Form1_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 317)
        Me._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'FrmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 317)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNotes"
        Me.Text = "FrmNotes"
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _Form1_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
End Class
