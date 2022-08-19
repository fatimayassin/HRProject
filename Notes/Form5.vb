Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetNotes.tblNotes' table. You can move, or remove it, as needed.
        Me.TblNotesTableAdapter.Fill(Me.DataSetNotes.tblNotes)

        'Me.UltraListView1.View = UltraListViewStyle.Tiles

        Me.ListView1.View = View.LargeIcon
        ListView1.LargeImageList = ilLarge

        'Me.UltraListView1.ViewSettingsDetails.SubItemColumnsVisibleByDefault = True
        'Me.UltraListView1.ViewSettingsTiles.SubItemsVisibleByDefault = True
        'Me.UltraListView1.ItemSettings.SubItemsVisibleInToolTipByDefault = False


        'Me.UltraListView1.ViewSettingsTiles.ImageList = Me.ilLarge
        'Me.UltraListView1.Appearance.Image = 53
        'Me.UltraListView1.ViewSettingsTiles.SubItemAppearance.Image = My.Resources.Notes

        'Dim dataColumn As DataColumn
        'For Each dataColumn In Me.DataSetNotes.Tables("tblNotes").Columns

        '    If (dataColumn.ColumnName = "NoteID") Then
        '    ElseIf (dataColumn.ColumnName = "Note") Then

        '        Dim mainColumn As UltraListViewMainColumn = Me.UltraListView1.MainColumn
        '        mainColumn.Text = "Note"
        '        mainColumn.DataType = dataColumn.DataType
        '    Else
        '        ' For all other fields, add a member to the
        '        ' SubItemColumns collection
        '        Dim subItemColumn As UltraListViewSubItemColumn
        '        subItemColumn = Me.ListView1.Items.Add(dataColumn.ColumnName)
        '        subItemColumn.DataType = dataColumn.DataType
        '    End If
        'Next

        For i = 0 To Me.DataSetNotes.Tables("tblNotes").Rows.Count - 1
            Dim row As DataRow = Me.DataSetNotes.Tables("tblNotes").Rows(i)
            ' Break out the field values for this row
            Dim NoteID As String = row("NoteID")
            Dim Note As String = row("Note")

            Dim item As ListViewItem = Me.ListView1.Items.Add(NoteID, Note)
            ListView1.Items(i).ImageIndex = 5
        Next
    End Sub
End Class