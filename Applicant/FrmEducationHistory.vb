Public Class FrmEducationHistory
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public applicantId As Integer = 0
    Public current As New TblEducation
    Public ForEdit As Boolean = False

    Private Sub frmEducationHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList

            If Not ForEdit Then
                If Id = 0 Then
                    TblEducationBindingSource.DataSource = New TblEducation
                End If
            Else
                TblEducationBindingSource.DataSource = current
            End If
        End Using
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If StartYearDateTimePicker.Text = "" Or GraduationYearDateTimePicker.Text = "" Or MajorTextBox.Text = "" Or CertificateIdComboBox.Text = "" Or UniversityTextBox.Text = "" Or GPATextBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            current = TblEducationBindingSource.Current
            Saved = True
            Me.Close()
        End If
    End Sub


    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub


    Private Sub CertificateIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CertificateIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim X As New FrmCertificateList
            X.ShowDialog()
            If X.saved Then
                Using aMainor As New LqHRDataContext(cnx)
                    TblCertificateBindingSource.DataSource = aMainor.TblCertificates.ToList

                End Using

            End If

            X.Dispose()
        End If
    End Sub
End Class