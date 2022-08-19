Imports Infragistics.Win.UltraWinTree
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinSchedule

Public Class frmQuery
    Inherits System.Windows.Forms.Form

    Private _databaseSupport As WinScheduleDatabaseSupportBase
    Private _queryType As QueryType


    Public Sub New(ByVal databaseSupport As WinScheduleDatabaseSupportBase, ByVal queryType As QueryType)
        MyBase.New()
        Me._databaseSupport = databaseSupport
        Me._queryType = queryType
        Me.InitializeComponent()
        Me.InitializeUI()
    End Sub

    Private Sub InitializeUI()
        Me.UltraTree1.Override.ShowExpansionIndicator = ShowExpansionIndicator.CheckOnDisplay
        Me.UltraTree1.Override.CellClickAction = CellClickAction.EditCell

        Select Case (Me._queryType)

            Case QueryType.AllOwners
                Me.Text = My.Resources.QueryAllOwners

                '	Assign the data source
                Me.UltraTree1.DataSource = Me.GetOwnersTable()

            Case QueryType.AllAppointments
                Me.Text = My.Resources.QueryAllAppointments

                '	Assign the data source
                Me.UltraTree1.DataSource = Me.GetAppointmentsTable()

            Case QueryType.AppointmentsByOwner
                Me.Text = My.Resources.QueryAppointmentsByOwner

                Dim dataSet As DataSet = New DataSet()
                Dim ownersTable As DataTable = Me.GetOwnersTable()
                Dim appointmentsTable As DataTable = Me.GetAppointmentsTable()

                dataSet.Tables.Add(ownersTable)
                dataSet.Tables.Add(appointmentsTable)

                dataSet.Relations.Add("AppointmentData", ownersTable.Columns("Key"), appointmentsTable.Columns("OwnerKey"), False)

                Me.UltraTree1.SetDataBinding(dataSet, "OwnerData")

                If (Me.UltraTree1.Nodes.Count > 0) Then Me.UltraTree1.Nodes(0).Expanded = True

        End Select

        If (Me.UltraTree1.Nodes.Count > 0) Then Me.AutoSizeColumns()
    End Sub

    Private Sub FormatAppointments(ByVal columnSet As UltraTreeColumnSet)

        columnSet.AllowCellSizing = LayoutSizing.Both

        '	Iterate the columns and format the DateTime columns also,
        '	assign the editor appropriate to the data type
        Dim i As Integer
        For i = 0 To columnSet.Columns.Count - 1

            Dim column As UltraTreeNodeColumn = columnSet.Columns(i)
            If column.DataType Is GetType(DateTime) Then
                column.Format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
            ElseIf column.DataType Is GetType(Boolean) Then
                Dim checkEditor As CheckEditor = New CheckEditor()
                checkEditor.CheckAlign = ContentAlignment.MiddleCenter
                column.Editor = checkEditor
            ElseIf column.DataType Is GetType(Color) Then
                column.Editor = New ColorPickerEditor()
            End If

            If column.Key = "Description" Then
                column.CellWrapText = DefaultableBoolean.True
            End If
        Next
    End Sub

    Private Sub FormatOwners(ByVal columnSet As UltraTreeColumnSet)

        '	Iterate the columns and format the bool columns also,
        '	assign the editor appropriate to the data type
        Dim i As Integer
        For i = 0 To columnSet.Columns.Count - 1
            Dim column As UltraTreeNodeColumn = columnSet.Columns(i)
            If column.DataType Is GetType(Boolean) Then
                Dim checkEditor As CheckEditor = New CheckEditor()
                checkEditor.CheckAlign = ContentAlignment.MiddleCenter
                column.Editor = checkEditor
            End If
        Next
    End Sub

    Private Sub AutoSizeColumns()

        Dim columnSet As UltraTreeColumnSet
        For Each columnSet In Me.UltraTree1.ColumnSettings.ColumnSets

            Dim column As UltraTreeNodeColumn
            For Each column In columnSet.Columns
                If column.CellWrapText <> DefaultableBoolean.True Then column.PerformAutoResize(ColumnAutoSizeMode.AllNodes)
            Next
        Next
    End Sub

    Private Function GetAppointmentsTable() As DataTable

        '	Get a reference to the actual database table, and create
        '	a new table which will contain the Appointment properties
        Dim databaseTable As DataTable = Me._databaseSupport.Appointments
        Dim newTable As DataTable = New DataTable("AppointmentData")

        '	Note that we have access to any Appointment property when
        '	we break out the contents of the 'AllProperties' field, so
        '	the structure of the table can be arbitrary, depending on
        '	the application's requirements.
        newTable.Columns.Add("Subject", GetType(String))
        newTable.Columns.Add("StartDateTime", GetType(DateTime))
        newTable.Columns.Add("EndDateTime", GetType(DateTime))
        newTable.Columns.Add("Description", GetType(String))
        newTable.Columns.Add("Location", GetType(String))
        newTable.Columns.Add("OwnerKey", GetType(String))
        newTable.Columns.Add("AllDayEvent", GetType(Boolean))
        newTable.Columns.Add("Locked", GetType(Boolean))
        newTable.Columns.Add("Visible", GetType(Boolean))
        newTable.Columns.Add("IsRecurringAppointmentRoot", GetType(Boolean))
        newTable.Columns.Add("HasReminder", GetType(Boolean))
        newTable.Columns.Add("BarColor", GetType(Color))

        Dim i As Integer
        For i = 0 To databaseTable.Rows.Count - 1

            '	Get a reference to the DataRow
            Dim row As DataRow = databaseTable.Rows(i)

            '	Get the contents of the 'AllProperties' field if it is
            '	not a byte array (which should never happen, since that
            '	implies data corruption), skip this row so we don't hurt
            '	ourselves.
            Dim rawAppointmentData As Object = row("AllProperties")
            If (rawAppointmentData.GetType() Is GetType(Byte())) Then

                '	Get the byte array
                Dim appointmentBytes As Byte() = CType(rawAppointmentData, Byte())

                '	Create an Appointment from the byte array, using the
                '	Appointment's static 'FromBytes' method.
                Dim appointment As Appointment = Infragistics.Win.UltraWinSchedule.Appointment.FromBytes(appointmentBytes)

                '	If the 'FromBytes' method returned null, the data could not
                '	be streamed out into an Appointment, so skip this row.
                If Not appointment Is Nothing Then

                    '	Create an object array, populated with the appointment
                    '	properties of interest.
                    Dim appointmentData As Object() = New Object() _
                    {
                        appointment.Subject,
                        appointment.StartDateTime,
                        appointment.EndDateTime,
                        appointment.Description,
                        appointment.Location,
                        appointment.OwnerKey,
                        appointment.AllDayEvent,
                        appointment.Locked,
                        appointment.Visible,
                        appointment.IsRecurringAppointmentRoot,
                        appointment.HasReminder,
                        appointment.BarColor}

                    '	Add a row to the new table to represent this Appointment.
                    newTable.Rows.Add(appointmentData)
                End If

            End If
        Next

        Return newTable

    End Function

    Private Function GetOwnersTable() As DataTable

        '	Get a reference to the actual database table, and create
        '	a new table which will contain the Appointment properties
        Dim databaseTable As DataTable = Me._databaseSupport.Owners
        Dim newTable As DataTable = New DataTable("OwnerData")

        '	Note that we have access to any Owner property when
        '	we break out the contents of the 'AllProperties' field, so
        '	the structure of the table can be arbitrary, depending on
        '	the application's requirements.
        newTable.Columns.Add("Key", GetType(String))
        newTable.Columns.Add("Name", GetType(String))
        newTable.Columns.Add("EmailAddress", GetType(String))
        newTable.Columns.Add("Locked", GetType(Boolean))
        newTable.Columns.Add("Visible", GetType(Boolean))

        Dim i As Integer
        For i = 0 To databaseTable.Rows.Count - 1

            '	Get a reference to the DataRow
            Dim row As DataRow = databaseTable.Rows(i)

            '	Get the contents of the 'AllProperties' field if it is
            '	not a byte array (which should never happen, since that
            '	implies data corruption), skip this row so we don't hurt
            '	ourselves.
            Dim rawOwnerData As Object = row("AllProperties")
            If (rawOwnerData.GetType() Is GetType(Byte())) Then

                '	Get the byte array
                Dim OwnerBytes As Byte() = CType(rawOwnerData, Byte())

                '	Create an Owner from the byte array, using the
                '	Owner's static 'FromBytes' method.
                Dim owner As Owner = Infragistics.Win.UltraWinSchedule.Owner.FromBytes(OwnerBytes)

                '	If the 'FromBytes' method returned null, the data could not
                '	be streamed out into an Owner, so skip this row.
                If Not owner Is Nothing Then

                    '	Create an object array, populated with the Owner
                    '	properties of interest.
                    Dim ownerData As Object() = New Object() _
                    {
                        owner.Key,
                        owner.Name,
                        owner.EmailAddress,
                        owner.Locked,
                        owner.Visible}

                    '	Add a row to the new table to represent this Owner.
                    newTable.Rows.Add(ownerData)
                End If

            End If
        Next

        Return newTable

    End Function

    Private Sub UltraTree1_ColumnSetGenerated(sender As Object, e As Infragistics.Win.UltraWinTree.ColumnSetGeneratedEventArgs) Handles UltraTree1.ColumnSetGenerated
        Dim columnSet As UltraTreeColumnSet = e.ColumnSet

        Select Case Me._queryType

            Case QueryType.AllAppointments
                Me.FormatAppointments(columnSet)

            Case QueryType.AllOwners
                Me.FormatOwners(columnSet)

            Case QueryType.AppointmentsByOwner
                If Not columnSet.Key Is Nothing AndAlso columnSet.Key.Length > 0 Then
                    If (columnSet.Key = "OwnerData") Then Me.FormatOwners(columnSet)
                Else
                    If (columnSet.Key = "AppointmentData") Then Me.FormatAppointments(columnSet)
                End If

        End Select

    End Sub

End Class

Public Enum QueryType

    ' <summary>
    ' Constant which represents a database query which returns
    ' all Owners in the Owners collection.
    ' </summary>
    AllOwners

    ' <summary>
    ' Constant which represents a database query which returns
    ' all Appointments in the Appointments collection.
    ' </summary>
    AllAppointments

    ' <summary>
    ' Constant which represents a database query which returns
    ' Owners with their Appointments as a child table.
    ' </summary>
    AppointmentsByOwner

End Enum
