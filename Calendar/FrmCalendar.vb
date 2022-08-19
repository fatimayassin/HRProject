Imports System.IO

Public Class FrmCalendar
    'Private currentDate As DateTime = DateTime.Today
    Dim m As MsgBoxResult
    Dim t As String

    Private Sub FrmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        Panel1.BackColor = My.Settings.PanelColor
        Panel2.BackColor = My.Settings.PanelColor
        Label2.BackColor = My.Settings.PanelColor
        BtSave.BackColor = My.Settings.PanelColor

        Dim m1 As MsgBoxResult

        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        If File.Exists(t & ".txt") = True Then
            Label2.Text = "Date:" + "  " + MonthCalendar1.SelectionStart + Environment.NewLine + "Event Title:" + "  " + File.ReadAllText(t & ".txt")
            Label2.Location = New Point(36, 215)
            Label2.Show()
            TextBox1.Enabled = False
            TextBox1.Hide()
            BtSave.Enabled = False
            BtSave.Hide()
        End If



        'If Date.Today = MonthCalendar1.TodayDate And File.Exists(t & ".txt") = True Then
        '    m1 = MsgBox("You Have Events Set On This Day. Would You Like To View Them?", MsgBoxStyle.YesNo)
        '    If m1 = MsgBoxResult.Yes Then
        '        'MonthCalendar1.Enabled = False
        '        ' MonthCalendar1.Hide()
        '        TextBox1.Enabled = False
        '        TextBox1.Hide()
        '        'BtBack.Enabled = True
        '        'BtBack.Show()
        '        BtSave.Enabled = True
        '        BtSave.Show()
        '        Label2.Show()
        '        Label2.Location = New Point(32, 212)
        '        'TextBox1.Text = File.ReadAllText(t & ".txt")
        '    End If
        'End If
    End Sub



    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        'TextBox1.Visible = True

        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        Try
            If File.Exists(t & ".txt") = True Then
                'MonthCalendar1.Enabled = False
                ' MonthCalendar1.Hide()
                TextBox1.Enabled = False
                TextBox1.Hide()
                'BtBack.Enabled = True
                'BtBack.Show()
                BtSave.Enabled = False
                BtSave.Hide()
                Label2.Show()
                Label2.Location = New Point(36, 215)
                Label2.Text = "Date:" + "  " + MonthCalendar1.SelectionStart + Environment.NewLine + "Event Title:" + "  " + File.ReadAllText(t & ".txt")
                'TextBox1.Text = File.ReadAllText(t & ".txt")
            Else
                m = MsgBox("Would You Like To Enter An Event For This Date?", MsgBoxStyle.YesNo)
                If m = MsgBoxResult.Yes Then
                    'MonthCalendar1.Enabled = False
                    ' MonthCalendar1.Hide()
                    Label2.Hide()
                    TextBox1.Text = " "
                    TextBox1.Enabled = True
                    TextBox1.Show()
                    TextBox1.Height = 50
                    'BtBack.Enabled = True
                    'BtBack.Show()
                    BtSave.Enabled = True
                    BtSave.Show()
                Else
                    Label2.Show()
                    Label2.Text = " "
                    TextBox1.Enabled = False
                    TextBox1.Hide()
                    BtSave.Enabled = False
                    BtSave.Hide()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub BtBack_Click(sender As Object, e As EventArgs) Handles BtBack.Click
    '    MonthCalendar1.Enabled = t
    '    'MonthCalendar1.Show()
    '    TextBox1.Enabled = False
    '    TextBox1.Hide()
    '    BtBack.Enabled = False
    '    BtBack.Hide()
    '    BtSave.Enabled = False
    '    BtSave.Hide()
    'End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Try
            If TextBox1.Text = " " Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                End If
            End If
            If TextBox1.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TextBox1.Text)
                TextBox1.Text = " "
                TextBox1.Enabled = False
                TextBox1.Hide()
                MsgBox("Event is Saved", MsgBoxStyle.OkOnly)
                BtSave.Enabled = False
                BtSave.Hide()
                Label2.Show()
                Label2.Location = New Point(32, 212)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If File.Exists(t & ".txt") = True Then
            m = MsgBox("Delete This Event?", MsgBoxStyle.YesNo)
            If m = MsgBoxResult.Yes Then
                File.Delete(t & ".txt")
                MsgBox("Event is Removed", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If File.Exists(t & ".txt") = True Then
            'File.OpenText(t & ".txt")
            'TextBox1.Text = t & ".txt"
            TextBox1.Enabled = True
            TextBox1.Show()
            TextBox1.Text = File.ReadAllText(t & ".txt")

            Label2.Hide()
            BtSave.Enabled = True
            BtSave.Show()
            File.WriteAllText(t & ".txt", TextBox1.Text)
            TextBox1.Text = " "
            'MsgBox("Event is Edited", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class