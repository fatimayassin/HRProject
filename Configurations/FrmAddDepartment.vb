Public Class FrmAddDepartment
    Public Saved As Boolean = False
    Public Id As Integer = 0
    Public parentId As Integer = 0


    Private Sub FrmAddDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            'TblDepartmentBindingSource1.DataSource = aMainOr.TblDepartments.ToList
            TblCompanyProfileBindingSource.DataSource = aMainor.TblCompanyProfiles.ToList
            TblDepartmentCategoryBindingSource.DataSource = aMainor.TblDepartmentCategories.ToList
            TblDepartmentTypeBindingSource.DataSource = aMainor.TblDepartmentTypes.ToList

            If Id = 0 Then
                TblDepartmentBindingSource.DataSource = New TblDepartment
                TblDepartmentBindingSource.Current.CompanyProfileId = (From ax In aMainor.TblCompanyProfiles Select ax.Id).ToList(0)
            Else
                TblDepartmentBindingSource.DataSource = (From aX In aMainor.TblDepartments Where aX.Id = Id).ToList(0)
            End If
        End Using
    End Sub




    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        BtnSave.Focus()
        If NameTextBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Id = 0 Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblDepartmentBindingSource.Current.ParentId = parentId
                    TblCompanyProfileBindingSource.DataSource = aMainor.TblCompanyProfiles.ToList
                    TblDepartmentCategoryBindingSource.DataSource = aMainor.TblDepartmentCategories.ToList
                    TblDepartmentTypeBindingSource.DataSource = aMainor.TblDepartmentTypes.ToList
                    If parentId = 0 Then
                        TblDepartmentBindingSource.Current.code = Nothing
                        TblDepartmentBindingSource.Current.ParentId = Nothing
                    Else
                        Dim ParentCode = (From aX In aMainOr.TblDepartments Where aX.Id = parentId Select aX.Code).ToList(0)

                        Dim result = (From aX In aMainOr.TblDepartments Where aX.ParentId = parentId)

                        If result.Count = 0 Then
                            TblDepartmentBindingSource.Current.code = ParentCode * 100 + 1
                        Else
                            Dim maxCode = (From aX In aMainOr.TblDepartments Where aX.ParentId = parentId Select aX.Code).Max()
                            TblDepartmentBindingSource.Current.code = maxCode + 1
                        End If

                    End If
                    aMainOr.TblDepartments.InsertOnSubmit(TblDepartmentBindingSource.Current)
                    aMainOr.SubmitChanges()
                    Dim currentId As Integer = TblDepartmentBindingSource.Current.ID

                    If parentId = 0 Then
                        Dim ADepartment As TblDepartment = (From aX In aMainOr.TblDepartments Where aX.Id = currentId).ToList(0)
                        ADepartment.Code = currentId
                        aMainOr.SubmitChanges()
                    End If
                End Using
            Else
                Using aMainor As New LqHRDataContext(cnx)
                    Dim OldDepartment As TblDepartment = (From aX In aMainOr.TblDepartments Where aX.Id = Id).ToList(0)
                    Dim NewDepartment As TblDepartment = TblDepartmentBindingSource.Current
                    OldDepartment.Name = NewDepartment.Name
                    OldDepartment.Description = NewDepartment.Description
                    OldDepartment.ParentId = NewDepartment.ParentId
                    OldDepartment.ArabicName = NewDepartment.ArabicName
                    OldDepartment.CompanyProfileId = NewDepartment.CompanyProfileId
                    OldDepartment.DepCategoryId = NewDepartment.DepCategoryId
                    OldDepartment.MakeSatisfication = NewDepartment.MakeSatisfication
                    OldDepartment.TypeId = NewDepartment.TypeId
                    aMainOr.SubmitChanges()
                End Using
            End If
            Saved = True
            Me.Close()
        End If
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub CompanyProfileIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CompanyProfileIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmCompanyProfil
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblCompanyProfileBindingSource.DataSource = aMainor.TblCompanyProfiles.ToList
            End Using

            X.Dispose()

        End If
    End Sub

    Private Sub DepCategoryIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DepCategoryIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmDepartmentCategory
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblDepartmentCategoryBindingSource.DataSource = aMainor.TblDepartmentCategories.ToList
            End Using


            X.Dispose()
        End If
    End Sub

    Private Sub TypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TypeIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmDepartmentType
            X.ShowDialog()

            Using aMainor As New LqHRDataContext(cnx)
                TblDepartmentTypeBindingSource.DataSource = aMainor.TblDepartmentTypes.ToList
            End Using


            X.Dispose()
        End If
    End Sub
End Class