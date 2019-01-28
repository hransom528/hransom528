'Harris Ransom
'Created 1/22/19

Public Class Form1
    'Declaration statements
    Dim snake As Rectangle 'Snake player
    Dim ball As Rectangle 'What the snake eats

    Dim snakeLength As Integer = 2 'How long the snake is
    Const SNAKEWIDTH As Integer = 8
    Const SNAKEHEIGHT As Integer = 8
    Dim snakeX As Integer = 400
    Dim snakeY As Integer = 225
    Dim MOVESPEED As Integer = 5
    Dim w As Boolean = False
    Dim a As Boolean = False
    Dim s As Boolean = False
    Dim d As Boolean = False

#Region "Methods"
    ''Movement Methods
    Public Sub moveUp()
        snakeY -= MOVESPEED
        Me.Refresh()
    End Sub
    Public Sub moveDown()
        snakeY += MOVESPEED
        Me.Refresh()
    End Sub
    Public Sub moveLeft()
        snakeX -= MOVESPEED
        Me.Refresh()
    End Sub
    Public Sub moveRight()
        snakeX += MOVESPEED
        Me.Refresh()
    End Sub
#End Region

#Region "Events"
    'Paint Event
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        snake = New Rectangle(snakeX, snakeY, SNAKEWIDTH, SNAKEHEIGHT)
        e.Graphics.FillRectangle(Brushes.LimeGreen, snake)
    End Sub

    'KeyPress Event
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Determines keypresses
        If (e.KeyChar = "w") Then
            w = True
            a = False
            s = False
            d = False
        End If
        If (e.KeyChar = "s") Then
            s = True
            w = False
            a = False
            d = False
        End If
        If (e.KeyChar = "a") Then
            a = True
            s = False
            d = False
            w = False
        End If
        If (e.KeyChar = "d") Then
            d = True
            a = False
            s = False
            w = False
        End If
    End Sub

#End Region

#Region "Timers"
    'Moves player, ticks every 10 ms
    Private Sub tmrMovement_Tick(sender As Object, e As EventArgs) Handles tmrMovement.Tick
        If (w) Then
            moveUp()
        End If
        If (s) Then
            moveDown()
        End If
        If (a) Then
            moveLeft()
        End If
        If (d) Then
            moveRight()
        End If
    End Sub

#End Region

End Class
