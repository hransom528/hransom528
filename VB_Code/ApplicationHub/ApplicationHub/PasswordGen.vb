'Harris Ransom
'Created 1/22/2019
Imports System

Public Class PasswordGen
    ''Declaration statements
    'Possible characters
    Dim lowercaseChars As String = "abcdefghijklmnopqrstuvwxyz"
    Dim uppercaseChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim nums As String = "1234567890"
    Dim specialChars As String = "`~!@#$%^&*()-_=+;:{}[]\|,.<>?/'"

    'Password requirements
    Dim length As Integer = 0 'Length requirement
    Dim capitalReq As Integer = 0 'Uppercase requirement
    Dim numReq As Integer = 0 'Number requirement
    Dim specialReq As Integer = 0 'Special character requirement

    'Misc.
    Dim password As String = ""
    Dim count As Integer = 0
    Dim lengthError As Boolean = False
    Dim capitalError As Boolean = False
    Dim numError As Boolean = False
    Dim specialError As Boolean = False

#Region "Methods"
    'Method to determine if there was an error
    Public Sub getError()
        'Length error
        If (length <= 0) Then
            lengthError = True
        End If
        'Capital error
        If (capitalReq < 0) Then
            capitalError = True
        End If
        'Number error
        If (numReq < 0) Then
            numError = True
        End If
        'Special error
        If (specialReq < 0) Then
            specialError = True
        End If
    End Sub

    'Method to generate actual password
    Public Sub makePassword(requiredCount, characterSet)
        'While the count is less than the requirement specified, add the characters from the character set specified 
        'to the password
        While (count < requiredCount)

        End While
    End Sub

    'Method to shuffle password after it is made
    Public Sub shuffle(str)

    End Sub
#End Region

    'Gets password
    Private Sub btnGetPass_Click(sender As Object, e As EventArgs) Handles btnGetPass.Click
        'Gets user input for password requirements
        length = Val(txtLength.Text)
        capitalReq = Val(txtCapital.Text)
        numReq = Val(txtNum.Text)
        specialReq = Val(txtSpecial.Text)

        'Gets any errors
        getError()

        'Makes password using methods, if there were no errors
        If (lengthError = False) And (capitalError = False) And (numError = False) And (specialError = False) Then
            makePassword(capitalReq, uppercaseChars) 'Uppercase
            makePassword(numReq, nums) 'Numbers
            makePassword(specialReq, specialChars) 'Special characters
            makePassword(length - Len(password), lowercaseChars) 'Lowercase
        End If

    End Sub
End Class