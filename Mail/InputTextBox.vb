Public Class InputTextBox
    Inherits Form

    Public ReadOnly Property TextEntered As String
        Get
            Return textBox1.Text
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal formCaption As String, ByVal inputMessage As String)
        InitializeComponent()
        label1.Text = inputMessage
        Me.Text = formCaption
    End Sub

    Private Sub textBox1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub
End Class