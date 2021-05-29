'Assignment 5 - Casino Craps
'By: Maor Gornik (ICS3U)
'Date: 26 of April, 2018

Public Class frm_Craps
    Dim result As Integer 'Creating a variable that will keep track of the total of the two rolled dice
    Dim roll As Integer 'Creating a variable to keep a track of the number of the roll
    Dim point As Integer 'Creating a variable to store the player's rolled point and keep a track of it
    Dim betCounter As Integer 'Creating a variable to make sure the player doesn't refund the chips after another roll
    Dim dicePics(6) As String 'Creating an array to hold a picture of all of the sides of a dice
    Dim bet As Integer 'Creating a variable to keep a track of the bets that the player has placed
    Dim wasted(9) As Integer 'Creating an array to check how much money the player has placed into each bet
    Dim passBet As Boolean 'Creating a variable to check if the player has placed a bet on the pass line
    Dim dPassBet As Boolean 'Creating a variable to check if the player has placed a bet on the don't pass line
    Dim sideBets(7) As Boolean 'Creating a variable to keep track of the side bets (hardways, big 6 and big 8) the player has placed
    Dim dice(1) As Integer 'Creating a variable to keep track of the rolled value of the two of the dice

    Private Sub btn_Roll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Roll.Click
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'Making sure the player has placed a bet
            If wasted(2) = 0 And wasted(3) = 0 Then
                MessageBox.Show("No bet was placed. Please place a bet!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Rolls the dices and
                roll = roll + 1
                betCounter = betCounter + 1
                'Hides the bet options when the player is 'rolling' the dice
                hideBet()
                'Storing the 6 sides of the dice into an array
                dicePics(1) = "img_Dice-1.png"
                dicePics(2) = "img_Dice-2.png"
                dicePics(3) = "img_Dice-3.png"
                dicePics(4) = "img_Dice-4.png"
                dicePics(5) = "img_Dice-5.png"
                dicePics(6) = "img_Dice-6.png"

                'Randomizing the number of rolls the dice will make
                Dim numrolls = Int((Rnd() * 10) + 5)

                'Creating the dice roll animation and storing the dice value as well as the combined result
                For x As Integer = 1 To numrolls
                    Threading.Thread.Sleep(200)
                    Dim dice1 = Int(Rnd() * 6) + 1
                    Dim dice2 = Int(Rnd() * 6) + 1
                    result = dice1 + dice2
                    Me.Refresh()
                    pic_Dice1.Image = Image.FromFile(dicePics(dice1)) 'loads picture box with file
                    pic_Dice2.Image = Image.FromFile(dicePics(dice2))
                    dice(0) = dice1
                    dice(1) = dice2
                Next x

                'Creating an if statement that will keep track of the roll of the player is in
                If roll = 1 Then
                    'Checking to see if the player has won
                    If result = 7 Or result = 11 Then
                        MessageBox.Show("You win! New round is up.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lbl_Status.FirstLabelText = "You win! New round is up."
                        lbl_Status.Text = "You win! New round is up."
                        'Keeping track of the number of wins
                        stats(1) += 1

                        'Checks if the player has placed a bet on the pass line. If there is a bet placed and the player wins, the player will earn money
                        If passBet = True Then
                            money += wasted(3) * 2
                            'Keeping track of the number of bets won
                            stats(0) += 1

                            'Checks if the player has placed a bet on the don't pass line. If there is a bet placed and the player loses, the player will lose money
                        ElseIf dPassBet = True Then
                            wasted(2) = 0
                        End If

                        'Calling the clear function and clearing everything
                        pic_PChip.Image = Nothing
                        pic_DChip.Image = Nothing
                        clear()

                        'Checking to see if the player has lost
                    ElseIf result = 2 Or result = 3 Or result = 12 Then
                        MessageBox.Show("You lost! New round is up.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lbl_Status.FirstLabelText = "You lost! New round is up."
                        lbl_Status.Text = "You lost! New round is up."
                        'Keeps a track of the number of losses
                        stats(2) += 1

                        'Checks if the player has placed a bet on the don't pass line. If there is a bet placed and the player loses, the player will earn money
                        If dPassBet = True Then
                            money += wasted(2) * 2
                            'Keeping track of the number of bets won
                            stats(0) += 1

                            'Checks if the player has placed a bet on the pass line. If there is a bet placed and the player wins, the player will lose money
                        ElseIf passBet = True Then
                            wasted(3) = 0
                        End If

                        'Calling the clear function and clearing everything
                        pic_PChip.Image = Nothing
                        pic_DChip.Image = Nothing
                        clear()

                        'Checking to see if the player has rolled a point and lets the user bet again
                    Else
                        point = result
                        MessageBox.Show("You rolled a point!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lbl_Status.FirstLabelText = "You rolled a point! [" + Convert.ToString(point) + "]"
                        lbl_Status.Text = "You rolled a point! [" + Convert.ToString(point) + "]"
                        pic_Chip.Enabled = True
                        pic_Point.Visible = True
                        showBet()

                        'Setting up a picture that will display the point on the screen for the player
                        If result = 4 Then
                            pic_Point.Location = New Point(167, 134)
                        ElseIf result = 5 Then
                            pic_Point.Location = New Point(227, 131)
                        ElseIf result = 6 Then
                            pic_Point.Location = New Point(288, 131)
                        ElseIf result = 8 Then
                            pic_Point.Location = New Point(348, 131)
                        ElseIf result = 9 Then
                            pic_Point.Location = New Point(411, 131)
                        ElseIf result = 10 Then
                            pic_Point.Location = New Point(472, 131)
                        Else
                            pic_Point.Visible = False
                        End If
                    End If

                    'Checks if the player is in the second roll and executes some code if the condition is met
                ElseIf roll = 2 Then

                    'Checking to see if the player has won
                    If result = point Then
                        MessageBox.Show("Pt rolled! You win! New round is up.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lbl_Status.FirstLabelText = "Pt rolled! You win! New round is up."
                        lbl_Status.Text = "Pt rolled! You win! New round is up."
                        'Keeping track of the number of wins
                        stats(1) += 1

                        'Checks if the player has placed a bet on the pass line. If there is a bet placed and the player wins, the player will earn money
                        If passBet = True Then
                            money += wasted(3) * 2
                            'Keeping track of the number of bets won
                            stats(0) += 1

                            'Checks if the player has placed a bet on the don't pass line. If there is a bet placed and the player loses, the player will lose money
                        ElseIf dPassBet = True Then
                            wasted(2) = 0
                        End If

                        'Calling the clear function and clearing everything
                        pic_PChip.Image = Nothing
                        pic_DChip.Image = Nothing
                        clear()

                        'Checking to see if the player has lost
                    ElseIf result = 7 Then
                        MessageBox.Show("You lost! New round is up.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lbl_Status.FirstLabelText = "You lost! New round is up."
                        lbl_Status.Text = "You lost! New round is up."
                        'Keeps a track of the number of losses
                        stats(2) += 1
                        pic_Point.Visible = False

                        'Checks if the player has placed a bet on the don't pass line. If there is a bet placed and the player loses, the player will earn money
                        If dPassBet = True Then
                            money += wasted(2) * 2
                            'Keeps a track of the number of bets won
                            stats(0) += 1

                            'Checks if the player has placed a bet on the pass line. If there is a bet placed and the player wins, the player will lose money
                        ElseIf passBet = True Then
                            wasted(3) = 0
                        End If

                        'Calling the clear function and clearing everything
                        pic_PChip.Image = Nothing
                        pic_DChip.Image = Nothing
                        clear()

                    Else
                        roll = 1
                        'Setting up the big 8 and 6 bets
                        If sideBets(0) = True And result = 6 Then
                            MessageBox.Show("Big 6 was rolled!", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Big 6 was rolled!"
                            lbl_Status.Text = "Big 6 was rolled!"
                            money += wasted(0) * 2
                            'Bets won
                            stats(0) += 1
                            pic_ChipB6.Image = Nothing
                            pic_ChipB6.Visible = False
                            wasted(0) = 0
                            sideBets(0) = False

                            'Setting up the hardway bets
                        ElseIf sideBets(1) = True And result = 8 Then
                            MessageBox.Show("Big 8 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Big 8 was rolled!"
                            lbl_Status.Text = "Big 8 was rolled!"
                            money += wasted(1) * 2
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipB8.Image = Nothing
                            pic_ChipB8.Visible = False
                            wasted(1) = 0
                            sideBets(1) = False

                        ElseIf sideBets(3) = True And dice(0) = 5 And dice(1) = 5 Then
                            MessageBox.Show("Hardway 10 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Hardway 10 was rolled!"
                            lbl_Status.Text = "Hardway 10 was rolled!"
                            money += wasted(6) * 8
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipH10.Image = Nothing
                            pic_ChipH10.Visible = False
                            wasted(6) = 0
                            sideBets(3) = False

                        ElseIf sideBets(5) = True And dice(0) = 2 And dice(1) = 2 Then
                            MessageBox.Show("Hardway 4 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Hardway 4 was rolled!"
                            lbl_Status.Text = "Hardway 4 was rolled!"
                            money += wasted(7) * 8
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipH4.Image = Nothing
                            pic_ChipH4.Visible = False
                            wasted(7) = 0
                            sideBets(5) = False

                        ElseIf sideBets(6) = True And dice(0) = 1 And dice(1) = 1 Then
                            MessageBox.Show("Snakes Eye was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Snakes Eye was rolled!"
                            lbl_Status.Text = "Snakes Eye was rolled!"
                            money += wasted(8) * 31
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipSnkEye.Image = Nothing
                            pic_ChipSnkEye.Visible = False
                            wasted(8) = 0
                            sideBets(6) = False

                        ElseIf sideBets(7) = True And dice(0) = 6 And dice(1) = 6 Then
                            MessageBox.Show("Hardway 12 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Hardway 12 was rolled!"
                            lbl_Status.Text = "Hardway 12 was rolled!"
                            money += wasted(9) * 31
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipH12.Image = Nothing
                            pic_ChipH12.Visible = False
                            wasted(9) = 0
                            sideBets(7) = False
                        End If

                        If sideBets(4) = True And dice(0) = 4 And dice(1) = 4 Then
                            MessageBox.Show("Hardway 8 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Hardway 8 was rolled!"
                            lbl_Status.Text = "Hardway 8 was rolled!"
                            money += wasted(5) * 10
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipH8.Image = Nothing
                            pic_ChipH8.Visible = False
                            wasted(5) = 0
                            sideBets(4) = False

                        ElseIf sideBets(2) = True And dice(0) = 3 And dice(1) = 3 Then
                            MessageBox.Show("Hardway 6 was rolled!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lbl_Status.FirstLabelText = "Hardway 6 was rolled!"
                            lbl_Status.Text = "Hardway 6 was rolled!"
                            money += wasted(4) * 10
                            'Keeps a track of the number of bets won
                            stats(0) += 1
                            pic_ChipH6.Image = Nothing
                            pic_ChipH6.Visible = False
                            wasted(4) = 0
                            sideBets(2) = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    'Creating a function that will reset everything to default
    Sub clear()
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            roll = 0
            result = 0
            point = 0
            betCounter = 0
            bet = 5
            wasted = Enumerable.Repeat(0, 10).ToArray
            passBet = False
            dPassBet = False
            cbo_Chips.SelectedIndex = 0
            pic_Dice1.Image = Image.FromFile("img_Dice-1.png")
            pic_Dice2.Image = Image.FromFile("img_Dice-1.png")
            pic_Point.Visible = False
            pic_Chip.Enabled = True
            pic_DChip.Image = Nothing
            pic_PChip.Image = Nothing
            pic_ChipB6.Visible = False
            pic_ChipB6.Image = Nothing
            pic_ChipB8.Visible = False
            pic_ChipB8.Image = Nothing
            pic_ChipB8.Visible = False
            pic_ChipH6.Visible = False
            pic_ChipH6.Image = Nothing
            pic_ChipH8.Visible = False
            pic_ChipH8.Image = Nothing
            pic_ChipH10.Visible = False
            pic_ChipH10.Image = Nothing
            pic_ChipH4.Visible = False
            pic_ChipH4.Image = Nothing
            pic_ChipH12.Visible = False
            pic_ChipH12.Image = Nothing
            pic_ChipSnkEye.Visible = False
            pic_ChipSnkEye.Image = Nothing
            wasted(0) = 0
            sideBets(0) = False
            wasted(1) = 0
            sideBets(1) = False

            'Checks to see if the player has lost all of the money and opens a new from as a result
            If money = 0 Then
                Me.Hide()
                frm_Premium.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    'Creating a function that will hide all the pictures and disable the player from betting
    Sub hideBet()
        pic_B6.Visible = False
        pic_B8.Visible = False
        pic_dPass.Visible = False
        pic_Pass.Visible = False
        pic_H4.Visible = False
        pic_H6.Visible = False
        pic_H8.Visible = False
        pic_H10.Visible = False
        pic_H12.Visible = False
        pic_SnkEye.Visible = False

    End Sub

    'Creating a function that will let the player bet if the conditions are met
    Sub showBet()
        If roll = 0 Then
            pic_dPass.Visible = True
            pic_Pass.Visible = True

        ElseIf roll >= 1 And pic_ChipB6.Image Is Nothing And money <> 0 Then
            pic_B6.Visible = True

        End If
        If roll >= 1 And pic_ChipB8.Image Is Nothing And money <> 0 Then
            pic_B8.Visible = True
        End If

        If roll >= 1 And pic_ChipH4.Image Is Nothing And money <> 0 Then
            pic_H4.Visible = True
        End If

        If roll >= 1 And pic_ChipH6.Image Is Nothing And money <> 0 Then
            pic_H6.Visible = True
        End If

        If roll >= 1 And pic_ChipH8.Image Is Nothing And money <> 0 Then
            pic_H8.Visible = True
        End If

        If roll >= 1 And pic_ChipH10.Image Is Nothing And money <> 0 Then
            pic_H10.Visible = True
        End If

        If roll >= 1 And pic_ChipSnkEye.Image Is Nothing And money <> 0 Then
            pic_SnkEye.Visible = True
        End If

        If roll >= 1 And pic_ChipH12.Image Is Nothing And money <> 0 Then
            pic_H12.Visible = True
        End If
    End Sub

    Private Sub btn_Reset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Reset.Click
        'Checks if the palyer has started the game
        If roll = 1 Then
            'Lets the player reset everything to default and start a new game 
            Dim response = MessageBox.Show("Are you sure you want to start a new game? Everything will be lost!", "Casino Craps Practice [Attention]", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                Me.Refresh()
                'Calling the clear function to reset everything to default
                clear()
                hideBet()
                money = 1000
            End If
        Else
            MessageBox.Show("Please start the game first!", "Casino Craps Practice Edition", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frm_Craps_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'Calling the randomize function to randomize the random generated number and setting up the main file directory
            Randomize()
            ChDir(Environment.CurrentDirectory + "\images")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub btn_Buy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Buy.Click
        'The button is just there to let the player see all of the 'premium' options
        MessageBox.Show("Sorry! You cannot buy in practice mode. Please download our premium version.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cbo_Chips_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_Chips.SelectedIndexChanged
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'Display the chip value on the screen
            If cbo_Chips.SelectedIndex = 0 Then
                pic_Chip.Image = Image.FromFile("chip5D.png")
                bet = 5
            ElseIf cbo_Chips.SelectedIndex = 1 Then
                pic_Chip.Image = Image.FromFile("chip25D.png")
                bet = 25
            ElseIf cbo_Chips.SelectedIndex = 2 Then
                pic_Chip.Image = Image.FromFile("chip100D.png")
                bet = 100
            ElseIf cbo_Chips.SelectedIndex = 3 Then
                pic_Chip.Image = Image.FromFile("chip500D.png")
                bet = 500
            ElseIf cbo_Chips.SelectedIndex = 4 Then
                pic_Chip.Image = Image.FromFile("chip1000D.png")
                bet = 1000
            Else
                pic_Chip.Image = Image.FromFile("chipAll_Orig.png")
                bet = Val(txt_Money.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub tmr_Check_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmr_Check.Tick
        'Displays the player's game statistics
        txt_Money.Text = money
        lbl_bWon.Text = "Bets Won: " + Convert.ToString(stats(0))
        lbl_Wins.Text = "Wins: " + Convert.ToString(stats(1))
        lbl_Loses.Text = "Loses: " + Convert.ToString(stats(2))

        If cbo_Chips.SelectedIndex = -1 Then
            cbo_Chips.SelectedIndex = 0
        End If

        'Disables the double click event when no bet is placed
        If pic_DChip.Image Is Nothing Then
            pic_DChip.Enabled = False
        Else
            pic_DChip.Enabled = True
        End If

        If pic_PChip.Image Is Nothing Then
            pic_PChip.Enabled = False
        Else
            pic_PChip.Enabled = True
        End If
    End Sub

    Private Sub pic_dPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_dPass.Click
        'Lets the player place a bet on the don't pass line
        If (money - bet) >= 0 Then
            money -= bet
            wasted(2) = bet
            dPassBet = True
            pic_DChip.Image = pic_Chip.Image
            pic_dPass.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_Pass_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Pass.Click
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'Lets the player place a bet on the pass line
            If (money - bet) >= 0 Then
                money -= bet
                wasted(3) = bet
                passBet = True
                pic_PChip.Image = pic_Chip.Image
                pic_Pass.Visible = False
            Else
                MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub

    Private Sub pic_dPass_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_dPass.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_dPass.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_dPass_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_dPass.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_dPass.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_Pass_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Pass.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_Pass.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_Pass_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Pass.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_Pass.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_B6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B6.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_B6.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_B6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B6.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_B6.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_B8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B8.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_B8.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_B8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B8.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_B8.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H6.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_H6.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H6.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_H6.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H10_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H10.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_H10.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H10.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_H10.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H8.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_H8.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H8.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_H8.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H4.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_H4.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H4.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_H4.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_SnkEye_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_SnkEye.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_SnkEye.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_SnkEye_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_SnkEye.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_SnkEye.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H12_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H12.MouseHover
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the mouse is right on the betting picture option, changes the color to red
            pic_H12.Image = Image.FromFile("here_Red.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_H12_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H12.MouseLeave
        'Catching unnecessary errors and notifying the user what might be the problem
        Try
            'When the player moves the mouse off the betting picture option, changes the color back to normal
            pic_H12.Image = Image.FromFile("here.png")
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B6.Click
        'Lets the player place a bet on big 6
        If (money - bet) >= 0 Then
            money -= bet
            wasted(0) = bet
            sideBets(0) = True
            pic_ChipB6.Image = pic_Chip.Image
            pic_ChipB6.Visible = True
            pic_B6.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_B8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_B8.Click
        'Lets the player place a bet on big 8
        If (money - bet) >= 0 Then
            money -= bet
            wasted(1) = bet
            sideBets(1) = True
            pic_ChipB8.Image = pic_Chip.Image
            pic_ChipB8.Visible = True
            pic_B8.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_H6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H6.Click
        'Lets the player place a bet on hardway 6
        If (money - bet) >= 0 Then
            money -= bet
            wasted(4) = bet
            sideBets(2) = True
            pic_ChipH6.Image = pic_Chip.Image
            pic_ChipH6.Visible = True
            pic_H6.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_H10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H10.Click
        'Lets the player place a bet on hardway 10
        If (money - bet) >= 0 Then
            money -= bet
            wasted(6) = bet
            sideBets(3) = True
            pic_ChipH10.Image = pic_Chip.Image
            pic_ChipH10.Visible = True
            pic_H10.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_H8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H8.Click
        'Lets the player place a bet on hardway 8
        If (money - bet) >= 0 Then
            money -= bet
            wasted(5) = bet
            sideBets(4) = True
            pic_ChipH8.Image = pic_Chip.Image
            pic_ChipH8.Visible = True
            pic_H8.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_H4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H4.Click
        'Lets the player place a bet on hardway 4
        If (money - bet) >= 0 Then
            money -= bet
            wasted(7) = bet
            sideBets(5) = True
            pic_ChipH4.Image = pic_Chip.Image
            pic_ChipH4.Visible = True
            pic_H4.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_ChipB6_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipB6.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed bet amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(0)
                sideBets(0) = False
                pic_ChipB6.Image = Nothing
                pic_B6.Visible = True
                pic_ChipB6.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub pic_Chip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Chip.Click
        'Calling the showBet function to display all the possible bets 
        showBet()
    End Sub

    Private Sub pic_ChipB8_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipB8.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(1)
                sideBets(1) = False
                pic_ChipB8.Image = Nothing
                pic_B8.Visible = True
                pic_ChipB8.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_DChip_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_DChip.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If roll = 0 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(2)
                dPassBet = False
                pic_DChip.Image = Nothing
                pic_dPass.Visible = True
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_PChip_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_PChip.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If roll = 0 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(3)
                passBet = False
                pic_PChip.Image = Nothing
                pic_Pass.Visible = True
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipH6_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipH6.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(4)
                sideBets(2) = False
                pic_ChipH6.Image = Nothing
                pic_H6.Visible = True
                pic_ChipH6.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipH8_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipH8.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(5)
                sideBets(4) = False
                pic_ChipH8.Image = Nothing
                pic_H8.Visible = True
                pic_ChipH8.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipH10_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipH10.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(6)
                sideBets(3) = False
                pic_ChipH10.Image = Nothing
                pic_H10.Visible = True
                pic_ChipH10.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipH4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipH4.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(7)
                sideBets(5) = False
                pic_ChipH4.Image = Nothing
                pic_H4.Visible = True
                pic_ChipH4.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipSnkEye_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ChipSnkEye.DoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(8)
                sideBets(6) = False
                pic_ChipSnkEye.Image = Nothing
                pic_SnkEye.Visible = True
                pic_ChipSnkEye.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pic_ChipH12_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_ChipH12.MouseDoubleClick
        'Asks the player for a premission to clear the bet and then refunds the placed amount
        If betCounter = 1 Then
            Dim response = MessageBox.Show("Are you sure you want to perform this action?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                money += wasted(9)
                sideBets(7) = False
                pic_ChipH12.Image = Nothing
                pic_H12.Visible = True
                pic_ChipH12.Visible = False
            End If
        Else
            MessageBox.Show("This bet cannot be cleared at the moment!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home.Click
        'Hides the current form and opens the main menu
        Me.Hide()
        frm_MainMenu.Visible = True
    End Sub

    Private Sub pic_SnkEye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_SnkEye.Click
        'Lets the player place a bet on the Snake Eye (hardway 2)
        If (money - bet) >= 0 Then
            money -= bet
            wasted(8) = bet
            sideBets(6) = True
            pic_ChipSnkEye.Image = pic_Chip.Image
            pic_ChipSnkEye.Visible = True
            pic_SnkEye.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_H12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_H12.Click
        'Lets the player place a bet on hardway 12
        If (money - bet) >= 0 Then
            money -= bet
            wasted(9) = bet
            sideBets(7) = True
            pic_ChipH12.Image = pic_Chip.Image
            pic_ChipH12.Visible = True
            pic_H12.Visible = False
        Else
            MessageBox.Show("Oops! You don't have enough money.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pic_Settings_Click(sender As Object, e As EventArgs) Handles pic_Settings.Click
        'The button is just there to let the player see all of the 'premium' options
        MessageBox.Show("Sorry! There are no additional options available in our practice edition. Please download our premium version.", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class