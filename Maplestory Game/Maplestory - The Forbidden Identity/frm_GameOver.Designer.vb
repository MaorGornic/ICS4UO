<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GameOver))
        Me.thm_GameOver = New Maplestory___The_Forbidden_Identity.FormSkin()
        Me.btn_LogOff = New Maplestory___The_Forbidden_Identity.TwitchBigButton()
        Me.btn_Respawn = New Maplestory___The_Forbidden_Identity.FlatButton()
        Me.pic_GameOver = New System.Windows.Forms.PictureBox()
        Me.thm_GameOver.SuspendLayout()
        CType(Me.pic_GameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_GameOver
        '
        Me.thm_GameOver.BackColor = System.Drawing.Color.White
        Me.thm_GameOver.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.thm_GameOver.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.thm_GameOver.Controls.Add(Me.btn_LogOff)
        Me.thm_GameOver.Controls.Add(Me.btn_Respawn)
        Me.thm_GameOver.Controls.Add(Me.pic_GameOver)
        Me.thm_GameOver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_GameOver.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thm_GameOver.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.thm_GameOver.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.thm_GameOver.HeaderMaximize = False
        Me.thm_GameOver.Location = New System.Drawing.Point(0, 0)
        Me.thm_GameOver.MaximumSize = New System.Drawing.Size(594, 352)
        Me.thm_GameOver.MinimumSize = New System.Drawing.Size(594, 352)
        Me.thm_GameOver.Name = "thm_GameOver"
        Me.thm_GameOver.Size = New System.Drawing.Size(594, 352)
        Me.thm_GameOver.TabIndex = 0
        Me.thm_GameOver.Text = "Game Over"
        '
        'btn_LogOff
        '
        Me.btn_LogOff.BackColor = System.Drawing.Color.Transparent
        Me.btn_LogOff.Colors = New Maplestory___The_Forbidden_Identity.Bloom(-1) {}
        Me.btn_LogOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LogOff.Customization = ""
        Me.btn_LogOff.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btn_LogOff.Image = Nothing
        Me.btn_LogOff.Location = New System.Drawing.Point(321, 288)
        Me.btn_LogOff.Name = "btn_LogOff"
        Me.btn_LogOff.NoRounding = False
        Me.btn_LogOff.Size = New System.Drawing.Size(270, 64)
        Me.btn_LogOff.TabIndex = 20
        Me.btn_LogOff.Tag = "black"
        Me.btn_LogOff.Text = "             Log off"
        Me.btn_LogOff.Transparent = True
        Me.btn_LogOff.twDoesTurnPurple = False
        Me.btn_LogOff.twStarred = False
        Me.btn_LogOff.twTabPage = Nothing
        Me.btn_LogOff.twTabPageNumber = 1
        '
        'btn_Respawn
        '
        Me.btn_Respawn.BackColor = System.Drawing.Color.Transparent
        Me.btn_Respawn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Respawn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Respawn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Respawn.Location = New System.Drawing.Point(0, 288)
        Me.btn_Respawn.Name = "btn_Respawn"
        Me.btn_Respawn.Rounded = False
        Me.btn_Respawn.Size = New System.Drawing.Size(323, 64)
        Me.btn_Respawn.TabIndex = 19
        Me.btn_Respawn.Text = "Respawn"
        Me.btn_Respawn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pic_GameOver
        '
        Me.pic_GameOver.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pic_GameOver.Image = CType(resources.GetObject("pic_GameOver.Image"), System.Drawing.Image)
        Me.pic_GameOver.Location = New System.Drawing.Point(0, 47)
        Me.pic_GameOver.Name = "pic_GameOver"
        Me.pic_GameOver.Size = New System.Drawing.Size(594, 241)
        Me.pic_GameOver.TabIndex = 18
        Me.pic_GameOver.TabStop = False
        '
        'frm_GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 352)
        Me.Controls.Add(Me.thm_GameOver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(594, 352)
        Me.MinimumSize = New System.Drawing.Size(594, 352)
        Me.Name = "frm_GameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_GameOver.ResumeLayout(False)
        CType(Me.pic_GameOver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_GameOver As Maplestory___The_Forbidden_Identity.FormSkin
    Friend WithEvents btn_LogOff As Maplestory___The_Forbidden_Identity.TwitchBigButton
    Friend WithEvents btn_Respawn As Maplestory___The_Forbidden_Identity.FlatButton
    Friend WithEvents pic_GameOver As System.Windows.Forms.PictureBox
End Class
