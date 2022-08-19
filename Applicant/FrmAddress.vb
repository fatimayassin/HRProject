Public Class FrmAddress
    Public Id As Integer = 0
    Public Saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public current As New TblAddress
    Public ForEdit As Boolean = False

    Private Sub frmAddress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If Not ForEdit Then
            If Id = 0 Then
                TblAddressBindingSource.DataSource = New TblAddress
            End If
        Else
            PropertyTypeComboBox.SelectedItem = current.PropertyType
            TblAddressBindingSource.DataSource = current
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If AddressTextBox.Text = "" Or BuildingTextBox.Text = "" Then
            MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            TblAddressBindingSource.Current.propertyType = PropertyTypeComboBox.SelectedItem
            current = TblAddressBindingSource.Current
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



End Class