Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports System.Configuration
Imports System.Windows.Forms



Public Class FileOpenClose
    Public Sub OpenFile(ByVal filename As String, ByVal textBox As TextBox)
        Try

            If File.Exists(filename) Then
                Dim fs As FileStream = New FileStream(filename, FileMode.Open, FileAccess.Read)
                Dim sr As StreamReader = New StreamReader(fs)
                textBox.Text = sr.ReadToEnd()
                sr.Close()
            Else
                MessageBox.Show("Can't find file", "No file Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch err As FileLoadException
            MessageBox.Show(err.Message, "Can't read File")
        Catch __unusedException2__ As Exception
        End Try
    End Sub

    Public Sub SaveFile(ByVal fileName As String, ByVal textBox As TextBox)
        Try

            If textBox.Text.Length > 0 Then
                Dim fs As FileStream = New FileStream(fileName, FileMode.Create, FileAccess.Write)
                Dim sw As StreamWriter = New StreamWriter(fs)
                sw.Write(textBox.Text)
                sw.Close()
                MessageBox.Show("File saved", "Save")
            Else
                MessageBox.Show("Nothing to save - note is empty", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch __unusedException1__ As Exception
        End Try
    End Sub

End Class
