'Harris Ransom
'Class 8
'Lab08-03_GraphicsWithArrays

Imports System.IO 'Imports IO module
Public Class StarshipFighter
#Region "Declaration Statements"
    Dim starshipX As Integer = 500 'X position of an individual starship
    Dim starshipY As Integer = 500 'Y position of an individual starship
    Dim starshipWidth As Integer = 50 'Starship width
    Dim starshipHeight As Integer = 50 'Starship height
    Dim starshipsNumber As Integer = 25 'Ammount of starships on the screen
    Dim starships(starshipsNumber) As Rectangle 'Starships array
    Dim starshipsMoveX(starships.Length) As Integer 'X Move values 
    Dim starshipsMoveY(starships.Length) As Integer 'Y Move Values

    Dim starsNumber As Integer = 150 'Ammount of stars on the screen
    Dim stars(starsNumber) As Rectangle 'Stars array
    Dim starX As Integer = 500 'X position of an individual starship
    Dim starY As Integer = 500 'Y position of an individual starship
    Dim starW As Integer = getRandom(2, 1) 'Random width of a star
    Dim starH As Integer = getRandom(2, 1) 'Random height of a star

    Dim score As Integer = 0
    Dim highScore As Integer = getHighScore()
    Dim highScoreAchieved As Boolean = False
    Dim secondsLeft As Integer = 60
    Dim starshipsLeft As Integer = starshipsNumber 'Ammount of starships left
    Dim difficulty As String = "Easy" 'Difficulty setting
#End Region

#Region "Methods"
    'Gets a random number
    Public Function getRandom(size As Integer, startNum As Integer)
        Dim randNum As Integer = Math.Floor(Rnd() * size) + startNum
        Return randNum
    End Function

    'Randomly creates the objects
    Public Sub randomObjectCreation()
        'Generates the random starships
        For i = 0 To starships.Length - 2
            starshipX = getRandom(Me.Width - starshipWidth, 0)
            starshipY = getRandom(405 - starshipHeight, 0)
            starships(i) = New Rectangle(starshipX, starshipY, starshipWidth, starshipHeight)
        Next

        'Generates the random stars
        For j = 0 To stars.Length - 2
            starX = getRandom(Me.Width, 0)
            starY = getRandom(405, 0)
            stars(j) = New Rectangle(starX, starY, starW, starH)
        Next

        'Determines a random way for each starship to move 
        For i = 0 To starships.Length - 2
            While (starshipsMoveX(i) = 0)
                starshipsMoveX(i) = getRandom(5, -2)
            End While

            While (starshipsMoveY(i) = 0)
                starshipsMoveY(i) = getRandom(5, -2)
            End While
        Next
    End Sub

    'Handles collision of starships
    Public Sub collision(i As Integer)
        'Detects collision with a wall 
        If (starships(i).Right >= Me.Width) Then
            starshipsMoveX(i) = starshipsMoveX(i) * -1
        ElseIf (starships(i).Left <= 0) Then
            starshipsMoveX(i) = starshipsMoveX(i) * -1
        End If

        If (starships(i).Bottom >= 405) Then
            starshipsMoveY(i) = starshipsMoveY(i) * -1
        ElseIf (starships(i).Top <= 0) Then
            starshipsMoveY(i) = starshipsMoveY(i) * -1
        End If
    End Sub

    'Resets the game
    Public Sub reset()
        btnReset.Visible = False
        btnReset.Enabled = False
        lblGameScreen.Visible = False
        lblHighScore.Visible = False
        score = 0
        randomObjectCreation()
        starshipsLeft = starshipsNumber

        If (difficulty = "Easy") Then
            secondsLeft = 60
        ElseIf (difficulty = "Medium") Then
            secondsLeft = 30
        ElseIf (difficulty = "Hard") Then
            secondsLeft = 15
        End If

        lblTimeLeft.Text = "SECONDS LEFT: " & CStr(secondsLeft)
        lblEnemiesLeft.Text = "ENEMIES LEFT: " & CStr(starshipsNumber)
        Me.Refresh()
    End Sub

    'Gets the current high score
    Public Function getHighScore()
        'If the file doesn't exist, creates a new file
        If (System.IO.File.Exists("HighScores.txt")) Then
            System.IO.File.Create("HighScores.txt").Dispose()
        End If

        'Declares and Initilize the StreamReader object. 
        Dim reader As New StreamReader("HighScores.txt")
        Dim s As String = Nothing
        Dim pos As Integer
        Dim high As Integer

        'Iterates through the file
        While Not s Is Nothing
            pos = s.IndexOf(" ")
            high = CInt(s.Substring(0, pos))
            s = reader.ReadLine() 'Let the String s equal the next line in the file
        End While

        'Close the StreamReader
        reader.Close()
        Return high
    End Function
#End Region

#Region "Events"
    'Paint method
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Draws stars
        For j = 0 To (stars.Length - 2)
            e.Graphics.FillRectangle(Brushes.White, stars(j))
        Next

        'Draws spaceships
        For i = 0 To (starships.Length - 2)
            e.Graphics.FillRectangle(Brushes.Transparent, starships(i))
            e.Graphics.DrawImage(My.Resources.Starship, starships(i))
        Next
    End Sub

    'Load method
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        'Randomly creates the starships and stars
        randomObjectCreation()
    End Sub

    'Timer, ticks every 100ms 
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        Me.Invalidate()

        'Handles collision 
        For i = 0 To starships.Length - 2
            collision(i)
            starships(i).Offset(starshipsMoveX(i), starshipsMoveY(i))
        Next

        'Tests for a high score
        If (highScoreAchieved) Then
            highScoreAchieved = False
            lblHighScore.Text = "High Score: " & highScore
            Dim name As String = InputBox("You won!" & vbCrLf & "Enter your name: ")
            Dim writer As New StreamWriter("HighScores.txt", True)
            highScore = score
            writer.WriteLine(score & "," & name & "," & difficulty)
            writer.Close()
            lblHighScore.Visible = True
        End If


        Me.Refresh()
    End Sub

    'MouseClick event
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim mouseX As Integer = e.X
        Dim mouseY As Integer = e.Y

        'Detects if the user "destroyed" an enemy starship
        For i = 0 To starships.Length - 2
            If (mouseX < starships(i).Right) And (mouseX > starships(i).Left) And (mouseY < starships(i).Bottom) And (mouseY > starships(i).Top) Then
                starships(i) = Nothing
                starshipsMoveX(i) = Nothing
                starshipsMoveY(i) = Nothing
                score += 1
                starshipsLeft -= 1
                lblEnemiesLeft.Text = "ENEMIES LEFT: " & CStr(starshipsLeft)
                lblScore.Text = "SCORE: " & CStr(score)
            End If

            'If a victory occurs
            If (starshipsLeft <= 0) Then
                lblGameScreen.Text = "VICTORY!"
                lblGameScreen.Visible = True

                'If a high score is achieved
                If score >= highScore Then
                    highScoreAchieved = True
                End If

                btnReset.Visible = True
                btnReset.Enabled = True
            End If
        Next
    End Sub
#End Region

#Region "Menu Buttons"
    'Increase starship number
    Private Sub mnuIncreaseStarships_Click(sender As Object, e As EventArgs) Handles mnuIncreaseStarships.Click
        'Clears the arrays
        For x = 0 To (starships.Length - 2)
            starships(x) = Nothing
            starshipsMoveX(x) = Nothing
            starshipsMoveY(x) = Nothing
        Next

        'Increases array size
        starshipsNumber *= 1.25
        ReDim starships(starshipsNumber)
        ReDim starshipsMoveX(starshipsNumber)
        ReDim starshipsMoveY(starshipsNumber)

        'Resets the game
        lblEnemiesLeft.Text = "ENEMIES LEFT: " & CStr(starshipsNumber)
        reset()
    End Sub

    'Decreases starship number
    Private Sub mnuDecreaseStarships_Click(sender As Object, e As EventArgs) Handles mnuDecreaseStarships.Click
        'Clears the arrays
        For x = 0 To (starships.Length - 2)
            starships(x) = Nothing
            starshipsMoveX(x) = Nothing
            starshipsMoveY(x) = Nothing
        Next

        'Decreases array size
        starshipsNumber *= 0.75
        ReDim starships(starshipsNumber)
        ReDim starshipsMoveX(starshipsNumber)
        ReDim starshipsMoveY(starshipsNumber)

        'Resets the game
        lblEnemiesLeft.Text = "ENEMIES LEFT: " & CStr(starshipsNumber)
        reset()
    End Sub

    'Increases the ammount of stars
    Private Sub mnuIncreaseStars_Click(sender As Object, e As EventArgs) Handles mnuIncreaseStars.Click
        'Clears the array
        For x = 0 To (stars.Length - 2)
            stars(x) = Nothing
        Next

        'Increases array size
        starsNumber *= 1.25
        ReDim stars(starsNumber)

        'Creates the new objects
        randomObjectCreation()
        Me.Refresh()
    End Sub

    'Decreases the ammount of stars
    Private Sub mnuDecreaseStars_Click(sender As Object, e As EventArgs) Handles mnuDecreaseStars.Click
        'Clears the array
        For x = 0 To (stars.Length - 2)
            stars(x) = Nothing
        Next

        'Decreases array size
        starsNumber *= 0.75
        ReDim stars(starsNumber)

        'Creates the new objects
        randomObjectCreation()
        Me.Refresh()
    End Sub

    'Sets the difficulty to Easy mode
    Private Sub mnuEasyDifficulty_Click(sender As Object, e As EventArgs) Handles mnuEasyDifficulty.Click
        difficulty = "Easy"
        reset()
        Me.Invalidate()
    End Sub

    'Sets the difficulty to Medium mode
    Private Sub mnuMediumDifficulty_Click(sender As Object, e As EventArgs) Handles mnuMediumDifficulty.Click
        difficulty = "Medium"
        reset()
        Me.Invalidate()
    End Sub

    'Sets the difficulty to Hard mode
    Private Sub mnuHardDifficulty_Click(sender As Object, e As EventArgs) Handles mnuHardDifficulty.Click
        difficulty = "Hard"
        reset()
        Me.Invalidate()
    End Sub

    'Resets the application from File -> Reset
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        reset()
    End Sub

    'Exits the application from File -> Exit
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ApplicationHub.Show()
        Me.Close()
    End Sub
#End Region

#Region "Misc."
    'Seconds Left timer, ticks every second
    Private Sub tmrSecondsLeft_Tick(sender As Object, e As EventArgs) Handles tmrSecondsLeft.Tick
        If (secondsLeft <= 0) And (starshipsLeft > 0) Then
            lblGameScreen.Text = "GAME OVER!"
            lblGameScreen.Visible = True
            btnReset.Visible = True
            btnReset.Enabled = True
            For i = 0 To (starships.Length - 2)
                starships(i) = Nothing
            Next
        Else
            lblTimeLeft.Text = "SECONDS LEFT: " & CStr(secondsLeft)
            secondsLeft -= 1
        End If
    End Sub

    'Reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    'Resets the high scores
    Private Sub mnuClearHighScores_Click(sender As Object, e As EventArgs) Handles mnuClearHighScores.Click
        Dim reader As New StreamReader("HighScores.txt")
        Dim writer As New StreamWriter("HighScores.txt", True)
        System.IO.File.WriteAllText("HighScores.txt", "")
        MessageBox.Show("The High Scores have been reset.")

        reader.Close()
        writer.Close()
    End Sub

    'Displays the high scores to the user
    Private Sub mnuShowHighScores_Click(sender As Object, e As EventArgs) Handles mnuShowHighScores.Click
        'Initializes StreamReader
        Dim reader As New StreamReader("HighScores.txt")
        Dim s As String = Nothing

        s = reader.ReadToEnd() 'Gets the scores
        MessageBox.Show(s) 'Shows the scores
        reader.Close() 'Closes the StreamReader
    End Sub
#End Region
End Class
