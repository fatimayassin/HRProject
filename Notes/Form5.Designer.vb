<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DataSetNotes = New HR.DataSetNotes()
        Me.TblNotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNotesTableAdapter = New HR.DataSetNotesTableAdapters.tblNotesTableAdapter()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ilLarge = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.DataSetNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(800, 450)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'DataSetNotes
        '
        Me.DataSetNotes.DataSetName = "DataSetNotes"
        Me.DataSetNotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNotesBindingSource
        '
        Me.TblNotesBindingSource.DataMember = "tblNotes"
        Me.TblNotesBindingSource.DataSource = Me.DataSetNotes
        '
        'TblNotesTableAdapter
        '
        Me.TblNotesTableAdapter.ClearBeforeFill = True
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.White
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        Me.imageList1.Images.SetKeyName(24, "")
        Me.imageList1.Images.SetKeyName(25, "")
        Me.imageList1.Images.SetKeyName(26, "")
        Me.imageList1.Images.SetKeyName(27, "")
        Me.imageList1.Images.SetKeyName(28, "")
        Me.imageList1.Images.SetKeyName(29, "")
        Me.imageList1.Images.SetKeyName(30, "")
        Me.imageList1.Images.SetKeyName(31, "")
        Me.imageList1.Images.SetKeyName(32, "")
        Me.imageList1.Images.SetKeyName(33, "")
        Me.imageList1.Images.SetKeyName(34, "")
        Me.imageList1.Images.SetKeyName(35, "")
        Me.imageList1.Images.SetKeyName(36, "")
        Me.imageList1.Images.SetKeyName(37, "")
        Me.imageList1.Images.SetKeyName(38, "")
        Me.imageList1.Images.SetKeyName(39, "")
        Me.imageList1.Images.SetKeyName(40, "")
        Me.imageList1.Images.SetKeyName(41, "")
        Me.imageList1.Images.SetKeyName(42, "")
        Me.imageList1.Images.SetKeyName(43, "")
        Me.imageList1.Images.SetKeyName(44, "")
        Me.imageList1.Images.SetKeyName(45, "")
        Me.imageList1.Images.SetKeyName(46, "")
        Me.imageList1.Images.SetKeyName(47, "")
        Me.imageList1.Images.SetKeyName(48, "")
        Me.imageList1.Images.SetKeyName(49, "")
        Me.imageList1.Images.SetKeyName(50, "")
        Me.imageList1.Images.SetKeyName(51, "")
        Me.imageList1.Images.SetKeyName(52, "")
        Me.imageList1.Images.SetKeyName(53, "Notes.png")
        '
        'ilLarge
        '
        Me.ilLarge.ImageStream = CType(resources.GetObject("ilLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLarge.Images.SetKeyName(0, "New Edit32.png")
        Me.ilLarge.Images.SetKeyName(1, "Word-32.gif")
        Me.ilLarge.Images.SetKeyName(2, "Excel-32.gif")
        Me.ilLarge.Images.SetKeyName(3, "PowerPoint-32.gif")
        Me.ilLarge.Images.SetKeyName(4, "Reader-32.gif")
        Me.ilLarge.Images.SetKeyName(5, "Notes.png")
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataSetNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents DataSetNotes As DataSetNotes
    Friend WithEvents TblNotesBindingSource As BindingSource
    Friend WithEvents TblNotesTableAdapter As DataSetNotesTableAdapters.tblNotesTableAdapter
    Private WithEvents imageList1 As ImageList
    Private WithEvents ilLarge As ImageList
End Class
