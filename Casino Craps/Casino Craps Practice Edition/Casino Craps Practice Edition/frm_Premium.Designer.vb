<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Premium
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Premium))
        Me.thm_Premium = New Casino_Craps_Practice_Edition.ElegantThemeContainer()
        Me.btn_nGame = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.grp_Description = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_getNow = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.pic_Craps = New System.Windows.Forms.PictureBox()
        Me.thm_Premium.SuspendLayout()
        Me.grp_Description.SuspendLayout()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_Premium
        '
        Me.thm_Premium.AllowClose = True
        Me.thm_Premium.AllowMaximize = True
        Me.thm_Premium.AllowMinimize = True
        Me.thm_Premium.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Premium.BaseColour = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Premium.BorderColour = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.thm_Premium.ControlBaseColour = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.thm_Premium.ControlBoxButtonSplitColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.thm_Premium.ControlBoxColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.thm_Premium.Controls.Add(Me.btn_nGame)
        Me.thm_Premium.Controls.Add(Me.grp_Description)
        Me.thm_Premium.Controls.Add(Me.btn_getNow)
        Me.thm_Premium.Controls.Add(Me.pic_Craps)
        Me.thm_Premium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Premium.IconColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.thm_Premium.Location = New System.Drawing.Point(0, 0)
        Me.thm_Premium.MaximumSize = New System.Drawing.Size(377, 363)
        Me.thm_Premium.MinimumSize = New System.Drawing.Size(377, 363)
        Me.thm_Premium.Name = "thm_Premium"
        Me.thm_Premium.Size = New System.Drawing.Size(377, 363)
        Me.thm_Premium.TabIndex = 0
        Me.thm_Premium.Text = "Casino Craps Practice Edition 2018"
        Me.thm_Premium.TopStripBorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.thm_Premium.TopStripColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'btn_nGame
        '
        Me.btn_nGame.BackColor = System.Drawing.Color.Transparent
        Me.btn_nGame.BaseColour = System.Drawing.Color.Green
        Me.btn_nGame.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_nGame.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_nGame.Location = New System.Drawing.Point(82, 282)
        Me.btn_nGame.Name = "btn_nGame"
        Me.btn_nGame.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_nGame.Size = New System.Drawing.Size(73, 77)
        Me.btn_nGame.TabIndex = 25
        Me.btn_nGame.Text = "New Game"
        Me.btn_nGame.TextColour = System.Drawing.SystemColors.Info
        '
        'grp_Description
        '
        Me.grp_Description.BackColor = System.Drawing.Color.Transparent
        Me.grp_Description.Controls.Add(Me.TextBox1)
        Me.grp_Description.ForeColor = System.Drawing.Color.Red
        Me.grp_Description.Location = New System.Drawing.Point(155, 283)
        Me.grp_Description.Name = "grp_Description"
        Me.grp_Description.Size = New System.Drawing.Size(219, 76)
        Me.grp_Description.TabIndex = 24
        Me.grp_Description.TabStop = False
        Me.grp_Description.Tag = ""
        Me.grp_Description.Text = "About Us"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 49)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "SuperCasino is the longest-running and most popular online TV casino. SuperCasino" & _
    " is a safe place to play."
        '
        'btn_getNow
        '
        Me.btn_getNow.BackColor = System.Drawing.Color.Transparent
        Me.btn_getNow.BaseColour = System.Drawing.Color.Red
        Me.btn_getNow.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_getNow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_getNow.Location = New System.Drawing.Point(5, 282)
        Me.btn_getNow.Name = "btn_getNow"
        Me.btn_getNow.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_getNow.Size = New System.Drawing.Size(73, 77)
        Me.btn_getNow.TabIndex = 19
        Me.btn_getNow.Text = "Get it now"
        Me.btn_getNow.TextColour = System.Drawing.SystemColors.Info
        '
        'pic_Craps
        '
        Me.pic_Craps.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pic_Craps.Image = CType(resources.GetObject("pic_Craps.Image"), System.Drawing.Image)
        Me.pic_Craps.Location = New System.Drawing.Point(3, 39)
        Me.pic_Craps.Name = "pic_Craps"
        Me.pic_Craps.Size = New System.Drawing.Size(372, 238)
        Me.pic_Craps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Craps.TabIndex = 1
        Me.pic_Craps.TabStop = False
        '
        'frm_Premium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 363)
        Me.Controls.Add(Me.thm_Premium)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(377, 363)
        Me.MinimumSize = New System.Drawing.Size(377, 363)
        Me.Name = "frm_Premium"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Premium"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Premium.ResumeLayout(False)
        Me.grp_Description.ResumeLayout(False)
        Me.grp_Description.PerformLayout()
        CType(Me.pic_Craps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Premium As Casino_Craps_Practice_Edition.ElegantThemeContainer
    Friend WithEvents pic_Craps As System.Windows.Forms.PictureBox
    Friend WithEvents btn_getNow As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents grp_Description As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_nGame As Casino_Craps_Practice_Edition.ElegantThemeButton
End Class
