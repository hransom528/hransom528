'Harris Ransom
'Created 1/15/19

Public Class ApplicationHub
#Region "Setup Code"
    'GetDateTime method
    Public Sub getDateTime()
        Dim dt As Date = Microsoft.VisualBasic.DateAndTime.Now() 'Gets date
        lblDateTime.Text = dt
    End Sub

    'Load Method
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDateTime()
    End Sub

    'Timer Tick event
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        getDateTime()
        Me.Refresh()
    End Sub
#End Region

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

    'Takes you to the perfect squares/prime numbers calculator
    Private Sub btnPerfectSquares_Click(sender As Object, e As EventArgs) Handles btnPerfectSquares.Click
        PerfectSquares.Show()
        Me.Hide()
    End Sub
End Class