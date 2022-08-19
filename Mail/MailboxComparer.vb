Imports System.Collections.Generic
Imports Email.Net.Imap

Public Class MailboxComparer
    Implements IEqualityComparer(Of Mailbox)

    Public Function IEqualityComparer_Equals(mb As Mailbox, mb2 As Mailbox) As Boolean Implements IEqualityComparer(Of Mailbox).Equals
        If mb Is Nothing OrElse mb2 Is Nothing Then

            If mb Is mb2 Then
                Return True
            Else
                Return False
            End If
        End If

        Dim par As Mailbox = mb.Parent
        Dim par2 As Mailbox = mb2.Parent

        If mb.FullName.Equals(mb2.FullName) Then

            If mb.Children.Count = mb2.Children.Count Then
                If (par Is Nothing AndAlso par2 Is Nothing) OrElse par.FullName.Equals(par2.FullName) Then Return True
            End If
        End If

        Return False
    End Function

    Public Function IEqualityComparer_GetHashCode(mb As Mailbox) As Integer Implements IEqualityComparer(Of Mailbox).GetHashCode
        Return mb.GetHashCode()
    End Function
End Class


