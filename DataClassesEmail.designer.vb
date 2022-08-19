﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Email")>  _
Partial Public Class DataClassesEmailDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertTblMailAttachment(instance As TblMailAttachment)
    End Sub
  Partial Private Sub UpdateTblMailAttachment(instance As TblMailAttachment)
    End Sub
  Partial Private Sub DeleteTblMailAttachment(instance As TblMailAttachment)
    End Sub
  Partial Private Sub InsertTblSentMailAttachment(instance As TblSentMailAttachment)
    End Sub
  Partial Private Sub UpdateTblSentMailAttachment(instance As TblSentMailAttachment)
    End Sub
  Partial Private Sub DeleteTblSentMailAttachment(instance As TblSentMailAttachment)
    End Sub
  Partial Private Sub InsertTblSentMessage(instance As TblSentMessage)
    End Sub
  Partial Private Sub UpdateTblSentMessage(instance As TblSentMessage)
    End Sub
  Partial Private Sub DeleteTblSentMessage(instance As TblSentMessage)
    End Sub
  Partial Private Sub InsertTblRfc822Message(instance As TblRfc822Message)
    End Sub
  Partial Private Sub UpdateTblRfc822Message(instance As TblRfc822Message)
    End Sub
  Partial Private Sub DeleteTblRfc822Message(instance As TblRfc822Message)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.HR.My.MySettings.Default.EmailConnectionString1, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property TblMailAttachments() As System.Data.Linq.Table(Of TblMailAttachment)
		Get
			Return Me.GetTable(Of TblMailAttachment)
		End Get
	End Property
	
	Public ReadOnly Property TblSentMailAttachments() As System.Data.Linq.Table(Of TblSentMailAttachment)
		Get
			Return Me.GetTable(Of TblSentMailAttachment)
		End Get
	End Property
	
	Public ReadOnly Property TblSentMessages() As System.Data.Linq.Table(Of TblSentMessage)
		Get
			Return Me.GetTable(Of TblSentMessage)
		End Get
	End Property
	
	Public ReadOnly Property TblRfc822Messages() As System.Data.Linq.Table(Of TblRfc822Message)
		Get
			Return Me.GetTable(Of TblRfc822Message)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblMailAttachments")>  _
Partial Public Class TblMailAttachment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _AttachmentID As Integer
	
	Private _AttachmentName As String
	
	Private _AttachmentType As String
	
	Private _Attachment() As Byte
	
	Private _MessageID As System.Nullable(Of Integer)
	
	Private _TblRfc822Message As EntityRef(Of TblRfc822Message)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnAttachmentIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAttachmentIDChanged()
    End Sub
    Partial Private Sub OnAttachmentNameChanging(value As String)
    End Sub
    Partial Private Sub OnAttachmentNameChanged()
    End Sub
    Partial Private Sub OnAttachmentTypeChanging(value As String)
    End Sub
    Partial Private Sub OnAttachmentTypeChanged()
    End Sub
    Partial Private Sub OnAttachmentChanging(value As Byte())
    End Sub
    Partial Private Sub OnAttachmentChanged()
    End Sub
    Partial Private Sub OnMessageIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnMessageIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblRfc822Message = CType(Nothing, EntityRef(Of TblRfc822Message))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property AttachmentID() As Integer
		Get
			Return Me._AttachmentID
		End Get
		Set
			If ((Me._AttachmentID = value)  _
						= false) Then
				Me.OnAttachmentIDChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentID = value
				Me.SendPropertyChanged("AttachmentID")
				Me.OnAttachmentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentName", DbType:="VarChar(MAX)")>  _
	Public Property AttachmentName() As String
		Get
			Return Me._AttachmentName
		End Get
		Set
			If (String.Equals(Me._AttachmentName, value) = false) Then
				Me.OnAttachmentNameChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentName = value
				Me.SendPropertyChanged("AttachmentName")
				Me.OnAttachmentNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentType", DbType:="VarChar(MAX)")>  _
	Public Property AttachmentType() As String
		Get
			Return Me._AttachmentType
		End Get
		Set
			If (String.Equals(Me._AttachmentType, value) = false) Then
				Me.OnAttachmentTypeChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentType = value
				Me.SendPropertyChanged("AttachmentType")
				Me.OnAttachmentTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Attachment", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Attachment() As Byte()
		Get
			Return Me._Attachment
		End Get
		Set
			If (Object.Equals(Me._Attachment, value) = false) Then
				Me.OnAttachmentChanging(value)
				Me.SendPropertyChanging
				Me._Attachment = value
				Me.SendPropertyChanged("Attachment")
				Me.OnAttachmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageID", DbType:="Int")>  _
	Public Property MessageID() As System.Nullable(Of Integer)
		Get
			Return Me._MessageID
		End Get
		Set
			If (Me._MessageID.Equals(value) = false) Then
				If Me._TblRfc822Message.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnMessageIDChanging(value)
				Me.SendPropertyChanging
				Me._MessageID = value
				Me.SendPropertyChanged("MessageID")
				Me.OnMessageIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblRfc822Message_TblMailAttachment", Storage:="_TblRfc822Message", ThisKey:="MessageID", OtherKey:="MessageID", IsForeignKey:=true)>  _
	Public Property TblRfc822Message() As TblRfc822Message
		Get
			Return Me._TblRfc822Message.Entity
		End Get
		Set
			Dim previousValue As TblRfc822Message = Me._TblRfc822Message.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TblRfc822Message.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TblRfc822Message.Entity = Nothing
					previousValue.TblMailAttachments.Remove(Me)
				End If
				Me._TblRfc822Message.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.TblMailAttachments.Add(Me)
					Me._MessageID = value.MessageID
				Else
					Me._MessageID = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("TblRfc822Message")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblSentMailAttachments")>  _
Partial Public Class TblSentMailAttachment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _AttachmentID As Integer
	
	Private _AttachmentName As String
	
	Private _AttachmentType As String
	
	Private _Attachment() As Byte
	
	Private _SentMessageID As System.Nullable(Of Integer)
	
	Private _TblSentMessage As EntityRef(Of TblSentMessage)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnAttachmentIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAttachmentIDChanged()
    End Sub
    Partial Private Sub OnAttachmentNameChanging(value As String)
    End Sub
    Partial Private Sub OnAttachmentNameChanged()
    End Sub
    Partial Private Sub OnAttachmentTypeChanging(value As String)
    End Sub
    Partial Private Sub OnAttachmentTypeChanged()
    End Sub
    Partial Private Sub OnAttachmentChanging(value As Byte())
    End Sub
    Partial Private Sub OnAttachmentChanged()
    End Sub
    Partial Private Sub OnSentMessageIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnSentMessageIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblSentMessage = CType(Nothing, EntityRef(Of TblSentMessage))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property AttachmentID() As Integer
		Get
			Return Me._AttachmentID
		End Get
		Set
			If ((Me._AttachmentID = value)  _
						= false) Then
				Me.OnAttachmentIDChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentID = value
				Me.SendPropertyChanged("AttachmentID")
				Me.OnAttachmentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentName", DbType:="VarChar(MAX)")>  _
	Public Property AttachmentName() As String
		Get
			Return Me._AttachmentName
		End Get
		Set
			If (String.Equals(Me._AttachmentName, value) = false) Then
				Me.OnAttachmentNameChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentName = value
				Me.SendPropertyChanged("AttachmentName")
				Me.OnAttachmentNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AttachmentType", DbType:="VarChar(MAX)")>  _
	Public Property AttachmentType() As String
		Get
			Return Me._AttachmentType
		End Get
		Set
			If (String.Equals(Me._AttachmentType, value) = false) Then
				Me.OnAttachmentTypeChanging(value)
				Me.SendPropertyChanging
				Me._AttachmentType = value
				Me.SendPropertyChanged("AttachmentType")
				Me.OnAttachmentTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Attachment", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Attachment() As Byte()
		Get
			Return Me._Attachment
		End Get
		Set
			If (Object.Equals(Me._Attachment, value) = false) Then
				Me.OnAttachmentChanging(value)
				Me.SendPropertyChanging
				Me._Attachment = value
				Me.SendPropertyChanged("Attachment")
				Me.OnAttachmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SentMessageID", DbType:="Int")>  _
	Public Property SentMessageID() As System.Nullable(Of Integer)
		Get
			Return Me._SentMessageID
		End Get
		Set
			If (Me._SentMessageID.Equals(value) = false) Then
				If Me._TblSentMessage.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnSentMessageIDChanging(value)
				Me.SendPropertyChanging
				Me._SentMessageID = value
				Me.SendPropertyChanged("SentMessageID")
				Me.OnSentMessageIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblSentMessage_TblSentMailAttachment", Storage:="_TblSentMessage", ThisKey:="SentMessageID", OtherKey:="SentMessageID", IsForeignKey:=true)>  _
	Public Property TblSentMessage() As TblSentMessage
		Get
			Return Me._TblSentMessage.Entity
		End Get
		Set
			Dim previousValue As TblSentMessage = Me._TblSentMessage.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TblSentMessage.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TblSentMessage.Entity = Nothing
					previousValue.TblSentMailAttachments.Remove(Me)
				End If
				Me._TblSentMessage.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.TblSentMailAttachments.Add(Me)
					Me._SentMessageID = value.SentMessageID
				Else
					Me._SentMessageID = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("TblSentMessage")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblSentMessages")>  _
Partial Public Class TblSentMessage
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _SentMessageID As Integer
	
	Private _From As String
	
	Private _Subject As String
	
	Private _MailDate As System.Nullable(Of Date)
	
	Private _To As String
	
	Private _Cc As String
	
	Private _Bcc As String
	
	Private _wbBody As String
	
	Private _tbBody As String
	
	Private _EmailUsername As String
	
	Private _TblSentMailAttachments As EntitySet(Of TblSentMailAttachment)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSentMessageIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnSentMessageIDChanged()
    End Sub
    Partial Private Sub OnFromChanging(value As String)
    End Sub
    Partial Private Sub OnFromChanged()
    End Sub
    Partial Private Sub OnSubjectChanging(value As String)
    End Sub
    Partial Private Sub OnSubjectChanged()
    End Sub
    Partial Private Sub OnMailDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnMailDateChanged()
    End Sub
    Partial Private Sub OnToChanging(value As String)
    End Sub
    Partial Private Sub OnToChanged()
    End Sub
    Partial Private Sub OnCcChanging(value As String)
    End Sub
    Partial Private Sub OnCcChanged()
    End Sub
    Partial Private Sub OnBccChanging(value As String)
    End Sub
    Partial Private Sub OnBccChanged()
    End Sub
    Partial Private Sub OnwbBodyChanging(value As String)
    End Sub
    Partial Private Sub OnwbBodyChanged()
    End Sub
    Partial Private Sub OntbBodyChanging(value As String)
    End Sub
    Partial Private Sub OntbBodyChanged()
    End Sub
    Partial Private Sub OnEmailUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnEmailUsernameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblSentMailAttachments = New EntitySet(Of TblSentMailAttachment)(AddressOf Me.attach_TblSentMailAttachments, AddressOf Me.detach_TblSentMailAttachments)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SentMessageID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property SentMessageID() As Integer
		Get
			Return Me._SentMessageID
		End Get
		Set
			If ((Me._SentMessageID = value)  _
						= false) Then
				Me.OnSentMessageIDChanging(value)
				Me.SendPropertyChanging
				Me._SentMessageID = value
				Me.SendPropertyChanged("SentMessageID")
				Me.OnSentMessageIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_From", DbType:="VarChar(50)")>  _
	Public Property [From]() As String
		Get
			Return Me._From
		End Get
		Set
			If (String.Equals(Me._From, value) = false) Then
				Me.OnFromChanging(value)
				Me.SendPropertyChanging
				Me._From = value
				Me.SendPropertyChanged("[From]")
				Me.OnFromChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Subject", DbType:="VarChar(50)")>  _
	Public Property Subject() As String
		Get
			Return Me._Subject
		End Get
		Set
			If (String.Equals(Me._Subject, value) = false) Then
				Me.OnSubjectChanging(value)
				Me.SendPropertyChanging
				Me._Subject = value
				Me.SendPropertyChanged("Subject")
				Me.OnSubjectChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MailDate", DbType:="DateTime")>  _
	Public Property MailDate() As System.Nullable(Of Date)
		Get
			Return Me._MailDate
		End Get
		Set
			If (Me._MailDate.Equals(value) = false) Then
				Me.OnMailDateChanging(value)
				Me.SendPropertyChanging
				Me._MailDate = value
				Me.SendPropertyChanged("MailDate")
				Me.OnMailDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_To", DbType:="VarChar(50)")>  _
	Public Property [To]() As String
		Get
			Return Me._To
		End Get
		Set
			If (String.Equals(Me._To, value) = false) Then
				Me.OnToChanging(value)
				Me.SendPropertyChanging
				Me._To = value
				Me.SendPropertyChanged("[To]")
				Me.OnToChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cc", DbType:="VarChar(50)")>  _
	Public Property Cc() As String
		Get
			Return Me._Cc
		End Get
		Set
			If (String.Equals(Me._Cc, value) = false) Then
				Me.OnCcChanging(value)
				Me.SendPropertyChanging
				Me._Cc = value
				Me.SendPropertyChanged("Cc")
				Me.OnCcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Bcc", DbType:="VarChar(50)")>  _
	Public Property Bcc() As String
		Get
			Return Me._Bcc
		End Get
		Set
			If (String.Equals(Me._Bcc, value) = false) Then
				Me.OnBccChanging(value)
				Me.SendPropertyChanging
				Me._Bcc = value
				Me.SendPropertyChanged("Bcc")
				Me.OnBccChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_wbBody", DbType:="VarChar(MAX)")>  _
	Public Property wbBody() As String
		Get
			Return Me._wbBody
		End Get
		Set
			If (String.Equals(Me._wbBody, value) = false) Then
				Me.OnwbBodyChanging(value)
				Me.SendPropertyChanging
				Me._wbBody = value
				Me.SendPropertyChanged("wbBody")
				Me.OnwbBodyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tbBody", DbType:="VarChar(MAX)")>  _
	Public Property tbBody() As String
		Get
			Return Me._tbBody
		End Get
		Set
			If (String.Equals(Me._tbBody, value) = false) Then
				Me.OntbBodyChanging(value)
				Me.SendPropertyChanging
				Me._tbBody = value
				Me.SendPropertyChanged("tbBody")
				Me.OntbBodyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailUsername", DbType:="VarChar(50)")>  _
	Public Property EmailUsername() As String
		Get
			Return Me._EmailUsername
		End Get
		Set
			If (String.Equals(Me._EmailUsername, value) = false) Then
				Me.OnEmailUsernameChanging(value)
				Me.SendPropertyChanging
				Me._EmailUsername = value
				Me.SendPropertyChanged("EmailUsername")
				Me.OnEmailUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblSentMessage_TblSentMailAttachment", Storage:="_TblSentMailAttachments", ThisKey:="SentMessageID", OtherKey:="SentMessageID")>  _
	Public Property TblSentMailAttachments() As EntitySet(Of TblSentMailAttachment)
		Get
			Return Me._TblSentMailAttachments
		End Get
		Set
			Me._TblSentMailAttachments.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_TblSentMailAttachments(ByVal entity As TblSentMailAttachment)
		Me.SendPropertyChanging
		entity.TblSentMessage = Me
	End Sub
	
	Private Sub detach_TblSentMailAttachments(ByVal entity As TblSentMailAttachment)
		Me.SendPropertyChanging
		entity.TblSentMessage = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblRfc822Message")>  _
Partial Public Class TblRfc822Message
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _MessageID As Integer
	
	Private _From As String
	
	Private _Subject As String
	
	Private _MailDate As System.Nullable(Of Date)
	
	Private _To As String
	
	Private _Cc As String
	
	Private _Bcc As String
	
	Private _wbBody As String
	
	Private _tbBody As String
	
	Private _EmailUsername As String
	
	Private _TblMailAttachments As EntitySet(Of TblMailAttachment)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMessageIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnMessageIDChanged()
    End Sub
    Partial Private Sub OnFromChanging(value As String)
    End Sub
    Partial Private Sub OnFromChanged()
    End Sub
    Partial Private Sub OnSubjectChanging(value As String)
    End Sub
    Partial Private Sub OnSubjectChanged()
    End Sub
    Partial Private Sub OnMailDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnMailDateChanged()
    End Sub
    Partial Private Sub OnToChanging(value As String)
    End Sub
    Partial Private Sub OnToChanged()
    End Sub
    Partial Private Sub OnCcChanging(value As String)
    End Sub
    Partial Private Sub OnCcChanged()
    End Sub
    Partial Private Sub OnBccChanging(value As String)
    End Sub
    Partial Private Sub OnBccChanged()
    End Sub
    Partial Private Sub OnwbBodyChanging(value As String)
    End Sub
    Partial Private Sub OnwbBodyChanged()
    End Sub
    Partial Private Sub OntbBodyChanging(value As String)
    End Sub
    Partial Private Sub OntbBodyChanged()
    End Sub
    Partial Private Sub OnEmailUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnEmailUsernameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblMailAttachments = New EntitySet(Of TblMailAttachment)(AddressOf Me.attach_TblMailAttachments, AddressOf Me.detach_TblMailAttachments)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property MessageID() As Integer
		Get
			Return Me._MessageID
		End Get
		Set
			If ((Me._MessageID = value)  _
						= false) Then
				Me.OnMessageIDChanging(value)
				Me.SendPropertyChanging
				Me._MessageID = value
				Me.SendPropertyChanged("MessageID")
				Me.OnMessageIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_From", DbType:="VarChar(50)")>  _
	Public Property [From]() As String
		Get
			Return Me._From
		End Get
		Set
			If (String.Equals(Me._From, value) = false) Then
				Me.OnFromChanging(value)
				Me.SendPropertyChanging
				Me._From = value
				Me.SendPropertyChanged("[From]")
				Me.OnFromChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Subject", DbType:="VarChar(50)")>  _
	Public Property Subject() As String
		Get
			Return Me._Subject
		End Get
		Set
			If (String.Equals(Me._Subject, value) = false) Then
				Me.OnSubjectChanging(value)
				Me.SendPropertyChanging
				Me._Subject = value
				Me.SendPropertyChanged("Subject")
				Me.OnSubjectChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MailDate", DbType:="DateTime")>  _
	Public Property MailDate() As System.Nullable(Of Date)
		Get
			Return Me._MailDate
		End Get
		Set
			If (Me._MailDate.Equals(value) = false) Then
				Me.OnMailDateChanging(value)
				Me.SendPropertyChanging
				Me._MailDate = value
				Me.SendPropertyChanged("MailDate")
				Me.OnMailDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_To", DbType:="VarChar(50)")>  _
	Public Property [To]() As String
		Get
			Return Me._To
		End Get
		Set
			If (String.Equals(Me._To, value) = false) Then
				Me.OnToChanging(value)
				Me.SendPropertyChanging
				Me._To = value
				Me.SendPropertyChanged("[To]")
				Me.OnToChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cc", DbType:="VarChar(50)")>  _
	Public Property Cc() As String
		Get
			Return Me._Cc
		End Get
		Set
			If (String.Equals(Me._Cc, value) = false) Then
				Me.OnCcChanging(value)
				Me.SendPropertyChanging
				Me._Cc = value
				Me.SendPropertyChanged("Cc")
				Me.OnCcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Bcc", DbType:="VarChar(50)")>  _
	Public Property Bcc() As String
		Get
			Return Me._Bcc
		End Get
		Set
			If (String.Equals(Me._Bcc, value) = false) Then
				Me.OnBccChanging(value)
				Me.SendPropertyChanging
				Me._Bcc = value
				Me.SendPropertyChanged("Bcc")
				Me.OnBccChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_wbBody", DbType:="VarChar(MAX)")>  _
	Public Property wbBody() As String
		Get
			Return Me._wbBody
		End Get
		Set
			If (String.Equals(Me._wbBody, value) = false) Then
				Me.OnwbBodyChanging(value)
				Me.SendPropertyChanging
				Me._wbBody = value
				Me.SendPropertyChanged("wbBody")
				Me.OnwbBodyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tbBody", DbType:="VarChar(MAX)")>  _
	Public Property tbBody() As String
		Get
			Return Me._tbBody
		End Get
		Set
			If (String.Equals(Me._tbBody, value) = false) Then
				Me.OntbBodyChanging(value)
				Me.SendPropertyChanging
				Me._tbBody = value
				Me.SendPropertyChanged("tbBody")
				Me.OntbBodyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailUsername", DbType:="VarChar(50)")>  _
	Public Property EmailUsername() As String
		Get
			Return Me._EmailUsername
		End Get
		Set
			If (String.Equals(Me._EmailUsername, value) = false) Then
				Me.OnEmailUsernameChanging(value)
				Me.SendPropertyChanging
				Me._EmailUsername = value
				Me.SendPropertyChanged("EmailUsername")
				Me.OnEmailUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblRfc822Message_TblMailAttachment", Storage:="_TblMailAttachments", ThisKey:="MessageID", OtherKey:="MessageID")>  _
	Public Property TblMailAttachments() As EntitySet(Of TblMailAttachment)
		Get
			Return Me._TblMailAttachments
		End Get
		Set
			Me._TblMailAttachments.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_TblMailAttachments(ByVal entity As TblMailAttachment)
		Me.SendPropertyChanging
		entity.TblRfc822Message = Me
	End Sub
	
	Private Sub detach_TblMailAttachments(ByVal entity As TblMailAttachment)
		Me.SendPropertyChanging
		entity.TblRfc822Message = Nothing
	End Sub
End Class
