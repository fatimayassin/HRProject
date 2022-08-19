Public Class Form4
    Private arrZodiac(11) As String 'Array To Hold Zodiac Signs
    Private arrFrom(11) As String 'Each Zodiac Sign's Starting Date
    Private arrTo(11) As String 'Each Zodiac Sign's Ending Date

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'LargeIcons

        'Declare A Variable To Loop Through Array Items
        Dim i As Integer

        'Loop Through Zodiac Array
        For i = 0 To arrZodiac.Length - 1

            ListView1.Items.Add(arrZodiac(i)) 'Add Each Item Of Zodiac Array

            ListView1.Items(i).ImageIndex = i 'Align ImageList Images With Array Items

        Next

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Popluate Zodiac Array
        arrZodiac(0) = "Aries"
        arrZodiac(1) = "Taurus"
        arrZodiac(2) = "Gemini"
        arrZodiac(3) = "Cancer"
        arrZodiac(4) = "Leo"
        arrZodiac(5) = "Virgo"
        arrZodiac(6) = "Libra"
        arrZodiac(7) = "Scorpio"
        arrZodiac(8) = "Sagittarius"
        arrZodiac(9) = "Capricorn"
        arrZodiac(10) = "Aquarius"
        arrZodiac(11) = "Pisces"

        'Popluate Starting Dates
        arrFrom(0) = "21 March"
        arrFrom(1) = "20 April"
        arrFrom(2) = "21 May"
        arrFrom(3) = "21 June"
        arrFrom(4) = "23 July"
        arrFrom(5) = "23 August"
        arrFrom(6) = "23 September"
        arrFrom(7) = "23 October"
        arrFrom(8) = "22 November"
        arrFrom(9) = "22 December"
        arrFrom(10) = "20 January"
        arrFrom(11) = "19 February"

        'Populate Ending Dates
        arrTo(0) = "19 April"
        arrTo(1) = "20 May"
        arrTo(2) = "20 June"
        arrTo(3) = "22 July"
        arrTo(4) = "22 August"
        arrTo(5) = "22 September"
        arrTo(6) = "22 October"
        arrTo(7) = "21 November"
        arrTo(8) = "21 December"
        arrTo(9) = "19 January"
        arrTo(10) = "18 February"
        arrTo(11) = "20 March"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Details

        'Add Three Columns To ListView 2
        ListView2.Columns.Add("Zodiac", 100, HorizontalAlignment.Center) 'Column 1
        ListView2.Columns.Add("From", 100, HorizontalAlignment.Left) 'Column 2
        ListView2.Columns.Add("To", 100, HorizontalAlignment.Right) 'Column 3

        'Show Small Images Next To Zodiac Sign
        ListView2.SmallImageList = ImageList2

        'Declare Array For ListView Items
        Dim arrLVItem(11) As ListViewItem

        Dim j As Integer 'Loop Counter

        'Loop Through Each ListViewItem Array Item
        For j = 0 To arrLVItem.Length - 1

            'Initialize ListViewItem Array
            arrLVItem(j) = New ListViewItem

            'Add Text To First ListView Item - The Zodiac Sign
            arrLVItem(j).SubItems(0).Text = arrZodiac(j)

            'Add From and To SubItems On Zodiac ListView Item
            arrLVItem(j).SubItems.Add(arrFrom(j))
            arrLVItem(j).SubItems.Add(arrTo(j))

            'Connect ListView Item With Its Associated Picture
            arrLVItem(j).ImageIndex = j

        Next j

        'Add Completed Arrays To ListView
        ListView2.Items.AddRange(arrLVItem)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'SmallIcon

        Dim i As Integer 'Loop Counter

        'Loop Through Zodiac Array
        For i = 0 To arrZodiac.Length - 1

            ListView3.Items.Add(arrZodiac(i)) 'Add Each Zodiac Sign

            ListView3.Items(i).ImageIndex = i 'Connect Items With ImageList Picture Items

        Next

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'List

        'Use With Structure To Popluate ListView 4
        With ListView4

            .View = View.List 'Set View Mode

            .FullRowSelect = True 'Select Full Row

            .Columns.Clear() 'Clear Existing Columns
            .Items.Clear() 'Clear Existing Items

            Dim strZodiac As String 'String Object To Hold Zodiacs

            'For Each String In Zodiac Array
            For Each strZodiac In arrZodiac 'Loop Through Zodiac Array

                .Items.Add(strZodiac, 0) 'Add Items From Zodiac Array In Column 0

            Next

        End With

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'Tiles

        ListView5.Columns.Clear() 'Clear Existing Columns
        ListView5.Items.Clear() 'Clear Existing Items

        'Add Columns
        ListView5.Columns.Add("Zodiac", 100, HorizontalAlignment.Center)
        ListView5.Columns.Add("From", 100, HorizontalAlignment.Left)

        Dim k As Integer 'Loop Counter

        For k = 0 To 11 'Loop Through Zodiac Array Items

            ListView5.Items.Add(arrZodiac(k)) 'Add Each Zodiac Array Item

            'Add From Sub Item For Each Zodiac Item
            ListView5.Items(k).SubItems.Add(arrFrom(k))

        Next k

    End Sub

End Class