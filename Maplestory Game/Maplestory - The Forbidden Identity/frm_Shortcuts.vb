'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Shortcuts
    Private Sub frm_Shortcuts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Changing the in-game cursor on form load
        Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
    End Sub

    Private Sub btn_CtrlBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CtrlBox.Click
        'Unpausing the game when player decides to close the Quest form
        pauseCounter = 2
    End Sub
End Class