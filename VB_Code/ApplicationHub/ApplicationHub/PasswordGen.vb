'Harris Ransom
'Created 1/22/2019
Imports System

Public Class PasswordGen
#Region "Declaration statements"
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

    Dim lengthError As Boolean = False
    Dim capitalError As Boolean = False
    Dim numError As Boolean = False
    Dim specialError As Boolean = False
    Dim additionError As Boolean = False

    Dim randomLowerIndex As Integer = Math.Floor(Rnd() * 26)
    Dim randomUpperIndex As Integer = Math.Floor(Rnd() * 26)
    Dim randomNumIndex As Integer = Math.Floor(Rnd() * 10)
    Dim randomSpecialIndex As Integer = Math.Floor(Rnd() * 31)
#End Region

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
        'Addition error
        If ((specialReq + capitalReq + numReq) > length) Then
            additionError = True
        End If
    End Sub

    'Method to generate actual password
    Public Sub makePassword(requiredCount As Integer, characterSet As String)
        Dim localCount As Integer = 0

        'If the characterset is lowercase
        If (characterSet = "lower") And (Len(password) < length) Then
            While (localCount < requiredCount)
                password += lowercaseChars.Substring(randomLowerIndex, 1)
                localCount += 1
                randomLowerIndex = Math.Floor(Rnd() * 26)
            End While
        End If

        'If the characterset is uppercase
        If (characterSet = "upper") And (Len(password) <= length) Then
            While (localCount < requiredCount)
                password += uppercaseChars.Chars(randomUpperIndex)
                localCount += 1
                randomUpperIndex = Math.Floor(Rnd() * 26)
            End While
            localCount = 0
        End If

        'If the characterset is numbers
        If (characterSet = "nums") And (Len(password) <= length) Then
            While (localCount < requiredCount)
                password += nums.Chars(randomNumIndex)
                localCount += 1
                randomNumIndex = Math.Floor(Rnd() * 10)
            End While
            localCount = 0
        End If

        'If the characterset is special
        If (characterSet = "special") And (Len(password) <= length) Then
            While (localCount < requiredCount)
                password += specialChars.Chars(randomSpecialIndex)
                localCount += 1
                randomSpecialIndex = Math.Floor(Rnd() * 31)
            End While
            localCount = 0
        End If
    End Sub

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
        If (lengthError = False) And (capitalError = False) And (numError = False) And (specialError = False) And (additionError = False) Then
            makePassword(capitalReq, "upper") 'Uppercase
            makePassword(numReq, "nums") 'Numbers
            makePassword(specialReq, "special") 'Special characters
            makePassword(length - Len(password) + 1, "lower") 'Lowercase
        ElseIf (additionError) Then
            MessageBox.Show("Requirements do not add up!")
        ElseIf (lengthError) Then
            MessageBox.Show("Invalid length requirement!")
        ElseIf (capitalError) Then
            MessageBox.Show("Invalid capital requirement!")
        ElseIf (numError) Then
            MessageBox.Show("Invalid number requirement!")
        ElseIf (specialError) Then
            MessageBox.Show("Invalid special requirement!")
        End If

        lblResult.Text = "Password: " + password

        'Enables reset and copy buttons
        btnCopy.Enabled = True
        btnReset.Enabled = True
    End Sub

    'Reset Button 
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCapital.Text = ""
        txtLength.Text = ""
        txtNum.Text = ""
        txtSpecial.Text = ""
        lblResult.Text = ""
        password = ""
        btnCopy.Enabled = False
        btnReset.Enabled = False
        Randomize()
        Me.Invalidate()
    End Sub

    'Copies password to clipboard
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(password)
    End Sub

    'Exits to the application hub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
#End Region

#Region "Events"
    'Form load
    Private Sub PasswordGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    'KeyDown Event
    Private Sub PasswordGen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If the escape key is pressed
        If (e.KeyCode = Keys.Escape) Then
            ApplicationHub.Show()
            Me.Close()
        End If
    End Sub
#End Region
End Class