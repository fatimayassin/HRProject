Public Class FrmPanels
    Private Sub FrmPanels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.OutlookNavigationPane

        Me.UltraExplorerBar1.NavigationPaneExpansionMode = Infragistics.Win.UltraWinExplorerBar.NavigationPaneExpansionMode.OnButtonClickOrSizeChanged
    End Sub

    Private Sub UltraExplorerBar1_ItemClick(sender As Object, e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles UltraExplorerBar1.ItemClick
        Select Case e.Item.Tag.ToString()
            Case "Sign In Account"
                PublicContainerPanel = Panel1
                MyOpenForm(FrmSignInAccount)
                'Dim x As Form3 = New Form3()
                'x.ShowDialog()
            Case "Compose Mail"
                PublicContainerPanel = Panel1
                MyOpenForm(FrmComposeMail)
            Case "All Mails"
                If FrmSignInAccount.tbhostname.Text = "Other" Then
                    ' Dim x As FrmOtherMail = New FrmOtherMail()
                    If FrmSignInAccount.attachemtnSaveDirectory.Text = Nothing Then
                        MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
                    Else
                        PublicContainerPanel = Panel1
                        MyOpenForm(FrmOtherMail)
                        ' x.ShowDialog()
                    End If
                Else
                    ' Dim x As FrmMail = New FrmMail()
                    If FrmSignInAccount.attachemtnSaveDirectory.Text = Nothing Then
                        MessageBox.Show("Please Select a Directory First To Add Mail Attachments")
                    Else
                        '   x.ShowDialog()
                        PublicContainerPanel = Panel1
                        MyOpenForm(FrmMail)
                    End If
                End If
            Case "New Note"
                Dim x As FrmNewNote = New FrmNewNote()
                x.ShowDialog()
        End Select
    End Sub

    Private Sub UltraExplorerBar1_GroupClick(sender As Object, e As Infragistics.Win.UltraWinExplorerBar.GroupEventArgs) Handles UltraExplorerBar1.GroupClick

        Select Case e.Group.Tag.ToString()
            Case "Mail"

            Case "Calendar"
                PublicContainerPanel = Panel1
                MyOpenForm(FrmCalendarOfEventsNAppointments)
            Case "Tasks"
                PublicContainerPanel = Panel1
                ' MyOpenForm(FrmGanttTasks)
                MyOpenForm(Form3)
            Case "Contacts"
                PublicContainerPanel = Panel1
                MyOpenForm(FrmContacts)
            Case "Notes"
                PublicContainerPanel = Panel1
                MyOpenForm(FrmNotesList)
                'MyOpenForm(Form5)
        End Select
    End Sub

End Class