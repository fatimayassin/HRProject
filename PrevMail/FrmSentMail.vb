
Imports System.IO
Imports System.Linq
Imports Email.Net.Common
Imports Email.Net.Common.Collections
Imports Email.Net.Common.Configurations
Imports Email.Net.Pop3


Public Class FrmSentMail

    Private ID As Integer

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles BtRefresh.Click
        If ToolStatus.Text Is "Connected" Then
            RefreshForm()
        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If
    End Sub

    Private Sub RefreshForm()

        If Not FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text + FrmMailSignIn.tbPassword.Text = "" Then

            'Create POP3 client with parameters needed
            'URL of host to connect to

            If FrmMailSignIn.tbhostname.Text = "Other" Then
                Pop3Client1.Host = FrmMailSignIn.TextOtherHost.Text
            Else
                Pop3Client1.Host = FrmMailSignIn.tbhostname.Text
            End If

            'TCP port for connection
            'Pop3Client1.Port = CUShort(Math.Truncate(FrmMailSignIn.nPort.Value))
            Pop3Client1.Port = CUShort(FrmMailSignIn.ComboPop3Port.Text)
            'Username to login to the POP3 server
            Pop3Client1.Username = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text
            'Password to login to the POP3 server
            Pop3Client1.Password = FrmMailSignIn.tbPassword.Text
            'Interaction type for connection
            Pop3Client1.SSLInteractionType = CType(FrmMailSignIn.cbInteractionType.SelectedIndex, EInteractionType)
            'Authentification type for authentification
            Pop3Client1.AuthenticationType = CType(FrmMailSignIn.cbAutentificationType.SelectedIndex, EAuthenticationType)
            If FrmMailSignIn.tbhostname.Text = "Other" Then
                Pop3Client1.SSLInteractionType = EInteractionType.StartTLS
            End If
            Try
                'Login to the server
                Dim response As Pop3Response = Pop3Client1.Login()

                If response.Type = EPop3ResponseType.OK Then
                    ToolStatus.Text = "Connected"
                Else
                    MessageBox.Show("Error", [String].Format("Connection error:" & vbLf & " {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    ToolStatus.Text = "Connection error"
                End If

                Me.FillMessageSList()

                Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                    ToolMailCountNbr.Text = (From ax In aMainor.TblSentMessages Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).Count
                End Using

                MessageBox.Show("Sent Has Been Refreshed")

            Catch
                MsgBox("Error , Incorrect User Details", MsgBoxStyle.Critical, "Error While Logining in")
                ToolStatus.Text = "Error: Please Check Your User Information"
            End Try

            Try
                'Logout from the server
                Pop3Client1.Logout()

            Catch
            End Try

        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If
    End Sub

    Public Sub FillMessageSList()
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            TblSentMessagesBindingSource.DataSource = (From ax In aMainor.TblSentMessages Order By ax.MailDate Descending Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList
        End Using
    End Sub

    Private Sub FrmSentMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel4.BackColor = My.Settings.PanelColor
        Me.BackColor = My.Settings.FormBackgroundColor
        ssMain.BackColor = My.Settings.PanelColor

        If ToolStatus.Text Is "Connected" Then
            FillMessageSList()
        Else
            MsgBox("Error , Please Log In First", MsgBoxStyle.Critical, "You are Not Logged In")
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'Delete Mail Msg
        If e.ColumnIndex = 4 Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New DataClassesEmailDataContext(cnxEmail)
                    Dim Id As Integer = TblSentMessagesBindingSource.Current.SentMessageID


                    Dim result = (From aX In aMainor.TblSentMessages Where aX.SentMessageID = Id).ToList(0)


                    If result.TblSentMailAttachments.Count > 0 Then
                        Dim r = (From ax In aMainor.TblSentMailAttachments Where ax.SentMessageID = Id).ToList
                        aMainor.TblSentMailAttachments.DeleteAllOnSubmit(r)
                        aMainor.SubmitChanges()

                    End If
                    TblSentMessagesBindingSource.RemoveCurrent()
                    aMainor.TblSentMessages.DeleteOnSubmit(result)
                    aMainor.SubmitChanges()
                    ToolMailCountNbr.Text = (From ax In aMainor.TblSentMessages Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).Count
                    MessageBox.Show("Mail is Deleted!")

                End Using
            End If
        End If
    End Sub

    Private Sub BtDateUp_Click(sender As Object, e As EventArgs) Handles BtDateUp.Click
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            TblSentMessagesBindingSource.DataSource = (From ax In aMainor.TblSentMessages Order By ax.MailDate Descending Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList
        End Using
    End Sub

    Private Sub BtDateDown_Click(sender As Object, e As EventArgs) Handles BtDateDown.Click
        Using aMainor As New DataClassesEmailDataContext(cnxEmail)
            TblSentMessagesBindingSource.DataSource = (From ax In aMainor.TblSentMessages Order By ax.MailDate Where ax.EmailUsername = FrmMailSignIn.tbuser.Text + FrmMailSignIn.tbLogin.Text).ToList
        End Using
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        If TblSentMessagesBindingSource.Count > 0 Then
            ID = TblSentMessagesBindingSource.Current.SentMessageID
            Dim viewer As New FrmSentMailMessageViewer()
            viewer.ID = ID
            viewer.ShowDialog()
        End If
    End Sub
End Class