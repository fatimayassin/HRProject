Imports System.IO
Public Class FrmCompanyProfil
    Public id As Integer = 0
    Dim EditAttachachment As Boolean = False
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        'Dim answer = MessageBox.Show("Are you sure you want to close?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        'If answer = DialogResult.Yes Then
        Me.Close()
        'End If
    End Sub

    Sub AddAttachment()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not OpenFileDialog1.FileName = String.Empty Then
                Dim fi As New FileInfo(OpenFileDialog1.FileName)
                Dim fr As Stream = fi.OpenRead
                Dim nbytes As Integer = fi.Length
                Dim bytearray(nbytes) As Byte
                fr.Read(bytearray, 0, nbytes)
                fr.Close()
                TblCompanyProfileBindingSource.Current.attachment = bytearray
                PBCompanyProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        End If
    End Sub
    Private Sub PBCompanyProfile_Click(sender As System.Object, e As System.EventArgs) Handles PBCompanyProfile.Click
        AddAttachment()
        If Not OpenFileDialog1.FileName = "OpenFileDialog1" And Not OpenFileDialog1.FileName = String.Empty Then
            Dim image As Image = image.FromFile(OpenFileDialog1.FileName)
            PBCompanyProfile.Image = image
        End If
    End Sub


    Private Sub FrmCompanyProfil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FormBackgroundColor
        lblText.BackColor = My.Settings.PanelColor
        lblClose.BackColor = My.Settings.PanelColor
        Using aMainor As New LqHRDataContext(cnx)
            Dim res = aMainor.TblCompanyProfiles.ToList
            If res.Count > 0 Then
                id = res.ToList(0).Id
                Dim r = (From ax In aMainor.TblCompanyProfiles Where ax.Id = id).ToList()
                TblCompanyProfileBindingSource.DataSource = (From ax In aMainor.TblCompanyProfiles Where ax.Id = id).ToList()

                If r.Count > 0 Then
                    If Not r.ToList(0).Attachment Is Nothing Then
                        Dim b As Byte() = r.ToList(0).Attachment.ToArray()
                        Dim ms As New IO.MemoryStream(b)
                        Dim img As Image = Image.FromStream(ms)
                        PBCompanyProfile.Image = img

                    Else
                        PBCompanyProfile.Image = My.Resources.AddEmployee
                    End If

                End If
            Else
                id = 0
                TblCompanyProfileBindingSource.DataSource = New TblCompanyProfile
            End If
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Using aMainor As New LqHRDataContext(cnx)
            If NameTextBox.Text = "" Then
                MessageBox.Show("Missing Some Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                
                    If id = 0 Then
                        aMainor.TblCompanyProfiles.InsertOnSubmit(TblCompanyProfileBindingSource.Current)
                        aMainor.SubmitChanges()
                    Else
                        Dim oldRow As TblCompanyProfile = (From ax In aMainor.TblCompanyProfiles Where ax.Id = id).ToList(0)
                        Dim newRow As TblCompanyProfile = TblCompanyProfileBindingSource.Current
                        oldRow.Name = newRow.Name
                        oldRow.Address = newRow.Address
                        oldRow.Email = newRow.Email
                        oldRow.Phone = newRow.Phone
                        oldRow.Purpose = newRow.Purpose
                        oldRow.Fax = newRow.Fax
                        oldRow.Website = newRow.Website
                        oldRow.Attachment = newRow.Attachment
                        aMainor.SubmitChanges()


                    End If

                End If

        End Using
        Me.Close()

    End Sub


    

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class