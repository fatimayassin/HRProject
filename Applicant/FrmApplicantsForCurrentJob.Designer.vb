<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApplicantsForCurrentJob
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
        Me.TblRequiredJobDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblApplicantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRequiredJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Info = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.TblRequiredJobDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblApplicantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRequiredJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblRequiredJobDataGridView
        '
        Me.TblRequiredJobDataGridView.AllowUserToAddRows = False
        Me.TblRequiredJobDataGridView.AllowUserToDeleteRows = False
        Me.TblRequiredJobDataGridView.AutoGenerateColumns = False
        Me.TblRequiredJobDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblRequiredJobDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblRequiredJobDataGridView.ColumnHeadersHeight = 32
        Me.TblRequiredJobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblRequiredJobDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Info})
        Me.TblRequiredJobDataGridView.DataSource = Me.TblRequiredJobBindingSource
        Me.TblRequiredJobDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblRequiredJobDataGridView.Location = New System.Drawing.Point(0, 36)
        Me.TblRequiredJobDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TblRequiredJobDataGridView.Name = "TblRequiredJobDataGridView"
        Me.TblRequiredJobDataGridView.ReadOnly = True
        Me.TblRequiredJobDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblRequiredJobDataGridView.Size = New System.Drawing.Size(628, 494)
        Me.TblRequiredJobDataGridView.TabIndex = 0
        '
        'TblApplicantBindingSource
        '
        Me.TblApplicantBindingSource.DataSource = GetType(HR.TblApplicant)
        '
        'TblCurrencyBindingSource
        '
        Me.TblCurrencyBindingSource.DataSource = GetType(HR.TblCurrency)
        '
        'TblRequiredJobBindingSource
        '
        Me.TblRequiredJobBindingSource.DataSource = GetType(HR.TblRequiredJob)
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(600, 4)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 1
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
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(628, 32)
        Me.lblText.TabIndex = 37
        Me.lblText.Text = "Applicants For The Selected Job"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EducationInfo"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.magnifier
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ApplicantId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.TblApplicantBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "FirstName"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Applicant"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Id"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ExpectedSalary"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Expected Salary"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CurrencyId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.TblCurrencyBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "Id"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "WayOfWorking"
        Me.DataGridViewTextBoxColumn6.HeaderText = "WayOfWorking"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'Info
        '
        Me.Info.HeaderText = "Show Info."
        Me.Info.Image = Global.HR.My.Resources.Resources.ViewIcon4
        Me.Info.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Info.Name = "Info"
        Me.Info.ReadOnly = True
        Me.Info.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FrmApplicantsForCurrentJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.TblRequiredJobDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmApplicantsForCurrentJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblRequiredJobDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblApplicantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRequiredJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TblRequiredJobDataGridView As DataGridView
    Friend WithEvents TblApplicantBindingSource As BindingSource
    Friend WithEvents TblCurrencyBindingSource As BindingSource
    Friend WithEvents TblRequiredJobBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TblJobDescriptionBindingSource As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Info As DataGridViewImageColumn
End Class
