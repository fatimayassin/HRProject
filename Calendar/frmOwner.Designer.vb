<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwner
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.chkLocked = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chkVisible = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lblEmail = New Infragistics.Win.Misc.UltraLabel()
        Me.txtEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblName = New Infragistics.Win.Misc.UltraLabel()
        Me.txtName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblKey = New Infragistics.Win.Misc.UltraLabel()
        Me.txtKey = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmdOk = New Infragistics.Win.Misc.UltraButton()
        Me.cmdCancel = New Infragistics.Win.Misc.UltraButton()
        CType(Me.chkLocked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkLocked
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.chkLocked.Appearance = Appearance1
        Me.chkLocked.BackColor = System.Drawing.Color.Transparent
        Me.chkLocked.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkLocked.Location = New System.Drawing.Point(4, 148)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(248, 24)
        Me.chkLocked.TabIndex = 37
        Me.chkLocked.Text = "This owner's data is accessible through the user interface"
        '
        'chkVisible
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.chkVisible.Appearance = Appearance2
        Me.chkVisible.BackColor = System.Drawing.Color.Transparent
        Me.chkVisible.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkVisible.Location = New System.Drawing.Point(4, 116)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(248, 21)
        Me.chkVisible.TabIndex = 36
        Me.chkVisible.Text = "This owner is visible in the user interface"
        '
        'lblEmail
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.TextHAlignAsString = "Right"
        Appearance3.TextVAlignAsString = "Middle"
        Me.lblEmail.Appearance = Appearance3
        Me.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmail.Location = New System.Drawing.Point(12, 76)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 34
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(68, 76)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(208, 21)
        Me.txtEmail.TabIndex = 35
        Me.txtEmail.Text = "[Email]"
        '
        'lblName
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.TextHAlignAsString = "Right"
        Appearance4.TextVAlignAsString = "Middle"
        Me.lblName.Appearance = Appearance4
        Me.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblName.Location = New System.Drawing.Point(12, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 20)
        Me.lblName.TabIndex = 32
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 21)
        Me.txtName.TabIndex = 33
        Me.txtName.Text = "[Name]"
        '
        'lblKey
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.TextHAlignAsString = "Right"
        Appearance5.TextVAlignAsString = "Middle"
        Me.lblKey.Appearance = Appearance5
        Me.lblKey.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKey.Location = New System.Drawing.Point(12, 12)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(48, 21)
        Me.lblKey.TabIndex = 30
        Me.lblKey.Text = "Key:"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(68, 12)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(208, 21)
        Me.txtKey.TabIndex = 31
        Me.txtKey.Text = "[Key]"
        '
        'cmdOk
        '
        Me.cmdOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOk.Location = New System.Drawing.Point(62, 189)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 28
        Me.cmdOk.Text = "Ok"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCancel.Location = New System.Drawing.Point(150, 189)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancel.TabIndex = 29
        Me.cmdCancel.Text = "Cancel"
        '
        'frmOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 229)
        Me.Controls.Add(Me.chkLocked)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Name = "frmOwner"
        Me.Text = "frmOwner"
        CType(Me.chkLocked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkLocked As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkVisible As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lblEmail As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblName As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblKey As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtKey As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmdOk As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmdCancel As Infragistics.Win.Misc.UltraButton
End Class
