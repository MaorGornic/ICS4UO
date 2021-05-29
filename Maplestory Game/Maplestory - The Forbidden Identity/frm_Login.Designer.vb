<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.tmr_Animation = New System.Windows.Forms.Timer(Me.components)
        Me.thm_Login = New Maplestory___The_Forbidden_Identity.FormSkin()
        Me.btn_Tutorial = New Maplestory___The_Forbidden_Identity.TwitchButton()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.prg_Animation = New System.Windows.Forms.ProgressBar()
        Me.alrt_Login = New Maplestory___The_Forbidden_Identity.FlatAlertBox()
        Me.snd_Intro = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btn_Login = New Maplestory___The_Forbidden_Identity.FlatButton()
        Me.pic_Login = New System.Windows.Forms.PictureBox()
        Me.pic_Background = New System.Windows.Forms.PictureBox()
        Me.btn_Close = New Maplestory___The_Forbidden_Identity.FlatClose()
        Me.btn_Mini = New Maplestory___The_Forbidden_Identity.FlatMini()
        Me.thm_Login.SuspendLayout()
        CType(Me.snd_Intro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_Animation
        '
        Me.tmr_Animation.Interval = 1
        '
        'thm_Login
        '
        Me.thm_Login.BackColor = System.Drawing.Color.White
        Me.thm_Login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.thm_Login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.thm_Login.Controls.Add(Me.btn_Tutorial)
        Me.thm_Login.Controls.Add(Me.txt_Password)
        Me.thm_Login.Controls.Add(Me.txt_ID)
        Me.thm_Login.Controls.Add(Me.prg_Animation)
        Me.thm_Login.Controls.Add(Me.alrt_Login)
        Me.thm_Login.Controls.Add(Me.snd_Intro)
        Me.thm_Login.Controls.Add(Me.btn_Login)
        Me.thm_Login.Controls.Add(Me.pic_Login)
        Me.thm_Login.Controls.Add(Me.pic_Background)
        Me.thm_Login.Controls.Add(Me.btn_Close)
        Me.thm_Login.Controls.Add(Me.btn_Mini)
        Me.thm_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Login.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.thm_Login.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.thm_Login.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.thm_Login.HeaderMaximize = False
        Me.thm_Login.Location = New System.Drawing.Point(0, 0)
        Me.thm_Login.Name = "thm_Login"
        Me.thm_Login.Size = New System.Drawing.Size(622, 440)
        Me.thm_Login.TabIndex = 0
        Me.thm_Login.Text = "Maplestory - The Forbidden Identity"
        '
        'btn_Tutorial
        '
        Me.btn_Tutorial.BackColor = System.Drawing.Color.Transparent
        Me.btn_Tutorial.Colors = New Maplestory___The_Forbidden_Identity.Bloom(-1) {}
        Me.btn_Tutorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Tutorial.Customization = ""
        Me.btn_Tutorial.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Tutorial.Image = Nothing
        Me.btn_Tutorial.Location = New System.Drawing.Point(163, 269)
        Me.btn_Tutorial.Name = "btn_Tutorial"
        Me.btn_Tutorial.NoRounding = False
        Me.btn_Tutorial.Size = New System.Drawing.Size(299, 22)
        Me.btn_Tutorial.TabIndex = 13
        Me.btn_Tutorial.Tag = "purple"
        Me.btn_Tutorial.Text = "Tutorial"
        Me.btn_Tutorial.Transparent = True
        Me.btn_Tutorial.twNoRounding = False
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(163, 234)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(225, 29)
        Me.txt_Password.TabIndex = 12
        Me.txt_Password.Text = "Password"
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(163, 199)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(225, 29)
        Me.txt_ID.TabIndex = 11
        Me.txt_ID.Text = "ID"
        '
        'prg_Animation
        '
        Me.prg_Animation.Location = New System.Drawing.Point(519, 414)
        Me.prg_Animation.Name = "prg_Animation"
        Me.prg_Animation.Size = New System.Drawing.Size(100, 23)
        Me.prg_Animation.TabIndex = 10
        Me.prg_Animation.Visible = False
        '
        'alrt_Login
        '
        Me.alrt_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.alrt_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alrt_Login.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.alrt_Login.kind = Maplestory___The_Forbidden_Identity.FlatAlertBox._Kind.Success
        Me.alrt_Login.Location = New System.Drawing.Point(-135, 315)
        Me.alrt_Login.Name = "alrt_Login"
        Me.alrt_Login.Size = New System.Drawing.Size(186, 42)
        Me.alrt_Login.TabIndex = 9
        Me.alrt_Login.Text = "Login Successful!"
        Me.alrt_Login.Visible = False
        '
        'snd_Intro
        '
        Me.snd_Intro.Enabled = True
        Me.snd_Intro.Location = New System.Drawing.Point(0, 417)
        Me.snd_Intro.Name = "snd_Intro"
        Me.snd_Intro.OcxState = CType(resources.GetObject("snd_Intro.OcxState"), System.Windows.Forms.AxHost.State)
        Me.snd_Intro.Size = New System.Drawing.Size(75, 23)
        Me.snd_Intro.TabIndex = 8
        Me.snd_Intro.Visible = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.btn_Login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Login.Location = New System.Drawing.Point(394, 199)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Rounded = False
        Me.btn_Login.Size = New System.Drawing.Size(68, 64)
        Me.btn_Login.TabIndex = 6
        Me.btn_Login.Text = "Login"
        Me.btn_Login.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pic_Login
        '
        Me.pic_Login.Image = CType(resources.GetObject("pic_Login.Image"), System.Drawing.Image)
        Me.pic_Login.Location = New System.Drawing.Point(153, 157)
        Me.pic_Login.Name = "pic_Login"
        Me.pic_Login.Size = New System.Drawing.Size(316, 151)
        Me.pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Login.TabIndex = 3
        Me.pic_Login.TabStop = False
        '
        'pic_Background
        '
        Me.pic_Background.Image = CType(resources.GetObject("pic_Background.Image"), System.Drawing.Image)
        Me.pic_Background.Location = New System.Drawing.Point(2, 52)
        Me.pic_Background.Name = "pic_Background"
        Me.pic_Background.Size = New System.Drawing.Size(619, 387)
        Me.pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_Background.TabIndex = 2
        Me.pic_Background.TabStop = False
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.White
        Me.btn_Close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btn_Close.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.btn_Close.Location = New System.Drawing.Point(595, 12)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(18, 18)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "btn_Close"
        Me.btn_Close.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_Mini
        '
        Me.btn_Mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mini.BackColor = System.Drawing.Color.White
        Me.btn_Mini.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_Mini.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_Mini.Location = New System.Drawing.Point(571, 12)
        Me.btn_Mini.Name = "btn_Mini"
        Me.btn_Mini.Size = New System.Drawing.Size(18, 18)
        Me.btn_Mini.TabIndex = 0
        Me.btn_Mini.Text = "btn_Minimize"
        Me.btn_Mini.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.thm_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(622, 440)
        Me.MinimumSize = New System.Drawing.Size(622, 440)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Login.ResumeLayout(False)
        Me.thm_Login.PerformLayout()
        CType(Me.snd_Intro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Login As Maplestory___The_Forbidden_Identity.FormSkin
    Friend WithEvents btn_Close As Maplestory___The_Forbidden_Identity.FlatClose
    Friend WithEvents btn_Mini As Maplestory___The_Forbidden_Identity.FlatMini
    Friend WithEvents pic_Background As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Login As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Login As Maplestory___The_Forbidden_Identity.FlatButton
    Friend WithEvents snd_Intro As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents alrt_Login As Maplestory___The_Forbidden_Identity.FlatAlertBox
    Friend WithEvents tmr_Animation As System.Windows.Forms.Timer
    Friend WithEvents prg_Animation As System.Windows.Forms.ProgressBar
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents btn_Tutorial As Maplestory___The_Forbidden_Identity.TwitchButton

End Class
