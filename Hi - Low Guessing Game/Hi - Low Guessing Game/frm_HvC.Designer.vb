<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HvC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HvC))
        Me.tmr_Rate = New System.Windows.Forms.Timer(Me.components)
        Me.thm_HvH = New Hi___Low_Guessing_Game.SLCTheme()
        Me.pic_Back = New System.Windows.Forms.PictureBox()
        Me.btn_Reset = New Hi___Low_Guessing_Game.SLCbtn()
        Me.SlcLabel2 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lst_Tries = New System.Windows.Forms.ListBox()
        Me.txt_Tries = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.lbl_Tries = New Hi___Low_Guessing_Game.SLCLabel()
        Me.grp_Start = New Hi___Low_Guessing_Game.SLCGroupBox()
        Me.pic_Selected = New System.Windows.Forms.PictureBox()
        Me.lbl_Num = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Generate = New Hi___Low_Guessing_Game.SLCbtn()
        Me.lbl_Answer = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Guess = New Hi___Low_Guessing_Game.SLCbtn()
        Me.txt_Guess = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.SlcLabel1 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.thm_HvH.SuspendLayout()
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Start.SuspendLayout()
        CType(Me.pic_Selected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.thm_HvH.Size = New System.Drawing.Size(578, 286)
        Me.thm_HvH.SmartBounds = True
        Me.thm_HvH.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_HvH.TabIndex = 1
        Me.thm_HvH.Text = "Human Vs. Computer"
        Me.thm_HvH.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_HvH.Transparent = False
        '
        'pic_Back
        '
        Me.pic_Back.BackColor = System.Drawing.Color.Transparent
        Me.pic_Back.Image = CType(resources.GetObject("pic_Back.Image"), System.Drawing.Image)
        Me.pic_Back.Location = New System.Drawing.Point(499, 234)
        Me.pic_Back.Name = "pic_Back"
        Me.pic_Back.Size = New System.Drawing.Size(67, 49)
        Me.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Back.TabIndex = 7
        Me.pic_Back.TabStop = False
        '
        'btn_Reset
        '
        Me.btn_Reset.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Reset.Customization = ""
        Me.btn_Reset.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Reset.Image = Nothing
        Me.btn_Reset.Location = New System.Drawing.Point(8, 263)
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
        Me.grp_Start.Controls.Add(Me.pic_Selected)
        Me.grp_Start.Controls.Add(Me.lbl_Num)
        Me.grp_Start.Controls.Add(Me.btn_Generate)
        Me.grp_Start.Controls.Add(Me.lbl_Answer)
        Me.grp_Start.Controls.Add(Me.btn_Guess)
        Me.grp_Start.Controls.Add(Me.txt_Guess)
        Me.grp_Start.DrawSeperator = False
        Me.grp_Start.Location = New System.Drawing.Point(8, 102)
        Me.grp_Start.Name = "grp_Start"
        Me.grp_Start.Size = New System.Drawing.Size(283, 155)
        Me.grp_Start.SubTitle = ""
        Me.grp_Start.TabIndex = 1
        Me.grp_Start.Text = "SlcGroupBox1"
        Me.grp_Start.Title = "Let`s begin"
        '
        'pic_Selected
        '
        Me.pic_Selected.BackColor = System.Drawing.Color.Transparent
        Me.pic_Selected.Image = CType(resources.GetObject("pic_Selected.Image"), System.Drawing.Image)
        Me.pic_Selected.Location = New System.Drawing.Point(181, 51)
        Me.pic_Selected.Name = "pic_Selected"
        Me.pic_Selected.Size = New System.Drawing.Size(22, 25)
        Me.pic_Selected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Selected.TabIndex = 8
        Me.pic_Selected.TabStop = False
        Me.pic_Selected.Visible = False
        '
        'lbl_Num
        '
        Me.lbl_Num.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Num.Location = New System.Drawing.Point(8, 31)
        Me.lbl_Num.Name = "lbl_Num"
        Me.lbl_Num.Size = New System.Drawing.Size(272, 20)
        Me.lbl_Num.TabIndex = 7
        Me.lbl_Num.Text = "Click on the button to generate random number"
        '
        'btn_Generate
        '
        Me.btn_Generate.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Generate.Customization = ""
        Me.btn_Generate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Generate.Image = Nothing
        Me.btn_Generate.Location = New System.Drawing.Point(104, 51)
        Me.btn_Generate.Name = "btn_Generate"
        Me.btn_Generate.NoRounding = False
        Me.btn_Generate.Size = New System.Drawing.Size(71, 25)
        Me.btn_Generate.TabIndex = 6
        Me.btn_Generate.Text = "Let's Play!"
        Me.btn_Generate.Transparent = False
        '
        'lbl_Answer
        '
        Me.lbl_Answer.BackColor = System.Drawing.Color.Red
        Me.lbl_Answer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Answer.ForeColor = System.Drawing.Color.Red
        Me.lbl_Answer.Location = New System.Drawing.Point(15, 88)
        Me.lbl_Answer.Name = "lbl_Answer"
        Me.lbl_Answer.Size = New System.Drawing.Size(128, 18)
        Me.lbl_Answer.TabIndex = 5
        Me.lbl_Answer.Text = "Enter guess below"
        '
        'btn_Guess
        '
        Me.btn_Guess.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Guess.Customization = ""
        Me.btn_Guess.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Guess.Image = Nothing
        Me.btn_Guess.Location = New System.Drawing.Point(213, 99)
        Me.btn_Guess.Name = "btn_Guess"
        Me.btn_Guess.NoRounding = False
        Me.btn_Guess.Size = New System.Drawing.Size(62, 40)
        Me.btn_Guess.TabIndex = 4
        Me.btn_Guess.Text = "Guess"
        Me.btn_Guess.Transparent = False
        '
        'txt_Guess
        '
        Me.txt_Guess.Location = New System.Drawing.Point(15, 106)
        Me.txt_Guess.MaxLength = 32767
        Me.txt_Guess.Multiline = False
        Me.txt_Guess.Name = "txt_Guess"
        Me.txt_Guess.ReadOnly = False
        Me.txt_Guess.Size = New System.Drawing.Size(188, 24)
        Me.txt_Guess.TabIndex = 3
        Me.txt_Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Guess.UseSystemPasswordChar = False
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcLabel1.Location = New System.Drawing.Point(47, 60)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(504, 36)
        Me.SlcLabel1.TabIndex = 0
        Me.SlcLabel1.Text = "Guess What (Human Vs. Computer 1-100)"
        '
        'frm_HvC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 286)
        Me.Controls.Add(Me.thm_HvH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_HvC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_HvC"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_HvH.ResumeLayout(False)
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Start.ResumeLayout(False)
        CType(Me.pic_Selected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcLabel1 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents thm_HvH As Hi___Low_Guessing_Game.SLCTheme
    Friend WithEvents btn_Reset As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents SlcLabel2 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lst_Tries As System.Windows.Forms.ListBox
    Friend WithEvents txt_Tries As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents lbl_Tries As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents grp_Start As Hi___Low_Guessing_Game.SLCGroupBox
    Friend WithEvents lbl_Num As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents btn_Generate As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents lbl_Answer As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents btn_Guess As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents txt_Guess As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents tmr_Rate As System.Windows.Forms.Timer
    Friend WithEvents pic_Back As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Selected As System.Windows.Forms.PictureBox
End Class
