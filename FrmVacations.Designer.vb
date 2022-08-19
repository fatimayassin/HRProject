<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVacations
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TblVacationDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeeId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblVacationTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExecutedDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AddVac = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.TblVacationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblClose.Location = New System.Drawing.Point(1063, 5)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 2
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
        Me.lblText.Size = New System.Drawing.Size(1093, 39)
        Me.lblText.TabIndex = 54
        Me.lblText.Text = "Vacations"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblVacationDataGridView
        '
        Me.TblVacationDataGridView.AllowUserToAddRows = False
        Me.TblVacationDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TblVacationDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TblVacationDataGridView.AutoGenerateColumns = False
        Me.TblVacationDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblVacationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblVacationDataGridView.ColumnHeadersHeight = 32
        Me.TblVacationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblVacationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.NumberOfDays, Me.ExecutedDays, Me.Remaining, Me.Details, Me.AddVac})
        Me.TblVacationDataGridView.DataSource = Me.TblVacationBindingSource
        Me.TblVacationDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblVacationDataGridView.Location = New System.Drawing.Point(0, 100)
        Me.TblVacationDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblVacationDataGridView.Name = "TblVacationDataGridView"
        Me.TblVacationDataGridView.ReadOnly = True
        Me.TblVacationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblVacationDataGridView.Size = New System.Drawing.Size(1093, 685)
        Me.TblVacationDataGridView.TabIndex = 1
        '
        'EmployeeId
        '
        Me.EmployeeId.DataPropertyName = "EmployeeId"
        Me.EmployeeId.DataSource = Me.TblEmployeeBindingSource
        Me.EmployeeId.DisplayMember = "EmployeeName"
        Me.EmployeeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.EmployeeId.HeaderText = "Employee"
        Me.EmployeeId.Name = "EmployeeId"
        Me.EmployeeId.ReadOnly = True
        Me.EmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmployeeId.ValueMember = "Id"
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataSource = GetType(HR.TblEmployee)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VacationTypeId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TblVacationTypeBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Id"
        '
        'TblVacationTypeBindingSource
        '
        Me.TblVacationTypeBindingSource.DataSource = GetType(HR.TblVacationType)
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VacationDate"
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'NumberOfDays
        '
        Me.NumberOfDays.DataPropertyName = "NumberOfDays"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NumberOfDays.DefaultCellStyle = DataGridViewCellStyle3
        Me.NumberOfDays.HeaderText = "# Of Days"
        Me.NumberOfDays.Name = "NumberOfDays"
        Me.NumberOfDays.ReadOnly = True
        '
        'ExecutedDays
        '
        Me.ExecutedDays.DataPropertyName = "ExecutedDays"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ExecutedDays.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExecutedDays.HeaderText = "Executed Days"
        Me.ExecutedDays.Name = "ExecutedDays"
        Me.ExecutedDays.ReadOnly = True
        '
        'Remaining
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Remaining.DefaultCellStyle = DataGridViewCellStyle5
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        '
        'Details
        '
        Me.Details.HeaderText = "Details"
        Me.Details.Image = Global.HR.My.Resources.Resources.magnifier
        Me.Details.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Details.Name = "Details"
        Me.Details.ReadOnly = True
        Me.Details.Width = 50
        '
        'AddVac
        '
        Me.AddVac.HeaderText = "Add"
        Me.AddVac.Image = Global.HR.My.Resources.Resources.add
        Me.AddVac.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.AddVac.Name = "AddVac"
        Me.AddVac.ReadOnly = True
        Me.AddVac.Width = 50
        '
        'TblVacationBindingSource
        '
        Me.TblVacationBindingSource.DataSource = GetType(HR.TblVacation)
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Add"
        Me.DataGridViewImageColumn1.Image = Global.HR.My.Resources.Resources.add
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = Global.HR.My.Resources.Resources.new1
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(8, 45)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(45, 47)
        Me.btnNew.TabIndex = 0
        Me.btnNew.UseCompatibleTextRendering = True
        Me.btnNew.UseMnemonic = False
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'FrmVacations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1093, 785)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.TblVacationDataGridView)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmVacations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblVacationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVacationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblVacationTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents EmployeeId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExecutedDays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Details As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents AddVac As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
