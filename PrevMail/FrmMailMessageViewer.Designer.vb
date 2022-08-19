<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMailMessageViewer
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
        Dim ssMain As System.Windows.Forms.StatusStrip
        Dim MailDateLabel As System.Windows.Forms.Label
        Dim splitContainer1 As System.Windows.Forms.SplitContainer
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbBody = New System.Windows.Forms.RichTextBox()
        Me.wbBody = New System.Windows.Forms.WebBrowser()
        Me.tcMessage = New System.Windows.Forms.TabControl()
        Me.tpMailMessage = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MailDateLabel1 = New System.Windows.Forms.Label()
        Me.tbBcc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbSubject = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tbCc = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbTo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbFrom = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblMailAttachmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailDataSet = New HR.EmailDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblMailAttachmentsTableAdapter = New HR.EmailDataSetTableAdapters.TblMailAttachmentsTableAdapter()
        Me.TblRfc822MessageTableAdapter = New HR.EmailDataSetTableAdapters.TblRfc822MessageTableAdapter()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblRfc822MessageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttachmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewImageColumn()
        ssMain = New System.Windows.Forms.StatusStrip()
        MailDateLabel = New System.Windows.Forms.Label()
        splitContainer1 = New System.Windows.Forms.SplitContainer()
        ssMain.SuspendLayout()
        CType(splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.Panel2.SuspendLayout()
        splitContainer1.SuspendLayout()
        Me.tcMessage.SuspendLayout()
        Me.tpMailMessage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMailAttachmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblRfc822MessageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssMain
        '
        ssMain.Dock = System.Windows.Forms.DockStyle.Fill
        ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        ssMain.Location = New System.Drawing.Point(0, 0)
        ssMain.Name = "ssMain"
        ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 25, 0)
        ssMain.Size = New System.Drawing.Size(764, 25)
        ssMain.TabIndex = 7
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(112, 20)
        Me.ToolStripStatusLabel2.Text = "Attachment Count:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(82, 20)
        Me.ToolStripStatusLabel1.Text = "Attachment #"
        '
        'MailDateLabel
        '
        MailDateLabel.AutoSize = True
        MailDateLabel.Location = New System.Drawing.Point(432, 11)
        MailDateLabel.Name = "MailDateLabel"
        MailDateLabel.Size = New System.Drawing.Size(70, 16)
        MailDateLabel.TabIndex = 25
        MailDateLabel.Text = "Mail Date:"
        '
        'splitContainer1
        '
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        splitContainer1.Location = New System.Drawing.Point(0, 0)
        splitContainer1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        splitContainer1.Name = "splitContainer1"
        splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        splitContainer1.Panel1.Controls.Add(Me.tbBody)
        '
        'splitContainer1.Panel2
        '
        splitContainer1.Panel2.Controls.Add(Me.wbBody)
        splitContainer1.Size = New System.Drawing.Size(764, 235)
        splitContainer1.SplitterDistance = 119
        splitContainer1.SplitterWidth = 7
        splitContainer1.TabIndex = 12
        '
        'tbBody
        '
        Me.tbBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbBody.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "tbBody", True))
        Me.tbBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBody.Location = New System.Drawing.Point(0, 0)
        Me.tbBody.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbBody.Name = "tbBody"
        Me.tbBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.tbBody.Size = New System.Drawing.Size(764, 119)
        Me.tbBody.TabIndex = 11
        Me.tbBody.Text = ""
        '
        'wbBody
        '
        Me.wbBody.DataBindings.Add(New System.Windows.Forms.Binding("Url", Me.TblRfc822MessageBindingSource, "wbBody", True))
        Me.wbBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbBody.Location = New System.Drawing.Point(0, 0)
        Me.wbBody.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.wbBody.MinimumSize = New System.Drawing.Size(48, 38)
        Me.wbBody.Name = "wbBody"
        Me.wbBody.Size = New System.Drawing.Size(764, 109)
        Me.wbBody.TabIndex = 12
        '
        'tcMessage
        '
        Me.tcMessage.Controls.Add(Me.tpMailMessage)
        Me.tcMessage.Controls.Add(Me.tabPage2)
        Me.tcMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMessage.Location = New System.Drawing.Point(0, 0)
        Me.tcMessage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tcMessage.Name = "tcMessage"
        Me.tcMessage.SelectedIndex = 0
        Me.tcMessage.Size = New System.Drawing.Size(786, 497)
        Me.tcMessage.TabIndex = 4
        '
        'tpMailMessage
        '
        Me.tpMailMessage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tpMailMessage.Controls.Add(Me.Panel4)
        Me.tpMailMessage.Controls.Add(Me.Panel3)
        Me.tpMailMessage.Location = New System.Drawing.Point(4, 25)
        Me.tpMailMessage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpMailMessage.Name = "tpMailMessage"
        Me.tpMailMessage.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpMailMessage.Size = New System.Drawing.Size(778, 468)
        Me.tpMailMessage.TabIndex = 0
        Me.tpMailMessage.Text = "MailMessage"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(splitContainer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(7, 227)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 235)
        Me.Panel4.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(7, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 221)
        Me.Panel3.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(MailDateLabel)
        Me.Panel2.Controls.Add(Me.MailDateLabel1)
        Me.Panel2.Controls.Add(Me.tbBcc)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tbSubject)
        Me.Panel2.Controls.Add(Me.label4)
        Me.Panel2.Controls.Add(Me.tbCc)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.tbTo)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.tbFrom)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 221)
        Me.Panel2.TabIndex = 11
        '
        'MailDateLabel1
        '
        Me.MailDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "MailDate", True))
        Me.MailDateLabel1.Location = New System.Drawing.Point(508, 11)
        Me.MailDateLabel1.Name = "MailDateLabel1"
        Me.MailDateLabel1.Size = New System.Drawing.Size(239, 23)
        Me.MailDateLabel1.TabIndex = 26
        Me.MailDateLabel1.Text = "Label6"
        '
        'tbBcc
        '
        Me.tbBcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBcc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "Bcc", True))
        Me.tbBcc.Location = New System.Drawing.Point(121, 149)
        Me.tbBcc.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbBcc.Name = "tbBcc"
        Me.tbBcc.Size = New System.Drawing.Size(627, 23)
        Me.tbBcc.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bcc:"
        '
        'tbSubject
        '
        Me.tbSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "Subject", True))
        Me.tbSubject.Location = New System.Drawing.Point(121, 184)
        Me.tbSubject.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(627, 23)
        Me.tbSubject.TabIndex = 15
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 190)
        Me.label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(54, 16)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Subject:"
        '
        'tbCc
        '
        Me.tbCc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "Cc", True))
        Me.tbCc.Location = New System.Drawing.Point(121, 113)
        Me.tbCc.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbCc.Name = "tbCc"
        Me.tbCc.Size = New System.Drawing.Size(627, 23)
        Me.tbCc.TabIndex = 13
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 119)
        Me.label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Cc:"
        '
        'tbTo
        '
        Me.tbTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "To", True))
        Me.tbTo.Location = New System.Drawing.Point(121, 77)
        Me.tbTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbTo.Name = "tbTo"
        Me.tbTo.Size = New System.Drawing.Size(627, 23)
        Me.tbTo.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 83)
        Me.label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(25, 16)
        Me.label2.TabIndex = 10
        Me.label2.Text = "To:"
        '
        'tbFrom
        '
        Me.tbFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFrom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRfc822MessageBindingSource, "From", True))
        Me.tbFrom.Location = New System.Drawing.Point(121, 39)
        Me.tbFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbFrom.Name = "tbFrom"
        Me.tbFrom.Size = New System.Drawing.Size(627, 23)
        Me.tbFrom.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 45)
        Me.label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 16)
        Me.label1.TabIndex = 8
        Me.label1.Text = "From:"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.DataGridView1)
        Me.tabPage2.Controls.Add(Me.Panel1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 25)
        Me.tabPage2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tabPage2.Size = New System.Drawing.Size(778, 468)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Attachment/s"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttachmentIDDataGridViewTextBoxColumn, Me.AttachmentNameDataGridViewTextBoxColumn, Me.AttachmentTypeDataGridViewTextBoxColumn, Me.Open})
        Me.DataGridView1.DataSource = Me.TblMailAttachmentsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(764, 431)
        Me.DataGridView1.TabIndex = 5
        '
        'TblMailAttachmentsBindingSource
        '
        Me.TblMailAttachmentsBindingSource.DataMember = "TblMailAttachments"
        Me.TblMailAttachmentsBindingSource.DataSource = Me.EmailDataSet
        '
        'EmailDataSet
        '
        Me.EmailDataSet.DataSetName = "EmailDataSet"
        Me.EmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(ssMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(7, 437)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 25)
        Me.Panel1.TabIndex = 4
        '
        'TblMailAttachmentsTableAdapter
        '
        Me.TblMailAttachmentsTableAdapter.ClearBeforeFill = True
        '
        'TblRfc822MessageTableAdapter
        '
        Me.TblRfc822MessageTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Open"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.folder
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'TblRfc822MessageBindingSource
        '
        Me.TblRfc822MessageBindingSource.DataSource = GetType(HR.TblRfc822Message)
        '
        'AttachmentIDDataGridViewTextBoxColumn
        '
        Me.AttachmentIDDataGridViewTextBoxColumn.DataPropertyName = "AttachmentID"
        Me.AttachmentIDDataGridViewTextBoxColumn.HeaderText = "AttachmentID"
        Me.AttachmentIDDataGridViewTextBoxColumn.Name = "AttachmentIDDataGridViewTextBoxColumn"
        Me.AttachmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttachmentNameDataGridViewTextBoxColumn
        '
        Me.AttachmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AttachmentNameDataGridViewTextBoxColumn.DataPropertyName = "AttachmentName"
        Me.AttachmentNameDataGridViewTextBoxColumn.HeaderText = "AttachmentName"
        Me.AttachmentNameDataGridViewTextBoxColumn.Name = "AttachmentNameDataGridViewTextBoxColumn"
        Me.AttachmentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttachmentTypeDataGridViewTextBoxColumn
        '
        Me.AttachmentTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AttachmentTypeDataGridViewTextBoxColumn.DataPropertyName = "AttachmentType"
        Me.AttachmentTypeDataGridViewTextBoxColumn.HeaderText = "AttachmentType"
        Me.AttachmentTypeDataGridViewTextBoxColumn.Name = "AttachmentTypeDataGridViewTextBoxColumn"
        Me.AttachmentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Open
        '
        Me.Open.HeaderText = "Open"
        Me.Open.Image = Global.HR.My.Resources.Resources.icons8_download_481
        Me.Open.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Open.Name = "Open"
        Me.Open.ReadOnly = True
        '
        'FrmMailMessageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 497)
        Me.Controls.Add(Me.tcMessage)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMailMessageViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMailMessageViewer"
        ssMain.ResumeLayout(False)
        ssMain.PerformLayout()
        splitContainer1.Panel1.ResumeLayout(False)
        splitContainer1.Panel2.ResumeLayout(False)
        CType(splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.ResumeLayout(False)
        Me.tcMessage.ResumeLayout(False)
        Me.tpMailMessage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMailAttachmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblRfc822MessageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMessage As TabControl
    Private WithEvents tpMailMessage As TabPage
    Private WithEvents tabPage2 As TabPage
    Friend WithEvents EmailDataSet As EmailDataSet
    Friend WithEvents TblMailAttachmentsBindingSource As BindingSource
    Friend WithEvents TblMailAttachmentsTableAdapter As EmailDataSetTableAdapters.TblMailAttachmentsTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TblRfc822MessageTableAdapter As EmailDataSetTableAdapters.TblRfc822MessageTableAdapter
    Public WithEvents tbSubject As TextBox
    Private WithEvents label4 As Label
    Public WithEvents tbCc As TextBox
    Private WithEvents label3 As Label
    Public WithEvents tbTo As TextBox
    Private WithEvents label2 As Label
    Public WithEvents tbFrom As TextBox
    Private WithEvents label1 As Label
    Public WithEvents tbBcc As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents TblRfc822MessageBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MailDateLabel1 As Label
    Public WithEvents tbBody As RichTextBox
    Public WithEvents wbBody As WebBrowser
    Friend WithEvents AttachmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Open As DataGridViewImageColumn
End Class
