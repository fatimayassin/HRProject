<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCHeaderTop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLeft3Timer = New System.Windows.Forms.Label()
        Me.lblLeft2Ref = New System.Windows.Forms.Label()
        Me.lblLeft1Setting = New System.Windows.Forms.Label()
        Me.lblHeaderText = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblWindowsState = New System.Windows.Forms.Label()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblLeft3Timer, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLeft2Ref, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLeft1Setting, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHeaderText, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblClose, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblWindowsState, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMinimize, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1229, 30)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblLeft3Timer
        '
        Me.lblLeft3Timer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLeft3Timer.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft3Timer.Location = New System.Drawing.Point(80, 0)
        Me.lblLeft3Timer.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblLeft3Timer.Name = "lblLeft3Timer"
        Me.lblLeft3Timer.Size = New System.Drawing.Size(40, 29)
        Me.lblLeft3Timer.TabIndex = 6
        Me.lblLeft3Timer.Text = "0"
        Me.lblLeft3Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeft2Ref
        '
        Me.lblLeft2Ref.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLeft2Ref.Font = New System.Drawing.Font("Wingdings 3", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLeft2Ref.Location = New System.Drawing.Point(40, 0)
        Me.lblLeft2Ref.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblLeft2Ref.Name = "lblLeft2Ref"
        Me.lblLeft2Ref.Size = New System.Drawing.Size(40, 29)
        Me.lblLeft2Ref.TabIndex = 5
        Me.lblLeft2Ref.Text = "P"
        Me.lblLeft2Ref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeft1Setting
        '
        Me.lblLeft1Setting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLeft1Setting.Font = New System.Drawing.Font("Wingdings 2", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLeft1Setting.Location = New System.Drawing.Point(0, 0)
        Me.lblLeft1Setting.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblLeft1Setting.Name = "lblLeft1Setting"
        Me.lblLeft1Setting.Size = New System.Drawing.Size(40, 29)
        Me.lblLeft1Setting.TabIndex = 4
        Me.lblLeft1Setting.Text = ""
        Me.lblLeft1Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderText
        '
        Me.lblHeaderText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderText.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderText.Location = New System.Drawing.Point(123, 0)
        Me.lblHeaderText.Name = "lblHeaderText"
        Me.lblHeaderText.Size = New System.Drawing.Size(983, 30)
        Me.lblHeaderText.TabIndex = 0
        Me.lblHeaderText.Text = "lblHeaderText"
        Me.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(1189, 0)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(40, 29)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWindowsState
        '
        Me.lblWindowsState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWindowsState.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblWindowsState.Location = New System.Drawing.Point(1149, 0)
        Me.lblWindowsState.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblWindowsState.Name = "lblWindowsState"
        Me.lblWindowsState.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblWindowsState.Size = New System.Drawing.Size(40, 29)
        Me.lblWindowsState.TabIndex = 2
        Me.lblWindowsState.Text = "."
        Me.lblWindowsState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinimize
        '
        Me.lblMinimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMinimize.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(1109, 0)
        Me.lblMinimize.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblMinimize.Size = New System.Drawing.Size(40, 29)
        Me.lblMinimize.TabIndex = 3
        Me.lblMinimize.Text = "_"
        Me.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'UCHeaderTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "UCHeaderTop"
        Me.Size = New System.Drawing.Size(1229, 30)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblLeft3Timer As Label
    Friend WithEvents lblLeft2Ref As Label
    Friend WithEvents lblLeft1Setting As Label
    Friend WithEvents lblHeaderText As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblWindowsState As Label
    Friend WithEvents lblMinimize As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
