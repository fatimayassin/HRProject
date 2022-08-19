Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration


Public Class ConfManager
    Public Function GetValue(ByVal paramName As String) As Integer
        Return Convert.ToInt32(ConfigurationManager.AppSettings(paramName))
    End Function

    Public Function GetValueString(ByVal paramName As String) As String
        Return ConfigurationManager.AppSettings(paramName).ToString()
    End Function

    Public Sub SetStringParam(ByVal paramName As String, ByVal value As Integer)
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath)
        config.AppSettings.Settings(paramName).Value = value.ToString()
        config.Save(ConfigurationSaveMode.Modified)
    End Sub

    Public Sub SetStringParam(ByVal paramName As String, ByVal value As String)
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath)
        config.AppSettings.Settings(paramName).Value = value
        config.Save(ConfigurationSaveMode.Modified)
    End Sub

End Class
