Imports System.IO

Public Class FrmAddAttachment
    Public Type As String
    Public saved As Boolean = False
    Public current As New TblAttachment


    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If TypeComboBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Type = TypeComboBox.Text
            saved = True
            Me.Close()
        End If
    End Sub


    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click

        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub FrmAddAttachment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
    End Sub
End Class