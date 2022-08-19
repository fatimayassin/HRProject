<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowMessage
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.attachmentList = New System.Windows.Forms.ListView()
        Me.nameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.typeHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sizeHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblTextType = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtBlCopy = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtCopy = New System.Windows.Forms.TextBox()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label9 = New System.Windows.Forms.Label()
        Me.lblSubj = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lbKeywords = New System.Windows.Forms.ListBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtInReplTo = New System.Windows.Forms.TextBox()
        Me.txtReplTo = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblEnc = New System.Windows.Forms.Label()
        Me.lblRecieved = New System.Windows.Forms.Label()
        Me.lblMultiPart = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.wbText = New System.Windows.Forms.WebBrowser()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.attachmentList, 0, 6)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.label7, 0, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.wbText, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label6, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.txtText, 0, 4)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 7
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(933, 519)
        Me.tableLayoutPanel1.TabIndex = 32
        '
        'attachmentList
        '
        Me.attachmentList.BackColor = System.Drawing.SystemColors.MenuBar
        Me.attachmentList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nameHeader, Me.typeHeader, Me.sizeHeader})
        Me.attachmentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.attachmentList.FullRowSelect = True
        Me.attachmentList.GridLines = True
        Me.attachmentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.attachmentList.HideSelection = False
        Me.attachmentList.Location = New System.Drawing.Point(3, 389)
        Me.attachmentList.MultiSelect = False
        Me.attachmentList.Name = "attachmentList"
        Me.attachmentList.ShowGroups = False
        Me.attachmentList.Size = New System.Drawing.Size(927, 127)
        Me.attachmentList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.attachmentList.TabIndex = 81
        Me.attachmentList.UseCompatibleStateImageBehavior = False
        Me.attachmentList.View = System.Windows.Forms.View.Details
        '
        'nameHeader
        '
        Me.nameHeader.Text = "Name"
        Me.nameHeader.Width = 120
        '
        'typeHeader
        '
        Me.typeHeader.Text = "Type"
        '
        'sizeHeader
        '
        Me.sizeHeader.Text = "Size (bytes)"
        Me.sizeHeader.Width = 120
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.lblTextType)
        Me.panel1.Controls.Add(Me.lblComm)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 190)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(927, 22)
        Me.panel1.TabIndex = 31
        '
        'lblTextType
        '
        Me.lblTextType.AutoSize = True
        Me.lblTextType.Location = New System.Drawing.Point(3, 3)
        Me.lblTextType.Name = "lblTextType"
        Me.lblTextType.Size = New System.Drawing.Size(33, 15)
        Me.lblTextType.TabIndex = 10
        Me.lblTextType.Text = "Text:"
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Location = New System.Drawing.Point(629, 3)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(63, 15)
        Me.lblComm.TabIndex = 14
        Me.lblComm.Text = "Comment:"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.tableLayoutPanel2)
        Me.panel3.Controls.Add(Me.panel5)
        Me.panel3.Controls.Add(Me.panel4)
        Me.panel3.Controls.Add(Me.panel2)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 3)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(927, 181)
        Me.panel3.TabIndex = 31
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.txtSubject, 0, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.txtTo, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.txtBlCopy, 0, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.txtFrom, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.txtCopy, 0, 2)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(66, 0)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 5
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(560, 129)
        Me.tableLayoutPanel2.TabIndex = 34
        '
        'txtSubject
        '
        Me.txtSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSubject.Location = New System.Drawing.Point(3, 99)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(554, 22)
        Me.txtSubject.TabIndex = 21
        '
        'txtTo
        '
        Me.txtTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTo.Location = New System.Drawing.Point(3, 3)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(554, 22)
        Me.txtTo.TabIndex = 1
        '
        'txtBlCopy
        '
        Me.txtBlCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBlCopy.Location = New System.Drawing.Point(3, 75)
        Me.txtBlCopy.Name = "txtBlCopy"
        Me.txtBlCopy.Size = New System.Drawing.Size(554, 22)
        Me.txtBlCopy.TabIndex = 20
        '
        'txtFrom
        '
        Me.txtFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFrom.Location = New System.Drawing.Point(3, 27)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(554, 22)
        Me.txtFrom.TabIndex = 3
        '
        'txtCopy
        '
        Me.txtCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCopy.Location = New System.Drawing.Point(3, 51)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(554, 22)
        Me.txtCopy.TabIndex = 5
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.label9)
        Me.panel5.Controls.Add(Me.lblSubj)
        Me.panel5.Controls.Add(Me.label2)
        Me.panel5.Controls.Add(Me.label3)
        Me.panel5.Controls.Add(Me.label1)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel5.Location = New System.Drawing.Point(0, 0)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(66, 129)
        Me.panel5.TabIndex = 33
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(3, 78)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(30, 15)
        Me.label9.TabIndex = 19
        Me.label9.Text = "Bcc:"
        '
        'lblSubj
        '
        Me.lblSubj.AutoSize = True
        Me.lblSubj.Location = New System.Drawing.Point(3, 102)
        Me.lblSubj.Name = "lblSubj"
        Me.lblSubj.Size = New System.Drawing.Size(52, 15)
        Me.lblSubj.TabIndex = 28
        Me.lblSubj.Text = "Subject: "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(3, 30)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "From:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(4, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 15)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Cc:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(23, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "To:"
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.label10)
        Me.panel4.Controls.Add(Me.lbKeywords)
        Me.panel4.Controls.Add(Me.label4)
        Me.panel4.Controls.Add(Me.txtInReplTo)
        Me.panel4.Controls.Add(Me.txtReplTo)
        Me.panel4.Controls.Add(Me.label8)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel4.Location = New System.Drawing.Point(626, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(301, 129)
        Me.panel4.TabIndex = 32
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(3, 65)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(63, 15)
        Me.label10.TabIndex = 25
        Me.label10.Text = "Keywords:"
        '
        'lbKeywords
        '
        Me.lbKeywords.FormattingEnabled = True
        Me.lbKeywords.ItemHeight = 15
        Me.lbKeywords.Location = New System.Drawing.Point(76, 65)
        Me.lbKeywords.Name = "lbKeywords"
        Me.lbKeywords.Size = New System.Drawing.Size(214, 64)
        Me.lbKeywords.TabIndex = 26
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(3, 38)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(53, 15)
        Me.label4.TabIndex = 21
        Me.label4.Text = "In rpl To:"
        '
        'txtInReplTo
        '
        Me.txtInReplTo.Location = New System.Drawing.Point(76, 35)
        Me.txtInReplTo.Name = "txtInReplTo"
        Me.txtInReplTo.Size = New System.Drawing.Size(214, 22)
        Me.txtInReplTo.TabIndex = 22
        '
        'txtReplTo
        '
        Me.txtReplTo.Location = New System.Drawing.Point(76, 5)
        Me.txtReplTo.Name = "txtReplTo"
        Me.txtReplTo.Size = New System.Drawing.Size(214, 22)
        Me.txtReplTo.TabIndex = 18
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(3, 8)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(49, 15)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Repl To:"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.lblDate)
        Me.panel2.Controls.Add(Me.lblEnc)
        Me.panel2.Controls.Add(Me.lblRecieved)
        Me.panel2.Controls.Add(Me.lblMultiPart)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 129)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(927, 52)
        Me.panel2.TabIndex = 31
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(4, 34)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 15)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblEnc
        '
        Me.lblEnc.AutoSize = True
        Me.lblEnc.Location = New System.Drawing.Point(629, 34)
        Me.lblEnc.Name = "lblEnc"
        Me.lblEnc.Size = New System.Drawing.Size(60, 15)
        Me.lblEnc.TabIndex = 13
        Me.lblEnc.Text = "Encoding:"
        '
        'lblRecieved
        '
        Me.lblRecieved.AutoSize = True
        Me.lblRecieved.Location = New System.Drawing.Point(3, 7)
        Me.lblRecieved.Name = "lblRecieved"
        Me.lblRecieved.Size = New System.Drawing.Size(58, 15)
        Me.lblRecieved.TabIndex = 23
        Me.lblRecieved.Text = "Recieved:"
        '
        'lblMultiPart
        '
        Me.lblMultiPart.AutoSize = True
        Me.lblMultiPart.Location = New System.Drawing.Point(629, 7)
        Me.lblMultiPart.Name = "lblMultiPart"
        Me.lblMultiPart.Size = New System.Drawing.Size(63, 15)
        Me.lblMultiPart.TabIndex = 24
        Me.lblMultiPart.Text = "MultiPart:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.label7.Location = New System.Drawing.Point(3, 368)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(81, 18)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Attachments:"
        '
        'wbText
        '
        Me.wbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbText.Location = New System.Drawing.Point(3, 218)
        Me.wbText.MinimumSize = New System.Drawing.Size(23, 23)
        Me.wbText.Name = "wbText"
        Me.wbText.Size = New System.Drawing.Size(927, 60)
        Me.wbText.TabIndex = 27
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.label6.Location = New System.Drawing.Point(3, 281)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(62, 21)
        Me.label6.TabIndex = 11
        Me.label6.Text = "Plain Text:"
        '
        'txtText
        '
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(3, 305)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(927, 60)
        Me.txtText.TabIndex = 12
        '
        'ShowMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ShowMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents attachmentList As ListView
    Private WithEvents nameHeader As ColumnHeader
    Private WithEvents typeHeader As ColumnHeader
    Private WithEvents sizeHeader As ColumnHeader
    Private WithEvents panel1 As Panel
    Private WithEvents lblTextType As Label
    Private WithEvents lblComm As Label
    Private WithEvents panel3 As Panel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtSubject As TextBox
    Private WithEvents txtTo As TextBox
    Private WithEvents txtBlCopy As TextBox
    Private WithEvents txtFrom As TextBox
    Private WithEvents txtCopy As TextBox
    Private WithEvents panel5 As Panel
    Private WithEvents label9 As Label
    Private WithEvents lblSubj As Label
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents label10 As Label
    Private WithEvents lbKeywords As ListBox
    Private WithEvents label4 As Label
    Private WithEvents txtInReplTo As TextBox
    Private WithEvents txtReplTo As TextBox
    Private WithEvents label8 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents lblDate As Label
    Private WithEvents lblEnc As Label
    Private WithEvents lblRecieved As Label
    Private WithEvents lblMultiPart As Label
    Private WithEvents label7 As Label
    Private WithEvents wbText As WebBrowser
    Private WithEvents label6 As Label
    Private WithEvents txtText As TextBox
End Class
