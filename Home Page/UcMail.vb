Public Class UcMail

    Public Event UC_BtSignInAccount()
    Public Event UC_BtComposeMail()
    Public Event UC_BtnMails()

    Public Sub BtSignInAccount_Click(sender As Object, e As EventArgs) Handles BtSignInAccount.Click
        RaiseEvent UC_BtSignInAccount()
    End Sub

    Public Sub BtComposeMail_Click(sender As Object, e As EventArgs) Handles BtComposeMail.Click
        RaiseEvent UC_BtComposeMail()
    End Sub

    Public Sub BtnMails_Click(sender As Object, e As EventArgs) Handles BtnMails.Click
        RaiseEvent UC_BtnMails()
    End Sub

    Private Sub UcMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtSignInAccount.BackColor = My.Settings.PanelColor
        BtComposeMail.BackColor = My.Settings.PanelColor
        BtnMails.BackColor = My.Settings.PanelColor
    End Sub
End Class
