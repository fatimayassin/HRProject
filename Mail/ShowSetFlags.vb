Imports System
Imports System.Windows.Forms
Imports Email.Net.Imap
Imports Email.Net.Imap.Collections

Public Class ShowSetFlags
    Inherits Form

    Public Enum ShowSetFlagMode
        Show
        Edit
    End Enum

    Public ReadOnly Property NewFlagCollection As MessageFlagCollection
        Get
            Dim col As MessageFlagCollection = New MessageFlagCollection()

            For Each flag As MessageFlag In lbFlags1.Items
                col.Add(flag)
            Next

            Return col
        End Get
    End Property

    Public ReadOnly Property FlagMode As EFlagMode
        Get

            Select Case comboBox1.SelectedIndex
                Case 0
                    Return EFlagMode.Add
                Case 1
                    Return EFlagMode.Remove
                Case Else
                    Return EFlagMode.Replace
            End Select
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        comboBox1.SelectedIndex = 0
        lbFlags1.Items.Clear()
        lbFlags2.Items.Clear()
        lbFlags2.Items.Add(New MessageFlag(EFlag.Answered))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Deleted))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Draft))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Flagged))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Recent))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Seen))
    End Sub

    Public Sub New(ByVal flagCol As MessageFlagCollection)
        InitializeComponent()
        label3.Text = ""
        label1.Text = "Currently setted flags:"
        lbFlags1.Items.Clear()
        lbFlags2.Items.Clear()

        For Each flag As MessageFlag In flagCol
            lbFlags1.Items.Add(flag)
        Next
    End Sub

    Public Sub New(ByVal flagCol As MessageFlagCollection, ByVal ssfm As ShowSetFlagMode)
        InitializeComponent()
        label3.Text = ""
        label1.Text = "Currently setted flags:"
        lbFlags1.Items.Clear()
        lbFlags2.Items.Clear()

        For Each flag As MessageFlag In flagCol
            lbFlags1.Items.Add(flag)
        Next

        If ssfm = ShowSetFlagMode.Show Then
            comboBox1.Enabled = False
            lbFlags2.Enabled = False
            btnAdd.Enabled = False
            btnAddAll.Enabled = False
            btnDel.Enabled = False
            btnDelAll.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        If lbFlags2.SelectedIndex < 0 Then Return
        lbFlags1.Items.Add(lbFlags2.SelectedItem)
        lbFlags2.Items.RemoveAt(lbFlags2.SelectedIndex)
    End Sub

    Private Sub btnAddAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAll.Click
        lbFlags1.Items.Clear()
        lbFlags2.Items.Clear()
        lbFlags1.Items.Add(New MessageFlag(EFlag.Answered))
        lbFlags1.Items.Add(New MessageFlag(EFlag.Deleted))
        lbFlags1.Items.Add(New MessageFlag(EFlag.Draft))
        lbFlags1.Items.Add(New MessageFlag(EFlag.Flagged))
        lbFlags1.Items.Add(New MessageFlag(EFlag.Recent))
        lbFlags1.Items.Add(New MessageFlag(EFlag.Seen))
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelAll.Click
        lbFlags1.Items.Clear()
        lbFlags2.Items.Clear()
        lbFlags2.Items.Add(New MessageFlag(EFlag.Answered))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Deleted))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Draft))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Flagged))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Recent))
        lbFlags2.Items.Add(New MessageFlag(EFlag.Seen))
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click
        If lbFlags1.SelectedIndex < 0 Then Return
        lbFlags2.Items.Add(lbFlags1.SelectedItem)
        lbFlags1.Items.RemoveAt(lbFlags1.SelectedIndex)
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class