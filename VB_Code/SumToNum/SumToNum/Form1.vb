'Harris Ransom
'Created 1/15/19
'Takes the sum of 1 to a number

Public Class Form1
    Dim num As Integer = 0 'Num range goes to
    Dim sum As Integer = 0 'Sum of numbers in range

    'Calculates and displays sum
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Gets num value from textbox
        num = Val(txtNum.Text)

        'Calculation
        For i = 1 To num
            sum += i
        Next

        'Displays sum
        lblSum.Visible = True
        lblSum.Text = "Sum: " + FormatNumber(sum, 0)
    End Sub

    'Resets program
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        sum = 0
        num = 0
        txtNum.Text = "Enter a number..."
        lblSum.Visible = False
    End Sub

    'Exits program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
