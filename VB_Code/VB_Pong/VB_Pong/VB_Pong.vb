﻿'VB_Pong v1.0
'By: Harris Ransom

Imports System 'Imports the system module (for the math methods)

Public Class VB_Pong
#Region "Declaration Statements"
    'Initiates rectangles
    Dim player1 As Rectangle 'Initiates player1 paddle
    Dim player2 As Rectangle 'Initiates player2 paddle
    Dim ball As Rectangle 'Initiates ball 
    Dim topWall As Rectangle 'Initiates top boundry
    Dim bottomWall As Rectangle 'Initiates bottom boundry
    Dim leftWall As Rectangle 'Initates the left side boundry (left goal)
    Dim rightWall As Rectangle 'Initiates the right side boundry (right goal)
    Dim middle As Rectangle 'Initiates the middle line (aesthetic)

    'Sets up the player's paddles
    Const PLAYER1X As Integer = 75 'X position of player 1 (doesn't change)
    Dim player1Y As Integer = 200 'Y position of player 1
    Const PLAYER2X As Integer = 725 'X position of player 2 (doesn't change)
    Dim player2Y As Integer = 200 'Y position of player 2
    Const P1YSTART As Integer = 225
    Const P2YSTART As Integer = 225

    'Sets up the ball
    Dim ballX As Integer = 360 'Ball x position
    Dim ballY As Integer = 225 'Ball y position
    Const BALLSPEED = 10 'Speed of ball, used for resuming after pause as well as speed checks
    Dim ballMoveX As Integer = BALLSPEED 'Ball X movement speed, used for speed checks
    Dim ballMoveY As Integer = BALLSPEED 'Ball Y movement speed, used for speed checks
    Dim ballStartingX = 395 'X value of the ball at the start, for reseting it's position
    Dim ballStartingY = 225 'Y value of the ball at the start, for reseting it's position

    'Sets up the score system
    Dim score1 As Integer = 0 'Player 1's score 
    Dim score2 As Integer = 0 'Player 2's score
    Dim player1Score As Boolean = False 'Detects if ball was scored by player 1
    Dim player2Score As Boolean = False 'Detects if ball was scored by player 2

    'Sets up collision booleans for paddles (used for bouncing the ball pseduo-randomly)
    Dim oneWithBall As Boolean = False 'If player1 collides with ball
    Dim twoWithBall As Boolean = False 'If player2 collides with ball

    'Sets up movement
    Const PLAYERMOVEUP As Integer = -30 'Pixels that each player moves up 
    Const PLAYERMOVEDOWN As Integer = 30 'Pixels that each player moves down
    Dim stopMove As Integer = 0 'Value to stop the player from moving (zeroes out their movement speed)
    Dim player1KeyPressUp As Boolean = False 'Detects if player 1 is pressing up 
    Dim player1KeyPressDown As Boolean = False 'Detects if player 1 is pressing down 
    Dim player2KeyPressUp As Boolean = False 'Detects if player 2 is pressing w
    Dim player2KeyPressDown As Boolean = False 'Detects if player2 is pressing s
    Dim disableMovement As Boolean = False 'For pausing, used to disable player movement
    Dim disableMovement1 As Boolean = False 'For disabling player 1's movement only
    Dim disableMovement2 As Boolean = False 'For disabling player 2's movement only
    Dim paused As Boolean = False 'For setting pause/unpaused 

    ''''SIDE NOTE''' Booleans are used because glitches or limitations that happen if they are not used (for moving both players at once, scoring, collision). 
    ''''This is just a heads up if you see a boolean where there doesn't seem to be a need for one. 


#End Region

#Region "Movement"
    'Moves player1 (left paddle) up
    Public Sub player1moveUp()
        player1Y += PLAYERMOVEUP
    End Sub
    'Moves player1 (left paddle) down
    Public Sub player1moveDown()
        player1Y += PLAYERMOVEDOWN
    End Sub
    'Moves player2 (right paddle) up
    Public Sub player2moveUp()
        player2Y += PLAYERMOVEUP
    End Sub
    'Moves player2 (right paddle) down
    Public Sub player2moveDown()
        player2Y += PLAYERMOVEDOWN
    End Sub

    'Stops player 1
    Public Sub stopMovementPlayer1()
        player1Y += stopMove
    End Sub
    'Stops player 2
    Public Sub stopMovementPlayer2()
        player2Y += stopMove
    End Sub
    'Stops ball movement
    Public Sub stopMovementBall()
        ballMoveX = stopMove
        ballMoveY = stopMove
    End Sub

    'Handles collision 
    Public Sub collision()
        'Detects if player 1 hits the ball
        If (player1.IntersectsWith(ball)) Then
            oneWithBall = True
        End If

        'Detects if player 2 hits the ball
        If (player2.IntersectsWith(ball)) Then
            twoWithBall = True
        End If

        'Does the collision for when the ball hits player1
        If (oneWithBall = True) Then
            ballMoveX = -(ballMoveX + 5)
            ballMoveY = -(ballMoveY + 5)
            ballX += ballMoveX
            ballY += ballMoveY
            oneWithBall = False
        End If

        'Does the collision for when the ball hits player2
        If (twoWithBall = True) Then
            ballMoveX = -(ballMoveX + 5)
            ballMoveY = -(ballMoveY + 5)
            ballX += ballMoveX
            ballY += ballMoveY
            twoWithBall = False
        End If

        'If ball hits the top boundry
        If (ball.IntersectsWith(topWall)) Then
            ballMoveY = -ballMoveY
            ballY += ballMoveY
        End If

        'If ball hits the bottom boundry
        If (ball.IntersectsWith(bottomWall)) Then
            ballMoveY = -ballMoveY
            ballY += ballMoveY
        End If

        'If player 1 hits the top wall
        If (player1Y < 132) Then
            player1Y = 132
        End If

        'If player 2 hits the top wall
        If (player2Y < 132) Then
            player2Y = 132
        End If

        'If player 1 hits the bottom wall
        If (player1Y > 375) Then
            player1Y = 375
        End If

        'If player 2 hits the bottom wall
        If (player2Y > 375) Then
            player2Y = 375
        End If

        'If player 2 scores
        If (ball.IntersectsWith(leftWall)) Then
            player2Score = True
        End If

        'If player 1 scores
        If (ball.IntersectsWith(rightWall)) Then
            player1Score = True
        End If

        'Controls the ball's speed to keep the game playable
        If (ballMoveX > 15) Then
            ballMoveX = 14
        End If
        If (ballMoveY > 15) Then
            ballMoveY = 14
        End If
        'Refreshes everything after collision is done
        Me.Refresh()
    End Sub
#End Region

#Region "Pause/Reset"
    'Pause method
    Public Sub pause()
        If (paused = True) Then
            stopMovementPlayer2()
            stopMovementPlayer1()
            stopMovementBall()
            lblPause.Visible = True
            disableMovement = True
        Else
            disableMovement = False
            lblPause.Visible = False
        End If
    End Sub

    'Unpause method
    Public Sub unpause()
        lblPause.Visible = False
        ballMoveX = BALLSPEED
        ballMoveY = BALLSPEED
        disableMovement = False
        paused = False
    End Sub

    'Reset method
    Public Sub reset()
        score1 = 0
        score2 = 0
        ballX = ballStartingX
        ballY = ballStartingY
        ballMoveX = BALLSPEED
        ballMoveY = BALLSPEED
        player1Y = P1YSTART
        player2Y = P2YSTART
        paused = False
        disableMovement = False
        lblPause.Visible = False
    End Sub
#End Region

#Region "Scoring"
    'Player 1 score method
    Public Sub goal1()
        score1 += 1
        ballMoveX = BALLSPEED
        ballMoveY = BALLSPEED
        ballMoveX = -ballMoveX
        ballMoveY = -ballMoveY
        ballX = ballStartingX
        ballY = ballStartingY
    End Sub

    'Player 2 score method
    Public Sub goal2()
        score2 += 1
        ballMoveX = -ballMoveX
        ballMoveX = BALLSPEED
        ballMoveY = BALLSPEED
        ballMoveX = ballMoveX
        ballMoveY = ballMoveY
        ballX = ballStartingX
        ballY = ballStartingY
    End Sub
#End Region

#Region "Events"
    'Handles KeyDown events 
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Detects if player 2 is pressing a key
        If (e.KeyCode = Keys.Up) Then
            player2KeyPressUp = True
        ElseIf (e.KeyCode = Keys.Down) Then
            player2KeyPressDown = True
        End If

        'Detects if player 1 is pressing a key
        If (e.KeyCode = Keys.W) Then
            player1KeyPressUp = True
        ElseIf (e.KeyCode = Keys.S) Then
            player1KeyPressDown = True
        End If

        'Moves player 1
        If (player1KeyPressDown = True) And (disableMovement = False) And (disableMovement1 = False) Then
            player1moveDown()
            collision()
            Me.Refresh()
        ElseIf (player1KeyPressUp = True) And (disableMovement = False) And (disableMovement1 = False) Then
            player1moveUp()
            collision()
            Me.Refresh()
        End If

        'Moves player 2
        If (player2KeyPressDown = True) And (disableMovement = False) And (disableMovement2 = False) Then
            player2moveDown()
            collision()
            Me.Refresh()
        ElseIf (player2KeyPressUp = True) And (disableMovement = False) And (disableMovement2 = False) Then
            player2moveUp()
            collision()
            Me.Refresh()
        End If
        Me.Refresh()

        'Exiting to main menu
        If (e.KeyCode = Keys.Escape) Then
            Me.Hide()
            PongMainMenu.Show()
        End If
    End Sub

    'Paint event
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Draws player1 paddle
        player1 = New Rectangle(PLAYER1X, player1Y, 35, 100)
        e.Graphics.FillRectangle(Brushes.White, player1)

        'Draws player2 paddle
        player2 = New Rectangle(PLAYER2X, player2Y, 35, 100)
        e.Graphics.FillRectangle(Brushes.White, player2)

        'Draws ball
        ball = New Rectangle(ballX, ballY, 18, 18)
        e.Graphics.FillRectangle(Brushes.White, ball)

        'Draws top boundry
        topWall = New Rectangle(0, 120, 800, 30)
        e.Graphics.FillRectangle(Brushes.White, topWall)

        'Draws bottom boundry
        bottomWall = New Rectangle(0, 440, 800, 30)
        e.Graphics.FillRectangle(Brushes.White, bottomWall)

        'Draws left boundry
        leftWall = New Rectangle(-10, 0, 30, 450)

        'Draws right boundry
        rightWall = New Rectangle(810, 0, 30, 450)

        'Draws middle line
        middle = New Rectangle(395, 132, 15, 368)
        e.Graphics.FillRectangle(Brushes.White, middle)
    End Sub

    'Detects if a player releases a key
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'Player 1 code
        If (e.KeyCode = Keys.W) Then
            stopMovementPlayer1()
            player1KeyPressUp = False
            Me.Refresh()
        ElseIf (e.KeyCode = Keys.S) Then
            stopMovementPlayer1()
            player1KeyPressDown = False
            Me.Refresh()
        End If

        'Player 2 code
        If (e.KeyCode = Keys.Up) Then
            stopMovementPlayer2()
            player2KeyPressUp = False
            Me.Refresh()
        ElseIf (e.KeyCode = Keys.Down) Then
            stopMovementPlayer2()
            player2KeyPressDown = False
            Me.Refresh()
        End If

    End Sub

    'KeyPress Event
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Pausing
        If (e.KeyChar = "p") Then
            paused = True
            pause()
        ElseIf (e.KeyChar = "u") Then
            paused = False
            unpause()
        ElseIf (e.KeyChar = "r") Then
            paused = False
            reset()
        End If
    End Sub

    'Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Starts tmrTimer 
        tmrTimer.Start()
    End Sub

    'Ticks every 25 ms
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'Does collision
        collision()
        Me.Refresh()

        'Moves ball
        ballX += ballMoveX
        ballY += ballMoveY

        'Evaluates score
        If (player1Score = True) Then
            goal1()
            player1Score = False
        ElseIf (player2Score = True) Then
            goal2()
            player2Score = False
        End If

        'Displays score
        lblScore1.Text = "Player 1 Score: " + FormatNumber(score1, 0)
        lblScore2.Text = "Player 2 Score: " + FormatNumber(score2, 0)
        Me.Refresh()
    End Sub
#End Region
End Class
