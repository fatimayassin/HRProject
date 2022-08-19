Public Class FrmApplicantSkills
    Public Id As Integer = 0
    Public saved As Boolean = False
    Public ApplicantId As Integer = 0
    Public current As BindingSource
    Public ForEdit As Boolean = False
    Public UCcount As Integer = 0
    Public UCcount2 As Integer = 0

    Private Sub FrmApplicantSkills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor

        Using aMainor As New LqHRDataContext(cnx)


            Dim result = aMainor.TblSkills.ToList()
            Dim count = result.Count

            For i As Integer = 0 To count - 1
                Dim uc As New UCSkills()
                uc.Tag = i + 1
                uc.CheckBox1.Tag = result.ToList(i).Id
                uc.TrackBar1.Tag = result.ToList(i).Id

                uc.Label1.Text = result.ToList(i).Name
                uc.TrackBar1.Value = 3
                If i = count - 1 Then
                    uc.PictureBox2.Visible = True
                    AddHandler uc.clicked, AddressOf clickedAdd
                End If
                FlowLayoutPanel1.Controls.Add(uc)
                UCcount += 1
                'ShowUc(getTag(), False)
            Next


            If Not ForEdit Then
                If Id = 0 Then

                    'Else

                    '    TblApplicantSkillBindingSource.DataSource = current.DataSource
                    '    Dim IDlist As New List(Of Integer)
                    '    Dim LevelList As New List(Of Integer)

                    '    TblApplicantSkillBindingSource.MoveFirst()
                    '    For i As Integer = 0 To TblApplicantSkillBindingSource.Count - 1
                    '        IDlist.Add(TblApplicantSkillBindingSource.Current.skillId)
                    '        LevelList.Add(TblApplicantSkillBindingSource.Current.SkillLevel)

                    '        TblApplicantSkillBindingSource.MoveNext()
                    '    Next

                    '    For Each Uc As UCSkills1 In FlowLayoutPanel1.Controls

                    '        For Each chkbox As CheckBox In Uc.Panel1.Controls
                    '            If IDlist.Contains(chkbox.Tag) Then
                    '                chkbox.Checked = True
                    '            End If
                    '        Next

                    '        For Each trkbar As TrackBar In Uc.Panel3.Controls
                    '            If IDlist.Contains(trkbar.Tag) Then
                    '                Dim tag As Integer = trkbar.Tag

                    '                trkbar.Value = LevelList.Item(IDlist.IndexOf(trkbar.Tag))
                    '            End If
                    '        Next

                    '    Next

                End If
            Else
                TblApplicantSkillBindingSource = current
                Dim IDlist As New List(Of Integer)
                Dim LevelList As New List(Of Integer)

                TblApplicantSkillBindingSource.MoveFirst()
                For i As Integer = 0 To TblApplicantSkillBindingSource.Count - 1
                    IDlist.Add(TblApplicantSkillBindingSource.Current.skillId)
                    LevelList.Add(TblApplicantSkillBindingSource.Current.SkillLevel)

                    TblApplicantSkillBindingSource.MoveNext()
                Next

                For Each Uc As UCSkills In FlowLayoutPanel1.Controls

                    For Each chkbox As CheckBox In Uc.Panel1.Controls
                        If IDlist.Contains(chkbox.Tag) Then
                            chkbox.Checked = True
                        End If
                    Next

                    For Each trkbar As TrackBar In Uc.Panel3.Controls
                        If IDlist.Contains(trkbar.Tag) Then
                            Dim tag As Integer = trkbar.Tag

                            trkbar.Value = LevelList.Item(IDlist.IndexOf(trkbar.Tag))
                        End If
                    Next

                Next
            End If



            'If Not Id = 0 Then
            '    Dim result3 = (From aX In aMainOr.TblApplicantSkills Where aX.ApplicantId = ApplicantId Select aX.SkillId).ToList
            '    For Each Uc As UCSkills1 In FlowLayoutPanel1.Controls

            '        For Each chkbox As CheckBox In Uc.Panel1.Controls
            '            If result3.Contains(chkbox.Tag) Then
            '                chkbox.Checked = True

            '            End If

            '        Next
            '        For Each trkbar As TrackBar In Uc.Panel3.Controls
            '            If result3.Contains(trkbar.Tag) Then
            '                Dim tag As Integer = trkbar.Tag
            '                Dim result2 = (From aX In aMainOr.TblApplicantSkills Where aX.ApplicantId = ApplicantId And aX.SkillId = tag).ToList(0)

            '                trkbar.Value = result2.SkillLevel
            '            End If


            '        Next

            '    Next

            'End If

        End Using

    End Sub
    Sub clickedAdd(ByVal sender As UCSkills)

        Dim old As UCSkills = sender
        Dim uc As New UCSkills()
        uc.Tag = Convert.ToString(Integer.Parse(old.Tag + 1))
        UCcount2 += 1
        old.PictureBox2.Visible = False
        uc.PictureBox2.Visible = True
        uc.Label1.Visible = False
        uc.TextBox1.Visible = True
        uc.Enabled = True
        AddHandler uc.clicked, AddressOf clickedAdd
        FlowLayoutPanel1.Controls.Add(uc)
        UCcount += 1
        'ShowUc(getTag(), False)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = (From aX In aMainor.TblApplicantSkills Where aX.ApplicantId = ApplicantId).ToList()
            Dim res1 = (From x In aMainor.TblSkills Where x.Id = Id).ToList()
            If UCcount2 > 0 Then
                For Each Uc1 As UCSkills In FlowLayoutPanel1.Controls
                    If Uc1.Tag > UCcount - UCcount2 Then
                        Dim newskills As New TblSkill
                        newskills.Name = Uc1.TextBox1.Text
                        aMainor.TblSkills.InsertOnSubmit(newskills)
                        aMainor.SubmitChanges()

                        Dim SkillId = newskills.Id



                        If Uc1.CheckBox1.Checked Then

                            Dim level = Uc1.TrackBar1.Value
                            Dim newSkill As New TblApplicantSkill
                            newSkill.SkillLevel = level
                            newSkill.ApplicantId = ApplicantId
                            newSkill.SkillId = SkillId
                            TblApplicantSkillBindingSource.Add(newSkill)


                        End If


                    End If

                Next
            Else
                Dim cnt = res.Count
                If cnt > 0 Then
                    'aMainOr.TblApplicantSkills.DeleteAllOnSubmit(res)
                    TblApplicantSkillBindingSource.List.Clear()
                End If

                If TblApplicantSkillBindingSource.Count > 0 Then
                    TblApplicantSkillBindingSource.List.Clear()
                End If
                For Each Uc As UCSkills In FlowLayoutPanel1.Controls


                    For Each chkbox As CheckBox In Uc.Panel1.Controls

                        If chkbox.Checked Then
                            For Each trackbar As TrackBar In Uc.Panel3.Controls
                                Dim level = trackbar.Value


                                Dim newSkill As New TblApplicantSkill
                                newSkill.SkillLevel = level
                                newSkill.ApplicantId = ApplicantId

                                newSkill.SkillId = chkbox.Tag

                                'aMainOr.TblApplicantSkills.InsertOnSubmit(newSkill)
                                'aMainOr.SubmitChanges()
                                TblApplicantSkillBindingSource.Add(newSkill)

                            Next
                        End If
                    Next
                Next
            End If

            current = TblApplicantSkillBindingSource
            saved = True
            Me.Close()

        End Using
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()

        'End If
    End Sub


    Function getTag() As Integer

        If UCcount > 5 Then
            Dim MinTag As Integer = UCcount
            For Each uc As UCSkills In FlowLayoutPanel1.Controls
                If uc.Visible Then
                    If Integer.Parse(uc.Tag) < MinTag Then
                        MinTag = Integer.Parse(uc.Tag)
                    End If
                End If
            Next

            Return MinTag

        Else
            Return 0
        End If

    End Function
    Sub ShowUc(ByVal tag As Integer, ByVal show As Boolean)
        For Each uc1 As UCSkills In FlowLayoutPanel1.Controls
            If uc1.Tag = tag Then
                uc1.Visible = show
            End If
        Next
    End Sub


    'Private Sub PBUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim tag As Integer = getTag()
    '    If tag > 1 Then
    '        ShowUc(tag + 4, False)
    '        ShowUc(tag - 1, True)
    '    End If

    'End Sub

    'Private Sub PBDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim tag As Integer = getTag()
    '    If tag + 4 < UCcount Then
    '        ShowUc(tag, False)
    '        ShowUc(tag + 5, True)
    '    End If
    'End Sub
End Class