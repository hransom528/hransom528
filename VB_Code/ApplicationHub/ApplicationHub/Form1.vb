'Harris Ransom
'Created 1/15/19

Public Class Form1
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPasswordGen.Click

    End Sub
End Class