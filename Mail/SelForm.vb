Imports System
Imports System.Windows.Forms
Imports Email.Net.Imap
Imports Email.Net.Imap.Collections


Public Class SelForm
    Inherits Form

    Private iClient As ImapClient
    Public Property selFolder As Mailbox

    'Public Sub New()
    '    InitializeComponent()
    'End Sub

    Public Sub New(ByVal client As ImapClient)
        InitializeComponent()
        iClient = client
        getAllFolders()
    End Sub

    'Public Sub New(ByVal client As ImapClient, ByVal actionName As String)
    '    InitializeComponent()
    '    btnOk.Text = actionName
    '    iClient = client
    '    getAllFolders()
    'End Sub

    Private Sub getAllFolders()
        Dim mailbox As Mailbox = iClient.GetMailboxTree()
        ' trFolders.Nodes.Clear()
        Dim nodeName As String = mailbox.DisplayName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.FullName
        If String.IsNullOrEmpty(nodeName) Then nodeName = mailbox.Name
        If String.IsNullOrEmpty(nodeName) Then nodeName = "RootNode"
        Dim tn As TreeNode = New TreeNode(nodeName)
        tn.Tag = mailbox
        ' trFolders.Nodes.Add(tn)
        addFoldersToTree(tn, mailbox.Children)
        tn.ExpandAll()
    End Sub

    Private Sub addFoldersToTree(ByVal rootNode As TreeNode, ByVal folders As MailboxCollection)
        For Each mb As Mailbox In folders
            Dim tn As TreeNode = New TreeNode(mb.DisplayName)
            tn.Tag = mb
            rootNode.Nodes.Add(tn)
            addFoldersToTree(tn, mb.Children)
        Next
    End Sub

    Private Sub trFolders_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs)
        If e.Node Is Nothing Then Return
        selFolder = CType(e.Node.Tag, Mailbox)
    End Sub
End Class