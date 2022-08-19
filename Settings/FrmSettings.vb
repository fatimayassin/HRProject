Imports System.IO
Public Class FrmSettings
    Public id As Integer = 0
    Public SAVED As Boolean = False
    Public cansave As Boolean = False
    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            RefreshStatus()
            refreshVac()
            refreshPositions()

            TblStatusBindingSource.Insert(0, New TblStatus)
            TblStatusBindingSource1.Insert(0, New TblStatus)
            TblStatusBindingSource2.Insert(0, New TblStatus)
            TblStatusBindingSource3.Insert(0, New TblStatus)
            TblStatusBindingSource4.Insert(0, New TblStatus)
            TblVacationBindingSource.Insert(0, New TblVacation)
            TblPositionBindingSource.Insert(0, New TblPosition)
            'TblVacationTypeBindingSource1.Insert(0, New TblVacationType)
            Dim res = aMainor.TblSettings.ToList
            If res.Count = 0 Then
                id = 0
                TblSettingBindingSource.DataSource = New TblSetting
            Else
                id = res.ToList(0).Id
                TblSettingBindingSource.DataSource = aMainor.TblSettings.ToList(0)
                Dim b As Byte() = res.ToList(0).DefaultImage.ToArray()
                Dim ms As New IO.MemoryStream(b)
                Dim img As Image = Image.FromStream(ms)

                PBApplicantImage.Image = img
                cansave = True
            End If
        End Using
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If cansave Then
            Using aMainor As New LqHRDataContext(cnx)
                If id = 0 Then
                    aMainor.TblSettings.InsertOnSubmit(TblSettingBindingSource.Current)
                    aMainor.SubmitChanges()

                Else
                    Dim oldrow As TblSetting = (From ax In aMainor.TblSettings Where ax.Id = id).ToList(0)
                    Dim newRow As TblSetting = TblSettingBindingSource.Current
                    oldrow.ApplicantStatusId = newRow.ApplicantStatusId
                    oldrow.EmployeeStatusId = newRow.EmployeeStatusId
                    oldrow.TraineeStatutsId = newRow.TraineeStatutsId
                    oldrow.RetiredStatusId = newRow.RetiredStatusId
                    oldrow.UnemploymentStatusId = newRow.UnemploymentStatusId
                    oldrow.HolidayTypeId = newRow.HolidayTypeId
                    oldrow.YearlyVacationId = newRow.YearlyVacationId
                    oldrow.TraineePositionId = newRow.TraineePositionId
                    oldrow.DefaultImage = newRow.DefaultImage
                    aMainor.SubmitChanges()

                End If

                Dim res As TblSetting = TblSettingBindingSource.Current
                ApplicantStatusId = res.ApplicantStatusId
                EmployeeStatusId = res.EmployeeStatusId
                TraineeStatusId = res.TraineeStatutsId
                RetiredStatusId = res.RetiredStatusId
                UnemploymentStatusId = res.UnemploymentStatusId
                'ImagePath = res.DefaultImage
                'HolidayTypeId = res.HolidayTypeId
                YearlyVacationId = res.YearlyVacationId
                traineePositionId = res.TraineePositionId
            End Using
            SAVED = True
            Me.Close()
        Else
MessageBox.Show("enter a default image")
        End If
 
    End Sub

    Private Sub ApplicantStatusIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ApplicantStatusIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmStatusList
            x.ShowDialog()
            If x.saved Then
                RefreshStatus()
            End If
            x.Dispose()
        End If
    End Sub
    Sub RefreshStatus()
        Using aMainor As New LqHRDataContext(cnx)
            TblStatusBindingSource.DataSource = aMainor.TblStatus.ToList
            TblStatusBindingSource1.DataSource = aMainor.TblStatus.ToList
            TblStatusBindingSource2.DataSource = aMainor.TblStatus.ToList
            TblStatusBindingSource3.DataSource = aMainor.TblStatus.ToList
            TblStatusBindingSource4.DataSource = aMainor.TblStatus.ToList
        End Using

    End Sub
    Sub refreshPositions()
        Using aMainor As New LqHRDataContext(cnx)
            TblPositionBindingSource.DataSource = aMainor.TblPositions.ToList
        End Using
    End Sub

    Sub refreshVac()
        Using aMainor As New LqHRDataContext(cnx)
            TblVacationBindingSource.DataSource = aMainor.TblVacations.ToList
            '    TblVacationTypeBindingSource1.DataSource = aMainor.TblVacationTypes.ToList
        End Using

    End Sub

    Private Sub TraineeStatutsIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TraineeStatutsIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmStatusList
            x.ShowDialog()
            If x.saved Then
                RefreshStatus()
            End If
            x.Dispose()
        End If
    End Sub

    Private Sub EmployeeStatusIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmployeeStatusIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmStatusList
            x.ShowDialog()
            If x.saved Then
                RefreshStatus()

            End If
            x.Dispose()
        End If
    End Sub

    Private Sub RetiredStatusIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RetiredStatusIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmStatusList
            x.ShowDialog()
            If x.saved Then
                RefreshStatus()
            End If

            x.Dispose()
        End If
    End Sub

    Private Sub YearlyVacationTypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles YearlyVacationTypeIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmVacations
            x.ShowDialog()
            If x.saved Then
                refreshVac()

            End If

            x.Dispose()
        End If
    End Sub

    Private Sub HolidayTypeIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.F2 Then
        '    Dim X As New FrmPersonalVacType
        '    X.ShowDialog()
        '    If X.saved Then
        '        Using aMainor As New LqHRDataContext(cnx)
        '            RefreshVac()
        '        End Using

        '    End If

        '    X.Dispose()
        'End If
    End Sub

    Private Sub TraineePositionIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TraineePositionIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmPositionList
            x.ShowDialog()
            If x.saved Then
                refreshPositions()
            End If
            x.Dispose()
        End If
    End Sub

    Private Sub PBApplicantImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBApplicantImage.Click
        AddAttachment("Photography")

        If Not OpenFileDialog1.FileName = "OpenFileDialog1" And Not OpenFileDialog1.FileName = String.Empty Then
            Dim image As Image = image.FromFile(OpenFileDialog1.FileName)
            PBApplicantImage.Image = image
        End If
    End Sub
    Sub AddAttachment(ByVal type As String)

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'PBApplicantImage.Image = Image.FromFile(OpenFileDialog1.FileName)

            If Not OpenFileDialog1.FileName = String.Empty Then
                Dim fi As New FileInfo(OpenFileDialog1.FileName)
                Dim fr As Stream = fi.OpenRead
                Dim nbytes As Integer = fi.Length
                Dim bytearray(nbytes) As Byte
                fr.Read(bytearray, 0, nbytes)
                fr.Close()

                'TblAttachmentBindingSource.Current.attachmment = bytearray
                ' If EditAttachachment Then
                TblSettingBindingSource.Current.defaultimage = bytearray
                If type = "Photography" Then
                    PBApplicantImage.Image = Image.FromFile(OpenFileDialog1.FileName)
                    CanSave = True
                End If

                '  End If




            End If

        End If
    End Sub

    Private Sub UnemploymentStatusIdComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UnemploymentStatusIdComboBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim x As New FrmStatusList
            x.ShowDialog()
            If x.saved Then
                RefreshStatus()

            End If
            x.Dispose()
        End If
    End Sub


End Class