Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Public Class GetStyleLibrary

#Region "Private Members"

    Private islFileName As String = "LucidDream.isl"
    Private Const DataRegistryKey As String = "Infragistics\NetAdvantage\Net\Full\WinForms\CLR4x\Version" & Infragistics.Shared.AssemblyVersion.MajorMinor & "\SamplesDirectory"

#End Region

#Region "styleLibraryPath"

    '<summary>
    ' Path to the Style Library folder installed by the install.
    ' </summary>"
    Private Shared ReadOnly Property styleLibraryPath() As String
        Get
            Dim dataRegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(DataRegistryKey)
            If dataRegKey Is Nothing Then
                Return Nothing
            End If

            Dim path As String = Nothing
            path = (CType(dataRegKey.GetValue(Nothing), String) & "Legacy\Data\StyleLibrary")

            dataRegKey.Close()
            Return path
        End Get
    End Property

#End Region

#Region "Private Methods"

#Region "GetIsl"

    Public Function GetIsl() As String
        Return System.IO.Path.Combine(styleLibraryPath, islFileName)
    End Function

#End Region

#End Region
End Class
