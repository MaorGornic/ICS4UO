'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Module Module1
    Public ID As String 'A variable used to store the player's ID
    Public password As String 'A variable used to store the player's in-game password
    Public Level As Integer = 10 'A variable used to keep a track of the player's in-game level
    Public EXP As Integer 'A variable used to keep a track of the player's in-game EXP (Experience points) value
    Public isRead As Boolean 'A variable used to determine whether the player has already read the tutorial
    Public isDeclined As Boolean = True 'A variable used to determine whether the player has declined the in-game Quest or not
    Public isPaused As Boolean 'A variable used to determine whether the player has paused the game
    Public pauseCounter As Integer 'A variable used to determine whether the player wants to pause or unpause the game
    Public isMuted As Boolean 'A variable used to determine whether the player has decided to mute the game or not
    Public killCount As Integer 'A variable used to keep a track of the amount of kills the player has in the game
    Public reqKills As Integer = 15 'A variable used to determine the required amount of kills in order to complete the in-game Quest
End Module
