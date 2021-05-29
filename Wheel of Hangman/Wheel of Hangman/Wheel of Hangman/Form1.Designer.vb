<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.tmr_Update = New System.Windows.Forms.Timer(Me.components)
        Me.thm_Main = New Wheel_of_Hangman.BaWGUIThemeContainer()
        Me.lbl_Length = New System.Windows.Forms.Label()
        Me.lbl_Guess = New System.Windows.Forms.Label()
        Me.lbl_GuessInfo = New System.Windows.Forms.Label()
        Me.lbl_LenInfo = New System.Windows.Forms.Label()
        Me.lbl_Wrong = New System.Windows.Forms.Label()
        Me.lbl_WrongInfo = New System.Windows.Forms.Label()
        Me.lbl_Score = New System.Windows.Forms.Label()
        Me.lbl_ScoreInfo = New System.Windows.Forms.Label()
        Me.pic_Attention = New System.Windows.Forms.PictureBox()
        Me.lbl_Subject = New System.Windows.Forms.Label()
        Me.lbl_SubjectInfo = New System.Windows.Forms.Label()
        Me.grp_Mode = New System.Windows.Forms.GroupBox()
        Me.rdo_Hard = New Wheel_of_Hangman.BaWGUIRadioButton()
        Me.rdo_Medium = New Wheel_of_Hangman.BaWGUIRadioButton()
        Me.rdo_Easy = New Wheel_of_Hangman.BaWGUIRadioButton()
        Me.lbl_Info = New System.Windows.Forms.Label()
        Me.btn_StrtOver = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_newGame = New Wheel_of_Hangman.BaWGUIButton()
        Me.grp_Letters = New System.Windows.Forms.GroupBox()
        Me.btn_P = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_O = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_N = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_B = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_V = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_C = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_M = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_X = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_Z = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_L = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_J = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_H = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_G = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_F = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_K = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_D = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_S = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_A = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_I = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_U = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_Y = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_T = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_R = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_E = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_Q = New Wheel_of_Hangman.BaWGUIButton()
        Me.btn_W = New Wheel_of_Hangman.BaWGUIButton()
        Me.pic_Hangman = New System.Windows.Forms.PictureBox()
        Me.grp_Missed = New System.Windows.Forms.GroupBox()
        Me.txt_Missed = New Wheel_of_Hangman.BaWGUITextBox()
        Me.pnl_Main = New System.Windows.Forms.Panel()
        Me.lbl_Letters = New System.Windows.Forms.Label()
        Me.lbl_Word = New System.Windows.Forms.Label()
        Me.btn_Lose = New Wheel_of_Hangman.BaWGUIButton()
        Me.thm_Main.SuspendLayout()
        CType(Me.pic_Attention, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Mode.SuspendLayout()
        Me.grp_Letters.SuspendLayout()
        CType(Me.pic_Hangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Missed.SuspendLayout()
        Me.pnl_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmr_Update
        '
        Me.tmr_Update.Enabled = True
        '
        'thm_Main
        '
        Me.thm_Main.BackColor = System.Drawing.Color.White
        Me.thm_Main.Controls.Add(Me.lbl_Length)
        Me.thm_Main.Controls.Add(Me.lbl_Guess)
        Me.thm_Main.Controls.Add(Me.lbl_GuessInfo)
        Me.thm_Main.Controls.Add(Me.lbl_LenInfo)
        Me.thm_Main.Controls.Add(Me.lbl_Wrong)
        Me.thm_Main.Controls.Add(Me.lbl_WrongInfo)
        Me.thm_Main.Controls.Add(Me.lbl_Score)
        Me.thm_Main.Controls.Add(Me.lbl_ScoreInfo)
        Me.thm_Main.Controls.Add(Me.pic_Attention)
        Me.thm_Main.Controls.Add(Me.lbl_Subject)
        Me.thm_Main.Controls.Add(Me.lbl_SubjectInfo)
        Me.thm_Main.Controls.Add(Me.grp_Mode)
        Me.thm_Main.Controls.Add(Me.lbl_Info)
        Me.thm_Main.Controls.Add(Me.btn_StrtOver)
        Me.thm_Main.Controls.Add(Me.btn_newGame)
        Me.thm_Main.Controls.Add(Me.grp_Letters)
        Me.thm_Main.Controls.Add(Me.pic_Hangman)
        Me.thm_Main.Controls.Add(Me.grp_Missed)
        Me.thm_Main.Controls.Add(Me.pnl_Main)
        Me.thm_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Main.DrawButtonStrings = True
        Me.thm_Main.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.thm_Main.Location = New System.Drawing.Point(0, 0)
        Me.thm_Main.Name = "thm_Main"
        Me.thm_Main.Size = New System.Drawing.Size(570, 425)
        Me.thm_Main.TabIndex = 0
        Me.thm_Main.Text = "Wheel of Hangman"
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Length.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Length.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Length.Location = New System.Drawing.Point(264, 299)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(19, 14)
        Me.lbl_Length.TabIndex = 23
        Me.lbl_Length.Text = "10"
        '
        'lbl_Guess
        '
        Me.lbl_Guess.AutoSize = True
        Me.lbl_Guess.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Guess.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Guess.ForeColor = System.Drawing.Color.Red
        Me.lbl_Guess.Location = New System.Drawing.Point(264, 250)
        Me.lbl_Guess.Name = "lbl_Guess"
        Me.lbl_Guess.Size = New System.Drawing.Size(19, 14)
        Me.lbl_Guess.TabIndex = 20
        Me.lbl_Guess.Text = "10"
        '
        'lbl_GuessInfo
        '
        Me.lbl_GuessInfo.AutoSize = True
        Me.lbl_GuessInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GuessInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GuessInfo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_GuessInfo.Location = New System.Drawing.Point(188, 250)
        Me.lbl_GuessInfo.Name = "lbl_GuessInfo"
        Me.lbl_GuessInfo.Size = New System.Drawing.Size(76, 14)
        Me.lbl_GuessInfo.TabIndex = 19
        Me.lbl_GuessInfo.Text = "Guesses Left:"
        '
        'lbl_LenInfo
        '
        Me.lbl_LenInfo.AutoSize = True
        Me.lbl_LenInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LenInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LenInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_LenInfo.Location = New System.Drawing.Point(221, 299)
        Me.lbl_LenInfo.Name = "lbl_LenInfo"
        Me.lbl_LenInfo.Size = New System.Drawing.Size(43, 14)
        Me.lbl_LenInfo.TabIndex = 22
        Me.lbl_LenInfo.Text = "Length:"
        '
        'lbl_Wrong
        '
        Me.lbl_Wrong.AutoSize = True
        Me.lbl_Wrong.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wrong.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Wrong.Location = New System.Drawing.Point(423, 404)
        Me.lbl_Wrong.Name = "lbl_Wrong"
        Me.lbl_Wrong.Size = New System.Drawing.Size(18, 19)
        Me.lbl_Wrong.TabIndex = 18
        Me.lbl_Wrong.Text = "0"
        '
        'lbl_WrongInfo
        '
        Me.lbl_WrongInfo.AutoSize = True
        Me.lbl_WrongInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_WrongInfo.ForeColor = System.Drawing.Color.Red
        Me.lbl_WrongInfo.Location = New System.Drawing.Point(360, 404)
        Me.lbl_WrongInfo.Name = "lbl_WrongInfo"
        Me.lbl_WrongInfo.Size = New System.Drawing.Size(66, 19)
        Me.lbl_WrongInfo.TabIndex = 17
        Me.lbl_WrongInfo.Text = "Wrong:"
        '
        'lbl_Score
        '
        Me.lbl_Score.AutoSize = True
        Me.lbl_Score.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Score.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Score.Location = New System.Drawing.Point(64, 404)
        Me.lbl_Score.Name = "lbl_Score"
        Me.lbl_Score.Size = New System.Drawing.Size(18, 19)
        Me.lbl_Score.TabIndex = 16
        Me.lbl_Score.Text = "0"
        '
        'lbl_ScoreInfo
        '
        Me.lbl_ScoreInfo.AutoSize = True
        Me.lbl_ScoreInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ScoreInfo.ForeColor = System.Drawing.Color.Red
        Me.lbl_ScoreInfo.Location = New System.Drawing.Point(6, 404)
        Me.lbl_ScoreInfo.Name = "lbl_ScoreInfo"
        Me.lbl_ScoreInfo.Size = New System.Drawing.Size(64, 19)
        Me.lbl_ScoreInfo.TabIndex = 15
        Me.lbl_ScoreInfo.Text = "Score: "
        '
        'pic_Attention
        '
        Me.pic_Attention.BackColor = System.Drawing.Color.Transparent
        Me.pic_Attention.Image = CType(resources.GetObject("pic_Attention.Image"), System.Drawing.Image)
        Me.pic_Attention.Location = New System.Drawing.Point(289, 59)
        Me.pic_Attention.Name = "pic_Attention"
        Me.pic_Attention.Size = New System.Drawing.Size(46, 40)
        Me.pic_Attention.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Attention.TabIndex = 12
        Me.pic_Attention.TabStop = False
        '
        'lbl_Subject
        '
        Me.lbl_Subject.AutoSize = True
        Me.lbl_Subject.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Subject.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subject.ForeColor = System.Drawing.Color.Red
        Me.lbl_Subject.Location = New System.Drawing.Point(59, 250)
        Me.lbl_Subject.Name = "lbl_Subject"
        Me.lbl_Subject.Size = New System.Drawing.Size(0, 14)
        Me.lbl_Subject.TabIndex = 10
        '
        'lbl_SubjectInfo
        '
        Me.lbl_SubjectInfo.AutoSize = True
        Me.lbl_SubjectInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubjectInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubjectInfo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_SubjectInfo.Location = New System.Drawing.Point(13, 250)
        Me.lbl_SubjectInfo.Name = "lbl_SubjectInfo"
        Me.lbl_SubjectInfo.Size = New System.Drawing.Size(46, 14)
        Me.lbl_SubjectInfo.TabIndex = 9
        Me.lbl_SubjectInfo.Text = "Subject:"
        '
        'grp_Mode
        '
        Me.grp_Mode.BackColor = System.Drawing.Color.Transparent
        Me.grp_Mode.Controls.Add(Me.rdo_Hard)
        Me.grp_Mode.Controls.Add(Me.rdo_Medium)
        Me.grp_Mode.Controls.Add(Me.rdo_Easy)
        Me.grp_Mode.Location = New System.Drawing.Point(295, 202)
        Me.grp_Mode.Name = "grp_Mode"
        Me.grp_Mode.Size = New System.Drawing.Size(266, 66)
        Me.grp_Mode.TabIndex = 6
        Me.grp_Mode.TabStop = False
        Me.grp_Mode.Text = "Game Mode"
        '
        'rdo_Hard
        '
        Me.rdo_Hard.BackColor = System.Drawing.Color.Transparent
        Me.rdo_Hard.Checked = False
        Me.rdo_Hard.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.rdo_Hard.Group = 1
        Me.rdo_Hard.Location = New System.Drawing.Point(185, 25)
        Me.rdo_Hard.Name = "rdo_Hard"
        Me.rdo_Hard.Size = New System.Drawing.Size(75, 26)
        Me.rdo_Hard.TabIndex = 2
        Me.rdo_Hard.Text = "Hard"
        '
        'rdo_Medium
        '
        Me.rdo_Medium.BackColor = System.Drawing.Color.Transparent
        Me.rdo_Medium.Checked = False
        Me.rdo_Medium.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.rdo_Medium.Group = 1
        Me.rdo_Medium.Location = New System.Drawing.Point(86, 25)
        Me.rdo_Medium.Name = "rdo_Medium"
        Me.rdo_Medium.Size = New System.Drawing.Size(93, 26)
        Me.rdo_Medium.TabIndex = 1
        Me.rdo_Medium.Text = "Medium"
        '
        'rdo_Easy
        '
        Me.rdo_Easy.BackColor = System.Drawing.Color.Transparent
        Me.rdo_Easy.Checked = True
        Me.rdo_Easy.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.rdo_Easy.Group = 1
        Me.rdo_Easy.Location = New System.Drawing.Point(6, 25)
        Me.rdo_Easy.Name = "rdo_Easy"
        Me.rdo_Easy.Size = New System.Drawing.Size(74, 26)
        Me.rdo_Easy.TabIndex = 0
        Me.rdo_Easy.Text = "Easy"
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Info.Location = New System.Drawing.Point(336, 59)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(228, 39)
        Me.lbl_Info.TabIndex = 8
        Me.lbl_Info.Text = "Pick a letter from the buttons. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Continue until you solve the puzzle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or all th" & _
            "e body parts are on the screen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_StrtOver
        '
        Me.btn_StrtOver.BackColor = System.Drawing.Color.Transparent
        Me.btn_StrtOver.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_StrtOver.Location = New System.Drawing.Point(364, 114)
        Me.btn_StrtOver.Name = "btn_StrtOver"
        Me.btn_StrtOver.Size = New System.Drawing.Size(133, 35)
        Me.btn_StrtOver.TabIndex = 7
        Me.btn_StrtOver.Text = "Start Over"
        '
        'btn_newGame
        '
        Me.btn_newGame.BackColor = System.Drawing.Color.Transparent
        Me.btn_newGame.Enabled = False
        Me.btn_newGame.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_newGame.Location = New System.Drawing.Point(364, 155)
        Me.btn_newGame.Name = "btn_newGame"
        Me.btn_newGame.Size = New System.Drawing.Size(133, 35)
        Me.btn_newGame.TabIndex = 6
        Me.btn_newGame.Text = "New Game"
        '
        'grp_Letters
        '
        Me.grp_Letters.BackColor = System.Drawing.Color.Transparent
        Me.grp_Letters.Controls.Add(Me.btn_P)
        Me.grp_Letters.Controls.Add(Me.btn_O)
        Me.grp_Letters.Controls.Add(Me.btn_N)
        Me.grp_Letters.Controls.Add(Me.btn_B)
        Me.grp_Letters.Controls.Add(Me.btn_V)
        Me.grp_Letters.Controls.Add(Me.btn_C)
        Me.grp_Letters.Controls.Add(Me.btn_M)
        Me.grp_Letters.Controls.Add(Me.btn_X)
        Me.grp_Letters.Controls.Add(Me.btn_Z)
        Me.grp_Letters.Controls.Add(Me.btn_L)
        Me.grp_Letters.Controls.Add(Me.btn_J)
        Me.grp_Letters.Controls.Add(Me.btn_H)
        Me.grp_Letters.Controls.Add(Me.btn_G)
        Me.grp_Letters.Controls.Add(Me.btn_F)
        Me.grp_Letters.Controls.Add(Me.btn_K)
        Me.grp_Letters.Controls.Add(Me.btn_D)
        Me.grp_Letters.Controls.Add(Me.btn_S)
        Me.grp_Letters.Controls.Add(Me.btn_A)
        Me.grp_Letters.Controls.Add(Me.btn_I)
        Me.grp_Letters.Controls.Add(Me.btn_U)
        Me.grp_Letters.Controls.Add(Me.btn_Y)
        Me.grp_Letters.Controls.Add(Me.btn_T)
        Me.grp_Letters.Controls.Add(Me.btn_R)
        Me.grp_Letters.Controls.Add(Me.btn_E)
        Me.grp_Letters.Controls.Add(Me.btn_Q)
        Me.grp_Letters.Controls.Add(Me.btn_W)
        Me.grp_Letters.Enabled = False
        Me.grp_Letters.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grp_Letters.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_Letters.Location = New System.Drawing.Point(3, 306)
        Me.grp_Letters.Name = "grp_Letters"
        Me.grp_Letters.Size = New System.Drawing.Size(349, 99)
        Me.grp_Letters.TabIndex = 3
        Me.grp_Letters.TabStop = False
        Me.grp_Letters.Text = "Letters"
        '
        'btn_P
        '
        Me.btn_P.BackColor = System.Drawing.Color.Transparent
        Me.btn_P.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_P.Location = New System.Drawing.Point(6, 50)
        Me.btn_P.Name = "btn_P"
        Me.btn_P.Size = New System.Drawing.Size(32, 19)
        Me.btn_P.TabIndex = 26
        Me.btn_P.Text = "P"
        '
        'btn_O
        '
        Me.btn_O.BackColor = System.Drawing.Color.Transparent
        Me.btn_O.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_O.Location = New System.Drawing.Point(310, 25)
        Me.btn_O.Name = "btn_O"
        Me.btn_O.Size = New System.Drawing.Size(32, 19)
        Me.btn_O.TabIndex = 25
        Me.btn_O.Text = "O"
        '
        'btn_N
        '
        Me.btn_N.BackColor = System.Drawing.Color.Transparent
        Me.btn_N.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_N.Location = New System.Drawing.Point(245, 75)
        Me.btn_N.Name = "btn_N"
        Me.btn_N.Size = New System.Drawing.Size(32, 19)
        Me.btn_N.TabIndex = 24
        Me.btn_N.Text = "N"
        '
        'btn_B
        '
        Me.btn_B.BackColor = System.Drawing.Color.Transparent
        Me.btn_B.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_B.Location = New System.Drawing.Point(207, 75)
        Me.btn_B.Name = "btn_B"
        Me.btn_B.Size = New System.Drawing.Size(32, 19)
        Me.btn_B.TabIndex = 23
        Me.btn_B.Text = "B"
        '
        'btn_V
        '
        Me.btn_V.BackColor = System.Drawing.Color.Transparent
        Me.btn_V.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_V.Location = New System.Drawing.Point(169, 75)
        Me.btn_V.Name = "btn_V"
        Me.btn_V.Size = New System.Drawing.Size(32, 19)
        Me.btn_V.TabIndex = 22
        Me.btn_V.Text = "V"
        '
        'btn_C
        '
        Me.btn_C.BackColor = System.Drawing.Color.Transparent
        Me.btn_C.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_C.Location = New System.Drawing.Point(131, 75)
        Me.btn_C.Name = "btn_C"
        Me.btn_C.Size = New System.Drawing.Size(32, 19)
        Me.btn_C.TabIndex = 21
        Me.btn_C.Text = "C"
        '
        'btn_M
        '
        Me.btn_M.BackColor = System.Drawing.Color.Transparent
        Me.btn_M.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_M.Location = New System.Drawing.Point(283, 75)
        Me.btn_M.Name = "btn_M"
        Me.btn_M.Size = New System.Drawing.Size(32, 19)
        Me.btn_M.TabIndex = 20
        Me.btn_M.Text = "M"
        '
        'btn_X
        '
        Me.btn_X.BackColor = System.Drawing.Color.Transparent
        Me.btn_X.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_X.Location = New System.Drawing.Point(93, 75)
        Me.btn_X.Name = "btn_X"
        Me.btn_X.Size = New System.Drawing.Size(32, 19)
        Me.btn_X.TabIndex = 19
        Me.btn_X.Text = "X"
        '
        'btn_Z
        '
        Me.btn_Z.BackColor = System.Drawing.Color.Transparent
        Me.btn_Z.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Z.Location = New System.Drawing.Point(55, 75)
        Me.btn_Z.Name = "btn_Z"
        Me.btn_Z.Size = New System.Drawing.Size(32, 19)
        Me.btn_Z.TabIndex = 18
        Me.btn_Z.Text = "Z"
        '
        'btn_L
        '
        Me.btn_L.BackColor = System.Drawing.Color.Transparent
        Me.btn_L.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_L.Location = New System.Drawing.Point(17, 75)
        Me.btn_L.Name = "btn_L"
        Me.btn_L.Size = New System.Drawing.Size(32, 19)
        Me.btn_L.TabIndex = 17
        Me.btn_L.Text = "L"
        '
        'btn_J
        '
        Me.btn_J.BackColor = System.Drawing.Color.Transparent
        Me.btn_J.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_J.Location = New System.Drawing.Point(272, 50)
        Me.btn_J.Name = "btn_J"
        Me.btn_J.Size = New System.Drawing.Size(32, 19)
        Me.btn_J.TabIndex = 16
        Me.btn_J.Text = "J"
        '
        'btn_H
        '
        Me.btn_H.BackColor = System.Drawing.Color.Transparent
        Me.btn_H.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_H.Location = New System.Drawing.Point(234, 50)
        Me.btn_H.Name = "btn_H"
        Me.btn_H.Size = New System.Drawing.Size(32, 19)
        Me.btn_H.TabIndex = 15
        Me.btn_H.Text = "H"
        '
        'btn_G
        '
        Me.btn_G.BackColor = System.Drawing.Color.Transparent
        Me.btn_G.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_G.Location = New System.Drawing.Point(196, 50)
        Me.btn_G.Name = "btn_G"
        Me.btn_G.Size = New System.Drawing.Size(32, 19)
        Me.btn_G.TabIndex = 14
        Me.btn_G.Text = "G"
        '
        'btn_F
        '
        Me.btn_F.BackColor = System.Drawing.Color.Transparent
        Me.btn_F.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_F.Location = New System.Drawing.Point(158, 50)
        Me.btn_F.Name = "btn_F"
        Me.btn_F.Size = New System.Drawing.Size(32, 19)
        Me.btn_F.TabIndex = 13
        Me.btn_F.Text = "F"
        '
        'btn_K
        '
        Me.btn_K.BackColor = System.Drawing.Color.Transparent
        Me.btn_K.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_K.Location = New System.Drawing.Point(310, 50)
        Me.btn_K.Name = "btn_K"
        Me.btn_K.Size = New System.Drawing.Size(32, 19)
        Me.btn_K.TabIndex = 12
        Me.btn_K.Text = "K"
        '
        'btn_D
        '
        Me.btn_D.BackColor = System.Drawing.Color.Transparent
        Me.btn_D.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_D.Location = New System.Drawing.Point(120, 50)
        Me.btn_D.Name = "btn_D"
        Me.btn_D.Size = New System.Drawing.Size(32, 19)
        Me.btn_D.TabIndex = 11
        Me.btn_D.Text = "D"
        '
        'btn_S
        '
        Me.btn_S.BackColor = System.Drawing.Color.Transparent
        Me.btn_S.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_S.Location = New System.Drawing.Point(82, 50)
        Me.btn_S.Name = "btn_S"
        Me.btn_S.Size = New System.Drawing.Size(32, 19)
        Me.btn_S.TabIndex = 10
        Me.btn_S.Text = "S"
        '
        'btn_A
        '
        Me.btn_A.BackColor = System.Drawing.Color.Transparent
        Me.btn_A.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_A.Location = New System.Drawing.Point(44, 50)
        Me.btn_A.Name = "btn_A"
        Me.btn_A.Size = New System.Drawing.Size(32, 19)
        Me.btn_A.TabIndex = 9
        Me.btn_A.Text = "A"
        '
        'btn_I
        '
        Me.btn_I.BackColor = System.Drawing.Color.Transparent
        Me.btn_I.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_I.Location = New System.Drawing.Point(272, 25)
        Me.btn_I.Name = "btn_I"
        Me.btn_I.Size = New System.Drawing.Size(32, 19)
        Me.btn_I.TabIndex = 8
        Me.btn_I.Text = "I"
        '
        'btn_U
        '
        Me.btn_U.BackColor = System.Drawing.Color.Transparent
        Me.btn_U.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_U.Location = New System.Drawing.Point(234, 25)
        Me.btn_U.Name = "btn_U"
        Me.btn_U.Size = New System.Drawing.Size(32, 19)
        Me.btn_U.TabIndex = 7
        Me.btn_U.Text = "U"
        '
        'btn_Y
        '
        Me.btn_Y.BackColor = System.Drawing.Color.Transparent
        Me.btn_Y.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Y.Location = New System.Drawing.Point(196, 25)
        Me.btn_Y.Name = "btn_Y"
        Me.btn_Y.Size = New System.Drawing.Size(32, 19)
        Me.btn_Y.TabIndex = 6
        Me.btn_Y.Text = "Y"
        '
        'btn_T
        '
        Me.btn_T.BackColor = System.Drawing.Color.Transparent
        Me.btn_T.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_T.Location = New System.Drawing.Point(158, 25)
        Me.btn_T.Name = "btn_T"
        Me.btn_T.Size = New System.Drawing.Size(32, 19)
        Me.btn_T.TabIndex = 5
        Me.btn_T.Text = "T"
        '
        'btn_R
        '
        Me.btn_R.BackColor = System.Drawing.Color.Transparent
        Me.btn_R.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_R.Location = New System.Drawing.Point(120, 25)
        Me.btn_R.Name = "btn_R"
        Me.btn_R.Size = New System.Drawing.Size(32, 19)
        Me.btn_R.TabIndex = 4
        Me.btn_R.Text = "R"
        '
        'btn_E
        '
        Me.btn_E.BackColor = System.Drawing.Color.Transparent
        Me.btn_E.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_E.Location = New System.Drawing.Point(82, 25)
        Me.btn_E.Name = "btn_E"
        Me.btn_E.Size = New System.Drawing.Size(32, 19)
        Me.btn_E.TabIndex = 3
        Me.btn_E.Text = "E"
        '
        'btn_Q
        '
        Me.btn_Q.BackColor = System.Drawing.Color.Transparent
        Me.btn_Q.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Q.Location = New System.Drawing.Point(6, 25)
        Me.btn_Q.Name = "btn_Q"
        Me.btn_Q.Size = New System.Drawing.Size(32, 19)
        Me.btn_Q.TabIndex = 1
        Me.btn_Q.Text = "Q"
        '
        'btn_W
        '
        Me.btn_W.BackColor = System.Drawing.Color.Transparent
        Me.btn_W.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_W.Location = New System.Drawing.Point(44, 25)
        Me.btn_W.Name = "btn_W"
        Me.btn_W.Size = New System.Drawing.Size(32, 19)
        Me.btn_W.TabIndex = 2
        Me.btn_W.Text = "W"
        '
        'pic_Hangman
        '
        Me.pic_Hangman.BackColor = System.Drawing.Color.Transparent
        Me.pic_Hangman.Image = CType(resources.GetObject("pic_Hangman.Image"), System.Drawing.Image)
        Me.pic_Hangman.Location = New System.Drawing.Point(12, 59)
        Me.pic_Hangman.Name = "pic_Hangman"
        Me.pic_Hangman.Size = New System.Drawing.Size(271, 188)
        Me.pic_Hangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Hangman.TabIndex = 0
        Me.pic_Hangman.TabStop = False
        '
        'grp_Missed
        '
        Me.grp_Missed.BackColor = System.Drawing.Color.Transparent
        Me.grp_Missed.Controls.Add(Me.txt_Missed)
        Me.grp_Missed.Location = New System.Drawing.Point(358, 303)
        Me.grp_Missed.Name = "grp_Missed"
        Me.grp_Missed.Size = New System.Drawing.Size(203, 99)
        Me.grp_Missed.TabIndex = 5
        Me.grp_Missed.TabStop = False
        Me.grp_Missed.Text = "Missed"
        '
        'txt_Missed
        '
        Me.txt_Missed.BackColor = System.Drawing.Color.Transparent
        Me.txt_Missed.Enabled = False
        Me.txt_Missed.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Missed.Image = Nothing
        Me.txt_Missed.Location = New System.Drawing.Point(9, 25)
        Me.txt_Missed.MaxLength = 32767
        Me.txt_Missed.Multiline = True
        Me.txt_Missed.Name = "txt_Missed"
        Me.txt_Missed.ReadOnly = True
        Me.txt_Missed.Size = New System.Drawing.Size(191, 67)
        Me.txt_Missed.TabIndex = 19
        Me.txt_Missed.UseSystemPasswordChar = False
        '
        'pnl_Main
        '
        Me.pnl_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_Main.Controls.Add(Me.lbl_Letters)
        Me.pnl_Main.Controls.Add(Me.lbl_Word)
        Me.pnl_Main.Controls.Add(Me.btn_Lose)
        Me.pnl_Main.Enabled = False
        Me.pnl_Main.Location = New System.Drawing.Point(11, 269)
        Me.pnl_Main.Name = "pnl_Main"
        Me.pnl_Main.Size = New System.Drawing.Size(272, 27)
        Me.pnl_Main.TabIndex = 21
        '
        'lbl_Letters
        '
        Me.lbl_Letters.AutoSize = True
        Me.lbl_Letters.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Letters.ForeColor = System.Drawing.Color.White
        Me.lbl_Letters.Location = New System.Drawing.Point(55, 4)
        Me.lbl_Letters.Name = "lbl_Letters"
        Me.lbl_Letters.Size = New System.Drawing.Size(0, 19)
        Me.lbl_Letters.TabIndex = 13
        '
        'lbl_Word
        '
        Me.lbl_Word.AutoSize = True
        Me.lbl_Word.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Word.ForeColor = System.Drawing.Color.White
        Me.lbl_Word.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Word.Name = "lbl_Word"
        Me.lbl_Word.Size = New System.Drawing.Size(56, 19)
        Me.lbl_Word.TabIndex = 11
        Me.lbl_Word.Text = "Word:"
        '
        'btn_Lose
        '
        Me.btn_Lose.BackColor = System.Drawing.Color.Transparent
        Me.btn_Lose.Enabled = False
        Me.btn_Lose.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Lose.Location = New System.Drawing.Point(199, 3)
        Me.btn_Lose.Name = "btn_Lose"
        Me.btn_Lose.Size = New System.Drawing.Size(70, 21)
        Me.btn_Lose.TabIndex = 14
        Me.btn_Lose.Text = "Give Up"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 425)
        Me.Controls.Add(Me.thm_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(570, 425)
        Me.MinimumSize = New System.Drawing.Size(570, 425)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wheel of Hangman"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Main.ResumeLayout(False)
        Me.thm_Main.PerformLayout()
        CType(Me.pic_Attention, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Mode.ResumeLayout(False)
        Me.grp_Letters.ResumeLayout(False)
        CType(Me.pic_Hangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Missed.ResumeLayout(False)
        Me.pnl_Main.ResumeLayout(False)
        Me.pnl_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Main As Wheel_of_Hangman.BaWGUIThemeContainer
    Friend WithEvents grp_Letters As System.Windows.Forms.GroupBox
    Friend WithEvents btn_O As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_N As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_B As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_V As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_C As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_M As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_X As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_Z As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_L As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_J As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_H As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_G As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_F As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_K As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_D As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_S As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_A As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_I As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_U As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_Y As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_T As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_R As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_E As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_Q As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_W As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents pic_Hangman As System.Windows.Forms.PictureBox
    Friend WithEvents btn_P As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents grp_Missed As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Info As System.Windows.Forms.Label
    Friend WithEvents btn_StrtOver As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents btn_newGame As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents grp_Mode As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Easy As Wheel_of_Hangman.BaWGUIRadioButton
    Friend WithEvents lbl_SubjectInfo As System.Windows.Forms.Label
    Friend WithEvents lbl_Subject As System.Windows.Forms.Label
    Friend WithEvents lbl_Word As System.Windows.Forms.Label
    Friend WithEvents pic_Attention As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Letters As System.Windows.Forms.Label
    Friend WithEvents btn_Lose As Wheel_of_Hangman.BaWGUIButton
    Friend WithEvents lbl_Score As System.Windows.Forms.Label
    Friend WithEvents lbl_ScoreInfo As System.Windows.Forms.Label
    Friend WithEvents lbl_Wrong As System.Windows.Forms.Label
    Friend WithEvents lbl_WrongInfo As System.Windows.Forms.Label
    Friend WithEvents txt_Missed As Wheel_of_Hangman.BaWGUITextBox
    Friend WithEvents lbl_Guess As System.Windows.Forms.Label
    Friend WithEvents lbl_GuessInfo As System.Windows.Forms.Label
    Friend WithEvents tmr_Update As System.Windows.Forms.Timer
    Friend WithEvents rdo_Hard As Wheel_of_Hangman.BaWGUIRadioButton
    Friend WithEvents rdo_Medium As Wheel_of_Hangman.BaWGUIRadioButton
    Friend WithEvents pnl_Main As System.Windows.Forms.Panel
    Friend WithEvents lbl_Length As System.Windows.Forms.Label
    Friend WithEvents lbl_LenInfo As System.Windows.Forms.Label

End Class
