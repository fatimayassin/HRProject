Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

#Region "WinScheduleDatabaseSupportBase class"
' <summary>
' Base class for the WinSchedule database access classes.
' </summary>
' <remarks>
' The <b>WinScheduleDatabaseSupportBase</b> class is an abstract class which
' defines properties that return instances of the OleDB-related classes that
' are necessary to connect to a database. The 'ConnectionString' property,
' which must be overridden in a derived class, defines the connection string
' specific to that type of database. The DataAdapterForOwners and
' DataAdapterForAppointments properties, which also must be overridden in a
' derived class, define the OleDbCommand instances which control the selection,
' updating, and deletion of records in their respective tables.
' </remarks>
Public MustInherit Class WinScheduleDatabaseSupportBase
    Implements IDisposable

#Region "Constants"
    ' <summary>
    ' Template for the SQL SELECT statement for Owners.
    ' </summary>
    Protected Const SELECT_OWNERS_TEMPLATE As String = "SELECT * FROM {0}"

    ' <summary>
    ' Template for the SQL SELECT statement for Appointments.
    ' </summary>
    Protected Const SELECT_APPOINTMENTS_TEMPLATE As String = "SELECT * FROM {0}"

    ' <summary>
    ' Defines the name of the table that contains the Owner data.
    ' </summary>
    Public Const OWNERS_TABLE_NAME As String = "Owners"

    ' <summary>
    ' Defines the name of the table that contains the Appointment data.
    ' </summary>
    Public Const APPOINTMENTS_TABLE_NAME As String = "Appointments"

    ' <summary>
    ' The maximum number of bytes allowed for an appointment. Note that this
    ' is a function of the database table, and should not be changed here.
    ' </summary>
    Public Const MAX_APPOINTMENT_BYTES As Integer = 1024

#End Region

#Region "Member variables"

    Friend _oleDbConnection As OleDbConnection = Nothing
    Friend _oleDbDataAdapterForOwners As OleDbDataAdapter = Nothing
    Friend _oleDbDataAdapterForAppointments As OleDbDataAdapter = Nothing
    Private _dataSet As DataSet = Nothing
    Private WithEvents _dataTableOwners As DataTable = Nothing
    Private WithEvents _dataTableAppointments As DataTable = Nothing
    Private _hasOwnerChanges As Boolean = False
    Private _hasAppointmentChanges As Boolean = False

#End Region

#Region "Connection"
    ' <summary>
    ' Returns the OleDbConnection with which to connect to the data source.
    ' An attempt is made to open the connection the first time the property
    ' is accessed.
    ' </summary>
    Protected ReadOnly Property Connection() As OleDbConnection
        Get
            If Me._oleDbConnection Is Nothing Then

                Me._oleDbConnection = New OleDbConnection()
                Me._oleDbConnection.ConnectionString = Me.ConnectionString

                Try

                    Me._oleDbConnection.Open()

                Catch ex As Exception

                    MessageBox.Show("Could not connect to data source: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            Return Me._oleDbConnection

        End Get
    End Property
#End Region

#Region "ConnectionString"
    ' <summary>
    ' Returns the connection string to be assigned to the ConnectionString
    ' property of the OleDbConnection referenced by the <see cref="Connection"/>
    ' property. Must be overridden in derived classes to return a valid connection
    ' string for the type of database associated with the derived class.
    ' </summary>
    Protected MustOverride ReadOnly Property ConnectionString() As String
#End Region

#Region "DataAdapterForOwners"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Owner data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected MustOverride ReadOnly Property DataAdapterForOwners() As OleDbDataAdapter
#End Region

#Region "DataAdapterForAppointments"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Appointment data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected MustOverride ReadOnly Property DataAdapterForAppointments() As OleDbDataAdapter
#End Region

#Region "DataSet"

    ' <summary>
    ' Returns the DataSet which holds the Owner and Appointment data.
    ' </summary>
    Public ReadOnly Property DataSet() As DataSet
        Get
            If Me._dataSet Is Nothing Then Me._dataSet = New DataSet("WinSchedule")

            Dim dataAdapter As OleDbDataAdapter = Nothing

            If Me._dataSet.Tables.Contains(WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME) = False Then

                dataAdapter = Me.DataAdapterForOwners
                Try
                    dataAdapter.Fill(Me._dataSet, WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Me._dataTableOwners = Me._dataSet.Tables(WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME)

            End If

            If Me._dataSet.Tables.Contains(WinScheduleDatabaseSupportBase.APPOINTMENTS_TABLE_NAME) = False Then

                dataAdapter = Me.DataAdapterForAppointments
                Try
                    dataAdapter.Fill(Me._dataSet, WinScheduleDatabaseSupportBase.APPOINTMENTS_TABLE_NAME)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Me._dataTableAppointments = Me._dataSet.Tables(WinScheduleDatabaseSupportBase.APPOINTMENTS_TABLE_NAME)

            End If

            Return Me._dataSet
        End Get
    End Property

#End Region

#Region "Owners"
    ' <summary>
    ' Returns the DataTable which contains the Owner data.
    ' </summary>
    Public ReadOnly Property Owners() As DataTable
        Get
            Return Me._dataSet.Tables(WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME)
        End Get
    End Property
#End Region

#Region "Appointments"
    ' <summary>
    ' Returns the DataTable which contains the Appointment data.
    ' </summary>
    Public ReadOnly Property Appointments() As DataTable
        Get
            Return Me._dataSet.Tables(WinScheduleDatabaseSupportBase.APPOINTMENTS_TABLE_NAME)
        End Get
    End Property
#End Region

#Region "OnRowChanged"
    Private Sub OnRowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs) Handles _dataTableOwners.RowChanged, _dataTableOwners.RowDeleted, _dataTableAppointments.RowChanged, _dataTableAppointments.RowDeleted
        If sender Is Me._dataTableAppointments Then Me._hasAppointmentChanges = True
        If sender Is Me._dataTableOwners Then Me._hasOwnerChanges = True
    End Sub
#End Region

#Region "UpdateOwnersTable"
    ' <summary>
    ' Commits any outstanding changes to owner data to the DataTable.
    ' </summary>
    Public Sub UpdateOwnersTable()
        If Me.HasOwnerChanges = False Then Return
        Me.DataAdapterForOwners.Update(Me.DataSet, WinScheduleDatabaseSupportBase.OWNERS_TABLE_NAME)
        Me._hasOwnerChanges = False
    End Sub
#End Region

#Region "UpdateAppointmentsTable"
    ' <summary>
    ' Commits any outstanding changes to appointment data to the DataTable.
    ' </summary>
    Public Sub UpdateAppointmentsTable()
        If Me.HasAppointmentChanges = False Then
            Return
        End If

        Try
            'Me.DataSet.Tables(WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME).AcceptChanges()

            '8/19/15
            'This is all you need to call - the update process also includes 
            'the clearing of any "dirty" flags or pending changes flags.
            Me.DataAdapterForAppointments.Update(Me.DataSet, WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME)
        Catch ee As Exception
            MessageBox.Show(String.Format("DB Error = {0}", ee.Message))
        End Try
        Me._hasAppointmentChanges = False
    End Sub
#End Region

#Region "HasOwnerChanges"

    ' <summary>
    ' Returns whether the Owners table has changes which have not
    ' been committed to the database.
    ' </summary>
    Public ReadOnly Property HasOwnerChanges() As Boolean
        Get
            Return Me._hasOwnerChanges
        End Get
    End Property
#End Region

#Region "HasAppointmentChanges"

    ' <summary>
    ' Returns whether the Appointments table has changes which have not
    ' been committed to the database.
    ' </summary>
    Public ReadOnly Property HasAppointmentChanges() As Boolean
        Get
            Return Me._hasAppointmentChanges
        End Get
    End Property
#End Region

#Region "IDisposable"
    ' <summary>
    ' Implements the IDisposable interface's Dispose method.
    ' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose

        If Not Me._oleDbConnection Is Nothing Then

            Me._oleDbConnection.Close()
            Me._oleDbConnection.Dispose()
            Me._oleDbConnection = Nothing
        End If

        If Not Me._oleDbDataAdapterForAppointments Is Nothing Then

            Me._oleDbDataAdapterForAppointments.Dispose()
            Me._oleDbDataAdapterForAppointments = Nothing
        End If

        If Not Me._oleDbDataAdapterForOwners Is Nothing Then

            Me._oleDbDataAdapterForOwners.Dispose()
            Me._oleDbDataAdapterForOwners = Nothing
        End If

        If Not Me._dataSet Is Nothing Then

            Me._dataSet.Dispose()
            Me._dataSet = Nothing
        End If
    End Sub

#End Region

End Class
#End Region

#Region "WinScheduleMSSQLServerSupport class"
' <summary>
' Handles communication between the WinSchedule data binding layer
' and a SQL Server database.
' </summary>
' <remarks>
' The WinScheduleMSSQLServerSupport class exposes properties that simplify the coding
' that is necessary to bind the UltraCalendarInfo component's Appointments and Owners
' collections to a SQL Server database.
' </remarks>
Public Class WinScheduleMSSQLServerSupport
    Inherits WinScheduleDatabaseSupportBase

#Region "Constants"

    ' <summary>
    ' Defines the connection string takes the following 5 parameters:
    ' 
    ' Parameter {0} = UserId
    ' Parameter {1} = Password
    ' Parameter {2} = DatabaseName
    ' Parameter {3} = ServerName
    ' Parameter {4} = WorkstationId
    ' </summary>
    Private Const DATABASE_CONNECTION_STRING_TEMPLATE As String = "Provider=SQLOLEDB.1Persist Security Info=FalseUser ID={0}Password={1}Initial Catalog={2}Data Source={3}Use Procedure for Prepare=1Auto Translate=TruePacket Size=4096Workstation ID={4}Use Encryption for Data=FalseTag with column collation when possible=False"

    ' <summary>
    ' The value of the 'User ID' parameter of the connection string.
    ' </summary>
    Private Const DATABASE_USER_ID As String = "WinSchedule"

    ' <summary>
    ' The value of the 'Password' parameter of the connection string.
    ' </summary>
    Private Const DATABASE_PASSWORD As String = "password"

    ' <summary>
    ' The value of the 'Initial Catalog' parameter of the connection string.
    ' </summary>
    Private Const DATABASE_NAME As String = "WinScheduleData"

    ' <summary>
    ' The value of the 'DataSource' parameter of the connection string.
    ' </summary>
    Private Const DATABASE_SERVER_NAME As String = "."

#End Region

#Region "ConnectionString"
    ' <summary>
    ' Returns a connection string specific to the SQL Server database
    ' associated with this instance.
    ' </summary>
    Protected Overrides ReadOnly Property ConnectionString() As String
        Get
            Dim workstationId As String = SystemInformation.ComputerName
            '  Dim _connectionString As String = String.Format(DATABASE_CONNECTION_STRING_TEMPLATE, DATABASE_USER_ID, DATABASE_PASSWORD, DATABASE_NAME, DATABASE_SERVER_NAME, workstationId)
            ' Dim _connectionString As String = "Data Source = .;Initial Catalog=WinScheduleData;Integrated Security=True"
            Dim _connectionString As String = "Provider=SQLOLEDB;Data Source=.;Initial Catalog = WinScheduleData;User ID = WinSchedule;Password=P@ssw0rd;"
            Return _connectionString
        End Get
    End Property
#End Region

#Region "DataAdapterForOwners"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Owner data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected Overrides ReadOnly Property DataAdapterForOwners() As OleDbDataAdapter
        Get
            If Me._oleDbDataAdapterForOwners Is Nothing Then

                Me._oleDbDataAdapterForOwners = New OleDbDataAdapter()

                '	Configure the SELECT command
                Dim selectCommandText As String = String.Format(WinScheduleMSSQLServerSupport.SELECT_OWNERS_TEMPLATE, WinScheduleMSSQLServerSupport.OWNERS_TABLE_NAME)
                Me._oleDbDataAdapterForOwners.SelectCommand = New OleDbCommand(selectCommandText, Me.Connection)

                '	Configure the INSERT command
                Dim insertCommand As OleDbCommand = New OleDbCommand()
                Dim commandTextTemplate As String = "INSERT INTO {0}(OwnerKey, AllProperties, Name, Visible) VALUES (?, ?, ?, ?) SELECT OwnerKey, AllProperties, Name, Visible FROM {0} WHERE (OwnerKey= ?)"
                insertCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.OWNERS_TABLE_NAME)
                insertCommand.Connection = Me.Connection
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 256, "AllProperties"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarChar, 50, "Name"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Visible", System.Data.OleDb.OleDbType.Boolean, 1, "Visible"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                Me._oleDbDataAdapterForOwners.InsertCommand = insertCommand

                '	Configure the UPDATE command
                Dim updateCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "UPDATE {0} SET OwnerKey = ?, AllProperties = ?, Name = ?, Visible = ? WHERE (OwnerKey = ?) AND (AllProperties = ? OR ? IS Null AND AllProperties IS Null) AND (Name = ?) AND (Visible = ?) SELECT OwnerKey, AllProperties, Name, Visible FROM {0} WHERE (OwnerKey = ?)"
                updateCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.OWNERS_TABLE_NAME)
                updateCommand.Connection = Me.Connection
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 256, "AllProperties"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarChar, 50, "Name"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Visible", System.Data.OleDb.OleDbType.Boolean, 1, "Visible"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Visible", System.Data.OleDb.OleDbType.Boolean, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Visible", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                Me._oleDbDataAdapterForOwners.UpdateCommand = updateCommand

                '	Configure the DELETE command
                Dim deleteCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "DELETE FROM {0} WHERE (OwnerKey = ?) AND (AllProperties = ? OR ? IS Null AND AllProperties IS Null) AND (Name = ?) AND (Visible = ?)"
                deleteCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.OWNERS_TABLE_NAME)
                deleteCommand.Connection = Me.Connection
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 256, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 256, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Visible", System.Data.OleDb.OleDbType.Boolean, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Visible", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForOwners.DeleteCommand = deleteCommand

            End If

            Return Me._oleDbDataAdapterForOwners
        End Get
    End Property
#End Region

#Region "DataAdapterForAppointments"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Appointment data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected Overrides ReadOnly Property DataAdapterForAppointments() As OleDbDataAdapter
        Get
            If Me._oleDbDataAdapterForAppointments Is Nothing Then

                Me._oleDbDataAdapterForAppointments = New OleDbDataAdapter()

                '	Configure the SELECT command
                Dim selectCommandText As String = String.Format(WinScheduleMSSQLServerSupport.SELECT_APPOINTMENTS_TEMPLATE, WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME)
                Me._oleDbDataAdapterForAppointments.SelectCommand = New OleDbCommand(selectCommandText, Me.Connection)

                '	Configure the INSERT command
                Dim insertCommand As OleDbCommand = New OleDbCommand()
                Dim commandTextTemplate As String = "INSERT INTO {0}(AllProperties, StartDateTime, EndDateTime, Subject, AllDayEvent, OwnerKey) VALUES (?, ?, ?, ?, ?, ?) SELECT AppointmentID, AllProperties, StartDateTime, EndDateTime, Subject, AllDayEvent, OwnerKey FROM {0} WHERE (AppointmentID = @@IDENTITY)"
                insertCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME)
                insertCommand.Connection = Me.Connection
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 1024, "AllProperties"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "StartDateTime"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "EndDateTime"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subject", System.Data.OleDb.OleDbType.VarChar, 50, "Subject"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 1, "AllDayEvent"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                Me._oleDbDataAdapterForAppointments.InsertCommand = insertCommand

                '	Configure the UPDATE command
                Dim updateCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "UPDATE {0} SET AllProperties = ?, StartDateTime = ?, EndDateTime = ?, Subject = ?, AllDayEvent = ?, OwnerKey = ? WHERE (AppointmentID = ?) AND (AllDayEvent = ?) AND (AllProperties = ? OR ? IS Null AND AllProperties IS Null) AND (EndDateTime = ?) AND (OwnerKey = ? OR ? IS Null AND OwnerKey IS Null) AND (StartDateTime = ?) AND (Subject = ?) SELECT AppointmentID, AllProperties, StartDateTime, EndDateTime, Subject, AllDayEvent, OwnerKey FROM {0} WHERE (AppointmentID = ?)"
                'commandTextTemplate = "UPDATE {0} SET AllProperties = ?, StartDateTime = ?, EndDateTime = ?, Subject = ?, AllDayEvent = ?, OwnerKey = ? WHERE (AppointmentID = ?) AND (AllDayEvent = ?) AND (AllProperties = ? ) AND (EndDateTime = ?) AND (OwnerKey = ? ) AND (StartDateTime = ?) AND (Subject = ?) SELECT AppointmentID, AllProperties, StartDateTime, EndDateTime, Subject, AllDayEvent, OwnerKey FROM {0} WHERE (AppointmentID = ?)"
                'commandTextTemplate = "UPDATE {0} SET AllProperties = ?, StartDateTime = ?, EndDateTime = ?, Subject = ?, AllDayEvent = ?, OwnerKey = ? WHERE (AppointmentID = ?) AND (AllDayEvent = ?) AND (AllProperties = ? OR ? IS Null) AND (EndDateTime = ?) AND (OwnerKey = ? OR ? IS Null ) AND (StartDateTime = ?) AND (Subject = ?) SELECT AppointmentID, AllProperties, StartDateTime, EndDateTime, Subject, AllDayEvent, OwnerKey FROM {0} WHERE (AppointmentID = ?)"
                updateCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME)
                updateCommand.Connection = Me.Connection
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 1024, "AllProperties"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "StartDateTime"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "EndDateTime"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subject", System.Data.OleDb.OleDbType.VarChar, 50, "Subject"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 1, "AllDayEvent"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, "OwnerKey"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AppointmentID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AppointmentID", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllDayEvent", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndDateTime", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDateTime", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_AppointmentID", System.Data.OleDb.OleDbType.Integer, 4, "AppointmentID"))
                Me._oleDbDataAdapterForAppointments.UpdateCommand = updateCommand
                'Me._dataTableAppointments.AcceptChanges()

                '	Configure the DELETE command
                Dim deleteCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "DELETE FROM {0} WHERE (AppointmentID = ?) AND (AllDayEvent = ?) AND (AllProperties = ? OR ? IS Null AND AllProperties IS Null) AND (EndDateTime = ?) AND (OwnerKey = ? OR ? IS Null AND OwnerKey IS Null) AND (StartDateTime = ?) AND (Subject = ?)"
                'commandTextTemplate = "DELETE FROM {0} WHERE (AppointmentID = ?) AND (AllDayEvent = ?) AND (AllProperties = ?) AND (EndDateTime = ?) AND (OwnerKey = ?) AND (StartDateTime = ?) AND (Subject = ?)"
                deleteCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSSQLServerSupport.APPOINTMENTS_TABLE_NAME)
                deleteCommand.Connection = Me.Connection
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AppointmentID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AppointmentID", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllDayEvent", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndDateTime", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDateTime", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForAppointments.DeleteCommand = deleteCommand

            End If

            Return Me._oleDbDataAdapterForAppointments
        End Get
    End Property
#End Region

End Class
#End Region

#Region "WinScheduleMSAccessSupport class"
' <summary>
' Handles communication between the WinSchedule data binding layer
' and an MS Access database.
' </summary>
' <remarks>
' The WinScheduleMSAccessSupport class exposes properties that simplify the coding
' that is necessary to bind the UltraCalendarInfo component's Appointments and Owners
' collections to an MS Access database.
' </remarks>
Public Class WinScheduleMSAccessSupport
    Inherits WinScheduleDatabaseSupportBase

#Region "Constants"

    ' <summary>
    ' Defines the connection string; takes the following parameters:
    ' 
    ' Parameter {0} = Path to the location (directory) of the database file
    ' Parameter {1} = Name of the database file, including file extension
    ' </summary>
    Private Const DATABASE_CONNECTION_STRING_TEMPLATE As String = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source={0}\{1};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"

    ' <summary>
    ' The value of the 'Initial Catalog' parameter of the connection string.
    ' </summary>
    Private Const DATABASE_NAME As String = "WinScheduleData.mdb"

#End Region

#Region "ConnectionString"
    ' <summary>
    ' Returns a connection string specific to the MS Access database
    ' associated with this instance.
    ' </summary>
    Protected Overrides ReadOnly Property ConnectionString() As String
        Get
            Dim _connectionString As String = String.Empty
            Dim databasePath As String = Common.DataPath
            If Not databasePath Is Nothing Then
                _connectionString = String.Format(DATABASE_CONNECTION_STRING_TEMPLATE, databasePath, DATABASE_NAME)
            End If

            Return _connectionString
        End Get
    End Property
#End Region

#Region "DataAdapterForOwners"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Owner data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected Overrides ReadOnly Property DataAdapterForOwners() As OleDbDataAdapter
        Get
            If Me._oleDbDataAdapterForOwners Is Nothing Then

                Me._oleDbDataAdapterForOwners = New OleDbDataAdapter()

                '	Configure the SELECT command
                Dim selectCommandText As String = String.Format(WinScheduleMSSQLServerSupport.SELECT_OWNERS_TEMPLATE, WinScheduleMSSQLServerSupport.OWNERS_TABLE_NAME)
                Me._oleDbDataAdapterForOwners.SelectCommand = New OleDbCommand(selectCommandText, Me.Connection)

                '	Configure the INSERT command
                Dim insertCommand As OleDbCommand = New OleDbCommand()
                Dim commandTextTemplate As String = "INSERT INTO {0}(AllProperties, Name, OwnerKey, Visible) VALUES (?, ?, ?, ?)"
                insertCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.OWNERS_TABLE_NAME)
                insertCommand.Connection = Me.Connection
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, "AllProperties"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, "OwnerKey"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Visible", System.Data.OleDb.OleDbType.Boolean, 2, "Visible"))
                Me._oleDbDataAdapterForOwners.InsertCommand = insertCommand

                '	Configure the UPDATE command
                Dim updateCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "UPDATE {0} SET AllProperties = ?, Name = ?, OwnerKey = ?, Visible = ? WHERE (OwnerKey = ?) AND (AllProperties = ? OR ? IS NULL AND AllProperties IS NULL) AND (Name = ?) AND (Visible = ?)"
                updateCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.OWNERS_TABLE_NAME)
                updateCommand.Connection = Me.Connection
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, "AllProperties"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, "OwnerKey"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Visible", System.Data.OleDb.OleDbType.Boolean, 2, "Visible"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Visible", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Visible", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForOwners.UpdateCommand = updateCommand

                '	Configure the DELETE command
                Dim deleteCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "DELETE FROM {0} WHERE (OwnerKey = ?) AND (AllProperties = ? OR ? IS NULL AND AllProperties IS NULL) AND (Name = ?) AND (Visible = ?)"
                deleteCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.OWNERS_TABLE_NAME)
                deleteCommand.Connection = Me.Connection
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Visible", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Visible", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForOwners.DeleteCommand = deleteCommand

            End If

            Return Me._oleDbDataAdapterForOwners
        End Get
    End Property
#End Region

#Region "DataAdapterForAppointments"
    ' <summary>
    ' Returns the OleDbDataAdapter to be used for Appointment data.
    ' </summary>
    ' <remarks>
    ' The OleDbDataAdapter instance referenced by this property is "lazily" created,
    ' i.e., object creation is deferred until the property is requested. When the
    ' object is created, the InsertCommand, UpdateCommand and DeleteCommand properties
    ' are all set to new instances of OleDbCommand objects, and those instances are
    ' configured appropriately.
    ' </remarks>
    Protected Overrides ReadOnly Property DataAdapterForAppointments() As OleDbDataAdapter
        Get
            If Me._oleDbDataAdapterForAppointments Is Nothing Then

                Me._oleDbDataAdapterForAppointments = New OleDbDataAdapter()

                '	Configure the SELECT command
                Dim selectCommandText As String = String.Format(WinScheduleMSAccessSupport.SELECT_APPOINTMENTS_TEMPLATE, WinScheduleMSAccessSupport.APPOINTMENTS_TABLE_NAME)
                Me._oleDbDataAdapterForAppointments.SelectCommand = New OleDbCommand(selectCommandText, Me.Connection)

                '	Configure the INSERT command
                Dim insertCommand As OleDbCommand = New OleDbCommand()
                Dim commandTextTemplate As String = "INSERT INTO {0}(AllDayEvent, AllProperties, EndDateTime, OwnerKey, StartDateTime, Subject) VALUES (?, ?, ?, ?, ?, ?)"
                insertCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.APPOINTMENTS_TABLE_NAME)
                insertCommand.Connection = Me.Connection
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 2, "AllDayEvent"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, "AllProperties"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "EndDateTime"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, "OwnerKey"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "StartDateTime"))
                insertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subject", System.Data.OleDb.OleDbType.VarWChar, 50, "Subject"))
                Me._oleDbDataAdapterForAppointments.InsertCommand = insertCommand

                '	Configure the UPDATE command
                Dim updateCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "UPDATE {0} SET AllDayEvent = ?, AllProperties = ?, EndDateTime = ?, OwnerKey = ?, StartDateTime = ?, Subject = ? WHERE (AppointmentId = ?) AND (AllDayEvent = ?) AND (AllProperties = ? OR ? IS NULL AND AllProperties IS NULL) AND (EndDateTime = ?) AND (OwnerKey = ? OR ? IS NULL AND OwnerKey IS NULL) AND (StartDateTime = ?) AND (Subject = ? OR ? IS NULL AND Subject IS NULL)"
                updateCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.APPOINTMENTS_TABLE_NAME)
                updateCommand.Connection = Me.Connection
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 2, "AllDayEvent"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, "AllProperties"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "EndDateTime"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, "OwnerKey"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "StartDateTime"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subject", System.Data.OleDb.OleDbType.VarWChar, 50, "Subject"))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AppointmentId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AppointmentId", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllDayEvent", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndDateTime", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDateTime", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                updateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForAppointments.UpdateCommand = updateCommand

                '	Configure the DELETE command
                Dim deleteCommand As OleDbCommand = New OleDbCommand()
                commandTextTemplate = "DELETE FROM {0} WHERE (AppointmentId = ?) AND (AllDayEvent = ?) AND (AllProperties = ? OR ? IS NULL AND AllProperties IS NULL) AND (EndDateTime = ?) AND (OwnerKey = ? OR ? IS NULL AND OwnerKey IS NULL) AND (StartDateTime = ?) AND (Subject = ? OR ? IS NULL AND Subject IS NULL)"
                deleteCommand.CommandText = String.Format(commandTextTemplate, WinScheduleMSAccessSupport.APPOINTMENTS_TABLE_NAME)
                deleteCommand.Connection = Me.Connection
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AppointmentId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AppointmentId", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllDayEvent", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllDayEvent", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AllProperties1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AllProperties", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EndDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndDateTime", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OwnerKey1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OwnerKey", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDateTime", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDateTime", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                deleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subject1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subject", System.Data.DataRowVersion.Original, Nothing))
                Me._oleDbDataAdapterForAppointments.DeleteCommand = deleteCommand

            End If

            Return Me._oleDbDataAdapterForAppointments
        End Get
    End Property
#End Region

End Class
#End Region
