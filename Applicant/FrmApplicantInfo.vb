Public Class FrmApplicantInfo
    Public id As Integer = 0
    Public StatusId As Integer = 0
    Public ApplicantList As New List(Of Integer)

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Private Sub FrmApplicantInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Panel1.Controls.Clear()
        Dim X As New UCApplicantInfo
        X.Dock = DockStyle.Fill
        X.StatusId = StatusId
        X.DontShowExitButton = True
        If ApplicantList.Count > 0 Then
            X.FilteredApplicantList = True
            X.ApplicantsList = ApplicantList
        End If
        X.Id = id
        Panel1.Controls.Add(X)
    End Sub

End Class