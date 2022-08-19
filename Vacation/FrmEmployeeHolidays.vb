Public Class FrmEmployeeHolidays
    Public EmployeeId As Integer = 0
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub

    Private Sub FrmEmployeeHolidays_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)
            TblHolidayBindingSource.DataSource = aMainor.TblHolidays.ToList
            TblEmployeeHolidayBindingSource.DataSource = (From ax In aMainor.TblEmployeeHolidays Where ax.EmployeeId = EmployeeId).ToList

        End Using
    End Sub
End Class