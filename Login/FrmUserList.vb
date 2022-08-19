Public Class FrmUserList
    Public isValidate As Boolean = True
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
    Sub refreshForm()
        Using aMainor As New LqHRDataContext(cnx)
            TblUserBindingSource.DataSource = aMainor.TblUsers.ToList
        End Using
    End Sub

    Sub checkgridValidate()
        isValidate = True
        For i As Integer = 0 To TblUserBindingSource.Count - 1

            Dim x As TblUser = TblUserBindingSource(i)
            If x.Username Is Nothing Or x.Password Is Nothing Then  'x.EmployeeId Is Nothing Or
                isValidate = False
            Else
                isValidate = True
            End If
        Next
    End Sub

    Private Sub FrmUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList

        End Using
        refreshForm()
        TblUserDataGridView.ReadOnly = True
        BtnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        checkgridValidate()
        If isValidate Then
            TblUserDataGridView.ReadOnly = False
            TblUserBindingSource.AddNew()
            BtnSave.Enabled = True
        Else
            MessageBox.Show("Missing info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TblUserDataGridView.ReadOnly = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim answer = MessageBox.Show("Are you Sure you want to save this record", "save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = Windows.Forms.DialogResult.Yes Then
                If TblUserBindingSource.Count < 1 Then
                    MessageBox.Show("Nothing to save ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    For i As Integer = 0 To TblUserBindingSource.Count - 1
                        Dim x As TblUser = TblUserBindingSource(i)
                        If x.Id = 0 Then
                            If Not x.EmployeeId Is Nothing And x.Username IsNot Nothing And x.Password IsNot Nothing Then
                                aMainor.TblUsers.InsertOnSubmit(x)
                                aMainor.SubmitChanges()
                            Else
                                TblUserBindingSource.RemoveCurrent()
                                TblUserDataGridView.Refresh()
                            End If
                        Else
                            If Not x.EmployeeId Is Nothing And x.Username IsNot Nothing And x.Password IsNot Nothing Then
                                Dim UserID As Integer = TblUserBindingSource(i).id
                                Dim oldUser = (From ax In aMainor.TblUsers Where ax.Id = UserID).ToList(0)
                                Dim NewUser As TblUser = TblUserBindingSource(i)
                                oldUser.EmployeeId = NewUser.EmployeeId
                                oldUser.Username = NewUser.Username
                                oldUser.Password = NewUser.Password
                                aMainor.SubmitChanges()
                            End If
                        End If

                    Next
                    TblUserDataGridView.ReadOnly = True
                    BtnSave.Enabled = False
                    refreshForm()
                End If
            End If
        End Using
    End Sub

    Private Sub TblUserDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblUserDataGridView.CellContentClick
        If TblUserBindingSource.Count > 0 Then
            If e.ColumnIndex = Delete.Index Then
                Dim answer = MessageBox.Show("Are you sure you want to delete this item!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If answer = Windows.Forms.DialogResult.Yes Then
                    Using aMainor As New LqHRDataContext(cnx)
                        Dim Id As Integer = TblUserBindingSource.Current.id
                        If Id = 0 Then
                            TblUserBindingSource.RemoveCurrent()
                        Else
                            Dim result = (From aX In aMainOR.TblUsers Where aX.Id = Id).ToList(0)

                            aMainOR.TblUsers.DeleteOnSubmit(result)
                            aMainOR.SubmitChanges()
                            refreshForm()
                        End If
                    End Using
                End If

            End If
        End If
    End Sub

    Private Sub TblUserDataGridView_ReadOnlyChanged(sender As System.Object, e As System.EventArgs) Handles TblUserDataGridView.ReadOnlyChanged

        c1.ReadOnly = True
        c2.ReadOnly = True

    End Sub
End Class