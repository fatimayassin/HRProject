<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMail
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.trFolders = New System.Windows.Forms.TreeView()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.btnSelFolder = New System.Windows.Forms.Button()
        Me.btnRenameFolder = New System.Windows.Forms.Button()
        Me.ConnBtn = New System.Windows.Forms.Button()
        Me.btnDeleteFolder = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnNewFolder = New System.Windows.Forms.Button()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.DisconnBtn = New System.Windows.Forms.Button()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.dgvMessages = New System.Windows.Forms.DataGridView()
        Me.dsMess = New System.Data.DataSet()
        Me.Messages = New System.Data.DataTable()
        Me.AttachmentsCol = New System.Data.DataColumn()
        Me.SubjectCol = New System.Data.DataColumn()
        Me.FromCol = New System.Data.DataColumn()
        Me.DateCol = New System.Data.DataColumn()
        Me.UIDCol = New System.Data.DataColumn()
        Me.SeenCol = New System.Data.DataColumn()
        Me.dataColumn1 = New System.Data.DataColumn()
        Me.Flags = New System.Data.DataColumn()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btnDelMess = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnUpdateMess = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.lblMess = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.dsSearchMess = New System.Data.DataSet()
        Me.dataTable1 = New System.Data.DataTable()
        Me.dataColumn2 = New System.Data.DataColumn()
        Me.dataColumn3 = New System.Data.DataColumn()
        Me.dataColumn4 = New System.Data.DataColumn()
        Me.dataColumn5 = New System.Data.DataColumn()
        Me.dataColumn6 = New System.Data.DataColumn()
        Me.dataColumn7 = New System.Data.DataColumn()
        Me.dataColumn8 = New System.Data.DataColumn()
        Me.dataColumn9 = New System.Data.DataColumn()
        Me.NoopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.iClient = New Email.Net.Imap.ImapClient(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lbNoopLog = New System.Windows.Forms.ListBox()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.fromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attachments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel10.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Messages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        CType(Me.dsSearchMess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.splitContainer1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1245, 523)
        Me.Panel10.TabIndex = 22
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.LightBlue
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.trFolders)
        Me.splitContainer1.Panel1.Controls.Add(Me.panel7)
        Me.splitContainer1.Panel1.Controls.Add(Me.panel6)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.panel3)
        Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
        Me.splitContainer1.Size = New System.Drawing.Size(1245, 523)
        Me.splitContainer1.SplitterDistance = 277
        Me.splitContainer1.SplitterWidth = 6
        Me.splitContainer1.TabIndex = 18
        '
        'trFolders
        '
        Me.trFolders.BackColor = System.Drawing.SystemColors.MenuBar
        Me.trFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trFolders.HideSelection = False
        Me.trFolders.Location = New System.Drawing.Point(0, 84)
        Me.trFolders.Name = "trFolders"
        Me.trFolders.Size = New System.Drawing.Size(277, 399)
        Me.trFolders.TabIndex = 2
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.btnSelFolder)
        Me.panel7.Controls.Add(Me.btnRenameFolder)
        Me.panel7.Controls.Add(Me.ConnBtn)
        Me.panel7.Controls.Add(Me.btnDeleteFolder)
        Me.panel7.Controls.Add(Me.label1)
        Me.panel7.Controls.Add(Me.btnNewFolder)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Location = New System.Drawing.Point(0, 0)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(277, 84)
        Me.panel7.TabIndex = 1
        '
        'btnSelFolder
        '
        Me.btnSelFolder.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSelFolder.FlatAppearance.BorderSize = 0
        Me.btnSelFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelFolder.ForeColor = System.Drawing.Color.White
        Me.btnSelFolder.Location = New System.Drawing.Point(72, 46)
        Me.btnSelFolder.Name = "btnSelFolder"
        Me.btnSelFolder.Size = New System.Drawing.Size(35, 31)
        Me.btnSelFolder.TabIndex = 15
        Me.btnSelFolder.Text = "Sel"
        Me.btnSelFolder.UseVisualStyleBackColor = False
        '
        'btnRenameFolder
        '
        Me.btnRenameFolder.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRenameFolder.FlatAppearance.BorderSize = 0
        Me.btnRenameFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenameFolder.ForeColor = System.Drawing.Color.White
        Me.btnRenameFolder.Location = New System.Drawing.Point(163, 46)
        Me.btnRenameFolder.Name = "btnRenameFolder"
        Me.btnRenameFolder.Size = New System.Drawing.Size(36, 31)
        Me.btnRenameFolder.TabIndex = 10
        Me.btnRenameFolder.Text = "Ren"
        Me.btnRenameFolder.UseVisualStyleBackColor = False
        '
        'ConnBtn
        '
        Me.ConnBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.ConnBtn.FlatAppearance.BorderSize = 0
        Me.ConnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnBtn.ForeColor = System.Drawing.Color.White
        Me.ConnBtn.Location = New System.Drawing.Point(6, 3)
        Me.ConnBtn.Name = "ConnBtn"
        Me.ConnBtn.Size = New System.Drawing.Size(101, 31)
        Me.ConnBtn.TabIndex = 0
        Me.ConnBtn.Text = "Connect"
        Me.ConnBtn.UseVisualStyleBackColor = False
        '
        'btnDeleteFolder
        '
        Me.btnDeleteFolder.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDeleteFolder.FlatAppearance.BorderSize = 0
        Me.btnDeleteFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFolder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteFolder.Location = New System.Drawing.Point(205, 45)
        Me.btnDeleteFolder.Name = "btnDeleteFolder"
        Me.btnDeleteFolder.Size = New System.Drawing.Size(42, 31)
        Me.btnDeleteFolder.TabIndex = 9
        Me.btnDeleteFolder.Text = "Del"
        Me.btnDeleteFolder.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 53)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 3
        Me.label1.Text = "All Folders:"
        '
        'btnNewFolder
        '
        Me.btnNewFolder.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNewFolder.FlatAppearance.BorderSize = 0
        Me.btnNewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewFolder.ForeColor = System.Drawing.Color.White
        Me.btnNewFolder.Location = New System.Drawing.Point(113, 46)
        Me.btnNewFolder.Name = "btnNewFolder"
        Me.btnNewFolder.Size = New System.Drawing.Size(44, 31)
        Me.btnNewFolder.TabIndex = 8
        Me.btnNewFolder.Text = "New"
        Me.btnNewFolder.UseVisualStyleBackColor = False
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.DisconnBtn)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel6.Location = New System.Drawing.Point(0, 483)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(277, 40)
        Me.panel6.TabIndex = 0
        '
        'DisconnBtn
        '
        Me.DisconnBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.DisconnBtn.Enabled = False
        Me.DisconnBtn.FlatAppearance.BorderSize = 0
        Me.DisconnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisconnBtn.ForeColor = System.Drawing.Color.White
        Me.DisconnBtn.Location = New System.Drawing.Point(6, 5)
        Me.DisconnBtn.Name = "DisconnBtn"
        Me.DisconnBtn.Size = New System.Drawing.Size(101, 31)
        Me.DisconnBtn.TabIndex = 1
        Me.DisconnBtn.Text = "Disconnect"
        Me.DisconnBtn.UseVisualStyleBackColor = False
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.dgvMessages)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 54)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(962, 469)
        Me.panel3.TabIndex = 1
        '
        'dgvMessages
        '
        Me.dgvMessages.AllowUserToAddRows = False
        Me.dgvMessages.AllowUserToDeleteRows = False
        Me.dgvMessages.AutoGenerateColumns = False
        Me.dgvMessages.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMessages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fromDataGridViewTextBoxColumn, Me.subjectDataGridViewTextBoxColumn, Me.dateDataGridViewTextBoxColumn, Me.Attachments, Me.Seen, Me.Del, Me.Sel, Me.Flag})
        Me.dgvMessages.DataMember = "Messages"
        Me.dgvMessages.DataSource = Me.dsMess
        Me.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMessages.Location = New System.Drawing.Point(0, 0)
        Me.dgvMessages.MultiSelect = False
        Me.dgvMessages.Name = "dgvMessages"
        Me.dgvMessages.ReadOnly = True
        Me.dgvMessages.RowHeadersVisible = False
        Me.dgvMessages.RowTemplate.Height = 18
        Me.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMessages.Size = New System.Drawing.Size(962, 469)
        Me.dgvMessages.TabIndex = 7
        '
        'dsMess
        '
        Me.dsMess.DataSetName = "NewDataSet"
        Me.dsMess.Tables.AddRange(New System.Data.DataTable() {Me.Messages})
        '
        'Messages
        '
        Me.Messages.Columns.AddRange(New System.Data.DataColumn() {Me.AttachmentsCol, Me.SubjectCol, Me.FromCol, Me.DateCol, Me.UIDCol, Me.SeenCol, Me.dataColumn1, Me.Flags})
        Me.Messages.TableName = "Messages"
        '
        'AttachmentsCol
        '
        Me.AttachmentsCol.ColumnName = "Attachments"
        '
        'SubjectCol
        '
        Me.SubjectCol.ColumnName = "Subject"
        '
        'FromCol
        '
        Me.FromCol.ColumnName = "From"
        '
        'DateCol
        '
        Me.DateCol.ColumnName = "Date"
        '
        'UIDCol
        '
        Me.UIDCol.ColumnName = "UID"
        Me.UIDCol.DataType = GetType(UInteger)
        '
        'SeenCol
        '
        Me.SeenCol.ColumnName = "Seen"
        Me.SeenCol.DataType = GetType(Integer)
        '
        'dataColumn1
        '
        Me.dataColumn1.ColumnName = "Del"
        Me.dataColumn1.DataType = GetType(Boolean)
        Me.dataColumn1.DefaultValue = False
        '
        'Flags
        '
        Me.Flags.Caption = "Flags"
        Me.Flags.ColumnName = "Flags"
        Me.Flags.DataType = GetType(Object)
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.panel5)
        Me.panel2.Controls.Add(Me.panel4)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(962, 54)
        Me.panel2.TabIndex = 0
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.btnDelMess)
        Me.panel5.Controls.Add(Me.label10)
        Me.panel5.Controls.Add(Me.comboBox1)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel5.Location = New System.Drawing.Point(471, 0)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(491, 54)
        Me.panel5.TabIndex = 1
        '
        'btnDelMess
        '
        Me.btnDelMess.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDelMess.FlatAppearance.BorderSize = 0
        Me.btnDelMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelMess.ForeColor = System.Drawing.Color.White
        Me.btnDelMess.Location = New System.Drawing.Point(390, 16)
        Me.btnDelMess.Name = "btnDelMess"
        Me.btnDelMess.Size = New System.Drawing.Size(78, 31)
        Me.btnDelMess.TabIndex = 11
        Me.btnDelMess.Text = "Del Marked"
        Me.btnDelMess.UseVisualStyleBackColor = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(90, 23)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(99, 15)
        Me.label10.TabIndex = 13
        Me.label10.Text = "Do with checked:"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"None", "Copy To", "Mark Seen", "Mark UnSeen", "Mark To Delete", "Mark UnDelete", "SetFlags"})
        Me.comboBox1.Location = New System.Drawing.Point(213, 18)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(163, 23)
        Me.comboBox1.TabIndex = 12
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.label9)
        Me.panel4.Controls.Add(Me.btnUpdateMess)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(238, 54)
        Me.panel4.TabIndex = 0
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(3, 24)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(60, 15)
        Me.label9.TabIndex = 4
        Me.label9.Text = "Messages:"
        '
        'btnUpdateMess
        '
        Me.btnUpdateMess.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdateMess.FlatAppearance.BorderSize = 0
        Me.btnUpdateMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateMess.ForeColor = System.Drawing.Color.White
        Me.btnUpdateMess.Location = New System.Drawing.Point(92, 15)
        Me.btnUpdateMess.Name = "btnUpdateMess"
        Me.btnUpdateMess.Size = New System.Drawing.Size(71, 31)
        Me.btnUpdateMess.TabIndex = 14
        Me.btnUpdateMess.Text = "Refresh"
        Me.btnUpdateMess.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel8.Controls.Add(Me.panel9)
        Me.Panel8.Controls.Add(Me.label16)
        Me.Panel8.Controls.Add(Me.label15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 638)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1245, 30)
        Me.Panel8.TabIndex = 23
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.lblMess)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel9.Location = New System.Drawing.Point(1039, 0)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(206, 30)
        Me.panel9.TabIndex = 4
        '
        'lblMess
        '
        Me.lblMess.AutoSize = True
        Me.lblMess.ForeColor = System.Drawing.Color.White
        Me.lblMess.Location = New System.Drawing.Point(3, 3)
        Me.lblMess.Name = "lblMess"
        Me.lblMess.Size = New System.Drawing.Size(60, 15)
        Me.lblMess.TabIndex = 2
        Me.lblMess.Text = "Messages:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(68, 3)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(0, 15)
        Me.label16.TabIndex = 3
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(9, 3)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(44, 15)
        Me.label15.TabIndex = 2
        Me.label15.Text = "Status:"
        '
        'dsSearchMess
        '
        Me.dsSearchMess.DataSetName = "NewDataSet"
        Me.dsSearchMess.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
        '
        'dataTable1
        '
        Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn2, Me.dataColumn3, Me.dataColumn4, Me.dataColumn5, Me.dataColumn6, Me.dataColumn7, Me.dataColumn8, Me.dataColumn9})
        Me.dataTable1.TableName = "Messages"
        '
        'dataColumn2
        '
        Me.dataColumn2.ColumnName = "Attachments"
        '
        'dataColumn3
        '
        Me.dataColumn3.ColumnName = "Subject"
        '
        'dataColumn4
        '
        Me.dataColumn4.ColumnName = "From"
        '
        'dataColumn5
        '
        Me.dataColumn5.ColumnName = "Date"
        '
        'dataColumn6
        '
        Me.dataColumn6.ColumnName = "UID"
        Me.dataColumn6.DataType = GetType(UInteger)
        '
        'dataColumn7
        '
        Me.dataColumn7.ColumnName = "Seen"
        Me.dataColumn7.DataType = GetType(Integer)
        '
        'dataColumn8
        '
        Me.dataColumn8.ColumnName = "Del"
        Me.dataColumn8.DataType = GetType(Boolean)
        Me.dataColumn8.DefaultValue = False
        '
        'dataColumn9
        '
        Me.dataColumn9.Caption = "Flags"
        Me.dataColumn9.ColumnName = "Flags"
        Me.dataColumn9.DataType = GetType(Object)
        '
        'NoopTimer
        '
        Me.NoopTimer.Enabled = True
        Me.NoopTimer.Interval = 1000
        '
        'iClient
        '
        Me.iClient.AttachmentDirectory = ""
        Me.iClient.AuthenticationType = Email.Net.Common.Configurations.EAuthenticationType.[Auto]
        Me.iClient.Host = "localhost"
        Me.iClient.Password = Nothing
        Me.iClient.Port = CType(25US, UShort)
        Me.iClient.ProxyPort = CType(0US, UShort)
        Me.iClient.ProxyType = Email.Net.Common.Configurations.EProxyType.No
        Me.iClient.ReceiveTimeout = 10000
        Me.iClient.SendTimeout = 10000
        Me.iClient.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.Plain
        Me.iClient.Username = Nothing
        '
        'toolTip
        '
        Me.toolTip.AutoPopDelay = 2000
        Me.toolTip.InitialDelay = 500
        Me.toolTip.ReshowDelay = 100
        Me.toolTip.UseAnimation = False
        Me.toolTip.UseFading = False
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.lbNoopLog)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.lbLog)
        Me.splitContainer2.Size = New System.Drawing.Size(1245, 115)
        Me.splitContainer2.SplitterDistance = 439
        Me.splitContainer2.SplitterWidth = 5
        Me.splitContainer2.TabIndex = 3
        '
        'lbNoopLog
        '
        Me.lbNoopLog.BackColor = System.Drawing.SystemColors.Info
        Me.lbNoopLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbNoopLog.FormattingEnabled = True
        Me.lbNoopLog.HorizontalScrollbar = True
        Me.lbNoopLog.ItemHeight = 15
        Me.lbNoopLog.Location = New System.Drawing.Point(0, 0)
        Me.lbNoopLog.Name = "lbNoopLog"
        Me.lbNoopLog.Size = New System.Drawing.Size(439, 115)
        Me.lbNoopLog.TabIndex = 0
        '
        'lbLog
        '
        Me.lbLog.BackColor = System.Drawing.SystemColors.Info
        Me.lbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.HorizontalScrollbar = True
        Me.lbLog.ItemHeight = 15
        Me.lbLog.Location = New System.Drawing.Point(0, 0)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(801, 115)
        Me.lbLog.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.splitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 523)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 115)
        Me.Panel1.TabIndex = 24
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 668)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1245, 10)
        Me.Panel11.TabIndex = 25
        '
        'fromDataGridViewTextBoxColumn
        '
        Me.fromDataGridViewTextBoxColumn.DataPropertyName = "From"
        Me.fromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn"
        Me.fromDataGridViewTextBoxColumn.ReadOnly = True
        Me.fromDataGridViewTextBoxColumn.Width = 150
        '
        'subjectDataGridViewTextBoxColumn
        '
        Me.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.subjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn"
        Me.subjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dateDataGridViewTextBoxColumn
        '
        Me.dateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.dateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn"
        Me.dateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Attachments
        '
        Me.Attachments.DataPropertyName = "Attachments"
        Me.Attachments.HeaderText = "Attachments"
        Me.Attachments.Name = "Attachments"
        Me.Attachments.ReadOnly = True
        Me.Attachments.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Seen
        '
        Me.Seen.HeaderText = "Seen"
        Me.Seen.Image = Global.HR.My.Resources.Resources.seen1
        Me.Seen.Name = "Seen"
        Me.Seen.ReadOnly = True
        Me.Seen.Width = 35
        '
        'Del
        '
        Me.Del.HeaderText = "Del"
        Me.Del.Image = Global.HR.My.Resources.Resources.kor2
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Width = 35
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sel.ToolTipText = "Sel"
        Me.Sel.Width = 30
        '
        'Flag
        '
        Me.Flag.HeaderText = "Flag"
        Me.Flag.Image = Global.HR.My.Resources.Resources.flag
        Me.Flag.Name = "Flag"
        Me.Flag.ReadOnly = True
        Me.Flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Flag.ToolTipText = "Look flags"
        Me.Flag.Width = 30
        '
        'FrmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 678)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel11)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMail"
        Me.Text = "FrmMail"
        Me.Panel10.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.panel6.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Messages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        CType(Me.dsSearchMess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel10 As Panel
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents trFolders As TreeView
    Private WithEvents panel7 As Panel
    Private WithEvents btnSelFolder As Button
    Private WithEvents btnRenameFolder As Button
    Private WithEvents ConnBtn As Button
    Private WithEvents btnDeleteFolder As Button
    Private WithEvents label1 As Label
    Private WithEvents btnNewFolder As Button
    Private WithEvents panel6 As Panel
    Private WithEvents DisconnBtn As Button
    Private WithEvents panel3 As Panel
    Private WithEvents dgvMessages As DataGridView
    Private WithEvents panel2 As Panel
    Private WithEvents panel5 As Panel
    Private WithEvents btnDelMess As Button
    Private WithEvents label10 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents panel4 As Panel
    Private WithEvents label9 As Label
    Private WithEvents btnUpdateMess As Button
    Friend WithEvents Panel8 As Panel
    Private WithEvents panel9 As Panel
    Private WithEvents lblMess As Label
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Private WithEvents dsMess As DataSet
    Private WithEvents Messages As DataTable
    Private WithEvents AttachmentsCol As DataColumn
    Private WithEvents SubjectCol As DataColumn
    Private WithEvents FromCol As DataColumn
    Private WithEvents DateCol As DataColumn
    Private WithEvents UIDCol As DataColumn
    Private WithEvents SeenCol As DataColumn
    Private WithEvents dataColumn1 As DataColumn
    Private WithEvents Flags As DataColumn
    Private WithEvents dsSearchMess As DataSet
    Private WithEvents dataTable1 As DataTable
    Private WithEvents dataColumn2 As DataColumn
    Private WithEvents dataColumn3 As DataColumn
    Private WithEvents dataColumn4 As DataColumn
    Private WithEvents dataColumn5 As DataColumn
    Private WithEvents dataColumn6 As DataColumn
    Private WithEvents dataColumn7 As DataColumn
    Private WithEvents dataColumn8 As DataColumn
    Private WithEvents dataColumn9 As DataColumn
    Private WithEvents NoopTimer As Timer
    Private WithEvents iClient As Email.Net.Imap.ImapClient
    Private WithEvents toolTip As ToolTip
    Private WithEvents splitContainer2 As SplitContainer
    Private WithEvents lbNoopLog As ListBox
    Private WithEvents lbLog As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents fromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents subjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Attachments As DataGridViewTextBoxColumn
    Friend WithEvents Seen As DataGridViewImageColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents Flag As DataGridViewImageColumn
End Class
