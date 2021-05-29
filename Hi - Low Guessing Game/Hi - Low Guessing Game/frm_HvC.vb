Public Class frm_HvC
    Dim answer As Integer
    Dim num As Integer
    Dim tries As Integer

    Private Sub btn_Answer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Guess.Click
        Try
            If IsNumeric(txt_Guess.Text) And Val(txt_Guess.Text) > 0 And Val(txt_Guess.Text) <= 100 And Val(txt_Guess.Text) = Int(txt_Guess.Text) Then
                answer = Val(txt_Guess.Text)
                tries = tries + 1
                txt_Tries.Text = tries
            Else
                MessageBox.Show("Number must be between 1 and 100. No decimal values are allowed!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Guess.Text = ""
            End If

            While (Val(txt_Guess.Text) > 0 And Val(txt_Guess.Text) <= 100 And Not (answer = 0))
                If answer < Val(num) Then
                    lst_Tries.Items.Add(Convert.ToString(answer) + " is: too low!")
                    txt_Guess.Text = ""
                ElseIf answer > Val(num) Then
                    lst_Tries.Items.Add(Convert.ToString(answer) + " is: too high!")
                    txt_Guess.Text = ""
                Else
                    'would you like to resart? No - goes back to menu
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
            txt_Guess.Text = ""
        End Try
    End Sub

    Sub reset()
        'Setting a reset function
        tries = 0
        num = 0
        txt_Guess.Text = ""
        txt_Tries.Text = ""
        lst_Tries.Items.Clear()
        btn_Generate.Enabled = True
        pic_Selected.Visible = False
    End Sub

    Private Sub btn_Generate_Click(sender As Object, e As EventArgs) Handles btn_Generate.Click
        num = CInt(Int((100 * Rnd()) + 1)) '<-- ASK IF OKAY
        pic_Selected.Visible = True
        btn_Generate.Enabled = False
        MessageBox.Show("A number between 1 and 100 was successfully generated. Go ahead and try your luck :)", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frm_HvC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
    End Sub

    Private Sub pic_Back_Click(sender As Object, e As EventArgs) Handles pic_Back.Click
        reset()
        Me.Hide()
        frm_Menu.Visible = True
    End Sub

    Private Sub btn_Reset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        reset()
    End Sub
End Class