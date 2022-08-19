Module modulePublicMainForm

    Public PublicContainerPanel As Panel
    Public PublicContainerPanel2 As SplitterPanel
    Public cscreen As Point

    Public conex As String = ""
    Public FullNameLogedIn As String = "User"
    Public UserIDLogedIN As Integer = 1
    Public ThisUserIsSuperAdmin As Boolean = False
    Public applocation As New Point

    Public Property MyLocation2 As Point
        Set(ByVal value As Point)
            My.Settings.LocX = value.X
            My.Settings.LocY = value.Y
            My.Settings.Save()
        End Set
        Get
            Return New Point(My.Settings.LocX, My.Settings.LocY)
        End Get
    End Property


    Public Sub MyOpenForm(ByVal FormName As Object)
        Dim isopen As Boolean = False
        Dim xx As Object
        For Each x In PublicContainerPanel.Controls
            If x.Name = FormName.name Then
                xx = x
                isopen = True
            End If

        Next


        If isopen = True Then
            xx.BringToFront
            xx.Show()
        Else
            FormName.TopLevel = False
            PublicContainerPanel.Controls.Add(FormName)
            'FormName.WindowState = FormWindowState.Normal
            FormName.AutoSize = True
            FormName.Dock = DockStyle.Fill
            FormName.BringToFront
            FormName.Show()
        End If
    End Sub

    Public Sub MyOpenForm2(ByVal FormName As Object)
        Dim isopen As Boolean = False
        Dim xx As Object
        For Each x In PublicContainerPanel2.Controls
            If x.Name = FormName.name Then
                xx = x
                isopen = True
            End If

        Next

        If isopen = True Then
            xx.BringToFront
            xx.Show()
        Else
            FormName.TopLevel = False
            PublicContainerPanel2.Controls.Add(FormName)
            'FormName.WindowState = FormWindowState.Normal
            FormName.AutoSize = True
            FormName.Dock = DockStyle.Fill
            FormName.BringToFront
            FormName.Show()
        End If
    End Sub

    Public Sub MyOpenForm3(ByVal FormName As Object)
        Dim isopen As Boolean = False
        Dim xx As Object
        For Each x In PublicContainerPanel.Controls
            If x.Name = FormName.name Then
                xx = x
                isopen = True
            End If

        Next


        If isopen = True Then
            xx.BringToFront
            xx.Show()
        Else
            FormName.TopLevel = False
            PublicContainerPanel.Controls.Add(FormName)
            'FormName.WindowState = FormWindowState.Normal
            'FormName.AutoSize = True
            'FormName.Dock = DockStyle.Fill
            FormName.BringToFront
            FormName.Show()
        End If
    End Sub
End Module
