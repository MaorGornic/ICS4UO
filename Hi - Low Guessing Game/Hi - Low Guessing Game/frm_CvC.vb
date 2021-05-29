Public Class frm_CvC
    Dim answer As Integer 'number = num
    Dim high As Integer = 100
    Dim low As Integer
    Dim guess As Integer = 50 'guess = answer
    Dim tries As Integer = 1

    Private Sub btn_Generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Generate.Click
        answer = CInt(Int((100 * Rnd()) + 1)) '<-- ASK IF OKAY
        txt_Generate.Text = answer
        pic_Selected.Visible = True
        btn_Generate.Enabled = False
    End Sub

    Sub reset()
        'Setting a reset function
        tries = 1
        txt_Generate.Text = ""
        txt_Tries.Text = ""
        lst_Tries.Items.Clear()
        high = 100
        low = 0
        answer = 0
        btn_Generate.Enabled = True
        pic_Selected.Visible = False
        pic_Selected2.Visible = False
    End Sub

    Private Sub frm_CvC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()
    End Sub

    Private Sub btn_Guess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guess.Click
        Try
            txt_Tries.Text = tries
            If answer = 0 Then
                MessageBox.Show("No number was generated! Please click to generate a number.", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    pic_Selected2.Visible = True
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