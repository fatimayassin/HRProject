Imports Infragistics.Win.UltraWinListView
Imports Infragistics.Win


Public Class FrmNotesList

    Private ID As Integer
    Private s As String

    Private Sub FrmNotesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblNotesTableAdapter.Fill(Me.DataSetNotes.tblNotes)

        Me.UltraListView1.View = UltraListViewStyle.Icons
        Me.UltraListView1.ViewSettingsIcons.ImageList = Me.ilLarge

        Me.UltraListView1.ViewSettingsDetails.SubItemColumnsVisibleByDefault = True
        Me.UltraListView1.ViewSettingsTiles.SubItemsVisibleByDefault = True
        Me.UltraListView1.ItemSettings.SubItemsVisibleInToolTipByDefault = False

        Dim dataColumn As DataColumn
        For Each dataColumn In Me.DataSetNotes.Tables("tblNotes").Columns

            If (dataColumn.ColumnName = "NoteID") Then
            ElseIf (dataColumn.ColumnName = "Note") Then

                Dim mainColumn As UltraListViewMainColumn = Me.UltraListView1.MainColumn
                mainColumn.Text = "Note"
                mainColumn.DataType = dataColumn.DataType
            Else
                ' For all other fields, add a member to the
                ' SubItemColumns collection
                Dim subItemColumn As UltraListViewSubItemColumn
                subItemColumn = Me.UltraListView1.SubItemColumns.Add(dataColumn.ColumnName)
                subItemColumn.DataType = dataColumn.DataType
            End If
        Next

        For i = 0 To Me.DataSetNotes.Tables("tblNotes").Rows.Count - 1
            Dim row As DataRow = Me.DataSetNotes.Tables("tblNotes").Rows(i)
            ' Break out the field values for this row
            Dim NoteID As String = row("NoteID")
            Dim Note As String = row("Note")

            Dim item As UltraListViewItem = Me.UltraListView1.Items.Add(NoteID, Note)

            ' UltraListView1.ItemSettings.Appearance.Image = 5
            Me.UltraListView1.Items(i).Appearance.Image = 5
        Next
    End Sub

    Private Sub UltraListView1_ItemDoubleClick(sender As Object, e As ItemDoubleClickEventArgs) Handles UltraListView1.ItemDoubleClick
        If UltraListView1.SelectedItems.Count > 0 Then
            ' ID = TblNotesBindingSource.Current.NoteID


            s = UltraListView1.SelectedItems(0).Value.ToString()

            Dim notes As New FrmNewNote
            notes.s = s
            notes.ShowDialog()
        End If
    End Sub

End Class