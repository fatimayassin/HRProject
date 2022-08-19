Public Class FrmLogin

    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles  Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As System.Object, e As System.EventArgs) Handles bLogin.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblUsers Where ax.Username = UsernameTextBox.Text And ax.Password = PasswordTextBox.Text).ToList
            If res.Count = 0 Then
                MessageBox.Show("Error")
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            Else
                Dim RES1 = (From AX In aMainor.TblSettings).ToList
                If RES1.Count > 0 Then
                    'Dim x As New Form1
                    'Dim x As New HeaderForm
                    Dim x As New FormNewHome
                    UserId = res.ToList(0).Id
                    If (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0) IsNot Nothing Then
                        MyEmployeeId = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0)
                    End If
                    'Me.Close()
                    Me.Hide()
                    x.ShowDialog()

                    ' x.Dispose()
                Else
                    Dim X As New FrmSettings
                    X.ShowDialog()
                    If X.SAVED = True Then
                        ' Dim x1 As New Form1
                        ' Dim x1 As New HeaderForm
                        Dim x1 As New FormNewHome
                        UserId = res.ToList(0).Id
                        If (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0) IsNot Nothing Then
                            MyEmployeeId = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0)
                        End If
                        'Me.Close()
                        Me.Hide()
                        x1.ShowDialog()

                    End If

                    X.Dispose()
                End If


                Me.Close()

            End If
        End Using

        'If CheckBoxRemember.Checked Then
        '    My.Settings.Username = UsernameTextBox.Text
        '    My.Settings.Password = PasswordTextBox.Text
        '    My.Settings.Save()
        'End If

    End Sub


    Private Sub PasswordTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown, PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin_Click(Nothing, Nothing)

        End If
    End Sub

    'Private Sub BtNewTemplate_Click(sender As Object, e As EventArgs) Handles BtNewTemplate.Click
    '    Dim x As New Form1
    '    x.ShowDialog()
    '    x.Dispose()
    'End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = My.Settings.FormBackgroundColor
        'lblText.BackColor = My.Settings.PanelColor
        'lblClose.BackColor = My.Settings.PanelColor

        'UsernameTextBox.Text = "Enter Username"
        'UsernameTextBox.ForeColor = Color.Silver

        'PasswordTextBox.Text = "Enter Password"
        'PasswordTextBox.ForeColor = Color.Silver
        'PasswordTextBox.UseSystemPasswordChar = False

        If My.Settings.Username = String.Empty Then
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            CheckBoxRemember.Checked = False
            CheckBoxRemember.CheckState = CheckState.Unchecked
        Else
            UsernameTextBox.Text = My.Settings.Username
            PasswordTextBox.Text = My.Settings.Password
            CheckBoxRemember.Checked = True
            CheckBoxRemember.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub BtOldTemplate_Click(sender As Object, e As EventArgs) Handles BtOldTemplate.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From ax In aMainor.TblUsers Where ax.Username = UsernameTextBox.Text And ax.Password = PasswordTextBox.Text).ToList
            If res.Count = 0 Then
                MessageBox.Show("Error")
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            Else
                Dim RES1 = (From AX In aMainor.TblSettings).ToList
                If RES1.Count > 0 Then
                    Dim x As New FrmHomePage
                    UserId = res.ToList(0).Id
                    If (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0) IsNot Nothing Then
                        MyEmployeeId = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0)
                    End If
                    Me.Close()
                    x.ShowDialog()
                    ' Dim x As New formx
                    'x.Show()
                    ' x.Dispose()
                Else
                    Dim X As New FrmSettings
                    X.ShowDialog()
                    If X.SAVED = True Then
                        Dim x1 As New FrmHomePage
                        UserId = res.ToList(0).Id
                        If (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0) IsNot Nothing Then
                            MyEmployeeId = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.EmployeeId).ToList(0)
                        End If
                        x1.ShowDialog()
                    End If

                    X.Dispose()
                End If


                Me.Close()

            End If
        End Using
    End Sub

    'Private Sub UsernameTextBox_Enter(sender As Object, e As EventArgs) Handles UsernameTextBox.Enter
    '    If UsernameTextBox.Text = "Enter Username" Then
    '        UsernameTextBox.Text = ""
    '        UsernameTextBox.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
    '    If UsernameTextBox.Text = "" Then
    '        UsernameTextBox.Text = "Enter Username"
    '        UsernameTextBox.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Enter
    '    If PasswordTextBox.Text = "Enter Password" Then
    '        PasswordTextBox.Text = ""
    '        PasswordTextBox.ForeColor = Color.Black
    '        PasswordTextBox.UseSystemPasswordChar = True
    '    End If
    'End Sub

    'Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
    '    If PasswordTextBox.Text = "" Then
    '        PasswordTextBox.Text = "Enter Password"
    '        PasswordTextBox.ForeColor = Color.Silver
    '        PasswordTextBox.UseSystemPasswordChar = False
    '    End If
    'End Sub

    Private Sub BtShowHidePass_Click(sender As Object, e As EventArgs) Handles BtShowHidePass.Click
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBoxRemember_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRemember.CheckedChanged
        If CheckBoxRemember.Checked = True Then
            My.Settings.Username = UsernameTextBox.Text
            My.Settings.Password = PasswordTextBox.Text
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.Username = ""
            My.Settings.Password = ""
            My.Settings.Save()
            My.Settings.Reload()
        End If

    End Sub

    'Private Sub BtMinimize_Click(sender As Object, e As EventArgs) Handles BtMinimize.Click
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub
End Class