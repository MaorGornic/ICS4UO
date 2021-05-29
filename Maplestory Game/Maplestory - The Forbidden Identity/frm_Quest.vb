'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Quest
    Private Sub ctrlBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CtrlBox.Click
        'Unpausing the game when player decides to close the Quest form
        pauseCounter = 2
    End Sub

    Private Sub btn_Forfeit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Forfeit.Click
        'If quest is accepted, allowing the player to give up on the quest and restart it in the future
        If MessageBox.Show("Are you sure to proceed? You will not be given any EXP!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            If isDeclined = False Then
                isDeclined = True
                killCount = 0
                frm_Ellinia.lbl_Status.Text = "Welcome Back!"
                Me.Visible = False
                pauseCounter = 2
            End If
        End If
    End Sub
End Class