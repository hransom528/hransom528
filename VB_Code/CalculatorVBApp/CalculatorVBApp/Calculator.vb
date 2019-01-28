'Harris Ransom
'Calculator VB Application
'Created 11/8/2018


Public Class Calculator
    'Declares Variables and imports modules
    Dim num1 As Double = 0.00 'First operand
    Dim num2 As Double = 0.00 'Second operand
    Dim op As String = "" 'Operation being used in the calculation
    Dim totalNumber As Double = 0.00 'End result

    'Adds addition as the operator
    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        op = "Addition"
        lblOperator.Text = "Operator: +"
    End Sub

    'Adds subtraction as the operator
    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        op = "Subtraction"
        lblOperator.Text = "Operator: -"
    End Sub

    'Adds multiplication as the operator
    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        op = "Multiplication"
        lblOperator.Text = "Operator: *"
    End Sub

    'Adds divsion as the operator
    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        op = "Division"
        lblOperator.Text = "Operator: /"

    End Sub

    'Adds exponent as the operator
    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        op = "Exponent"
        lblOperator.Text = "Operator: ^"
    End Sub

    'Adds modulo as the operator
    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click
        op = "Mod"
        lblOperator.Text = "Operator: Mod"
    End Sub

    'Adds square root as operator
    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        op = "Square Root"
        lblOperator.Text = "Operator: √"
    End Sub

    'Computes for the calculator program
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Gets values
        num1 = Val(txtNumber1.Text)
        num2 = Val(txtNumber2.Text)
        'Checks for operator, and does appropriate calculation
        If op = "Addition" Then
            totalNumber = num1 + num2
        ElseIf op = "Subtraction" Then
            totalNumber = num1 - num2
        ElseIf op = "Multiplicatioh" Then
            totalNumber = num1 * num2
        ElseIf op = "Division" Then
            totalNumber = num1 / num2
        ElseIf op = "Exponent" Then
            totalNumber = Math.Pow(num1, num2)
        ElseIf op = "Mod" Then
            totalNumber = num1 Mod num2
        ElseIf op = "Square Root" Then
            totalNumber = Math.Sqrt(num2)
        End If

        'Displays calculation
        lblResult.Text = "Result: " + FormatNumber(totalNumber, 3)
    End Sub

    'Goes to the advanced functions form
    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        AdvancedFunctions.Show()
        Me.Hide()
    End Sub

    'Clears the program
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        totalNumber = 0
        op = ""
        num1 = 0
        num2 = 0
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        lblOperator.Text = "Operator: "
        lblResult.Text = "Result: "
    End Sub

    'Exits the calculator bprogram
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Takes the user to the Factor Calculator form
    Private Sub btnFactorCalculator_Click(sender As Object, e As EventArgs) Handles btnFactorCalculator.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
