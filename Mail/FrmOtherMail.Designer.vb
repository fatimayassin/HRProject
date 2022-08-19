<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOtherMail
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.lblMess = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lbNoopLog = New System.Windows.Forms.ListBox()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelMess = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.ConnBtn = New System.Windows.Forms.Button()
        Me.btnUpdateMess = New System.Windows.Forms.Button()
        Me.DisconnBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lvMessageBrowser = New System.Windows.Forms.ListView()
        Me.chFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pop3Client1 = New Email.Net.Pop3.Pop3Client(Me.components)
        Me.NoopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.fromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attachments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Messages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel8.Controls.Add(Me.panel9)
        Me.Panel8.Controls.Add(Me.label16)
        Me.Panel8.Controls.Add(Me.label15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 476)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1178, 26)
        Me.Panel8.TabIndex = 21
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.lblMess)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel9.Location = New System.Drawing.Point(1001, 0)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(177, 26)
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
        Me.label16.Location = New System.Drawing.Point(58, 3)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(0, 15)
        Me.label16.TabIndex = 3
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(8, 3)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(44, 15)
        Me.label15.TabIndex = 2
        Me.label15.Text = "Status:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.splitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 133)
        Me.Panel1.TabIndex = 22
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
        Me.splitContainer2.Size = New System.Drawing.Size(1178, 133)
        Me.splitContainer2.SplitterDistance = 416
        Me.splitContainer2.TabIndex = 22
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
        Me.lbNoopLog.Size = New System.Drawing.Size(416, 133)
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
        Me.lbLog.Size = New System.Drawing.Size(758, 133)
        Me.lbLog.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelMess)
        Me.Panel2.Controls.Add(Me.label10)
        Me.Panel2.Controls.Add(Me.comboBox1)
        Me.Panel2.Controls.Add(Me.ConnBtn)
        Me.Panel2.Controls.Add(Me.btnUpdateMess)
        Me.Panel2.Controls.Add(Me.DisconnBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1178, 34)
        Me.Panel2.TabIndex = 26
        '
        'btnDelMess
        '
        Me.btnDelMess.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDelMess.FlatAppearance.BorderSize = 0
        Me.btnDelMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelMess.ForeColor = System.Drawing.Color.White
        Me.btnDelMess.Location = New System.Drawing.Point(1032, 4)
        Me.btnDelMess.Name = "btnDelMess"
        Me.btnDelMess.Size = New System.Drawing.Size(84, 27)
        Me.btnDelMess.TabIndex = 25
        Me.btnDelMess.Text = "Del Marked"
        Me.btnDelMess.UseVisualStyleBackColor = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(775, 10)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(99, 15)
        Me.label10.TabIndex = 27
        Me.label10.Text = "Do with checked:"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"None", "Copy To", "Mark Seen", "Mark UnSeen", "Mark To Delete", "Mark UnDelete", "SetFlags"})
        Me.comboBox1.Location = New System.Drawing.Point(881, 6)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(140, 23)
        Me.comboBox1.TabIndex = 26
        '
        'ConnBtn
        '
        Me.ConnBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.ConnBtn.FlatAppearance.BorderSize = 0
        Me.ConnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnBtn.ForeColor = System.Drawing.Color.White
        Me.ConnBtn.Location = New System.Drawing.Point(3, 3)
        Me.ConnBtn.Name = "ConnBtn"
        Me.ConnBtn.Size = New System.Drawing.Size(87, 27)
        Me.ConnBtn.TabIndex = 22
        Me.ConnBtn.Text = "Connect"
        Me.ConnBtn.UseVisualStyleBackColor = False
        '
        'btnUpdateMess
        '
        Me.btnUpdateMess.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdateMess.FlatAppearance.BorderSize = 0
        Me.btnUpdateMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateMess.ForeColor = System.Drawing.Color.White
        Me.btnUpdateMess.Location = New System.Drawing.Point(499, 4)
        Me.btnUpdateMess.Name = "btnUpdateMess"
        Me.btnUpdateMess.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdateMess.TabIndex = 24
        Me.btnUpdateMess.Text = "Refresh"
        Me.btnUpdateMess.UseVisualStyleBackColor = False
        '
        'DisconnBtn
        '
        Me.DisconnBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.DisconnBtn.Enabled = False
        Me.DisconnBtn.FlatAppearance.BorderSize = 0
        Me.DisconnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisconnBtn.ForeColor = System.Drawing.Color.White
        Me.DisconnBtn.Location = New System.Drawing.Point(96, 3)
        Me.DisconnBtn.Name = "DisconnBtn"
        Me.DisconnBtn.Size = New System.Drawing.Size(87, 27)
        Me.DisconnBtn.TabIndex = 23
        Me.DisconnBtn.Text = "Disconnect"
        Me.DisconnBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvMessages)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 118)
        Me.Panel3.TabIndex = 27
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
        Me.dgvMessages.Size = New System.Drawing.Size(1178, 118)
        Me.dgvMessages.TabIndex = 9
        '
        'dsMess
        '
        Me.dsMess.DataSetName = "NewDataSet"
        Me.dsMess.Tables.AddRange(New System.Data.DataTable() {Me.Messages})
        '
        'Messages
        '
        Me.Messages.Columns.AddRange(New System.Data.DataColumn() {Me.AttachmentsCol, Me.SubjectCol, Me.FromCol, Me.DateCol, Me.UIDCol, Me.SeenCol, Me.dataColumn1, Me.Flags})
        Me.Messages.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"UID"}, False)})
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
        Me.UIDCol.AutoIncrement = True
        Me.UIDCol.ColumnName = "UID"
        Me.UIDCol.DataType = GetType(Short)
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lvMessageBrowser)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 152)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1178, 191)
        Me.Panel4.TabIndex = 28
        '
        'lvMessageBrowser
        '
        Me.lvMessageBrowser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFrom, Me.chSubject, Me.chDate})
        Me.lvMessageBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMessageBrowser.HideSelection = False
        Me.lvMessageBrowser.Location = New System.Drawing.Point(0, 0)
        Me.lvMessageBrowser.Name = "lvMessageBrowser"
        Me.lvMessageBrowser.Size = New System.Drawing.Size(1178, 191)
        Me.lvMessageBrowser.TabIndex = 2
        Me.lvMessageBrowser.UseCompatibleStateImageBehavior = False
        Me.lvMessageBrowser.View = System.Windows.Forms.View.Details
        '
        'chFrom
        '
        Me.chFrom.Text = "From"
        Me.chFrom.Width = 252
        '
        'chSubject
        '
        Me.chSubject.Text = "Subject"
        Me.chSubject.Width = 281
        '
        'chDate
        '
        Me.chDate.Text = "Date"
        Me.chDate.Width = 449
        '
        'Pop3Client1
        '
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
        'NoopTimer
        '
        Me.NoopTimer.Enabled = True
        Me.NoopTimer.Interval = 1000
        '
        'toolTip
        '
        Me.toolTip.AutoPopDelay = 2000
        Me.toolTip.InitialDelay = 500
        Me.toolTip.ReshowDelay = 100
        Me.toolTip.UseAnimation = False
        Me.toolTip.UseFading = False
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
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 502)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1178, 17)
        Me.Panel5.TabIndex = 29
        '
        'FrmOtherMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 519)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOtherMail"
        Me.Text = "FrmOtherMail"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Messages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel8 As Panel
    Private WithEvents panel9 As Panel
    Private WithEvents lblMess As Label
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents splitContainer2 As SplitContainer
    Private WithEvents lbNoopLog As ListBox
    Private WithEvents lbLog As ListBox
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnDelMess As Button
    Private WithEvents label10 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents ConnBtn As Button
    Private WithEvents btnUpdateMess As Button
    Private WithEvents DisconnBtn As Button
    Friend WithEvents Panel3 As Panel
    Private WithEvents dgvMessages As DataGridView
    Friend WithEvents Panel4 As Panel
    Private WithEvents lvMessageBrowser As ListView
    Private WithEvents chFrom As ColumnHeader
    Private WithEvents chSubject As ColumnHeader
    Private WithEvents chDate As ColumnHeader
    Friend WithEvents Pop3Client1 As Email.Net.Pop3.Pop3Client
    Private WithEvents NoopTimer As Timer
    Private WithEvents toolTip As ToolTip
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
    Friend WithEvents fromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents subjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Attachments As DataGridViewTextBoxColumn
    Friend WithEvents Seen As DataGridViewImageColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents Flag As DataGridViewImageColumn
    Friend WithEvents Panel5 As Panel
End Class
