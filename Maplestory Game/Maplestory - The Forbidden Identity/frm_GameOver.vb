'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_GameOver
    Private Sub btn_LogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LogOff.Click
        'Loggs Player out of the game
        If MessageBox.Show("Do you really wish to log out?", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Application.Restart()
        End If
    End Sub

    Private Sub frm_GameOver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Changing the in-game cursor on form load
        Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
    End Sub

    Private Sub btn_Respawn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Respawn.Click
        'Determining whether the player wishes to continue playing, if so, respawns the player and closing the current form
        frm_Ellinia.prg_HP.Value = 100
        pauseCounter = 2
        If frm_Ellinia.prg_EXP.Value >= 10 Then frm_Ellinia.prg_EXP.Value -= 10
        If isMuted <> True Then frm_Ellinia.snd_Ellinia.URL = Environment.CurrentDirectory + "\soundtracks\Maplestory Ellinia.mp3"
        Me.Hide()
    End Sub
End Class