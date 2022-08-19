Public Class FrmApplicantList
    Public id As Integer = 0
    Public statusId As Integer = 0
    Public saved As Boolean = False
    Public empName As String = ""
    Public RowIndex As Integer = 0
    Public counter As Integer = 0

    Private Sub FrmApplicantList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        AgeComboBox.SelectedIndex = 0
        FirstNameTextBox.Text = empName

        Filter()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If counter >= 4 Then
            Timer1.Stop()
            Filter()
            counter = 0
        End If
    End Sub

    Sub refrsh()
        counter = 0
        Timer1.Start()
    End Sub

    Private Sub FirstNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaritalStatusComboBox.TextChanged, GenderComboBox.TextChanged, FirstNameTextBox.TextChanged, AgeComboBox.TextChanged
        refrsh()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub



    Sub Filter()
        Using aMainor As New LqHRDataContext(cnx)
            Dim ageDate As Date = New Date(Date.Now.Year - AgeComboBox.SelectedItem, 12, 31)
            Filter_ApplicantListResultBindingSource.DataSource = (From ax In aMainor.Filter_ApplicantList(FirstNameTextBox.Text, ageDate, GenderComboBox.SelectedItem, MaritalStatusComboBox.SelectedItem) Where ax.StatusId = statusId Order By ax.Id).ToList
        End Using
        ScrollBar1()
        Label1.Text = Filter_ApplicantListResultBindingSource.Count
    End Sub



    Sub ScrollBar1()
        For Each c In Filter_ApplicantListResultDataGridView.Controls
            If c.GetType() Is GetType(VScrollBar) Then
                Dim vbar As VScrollBar = DirectCast(c, VScrollBar)
                If vbar.Visible = True Then
                    TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, vbar.Width))
                    TableLayoutPanel1.ColumnCount = 8
                Else
                    Try
                        TableLayoutPanel1.ColumnStyles.RemoveAt(7)
                        TableLayoutPanel1.ColumnCount = 7
                    Catch ex As Exception

                    End Try
                End If

            End If
        Next
    End Sub

    Private Sub Filter_ApplicantListResultDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Filter_ApplicantListResultDataGridView.CellDoubleClick
        id = Filter_ApplicantListResultBindingSource.Current.id
        RowIndex = Filter_ApplicantListResultDataGridView.CurrentRow.Index

        saved = True
        Me.Close()
    End Sub
End Class