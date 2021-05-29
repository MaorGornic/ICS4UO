'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Settings
    Dim soundCounter As Integer 'A variable used to determine wheter the player wants to mute the game or not

    Private Sub frm_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Changing the in-game cursor on form load
        Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
    End Sub

    Private Sub btn_CtrlBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Unpausing the game when player decides to close the form
        pauseCounter = 2
    End Sub

    'Setting up a function that will allow the player to mute the game when wished
    Sub muteSound()
        If soundCounter = 1 Then
            isMuted = True
            frm_Ellinia.snd_Ellinia.URL = ""
            tgl_Sound.Checked = False
            pic_Sound.Image = Image.FromFile(Environment.CurrentDirectory + "/pictures/img_SoundOff.png")
        Else
            soundCounter = 0
            isMuted = False
            frm_Ellinia.snd_Ellinia.URL = Environment.CurrentDirectory + "\soundtracks\Maplestory Ellinia.mp3"
            tgl_Sound.Checked = True
            pic_Sound.Image = Image.FromFile(Environment.CurrentDirectory + "/pictures/img_SoundOn.png")
        End If
    End Sub

    Private Sub pic_Sound_Click(sender As Object, e As EventArgs) Handles pic_Sound.Click
        'Calling the muteSound function to mute the game
        soundCounter += 1
        muteSound()
    End Sub

    Private Sub tgl_Sound_CheckedChanged(sender As Object) Handles tgl_Sound.CheckedChanged
        'Calling the muteSound function to mute the game when checked
        soundCounter += 1
        muteSound()
    End Sub

    Private Sub pic_Close_Click(sender As Object, e As EventArgs) Handles pic_Close.Click
        'Unpausing the game when player decides to close the Quest form
        pauseCounter = 2
        Me.Hide()
    End Sub

    Private Sub btn_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        'Confirming if the player really wishes to wipe all of his in-game savings
        If MessageBox.Show("Are you sure to proceed? You will be logged off!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            EXP = 0
            Level = 10
            frm_Login.txt_ID.Text = "ID"
            frm_Login.txt_ID.Text = "Password"
            frm_Login.txt_ID.Focus()
            Application.Restart()
        End If
    End Sub

    Private Sub pic_LogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_LogOff.Click
        'Confirming if the player really wishes to log out of the game
        If MessageBox.Show("Do you wish to log out?", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Application.Restart()
        End If
    End Sub
End Class