Public Class frmAfterAssignYearlyVacToEmployee

    Private Sub frmAfterAssignYearlyVacToEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            TblEmployeeBindingSource.DataSource = aMainor.TblEmployees.ToList
            TblVacationBindingSource.DataSource = aMainor.TblVacations.ToList
            AssignYearlyVacationsToEmployeeResultBindingSource.DataSource = aMainor.AssignYearlyVacationsToEmployee(Date.Now).ToList
        End Using
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub
End Class