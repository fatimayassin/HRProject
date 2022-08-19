Imports Infragistics.Win
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinSchedule
Imports Infragistics.Win.UltraWinToolbars

Public Class FrmCalendarOfEventsNAppointments

    Private WithEvents menuItem_ModifyOwner As Infragistics.Win.IGControls.IGMenuItem
    Private WithEvents menuItem_RemoveOwner As Infragistics.Win.IGControls.IGMenuItem
    Const DATABASE_SQLSERVER As Boolean = True
    Private _databaseSupport As WinScheduleDatabaseSupportBase = Nothing

    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
        Me.InitializeUI()
    End Sub

    Private Sub InitializeUI()

        'Load the IG isl File
        'Dim style As GetStyleLibrary = New GetStyleLibrary
        ' Dim islFile As String = style.GetIsl
        '  Infragistics.Win.AppStyling.StyleManager.Load(islFile)

        '	Set the appointment grouping properties for the WinSchedule controls
        '	that support appointment grouping.
        Me.ultraDayView1.GroupingStyle = DayViewGroupingStyle.OwnerWithinDate
        Me.ultraWeekView1.OwnerDisplayStyle = OwnerDisplayStyle.Separate
        Me.ultraWeekView1.MaximumOwnersInView = 2
        Me.ultraMonthViewSingle1.OwnerDisplayStyle = OwnerDisplayStyle.Separate
        Me.ultraMonthViewSingle1.MaximumOwnersInView = 2
        Me.ultraTimelineView1.OwnerGroupingStyle = TimelineViewOwnerGroupingStyle.Separate
        Me.ultraTimelineView1.MaximumOwnersInView = 2

        '	Hide the unassigned owner
        Me.ultraCalendarInfo1.Owners.UnassignedOwner.Visible = False

        '	Set up data binding for Owners
        Dim ownersDataBinding As OwnersDataBinding = Me.ultraCalendarInfo1.DataBindingsForOwners
        ownersDataBinding.AllPropertiesMember = "AllProperties"
        ownersDataBinding.NameMember = "Name"
        ownersDataBinding.KeyMember = "OwnerKey"
        ownersDataBinding.VisibleMember = "Visible"
        ownersDataBinding.SetDataBinding(Me.DatabaseSupport.DataSet, WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME)
        ownersDataBinding.BindingContextControl = Me
        ownersDataBinding.BindingContext = Me.BindingContext

        '	Set up data binding for Appointments
        Dim appointmentsDataBinding As AppointmentsDataBinding = Me.ultraCalendarInfo1.DataBindingsForAppointments
        appointmentsDataBinding.AllPropertiesMember = "AllProperties"
        appointmentsDataBinding.StartDateTimeMember = "StartDateTime"
        appointmentsDataBinding.EndDateTimeMember = "EndDateTime"
        appointmentsDataBinding.SubjectMember = "Subject"
        appointmentsDataBinding.AllDayEventMember = "AllDayEvent"
        appointmentsDataBinding.OwnerKeyMember = "OwnerKey"
        appointmentsDataBinding.SetDataBinding(Me.DatabaseSupport.DataSet, WinScheduleDatabaseSupportBase.APPOINTMENTS_TABLE_NAME)
        appointmentsDataBinding.BindingContextControl = Me
        appointmentsDataBinding.BindingContext = Me.BindingContext

        '	Configure the context menu, and assign the context menu to
        '	each of the WinSchedule controls
        Me.menuItem_ModifyOwner = New Infragistics.Win.IGControls.IGMenuItem(My.Resources.ModifyOwnerMenu)
        Me.menuItem_RemoveOwner = New Infragistics.Win.IGControls.IGMenuItem(My.Resources.RemoveOwnerMenu)
        Me.contextMenu1.MenuItems.Add(Me.menuItem_ModifyOwner)
        Me.contextMenu1.MenuItems.Add(Me.menuItem_RemoveOwner)
        Me.ultraDayView1.ContextMenu = Me.contextMenu1
        Me.ultraWeekView1.ContextMenu = Me.contextMenu1
        Me.ultraMonthViewSingle1.ContextMenu = Me.contextMenu1
        Me.ultraTimelineView1.ContextMenu = Me.contextMenu1

        '	Add a checkbox for each owner in the collection to the Panel control
        Me.InitializeOwnersPanel(False)

        '	Initialize the dialog for the current view
        If (Me.ultraCalendarLook1.ViewStyle = ViewStyle.Office2007) Then

            Dim colorScheme As Office2007ColorScheme = Infragistics.Win.Office2007ColorTable.ColorScheme
            Dim toolKey As String = String.Format("menuMain_View_Office2007_{0}", colorScheme)
            If (Me.ultraToolbarsManager1.Tools.Exists(toolKey)) Then
                Dim tool As ToolBase = Me.ultraToolbarsManager1.Tools(toolKey)
                Me.ultraToolbarsManager1_ToolClick(Me.ultraToolbarsManager1, New ToolClickEventArgs(tool, Nothing))

                '	Reserve the default color schemes we will assign them to
                '	the Owner that was initially present in the database table.
                Dim colorSchemes As Outlook2007ColorSchemeCollection = Me.ultraCalendarLook1.Outlook2007ColorSchemes
                colorSchemes.DisallowAutoAssignment(colorSchemes.BaseColorBlue)
                colorSchemes.DisallowAutoAssignment(colorSchemes.BaseColorBlack)
            End If
        End If

    End Sub

    Private Sub InitializeOwnersPanel(ByVal refreshOnly As Boolean)
        Dim i As Integer
        If refreshOnly Then
            For i = 0 To Me.pnlOwners.Controls.Count - 1

                If Me.pnlOwners.Controls(i).GetType() Is GetType(UltraCheckEditor) Then
                    Dim checkEditor As UltraCheckEditor = Me.pnlOwners.Controls(i)

                    Dim owner As Owner = CType(checkEditor.Tag, Owner)
                    If checkEditor.Text <> owner.Name Then checkEditor.Text = owner.Name
                    If checkEditor.Checked <> owner.Visible Then checkEditor.Checked = owner.Visible
                End If
            Next
        Else

            Me.pnlOwners.Controls.Clear()

            For i = 0 To Me.ultraCalendarInfo1.Owners.Count - 1
                Dim owner As Owner = Me.ultraCalendarInfo1.Owners(i)
                Me.AddCheckboxForOwner(owner)
            Next
        End If
    End Sub

    Private Sub AddCheckboxForOwner(ByVal owner As Owner)

        Dim controlCount As Integer = Me.pnlOwners.Controls.Count
        Dim newTop As Integer = controlCount * 20

        Dim checkEditor As UltraCheckEditor = New UltraCheckEditor()
        checkEditor.Text = owner.Name
        checkEditor.Checked = owner.Visible
        checkEditor.Tag = owner
        checkEditor.Location = New Point(Me.pnlOwners.Left + 2, newTop)
        checkEditor.Size = New Size(Me.pnlOwners.Width - 5, 20)
        Me.pnlOwners.Controls.Add(checkEditor)
        checkEditor.BringToFront()
        AddHandler checkEditor.CheckedChanged, AddressOf Me.OwnerCheckbox_CheckedChanged
    End Sub

    Private Sub ShowScheduleControl(ByVal scheduleControl As UltraScheduleControlBase)

        If (Not scheduleControl Is Me.ultraDayView1) Then Me.ultraDayView1.Visible = False

        If (Not scheduleControl Is Me.ultraWeekView1) Then Me.ultraWeekView1.Visible = False

        If (Not scheduleControl Is Me.ultraMonthViewSingle1) Then Me.ultraMonthViewSingle1.Visible = False

        If (Not scheduleControl Is Me.ultraTimelineView1) Then Me.ultraTimelineView1.Visible = False

        scheduleControl.Visible = True
        scheduleControl.Dock = DockStyle.Fill
    End Sub

    Private ReadOnly Property DatabaseSupport() As WinScheduleDatabaseSupportBase
        Get
            If Me._databaseSupport Is Nothing Then
                '   Note that by default, the 'DATABASE_SQLSERVER' constant
                '   is defined as false; to use this sample with a SQL Server
                '   database requires that the database be created and set up.
                If DATABASE_SQLSERVER Then
                    Me._databaseSupport = New WinScheduleMSSQLServerSupport()
                Else
                    Me._databaseSupport = New WinScheduleMSAccessSupport()
                End If
            End If
            Return Me._databaseSupport
        End Get
    End Property

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '	If the Appointments or Owners table has changes pending that have not
        '	yet been committed to the database, prompt the end user to determine
        '	whether they want to save the changes.
        If (Me.DatabaseSupport.HasAppointmentChanges Or Me.DatabaseSupport.HasOwnerChanges) Then

            Dim result As DialogResult
            ' result = MessageBox.Show(My.Resources.SaveChangesMessage, My.Resources.SaveChangesTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            result = MessageBox.Show(MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case result

                Case System.Windows.Forms.DialogResult.Cancel
                    e.Cancel = True

                Case System.Windows.Forms.DialogResult.Yes

                    Try
                        Me.DatabaseSupport.UpdateAppointmentsTable()
                    Catch ex As Exception
                        '    MessageBox.Show(My.Resources.AppointmentUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    Try
                        Me.DatabaseSupport.UpdateOwnersTable()
                    Catch ex As Exception
                        '  MessageBox.Show(My.Resources.OwnersUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

            End Select


        End If

    End Sub

    Private Sub ultraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles ultraToolbarsManager1.ToolClick

        Select Case (e.Tool.Key)
            Case "Day"
                Me.ShowScheduleControl(Me.ultraDayView1)
            Case "Week"
                Me.ShowScheduleControl(Me.ultraWeekView1)
            Case "Month"
                Me.ShowScheduleControl(Me.ultraMonthViewSingle1)
            Case "TimeLine"
                Me.ShowScheduleControl(Me.ultraTimelineView1)

            Case "menuMain_View_Standard"
                Me.ultraDayView1.Appearance.BackColor = SystemColors.Control
                Me.ultraCalendarLook1.ViewStyle = ViewStyle.Standard
                Me.ultraToolbarsManager1.Style = ToolbarStyle.OfficeXP
                Me.contextMenu1.Style = IGControls.MenuStyle.OfficeXP

            Case "menuMain_View_Office2003"
                Me.ultraDayView1.Appearance.BackColor = SystemColors.Control
                Me.ultraCalendarLook1.ViewStyle = ViewStyle.Office2003
                Me.ultraToolbarsManager1.Style = ToolbarStyle.Office2003
                Me.contextMenu1.Style = IGControls.MenuStyle.Office2003

            Case "menuMain_View_VS2005"
                Me.ultraDayView1.Appearance.BackColor = SystemColors.Control
                Me.ultraCalendarLook1.ViewStyle = ViewStyle.VisualStudio2005
                Me.ultraToolbarsManager1.Style = ToolbarStyle.VisualStudio2005
                Me.contextMenu1.Style = IGControls.MenuStyle.VisualStudio2005

            Case "menuMain_View_Office2007_Blue", "menuMain_View_Office2007_Black", "menuMain_View_Office2007_Silver"

                Me.ultraDayView1.Appearance.Reset()
                Me.ultraCalendarLook1.ViewStyle = ViewStyle.Office2007
                Me.ultraToolbarsManager1.Style = ToolbarStyle.Office2007
                Me.contextMenu1.Style = Infragistics.Win.IGControls.MenuStyle.Office2007

                If (e.Tool.Key = "menuMain_View_Office2007_Blue") Then
                    Infragistics.Win.Office2007ColorTable.ColorScheme = Office2007ColorScheme.Blue
                ElseIf (e.Tool.Key = "menuMain_View_Office2007_Black") Then
                    Infragistics.Win.Office2007ColorTable.ColorScheme = Office2007ColorScheme.Black
                Else
                    Infragistics.Win.Office2007ColorTable.ColorScheme = Office2007ColorScheme.Silver
                End If

                Dim stateButtonTool As StateButtonTool = Me.ultraToolbarsManager1.Tools(e.Tool.Key)
                stateButtonTool.Checked = True

                '	Assign the default color scheme
                Dim ownerKey As String = "INFRAGISTICS_POWER_USER"
                If (Me.ultraCalendarInfo1.Owners.Exists(ownerKey)) Then
                    Dim owner As Infragistics.Win.UltraWinSchedule.Owner = Me.ultraCalendarInfo1.Owners(ownerKey)
                    owner.Outlook2007ColorScheme = Me.ultraCalendarLook1.Outlook2007ColorSchemes.DefaultScheme
                End If

            Case "AddOwner"
                Dim frmOwner As frmOwner = New frmOwner(Me.ultraCalendarInfo1)
                frmOwner.ShowMe(Nothing)
                If frmOwner.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Dim newOwner As Owner = Me.ultraCalendarInfo1.Owners.Add(frmOwner.Key, frmOwner.OwnerName)
                    newOwner.EmailAddress = frmOwner.EmailAddress
                    newOwner.Visible = frmOwner.OwnerVisible
                    newOwner.Locked = frmOwner.Locked
                    Me.AddCheckboxForOwner(newOwner)
                End If

            Case "menuMain_Data_UpdateAppointmentsTable"
                Try
                    Me.DatabaseSupport.UpdateAppointmentsTable()
                Catch ex As Exception
                    MessageBox.Show(My.Resources.AppointmentUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case "menuMain_Data_UpdateOwnersTable"
                Try
                    Me.DatabaseSupport.UpdateOwnersTable()
                Catch ex As Exception
                    MessageBox.Show(My.Resources.OwnersUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case "menuQueries_AllAppointments", "menuQueries_AllOwners", "menuQueries_AppointmentsByOwner"
                Dim queryType As QueryType = QueryType.AllAppointments
                If e.Tool.Key = "menuQueries_AllOwners" Then
                    queryType = QueryType.AllOwners
                ElseIf (e.Tool.Key = "menuQueries_AppointmentsByOwner") Then
                    queryType = QueryType.AppointmentsByOwner
                End If

                Dim frmQuery As frmQuery = New frmQuery(Me.DatabaseSupport, queryType)
                frmQuery.ShowDialog()

            Case "menuMain_File_Exit"
                Me.Close()

            Case "Save"

                If (Me.DatabaseSupport.HasAppointmentChanges Or Me.DatabaseSupport.HasOwnerChanges) Then
                    Dim result As DialogResult
                    result = MessageBox.Show(My.Resources.SaveChangesMessage, My.Resources.SaveChangesTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Select Case result

                    'Case System.Windows.Forms.DialogResult.Cancel
                    'e.Cancel = True

                        Case System.Windows.Forms.DialogResult.Yes
                            Try
                                Me.DatabaseSupport.UpdateAppointmentsTable()
                            Catch ex As Exception
                                MessageBox.Show(My.Resources.AppointmentUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                            Try
                                Me.DatabaseSupport.UpdateOwnersTable()
                            Catch ex As Exception
                                MessageBox.Show(My.Resources.OwnersUpdateError + ex.Message, My.Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                    End Select
                End If

        End Select

    End Sub

    Private Sub WinScheduleControl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ultraDayView1.MouseDown, ultraWeekView1.MouseDown, ultraMonthViewSingle1.MouseDown, ultraTimelineView1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim cursorPos As Point = New Point(e.X, e.Y)
            Dim ownerAtPoint As Owner = Nothing

            If sender Is Me.ultraDayView1 Then
                ownerAtPoint = Me.ultraDayView1.GetOwnerFromPoint(cursorPos)
            ElseIf sender.GetType() Is GetType(UltraMonthViewSingleBase) Then
                Dim monthView As UltraMonthViewSingleBase = CType(sender, UltraMonthViewSingleBase)
                ownerAtPoint = monthView.GetOwnerFromPoint(cursorPos)
            End If

            If Not ownerAtPoint Is Nothing Then
                Me.menuItem_ModifyOwner.Tag = ownerAtPoint
                Me.menuItem_RemoveOwner.Tag = ownerAtPoint
            End If
        End If
    End Sub

    Private Sub OnContextMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles menuItem_ModifyOwner.Click, menuItem_RemoveOwner.Click

        Dim owner As Owner = Nothing
        If sender Is Me.menuItem_ModifyOwner Then
            owner = CType(Me.menuItem_ModifyOwner.Tag, Owner)
            Dim frmOwner As frmOwner = New frmOwner(Me.ultraCalendarInfo1)
            frmOwner.Text = String.Format(My.Resources.ModifyOwner, owner.Name)
            frmOwner.ShowMe(owner)
            If frmOwner.DialogResult = System.Windows.Forms.DialogResult.OK Then

                owner.Key = frmOwner.Key
                owner.Name = frmOwner.OwnerName
                owner.EmailAddress = frmOwner.EmailAddress
                owner.Visible = frmOwner.OwnerVisible
                owner.Locked = frmOwner.Locked
                Me.InitializeOwnersPanel(True)
            End If
        ElseIf sender Is Me.menuItem_RemoveOwner Then
            owner = CType(Me.menuItem_RemoveOwner.Tag, Owner)
            Dim result As DialogResult = MessageBox.Show(String.Format(My.Resources.RemoveOwnerMessage, owner.Name), My.Resources.RemoveOwnerTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.ultraCalendarInfo1.Owners.Remove(owner)
                Me.InitializeOwnersPanel(False)
            End If
        End If

    End Sub

    Private Sub OwnerCheckbox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim checkEditor As UltraCheckEditor = sender
        Dim owner As Owner = CType(checkEditor.Tag, Owner)
        owner.Visible = checkEditor.Checked
    End Sub

    Private Sub ultraCalendarInfo1_ValidateAppointment(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinSchedule.ValidateAppointmentEventArgs)
        '	Make sure the number of bytes needed to serialize the Appointment
        '	does not exceed the size of the 'AllProperties' field.
        Dim appointmentBytes As Byte() = e.Appointment.Save()
        If (Not appointmentBytes Is Nothing AndAlso appointmentBytes.Length > WinScheduleDatabaseSupportBase.MAX_APPOINTMENT_BYTES) Then

            e.Message = My.Resources.ValidateAppointmentMessage
            e.CloseDialog = False
        End If

    End Sub

End Class