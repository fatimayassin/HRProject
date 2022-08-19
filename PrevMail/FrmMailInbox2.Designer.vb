<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMailInbox2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtRefresh = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MessageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblRfc822MessageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailDataSet = New HR.EmailDataSet()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtDateDown = New System.Windows.Forms.Button()
        Me.BtDateUp = New System.Windows.Forms.Button()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.ToolStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolMailCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolMailCountNbr = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pop3Client1 = New Email.Net.Pop3.Pop3Client(Me.components)
        Me.TblRfc822MessageTableAdapter = New HR.EmailDataSetTableAdapters.TblRfc822MessageTableAdapter()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRfc822MessageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(452, 46)
        Me.Panel4.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inbox  :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.HR.My.Resources.Resources.icons8_gmail_100
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(385, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 46)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 50)
        Me.Panel1.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtRefresh)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(71, 50)
        Me.Panel3.TabIndex = 0
        '
        'BtRefresh
        '
        Me.BtRefresh.BackgroundImage = Global.HR.My.Resources.Resources.icons8_refresh_48
        Me.BtRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtRefresh.FlatAppearance.BorderSize = 0
        Me.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRefresh.Location = New System.Drawing.Point(0, 0)
        Me.BtRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.BtRefresh.Name = "BtRefresh"
        Me.BtRefresh.Size = New System.Drawing.Size(71, 50)
        Me.BtRefresh.TabIndex = 12
        Me.BtRefresh.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.ssMain)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 401)
        Me.Panel2.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MessageIDDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.MailDateDataGridViewTextBoxColumn, Me.Delete})
        Me.DataGridView1.DataSource = Me.TblRfc822MessageBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(398, 379)
        Me.DataGridView1.TabIndex = 19
        '
        'MessageIDDataGridViewTextBoxColumn
        '
        Me.MessageIDDataGridViewTextBoxColumn.DataPropertyName = "MessageID"
        Me.MessageIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.MessageIDDataGridViewTextBoxColumn.Name = "MessageIDDataGridViewTextBoxColumn"
        Me.MessageIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MessageIDDataGridViewTextBoxColumn.Width = 40
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "From"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        Me.FromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDateDataGridViewTextBoxColumn
        '
        Me.MailDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MailDateDataGridViewTextBoxColumn.DataPropertyName = "MailDate"
        Me.MailDateDataGridViewTextBoxColumn.HeaderText = "MailDate"
        Me.MailDateDataGridViewTextBoxColumn.Name = "MailDateDataGridViewTextBoxColumn"
        Me.MailDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.HR.My.Resources.Resources.icons8_delete_20
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 50
        '
        'TblRfc822MessageBindingSource
        '
        Me.TblRfc822MessageBindingSource.DataMember = "TblRfc822Message"
        Me.TblRfc822MessageBindingSource.DataSource = Me.EmailDataSet
        '
        'EmailDataSet
        '
        Me.EmailDataSet.DataSetName = "EmailDataSet"
        Me.EmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtDateDown)
        Me.Panel5.Controls.Add(Me.BtDateUp)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(398, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(54, 379)
        Me.Panel5.TabIndex = 0
        '
        'BtDateDown
        '
        Me.BtDateDown.BackgroundImage = Global.HR.My.Resources.Resources.icons8_down_arrow_48
        Me.BtDateDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtDateDown.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtDateDown.FlatAppearance.BorderSize = 0
        Me.BtDateDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDateDown.Location = New System.Drawing.Point(0, 79)
        Me.BtDateDown.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDateDown.Name = "BtDateDown"
        Me.BtDateDown.Size = New System.Drawing.Size(54, 79)
        Me.BtDateDown.TabIndex = 14
        Me.BtDateDown.UseVisualStyleBackColor = True
        '
        'BtDateUp
        '
        Me.BtDateUp.BackgroundImage = Global.HR.My.Resources.Resources.icons8_up_48
        Me.BtDateUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtDateUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtDateUp.FlatAppearance.BorderSize = 0
        Me.BtDateUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDateUp.Location = New System.Drawing.Point(0, 0)
        Me.BtDateUp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDateUp.Name = "BtDateUp"
        Me.BtDateUp.Size = New System.Drawing.Size(54, 79)
        Me.BtDateUp.TabIndex = 13
        Me.BtDateUp.UseVisualStyleBackColor = True
        '
        'ssMain
        '
        Me.ssMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStatusLabel, Me.ToolStatus, Me.ToolMailCountLabel, Me.ToolMailCountNbr})
        Me.ssMain.Location = New System.Drawing.Point(0, 379)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(452, 22)
        Me.ssMain.TabIndex = 20
        Me.ssMain.Text = "StatusStrip1"
        '
        'ToolStatusLabel
        '
        Me.ToolStatusLabel.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ToolStatusLabel.Name = "ToolStatusLabel"
        Me.ToolStatusLabel.Size = New System.Drawing.Size(44, 17)
        Me.ToolStatusLabel.Text = "Status:"
        '
        'ToolStatus
        '
        Me.ToolStatus.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStatus.ForeColor = System.Drawing.Color.White
        Me.ToolStatus.Name = "ToolStatus"
        Me.ToolStatus.Size = New System.Drawing.Size(81, 17)
        Me.ToolStatus.Text = "Disconnected"
        '
        'ToolMailCountLabel
        '
        Me.ToolMailCountLabel.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolMailCountLabel.ForeColor = System.Drawing.Color.White
        Me.ToolMailCountLabel.Name = "ToolMailCountLabel"
        Me.ToolMailCountLabel.Size = New System.Drawing.Size(71, 17)
        Me.ToolMailCountLabel.Text = "Mail Count :"
        '
        'ToolMailCountNbr
        '
        Me.ToolMailCountNbr.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolMailCountNbr.ForeColor = System.Drawing.Color.White
        Me.ToolMailCountNbr.Name = "ToolMailCountNbr"
        Me.ToolMailCountNbr.Size = New System.Drawing.Size(14, 17)
        Me.ToolMailCountNbr.Text = "0"
        '
        'Pop3Client1
        '
        Me.Pop3Client1.AttachmentDirectory = ""
        Me.Pop3Client1.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.[Auto]
        Me.Pop3Client1.Host = "localhost"
        Me.Pop3Client1.Password = ""
        Me.Pop3Client1.Port = CType(25US, UShort)
        Me.Pop3Client1.ProxyHost = ""
        Me.Pop3Client1.ProxyPassword = ""
        Me.Pop3Client1.ProxyPort = CType(0US, UShort)
        Me.Pop3Client1.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.Pop3Client1.ProxyUser = ""
        Me.Pop3Client1.ReceiveTimeout = 10000
        Me.Pop3Client1.SendTimeout = 10000
        Me.Pop3Client1.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.Pop3Client1.Username = ""
        '
        'TblRfc822MessageTableAdapter
        '
        Me.TblRfc822MessageTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Delete"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.folderdel
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'FrmMailInbox2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 497)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMailInbox2"
        Me.Text = "FrmMailInbox2"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRfc822MessageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtRefresh As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtDateDown As Button
    Friend WithEvents BtDateUp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents Pop3Client1 As Email.Net.Pop3.Pop3Client
    Friend WithEvents EmailDataSet As EmailDataSet
    Friend WithEvents TblRfc822MessageBindingSource As BindingSource
    Friend WithEvents TblRfc822MessageTableAdapter As EmailDataSetTableAdapters.TblRfc822MessageTableAdapter
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents ToolStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStatus As ToolStripStatusLabel
    Friend WithEvents ToolMailCountLabel As ToolStripStatusLabel
    Friend WithEvents ToolMailCountNbr As ToolStripStatusLabel
    Friend WithEvents MessageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
