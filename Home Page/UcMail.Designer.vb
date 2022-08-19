<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMail
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
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.BtnMails = New System.Windows.Forms.Button()
        Me.BtComposeMail = New System.Windows.Forms.Button()
        Me.BtSignInAccount = New System.Windows.Forms.Button()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.ForeColor = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(211, 441)
        Me.UltraExpandableGroupBox1.TabIndex = 25
        Me.UltraExpandableGroupBox1.Text = "My Mail"
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.BtnMails)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.BtComposeMail)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.BtSignInAccount)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(205, 418)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'BtnMails
        '
        Me.BtnMails.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnMails.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMails.FlatAppearance.BorderSize = 0
        Me.BtnMails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMails.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMails.ForeColor = System.Drawing.Color.White
        Me.BtnMails.Image = Global.HR.My.Resources.Resources.icons8_download_mail_24
        Me.BtnMails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMails.Location = New System.Drawing.Point(0, 80)
        Me.BtnMails.Name = "BtnMails"
        Me.BtnMails.Size = New System.Drawing.Size(205, 40)
        Me.BtnMails.TabIndex = 9
        Me.BtnMails.Text = "           Mails"
        Me.BtnMails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMails.UseVisualStyleBackColor = False
        '
        'BtComposeMail
        '
        Me.BtComposeMail.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtComposeMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtComposeMail.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtComposeMail.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatAppearance.BorderSize = 0
        Me.BtComposeMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtComposeMail.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtComposeMail.ForeColor = System.Drawing.Color.White
        Me.BtComposeMail.Image = Global.HR.My.Resources.Resources.icons8_composing_mail_24
        Me.BtComposeMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtComposeMail.Location = New System.Drawing.Point(0, 40)
        Me.BtComposeMail.Name = "BtComposeMail"
        Me.BtComposeMail.Size = New System.Drawing.Size(205, 40)
        Me.BtComposeMail.TabIndex = 8
        Me.BtComposeMail.Text = "           Compose Mail"
        Me.BtComposeMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtComposeMail.UseVisualStyleBackColor = False
        '
        'BtSignInAccount
        '
        Me.BtSignInAccount.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtSignInAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtSignInAccount.FlatAppearance.BorderSize = 0
        Me.BtSignInAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSignInAccount.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSignInAccount.ForeColor = System.Drawing.Color.White
        Me.BtSignInAccount.Image = Global.HR.My.Resources.Resources.icons8_gmail_login_24
        Me.BtSignInAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSignInAccount.Location = New System.Drawing.Point(0, 0)
        Me.BtSignInAccount.Name = "BtSignInAccount"
        Me.BtSignInAccount.Size = New System.Drawing.Size(205, 40)
        Me.BtSignInAccount.TabIndex = 11
        Me.BtSignInAccount.Text = "           Sign Into Account"
        Me.BtSignInAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSignInAccount.UseVisualStyleBackColor = False
        '
        'UcMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Name = "UcMail"
        Me.Size = New System.Drawing.Size(211, 441)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents BtnMails As Button
    Friend WithEvents BtComposeMail As Button
    Friend WithEvents BtSignInAccount As Button
End Class
