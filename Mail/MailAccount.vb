Imports System
Imports Email.Net.Common.Configurations

<Serializable>
Public Class MailAccount
        Implements IComparable

    Public Property AccountName As String
    Public Property InServer As String
    Public Property InServerOther As String
    Public Property LoginName As String
    Public Property LoginHost As String
    Public Property Password As String
    Public Property EmailType As String
    Public Property IMAPPort As Integer
    Public Property POPPort As Integer
    Public Property STMPPort As Integer
    Public Property SecType As EInteractionType
    Public Property attachemtnSaveDirectory As String

    Public Overrides Function ToString() As String
        Return AccountName
        ' Return String.Format("{0} ({1}, {2} , {3} , {4} , {5} , {6} ,{7} )", AccountName, InServer, Login, Password, IMAPPort, POPPort, STMPPort, SecType)
    End Function

    Private Function IComparable_CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If Not (TypeOf obj Is MailAccount) Then Throw New Exception("Try to compare MailAccount with unknown value")
        Dim ma As MailAccount = CType(obj, MailAccount)
        If ma Is Nothing Then Throw New Exception("Try to compare MailAccount with null value")
        Return ma.AccountName.CompareTo(AccountName)
    End Function

End Class


