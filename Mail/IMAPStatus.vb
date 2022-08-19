
Public Delegate Sub StatusUpdater()

    Public Class IMAPStatus
    Public Shared connStatus As ConnectionStatus

    Public Shared Property ConnStatus1 As ConnectionStatus
        Get
            Return connStatus
        End Get
        Set(ByVal value As ConnectionStatus)
            connStatus = value
            statUpd.Invoke()
            If connStatus = ConnectionStatus.Connected Then activateFunc.Invoke()
            If connStatus = ConnectionStatus.Disconnected Then deactivateFunc.Invoke()
        End Set
    End Property

    Public Shared Property statUpd As StatusUpdater
        Public Shared Property activateFunc As StatusUpdater
        Public Shared Property deactivateFunc As StatusUpdater

        Private Sub New()
        ConnStatus1 = ConnectionStatus.Disconnected
    End Sub
    End Class

