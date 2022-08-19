Public Class FrmAddClassification
    Public saved As Boolean = False
    Public id As Integer = 0

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub FrmAddClassification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If id = 0 Then
            TblClassificationBindingSource.DataSource = New TblClassification

        Else
            Using aMainor As New LqHRDataContext(cnx)
                TblClassificationBindingSource.DataSource = (From ax In aMainor.TblClassifications Where ax.Id = id).ToList(0)
            End Using

        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)
                If id = 0 Then
                    aMainor.TblClassifications.InsertOnSubmit(TblClassificationBindingSource.Current)
                    aMainor.SubmitChanges()
                Else
                    Dim old = (From ax In aMainor.TblClassifications Where ax.Id = id).ToList(0)
                    Dim newrow As TblClassification = TblClassificationBindingSource.Current
                    old.Name = newrow.Name
                    aMainor.SubmitChanges()


                End If
            End Using
            saved = True
            Me.Close()
        End If
    End Sub
End Class