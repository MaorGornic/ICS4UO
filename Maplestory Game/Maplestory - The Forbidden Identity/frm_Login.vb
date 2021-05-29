'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Login
    Private Sub frm_Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Changing the in-game cursor on form load and playing some music
        Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
        snd_Intro.URL = Environment.CurrentDirectory + "\soundtracks\Maplestory Theme Music.mp3"
        snd_Intro.settings.setMode("loop", True)
    End Sub

    Private Sub btn_Login_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Login.Click
        'Setting up the player's login panel to access the game
        ID = txt_ID.Text
        password = txt_Password.Text

        'Asking the player if they have already read the tutorial and opening the form based on their response
        If isRead = False And frm_Tutorial.Visible = False Then
            If MessageBox.Show("Is that your first time here?", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                frm_Tutorial.Visible = True
            Else
                isRead = True
                If ID <> "" And password <> "" Then
                    If Len(ID) >= 4 Then
                        tmr_Animation.Enabled = True
                    Else
                        MessageBox.Show("ID must be at least 4 digits long!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("Incorrect Login!", "Maplestory", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    btn_Login.Focus()
                    txt_ID.Text = "ID"
                    txt_Password.Text = "Password"
                    txt_ID.ForeColor = Color.Red
                    txt_Password.ForeColor = Color.Red
                End If
            End If
        Else

            If ID <> "" And password <> "" Then
                If Len(ID) >= 4 Then
                    tmr_Animation.Enabled = True
                Else
                    MessageBox.Show("ID must be at least 4 digits long!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If ID <> "" And password <> "" And Len(ID) >= 4 Then
                    MessageBox.Show("Incorrect Login!", "Maplestory", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    btn_Login.Focus()
                    txt_ID.Text = "ID"
                    txt_Password.Text = "Password"
                    txt_ID.ForeColor = Color.Red
                    txt_Password.ForeColor = Color.Red
                Else
                    MessageBox.Show("Please enter your username and password!", "Maplestory - Forbidden Identitiy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Private Sub tmr_Animation_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmr_Animation.Tick
        'Setting up the log-in animation and opening the game form when animation is completed
        prg_Animation.Increment(200)
        frm_Tutorial.Visible = False
        alrt_Login.Visible = True

        For x = 1 To 100
            If prg_Animation.Value = x Then
                alrt_Login.Left += 1
                If alrt_Login.Left = 202 Then
                    tmr_Animation.Enabled = False
                    prg_Animation.Value = 0
                    snd_Intro.URL = ""
                    Me.Hide()
                    frm_Ellinia.Show()
                Else
                    x = 100
                    prg_Animation.Value = 0
                End If
            End If
        Next
    End Sub

    Private Sub txt_ID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ID.Click
        'Clearing the ID containing textbox when clicked
        txt_ID.Text = Nothing
        txt_ID.ForeColor = Color.Black
    End Sub

    Private Sub txt_Password_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Password.Click
        'Clearing the Password containing textbox when clicked and setting up a password char 
        txt_Password.PasswordChar = "*"
        txt_Password.Text = Nothing
        txt_Password.ForeColor = Color.Black
    End Sub

    Private Sub btn_Tutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tutorial.Click
        'Opening the tutorial form when pressed
        frm_Tutorial.Visible = True
    End Sub

    Private Sub pic_Background_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Background.Click
        'Refocusing on the tutorial's form whenever the form is ignored
        If frm_Tutorial.Visible = True Then
            frm_Tutorial.Focus()
        End If
    End Sub

    Private Sub txt_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Password.TextChanged
        'Clearing the Password containing textbox and setting up a password char 
        txt_Password.PasswordChar = "*"
    End Sub
End Class
