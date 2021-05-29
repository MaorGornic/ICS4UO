<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Shortcuts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Shortcuts))
        Me.btn_CtrlBox = New Maplestory___The_Forbidden_Identity.RedemptionControlBox()
        Me.SuspendLayout()
        '
        'btn_CtrlBox
        '
        Me.btn_CtrlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CtrlBox.BackColor = System.Drawing.Color.Transparent
        Me.btn_CtrlBox.ForeColor = System.Drawing.Color.White
        Me.btn_CtrlBox.Location = New System.Drawing.Point(415, 3)
        Me.btn_CtrlBox.Name = "btn_CtrlBox"
        Me.btn_CtrlBox.Size = New System.Drawing.Size(60, 25)
        Me.btn_CtrlBox.TabIndex = 0
        Me.btn_CtrlBox.Text = "RedemptionControlBox1"
        '
        'frm_Shortcuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(478, 213)
        Me.Controls.Add(Me.btn_CtrlBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(478, 213)
        Me.MinimumSize = New System.Drawing.Size(478, 213)
        Me.Name = "frm_Shortcuts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Shortcuts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_CtrlBox As Maplestory___The_Forbidden_Identity.RedemptionControlBox
End Class
