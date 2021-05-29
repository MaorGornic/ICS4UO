<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MainMenu))
        Me.thm_Main = New Casino_Craps_Practice_Edition.ElegantThemeContainer()
        Me.btn_Instructions = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.btn_Practice = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.btn_Premium = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.btn_Update = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.rdo_No = New Casino_Craps_Practice_Edition.ElegantRadioButton()
        Me.rdo_Yes = New Casino_Craps_Practice_Edition.ElegantRadioButton()
        Me.lbl_Info = New Casino_Craps_Practice_Edition.ElegantThemeLabel()
        Me.spr_Play = New Casino_Craps_Practice_Edition.ElegantThemeSeperator()
        Me.lbl_Name = New Casino_Craps_Practice_Edition.ElegantThemeLabel()
        Me.txt_Name = New Casino_Craps_Practice_Edition.ElegantThemeTextBox()
        Me.spr_Info = New Casino_Craps_Practice_Edition.ElegantThemeSeperator()
        Me.pic_Craps = New System.Windows.Forms.PictureBox()
        Me.thm_Main.SuspendLayout()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_Main
        '
        Me.thm_Main.AllowClose = True
        Me.thm_Main.AllowMaximize = True
        Me.thm_Main.AllowMinimize = True
        Me.thm_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Main.BaseColour = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Main.BorderColour = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.thm_Main.ControlBaseColour = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.thm_Main.ControlBoxButtonSplitColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.thm_Main.ControlBoxColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.thm_Main.Controls.Add(Me.btn_Instructions)
        Me.thm_Main.Controls.Add(Me.btn_Practice)
        Me.thm_Main.Controls.Add(Me.btn_Premium)
        Me.thm_Main.Controls.Add(Me.btn_Update)
        Me.thm_Main.Controls.Add(Me.rdo_No)
        Me.thm_Main.Controls.Add(Me.rdo_Yes)
        Me.thm_Main.Controls.Add(Me.lbl_Info)
        Me.thm_Main.Controls.Add(Me.spr_Play)
        Me.thm_Main.Controls.Add(Me.lbl_Name)
        Me.thm_Main.Controls.Add(Me.txt_Name)
        Me.thm_Main.Controls.Add(Me.spr_Info)
        Me.thm_Main.Controls.Add(Me.pic_Craps)
        Me.thm_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Main.IconColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.thm_Main.Location = New System.Drawing.Point(0, 0)
        Me.thm_Main.Name = "thm_Main"
        Me.thm_Main.Size = New System.Drawing.Size(387, 378)
        Me.thm_Main.TabIndex = 0
        Me.thm_Main.Text = "Casino Craps - Main Menu"
        Me.thm_Main.TopStripBorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.thm_Main.TopStripColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'btn_Instructions
        '
        Me.btn_Instructions.BackColor = System.Drawing.Color.Transparent
        Me.btn_Instructions.BaseColour = System.Drawing.Color.Goldenrod
        Me.btn_Instructions.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Instructions.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Instructions.Location = New System.Drawing.Point(6, 302)
        Me.btn_Instructions.Name = "btn_Instructions"
        Me.btn_Instructions.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Instructions.Size = New System.Drawing.Size(376, 33)
        Me.btn_Instructions.TabIndex = 19
        Me.btn_Instructions.Text = "Instructions"
        Me.btn_Instructions.TextColour = System.Drawing.SystemColors.Info
        '
        'btn_Practice
        '
        Me.btn_Practice.BackColor = System.Drawing.Color.Transparent
        Me.btn_Practice.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Practice.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Practice.Location = New System.Drawing.Point(189, 341)
        Me.btn_Practice.Name = "btn_Practice"
        Me.btn_Practice.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Practice.Size = New System.Drawing.Size(194, 34)
        Me.btn_Practice.TabIndex = 11
        Me.btn_Practice.Text = "Start Practice"
        Me.btn_Practice.TextColour = System.Drawing.Color.DeepSkyBlue
        '
        'btn_Premium
        '
        Me.btn_Premium.BackColor = System.Drawing.Color.Transparent
        Me.btn_Premium.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Premium.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Premium.Location = New System.Drawing.Point(3, 341)
        Me.btn_Premium.Name = "btn_Premium"
        Me.btn_Premium.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Premium.Size = New System.Drawing.Size(180, 34)
        Me.btn_Premium.TabIndex = 10
        Me.btn_Premium.Text = "Download Premium"
        Me.btn_Premium.TextColour = System.Drawing.Color.Firebrick
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Transparent
        Me.btn_Update.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Update.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Update.Location = New System.Drawing.Point(7, 279)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Update.Size = New System.Drawing.Size(180, 17)
        Me.btn_Update.TabIndex = 9
        Me.btn_Update.Text = "Update Information"
        Me.btn_Update.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        'rdo_No
        '
        Me.rdo_No.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdo_No.BorderColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.rdo_No.Checked = False
        Me.rdo_No.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.rdo_No.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdo_No.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.rdo_No.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.rdo_No.Location = New System.Drawing.Point(220, 274)
        Me.rdo_No.Name = "rdo_No"
        Me.rdo_No.Size = New System.Drawing.Size(155, 22)
        Me.rdo_No.TabIndex = 8
        Me.rdo_No.Text = "No"
        '
        'rdo_Yes
        '
        Me.rdo_Yes.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdo_Yes.BorderColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.rdo_Yes.Checked = False
        Me.rdo_Yes.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.rdo_Yes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdo_Yes.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.rdo_Yes.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.rdo_Yes.Location = New System.Drawing.Point(220, 246)
        Me.rdo_Yes.Name = "rdo_Yes"
        Me.rdo_Yes.Size = New System.Drawing.Size(155, 22)
        Me.rdo_Yes.TabIndex = 7
        Me.rdo_Yes.Text = "Yes"
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Info.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lbl_Info.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Info.Location = New System.Drawing.Point(217, 228)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(158, 15)
        Me.lbl_Info.TabIndex = 6
        Me.lbl_Info.Text = "Have you ever played Craps?"
        '
        'spr_Play
        '
        Me.spr_Play.Alignment = Casino_Craps_Practice_Edition.ElegantThemeSeperator.Style.Horizontal
        Me.spr_Play.BackColor = System.Drawing.Color.Transparent
        Me.spr_Play.Location = New System.Drawing.Point(3, 283)
        Me.spr_Play.Name = "spr_Play"
        Me.spr_Play.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.spr_Play.ShowText = True
        Me.spr_Play.Size = New System.Drawing.Size(380, 31)
        Me.spr_Play.TabIndex = 5
        Me.spr_Play.TextColour = System.Drawing.Color.RoyalBlue
        Me.spr_Play.Thickness = 1.0!
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Name.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lbl_Name.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Name.Location = New System.Drawing.Point(3, 228)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "Name"
        '
        'txt_Name
        '
        Me.txt_Name.BackColor = System.Drawing.Color.Transparent
        Me.txt_Name.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Name.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txt_Name.LeftPolygonColour = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txt_Name.LineColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txt_Name.Location = New System.Drawing.Point(6, 246)
        Me.txt_Name.MaxLength = 32767
        Me.txt_Name.Multiline = False
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Picture = Casino_Craps_Practice_Edition.ElegantThemeTextBox.Pictures.Username
        Me.txt_Name.ReadOnly = False
        Me.txt_Name.Size = New System.Drawing.Size(181, 27)
        Me.txt_Name.TabIndex = 3
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Name.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txt_Name.UseSystemPasswordChar = False
        '
        'spr_Info
        '
        Me.spr_Info.Alignment = Casino_Craps_Practice_Edition.ElegantThemeSeperator.Style.Horizontal
        Me.spr_Info.BackColor = System.Drawing.Color.Transparent
        Me.spr_Info.Location = New System.Drawing.Point(3, 202)
        Me.spr_Info.Name = "spr_Info"
        Me.spr_Info.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.spr_Info.ShowText = True
        Me.spr_Info.Size = New System.Drawing.Size(380, 31)
        Me.spr_Info.TabIndex = 2
        Me.spr_Info.Text = "About Me"
        Me.spr_Info.TextColour = System.Drawing.Color.RoyalBlue
        Me.spr_Info.Thickness = 1.0!
        '
        'pic_Craps
        '
        Me.pic_Craps.Image = CType(resources.GetObject("pic_Craps.Image"), System.Drawing.Image)
        Me.pic_Craps.Location = New System.Drawing.Point(3, 37)
        Me.pic_Craps.Name = "pic_Craps"
        Me.pic_Craps.Size = New System.Drawing.Size(380, 159)
        Me.pic_Craps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Craps.TabIndex = 0
        Me.pic_Craps.TabStop = False
        '
        'frm_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 378)
        Me.Controls.Add(Me.thm_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(387, 378)
        Me.MinimumSize = New System.Drawing.Size(387, 378)
        Me.Name = "frm_MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Main.ResumeLayout(False)
        Me.thm_Main.PerformLayout()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Main As Casino_Craps_Practice_Edition.ElegantThemeContainer
    Friend WithEvents pic_Craps As System.Windows.Forms.PictureBox
    Friend WithEvents spr_Play As Casino_Craps_Practice_Edition.ElegantThemeSeperator
    Friend WithEvents lbl_Name As Casino_Craps_Practice_Edition.ElegantThemeLabel
    Friend WithEvents txt_Name As Casino_Craps_Practice_Edition.ElegantThemeTextBox
    Friend WithEvents spr_Info As Casino_Craps_Practice_Edition.ElegantThemeSeperator
    Friend WithEvents btn_Update As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents rdo_No As Casino_Craps_Practice_Edition.ElegantRadioButton
    Friend WithEvents rdo_Yes As Casino_Craps_Practice_Edition.ElegantRadioButton
    Friend WithEvents lbl_Info As Casino_Craps_Practice_Edition.ElegantThemeLabel
    Friend WithEvents btn_Premium As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents btn_Practice As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents btn_Instructions As Casino_Craps_Practice_Edition.ElegantThemeButton

End Class
