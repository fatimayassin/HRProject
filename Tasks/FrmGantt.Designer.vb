<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGantt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGantt))
        Dim buttonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exit")
        Dim RibbonTab1 As Infragistics.Win.UltraWinToolbars.RibbonTab = New Infragistics.Win.UltraWinToolbars.RibbonTab("Ribbon_Task")
        Dim ribbonGroup1 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("RibbonGrp_Font")
        Dim fontListTool1 As Infragistics.Win.UltraWinToolbars.FontListTool = New Infragistics.Win.UltraWinToolbars.FontListTool("FontList")
        Dim comboBoxTool1 As Infragistics.Win.UltraWinToolbars.ComboBoxTool = New Infragistics.Win.UltraWinToolbars.ComboBoxTool("FontSize")
        Dim stateButtonTool1 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Bold", "")
        Dim stateButtonTool3 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Italics", "")
        Dim stateButtonTool5 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Underline", "")
        Dim popupColorPickerTool1 As Infragistics.Win.UltraWinToolbars.PopupColorPickerTool = New Infragistics.Win.UltraWinToolbars.PopupColorPickerTool("FontBGColor")
        Dim popupColorPickerTool2 As Infragistics.Win.UltraWinToolbars.PopupColorPickerTool = New Infragistics.Win.UltraWinToolbars.PopupColorPickerTool("Font_ForeColor")
        Dim ribbonGroup2 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("RibbonGrp_Tasks")
        Dim buttonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_ZeroPercent")
        Dim buttonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_25Percent")
        Dim buttonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_50Percent")
        Dim buttonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_75Percent")
        Dim buttonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_100Percent")
        Dim buttonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_Outdent")
        Dim buttonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_Indent")
        Dim popupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Schedule_MoveTask")
        Dim ribbonGroup3 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("RibbonGrp_Insert")
        Dim popupMenuTool9 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Insert_Task")
        Dim buttonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Milestone")
        Dim ribbonGroup4 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("Properties")
        Dim buttonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Properties_TaskInformation")
        Dim buttonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Properties_Notes")
        Dim fontListTool2 As Infragistics.Win.UltraWinToolbars.FontListTool = New Infragistics.Win.UltraWinToolbars.FontListTool("FontList")
        Dim comboBoxTool2 As Infragistics.Win.UltraWinToolbars.ComboBoxTool = New Infragistics.Win.UltraWinToolbars.ComboBoxTool("FontSize")
        Dim ValueList1 As Infragistics.Win.ValueList = New Infragistics.Win.ValueList(0)
        Dim popupColorPickerTool3 As Infragistics.Win.UltraWinToolbars.PopupColorPickerTool = New Infragistics.Win.UltraWinToolbars.PopupColorPickerTool("FontBGColor")
        Dim popupColorPickerTool4 As Infragistics.Win.UltraWinToolbars.PopupColorPickerTool = New Infragistics.Win.UltraWinToolbars.PopupColorPickerTool("Font_ForeColor")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim buttonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_ZeroPercent")
        Dim buttonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_25Percent")
        Dim buttonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_50Percent")
        Dim buttonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_100Percent")
        Dim buttonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_Outdent")
        Dim buttonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_Indent")
        Dim popupMenuTool6 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Schedule_MoveTask")
        Dim labelTool1 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("Schedule_MoveTask_MoveTaskForward")
        Dim buttonTool47 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_1Day")
        Dim buttonTool48 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_1Week")
        Dim buttonTool49 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_4Weeks")
        Dim labelTool2 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("Schedule_MoveTask_MoveTaskBackward")
        Dim buttonTool53 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards1Day")
        Dim buttonTool54 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards1Week")
        Dim buttonTool55 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards4Weeks")
        Dim popupMenuTool10 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Insert_Task")
        Dim buttonTool59 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Task_TaskAtSelectedRow")
        Dim buttonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Task_Task")
        Dim buttonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Summary")
        Dim buttonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Milestone")
        Dim stateButtonTool2 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Bold", "")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim stateButtonTool4 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Italics", "")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim stateButtonTool6 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Font_Underline", "")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim buttonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Task_Task")
        Dim buttonTool50 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_1Day")
        Dim buttonTool51 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_1Week")
        Dim buttonTool52 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_4Weeks")
        Dim labelTool3 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("Schedule_MoveTask_MoveTaskForward")
        Dim labelTool4 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("Schedule_MoveTask_MoveTaskBackward")
        Dim buttonTool56 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards1Day")
        Dim buttonTool57 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards1Week")
        Dim buttonTool58 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Schedule_MoveTask_MoveTaskBackwards4Weeks")
        Dim buttonTool60 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Insert_Task_TaskAtSelectedRow")
        Dim buttonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Task_75Percent")
        Dim buttonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Properties_TaskInformation")
        Dim buttonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Properties_Notes")
        Dim buttonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exit")
        Dim buttonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ultraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Form1_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Form1_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ultraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.ilLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.TaskDataSet1 = New HR.TaskDataSet()
        Me.FrmGantt_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.ultraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.ultraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.ultraGanttView1 = New Infragistics.Win.UltraWinGanttView.UltraGanttView()
        CType(Me.ultraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmGantt_Fill_Panel.ClientArea.SuspendLayout()
        Me.FrmGantt_Fill_Panel.SuspendLayout()
        CType(Me.ultraGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.White
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        Me.imageList1.Images.SetKeyName(24, "")
        Me.imageList1.Images.SetKeyName(25, "")
        Me.imageList1.Images.SetKeyName(26, "")
        Me.imageList1.Images.SetKeyName(27, "")
        Me.imageList1.Images.SetKeyName(28, "")
        Me.imageList1.Images.SetKeyName(29, "")
        Me.imageList1.Images.SetKeyName(30, "")
        Me.imageList1.Images.SetKeyName(31, "")
        Me.imageList1.Images.SetKeyName(32, "")
        Me.imageList1.Images.SetKeyName(33, "")
        Me.imageList1.Images.SetKeyName(34, "")
        Me.imageList1.Images.SetKeyName(35, "")
        Me.imageList1.Images.SetKeyName(36, "")
        Me.imageList1.Images.SetKeyName(37, "")
        Me.imageList1.Images.SetKeyName(38, "")
        Me.imageList1.Images.SetKeyName(39, "")
        Me.imageList1.Images.SetKeyName(40, "")
        Me.imageList1.Images.SetKeyName(41, "")
        Me.imageList1.Images.SetKeyName(42, "")
        Me.imageList1.Images.SetKeyName(43, "")
        Me.imageList1.Images.SetKeyName(44, "")
        Me.imageList1.Images.SetKeyName(45, "")
        Me.imageList1.Images.SetKeyName(46, "")
        Me.imageList1.Images.SetKeyName(47, "")
        Me.imageList1.Images.SetKeyName(48, "")
        Me.imageList1.Images.SetKeyName(49, "")
        Me.imageList1.Images.SetKeyName(50, "")
        Me.imageList1.Images.SetKeyName(51, "")
        Me.imageList1.Images.SetKeyName(52, "")
        '
        'ultraToolbarsManager1
        '
        Me.ultraToolbarsManager1.DesignerFlags = 1
        Me.ultraToolbarsManager1.DockWithinContainer = Me
        Me.ultraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.ultraToolbarsManager1.ImageListSmall = Me.imageList1
        Me.ultraToolbarsManager1.Office2007UICompatibility = False
        Me.ultraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {buttonTool4})
        Me.ultraToolbarsManager1.Ribbon.FileMenuStyle = Infragistics.Win.UltraWinToolbars.FileMenuStyle.ApplicationMenu2010
        RibbonTab1.Caption = "Task"
        ribbonGroup1.Caption = "Font"
        ribbonGroup1.LayoutDirection = Infragistics.Win.UltraWinToolbars.RibbonGroupToolLayoutDirection.Horizontal
        fontListTool1.InstanceProps.Width = 193
        comboBoxTool1.InstanceProps.ButtonGroup = "FontSize"
        comboBoxTool1.InstanceProps.Width = 50
        stateButtonTool1.InstanceProps.ButtonGroup = "TextStyle"
        stateButtonTool1.InstanceProps.IsFirstInGroup = True
        stateButtonTool3.InstanceProps.ButtonGroup = "TextStyle"
        stateButtonTool5.InstanceProps.ButtonGroup = "TextStyle"
        popupColorPickerTool1.InstanceProps.ButtonGroup = "Colors"
        popupColorPickerTool1.InstanceProps.IsFirstInGroup = True
        popupColorPickerTool2.InstanceProps.ButtonGroup = "Colors"
        popupColorPickerTool2.InstanceProps.IsFirstInGroup = True
        ribbonGroup1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {fontListTool1, comboBoxTool1, stateButtonTool1, stateButtonTool3, stateButtonTool5, popupColorPickerTool1, popupColorPickerTool2})
        ribbonGroup2.Caption = "Tasks"
        buttonTool1.InstanceProps.IsFirstInGroup = True
        buttonTool1.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool1.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool19.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool19.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool20.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool20.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool2.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool2.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool21.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool21.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool22.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool22.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Normal
        buttonTool23.InstanceProps.MinimumSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ribbonGroup2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {buttonTool1, buttonTool19, buttonTool20, buttonTool2, buttonTool21, buttonTool22, buttonTool23, popupMenuTool1})
        ribbonGroup3.Caption = "Insert"
        popupMenuTool9.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool36.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ribbonGroup3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {popupMenuTool9, buttonTool36})
        ribbonGroup4.Caption = "Properties"
        buttonTool6.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        buttonTool8.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ribbonGroup4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {buttonTool6, buttonTool8})
        RibbonTab1.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {ribbonGroup1, ribbonGroup2, ribbonGroup3, ribbonGroup4})
        Me.ultraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonTab() {RibbonTab1})
        Me.ultraToolbarsManager1.Ribbon.Visible = True
        Me.ultraToolbarsManager1.ShowFullMenusDelay = 500
        comboBoxTool2.ValueList = ValueList1
        popupColorPickerTool3.SharedPropsInternal.Caption = "BGColor"
        Appearance1.Image = 41
        popupColorPickerTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance1
        popupColorPickerTool4.SharedPropsInternal.Caption = "FontColor"
        buttonTool5.SharedPropsInternal.Caption = "0%"
        buttonTool24.SharedPropsInternal.Caption = "25%"
        buttonTool25.SharedPropsInternal.Caption = "50%"
        buttonTool26.SharedPropsInternal.Caption = "100%"
        buttonTool27.SharedPropsInternal.Caption = "Move Left"
        buttonTool28.SharedPropsInternal.Caption = "Move Right"
        popupMenuTool6.SharedPropsInternal.Caption = "Move Task"
        popupMenuTool6.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {labelTool1, buttonTool47, buttonTool48, buttonTool49, labelTool2, buttonTool53, buttonTool54, buttonTool55})
        popupMenuTool10.SharedPropsInternal.Caption = "Task"
        popupMenuTool10.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {buttonTool59, buttonTool13})
        buttonTool37.SharedPropsInternal.Caption = "Summary"
        buttonTool38.SharedPropsInternal.Caption = "Milestone"
        Appearance2.Image = 3
        stateButtonTool2.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        stateButtonTool2.SharedPropsInternal.Caption = "B"
        Appearance3.Image = 5
        stateButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance3
        stateButtonTool4.SharedPropsInternal.Caption = "I"
        Appearance4.Image = 4
        stateButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance4
        stateButtonTool6.SharedPropsInternal.Caption = "U"
        buttonTool16.SharedPropsInternal.Caption = "Add task at bottom"
        buttonTool50.SharedPropsInternal.Caption = "1 Day"
        buttonTool51.SharedPropsInternal.Caption = "1 Week"
        buttonTool52.SharedPropsInternal.Caption = "4 Weeks"
        labelTool3.SharedPropsInternal.Caption = "Move Task Forward"
        labelTool4.SharedPropsInternal.Caption = "Move Task Backward"
        buttonTool56.SharedPropsInternal.Caption = "1 Day"
        buttonTool57.SharedPropsInternal.Caption = "1 Week"
        buttonTool58.SharedPropsInternal.Caption = "4 Weeks"
        buttonTool60.SharedPropsInternal.Caption = "Add task at selected row"
        buttonTool3.SharedPropsInternal.Caption = "75%"
        buttonTool9.SharedPropsInternal.Caption = "Task Information"
        buttonTool10.SharedPropsInternal.Caption = "Notes"
        buttonTool7.SharedPropsInternal.Caption = "Exit"
        buttonTool7.SharedPropsInternal.DescriptionOnMenu = "Close the application"
        buttonTool12.SharedPropsInternal.Caption = "Save"
        Me.ultraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {fontListTool2, comboBoxTool2, popupColorPickerTool3, popupColorPickerTool4, buttonTool5, buttonTool24, buttonTool25, buttonTool26, buttonTool27, buttonTool28, popupMenuTool6, popupMenuTool10, buttonTool37, buttonTool38, stateButtonTool2, stateButtonTool4, stateButtonTool6, buttonTool16, buttonTool50, buttonTool51, buttonTool52, labelTool3, labelTool4, buttonTool56, buttonTool57, buttonTool58, buttonTool60, buttonTool3, buttonTool9, buttonTool10, buttonTool7, buttonTool12})
        '
        '_Form1_Toolbars_Dock_Area_Top
        '
        Me._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top"
        Me._Form1_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(800, 162)
        Me._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Bottom
        '
        Me._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 8
        Me._Form1_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 571)
        Me._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom"
        Me._Form1_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(800, 8)
        Me._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Left
        '
        Me._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8
        Me._Form1_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 162)
        Me._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left"
        Me._Form1_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(8, 409)
        Me._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_Form1_Toolbars_Dock_Area_Right
        '
        Me._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8
        Me._Form1_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(792, 162)
        Me._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right"
        Me._Form1_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(8, 409)
        Me._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = Me.ultraToolbarsManager1
        '
        'ilLarge
        '
        Me.ilLarge.ImageStream = CType(resources.GetObject("ilLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLarge.Images.SetKeyName(0, "New Edit32.png")
        Me.ilLarge.Images.SetKeyName(1, "Word-32.gif")
        Me.ilLarge.Images.SetKeyName(2, "Excel-32.gif")
        Me.ilLarge.Images.SetKeyName(3, "PowerPoint-32.gif")
        Me.ilLarge.Images.SetKeyName(4, "Reader-32.gif")
        '
        'TaskDataSet1
        '
        Me.TaskDataSet1.DataSetName = "TaskDataSet"
        Me.TaskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmGantt_Fill_Panel
        '
        '
        'FrmGantt_Fill_Panel.ClientArea
        '
        Me.FrmGantt_Fill_Panel.ClientArea.Controls.Add(Me.ultraGanttView1)
        Me.FrmGantt_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrmGantt_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmGantt_Fill_Panel.Location = New System.Drawing.Point(8, 162)
        Me.FrmGantt_Fill_Panel.Name = "FrmGantt_Fill_Panel"
        Me.FrmGantt_Fill_Panel.Size = New System.Drawing.Size(784, 409)
        Me.FrmGantt_Fill_Panel.TabIndex = 8
        '
        'ultraButton2
        '
        Me.ultraButton2.Location = New System.Drawing.Point(302, 32)
        Me.ultraButton2.Name = "ultraButton2"
        Me.ultraButton2.Size = New System.Drawing.Size(145, 23)
        Me.ultraButton2.TabIndex = 4
        Me.ultraButton2.Text = "Save changes"
        '
        'ultraButton1
        '
        Me.ultraButton1.Location = New System.Drawing.Point(151, 32)
        Me.ultraButton1.Name = "ultraButton1"
        Me.ultraButton1.Size = New System.Drawing.Size(145, 23)
        Me.ultraButton1.TabIndex = 3
        Me.ultraButton1.Text = "Load Data from Databse"
        '
        'ultraGanttView1
        '
        Me.ultraGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Constraint").VisiblePosition = 6
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("ConstraintDateTime").VisiblePosition = 7
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Dependencies").VisiblePosition = 4
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Deadline").VisiblePosition = 8
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Duration").VisiblePosition = 1
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("EndDateTime").VisiblePosition = 3
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Milestone").VisiblePosition = 9
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Name").VisiblePosition = 0
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Notes").VisiblePosition = 10
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("PercentComplete").VisiblePosition = 11
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("Resources").VisiblePosition = 5
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("StartDateTime").VisiblePosition = 2
        Me.ultraGanttView1.GridSettings.ColumnSettings.GetValue("RowNumber").VisiblePosition = 12
        Me.ultraGanttView1.Location = New System.Drawing.Point(0, 0)
        Me.ultraGanttView1.Name = "ultraGanttView1"
        Me.ultraGanttView1.Size = New System.Drawing.Size(784, 409)
        Me.ultraGanttView1.TabIndex = 1
        Me.ultraGanttView1.Text = "ultraGanttView1"
        Me.ultraGanttView1.VerticalSplitterMinimumResizeWidth = 10
        '
        'FrmGantt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.ultraButton2)
        Me.Controls.Add(Me.FrmGantt_Fill_Panel)
        Me.Controls.Add(Me.ultraButton1)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Top)
        Me.Name = "FrmGantt"
        Me.Text = "FrmGantt"
        CType(Me.ultraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmGantt_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.FrmGantt_Fill_Panel.ResumeLayout(False)
        CType(Me.ultraGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents imageList1 As ImageList
    Private WithEvents ultraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Private WithEvents _Form1_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Private WithEvents _Form1_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Private WithEvents _Form1_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Private WithEvents _Form1_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Private WithEvents ultraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Private WithEvents ilLarge As ImageList
    Friend WithEvents TaskDataSet1 As TaskDataSet
    Friend WithEvents FrmGantt_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Private WithEvents ultraButton2 As Infragistics.Win.Misc.UltraButton
    Private WithEvents ultraButton1 As Infragistics.Win.Misc.UltraButton
    Private WithEvents ultraGanttView1 As Infragistics.Win.UltraWinGanttView.UltraGanttView
    Private dbProjectsTableAdapter As TaskDataSetTableAdapters.dbProjectsTableAdapter
    Private dbTasksTableAdapter As TaskDataSetTableAdapters.dbTasksTableAdapter

End Class
