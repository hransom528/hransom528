'Harris Ransom
'SPACE INVADERS
'Created 1/29/19

Imports System.IO 'Imports the IO module for stream reader/writer
Public Class SpaceInvaders
    'Initializes sound DLL for music and SFX
    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
#Region "Declaration Statements"

    'Player Rectanglees
    Dim ship As Rectangle 'Player's ship

    'Boundaries
    Dim topWall As Rectangle = New Rectangle(0, 0, 800, 50) 'Top bounds
    Dim bottomWall As Rectangle = New Rectangle(0, 700, 800, 50) 'Bottom bounds
    Dim rightWall As Rectangle = New Rectangle(800, 0, 30, 700) 'Right bounds
    Dim leftWall As Rectangle = New Rectangle(-30, 0, 30, 700) 'Left bounds

    'Lasers and Missles 
    Dim alienLaser As Rectangle 'Alien lasers
    Dim alienLaserMoving As Boolean 'If the alien laser is moving
    Dim shipMissle As Rectangle 'Laser from ship
    Dim shipMissleX As Integer = 0 'X cord of the player missle
    Dim shipMissleY As Integer = 0 'Y cord of the player missle
    Dim alienLaserX As Integer = 900 'X cord of the alien laser
    Dim alienLaserY As Integer = 50 'Y cord of the alien laser
    Dim missleIsGoing As Boolean = False 'If the player missle is going
    Dim randomShip As Integer = 0 'Selects a random ship to shoot a laser from

    'Alien Rectanglees
    Dim frontAlien(5) As Rectangle 'Front aliens
    Dim middleAlien(5) As Rectangle 'Middle aliens
    Dim backAlien(5) As Rectangle 'Back aliens
    Dim bonusAlien As Rectangle 'Bonus alien

    'Ship Movement
    Dim shipX As Integer = 367 'X coordinate of the player's ship
    Const SHIPY As Integer = 600 'Y coordinate of the player's ship
    Const PLAYERMOVESPEED As Integer = 13 'Movement speed of the player

    'Alien Movement 
    Dim frontAlienX() As Integer = {279, 323, 367, 411, 455} 'X cords of the front aliens
    Dim middleAlienX() As Integer = {279, 323, 367, 411, 455} 'X cords of the middle aliens
    Dim backAlienX() As Integer = {279, 323, 367, 411, 455} 'X cords of the back aliens
    Dim bonusAlienX As Integer = 900 'X cord of the bonus alien

    Dim frontAlienY As Integer = 227 'Y cords of the front aliens
    Dim middleAlienY As Integer = 183 'Y cords of the middle aliens
    Dim backAlienY As Integer = 139 'Y cords of the back aliens
    Dim bonusAlienY As Integer = 73 'Y cords of the bonus alien

    Const ALIENMOVESPEED As Integer = 13 'Speed, in pixels, of which the aliens move

    Dim alienMoveRightBool As Boolean = True ' Detects if the aliens are moving right
    Dim alienMoveDownBool As Boolean = False ' Detects if the aliens need to move down
    Dim bonusAppear As Boolean = False 'If the bonus ship needs to start moving 

    'Forts
    Dim forts(4) As Rectangle
    Dim fortsHealth() As Integer = {3, 3, 3, 3}
    Dim fortsX As Integer() = {50, 250, 450, 650}
    Dim fortsY As Integer = 525

    'Banned Indexes (indexes that are equal to Nothing, which cannot be accessed without an error)
    ''These banned indexes are checked against whenever a program tries to access indexes for the alien rectangles
    Dim bannedFrontIndexes(5) As Integer
    Dim bannedMiddleIndexes(5) As Integer
    Dim bannedBackIndexes(5) As Integer

    'Victory/Game Over Conditions
    Dim victory = False 'If a victory occurs
    Dim gameOverBool = False 'If a game over occurs
    Dim aliensLeft As Integer = 15 'Aliens still alive
    Dim lives As Integer = 3 'Player lives, starts at 3

    'Misc
    Dim score As Integer = 0 'Player score
    Dim alienTimerCount As Integer = 0 'Time elapsed in seconds for the aliens
    Dim playGameOverSound As Boolean = True 'Determines whether or not to play the game over sound effect at the end
    Dim playVictorySound As Boolean = True 'Determines whether or not to play the victory sound effect at the end
    Dim allowMovement As Boolean = True 'Used to stop movement if player goes off screen
#End Region

#Region "Methods"
    'Moves player ship right
    Public Sub playerMoveRight()
        shipX += PLAYERMOVESPEED
        Me.Refresh()
    End Sub

    'Moves player ship left
    Public Sub playerMoveLeft()
        shipX -= PLAYERMOVESPEED
        Me.Refresh()
    End Sub

    'Moves aliens left
    Public Sub alienMoveLeft()
        'Moves front aliens
        For i = 0 To frontAlien.Length - 2
            frontAlien(i).Offset((-1) * (ALIENMOVESPEED), 0)
        Next

        'Moves middle aliens
        For i = 0 To middleAlien.Length - 2
            middleAlien(i).Offset((-1) * (ALIENMOVESPEED), 0)
        Next

        'Moves back aliens
        For i = 0 To backAlien.Length - 2
            backAlien(i).Offset((-1) * (ALIENMOVESPEED), 0)
        Next

        Me.Refresh()
    End Sub

    'Moves aliens right
    Public Sub alienMoveRight()
        'Moves front aliens
        For i = 0 To frontAlien.Length - 2
            frontAlien(i).Offset(ALIENMOVESPEED, 0)
        Next

        'Moves middle aliens
        For i = 0 To middleAlien.Length - 2
            middleAlien(i).Offset(ALIENMOVESPEED, 0)
        Next

        'Moves back aliens
        For i = 0 To backAlien.Length - 2
            backAlien(i).Offset(ALIENMOVESPEED, 0)
        Next

        Me.Refresh()
    End Sub

    'Moves alien's down
    Public Sub alienMoveDown()
        If (alienMoveDownBool) Then
            For i = 0 To frontAlien.Length() - 2
                frontAlien(i).Offset(0, 5)
                middleAlien(i).Offset(0, 5)
                backAlien(i).Offset(0, 5)
            Next
            alienMoveDownBool = False
        End If
        Me.Invalidate()
    End Sub

    'Shoots a laser from a specific enemy
    Public Sub alienShoot()
        Dim randEnemy As Integer = -1
        randEnemy = Math.Floor(Rnd() * 15)

        'Determines if game is over
        If (victory) Or (gameOverBool) Then
            Exit Sub
        Else
            'Determines what alien to shoot from
            If (randEnemy <= 4) And (randEnemy > 0) Then
                alienLaserX = frontAlien(randEnemy).Right
                alienLaserY = frontAlien(randEnemy).Bottom
                alienLaserMoving = True
            ElseIf (randEnemy >= 5) And (randEnemy <= 9) Then
                alienLaserX = middleAlien(randEnemy - 5).Right
                alienLaserY = middleAlien(randEnemy - 5).Bottom
                alienLaserMoving = True '
            ElseIf (randEnemy >= 10) And (randEnemy <= 14) Then
                alienLaserX = backAlien(randEnemy - 10).Right
                alienLaserY = backAlien(randEnemy - 10).Bottom
                alienLaserMoving = True
            Else
                Exit Sub
                alienLaserMoving = False
            End If
        End If
    End Sub

    'Shoots a missle from the player
    Public Sub playerShoot()
        shipMissleX = (ship.Right - (ship.Width / 2))
        shipMissleY = 600
        missleIsGoing = True

        Me.Refresh()
    End Sub

    'Moves the bonus ship
    Public Sub bonusMove()
        If (bonusAlien.Left <= 0) Then
            bonusAlienX = 900
            bonusAppear = False
        Else
            bonusAlienX -= 3
        End If

        Me.Refresh()
    End Sub

    'Handles all of the collision
    Public Sub collision()
        'If alien hits wall
        checkForWall()

        'If laser hits ship
        If (alienLaser.IntersectsWith(ship)) And (lives = 3) Then
            lives -= 1
            picLife3.Visible = False
            alienLaserX = 900
            alienLaserY = 40
        ElseIf (alienLaser.IntersectsWith(ship)) And (lives = 2) Then
            lives -= 1
            picLife3.Visible = False
            picLife2.Visible = False
            alienLaserX = 900
            alienLaserY = 40
        ElseIf (alienLaser.IntersectsWith(ship)) And (lives = 1) Then
            lives -= 1
            picLife3.Visible = False
            picLife2.Visible = False
            picLife1.Visible = False
            gameOverBool = True
            gameOver()
        End If

        'If player missle hits an alien
        For i = 0 To frontAlien.Length - 2 'Checks all front aliens
            If (shipMissle.IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                frontAlien(i) = Nothing
                bannedFrontIndexes(i) = i
                score += 5
                lblScore.Text = "Score: " & CStr(score)
                missleIsGoing = False
                aliensLeft -= 1
            End If
        Next
        For i = 0 To middleAlien.Length - 2 'Checks all middle aliens 
            If (shipMissle.IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                middleAlien(i) = Nothing
                bannedMiddleIndexes(i) = i
                score += 10
                lblScore.Text = "Score: " & CStr(score)
                missleIsGoing = False
                aliensLeft -= 1
            End If
        Next
        For i = 0 To backAlien.Length - 2 'Checks all back aliens
            If (shipMissle.IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                backAlien(i) = Nothing
                bannedBackIndexes(i) = i
                score += 15
                lblScore.Text = "Score: " & CStr(score)
                missleIsGoing = False
                aliensLeft -= 1
            End If
        Next

        'If the ship shoots the bonus alien 
        If (shipMissle.IntersectsWith(bonusAlien)) And (gameOverBool = False) And (victory = False) Then
            score += 1000
            lblScore.Text = "Score: " & CStr(score)
            bonusAlien = Nothing
            bonusAlienX = 900
            bonusAlienY = 73
            bonusAppear = False
            missleIsGoing = False
            shipMissleX = 900
            shipMissleY = 40
        End If

        'If ship laser hits fort from behind
        For i = 0 To forts.Length - 2
            If (shipMissle.IntersectsWith(forts(i))) Then
                fortsHealth(i) -= 1
                missleIsGoing = False
            End If
        Next

        'If alien laser hits fort
        If (alienLaser.IntersectsWith(forts(0))) And (forts(0) <> Nothing) Then 'Fort 1, farthest left
            fortsHealth(0) -= 1
            alienLaserX = 900
            alienLaserY = 40
            alienLaserMoving = False
            If (fortsHealth(0) = 0) Then
                forts(0) = Nothing
            End If
        End If
        If (alienLaser.IntersectsWith(forts(1))) And (forts(1) <> Nothing) Then 'Fort 2, left middle
            fortsHealth(1) -= 1
            alienLaserX = 900
            alienLaserY = 40
            alienLaserMoving = False
            If (fortsHealth(1) = 0) Then
                forts(1) = Nothing
            End If
        End If
        If (alienLaser.IntersectsWith(forts(2))) And (forts(2) <> Nothing) Then 'Fort 3, right middle
            fortsHealth(2) -= 1
            alienLaserX = 900
            alienLaserY = 40
            alienLaserMoving = False
            If (fortsHealth(2) = 0) Then
                forts(2) = Nothing
            End If
        End If
        If (alienLaser.IntersectsWith(forts(3))) And (forts(3) <> Nothing) Then 'Fort 4, farthest right
            fortsHealth(3) -= 1
            alienLaserX = 900
            alienLaserY = 40
            alienLaserMoving = False
            If (fortsHealth(3) = 0) Then
                forts(3) = Nothing
            End If
        End If


        'Checks if aliens intersect with a fort or player
        For i = 0 To frontAlien.Length - 2 'Checks all front aliens
            If (forts(1).IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(2).IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(3).IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(4).IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (ship.IntersectsWith(frontAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            End If
        Next
        For i = 0 To middleAlien.Length - 2 'Checks all middle aliens
            If (forts(1).IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(2).IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(3).IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(4).IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (ship.IntersectsWith(middleAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            End If
        Next
        For i = 0 To backAlien.Length - 2 'Checks all back aliens
            If (forts(1).IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(2).IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(3).IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (forts(4).IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            ElseIf (ship.IntersectsWith(backAlien(i))) And (gameOverBool = False) And (victory = False) Then
                gameOverBool = True
            End If
        Next

        'Tests to see if the player will go off the screen
        If (ship.IntersectsWith(rightWall)) Then
            allowMovement = False
            playerMoveLeft()
        ElseIf (ship.IntersectsWith(leftWall)) Then
            allowMovement = False
            playerMoveRight()
        Else
            allowMovement = True
        End If
    End Sub

    'Checks for collision with a wall
    Public Sub checkForWall()
        'Checks front aliens
        For i = 0 To frontAlien.Length - 2
            If (checkIndexes(i, 1) = False) Then
                If (frontAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = False
                    alienMoveDownBool = True
                    alienMoveDown()
                    alienMoveDownBool = False
                    Exit Sub
                ElseIf (frontAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = True
                    alienMoveDownBool = True
                    alienMoveDown()
                    alienMoveDownBool = False
                    Exit Sub
                ElseIf (frontAlien(i).IntersectsWith(rightWall)) And Not (frontAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = False
                ElseIf (frontAlien(i).IntersectsWith(leftWall)) And Not (frontAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = True
                Else
                    alienMoveDownBool = False
                End If
            End If
        Next

        'Checks middle aliens
        For i = 0 To middleAlien.Length - 2
            If (checkIndexes(i, 2) = False) Then
                If (middleAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = False
                    alienMoveDownBool = True
                    Exit Sub
                ElseIf (middleAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = True
                    alienMoveDownBool = True
                    alienMoveDown()
                    alienMoveDownBool = False
                    Exit Sub
                ElseIf (middleAlien(i).IntersectsWith(rightWall)) And Not (middleAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = False
                ElseIf (middleAlien(i).IntersectsWith(leftWall)) And Not (middleAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = True
                Else
                    alienMoveDownBool = False
                End If
            End If
        Next

        'Checks back aliens
        For i = 0 To backAlien.Length - 2
            If (checkIndexes(i, 3) = False) Then
                'Checks for collision with a wall
                If (backAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = False
                    alienMoveDownBool = True
                    alienMoveDown()
                    Exit Sub
                ElseIf (backAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = True
                    alienMoveDownBool = True
                    alienMoveDown()
                    alienMoveDownBool = False
                    Exit Sub
                ElseIf (backAlien(i).IntersectsWith(rightWall)) And Not (backAlien(i).IntersectsWith(leftWall)) Then
                    alienMoveRightBool = False
                ElseIf (backAlien(i).IntersectsWith(leftWall)) And Not (backAlien(i).IntersectsWith(rightWall)) Then
                    alienMoveRightBool = True
                Else
                    alienMoveDownBool = False
                End If
            End If
        Next
    End Sub

    'If a game over occurs
    Public Sub gameOver()
        'Clears the game
        picLife3.Visible = False
        picLife2.Visible = False
        picLife1.Visible = False
        For i = 0 To frontAlien.Length - 2
            frontAlien(i) = Nothing
            middleAlien(i) = Nothing
            backAlien(i) = Nothing
        Next
        For i = 0 To fortsHealth.Length - 2
            fortsHealth(i) = 0
            forts(i) = Nothing
            forts(3) = Nothing
        Next
        lblgameScreen.Visible = True
        alienLaserMoving = False
        alienLaser = Nothing
        alienLaserX = 900
        alienLaserY = 50
        shipMissleX = 900
        shipMissleY = 50
        missleIsGoing = False
        shipMissle = Nothing
        ship = Nothing
        bonusAlienX = 900
        bonusAlienY = 50
        bonusAlien = Nothing
        bonusAppear = False
        ship = Nothing

        'Tests for a victory
        If (victory) Then 'Victory
            My.Computer.Audio.Stop()
            lblgameScreen.Text = "VICTORY"
            playGameOverSound = False
            If (playVictorySound) Then
                My.Computer.Audio.Play(My.Resources.victorySFX, AudioPlayMode.WaitToComplete)
                playVictorySound = False
            End If
        ElseIf (victory = False) And (gameOverBool) Then 'Game over
            My.Computer.Audio.Stop()
            If (playGameOverSound) Then
                My.Computer.Audio.Play(My.Resources.gameOver, AudioPlayMode.WaitToComplete)
                playGameOverSound = False
            End If
            lblgameScreen.Text = "GAME OVER"
        Else 'Error
            Err()
        End If
    End Sub

    'Checks to see if an array refers to an unavailable index, avoiding an index error
    Public Function checkIndexes(index As Integer, group As Integer)
        Dim result As Boolean 'If an index is banned, returned as true

        'Group 1 = Front aliens
        'Group 2 = Middle aliens
        'Group 3 = Back aliens 

        If (group = 1) Then
            If (bannedFrontIndexes(index) <> Nothing) Then
                result = True
            Else
                result = Nothing
            End If
        ElseIf (group = 2) Then
            If (bannedMiddleIndexes(index) <> Nothing) Then
                result = True
            Else
                result = Nothing
            End If
        ElseIf (group = 3) Then
            If (bannedBackIndexes(index) <> Nothing) Then
                result = True
            Else
                result = Nothing
            End If
        End If

        Return result
    End Function
#End Region

#Region "Events"
    'Paint Event
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Draws ship
        ship = New Rectangle(shipX, SHIPY, 50, 38)
        e.Graphics.DrawImage(My.Resources.ship, ship)

        'Draws front aliens
        For i = 0 To frontAlien.Length - 2
            If (checkIndexes(i, 1) = Nothing) Then
                e.Graphics.DrawImage(My.Resources.front_alien, frontAlien(i))
            End If
        Next

        'Draws middle aliens
        For i = 0 To middleAlien.Length - 2
            If (checkIndexes(i, 2) = Nothing) Then
                e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien(i))
            End If
        Next

        'Draws back aliens
        For i = 0 To backAlien.Length - 2
            If (checkIndexes(i, 3) = Nothing) Then
                e.Graphics.DrawImage(My.Resources.back_alien, backAlien(i))
            End If
        Next

        'Draws forts
        For i = 0 To forts.Length - 2
            If (fortsHealth(i) = 0) Then
                forts(i) = Nothing
            ElseIf (fortsHealth(i) = 1) Then
                e.Graphics.DrawImage(My.Resources.heavilyDamagedFort, forts(i))
            ElseIf (fortsHealth(i) = 2) Then
                e.Graphics.DrawImage(My.Resources.lightlyDamagedFort, forts(i))
            ElseIf (fortsHealth(i) = 3) Then
                e.Graphics.DrawImage(My.Resources.undamagedFort, forts(i))
            End If
        Next

        'Draws bonus alien
        bonusAlien = New Rectangle(bonusAlienX, bonusAlienY, 75, 38)
        e.Graphics.DrawImage(My.Resources.bonus_alien, bonusAlien)

        'Draws ship missle
        shipMissle = New Rectangle(shipMissleX, shipMissleY, 10, 30)
        e.Graphics.FillRectangle(Brushes.White, shipMissle)

        'Draws alien lasers
        alienLaser = New Rectangle(alienLaserX, alienLaserY, 10, 30)
        e.Graphics.FillRectangle(Brushes.Lime, alienLaserX, alienLaserY, 10, 30)
    End Sub

    'Keypress Event
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'If a gameover has not occured, allow movement
        If (victory = False) And (gameOverBool = False) And (allowMovement) Then
            'If player presses d, moves right
            If (e.KeyChar = "d") Or (e.KeyChar = "D") Then
                playerMoveRight()
            End If

            'If player presses a, moves left 
            If (e.KeyChar = "a") Or (e.KeyChar = "A") Then
                playerMoveLeft()
            End If
        End If
    End Sub

    'KeyDown event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If a gameover has not occured, allow movement
        If (victory = False) And (gameOverBool = False) And (allowMovement) Then
            'Detects a spacebar press, shoots a missle 
            If (e.KeyCode = Keys.Space) And (missleIsGoing = False) Then
                playerShoot()
            End If

            'Detects if the d key is pressed, moves player right
            If (e.KeyCode = Keys.D) Then
                playerMoveRight()
            End If

            'Detects if the a key is pressed, moves player left
            If (e.KeyCode = Keys.A) Then
                playerMoveLeft()
            End If
        End If
    End Sub

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initializes front aliens
        For i = 0 To frontAlien.Length - 2
            frontAlien(i) = New Rectangle(frontAlienX(i), frontAlienY, 38, 38)
        Next

        'Initializes middle aliens
        For i = 0 To middleAlien.Length - 2
            middleAlien(i) = New Rectangle(middleAlienX(i), middleAlienY, 38, 38)
        Next

        'Initializes back aliens
        For i = 0 To backAlien.Length - 2
            backAlien(i) = New Rectangle(backAlienX(i), backAlienY, 38, 38)
        Next

        'Initializes alien laser
        alienLaser = New Rectangle(alienLaserX, alienLaserY, 10, 30)

        'Initializes forts
        For i = 0 To forts.Length - 2
            forts(i) = New Rectangle(fortsX(i), fortsY, 90, 50)
        Next
        'Initializes background music
        My.Computer.Audio.Play(My.Resources.backgroundMusic, AudioPlayMode.BackgroundLoop)
    End Sub
#End Region

#Region "Timers"
    'Timer that ticks every 25ms, general game timer
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        collision()

        'If the player shoots a missle
        If (missleIsGoing = False) Or (shipMissleY <= 0) Then
            shipMissleY = 300
            shipMissleX = 900
            missleIsGoing = False
            Me.Refresh()
        ElseIf (missleIsGoing) Then
            shipMissleY -= 10
            Me.Refresh()
        End If

        'If the alien laser is going
        If (alienLaserMoving) Then
            alienLaserY += 10
            Me.Invalidate()
        ElseIf (alienLaserMoving = False) Or (alienLaser.Top >= 700) Then
            alienLaserX = 900
            alienLaserY = 40
            alienLaserMoving = False
            Me.Refresh()
        End If

        'If the bonus ship needs to appear
        If (bonusAppear) Then
            bonusMove()
        End If

        'If all the aliens are eliminated (victory)
        If (aliensLeft = 0) Then
            lblgameScreen.Text = "VICTORY!"
            lblgameScreen.Visible = True
            victory = True
        End If

        'If a victory or game over condition occurs 
        If (victory) Or (gameOverBool) Then
            gameOver()
        End If
    End Sub

    'Timer for the aliens
    Private Sub tmrAliens_Tick(sender As Object, e As EventArgs) Handles tmrAliens.Tick
        'Counts the time elapsed, used for timing of the game 
        alienTimerCount += 1

        'Detects whether the aliens need to move right or left
        If (alienMoveRightBool) Then
            alienMoveRight()
        ElseIf (alienMoveRightBool = False) Then
            alienMoveLeft()
        End If

        'Speeds up the aliens based off of the time
        If (alienTimerCount = 10) Then
            tmrAliens.Interval /= 2
        End If

        If (alienTimerCount = 20) Then
            tmrAliens.Interval /= 2
        End If

        If (alienTimerCount = 100) Then
            tmrAliens.Interval /= 1.5
            bonusAppear = True
        End If

        If (alienTimerCount = 200) Then
            tmrAliens.Interval /= 2
        End If

        If (alienTimerCount = 500) Then
            tmrAliens.Interval /= 2
        End If

        'If any game over condition occurs
        If (victory) Or (gameOverBool) Then
            gameOver()
        End If
    End Sub


    'Randomly fires a missle from an alien every 2.5 seconds
    Private Sub tmrAlienRandShoot_Tick(sender As Object, e As EventArgs) Handles tmrAlienRandShoot.Tick
        'If the game has not ended, fire a missle 
        If (victory = False) And (gameOverBool = False) Then
            alienShoot()
        End If
    End Sub
#End Region
End Class