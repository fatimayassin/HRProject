<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInterfaceClock
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.secondBox = New System.Windows.Forms.PictureBox()
        Me.dotBox = New System.Windows.Forms.PictureBox()
        Me.minuteBox = New System.Windows.Forms.PictureBox()
        Me.hourBox = New System.Windows.Forms.PictureBox()
        Me.backBox = New System.Windows.Forms.PictureBox()
        CType(Me.secondBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dotBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minuteBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hourBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'secondBox
        '
        Me.secondBox.BackColor = System.Drawing.Color.Transparent
        Me.secondBox.Location = New System.Drawing.Point(278, 110)
        Me.secondBox.Name = "secondBox"
        Me.secondBox.Size = New System.Drawing.Size(500, 500)
        Me.secondBox.TabIndex = 14
        Me.secondBox.TabStop = False
        '
        'dotBox
        '
        Me.dotBox.BackColor = System.Drawing.Color.Transparent
        Me.dotBox.Location = New System.Drawing.Point(162, 87)
        Me.dotBox.Name = "dotBox"
        Me.dotBox.Size = New System.Drawing.Size(500, 500)
        Me.dotBox.TabIndex = 13
        Me.dotBox.TabStop = False
        '
        'minuteBox
        '
        Me.minuteBox.BackColor = System.Drawing.Color.Transparent
        Me.minuteBox.Location = New System.Drawing.Point(104, 55)
        Me.minuteBox.Name = "minuteBox"
        Me.minuteBox.Size = New System.Drawing.Size(500, 500)
        Me.minuteBox.TabIndex = 12
        Me.minuteBox.TabStop = False
        '
        'hourBox
        '
        Me.hourBox.BackColor = System.Drawing.Color.Transparent
        Me.hourBox.Location = New System.Drawing.Point(36, 30)
        Me.hourBox.Name = "hourBox"
        Me.hourBox.Size = New System.Drawing.Size(500, 500)
        Me.hourBox.TabIndex = 11
        Me.hourBox.TabStop = False
        '
        'backBox
        '
        Me.backBox.BackColor = System.Drawing.Color.Transparent
        Me.backBox.Location = New System.Drawing.Point(11, 12)
        Me.backBox.Name = "backBox"
        Me.backBox.Size = New System.Drawing.Size(500, 500)
        Me.backBox.TabIndex = 10
        Me.backBox.TabStop = False
        '
        'UCInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.secondBox)
        Me.Controls.Add(Me.dotBox)
        Me.Controls.Add(Me.minuteBox)
        Me.Controls.Add(Me.hourBox)
        Me.Controls.Add(Me.backBox)
        Me.Name = "UCInterface"
        Me.Size = New System.Drawing.Size(789, 629)
        CType(Me.secondBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dotBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minuteBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hourBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents secondBox As PictureBox
    Private WithEvents dotBox As PictureBox
    Private WithEvents minuteBox As PictureBox
    Private WithEvents hourBox As PictureBox
    Private WithEvents backBox As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
