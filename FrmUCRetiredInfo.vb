Public Class FrmUCRetiredInfo
    Public StatusId As Integer = 0
    Dim counter As Integer = 1
    Dim counter2 As Integer = 1
    Dim counter3 As Integer = 1
    Dim counter4 As Integer = 1

    Private Sub FrmUCRetiredInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim uc As New UCApplicantInfo()
        'uc.StatusId = StatusId
        'Panel1.Controls.Add(uc)

        Panel1.Controls.Clear()
        counter2 = 1
        counter3 = 1
        counter4 += 1
        counter = 1
        If counter4 Mod 2 = 0 Then
            Dim uc As New UCApplicantInfo
            uc.StatusId = StatusId
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Public Sub refreshdata()
        Panel1.Controls.Clear()
        'counter2 = 1
        'counter3 = 1
        'counter4 += 1
        'counter = 1
        If counter4 Mod 2 = 0 Then
            Dim uc As New UCApplicantInfo
            uc.StatusId = StatusId
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

End Class