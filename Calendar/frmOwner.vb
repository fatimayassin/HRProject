Imports Infragistics.Win
Imports Infragistics.Win.UltraWinSchedule


Public Class frmOwner
    Inherits System.Windows.Forms.Form

    Private _owner As Owner
    Private _calendarInfo As UltraCalendarInfo

    Public Sub New(ByVal calendarInfo As UltraCalendarInfo)
        MyBase.New()

        Me._calendarInfo = calendarInfo

        InitializeComponent()
    End Sub


#Region "Event handlers"
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If Me.ValidateKey() = False Then Return

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "ShowMe"
    ' <summary>
    ' Shows the dialog
    ' </summary>
    ' <param name="owner">The Owner being edited, or null if adding a new Owner.</param>
    Public Sub ShowMe(ByVal owner As Owner)
        Me._owner = owner
        Me.txtKey.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtEmail.Text = String.Empty
        Me.chkVisible.Checked = True
        Me.chkLocked.Checked = False
        Me.cmdOk.Enabled = False
        'Me.Text = My.Resources.AddOwner


        Me.txtKey.MaxLength = 50
        Me.txtName.MaxLength = 50
        Me.txtEmail.MaxLength = 50

        If Not Me._owner Is Nothing Then

            Me.txtKey.Text = owner.Key
            Me.txtName.Text = owner.Name
            Me.txtEmail.Text = owner.EmailAddress
            Me.chkVisible.Checked = owner.Visible
            Me.chkLocked.Checked = owner.Locked
            Me.Text = String.Format(owner.Name)
        End If

        Me.StartPosition = FormStartPosition.CenterParent

        AddHandler chkLocked.CheckedChanged, AddressOf Me.OnFieldValueChanged
        AddHandler chkVisible.CheckedChanged, AddressOf Me.OnFieldValueChanged
        AddHandler txtKey.TextChanged, AddressOf Me.OnFieldValueChanged
        AddHandler txtName.TextChanged, AddressOf Me.OnFieldValueChanged
        AddHandler txtEmail.TextChanged, AddressOf Me.OnFieldValueChanged

        Me.ShowDialog()

    End Sub
#End Region

#Region "ValidateKey"

    ' <summary>
    ' Validates the 'Key' field by ensuring the key is non-empty and unique.
    ' </summary>
    Private Function ValidateKey() As Boolean

        Dim keyOk As Boolean = True
        If Me.txtKey.Text.Length = 0 Then

            MessageBox.Show("Must specify key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            keyOk = False

        ElseIf Me._calendarInfo.Owners.Exists(Me.txtKey.Text) Then

            '	If the specified key exists, and we are adding a new owner,
            '	fail the validation.
            If Me._owner Is Nothing Then
                keyOk = False
            Else
                '	If the specified key exists, we are modifying an existing owner,
                '	and the specified key is different than this owner's fail the validation.
                If (Me.txtKey.Text.Equals(Me._owner.Key) = False) Then
                    keyOk = False
                End If
            End If
        End If

        If keyOk = False Then

            Me.txtKey.Select()
            MessageBox.Show("Specified key already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return keyOk
    End Function

#End Region

#Region "OnFieldValueChanged"
    ' <summary>
    ' Handles the appropriate "value changed" event for all controls
    ' on the dialog which represent Owner properties.
    ' </summary>
    Private Sub OnFieldValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cmdOk.Enabled = True
    End Sub
#End Region

#Region "Key"
    Public ReadOnly Property Key() As String
        Get
            Return Me.txtKey.Text
        End Get
    End Property
#End Region

#Region "Name"
    Public ReadOnly Property OwnerName() As String
        Get
            Return Me.txtName.Text
        End Get
    End Property
#End Region

#Region "EmailAddress"
    Public ReadOnly Property EmailAddress() As String
        Get
            Return Me.txtEmail.Text
        End Get
    End Property
#End Region

#Region "OwnerVisible"
    Public ReadOnly Property OwnerVisible() As Boolean
        Get
            Return Me.chkVisible.Checked
        End Get
    End Property
#End Region

#Region "Visible"
    Public ReadOnly Property Locked() As Boolean
        Get
            Return Me.chkLocked.Checked
        End Get
    End Property
#End Region
End Class