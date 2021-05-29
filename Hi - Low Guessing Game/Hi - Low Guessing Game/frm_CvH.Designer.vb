<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CvH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CvH))
        Me.btn_Reset = New Hi___Low_Guessing_Game.SLCbtn()
        Me.btn_Num = New Hi___Low_Guessing_Game.SLCbtn()
        Me.btn_Guess = New Hi___Low_Guessing_Game.SLCbtn()
        Me.grp_Start = New Hi___Low_Guessing_Game.SLCGroupBox()
        Me.pic_Confirm = New System.Windows.Forms.PictureBox()
        Me.lbl_Num = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lbl_Answer = New Hi___Low_Guessing_Game.SLCLabel()
        Me.txt_Guess = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.SlcLabel2 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lst_Tries = New System.Windows.Forms.ListBox()
        Me.txt_Tries = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.lbl_Tries = New Hi___Low_Guessing_Game.SLCLabel()
        Me.SlcLabel1 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.thm_CvH = New Hi___Low_Guessing_Game.SLCTheme()
        Me.pic_Back = New System.Windows.Forms.PictureBox()
        Me.grp_Start.SuspendLayout()
        CType(Me.pic_Confirm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thm_CvH.SuspendLayout()
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Reset
        '
        Me.btn_Reset.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Reset.Customization = ""
        Me.btn_Reset.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Reset.Image = Nothing
        Me.btn_Reset.Location = New System.Drawing.Point(9, 280)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.NoRounding = False
        Me.btn_Reset.Size = New System.Drawing.Size(94, 16)
        Me.btn_Reset.TabIndex = 13
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.Transparent = False
        '
        'btn_Num
        '
        Me.btn_Num.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Num.Customization = ""
        Me.btn_Num.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Num.Image = Nothing
        Me.btn_Num.Location = New System.Drawing.Point(92, 111)
        Me.btn_Num.Name = "btn_Num"
        Me.btn_Num.NoRounding = False
        Me.btn_Num.Size = New System.Drawing.Size(71, 25)
        Me.btn_Num.TabIndex = 6
        Me.btn_Num.Text = "Let's Play!"
        Me.btn_Num.Transparent = False
        '
        'btn_Guess
        '
        Me.btn_Guess.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Guess.Customization = ""
        Me.btn_Guess.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Guess.Image = Nothing
        Me.btn_Guess.Location = New System.Drawing.Point(213, 45)
        Me.btn_Guess.Name = "btn_Guess"
        Me.btn_Guess.NoRounding = False
        Me.btn_Guess.Size = New System.Drawing.Size(62, 40)
        Me.btn_Guess.TabIndex = 4
        Me.btn_Guess.Text = "Set"
        Me.btn_Guess.Transparent = False
        '
        'grp_Start
        '
        Me.grp_Start.Controls.Add(Me.pic_Confirm)
        Me.grp_Start.Controls.Add(Me.lbl_Num)
        Me.grp_Start.Controls.Add(Me.btn_Num)
        Me.grp_Start.Controls.Add(Me.lbl_Answer)
        Me.grp_Start.Controls.Add(Me.txt_Guess)
        Me.grp_Start.Controls.Add(Me.btn_Guess)
        Me.grp_Start.DrawSeperator = False
        Me.grp_Start.Location = New System.Drawing.Point(9, 106)
        Me.grp_Start.Name = "grp_Start"
        Me.grp_Start.Size = New System.Drawing.Size(283, 155)
        Me.grp_Start.SubTitle = ""
        Me.grp_Start.TabIndex = 9
        Me.grp_Start.Text = "SlcGroupBox1"
        Me.grp_Start.Title = "Let`s begin"
        '
        'pic_Confirm
        '
        Me.pic_Confirm.BackColor = System.Drawing.Color.Transparent
        Me.pic_Confirm.Image = CType(resources.GetObject("pic_Confirm.Image"), System.Drawing.Image)
        Me.pic_Confirm.Location = New System.Drawing.Point(169, 111)
        Me.pic_Confirm.Name = "pic_Confirm"
        Me.pic_Confirm.Size = New System.Drawing.Size(22, 25)
        Me.pic_Confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Confirm.TabIndex = 8
        Me.pic_Confirm.TabStop = False
        Me.pic_Confirm.Visible = False
        '
        'lbl_Num
        '
        Me.lbl_Num.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Num.Location = New System.Drawing.Point(15, 94)
        Me.lbl_Num.Name = "lbl_Num"
        Me.lbl_Num.Size = New System.Drawing.Size(260, 14)
        Me.lbl_Num.TabIndex = 7
        Me.lbl_Num.Text = "Click on the button to let the computer guess"
        '
        'lbl_Answer
        '
        Me.lbl_Answer.BackColor = System.Drawing.Color.Red
        Me.lbl_Answer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Answer.ForeColor = System.Drawing.Color.Red
        Me.lbl_Answer.Location = New System.Drawing.Point(15, 34)
        Me.lbl_Answer.Name = "lbl_Answer"
        Me.lbl_Answer.Size = New System.Drawing.Size(128, 18)
        Me.lbl_Answer.TabIndex = 5
        Me.lbl_Answer.Text = "Enter number below"
        '
        'txt_Guess
        '
        Me.txt_Guess.Location = New System.Drawing.Point(15, 52)
        Me.txt_Guess.MaxLength = 32767
        Me.txt_Guess.Multiline = False
        Me.txt_Guess.Name = "txt_Guess"
        Me.txt_Guess.ReadOnly = False
        Me.txt_Guess.Size = New System.Drawing.Size(188, 24)
        Me.txt_Guess.TabIndex = 3
        Me.txt_Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Guess.UseSystemPasswordChar = False
        '
        'SlcLabel2
        '
        Me.SlcLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcLabel2.Location = New System.Drawing.Point(298, 108)
        Me.SlcLabel2.Name = "SlcLabel2"
        Me.SlcLabel2.Size = New System.Drawing.Size(103, 17)
        Me.SlcLabel2.TabIndex = 14
        Me.SlcLabel2.Text = "Results"
        '
        'lst_Tries
        '
        Me.lst_Tries.FormattingEnabled = True
        Me.lst_Tries.Location = New System.Drawing.Point(298, 129)
        Me.lst_Tries.Name = "lst_Tries"
        Me.lst_Tries.Size = New System.Drawing.Size(161, 121)
        Me.lst_Tries.TabIndex = 12
        '
        'txt_Tries
        '
        Me.txt_Tries.Enabled = False
        Me.txt_Tries.Location = New System.Drawing.Point(485, 127)
        Me.txt_Tries.MaxLength = 32767
        Me.txt_Tries.Multiline = False
        Me.txt_Tries.Name = "txt_Tries"
        Me.txt_Tries.ReadOnly = False
        Me.txt_Tries.Size = New System.Drawing.Size(65, 24)
        Me.txt_Tries.TabIndex = 11
        Me.txt_Tries.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Tries.UseSystemPasswordChar = False
        '
        'lbl_Tries
        '
        Me.lbl_Tries.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Tries.Location = New System.Drawing.Point(463, 106)
        Me.lbl_Tries.Name = "lbl_Tries"
        Me.lbl_Tries.Size = New System.Drawing.Size(103, 17)
        Me.lbl_Tries.TabIndex = 10
        Me.lbl_Tries.Text = "Number of tries:"
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcLabel1.Location = New System.Drawing.Point(36, 64)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(504, 36)
        Me.SlcLabel1.TabIndex = 8
        Me.SlcLabel1.Text = "Guess What (Computer  Vs. Human 1-100)"
        '
        'thm_CvH
        '
        Me.thm_CvH.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.thm_CvH.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_CvH.Controls.Add(Me.pic_Back)
        Me.thm_CvH.Controls.Add(Me.btn_Reset)
        Me.thm_CvH.Controls.Add(Me.SlcLabel2)
        Me.thm_CvH.Controls.Add(Me.lst_Tries)
        Me.thm_CvH.Controls.Add(Me.txt_Tries)
        Me.thm_CvH.Controls.Add(Me.lbl_Tries)
        Me.thm_CvH.Controls.Add(Me.grp_Start)
        Me.thm_CvH.Controls.Add(Me.SlcLabel1)
        Me.thm_CvH.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.thm_CvH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_CvH.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.thm_CvH.Image = Nothing
        Me.thm_CvH.Location = New System.Drawing.Point(0, 0)
        Me.thm_CvH.Movable = True
        Me.thm_CvH.Name = "thm_CvH"
        Me.thm_CvH.NoRounding = False
        Me.thm_CvH.Sizable = True
        Me.thm_CvH.Size = New System.Drawing.Size(578, 299)
        Me.thm_CvH.SmartBounds = True
        Me.thm_CvH.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_CvH.TabIndex = 1
        Me.thm_CvH.Text = "Computer Vs. Human"
        Me.thm_CvH.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_CvH.Transparent = False
        '
        'pic_Back
        '
        Me.pic_Back.BackColor = System.Drawing.Color.Transparent
        Me.pic_Back.Image = CType(resources.GetObject("pic_Back.Image"), System.Drawing.Image)
        Me.pic_Back.Location = New System.Drawing.Point(499, 247)
        Me.pic_Back.Name = "pic_Back"
        Me.pic_Back.Size = New System.Drawing.Size(67, 49)
        Me.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Back.TabIndex = 15
        Me.pic_Back.TabStop = False
        '
        'frm_CvH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 299)
        Me.Controls.Add(Me.thm_CvH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CvH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_CvH"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.grp_Start.ResumeLayout(False)
        CType(Me.pic_Confirm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thm_CvH.ResumeLayout(False)
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Reset As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents btn_Num As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents btn_Guess As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents grp_Start As Hi___Low_Guessing_Game.SLCGroupBox
    Friend WithEvents pic_Confirm As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Num As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lbl_Answer As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents txt_Guess As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents SlcLabel2 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lst_Tries As System.Windows.Forms.ListBox
    Friend WithEvents txt_Tries As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents lbl_Tries As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents SlcLabel1 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents thm_CvH As Hi___Low_Guessing_Game.SLCTheme
    Friend WithEvents pic_Back As System.Windows.Forms.PictureBox
End Class
