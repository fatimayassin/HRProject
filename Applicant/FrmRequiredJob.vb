Public Class FrmRequiredJob
    Public id As Integer = 0
    Public ApplicantId As Integer = 0
    Public saved As Boolean = False
    Public current As TblRequiredJob
    Public ForEdit As Boolean = False

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmRequiredJob_Load(ByVal sender As Object, ByVal e As EventArgs)

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblDepartmentBindingSource.DataSource = aMainor.TblDepartments.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList

            If Not ForEdit Then
                If id = 0 Then
                    TblRequiredJobBindingSource.DataSource = New TblRequiredJob
                End If
            Else
                WayOfWorkingComboBox.SelectedItem = current.WayOfWorking
                TblRequiredJobBindingSource.DataSource = current
            End If

        End Using
    End Sub

    Private Sub DepartmentIdComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Using aMainor As New LqHRDataContext(cnx)
            If Not DepartmentIdComboBox.SelectedIndex = -1 Then
                Dim DepId As Integer = DepartmentIdComboBox.SelectedValue
                Dim res = (From aX In aMainor.TblJobsPerDepartments Where aX.DepartmentId = DepId Select aX.JobId).ToList()
                TblJobDescriptionBindingSource.DataSource = (From ax In aMainor.TblJobDescriptions Where res.Contains(ax.Id)).ToList
            End If
        End Using
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DepartmentIdComboBox.Text = "" Then 'Or JobDescriptionIdComboBox.Text = "" Or WayOfWorkingComboBox.Text = "" Or ExpectedSalaryNumericUpDown.Value = 0 Then
            MessageBox.Show("missing information", "warning", MessageBoxButtons.OK)
        Else
            TblRequiredJobBindingSource.Current.WayOfWorking = WayOfWorkingComboBox.SelectedItem
            current = TblRequiredJobBindingSource.Current
            saved = True
            Me.Close()
        End If
    End Sub

    Private Sub lblClose_Click_1(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class