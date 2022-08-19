Public Class FrmLanguages
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public current As New TblLanguage
    Public ForEdit As Boolean = False

    Private Sub FrmLanguages_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If Not ForEdit Then
            If Id = 0 Then
                TblLanguageBindingSource.DataSource = New TblLanguage
                TblLanguageBindingSource.Current.ReadingLevel = ReadingLevelTrackBar.Value
                TblLanguageBindingSource.Current.WritingLevel = WritingLevelTrackBar.Value
                TblLanguageBindingSource.Current.CommLevel = CommLevelTrackBar.Value

            End If
        Else
            LanguageComboBox.SelectedItem = current.Language
            TblLanguageBindingSource.DataSource = current
        End If

    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If LanguageComboBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            'If Id = 0 Then
            '    TblLanguageBindingSource.Current.applicantId = ApplicantId
            '    aMainOr.TblLanguages.InsertOnSubmit(TblLanguageBindingSource.Current)
            'Else
            '    Dim Old = (From aX In aMainOr.TblLanguages Where aX.Id = Id).ToList(0)
            '    Dim newItem As TblLanguage = TblLanguageBindingSource.Current
            '    Old.Language = newItem.Language
            '    Old.CommLevel = newItem.CommLevel
            '    Old.ReadingLevel = newItem.ReadingLevel
            '    Old.WritingLevel = newItem.WritingLevel

            'End If
            'aMainOr.SubmitChanges()
            TblLanguageBindingSource.Current.language = LanguageComboBox.SelectedItem
            current = TblLanguageBindingSource.Current
            Saved = True
            Me.Close()

        End If
    End Sub
End Class