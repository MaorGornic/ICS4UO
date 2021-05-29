'Assignment 5 - Casino Craps
'By: Maor Gornik (ICS3U)
'Date: 26 of April, 2018

Public Class frm_Premium
    Private Sub btn_getNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getNow.Click
        'Opens our 'real' website for the player to download the 'premium' version
        MessageBox.Show("Please be sure to check our premium version at supercasino.com", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim response = MessageBox.Show("Do you want to be redirected to our website?", "Casino Craps Practice Edition 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If response = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://www.supercasino.com")
        End If
    End Sub

    Private Sub btn_nGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nGame.Click
        'When pressed, resets everything and starts a new game
        Me.Hide()
        frm_Craps.Visible = True
        frm_Craps.lbl_Status.FirstLabelText = "New Game!"
        frm_Craps.lbl_Status.Text = "New Game!"
        stats = Enumerable.Repeat(0, 3).ToArray
        money = 1000
        frm_Craps.clear()
    End Sub
End Class