<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Tutorial))
        Me.thm_Tutorial = New Maplestory___The_Forbidden_Identity.FormSkin()
        Me.tab_Tutorial = New Maplestory___The_Forbidden_Identity.FlatTabControl()
        Me.tab_Welcome = New System.Windows.Forms.TabPage()
        Me.btn_No = New Maplestory___The_Forbidden_Identity.FlatButton()
        Me.btn_Yes = New Maplestory___The_Forbidden_Identity.FlatButton()
        Me.TwitchLabel1 = New Maplestory___The_Forbidden_Identity.TwitchLabel()
        Me.tab_Shortcuts = New System.Windows.Forms.TabPage()
        Me.txt_Keys = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Pots = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Inv = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Jmp = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Attk = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Ext = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.pic_Keyboard = New System.Windows.Forms.PictureBox()
        Me.lbl_Shortcuts = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.tab_General = New System.Windows.Forms.TabPage()
        Me.TwitchTextBox1 = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.txt_Portal = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.lbl_NPC = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Name = New Maplestory___The_Forbidden_Identity.TwitchLabel()
        Me.pic_NPC = New System.Windows.Forms.PictureBox()
        Me.lbl_Portal = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.tab_Stats = New System.Windows.Forms.TabPage()
        Me.txt_Save = New Maplestory___The_Forbidden_Identity.TwitchTextBox()
        Me.FlatLabel1 = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tab_Finish = New System.Windows.Forms.TabPage()
        Me.btn_Finish = New Maplestory___The_Forbidden_Identity.FlatButton()
        Me.lbl_Rdy = New Maplestory___The_Forbidden_Identity.TwitchLabel()
        Me.thm_Tutorial.SuspendLayout()
        Me.tab_Tutorial.SuspendLayout()
        Me.tab_Welcome.SuspendLayout()
        Me.tab_Shortcuts.SuspendLayout()
        CType(Me.pic_Keyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_General.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_NPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Stats.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Finish.SuspendLayout()
        Me.SuspendLayout()
        '
        'thm_Tutorial
        '
        Me.thm_Tutorial.BackColor = System.Drawing.Color.White
        Me.thm_Tutorial.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.thm_Tutorial.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.thm_Tutorial.Controls.Add(Me.tab_Tutorial)
        Me.thm_Tutorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Tutorial.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thm_Tutorial.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.thm_Tutorial.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.thm_Tutorial.HeaderMaximize = False
        Me.thm_Tutorial.Location = New System.Drawing.Point(0, 0)
        Me.thm_Tutorial.Name = "thm_Tutorial"
        Me.thm_Tutorial.Size = New System.Drawing.Size(832, 381)
        Me.thm_Tutorial.TabIndex = 0
        Me.thm_Tutorial.Text = "Maplestory: The Forbidden Identity (Tutorial)"
        '
        'tab_Tutorial
        '
        Me.tab_Tutorial.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tab_Tutorial.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tab_Tutorial.Controls.Add(Me.tab_Welcome)
        Me.tab_Tutorial.Controls.Add(Me.tab_Shortcuts)
        Me.tab_Tutorial.Controls.Add(Me.tab_General)
        Me.tab_Tutorial.Controls.Add(Me.tab_Stats)
        Me.tab_Tutorial.Controls.Add(Me.tab_Finish)
        Me.tab_Tutorial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tab_Tutorial.ItemSize = New System.Drawing.Size(120, 40)
        Me.tab_Tutorial.Location = New System.Drawing.Point(3, 54)
        Me.tab_Tutorial.Name = "tab_Tutorial"
        Me.tab_Tutorial.SelectedIndex = 0
        Me.tab_Tutorial.Size = New System.Drawing.Size(826, 317)
        Me.tab_Tutorial.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab_Tutorial.TabIndex = 2
        '
        'tab_Welcome
        '
        Me.tab_Welcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tab_Welcome.Controls.Add(Me.btn_No)
        Me.tab_Welcome.Controls.Add(Me.btn_Yes)
        Me.tab_Welcome.Controls.Add(Me.TwitchLabel1)
        Me.tab_Welcome.Location = New System.Drawing.Point(4, 44)
        Me.tab_Welcome.Name = "tab_Welcome"
        Me.tab_Welcome.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Welcome.Size = New System.Drawing.Size(818, 269)
        Me.tab_Welcome.TabIndex = 0
        Me.tab_Welcome.Text = "Welcome"
        '
        'btn_No
        '
        Me.btn_No.BackColor = System.Drawing.Color.Transparent
        Me.btn_No.BaseColor = System.Drawing.Color.Maroon
        Me.btn_No.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_No.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.btn_No.Location = New System.Drawing.Point(414, 112)
        Me.btn_No.Name = "btn_No"
        Me.btn_No.Rounded = False
        Me.btn_No.Size = New System.Drawing.Size(195, 138)
        Me.btn_No.TabIndex = 4
        Me.btn_No.Text = "No"
        Me.btn_No.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_Yes
        '
        Me.btn_Yes.BackColor = System.Drawing.Color.Transparent
        Me.btn_Yes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Yes.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.btn_Yes.Location = New System.Drawing.Point(181, 112)
        Me.btn_Yes.Name = "btn_Yes"
        Me.btn_Yes.Rounded = False
        Me.btn_Yes.Size = New System.Drawing.Size(195, 138)
        Me.btn_Yes.TabIndex = 3
        Me.btn_Yes.Text = "Yes"
        Me.btn_Yes.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TwitchLabel1
        '
        Me.TwitchLabel1.AutoSize = True
        Me.TwitchLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel1.Font = New System.Drawing.Font("Segoe UI", 50.0!)
        Me.TwitchLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TwitchLabel1.Location = New System.Drawing.Point(126, 3)
        Me.TwitchLabel1.Name = "TwitchLabel1"
        Me.TwitchLabel1.Size = New System.Drawing.Size(579, 89)
        Me.TwitchLabel1.TabIndex = 2
        Me.TwitchLabel1.Text = "New to the game?"
        '
        'tab_Shortcuts
        '
        Me.tab_Shortcuts.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tab_Shortcuts.Controls.Add(Me.txt_Keys)
        Me.tab_Shortcuts.Controls.Add(Me.txt_Pots)
        Me.tab_Shortcuts.Controls.Add(Me.txt_Inv)
        Me.tab_Shortcuts.Controls.Add(Me.txt_Jmp)
        Me.tab_Shortcuts.Controls.Add(Me.txt_Attk)
        Me.tab_Shortcuts.Controls.Add(Me.txt_Ext)
        Me.tab_Shortcuts.Controls.Add(Me.pic_Keyboard)
        Me.tab_Shortcuts.Controls.Add(Me.lbl_Shortcuts)
        Me.tab_Shortcuts.Location = New System.Drawing.Point(4, 44)
        Me.tab_Shortcuts.Name = "tab_Shortcuts"
        Me.tab_Shortcuts.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Shortcuts.Size = New System.Drawing.Size(818, 269)
        Me.tab_Shortcuts.TabIndex = 1
        Me.tab_Shortcuts.Text = "Keyboard Shortcuts"
        '
        'txt_Keys
        '
        Me.txt_Keys.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Keys.Enabled = False
        Me.txt_Keys.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Keys.Image = Nothing
        Me.txt_Keys.Location = New System.Drawing.Point(495, 226)
        Me.txt_Keys.MaxLength = 32767
        Me.txt_Keys.Multiline = True
        Me.txt_Keys.Name = "txt_Keys"
        Me.txt_Keys.NoRounding = False
        Me.txt_Keys.ReadOnly = False
        Me.txt_Keys.Size = New System.Drawing.Size(306, 38)
        Me.txt_Keys.TabIndex = 9
        Me.txt_Keys.Text = "Arrow keys (Moves the player in the direction of the pressed key)"
        Me.txt_Keys.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Keys.Transparent = False
        Me.txt_Keys.UseSystemPasswordChar = False
        '
        'txt_Pots
        '
        Me.txt_Pots.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Pots.Enabled = False
        Me.txt_Pots.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Pots.Image = Nothing
        Me.txt_Pots.Location = New System.Drawing.Point(495, 173)
        Me.txt_Pots.MaxLength = 32767
        Me.txt_Pots.Multiline = True
        Me.txt_Pots.Name = "txt_Pots"
        Me.txt_Pots.NoRounding = False
        Me.txt_Pots.ReadOnly = False
        Me.txt_Pots.Size = New System.Drawing.Size(306, 50)
        Me.txt_Pots.TabIndex = 8
        Me.txt_Pots.Text = "HP = Health, MP = Mana (Press button to activate potions without opening the inve" & _
            "ntory, hold if needed)"
        Me.txt_Pots.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Pots.Transparent = False
        Me.txt_Pots.UseSystemPasswordChar = False
        '
        'txt_Inv
        '
        Me.txt_Inv.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Inv.Enabled = False
        Me.txt_Inv.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Inv.Image = Nothing
        Me.txt_Inv.Location = New System.Drawing.Point(495, 130)
        Me.txt_Inv.MaxLength = 32767
        Me.txt_Inv.Multiline = True
        Me.txt_Inv.Name = "txt_Inv"
        Me.txt_Inv.NoRounding = False
        Me.txt_Inv.ReadOnly = False
        Me.txt_Inv.Size = New System.Drawing.Size(306, 39)
        Me.txt_Inv.TabIndex = 7
        Me.txt_Inv.Text = "Inv = Inventory (Press to open inventory and double click on potion to activate i" & _
            "t)"
        Me.txt_Inv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Inv.Transparent = False
        Me.txt_Inv.UseSystemPasswordChar = False
        '
        'txt_Jmp
        '
        Me.txt_Jmp.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Jmp.Enabled = False
        Me.txt_Jmp.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Jmp.Image = Nothing
        Me.txt_Jmp.Location = New System.Drawing.Point(495, 87)
        Me.txt_Jmp.MaxLength = 32767
        Me.txt_Jmp.Multiline = True
        Me.txt_Jmp.Name = "txt_Jmp"
        Me.txt_Jmp.NoRounding = False
        Me.txt_Jmp.ReadOnly = False
        Me.txt_Jmp.Size = New System.Drawing.Size(306, 39)
        Me.txt_Jmp.TabIndex = 6
        Me.txt_Jmp.Text = "Jump (Press button to jump in the air - doesn't work in all places)"
        Me.txt_Jmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Jmp.Transparent = False
        Me.txt_Jmp.UseSystemPasswordChar = False
        '
        'txt_Attk
        '
        Me.txt_Attk.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Attk.Enabled = False
        Me.txt_Attk.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Attk.Image = Nothing
        Me.txt_Attk.Location = New System.Drawing.Point(495, 46)
        Me.txt_Attk.MaxLength = 32767
        Me.txt_Attk.Multiline = True
        Me.txt_Attk.Name = "txt_Attk"
        Me.txt_Attk.NoRounding = False
        Me.txt_Attk.ReadOnly = False
        Me.txt_Attk.Size = New System.Drawing.Size(306, 38)
        Me.txt_Attk.TabIndex = 5
        Me.txt_Attk.Text = "Attack (Keep holding the space button to lunch a full attack on monsters)"
        Me.txt_Attk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Attk.Transparent = False
        Me.txt_Attk.UseSystemPasswordChar = False
        '
        'txt_Ext
        '
        Me.txt_Ext.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Ext.Enabled = False
        Me.txt_Ext.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_Ext.Image = Nothing
        Me.txt_Ext.Location = New System.Drawing.Point(495, 12)
        Me.txt_Ext.MaxLength = 32767
        Me.txt_Ext.Multiline = True
        Me.txt_Ext.Name = "txt_Ext"
        Me.txt_Ext.NoRounding = False
        Me.txt_Ext.ReadOnly = False
        Me.txt_Ext.Size = New System.Drawing.Size(306, 31)
        Me.txt_Ext.TabIndex = 4
        Me.txt_Ext.Text = " EXT = Exit (Terminating the program)"
        Me.txt_Ext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Ext.Transparent = False
        Me.txt_Ext.UseSystemPasswordChar = False
        '
        'pic_Keyboard
        '
        Me.pic_Keyboard.Image = CType(resources.GetObject("pic_Keyboard.Image"), System.Drawing.Image)
        Me.pic_Keyboard.Location = New System.Drawing.Point(8, 43)
        Me.pic_Keyboard.Name = "pic_Keyboard"
        Me.pic_Keyboard.Size = New System.Drawing.Size(481, 211)
        Me.pic_Keyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_Keyboard.TabIndex = 1
        Me.pic_Keyboard.TabStop = False
        '
        'lbl_Shortcuts
        '
        Me.lbl_Shortcuts.AutoSize = True
        Me.lbl_Shortcuts.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Shortcuts.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_Shortcuts.ForeColor = System.Drawing.Color.White
        Me.lbl_Shortcuts.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Shortcuts.Name = "lbl_Shortcuts"
        Me.lbl_Shortcuts.Size = New System.Drawing.Size(331, 28)
        Me.lbl_Shortcuts.TabIndex = 0
        Me.lbl_Shortcuts.Text = "Keyboard Shortcuts AND Definitions"
        '
        'tab_General
        '
        Me.tab_General.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tab_General.Controls.Add(Me.TwitchTextBox1)
        Me.tab_General.Controls.Add(Me.txt_Portal)
        Me.tab_General.Controls.Add(Me.lbl_NPC)
        Me.tab_General.Controls.Add(Me.PictureBox1)
        Me.tab_General.Controls.Add(Me.lbl_Name)
        Me.tab_General.Controls.Add(Me.pic_NPC)
        Me.tab_General.Controls.Add(Me.lbl_Portal)
        Me.tab_General.Location = New System.Drawing.Point(4, 44)
        Me.tab_General.Name = "tab_General"
        Me.tab_General.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_General.Size = New System.Drawing.Size(818, 269)
        Me.tab_General.TabIndex = 2
        Me.tab_General.Text = "General"
        '
        'TwitchTextBox1
        '
        Me.TwitchTextBox1.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.TwitchTextBox1.Enabled = False
        Me.TwitchTextBox1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TwitchTextBox1.Image = Nothing
        Me.TwitchTextBox1.Location = New System.Drawing.Point(660, 46)
        Me.TwitchTextBox1.MaxLength = 32767
        Me.TwitchTextBox1.Multiline = True
        Me.TwitchTextBox1.Name = "TwitchTextBox1"
        Me.TwitchTextBox1.NoRounding = False
        Me.TwitchTextBox1.ReadOnly = False
        Me.TwitchTextBox1.Size = New System.Drawing.Size(152, 189)
        Me.TwitchTextBox1.TabIndex = 52
        Me.TwitchTextBox1.Text = "Player must double click on the NPC (non-player character) in order to chat with " & _
            "them and accept any quests."
        Me.TwitchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TwitchTextBox1.Transparent = False
        Me.TwitchTextBox1.UseSystemPasswordChar = False
        '
        'txt_Portal
        '
        Me.txt_Portal.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Portal.Enabled = False
        Me.txt_Portal.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txt_Portal.Image = Nothing
        Me.txt_Portal.Location = New System.Drawing.Point(206, 46)
        Me.txt_Portal.MaxLength = 32767
        Me.txt_Portal.Multiline = True
        Me.txt_Portal.Name = "txt_Portal"
        Me.txt_Portal.NoRounding = False
        Me.txt_Portal.ReadOnly = False
        Me.txt_Portal.Size = New System.Drawing.Size(306, 189)
        Me.txt_Portal.TabIndex = 51
        Me.txt_Portal.Text = resources.GetString("txt_Portal.Text")
        Me.txt_Portal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Portal.Transparent = False
        Me.txt_Portal.UseSystemPasswordChar = False
        '
        'lbl_NPC
        '
        Me.lbl_NPC.AutoSize = True
        Me.lbl_NPC.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NPC.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lbl_NPC.ForeColor = System.Drawing.Color.White
        Me.lbl_NPC.Location = New System.Drawing.Point(513, 9)
        Me.lbl_NPC.Name = "lbl_NPC"
        Me.lbl_NPC.Size = New System.Drawing.Size(141, 32)
        Me.lbl_NPC.TabIndex = 50
        Me.lbl_NPC.Text = "NPC Quests"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Name.ForeColor = System.Drawing.Color.White
        Me.lbl_Name.Location = New System.Drawing.Point(595, 214)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(41, 21)
        Me.lbl_Name.TabIndex = 48
        Me.lbl_Name.Text = "Reef"
        '
        'pic_NPC
        '
        Me.pic_NPC.Image = CType(resources.GetObject("pic_NPC.Image"), System.Drawing.Image)
        Me.pic_NPC.Location = New System.Drawing.Point(518, 57)
        Me.pic_NPC.Name = "pic_NPC"
        Me.pic_NPC.Size = New System.Drawing.Size(136, 158)
        Me.pic_NPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_NPC.TabIndex = 3
        Me.pic_NPC.TabStop = False
        '
        'lbl_Portal
        '
        Me.lbl_Portal.AutoSize = True
        Me.lbl_Portal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Portal.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lbl_Portal.ForeColor = System.Drawing.Color.White
        Me.lbl_Portal.Location = New System.Drawing.Point(6, 9)
        Me.lbl_Portal.Name = "lbl_Portal"
        Me.lbl_Portal.Size = New System.Drawing.Size(194, 32)
        Me.lbl_Portal.TabIndex = 2
        Me.lbl_Portal.Text = "How to teleport?"
        '
        'tab_Stats
        '
        Me.tab_Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tab_Stats.Controls.Add(Me.txt_Save)
        Me.tab_Stats.Controls.Add(Me.FlatLabel1)
        Me.tab_Stats.Controls.Add(Me.PictureBox2)
        Me.tab_Stats.Location = New System.Drawing.Point(4, 44)
        Me.tab_Stats.Name = "tab_Stats"
        Me.tab_Stats.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Stats.Size = New System.Drawing.Size(818, 269)
        Me.tab_Stats.TabIndex = 3
        Me.tab_Stats.Text = "Game Statistics"
        '
        'txt_Save
        '
        Me.txt_Save.Customization = "/////wAAAP8eHh7/Hh4e/w=="
        Me.txt_Save.Enabled = False
        Me.txt_Save.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txt_Save.Image = Nothing
        Me.txt_Save.Location = New System.Drawing.Point(12, 38)
        Me.txt_Save.MaxLength = 32767
        Me.txt_Save.Multiline = True
        Me.txt_Save.Name = "txt_Save"
        Me.txt_Save.NoRounding = False
        Me.txt_Save.ReadOnly = False
        Me.txt_Save.Size = New System.Drawing.Size(415, 82)
        Me.txt_Save.TabIndex = 54
        Me.txt_Save.Text = "The game has a built-in auto save feature. What that means, is that that will alw" & _
            "ays be saved, so you'll never loss your account state."
        Me.txt_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Save.Transparent = False
        Me.txt_Save.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(6, 3)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(123, 32)
        Me.FlatLabel1.TabIndex = 53
        Me.FlatLabel1.Text = "Auto Save"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(746, 240)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'tab_Finish
        '
        Me.tab_Finish.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tab_Finish.Controls.Add(Me.btn_Finish)
        Me.tab_Finish.Controls.Add(Me.lbl_Rdy)
        Me.tab_Finish.Location = New System.Drawing.Point(4, 44)
        Me.tab_Finish.Name = "tab_Finish"
        Me.tab_Finish.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Finish.Size = New System.Drawing.Size(818, 269)
        Me.tab_Finish.TabIndex = 4
        Me.tab_Finish.Text = "Finish"
        '
        'btn_Finish
        '
        Me.btn_Finish.BackColor = System.Drawing.Color.Transparent
        Me.btn_Finish.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Finish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Finish.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.btn_Finish.Location = New System.Drawing.Point(89, 136)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.Rounded = False
        Me.btn_Finish.Size = New System.Drawing.Size(647, 105)
        Me.btn_Finish.TabIndex = 4
        Me.btn_Finish.Text = "Yes"
        Me.btn_Finish.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lbl_Rdy
        '
        Me.lbl_Rdy.AutoSize = True
        Me.lbl_Rdy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Rdy.Font = New System.Drawing.Font("Segoe UI", 50.0!)
        Me.lbl_Rdy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lbl_Rdy.Location = New System.Drawing.Point(74, 14)
        Me.lbl_Rdy.Name = "lbl_Rdy"
        Me.lbl_Rdy.Size = New System.Drawing.Size(696, 89)
        Me.lbl_Rdy.TabIndex = 3
        Me.lbl_Rdy.Text = "Are you ready to play?"
        '
        'frm_Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 381)
        Me.Controls.Add(Me.thm_Tutorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Tutorial"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Tutorial.ResumeLayout(False)
        Me.tab_Tutorial.ResumeLayout(False)
        Me.tab_Welcome.ResumeLayout(False)
        Me.tab_Welcome.PerformLayout()
        Me.tab_Shortcuts.ResumeLayout(False)
        Me.tab_Shortcuts.PerformLayout()
        CType(Me.pic_Keyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_General.ResumeLayout(False)
        Me.tab_General.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_NPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Stats.ResumeLayout(False)
        Me.tab_Stats.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Finish.ResumeLayout(False)
        Me.tab_Finish.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Tutorial As Maplestory___The_Forbidden_Identity.FormSkin
    Friend WithEvents tab_Tutorial As Maplestory___The_Forbidden_Identity.FlatTabControl
    Friend WithEvents tab_Welcome As System.Windows.Forms.TabPage
    Friend WithEvents btn_No As Maplestory___The_Forbidden_Identity.FlatButton
    Friend WithEvents btn_Yes As Maplestory___The_Forbidden_Identity.FlatButton
    Friend WithEvents TwitchLabel1 As Maplestory___The_Forbidden_Identity.TwitchLabel
    Friend WithEvents tab_Shortcuts As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Shortcuts As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents pic_Keyboard As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Keys As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents txt_Pots As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents txt_Inv As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents txt_Jmp As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents txt_Attk As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents txt_Ext As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents tab_General As System.Windows.Forms.TabPage
    Friend WithEvents pic_NPC As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Portal As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Name As Maplestory___The_Forbidden_Identity.TwitchLabel
    Friend WithEvents lbl_NPC As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Portal As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents TwitchTextBox1 As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents tab_Stats As System.Windows.Forms.TabPage
    Friend WithEvents tab_Finish As System.Windows.Forms.TabPage
    Friend WithEvents txt_Save As Maplestory___The_Forbidden_Identity.TwitchTextBox
    Friend WithEvents FlatLabel1 As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents btn_Finish As Maplestory___The_Forbidden_Identity.FlatButton
    Friend WithEvents lbl_Rdy As Maplestory___The_Forbidden_Identity.TwitchLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
