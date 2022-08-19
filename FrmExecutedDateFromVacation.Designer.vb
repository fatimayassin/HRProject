<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExecutedDateFromVacation
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
        Dim FromDateLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim NumberOfDaysLabel As System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TblExecuteDateFromVacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FromDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        FromDateLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        NumberOfDaysLabel = New System.Windows.Forms.Label()
        CType(Me.TblExecuteDateFromVacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FromDateLabel
        '
        FromDateLabel.AutoSize = True
        FromDateLabel.Location = New System.Drawing.Point(39, 87)
        FromDateLabel.Name = "FromDateLabel"
        FromDateLabel.Size = New System.Drawing.Size(73, 16)
        FromDateLabel.TabIndex = 59
        FromDateLabel.Text = "From Date:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(73, 193)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(39, 16)
        NoteLabel.TabIndex = 60
        NoteLabel.Text = "Note:"
        '
        'NumberOfDaysLabel
        '
        NumberOfDaysLabel.AutoSize = True
        NumberOfDaysLabel.Location = New System.Drawing.Point(6, 142)
        NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        NumberOfDaysLabel.Size = New System.Drawing.Size(106, 16)
        NumberOfDaysLabel.TabIndex = 61
        NumberOfDaysLabel.Text = "Number Of Days:"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(347, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 4
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
        Me.lblText.Size = New System.Drawing.Size(373, 39)
        Me.lblText.TabIndex = 56
        Me.lblText.Text = "Execute Vacations"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblExecuteDateFromVacationBindingSource
        '
        Me.TblExecuteDateFromVacationBindingSource.DataSource = GetType(HR.TblExecuteDateFromVacation)
        '
        'FromDateDateTimePicker
        '
        Me.FromDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblExecuteDateFromVacationBindingSource, "FromDate", True))
        Me.FromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDateDateTimePicker.Location = New System.Drawing.Point(118, 83)
        Me.FromDateDateTimePicker.Name = "FromDateDateTimePicker"
        Me.FromDateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.FromDateDateTimePicker.TabIndex = 0
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecuteDateFromVacationBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(118, 189)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(200, 23)
        Me.NoteTextBox.TabIndex = 2
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExecuteDateFromVacationBindingSource, "NumberOfDays", True))
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(118, 136)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(200, 23)
        Me.NumberOfDaysTextBox.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.save2
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(273, 244)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(45, 47)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmExecutedDateFromVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(373, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(NumberOfDaysLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(FromDateLabel)
        Me.Controls.Add(Me.FromDateDateTimePicker)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmExecutedDateFromVacation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblExecuteDateFromVacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents TblExecuteDateFromVacationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FromDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
