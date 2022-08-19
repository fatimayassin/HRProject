Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinTabs
Imports Infragistics.Win.UltraWinRadialMenu


Public Class FrmNewNote

    Private _richTextEditor As RichTextBox
    Private _toolsFontStyle As FontStyle
    Private _boldIsChecked As Boolean
    Private _underlineIsChecked As Boolean
    Private _italicIsChecked As Boolean
    Private _imagePath As String = Application.ExecutablePath & "\\..\\..\\..\\..\\Images\\"
    Private ImageSuffix As String = ".png"

    Public ID As Integer
    Public s As String

    'Public Sub New(tag As Object)
    '    Me.Tag = tag
    'End Sub

    Private Sub FrmNewNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltraRadialMenu1.ImageTransparentColor = Color.Magenta
        ' Save the RadialMenu's initial settings in case of the user request to reset.
        SaveRadialManuInitialSettings()
        ShowRadialMenu()

        AddHandler RichTextBox1.SelectionChanged, AddressOf RichTextEditorSelectionChanged
    End Sub

    Public Sub ShowRadialMenu()
        UltraRadialMenu1.Show(Me, New Point(Bounds.Right, Bounds.Top))
    End Sub

    Private Sub RichTextEditorSelectionChanged(sender As Object, e As EventArgs)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        ' Evaluate the font size synchronizing with the selected text. 
        EvaluateFontSize()

        ' Reload the FontList tool with valid fonts.
        RemoveInvalidFonts()

        ' Reset the Font tools' "Checked" properties based on a selected text in RichTextBox.
        If RichTextBox1.SelectedText.Length > 0 Then
            ReevaluateFontTools()
        End If

    End Sub

    Private Sub UltraRadialMenu1ToolClick(sender As Object, e As RadialMenuToolClickEventArgs) Handles UltraRadialMenu1.ToolClick
        Dim key = e.Tool.Key

        Select Case key
            Case "FontColor", "HighlightColor", "FillColor"
                ' Clicking directly on a color category expands the child colors and no further action is needed.
                Return
        End Select

        Dim colorWellTool = TryCast(e.Tool, RadialMenuColorWellTool)
        If colorWellTool IsNot Nothing Then
            ' If the tool is a color well, then we need to change either the BackColor or ForeColor, depending on the
            ' selected ancestor color tool. The color well itself is not important, it's the category it resides under is important. 
            ' So find the ansector color tool and process the click as though that tool were clicked. 
            Dim colorCategoryTool = TryCast(colorWellTool.FindAncestor(GetType(RadialMenuColorTool)), RadialMenuColorTool)
            If colorCategoryTool IsNot Nothing Then
                ProcessToolClick(colorCategoryTool)
                Return
            End If
        End If

        ProcessToolClick(e.Tool)
    End Sub

    Private Sub UltraRadialMenu1ToolCheckedChanged(sender As System.Object, e As Infragistics.Win.UltraWinRadialMenu.RadialMenuToolCheckedChangedEventArgs) Handles UltraRadialMenu1.ToolCheckedChanged
        Select Case e.Tool.Key
            Case "Bold"
                If True Then
                    ' There are two bold tools, one parent and one child. Keep them in synch.
                    '
                    ' First, check to see if this tool's parent is the "Bold" tool. 
                    Dim boldTool As RadialMenuTool = e.Tool.ParentTool
                    If boldTool.Key = "Bold" Then
                        boldTool.Checked = e.Tool.Checked
                    End If

                    ' Now check to see if it has a child whose key is "Bold"
                    boldTool = e.Tool.FindToolByKey("Bold")
                    If boldTool IsNot Nothing Then
                        boldTool.Checked = e.Tool.Checked
                    End If

                    ApplyBoldText(e.Tool.Checked)
                End If
                Exit Select
            Case "Italic"
                If True Then
                    ApplyItalicText(e.Tool.Checked)
                End If
                Exit Select
            Case "Underline"
                If True Then
                    ApplyUnderlineText(e.Tool.Checked)
                End If
                Exit Select
        End Select
    End Sub

    Private Sub UltraRadialMenu1ToolCheckedChanging(sender As System.Object, e As Infragistics.Win.UltraWinRadialMenu.RadialMenuToolCheckedChangingEventArgs) Handles UltraRadialMenu1.ToolCheckedChanging
        Select Case e.Tool.Key
            Case "Parent Center"
                If True Then
                    ' If the current state is true, 
                    ' it means the user is trying to change it to false and we cannot allow that. 
                    If e.Tool.Checked Then
                        e.Cancel = True
                    End If
                End If
                Exit Select
        End Select
    End Sub

    Private Sub UltraRadialMenu1ToolColorChanged(sender As Object, e As RadialMenuToolColorChangedEventArgs)
        If e.Tool Is Nothing Then
            Return
        End If

        ' When a child tool is selected, replace the parent tool's icon and text with the child's icon and text.
        If e.Tool.ToolSettings.Appearance.Image IsNot Nothing Then
            e.Tool.ParentTool.UseAppearanceOfLastToggledChildTool = True
            e.Tool.ParentTool.Text = e.Tool.Text
        End If

        ' Return if a tool is checkable but not checked
        If e.Tool.Checkable AndAlso e.Tool.Checked = False Then
            Return
        End If

        ApplyFontColor(e.Tool)
    End Sub

    Private Sub UltraRadialMenu1ListToolSelectedValueChanged(sender As Object, e As RadialMenuListToolSelectedValueChangedEventArgs) Handles UltraRadialMenu1.ListToolSelectedValueChanged
        Dim rootTool = DirectCast(e.Tool, RadialMenuListTool)
        If rootTool Is Nothing Then
            Return
        End If

        e.Tool.Text = rootTool.ValueList.SelectedItem.ToString()
    End Sub

    Private Sub UltraRadialMenu1ListToolSelectedValueCommitted(sender As System.Object, e As Infragistics.Win.UltraWinRadialMenu.RadialMenuListToolSelectedValueCommittedEventArgs) Handles UltraRadialMenu1.ListToolSelectedValueCommitted
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        Dim fontList = DirectCast(e.Tool, RadialMenuListTool)
        If fontList Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionFont = If(RichTextBox1.SelectionFont Is Nothing, New Font(DefaultFont.Name, DefaultFont.Size, DefaultFont.Style), New Font(fontList.SelectedValue.ToString(), RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style))
    End Sub

    Private Sub UltraRadialMenu1ToolValueChanged(sender As Object, e As RadialMenuToolValueChangedEventArgs) Handles UltraRadialMenu1.ToolValueChanged
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        ' Initialize (float) font size variable.
        Dim fontSize = 0.0F

        Dim gaugeTool = TryCast(e.Tool, RadialMenuNumericGaugeTool)
        If gaugeTool IsNot Nothing Then
            fontSize = gaugeTool.Value
        End If

        ' If the font size is other than the initialized value, then set your text font size with the retrieved value.
        If fontSize > 0.0F Then
            ' Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
            If RichTextBox1 Is Nothing Then
                Return
            End If

            If RichTextBox1.SelectionFont IsNot Nothing Then
                RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, fontSize, RichTextBox1.SelectionFont.Style)
            End If
        End If
    End Sub

    Public Sub EvaluateFontSize()
        ' Dim textEditor = TryCast(ultraTabControl1.SelectedTab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        Dim fontSizeTool = UltraRadialMenu1.CenterTool.FindToolByKey("FontSize")
        If fontSizeTool Is Nothing Then
            Return
        End If

        Dim gaugeValue = TryCast(fontSizeTool.Tools(0), RadialMenuNumericGaugeTool)
        If gaugeValue Is Nothing Then
            Return
        End If

        '  Note:  RichTextEditor sets the font size to 13(we will bypass it) when multiple texts are selected.
        If RichTextBox1.SelectionFont IsNot Nothing AndAlso CInt(RichTextBox1.SelectionFont.Size) <> 13 Then
            gaugeValue.Value = CInt(RichTextBox1.SelectionFont.Size)
        End If
    End Sub

    Public Sub RemoveInvalidFonts()
        Dim fontListTool = TryCast(UltraRadialMenu1.CenterTool.FindRootTool().FindToolByKey("Font Type"), RadialMenuFontListTool)
        If fontListTool Is Nothing Then
            Return
        End If

        ' Reload the font family list removing any font that does not support regular font style.
        Dim list As List(Of FontFamily) = FontFamily.Families.Where(Function(p) p.IsStyleAvailable(FontStyle.Regular)).ToList()

        fontListTool.ValueList.ValueListItems.Clear()
        For Each fontlist As FontFamily In list
            fontListTool.ValueList.ValueListItems.Add(fontlist.Name)
        Next
    End Sub

    Public Sub ProcessToolClick(tool As RadialMenuTool)
        Select Case tool.Key
            Case "Color"
                If True Then
                    ' What happens here depends on the last toggled child tool. 
                    ' Process the click as though the LastToggledChildTool were clicked. 
                    Dim lastToggledChildTool = TryCast(tool.LastToggledChildTool, RadialMenuColorTool)
                    If lastToggledChildTool IsNot Nothing Then
                        ProcessToolClick(lastToggledChildTool)
                    End If
                    Exit Select
                End If
            Case "Cut", "Copy", "Paste"
                If True Then
                    ApplyCutCopyPaste(tool)
                    Exit Select
                End If
            Case "Undo", "Redo"
                If True Then
                    ApplyUndoRedo(tool)
                    Exit Select
                End If
            Case "Parent Center", "Align Left", "Center", "Align Right"
                If True Then
                    ApplyTextAlignment(tool)
                    Exit Select
                End If
            Case "Indent", "Indent More", "Indent Less"
                If True Then
                    ApplyIndentation(tool)
                    Exit Select
                End If
            Case "Bullet"
                If True Then
                    ApplyBullet(tool)
                    Exit Select
                End If
            Case "Font Type"
                If True Then
                    UpdateFontName(DirectCast(tool, RadialMenuFontListTool))
                    Exit Select
                End If
            Case "Font Size"
                If True Then
                    UpdateFontSize(DirectCast(tool, RadialMenuNumericTool))
                    Exit Select
                End If
            Case "Font Color"
                If True Then
                    ApplyFontColor(DirectCast(tool, RadialMenuColorTool))
                    Exit Select
                End If
            Case "Highlight Color"
                If True Then
                    ApplyHighlightColor(DirectCast(tool, RadialMenuColorTool))
                    Exit Select
                End If
            Case "Fill Color"
                If True Then
                    ' Fill color is intended for a Table that is not implemented in this sample, so we exit out. 
                    Exit Select
                End If
        End Select
    End Sub

    Public Sub ApplyFontColor(rmTool As RadialMenuColorTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        ' Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionColor = rmTool.Color
    End Sub

    Public Sub ApplyHighlightColor(rmTool As RadialMenuColorTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionBackColor = rmTool.Color
    End Sub

    Public Sub UpdateFontName(rmTool As RadialMenuFontListTool)
        If rmTool Is Nothing Or rmTool.SelectedValue Is Nothing Then
            Return
        End If

        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        '  Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionFont = If(RichTextBox1.SelectionFont Is Nothing, New Font(DefaultFont.Name, DefaultFont.Size, DefaultFont.Style), New Font(rmTool.SelectedValue.ToString(), RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style))
    End Sub

    Public Sub ApplyBoldText(isChecked As Boolean)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        ' Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        If isChecked Then
            _toolsFontStyle = _toolsFontStyle Or FontStyle.Bold
        Else
            _toolsFontStyle = _toolsFontStyle And Not FontStyle.Bold
        End If

        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, _toolsFontStyle)
    End Sub

    Public Sub DoWorkParentFontTools(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        If RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        Select Case rmTool.Text
            Case "Bold"
                If rmTool.Checked Then
                    _toolsFontStyle = _toolsFontStyle Or FontStyle.Bold
                    ' This will turn On the child font (Bold) tool when the parent is checked.
                    rmTool.Tools("FontBold").Checked = True
                Else
                    _toolsFontStyle = _toolsFontStyle And Not FontStyle.Bold
                    ' This will turn Off the child font (Bold) tool when the parent is unchecked.
                    rmTool.Tools("FontBold").Checked = False
                End If
                Exit Select
            Case "Underline"
                _toolsFontStyle = _toolsFontStyle Or FontStyle.Underline
                Exit Select
            Case "Italic"
                _toolsFontStyle = _toolsFontStyle Or FontStyle.Italic
                Exit Select
            Case Else
                _toolsFontStyle = FontStyle.Regular
                Exit Select
        End Select
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, _toolsFontStyle)
    End Sub

    Public Sub ApplyItalicText(isChecked As Boolean)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        If isChecked Then
            _toolsFontStyle = _toolsFontStyle Or FontStyle.Italic
        Else
            _toolsFontStyle = _toolsFontStyle And Not FontStyle.Italic
        End If
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, _toolsFontStyle)
    End Sub

    Public Sub ApplyUnderlineText(isChecked As Boolean)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        If isChecked Then
            _toolsFontStyle = _toolsFontStyle Or FontStyle.Underline
        Else
            _toolsFontStyle = _toolsFontStyle And Not FontStyle.Underline
        End If
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, RichTextBox1.SelectionFont.Size, _toolsFontStyle)
    End Sub

    Public Sub ApplyTextAlignment(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        Select Case rmTool.Key
            Case "Parent Center"
                If rmTool.Checked Then
                    RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

                    ' When ParentCenter is checked, synchronize with the child "Center" tool. 
                    Dim centerTool As RadialMenuTool = rmTool.FindToolByKey("Center")
                    centerTool.Checked = rmTool.Checked
                End If
                Exit Select
            Case "Center"
                If rmTool.Checked Then
                    RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

                    ' When child Center is checked synchronize with the "ParentCenter" tool.
                    ' But don't fire the events, because we don't want this getting cancelled in ToolCheckedChanging event. 
                    Dim parentCenterTool As RadialMenuTool = rmTool.ParentTool
                    parentCenterTool.SetChecked(rmTool.Checked, False)
                End If
                Exit Select
            Case "Align Left"
                If rmTool.Checked Then
                    RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
                    Dim parentCenterTool As RadialMenuTool = rmTool.ParentTool
                    parentCenterTool.SetChecked(False, False)
                End If
                Exit Select
            Case "Align Right"
                If rmTool.Checked Then
                    RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
                    Dim parentCenterTool As RadialMenuTool = rmTool.ParentTool
                    parentCenterTool.SetChecked(False, False)
                End If
                Exit Select
        End Select
    End Sub

    Public Sub ApplyBullet(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionBullet = Not RichTextBox1.SelectionBullet
        RichTextBox1.BulletIndent = 15
        ' Indent 15 pixels from the bullet symbol to the right.
    End Sub

    Public Sub ApplyIndentation(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        ' Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        Select Case rmTool.Text
            Case "Indent"
                ' Parent tool always Indents Right
                RichTextBox1.SelectionIndent += 15
                Exit Select
            Case "Indent More"
                ' Indent 15 pixels from the left edge to the right
                RichTextBox1.SelectionIndent += 15
                Exit Select
            Case "Indent Less"
                ' Indent 15 pixels from the left edge to the right
                RichTextBox1.SelectionIndent -= 15
                Exit Select
        End Select
    End Sub

    Public Sub ApplyCutCopyPaste(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        ' Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        Select Case rmTool.Key
            Case "Cut"
                RichTextBox1.Cut()
                Exit Select
            Case "Copy"
                RichTextBox1.Copy()
                Exit Select
            Case "Paste"
                RichTextBox1.Paste()
                Exit Select
        End Select
    End Sub

    Public Sub ApplyUndoRedo(rmTool As RadialMenuTool)
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        Select Case rmTool.Key
            Case "Undo"
                RichTextBox1.Undo()
                Exit Select
            Case "Redo"
                RichTextBox1.Redo()
                Exit Select
        End Select
    End Sub

    Public Sub UpdateFontSize(rmTool As RadialMenuNumericTool)
        ' Initialize (float) font size variable.
        Dim fontSize = 0.0F

        Dim gaugeTool = TryCast(rmTool.Tools(0), RadialMenuNumericGaugeTool)
        If gaugeTool IsNot Nothing Then
            fontSize = gaugeTool.Value
        End If

        ' If the font size is other than the initialized value, then set your text font size with the retrieved value.
        If Not (fontSize > 0.0F) Then
            Return
        End If

        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing Then
            Return
        End If

        RichTextBox1.SelectionFont = If(RichTextBox1.SelectionFont Is Nothing, New Font(DefaultFont.Name, DefaultFont.Size, DefaultFont.Style), New Font(RichTextBox1.SelectionFont.Name, fontSize, RichTextBox1.SelectionFont.Style))
    End Sub

    Public Sub ReevaluateFontTools()
        ' Expand the menu and replace the center icon.
        'UltraRadialMenu1.Expanded = True
        'UltraRadialMenu1.CenterTool.ToolSettings.CenterButtonAppearance.Image = New Bitmap(_imagePath & "CenterIcon_Text" & ImageSuffix)

        ' Synchronize the font weight state between the current text selection and RadialMenu Font tools.
        CurrentFontState()

        Dim rmTool As RadialMenuTool = UltraRadialMenu1.CenterTool.FindToolByKey("Bold")
        If rmTool Is Nothing Then
            Return
        End If

        If rmTool.ParentTool.Key = "Bold" Then
            ' This is a child tool that has a parent tool called "Bold"
            For Each tool As RadialMenuTool In rmTool.ParentTool.Tools
                If tool.Key = "Bold" Then
                    tool.Checked = _boldIsChecked
                End If
                If tool.Key = "Underline" Then
                    tool.Checked = _underlineIsChecked
                End If
                If tool.Key = "Italic" Then
                    tool.Checked = _italicIsChecked
                End If
            Next
        End If

        If rmTool.FindToolByKey("Bold") IsNot Nothing Then
            ' This is a parent tool, but we still want to loop through the children,
            ' and update the checked state. It will synchronize with the parent as well.
            rmTool.FindToolByKey("Bold").Checked = _boldIsChecked
            rmTool.FindToolByKey("Underline").Checked = _underlineIsChecked
            rmTool.FindToolByKey("Italic").Checked = _italicIsChecked
        End If
    End Sub

    Public Sub CurrentFontState()
        'Dim tab = ultraTabControl1.SelectedTab
        'If tab Is Nothing Then
        '    Return
        'End If

        'Dim textEditor = TryCast(tab.TabPage.Controls(0), RichTextBox)
        If RichTextBox1 Is Nothing OrElse RichTextBox1.SelectionFont Is Nothing Then
            Return
        End If

        ' Re-Initialize the check fields.
        _boldIsChecked = False
        _underlineIsChecked = False
        _italicIsChecked = False

        If RichTextBox1.SelectionFont.Bold Then
            _boldIsChecked = True
        End If
        If RichTextBox1.SelectionFont.Underline Then
            _underlineIsChecked = True
        End If
        If RichTextBox1.SelectionFont.Italic Then
            _italicIsChecked = True
        End If
    End Sub

    Public Sub SaveRadialManuInitialSettings()
        ' ReSharper disable AssignNullToNotNullAttribute
        Dim filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "RadialMenuInitalSettings.xml")
        ' ReSharper restore AssignNullToNotNullAttribute
        UltraRadialMenu1.SaveAsXml(filename)
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Me.Close()
        Using aMainor As New linqNotesDataContext(cnxNotes)
            Dim note As New tblNote
            note.Note = RichTextBox1.Rtf
            aMainor.tblNotes.InsertOnSubmit(note)
            aMainor.SubmitChanges()
        End Using

    End Sub


End Class