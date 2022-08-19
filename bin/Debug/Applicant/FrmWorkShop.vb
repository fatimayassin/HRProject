Public Class FrmWorkShop
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public current As New TblWorkShop
    Public ForEdit As Boolean = False

    Private Sub FrmWorkShop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If Not ForEdit Then
            If Id = 0 Then
                TblWorkShopBindingSource.DataSource = New TblWorkShop
            End If
        Else
            TblWorkShopBindingSource.DataSource = current
        End If
        DateDateTimePicker.MaxDate = Date.Now
    End Sub

    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If NameTextBox.Text = "" Or OrganizationTextBox.Text = "" Or PlaceTextBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            current = TblWorkShopBindingSource.Current
            Saved = True
            Me.Close()
        End If
    End Sub


End Class