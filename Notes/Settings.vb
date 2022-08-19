Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class Settings
    Private cm As ConfManager = New ConfManager()
    Private ht As HotKeysForm = New HotKeysForm()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Public Sub LoadDefaultHotKeys()
        cm.SetStringParam("maxOpenNote", 7)
        cm.SetStringParam("open", "Control,N")
        cm.SetStringParam("close", "Control,Q")
        cm.SetStringParam("clear", "Control,D")
        cm.SetStringParam("settings", "Control,S")
        cm.SetStringParam("fontKey", "Control,T")
        cm.SetStringParam("colorKey", "Control,K")
        cm.SetStringParam("defaultKey", "Control,P")
    End Sub

    Private Sub buttonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSave.Click
        Try
            cm.SetStringParam("maxOpenNote", Convert.ToInt32(numericUpDownNotesQ.Value))
            MessageBox.Show("All setting stored successfully", "Saving settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch err As Exception
            MessageBox.Show(err.Message, "Error")
        End Try
    End Sub

    Private Sub buttonDefault_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDefault.Click
        Try

            If MessageBox.Show("Do you realy want to set default setting", "Set default...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                LoadDefaultHotKeys()
                MessageBox.Show("All setting reseted", "Reset settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch err As Exception
            MessageBox.Show(err.Message, "Error")
        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If fontDialog1.ShowDialog() = DialogResult.OK Then
            Dim font As Font = fontDialog1.Font
            Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
            Dim fontString As String = converter.ConvertToString(font)
            cm.SetStringParam("fontStyle", fontString)
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            Dim color As Color = colorDialog1.Color
            Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
            Dim colorString As String = converter.ConvertToString(color)
            cm.SetStringParam("colorType", colorString)
            MessageBox.Show("all setting will be applied after restarting...")
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        If ht.Visible = False Then
            ht.Show()
        Else
            ht.Hide()
        End If
    End Sub
End Class