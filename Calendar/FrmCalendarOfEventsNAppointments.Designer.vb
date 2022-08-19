<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalendarOfEventsNAppointments
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
        Dim OptionSet1 As Infragistics.Win.UltraWinToolbars.OptionSet = New Infragistics.Win.UltraWinToolbars.OptionSet("DateButtons")
        Dim OptionSet2 As Infragistics.Win.UltraWinToolbars.OptionSet = New Infragistics.Win.UltraWinToolbars.OptionSet("ViewStyle")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("tlbMainMenu")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuFile")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuData")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuView")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("tlbMainToolbar")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("New")
        Dim StateButtonTool1 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Day", "DateButtons")
        Dim StateButtonTool2 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Week", "DateButtons")
        Dim StateButtonTool3 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Month", "DateButtons")
        Dim StateButtonTool20 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("TimeLine", "DateButtons")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Dim PopupMenuTool5 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuFile")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_File_Exit")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_File_Exit")
        Dim PopupMenuTool6 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("New")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalendarOfEventsNAppointments))
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AddOwner")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AddAppointment")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AddOwner")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim StateButtonTool4 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Day", "DateButtons")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim StateButtonTool5 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Week", "DateButtons")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim StateButtonTool6 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Month", "DateButtons")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool7 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuView")
        Dim StateButtonTool7 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Standard", "ViewStyle")
        Dim StateButtonTool8 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2003", "ViewStyle")
        Dim StateButtonTool9 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_VS2005", "ViewStyle")
        Dim PopupMenuTool8 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Office2007")
        Dim StateButtonTool10 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Standard", "ViewStyle")
        Dim StateButtonTool11 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2003", "ViewStyle")
        Dim StateButtonTool12 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_VS2005", "ViewStyle")
        Dim PopupMenuTool9 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuData")
        Dim PopupMenuTool10 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuQueries")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_Data_UpdateOwnersTable")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_Data_UpdateAppointmentsTable")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_Data_UpdateOwnersTable")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuMain_Data_UpdateAppointmentsTable")
        Dim PopupMenuTool11 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("menuQueries")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AllOwners")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AllAppointments")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AppointmentsByOwner")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AppointmentsByOwner")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AllAppointments")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("menuQueries_AllOwners")
        Dim PopupMenuTool12 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Office2007")
        Dim StateButtonTool13 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Blue", "ViewStyle")
        Dim StateButtonTool14 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Black", "ViewStyle")
        Dim StateButtonTool15 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Silver", "ViewStyle")
        Dim StateButtonTool16 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Blue", "ViewStyle")
        Dim StateButtonTool17 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Black", "ViewStyle")
        Dim StateButtonTool18 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("menuMain_View_Office2007_Silver", "ViewStyle")
        Dim StateButtonTool19 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("TimeLine", "DateButtons")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Save")
        Dim DateInterval1 As Infragistics.Win.UltraWinSchedule.DateInterval = New Infragistics.Win.UltraWinSchedule.DateInterval()
        Dim TimeInterval1 As Infragistics.Win.UltraWinSchedule.TimeInterval = New Infragistics.Win.UltraWinSchedule.TimeInterval()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ultraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.ultraTimelineView1 = New Infragistics.Win.UltraWinSchedule.UltraTimelineView()
        Me.ultraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.ultraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        Me.ultraWeekView1 = New Infragistics.Win.UltraWinSchedule.UltraWeekView()
        Me.ultraMonthViewSingle1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewSingle()
        Me.ultraDayView1 = New Infragistics.Win.UltraWinSchedule.UltraDayView()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlOwners = New System.Windows.Forms.Panel()
        Me.splitter2 = New System.Windows.Forms.Splitter()
        Me.ultraMonthViewMulti1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.contextMenu1 = New Infragistics.Win.IGControls.IGContextMenu()
        CType(Me.ultraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.ClientArea.SuspendLayout()
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.ultraTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultraWeekView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultraMonthViewSingle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultraDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.ultraMonthViewMulti1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ultraToolbarsManager1
        '
        Me.ultraToolbarsManager1.DesignerFlags = 1
        Me.ultraToolbarsManager1.DockWithinContainer = Me
        Me.ultraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.ultraToolbarsManager1.ImageTransparentColor = System.Drawing.Color.Magenta
        OptionSet1.AllowAllUp = False
        OptionSet2.AllowAllUp = False
        Me.ultraToolbarsManager1.OptionSets.Add(OptionSet1)
        Me.ultraToolbarsManager1.OptionSets.Add(OptionSet2)
        Me.ultraToolbarsManager1.ShowFullMenusDelay = 500
        Me.ultraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2003
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool1, PopupMenuTool2, PopupMenuTool3})
        UltraToolbar1.Text = "tlbMainMenu"
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 1
        PopupMenuTool4.InstanceProps.IsFirstInGroup = True
        StateButtonTool1.Checked = True
        StateButtonTool1.InstanceProps.IsFirstInGroup = True
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool4, StateButtonTool1, StateButtonTool2, StateButtonTool3, StateButtonTool20, ButtonTool16})
        UltraToolbar2.Text = "tlbMainToolbar"
        Me.ultraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1, UltraToolbar2})
        PopupMenuTool5.SharedPropsInternal.Caption = "&File"
        PopupMenuTool5.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        ButtonTool2.SharedPropsInternal.Caption = "E&xit"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        PopupMenuTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        PopupMenuTool6.SharedPropsInternal.Caption = "&New"
        PopupMenuTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        PopupMenuTool6.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3})
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance3
        ButtonTool4.SharedPropsInternal.Caption = "&Appointment"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool4.SharedPropsInternal.ToolTipText = "Add a new Appointment"
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance4
        ButtonTool5.SharedPropsInternal.Caption = "&Owner"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool5.SharedPropsInternal.ToolTipText = "Add a new Owner"
        StateButtonTool4.Checked = True
        StateButtonTool4.OptionSetKey = "DateButtons"
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        StateButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance5
        StateButtonTool4.SharedPropsInternal.Caption = "Da&y"
        StateButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        StateButtonTool5.OptionSetKey = "DateButtons"
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        StateButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance6
        StateButtonTool5.SharedPropsInternal.Caption = "&Week"
        StateButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        StateButtonTool6.OptionSetKey = "DateButtons"
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        StateButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance7
        StateButtonTool6.SharedPropsInternal.Caption = "&Month"
        StateButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        PopupMenuTool7.SharedPropsInternal.Caption = "&View"
        StateButtonTool7.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool8.Checked = True
        StateButtonTool8.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool9.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        PopupMenuTool7.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool7, StateButtonTool8, StateButtonTool9, PopupMenuTool8})
        StateButtonTool10.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool10.OptionSetKey = "ViewStyle"
        StateButtonTool10.SharedPropsInternal.Caption = "Standard"
        StateButtonTool11.Checked = True
        StateButtonTool11.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool11.OptionSetKey = "ViewStyle"
        StateButtonTool11.SharedPropsInternal.Caption = "Office2003"
        StateButtonTool12.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool12.OptionSetKey = "ViewStyle"
        StateButtonTool12.SharedPropsInternal.Caption = "VS2005"
        PopupMenuTool9.SharedPropsInternal.Caption = "&Data"
        PopupMenuTool9.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool10, ButtonTool6, ButtonTool7})
        ButtonTool8.SharedPropsInternal.Caption = "Update &Owners Table"
        ButtonTool9.SharedPropsInternal.Caption = "Update &Appointments Table"
        PopupMenuTool11.SharedPropsInternal.Caption = "Queries"
        PopupMenuTool11.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool10, ButtonTool11, ButtonTool12})
        ButtonTool13.SharedPropsInternal.Caption = "Appointments By Owner"
        ButtonTool14.SharedPropsInternal.Caption = "All Appointments"
        ButtonTool15.SharedPropsInternal.Caption = "All Owners"
        PopupMenuTool12.SharedPropsInternal.Caption = "Office2007"
        StateButtonTool13.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool14.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool15.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        PopupMenuTool12.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool13, StateButtonTool14, StateButtonTool15})
        StateButtonTool16.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool16.OptionSetKey = "ViewStyle"
        StateButtonTool16.SharedPropsInternal.Caption = "Blue"
        StateButtonTool17.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool17.OptionSetKey = "ViewStyle"
        StateButtonTool17.SharedPropsInternal.Caption = "Black"
        StateButtonTool18.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool18.OptionSetKey = "ViewStyle"
        StateButtonTool18.SharedPropsInternal.Caption = "Silver"
        StateButtonTool19.OptionSetKey = "DateButtons"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        StateButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance8
        StateButtonTool19.SharedPropsInternal.Caption = "&TimeLine"
        StateButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool17.SharedPropsInternal.Caption = "Save"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        Me.ultraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool5, ButtonTool2, PopupMenuTool6, ButtonTool4, ButtonTool5, StateButtonTool4, StateButtonTool5, StateButtonTool6, PopupMenuTool7, StateButtonTool10, StateButtonTool11, StateButtonTool12, PopupMenuTool9, ButtonTool8, ButtonTool9, PopupMenuTool11, ButtonTool13, ButtonTool14, ButtonTool15, PopupMenuTool12, StateButtonTool16, StateButtonTool17, StateButtonTool18, StateButtonTool19, ButtonTool17})
        '
        '_frmAppointmentGrouping_Toolbars_Dock_Area_Top
        '
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.Name = "_frmAppointmentGrouping_Toolbars_Dock_Area_Top"
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(933, 50)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_frmAppointmentGrouping_Toolbars_Dock_Area_Bottom
        '
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 519)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.Name = "_frmAppointmentGrouping_Toolbars_Dock_Area_Bottom"
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(933, 0)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_frmAppointmentGrouping_Toolbars_Dock_Area_Left
        '
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 50)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.Name = "_frmAppointmentGrouping_Toolbars_Dock_Area_Left"
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 469)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left.ToolbarsManager = Me.ultraToolbarsManager1
        '
        '_frmAppointmentGrouping_Toolbars_Dock_Area_Right
        '
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(245, Byte), Integer))
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(933, 50)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.Name = "_frmAppointmentGrouping_Toolbars_Dock_Area_Right"
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 469)
        Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right.ToolbarsManager = Me.ultraToolbarsManager1
        '
        'FrmCalendarOfEventsNAppointments_Fill_Panel
        '
        '
        'FrmCalendarOfEventsNAppointments_Fill_Panel.ClientArea
        '
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.ClientArea.Controls.Add(Me.pnlMain)
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.ClientArea.Controls.Add(Me.pnlLeft)
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.Location = New System.Drawing.Point(0, 50)
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.Name = "FrmCalendarOfEventsNAppointments_Fill_Panel"
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.Size = New System.Drawing.Size(933, 469)
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.TabIndex = 8
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.ultraTimelineView1)
        Me.pnlMain.Controls.Add(Me.ultraWeekView1)
        Me.pnlMain.Controls.Add(Me.ultraMonthViewSingle1)
        Me.pnlMain.Controls.Add(Me.ultraDayView1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(157, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(776, 469)
        Me.pnlMain.TabIndex = 7
        '
        'ultraTimelineView1
        '
        Me.ultraTimelineView1.AdditionalIntervals.Add(DateInterval1)
        Me.ultraTimelineView1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraTimelineView1.CalendarLook = Me.ultraCalendarLook1
        Me.ultraTimelineView1.Location = New System.Drawing.Point(334, 126)
        Me.ultraTimelineView1.Name = "ultraTimelineView1"
        Me.ultraTimelineView1.PrimaryInterval = TimeInterval1
        Me.ultraTimelineView1.Size = New System.Drawing.Size(195, 225)
        Me.ultraTimelineView1.TabIndex = 4
        Me.ultraTimelineView1.Visible = False
        '
        'ultraCalendarInfo1
        '
        Me.ultraCalendarInfo1.AllowRecurringAppointments = True
        '
        'ultraCalendarLook1
        '
        Me.ultraCalendarLook1.ViewStyle = Infragistics.Win.UltraWinSchedule.ViewStyle.Office2007
        '
        'ultraWeekView1
        '
        Me.ultraWeekView1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraWeekView1.CalendarLook = Me.ultraCalendarLook1
        Me.ultraWeekView1.Location = New System.Drawing.Point(160, 232)
        Me.ultraWeekView1.Name = "ultraWeekView1"
        Me.ultraWeekView1.Size = New System.Drawing.Size(168, 144)
        Me.ultraWeekView1.TabIndex = 2
        Me.ultraWeekView1.Visible = False
        '
        'ultraMonthViewSingle1
        '
        Me.ultraMonthViewSingle1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraMonthViewSingle1.CalendarLook = Me.ultraCalendarLook1
        Me.ultraMonthViewSingle1.Location = New System.Drawing.Point(160, 72)
        Me.ultraMonthViewSingle1.Name = "ultraMonthViewSingle1"
        Me.ultraMonthViewSingle1.Size = New System.Drawing.Size(168, 152)
        Me.ultraMonthViewSingle1.TabIndex = 1
        Me.ultraMonthViewSingle1.Visible = False
        '
        'ultraDayView1
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Control
        Me.ultraDayView1.Appearance = Appearance1
        Me.ultraDayView1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraDayView1.CalendarLook = Me.ultraCalendarLook1
        Me.ultraDayView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ultraDayView1.Location = New System.Drawing.Point(0, 0)
        Me.ultraDayView1.Name = "ultraDayView1"
        Me.ultraDayView1.Size = New System.Drawing.Size(776, 469)
        Me.ultraDayView1.TabIndex = 0
        Me.ultraDayView1.Text = "ultraDayView1"
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pnlOwners)
        Me.pnlLeft.Controls.Add(Me.splitter2)
        Me.pnlLeft.Controls.Add(Me.ultraMonthViewMulti1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(157, 469)
        Me.pnlLeft.TabIndex = 6
        '
        'pnlOwners
        '
        Me.pnlOwners.AutoScroll = True
        Me.pnlOwners.BackColor = System.Drawing.Color.White
        Me.pnlOwners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOwners.Location = New System.Drawing.Point(0, 142)
        Me.pnlOwners.Name = "pnlOwners"
        Me.pnlOwners.Size = New System.Drawing.Size(157, 327)
        Me.pnlOwners.TabIndex = 3
        '
        'splitter2
        '
        Me.splitter2.BackColor = System.Drawing.Color.Navy
        Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.splitter2.Location = New System.Drawing.Point(0, 140)
        Me.splitter2.Name = "splitter2"
        Me.splitter2.Size = New System.Drawing.Size(157, 2)
        Me.splitter2.TabIndex = 2
        Me.splitter2.TabStop = False
        '
        'ultraMonthViewMulti1
        '
        Me.ultraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window
        Me.ultraMonthViewMulti1.CalendarInfo = Me.ultraCalendarInfo1
        Me.ultraMonthViewMulti1.CalendarLook = Me.ultraCalendarLook1
        Me.ultraMonthViewMulti1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ultraMonthViewMulti1.Location = New System.Drawing.Point(0, 0)
        Me.ultraMonthViewMulti1.MonthOrientation = Infragistics.Win.UltraWinSchedule.MonthOrientation.DownThenAcross
        Me.ultraMonthViewMulti1.Name = "ultraMonthViewMulti1"
        Me.ultraMonthViewMulti1.Size = New System.Drawing.Size(158, 140)
        Me.ultraMonthViewMulti1.TabIndex = 1
        '
        'contextMenu1
        '
        Me.contextMenu1.ImageList = Nothing
        Me.contextMenu1.Style = Infragistics.Win.IGControls.MenuStyle.OfficeXP
        Me.contextMenu1.TouchMetricsEnabled = False
        Me.contextMenu1.ZoomFactor = Nothing
        '
        'FrmCalendarOfEventsNAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.FrmCalendarOfEventsNAppointments_Fill_Panel)
        Me.Controls.Add(Me._frmAppointmentGrouping_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmAppointmentGrouping_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmAppointmentGrouping_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._frmAppointmentGrouping_Toolbars_Dock_Area_Top)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCalendarOfEventsNAppointments"
        Me.Text = "FrmCalendarOfEventsNAppointments"
        CType(Me.ultraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.FrmCalendarOfEventsNAppointments_Fill_Panel.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.ultraTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultraWeekView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultraMonthViewSingle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultraDayView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.ultraMonthViewMulti1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ultraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents FrmCalendarOfEventsNAppointments_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _frmAppointmentGrouping_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAppointmentGrouping_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAppointmentGrouping_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAppointmentGrouping_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Private WithEvents pnlMain As Panel
    Private WithEvents ultraTimelineView1 As Infragistics.Win.UltraWinSchedule.UltraTimelineView
    Private WithEvents ultraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Private WithEvents ultraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
    Private WithEvents ultraWeekView1 As Infragistics.Win.UltraWinSchedule.UltraWeekView
    Private WithEvents ultraMonthViewSingle1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewSingle
    Private WithEvents ultraDayView1 As Infragistics.Win.UltraWinSchedule.UltraDayView
    Private WithEvents pnlLeft As Panel
    Private WithEvents pnlOwners As Panel
    Private WithEvents splitter2 As Splitter
    Private WithEvents ultraMonthViewMulti1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Private WithEvents contextMenu1 As Infragistics.Win.IGControls.IGContextMenu
End Class
