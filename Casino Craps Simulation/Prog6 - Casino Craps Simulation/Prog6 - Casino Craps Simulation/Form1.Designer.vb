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
        Me.lbl_Dice1 = New System.Windows.Forms.Label()
        Me.lbl_Dice2 = New System.Windows.Forms.Label()
        Me.lbl_Result = New System.Windows.Forms.Label()
        Me.btn_Roll = New System.Windows.Forms.Button()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Roll = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Dice1
        '
        Me.lbl_Dice1.AutoSize = True
        Me.lbl_Dice1.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Dice1.Name = "lbl_Dice1"
        Me.lbl_Dice1.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Dice1.TabIndex = 0
        Me.lbl_Dice1.Text = "Dice 1: "
        '
        'lbl_Dice2
        '
        Me.lbl_Dice2.AutoSize = True
        Me.lbl_Dice2.Location = New System.Drawing.Point(114, 20)
        Me.lbl_Dice2.Name = "lbl_Dice2"
        Me.lbl_Dice2.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Dice2.TabIndex = 1
        Me.lbl_Dice2.Text = "Dice 2:"
        '
        'lbl_Result
        '
        Me.lbl_Result.AutoSize = True
        Me.lbl_Result.Location = New System.Drawing.Point(211, 20)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Result.TabIndex = 2
        Me.lbl_Result.Text = "Total is:"
        '
        'btn_Roll
        '
        Me.btn_Roll.Location = New System.Drawing.Point(52, 58)
        Me.btn_Roll.Name = "btn_Roll"
        Me.btn_Roll.Size = New System.Drawing.Size(179, 58)
        Me.btn_Roll.TabIndex = 3
        Me.btn_Roll.Text = "Roll Dice"
        Me.btn_Roll.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(100, 168)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Status.TabIndex = 4
        Me.lbl_Status.Text = "You: "
        '
        'lbl_Roll
        '
        Me.lbl_Roll.AutoSize = True
        Me.lbl_Roll.ForeColor = System.Drawing.Color.Red
        Me.lbl_Roll.Location = New System.Drawing.Point(100, 240)
        Me.lbl_Roll.Name = "lbl_Roll"
        Me.lbl_Roll.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Roll.TabIndex = 5
        Me.lbl_Roll.Text = "Roll: "
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_Roll)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.btn_Roll)
        Me.Controls.Add(Me.lbl_Result)
        Me.Controls.Add(Me.lbl_Dice2)
        Me.Controls.Add(Me.lbl_Dice1)
        Me.Name = "frm_Main"
        Me.Text = "Casino Craps Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Dice1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Dice2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Result As System.Windows.Forms.Label
    Friend WithEvents btn_Roll As System.Windows.Forms.Button
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_Roll As System.Windows.Forms.Label

End Class
