<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Instructions))
        Me.thm_Instructions = New Casino_Craps_Practice_Edition.ElegantThemeContainer()
        Me.btn_Next = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.pic_Start = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New Casino_Craps_Practice_Edition.ElegantThemeButton()
        Me.txt_One = New System.Windows.Forms.TextBox()
        Me.pic_One = New System.Windows.Forms.PictureBox()
        Me.grp_Instructions = New Casino_Craps_Practice_Edition.ElegantThemeTitledListBox()
        Me.thm_Instructions.SuspendLayout()
        CType(Me.pic_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_One, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'thm_Instructions
        '
        Me.thm_Instructions.AllowClose = True
        Me.thm_Instructions.AllowMaximize = True
        Me.thm_Instructions.AllowMinimize = True
        Me.thm_Instructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Instructions.BaseColour = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.thm_Instructions.BorderColour = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.thm_Instructions.ControlBaseColour = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.thm_Instructions.ControlBoxButtonSplitColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.thm_Instructions.ControlBoxColour = System.Drawing.Color.DodgerBlue
        Me.thm_Instructions.Controls.Add(Me.btn_Next)
        Me.thm_Instructions.Controls.Add(Me.pic_Start)
        Me.thm_Instructions.Controls.Add(Me.btn_Back)
        Me.thm_Instructions.Controls.Add(Me.txt_One)
        Me.thm_Instructions.Controls.Add(Me.pic_One)
        Me.thm_Instructions.Controls.Add(Me.grp_Instructions)
        Me.thm_Instructions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Instructions.IconColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.thm_Instructions.Location = New System.Drawing.Point(0, 0)
        Me.thm_Instructions.Name = "thm_Instructions"
        Me.thm_Instructions.Size = New System.Drawing.Size(983, 437)
        Me.thm_Instructions.TabIndex = 0
        Me.thm_Instructions.Text = "Casino Craps Instructions"
        Me.thm_Instructions.TopStripBorderColour = System.Drawing.Color.DodgerBlue
        Me.thm_Instructions.TopStripColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Transparent
        Me.btn_Next.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Next.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Next.Location = New System.Drawing.Point(511, 392)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Next.Size = New System.Drawing.Size(180, 34)
        Me.btn_Next.TabIndex = 27
        Me.btn_Next.Text = "Next"
        Me.btn_Next.TextColour = System.Drawing.Color.Firebrick
        '
        'pic_Start
        '
        Me.pic_Start.BackColor = System.Drawing.Color.Transparent
        Me.pic_Start.Image = CType(resources.GetObject("pic_Start.Image"), System.Drawing.Image)
        Me.pic_Start.Location = New System.Drawing.Point(49, 73)
        Me.pic_Start.Name = "pic_Start"
        Me.pic_Start.Size = New System.Drawing.Size(456, 313)
        Me.pic_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Start.TabIndex = 26
        Me.pic_Start.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Back.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(311, 391)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Back.Size = New System.Drawing.Size(194, 34)
        Me.btn_Back.TabIndex = 25
        Me.btn_Back.Text = "Back"
        Me.btn_Back.TextColour = System.Drawing.Color.DeepSkyBlue
        '
        'txt_One
        '
        Me.txt_One.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_One.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_One.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txt_One.ForeColor = System.Drawing.Color.White
        Me.txt_One.Location = New System.Drawing.Point(511, 73)
        Me.txt_One.Multiline = True
        Me.txt_One.Name = "txt_One"
        Me.txt_One.ReadOnly = True
        Me.txt_One.Size = New System.Drawing.Size(460, 313)
        Me.txt_One.TabIndex = 24
        Me.txt_One.Text = resources.GetString("txt_One.Text")
        '
        'pic_One
        '
        Me.pic_One.BackColor = System.Drawing.Color.Transparent
        Me.pic_One.Image = CType(resources.GetObject("pic_One.Image"), System.Drawing.Image)
        Me.pic_One.Location = New System.Drawing.Point(3, 73)
        Me.pic_One.Name = "pic_One"
        Me.pic_One.Size = New System.Drawing.Size(40, 34)
        Me.pic_One.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_One.TabIndex = 19
        Me.pic_One.TabStop = False
        '
        'grp_Instructions
        '
        Me.grp_Instructions.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grp_Instructions.BorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.grp_Instructions.Items = New String() {""}
        Me.grp_Instructions.Location = New System.Drawing.Point(3, 43)
        Me.grp_Instructions.MaximumSize = New System.Drawing.Size(977, 391)
        Me.grp_Instructions.MinimumSize = New System.Drawing.Size(977, 391)
        Me.grp_Instructions.Name = "grp_Instructions"
        Me.grp_Instructions.SelectedColour = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grp_Instructions.Size = New System.Drawing.Size(977, 391)
        Me.grp_Instructions.TabIndex = 20
        Me.grp_Instructions.Text = "                                                                                 " & _
    "                              Basic Craps Rule"
        Me.grp_Instructions.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.grp_Instructions.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'frm_Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 437)
        Me.Controls.Add(Me.thm_Instructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(983, 437)
        Me.MinimumSize = New System.Drawing.Size(983, 437)
        Me.Name = "frm_Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Instructions.ResumeLayout(False)
        Me.thm_Instructions.PerformLayout()
        CType(Me.pic_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_One, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Instructions As Casino_Craps_Practice_Edition.ElegantThemeContainer
    Friend WithEvents pic_One As System.Windows.Forms.PictureBox
    Friend WithEvents grp_Instructions As Casino_Craps_Practice_Edition.ElegantThemeTitledListBox
    Friend WithEvents txt_One As System.Windows.Forms.TextBox
    Friend WithEvents btn_Back As Casino_Craps_Practice_Edition.ElegantThemeButton
    Friend WithEvents pic_Start As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As Casino_Craps_Practice_Edition.ElegantThemeButton
End Class
