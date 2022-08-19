Imports Email.Net.Common
Imports Email.Net.Common.Collections
Imports Email.Net.Imap.Collections
Imports Email.Net.Imap.Sequences
Imports Email.Net.Pop3


Public Class FrmOtherMail
    Private noopLogger, logger As SimpleLogger

    Public Sub New()
        InitializeComponent()
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel2.BackColor = My.Settings.FormBackgroundColor
        ConnBtn.BackColor = My.Settings.PanelColor
        DisconnBtn.BackColor = My.Settings.PanelColor
        btnUpdateMess.BackColor = My.Settings.PanelColor
        btnDelMess.BackColor = My.Settings.PanelColor
        Panel8.BackColor = My.Settings.PanelColor
        Panel5.BackColor = My.Settings.FormBackgroundColor

        'Set loggers output to ListBoxes
        logger = New SimpleLogger(lbLog.Items)
        noopLogger = New SimpleLogger(lbNoopLog.Items)
        'Set current status of ImapClientExample
        IMAPStatus.statUpd = New StatusUpdater(AddressOf Me.SetStatus)
        IMAPStatus.activateFunc = New StatusUpdater(AddressOf Me.ActivateButtons)
        IMAPStatus.deactivateFunc = New StatusUpdater(AddressOf Me.DeactivateButtons)
        IMAPStatus.ConnStatus1 = ConnectionStatus.Disconnected
    End Sub

    Protected Overrides Sub Finalize()
        If IMAPStatus.ConnStatus1 = ConnectionStatus.Connected Then
            Pop3Client1.Logout()
        End If
    End Sub

    Public Sub SetStatus()
        label16.Text = IMAPStatus.ConnStatus1.ToString()
    End Sub

    Public Sub ActivateButtons()
        logger.addLogMessage("Connection successfull!")
        'btnDeleteFolder.Enabled = True
        'btnDelMess.Enabled = True
        'btnNewFolder.Enabled = True
        'btnSelFolder.Enabled = True
        'comboBox1.Enabled = True
        'btnRenameFolder.Enabled = True
        '' btnSearch.Enabled = True
        'comboBox1.SelectedIndex = 0
        'ConnBtn.Enabled = False
        'DisconnBtn.Enabled = True
        ''Show mailbox tree
        'getAllFolders()
    End Sub

    Public Sub DeactivateButtons()
        logger.addLogMessage("Disonnection successfull!")
        'btnDeleteFolder.Enabled = False
        'btnDelMess.Enabled = False
        'btnNewFolder.Enabled = False
        'btnSelFolder.Enabled = False
        'comboBox1.Enabled = False
        'btnRenameFolder.Enabled = False
        '' btnSearch.Enabled = False
        'ConnBtn.Enabled = True
        'DisconnBtn.Enabled = False
        'trFolders.Nodes.Clear()
        'dsMess.Tables(0).Rows.Clear()
        'lbNoopLog.Items.Clear()
    End Sub

    Private Sub ConnBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ConnBtn.Click
        If FrmSignInAccount.tbhostname.Text = "Other" Then
            Pop3Client1.Host = FrmSignInAccount.selAccount.InServerOther
        Else
            Pop3Client1.Host = FrmSignInAccount.selAccount.InServer
        End If

        Pop3Client1.Port = CUShort(FrmSignInAccount.selAccount.POPPort)
        Pop3Client1.Password = FrmSignInAccount.selAccount.Password
        Pop3Client1.Username = FrmSignInAccount.selAccount.LoginName + FrmSignInAccount.selAccount.LoginHost
        Pop3Client1.SSLInteractionType = FrmSignInAccount.selAccount.SecType

        Try
            Dim response As Pop3Response = Pop3Client1.Login()
            logger.addLogMessage("Connection.")

            If response.Type = EPop3ResponseType.OK Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.Connected
            ElseIf response.Type = EPop3ResponseType.ERR Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.FailedConnect
                MessageBox.Show("Connection failed.  Message=" + response.Message & ".", "Connection failed", MessageBoxButtons.OK)
            End If

            'Get messages for the server
            Dim messages As Rfc822MessageCollection = Pop3Client1.GetAllMessages()
            FillMessageSList(messages)

            fillTableWithMessages(dsMess.Tables(0), messages)

        Catch ex As Exception
            MessageBox.Show("Exception during login. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during login", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub fillTableWithMessages(ByVal dt As DataTable, messages As Rfc822MessageCollection)
        dt.Rows.Clear()
        'showMessCount()
        For Each message As Email.Net.Common.Rfc822Message In messages
            Dim row As DataRow = dt.NewRow()
            row("Subject") = message.Header.Subject

            If message.Header.From IsNot Nothing Then
                row("From") = message.Header.From.DisplayName & " (" + message.Header.From.Address & ")"
            Else
                row("From") = "message.Header.From is null!"
            End If

            If message.Attachments.Count > 0 Then
                row("Attachments") = "+"
            Else
                row("Attachments") = "-"
            End If

            ' row("UID") = message.UID
            row("Date") = message.Header.Date.ToShortDateString() & " " + message.Header.Date.ToShortTimeString()

            ' Dim mfc As MessageFlagCollection = message.Flags

            'If mfc.Contains(New MessageFlag(EFlag.Seen)) Then
            '    row("Seen") = 1
            'Else
            '    row("Seen") = 0
            'End If

            'row("Del") = message.IsDeleted
            'row("Flags") = message.Flags
            dt.Rows.Add(row)
        Next
    End Sub

    Private Sub FillMessageSList(messages As Rfc822MessageCollection)
        'Clear messages list
        lvMessageBrowser.Items.Clear()

        'Adding messages to list
        For Each message As Rfc822Message In messages
            'Get message's subject and date
            Dim subject As String
            If (message.Subject IsNot Nothing) Then
                subject = message.Subject
            Else
                subject = "n/a"
            End If

            Dim [date] As String = message.[Date].ToString("yyyy-MM-dd HH:mm:ss")
            'Creating new ListView item
            Dim item As New ListViewItem(message.From.ToString())
            'Filling item
            item.Tag = message
            item.SubItems.Add(subject)
            item.SubItems.Add([date])
            'Adding item
            lvMessageBrowser.Items.Add(item)
        Next
    End Sub



    'Private Sub showMessCount()
    '    Try
    '        'Dim count As UInteger = iClient.GetMessageCount(folder)
    '        logger.addLogMessage("Calling GetMessageCount. Got " & dgvMessages.Rows.Count)
    '        lblMess.Text = "Messages: " & dgvMessages.Rows.Count
    '    Catch ex As Exception
    '        MessageBox.Show("Exception during GetMessageCount. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during GetAllMessages", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    '    End Try
    'End Sub

    'Private Sub dgvMessages_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvMessages.RowsAdded
    '    'Dim row As DataGridViewRow = dgvMessages.Rows(e.RowIndex)

    '    'If (CInt(dsMess.Tables(0).Rows(e.RowIndex)("Seen"))) = 0 Then
    '    '    dgvMessages.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Lato", CSng(9), FontStyle.Bold)
    '    '    CType(row.Cells("Seen"), DataGridViewImageCell).Value = My.Resources.seen1
    '    'Else
    '    '    CType(row.Cells("Seen"), DataGridViewImageCell).Value = My.Resources.seen2
    '    'End If

    '    'If (CBool(dsMess.Tables(0).Rows(e.RowIndex)("Del"))) Then
    '    '    dgvMessages.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkMagenta
    '    '    CType(row.Cells("Del"), DataGridViewImageCell).Value = My.Resources.kor1
    '    'Else
    '    '    CType(row.Cells("Del"), DataGridViewImageCell).Value = My.Resources.kor2
    '    'End If
    '    'row.Cells("Sel").Value = False
    'End Sub

    Private Sub dgvMessages_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvMessages.CellDoubleClick
        'Dim tn As TreeNode = trFolders.SelectedNode
        'If tn Is Nothing Then Return
        '  Dim row As DataRow = dsMess.Tables(0).Rows(e.RowIndex)
        'getMessage(CUInt(row("UID")), CType(tn.Tag, Mailbox))
        Dim selectedRowIndex As Integer
        Dim row As DataGridViewRow
        row = dgvMessages.Rows(selectedRowIndex)

        'Dim row As DataRow = dsMess.Tables(0).Rows(e.RowIndex)


        'Showing received message
        Dim viewer As New ShowMessagePOP(DirectCast(dgvMessages.Rows(selectedRowIndex).Tag, Rfc822Message))
        'Dim viewer As New ShowMessagePOP(DirectCast(dgvMessages.SelectedRows(CUInt(row("UID"))).Tag, Rfc822Message))
        viewer.ShowDialog()
    End Sub

    Private Sub DisconnBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisconnBtn.Click
        Try
            Dim response As Pop3Response = Pop3Client1.Logout()
            logger.addLogMessage("Disconnection.")

            If response.Type = EPop3ResponseType.OK Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.Disconnected
                Pop3Client1.Logout()
            ElseIf response.Type = EPop3ResponseType.ERR Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.FailedConnect
                MessageBox.Show("Connection failed.  Message=" + response.Message & ".", "Connection failed", MessageBoxButtons.OK)
                '  Pop3Client1.Logout()
            End If

        Catch ex As Exception
            MessageBox.Show("Exception during logout. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during logout", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub lvMessageBrowser_DoubleClick(sender As Object, e As EventArgs) Handles lvMessageBrowser.DoubleClick
        If lvMessageBrowser.SelectedItems.Count > 0 Then
            'Showing received message
            Dim viewer As New ShowMessagePOP(DirectCast(lvMessageBrowser.SelectedItems(0).Tag, Rfc822Message))
            viewer.ShowDialog()
        End If
    End Sub

End Class