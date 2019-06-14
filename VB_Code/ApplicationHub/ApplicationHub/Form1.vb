'Harris Ransom
'Created 1/15/19
'Completed on 

Public Class ApplicationHub
#Region "Setup Code"

    'GetDateTime method
    Public Sub getDateTime()
        Dim dt As Date = Microsoft.VisualBasic.DateAndTime.Now() 'Gets datetime
        lblDateTime.Text = dt
    End Sub

    'Load Method
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDateTime()
    End Sub

    'Timer Tick event
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        'Gets the date/time for clock
        getDateTime()
        Me.Refresh()

        'Checks to see if the form is closed
        If (Me.IsDisposed) Then
            Application.Exit()
        End If
    End Sub

    'KeyDown event
    Private Sub ApplicationHub_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Application.Exit()
        End If
    End Sub
#End Region

#Region "Buttons"
    'Takes you to pong
    Private Sub btnPong_Click(sender As Object, e As EventArgs) Handles btnPong.Click
        VB_Pong.Show()
        Me.Hide()
    End Sub

    'Takes you to the calculator
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Calculator.Show()
        Me.Hide()
    End Sub

    'Takes you to the factorial calculator
    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Factorial.Show()
        Me.Hide()
    End Sub

    'Takes you to the factor calculator
    Private Sub btnFactorCalc_Click(sender As Object, e As EventArgs) Handles btnFactorCalc.Click
        FactorCalc.Show()
        Me.Hide()
    End Sub

    'Takes you to the quadratic formula calculator
    Private Sub btnQuadForm_Click(sender As Object, e As EventArgs) Handles btnQuadForm.Click
        QuadForm.Show()
        Me.Hide()
    End Sub

    'Takes you to the password generator
    Private Sub btnPasswordGen_Click(sender As Object, e As EventArgs) Handles btnPasswordGen.Click
        PasswordGen.Show()
        Me.Hide()
    End Sub

    'Takes you to the text editor
    Private Sub btnTextEditor_Click(sender As Object, e As EventArgs) Handles btnTextEditor.Click
        TextEditor.Show()
        Me.Hide()
    End Sub

    'Takes you to the mouse debugger
    Private Sub btnMouseDebug_Click(sender As Object, e As EventArgs) Handles btnMouseDebug.Click
        MouseDebugger.Show()
        Me.Hide()
    End Sub

    'Takes you to the music player
    Private Sub btnMusicPlayer_Click(sender As Object, e As EventArgs) Handles btnMusicPlayer.Click
        MusicPlayer.Show()
        Me.Hide()
    End Sub

    'Takes you to the perfect squares/prime numbers calculator
    Private Sub btnPerfectSquares_Click(sender As Object, e As EventArgs) Handles btnPerfectSquares.Click
        PerfectSquares.Show()
        Me.Hide()
    End Sub

    'Takes you to the Starship Fighter game
    Private Sub btnStarshipFighter_Click(sender As Object, e As EventArgs) Handles btnStarshipFighter.Click
        StarshipFighter.Show()
        Me.Hide()
    End Sub

    'Takes you to Space Invaders
    Private Sub btnSpaceInvaders_Click(sender As Object, e As EventArgs) Handles btnSpaceInvaders.Click
        VB_SpaceInvaders.Show()
        Me.Hide()
    End Sub

    'Exits the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
#End Region
End Class