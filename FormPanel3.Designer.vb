<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPanel3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.PanelNavBtm = New System.Windows.Forms.Panel()
        Me.BtFoldersPanel = New System.Windows.Forms.Button()
        Me.BtNotesPanel = New System.Windows.Forms.Button()
        Me.BtTasksPanel = New System.Windows.Forms.Button()
        Me.BtCalendarPanel = New System.Windows.Forms.Button()
        Me.BtMailPanel = New System.Windows.Forms.Button()
        Me.PanelMyMail = New System.Windows.Forms.Panel()
        Me.PanelMyMailButtons = New System.Windows.Forms.Panel()
        Me.BtSent = New System.Windows.Forms.Button()
        Me.BtInbox = New System.Windows.Forms.Button()
        Me.BtComposeMail = New System.Windows.Forms.Button()
        Me.BtSignInAccount = New System.Windows.Forms.Button()
        Me.PanelMyMailTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtCloseMailPanel = New System.Windows.Forms.Button()
        Me.BtOpenMailPanel = New System.Windows.Forms.Button()
        Me.PanelMyFolders = New System.Windows.Forms.Panel()
        Me.PanelMyFoldersButtons = New System.Windows.Forms.Panel()
        Me.BtToDoFolder = New System.Windows.Forms.Button()
        Me.BtNotesFolder = New System.Windows.Forms.Button()
        Me.BtCalendarFolder = New System.Windows.Forms.Button()
        Me.BtMailInboxFolder = New System.Windows.Forms.Button()
        Me.PanelMyFoldersTitle = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtCloseFoldersPanel = New System.Windows.Forms.Button()
        Me.BtOpenFoldersPanel = New System.Windows.Forms.Button()
        Me.PanelMyNotes = New System.Windows.Forms.Panel()
        Me.PanelMyNotesButtons = New System.Windows.Forms.Panel()
        Me.BtNotes = New System.Windows.Forms.Button()
        Me.PanelMyNotesTitle = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtCloseNotesPanel = New System.Windows.Forms.Button()
        Me.BtOpenNotesPanel = New System.Windows.Forms.Button()
        Me.PanelMyTasks = New System.Windows.Forms.Panel()
        Me.PanelMyTasksButtons = New System.Windows.Forms.Panel()
        Me.BtTasks = New System.Windows.Forms.Button()
        Me.BtToDoList = New System.Windows.Forms.Button()
        Me.PanelMyTasksTitle = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtCloseTasksPanel = New System.Windows.Forms.Button()
        Me.BtOpenTasksPanel = New System.Windows.Forms.Button()
        Me.PanelMyCalendar = New System.Windows.Forms.Panel()
        Me.PaneMyCalendarButtons = New System.Windows.Forms.Panel()
        Me.BtCalendar = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PanelMyCalendarTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtCloseCalendarPanel = New System.Windows.Forms.Button()
        Me.BtOpenCalendarPanel = New System.Windows.Forms.Button()
        Me.PanelNavRight = New System.Windows.Forms.Panel()
        Me.BtPinPanel = New System.Windows.Forms.Button()
        Me.BtExpandNavPanel = New System.Windows.Forms.Button()
        Me.BtHideNavPanel = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelNav.SuspendLayout()
        Me.PanelNavBtm.SuspendLayout()
        Me.PanelMyMail.SuspendLayout()
        Me.PanelMyMailButtons.SuspendLayout()
        Me.PanelMyMailTitle.SuspendLayout()
        Me.PanelMyFolders.SuspendLayout()
        Me.PanelMyFoldersButtons.SuspendLayout()
        Me.PanelMyFoldersTitle.SuspendLayout()
        Me.PanelMyNotes.SuspendLayout()
        Me.PanelMyNotesButtons.SuspendLayout()
        Me.PanelMyNotesTitle.SuspendLayout()
        Me.PanelMyTasks.SuspendLayout()
        Me.PanelMyTasksButtons.SuspendLayout()
        Me.PanelMyTasksTitle.SuspendLayout()
        Me.PanelMyCalendar.SuspendLayout()
        Me.PaneMyCalendarButtons.SuspendLayout()
        Me.PanelMyCalendarTitle.SuspendLayout()
        Me.PanelNavRight.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelNav)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelNavRight)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1098, 678)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'PanelNav
        '
        Me.PanelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelNav.Controls.Add(Me.PanelNavBtm)
        Me.PanelNav.Controls.Add(Me.PanelMyMail)
        Me.PanelNav.Controls.Add(Me.PanelMyFolders)
        Me.PanelNav.Controls.Add(Me.PanelMyNotes)
        Me.PanelNav.Controls.Add(Me.PanelMyTasks)
        Me.PanelNav.Controls.Add(Me.PanelMyCalendar)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(215, 678)
        Me.PanelNav.TabIndex = 98
        '
        'PanelNavBtm
        '
        Me.PanelNavBtm.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelNavBtm.Controls.Add(Me.BtFoldersPanel)
        Me.PanelNavBtm.Controls.Add(Me.BtNotesPanel)
        Me.PanelNavBtm.Controls.Add(Me.BtTasksPanel)
        Me.PanelNavBtm.Controls.Add(Me.BtCalendarPanel)
        Me.PanelNavBtm.Controls.Add(Me.BtMailPanel)
        Me.PanelNavBtm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelNavBtm.Location = New System.Drawing.Point(0, 625)
        Me.PanelNavBtm.Name = "PanelNavBtm"
        Me.PanelNavBtm.Size = New System.Drawing.Size(211, 49)
        Me.PanelNavBtm.TabIndex = 0
        '
        'BtFoldersPanel
        '
        Me.BtFoldersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtFoldersPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtFoldersPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtFoldersPanel.FlatAppearance.BorderSize = 0
        Me.BtFoldersPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFoldersPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFoldersPanel.Image = Global.HR.My.Resources.Resources.folder_24
        Me.BtFoldersPanel.Location = New System.Drawing.Point(172, 0)
        Me.BtFoldersPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtFoldersPanel.Name = "BtFoldersPanel"
        Me.BtFoldersPanel.Size = New System.Drawing.Size(43, 49)
        Me.BtFoldersPanel.TabIndex = 88
        Me.BtFoldersPanel.UseCompatibleTextRendering = True
        Me.BtFoldersPanel.UseMnemonic = False
        Me.BtFoldersPanel.UseVisualStyleBackColor = True
        '
        'BtNotesPanel
        '
        Me.BtNotesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtNotesPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtNotesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtNotesPanel.FlatAppearance.BorderSize = 0
        Me.BtNotesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNotesPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNotesPanel.Image = Global.HR.My.Resources.Resources.note_24
        Me.BtNotesPanel.Location = New System.Drawing.Point(129, 0)
        Me.BtNotesPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtNotesPanel.Name = "BtNotesPanel"
        Me.BtNotesPanel.Size = New System.Drawing.Size(43, 49)
        Me.BtNotesPanel.TabIndex = 87
        Me.BtNotesPanel.UseCompatibleTextRendering = True
        Me.BtNotesPanel.UseMnemonic = False
        Me.BtNotesPanel.UseVisualStyleBackColor = True
        '
        'BtTasksPanel
        '
        Me.BtTasksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtTasksPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtTasksPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtTasksPanel.FlatAppearance.BorderSize = 0
        Me.BtTasksPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtTasksPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTasksPanel.Image = Global.HR.My.Resources.Resources.task_24
        Me.BtTasksPanel.Location = New System.Drawing.Point(86, 0)
        Me.BtTasksPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtTasksPanel.Name = "BtTasksPanel"
        Me.BtTasksPanel.Size = New System.Drawing.Size(43, 49)
        Me.BtTasksPanel.TabIndex = 86
        Me.BtTasksPanel.UseCompatibleTextRendering = True
        Me.BtTasksPanel.UseMnemonic = False
        Me.BtTasksPanel.UseVisualStyleBackColor = True
        '
        'BtCalendarPanel
        '
        Me.BtCalendarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCalendarPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCalendarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCalendarPanel.FlatAppearance.BorderSize = 0
        Me.BtCalendarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalendarPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalendarPanel.Image = Global.HR.My.Resources.Resources.calendar_24
        Me.BtCalendarPanel.Location = New System.Drawing.Point(43, 0)
        Me.BtCalendarPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCalendarPanel.Name = "BtCalendarPanel"
        Me.BtCalendarPanel.Size = New System.Drawing.Size(43, 49)
        Me.BtCalendarPanel.TabIndex = 85
        Me.BtCalendarPanel.UseCompatibleTextRendering = True
        Me.BtCalendarPanel.UseMnemonic = False
        Me.BtCalendarPanel.UseVisualStyleBackColor = True
        '
        'BtMailPanel
        '
        Me.BtMailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtMailPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMailPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtMailPanel.FlatAppearance.BorderSize = 0
        Me.BtMailPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtMailPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtMailPanel.Image = Global.HR.My.Resources.Resources.mail_24
        Me.BtMailPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtMailPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtMailPanel.Name = "BtMailPanel"
        Me.BtMailPanel.Size = New System.Drawing.Size(43, 49)
        Me.BtMailPanel.TabIndex = 89
        Me.BtMailPanel.UseCompatibleTextRendering = True
        Me.BtMailPanel.UseMnemonic = False
        Me.BtMailPanel.UseVisualStyleBackColor = True
        '
        'PanelMyMail
        '
        Me.PanelMyMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyMail.Controls.Add(Me.PanelMyMailButtons)
        Me.PanelMyMail.Controls.Add(Me.PanelMyMailTitle)
        Me.PanelMyMail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyMail.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyMail.Name = "PanelMyMail"
        Me.PanelMyMail.Size = New System.Drawing.Size(211, 674)
        Me.PanelMyMail.TabIndex = 93
        '
        'PanelMyMailButtons
        '
        Me.PanelMyMailButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyMailButtons.Controls.Add(Me.BtSent)
        Me.PanelMyMailButtons.Controls.Add(Me.BtInbox)
        Me.PanelMyMailButtons.Controls.Add(Me.BtComposeMail)
        Me.PanelMyMailButtons.Controls.Add(Me.BtSignInAccount)
        Me.PanelMyMailButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyMailButtons.Location = New System.Drawing.Point(0, 40)
        Me.PanelMyMailButtons.Name = "PanelMyMailButtons"
        Me.PanelMyMailButtons.Size = New System.Drawing.Size(211, 634)
        Me.PanelMyMailButtons.TabIndex = 1
        '
        'BtSent
        '
        Me.BtSent.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtSent.FlatAppearance.BorderSize = 0
        Me.BtSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSent.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSent.ForeColor = System.Drawing.Color.White
        Me.BtSent.Image = Global.HR.My.Resources.Resources.icons8_upload_mail_24
        Me.BtSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSent.Location = New System.Drawing.Point(0, 120)
        Me.BtSent.Name = "BtSent"
        Me.BtSent.Size = New System.Drawing.Size(211, 40)
        Me.BtSent.TabIndex = 6
        Me.BtSent.Text = "           Sent "
        Me.BtSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSent.UseVisualStyleBackColor = True
        '
        'BtInbox
        '
        Me.BtInbox.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtInbox.FlatAppearance.BorderSize = 0
        Me.BtInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtInbox.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtInbox.ForeColor = System.Drawing.Color.White
        Me.BtInbox.Image = Global.HR.My.Resources.Resources.icons8_download_mail_24
        Me.BtInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtInbox.Location = New System.Drawing.Point(0, 80)
        Me.BtInbox.Name = "BtInbox"
        Me.BtInbox.Size = New System.Drawing.Size(211, 40)
        Me.BtInbox.TabIndex = 5
        Me.BtInbox.Text = "           Inbox "
        Me.BtInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtInbox.UseVisualStyleBackColor = True
        '
        'BtComposeMail
        '
        Me.BtComposeMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtComposeMail.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtComposeMail.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatAppearance.BorderSize = 0
        Me.BtComposeMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtComposeMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtComposeMail.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtComposeMail.ForeColor = System.Drawing.Color.White
        Me.BtComposeMail.Image = Global.HR.My.Resources.Resources.icons8_composing_mail_24
        Me.BtComposeMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtComposeMail.Location = New System.Drawing.Point(0, 40)
        Me.BtComposeMail.Name = "BtComposeMail"
        Me.BtComposeMail.Size = New System.Drawing.Size(211, 40)
        Me.BtComposeMail.TabIndex = 4
        Me.BtComposeMail.Text = "           Compose Mail"
        Me.BtComposeMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtComposeMail.UseVisualStyleBackColor = True
        '
        'BtSignInAccount
        '
        Me.BtSignInAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtSignInAccount.FlatAppearance.BorderSize = 0
        Me.BtSignInAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSignInAccount.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSignInAccount.ForeColor = System.Drawing.Color.White
        Me.BtSignInAccount.Image = Global.HR.My.Resources.Resources.icons8_gmail_login_24
        Me.BtSignInAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSignInAccount.Location = New System.Drawing.Point(0, 0)
        Me.BtSignInAccount.Name = "BtSignInAccount"
        Me.BtSignInAccount.Size = New System.Drawing.Size(211, 40)
        Me.BtSignInAccount.TabIndex = 7
        Me.BtSignInAccount.Text = "           Sign Into Account"
        Me.BtSignInAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSignInAccount.UseVisualStyleBackColor = True
        '
        'PanelMyMailTitle
        '
        Me.PanelMyMailTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyMailTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMyMailTitle.Controls.Add(Me.Label1)
        Me.PanelMyMailTitle.Controls.Add(Me.BtCloseMailPanel)
        Me.PanelMyMailTitle.Controls.Add(Me.BtOpenMailPanel)
        Me.PanelMyMailTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMyMailTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyMailTitle.Name = "PanelMyMailTitle"
        Me.PanelMyMailTitle.Size = New System.Drawing.Size(211, 40)
        Me.PanelMyMailTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My Mail"
        '
        'BtCloseMailPanel
        '
        Me.BtCloseMailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCloseMailPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCloseMailPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCloseMailPanel.FlatAppearance.BorderSize = 0
        Me.BtCloseMailPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCloseMailPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCloseMailPanel.Image = Global.HR.My.Resources.Resources.sort_down_8_1
        Me.BtCloseMailPanel.Location = New System.Drawing.Point(33, 0)
        Me.BtCloseMailPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCloseMailPanel.Name = "BtCloseMailPanel"
        Me.BtCloseMailPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtCloseMailPanel.TabIndex = 91
        Me.BtCloseMailPanel.UseCompatibleTextRendering = True
        Me.BtCloseMailPanel.UseMnemonic = False
        Me.BtCloseMailPanel.UseVisualStyleBackColor = True
        '
        'BtOpenMailPanel
        '
        Me.BtOpenMailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOpenMailPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOpenMailPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtOpenMailPanel.FlatAppearance.BorderSize = 0
        Me.BtOpenMailPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOpenMailPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpenMailPanel.Image = Global.HR.My.Resources.Resources.sort_right_8_1
        Me.BtOpenMailPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtOpenMailPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtOpenMailPanel.Name = "BtOpenMailPanel"
        Me.BtOpenMailPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtOpenMailPanel.TabIndex = 90
        Me.BtOpenMailPanel.UseCompatibleTextRendering = True
        Me.BtOpenMailPanel.UseMnemonic = False
        Me.BtOpenMailPanel.UseVisualStyleBackColor = True
        '
        'PanelMyFolders
        '
        Me.PanelMyFolders.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyFolders.Controls.Add(Me.PanelMyFoldersButtons)
        Me.PanelMyFolders.Controls.Add(Me.PanelMyFoldersTitle)
        Me.PanelMyFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyFolders.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyFolders.Name = "PanelMyFolders"
        Me.PanelMyFolders.Size = New System.Drawing.Size(211, 674)
        Me.PanelMyFolders.TabIndex = 97
        '
        'PanelMyFoldersButtons
        '
        Me.PanelMyFoldersButtons.Controls.Add(Me.BtToDoFolder)
        Me.PanelMyFoldersButtons.Controls.Add(Me.BtNotesFolder)
        Me.PanelMyFoldersButtons.Controls.Add(Me.BtCalendarFolder)
        Me.PanelMyFoldersButtons.Controls.Add(Me.BtMailInboxFolder)
        Me.PanelMyFoldersButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyFoldersButtons.Location = New System.Drawing.Point(0, 40)
        Me.PanelMyFoldersButtons.Name = "PanelMyFoldersButtons"
        Me.PanelMyFoldersButtons.Size = New System.Drawing.Size(211, 634)
        Me.PanelMyFoldersButtons.TabIndex = 2
        '
        'BtToDoFolder
        '
        Me.BtToDoFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtToDoFolder.FlatAppearance.BorderSize = 0
        Me.BtToDoFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtToDoFolder.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtToDoFolder.ForeColor = System.Drawing.Color.White
        Me.BtToDoFolder.Image = Global.HR.My.Resources.Resources.icons8_add_list_24
        Me.BtToDoFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoFolder.Location = New System.Drawing.Point(0, 120)
        Me.BtToDoFolder.Name = "BtToDoFolder"
        Me.BtToDoFolder.Size = New System.Drawing.Size(211, 40)
        Me.BtToDoFolder.TabIndex = 9
        Me.BtToDoFolder.Text = "           To-Do"
        Me.BtToDoFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoFolder.UseVisualStyleBackColor = True
        '
        'BtNotesFolder
        '
        Me.BtNotesFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtNotesFolder.FlatAppearance.BorderSize = 0
        Me.BtNotesFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNotesFolder.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNotesFolder.ForeColor = System.Drawing.Color.White
        Me.BtNotesFolder.Image = Global.HR.My.Resources.Resources.icons8_create_document_24
        Me.BtNotesFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotesFolder.Location = New System.Drawing.Point(0, 80)
        Me.BtNotesFolder.Name = "BtNotesFolder"
        Me.BtNotesFolder.Size = New System.Drawing.Size(211, 40)
        Me.BtNotesFolder.TabIndex = 8
        Me.BtNotesFolder.Text = "           Notes"
        Me.BtNotesFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotesFolder.UseVisualStyleBackColor = True
        '
        'BtCalendarFolder
        '
        Me.BtCalendarFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtCalendarFolder.FlatAppearance.BorderSize = 0
        Me.BtCalendarFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalendarFolder.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalendarFolder.ForeColor = System.Drawing.Color.White
        Me.BtCalendarFolder.Image = Global.HR.My.Resources.Resources.icons8_calendar_plus_24
        Me.BtCalendarFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendarFolder.Location = New System.Drawing.Point(0, 40)
        Me.BtCalendarFolder.Name = "BtCalendarFolder"
        Me.BtCalendarFolder.Size = New System.Drawing.Size(211, 40)
        Me.BtCalendarFolder.TabIndex = 7
        Me.BtCalendarFolder.Text = "           Calendar"
        Me.BtCalendarFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendarFolder.UseVisualStyleBackColor = True
        '
        'BtMailInboxFolder
        '
        Me.BtMailInboxFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtMailInboxFolder.FlatAppearance.BorderSize = 0
        Me.BtMailInboxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtMailInboxFolder.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtMailInboxFolder.ForeColor = System.Drawing.Color.White
        Me.BtMailInboxFolder.Image = Global.HR.My.Resources.Resources.icons8_download_mail_24
        Me.BtMailInboxFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtMailInboxFolder.Location = New System.Drawing.Point(0, 0)
        Me.BtMailInboxFolder.Name = "BtMailInboxFolder"
        Me.BtMailInboxFolder.Size = New System.Drawing.Size(211, 40)
        Me.BtMailInboxFolder.TabIndex = 6
        Me.BtMailInboxFolder.Text = "           Mail Inbox"
        Me.BtMailInboxFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtMailInboxFolder.UseVisualStyleBackColor = True
        '
        'PanelMyFoldersTitle
        '
        Me.PanelMyFoldersTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMyFoldersTitle.Controls.Add(Me.Label5)
        Me.PanelMyFoldersTitle.Controls.Add(Me.BtCloseFoldersPanel)
        Me.PanelMyFoldersTitle.Controls.Add(Me.BtOpenFoldersPanel)
        Me.PanelMyFoldersTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMyFoldersTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyFoldersTitle.Name = "PanelMyFoldersTitle"
        Me.PanelMyFoldersTitle.Size = New System.Drawing.Size(211, 40)
        Me.PanelMyFoldersTitle.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MyFolders"
        '
        'BtCloseFoldersPanel
        '
        Me.BtCloseFoldersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCloseFoldersPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCloseFoldersPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCloseFoldersPanel.FlatAppearance.BorderSize = 0
        Me.BtCloseFoldersPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCloseFoldersPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCloseFoldersPanel.Image = Global.HR.My.Resources.Resources.sort_down_8_1
        Me.BtCloseFoldersPanel.Location = New System.Drawing.Point(33, 0)
        Me.BtCloseFoldersPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCloseFoldersPanel.Name = "BtCloseFoldersPanel"
        Me.BtCloseFoldersPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtCloseFoldersPanel.TabIndex = 91
        Me.BtCloseFoldersPanel.UseCompatibleTextRendering = True
        Me.BtCloseFoldersPanel.UseMnemonic = False
        Me.BtCloseFoldersPanel.UseVisualStyleBackColor = True
        '
        'BtOpenFoldersPanel
        '
        Me.BtOpenFoldersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOpenFoldersPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOpenFoldersPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtOpenFoldersPanel.FlatAppearance.BorderSize = 0
        Me.BtOpenFoldersPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOpenFoldersPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpenFoldersPanel.Image = Global.HR.My.Resources.Resources.sort_right_8_1
        Me.BtOpenFoldersPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtOpenFoldersPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtOpenFoldersPanel.Name = "BtOpenFoldersPanel"
        Me.BtOpenFoldersPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtOpenFoldersPanel.TabIndex = 90
        Me.BtOpenFoldersPanel.UseCompatibleTextRendering = True
        Me.BtOpenFoldersPanel.UseMnemonic = False
        Me.BtOpenFoldersPanel.UseVisualStyleBackColor = True
        '
        'PanelMyNotes
        '
        Me.PanelMyNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyNotes.Controls.Add(Me.PanelMyNotesButtons)
        Me.PanelMyNotes.Controls.Add(Me.PanelMyNotesTitle)
        Me.PanelMyNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyNotes.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyNotes.Name = "PanelMyNotes"
        Me.PanelMyNotes.Size = New System.Drawing.Size(211, 674)
        Me.PanelMyNotes.TabIndex = 96
        '
        'PanelMyNotesButtons
        '
        Me.PanelMyNotesButtons.Controls.Add(Me.BtNotes)
        Me.PanelMyNotesButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyNotesButtons.Location = New System.Drawing.Point(0, 40)
        Me.PanelMyNotesButtons.Name = "PanelMyNotesButtons"
        Me.PanelMyNotesButtons.Size = New System.Drawing.Size(211, 634)
        Me.PanelMyNotesButtons.TabIndex = 2
        '
        'BtNotes
        '
        Me.BtNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtNotes.FlatAppearance.BorderSize = 0
        Me.BtNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNotes.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNotes.ForeColor = System.Drawing.Color.White
        Me.BtNotes.Image = Global.HR.My.Resources.Resources.icons8_create_document_24
        Me.BtNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotes.Location = New System.Drawing.Point(0, 0)
        Me.BtNotes.Name = "BtNotes"
        Me.BtNotes.Size = New System.Drawing.Size(211, 40)
        Me.BtNotes.TabIndex = 3
        Me.BtNotes.Text = "           Notes "
        Me.BtNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtNotes.UseVisualStyleBackColor = True
        '
        'PanelMyNotesTitle
        '
        Me.PanelMyNotesTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMyNotesTitle.Controls.Add(Me.Label4)
        Me.PanelMyNotesTitle.Controls.Add(Me.BtCloseNotesPanel)
        Me.PanelMyNotesTitle.Controls.Add(Me.BtOpenNotesPanel)
        Me.PanelMyNotesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMyNotesTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyNotesTitle.Name = "PanelMyNotesTitle"
        Me.PanelMyNotesTitle.Size = New System.Drawing.Size(211, 40)
        Me.PanelMyNotesTitle.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "My Notes"
        '
        'BtCloseNotesPanel
        '
        Me.BtCloseNotesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCloseNotesPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCloseNotesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCloseNotesPanel.FlatAppearance.BorderSize = 0
        Me.BtCloseNotesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCloseNotesPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCloseNotesPanel.Image = Global.HR.My.Resources.Resources.sort_down_8_1
        Me.BtCloseNotesPanel.Location = New System.Drawing.Point(33, 0)
        Me.BtCloseNotesPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCloseNotesPanel.Name = "BtCloseNotesPanel"
        Me.BtCloseNotesPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtCloseNotesPanel.TabIndex = 91
        Me.BtCloseNotesPanel.UseCompatibleTextRendering = True
        Me.BtCloseNotesPanel.UseMnemonic = False
        Me.BtCloseNotesPanel.UseVisualStyleBackColor = True
        '
        'BtOpenNotesPanel
        '
        Me.BtOpenNotesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOpenNotesPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOpenNotesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtOpenNotesPanel.FlatAppearance.BorderSize = 0
        Me.BtOpenNotesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOpenNotesPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpenNotesPanel.Image = Global.HR.My.Resources.Resources.sort_right_8_1
        Me.BtOpenNotesPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtOpenNotesPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtOpenNotesPanel.Name = "BtOpenNotesPanel"
        Me.BtOpenNotesPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtOpenNotesPanel.TabIndex = 90
        Me.BtOpenNotesPanel.UseCompatibleTextRendering = True
        Me.BtOpenNotesPanel.UseMnemonic = False
        Me.BtOpenNotesPanel.UseVisualStyleBackColor = True
        '
        'PanelMyTasks
        '
        Me.PanelMyTasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyTasks.Controls.Add(Me.PanelMyTasksButtons)
        Me.PanelMyTasks.Controls.Add(Me.PanelMyTasksTitle)
        Me.PanelMyTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyTasks.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyTasks.Name = "PanelMyTasks"
        Me.PanelMyTasks.Size = New System.Drawing.Size(211, 674)
        Me.PanelMyTasks.TabIndex = 95
        '
        'PanelMyTasksButtons
        '
        Me.PanelMyTasksButtons.Controls.Add(Me.BtTasks)
        Me.PanelMyTasksButtons.Controls.Add(Me.BtToDoList)
        Me.PanelMyTasksButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyTasksButtons.Location = New System.Drawing.Point(0, 40)
        Me.PanelMyTasksButtons.Name = "PanelMyTasksButtons"
        Me.PanelMyTasksButtons.Size = New System.Drawing.Size(211, 634)
        Me.PanelMyTasksButtons.TabIndex = 2
        '
        'BtTasks
        '
        Me.BtTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtTasks.FlatAppearance.BorderSize = 0
        Me.BtTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtTasks.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTasks.ForeColor = System.Drawing.Color.White
        Me.BtTasks.Image = Global.HR.My.Resources.Resources.icons8_kackstiftaufpapier_24
        Me.BtTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtTasks.Location = New System.Drawing.Point(0, 40)
        Me.BtTasks.Name = "BtTasks"
        Me.BtTasks.Size = New System.Drawing.Size(211, 40)
        Me.BtTasks.TabIndex = 5
        Me.BtTasks.Text = "           Tasks "
        Me.BtTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtTasks.UseVisualStyleBackColor = True
        '
        'BtToDoList
        '
        Me.BtToDoList.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtToDoList.FlatAppearance.BorderSize = 0
        Me.BtToDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtToDoList.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtToDoList.ForeColor = System.Drawing.Color.White
        Me.BtToDoList.Image = Global.HR.My.Resources.Resources.icons8_add_list_24
        Me.BtToDoList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoList.Location = New System.Drawing.Point(0, 0)
        Me.BtToDoList.Name = "BtToDoList"
        Me.BtToDoList.Size = New System.Drawing.Size(211, 40)
        Me.BtToDoList.TabIndex = 4
        Me.BtToDoList.Text = "           To-Do List"
        Me.BtToDoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtToDoList.UseVisualStyleBackColor = True
        '
        'PanelMyTasksTitle
        '
        Me.PanelMyTasksTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMyTasksTitle.Controls.Add(Me.Label3)
        Me.PanelMyTasksTitle.Controls.Add(Me.BtCloseTasksPanel)
        Me.PanelMyTasksTitle.Controls.Add(Me.BtOpenTasksPanel)
        Me.PanelMyTasksTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMyTasksTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyTasksTitle.Name = "PanelMyTasksTitle"
        Me.PanelMyTasksTitle.Size = New System.Drawing.Size(211, 40)
        Me.PanelMyTasksTitle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "My Tasks"
        '
        'BtCloseTasksPanel
        '
        Me.BtCloseTasksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCloseTasksPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCloseTasksPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCloseTasksPanel.FlatAppearance.BorderSize = 0
        Me.BtCloseTasksPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCloseTasksPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCloseTasksPanel.Image = Global.HR.My.Resources.Resources.sort_down_8_1
        Me.BtCloseTasksPanel.Location = New System.Drawing.Point(33, 0)
        Me.BtCloseTasksPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCloseTasksPanel.Name = "BtCloseTasksPanel"
        Me.BtCloseTasksPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtCloseTasksPanel.TabIndex = 91
        Me.BtCloseTasksPanel.UseCompatibleTextRendering = True
        Me.BtCloseTasksPanel.UseMnemonic = False
        Me.BtCloseTasksPanel.UseVisualStyleBackColor = True
        '
        'BtOpenTasksPanel
        '
        Me.BtOpenTasksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOpenTasksPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOpenTasksPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtOpenTasksPanel.FlatAppearance.BorderSize = 0
        Me.BtOpenTasksPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOpenTasksPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpenTasksPanel.Image = Global.HR.My.Resources.Resources.sort_right_8_1
        Me.BtOpenTasksPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtOpenTasksPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtOpenTasksPanel.Name = "BtOpenTasksPanel"
        Me.BtOpenTasksPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtOpenTasksPanel.TabIndex = 90
        Me.BtOpenTasksPanel.UseCompatibleTextRendering = True
        Me.BtOpenTasksPanel.UseMnemonic = False
        Me.BtOpenTasksPanel.UseVisualStyleBackColor = True
        '
        'PanelMyCalendar
        '
        Me.PanelMyCalendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelMyCalendar.Controls.Add(Me.PaneMyCalendarButtons)
        Me.PanelMyCalendar.Controls.Add(Me.PanelMyCalendarTitle)
        Me.PanelMyCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMyCalendar.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyCalendar.Name = "PanelMyCalendar"
        Me.PanelMyCalendar.Size = New System.Drawing.Size(211, 674)
        Me.PanelMyCalendar.TabIndex = 94
        '
        'PaneMyCalendarButtons
        '
        Me.PaneMyCalendarButtons.Controls.Add(Me.BtCalendar)
        Me.PaneMyCalendarButtons.Controls.Add(Me.MonthCalendar1)
        Me.PaneMyCalendarButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneMyCalendarButtons.Location = New System.Drawing.Point(0, 40)
        Me.PaneMyCalendarButtons.Name = "PaneMyCalendarButtons"
        Me.PaneMyCalendarButtons.Size = New System.Drawing.Size(211, 634)
        Me.PaneMyCalendarButtons.TabIndex = 2
        '
        'BtCalendar
        '
        Me.BtCalendar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtCalendar.FlatAppearance.BorderSize = 0
        Me.BtCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalendar.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalendar.ForeColor = System.Drawing.Color.White
        Me.BtCalendar.Image = Global.HR.My.Resources.Resources.icons8_calendar_plus_24
        Me.BtCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendar.Location = New System.Drawing.Point(0, 162)
        Me.BtCalendar.Name = "BtCalendar"
        Me.BtCalendar.Size = New System.Drawing.Size(211, 40)
        Me.BtCalendar.TabIndex = 5
        Me.BtCalendar.Text = "           Calendar "
        Me.BtCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalendar.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'PanelMyCalendarTitle
        '
        Me.PanelMyCalendarTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMyCalendarTitle.Controls.Add(Me.Label2)
        Me.PanelMyCalendarTitle.Controls.Add(Me.BtCloseCalendarPanel)
        Me.PanelMyCalendarTitle.Controls.Add(Me.BtOpenCalendarPanel)
        Me.PanelMyCalendarTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMyCalendarTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelMyCalendarTitle.Name = "PanelMyCalendarTitle"
        Me.PanelMyCalendarTitle.Size = New System.Drawing.Size(211, 40)
        Me.PanelMyCalendarTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "My Calendar"
        '
        'BtCloseCalendarPanel
        '
        Me.BtCloseCalendarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCloseCalendarPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCloseCalendarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtCloseCalendarPanel.FlatAppearance.BorderSize = 0
        Me.BtCloseCalendarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCloseCalendarPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCloseCalendarPanel.Image = Global.HR.My.Resources.Resources.sort_down_8_1
        Me.BtCloseCalendarPanel.Location = New System.Drawing.Point(33, 0)
        Me.BtCloseCalendarPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtCloseCalendarPanel.Name = "BtCloseCalendarPanel"
        Me.BtCloseCalendarPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtCloseCalendarPanel.TabIndex = 91
        Me.BtCloseCalendarPanel.UseCompatibleTextRendering = True
        Me.BtCloseCalendarPanel.UseMnemonic = False
        Me.BtCloseCalendarPanel.UseVisualStyleBackColor = True
        '
        'BtOpenCalendarPanel
        '
        Me.BtOpenCalendarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtOpenCalendarPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtOpenCalendarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtOpenCalendarPanel.FlatAppearance.BorderSize = 0
        Me.BtOpenCalendarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtOpenCalendarPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpenCalendarPanel.Image = Global.HR.My.Resources.Resources.sort_right_8_1
        Me.BtOpenCalendarPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtOpenCalendarPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtOpenCalendarPanel.Name = "BtOpenCalendarPanel"
        Me.BtOpenCalendarPanel.Size = New System.Drawing.Size(33, 36)
        Me.BtOpenCalendarPanel.TabIndex = 90
        Me.BtOpenCalendarPanel.UseCompatibleTextRendering = True
        Me.BtOpenCalendarPanel.UseMnemonic = False
        Me.BtOpenCalendarPanel.UseVisualStyleBackColor = True
        '
        'PanelNavRight
        '
        Me.PanelNavRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelNavRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelNavRight.Controls.Add(Me.BtPinPanel)
        Me.PanelNavRight.Controls.Add(Me.BtExpandNavPanel)
        Me.PanelNavRight.Controls.Add(Me.BtHideNavPanel)
        Me.PanelNavRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelNavRight.Location = New System.Drawing.Point(215, 0)
        Me.PanelNavRight.Name = "PanelNavRight"
        Me.PanelNavRight.Size = New System.Drawing.Size(51, 678)
        Me.PanelNavRight.TabIndex = 99
        '
        'BtPinPanel
        '
        Me.BtPinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtPinPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtPinPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtPinPanel.FlatAppearance.BorderSize = 0
        Me.BtPinPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPinPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPinPanel.Image = Global.HR.My.Resources.Resources.Pin_24
        Me.BtPinPanel.Location = New System.Drawing.Point(0, 98)
        Me.BtPinPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtPinPanel.Name = "BtPinPanel"
        Me.BtPinPanel.Size = New System.Drawing.Size(47, 49)
        Me.BtPinPanel.TabIndex = 92
        Me.BtPinPanel.UseCompatibleTextRendering = True
        Me.BtPinPanel.UseMnemonic = False
        Me.BtPinPanel.UseVisualStyleBackColor = True
        '
        'BtExpandNavPanel
        '
        Me.BtExpandNavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtExpandNavPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtExpandNavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtExpandNavPanel.FlatAppearance.BorderSize = 0
        Me.BtExpandNavPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtExpandNavPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtExpandNavPanel.Image = Global.HR.My.Resources.Resources.icons8_more_than_24
        Me.BtExpandNavPanel.Location = New System.Drawing.Point(0, 49)
        Me.BtExpandNavPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtExpandNavPanel.Name = "BtExpandNavPanel"
        Me.BtExpandNavPanel.Size = New System.Drawing.Size(47, 49)
        Me.BtExpandNavPanel.TabIndex = 91
        Me.BtExpandNavPanel.UseCompatibleTextRendering = True
        Me.BtExpandNavPanel.UseMnemonic = False
        Me.BtExpandNavPanel.UseVisualStyleBackColor = True
        '
        'BtHideNavPanel
        '
        Me.BtHideNavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtHideNavPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtHideNavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtHideNavPanel.FlatAppearance.BorderSize = 0
        Me.BtHideNavPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtHideNavPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtHideNavPanel.Image = Global.HR.My.Resources.Resources.icons8_less_than_24
        Me.BtHideNavPanel.Location = New System.Drawing.Point(0, 0)
        Me.BtHideNavPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtHideNavPanel.Name = "BtHideNavPanel"
        Me.BtHideNavPanel.Size = New System.Drawing.Size(47, 49)
        Me.BtHideNavPanel.TabIndex = 89
        Me.BtHideNavPanel.UseCompatibleTextRendering = True
        Me.BtHideNavPanel.UseMnemonic = False
        Me.BtHideNavPanel.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.AutoScrollMinSize = New System.Drawing.Size(403, 497)
        Me.SplitContainer2.Size = New System.Drawing.Size(828, 678)
        Me.SplitContainer2.SplitterDistance = 428
        Me.SplitContainer2.TabIndex = 0
        '
        'FormPanel3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 678)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPanel3"
        Me.Text = "Form3"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNavBtm.ResumeLayout(False)
        Me.PanelMyMail.ResumeLayout(False)
        Me.PanelMyMailButtons.ResumeLayout(False)
        Me.PanelMyMailTitle.ResumeLayout(False)
        Me.PanelMyMailTitle.PerformLayout()
        Me.PanelMyFolders.ResumeLayout(False)
        Me.PanelMyFoldersButtons.ResumeLayout(False)
        Me.PanelMyFoldersTitle.ResumeLayout(False)
        Me.PanelMyFoldersTitle.PerformLayout()
        Me.PanelMyNotes.ResumeLayout(False)
        Me.PanelMyNotesButtons.ResumeLayout(False)
        Me.PanelMyNotesTitle.ResumeLayout(False)
        Me.PanelMyNotesTitle.PerformLayout()
        Me.PanelMyTasks.ResumeLayout(False)
        Me.PanelMyTasksButtons.ResumeLayout(False)
        Me.PanelMyTasksTitle.ResumeLayout(False)
        Me.PanelMyTasksTitle.PerformLayout()
        Me.PanelMyCalendar.ResumeLayout(False)
        Me.PaneMyCalendarButtons.ResumeLayout(False)
        Me.PanelMyCalendarTitle.ResumeLayout(False)
        Me.PanelMyCalendarTitle.PerformLayout()
        Me.PanelNavRight.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelNav As Panel
    Friend WithEvents PanelMyMail As Panel
    Friend WithEvents PanelMyMailButtons As Panel
    Friend WithEvents BtSent As Button
    Friend WithEvents BtInbox As Button
    Friend WithEvents BtComposeMail As Button
    Friend WithEvents PanelMyMailTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtCloseMailPanel As Button
    Friend WithEvents BtOpenMailPanel As Button
    Friend WithEvents PanelNavBtm As Panel
    Friend WithEvents BtFoldersPanel As Button
    Friend WithEvents BtNotesPanel As Button
    Friend WithEvents BtTasksPanel As Button
    Friend WithEvents BtCalendarPanel As Button
    Friend WithEvents BtMailPanel As Button
    Friend WithEvents PanelMyFolders As Panel
    Friend WithEvents PanelMyFoldersButtons As Panel
    Friend WithEvents BtToDoFolder As Button
    Friend WithEvents BtNotesFolder As Button
    Friend WithEvents BtCalendarFolder As Button
    Friend WithEvents BtMailInboxFolder As Button
    Friend WithEvents PanelMyFoldersTitle As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BtCloseFoldersPanel As Button
    Friend WithEvents BtOpenFoldersPanel As Button
    Friend WithEvents PanelMyNotes As Panel
    Friend WithEvents PanelMyNotesButtons As Panel
    Friend WithEvents BtNotes As Button
    Friend WithEvents PanelMyNotesTitle As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtCloseNotesPanel As Button
    Friend WithEvents BtOpenNotesPanel As Button
    Friend WithEvents PanelMyTasks As Panel
    Friend WithEvents PanelMyTasksButtons As Panel
    Friend WithEvents BtTasks As Button
    Friend WithEvents BtToDoList As Button
    Friend WithEvents PanelMyTasksTitle As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtCloseTasksPanel As Button
    Friend WithEvents BtOpenTasksPanel As Button
    Friend WithEvents PanelMyCalendar As Panel
    Friend WithEvents PaneMyCalendarButtons As Panel
    Friend WithEvents BtCalendar As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PanelMyCalendarTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtCloseCalendarPanel As Button
    Friend WithEvents BtOpenCalendarPanel As Button
    Friend WithEvents PanelNavRight As Panel
    Friend WithEvents BtPinPanel As Button
    Friend WithEvents BtExpandNavPanel As Button
    Friend WithEvents BtHideNavPanel As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtSignInAccount As Button
End Class
