Public Class FrmMotivationPunishmentType
    Public isValidate As Boolean = True
    Public saved As Boolean = False

    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblMotivationPunishmentTypeBindingSource.DataSource = aMainor.TblMotivationPunishmentTypes.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblMotivationPunishmentTypeBindingSource.Count - 1

            Dim x As TblMotivationPunishmentType = TblMotivationPunishmentTypeBindingSource(i)
            If x.Name = Nothing Then
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub


    Private Sub FrmMotivationPunishmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        refreshForm()
        TblMotivationPunishmentTypeDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub


    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblMotivationPunishmentTypeDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblMotivationPunishmentTypeDataGridView.ReadOnly = False
            TblMotivationPunishmentTypeBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblMotivationPunishmentTypeBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblMotivationPunishmentTypeBindingSource.Count - 1
                        Dim x As TblMotivationPunishmentType = TblMotivationPunishmentTypeBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.Name = Nothing Then
                                aMainor.TblMotivationPunishmentTypes.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblMotivationPunishmentTypeBindingSource.RemoveCurrent()
                                TblMotivationPunishmentTypeDataGridView.Refresh()
                            End If
                        Else
                            If Not x.Name = Nothing Then
                                Dim MotPunTypeID As Integer = TblMotivationPunishmentTypeBindingSource(i).id
                                Dim oldMotPunType = (From ax In aMainor.TblMotivationPunishmentTypes Where ax.Id = MotPunTypeID).ToList(0)
                                Dim NewMotPunType As TblMotivationPunishmentType = TblMotivationPunishmentTypeBindingSource(i)
                                oldMotPunType.Name = NewMotPunType.Name
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblMotivationPunishmentTypeDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()

                End If
            End If
        End Using
        saved = True

    End Sub


    Private Sub TblMotivationPunishmentTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMotivationPunishmentTypeDataGridView.CellContentClick
        If TblMotivationPunishmentTypeBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblMotivationPunishmentTypeBindingSource.Current.id
                        If Id = 0 Then
                            TblMotivationPunishmentTypeBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblMotivationPunishmentTypes Where aX.Id = Id).ToList(0)

                            If result.TblMotivationPunishments.Count > 0 Then
                                MessageBox.Show("This Place is related to some TblMotivationPunishments!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                aMainOR.TblMotivationPunishmentTypes.DeleteOnSubmit(result)
                                aMainOR.SubmitChanges()
                                refreshForm()
                            End If
                        End If
                    End Using
                End If

            End If
        End If
    End Sub
End Class