Public Class frm_CvH
    Dim answer As Integer 'number = num
    Dim high As Integer = 100
    Dim low As Integer
    Dim guess As Integer = 50 'guess = answer
    Dim tries As Integer = 1
   

    Private Sub btn_Num_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Guess.Click
        Try
            'Fix - when someone doesnt enter anything, the program gives an error + add instructions form
            If IsNumeric(txt_Guess.Text) And Val(txt_Guess.Text) > 0 And Val(txt_Guess.Text) <= 100 And Val(txt_Guess.Text) = Int(txt_Guess.Text) Then
                answer = txt_Guess.Text
                btn_Guess.Enabled = False
                txt_Guess.Text = "Great choice!"
                txt_Guess.Enabled = False
            Else
                MessageBox.Show("Number must be between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Guess.Text = ""

            End If

        Catch ex As Exception
            MessageBox.Show("Number must be between 1 and 100", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub reset()
        'Setting a reset function
        tries = 1
        txt_Guess.Text = ""
        txt_Tries.Text = ""
        lst_Tries.Items.Clear()
        high = 100
        low = 0
        answer = 0
        txt_Guess.Enabled = True
        btn_Guess.Enabled = True
        pic_Confirm.Visible = False
        txt_Guess.Focus()
    End Sub

    Private Sub btn_Guess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Num.Click
        Try
            txt_Tries.Text = tries
            If txt_Guess.Text = "" Or Not txt_Guess.Text = "Great choice!" Then
                MessageBox.Show("Please enter a number between 1 and 100", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If guess < answer Then
                    low = guess
                    lst_Tries.Items.Add(Convert.ToString(guess) + " is: too low!")
                    tries = tries + 1
                ElseIf guess > answer Then
                    high = guess
                    lst_Tries.Items.Add(Convert.ToString(guess) + " is: too high!")
                    tries = tries + 1
                Else
                    pic_Confirm.Visible = True
                    'tries = tries + 1
                    txt_Tries.Text = tries
                    'would you like to resart? No - goes back to menu
                    MessageBox.Show("I have got it! The number is: " + Convert.ToString(answer) + Environment.NewLine + "It took me: " + Convert.ToString(tries) + " tries.", "Wooohooo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim response = MessageBox.Show("Would you like to start a new game?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If response = MsgBoxResult.Yes Then
                        reset()
                    Else
                        Me.Hide()
                        frm_Menu.Visible = True
                    End If
                End If
            End If
            guess = (high + low) / 2
        Catch ex As Exception
            MessageBox.Show("Please enter a number between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Guess.Text = ""
        End Try
    End Sub

    Private Sub btn_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        reset()

    End Sub

    Private Sub pic_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Back.Click
        reset()
        Me.Hide()
        frm_Menu.Visible = True
    End Sub
End Class