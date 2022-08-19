Public Class FrmAddDegree
    Public id As Integer = 0
    Public Classid As Integer = 0
    Public saved As Boolean = False

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub FrmAddDegree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If id = 0 Then
            TblDegreeBindingSource.DataSource = New TblDegree

        Else
            Using aMainor As New LqHRDataContext(cnx)
                TblDegreeBindingSource.DataSource = (From ax In aMainor.TblDegrees Where ax.Id = id).ToList(0)
            End Using

        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = Windows.Forms.DialogResult.Yes Then
            Using aMainor As New LqHRDataContext(cnx)
                TblDegreeBindingSource.Current.classificationId = Classid
                If id = 0 Then

                    aMainor.TblDegrees.InsertOnSubmit(TblDegreeBindingSource.Current)
                    aMainor.SubmitChanges()

                Else
                    Dim old = (From ax In aMainor.TblDegrees Where ax.Id = id).ToList(0)
                    Dim newrow As TblDegree = TblDegreeBindingSource.Current
                    old.Name = newrow.Name
                    old.Amount = newrow.Amount
                    aMainor.SubmitChanges()


                End If
            End Using
            saved = True
            Me.Close()
        End If
    End Sub
End Class