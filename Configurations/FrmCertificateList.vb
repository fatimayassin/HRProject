Public Class FrmCertificateList
    Public isValidate As Boolean = True
    Public saved As Boolean = False
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList
        End Using
    End Sub
    Private Sub FrmCertificateList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblCertificateDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub
    Sub checkgridValidate()
        For i As Integer = 0 To TblCertificateBindingSource.Count - 1
            Dim x As TblCertificate = TblCertificateBindingSource(i)
            If x.Name = Nothing Then
                If i = 0 Then
                    isValidate = False
                Else
                    isValidate = isValidate And False
                End If
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub TblCertificateDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCertificateDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Dim answer = MessageBox.Show("Are you sure you want to delete this!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                Using aMainor As New LqHRDataContext(cnx)
                    Dim Id As Integer = TblCertificateBindingSource.Current.id
                    If Id = 0 Then
                        TblCertificateBindingSource.RemoveCurrent()
                        TblCertificateDataGridView.Refresh()
                    Else

                        Dim result = (From aX In aMainOR.TblCertificates Where aX.Id = Id).ToList(0)

                        If result.TblEducations.Count > 0 Or result.TblRequirements.Count > 0 Then
                            MessageBox.Show("cannot be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            aMainOR.TblCertificates.DeleteOnSubmit(result)
                            aMainOR.SubmitChanges()
                            refreshForm()
                        End If
                    End If
                End Using
            End If

        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblCertificateDataGridView.ReadOnly = False
            BtnSave.Enabled = True
            TblCertificateBindingSource.AddNew()
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblCertificateBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblCertificateBindingSource.Count - 1
                        Dim x As TblCertificate = TblCertificateBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblCertificates.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblCertificateBindingSource.RemoveCurrent()
                                TblCertificateDataGridView.Refresh()
                            End If
                        Else
                            Dim CerId As Integer = TblCertificateBindingSource(i).id
                            Dim oldCer = (From ax In aMainor.TblCertificates Where ax.Id = CerId).ToList(0)
                            Dim newCer As TblCertificate = TblCertificateBindingSource(i)
                            oldCer.Name = newCer.Name
                            aMainor.SubmitChanges()

                        End If
                    Next
                    TblCertificateDataGridView.ReadOnly = True
                    BtnSave.Enabled = False

                End If
            End If
        End Using
        saved = True
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblCertificateDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub
End Class