<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLanguages
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
        Dim CommLevelLabel As System.Windows.Forms.Label
        Dim WritingLevelLabel As System.Windows.Forms.Label
        Dim ReadingLevelLabel As System.Windows.Forms.Label
        Dim LanguageLabel As System.Windows.Forms.Label
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.TblLanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.CommLevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.WritingLevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.ReadingLevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CommLevelLabel = New System.Windows.Forms.Label()
        WritingLevelLabel = New System.Windows.Forms.Label()
        ReadingLevelLabel = New System.Windows.Forms.Label()
        LanguageLabel = New System.Windows.Forms.Label()
        CType(Me.TblLanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WritingLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadingLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommLevelLabel
        '
        CommLevelLabel.AutoSize = True
        CommLevelLabel.Location = New System.Drawing.Point(12, 229)
        CommLevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CommLevelLabel.Name = "CommLevelLabel"
        CommLevelLabel.Size = New System.Drawing.Size(84, 16)
        CommLevelLabel.TabIndex = 43
        CommLevelLabel.Text = "Comm Level:"
        '
        'WritingLevelLabel
        '
        WritingLevelLabel.AutoSize = True
        WritingLevelLabel.Location = New System.Drawing.Point(12, 166)
        WritingLevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WritingLevelLabel.Name = "WritingLevelLabel"
        WritingLevelLabel.Size = New System.Drawing.Size(92, 16)
        WritingLevelLabel.TabIndex = 41
        WritingLevelLabel.Text = "Writing Level:"
        '
        'ReadingLevelLabel
        '
        ReadingLevelLabel.AutoSize = True
        ReadingLevelLabel.Location = New System.Drawing.Point(12, 102)
        ReadingLevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ReadingLevelLabel.Name = "ReadingLevelLabel"
        ReadingLevelLabel.Size = New System.Drawing.Size(94, 16)
        ReadingLevelLabel.TabIndex = 39
        ReadingLevelLabel.Text = "Reading Level:"
        '
        'LanguageLabel
        '
        LanguageLabel.AutoSize = True
        LanguageLabel.Location = New System.Drawing.Point(12, 48)
        LanguageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LanguageLabel.Name = "LanguageLabel"
        LanguageLabel.Size = New System.Drawing.Size(67, 16)
        LanguageLabel.TabIndex = 37
        LanguageLabel.Text = "Language:"
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Items.AddRange(New Object() {"Afrikaans", "Akan", "Albanian", "Amharic", "Arabic", "Armenian", "ASL", "Assamese", "Assyrian", "Azerbaijani", "Bahdini", "Bambara", "Bashkir", "Basque", "Belarusian", "Bengali", "Bosnian", "Bravanese", "Bulgarian", "Burmese", "Cambodian", "Cantonese", "Catalan", "Cebuano", "Chaldean", "Chamorro", "Chaozhou", "Chavacano", "Chin", "Chuukese", "Cree", "Croatian", "Czech", "Dakota", "Danish", "Dari", "Dinka", "Dioula", "Dutch", "Dzongkha", "English", "Estonian", "Ewe", "Fante", "Faroese", "Farsi", "Fijian Hindi", "Finnish", "Flemish", "French", "French Canadian", "Frisian", "Fujianese", "Fukienese", "Fula", "Fulani", "Fuzhou", "Ga", "Gaelic", "Galician", "Ganda", "Georgian", "German", "Gorani", "Greek", "Gujarati", "Haitian Creole", "Hakka", "Hassaniyya", "Hausa", "Hebrew", "Hiligaynon", "Hindi"})
        Me.LanguageComboBox.Location = New System.Drawing.Point(125, 45)
        Me.LanguageComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(307, 24)
        Me.LanguageComboBox.TabIndex = 0
        '
        'TblLanguageBindingSource
        '
        Me.TblLanguageBindingSource.DataSource = GetType(HR.TblLanguage)
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(432, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 5
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
        Me.lblText.Size = New System.Drawing.Size(460, 32)
        Me.lblText.TabIndex = 46
        Me.lblText.Text = "Languages"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CommLevelTrackBar
        '
        Me.CommLevelTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblLanguageBindingSource, "CommLevel", True))
        Me.CommLevelTrackBar.Location = New System.Drawing.Point(125, 229)
        Me.CommLevelTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.CommLevelTrackBar.Maximum = 5
        Me.CommLevelTrackBar.Minimum = 1
        Me.CommLevelTrackBar.Name = "CommLevelTrackBar"
        Me.CommLevelTrackBar.Size = New System.Drawing.Size(307, 45)
        Me.CommLevelTrackBar.TabIndex = 3
        Me.CommLevelTrackBar.Value = 3
        '
        'WritingLevelTrackBar
        '
        Me.WritingLevelTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblLanguageBindingSource, "WritingLevel", True))
        Me.WritingLevelTrackBar.Location = New System.Drawing.Point(125, 166)
        Me.WritingLevelTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.WritingLevelTrackBar.Maximum = 5
        Me.WritingLevelTrackBar.Minimum = 1
        Me.WritingLevelTrackBar.Name = "WritingLevelTrackBar"
        Me.WritingLevelTrackBar.Size = New System.Drawing.Size(307, 45)
        Me.WritingLevelTrackBar.TabIndex = 2
        Me.WritingLevelTrackBar.Value = 3
        '
        'ReadingLevelTrackBar
        '
        Me.ReadingLevelTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblLanguageBindingSource, "ReadingLevel", True))
        Me.ReadingLevelTrackBar.Location = New System.Drawing.Point(125, 102)
        Me.ReadingLevelTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.ReadingLevelTrackBar.Maximum = 5
        Me.ReadingLevelTrackBar.Minimum = 1
        Me.ReadingLevelTrackBar.Name = "ReadingLevelTrackBar"
        Me.ReadingLevelTrackBar.Size = New System.Drawing.Size(307, 45)
        Me.ReadingLevelTrackBar.TabIndex = 1
        Me.ReadingLevelTrackBar.Value = 3
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.HR.My.Resources.Resources.SaveIcon7
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(398, 280)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 47)
        Me.BtnSave.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseCompatibleTextRendering = True
        Me.BtnSave.UseMnemonic = False
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmLanguages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(460, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(CommLevelLabel)
        Me.Controls.Add(WritingLevelLabel)
        Me.Controls.Add(ReadingLevelLabel)
        Me.Controls.Add(LanguageLabel)
        Me.Controls.Add(Me.LanguageComboBox)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.CommLevelTrackBar)
        Me.Controls.Add(Me.WritingLevelTrackBar)
        Me.Controls.Add(Me.ReadingLevelTrackBar)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLanguages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblLanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WritingLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadingLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LanguageComboBox As ComboBox
    Friend WithEvents TblLanguageBindingSource As BindingSource
    Friend WithEvents lblClose As Label
    Friend WithEvents lblText As Label
    Friend WithEvents CommLevelTrackBar As TrackBar
    Friend WithEvents WritingLevelTrackBar As TrackBar
    Friend WithEvents ReadingLevelTrackBar As TrackBar
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
