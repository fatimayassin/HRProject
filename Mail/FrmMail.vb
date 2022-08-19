Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Email.Net.Common.Configurations
Imports Email.Net.Imap
Imports Email.Net.Imap.Collections
Imports Email.Net.Imap.Responses
Imports Email.Net.Imap.Sequences
Imports Message = Email.Net.Imap.ImapMessage


Public Class FrmMail
    Private selMailbox As Mailbox = Nothing
    Private noopLogger, logger As SimpleLogger
    Private subsFolders As List(Of Mailbox)

    Public Sub New()
        InitializeComponent()
        Me.BackColor = My.Settings.FormBackgroundColor
        splitContainer1.BackColor = My.Settings.FormBackgroundColor
        ConnBtn.BackColor = My.Settings.PanelColor
        btnSelFolder.BackColor = My.Settings.PanelColor
        btnNewFolder.BackColor = My.Settings.PanelColor
        btnRenameFolder.BackColor = My.Settings.PanelColor
        btnDeleteFolder.BackColor = My.Settings.PanelColor
        DisconnBtn.BackColor = My.Settings.PanelColor
        Panel8.BackColor = My.Settings.PanelColor
        btnUpdateMess.BackColor = My.Settings.PanelColor
        btnDelMess.BackColor = My.Settings.PanelColor


        subsFolders = New List(Of Mailbox)()
        'Set loggers output to ListBoxes
        logger = New SimpleLogger(lbLog.Items)
        noopLogger = New SimpleLogger(lbNoopLog.Items)
        'Set current status of ImapClientExample
        IMAPStatus.statUpd = New StatusUpdater(AddressOf Me.SetStatus)
        IMAPStatus.activateFunc = New StatusUpdater(AddressOf Me.ActivateButtons)
        IMAPStatus.deactivateFunc = New StatusUpdater(AddressOf Me.DeactivateButtons)
        IMAPStatus.ConnStatus1 = ConnectionStatus.Disconnected

        iClient = New ImapClient()
        setToolTips()
    End Sub

    Protected Overrides Sub Finalize()
        If IMAPStatus.ConnStatus1 = ConnectionStatus.Connected Then
            iClient.Logout()
        End If
    End Sub

    Private Sub setToolTips()
        toolTip.SetToolTip(Me.ConnBtn, "Connect to server")
        toolTip.SetToolTip(Me.DisconnBtn, "Disonnect from server")
        toolTip.SetToolTip(Me.btnSelFolder, "Select mailbox")
        toolTip.SetToolTip(Me.btnNewFolder, "Create new child mailbox")
        toolTip.SetToolTip(Me.btnRenameFolder, "Rename current mailbox")
        toolTip.SetToolTip(Me.btnDeleteFolder, "Delete selected mailbox")
        toolTip.SetToolTip(Me.btnUpdateMess, "Update messages for selected mailbox")
        toolTip.SetToolTip(Me.btnDelMess, "Delete messages marked as ""deleted""")
        toolTip.SetToolTip(Me.comboBox1, "Choose action with checked messages")
        ' toolTip.SetToolTip(Me.NewBtn, "Save credentials as new account")
        ' toolTip.SetToolTip(Me.SetBtn, "Update credentials for current account")
        'toolTip.SetToolTip(Me.btnGetSubs, "Get subscription tree")
        'toolTip.SetToolTip(Me.btnAddSubs, "Add selected mailbox to subscriptions")
        'toolTip.SetToolTip(Me.btnDelSubs, "Remove selected mailbox from subscriptions")
    End Sub

    'Private Sub cbAuth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If cbAuth.Checked Then
    '        iClient.Authentificated += New Email.Net.Imap.Events.ClientEventHandler(AddressOf iClient_Authentificated)
    '    Else
    '        iClient.Authentificated += New Email.Net.Imap.Events.ClientEventHandler(AddressOf iClient_Authentificated)
    '    End If
    'End Sub

    Private Sub iClient_Authentificated(ByVal sender As ImapClient)
        logger.addLogMessage("Authentificated!")
    End Sub

    'Private Sub cbAllMessReceived_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If cbAllMessReceived.Checked Then
    '        iClient.AllMessagesReceived += New Email.Net.Imap.Events.ClientEventHandler(AddressOf iClient_AllMessagesReceived)
    '    Else
    '        iClient.AllMessagesReceived -= New Email.Net.Imap.Events.ClientEventHandler(AddressOf iClient_AllMessagesReceived)
    '    End If
    'End Sub

    Private Sub iClient_AllMessagesReceived(ByVal sender As ImapClient)
        logger.addLogMessage("All Messages Received!")
    End Sub

    'Private Sub cbMessReceived_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If cbMessReceived.Checked Then
    '        iClient.MessageReceived += New Email.Net.Imap.Events.MessageReceivedEventHandler(AddressOf iClient_MessageRecived)
    '    Else
    '        iClient.MessageReceived -= New Email.Net.Imap.Events.MessageReceivedEventHandler(AddressOf iClient_MessageRecived)
    '    End If
    'End Sub

    Private Sub iClient_MessageRecived(ByVal sender As ImapClient, ByVal message As ImapMessage)
        logger.addLogMessage("Messages from " & message.From.Address & """ with subject""" + message.Subject & """ received!")
    End Sub

    'Private Sub cbServerRespRec_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If cbServerRespRec.Checked Then
    '        iClient.ServerResponseReceived += New Email.Net.Imap.Events.ServerResponseReceived(AddressOf iClient_ServerResponseReceived)
    '    Else
    '        iClient.ServerResponseReceived -= New Email.Net.Imap.Events.ServerResponseReceived(AddressOf iClient_ServerResponseReceived)
    '    End If
    'End Sub

    Private Sub iClient_ServerResponseReceived(ByVal sender As Object, ByVal response As IMAP4Response)
        logger.addLogMessage("Server response """ & response.Response & """ received! ")
    End Sub

    Public Sub SetStatus()
        label16.Text = IMAPStatus.ConnStatus1.ToString()
    End Sub

    Public Sub ActivateButtons()
        logger.addLogMessage("Connection successfull!")
        btnDeleteFolder.Enabled = True
        btnDelMess.Enabled = True
        btnNewFolder.Enabled = True
        btnSelFolder.Enabled = True
        comboBox1.Enabled = True
        btnRenameFolder.Enabled = True
        ' btnSearch.Enabled = True
        comboBox1.SelectedIndex = 0
        ConnBtn.Enabled = False
        DisconnBtn.Enabled = True
        'Show mailbox tree
        getAllFolders()
    End Sub

    Public Sub DeactivateButtons()
        logger.addLogMessage("Disonnection successfull!")
        btnDeleteFolder.Enabled = False
        btnDelMess.Enabled = False
        btnNewFolder.Enabled = False
        btnSelFolder.Enabled = False
        comboBox1.Enabled = False
        btnRenameFolder.Enabled = False
        ' btnSearch.Enabled = False
        ConnBtn.Enabled = True
        DisconnBtn.Enabled = False
        trFolders.Nodes.Clear()
        dsMess.Tables(0).Rows.Clear()
        lbNoopLog.Items.Clear()
    End Sub

    Private Sub ConnBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ConnBtn.Click

        If FrmSignInAccount.tbhostname.Text = "Other" Then
            iClient.Host = FrmSignInAccount.selAccount.InServerOther
        Else
            iClient.Host = FrmSignInAccount.selAccount.InServer
        End If

        iClient.Port = CUShort(FrmSignInAccount.selAccount.IMAPPort)
        iClient.Password = FrmSignInAccount.selAccount.Password
        iClient.Username = FrmSignInAccount.selAccount.LoginName + FrmSignInAccount.selAccount.LoginHost
        iClient.SSLInteractionType = FrmSignInAccount.selAccount.SecType

        Try
            Dim response As CompletionResponse = iClient.Login()
            logger.addLogMessage("Connection.", response)

            If response.CompletionResult = ECompletionResponseType.OK Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.Connected
                'label16.Text = "Connected"
            ElseIf response.CompletionResult = ECompletionResponseType.NO Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.FailedConnect
                MessageBox.Show("Connection failed. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK)
                ' label16.Text = "Disonnected"
            ElseIf response.CompletionResult = ECompletionResponseType.BAD Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.BadResponse
                MessageBox.Show("Connection bad response. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Connection bad response", MessageBoxButtons.OK)
                ' label16.Text = "Disonnected"
            End If

        Catch ex As Exception
            MessageBox.Show("Exception during login. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during login", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub DisconnBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisconnBtn.Click
        Try
            Dim response As CompletionResponse = iClient.Logout()
            logger.addLogMessage("Disconnection.", response)

            If response.CompletionResult = ECompletionResponseType.OK Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.Disconnected
            ElseIf response.CompletionResult = ECompletionResponseType.NO Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.FailedDisconnect
                MessageBox.Show("Logout failed. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Logout failed", MessageBoxButtons.OK)
                iClient.Logout()
            ElseIf response.CompletionResult = ECompletionResponseType.BAD Then
                IMAPStatus.ConnStatus1 = ConnectionStatus.BadResponse
                MessageBox.Show("Logout bad response. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Logout bad response", MessageBoxButtons.OK)
                iClient.Logout()
            End If

        Catch ex As Exception
            MessageBox.Show("Exception during logout. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during logout", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub NoopTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles NoopTimer.Tick
        If IMAPStatus.ConnStatus1 = ConnectionStatus.Connected Then
            Dim resp As CompletionResponse = iClient.Noop()
            noopLogger.addLogMessage(resp)
        End If
    End Sub

    Private Function MailboxesEquals(ByVal mb1 As Mailbox, ByVal mb2 As Mailbox) As Boolean
        Dim mc As MailboxComparer = New MailboxComparer()
        Return mc.IEqualityComparer_Equals(mb1, mb2)
    End Function

    Private Sub getAllFolders()
        logger.addLogMessage("Calling GetMailboxTree")
        Dim mailbox As Mailbox = iClient.GetMailboxTree()
        trFolders.Nodes.Clear()
        Dim nodeName As String = mailbox.DisplayName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.FullName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.Name
        If String.IsNullOrEmpty(nodeName) Then nodeName = "RootNode"
        Dim tn As TreeNode = New TreeNode(nodeName)
        tn.Tag = mailbox
        If MailboxesEquals(mailbox, selMailbox) Then tn.ForeColor = Color.Red
        trFolders.Nodes.Add(tn)
        addFoldersToTree(tn, mailbox.Children)
        tn.ExpandAll()
    End Sub

    Private Sub addFoldersToTree(ByVal rootNode As TreeNode, ByVal folders As MailboxCollection)
        For Each mb As Mailbox In folders
            Dim tn As TreeNode = New TreeNode(mb.DisplayName)
            If MailboxesEquals(mb, selMailbox) Then tn.ForeColor = Color.Red
            tn.Tag = mb
            rootNode.Nodes.Add(tn)
            addFoldersToTree(tn, mb.Children)
        Next
    End Sub

    Private Sub getAllSubsFolders()
        'trSubs.Nodes.Clear()
        'trFolders2.Nodes.Clear()
        subsFolders.Clear()
        logger.addLogMessage("Calling GetSubscribedMailboxTree")
        Dim subsMailbox As Mailbox = iClient.GetSubscribedMailboxTree()
        Dim nodeName As String = subsMailbox.DisplayName
        If String.IsNullOrEmpty(nodeName) Then nodeName = subsMailbox.FullName
        If String.IsNullOrEmpty(nodeName) Then nodeName = subsMailbox.Name
        If String.IsNullOrEmpty(nodeName) Then nodeName = "RootNode"
        Dim tn As TreeNode = New TreeNode(nodeName)
        subsFolders.Add(subsMailbox)
        tn.Tag = subsMailbox
        'trSubs.Nodes.Add(tn)
        'addSubsFoldersToTree(tn, subsMailbox.Children)
        tn.ExpandAll()
        logger.addLogMessage("Calling GetMailboxTree")
        Dim mailbox As Mailbox = iClient.GetMailboxTree()
        nodeName = mailbox.DisplayName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.FullName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.Name
        If String.IsNullOrEmpty(nodeName) Then nodeName = "RootNode"
        Dim tn2 As TreeNode = New TreeNode(nodeName)
        tn2.Tag = mailbox
        ' trFolders2.Nodes.Add(tn2)
        addFoldersToTree(tn2, mailbox.Children, Color.Gray)
        tn2.ExpandAll()
    End Sub

    Private Sub addSubsFoldersToTree(ByVal rootNode As TreeNode, ByVal folders As MailboxCollection)
        For Each mb As Mailbox In folders
            Dim tn As TreeNode = New TreeNode(mb.DisplayName)
            tn.Tag = mb
            rootNode.Nodes.Add(tn)
            subsFolders.Add(mb)
            addSubsFoldersToTree(tn, mb.Children)
        Next
    End Sub

    Private Sub addFoldersToTree(ByVal rootNode As TreeNode, ByVal folders As MailboxCollection, ByVal color As Color)
        For Each mb As Mailbox In folders
            Dim tn As TreeNode = New TreeNode(mb.DisplayName)
            tn.Tag = mb
            rootNode.Nodes.Add(tn)

            For Each box As Mailbox In subsFolders
                If New MailboxComparer().IEqualityComparer_Equals(box, mb) Then tn.ForeColor = color
            Next

            addFoldersToTree(tn, mb.Children, color)
        Next
    End Sub

    Private Sub btnGetSubs_Click(ByVal sender As Object, ByVal e As EventArgs)
        getAllSubsFolders()
    End Sub

    Private Sub btnAddSubs_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' If trFolders2.SelectedNode Is Nothing Then Return
        ' Dim tn As TreeNode = trFolders2.SelectedNode
        ' Dim mb As Mailbox = CType(tn.Tag, Mailbox)
        '  If mb.Parent Is Nothing Then Return

        '  For Each box As Mailbox In subsFolders
        'If New MailboxComparer().Equals(box, mb) Then Return
        ' Next

        '  iClient.Subscribe(mb)
        '  getAllSubsFolders()
    End Sub

    Private Sub btnDelSubs_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' If trSubs.SelectedNode Is Nothing Then Return
        ' Dim tn As TreeNode = trSubs.SelectedNode
        ' Dim mb As Mailbox = CType(tn.Tag, Mailbox)
        ' iClient.Unsubscribe(mb)
        ' getAllSubsFolders()
    End Sub

    Private Sub trFolders_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles trFolders.AfterSelect
        If e.Node Is Nothing Then Return
        If IMAPStatus.ConnStatus1 <> ConnectionStatus.Connected Then Return
        If (CType(e.Node.Tag, Mailbox)).Parent Is Nothing Then Return
        getAllMessages(CType(e.Node.Tag, Mailbox))
        showMessCount(CType(e.Node.Tag, Mailbox))
    End Sub

    Private Sub getAllMessages(ByVal folder As Mailbox)
        fillAllMessagesForFolder(folder)
    End Sub

    Private Sub getAllMessages()
        If IMAPStatus.ConnStatus1 <> ConnectionStatus.Connected Then Return
        If trFolders.SelectedNode Is Nothing Then Return
        Dim folder As Mailbox = CType(trFolders.SelectedNode.Tag, Mailbox)
        If folder.Parent Is Nothing Then Return
        fillAllMessagesForFolder(folder)
    End Sub

    Private Sub fillAllMessagesForFolder(ByVal folder As Mailbox)
        Try
            Dim messages As MessageCollection = iClient.GetAllMessageHeaders(folder)
            logger.addLogMessage("Calling GetAllMessageHeaders. Got " & messages.Count & " messages")
            fillTableWithMessages(dsMess.Tables(0), messages)
        Catch ex As Exception
            MessageBox.Show("Exception during GetAllMessages. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during GetAllMessages", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub fillTableWithMessages(ByVal dt As DataTable, ByVal messages As MessageCollection)
        dt.Rows.Clear()

        For Each message As Message In messages
            Dim row As DataRow = dt.NewRow()
            row("Subject") = message.Header.Subject

            If message.Header.From IsNot Nothing Then
                row("From") = message.Header.From.DisplayName & " (" + message.Header.From.Address & ")"
            Else
                row("From") = "message.Header.From is null!"
            End If

            If message.Attachments.Count > 0 Then
                'row("Attachments") = "A"
                row("Attachments") = "+"
            Else
                ' row("Attachments") = ""
                row("Attachments") = "-"
            End If

            row("UID") = message.UID
            row("Date") = message.Header.Date.ToShortDateString() & " " + message.Header.Date.ToShortTimeString()
            Dim mfc As MessageFlagCollection = message.Flags

            If mfc.Contains(New MessageFlag(EFlag.Seen)) Then
                row("Seen") = 1
            Else
                row("Seen") = 0
            End If

            row("Del") = message.IsDeleted
            row("Flags") = message.Flags
            dt.Rows.Add(row)
        Next
    End Sub

    Private Sub showMessCount(ByVal folder As Mailbox)
        Try
            Dim count As UInteger = iClient.GetMessageCount(folder)
            logger.addLogMessage("Calling GetMessageCount. Got " & count)
            lblMess.Text = "Messages: " & count
        Catch ex As Exception
            MessageBox.Show("Exception during GetMessageCount. Message=" & ex.Message & ". Trace=" & ex.StackTrace & ". Source=" & ex.Source, "Exception during GetAllMessages", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub dgvMessages_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvMessages.RowsAdded
        Dim row As DataGridViewRow = dgvMessages.Rows(e.RowIndex)

        If (CInt(dsMess.Tables(0).Rows(e.RowIndex)("Seen"))) = 0 Then
            dgvMessages.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Lato", CSng(9), FontStyle.Bold)
            CType(row.Cells("Seen"), DataGridViewImageCell).Value = My.Resources.seen1
        Else
            CType(row.Cells("Seen"), DataGridViewImageCell).Value = My.Resources.seen2
        End If

        If (CBool(dsMess.Tables(0).Rows(e.RowIndex)("Del"))) Then
            dgvMessages.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkMagenta
            CType(row.Cells("Del"), DataGridViewImageCell).Value = My.Resources.kor1
        Else
            CType(row.Cells("Del"), DataGridViewImageCell).Value = My.Resources.kor2
        End If
        row.Cells("Sel").Value = False
    End Sub

    Private Sub btnUpdateMess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateMess.Click
        getAllMessages()
    End Sub

    Private Sub dgvMessages_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvMessages.CellDoubleClick
        Dim tn As TreeNode = trFolders.SelectedNode
        If tn Is Nothing Then Return
        Dim row As DataRow = dsMess.Tables(0).Rows(e.RowIndex)
        getMessage(CUInt(row("UID")), CType(tn.Tag, Mailbox))
    End Sub

    Private Sub getMessage(ByVal messUID As UInteger, ByVal folder As Mailbox)
        'logger.addLogMessage("Get full message from folder " + folder.DisplayName + "For uid" + messUID)
        ' *********** !!!!!! Error For WebMail : 'Length cannot be less than zero.  Parameter Name: length !!!! ***********
        Dim message As Message = iClient.GetFullMessage(messUID, folder)
        Dim sm As ShowMessage = New ShowMessage(message)
        sm.Show()
        getAllMessages()
    End Sub

    Private Sub btnNewFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewFolder.Click
        Dim selNode As TreeNode = trFolders.SelectedNode
        If selNode Is Nothing Then Return
        If IMAPStatus.ConnStatus1 <> ConnectionStatus.Connected Then Return
        Dim itb As InputTextBox = New InputTextBox("New Folder Name", "Input new folder name")
        If itb.ShowDialog() <> DialogResult.OK Then Return
        Dim response As CompletionResponse

        If (CType(selNode.Tag, Mailbox)).Parent Is Nothing Then
            response = iClient.CreateMailbox(itb.TextEntered)
        Else
            response = iClient.CreateMailbox(itb.TextEntered, CType(selNode.Tag, Mailbox))
        End If

        logger.addLogMessage("CreateMailbox: ", response)

        If response.CompletionResult <> ECompletionResponseType.OK Then
            MessageBox.Show("Creation failed. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK)
        Else
            getAllFolders()
        End If
    End Sub

    Private Sub btnDeleteFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteFolder.Click
        Dim selNode As TreeNode = trFolders.SelectedNode
        If selNode Is Nothing Then Return
        If IMAPStatus.ConnStatus1 <> ConnectionStatus.Connected Then Return
        Dim response As CompletionResponse = iClient.DeleteMailbox(CType(selNode.Tag, Mailbox))
        logger.addLogMessage("DeleteMailbox: ", response)

        If response.CompletionResult <> ECompletionResponseType.OK Then
            MessageBox.Show("Delete failed. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK)
        Else
            getAllFolders()
        End If
    End Sub

    Private Sub btnRenameFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRenameFolder.Click
        Dim selNode As TreeNode = trFolders.SelectedNode
        If selNode Is Nothing Then Return
        If IMAPStatus.ConnStatus1 <> ConnectionStatus.Connected Then Return
        Dim itb As InputTextBox = New InputTextBox("Rename Folder", "Input new name for folder")
        If itb.ShowDialog() <> DialogResult.OK Then Return
        Dim response As CompletionResponse = iClient.RenameMailbox(CType(selNode.Tag, Mailbox), itb.TextEntered)
        logger.addLogMessage("RenameMailbox: ", response)

        If response.CompletionResult <> ECompletionResponseType.OK Then
            MessageBox.Show("Rename failed. Response=" & response.Response & ". Message=" + response.Message & ". Data=" + response.Data, "Connection failed", MessageBoxButtons.OK)
        Else
            getAllFolders()
        End If
    End Sub

    Private Sub dgvMessages_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvMessages.CellClick
        Dim row As DataRow = dsMess.Tables(0).Rows(e.RowIndex)

        If dgvMessages.Columns(e.ColumnIndex).Name.Equals("Seen") Then
            Dim folder As Mailbox = CType(trFolders.SelectedNode.Tag, Mailbox)
            Dim messUID As UInteger = CUInt(row("UID"))
            Dim n As MessageSequenceNumbers = New MessageSequenceNumbers()
            n.Add(New SequenceNumber(messUID))

            If CInt(row("Seen")) = 0 Then
                logger.addLogMessage("MarkAsSeen message with uid=" & messUID)
                iClient.MarkAsSeen(n, folder)
            Else
                logger.addLogMessage("MarkAsUnseen message with uid=" & messUID)
                iClient.MarkAsUnseen(n, folder)
            End If

            getAllMessages()
        End If

        If dgvMessages.Columns(e.ColumnIndex).Name.Equals("Del") Then
            Dim folder As Mailbox = CType(trFolders.SelectedNode.Tag, Mailbox)
            Dim messUID As UInteger = CUInt(row("UID"))
            Dim n As MessageSequenceNumbers = New MessageSequenceNumbers()
            n.Add(New SequenceNumber(messUID))

            If CBool(row("Del")) Then
                logger.addLogMessage("MarkAsUndeleted message with uid=" & messUID)
                iClient.MarkAsUndeleted(n, folder)
            Else
                logger.addLogMessage("MarkAsDeleted message with uid=" & messUID)
                iClient.MarkAsDeleted(n, folder)
            End If

            getAllMessages()
        End If

        If dgvMessages.Columns(e.ColumnIndex).Name.Equals("Flag") Then
            Dim flCol As MessageFlagCollection = CType(row("Flags"), MessageFlagCollection)
            Dim sst As ShowSetFlags = New ShowSetFlags(flCol, ShowSetFlags.ShowSetFlagMode.Show)
            sst.ShowDialog()
        End If

        If dgvMessages.Columns(e.ColumnIndex).Name.Equals("Sel") Then
            CType(dgvMessages.Rows(e.RowIndex).Cells("Sel"), DataGridViewCheckBoxCell).Value = Not (CType((CType(dgvMessages.Rows(e.RowIndex).Cells("Sel"), DataGridViewCheckBoxCell)).Value, Boolean))
        End If
    End Sub

    Private Sub btnDelMess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelMess.Click
        If trFolders.SelectedNode Is Nothing Then Return
        Dim folder As Mailbox = CType(trFolders.SelectedNode.Tag, Mailbox)
        If folder.Parent Is Nothing Then Return
        logger.addLogMessage("Calling DeleteMarkedMessages")
        iClient.DeleteMarkedMessages(folder)
        getAllMessages()
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        If trFolders.SelectedNode Is Nothing Then Return
        Dim folder As Mailbox = CType(trFolders.SelectedNode.Tag, Mailbox)
        If folder.Parent Is Nothing Then Return
        If comboBox1.SelectedIndex = 0 Then Return

        If comboBox1.SelectedIndex >= 1 AndAlso comboBox1.SelectedIndex <= 6 Then
            Dim n As MessageSequenceNumbers = New MessageSequenceNumbers()

            For Each row As DataGridViewRow In dgvMessages.Rows

                If (CBool((CType(row.Cells("Sel"), DataGridViewCheckBoxCell)).Value)) Then
                    Dim dr As DataRow = dsMess.Tables(0).Rows(row.Index)
                    n.Add(New SequenceNumber(CUInt(dr("UID"))))
                End If
            Next

            Select Case comboBox1.SelectedIndex
                Case 1
                    Dim ssf As SelForm = New SelForm(iClient)
                    If ssf.ShowDialog() <> DialogResult.OK Then Return
                    Dim folderTo As Mailbox = ssf.selFolder
                    If folderTo.Parent Is Nothing Then Return
                    logger.addLogMessage("Copy " & n.Count & " messages from " + folder.DisplayName & " to " + folderTo.DisplayName)
                    iClient.Copy(n, folder, folderTo)
                Case 2
                    logger.addLogMessage("MarkAsSeen " & n.Count & " messages from " + folder.DisplayName & " folder ")
                    iClient.MarkAsSeen(n, folder)
                Case 3
                    logger.addLogMessage("MarkAsUnseen " & n.Count & " messages from " + folder.DisplayName & " folder ")
                    iClient.MarkAsUnseen(n, folder)
                Case 4
                    logger.addLogMessage("MarkAsDelete " & n.Count & " messages from " + folder.DisplayName & " folder ")
                    iClient.MarkAsDeleted(n, folder)
                Case 5
                    logger.addLogMessage("MarkAsUndelete " & n.Count & " messages from " + folder.DisplayName & " folder ")
                    iClient.MarkAsUndeleted(n, folder)
                Case 6
                    Dim sst As ShowSetFlags = New ShowSetFlags()
                    If sst.ShowDialog() <> DialogResult.OK Then Return
                    logger.addLogMessage("SetMessageFlags for " & n.Count & " messages from " + folder.DisplayName & " folder. FlagMode=" + sst.FlagMode)
                    iClient.SetMessageFlags(n, folder, sst.NewFlagCollection, sst.FlagMode)
            End Select
        End If

        comboBox1.SelectedIndex = 0
        getAllMessages()
    End Sub

    Private Sub SelBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelFolder.Click
        Dim selNode As TreeNode = trFolders.SelectedNode
        If selNode Is Nothing Then Return
        logger.addLogMessage("Select " & (CType(selNode.Tag, Mailbox)).DisplayName & " folder")
        Dim resp As CompletionResponse = iClient.[Select](CType(selNode.Tag, Mailbox))
        If resp.CompletionResult = ECompletionResponseType.OK Then selMailbox = CType(selNode.Tag, Mailbox)
        getAllFolders()
    End Sub

    '   Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
    'If txtSFolder.Tag Is Nothing Then
    '        MessageBox.Show("Please choose mailbox to search in", "Choose mailbox", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return
    '    End If

    '    Dim q As Query = Nothing

    '    If cbOrOldRecent.Checked Then

    '        If rbOld.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Old()
    '            Else
    '                q = Query.[Or](q, Query.Old())
    '            End If
    '        End If

    '        If rbRecent.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Recent()
    '            Else
    '                q = Query.[Or](q, Query.Recent())
    '            End If
    '        End If
    '    End If

    '    If cbOrSeen.Checked Then

    '        If rbSeen.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Seen()
    '            Else
    '                q = Query.[Or](q, Query.Seen())
    '            End If
    '        End If

    '        If rbUnSeen.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Unseen()
    '            Else
    '                q = Query.[Or](q, Query.Unseen())
    '            End If
    '        End If
    '    End If

    '    If cbOrAns.Checked Then

    '        If rbAnswered.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Answered()
    '            Else
    '                q = Query.[Or](q, Query.Answered())
    '            End If
    '        End If

    '        If rbUnAns.Checked Then

    '            If q Is Nothing Then
    '                q = Query.UnAnswered()
    '            Else
    '                q = Query.[Or](q, Query.UnAnswered())
    '            End If
    '        End If
    '    End If

    '    If cbOrDeleted.Checked Then

    '        If rbDeleted.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Deleted()
    '            Else
    '                q = Query.[Or](q, Query.Deleted())
    '            End If
    '        End If

    '        If rbUnDel.Checked Then

    '            If q Is Nothing Then
    '                q = Query.UnDeleted()
    '            Else
    '                q = Query.[Or](q, Query.UnDeleted())
    '            End If
    '        End If
    '    End If

    '    If cbOrDraft.Checked Then

    '        If rbDraft.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Draft()
    '            Else
    '                q = Query.[Or](q, Query.Draft())
    '            End If
    '        End If

    '        If rbUnDraft.Checked Then

    '            If q Is Nothing Then
    '                q = Query.UnDraft()
    '            Else
    '                q = Query.[Or](q, Query.UnDraft())
    '            End If
    '        End If
    '    End If

    '    If cbOrFlagged.Checked Then

    '        If rbFlagged.Checked Then

    '            If q Is Nothing Then
    '                q = Query.Flagged()
    '            Else
    '                q = Query.[Or](q, Query.Flagged())
    '            End If
    '        End If

    '        If rbUnFlagged.Checked Then

    '            If q Is Nothing Then
    '                q = Query.UnFlagged()
    '            Else
    '                q = Query.[Or](q, Query.UnFlagged())
    '            End If
    '        End If
    '    End If

    '    If cbOrLarger.Checked Then
    '        Dim value As UInteger

    '        If UInt32.TryParse(txtSLarger.Text, value) Then

    '            If q Is Nothing Then
    '                q = Query.Larger(value)
    '            Else
    '                q = Query.[Or](q, Query.Larger(value))
    '            End If
    '        End If
    '    End If

    '    If cbOrSmaller.Checked Then
    '        Dim value As UInteger

    '        If UInt32.TryParse(txtSSmaller.Text, value) Then

    '            If q Is Nothing Then
    '                q = Query.Smaller(value)
    '            Else
    '                q = Query.[Or](q, Query.Smaller(value))
    '            End If
    '        End If
    '    End If

    '    If cbOrUID.Checked Then
    '        Dim uids As MessageSequenceNumbers = New MessageSequenceNumbers()

    '        For Each uidStr As String In txtSUID.Text.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
    '            Dim value As UInteger
    '            If UInt32.TryParse(uidStr, value) Then uids.Add(New SequenceNumber(value))
    '        Next

    '        If q Is Nothing Then
    '            q = Query.UID(uids)
    '        Else
    '            q = Query.[Or](q, Query.UID(uids))
    '        End If
    '    End If

    '    If cbOrSubj.Checked Then

    '        If Not String.IsNullOrEmpty(txtSSubj.Text) Then

    '            If q Is Nothing Then
    '                q = Query.Subject(txtSSubj.Text)
    '            Else
    '                q = Query.[Or](q, Query.Subject(txtSSubj.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrFrom.Checked Then

    '        If Not String.IsNullOrEmpty(txtSFrom.Text) Then

    '            If q Is Nothing Then
    '                q = Query.From(txtSFrom.Text)
    '            Else
    '                q = Query.[Or](q, Query.From(txtSFrom.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrTo.Checked Then

    '        If Not String.IsNullOrEmpty(txtSTo.Text) Then

    '            If q Is Nothing Then
    '                q = Query.[To](txtSTo.Text)
    '            Else
    '                q = Query.[Or](q, Query.[To](txtSTo.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrCopy.Checked Then

    '        If Not String.IsNullOrEmpty(txtSCopy.Text) Then

    '            If q Is Nothing Then
    '                q = Query.CC(txtSCopy.Text)
    '            Else
    '                q = Query.[Or](q, Query.CC(txtSCopy.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrBlCopy.Checked Then

    '        If Not String.IsNullOrEmpty(txtSBlCopy.Text) Then

    '            If q Is Nothing Then
    '                q = Query.BCC(txtSBlCopy.Text)
    '            Else
    '                q = Query.[Or](q, Query.BCC(txtSBlCopy.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrText.Checked Then

    '        If Not String.IsNullOrEmpty(txtSText.Text) Then

    '            If q Is Nothing Then
    '                q = Query.Text(txtSText.Text)
    '            Else
    '                q = Query.[Or](q, Query.Text(txtSText.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrBody.Checked Then

    '        If Not String.IsNullOrEmpty(txtSBody.Text) Then

    '            If q Is Nothing Then
    '                q = Query.Body(txtSBody.Text)
    '            Else
    '                q = Query.[Or](q, Query.Body(txtSBody.Text))
    '            End If
    '        End If
    '    End If

    '    If cbOrHeader.Checked Then

    '        If Not String.IsNullOrEmpty(txtSField.Text) Then

    '            If Not String.IsNullOrEmpty(txtSValue.Text) Then

    '                If q Is Nothing Then
    '                    q = Query.Header(txtSField.Text, txtSValue.Text)
    '                Else
    '                    q = Query.[Or](q, Query.Header(txtSField.Text, txtSValue.Text))
    '                End If
    '            End If
    '        End If
    '    End If

    '    If cbOrSince.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtSSince.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.Since(dt)
    '            Else
    '                q = Query.[Or](q, Query.Since(dt))
    '            End If
    '        End If
    '    End If

    '    If cbOrOn.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtsOn.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.[On](dt)
    '            Else
    '                q = Query.[Or](q, Query.[On](dt))
    '            End If
    '        End If
    '    End If

    '    If cbOrBefore.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtSBefore.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.Before(dt)
    '            Else
    '                q = Query.[Or](q, Query.Before(dt))
    '            End If
    '        End If
    '    End If

    '    If cbOrSendSince.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtSSendSince.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.SentSince(dt)
    '            Else
    '                q = Query.[Or](q, Query.SentSince(dt))
    '            End If
    '        End If
    '    End If

    '    If cbOrSendOn.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtSSendOn.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.SentOn(dt)
    '            Else
    '                q = Query.[Or](q, Query.SentOn(dt))
    '            End If
    '        End If
    '    End If

    '    If cbOrSendBefore.Checked Then
    '        Dim dt As DateTime

    '        If DateTime.TryParse(mtxtSSentBefore.Text, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), System.Globalization.DateTimeStyles.AssumeLocal, dt) Then

    '            If q Is Nothing Then
    '                q = Query.SentBefore(dt)
    '            Else
    '                q = Query.[Or](q, Query.SentBefore(dt))
    '            End If
    '        End If
    '    End If

    '    If q Is Nothing Then q = Query.All()
    '    Dim res As IEnumerable(Of UInteger) = iClient.Search(q, CType(txtSFolder.Tag, Mailbox))
    '    Dim messages As MessageCollection = iClient.GetMessagesHeader(CType(txtSFolder.Tag, Mailbox), res)
    '    fillTableWithMessages(dsSearchMess.Tables(0), messages)
    'End Sub

    'Private Sub btnSSelFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim ssf As SelFolderForm = New SelFolderForm(iClient, "Select")
    '    If ssf.ShowDialog() <> DialogResult.OK Then Return
    '    Dim folderTo As Mailbox = ssf.selFolder
    '    If folderTo.Parent Is Nothing Then Return
    '    txtSFolder.Tag = folderTo
    '    txtSFolder.Text = folderTo.DisplayName
    'End Sub

    'Private Sub dataGridView1_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
    '    Dim row As DataGridViewRow = dgvSearchMessages.Rows(e.RowIndex)

    '    If (CInt(dsSearchMess.Tables(0).Rows(e.RowIndex)("Seen"))) = 0 Then
    '        dgvSearchMessages.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Verdana", CSng(7), FontStyle.Bold)
    '    End If
    'End Sub

    'Private Sub dgvSearchMessages_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
    '    If e.RowIndex = -1 Then Return
    '    Dim row As DataRow = dsSearchMess.Tables(0).Rows(e.RowIndex)

    '    If dgvSearchMessages.Columns(e.ColumnIndex).Name.Equals("SearchFlag") Then
    '        Dim flCol As MessageFlagCollection = CType(row("Flags"), MessageFlagCollection)
    '        Dim sst As ShowSetFlags = New ShowSetFlags(flCol, ShowSetFlags.ShowSetFlagMode.Show)
    '        sst.ShowDialog()
    '    End If
    'End Sub
End Class