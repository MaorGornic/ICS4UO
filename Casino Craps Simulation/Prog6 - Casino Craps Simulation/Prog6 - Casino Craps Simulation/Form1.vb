Public Class frm_Main
    Dim dice1 As Integer
    Dim dice2 As Integer
    Dim result As Integer
    Dim roll As Integer
    Dim point As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Roll.Click
        roll += 1
        lbl_Roll.Text = "Roll: " + Convert.ToString(roll)
        dice1 = Int(6 * Rnd()) + 1
        lbl_Dice1.Text = "Dice 1: " + Convert.ToString(dice1)
        dice2 = Int(6 * Rnd()) + 1
        lbl_Dice2.Text = "Dice 2: " + Convert.ToString(dice2)
        result = dice1 + dice2
        lbl_Result.Text = "Total: " + Convert.ToString(result)

        If roll = 1 Then

            If result = 7 Or result = 11 Then
                lbl_Status.Text = "You: Win"
                MessageBox.Show("You win! New round is up.")
                clear()
            ElseIf result = 2 Or result = 3 Or result = 12 Then
                lbl_Status.Text = "You: Lose"
                MessageBox.Show("You lost! New round is up.")
                clear()
            Else
                point = result
                lbl_Status.Text = "You: Got a Point"
            End If

        Else
            If result = point Then
                lbl_Status.Text = "You: Win"
                MessageBox.Show("You win! New round is up.")
                clear()

            ElseIf result = 7 Then
                lbl_Status.Text = "You: Lose"
                MessageBox.Show("You lost! New round is up.")
                clear()
            Else
                lbl_Status.Text = "Roll again please!"
            End If

        End If
    End Sub

    Sub clear()
        lbl_Status.Text = "You:"
        dice1 = 0
        dice2 = 0
        result = 0
        roll = 0
        point = 0
        roll = 0
        lbl_Roll.Text = "Roll: " + Convert.ToString(roll)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
