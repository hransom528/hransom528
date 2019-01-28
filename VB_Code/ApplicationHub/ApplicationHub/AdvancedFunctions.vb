'Creator: Harris Ransom
'Calculator VB Application, Advanced Functions
'Created 12/11/18


Public Class AdvancedFunctions
    'Declares variables
    Dim num1 As Double = 0.0 'First operand
    Dim num2 As Double = 0.0 'Second operand
    Dim op As String = "" 'Operator being used in calculation
    Dim totalNumber As Double = 0.0 'Final result of calculation
    Const PI As Double = 3.1415926535897 'Constant of pi

    'Adds sin as the operator
    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        op = "sin"
        lblOperator.Text = "Operator: Sin"
    End Sub

    'Adds cos as operator
    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        op = "cos"
        lblOperator.Text = "Operator: Cos"
    End Sub

    'Adds tan as operator
    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        op = "tan"
        lblOperator.Text = "Operator: Tan"
    End Sub

    'Adds the pi constant as operator
    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        op = "pi"
        lblOperator.Text = "Operator: Pi"
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

    'Calculates everything
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Gets values
        num1 = Val(txt1.Text)
        num2 = Val(txt2.Text)

        'Determines calculation
        If op = "sin" Then
            totalNumber = Math.Sin(num2)
        ElseIf op = "cos" Then
            totalNumber = Math.Cos(num2)
        ElseIf op = "tan" Then
            totalNumber = Math.Tan(num2)
        ElseIf op = "pi" Then
            totalNumber = PI * num2
        ElseIf op = "Exponent" Then
            totalNumber = Math.Pow(num1, num2)
        ElseIf op = "Modulo" Then
            totalNumber = num1 Mod num2
        ElseIf op = "Square Root" Then
            totalNumber = Math.Sqrt(num2)
        Else
            lblResult.Visible = True
            lblResult.Text = "Result: Error"
        End If

        'Displays calculation
        If (lblResult.Text <> "Result: Error") Then
            lblResult.Visible = True
            lblResult.Text = "Result: " + FormatNumber(totalNumber, 3)
        End If
    End Sub

    'Clears program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblResult.Text = "Result: "
        lblResult.Visible = False
        op = ""
        num1 = 0
        num2 = 0
        totalNumber = 0
        txt1.Text = ""
        txt2.Text = ""
        lblOperator.Text = "Operator: "
    End Sub

    'Takes user back to basic calculator
    Private Sub btnForm1_Click(sender As Object, e As EventArgs) Handles btnForm1.Click
        Calculator.Show()
        Me.Hide()
    End Sub

    'Exits application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class