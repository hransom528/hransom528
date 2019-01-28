'Harris Ransom
'Created 1/22/2019
Public Class PasswordGen
    ''Declaration statements
    'Possible characters
    Dim lowercaseChars As String = "abcdefghijklmnopqrstuvwxyz"
    Dim uppercaseChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim nums As String = "1234567890"
    Dim specialChars As String = "`~!@#$%^&*()-_=+;:{}[]\|,.<>?/'"

    'Password requirements
    Dim length As Integer = 0 'Length requirement
    Dim upperReq As Integer = 0 'Uppercase requirement
    Dim numReq As Integer = 0 'Number requirement
    Dim specialReq As Integer = 0 'Special character requirement

    'Misc.
    Dim password As String = ""
    Dim count As Integer = 0
    Dim requirementError As Boolean = False 'If requirement values are invalid


    'Gets password
    Private Sub btnGetPass_Click(sender As Object, e As EventArgs) Handles btnGetPass.Click
        'Gets user input for password requirements
        length = Val(txtLength.Text)
        upperReq = Val(txtCapital.Text)
        numReq = Val(txtNum.Text)
        specialReq = Val(txtSpecial.Text)

        'Determines if there is an error
        If (length <= 0) Or (upperReq < 0) Or (numReq < 0) Or (specialReq < 0) Then
            requirementError = True
        End If

        If (requirementError = False) Then
            lblResult.Text = "Error! Invalid requirements!"
        End If
    End Sub
End Class