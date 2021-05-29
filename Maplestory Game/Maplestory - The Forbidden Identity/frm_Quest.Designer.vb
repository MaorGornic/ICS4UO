<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Quest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Quest))
        Me.thm_Quest = New Maplestory___The_Forbidden_Identity.TwitchTheme()
        Me.btn_CtrlBox = New Maplestory___The_Forbidden_Identity.RedemptionControlBox()
        Me.grp_Quest = New Maplestory___The_Forbidden_Identity.TwitchCollapseBox()
        Me.lbl_NPC = New Maplestory___The_Forbidden_Identity.TwitchLabel()
        Me.lbl_InfoKill = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Kills = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Info3 = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Info2 = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Info = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.pic_NPC = New System.Windows.Forms.PictureBox()
        Me.btn_Forfeit = New Maplestory___The_Forbidden_Identity.FlatStickyButton()
        Me.thm_Quest.SuspendLayout()
        Me.grp_Quest.SuspendLayout()
        CType(Me.pic_NPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_Quest
        '
        Me.thm_Quest.BackColor = System.Drawing.Color.White
        Me.thm_Quest.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_Quest.Controls.Add(Me.btn_CtrlBox)
        Me.thm_Quest.Controls.Add(Me.grp_Quest)
        Me.thm_Quest.Customization = "AAD//w=="
        Me.thm_Quest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Quest.Fill = True
        Me.thm_Quest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thm_Quest.Image = Nothing
        Me.thm_Quest.Location = New System.Drawing.Point(0, 0)
        Me.thm_Quest.Movable = False
        Me.thm_Quest.Name = "thm_Quest"
        Me.thm_Quest.NoRounding = False
        Me.thm_Quest.Sizable = False
        Me.thm_Quest.Size = New System.Drawing.Size(284, 246)
        Me.thm_Quest.SmartBounds = True
        Me.thm_Quest.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_Quest.TabIndex = 0
        Me.thm_Quest.Text = "Quest Statistics"
        Me.thm_Quest.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Quest.Transparent = False
        '
        'btn_CtrlBox
        '
        Me.btn_CtrlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CtrlBox.BackColor = System.Drawing.Color.Transparent
        Me.btn_CtrlBox.ForeColor = System.Drawing.Color.White
        Me.btn_CtrlBox.Location = New System.Drawing.Point(221, 0)
        Me.btn_CtrlBox.Name = "btn_CtrlBox"
        Me.btn_CtrlBox.Size = New System.Drawing.Size(60, 25)
        Me.btn_CtrlBox.TabIndex = 73
        '
        'grp_Quest
        '
        Me.grp_Quest.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.grp_Quest.Controls.Add(Me.lbl_NPC)
        Me.grp_Quest.Controls.Add(Me.lbl_InfoKill)
        Me.grp_Quest.Controls.Add(Me.lbl_Kills)
        Me.grp_Quest.Controls.Add(Me.lbl_Info3)
        Me.grp_Quest.Controls.Add(Me.lbl_Info2)
        Me.grp_Quest.Controls.Add(Me.lbl_Info)
        Me.grp_Quest.Controls.Add(Me.pic_NPC)
        Me.grp_Quest.Controls.Add(Me.btn_Forfeit)
        Me.grp_Quest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grp_Quest.Customization = "AAD//wAA//8AAP//"
        Me.grp_Quest.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.grp_Quest.Image = Nothing
        Me.grp_Quest.Location = New System.Drawing.Point(3, 28)
        Me.grp_Quest.Movable = True
        Me.grp_Quest.Name = "grp_Quest"
        Me.grp_Quest.NoRounding = False
        Me.grp_Quest.Sizable = True
        Me.grp_Quest.Size = New System.Drawing.Size(278, 221)
        Me.grp_Quest.SmartBounds = True
        Me.grp_Quest.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grp_Quest.TabIndex = 0
        Me.grp_Quest.Text = "Info"
        Me.grp_Quest.TransparencyKey = System.Drawing.Color.Empty
        Me.grp_Quest.Transparent = False
        Me.grp_Quest.twIsCollapsable = True
        '
        'lbl_NPC
        '
        Me.lbl_NPC.AutoSize = True
        Me.lbl_NPC.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NPC.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_NPC.ForeColor = System.Drawing.Color.White
        Me.lbl_NPC.Location = New System.Drawing.Point(3, 129)
        Me.lbl_NPC.Name = "lbl_NPC"
        Me.lbl_NPC.Size = New System.Drawing.Size(41, 21)
        Me.lbl_NPC.TabIndex = 48
        Me.lbl_NPC.Text = "Reef"
        '
        'lbl_InfoKill
        '
        Me.lbl_InfoKill.AutoSize = True
        Me.lbl_InfoKill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_InfoKill.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_InfoKill.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_InfoKill.Location = New System.Drawing.Point(119, 123)
        Me.lbl_InfoKill.Name = "lbl_InfoKill"
        Me.lbl_InfoKill.Size = New System.Drawing.Size(159, 28)
        Me.lbl_InfoKill.TabIndex = 72
        Me.lbl_InfoKill.Text = "have been killed!"
        '
        'lbl_Kills
        '
        Me.lbl_Kills.AutoSize = True
        Me.lbl_Kills.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Kills.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_Kills.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Kills.Location = New System.Drawing.Point(170, 97)
        Me.lbl_Kills.Name = "lbl_Kills"
        Me.lbl_Kills.Size = New System.Drawing.Size(42, 28)
        Me.lbl_Kills.TabIndex = 71
        Me.lbl_Kills.Text = "0/0"
        '
        'lbl_Info3
        '
        Me.lbl_Info3.AutoSize = True
        Me.lbl_Info3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_Info3.ForeColor = System.Drawing.Color.White
        Me.lbl_Info3.Location = New System.Drawing.Point(125, 66)
        Me.lbl_Info3.Name = "lbl_Info3"
        Me.lbl_Info3.Size = New System.Drawing.Size(139, 19)
        Me.lbl_Info3.TabIndex = 70
        Me.lbl_Info3.Text = " a threat to our lord""."
        '
        'lbl_Info2
        '
        Me.lbl_Info2.AutoSize = True
        Me.lbl_Info2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_Info2.ForeColor = System.Drawing.Color.White
        Me.lbl_Info2.Location = New System.Drawing.Point(125, 47)
        Me.lbl_Info2.Name = "lbl_Info2"
        Me.lbl_Info2.Size = New System.Drawing.Size(157, 19)
        Me.lbl_Info2.TabIndex = 69
        Me.lbl_Info2.Text = "the monsters who pose "
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_Info.ForeColor = System.Drawing.Color.White
        Me.lbl_Info.Location = New System.Drawing.Point(125, 28)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(143, 19)
        Me.lbl_Info.TabIndex = 68
        Me.lbl_Info.Text = """Your task is to kill all "
        '
        'pic_NPC
        '
        Me.pic_NPC.BackColor = System.Drawing.Color.Transparent
        Me.pic_NPC.Image = CType(resources.GetObject("pic_NPC.Image"), System.Drawing.Image)
        Me.pic_NPC.Location = New System.Drawing.Point(0, 28)
        Me.pic_NPC.Name = "pic_NPC"
        Me.pic_NPC.Size = New System.Drawing.Size(119, 123)
        Me.pic_NPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_NPC.TabIndex = 67
        Me.pic_NPC.TabStop = False
        '
        'btn_Forfeit
        '
        Me.btn_Forfeit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Forfeit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Forfeit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Forfeit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Forfeit.Location = New System.Drawing.Point(7, 176)
        Me.btn_Forfeit.MaximumSize = New System.Drawing.Size(262, 32)
        Me.btn_Forfeit.MinimumSize = New System.Drawing.Size(262, 32)
        Me.btn_Forfeit.Name = "btn_Forfeit"
        Me.btn_Forfeit.Rounded = False
        Me.btn_Forfeit.Size = New System.Drawing.Size(262, 32)
        Me.btn_Forfeit.TabIndex = 1
        Me.btn_Forfeit.Text = "Forfeit"
        Me.btn_Forfeit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frm_Quest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 246)
        Me.Controls.Add(Me.thm_Quest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Quest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Quest"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Quest.ResumeLayout(False)
        Me.grp_Quest.ResumeLayout(False)
        Me.grp_Quest.PerformLayout()
        CType(Me.pic_NPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Quest As Maplestory___The_Forbidden_Identity.TwitchTheme
    Friend WithEvents grp_Quest As Maplestory___The_Forbidden_Identity.TwitchCollapseBox
    Friend WithEvents btn_Forfeit As Maplestory___The_Forbidden_Identity.FlatStickyButton
    Friend WithEvents pic_NPC As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Info3 As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Info2 As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Info As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Kills As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_InfoKill As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_NPC As Maplestory___The_Forbidden_Identity.TwitchLabel
    Friend WithEvents btn_CtrlBox As Maplestory___The_Forbidden_Identity.RedemptionControlBox
End Class
