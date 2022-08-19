<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSentMailMessageViewer
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
        Dim SplitContainer2 As System.Windows.Forms.SplitContainer
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbBody = New System.Windows.Forms.RichTextBox()
        Me.tbBodyWithFormat = New System.Windows.Forms.RichTextBox()
        Me.tcMessage = New System.Windows.Forms.TabControl()
        Me.tpMailMessage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbBcc = New System.Windows.Forms.TextBox()
        Me.TblSentMessagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SentEmailDataSet = New HR.SentEmailDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MailDateLabel1 = New System.Windows.Forms.Label()
        Me.tbSubject = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tbFrom = New System.Windows.Forms.TextBox()
        Me.tbCc = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbTo = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblSentMailAttachmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblSentMessagesTableAdapter = New HR.SentEmailDataSetTableAdapters.TblSentMessagesTableAdapter()
        Me.TableAdapterManager = New HR.SentEmailDataSetTableAdapters.TableAdapterManager()
        Me.TblSentMailAttachmentsTableAdapter = New HR.SentEmailDataSetTableAdapters.TblSentMailAttachmentsTableAdapter()
        Me.AttachmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewImageColumn()
        ssMain = New System.Windows.Forms.StatusStrip()
        MailDateLabel = New System.Windows.Forms.Label()
        SplitContainer2 = New System.Windows.Forms.SplitContainer()
        ssMain.SuspendLayout()
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Me.tcMessage.SuspendLayout()
        Me.tpMailMessage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblSentMessagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SentEmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSentMailAttachmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        MailDateLabel.Location = New System.Drawing.Point(446, 6)
        MailDateLabel.Name = "MailDateLabel"
        MailDateLabel.Size = New System.Drawing.Size(70, 16)
        MailDateLabel.TabIndex = 0
        MailDateLabel.Text = "Mail Date:"
        '
        'SplitContainer2
        '
        SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        SplitContainer2.Location = New System.Drawing.Point(0, 0)
        SplitContainer2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        SplitContainer2.Panel1.Controls.Add(Me.tbBody)
        '
        'SplitContainer2.Panel2
        '
        SplitContainer2.Panel2.Controls.Add(Me.tbBodyWithFormat)
        SplitContainer2.Size = New System.Drawing.Size(764, 224)
        SplitContainer2.SplitterDistance = 113
        SplitContainer2.SplitterWidth = 7
        SplitContainer2.TabIndex = 13
        '
        'tbBody
        '
        Me.tbBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBody.Location = New System.Drawing.Point(0, 0)
        Me.tbBody.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbBody.Name = "tbBody"
        Me.tbBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.tbBody.Size = New System.Drawing.Size(764, 113)
        Me.tbBody.TabIndex = 11
        Me.tbBody.Text = ""
        '
        'tbBodyWithFormat
        '
        Me.tbBodyWithFormat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbBodyWithFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBodyWithFormat.Location = New System.Drawing.Point(0, 0)
        Me.tbBodyWithFormat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbBodyWithFormat.Name = "tbBodyWithFormat"
        Me.tbBodyWithFormat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.tbBodyWithFormat.Size = New System.Drawing.Size(764, 104)
        Me.tbBodyWithFormat.TabIndex = 12
        Me.tbBodyWithFormat.Text = ""
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
        Me.tcMessage.TabIndex = 5
        '
        'tpMailMessage
        '
        Me.tpMailMessage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tpMailMessage.Controls.Add(Me.SplitContainer1)
        Me.tpMailMessage.Location = New System.Drawing.Point(4, 25)
        Me.tpMailMessage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpMailMessage.Name = "tpMailMessage"
        Me.tpMailMessage.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpMailMessage.Size = New System.Drawing.Size(778, 468)
        Me.tpMailMessage.TabIndex = 0
        Me.tpMailMessage.Text = "Sent Mail Message"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 456)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbBcc)
        Me.Panel2.Controls.Add(MailDateLabel)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.MailDateLabel1)
        Me.Panel2.Controls.Add(Me.tbSubject)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Controls.Add(Me.label4)
        Me.Panel2.Controls.Add(Me.tbFrom)
        Me.Panel2.Controls.Add(Me.tbCc)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.tbTo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 228)
        Me.Panel2.TabIndex = 14
        '
        'tbBcc
        '
        Me.tbBcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBcc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "Bcc", True))
        Me.tbBcc.Location = New System.Drawing.Point(121, 140)
        Me.tbBcc.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbBcc.Name = "tbBcc"
        Me.tbBcc.Size = New System.Drawing.Size(627, 23)
        Me.tbBcc.TabIndex = 22
        '
        'TblSentMessagesBindingSource
        '
        Me.TblSentMessagesBindingSource.DataMember = "TblSentMessages"
        Me.TblSentMessagesBindingSource.DataSource = Me.SentEmailDataSet
        '
        'SentEmailDataSet
        '
        Me.SentEmailDataSet.DataSetName = "SentEmailDataSet"
        Me.SentEmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Bcc:"
        '
        'MailDateLabel1
        '
        Me.MailDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "MailDate", True))
        Me.MailDateLabel1.Location = New System.Drawing.Point(522, 6)
        Me.MailDateLabel1.Name = "MailDateLabel1"
        Me.MailDateLabel1.Size = New System.Drawing.Size(239, 23)
        Me.MailDateLabel1.TabIndex = 1
        Me.MailDateLabel1.Text = "Label6"
        '
        'tbSubject
        '
        Me.tbSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSubject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "Subject", True))
        Me.tbSubject.Location = New System.Drawing.Point(121, 181)
        Me.tbSubject.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(627, 23)
        Me.tbSubject.TabIndex = 20
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 42)
        Me.label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 16)
        Me.label1.TabIndex = 13
        Me.label1.Text = "From:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 187)
        Me.label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(54, 16)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Subject:"
        '
        'tbFrom
        '
        Me.tbFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFrom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "From", True))
        Me.tbFrom.Location = New System.Drawing.Point(121, 36)
        Me.tbFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbFrom.Name = "tbFrom"
        Me.tbFrom.Size = New System.Drawing.Size(627, 23)
        Me.tbFrom.TabIndex = 14
        '
        'tbCc
        '
        Me.tbCc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "Cc", True))
        Me.tbCc.Location = New System.Drawing.Point(121, 105)
        Me.tbCc.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbCc.Name = "tbCc"
        Me.tbCc.Size = New System.Drawing.Size(627, 23)
        Me.tbCc.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 76)
        Me.label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(25, 16)
        Me.label2.TabIndex = 15
        Me.label2.Text = "To:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 111)
        Me.label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 16)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Cc:"
        '
        'tbTo
        '
        Me.tbTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSentMessagesBindingSource, "To", True))
        Me.tbTo.Location = New System.Drawing.Point(121, 70)
        Me.tbTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbTo.Name = "tbTo"
        Me.tbTo.Size = New System.Drawing.Size(627, 23)
        Me.tbTo.TabIndex = 16
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
        Me.tabPage2.Text = "Sent Attachment/s"
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
        Me.DataGridView1.DataSource = Me.TblSentMailAttachmentsBindingSource
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
        'TblSentMailAttachmentsBindingSource
        '
        Me.TblSentMailAttachmentsBindingSource.DataMember = "TblSentMailAttachments"
        Me.TblSentMailAttachmentsBindingSource.DataSource = Me.SentEmailDataSet
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
        'TblSentMessagesTableAdapter
        '
        Me.TblSentMessagesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TblSentMailAttachmentsTableAdapter = Me.TblSentMailAttachmentsTableAdapter
        Me.TableAdapterManager.TblSentMessagesTableAdapter = Me.TblSentMessagesTableAdapter
        Me.TableAdapterManager.UpdateOrder = HR.SentEmailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSentMailAttachmentsTableAdapter
        '
        Me.TblSentMailAttachmentsTableAdapter.ClearBeforeFill = True
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
        Me.Open.Image = Global.HR.My.Resources.Resources.icons8_download_48
        Me.Open.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Open.Name = "Open"
        Me.Open.ReadOnly = True
        '
        'FrmSentMailMessageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 497)
        Me.Controls.Add(Me.tcMessage)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSentMailMessageViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSentMailMessageViewer"
        ssMain.ResumeLayout(False)
        ssMain.PerformLayout()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Me.tcMessage.ResumeLayout(False)
        Me.tpMailMessage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblSentMessagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SentEmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSentMailAttachmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMessage As TabControl
    Private WithEvents tpMailMessage As TabPage
    Private WithEvents tabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SentEmailDataSet As SentEmailDataSet
    Friend WithEvents TblSentMessagesBindingSource As BindingSource
    Friend WithEvents TblSentMessagesTableAdapter As SentEmailDataSetTableAdapters.TblSentMessagesTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Public WithEvents tbBcc As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents MailDateLabel1 As Label
    Public WithEvents tbSubject As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Public WithEvents tbFrom As TextBox
    Public WithEvents tbCc As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Public WithEvents tbTo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableAdapterManager As SentEmailDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSentMailAttachmentsTableAdapter As SentEmailDataSetTableAdapters.TblSentMailAttachmentsTableAdapter
    Friend WithEvents TblSentMailAttachmentsBindingSource As BindingSource
    Public WithEvents tbBody As RichTextBox
    Public WithEvents tbBodyWithFormat As RichTextBox
    Friend WithEvents AttachmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Open As DataGridViewImageColumn
End Class
