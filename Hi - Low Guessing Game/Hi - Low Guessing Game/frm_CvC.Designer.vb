<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CvC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CvC))
        Me.thm_CvC = New Hi___Low_Guessing_Game.SLCTheme()
        Me.pic_Back = New System.Windows.Forms.PictureBox()
        Me.btn_Reset = New Hi___Low_Guessing_Game.SLCbtn()
        Me.lbl_Results = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lst_Tries = New System.Windows.Forms.ListBox()
        Me.txt_Tries = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.lbl_Tries = New Hi___Low_Guessing_Game.SLCLabel()
        Me.grp_Start = New Hi___Low_Guessing_Game.SLCGroupBox()
        Me.txt_Generate = New Hi___Low_Guessing_Game.SLCTextBox()
        Me.pic_Selected = New System.Windows.Forms.PictureBox()
        Me.lbl_Generate = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Generate = New Hi___Low_Guessing_Game.SLCbtn()
        Me.pic_Selected2 = New System.Windows.Forms.PictureBox()
        Me.lbl_Guess = New Hi___Low_Guessing_Game.SLCLabel()
        Me.btn_Guess = New Hi___Low_Guessing_Game.SLCbtn()
        Me.SlcLabel1 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.thm_CvC.SuspendLayout()
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Start.SuspendLayout()
        CType(Me.pic_Selected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Selected2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_CvC
        '
        Me.thm_CvC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.thm_CvC.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_CvC.Controls.Add(Me.pic_Back)
        Me.thm_CvC.Controls.Add(Me.btn_Reset)
        Me.thm_CvC.Controls.Add(Me.lbl_Results)
        Me.thm_CvC.Controls.Add(Me.lst_Tries)
        Me.thm_CvC.Controls.Add(Me.txt_Tries)
        Me.thm_CvC.Controls.Add(Me.lbl_Tries)
        Me.thm_CvC.Controls.Add(Me.grp_Start)
        Me.thm_CvC.Controls.Add(Me.SlcLabel1)
        Me.thm_CvC.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.thm_CvC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_CvC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.thm_CvC.Image = Nothing
        Me.thm_CvC.Location = New System.Drawing.Point(0, 0)
        Me.thm_CvC.Movable = True
        Me.thm_CvC.Name = "thm_CvC"
        Me.thm_CvC.NoRounding = False
        Me.thm_CvC.Sizable = True
        Me.thm_CvC.Size = New System.Drawing.Size(589, 294)
        Me.thm_CvC.SmartBounds = True
        Me.thm_CvC.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_CvC.TabIndex = 0
        Me.thm_CvC.Text = "Computer Vs. Computer"
        Me.thm_CvC.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_CvC.Transparent = False
        '
        'pic_Back
        '
        Me.pic_Back.BackColor = System.Drawing.Color.Transparent
        Me.pic_Back.Image = CType(resources.GetObject("pic_Back.Image"), System.Drawing.Image)
        Me.pic_Back.Location = New System.Drawing.Point(506, 241)
        Me.pic_Back.Name = "pic_Back"
        Me.pic_Back.Size = New System.Drawing.Size(71, 49)
        Me.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Back.TabIndex = 23
        Me.pic_Back.TabStop = False
        '
        'btn_Reset
        '
        Me.btn_Reset.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Reset.Customization = ""
        Me.btn_Reset.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Reset.Image = Nothing
        Me.btn_Reset.Location = New System.Drawing.Point(7, 274)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.NoRounding = False
        Me.btn_Reset.Size = New System.Drawing.Size(94, 16)
        Me.btn_Reset.TabIndex = 21
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.Transparent = False
        '
        'lbl_Results
        '
        Me.lbl_Results.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Results.Location = New System.Drawing.Point(296, 102)
        Me.lbl_Results.Name = "lbl_Results"
        Me.lbl_Results.Size = New System.Drawing.Size(103, 17)
        Me.lbl_Results.TabIndex = 22
        Me.lbl_Results.Text = "Results"
        '
        'lst_Tries
        '
        Me.lst_Tries.FormattingEnabled = True
        Me.lst_Tries.Location = New System.Drawing.Point(296, 123)
        Me.lst_Tries.Name = "lst_Tries"
        Me.lst_Tries.Size = New System.Drawing.Size(161, 121)
        Me.lst_Tries.TabIndex = 20
        '
        'txt_Tries
        '
        Me.txt_Tries.Enabled = False
        Me.txt_Tries.Location = New System.Drawing.Point(483, 121)
        Me.txt_Tries.MaxLength = 32767
        Me.txt_Tries.Multiline = False
        Me.txt_Tries.Name = "txt_Tries"
        Me.txt_Tries.ReadOnly = False
        Me.txt_Tries.Size = New System.Drawing.Size(65, 24)
        Me.txt_Tries.TabIndex = 19
        Me.txt_Tries.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Tries.UseSystemPasswordChar = False
        '
        'lbl_Tries
        '
        Me.lbl_Tries.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Tries.Location = New System.Drawing.Point(461, 100)
        Me.lbl_Tries.Name = "lbl_Tries"
        Me.lbl_Tries.Size = New System.Drawing.Size(103, 17)
        Me.lbl_Tries.TabIndex = 18
        Me.lbl_Tries.Text = "Number of tries:"
        '
        'grp_Start
        '
        Me.grp_Start.Controls.Add(Me.txt_Generate)
        Me.grp_Start.Controls.Add(Me.pic_Selected)
        Me.grp_Start.Controls.Add(Me.lbl_Generate)
        Me.grp_Start.Controls.Add(Me.btn_Generate)
        Me.grp_Start.Controls.Add(Me.pic_Selected2)
        Me.grp_Start.Controls.Add(Me.lbl_Guess)
        Me.grp_Start.Controls.Add(Me.btn_Guess)
        Me.grp_Start.DrawSeperator = False
        Me.grp_Start.Location = New System.Drawing.Point(7, 100)
        Me.grp_Start.Name = "grp_Start"
        Me.grp_Start.Size = New System.Drawing.Size(283, 155)
        Me.grp_Start.SubTitle = ""
        Me.grp_Start.TabIndex = 17
        Me.grp_Start.Text = "SlcGroupBox1"
        Me.grp_Start.Title = "Let`s begin"
        '
        'txt_Generate
        '
        Me.txt_Generate.Enabled = False
        Me.txt_Generate.Location = New System.Drawing.Point(117, 51)
        Me.txt_Generate.MaxLength = 32767
        Me.txt_Generate.Multiline = False
        Me.txt_Generate.Name = "txt_Generate"
        Me.txt_Generate.ReadOnly = False
        Me.txt_Generate.Size = New System.Drawing.Size(65, 24)
        Me.txt_Generate.TabIndex = 24
        Me.txt_Generate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Generate.UseSystemPasswordChar = False
        '
        'pic_Selected
        '
        Me.pic_Selected.BackColor = System.Drawing.Color.Transparent
        Me.pic_Selected.Image = CType(resources.GetObject("pic_Selected.Image"), System.Drawing.Image)
        Me.pic_Selected.Location = New System.Drawing.Point(188, 51)
        Me.pic_Selected.Name = "pic_Selected"
        Me.pic_Selected.Size = New System.Drawing.Size(22, 25)
        Me.pic_Selected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Selected.TabIndex = 11
        Me.pic_Selected.TabStop = False
        Me.pic_Selected.Visible = False
        '
        'lbl_Generate
        '
        Me.lbl_Generate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Generate.Location = New System.Drawing.Point(27, 31)
        Me.lbl_Generate.Name = "lbl_Generate"
        Me.lbl_Generate.Size = New System.Drawing.Size(243, 14)
        Me.lbl_Generate.TabIndex = 10
        Me.lbl_Generate.Text = "Click on the button to generate a number"
        '
        'btn_Generate
        '
        Me.btn_Generate.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Generate.Customization = ""
        Me.btn_Generate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Generate.Image = Nothing
        Me.btn_Generate.Location = New System.Drawing.Point(40, 51)
        Me.btn_Generate.Name = "btn_Generate"
        Me.btn_Generate.NoRounding = False
        Me.btn_Generate.Size = New System.Drawing.Size(71, 25)
        Me.btn_Generate.TabIndex = 9
        Me.btn_Generate.Text = "Let's Play!"
        Me.btn_Generate.Transparent = False
        '
        'pic_Selected2
        '
        Me.pic_Selected2.BackColor = System.Drawing.Color.Transparent
        Me.pic_Selected2.Image = CType(resources.GetObject("pic_Selected2.Image"), System.Drawing.Image)
        Me.pic_Selected2.Location = New System.Drawing.Point(169, 111)
        Me.pic_Selected2.Name = "pic_Selected2"
        Me.pic_Selected2.Size = New System.Drawing.Size(22, 25)
        Me.pic_Selected2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Selected2.TabIndex = 8
        Me.pic_Selected2.TabStop = False
        Me.pic_Selected2.Visible = False
        '
        'lbl_Guess
        '
        Me.lbl_Guess.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Guess.Location = New System.Drawing.Point(27, 91)
        Me.lbl_Guess.Name = "lbl_Guess"
        Me.lbl_Guess.Size = New System.Drawing.Size(217, 14)
        Me.lbl_Guess.TabIndex = 7
        Me.lbl_Guess.Text = "Click on the button to guess number"
        '
        'btn_Guess
        '
        Me.btn_Guess.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Guess.Customization = ""
        Me.btn_Guess.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Guess.Image = Nothing
        Me.btn_Guess.Location = New System.Drawing.Point(92, 111)
        Me.btn_Guess.Name = "btn_Guess"
        Me.btn_Guess.NoRounding = False
        Me.btn_Guess.Size = New System.Drawing.Size(71, 25)
        Me.btn_Guess.TabIndex = 6
        Me.btn_Guess.Text = "Let's Play!"
        Me.btn_Guess.Transparent = False
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcLabel1.Location = New System.Drawing.Point(34, 60)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(504, 36)
        Me.SlcLabel1.TabIndex = 16
        Me.SlcLabel1.Text = "Guess What (Computer  Vs. Computer 1-100)"
        '
        'frm_CvC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 294)
        Me.Controls.Add(Me.thm_CvC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CvC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_CvC"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_CvC.ResumeLayout(False)
        CType(Me.pic_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Start.ResumeLayout(False)
        CType(Me.pic_Selected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Selected2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_CvC As Hi___Low_Guessing_Game.SLCTheme
    Friend WithEvents pic_Back As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Reset As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents lbl_Results As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lst_Tries As System.Windows.Forms.ListBox
    Friend WithEvents txt_Tries As Hi___Low_Guessing_Game.SLCTextBox
    Friend WithEvents lbl_Tries As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents grp_Start As Hi___Low_Guessing_Game.SLCGroupBox
    Friend WithEvents pic_Selected2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Guess As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents btn_Guess As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents SlcLabel1 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents pic_Selected As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Generate As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents btn_Generate As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents txt_Generate As Hi___Low_Guessing_Game.SLCTextBox
End Class
