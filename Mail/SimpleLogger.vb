Imports System
Imports System.Collections
Imports Email.Net.Imap.Responses

Public Class SimpleLogger
    Private destination As IList

    Public Sub New(ByVal logDest As IList)
        destination = logDest
    End Sub

    Public Sub setOutput(ByVal logDest As IList)
        destination = logDest
    End Sub

    Public Sub addLogMessage(ByVal mes As String)
        destination.Add(DateTime.Now.ToLongTimeString() + mes)
    End Sub

    Public Sub addLogMessage(ByVal resp As CompletionResponse)
        destination.Add(DateTime.Now.ToLongTimeString() & ". Response: " & resp.Response & " Message: " + resp.Message)
    End Sub

    Public Sub addLogMessage(ByVal mes As String, ByVal resp As CompletionResponse)
        destination.Add(DateTime.Now.ToLongTimeString() & " " & mes & ". Response: " & resp.Response & " Message: " + resp.Message)
    End Sub
End Class

