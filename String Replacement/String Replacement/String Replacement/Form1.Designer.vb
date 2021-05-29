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
        Me.ofd_File = New System.Windows.Forms.OpenFileDialog()
        Me.thm_Main = New String_Replacement.SugarTheme()
        Me.btn_Close = New String_Replacement.SugarButton()
        Me.tab_StringManipulation = New String_Replacement.SugarTabControl()
        Me.tab_Main = New System.Windows.Forms.TabPage()
        Me.lbl_Result = New System.Windows.Forms.Label()
        Me.btn_Load = New String_Replacement.SugarButton()
        Me.btn_Save = New String_Replacement.SugarButton()
        Me.grp_Manipulation = New System.Windows.Forms.GroupBox()
        Me.rdo_Case = New String_Replacement.SugarRadiobutton()
        Me.rdo_VowelsReplace = New String_Replacement.SugarRadiobutton()
        Me.rdo_Vowels = New String_Replacement.SugarRadiobutton()
        Me.rdo_Space = New String_Replacement.SugarRadiobutton()
        Me.rdo_Reverse = New String_Replacement.SugarRadiobutton()
        Me.btn_Apply = New String_Replacement.SugarButton()
        Me.lbl_Text = New System.Windows.Forms.Label()
        Me.txt_Input = New String_Replacement.SugarTextBox()
        Me.pnl_Main = New System.Windows.Forms.Panel()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.thm_Main.SuspendLayout()
        Me.tab_StringManipulation.SuspendLayout()
        Me.tab_Main.SuspendLayout()
        Me.grp_Manipulation.SuspendLayout()
        Me.pnl_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd_File
        '
        Me.ofd_File.FileName = "OpenFileDialog1"
        '
        'thm_Main
        '
        Me.thm_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.thm_Main.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.thm_Main.Controls.Add(Me.btn_Close)
        Me.thm_Main.Controls.Add(Me.tab_StringManipulation)
        Me.thm_Main.Customization = "2dK+/zAzMf8="
        Me.thm_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thm_Main.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.thm_Main.Image = Nothing
        Me.thm_Main.Location = New System.Drawing.Point(0, 0)
        Me.thm_Main.Movable = True
        Me.thm_Main.Name = "thm_Main"
        Me.thm_Main.NoRounding = False
        Me.thm_Main.Sizable = True
        Me.thm_Main.Size = New System.Drawing.Size(620, 309)
        Me.thm_Main.SmartBounds = True
        Me.thm_Main.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.thm_Main.TabIndex = 0
        Me.thm_Main.Text = "String Replacement"
        Me.thm_Main.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Main.Transparent = False
        '
        'btn_Close
        '
        Me.btn_Close.Customization = "6+jc/zAzMf//////"
        Me.btn_Close.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Close.Image = Nothing
        Me.btn_Close.Location = New System.Drawing.Point(585, 10)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.NoRounding = False
        Me.btn_Close.Size = New System.Drawing.Size(22, 19)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "X"
        Me.btn_Close.Transparent = False
        '
        'tab_StringManipulation
        '
        Me.tab_StringManipulation.Controls.Add(Me.tab_Main)
        Me.tab_StringManipulation.Location = New System.Drawing.Point(11, 40)
        Me.tab_StringManipulation.Name = "tab_StringManipulation"
        Me.tab_StringManipulation.SelectedIndex = 0
        Me.tab_StringManipulation.Size = New System.Drawing.Size(597, 257)
        Me.tab_StringManipulation.TabIndex = 0
        '
        'tab_Main
        '
        Me.tab_Main.Controls.Add(Me.lbl_Result)
        Me.tab_Main.Controls.Add(Me.btn_Load)
        Me.tab_Main.Controls.Add(Me.btn_Save)
        Me.tab_Main.Controls.Add(Me.grp_Manipulation)
        Me.tab_Main.Controls.Add(Me.btn_Apply)
        Me.tab_Main.Controls.Add(Me.lbl_Text)
        Me.tab_Main.Controls.Add(Me.txt_Input)
        Me.tab_Main.Controls.Add(Me.pnl_Main)
        Me.tab_Main.Location = New System.Drawing.Point(4, 25)
        Me.tab_Main.Name = "tab_Main"
        Me.tab_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Main.Size = New System.Drawing.Size(589, 228)
        Me.tab_Main.TabIndex = 0
        Me.tab_Main.Text = "Main"
        Me.tab_Main.UseVisualStyleBackColor = True
        '
        'lbl_Result
        '
        Me.lbl_Result.AutoSize = True
        Me.lbl_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Result.Location = New System.Drawing.Point(157, 153)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Result.TabIndex = 19
        Me.lbl_Result.Text = "Result:"
        '
        'btn_Load
        '
        Me.btn_Load.Customization = "6+jc/zAzMf//////"
        Me.btn_Load.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btn_Load.Image = Nothing
        Me.btn_Load.Location = New System.Drawing.Point(502, 54)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.NoRounding = False
        Me.btn_Load.Size = New System.Drawing.Size(81, 94)
        Me.btn_Load.TabIndex = 17
        Me.btn_Load.Text = "Load"
        Me.btn_Load.Transparent = False
        '
        'btn_Save
        '
        Me.btn_Save.Customization = "6+jc/zAzMf//////"
        Me.btn_Save.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btn_Save.Image = Nothing
        Me.btn_Save.Location = New System.Drawing.Point(435, 54)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.NoRounding = False
        Me.btn_Save.Size = New System.Drawing.Size(61, 94)
        Me.btn_Save.TabIndex = 10
        Me.btn_Save.Text = "Save"
        Me.btn_Save.Transparent = False
        '
        'grp_Manipulation
        '
        Me.grp_Manipulation.Controls.Add(Me.rdo_Case)
        Me.grp_Manipulation.Controls.Add(Me.rdo_VowelsReplace)
        Me.grp_Manipulation.Controls.Add(Me.rdo_Vowels)
        Me.grp_Manipulation.Controls.Add(Me.rdo_Space)
        Me.grp_Manipulation.Controls.Add(Me.rdo_Reverse)
        Me.grp_Manipulation.Location = New System.Drawing.Point(10, 54)
        Me.grp_Manipulation.Name = "grp_Manipulation"
        Me.grp_Manipulation.Size = New System.Drawing.Size(141, 169)
        Me.grp_Manipulation.TabIndex = 8
        Me.grp_Manipulation.TabStop = False
        Me.grp_Manipulation.Text = "Manipulation"
        '
        'rdo_Case
        '
        Me.rdo_Case.Checked = False
        Me.rdo_Case.Colors = New String_Replacement.Bloom(-1) {}
        Me.rdo_Case.Customization = ""
        Me.rdo_Case.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rdo_Case.Image = Nothing
        Me.rdo_Case.Location = New System.Drawing.Point(6, 145)
        Me.rdo_Case.Name = "rdo_Case"
        Me.rdo_Case.NoRounding = False
        Me.rdo_Case.Size = New System.Drawing.Size(105, 14)
        Me.rdo_Case.TabIndex = 6
        Me.rdo_Case.Text = "Case Reversed"
        Me.rdo_Case.Transparent = False
        '
        'rdo_VowelsReplace
        '
        Me.rdo_VowelsReplace.Checked = False
        Me.rdo_VowelsReplace.Colors = New String_Replacement.Bloom(-1) {}
        Me.rdo_VowelsReplace.Customization = ""
        Me.rdo_VowelsReplace.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rdo_VowelsReplace.Image = Nothing
        Me.rdo_VowelsReplace.Location = New System.Drawing.Point(6, 115)
        Me.rdo_VowelsReplace.Name = "rdo_VowelsReplace"
        Me.rdo_VowelsReplace.NoRounding = False
        Me.rdo_VowelsReplace.Size = New System.Drawing.Size(116, 14)
        Me.rdo_VowelsReplace.TabIndex = 5
        Me.rdo_VowelsReplace.Text = "Vowels Replaced"
        Me.rdo_VowelsReplace.Transparent = False
        '
        'rdo_Vowels
        '
        Me.rdo_Vowels.Checked = False
        Me.rdo_Vowels.Colors = New String_Replacement.Bloom(-1) {}
        Me.rdo_Vowels.Customization = ""
        Me.rdo_Vowels.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rdo_Vowels.Image = Nothing
        Me.rdo_Vowels.Location = New System.Drawing.Point(6, 85)
        Me.rdo_Vowels.Name = "rdo_Vowels"
        Me.rdo_Vowels.NoRounding = False
        Me.rdo_Vowels.Size = New System.Drawing.Size(117, 14)
        Me.rdo_Vowels.TabIndex = 4
        Me.rdo_Vowels.Text = "Vowels Removed"
        Me.rdo_Vowels.Transparent = False
        '
        'rdo_Space
        '
        Me.rdo_Space.Checked = False
        Me.rdo_Space.Colors = New String_Replacement.Bloom(-1) {}
        Me.rdo_Space.Customization = ""
        Me.rdo_Space.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rdo_Space.Image = Nothing
        Me.rdo_Space.Location = New System.Drawing.Point(6, 58)
        Me.rdo_Space.Name = "rdo_Space"
        Me.rdo_Space.NoRounding = False
        Me.rdo_Space.Size = New System.Drawing.Size(112, 14)
        Me.rdo_Space.TabIndex = 3
        Me.rdo_Space.Text = "Space Removed"
        Me.rdo_Space.Transparent = False
        '
        'rdo_Reverse
        '
        Me.rdo_Reverse.Checked = True
        Me.rdo_Reverse.Colors = New String_Replacement.Bloom(-1) {}
        Me.rdo_Reverse.Customization = ""
        Me.rdo_Reverse.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rdo_Reverse.Image = Nothing
        Me.rdo_Reverse.Location = New System.Drawing.Point(6, 29)
        Me.rdo_Reverse.Name = "rdo_Reverse"
        Me.rdo_Reverse.NoRounding = False
        Me.rdo_Reverse.Size = New System.Drawing.Size(105, 14)
        Me.rdo_Reverse.TabIndex = 2
        Me.rdo_Reverse.Text = "String Reverse"
        Me.rdo_Reverse.Transparent = False
        '
        'btn_Apply
        '
        Me.btn_Apply.Customization = "6+jc/zAzMf//////"
        Me.btn_Apply.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btn_Apply.Image = Nothing
        Me.btn_Apply.Location = New System.Drawing.Point(157, 54)
        Me.btn_Apply.Name = "btn_Apply"
        Me.btn_Apply.NoRounding = False
        Me.btn_Apply.Size = New System.Drawing.Size(272, 94)
        Me.btn_Apply.TabIndex = 7
        Me.btn_Apply.Text = "Apply Changes"
        Me.btn_Apply.Transparent = False
        '
        'lbl_Text
        '
        Me.lbl_Text.AutoSize = True
        Me.lbl_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_Text.Location = New System.Drawing.Point(6, 15)
        Me.lbl_Text.Name = "lbl_Text"
        Me.lbl_Text.Size = New System.Drawing.Size(43, 20)
        Me.lbl_Text.TabIndex = 1
        Me.lbl_Text.Text = "Text:"
        '
        'txt_Input
        '
        Me.txt_Input.Customization = "AAAA/+vo3P///////////w=="
        Me.txt_Input.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.txt_Input.Image = Nothing
        Me.txt_Input.Location = New System.Drawing.Point(52, 6)
        Me.txt_Input.MaxLength = 32767
        Me.txt_Input.Multiline = True
        Me.txt_Input.Name = "txt_Input"
        Me.txt_Input.NoRounding = False
        Me.txt_Input.ReadOnly = False
        Me.txt_Input.Size = New System.Drawing.Size(531, 39)
        Me.txt_Input.TabIndex = 0
        Me.txt_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Input.Transparent = False
        Me.txt_Input.UseSystemPasswordChar = False
        '
        'pnl_Main
        '
        Me.pnl_Main.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_Main.Controls.Add(Me.lbl_Output)
        Me.pnl_Main.Location = New System.Drawing.Point(158, 169)
        Me.pnl_Main.Name = "pnl_Main"
        Me.pnl_Main.Size = New System.Drawing.Size(425, 53)
        Me.pnl_Main.TabIndex = 18
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_Output.Location = New System.Drawing.Point(3, 13)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(0, 31)
        Me.lbl_Output.TabIndex = 9
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 309)
        Me.Controls.Add(Me.thm_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Replacement"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.thm_Main.ResumeLayout(False)
        Me.tab_StringManipulation.ResumeLayout(False)
        Me.tab_Main.ResumeLayout(False)
        Me.tab_Main.PerformLayout()
        Me.grp_Manipulation.ResumeLayout(False)
        Me.pnl_Main.ResumeLayout(False)
        Me.pnl_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents thm_Main As String_Replacement.SugarTheme
    Friend WithEvents tab_StringManipulation As String_Replacement.SugarTabControl
    Friend WithEvents tab_Main As System.Windows.Forms.TabPage
    Friend WithEvents txt_Input As String_Replacement.SugarTextBox
    Friend WithEvents lbl_Text As System.Windows.Forms.Label
    Friend WithEvents btn_Apply As String_Replacement.SugarButton
    Friend WithEvents rdo_Reverse As String_Replacement.SugarRadiobutton
    Friend WithEvents grp_Manipulation As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Case As String_Replacement.SugarRadiobutton
    Friend WithEvents rdo_VowelsReplace As String_Replacement.SugarRadiobutton
    Friend WithEvents rdo_Vowels As String_Replacement.SugarRadiobutton
    Friend WithEvents rdo_Space As String_Replacement.SugarRadiobutton
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents btn_Save As String_Replacement.SugarButton
    Friend WithEvents ofd_File As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_Close As String_Replacement.SugarButton
    Friend WithEvents btn_Load As String_Replacement.SugarButton
    Friend WithEvents pnl_Main As System.Windows.Forms.Panel
    Friend WithEvents lbl_Result As System.Windows.Forms.Label

End Class
