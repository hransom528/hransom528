'Harris Ransom
'SPACE INVADERS
'Created 1/29/19

Public Class Form1
    ''Declaration Statements
    'Player pictureboxes
    Dim ship As PictureBox 'Player's ship
    Dim fort1 As PictureBox 'Farthest fort to the left
    Dim fort2 As PictureBox 'Fort to the right of fort 1
    Dim fort3 As PictureBox 'Fort to the left of fort 4
    Dim fort4 As PictureBox 'Farthest fort to the right
    Dim life As PictureBox 'Life picture

    'Lasers and Missles 
    Dim alienLaser1 As Rectangle 'One laser on screen
    Dim alienLaser2 As Rectangle 'Another laser on screen
    Dim alienLaser3 As Rectangle 'Another ANOTHER laser on screen
    Dim shipMissle As PictureBox 'Laser from ship

    'Alien pictureboxes
    Dim alien1 As PictureBox
    Dim alien2 As PictureBox
    Dim alien3 As PictureBox
    Dim alien4 As PictureBox
    Dim alien5 As PictureBox
    Dim alien6 As PictureBox
    Dim alien7 As PictureBox
    Dim alien8 As PictureBox
    Dim alien9 As PictureBox
    Dim alien10 As PictureBox
    Dim alien11 As PictureBox
    Dim alien12 As PictureBox
    Dim alien13 As PictureBox
    Dim alien14 As PictureBox
    Dim alien15 As PictureBox
    Dim alien16 As PictureBox
    Dim alien17 As PictureBox
    Dim alien18 As PictureBox
    Dim alien19 As PictureBox
    Dim alien20 As PictureBox
    Dim alien21 As PictureBox
    Dim alien22 As PictureBox
    Dim alien23 As PictureBox
    Dim alien24 As PictureBox
    Dim alien25 As PictureBox

    'Misc.
    Dim randomShip As Integer = 0 'Selects a random ship to shoot a laser from
    Dim shipAmmount As Integer = 25 'Ammount of ships on screen
    Dim score As Integer = 0 'Player score
    Dim lives As Integer = 3 'Player lives, starts at 3
    Const PLAYERMOVESPEED As Integer = 10 'Movement speed of the player

#Region "Methods"
    'Moves ship right
    Public Sub playerMoveRight()

    End Sub

    'Moves ship left
    Public Sub playerMoveLeft()

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

    End Sub
#End Region

#Region "Events"
    'Paint Event
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    'Keydown Event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    'Keyup event
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub

    'Keypress Event
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub
#End Region

    'Timer that ticks every 25ms
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

    End Sub


End Class
