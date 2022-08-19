Public Class Human_Resourse_Management_System

    Dim counter As Integer = 1
    Dim counter2 As Integer = 1
    Dim counter3 As Integer = 1
    Dim counter4 As Integer = 1
    Dim Isloaded = False
    Public mypoint As Point
    Dim clickLoc As Point


    Private Sub Human_Resourse_Management_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UcHomeNav As New UCHomeNav
        Panel1.Controls.Add(UcHomeNav)

        'Me.UltraToolbarsManager1.Ribbon.Visible = True
        'Me.UltraToolbarsManager1.Office2007UICompatibility = False
        'Me.UltraToolbarsManager1.Ribbon.FileMenuStyle = Infragistics.Win.UltraWinToolbars.FileMenuStyle.None
        '' Me.ShowIcon = False
        'Me.UltraToolbarsManager1.AlwaysShowMenusExpanded = Infragistics.Win.DefaultableBoolean.True

        Me.BackColor = My.Settings.FormBackgroundColor
        StatusStrip1.BackColor = My.Settings.PanelColor

        PublicContainerPanel = Me.Panel2
        'MyOpenForm(New FrmInterface)
        'MyOpenForm(New FormPanel3)
        ' MyOpenForm(New FrmDockable)
        ' MyOpenForm(New FrmPanels)
        MyOpenForm(New Form6)

        Isloaded = True
        mypoint = New Point(Me.Location.X + Me.Width, Me.Location.Y + Me.Height)


        cscreen = New Point((My.Computer.Screen.Bounds.Width - Me.Width) / 2, (My.Computer.Screen.Bounds.Height - Me.Height) / 2)
        '  Me.Location = cscreen
        applocation = New Point(0, 0)

        Using aMainor As New LqHRDataContext(cnx)
            Dim user = (From ax In aMainor.TblUsers Where ax.Id = UserId Select ax.Username).ToList(0)
            lblUser.Text = " Logged in as " & " " & user
            ToolStripStatusLabel3.Text = " Logged in At" & " " & Today & " " & TimeOfDay
        End Using

    End Sub
End Class