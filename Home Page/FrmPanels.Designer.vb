<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPanels
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarItem1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarItem2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarItem3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarItem5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarItem4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        Appearance1.Image = Global.HR.My.Resources.Resources.icons8_mail_account_50
        UltraExplorerBarItem1.Settings.AppearancesSmall.Appearance = Appearance1
        UltraExplorerBarItem1.Tag = "Sign In Account"
        UltraExplorerBarItem1.Text = "Sign In Account"
        Appearance2.Image = Global.HR.My.Resources.Resources.icons8_composing_mail_50
        UltraExplorerBarItem2.Settings.AppearancesSmall.Appearance = Appearance2
        UltraExplorerBarItem2.Tag = "Compose Mail"
        UltraExplorerBarItem2.Text = "Compose Mail"
        Appearance3.Image = Global.HR.My.Resources.Resources.icons8_download_mail_50
        UltraExplorerBarItem3.Settings.AppearancesSmall.Appearance = Appearance3
        UltraExplorerBarItem3.Tag = "All Mails"
        UltraExplorerBarItem3.Text = "All Mails"
        Appearance4.Image = Global.HR.My.Resources.Resources.icons8_secured_letter_50
        UltraExplorerBarItem5.Settings.AppearancesSmall.Appearance = Appearance4
        UltraExplorerBarItem5.Text = "Outlook Mail"
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1, UltraExplorerBarItem2, UltraExplorerBarItem3, UltraExplorerBarItem5})
        Appearance5.Image = Global.HR.My.Resources.Resources.Orders48
        UltraExplorerBarGroup1.Settings.AppearancesSmall.HeaderAppearance = Appearance5
        UltraExplorerBarGroup1.Tag = "Mail"
        UltraExplorerBarGroup1.Text = "Mail"
        Appearance6.Image = Global.HR.My.Resources.Resources.Calendar
        UltraExplorerBarGroup2.Settings.AppearancesSmall.HeaderAppearance = Appearance6
        UltraExplorerBarGroup2.Tag = "Calendar"
        UltraExplorerBarGroup2.Text = "Calendar"
        Appearance7.Image = Global.HR.My.Resources.Resources.Tasks
        UltraExplorerBarGroup3.Settings.AppearancesSmall.HeaderAppearance = Appearance7
        UltraExplorerBarGroup3.Tag = "Tasks"
        UltraExplorerBarGroup3.Text = "Tasks"
        Appearance8.Image = Global.HR.My.Resources.Resources.Customers48
        UltraExplorerBarGroup5.Settings.AppearancesSmall.HeaderAppearance = Appearance8
        UltraExplorerBarGroup5.Tag = "Contacts"
        UltraExplorerBarGroup5.Text = "Contacts"
        Appearance9.Image = Global.HR.My.Resources.Resources.icons8_add_file_50
        UltraExplorerBarItem4.Settings.AppearancesSmall.Appearance = Appearance9
        UltraExplorerBarItem4.Tag = "New Note"
        UltraExplorerBarItem4.Text = "New Note"
        UltraExplorerBarGroup4.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem4})
        Appearance10.Image = Global.HR.My.Resources.Resources.Notes
        UltraExplorerBarGroup4.Settings.AppearancesSmall.HeaderAppearance = Appearance10
        UltraExplorerBarGroup4.Tag = "Notes"
        UltraExplorerBarGroup4.Text = "Notes"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2, UltraExplorerBarGroup3, UltraExplorerBarGroup5, UltraExplorerBarGroup4})
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(201, 448)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.OutlookNavigationPane
        Me.UltraExplorerBar1.TabIndex = 13
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Splitter1.Location = New System.Drawing.Point(201, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 448)
        Me.Splitter1.TabIndex = 14
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(211, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 448)
        Me.Panel1.TabIndex = 15
        '
        'FrmPanels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.UltraExplorerBar1)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPanels"
        Me.Text = "FrmPanels"
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel1 As Panel
End Class
