<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYearCalendarForSalaries
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.ArabicMonthTextBox = New System.Windows.Forms.TextBox()
        Me.Filter_MonthPerYearCalendarResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArabicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Filter_MonthPerYearCalendarResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PBLast = New System.Windows.Forms.PictureBox()
        Me.PBNext = New System.Windows.Forms.PictureBox()
        Me.PBBack = New System.Windows.Forms.PictureBox()
        Me.PBFirst = New System.Windows.Forms.PictureBox()
        Me.TblYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Filter_MonthPerYearCalendarResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Filter_MonthPerYearCalendarResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFirst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(722, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 51
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(750, 32)
        Me.lblText.TabIndex = 52
        Me.lblText.Text = "Months Per Year"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthTextBox
        '
        Me.MonthTextBox.Location = New System.Drawing.Point(39, 38)
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.Size = New System.Drawing.Size(102, 23)
        Me.MonthTextBox.TabIndex = 54
        '
        'ArabicMonthTextBox
        '
        Me.ArabicMonthTextBox.Location = New System.Drawing.Point(147, 38)
        Me.ArabicMonthTextBox.Name = "ArabicMonthTextBox"
        Me.ArabicMonthTextBox.Size = New System.Drawing.Size(94, 23)
        Me.ArabicMonthTextBox.TabIndex = 55
        '
        'Filter_MonthPerYearCalendarResultDataGridView
        '
        Me.Filter_MonthPerYearCalendarResultDataGridView.AllowUserToAddRows = False
        Me.Filter_MonthPerYearCalendarResultDataGridView.AllowUserToDeleteRows = False
        Me.Filter_MonthPerYearCalendarResultDataGridView.AutoGenerateColumns = False
        Me.Filter_MonthPerYearCalendarResultDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Filter_MonthPerYearCalendarResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Filter_MonthPerYearCalendarResultDataGridView.ColumnHeadersHeight = 32
        Me.Filter_MonthPerYearCalendarResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Filter_MonthPerYearCalendarResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.ArabicName, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.View})
        Me.Filter_MonthPerYearCalendarResultDataGridView.DataSource = Me.Filter_MonthPerYearCalendarResultBindingSource
        Me.Filter_MonthPerYearCalendarResultDataGridView.Location = New System.Drawing.Point(0, 67)
        Me.Filter_MonthPerYearCalendarResultDataGridView.Name = "Filter_MonthPerYearCalendarResultDataGridView"
        Me.Filter_MonthPerYearCalendarResultDataGridView.ReadOnly = True
        Me.Filter_MonthPerYearCalendarResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Filter_MonthPerYearCalendarResultDataGridView.Size = New System.Drawing.Size(750, 224)
        Me.Filter_MonthPerYearCalendarResultDataGridView.TabIndex = 57
        '
        'Name
        '
        Me.Name.DataPropertyName = "Name"
        Me.Name.HeaderText = "Month"
        Me.Name.Name = "Name"
        Me.Name.ReadOnly = True
        '
        'ArabicName
        '
        Me.ArabicName.DataPropertyName = "ArabicName"
        Me.ArabicName.HeaderText = "ArabicName"
        Me.ArabicName.Name = "ArabicName"
        Me.ArabicName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Posted"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Posted"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Locked"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Locked"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PostNote"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'View
        '
        Me.View.HeaderText = "View"
        Me.View.Image = Global.HR.My.Resources.Resources.ViewIcon4
        Me.View.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.Width = 50
        '
        'Filter_MonthPerYearCalendarResultBindingSource
        '
        Me.Filter_MonthPerYearCalendarResultBindingSource.DataSource = GetType(HR.Filter_MonthPerYearCalendarResult)
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "View"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.ViewIcon4
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'PBLast
        '
        Me.PBLast.Image = Global.HR.My.Resources.Resources.LastIcon7
        Me.PBLast.Location = New System.Drawing.Point(451, 297)
        Me.PBLast.Name = "PBLast"
        Me.PBLast.Size = New System.Drawing.Size(58, 45)
        Me.PBLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLast.TabIndex = 64
        Me.PBLast.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBLast, "Last")
        '
        'PBNext
        '
        Me.PBNext.Image = Global.HR.My.Resources.Resources.GoNextIcon7
        Me.PBNext.Location = New System.Drawing.Point(383, 297)
        Me.PBNext.Name = "PBNext"
        Me.PBNext.Size = New System.Drawing.Size(58, 45)
        Me.PBNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBNext.TabIndex = 63
        Me.PBNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBNext, "Next")
        '
        'PBBack
        '
        Me.PBBack.Image = Global.HR.My.Resources.Resources.GoPrevIcon7
        Me.PBBack.Location = New System.Drawing.Point(314, 297)
        Me.PBBack.Name = "PBBack"
        Me.PBBack.Size = New System.Drawing.Size(58, 45)
        Me.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBack.TabIndex = 62
        Me.PBBack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBBack, "Back")
        '
        'PBFirst
        '
        Me.PBFirst.Image = Global.HR.My.Resources.Resources.FirstIcon7
        Me.PBFirst.Location = New System.Drawing.Point(246, 297)
        Me.PBFirst.Name = "PBFirst"
        Me.PBFirst.Size = New System.Drawing.Size(58, 45)
        Me.PBFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBFirst.TabIndex = 61
        Me.PBFirst.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBFirst, "First")
        '
        'TblYearBindingSource
        '
        Me.TblYearBindingSource.DataSource = GetType(HR.TblYear)
        '
        'FrmYearCalendarForSalaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBLast)
        Me.Controls.Add(Me.PBNext)
        Me.Controls.Add(Me.PBBack)
        Me.Controls.Add(Me.PBFirst)
        Me.Controls.Add(Me.Filter_MonthPerYearCalendarResultDataGridView)
        Me.Controls.Add(Me.ArabicMonthTextBox)
        Me.Controls.Add(Me.MonthTextBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        ' Me.Name = "FrmYearCalendarForSalaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Filter_MonthPerYearCalendarResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Filter_MonthPerYearCalendarResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFirst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents MonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArabicMonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Filter_MonthPerYearCalendarResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Filter_MonthPerYearCalendarResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PBLast As System.Windows.Forms.PictureBox
    Friend WithEvents PBNext As System.Windows.Forms.PictureBox
    Friend WithEvents PBBack As System.Windows.Forms.PictureBox
    Friend WithEvents PBFirst As System.Windows.Forms.PictureBox
    Friend WithEvents TblYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents ArabicName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents View As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
