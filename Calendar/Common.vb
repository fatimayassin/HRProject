Public Class Common
#Region "Constructor"
    Private Sub New()
    End Sub
#End Region     'Constructor

#Region "Constants"

    '#If CLR2 Then
    'HKCR path
    'Private Const DataRegistryKey As String = "Infragistics\NetAdvantage\Net\Full\WinForms\CLR2x\Version" & Infragistics.Shared.AssemblyVersion.MajorMinor & "\WinDataDir"
    '#Else
    'HKCR path
    Private Const DataRegistryKey As String = "Infragistics\NetAdvantage\Net\Full\WinForms\CLR4x\Version" & Infragistics.Shared.AssemblyVersion.MajorMinor & "\WinDataDir"
    '#End If

#End Region  'Constants

#Region "DataPath"
    ' <summary>
    ' Path to the data installed by the install.
    ' </summary>
    Public Shared ReadOnly Property DataPath() As String
        Get
            Dim dataRegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(DataRegistryKey)
            Dim path As String = Nothing

            If Not dataRegKey Is Nothing Then
                path = CType(dataRegKey.GetValue(Nothing), String)
                dataRegKey.Close()
            End If

            Return path
        End Get
    End Property
#End Region   'DataPath
End Class
