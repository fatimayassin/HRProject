Public Class FrmStickyNote
    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Me.Close()
    End Sub

    Private Sub FrmStickyNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RichTextBox1.Text = My.Settings.Note

        PanelOFColors.Visible = False

        'If Panel1.BackColor = My.Settings.YellowStickyNote Then

        '    Panel1.BackColor = My.Settings.YellowStickyNote
        '    Panel2.BackColor = My.Settings.YellowLightStickyNote
        '    PanelForUCNote.BackColor = My.Settings.YellowLightStickyNote
        '    RichTextBox1.BackColor = My.Settings.YellowLightStickyNote

        'ElseIf Panel1.BackColor = My.Settings.GreenStickyNote Then
        '    Panel1.BackColor = My.Settings.GreenStickyNote
        '    Panel2.BackColor = My.Settings.GreenLightStickyNote
        '    PanelForUCNote.BackColor = My.Settings.GreenLightStickyNote
        '    RichTextBox1.BackColor = My.Settings.GreenLightStickyNote

        'ElseIf Panel1.BackColor = My.Settings.BlueStickyNote Then
        '    Panel1.BackColor = My.Settings.BlueStickyNote
        '    Panel2.BackColor = My.Settings.BlueLightStickyNote
        '    PanelForUCNote.BackColor = My.Settings.BlueLightStickyNote
        '    RichTextBox1.BackColor = My.Settings.BlueLightStickyNote

        'ElseIf Panel1.BackColor = My.Settings.BlueStickyNote Then
        '    Panel1.BackColor = My.Settings.PinkStickyNote
        '    Panel2.BackColor = My.Settings.PinkLightStickyNote
        '    PanelForUCNote.BackColor = My.Settings.PinkLightStickyNote
        '    RichTextBox1.BackColor = My.Settings.PinkLightStickyNote

        'End If

        RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None

    End Sub

    Private Sub BtMoreColors_Click(sender As Object, e As EventArgs) Handles BtMoreColors.Click
        If PanelOFColors.Visible = False Then
            PanelOFColors.Visible = True
        Else
            PanelOFColors.Visible = False
        End If
    End Sub

    Private Sub BtYellow_Click(sender As Object, e As EventArgs) Handles BtYellow.Click
        Panel1.BackColor = My.Settings.YellowStickyNote
        Panel2.BackColor = My.Settings.YellowLightStickyNote
        PanelForUCNote.BackColor = My.Settings.YellowLightStickyNote
        RichTextBox1.BackColor = My.Settings.YellowLightStickyNote

        My.Settings.YellowStickyNote = Panel1.BackColor
        My.Settings.Save()
    End Sub

    Private Sub BtGreen_Click(sender As Object, e As EventArgs) Handles BtGreen.Click
        Panel1.BackColor = My.Settings.GreenStickyNote
        Panel2.BackColor = My.Settings.GreenLightStickyNote
        PanelForUCNote.BackColor = My.Settings.GreenLightStickyNote
        RichTextBox1.BackColor = My.Settings.GreenLightStickyNote

        My.Settings.GreenStickyNote = Panel1.BackColor
        My.Settings.Save()
    End Sub

    Private Sub BtBlue_Click(sender As Object, e As EventArgs) Handles BtBlue.Click
        Panel1.BackColor = My.Settings.BlueStickyNote
        Panel2.BackColor = My.Settings.BlueLightStickyNote
        PanelForUCNote.BackColor = My.Settings.BlueLightStickyNote
        RichTextBox1.BackColor = My.Settings.BlueLightStickyNote

        My.Settings.BlueStickyNote = Panel1.BackColor
        My.Settings.Save()
    End Sub

    Private Sub BtPink_Click(sender As Object, e As EventArgs) Handles BtPink.Click
        Panel1.BackColor = My.Settings.PinkStickyNote
        Panel2.BackColor = My.Settings.PinkLightStickyNote
        PanelForUCNote.BackColor = My.Settings.PinkLightStickyNote
        RichTextBox1.BackColor = My.Settings.PinkLightStickyNote

        My.Settings.PinkStickyNote = Panel1.BackColor
        My.Settings.Save()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        My.Settings.Note = RichTextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub BtBold_Click(sender As Object, e As EventArgs) Handles BtBold.Click
        If RichTextBox1.SelectionFont.Bold Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Regular)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Bold)
        End If

    End Sub

    Private Sub BtItalic_Click(sender As Object, e As EventArgs) Handles BtItalic.Click
        If RichTextBox1.SelectionFont.Italic Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Regular)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Italic)
        End If

    End Sub

    Private Sub BtUnderline_Click(sender As Object, e As EventArgs) Handles BtUnderline.Click
        If RichTextBox1.SelectionFont.Underline Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Regular)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Underline)
        End If

    End Sub

    Private Sub BtStrikeThrough_Click(sender As Object, e As EventArgs) Handles BtStrikeThrough.Click
        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Regular)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Strikeout)
        End If

    End Sub

    Private Sub BtBullets_Click(sender As Object, e As EventArgs) Handles BtBullets.Click
        RichTextBox1.SelectedText = "• " & RichTextBox1.SelectedText
    End Sub

    Private Sub BtFontSize_Click(sender As Object, e As EventArgs) Handles BtFontSize.Click

        Dim fd As FontDialog = New FontDialog()

        If fd.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = fd.Font
        End If

    End Sub

    Private Sub BtFontColor_Click(sender As Object, e As EventArgs) Handles BtFontColor.Click

        Dim col As ColorDialog = New ColorDialog()

        If col.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = col.Color
        End If
    End Sub
End Class