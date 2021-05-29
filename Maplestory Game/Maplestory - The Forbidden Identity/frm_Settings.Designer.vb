<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.thm_Settings = New Maplestory___The_Forbidden_Identity.TwitchTheme()
        Me.pic_Close = New System.Windows.Forms.PictureBox()
        Me.grp_Settings = New Maplestory___The_Forbidden_Identity.TwitchCollapseBox()
        Me.grp_Account = New Maplestory___The_Forbidden_Identity.TwitchGroupBox()
        Me.lbl_Name = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Account = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.btn_Reset = New Maplestory___The_Forbidden_Identity.FlatStickyButton()
        Me.pic_LogOff = New System.Windows.Forms.PictureBox()
        Me.grp_Sound = New Maplestory___The_Forbidden_Identity.TwitchGroupBox()
        Me.tgl_Sound = New Maplestory___The_Forbidden_Identity.FlatToggle()
        Me.pic_Sound = New System.Windows.Forms.PictureBox()
        Me.thm_Settings.SuspendLayout()
        CType(Me.pic_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Settings.SuspendLayout()
        Me.grp_Account.SuspendLayout()
        CType(Me.pic_LogOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Sound.SuspendLayout()
        CType(Me.pic_Sound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_Settings
        '
        Me.thm_Settings.BackColor = System.Drawing.Color.White
        Me.thm_Settings.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_Settings.Controls.Add(Me.pic_Close)
        Me.thm_Settings.Controls.Add(Me.grp_Settings)
        Me.thm_Settings.Customization = "AAD//w=="
        Me.thm_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Settings.Fill = True
        Me.thm_Settings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thm_Settings.Image = Nothing
        Me.thm_Settings.Location = New System.Drawing.Point(0, 0)
        Me.thm_Settings.Movable = True
        Me.thm_Settings.Name = "thm_Settings"
        Me.thm_Settings.NoRounding = False
        Me.thm_Settings.Sizable = False
        Me.thm_Settings.Size = New System.Drawing.Size(456, 173)
        Me.thm_Settings.SmartBounds = True
        Me.thm_Settings.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_Settings.TabIndex = 0
        Me.thm_Settings.Text = "Maplestory - The Forbidden Identity"
        Me.thm_Settings.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Settings.Transparent = False
        '
        'pic_Close
        '
        Me.pic_Close.Image = CType(resources.GetObject("pic_Close.Image"), System.Drawing.Image)
        Me.pic_Close.Location = New System.Drawing.Point(430, -1)
        Me.pic_Close.Name = "pic_Close"
        Me.pic_Close.Size = New System.Drawing.Size(26, 26)
        Me.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_Close.TabIndex = 4
        Me.pic_Close.TabStop = False
        '
        'grp_Settings
        '
        Me.grp_Settings.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.grp_Settings.Controls.Add(Me.grp_Account)
        Me.grp_Settings.Controls.Add(Me.grp_Sound)
        Me.grp_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grp_Settings.Customization = "AAD//wAA//8AAP//"
        Me.grp_Settings.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.grp_Settings.Image = Nothing
        Me.grp_Settings.Location = New System.Drawing.Point(3, 29)
        Me.grp_Settings.Movable = True
        Me.grp_Settings.Name = "grp_Settings"
        Me.grp_Settings.NoRounding = False
        Me.grp_Settings.Sizable = True
        Me.grp_Settings.Size = New System.Drawing.Size(450, 144)
        Me.grp_Settings.SmartBounds = True
        Me.grp_Settings.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grp_Settings.TabIndex = 3
        Me.grp_Settings.Text = "Settings"
        Me.grp_Settings.TransparencyKey = System.Drawing.Color.Empty
        Me.grp_Settings.Transparent = False
        Me.grp_Settings.twIsCollapsable = True
        '
        'grp_Account
        '
        Me.grp_Account.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.grp_Account.Colors = New Maplestory___The_Forbidden_Identity.Bloom(-1) {}
        Me.grp_Account.Controls.Add(Me.lbl_Name)
        Me.grp_Account.Controls.Add(Me.lbl_Account)
        Me.grp_Account.Controls.Add(Me.btn_Reset)
        Me.grp_Account.Controls.Add(Me.pic_LogOff)
        Me.grp_Account.Cursor = System.Windows.Forms.Cursors.Default
        Me.grp_Account.Customization = ""
        Me.grp_Account.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.grp_Account.Image = Nothing
        Me.grp_Account.Location = New System.Drawing.Point(178, 31)
        Me.grp_Account.Movable = True
        Me.grp_Account.Name = "grp_Account"
        Me.grp_Account.NoRounding = False
        Me.grp_Account.Sizable = True
        Me.grp_Account.Size = New System.Drawing.Size(269, 110)
        Me.grp_Account.SmartBounds = True
        Me.grp_Account.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grp_Account.TabIndex = 1
        Me.grp_Account.Text = "Account Settings"
        Me.grp_Account.TransparencyKey = System.Drawing.Color.Empty
        Me.grp_Account.Transparent = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_Name.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_Name.Location = New System.Drawing.Point(140, 85)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Name.TabIndex = 5
        Me.lbl_Name.Text = "Abwatts"
        '
        'lbl_Account
        '
        Me.lbl_Account.AutoSize = True
        Me.lbl_Account.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Account.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_Account.ForeColor = System.Drawing.Color.White
        Me.lbl_Account.Location = New System.Drawing.Point(91, 85)
        Me.lbl_Account.Name = "lbl_Account"
        Me.lbl_Account.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Account.TabIndex = 4
        Me.lbl_Account.Text = "Account:"
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_Reset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Reset.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Reset.Location = New System.Drawing.Point(94, 37)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Rounded = False
        Me.btn_Reset.Size = New System.Drawing.Size(162, 45)
        Me.btn_Reset.TabIndex = 3
        Me.btn_Reset.Text = "Reset Account"
        Me.btn_Reset.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pic_LogOff
        '
        Me.pic_LogOff.BackColor = System.Drawing.Color.Transparent
        Me.pic_LogOff.Image = CType(resources.GetObject("pic_LogOff.Image"), System.Drawing.Image)
        Me.pic_LogOff.Location = New System.Drawing.Point(14, 37)
        Me.pic_LogOff.Name = "pic_LogOff"
        Me.pic_LogOff.Size = New System.Drawing.Size(64, 57)
        Me.pic_LogOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_LogOff.TabIndex = 2
        Me.pic_LogOff.TabStop = False
        '
        'grp_Sound
        '
        Me.grp_Sound.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.grp_Sound.Colors = New Maplestory___The_Forbidden_Identity.Bloom(-1) {}
        Me.grp_Sound.Controls.Add(Me.tgl_Sound)
        Me.grp_Sound.Controls.Add(Me.pic_Sound)
        Me.grp_Sound.Cursor = System.Windows.Forms.Cursors.Default
        Me.grp_Sound.Customization = ""
        Me.grp_Sound.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.grp_Sound.Image = Nothing
        Me.grp_Sound.Location = New System.Drawing.Point(3, 31)
        Me.grp_Sound.Movable = True
        Me.grp_Sound.Name = "grp_Sound"
        Me.grp_Sound.NoRounding = False
        Me.grp_Sound.Sizable = True
        Me.grp_Sound.Size = New System.Drawing.Size(169, 110)
        Me.grp_Sound.SmartBounds = True
        Me.grp_Sound.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grp_Sound.TabIndex = 0
        Me.grp_Sound.Text = "Sound Settings"
        Me.grp_Sound.TransparencyKey = System.Drawing.Color.Empty
        Me.grp_Sound.Transparent = False
        '
        'tgl_Sound
        '
        Me.tgl_Sound.BackColor = System.Drawing.Color.Transparent
        Me.tgl_Sound.Checked = True
        Me.tgl_Sound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tgl_Sound.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tgl_Sound.Location = New System.Drawing.Point(76, 49)
        Me.tgl_Sound.Name = "tgl_Sound"
        Me.tgl_Sound.Options = Maplestory___The_Forbidden_Identity.FlatToggle._Options.Style1
        Me.tgl_Sound.Size = New System.Drawing.Size(76, 33)
        Me.tgl_Sound.TabIndex = 1
        Me.tgl_Sound.Text = "FlatToggle1"
        '
        'pic_Sound
        '
        Me.pic_Sound.BackColor = System.Drawing.Color.Transparent
        Me.pic_Sound.Image = CType(resources.GetObject("pic_Sound.Image"), System.Drawing.Image)
        Me.pic_Sound.Location = New System.Drawing.Point(6, 37)
        Me.pic_Sound.Name = "pic_Sound"
        Me.pic_Sound.Size = New System.Drawing.Size(64, 57)
        Me.pic_Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Sound.TabIndex = 0
        Me.pic_Sound.TabStop = False
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 173)
        Me.Controls.Add(Me.thm_Settings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maplestory - The Forbidden Identity"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Settings.ResumeLayout(False)
        Me.thm_Settings.PerformLayout()
        CType(Me.pic_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Account.ResumeLayout(False)
        Me.grp_Account.PerformLayout()
        CType(Me.pic_LogOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Sound.ResumeLayout(False)
        CType(Me.pic_Sound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Settings As Maplestory___The_Forbidden_Identity.TwitchTheme
    Friend WithEvents grp_Sound As Maplestory___The_Forbidden_Identity.TwitchGroupBox
    Friend WithEvents grp_Account As Maplestory___The_Forbidden_Identity.TwitchGroupBox
    Friend WithEvents grp_Settings As Maplestory___The_Forbidden_Identity.TwitchCollapseBox
    Friend WithEvents pic_Sound As System.Windows.Forms.PictureBox
    Friend WithEvents tgl_Sound As Maplestory___The_Forbidden_Identity.FlatToggle
    Friend WithEvents pic_Close As System.Windows.Forms.PictureBox
    Friend WithEvents pic_LogOff As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Reset As Maplestory___The_Forbidden_Identity.FlatStickyButton
    Friend WithEvents lbl_Name As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Account As Maplestory___The_Forbidden_Identity.FlatLabel
End Class
