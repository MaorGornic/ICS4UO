<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Tutorial))
        Me.thm_Tutorial = New Hi___Low_Guessing_Game.SLCTheme()
        Me.btn_Begin = New Hi___Low_Guessing_Game.SLCbtn()
        Me.SlcGroupBox1 = New Hi___Low_Guessing_Game.SLCGroupBox()
        Me.SlcLabel5 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.SlcLabel4 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.SlcLabel3 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.SlcLabel2 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.rdo_CvC = New Hi___Low_Guessing_Game.SLCRadionButton()
        Me.rdo_CvH = New Hi___Low_Guessing_Game.SLCRadionButton()
        Me.rdo_HvC = New Hi___Low_Guessing_Game.SLCRadionButton()
        Me.rdo_HvH = New Hi___Low_Guessing_Game.SLCRadionButton()
        Me.SlcLabel1 = New Hi___Low_Guessing_Game.SLCLabel()
        Me.lbl_Tutorial = New Hi___Low_Guessing_Game.SLCLabel()
        Me.thm_Tutorial.SuspendLayout()
        Me.SlcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'thm_Tutorial
        '
        Me.thm_Tutorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.thm_Tutorial.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_Tutorial.Controls.Add(Me.btn_Begin)
        Me.thm_Tutorial.Controls.Add(Me.SlcGroupBox1)
        Me.thm_Tutorial.Controls.Add(Me.lbl_Tutorial)
        Me.thm_Tutorial.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.thm_Tutorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Tutorial.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.thm_Tutorial.Image = Nothing
        Me.thm_Tutorial.Location = New System.Drawing.Point(0, 0)
        Me.thm_Tutorial.Movable = True
        Me.thm_Tutorial.Name = "thm_Tutorial"
        Me.thm_Tutorial.NoRounding = False
        Me.thm_Tutorial.Sizable = True
        Me.thm_Tutorial.Size = New System.Drawing.Size(621, 353)
        Me.thm_Tutorial.SmartBounds = True
        Me.thm_Tutorial.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_Tutorial.TabIndex = 0
        Me.thm_Tutorial.Text = "Guess What"
        Me.thm_Tutorial.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Tutorial.Transparent = False
        '
        'btn_Begin
        '
        Me.btn_Begin.Colors = New Hi___Low_Guessing_Game.Bloom(-1) {}
        Me.btn_Begin.Customization = ""
        Me.btn_Begin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Begin.Image = Nothing
        Me.btn_Begin.Location = New System.Drawing.Point(267, 308)
        Me.btn_Begin.Name = "btn_Begin"
        Me.btn_Begin.NoRounding = False
        Me.btn_Begin.Size = New System.Drawing.Size(82, 25)
        Me.btn_Begin.TabIndex = 11
        Me.btn_Begin.Text = "Got it"
        Me.btn_Begin.Transparent = False
        '
        'SlcGroupBox1
        '
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel5)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel4)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel3)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel2)
        Me.SlcGroupBox1.Controls.Add(Me.rdo_CvC)
        Me.SlcGroupBox1.Controls.Add(Me.rdo_CvH)
        Me.SlcGroupBox1.Controls.Add(Me.rdo_HvC)
        Me.SlcGroupBox1.Controls.Add(Me.rdo_HvH)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel1)
        Me.SlcGroupBox1.DrawSeperator = False
        Me.SlcGroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.SlcGroupBox1.Name = "SlcGroupBox1"
        Me.SlcGroupBox1.Size = New System.Drawing.Size(596, 189)
        Me.SlcGroupBox1.SubTitle = "Tutorial"
        Me.SlcGroupBox1.TabIndex = 10
        Me.SlcGroupBox1.Text = "How To Play"
        Me.SlcGroupBox1.Title = "How To Play"
        '
        'SlcLabel5
        '
        Me.SlcLabel5.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.SlcLabel5.Location = New System.Drawing.Point(164, 160)
        Me.SlcLabel5.Name = "SlcLabel5"
        Me.SlcLabel5.Size = New System.Drawing.Size(401, 19)
        Me.SlcLabel5.TabIndex = 11
        Me.SlcLabel5.Text = "<-- Computer thinks of a number and the computer has to guess it."
        '
        'SlcLabel4
        '
        Me.SlcLabel4.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.SlcLabel4.Location = New System.Drawing.Point(151, 132)
        Me.SlcLabel4.Name = "SlcLabel4"
        Me.SlcLabel4.Size = New System.Drawing.Size(401, 19)
        Me.SlcLabel4.TabIndex = 10
        Me.SlcLabel4.Text = "<-- Player thinks of a number and the computer has to guess it."
        '
        'SlcLabel3
        '
        Me.SlcLabel3.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.SlcLabel3.Location = New System.Drawing.Point(151, 101)
        Me.SlcLabel3.Name = "SlcLabel3"
        Me.SlcLabel3.Size = New System.Drawing.Size(401, 19)
        Me.SlcLabel3.TabIndex = 9
        Me.SlcLabel3.Text = "<-- Computer thinks of a number and the player has to guess it."
        '
        'SlcLabel2
        '
        Me.SlcLabel2.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.SlcLabel2.Location = New System.Drawing.Point(137, 71)
        Me.SlcLabel2.Name = "SlcLabel2"
        Me.SlcLabel2.Size = New System.Drawing.Size(401, 19)
        Me.SlcLabel2.TabIndex = 8
        Me.SlcLabel2.Text = "<-- Player one enters a number that player two has to guess."
        '
        'rdo_CvC
        '
        Me.rdo_CvC.BackColor = System.Drawing.Color.White
        Me.rdo_CvC.Checked = False
        Me.rdo_CvC.Location = New System.Drawing.Point(3, 154)
        Me.rdo_CvC.Name = "rdo_CvC"
        Me.rdo_CvC.Size = New System.Drawing.Size(167, 24)
        Me.rdo_CvC.TabIndex = 7
        Me.rdo_CvC.Text = "Computer Vs Computer"
        '
        'rdo_CvH
        '
        Me.rdo_CvH.BackColor = System.Drawing.Color.White
        Me.rdo_CvH.Checked = False
        Me.rdo_CvH.Location = New System.Drawing.Point(3, 124)
        Me.rdo_CvH.Name = "rdo_CvH"
        Me.rdo_CvH.Size = New System.Drawing.Size(191, 24)
        Me.rdo_CvH.TabIndex = 6
        Me.rdo_CvH.Text = "Computer Vs. Human"
        '
        'rdo_HvC
        '
        Me.rdo_HvC.BackColor = System.Drawing.Color.White
        Me.rdo_HvC.Checked = False
        Me.rdo_HvC.Location = New System.Drawing.Point(3, 94)
        Me.rdo_HvC.Name = "rdo_HvC"
        Me.rdo_HvC.Size = New System.Drawing.Size(191, 24)
        Me.rdo_HvC.TabIndex = 5
        Me.rdo_HvC.Text = "Human Vs. Computer"
        '
        'rdo_HvH
        '
        Me.rdo_HvH.BackColor = System.Drawing.Color.White
        Me.rdo_HvH.Checked = False
        Me.rdo_HvH.Location = New System.Drawing.Point(3, 64)
        Me.rdo_HvH.Name = "rdo_HvH"
        Me.rdo_HvH.Size = New System.Drawing.Size(191, 24)
        Me.rdo_HvH.TabIndex = 4
        Me.rdo_HvH.Text = "Human vs. Human"
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcLabel1.Location = New System.Drawing.Point(3, 40)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(574, 23)
        Me.SlcLabel1.TabIndex = 0
        Me.SlcLabel1.Text = "After starting the game, you may pick one of the following game modes:"
        '
        'lbl_Tutorial
        '
        Me.lbl_Tutorial.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tutorial.Location = New System.Drawing.Point(149, 68)
        Me.lbl_Tutorial.Name = "lbl_Tutorial"
        Me.lbl_Tutorial.Size = New System.Drawing.Size(338, 39)
        Me.lbl_Tutorial.TabIndex = 9
        Me.lbl_Tutorial.Text = "The Guessing Game"
        '
        'frm_Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 353)
        Me.Controls.Add(Me.thm_Tutorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Tutorial"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Tutorial.ResumeLayout(False)
        Me.SlcGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Tutorial As Hi___Low_Guessing_Game.SLCTheme
    Friend WithEvents btn_Begin As Hi___Low_Guessing_Game.SLCbtn
    Friend WithEvents SlcGroupBox1 As Hi___Low_Guessing_Game.SLCGroupBox
    Friend WithEvents SlcLabel5 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents SlcLabel4 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents SlcLabel3 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents SlcLabel2 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents rdo_CvC As Hi___Low_Guessing_Game.SLCRadionButton
    Friend WithEvents rdo_CvH As Hi___Low_Guessing_Game.SLCRadionButton
    Friend WithEvents rdo_HvC As Hi___Low_Guessing_Game.SLCRadionButton
    Friend WithEvents rdo_HvH As Hi___Low_Guessing_Game.SLCRadionButton
    Friend WithEvents SlcLabel1 As Hi___Low_Guessing_Game.SLCLabel
    Friend WithEvents lbl_Tutorial As Hi___Low_Guessing_Game.SLCLabel
End Class
