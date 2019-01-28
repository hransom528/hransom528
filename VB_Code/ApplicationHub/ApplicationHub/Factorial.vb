'Harris Ransom
'Class 8
'Lab05-02_Factorial

Public Class Factorial
    'Declares variable
    Dim number As Integer = 0 'Number to calculate
    Dim answer As Integer = 1 'The result of the factorial
    'Calculates and displays factorial
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Gets value of number
        number = Val(txtNumber.Text)

        'Calculates factorial or displays error if system overflow occurs
        If (number > 12) Then
            lblResult.Text = "Error! System overflow!"
        Else
            'Calculates factorial
            For i = 1 To number
                answer *= i
            Next
            'Displays factorial if no error occured
            lblResult.Text = Str(number) + "! = " + Str(answer)
        End If

        'Shows result
        lblResult.Visible = True

        'Disables the submit button and enables the reset button
        btnSubmit.Visible = False
        btnSubmit.Enabled = False
        btnReset.Visible = True
        btnReset.Enabled = True
    End Sub

    'Resets the program
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblResult.Visible = False
        lblResult.Text = ""
        txtNumber.Text = ""
        number = 0
        answer = 1
        btnReset.Visible = False
        btnReset.Enabled = False
        btnSubmit.Visible = True
        btnSubmit.Enabled = True
    End Sub

    'Takes user back to hub
    Private Sub btnHub_Click(sender As Object, e As EventArgs) Handles btnHub.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
