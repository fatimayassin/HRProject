<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeSalaries2
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblEmployeeSalaryDataGridView = New System.Windows.Forms.DataGridView()
        Me.SalaryCatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectCat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalaryCatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalaryCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeSalary2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TblEmployeeSalaryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalaryCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeSalary2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(721, 32)
        Me.lblText.TabIndex = 53
        Me.lblText.Text = "Salary"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(669, 290)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(41, 39)
        Me.BtnSave.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(690, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 56
        Me.lblClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TblEmployeeSalaryDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 251)
        Me.Panel1.TabIndex = 55
        '
        'TblEmployeeSalaryDataGridView
        '
        Me.TblEmployeeSalaryDataGridView.AllowUserToDeleteRows = False
        Me.TblEmployeeSalaryDataGridView.AutoGenerateColumns = False
        Me.TblEmployeeSalaryDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TblEmployeeSalaryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblEmployeeSalaryDataGridView.ColumnHeadersHeight = 32
        Me.TblEmployeeSalaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblEmployeeSalaryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalaryCatID, Me.SelectCat, Me.SalaryCatIDDataGridViewTextBoxColumn, Me.UnitColumn, Me.Value, Me.Note})
        Me.TblEmployeeSalaryDataGridView.DataSource = Me.TblSalaryCategoryBindingSource
        Me.TblEmployeeSalaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblEmployeeSalaryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblEmployeeSalaryDataGridView.Name = "TblEmployeeSalaryDataGridView"
        Me.TblEmployeeSalaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TblEmployeeSalaryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblEmployeeSalaryDataGridView.Size = New System.Drawing.Size(721, 251)
        Me.TblEmployeeSalaryDataGridView.TabIndex = 0
        '
        'SalaryCatID
        '
        Me.SalaryCatID.DataPropertyName = "SalaryCatID"
        Me.SalaryCatID.HeaderText = "SalaryCatID"
        Me.SalaryCatID.Name = "SalaryCatID"
        Me.SalaryCatID.Visible = False
        '
        'SelectCat
        '
        Me.SelectCat.HeaderText = "Select"
        Me.SelectCat.Name = "SelectCat"
        Me.SelectCat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SelectCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SelectCat.Width = 115
        '
        'SalaryCatIDDataGridViewTextBoxColumn
        '
        Me.SalaryCatIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SalaryCatIDDataGridViewTextBoxColumn.DataPropertyName = "SalaryCategory"
        Me.SalaryCatIDDataGridViewTextBoxColumn.HeaderText = "Salary Category "
        Me.SalaryCatIDDataGridViewTextBoxColumn.Name = "SalaryCatIDDataGridViewTextBoxColumn"
        '
        'UnitColumn
        '
        Me.UnitColumn.HeaderText = "Unit"
        Me.UnitColumn.Items.AddRange(New Object() {"Per Day", "Per Week", "Per Month", "Per Year"})
        Me.UnitColumn.Name = "UnitColumn"
        Me.UnitColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'Note
        '
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        '
        'TblSalaryCategoryBindingSource
        '
        Me.TblSalaryCategoryBindingSource.DataSource = GetType(HR.TblSalaryCategory)
        '
        'TblUnitBindingSource
        '
        Me.TblUnitBindingSource.DataSource = GetType(HR.TblUnit)
        '
        'TblEmployeeSalary2BindingSource
        '
        Me.TblEmployeeSalary2BindingSource.DataSource = GetType(HR.TblEmployeeSalary2)
        '
        'FrmEmployeeSalaries2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 337)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.BtnSave)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEmployeeSalaries2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEmployeeSalaries2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TblEmployeeSalaryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalaryCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeSalary2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblEmployeeSalaryDataGridView As DataGridView
    Friend WithEvents TblEmployeeSalary2BindingSource As BindingSource
    Friend WithEvents TblSalaryCategoryBindingSource As BindingSource
    Friend WithEvents TblUnitBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents SalaryCatID As DataGridViewTextBoxColumn
    Friend WithEvents SelectCat As DataGridViewCheckBoxColumn
    Friend WithEvents SalaryCatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitColumn As DataGridViewComboBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
End Class
