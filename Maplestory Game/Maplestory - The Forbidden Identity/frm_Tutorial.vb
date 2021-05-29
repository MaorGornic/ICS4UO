'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Tutorial
    Private Sub btn_No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_No.Click
        'If the player had already played the game before and has read the tutorial and closing the tutorial
        isRead = True
        Me.Hide()
    End Sub

    Private Sub btn_Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finish.Click
        'Determining whether the player has finished the tutorial, resetting the tutorial and closing the form
        tab_Tutorial.SelectedIndex = 0
        isRead = True

        If ID <> "" And password <> "" Then
            If Len(ID) >= 4 Then
                frm_Login.tmr_Animation.Enabled = True
            Else
                MessageBox.Show("ID must be at least 4 digits long!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If ID <> "" And password <> "" And Len(ID) >= 4 Then
                MessageBox.Show("Incorrect Login!", "Maplestory", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                frm_Login.btn_Login.Focus()
                frm_Login.txt_ID.Text = "ID"
                frm_Login.txt_Password.Text = "Password"
                frm_Login.txt_ID.ForeColor = Color.Red
                frm_Login.txt_Password.ForeColor = Color.Red
            Else
                MessageBox.Show("Please enter your username and password!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Me.Hide()
    End Sub

    Private Sub btn_Yes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Yes.Click
        'Switching to the tutorial if the player chooses to proceed
        tab_Tutorial.SelectedIndex = 1
    End Sub
End Class