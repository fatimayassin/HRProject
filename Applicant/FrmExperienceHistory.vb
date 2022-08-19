Public Class FrmExperienceHistory
    Public dob As Date

    Public ApplicantId As Integer = 0
    Public id As Integer = 0
    Public saved As Boolean = False
    Public current As TblExperienceHistory
    Public ForEdit As Boolean = False

    Private Sub FrmExperienceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            If Not dob.Date = Date.Now.Date Then
                StartDateDateTimePicker.MinDate = dob
                StartDateDateTimePicker.MaxDate = Date.Now
                LeaveDateDateTimePicker.MinDate = dob
            End If
            TblPositionBindingSource.DataSource = aMainor.TblPositions.ToList
            TblCurrencyBindingSource.DataSource = aMainor.TblCurrencies.ToList

            If Not ForEdit Then
                If id = 0 Then
                    LeavingInfoGroupBox.Enabled = True
                    ScheduleNoteGroupBox.Enabled = False
                    NSSFGroupBox.Enabled = False
                    CanBeLeaveGroupBox.Enabled = False
                    TblExperienceHistoryBindingSource.DataSource = New TblExperienceHistory
                    TblExperienceHistoryBindingSource.Current.IsNSSF = False
                    TblExperienceHistoryBindingSource.Current.canBeLeave = False
                    TblExperienceHistoryBindingSource.Current.stillWorking = False

                End If
            Else
                TblExperienceHistoryBindingSource.DataSource = current

            End If


        End Using

    End Sub

    Sub check()
        If IsNSSFCheckBox.Checked = True Then
            NSSFGroupBox.Enabled = True
        Else
            NSSFGroupBox.Enabled = False

        End If
        If StillWorkingCheckBox.Checked = True Then
            CanBeLeaveGroupBox.Enabled = True
            LeavingInfoGroupBox.Enabled = False
            ScheduleNoteGroupBox.Enabled = True

        Else
            ScheduleNoteGroupBox.Enabled = False
            CanBeLeaveGroupBox.Enabled = False
            LeavingInfoGroupBox.Enabled = True
            CanBeLeaveCheckBox.Checked = False

        End If
        If CanBeLeaveCheckBox.Checked = True Then
            ScheduleNoteGroupBox.Enabled = False
            LeavingInfoGroupBox.Enabled = True

        Else
            LeavingInfoGroupBox.Enabled = False
            If StillWorkingCheckBox.Checked = True Then
                ScheduleNoteGroupBox.Enabled = True

            Else
                ScheduleNoteGroupBox.Enabled = False
            End If
        End If
    End Sub

    Private Sub IsNSSFCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles IsNSSFCheckBox.CheckedChanged
        If IsNSSFCheckBox.Checked Then
            NSSFGroupBox.Enabled = True
        Else
            NSSFGroupBox.Enabled = False
            NSSFNumberTextBox.Text = ""
            NSSFSideComboBox.Text = ""
        End If
    End Sub

    Private Sub StillWorkingCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles StillWorkingCheckBox.CheckedChanged
        If StillWorkingCheckBox.Checked = True Then
            CanBeLeaveGroupBox.Enabled = True
            LeavingInfoGroupBox.Enabled = False
            ScheduleNoteGroupBox.Enabled = True
            LeaveDateDateTimePicker.Text = ""
            LeaveReasonTextBox.Text = ""
        Else
            ScheduleNoteGroupBox.Enabled = False
            CanBeLeaveGroupBox.Enabled = False
            LeavingInfoGroupBox.Enabled = True
            CanBeLeaveCheckBox.Checked = False
            ScheduleNoteTextBox.Text = ""

        End If
    End Sub

    Private Sub CanBeLeaveCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CanBeLeaveCheckBox.CheckedChanged
        If CanBeLeaveCheckBox.Checked = True Then
            LeavingInfoGroupBox.Enabled = True
            'ScheduleNoteGroupBox.Enabled = False
            ScheduleNoteTextBox.Text = ""
        Else
            LeavingInfoGroupBox.Enabled = False
            'ScheduleNoteGroupBox.Enabled = True
            LeaveDateDateTimePicker.Text = ""
            LeaveReasonTextBox.Text = ""

        End If
    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            If CompanyNameTextBox.Text = "" Or StartDateDateTimePicker.Text = "" Then
                MessageBox.Show("missing information!", "warning", MessageBoxButtons.OK)
            Else

                'If StartDateDateTimePicker.Value < LeaveDateDateTimePicker.Value Then
                '    MessageBox.Show("enter a valid date!", "warning", MessageBoxButtons.OK)
                'Else
                current = TblExperienceHistoryBindingSource.Current
                saved = True
                Me.Close()
            End If
            'End If
        End Using
    End Sub



    'Private Sub LeaveDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveDateDateTimePicker.ValueChanged
    '    If StartDateDateTimePicker.Value < LeaveDateDateTimePicker.Value Then
    '        MessageBox.Show("Enter a valid date")
    '    End If
    'End Sub
End Class