'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Ellinia
    Dim charCount As Integer = 1 'A variable used for creating the player's moving animation
    Dim MonsterCount As Integer = 1 'A variable used for creating the monsters' moving animation
    Dim HPcount As Integer = 5 'A variable used to keep a track of the player's health
    Dim MPcount As Integer = 5 'A variable used to keep a track of the player's mana (Magicial power which allows the player to attack)
    Dim currentY As Integer 'A variable used to keep a track of the player's latest jumping height 
    Dim monsterFlag(1) As String 'A variable used to keep a track of the monsters' direction of movment
    Dim monsterHit(1) As Integer 'A variable used to keep a track of the monsters' remaining health
    Dim isKilled(1) As Boolean 'A variable used to keep a track of the monsters' death
    Dim isUpper As Boolean 'A variable used to keep check if the player has used the teleport
    Dim inventoryCount As Integer 'A variable used to keep a track of number of times the inventory has been opened
    Dim canTeleport As Boolean = True 'A variable used to determine whether the player can use the teleport
    Dim canJump As Boolean = True 'A variable used to determine whether the player can jump
    Dim controlCounter As Long 'A variable used to keep a track of the player's attacking animation
    Dim flipFlag As String 'A variable used to keep a track of the player's direction of movment
    Dim revFlag As String 'A variable used to keep a track of the monsters reverse movment (to make them follow the player when attacking)
    Dim isAttack As Boolean 'A variable used to determine whether the player is attacking
    Dim mMonster(1) As Double 'A variable used to keep a track of the monsters' slope (used for making the path)
    Dim m As Double 'A variable used to keep a track of the player's slope (used for making the path)
    '========================================================================================================================================'
    'Character Related Variables
    Private CharBmp As New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Stationary(R).png") 'A variable used to take the image and turn it into a bitmap
    Private CharRect As Rectangle 'A variable used to make a rectangle around the player to have control over it

    'Monsters Related Variables
    Private MonsterBmp As New List(Of Bitmap) 'A set of variables used to take the image and turn it into a bitmap
    Private MonsterRect(1) As Rectangle 'A variable used to deploy a rectangle around the monster to have control over it

    'Inventory Related Variables
    Private InventoryBmp As New Bitmap(Environment.CurrentDirectory + "\pictures\Inventory.png") 'A variable used to take the image and turn it into a bitmap
    Private InventoryRect As Rectangle 'A variable used to make a rectangle around the inventory to have hide and unhide it smoothly
    '========================================================================================================================================'

    'Importing the user32.dll library for a much more faster and much more reliable keypress recognition API
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="GetAsyncKeyState")> _
    Public Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Short
    End Function

    Private Sub frm_Ellinia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'On form load event, loading all the neccesary pictures and setting up the required variables
        Try
            'Changing the in-game cursor
            Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
            pic_Level.Parent = pic_Background
            pic_NPC.Parent = pic_Background
            Randomize()
            CharRect.Y = 336
            monsterFlag(1) = "left"
            Me.KeyPreview = True
            tmr_Walk.Enabled = True

            'Changing the music in the background and looping it
            snd_Ellinia.URL = Environment.CurrentDirectory + "\soundtracks\Maplestory Ellinia.mp3"
            snd_Ellinia.settings.setMode("loop", True)

            'Drawing the character and the inventory images to the form itself
            CharRect = New Rectangle(10, 250, CharBmp.Width, CharBmp.Height) 'sets the character at a starting location
            InventoryRect = New Rectangle(0, 0, 0, 0)

            'Setting up the monsters and drawing them to the form
            Dim Monster1 As New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeStationary.png")
            MonsterBmp.Add(Monster1)
            MonsterRect(0) = New Rectangle(10, 250, Monster1.Width - 10, Monster1.Height - 10) 'sets the monster at a starting location\
            'Monster 2
            Dim Monster2 As New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeStationary.png")
            MonsterBmp.Add(Monster2)
            MonsterRect(1) = New Rectangle(650, 250, Monster2.Width - 10, Monster2.Height - 10)
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        'Setting up an auto save feature for the game that will always save the player's current level
        Try
            Dim streamRead As System.IO.StreamReader = New System.IO.StreamReader(Environment.CurrentDirectory + "/saves/level.txt")
            Level = streamRead.ReadLine()
            If Level = 0 Then
                Level = 10
            Else
                lbl_Lvl.Text = Level
                streamRead.Close()
            End If

            'Setting up an auto save feature for the game that will always save the player's experience points
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Environment.CurrentDirectory + "/saves/EXP.txt")
            EXP = streamReader.ReadLine()
            streamReader.Close()
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("The game couldn't load successfully! One of files is being used by another program. Please close it and then try again!", "String Replacement Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Exit()
        End Try
    End Sub

    Private Sub tmr_Animation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Animation.Tick
        'Settings up the player's complete path animation for the first floor level ================================
        If isUpper = False And isPaused = False Then
            If CharRect.X < 140 Then
                m = (L1targetStrt.Top - L1target.Top) / (L1targetStrt.Left - L1target.Left)
                charWalk()
                CharRect.Y = m * (CharRect.X - L1target.Left) + L1target.Top

            ElseIf CharRect.X > 140 And CharRect.X < 310 Then
                m = (L1target2.Top - L1target.Top) / (L1target2.Left - L1target.Left)
                If CharRect.X >= 160 Then m -= 0.01
                If CharRect.X >= 170 Then m -= 0.05
                If CharRect.X >= 180 Then m -= 0.05
                If CharRect.X > 200 Then m -= 0.05
                charWalk()
                CharRect.Y = m * (CharRect.X - L1target2.Left) + L1target2.Top

            ElseIf CharRect.X > 310 And CharRect.X < 435 Then
                m = -0.192265193370166
                If CharRect.X >= 365 Then m -= 0.1
                If CharRect.X >= 400 Then m -= 0.1
                If CharRect.X > 440 Then m -= 0.5
                charWalk()
                CharRect.Y = m * (CharRect.X - L1target3.Left) + L1target3.Top

            ElseIf CharRect.X > 435 And CharRect.X < 600 Then
                m = (L1target4.Top - L1target3.Top) / (L1target4.Left - L1target3.Left)
                If CharRect.X >= 435 Then m -= 0.1
                If CharRect.X > 480 Then m -= 0.05
                charWalk()
                CharRect.Y = m * (CharRect.X - L1target4.Left) + L1target4.Top

            ElseIf CharRect.X > 600 Then
                m = (L1target4.Top - L1target5.Top) / (L1target4.Left - L1target5.Left)
                charWalk()
                CharRect.Y = m * (CharRect.X - L1target5.Left) + L1target5.Top
            End If
        End If

        'Settings up the player's complete path animation for the second floor level ================================
        If isUpper = True Then
            If CharRect.X < 140 Then
                m = ((L2targetStrt.Top - 100) - L2target.Top) / (L2targetStrt.Left - L2target.Left)
                charWalk()
                CharRect.Y = m * (CharRect.X - L2target.Left) + L2target.Top

            ElseIf CharRect.X > 140 And CharRect.X < 290 Then
                m = (L2target2.Top - L2target.Top) / (L2target2.Left - L2target.Left)
                If CharRect.X > 250 Then m += 0.05
                If CharRect.X > 260 Then m += 0.05
                If CharRect.X > 265 Then m += 0.05
                If CharRect.X > 270 Then m += 0.05
                If CharRect.X > 275 Then m += 0.05
                If CharRect.X > 280 Then m += 0.2
                If CharRect.X > 285 Then m += 0.2
                charWalk()
                CharRect.Y = m * (CharRect.X - L2target2.Left) + L2target2.Top

            ElseIf CharRect.X > 290 And CharRect.X < 455 Then
                m = -0.292265193370166
                If CharRect.X >= 290 Then m += 0.2
                If CharRect.X >= 335 Then m -= 0.05
                If CharRect.X >= 340 Then m -= 0.05
                If CharRect.X >= 395 Then m -= 0.1
                If CharRect.X >= 400 Then m -= 0.1
                If CharRect.X >= 440 Then m -= 0.4
                If CharRect.X >= 445 Then m -= 0.4
                charWalk()
                CharRect.Y = m * (CharRect.X - L2target3.Left) + L2target3.Top

            ElseIf CharRect.X > 455 And CharRect.X < 600 Then
                m = (L2target4.Top - L2target3P2.Top) / (L2target4.Left - L2target3P2.Left)
                charWalk()
                CharRect.Y = m * (CharRect.X - L2target4.Left) + L2target4.Top
            End If
        End If

        'Creating the player's attack animation when control key is pressed and player is attacking (player must hold the control key to attack)
        Try
            If isAttack = True Then
                prg_Attack.Increment(10)

                If prg_Attack.Value = 20 Then

                    If flipFlag <> "left" Then
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att1(R).png")
                    Else
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att1.png")
                    End If
                    Threading.Thread.Sleep(20)

                ElseIf prg_Attack.Value = 40 Then

                    If flipFlag <> "left" Then
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att2(R).png")
                    Else
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att2.png")
                    End If
                    Threading.Thread.Sleep(20)

                ElseIf prg_Attack.Value = 60 Then

                    If flipFlag <> "left" Then
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att3(R).png")
                    Else
                        CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Att3.png")
                    End If
                    Threading.Thread.Sleep(20)

                ElseIf prg_Attack.Value = 90 Then
                    prg_Attack.Value = 0
                    isAttack = False
                    tmr_Walk.Enabled = True
                End If
            End If
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        'Notifying the player that they have no MP (Mana) left
        If prg_MP.Value = 0 Then lbl_Status.Text = "Not enough MP!"

        'Making sure player not crosses the required monster amount kills
        If killCount > reqKills Then killCount -= 1

        'Calls the levelUp function which is supposed to increment the level variable by one and play a sound when player levels up
        If EXP = 100 Then
            levelUp()

            'Displaying the quest finish button when player has successfully killed the required amount of monsters
        ElseIf killCount = reqKills Then
            btn_Finish.Visible = True
        End If

        'Displays the player's current level
        lbl_Lvl.Text = Level

        'Displaying the player's remaining amount of HP (Health) and MP (Mana) potions in the inventory
        lbl_HP.Text = HPcount
        lbl_MP.Text = MPcount
    End Sub

    'Setting up the levelUp function which is suppose to increment the player's level by one and play a quick sound
    Sub levelUp()
        Try
            EXP = 0
            Level += 1
            pic_Level.Visible = True
            If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\level-up.wav")
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    'Setting up a function that will allow the player to use certain keys to move, attack and jump
    Sub charWalk()
        Try
            'Using the GetAsyncKeyState function to determine whether the left arrow is pressed and execute a code
            If GetAsyncKeyState(Keys.Left) <> 0 And isAttack = False And frm_Chat.Visible = False Then
                'Determining in what direction the player is going
                flipFlag = "left"
                revFlag = "right"

                'Allows the player to teleport when standing on the portal
                If CharRect.X >= 105 Then canTeleport = True
                'Displaying the level up picture box when player has leveled up
                If EXP <> 100 Then pic_Level.Visible = False
                'Incrementing the player's animation variable
                charCount = charCount + 1
                'Moving the character in the left direction
                CharRect.X -= 5

                'Looping the player's animation
                If controlCounter < 10 Then controlCounter = 0
                If charCount > 3 Then charCount = 1

                'Using the GetAsyncKeyState function to determine whether the control key is pressed and execute a code
            ElseIf GetAsyncKeyState(Keys.ControlKey) <> 0 And prg_Jump.Value = 0 And prg_MP.Value <> 0 Then
                'Incrementing the player's control key attacking animation variable
                controlCounter += 1
                isAttack = True
                tmr_Walk.Enabled = False

                'Determining the end of the attacking animation, deducting 10 MP (Mana) points and using a sound
                If controlCounter = 10 Then
                    prg_MP.Value -= 10
                    If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\attack.wav")

                    'Determining whether the player intersects with the first monster and hits the monster
                    If CharRect.IntersectsWith(MonsterRect(0)) Then
                        'Setting up a variable that will make the monster follow the player when attacked
                        monsterFlag(0) = revFlag

                        'When monster 1 is attacked, change its picture to a one that shows that he is being hit according to its direction of motion
                        If monsterFlag(0) <> "left" Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeDead(R).png")
                        Else
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeDead.png")
                        End If
                        monsterHit(0) += 1
                    End If

                    'Determining whether the player intersects with the second monster and hits the monster
                    If CharRect.IntersectsWith(MonsterRect(1)) Then
                        monsterFlag(1) = revFlag

                        'When monster 1 is attacked, change its picture to a one that shows that he is being hit according to its direction of motion
                        If monsterFlag(1) <> "left" Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeDead(R).png")
                        Else
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeDead.png")
                        End If
                        monsterHit(1) += 1
                    End If

                    'Setting up the amount needed to hit the monster in order to kill it (2 times)
                    If monsterHit(0) = 2 And isKilled(0) = False Then
                        'Eliminate the monster - Dead
                        monsterHit(0) = 0
                        isKilled(0) = True
                        HPcount += 5
                        MPcount += 5
                        EXP += 10
                        'Checking whether the player has accepted the quest and starting to count the amount of kills
                        If isDeclined = False And killCount <= reqKills Then lbl_Status.Text = "Quest: " & killCount + 1 & "/" & reqKills
                        If isDeclined = False Then killCount += 1
                        tmr_Death.Enabled = True
                    End If

                    'Hit the monster 2 in order to kill it
                    If monsterHit(1) = 2 And isKilled(1) = False Then
                        'Eliminate the monster - Dead
                        monsterHit(1) = 0
                        isKilled(1) = True
                        HPcount += 5
                        MPcount += 5
                        EXP += 10
                        'Checking whether the player has accepted the quest and starting to count the amount of kills
                        If isDeclined = False And killCount <= reqKills Then lbl_Status.Text = "Quest: " & killCount + 1 & "/" & reqKills
                        If isDeclined = False Then killCount += 1
                        tmr_Death.Enabled = True
                    End If
                    'Resetting the attack animation back to its default state
                    controlCounter = 0
                End If

                'Using the GetAsyncKeyState function to determine whether the right arrow is pressed and execute a code
            ElseIf GetAsyncKeyState(Keys.Right) <> 0 And isAttack = False And frm_Chat.Visible = False Then
                'Determining in what direction the player is going
                flipFlag = "right"
                revFlag = "left"

                'Allows the player to teleport when standing on the portal
                If CharRect.X >= 105 Then canTeleport = True
                'Displaying the level up picture box when player has leveled up
                If EXP <> 100 Then pic_Level.Visible = False
                'Incrementing the player's animation variable
                charCount += 1
                'Moving the character in the left direction
                CharRect.X += 5

                'Looping the player's animation
                If controlCounter < 10 Then controlCounter = 0
                If charCount > 3 Then charCount = 1

            Else
                'Determining if the player is going to the right and changing the player's picture
                If flipFlag <> "left" Then
                    CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Stationary(R).png")
                Else
                    'Determining if the player is going to the left and changing the player's picture
                    CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Stationary.png")
                End If
                'Resetting the player's walking animation
                charCount = 0
            End If

            'Restricting the player from going off the form on the X-axis on the first level
            If CharRect.X < -25 Then CharRect.X = -5

            'Restricting the player from going off the form on the X-axis on the first level
            If CharRect.X > (thm_Ellinia.Width - CharRect.Width) + 20 Then CharRect.X = 660
            'Restricting the player from going off the form on the X-axis on the second level 
            If CharRect.X > (thm_Ellinia.Width - CharRect.Width) And isUpper = True Then CharRect.X = 640
            'Restricting the player from  walking off the form on the X-axis on the second level 
            If CharRect.X <= 55 And isUpper = True Then CharRect.X = 65
            'Restricting the player from  falling off the form (Y-axis)
            If CharRect.Y < 0 Then CharRect.Y = 0
            If CharRect.Bottom > Me.ClientRectangle.Bottom Then CharRect.Y = Me.ClientRectangle.Bottom - CharRect.Height
            'Refreshing the form to avoid any lags
            Me.Refresh()
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Determining whether the space button is pressed and allowing the player to jump if found right
        If keyData = Keys.Space And isAttack = False And CharRect.Y > currentY And CharRect.X < 625 Then
            'Determining whether the player is in the first floor level
            If CharRect.Y >= 245 Then
                tmr_Animation.Enabled = False
                tmr_Jump.Enabled = True
            Else
                'Determining whether the player is in the second floor level and printing a message on the label
                lbl_Status.Text = "You cannot jump in here!"
            End If
            'Determining whether the player is in the second floor level and printing a message on the label
        ElseIf keyData = Keys.Space And isUpper Then
            lbl_Status.Text = "You cannot jump in here!"
            'Determining whether the I button is pressed and opening the player's inventory
        ElseIf keyData = Keys.I Then
            inventoryCount += 1
            'Loading the inventory and all of what it contains
            If inventoryCount = 1 Then
                lbl_NPC.Visible = False
                pic_NPC.Visible = False
                InventoryRect = New Rectangle(Me.Width - (InventoryBmp.Width + 30), 50, InventoryBmp.Width, InventoryBmp.Height)
                pic_HP.Visible = True
                pic_MP.Visible = True
                lbl_HP.Visible = True
                lbl_MP.Visible = True
                btn_InvClose.Visible = True

            Else
                'Unloading the inventory and all of what it contains
                inventoryCount = 0
                InventoryRect = New Rectangle(0, 0, 0, 0)
                lbl_NPC.Visible = True
                pic_NPC.Visible = True
                pic_HP.Visible = False
                pic_MP.Visible = False
                lbl_HP.Visible = False
                lbl_MP.Visible = False
                btn_InvClose.Visible = False
            End If

            'Determining whether the H button is pressed and calling the reduceHP function which increments the player's HP (Health) value
        ElseIf keyData = Keys.H Then
            reduceHP()

            'Determining whether the M button is pressed and calling the reduceMP function which increments the player's MP (Mana) value
        ElseIf keyData = Keys.M Then
            reduceMP()
            'Determining whether the Escape button is pressed and asking the player for premission to log out of the game
        ElseIf keyData = Keys.Escape Then
            pause()
            If MessageBox.Show("Do you wish to log out?", "Maplestory - Forbidden Identitiy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Application.Restart()
            Else
                pauseCounter = 2
            End If
        End If
        'End of function 
        Return True
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub tmr_Walk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Walk.Tick
        Try
            'Executing the code below if game is not paused
            If isPaused = False Then
                charWalk()

                'Setting up the player's walking animation with respect to the direction of movment 
                If flipFlag <> "left" Then
                    Select Case charCount
                        Case 1
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov1(R).png")
                            Threading.Thread.Sleep(20)
                        Case 2
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov2(R).png")
                            Threading.Thread.Sleep(20)
                        Case Else
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov1(R).png")
                            charCount = 0
                    End Select

                Else
                    Select Case charCount
                        Case 1
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov1.png")
                            Threading.Thread.Sleep(20)
                        Case 2
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov2.png")
                            Threading.Thread.Sleep(20)
                        Case Else
                            CharBmp = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Mov1.png")
                            charCount = 0
                    End Select
                End If

                If tmr_Jump.Enabled = False And CharRect.Y >= 245 Then
                    tmr_Animation.Enabled = True
                End If

                'Using the GetAsyncKeyState function to determine whether the up arrow is pressed and teleporting the player upwards if standing on the portal
                If GetAsyncKeyState(Keys.Up) <> 0 And CharRect.Y = 0 And CharRect.X >= 65 And CharRect.X <= 90 And canTeleport = True Then
                    canTeleport = False
                    If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\portal.wav")
                    isUpper = False
                    CharRect.Y += 250

                    'Using the GetAsyncKeyState function to determine whether the up arrow is pressed and teleporting the player back if standing on the portal
                ElseIf GetAsyncKeyState(Keys.Up) <> 0 And CharRect.X >= 65 And CharRect.X <= 90 And canTeleport = True Then
                    canTeleport = False
                    If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\portal.wav")
                    isUpper = True
                    CharRect.Y -= 250
                End If

                'Checking if the player intersects with the first monster and taking away 10 HP (Health) points and slightly moving the player
                If CharRect.IntersectsWith(MonsterRect(0)) Then
                    'Drop Player's HP
                    prg_HP.Value -= 1

                    If flipFlag <> "left" Then
                        CharRect.X -= 1
                    Else
                        CharRect.X += 1
                    End If

                    'Checking if the player intersects with the second monster and taking away 10 HP (Health) points and slightly moving the player
                ElseIf CharRect.IntersectsWith(MonsterRect(1)) Then
                    prg_HP.Value -= 1

                    If flipFlag <> "left" Then
                        CharRect.X -= 1
                    Else
                        CharRect.X += 1
                    End If
                End If
            End If
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub pic_Background_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_Background.Paint
        'Drawing all the bitmaps straight to the form (on the screen)
        With e.Graphics
            .DrawImage(MonsterBmp(0), MonsterRect(0)) 'Draws the second monster
            .DrawImage(MonsterBmp(1), MonsterRect(1)) 'Draws the first monster
            .DrawImage(CharBmp, CharRect) 'Draws the character
            .DrawImage(InventoryBmp, InventoryRect) 'Draws the Inventory
        End With
    End Sub

    Private Sub tmr_Jump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Jump.Tick
        'Setting up the player's jumping animation using gravity when space key is pressed and isAttack becomes true
        If isAttack = False And isPaused = False Then
            prg_Jump.Increment(10)
            Threading.Thread.Sleep(30)

            If CharRect.X >= -25 And CharRect.X <= 665 And tmr_Animation.Enabled = False Then
                tmr_Animation.Enabled = True
            Else
                tmr_Animation.Enabled = False
            End If

            If prg_Jump.Value = 10 Then
                CharRect.Y -= 10

                If flipFlag = "right" Then

                    CharRect.X += 5
                Else
                    CharRect.X -= 5
                End If

            ElseIf prg_Jump.Value = 20 Then
                CharRect.Y -= 10

                If flipFlag = "right" Then

                    CharRect.X += 5
                Else
                    CharRect.X -= 5
                End If

            ElseIf prg_Jump.Value = 30 Then
                CharRect.Y -= 10

                If flipFlag = "right" Then

                    CharRect.X += 5
                Else
                    CharRect.X -= 5
                End If

            ElseIf prg_Jump.Value = 40 Then
                CharRect.Y -= 10

                If flipFlag = "right" Then

                    CharRect.X += 5
                Else
                    CharRect.X -= 5
                End If

            ElseIf prg_Jump.Value = 50 Then
                CharRect.Y -= 5

                If flipFlag = "right" Then

                    CharRect.X += 5
                Else
                    CharRect.X -= 5
                End If

            ElseIf prg_Jump.Value = 60 Then
                CharRect.Y += 5

            ElseIf prg_Jump.Value = 70 Then
                CharRect.Y += 5

            ElseIf prg_Jump.Value = 80 Then
                CharRect.Y += 15
                currentY = CharRect.Y

            ElseIf prg_Jump.Value = 90 Then
                prg_Jump.Value = 0
                tmr_Jump.Enabled = False

            ElseIf prg_Jump.Value = 100 Then
                tmr_Jump.Enabled = False
            End If
        End If
    End Sub

    Private Sub tmr_Monster_Tick(sender As Object, e As EventArgs) Handles tmr_Monster.Tick
        'Setting up both of the monsters' walking animation
        Try
            If isPaused = False Then
                Select Case MonsterCount
                    Case 1
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump1(R).png")
                        Else '<== Problem
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump1.png")
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" And isKilled(0) = False Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump1(R).png")
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump1.png")
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount += 1

                    Case 2
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump2(R).png")
                        Else
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump2.png")
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" And isKilled(0) = False Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump2(R).png")
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump2.png")
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount += 1

                    Case 3
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump3(R).png")
                            If isKilled(0) <> True Then MonsterRect(0).X += 25
                        Else
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump3.png")
                            If isKilled(0) = False Then MonsterRect(0).X -= 25
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" And isKilled(0) = False Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump3(R).png")
                            If isKilled(1) <> True Then MonsterRect(1).X += 25
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump3.png")
                            If isKilled(1) <> True Then MonsterRect(1).X -= 25
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount += 1

                    Case 4
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump4(R).png")
                        Else
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump4.png")
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump4(R).png")
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump4.png")
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount += 1

                    Case 5
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump5(R).png")
                        Else
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump5.png")
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump5(R).png")
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeJump5.png")
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount += 1

                    Case Else
                        'Monster 1
                        If monsterFlag(0) <> "left" And isKilled(0) = False Then
                            MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeRest(R).png")
                        Else
                            If isKilled(0) = False Then MonsterBmp(0) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeRest.png")
                        End If

                        'Monster 2
                        If monsterFlag(1) <> "left" Then
                            MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeRest(R).png")
                        Else
                            If isKilled(1) = False Then MonsterBmp(1) = New Bitmap(Environment.CurrentDirectory + "\pictures\Animation\Monsters\SlimeRest.png")
                        End If
                        'Constantly changing both of the monsters' picture
                        MonsterCount = 1
                End Select

                'Settings up the first monster's complete path animation ================================
                If isKilled(0) = False Then
                    If MonsterRect(0).X < 140 Then
                        mMonster(0) = (L1targetStrt.Top - L1target.Top) / (L1targetStrt.Left - L1target.Left)
                        MonsterRect(0).Y = mMonster(0) * (MonsterRect(0).X - L1target.Left) + L1target.Top
                        If MonsterRect(0).X < 0 Then monsterFlag(0) = "right"

                    ElseIf MonsterRect(0).X > 140 And MonsterRect(0).X < 310 Then
                        mMonster(0) = (L1target2.Top - L1target.Top) / (L1target2.Left - L1target.Left)
                        If MonsterRect(0).X >= 160 Then mMonster(0) += 0.1
                        If MonsterRect(0).X >= 170 Then mMonster(0) += 0.1
                        If MonsterRect(0).X >= 180 And MonsterRect(0).X <= 240 Then mMonster(0) += 0.1
                        MonsterRect(0).Y = mMonster(0) * (MonsterRect(0).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(0).X >= 240 And MonsterRect(0).X < 435 Then
                        mMonster(0) = ((L1target3.Top + 150) - L1target2.Top) / ((L1target3.Left + 150) - L1target2.Left)
                        If MonsterRect(0).X >= 355 Then mMonster(0) -= 0.1
                        If MonsterRect(0).X >= 410 Then mMonster(0) -= 0.05
                        MonsterRect(0).Y = mMonster(0) * (MonsterRect(0).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(0).X > 480 And MonsterRect(0).X < 600 Then
                        mMonster(0) = ((L1target4.Top + 90) - L1target3.Top) / ((L1target4.Left + 90) - L1target3.Left)
                        If MonsterRect(0).X >= 485 Then mMonster(0) -= 0.01
                        If MonsterRect(0).X >= 510 Then mMonster(0) -= 0.01
                        If MonsterRect(0).X >= 535 Then mMonster(0) -= 0.05
                        If MonsterRect(0).X = 560 Then mMonster(0) -= 0.05
                        If MonsterRect(0).X > 560 Then mMonster(0) -= 0.05
                        If MonsterRect(0).X = 585 Then mMonster(0) -= 0.05
                        MonsterRect(0).Y = mMonster(0) * (MonsterRect(0).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(0).X >= 610 Then
                        mMonster(0) = ((L1target5.Top - 10) - L1target4.Top) / ((L1target5.Left - 10) - L1target4.Left)
                        If MonsterRect(0).X > thm_Ellinia.Width - MonsterRect(0).Width Then
                            monsterFlag(0) = "left"
                            MonsterRect(0).X = thm_Ellinia.Width - MonsterRect(0).Width 'Turn the monster to the left side
                        End If
                        MonsterRect(0).Y = mMonster(0) * (MonsterRect(0).X - L1target.Left) + L1target.Top
                    End If
                End If

                'Settings up the second monster's complete path animation ================================

                If isKilled(1) = False Then
                    If MonsterRect(1).X < 140 Then
                        mMonster(1) = (L1targetStrt.Top - L1target.Top) / (L1targetStrt.Left - L1target.Left)
                        MonsterRect(1).Y = mMonster(1) * (MonsterRect(1).X - L1target.Left) + L1target.Top
                        If MonsterRect(1).X < 0 Then monsterFlag(1) = "right"

                    ElseIf MonsterRect(1).X > 140 And MonsterRect(1).X < 310 Then
                        mMonster(1) = (L1target2.Top - L1target.Top) / (L1target2.Left - L1target.Left)
                        If MonsterRect(1).X >= 160 Then mMonster(1) += 0.1
                        If MonsterRect(1).X >= 170 Then mMonster(1) += 0.1
                        If MonsterRect(1).X >= 180 And MonsterRect(1).X <= 240 Then mMonster(1) += 0.1
                        MonsterRect(1).Y = mMonster(1) * (MonsterRect(1).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(1).X >= 240 And MonsterRect(1).X < 435 Then
                        mMonster(1) = ((L1target3.Top + 150) - L1target2.Top) / ((L1target3.Left + 150) - L1target2.Left)
                        If MonsterRect(1).X >= 355 Then mMonster(1) -= 0.1
                        If MonsterRect(1).X >= 410 Then mMonster(1) -= 0.05
                        MonsterRect(1).Y = mMonster(1) * (MonsterRect(1).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(1).X > 480 And MonsterRect(1).X < 600 Then
                        mMonster(1) = ((L1target4.Top + 90) - L1target3.Top) / ((L1target4.Left + 90) - L1target3.Left)
                        If MonsterRect(1).X >= 485 Then mMonster(1) -= 0.01
                        If MonsterRect(1).X >= 510 Then mMonster(1) -= 0.01
                        If MonsterRect(1).X >= 535 Then mMonster(1) -= 0.05
                        If MonsterRect(1).X = 560 Then mMonster(1) -= 0.05
                        If MonsterRect(1).X > 560 Then mMonster(1) -= 0.05
                        If MonsterRect(1).X = 585 Then mMonster(1) -= 0.05
                        MonsterRect(1).Y = mMonster(1) * (MonsterRect(1).X - L1target.Left) + L1target.Top

                    ElseIf MonsterRect(1).X >= 610 Then
                        mMonster(1) = ((L1target5.Top - 10) - L1target4.Top) / ((L1target5.Left - 10) - L1target4.Left)
                        If MonsterRect(1).X > thm_Ellinia.Width - MonsterRect(1).Width Then
                            monsterFlag(1) = "left"
                            MonsterRect(1).X = thm_Ellinia.Width - MonsterRect(1).Width 'Turn the monster to the left side
                        End If
                        MonsterRect(1).Y = mMonster(1) * (MonsterRect(1).X - L1target.Left) + L1target.Top
                    End If
                End If
            End If
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    'Setting up the reduceHP function which will increment the player's HP (Health) points if enough potions are found in the inventory
    Sub reduceHP()
        Try
            If prg_HP.Value <= 90 And HPcount <> 0 Then
                prg_HP.Value += 10
                HPcount -= 1
                If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\potionHP.wav")
                'Writing to console an update on the status of the player's HP (Health)
                lbl_Status.Text = "HP Potion was used! +10HP"
            ElseIf prg_HP.Value = 100 Then
                lbl_Status.Text = "HP is already full!"
            ElseIf HPcount = 0 Then
                lbl_Status.Text = "No HP potions remaining!"
            End If
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    'Setting up the reduceHP function which will increment the player's MP (Mana) points if enough potions are found in the inventory
    Sub reduceMP()
        Try
            If prg_MP.Value <= 90 And MPcount <> 0 Then
                prg_MP.Value += 10
                MPcount -= 1
                If isMuted <> True Then My.Computer.Audio.Play(Environment.CurrentDirectory + "\soundtracks\potionMP.wav")
                'Writing to console an update on the status of the player's MP (Mana)
                lbl_Status.Text = "MP Potion was used! +10MP"
            ElseIf prg_MP.Value = 100 Then
                lbl_Status.Text = "MP is already full!"
            ElseIf MPcount = 0 Then
                lbl_Status.Text = "No MP potions remaining!"
            End If
            'Catching unnecessary errors and notifying the user what might be the problem
        Catch ex As Exception
            MessageBox.Show("Couldn't find all files. Please make sure all files are in the same folder and then try again!", "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub
    Private Sub pic_HP_DoubleClick(sender As Object, e As EventArgs) Handles pic_HP.DoubleClick
        'Calling the reduceHP function when HP (Health) potion is double clicked
        reduceHP()
    End Sub

    Private Sub btn_InvClose_Click(sender As Object, e As EventArgs) Handles btn_InvClose.Click
        'Closing Inventory when the close button is pressed
        inventoryCount = 0
        InventoryRect = New Rectangle(0, 0, 0, 0)
        pic_HP.Visible = False
        pic_MP.Visible = False
        btn_InvClose.Visible = False
    End Sub

    Private Sub pic_MP_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_MP.DoubleClick
        'Calling the reduceHP function when MP (Mana) potion is double clicked
        reduceMP()
    End Sub

    Private Sub tmr_Death_Tick(sender As Object, e As EventArgs) Handles tmr_Death.Tick
        'Setting up the monsters' complete death animation
        prg_Death.Increment(10)

        'Monster 1
        If prg_Death.Value = 20 Then
            If isKilled(0) = True Then MonsterRect(0).Y += 50
            If isKilled(0) = True Then MonsterBmp(0).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 2
            If isKilled(1) = True Then MonsterRect(1).Y += 50
            If isKilled(1) = True Then MonsterBmp(1).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 1
        ElseIf prg_Death.Value = 40 Then
            If isKilled(0) = True Then MonsterRect(0).Y += 50
            If isKilled(0) = True Then MonsterBmp(0).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 2
            If isKilled(1) = True Then MonsterRect(1).Y += 50
            If isKilled(1) = True Then MonsterBmp(1).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 1
        ElseIf prg_Death.Value = 60 Then
            If isKilled(0) = True Then MonsterRect(0).Y += 50
            If isKilled(0) = True Then MonsterBmp(0).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 2
            If isKilled(1) = True Then MonsterRect(1).Y += 50
            If isKilled(1) = True Then MonsterBmp(1).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 1
        ElseIf prg_Death.Value = 80 Then
            If isKilled(0) = True Then MonsterRect(0).Y += 50
            If isKilled(0) = True Then MonsterBmp(0).RotateFlip(RotateFlipType.Rotate90FlipY)

            'Monster 2
            If isKilled(1) = True Then MonsterRect(1).Y += 50
            If isKilled(1) = True Then MonsterBmp(1).RotateFlip(RotateFlipType.Rotate90FlipY)

        ElseIf prg_Death.Value = 90 Then
            'Monster 1
            If isKilled(0) = True Then MonsterRect(0).Y += 50
            If isKilled(0) = True Then
                MonsterBmp(0).RotateFlip(RotateFlipType.Rotate90FlipY)
                prg_Death.Value = 0
                tmr_Death.Enabled = False
                MonsterCount = 1
                tmr_Monster.Enabled = True
                Threading.Thread.Sleep(250)
                'After killing the monster, teleporting the monster to a random place on the map
                Dim randNum = Int(Rnd() * 665) + 1 'Generating a random number between 1 and 665
                MonsterRect(0).X = randNum
                isKilled(0) = False
            End If

            'Monster 2
            If isKilled(1) = True Then MonsterRect(1).Y += 50

            If isKilled(1) = True Then
                MonsterBmp(1).RotateFlip(RotateFlipType.Rotate90FlipY)
                prg_Death.Value = 0
                tmr_Death.Enabled = False
                MonsterCount = 1
                tmr_Monster.Enabled = True
                Threading.Thread.Sleep(250)
                'After killing the monster, teleporting the monster to a random place on the map
                Dim randNum = Int(Rnd() * 670) + 1 'Generating a random number between 1 and 665
                MonsterRect(1).X = randNum
                isKilled(1) = False
            End If
            'Refreshing the game to avoid any lags
            Me.Refresh()
        End If
    End Sub

    'Setting up the pause function which will pause the game whenever called
    Sub pause()
        pauseCounter += 1
        'Function needs to be called twice to unpause the game
        If pauseCounter = 1 Then
            isPaused = True
        Else
            pauseCounter = 0
            isPaused = False
        End If
    End Sub

    Private Sub pic_Background_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Background.Click
        'Closing the quest form when player clicks on the game background
        If frm_Chat.Visible = True Then
            tmr_Walk.Enabled = True
            isDeclined = True
            frm_Chat.Hide()

            'Refocusing on all the open forms whenever forms are open and ignored
        ElseIf frm_GameOver.Visible = True Then
            frm_GameOver.Focus()

        ElseIf frm_Shortcuts.Visible = True Then
            frm_Shortcuts.Focus()

        ElseIf frm_Quest.Visible = True Then
            frm_Quest.Focus()
        End If
    End Sub

    Private Sub pic_Shortcuts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Shortcuts.Click
        'Opening the Shortcuts form
        pause()
        frm_Shortcuts.Visible = True
    End Sub

    Private Sub pic_Stats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Stats.Click
        'Opening the Quest form
        pause()
        frm_Quest.Visible = True
    End Sub

    Private Sub pic_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Settings.Click
        'Opening the Settings form
        pause()
        frm_Settings.lbl_Name.Text = ID
        frm_Settings.Visible = True
    End Sub

    Private Sub tmr_Check_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Check.Tick
        'Constantly checking if the game is paused when not needed
        If pauseCounter = 2 Then
            pauseCounter = 0
            isPaused = False
        End If

        'Teleports the player to the starting position upon death
        If frm_GameOver.Visible = True Then
            CharRect.X = 10
        End If

        'Constantly saving the updated EXP (Experience points)
        prg_EXP.Value = EXP

        'Allowing the player to jump in the starting position even though the last Y value was way less and prevented the player from jumping
        If CharRect.X <= 145 Then
            currentY = 245
        End If

        'Updating the Quest statistics of the player
        frm_Quest.lbl_Kills.Text = killCount & "/" & reqKills
        'Updating the player's name from the log in form
        If ID <> "" And ID <> "ID" Then lbl_Name.Text = ID

        'Setting up an auto-load feature that will load the player's current level using the I/O method
        Try
            If Level > 10 Then
                Dim streamWrite As System.IO.StreamWriter = New System.IO.StreamWriter(Environment.CurrentDirectory + "/saves/level.txt", False)
                If lbl_Lvl.Text Is Nothing Then
                    Level = 10
                Else
                    streamWrite.WriteLine(Level)
                    streamWrite.Close()
                End If
            End If

            'Setting up an auto-load feature that will load the player's current amount of EXP using the I/O method 
            Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Environment.CurrentDirectory + "/saves/EXP.txt", False)
            If streamWriter Is Nothing Then
                EXP = 0
            Else
                If pic_Level.Visible = True Then EXP = 0
                streamWriter.WriteLine(EXP)
                streamWriter.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("The game couldn't load successfully! One of files is being used by another program. Please close it and then try again!", "String Replacement Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Exit()
        End Try

    End Sub

    Private Sub pic_NPC_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_NPC.DoubleClick
        'Displaying the NPC's Quest chat form
        If isDeclined <> False Then frm_Chat.Visible = True
    End Sub

    Private Sub btn_Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finish.Click
        'Calling the levelUp function to level up the player when the player finishes the Quest completely, displaying the Quest on the console and incrementing required monster kill amount by 15
        If killCount = reqKills Then
            levelUp()
            btn_Finish.Visible = False
            reqKills += 15
            lbl_Status.Text = "Quest: " & 0 & "/" & reqKills
            killCount = 0
        End If
    End Sub
End Class