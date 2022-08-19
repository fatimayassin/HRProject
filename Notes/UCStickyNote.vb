Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class UCStickyNote

    Private di As DateInfo = New DateInfo()
    Private f As FileOpenClose = New FileOpenClose()
    Private cm As ConfManager = New ConfManager()
    Private s As Settings = New Settings()
    Private ht As HotKeysForm = New HotKeysForm()
    Private onlyHideOnClose As Boolean = True

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadDefaultSettingOnStart()
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
        textBox1.Font = CType(converter.ConvertFromString(cm.GetValueString("fontStyle").ToString()), Font)
        Dim converterColor As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
        Dim setColor As Color = CType(converterColor.ConvertFromString(cm.GetValueString("colorType").ToString()), Color)
        Me.BackColor = setColor
        textBox1.BackColor = setColor
        checkBox1.BackColor = setColor
        checkBoxOnTop.BackColor = setColor
        checkBoxOpen.BackColor = setColor
    End Sub

    Private Sub UCStickyNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerDate.Start()
        LoadDefaultSettingOnStart()
    End Sub

    Private Sub timerDate_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerDate.Tick
        timerDate.Enabled = True
        labelCurrDateTime.Text = di.GetCurrentDateTime()
    End Sub

    Private Sub OpenNew()
        If Application.OpenForms.Cast(Of Form)().Count() < Convert.ToInt32(cm.GetValue("maxOpenNote")) Then

            If Not checkBoxOpen.Checked Then
                Dim fm As Settings = New Settings()
                fm.Width = 300
                fm.Show()
            End If

            If checkBoxOpen.Checked Then

                If Me.textBox1.Text.Length = 0 Then

                    If openFileDialog1.ShowDialog() = DialogResult.OK Then
                        openFileDialog1.Title = "Open Note"
                        f.OpenFile(openFileDialog1.FileName.ToString(), Me.textBox1)
                    End If
                Else

                    If MessageBox.Show("Do you want to save current Note?", "Saving Note...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                            saveFileDialog1.Title = "Save note"
                            f.SaveFile(saveFileDialog1.FileName.ToString(), textBox1)
                        End If
                    Else

                        If openFileDialog1.ShowDialog() = DialogResult.OK Then
                            openFileDialog1.Title = "Open Note"
                            f.OpenFile(openFileDialog1.FileName.ToString(), Me.textBox1)
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("Maximum q-ty of Notes - " & Convert.ToInt32(cm.GetValue("maxOpenNote")) & " If you want more - please change settings", "Information")
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        If Not checkBox1.Checked Then
            Me.Width = 355
            checkBox1.Text = "hide Panel"
        End If

        If checkBox1.Checked Then
            Me.Width = 300
            checkBox1.Text = "show Panel"
        End If
    End Sub

    Private Sub ExitProg()
        notifyIconMain.Visible = False
        onlyHideOnClose = False
        'Me.Close()
    End Sub

    Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textBox1.KeyDown
        Dim keyValueTemp As String()
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Keys))

        If ht.statusCheckBoxOpen() Then
            keyValueTemp = cm.GetValueString("open").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then
                OpenNew()
            End If
        End If

        If ht.statusCheckBoxClosed() Then
            keyValueTemp = cm.GetValueString("close").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then

                If MessageBox.Show("Do you realy want to close programm?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ExitProg()
                End If
            End If
        End If

        If ht.statusCheckBoxClear() Then
            keyValueTemp = cm.GetValueString("clear").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then
                textBox1.Clear()
            End If
        End If

        If ht.statusCheckBoxSettings() Then
            keyValueTemp = cm.GetValueString("settings").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then

                If s.Visible = False Then
                    s.Show()
                Else
                    s.Hide()
                End If
            End If
        End If

        If ht.statusCheckBoxColor() Then
            keyValueTemp = cm.GetValueString("colorKey").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then
                ColorDialogSet()
            End If
        End If

        If ht.statusCheckBoxFont() Then
            keyValueTemp = cm.GetValueString("fontKey").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then
                FontDialogSet(textBox1, fontDialog1)
            End If
        End If

        If ht.statusCheckBoxDefault() Then
            keyValueTemp = cm.GetValueString("defaultKey").ToString().Split(","c)
            Dim key As Keys = CType(converter.ConvertFromString(keyValueTemp(0)), Keys)
            Dim key2 As Keys = CType(converter.ConvertFromString(keyValueTemp(1)), Keys)

            If e.Modifiers = key AndAlso e.KeyCode = key2 Then

                Try
                    LoadDefaultSettingOnStart()
                    s.LoadDefaultHotKeys()
                    MessageBox.Show("Default setting loaded...", "Load default")
                Catch err As Exception
                    MessageBox.Show(err.Message, "Error")
                End Try
            End If
        End If
    End Sub

    Public Sub ColorDialogSet()
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            Dim color As Color = colorDialog1.Color
            Me.BackColor = color
            textBox1.BackColor = color
            checkBox1.BackColor = color
            checkBoxOnTop.BackColor = color
            checkBoxOpen.BackColor = color
            Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
            Dim colorString As String = converter.ConvertToString(color)
            cm.SetStringParam("colorType", colorString)
        End If
    End Sub

    Public Sub FontDialogSet(ByVal textBox As TextBox, ByVal fontDialog As FontDialog)
        If fontDialog.ShowDialog() = DialogResult.OK Then
            Dim font As Font = fontDialog.Font
            textBox.Font = font
            Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
            Dim fontString As String = converter.ConvertToString(font)
            cm.SetStringParam("fontStyle", fontString)
        End If
    End Sub

    'Private Sub checkBoxOnTop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If checkBoxOnTop.Checked Then
    '        Me.TopMost = True
    '    End If

    '    If Not checkBoxOnTop.Checked Then
    '        Me.TopMost = False
    '    End If
    'End Sub

    Private Sub buttonAddNewNote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAddNewNote.Click
        OpenNew()
    End Sub

    Private Sub buttonClearNote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClearNote.Click
        textBox1.Clear()
    End Sub

    Private Sub buttonSaveNote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSaveNote.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            saveFileDialog1.Title = "Save note"
            f.SaveFile(saveFileDialog1.FileName.ToString(), textBox1)
        End If
    End Sub

    Private Sub buttonSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSettings.Click
        If s.Visible = False Then
            s.Show()
        Else
            s.Hide()
        End If
    End Sub

    'Private Sub contextMenuStripStickMain_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
    '    If Me.WindowState = FormWindowState.Normal Then
    '        toolStripMenuItemShow.Enabled = False
    '        toolStripMenuItemHide.Enabled = True
    '    End If

    '    If Me.WindowState = FormWindowState.Minimized Then
    '        toolStripMenuItemShow.Enabled = True
    '        toolStripMenuItemHide.Enabled = False
    '    End If
    'End Sub

    'Private Sub toolStripMenuItemHide_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    'Private Sub toolStripMenuItemShow_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.WindowState = FormWindowState.Normal
    'End Sub

    Private Sub toolStripMenuItemExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemExit.Click
        ExitProg()
    End Sub

    Private Sub toolStripMenuItemFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemFont.Click
        FontDialogSet(textBox1, fontDialog1)
    End Sub

    Private Sub toolStripMenuItemColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemColor.Click
        ColorDialogSet()
    End Sub

    Private Sub toolStripMenuItemHotKey_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemHotKey.Click
        If ht.Visible = False Then
            ht.Show()
        Else
            ht.Hide()
        End If
    End Sub

End Class
