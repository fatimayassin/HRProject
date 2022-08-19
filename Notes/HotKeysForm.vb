Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class HotKeysForm
    Private cm As ConfManager = New ConfManager()

    Public Sub New()
        InitializeComponent()
        LoadHotKeys()
        LoadConfigForHotKeys()
    End Sub

    Private Sub HotKeysForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub checkBoxEnableHotKeys_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxEnableHotKeys.CheckedChanged
        If checkBoxEnableHotKeys.Checked Then
            EnableControls(Me.Controls, True)
            cm.SetStringParam("enableChecked", "true")
        End If

        If Not checkBoxEnableHotKeys.Checked Then
            EnableControls(Me.Controls, False)
            cm.SetStringParam("enableChecked", "false")
        End If

        checkBoxEnableHotKeys.Enabled = True
    End Sub

    Private Sub EnableControls(ByVal controls As Control.ControlCollection, ByVal status As Boolean)
        For Each c As Control In controls
            c.Enabled = status

            If TypeOf c Is MenuStrip Then
                c.Enabled = True
            End If

            If c.Controls.Count > 0 Then
                EnableControls(c.Controls, status)
            End If
        Next

        tableLayoutPanel1.Enabled = True
        checkBoxEnableHotKeys.Enabled = True
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSave.Click
        Try
            cm.SetStringParam("open", textBoxOpenKey1.Text.Replace("Key", "") & "," + textBoxOpenKey2.Text.Replace("Key", ""))
            cm.SetStringParam("close", textBoxCloseKey1.Text.Replace("Key", "") & "," + textBoxCloseKey2.Text.Replace("Key", ""))
            cm.SetStringParam("clear", textBoxClearKey1.Text.Replace("Key", "") & "," + textBoxclearKey2.Text.Replace("Key", ""))
            cm.SetStringParam("settings", textBoxSettingsKey1.Text.Replace("Key", "") & "," + textBoxSettingsKey2.Text.Replace("Key", ""))
            cm.SetStringParam("fontKey", textBoxFontKey1.Text.Replace("Key", "") & "," + textBoxFontKey2.Text.Replace("Key", ""))
            cm.SetStringParam("colorKey", textBoxColorKey1.Text.Replace("Key", "") & "," + textBoxColorKey2.Text.Replace("Key", ""))
            cm.SetStringParam("defaultKey", textBoxLoadKey1.Text.Replace("Key", "") & "," + textBoxLoadKey2.Text.Replace("Key", ""))
            MessageBox.Show("Hotkeys Storred successfuly", "Settings Stored", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub LoadHotKeys()
        'Dim keyValueTemp As String()
        'keyValueTemp = cm.GetValueString("open").ToString().Split(","c)
        'textBoxOpenKey1.Text = keyValueTemp(0)
        'textBoxOpenKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("close").ToString().Split(","c)
        'textBoxCloseKey1.Text = keyValueTemp(0)
        'textBoxCloseKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("clear").ToString().Split(","c)
        'textBoxClearKey1.Text = keyValueTemp(0)
        'textBoxclearKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("settings").ToString().Split(","c)
        'textBoxSettingsKey1.Text = keyValueTemp(0)
        'textBoxSettingsKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("fontKey").ToString().Split(","c)
        'textBoxFontKey1.Text = keyValueTemp(0)
        'textBoxFontKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("colorKey").ToString().Split(","c)
        'textBoxColorKey1.Text = keyValueTemp(0)
        'textBoxColorKey2.Text = keyValueTemp(1)
        'keyValueTemp = cm.GetValueString("defaultKey").ToString().Split(","c)
        'textBoxLoadKey1.Text = keyValueTemp(0)
        'textBoxLoadKey2.Text = keyValueTemp(1)
    End Sub

    Private Sub LoadConfigForHotKeys()
        'If cm.GetValueString("enableChecked") = "true" Then
        '    checkBoxEnableHotKeys.Enabled = True
        '    checkBoxEnableHotKeys.Checked = True

        '    If cm.GetValueString("openChecked") = "true" Then
        '        checkBoxOpen.Checked = True
        '    End If

        '    If cm.GetValueString("closeChecked") = "true" Then
        '        checkBoxClose.Checked = True
        '    End If

        '    If cm.GetValueString("clearChecked") = "true" Then
        '        checkBoxClear.Checked = True
        '    End If

        '    If cm.GetValueString("settingsChecked") = "true" Then
        '        checkBoxSettings.Checked = True
        '    End If

        '    If cm.GetValueString("colorKeyChecked") = "true" Then
        '        checkBoxColor.Checked = True
        '    End If

        '    If cm.GetValueString("fontKeyChecked") = "true" Then
        '        checkBoxFont.Checked = True
        '    End If

        '    If cm.GetValueString("defaultKeyChecked") = "true" Then
        '        checkBoxDefault.Checked = True
        '    End If
        ' End If
    End Sub

    Private Sub CaptureKeyPress(ByVal textBox As TextBox, ByVal e As KeyEventArgs)
        textBox.Clear()
        textBox.Text = e.KeyCode.ToString()
    End Sub

    Private Sub textBoxOpenKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxOpenKey1.KeyDown
        CaptureKeyPress(textBoxOpenKey1, e)
    End Sub

    Private Sub textBoxOpenKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxOpenKey2.KeyDown
        CaptureKeyPress(textBoxOpenKey2, e)
    End Sub

    Private Sub textBoxCloseKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxCloseKey1.KeyDown
        CaptureKeyPress(textBoxCloseKey1, e)
    End Sub

    Private Sub textBoxCloseKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxCloseKey2.KeyDown
        CaptureKeyPress(textBoxCloseKey2, e)
    End Sub

    Private Sub textBoxClearKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxClearKey1.KeyDown
        CaptureKeyPress(textBoxClearKey1, e)
    End Sub

    Private Sub textBoxclearKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxclearKey2.KeyDown
        CaptureKeyPress(textBoxclearKey2, e)
    End Sub

    Private Sub textBoxSettingsKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxSettingsKey1.KeyDown
        CaptureKeyPress(textBoxSettingsKey1, e)
    End Sub

    Private Sub textBoxSettingsKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxSettingsKey2.KeyDown
        CaptureKeyPress(textBoxSettingsKey2, e)
    End Sub

    Private Sub textBoxColorKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxColorKey1.KeyDown
        CaptureKeyPress(textBoxColorKey1, e)
    End Sub

    Private Sub textBoxColorKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxColorKey2.KeyDown
        CaptureKeyPress(textBoxColorKey2, e)
    End Sub

    Private Sub textBoxFontKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxFontKey1.KeyDown
        CaptureKeyPress(textBoxFontKey1, e)
    End Sub

    Private Sub textBoxFontKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxFontKey2.KeyDown
        CaptureKeyPress(textBoxFontKey2, e)
    End Sub

    Private Sub textBoxLoadKey1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxLoadKey1.KeyDown
        CaptureKeyPress(textBoxLoadKey1, e)
    End Sub

    Private Sub textBoxLoadKey2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBoxLoadKey2.KeyDown
        CaptureKeyPress(textBoxLoadKey2, e)
    End Sub

    Public Function statusCheckBoxOpen() As Boolean
        If cm.GetValueString("openChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxClosed() As Boolean
        If cm.GetValueString("closeChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxClear() As Boolean
        If cm.GetValueString("clearChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxSettings() As Boolean
        If cm.GetValueString("settingsChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxColor() As Boolean
        If cm.GetValueString("colorKeyChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxFont() As Boolean
        If cm.GetValueString("fontKeyChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Public Function statusCheckBoxDefault() As Boolean
        If cm.GetValueString("defaultKeyChecked") = "true" Then
            Return True
        End If

        Return False
    End Function

    Private Sub c_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxOpen.CheckedChanged
        If checkBoxOpen.Checked Then
            cm.SetStringParam("openChecked", "true")
        End If

        If Not checkBoxOpen.Checked Then
            cm.SetStringParam("openChecked", "false")
        End If
    End Sub

    Private Sub checkBoxClose_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxClose.CheckedChanged
        If checkBoxClose.Checked Then
            cm.SetStringParam("closeChecked", "true")
        End If

        If Not checkBoxClose.Checked Then
            cm.SetStringParam("closeChecked", "false")
        End If
    End Sub

    Private Sub checkBoxClear_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxClear.CheckedChanged
        If checkBoxClear.Checked Then
            cm.SetStringParam("clearChecked", "true")
        End If

        If Not checkBoxClear.Checked Then
            cm.SetStringParam("clearChecked", "false")
        End If
    End Sub

    Private Sub checkBoxSettings_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxSettings.CheckedChanged
        If checkBoxSettings.Checked Then
            cm.SetStringParam("settingsChecked", "true")
        End If

        If Not checkBoxSettings.Checked Then
            cm.SetStringParam("settingsChecked", "false")
        End If
    End Sub

    Private Sub checkBoxColor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxColor.CheckedChanged
        If checkBoxColor.Checked Then
            cm.SetStringParam("colorKeyChecked", "true")
        End If

        If Not checkBoxColor.Checked Then
            cm.SetStringParam("colorKeyChecked", "false")
        End If
    End Sub

    Private Sub checkBoxFont_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxFont.CheckedChanged
        If checkBoxFont.Checked Then
            cm.SetStringParam("fontKeyChecked", "true")
        End If

        If Not checkBoxFont.Checked Then
            cm.SetStringParam("fontKeyChecked", "false")
        End If
    End Sub

    Private Sub checkBoxDefault_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxDefault.CheckedChanged
        If checkBoxDefault.Checked Then
            cm.SetStringParam("defaultKeyChecked", "true")
        End If

        If Not checkBoxDefault.Checked Then
            cm.SetStringParam("defaultKeyChecked", "false")
        End If
    End Sub

End Class