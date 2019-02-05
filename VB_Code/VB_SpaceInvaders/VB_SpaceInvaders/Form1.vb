'Harris Ransom
'SPACE INVADERS
'Created 1/29/19

Public Class Form1
    ''Declaration Statements
    'Player Rectanglees
    Dim ship As Rectangle 'Player's ship
    Dim fort1 As Rectangle 'Farthest fort to the left
    Dim fort2 As Rectangle 'Fort to the right of fort 1
    Dim fort3 As Rectangle 'Fort to the left of fort 4
    Dim fort4 As Rectangle 'Farthest fort to the right

    'Lasers and Missles 
    Dim alienLaser1 As Rectangle 'One laser on screen
    Dim alienLaser2 As Rectangle 'Another laser on screen
    Dim alienLaser3 As Rectangle 'Another ANOTHER laser on screen
    Dim shipMissle As Rectangle 'Laser from ship
    Dim shipMissleX As Integer = 0
    Dim shipMissleY As Integer = 0

    'Alien Rectanglees
    Dim frontAlien1 As Rectangle
    Dim frontAlien2 As Rectangle
    Dim frontAlien3 As Rectangle
    Dim frontAlien4 As Rectangle
    Dim frontAlien5 As Rectangle
    Dim middleAlien1 As Rectangle
    Dim middleAlien2 As Rectangle
    Dim middleAlien3 As Rectangle
    Dim middleAlien4 As Rectangle
    Dim middleAlien5 As Rectangle
    Dim backAlien1 As Rectangle
    Dim backAlien2 As Rectangle
    Dim backAlien3 As Rectangle
    Dim backAlien4 As Rectangle
    Dim backAlien5 As Rectangle
    Dim bonusAlien As Rectangle

    'Ship Movement
    Dim shipX As Integer = 367
    Const SHIPY As Integer = 400
    Const PLAYERMOVESPEED As Integer = 13 'Movement speed of the player

    'Alien Movement
    Dim frontAlien1X As Integer = 279
    Dim frontAlien2X As Integer = 323
    Dim frontAlien3X As Integer = 367
    Dim frontAlien4X As Integer = 411
    Dim frontAlien5X As Integer = 455
    Dim middleAlien1X As Integer = 279
    Dim middleAlien2X As Integer = 323
    Dim middleAlien3X As Integer = 367
    Dim middleAlien4X As Integer = 411
    Dim middleAlien5X As Integer = 455
    Dim backAlien1X As Integer = 279
    Dim backAlien2X As Integer = 323
    Dim backAlien3X As Integer = 367
    Dim backAlien4X As Integer = 411
    Dim backAlien5X As Integer = 455
    Dim bonusAlienX As Integer = 805

    Dim frontAlien1Y As Integer = 227
    Dim frontAlien2Y As Integer = 227
    Dim frontAlien3Y As Integer = 227
    Dim frontAlien4Y As Integer = 227
    Dim frontAlien5Y As Integer = 227
    Dim middleAlien1Y As Integer = 183
    Dim middleAlien2Y As Integer = 183
    Dim middleAlien3Y As Integer = 183
    Dim middleAlien4Y As Integer = 183
    Dim middleAlien5Y As Integer = 183
    Dim backAlien1Y As Integer = 139
    Dim backAlien2Y As Integer = 139
    Dim backAlien3Y As Integer = 139
    Dim backAlien4Y As Integer = 139
    Dim backAlien5Y As Integer = 139
    Dim bonusAlienY As Integer = 73

    Dim alienMoveLeftBool As Boolean = False 'Detects if the aliens are moving left
    Dim alienMoveRightBool As Boolean = True ' Detects if the aliens are moving right

    'Forts
    Dim fort1Health As Integer = 8
    Dim fort2Health As Integer = 8
    Dim fort3Health As Integer = 8
    Dim fort4Health As Integer = 8

    'Misc.
    Dim randomShip As Integer = 0 'Selects a random ship to shoot a laser from
    Dim shipAmmount As Integer = 16 'Ammount of ships on screen
    Dim score As Integer = 0 'Player score
    Dim lives As Integer = 3 'Player lives, starts at 3
    Dim alienTimerCount As Integer = 0

#Region "Methods"
    'Moves ship right
    Public Sub playerMoveRight()
        shipX += PLAYERMOVESPEED
        Me.Refresh()
    End Sub

    'Moves ship left
    Public Sub playerMoveLeft()
        shipX -= PLAYERMOVESPEED
        Me.Refresh()
    End Sub

    'Moves aliens left
    Public Sub alienMoveLeft()

    End Sub

    'Moves aliens right
    Public Sub alienMoveRight()

    End Sub

    'Shoots a laser from a specific enemy
    Public Sub alienShoot(alien, lasernum)

    End Sub

    'Shoots a missle from the player
    Public Sub playerShoot()

    End Sub

    'Handles all of the collision
    Public Sub collision()
        'If laser hits ship
        If (alienLaser1.IntersectsWith(ship)) Or (alienLaser2.IntersectsWith(ship)) Or (alienLaser1.IntersectsWith(ship)) And (lives = 3) Then
            lives -= 1
            picLife3.Visible = False
        End If
        If (alienLaser1.IntersectsWith(ship)) Or (alienLaser2.IntersectsWith(ship)) Or (alienLaser1.IntersectsWith(ship)) And (lives = 2) Then
            lives -= 1
            picLife2.Visible = False
        End If
        If (alienLaser1.IntersectsWith(ship)) Or (alienLaser2.IntersectsWith(ship)) Or (alienLaser1.IntersectsWith(ship)) And (lives = 1) Then
            lives -= 1
            picLife1.Visible = False
            gameOver()
        End If

        'If player laser hits alien
        If (shipMissle.IntersectsWith(frontAlien1)) Or (shipMissle.IntersectsWith(frontAlien2)) Or (shipMissle.IntersectsWith(frontAlien3)) Or (shipMissle.IntersectsWith(frontAlien4)) Or (shipMissle.IntersectsWith(frontAlien5)) Then

        End If

    End Sub

    'If a game over occurs
    Public Sub gameOver()
        picLife3.Visible = False
        picLife2.Visible = False
        picLife1.Visible = False
    End Sub
#End Region

#Region "Events"
    'Paint Event
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Draws ship
        ship = New Rectangle(shipX, SHIPY, 50, 38)
        e.Graphics.DrawImage(My.Resources.ship, ship)

        'Draws aliens
        frontAlien1 = New Rectangle(frontAlien1X, frontAlien1Y, 38, 38)
        frontAlien2 = New Rectangle(frontAlien2X, frontAlien2Y, 38, 38)
        frontAlien3 = New Rectangle(frontAlien3X, frontAlien3Y, 38, 38)
        frontAlien4 = New Rectangle(frontAlien4X, frontAlien4Y, 38, 38)
        frontAlien5 = New Rectangle(frontAlien5X, frontAlien5Y, 38, 38)
        middleAlien1 = New Rectangle(middleAlien1X, middleAlien1Y, 38, 38)
        middleAlien2 = New Rectangle(middleAlien2X, middleAlien2Y, 38, 38)
        middleAlien3 = New Rectangle(middleAlien3X, middleAlien3Y, 38, 38)
        middleAlien4 = New Rectangle(middleAlien4X, middleAlien4Y, 38, 38)
        middleAlien5 = New Rectangle(middleAlien5X, middleAlien5Y, 38, 38)
        backAlien1 = New Rectangle(backAlien1X, backAlien1Y, 38, 38)
        backAlien2 = New Rectangle(backAlien2X, backAlien2Y, 38, 38)
        backAlien3 = New Rectangle(backAlien3X, backAlien3Y, 38, 38)
        backAlien4 = New Rectangle(backAlien4X, backAlien4Y, 38, 38)
        backAlien5 = New Rectangle(backAlien5X, backAlien5Y, 38, 38)
        bonusAlien = New Rectangle(bonusAlienX, bonusAlienY, 75, 38)

        e.Graphics.DrawImage(My.Resources.front_alien, frontAlien1)
        e.Graphics.DrawImage(My.Resources.front_alien, frontAlien2)
        e.Graphics.DrawImage(My.Resources.front_alien, frontAlien3)
        e.Graphics.DrawImage(My.Resources.front_alien, frontAlien4)
        e.Graphics.DrawImage(My.Resources.front_alien, frontAlien5)
        e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien1)
        e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien2)
        e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien3)
        e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien4)
        e.Graphics.DrawImage(My.Resources.middle_alien, middleAlien5)
        e.Graphics.DrawImage(My.Resources.back_alien, backAlien1)
        e.Graphics.DrawImage(My.Resources.back_alien, backAlien2)
        e.Graphics.DrawImage(My.Resources.back_alien, backAlien3)
        e.Graphics.DrawImage(My.Resources.back_alien, backAlien4)
        e.Graphics.DrawImage(My.Resources.back_alien, backAlien5)
        e.Graphics.DrawImage(My.Resources.bonus_alien, bonusAlien)
    End Sub

    'Keypress Event
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'If player presses d
        If (e.KeyChar = "d") Then
            playerMoveRight()
        End If

        'If player presses a
        If (e.KeyChar = "a") Then
            playerMoveLeft()
        End If
    End Sub
#End Region

    'Timer that ticks every 25ms
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

    End Sub

    'Timer for the aliens
    Private Sub tmrAliens_Tick(sender As Object, e As EventArgs) Handles tmrAliens.Tick
        alienTimerCount += 1
    End Sub
End Class
