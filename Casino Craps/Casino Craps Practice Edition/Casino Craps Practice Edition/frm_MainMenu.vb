'Assignment 5 - Casino Craps
'By: Maor Gornik (ICS3U)
'Date: 26 of April, 2018

Public Class frm_MainMenu
    Dim userName As String 'Creating a variable to store the player's name
    Dim isFilled As Boolean 'Creating a variable to check if the player has filled the required information
    Dim changeCounter As Integer 'Creating a variable that will check if the player has changed the username



    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        'Lets the player enter a name and saves the name
        userName = txt_Name.Text
        If userName = "" Or userName.Length < 3 Then
            MessageBox.Show("Oops! Please enter your name.", "Casino Craps Practice 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Name.Text = ""
            txt_Name.Focus()
        Else
            MessageBox.Show("Welcome " + userName.ToUpper + "!" + Environment.NewLine + "This is our practice mode. Please be sure to check our premium mode!", "Casino Craps Practice 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            isFilled = True
            btn_Practice.Focus()
        End If
    End Sub

    Private Sub btn_Practice_Click(sender As Object, e As EventArgs) Handles btn_Practice.Click
        'Increments the counter by 1 to check if the player wishes to change the username
        changeCounter = changeCounter + 1
        'Checks if the player has chosen a username and opens the main game form
        If isFilled = False Then
            MessageBox.Show("Oops! Please fill up and submit all the information.", "Casino Craps Practice 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Name.Text = ""
            txt_Name.Focus()
        ElseIf userName = txt_Name.Text And changeCounter >= 2 Then
            Dim response = MessageBox.Show("No new information was submitted. Do you wish to continue?", "Casino Craps Practice 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If response = MsgBoxResult.Yes Then
                Me.Refresh()
                Me.Hide()
                frm_Craps.Visible = True
            End If
        Else
            Me.Hide()
            frm_Craps.Visible = True
        End If
    End Sub

    Private Sub btn_Premium_Click(sender As Object, e As EventArgs) Handles btn_Premium.Click
        'Lets the user know about the 'premium' game version
        MessageBox.Show("Please be sure to check our premium version at supercasino.com", "Casino Craps Practice Edition 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_Instructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Instructions.Click
        'Hides the current form and opens the instructions form
        Me.Hide()
        frm_Instructions.Visible = True
    End Sub
End Class
