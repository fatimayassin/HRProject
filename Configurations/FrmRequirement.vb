Public Class FrmRequirement
    Public id As Integer = 0
    Public saved As Boolean = False
    Public typeId As Integer = 0
    Public DepartmentId As Integer = 0

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub FrmNewJobRequirment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From aX In aMainor.TblTypes Where aX.Id = typeId).ToList(0)
            If res.Name = "Certifications" Then
                Panel1.Visible = True
                Panel2.Visible = False
                Me.Size = New Size(457, 390)
            Else
                Panel1.Visible = False
                Panel2.Visible = True
                Me.Size = New Size(457, 230)
            End If

            TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList
            If id = 0 Then
                TblRequirementBindingSource.DataSource = New TblRequirement
            Else
                TblRequirementBindingSource.DataSource = (From aX In aMainor.TblRequirements Where aX.Id = id).ToList(0)
            End If
        End Using

    End Sub



    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Using aMainor As New LqHRDataContext(cnx)

            If isGeneral.Checked Then
                DepartmentId = 0
            End If

            Dim res = (From aX In aMainOr.TblTypes Where aX.Id = typeId).ToList(0)

            If id = 0 Then
                If res.Name = "Certifications" Then
                    If MajorTextBox.Text = "" Or CertificateIdComboBox.Text = "" Then
                        MessageBox.Show("missing info", "warning", MessageBoxButtons.OK)
                    Else
                        Dim certID As Integer = CertificateIdComboBox.SelectedItem.id
                        Dim res2 = (From aX In aMainOr.TblCertificates Where aX.Id = certID).ToList(0)
                        TblRequirementBindingSource.Current.typeId = typeId
                        TblRequirementBindingSource.Current.DepartmentId = DepartmentId
                        TblRequirementBindingSource.Current.Description = res2.Name & " " & "in" & " " & MajorTextBox.Text & " " & "in " & LanguageComboBox.Text & ", " & ExperienceYearsNumericUpDown.Value & " " & "years of exp with " & " " & MinAgeNumericUpDown.Value & " " & " < age<" & " " & MaxAgeNumericUpDown.Value & " " & "note that " & NoteTextBox.Text
                    End If
                Else
                    TblRequirementBindingSource.Current.typeId = typeId
                    TblRequirementBindingSource.Current.DepartmentId = DepartmentId
                    TblRequirementBindingSource.Current.Description = DescriptionTextBox.Text
                End If
                aMainOr.TblRequirements.InsertOnSubmit(TblRequirementBindingSource.Current)

            Else
                Dim oldTblRequirement As TblRequirement = (From aX In aMainOr.TblRequirements Where aX.Id = id).ToList(0)
                Dim newTblRequirement As TblRequirement = TblRequirementBindingSource.Current
                If res.Name = "Certifications" Then
                    Dim certID = CertificateIdComboBox.SelectedItem.id
                    Dim res2 = (From aX In aMainOr.TblCertificates Where aX.Id = certID).ToList(0)

                    oldTblRequirement.Major = newTblRequirement.Major
                    oldTblRequirement.CertificateId = newTblRequirement.CertificateId
                    oldTblRequirement.ExperienceYears = newTblRequirement.ExperienceYears
                    oldTblRequirement.MaxAge = newTblRequirement.MaxAge

                    oldTblRequirement.MinAge = newTblRequirement.MinAge
                    oldTblRequirement.Language = newTblRequirement.Language
                    oldTblRequirement.Note = newTblRequirement.Note
                    oldTblRequirement.Description = res2.Name & " " & "in" & " " & MajorTextBox.Text & " " & "in " & LanguageComboBox.Text & ", " & ExperienceYearsNumericUpDown.Value & " " & "years of exp with " & " " & MinAgeNumericUpDown.Value & " " & " < age<" & " " & MaxAgeNumericUpDown.Value & " " & "note that " & NoteTextBox.Text

                Else
                    oldTblRequirement.Description = newTblRequirement.Description
                End If
            End If
            aMainOr.SubmitChanges()
            saved = True
            Me.Close()
        End Using

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class