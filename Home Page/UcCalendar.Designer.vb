<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcCalendar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.BtCalendar = New System.Windows.Forms.Button()
        Me.ultraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.ultraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox2.ForeColor = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox2.TabIndex = 25
        Me.UltraExpandableGroupBox2.Text = "My Calendar"
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.BtCalendar)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(205, 418)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'BtCalendar
        '
        Me.BtCalendar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtCalendar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtCalendar.FlatAppearance.BorderSize = 0
        Me.BtCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalendar.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalendar.ForeColor = System.Drawing.Color.White
        Me.BtCalendar.Image = Global.HR.My.Resources.Resources.icons8_calendar_plus_24
        Me.BtCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendar.Location = New System.Drawing.Point(0, 0)
        Me.BtCalendar.Name = "BtCalendar"
        Me.BtCalendar.Size = New System.Drawing.Size(205, 40)
        Me.BtCalendar.TabIndex = 6
        Me.BtCalendar.Text = "           Calendar "
        Me.BtCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendar.UseVisualStyleBackColor = False
        '
        'ultraCalendarInfo1
        '
        Me.ultraCalendarInfo1.AllowRecurringAppointments = True
        '
        'ultraCalendarLook1
        '
        Me.ultraCalendarLook1.ViewStyle = Infragistics.Win.UltraWinSchedule.ViewStyle.Office2007
        '
        'UcCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.Name = "UcCalendar"
        Me.Size = New System.Drawing.Size(211, 441)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents BtCalendar As Button
    Private WithEvents ultraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Private WithEvents ultraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
End Class
