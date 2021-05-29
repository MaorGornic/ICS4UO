<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Chat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Chat))
        Me.lbl_Agree = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.lbl_Cancel = New Maplestory___The_Forbidden_Identity.FlatLabel()
        Me.SuspendLayout()
        '
        'lbl_Agree
        '
        Me.lbl_Agree.AutoSize = True
        Me.lbl_Agree.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Agree.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_Agree.ForeColor = System.Drawing.Color.White
        Me.lbl_Agree.Location = New System.Drawing.Point(434, 122)
        Me.lbl_Agree.Name = "lbl_Agree"
        Me.lbl_Agree.Size = New System.Drawing.Size(22, 13)
        Me.lbl_Agree.TabIndex = 0
        Me.lbl_Agree.Text = "OK"
        '
        'lbl_Cancel
        '
        Me.lbl_Cancel.AutoSize = True
        Me.lbl_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cancel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_Cancel.ForeColor = System.Drawing.Color.White
        Me.lbl_Cancel.Location = New System.Drawing.Point(16, 170)
        Me.lbl_Cancel.Name = "lbl_Cancel"
        Me.lbl_Cancel.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Cancel.TabIndex = 1
        Me.lbl_Cancel.Text = "END CHAT"
        '
        'frm_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(493, 190)
        Me.Controls.Add(Me.lbl_Cancel)
        Me.Controls.Add(Me.lbl_Agree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Agree As Maplestory___The_Forbidden_Identity.FlatLabel
    Friend WithEvents lbl_Cancel As Maplestory___The_Forbidden_Identity.FlatLabel
End Class
