<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Craps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Craps))
        Me.tmr_Check = New System.Windows.Forms.Timer(Me.components)
        Me.thm_Craps = New Casino_Craps_Practice_Edition.ElegantThemeContainer()
        Me.pic_H12 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipH12 = New System.Windows.Forms.PictureBox()
        Me.pic_SnkEye = New System.Windows.Forms.PictureBox()
        Me.pic_ChipSnkEye = New System.Windows.Forms.PictureBox()
        Me.grp_Stats = New System.Windows.Forms.GroupBox()
        Me.lbl_Loses = New Casino_Craps_Practice_Edition.ElegantThemeLabel()
        Me.lbl_Wins = New Casino_Craps_Practice_Edition.ElegantThemeLabel()
        Me.lbl_bWon = New Casino_Craps_Practice_Edition.ElegantThemeLabel()
        Me.pic_H8 = New System.Windows.Forms.PictureBox()
        Me.pic_H6 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipH4 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipH8 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipH10 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipH6 = New System.Windows.Forms.PictureBox()
        Me.pic_H4 = New System.Windows.Forms.PictureBox()
        Me.pic_H10 = New System.Windows.Forms.PictureBox()
        Me.pic_B8 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipB8 = New System.Windows.Forms.PictureBox()
        Me.pic_ChipB6 = New System.Windows.Forms.PictureBox()
        Me.pic_B6 = New System.Windows.Forms.PictureBox()
        Me.pic_PChip = New System.Windows.Forms.PictureBox()
        Me.pic_Pass = New System.Windows.Forms.PictureBox()
        Me.pic_dPass = New System.Windows.Forms.PictureBox()
        Me.pic_Chip = New System.Windows.Forms.PictureBox()
        Me.pic_DChip = New System.Windows.Forms.PictureBox()
        Me.pic_Point = New System.Windows.Forms.PictureBox()
        Me.btn_Roll = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.btn_Reset = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.grp_Chip = New System.Windows.Forms.GroupBox()
        Me.cbo_Chips = New System.Windows.Forms.ComboBox()
        Me.pic_Settings = New System.Windows.Forms.PictureBox()
        Me.grp_Dice = New System.Windows.Forms.GroupBox()
        Me.pic_Dice2 = New System.Windows.Forms.PictureBox()
        Me.pic_Dice1 = New System.Windows.Forms.PictureBox()
        Me.btn_Buy = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.txt_Money = New Casino_Craps_Practice_Edition.ElegantThemeRichTextBox()
        Me.lbl_Status = New Casino_Craps_Practice_Edition.ElegantThemeStatusBar()
        Me.btn_Home = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.pic_Craps = New System.Windows.Forms.PictureBox()
        Me.thm_Craps.SuspendLayout()
        CType(Me.pic_H12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipH12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_SnkEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipSnkEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Stats.SuspendLayout()
        CType(Me.pic_H8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_H6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipH4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipH8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipH10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipH6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_H4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_H10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_B8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipB8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ChipB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_B6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_PChip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_dPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Chip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_DChip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Point, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Chip.SuspendLayout()
        CType(Me.pic_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Dice.SuspendLayout()
        CType(Me.pic_Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_Check
        '
        Me.tmr_Check.Enabled = True
        '
        'thm_Craps
        '
        Me.thm_Craps.AllowClose = True
        Me.thm_Craps.AllowMaximize = True
        Me.thm_Craps.AllowMinimize = True
        Me.thm_Craps.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Craps.BaseColour = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Craps.BorderColour = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.thm_Craps.ControlBaseColour = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.thm_Craps.ControlBoxButtonSplitColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.thm_Craps.ControlBoxColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.thm_Craps.Controls.Add(Me.pic_H12)
        Me.thm_Craps.Controls.Add(Me.pic_ChipH12)
        Me.thm_Craps.Controls.Add(Me.pic_SnkEye)
        Me.thm_Craps.Controls.Add(Me.pic_ChipSnkEye)
        Me.thm_Craps.Controls.Add(Me.grp_Stats)
        Me.thm_Craps.Controls.Add(Me.pic_H8)
        Me.thm_Craps.Controls.Add(Me.pic_H6)
        Me.thm_Craps.Controls.Add(Me.pic_ChipH4)
        Me.thm_Craps.Controls.Add(Me.pic_ChipH8)
        Me.thm_Craps.Controls.Add(Me.pic_ChipH10)
        Me.thm_Craps.Controls.Add(Me.pic_ChipH6)
        Me.thm_Craps.Controls.Add(Me.pic_H4)
        Me.thm_Craps.Controls.Add(Me.pic_H10)
        Me.thm_Craps.Controls.Add(Me.pic_B8)
        Me.thm_Craps.Controls.Add(Me.pic_ChipB8)
        Me.thm_Craps.Controls.Add(Me.pic_ChipB6)
        Me.thm_Craps.Controls.Add(Me.pic_B6)
        Me.thm_Craps.Controls.Add(Me.pic_PChip)
        Me.thm_Craps.Controls.Add(Me.pic_Pass)
        Me.thm_Craps.Controls.Add(Me.pic_dPass)
        Me.thm_Craps.Controls.Add(Me.pic_Chip)
        Me.thm_Craps.Controls.Add(Me.pic_DChip)
        Me.thm_Craps.Controls.Add(Me.pic_Point)
        Me.thm_Craps.Controls.Add(Me.btn_Roll)
        Me.thm_Craps.Controls.Add(Me.btn_Reset)
        Me.thm_Craps.Controls.Add(Me.grp_Chip)
        Me.thm_Craps.Controls.Add(Me.pic_Settings)
        Me.thm_Craps.Controls.Add(Me.grp_Dice)
        Me.thm_Craps.Controls.Add(Me.btn_Buy)
        Me.thm_Craps.Controls.Add(Me.txt_Money)
        Me.thm_Craps.Controls.Add(Me.lbl_Status)
        Me.thm_Craps.Controls.Add(Me.btn_Home)
        Me.thm_Craps.Controls.Add(Me.pic_Craps)
        Me.thm_Craps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Craps.IconColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.thm_Craps.Location = New System.Drawing.Point(0, 0)
        Me.thm_Craps.Name = "thm_Craps"
        Me.thm_Craps.Size = New System.Drawing.Size(796, 620)
        Me.thm_Craps.TabIndex = 0
        Me.thm_Craps.Text = "Casino Craps Practice Mode 2018"
        Me.thm_Craps.TopStripBorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.thm_Craps.TopStripColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'pic_H12
        '
        Me.pic_H12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_H12.Image = CType(resources.GetObject("pic_H12.Image"), System.Drawing.Image)
        Me.pic_H12.Location = New System.Drawing.Point(694, 363)
        Me.pic_H12.Name = "pic_H12"
        Me.pic_H12.Size = New System.Drawing.Size(25, 34)
        Me.pic_H12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_H12.TabIndex = 46
        Me.pic_H12.TabStop = False
        Me.pic_H12.Visible = False
        '
        'pic_ChipH12
        '
        Me.pic_ChipH12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipH12.Location = New System.Drawing.Point(688, 363)
        Me.pic_ChipH12.Name = "pic_ChipH12"
        Me.pic_ChipH12.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipH12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipH12.TabIndex = 47
        Me.pic_ChipH12.TabStop = False
        Me.pic_ChipH12.Visible = False
        '
        'pic_SnkEye
        '
        Me.pic_SnkEye.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_SnkEye.Image = CType(resources.GetObject("pic_SnkEye.Image"), System.Drawing.Image)
        Me.pic_SnkEye.Location = New System.Drawing.Point(616, 363)
        Me.pic_SnkEye.Name = "pic_SnkEye"
        Me.pic_SnkEye.Size = New System.Drawing.Size(25, 34)
        Me.pic_SnkEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_SnkEye.TabIndex = 44
        Me.pic_SnkEye.TabStop = False
        Me.pic_SnkEye.Visible = False
        '
        'pic_ChipSnkEye
        '
        Me.pic_ChipSnkEye.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipSnkEye.Location = New System.Drawing.Point(643, 363)
        Me.pic_ChipSnkEye.Name = "pic_ChipSnkEye"
        Me.pic_ChipSnkEye.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipSnkEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipSnkEye.TabIndex = 45
        Me.pic_ChipSnkEye.TabStop = False
        Me.pic_ChipSnkEye.Visible = False
        '
        'grp_Stats
        '
        Me.grp_Stats.BackColor = System.Drawing.Color.Transparent
        Me.grp_Stats.Controls.Add(Me.lbl_Loses)
        Me.grp_Stats.Controls.Add(Me.lbl_Wins)
        Me.grp_Stats.Controls.Add(Me.lbl_bWon)
        Me.grp_Stats.ForeColor = System.Drawing.Color.Red
        Me.grp_Stats.Location = New System.Drawing.Point(482, 512)
        Me.grp_Stats.Name = "grp_Stats"
        Me.grp_Stats.Size = New System.Drawing.Size(149, 80)
        Me.grp_Stats.TabIndex = 23
        Me.grp_Stats.TabStop = False
        Me.grp_Stats.Tag = ""
        Me.grp_Stats.Text = "Stats:"
        '
        'lbl_Loses
        '
        Me.lbl_Loses.AutoSize = True
        Me.lbl_Loses.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Loses.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Loses.FontColour = System.Drawing.Color.DodgerBlue
        Me.lbl_Loses.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Loses.Location = New System.Drawing.Point(0, 62)
        Me.lbl_Loses.Name = "lbl_Loses"
        Me.lbl_Loses.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Loses.TabIndex = 2
        Me.lbl_Loses.Text = "Loses:"
        '
        'lbl_Wins
        '
        Me.lbl_Wins.AutoSize = True
        Me.lbl_Wins.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wins.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Wins.FontColour = System.Drawing.Color.DodgerBlue
        Me.lbl_Wins.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Wins.Location = New System.Drawing.Point(0, 39)
        Me.lbl_Wins.Name = "lbl_Wins"
        Me.lbl_Wins.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Wins.TabIndex = 1
        Me.lbl_Wins.Text = "Wins: "
        '
        'lbl_bWon
        '
        Me.lbl_bWon.AutoSize = True
        Me.lbl_bWon.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bWon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_bWon.FontColour = System.Drawing.Color.DodgerBlue
        Me.lbl_bWon.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_bWon.Location = New System.Drawing.Point(0, 16)
        Me.lbl_bWon.Name = "lbl_bWon"
        Me.lbl_bWon.Size = New System.Drawing.Size(61, 15)
        Me.lbl_bWon.TabIndex = 0
        Me.lbl_bWon.Text = "Bets won: "
        '
        'pic_H8
        '
        Me.pic_H8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_H8.Image = CType(resources.GetObject("pic_H8.Image"), System.Drawing.Image)
        Me.pic_H8.Location = New System.Drawing.Point(606, 317)
        Me.pic_H8.Name = "pic_H8"
        Me.pic_H8.Size = New System.Drawing.Size(25, 34)
        Me.pic_H8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_H8.TabIndex = 36
        Me.pic_H8.TabStop = False
        Me.pic_H8.Visible = False
        '
        'pic_H6
        '
        Me.pic_H6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_H6.Image = CType(resources.GetObject("pic_H6.Image"), System.Drawing.Image)
        Me.pic_H6.Location = New System.Drawing.Point(606, 268)
        Me.pic_H6.Name = "pic_H6"
        Me.pic_H6.Size = New System.Drawing.Size(25, 34)
        Me.pic_H6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_H6.TabIndex = 37
        Me.pic_H6.TabStop = False
        Me.pic_H6.Visible = False
        '
        'pic_ChipH4
        '
        Me.pic_ChipH4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipH4.Location = New System.Drawing.Point(717, 317)
        Me.pic_ChipH4.Name = "pic_ChipH4"
        Me.pic_ChipH4.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipH4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipH4.TabIndex = 43
        Me.pic_ChipH4.TabStop = False
        Me.pic_ChipH4.Visible = False
        '
        'pic_ChipH8
        '
        Me.pic_ChipH8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipH8.Location = New System.Drawing.Point(606, 317)
        Me.pic_ChipH8.Name = "pic_ChipH8"
        Me.pic_ChipH8.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipH8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipH8.TabIndex = 42
        Me.pic_ChipH8.TabStop = False
        Me.pic_ChipH8.Visible = False
        '
        'pic_ChipH10
        '
        Me.pic_ChipH10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipH10.Location = New System.Drawing.Point(717, 268)
        Me.pic_ChipH10.Name = "pic_ChipH10"
        Me.pic_ChipH10.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipH10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipH10.TabIndex = 41
        Me.pic_ChipH10.TabStop = False
        Me.pic_ChipH10.Visible = False
        '
        'pic_ChipH6
        '
        Me.pic_ChipH6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipH6.Location = New System.Drawing.Point(606, 268)
        Me.pic_ChipH6.Name = "pic_ChipH6"
        Me.pic_ChipH6.Size = New System.Drawing.Size(42, 34)
        Me.pic_ChipH6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipH6.TabIndex = 40
        Me.pic_ChipH6.TabStop = False
        Me.pic_ChipH6.Visible = False
        '
        'pic_H4
        '
        Me.pic_H4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_H4.Image = CType(resources.GetObject("pic_H4.Image"), System.Drawing.Image)
        Me.pic_H4.Location = New System.Drawing.Point(700, 317)
        Me.pic_H4.Name = "pic_H4"
        Me.pic_H4.Size = New System.Drawing.Size(25, 34)
        Me.pic_H4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_H4.TabIndex = 39
        Me.pic_H4.TabStop = False
        Me.pic_H4.Visible = False
        '
        'pic_H10
        '
        Me.pic_H10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_H10.Image = CType(resources.GetObject("pic_H10.Image"), System.Drawing.Image)
        Me.pic_H10.Location = New System.Drawing.Point(700, 268)
        Me.pic_H10.Name = "pic_H10"
        Me.pic_H10.Size = New System.Drawing.Size(25, 34)
        Me.pic_H10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_H10.TabIndex = 38
        Me.pic_H10.TabStop = False
        Me.pic_H10.Visible = False
        '
        'pic_B8
        '
        Me.pic_B8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_B8.Image = CType(resources.GetObject("pic_B8.Image"), System.Drawing.Image)
        Me.pic_B8.Location = New System.Drawing.Point(108, 354)
        Me.pic_B8.Name = "pic_B8"
        Me.pic_B8.Size = New System.Drawing.Size(22, 29)
        Me.pic_B8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_B8.TabIndex = 33
        Me.pic_B8.TabStop = False
        Me.pic_B8.Visible = False
        '
        'pic_ChipB8
        '
        Me.pic_ChipB8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipB8.Location = New System.Drawing.Point(115, 340)
        Me.pic_ChipB8.Name = "pic_ChipB8"
        Me.pic_ChipB8.Size = New System.Drawing.Size(45, 43)
        Me.pic_ChipB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipB8.TabIndex = 35
        Me.pic_ChipB8.TabStop = False
        Me.pic_ChipB8.Visible = False
        '
        'pic_ChipB6
        '
        Me.pic_ChipB6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_ChipB6.Location = New System.Drawing.Point(69, 288)
        Me.pic_ChipB6.Name = "pic_ChipB6"
        Me.pic_ChipB6.Size = New System.Drawing.Size(45, 34)
        Me.pic_ChipB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ChipB6.TabIndex = 34
        Me.pic_ChipB6.TabStop = False
        Me.pic_ChipB6.Visible = False
        '
        'pic_B6
        '
        Me.pic_B6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_B6.Image = CType(resources.GetObject("pic_B6.Image"), System.Drawing.Image)
        Me.pic_B6.Location = New System.Drawing.Point(70, 322)
        Me.pic_B6.Name = "pic_B6"
        Me.pic_B6.Size = New System.Drawing.Size(22, 29)
        Me.pic_B6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_B6.TabIndex = 32
        Me.pic_B6.TabStop = False
        Me.pic_B6.Visible = False
        '
        'pic_PChip
        '
        Me.pic_PChip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_PChip.Location = New System.Drawing.Point(416, 389)
        Me.pic_PChip.Name = "pic_PChip"
        Me.pic_PChip.Size = New System.Drawing.Size(45, 34)
        Me.pic_PChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_PChip.TabIndex = 31
        Me.pic_PChip.TabStop = False
        '
        'pic_Pass
        '
        Me.pic_Pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_Pass.Image = CType(resources.GetObject("pic_Pass.Image"), System.Drawing.Image)
        Me.pic_Pass.Location = New System.Drawing.Point(368, 389)
        Me.pic_Pass.Name = "pic_Pass"
        Me.pic_Pass.Size = New System.Drawing.Size(28, 34)
        Me.pic_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Pass.TabIndex = 30
        Me.pic_Pass.TabStop = False
        Me.pic_Pass.Visible = False
        '
        'pic_dPass
        '
        Me.pic_dPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_dPass.Image = CType(resources.GetObject("pic_dPass.Image"), System.Drawing.Image)
        Me.pic_dPass.Location = New System.Drawing.Point(368, 349)
        Me.pic_dPass.Name = "pic_dPass"
        Me.pic_dPass.Size = New System.Drawing.Size(28, 34)
        Me.pic_dPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_dPass.TabIndex = 29
        Me.pic_dPass.TabStop = False
        Me.pic_dPass.Visible = False
        '
        'pic_Chip
        '
        Me.pic_Chip.Image = CType(resources.GetObject("pic_Chip.Image"), System.Drawing.Image)
        Me.pic_Chip.Location = New System.Drawing.Point(215, 558)
        Me.pic_Chip.Name = "pic_Chip"
        Me.pic_Chip.Size = New System.Drawing.Size(50, 34)
        Me.pic_Chip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Chip.TabIndex = 21
        Me.pic_Chip.TabStop = False
        '
        'pic_DChip
        '
        Me.pic_DChip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pic_DChip.Location = New System.Drawing.Point(416, 349)
        Me.pic_DChip.Name = "pic_DChip"
        Me.pic_DChip.Size = New System.Drawing.Size(45, 34)
        Me.pic_DChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_DChip.TabIndex = 22
        Me.pic_DChip.TabStop = False
        '
        'pic_Point
        '
        Me.pic_Point.Image = CType(resources.GetObject("pic_Point.Image"), System.Drawing.Image)
        Me.pic_Point.Location = New System.Drawing.Point(4, 68)
        Me.pic_Point.Name = "pic_Point"
        Me.pic_Point.Size = New System.Drawing.Size(40, 17)
        Me.pic_Point.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Point.TabIndex = 21
        Me.pic_Point.TabStop = False
        Me.pic_Point.Visible = False
        '
        'btn_Roll
        '
        Me.btn_Roll.BackColor = System.Drawing.Color.Transparent
        Me.btn_Roll.BaseColour = System.Drawing.Color.Goldenrod
        Me.btn_Roll.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Roll.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Roll.Location = New System.Drawing.Point(637, 516)
        Me.btn_Roll.Name = "btn_Roll"
        Me.btn_Roll.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Roll.Size = New System.Drawing.Size(146, 76)
        Me.btn_Roll.TabIndex = 18
        Me.btn_Roll.Text = "Roll"
        Me.btn_Roll.TextColour = System.Drawing.SystemColors.Info
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_Reset.BaseColour = System.Drawing.Color.Firebrick
        Me.btn_Reset.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Reset.Location = New System.Drawing.Point(335, 516)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Reset.Size = New System.Drawing.Size(141, 76)
        Me.btn_Reset.TabIndex = 17
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.TextColour = System.Drawing.Color.WhiteSmoke
        '
        'grp_Chip
        '
        Me.grp_Chip.BackColor = System.Drawing.Color.Transparent
        Me.grp_Chip.Controls.Add(Me.cbo_Chips)
        Me.grp_Chip.ForeColor = System.Drawing.Color.Red
        Me.grp_Chip.Location = New System.Drawing.Point(167, 516)
        Me.grp_Chip.Name = "grp_Chip"
        Me.grp_Chip.Size = New System.Drawing.Size(149, 80)
        Me.grp_Chip.TabIndex = 22
        Me.grp_Chip.TabStop = False
        Me.grp_Chip.Tag = ""
        Me.grp_Chip.Text = "Bet"
        '
        'cbo_Chips
        '
        Me.cbo_Chips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Chips.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbo_Chips.FormattingEnabled = True
        Me.cbo_Chips.Items.AddRange(New Object() {"Chip [$5]", "Chip [$25]", "Chip [$100]", "Chip [$500]", "Chip [$1000]", "Chip [ALL IN]"})
        Me.cbo_Chips.Location = New System.Drawing.Point(4, 15)
        Me.cbo_Chips.Name = "cbo_Chips"
        Me.cbo_Chips.Size = New System.Drawing.Size(139, 21)
        Me.cbo_Chips.TabIndex = 19
        '
        'pic_Settings
        '
        Me.pic_Settings.Image = CType(resources.GetObject("pic_Settings.Image"), System.Drawing.Image)
        Me.pic_Settings.Location = New System.Drawing.Point(682, 31)
        Me.pic_Settings.Name = "pic_Settings"
        Me.pic_Settings.Size = New System.Drawing.Size(34, 31)
        Me.pic_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Settings.TabIndex = 14
        Me.pic_Settings.TabStop = False
        '
        'grp_Dice
        '
        Me.grp_Dice.Controls.Add(Me.pic_Dice2)
        Me.grp_Dice.Controls.Add(Me.pic_Dice1)
        Me.grp_Dice.ForeColor = System.Drawing.Color.Red
        Me.grp_Dice.Location = New System.Drawing.Point(4, 516)
        Me.grp_Dice.Name = "grp_Dice"
        Me.grp_Dice.Size = New System.Drawing.Size(157, 80)
        Me.grp_Dice.TabIndex = 13
        Me.grp_Dice.TabStop = False
        Me.grp_Dice.Tag = ""
        Me.grp_Dice.Text = "Dice"
        '
        'pic_Dice2
        '
        Me.pic_Dice2.Image = CType(resources.GetObject("pic_Dice2.Image"), System.Drawing.Image)
        Me.pic_Dice2.Location = New System.Drawing.Point(82, 16)
        Me.pic_Dice2.Name = "pic_Dice2"
        Me.pic_Dice2.Size = New System.Drawing.Size(70, 60)
        Me.pic_Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Dice2.TabIndex = 20
        Me.pic_Dice2.TabStop = False
        '
        'pic_Dice1
        '
        Me.pic_Dice1.Image = CType(resources.GetObject("pic_Dice1.Image"), System.Drawing.Image)
        Me.pic_Dice1.Location = New System.Drawing.Point(6, 16)
        Me.pic_Dice1.Name = "pic_Dice1"
        Me.pic_Dice1.Size = New System.Drawing.Size(70, 60)
        Me.pic_Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Dice1.TabIndex = 19
        Me.pic_Dice1.TabStop = False
        '
        'btn_Buy
        '
        Me.btn_Buy.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buy.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Buy.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Buy.Location = New System.Drawing.Point(136, 38)
        Me.btn_Buy.Name = "btn_Buy"
        Me.btn_Buy.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Buy.Size = New System.Drawing.Size(64, 24)
        Me.btn_Buy.TabIndex = 11
        Me.btn_Buy.Text = "Buy"
        Me.btn_Buy.TextColour = System.Drawing.Color.Firebrick
        '
        'txt_Money
        '
        Me.txt_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txt_Money.Enabled = False
        Me.txt_Money.Location = New System.Drawing.Point(14, 38)
        Me.txt_Money.Name = "txt_Money"
        Me.txt_Money.Size = New System.Drawing.Size(116, 24)
        Me.txt_Money.TabIndex = 3
        Me.txt_Money.Text = "1000"
        Me.txt_Money.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        'lbl_Status
        '
        Me.lbl_Status.AmountOfString = Casino_Craps_Practice_Edition.ElegantThemeStatusBar.AmountOfStrings.One
        Me.lbl_Status.BaseColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lbl_Status.BorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lbl_Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_Status.FirstLabelAlignment = Casino_Craps_Practice_Edition.ElegantThemeStatusBar.Alignments.Center
        Me.lbl_Status.FirstLabelText = "Everything is ready..."
        Me.lbl_Status.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Status.ForeColor = System.Drawing.Color.White
        Me.lbl_Status.LinesToShow = Casino_Craps_Practice_Edition.ElegantThemeStatusBar.LinesCount.One
        Me.lbl_Status.Location = New System.Drawing.Point(0, 597)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_Status.SecondLabelAlignment = Casino_Craps_Practice_Edition.ElegantThemeStatusBar.Alignments.Center
        Me.lbl_Status.SecondLabelText = "Label2"
        Me.lbl_Status.ShowBorder = True
        Me.lbl_Status.ShowLine = True
        Me.lbl_Status.Size = New System.Drawing.Size(796, 23)
        Me.lbl_Status.TabIndex = 2
        Me.lbl_Status.TextColour = System.Drawing.Color.Red
        Me.lbl_Status.ThirdLabelAlignment = Casino_Craps_Practice_Edition.ElegantThemeStatusBar.Alignments.Center
        Me.lbl_Status.ThirdLabelText = "Label3"
        '
        'btn_Home
        '
        Me.btn_Home.BackColor = System.Drawing.Color.Transparent
        Me.btn_Home.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Home.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Home.Location = New System.Drawing.Point(722, 31)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Home.Size = New System.Drawing.Size(62, 31)
        Me.btn_Home.TabIndex = 1
        Me.btn_Home.Text = "Home"
        Me.btn_Home.TextColour = System.Drawing.SystemColors.MenuHighlight
        '
        'pic_Craps
        '
        Me.pic_Craps.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pic_Craps.Image = CType(resources.GetObject("pic_Craps.Image"), System.Drawing.Image)
        Me.pic_Craps.Location = New System.Drawing.Point(4, 67)
        Me.pic_Craps.Name = "pic_Craps"
        Me.pic_Craps.Size = New System.Drawing.Size(780, 443)
        Me.pic_Craps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Craps.TabIndex = 0
        Me.pic_Craps.TabStop = False
        '
        'frm_Craps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(796, 620)
        Me.Controls.Add(Me.thm_Craps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(796, 620)
        Me.MinimumSize = New System.Drawing.Size(796, 620)
        Me.Name = "frm_Craps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Craps.ResumeLayout(False)
        CType(Me.pic_H12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipH12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_SnkEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipSnkEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Stats.ResumeLayout(False)
        Me.grp_Stats.PerformLayout()
        CType(Me.pic_H8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_H6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipH4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipH8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipH10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipH6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_H4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_H10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_B8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipB8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ChipB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_B6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_PChip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_dPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Chip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_DChip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Point, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Chip.ResumeLayout(False)
        CType(Me.pic_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Dice.ResumeLayout(False)
        CType(Me.pic_Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Craps As Casino_Craps_Practice_Edition.ElegantThemeContainer
    Friend WithEvents txt_Money As Casino_Craps_Practice_Edition.ElegantThemeRichTextBox
    Friend WithEvents btn_Home As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents btn_Buy As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents grp_Dice As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Roll As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents btn_Reset As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents pic_Settings As System.Windows.Forms.PictureBox
    Friend WithEvents cbo_Chips As System.Windows.Forms.ComboBox
    Friend WithEvents grp_Chip As System.Windows.Forms.GroupBox
    Friend WithEvents tmr_Check As System.Windows.Forms.Timer
    Friend WithEvents lbl_Status As Casino_Craps_Practice_Edition.ElegantThemeStatusBar
    Friend WithEvents pic_Dice2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Dice1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Point As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Chip As System.Windows.Forms.PictureBox
    Friend WithEvents pic_DChip As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Craps As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Pass As System.Windows.Forms.PictureBox
    Friend WithEvents pic_dPass As System.Windows.Forms.PictureBox
    Friend WithEvents pic_PChip As System.Windows.Forms.PictureBox
    Friend WithEvents pic_B8 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_B6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipB6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipB8 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_H4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_H10 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_H6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_H8 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipH4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipH8 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipH10 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipH6 As System.Windows.Forms.PictureBox
    Friend WithEvents grp_Stats As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Loses As Casino_Craps_Practice_Edition.ElegantThemeLabel
    Friend WithEvents lbl_Wins As Casino_Craps_Practice_Edition.ElegantThemeLabel
    Friend WithEvents lbl_bWon As Casino_Craps_Practice_Edition.ElegantThemeLabel
    Friend WithEvents pic_H12 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipH12 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_SnkEye As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ChipSnkEye As System.Windows.Forms.PictureBox
End Class
