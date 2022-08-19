Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class DateInfo
    Public Function GetCurrentDateTime() As String
        Return (DateTime.Today).ToShortDateString() & "       " & String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Function
End Class
