Public Class frm_HvH
    Dim num As Integer
    Dim answer As Integer
    Dim tries As Integer

    Private Sub btn_Num_Click(sender As Object, e As EventArgs) Handles btn_Num.Click
        'Trying to check all possible errors and setting the answer to the entered number
        Try
            If IsNumeric(txt_Num.Text) And Val(txt_Num.Text) > 0 And Val(txt_Num.Text) <= 100 And Val(txt_Num.Text) = Int(txt_Num.Text) Then
                num = txt_Num.Text
                btn_Num.Enabled = False
                txt_Num.Text = "Awesome choice!"
                txt_Num.Enabled = False
            Else
                MessageBox.Show("Number must be between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Num.Text = ""

            End If

        Catch ex As Exception
            MessageBox.Show("Number must be between 1 and 100", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Num.Text = ""
        End Try

    End Sub

    Sub reset()
        'Setting a reset function
        tries = 0
        num = 0
        txt_Num.Text = ""
        txt_Answer.Text = ""
        txt_Tries.Text = ""
        lst_Tries.Items.Clear()
        txt_Num.Enabled = True
        btn_Num.Enabled = True
        txt_Num.Focus()
    End Sub

    Private Sub btn_Answer_Click(sender As Object, e As EventArgs) Handles btn_Answer.Click
        'Trying to check all possible errors and checking if the entered number matches the answer 
        Try
            If txt_Num.Text = "" Or Not txt_Num.Text = "Awesome choice!" Then
                MessageBox.Show("Please enter a number between 1 and 100", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If IsNumeric(txt_Answer.Text) And Val(txt_Answer.Text) > 0 And Val(txt_Answer.Text) <= 100 And Val(txt_Answer.Text) = Int(txt_Answer.Text) Then
                    answer = txt_Answer.Text
                    tries = tries + 1
                    txt_Tries.Text = tries
                Else
                    MessageBox.Show("Number must be between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_Answer.Text = ""
                End If
            End If

            While (Val(txt_Answer.Text) > 0 And Val(txt_Answer.Text) <= 100 And Not (answer = 0))

                If answer < num Then
                    lst_Tries.Items.Add(Convert.ToString(answer) + " is: too low!")
                    txt_Answer.Text = ""
                ElseIf answer > num Then
                    lst_Tries.Items.Add(Convert.ToString(answer) + " is: too high!")
                    txt_Answer.Text = ""
                Else
                    MessageBox.Show("You Guessed it!" + Environment.NewLine + "It took you: " + Convert.ToString(tries) + " tries.", "Wooohooo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim response = MessageBox.Show("Would you like to start a new game?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If response = MsgBoxResult.Yes Then
                        reset()
                    Else
                        reset()
                        Me.Hide()
                        frm_Menu.Visible = True
                    End If
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Please enter a number between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Answer.Text = ""
        End Try

    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        reset()
    End Sub

    Private Sub tmr_Rate_Tick(sender As Object, e As EventArgs) Handles tmr_Rate.Tick
        If Val(txt_Tries.Text) > 5 Then
            'nice
        Else
            'Running out of luck?
        End If
    End Sub

    Private Sub pic_Back_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pic_Back.Click
        txt_Answer.Focus()
        reset()
        Me.Hide()
        frm_Menu.Visible = True
    End Sub
End Class

