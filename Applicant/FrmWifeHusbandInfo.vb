Public Class FrmWifeHusbandInfo
    Dim EmployeeId As Integer = 0
    Public Id As Integer = 0
    Public ApplicantId As Integer = 0
    Public AppId As Integer = 0
    Public first As Boolean = True
    Public current As New TblWifeHusband
    Public ForEdit As Boolean = False
    Public Saved As Boolean = False


    Private Sub lblClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmWifeHusbandInfo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        If Not ForEdit Then
            If Id = 0 Then
                NSSFSideComboBox.Visible = True
                TblWifeHusbandBindingSource.DataSource = New TblWifeHusband
                Me.InCompanyCheckBox.CheckState = 0

            End If
        Else

            TblWifeHusbandBindingSource.DataSource = current
            NSSFSideComboBox.SelectedItem = current.NSSFSide
            MaritalStatusComboBox.SelectedItem = current.MaritalStatus


        End If
        first = False

    End Sub

    Private Sub InCompanyCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles InCompanyCheckBox.CheckedChanged
        If first = False Then

            If InCompanyCheckBox.Checked = True Then
                Dim x As New FrmEmployeeList
                x.SelectRelativeReference = True
                x.statusId = EmployeeStatusId
                x.ShowDialog()
                If x.Saved Then

                    Using aMainor As New LqHRDataContext(cnx)
                        '    returnedId = x.WifeHusbandApplicatId
                        AppId = x.appId
                        EmployeeId = x.EmpId
                        TblWifeHusbandBindingSource.Current.incompany = True
                        NSSFSideComboBox.Visible = False
                        Label1.Visible = False
                        Dim res = (From ax In aMainor.TblApplicants Where ax.Id = AppId).ToList(0)
                        TblWifeHusbandBindingSource.Current.FirstName = res.FirstName
                        TblWifeHusbandBindingSource.Current.LastName = res.LastName


                        Dim res1 = (From ax In aMainor.TblEmployeeJobs Where ax.EmployeeId = EmployeeId).ToList()
                        If res1.Count > 0 Then
                            Dim job = res1.ToList(0).JobId
                            Dim jobName = (From ax In aMainor.TblJobDescriptions Where ax.Id = job Select ax.Name).ToList(0)
                            TblWifeHusbandBindingSource.Current.job = jobName
                        End If


                        TblWifeHusbandBindingSource.Current.NSSFSide = "Company"
                        TblWifeHusbandBindingSource.Current.isNSSF = True
                        TblWifeHusbandBindingSource.Current.WifeHusbandEmployeeId = EmployeeId

                    End Using
                End If


            Else
                first = True
                NSSFSideComboBox.Visible = True
                Label1.Visible = True
                TblWifeHusbandBindingSource.Current.FirstName = ""
                TblWifeHusbandBindingSource.Current.lastName = ""
                TblWifeHusbandBindingSource.Current.job = ""
                TblWifeHusbandBindingSource.Current.incompany = False
                TblWifeHusbandBindingSource.Current.isNSSF = False
                TblWifeHusbandBindingSource.Current.NSSFSide = ""
                TblWifeHusbandBindingSource.Current.maritalStatus = ""
                first = False
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or JobTextBox.Text = "" Then
            MessageBox.Show("missing info", "warning", MessageBoxButtons.OK)
        Else
            Using aMainor As New LqHRDataContext(cnx)
                'If Id = 0 Then
                '    If Not returnedId = 0 Then
                '        TblWifeHusbandBindingSource.Current.ApplicantId = ApplicantId
                '        TblWifeHusbandBindingSource.Current.WifeHusbandId = returnedId
                '        aMainOr.TblWifeHusbands.InsertOnSubmit(TblWifeHusbandBindingSource.Current)
                '        aMainOr.SubmitChanges()


                '    Else
                '        TblWifeHusbandBindingSource.Current.ApplicantId = ApplicantId
                '        If NSSFSideComboBox.Text = "None" Then
                '            TblWifeHusbandBindingSource.Current.isNSSF = False
                '        Else
                '            TblWifeHusbandBindingSource.Current.isNSSF = True
                '            TblWifeHusbandBindingSource.Current.incompany = False
                '            aMainOr.TblWifeHusbands.InsertOnSubmit(TblWifeHusbandBindingSource.Current)
                '            aMainOr.SubmitChanges()

                '        End If

                '    End If
                'Else
                '    If Not returnedId = 0 Then
                '        Dim Old = (From aX In aMainOr.TblWifeHusbands Where aX.Id = Id).ToList(0)
                '        Dim newT As TblWifeHusband = TblWifeHusbandBindingSource.Current
                '        Old.FirstName = newT.FirstName
                '        Old.LastName = newT.LastName
                '        Old.Job = newT.Job
                '        newT.IsNSSF = True
                '        Old.IsNSSF = newT.IsNSSF
                '        Old.NSSFSide = newT.NSSFSide
                '        Old.InCompany = newT.InCompany
                '        Old.WifeHusbandId = returnedId

                '        aMainOr.SubmitChanges()
                '    Else
                '        Dim Old = (From aX In aMainOr.TblWifeHusbands Where aX.Id = Id).ToList(0)
                '        Dim newT As TblWifeHusband = TblWifeHusbandBindingSource.Current
                '        Old.FirstName = newT.FirstName
                '        Old.LastName = newT.LastName
                '        Old.Job = newT.Job
                '        If NSSFSideComboBox.Text = "None" Then

                '            newT.IsNSSF = False
                '            Old.IsNSSF = newT.IsNSSF
                '        Else
                '            newT.IsNSSF = True
                '            Old.IsNSSF = newT.IsNSSF
                '        End If
                '        newT.WifeHusbandId = Nothing
                '        Old.WifeHusbandId = newT.WifeHusbandId

                '        Old.InCompany = newT.InCompany

                '        Old.NSSFSide = newT.NSSFSide
                '        aMainOr.SubmitChanges()
                '    End If

                ' End If
                TblWifeHusbandBindingSource.Current.maritalStatus = MaritalStatusComboBox.SelectedItem
                If Not InCompanyCheckBox.Checked = True Then
                    TblWifeHusbandBindingSource.Current.nssfSide = NSSFSideComboBox.SelectedItem
                End If
                If NSSFSideComboBox.SelectedItem = "None" Then
                    TblWifeHusbandBindingSource.Current.isNssf = 0
                Else
                    TblWifeHusbandBindingSource.Current.isNssf = 1
                End If

                current = TblWifeHusbandBindingSource.Current
                Saved = True
                Me.Close()

            End Using
        End If
    End Sub


End Class