Public Class TodoItem

    Public Id As Guid
    Public TaskName As String
    Public TaskDate As Date
    Public TaskCompletedDate As Date
    Public TaskIsDone As Boolean

    Public Overrides Function ToString() As String
        If Not TaskIsDone Then
            Return TaskName
        Else
            Return String.Format("({0}) {1}", TaskCompletedDate.ToString, TaskName)
        End If
    End Function

End Class
