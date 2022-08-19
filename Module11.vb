Module Module1
    'Public cnx As String = My.Settings.StockSystem2019ConnectionString
    'Public cnxPH As String = My.Settings.Pharmacy2019ConnectionString
    'Public cnxHIS As String = My.Settings.rhh2012ConnectionString
    'Public cnxOrg As String = My.Settings.OrganigramSecurityConnectionString
    Public idx As String = "*1*2*3*4*5*6*7*8*9*10*11*12*13*"
    Public SelectedMRN As String

    Public Property deafultLablePrinterName As String
        Set(ByVal value As String)
            'My.Settings.deafultLablePrinterName = value
            My.Settings.Save()
        End Set
        Get
            'Return My.Settings.deafultLablePrinterName
        End Get
    End Property


    Public Property Pharmacy2019ConnectionString As String
        Set(ByVal value As String)
            'My.Settings.Pharmacy2019ConnectionString = value
            My.Settings.Save()
        End Set
        Get
            'Return My.Settings.Pharmacy2019ConnectionString
        End Get
    End Property
    Public Property StockSystem2019ConnectionString As String
        Set(ByVal value As String)
            'My.Settings.StockSystem2019ConnectionString = value
            My.Settings.Save()
        End Set
        Get
            'Return My.Settings.StockSystem2019ConnectionString
        End Get
    End Property
    Public Property rhh2012ConnectionString As String
        Set(ByVal value As String)
            'My.Settings.rhh2012ConnectionString = value
            My.Settings.Save()
        End Set
        Get
            'Return My.Settings.rhh2012ConnectionString
        End Get
    End Property
    Public Property OrganigramSecurityConnectionString As String
        Set(ByVal value As String)
            'My.Settings.OrganigramSecurityConnectionString = value
            My.Settings.Save()
        End Set
        Get
            'Return My.Settings.OrganigramSecurityConnectionString
        End Get
    End Property

    Public Property MyLocation As Point
        Set(ByVal value As Point)
            My.Settings.LocX = value.X
            My.Settings.LocY = value.Y
            My.Settings.Save()
        End Set
        Get
            Return New Point(My.Settings.LocX, My.Settings.LocY)
        End Get
    End Property

    Public Property MySize As Point
        Set(ByVal value As Point)
            My.Settings.SizeX = value.X
            My.Settings.SizeY = value.Y
            My.Settings.Save()
        End Set
        Get
            Return New Point(My.Settings.SizeX, My.Settings.SizeY)
        End Get
    End Property
End Module


