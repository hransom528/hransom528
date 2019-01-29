'Harris Ransom
'Lab02-03_QuadForm
'Class 8

Public Class QuadForm
    'Declares variables
    Dim aValue As Double = 0 'A Coefficient
    Dim bValue As Double = 0 'B Coefficient
    Dim cValue As Double = 0  'C Coefficient
    Dim x1 As Double = 0  'First solution
    Dim x2 As Double = 0  'Second solution

    'Computes everything
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Gets values of variables
        aValue = Val(txtA.Text)
        bValue = Val(txtB.Text)
        cValue = Val(txtC.Text)

        'Computes the two solutions and stores them to variables x1 and x2
        x1 = -(-(bValue) + Math.Sqrt(Math.Pow(bValue, 2) - (4 * (aValue * cValue)))) / (2 * aValue)
        x2 = -(-(bValue) - Math.Sqrt(Math.Pow(bValue, 2) - (4 * (aValue * cValue)))) / (2 * aValue)

        'Displays the solutions
        lblSolutions.Text = "Solutions: " + Str(FormatNumber(x1, 1)) + ", " + Str(FormatNumber(x2, 1))
        btnCompute.Enabled = False
    End Sub

    'Exits the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Clears the program
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCompute.Enabled = True
        lblSolutions.Text = "Solutions: ? "

    End Sub

    'Goes back to the application hub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
