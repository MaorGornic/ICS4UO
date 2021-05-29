<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HvH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HvH))
        Me.tmr_Rate = New System.Windows.Forms.Timer(Me.components)
        Me.thm_HvH = New Hi___Low_Guessing_Game.SLCTheme()
        Me.pic_Back = New System.Windows.Forms.PictureBox()
        Me.btn_Reset = New Hi___Low_Guessing_Game.SLCbtn()
        Me.SlcLabel2 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lst_Tries = New System.Windows.Forms.ListBox()
        Me.txt_Tries = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.lbl_Tries = New Hi___Low_Guessing_Game.SLCLabel()
        Me.grp_Start = New Hi___Low_Guessing_Game.SLCGroupBox()
        Me.lbl_Answer = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Answer = New Hi___Low_Guessing_Game.SLCbtn()
        Me.txt_Answer = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.lbl_Num = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Num = New Hi___Low_Guessing_Game.SLCbtn()
        Me.txt_Num = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.SlcLabel1 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.thm_HvH.SuspendLayout()
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Start.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmr_Rate
        '
        '
        'thm_HvH
        '
        Me.thm_HvH.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.thm_HvH.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_HvH.Controls.Add(Me.pic_Back)
        Me.thm_HvH.Controls.Add(Me.btn_Reset)
        Me.thm_HvH.Controls.Add(Me.SlcLabel2)
        Me.thm_HvH.Controls.Add(Me.lst_Tries)
        Me.thm_HvH.Controls.Add(Me.txt_Tries)
        Me.thm_HvH.Controls.Add(Me.lbl_Tries)
        Me.thm_HvH.Controls.Add(Me.grp_Start)
        Me.thm_HvH.Controls.Add(Me.SlcLabel1)
        Me.thm_HvH.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.thm_HvH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_HvH.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.thm_HvH.Image = Nothing
        Me.thm_HvH.Location = New System.Drawing.Point(0, 0)
        Me.thm_HvH.Movable = True
        Me.thm_HvH.Name = "thm_HvH"
        Me.thm_HvH.NoRounding = False
        Me.thm_HvH.Sizable = True
        Me.thm_HvH.Size = New System.Drawing.Size(594, 277)
        Me.thm_HvH.SmartBounds = True
        Me.thm_HvH.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_HvH.TabIndex = 0
        Me.thm_HvH.Text = "Human Vs. Human"
        Me.thm_HvH.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_HvH.Transparent = False
        '
        'pic_Back
        '
        Me.pic_Back.BackColor = System.Drawing.Color.Transparent
        Me.pic_Back.Image = CType(resources.GetObject("pic_Back.Image"), System.Drawing.Image)
        Me.pic_Back.Location = New System.Drawing.Point(515, 225)
        Me.pic_Back.Name = "pic_Back"
        Me.pic_Back.Size = New System.Drawing.Size(67, 49)
        Me.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Back.TabIndex = 8
        Me.pic_Back.TabStop = False
        '
        'btn_Reset
        '
        Me.btn_Reset.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Reset.Customization = ""
        Me.btn_Reset.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Reset.Image = Nothing
        Me.btn_Reset.Location = New System.Drawing.Point(8, 258)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.NoRounding = False
        Me.btn_Reset.Size = New System.Drawing.Size(94, 16)
        Me.btn_Reset.TabIndex = 6
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.Transparent = False
        '
        'SlcLabel2
        '
        Me.SlcLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcLabel2.Location = New System.Drawing.Point(299, 104)
        Me.SlcLabel2.Name = "SlcLabel2"
        Me.SlcLabel2.Size = New System.Drawing.Size(103, 17)
        Me.SlcLabel2.TabIndex = 6
        Me.SlcLabel2.Text = "Results"
        '
        'lst_Tries
        '
        Me.lst_Tries.FormattingEnabled = True
        Me.lst_Tries.Location = New System.Drawing.Point(299, 127)
        Me.lst_Tries.Name = "lst_Tries"
        Me.lst_Tries.Size = New System.Drawing.Size(161, 121)
        Me.lst_Tries.TabIndex = 5
        '
        'txt_Tries
        '
        Me.txt_Tries.Enabled = False
        Me.txt_Tries.Location = New System.Drawing.Point(486, 123)
        Me.txt_Tries.MaxLength = 32767
        Me.txt_Tries.Multiline = False
        Me.txt_Tries.Name = "txt_Tries"
        Me.txt_Tries.ReadOnly = False
        Me.txt_Tries.Size = New System.Drawing.Size(65, 24)
        Me.txt_Tries.TabIndex = 4
        Me.txt_Tries.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Tries.UseSystemPasswordChar = False
        '
        'lbl_Tries
        '
        Me.lbl_Tries.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Tries.Location = New System.Drawing.Point(469, 104)
        Me.lbl_Tries.Name = "lbl_Tries"
        Me.lbl_Tries.Size = New System.Drawing.Size(103, 17)
        Me.lbl_Tries.TabIndex = 3
        Me.lbl_Tries.Text = "Number of tries:"
        '
        'grp_Start
        '
        Me.grp_Start.Controls.Add(Me.lbl_Answer)
        Me.grp_Start.Controls.Add(Me.btn_Answer)
        Me.grp_Start.Controls.Add(Me.txt_Answer)
        Me.grp_Start.Controls.Add(Me.lbl_Num)
        Me.grp_Start.Controls.Add(Me.btn_Num)
        Me.grp_Start.Controls.Add(Me.txt_Num)
        Me.grp_Start.DrawSeperator = False
        Me.grp_Start.Location = New System.Drawing.Point(8, 102)
        Me.grp_Start.Name = "grp_Start"
        Me.grp_Start.Size = New System.Drawing.Size(283, 155)
        Me.grp_Start.SubTitle = ""
        Me.grp_Start.TabIndex = 1
        Me.grp_Start.Text = "SlcGroupBox1"
        Me.grp_Start.Title = "Let`s begin"
        '
        'lbl_Answer
        '
        Me.lbl_Answer.BackColor = System.Drawing.Color.Red
        Me.lbl_Answer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Answer.ForeColor = System.Drawing.Color.Red
        Me.lbl_Answer.Location = New System.Drawing.Point(15, 88)
        Me.lbl_Answer.Name = "lbl_Answer"
        Me.lbl_Answer.Size = New System.Drawing.Size(139, 19)
        Me.lbl_Answer.TabIndex = 5
        Me.lbl_Answer.Text = "Enter your guess below"
        '
        'btn_Answer
        '
        Me.btn_Answer.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Answer.Customization = ""
        Me.btn_Answer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Answer.Image = Nothing
        Me.btn_Answer.Location = New System.Drawing.Point(213, 99)
        Me.btn_Answer.Name = "btn_Answer"
        Me.btn_Answer.NoRounding = False
        Me.btn_Answer.Size = New System.Drawing.Size(62, 40)
        Me.btn_Answer.TabIndex = 4
        Me.btn_Answer.Text = "Guess"
        Me.btn_Answer.Transparent = False
        '
        'txt_Answer
        '
        Me.txt_Answer.Location = New System.Drawing.Point(15, 106)
        Me.txt_Answer.MaxLength = 32767
        Me.txt_Answer.Multiline = False
        Me.txt_Answer.Name = "txt_Answer"
        Me.txt_Answer.ReadOnly = False
        Me.txt_Answer.Size = New System.Drawing.Size(188, 24)
        Me.txt_Answer.TabIndex = 3
        Me.txt_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Answer.UseSystemPasswordChar = False
        '
        'lbl_Num
        '
        Me.lbl_Num.BackColor = System.Drawing.Color.Red
        Me.lbl_Num.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Num.ForeColor = System.Drawing.Color.Red
        Me.lbl_Num.Location = New System.Drawing.Point(15, 33)
        Me.lbl_Num.Name = "lbl_Num"
        Me.lbl_Num.Size = New System.Drawing.Size(128, 12)
        Me.lbl_Num.TabIndex = 2
        Me.lbl_Num.Text = "Enter number below"
        '
        'btn_Num
        '
        Me.btn_Num.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Num.Customization = ""
        Me.btn_Num.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Num.Image = Nothing
        Me.btn_Num.Location = New System.Drawing.Point(213, 44)
        Me.btn_Num.Name = "btn_Num"
        Me.btn_Num.NoRounding = False
        Me.btn_Num.Size = New System.Drawing.Size(62, 40)
        Me.btn_Num.TabIndex = 1
        Me.btn_Num.Text = "Lock"
        Me.btn_Num.Transparent = False
        '
        'txt_Num
        '
        Me.txt_Num.Location = New System.Drawing.Point(15, 51)
        Me.txt_Num.MaxLength = 32767
        Me.txt_Num.Multiline = False
        Me.txt_Num.Name = "txt_Num"
        Me.txt_Num.ReadOnly = False
        Me.txt_Num.Size = New System.Drawing.Size(188, 24)
        Me.txt_Num.TabIndex = 0
        Me.txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Num.UseSystemPasswordChar = False
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcLabel1.Location = New System.Drawing.Point(23, 60)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(535, 36)
        Me.SlcLabel1.TabIndex = 0
        Me.SlcLabel1.Text = "Guess What (Human Vs. Human 1-100)"
        '
        'frm_HvH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 277)
        Me.Controls.Add(Me.thm_HvH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_HvH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_HvH"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_HvH.ResumeLayout(False)
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Start.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_HvH As Hi___Low_Guessing_Game.SLCTheme
    Friend WithEvents txt_Tries As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents lbl_Tries As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents grp_Start As Hi___Low_Guessing_Game.SLCGroupBox
    Friend WithEvents btn_Answer As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents txt_Answer As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents lbl_Num As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents btn_Num As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents txt_Num As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents SlcLabel1 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lbl_Answer As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents SlcLabel2 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lst_Tries As System.Windows.Forms.ListBox
    Friend WithEvents btn_Reset As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents tmr_Rate As System.Windows.Forms.Timer
    Friend WithEvents pic_Back As System.Windows.Forms.PictureBox
End Class
