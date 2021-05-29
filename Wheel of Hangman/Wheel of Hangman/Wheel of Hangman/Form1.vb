'Assignment 6 - Wheel of Hangman
'By: Maor Gornik (ICS3U)
'Date: 18th of May, 2018

Imports System.Collections

Public Class frm_Main
    Dim wordsE(20) As String 'Creating a variable to store all the possible words for the Easy level
    Dim wordsM(20) As String 'Creating a variable to store all the possible words for the Medium level
    Dim wordsH(20) As String 'Creating a variable to store all the possible words for the Hard level
    Dim hiddenWord As String 'Creating a variable to replace the unknown letter with the one that was guessed
    Dim bodyCounter As Integer = 12 'Creating a variable to keep a track of the number of body parts of the hangman
    Dim wrongCounter As Integer 'Creating a variable to keep a track of the amount of wrong guesses
    Dim verifyWord As Boolean 'Creating a variable that will determine whether the inserted letter is found in the generated word
    Dim wordLen As Integer 'Creating a variable that will keep a track of the word's length
    Dim guessCounter As Integer = 10 'Creating a variable that will keep a track of the number of guesses left
    Dim max As Integer = 20 'Creating a variable that will keep a track of the generated words and avoid repetition
    Dim word As String 'Creating a variable that will hold the generated word
    Dim OrigWord As String 'Creating a variable that will hold the generated word without the additional spaces or interference
    Dim OrigHidden As String 'Creating a variable that will keep a track of the guessed letters without the additional spaces or interference
    Dim checkLetter As String 'Creating a variable that will check if the guessed letter exists in the generated word
    Dim winCounter As Integer 'Creating a variable that will keep a track of the number of wins the player has got in total

    Private Sub btn_StrtOver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_StrtOver.Click
        'Disabling and enabling the required controllers on form load event
        RandomWord()
        grp_Letters.Enabled = True
        btn_Lose.Enabled = True
        pnl_Main.Enabled = True
        btn_StrtOver.Enabled = False
        grp_Mode.Enabled = False
        btn_newGame.Enabled = True
        grp_Letters.Enabled = True
    End Sub
    'Creating a function that will generate a random word everytime the function is called and adding empty spots to be filled we the player's gueeses accordingly to the length
    Sub RandomWord()
        btn_Lose.Enabled = True

        'Checking to see if the player has chosen the easy game mode
        If rdo_Easy.Checked = True Then
            wordsE(1) = "C a n a d a"
            wordsE(2) = "M o r o c c o"
            wordsE(3) = "A f g h a n i s t a n"
            wordsE(4) = "H u n g a r y"
            wordsE(5) = "I t a l y"
            wordsE(6) = "I s r a e l"
            wordsE(7) = "G e r m a n y"
            wordsE(8) = "I r e l a n d"
            wordsE(9) = "A u s t r i a"
            wordsE(11) = "R o m a n i a"
            wordsE(12) = "R u s s i a"
            wordsE(13) = "S e r b i a"
            wordsE(14) = "S w e d e n"
            wordsE(15) = "S p a i n"
            wordsE(16) = "L u x e m b o u r g"
            wordsE(17) = "C h i n a"
            wordsE(18) = "J a p a n"
            wordsE(19) = "D e n m a r k"
            wordsE(20) = "U k r a i n e"

            'Reducing the maximum word counter by 1 to avoid repetition of the same words
            max -= 1
            Dim randNum = Int(Rnd() * max) + 1

            'Replacing the generated word's index with the last index in the array
            For x = 0 To max
                wordsE(randNum) = wordsE(max)
            Next
            word = wordsE(randNum)

            'Checking to see if the player has won the easiest game mode
            If max = 0 Then
                MessageBox.Show("Congratulations! You have won the EASY mode.", "Wheel of Hangman [Congratulations]")
                rdo_Easy.Checked = False
                rdo_Easy.Enabled = False
            End If

            'Adding an underscore following an empty space for each letter in the word
            Try
                For Each letter In word
                    lbl_Letters.Text = lbl_Letters.Text + " _"
                    hiddenWord = lbl_Letters.Text
                    wordLen = Len(word)
                Next
            Catch ex As Exception
                randNum = Int(Rnd() * max) + 1
                wordsE(randNum) = wordsE(max)
            End Try

            'Checking to see if the player has chosen the medium game mode
        ElseIf rdo_Medium.Checked = True Then
            wordsM(1) = "C h r y s l e r"
            wordsM(2) = "T e s l a"
            wordsM(3) = "D a t s u n"
            wordsM(4) = "V o l k s w a g e n"
            wordsM(5) = "S u z u k i"
            wordsM(6) = "C h e v r o l e t"
            wordsM(7) = "L a g o n d a"
            wordsM(8) = "T o y o t a"
            wordsM(9) = "R e n a u l t"
            wordsM(11) = "C i t r o e n"
            wordsM(12) = "D o d g e"
            wordsM(13) = "F e r r a r i"
            wordsM(14) = "C a d i l l a c"
            wordsM(15) = "M a s e r a t i"
            wordsM(16) = "P e u g e o t"
            wordsM(17) = "M i t s u b i s h i"
            wordsM(18) = "N i s s a n"
            wordsM(19) = "P a g a n i"
            wordsM(20) = "A c u r a"

            'Reducing the maximum word counter by 1 to avoid repetition of the same words
            max -= 1
            Dim randNum = Int(Rnd() * max) + 1

            'Replacing the generated word's index with the last index in the array
            For x = 0 To max
                wordsM(randNum) = wordsM(max)
            Next
            word = wordsM(randNum)

            'Checking to see if the player has won the medium game mode
            If max = 0 Then
                MessageBox.Show("Congratulations! You have won the MEDIUM mode.", "Wheel of Hangman [Congratulations]")
                rdo_Easy.Checked = False
                rdo_Easy.Enabled = False
            End If

            'Adding an underscore following an empty space for each letter in the word
            Try
                For Each letter In word
                    lbl_Letters.Text = lbl_Letters.Text + " _"
                    hiddenWord = lbl_Letters.Text
                    wordLen = Len(word)
                Next
            Catch ex As Exception
                randNum = Int(Rnd() * max) + 1
                wordsM(randNum) = wordsM(max)
            End Try

            'Checking to see if the player has chosen the hardest game mode
        ElseIf rdo_Hard.Checked = True Then
            wordsH(1) = "R o t t w e i l e r"
            wordsH(2) = "B e a g l e"
            wordsH(3) = "B u l l d o g"
            wordsH(4) = "P o o d l e"
            wordsH(5) = "D o b e r m a n n"
            wordsH(6) = "D a c h s u n d"
            wordsH(7) = "C h i h u a h u a"
            wordsH(8) = "B o x e r"
            wordsH(9) = "Y o r k s h i r e"
            wordsH(11) = "V i z s l a"
            wordsH(12) = "P i t b u l l"
            wordsH(13) = "G r e y h o u n d"
            wordsH(14) = "A k i t a"
            wordsH(15) = "P o m e r a n i a n"
            wordsH(16) = "M a l i n o i s"
            wordsH(17) = "S h e e p d o g"
            wordsH(18) = "A u s t r a l i a n"
            wordsH(19) = "A l a s k a n"
            wordsH(20) = "S a l u k i"

            'Reducing the maximum word counter by 1 to avoid repetition of the same words
            max -= 1
            Dim randNum = Int(Rnd() * max) + 1

            'Replacing the generated word's index with the last index in the array
            For x = 0 To max
                wordsH(randNum) = wordsH(max)
            Next
            word = wordsH(randNum)

            'Checking to see if the player has won the hardest game mode
            If max = 0 Then
                MessageBox.Show("Congratulations! You have won the HARDEST mode in the game.", "Wheel of Hangman [Congratulations]")
                rdo_Easy.Checked = False
                rdo_Easy.Enabled = False
            End If

            'Adding an underscore following an empty space for each letter in the word
            Try
                For Each letter In word
                    lbl_Letters.Text = lbl_Letters.Text + " _"
                    hiddenWord = lbl_Letters.Text
                    wordLen = Len(word)
                Next
            Catch ex As Exception
                randNum = Int(Rnd() * max) + 1
                wordsH(randNum) = wordsH(max)
            End Try
        End If

        'Making sure that the empty spaces match the word's length and replacing the whole word with underscores
        If Int((wordLen / 2) + 1) > 5 And Int((wordLen / 2) + 1) < 10 And rdo_Hard.Checked = False Then
            hiddenWord = hiddenWord.Substring(0, wordLen / 2 + 7)
            lbl_Letters.Text = hiddenWord

        ElseIf Int((wordLen / 2) + 1) >= 10 Then
            hiddenWord = hiddenWord.Substring(0, wordLen / 2 + 10)
            lbl_Letters.Text = hiddenWord

        ElseIf Int((wordLen / 2) + 1) > 5 And Int((wordLen / 2) + 1) < 10 And rdo_Hard.Checked = True Then
            hiddenWord = hiddenWord.Substring(0, wordLen / 2 + 8)
            lbl_Letters.Text = hiddenWord

        Else
            hiddenWord = hiddenWord.Substring(0, wordLen / 2 + 6)
            lbl_Letters.Text = hiddenWord
        End If

    End Sub
    'Creating a function that will reset everything to its default state
    Sub reset()
        btn_A.Enabled = True
        btn_B.Enabled = True
        btn_C.Enabled = True
        btn_D.Enabled = True
        btn_K.Enabled = True
        btn_E.Enabled = True
        btn_F.Enabled = True
        btn_G.Enabled = True
        btn_H.Enabled = True
        btn_I.Enabled = True
        btn_J.Enabled = True
        btn_L.Enabled = True
        btn_M.Enabled = True
        btn_N.Enabled = True
        btn_O.Enabled = True
        btn_P.Enabled = True
        btn_Q.Enabled = True
        btn_R.Enabled = True
        btn_S.Enabled = True
        btn_T.Enabled = True
        btn_U.Enabled = True
        btn_V.Enabled = True
        btn_W.Enabled = True
        btn_X.Enabled = True
        btn_Y.Enabled = True
        btn_Z.Enabled = True
        txt_Missed.Text = Nothing
        lbl_Letters.Text = Nothing
        wordLen = 0
        bodyCounter = 12
        pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged1.png")
        guessCounter = 10

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Calling the randomize function to truly randomize the order of the generated number
        Randomize()
    End Sub

    'Checks if the player has guessed all of the right letters in the word, adds them all up and compares them to the original generated word
    Sub winCheck()
        OrigWord = word.Replace(" ", "")
        OrigHidden = hiddenWord.Replace(" ", "")

        If OrigHidden = OrigWord Then
            MessageBox.Show("Good job!", "Wheel of Hangman [Right]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_Letters.Text = Nothing
            btn_newGame.Enabled = True
            winCounter += 1
            reset()
            RandomWord()
        End If
    End Sub
    'Creating a function that will check whether the player has lost by taking into consideration the number of guesses the player has left
    Sub loseCheck()
        Select Case bodyCounter
            Case 11
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged2.png")
            Case 10
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged3.png")
            Case 9
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged4.png")
            Case 8
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged5.png")
            Case 7
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged6.png")
            Case 6
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged7.png")
            Case 5
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged8.png")
            Case 4
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged9.png")
            Case 3
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged10.png")
            Case 2
                pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged11.png")
                'u lost
                If MessageBox.Show("Oh no! You have lost. Would you like to continue?", "Wheel of Hangman [Alert]", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    pic_Hangman.Image = Image.FromFile(Environment.CurrentDirectory + "\pictures\hanged1.png")
                    reset()
                    RandomWord()
                Else
                    reset()
                    btn_Lose.Enabled = False
                    grp_Letters.Enabled = False
                    grp_Mode.Enabled = True
                    btn_StrtOver.Enabled = True
                    MessageBox.Show("Feel free to change the game mode.", "Wheel of Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    Private Sub btn_Q_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Q.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_Q.Enabled = False

        For x = 1 To Len(word)
            Dim checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "Q" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "q")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "Q" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "Q")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next
        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "Q, "
            guessCounter -= 1
            wrongCounter += 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_W.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_W.Enabled = False

        For x = 1 To Len(word)
            Dim checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "W" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "w")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "Q" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "Q")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "W, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_E.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_E.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "E" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "e")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "E" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "E")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "E, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_D.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_D.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "D" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "d")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "D" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "D")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "D, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_N.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_N.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If checkLetter = "n" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "n")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "N" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "N")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "N, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_M.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If checkLetter = "m" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "m")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "M" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "M")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "M, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_R.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_R.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "R" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "r")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "R" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "R")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "R, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_K.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_K.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "K" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "k")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "K" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "K")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "K, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_A.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_A.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "A" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "a")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "A" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "A")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "A, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_C.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_C.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If checkLetter = "C" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "c")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "C" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "C")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "C, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_J.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_J.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)

            If checkLetter = "J" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "j")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "J" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "J")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "J, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_P.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "P" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "p")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "P" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "P")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "P, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_T.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_T.Enabled = False
        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "T" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "t")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "T" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "T")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "T, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Y.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_Y.Enabled = False
        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "Y" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "y")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "Y" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "Y")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "Y, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_F.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_F.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "F" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "f")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
            If UCase(checkLetter) = "F" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "F")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "F, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_H.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "H" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "h")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "H" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "H")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "H, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_U.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_U.Enabled = False
        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "U" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "u")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "Y" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "Y")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "U, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_I.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_I.Enabled = False
        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "I" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "i")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "I" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "I")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "I, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_O.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_O.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "O" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "o")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "O" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "O")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "O, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_S.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_S.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "S" And OrigWord <> "Serbia" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "s")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If


            If UCase(checkLetter) = "S" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "S")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "S, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_G.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_G.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "G" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "g")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "G" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "G")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "G, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_L.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_L.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "L" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "l")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "L" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "L")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "L, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Z.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_Z.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "Z" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "z")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "Z" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "Z")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "Z, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_X.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_X.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "X" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "x")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "X" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "X")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "X, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_V.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_V.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "V" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "v")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "V" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "V")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "V, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_B.Click
        'Checks if the player has guessed the right letter in the word, and replace the underscore with the right guessed letter 
        btn_B.Enabled = False

        For x = 1 To Len(word)
            checkLetter = Mid(word, x, 1)
            If UCase(checkLetter) = "B" Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "b")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If

            If UCase(checkLetter) = "B" And x = 1 Then
                hiddenWord = hiddenWord.Remove(x, 1).Insert(x, "B")
                lbl_Letters.Text = hiddenWord
                verifyWord = True
                winCheck()
            End If
        Next

        'If the guessed letter is not part of the generated word, adding the letter to the guessed wrong text box
        If verifyWord = False Then
            txt_Missed.Text = txt_Missed.Text + "B, "
            guessCounter -= 1
            bodyCounter -= 1
            loseCheck()
        Else
            verifyWord = False
        End If
    End Sub

    Private Sub btn_Lose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lose.Click
        'Setting up the 'give up' button in the game and resetting everything to default when player wants to give up on the generated word
        If guessCounter = 10 Then
            MessageBox.Show("Please try before giving up!", "Wheel of Hangman", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If MessageBox.Show("Do you really wish to give up that easily?", "Wheel of Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                reset()
                RandomWord()
            End If
        End If
    End Sub

    Private Sub rdo_Easy_CheckedChanged(ByVal sender As System.Object) Handles rdo_Easy.CheckedChanged
        'Changing the title and the game subject of the form when the player chooses the easiest game mode
        If rdo_Easy.Checked = True Then
            thm_Main.Text = "Wheel of Hangman [Easy]"
            lbl_Subject.Text = "Countries"
            btn_StrtOver.Enabled = True
        End If
    End Sub

    Private Sub tmr_Check_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Update.Tick
        'Updates the statistics of the player everytime the timer is being executed
        lbl_Guess.Text = guessCounter
        lbl_Wrong.Text = wrongCounter
        lbl_Score.Text = winCounter
        lbl_Length.Text = Int((wordLen / 2) + 1)

        If lbl_Length.Text = "1" Then
            lbl_Length.Text = "0"
        End If

    End Sub

    Private Sub rdo_Medium_CheckedChanged(ByVal sender As System.Object) Handles rdo_Medium.CheckedChanged
        'Changing the title and the game subject of the form when the player chooses the medium game mode
        If rdo_Medium.Checked = True Then
            thm_Main.Text = "Wheel of Hangman [Medium]"
            lbl_Subject.Text = "Cars Brands"
            btn_StrtOver.Enabled = True
        End If
    End Sub

    Private Sub rdo_Hard_CheckedChanged(ByVal sender As System.Object) Handles rdo_Hard.CheckedChanged
        'Changing the title and the game subject of the form when the player chooses the hardest game mode
        If rdo_Hard.Checked = True Then
            thm_Main.Text = "Wheel of Hangman [Hard]"
            lbl_Subject.Text = "Dog Breeds"
            btn_StrtOver.Enabled = True
        End If
    End Sub

    Private Sub btn_newGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_newGame.Click
        'Resetting everything and re-enabling certain controllers when the player wishes to start a new game
        If MessageBox.Show("Do you really wish to give up that easily?", "Wheel of Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            reset()
            btn_Lose.Enabled = False
            grp_Letters.Enabled = False
            grp_Mode.Enabled = True
            btn_StrtOver.Enabled = True
            wrongCounter = 0
            winCounter = 0
            MessageBox.Show("Feel free to change the game mode.", "Wheel of Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class


