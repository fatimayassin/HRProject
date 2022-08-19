<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMothsPerYear
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
        Me.TblMonthsPerYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonthsPerYearDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblMonthsPerYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthsPerYearDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblClose.Location = New System.Drawing.Point(728, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 36
        Me.lblClose.Text = "X"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(754, 32)
        Me.lblText.TabIndex = 37
        Me.lblText.Text = "Months Per Year"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblMonthsPerYearBindingSource
        '
        Me.TblMonthsPerYearBindingSource.DataSource = GetType(HR.TblMonthsPerYear)
        '
        'TblMonthsPerYearDataGridView
        '
        Me.TblMonthsPerYearDataGridView.AllowUserToAddRows = False
        Me.TblMonthsPerYearDataGridView.AllowUserToDeleteRows = False
        Me.TblMonthsPerYearDataGridView.AutoGenerateColumns = False
        Me.TblMonthsPerYearDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblMonthsPerYearDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblMonthsPerYearDataGridView.ColumnHeadersHeight = 32
        Me.TblMonthsPerYearDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblMonthsPerYearDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.MonthId, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblMonthsPerYearDataGridView.DataSource = Me.TblMonthsPerYearBindingSource
        Me.TblMonthsPerYearDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblMonthsPerYearDataGridView.Location = New System.Drawing.Point(0, 92)
        Me.TblMonthsPerYearDataGridView.Name = "TblMonthsPerYearDataGridView"
        Me.TblMonthsPerYearDataGridView.ReadOnly = True
        Me.TblMonthsPerYearDataGridView.Size = New System.Drawing.Size(754, 364)
        Me.TblMonthsPerYearDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MonthId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TblMonthBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Month"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Id"
        '
        'TblMonthBindingSource
        '
        Me.TblMonthBindingSource.DataSource = GetType(HR.TblMonth)
        '
        'MonthId
        '
        Me.MonthId.DataPropertyName = "MonthId"
        Me.MonthId.DataSource = Me.TblMonthBindingSource
        Me.MonthId.DisplayMember = "ArabicName"
        Me.MonthId.HeaderText = "Arabic Name"
        Me.MonthId.Name = "MonthId"
        Me.MonthId.ReadOnly = True
        Me.MonthId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MonthId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MonthId.ValueMember = "Id"
        Me.MonthId.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Posted"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Posted"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Locked"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Locked"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PostNote"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PostNote"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'FrmMothsPerYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.TblMonthsPerYearDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMothsPerYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblMonthsPerYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthsPerYearDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblMonthsPerYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMonthsPerYearDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
