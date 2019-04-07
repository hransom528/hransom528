'Harris Ransom
'Class 8
'Lab08-01_PerfectSquares

Public Class PerfectSquares
    Dim perfectSquares() As Integer 'Perfect squares array
    Dim primeNumbers() As Integer 'Prime numbers array
    Dim factorials() As Int64 'Factorials array
    Dim primeNumbersSize As Integer 'Size of the prime numbers array
    Dim underflowError As Boolean 'For an underflow error
    Dim overflowError As Boolean 'For an overflow error 
    Dim perfectSquaresCalculated As Boolean 'For when the perfect squares button is pressed
    Dim primeNumbersCalculated As Boolean 'For when the prime numbers button is pressed
    Dim factorialsCalculated As Boolean 'For when the factorial button is pressed
    Dim factorialOverflowError As Boolean 'For when the factorials overflow
    Dim negativeFactorial As Boolean 'For when the factorial calculation is negative
    Dim zeroFactorial As Boolean 'For when the factorial calculation is zero

    'Computes the perfect squares
    Private Sub btnComputePerfectSquares_Click(sender As Object, e As EventArgs) Handles btnComputePerfectSquares.Click
        Dim perfectSquaresSize As Integer 'Size of the perfect squares array
        perfectSquaresSize = Val(txtPerfectSquares.Text) 'Gets the size
        ReDim perfectSquares(perfectSquaresSize) 'Allocates space for the array

        'Computes the perfect squares and stores them in the array if no errors occur
        errorChecker(perfectSquaresSize, "Squares")
        If (underflowError = False) And (overflowError = False) Then
            For i = 0 To (perfectSquaresSize)
                perfectSquares(i) = (i + 1) * (i + 1)
            Next

            btnComputePerfectSquares.Enabled = False
            perfectSquaresCalculated = True

            If (perfectSquaresCalculated) And (primeNumbersCalculated) And (factorialsCalculated) Then
                btnShowLists.Enabled = True
            End If
        ElseIf (underflowError) Then
            MsgBox("Perfect Squares underflow error!", MsgBoxStyle.Critical)
        ElseIf (overflowError) Then
            MsgBox("Perfect Squares overflow error!", MsgBoxStyle.Critical)
        End If
    End Sub

    'Computes the prime numbers
    Private Sub btnComputePrimeNumbers_Click(sender As Object, e As EventArgs) Handles btnComputePrimeNumbers.Click
        Dim isPrime As Boolean = True 'Boolean for whether the number is prime or not
        Dim currentNum As Integer = 2 'Number being tested
        primeNumbersSize = Val(txtPrimeNumbers.Text) 'Gets the size of the array
        ReDim primeNumbers(primeNumbersSize) 'Allocates space for the array

        'Computes the prime numbers and stores them in the array if no errors occured
        errorChecker(primeNumbersSize, "Prime")
        If (underflowError = False) Then
            For i = 2 To primeNumbersSize
                isPrime = True

                For d = 2 To (i - 1)
                    If (i Mod d = 0) Then
                        isPrime = False
                    Else
                        currentNum = i
                    End If
                Next

                If (isPrime) Then
                    primeNumbers(i - 1) = currentNum
                End If
            Next
            primeNumbersCalculated = True
            btnComputePrimeNumbers.Enabled = False
        ElseIf (underflowError) Then
            MsgBox("Prime underflow error!", MsgBoxStyle.Critical)
        ElseIf (overflowError) Then
            MsgBox("Prime overflow error!", MsgBoxStyle.Critical)
        End If

        'Checks to see if all buttons sucessfully calculated 
        If (perfectSquaresCalculated) And (primeNumbersCalculated) And (factorialsCalculated) Then
            btnShowLists.Enabled = True
        End If
    End Sub

    'Computes the factorials
    Private Sub btnComputeFactorials_Click(sender As Object, e As EventArgs) Handles btnComputeFactorials.Click
        'Does the calculations
        Dim limit As Integer = Val(txtFactorials.Text)
        Dim currAnswer As Int64 = 1
        ReDim factorials(Math.Abs(limit))

        errorChecker(limit, "Factorials") 'Gets any errors

        'If no errors or edge cases occur, does the calculations 
        If (factorialOverflowError) Then
            MsgBox("Factorial overflow error!", MsgBoxStyle.Critical)
        ElseIf (limit = 0) Then
            zeroFactorial = True
        ElseIf (limit < 0) Then
            For i = 0 To factorials.Length - 2
                factorials(i) = 1
                negativeFactorial = True
            Next
        Else
            For i = 1 To (factorials.Length() - 1)
                factorials(i - 1) = getFactorial(i)
            Next
        End If

        'Sets up other buttons if no errors occured
        If (factorialOverflowError = False) Then
            btnComputeFactorials.Enabled = False
            factorialsCalculated = True
        End If

        'Checks to see if all buttons sucessfully calculated 
        If (perfectSquaresCalculated) And (primeNumbersCalculated) And (factorialsCalculated) Then
            btnShowLists.Enabled = True
        End If
    End Sub

    'Calculates a factorial number
    Public Function getFactorial(num As Integer)
        Dim result As Int64 = 1
        For j = 1 To num
            result *= j
        Next
        Return result
    End Function

    'Gets any errors
    Public Sub errorChecker(data As Integer, dataSet As String)
        'Checks if the prime numbers size or perfect squares size underflows 
        If (data <= 1) And ((dataSet = "Squares") Or (dataSet = "Prime")) Then
            underflowError = True
        Else
            underflowError = False
        End If

        'Checks if the prime numbers size or perfect squares size overflows
        If (data >= 2147483647) And (dataSet = "Prime" Or dataSet = "Squares") Then
            overflowError = True
        Else
            overflowError = False
        End If

        'Checks to see if the factorials overflow
        If (data > 20) Then
            factorialOverflowError = True
        Else
            factorialOverflowError = False
        End If
    End Sub

    'Displays the arrays in the listboxes
    Private Sub btnShowLists_Click(sender As Object, e As EventArgs) Handles btnShowLists.Click
        'Displays the perfect squares 
        For i = 0 To (perfectSquares.Length - 2)
            lstPerfectSquares.Items.Add(perfectSquares(i))
        Next

        'Displays the prime numbers
        For i = 0 To (primeNumbers.Length - 2)
            lstPrimeNumbers.Items.Add(primeNumbers(i))
        Next

        'Displays the factorials, including edge cases
        If (negativeFactorial) Then
            For i = 0 To (factorials.Length - 2)
                lstFactorials.Items.Add("(" & (CStr(-1 * (Math.Abs(i + 1)))) & ")" & "! = " & factorials(i))
            Next
            negativeFactorial = False
        ElseIf (zeroFactorial) Then
            lstFactorials.Items.Add("0! = 1")
        Else
            For i = 0 To (factorials.Length - 2)
                lstFactorials.Items.Add(CStr(i + 1) & "! = " & factorials(i))
            Next
        End If

        'Removes the zeroes from the prime numbers list 
        While (lstPrimeNumbers.Items.Contains(0))
            lstPrimeNumbers.Items.RemoveAt(lstPrimeNumbers.Items.IndexOf(0))
        End While

        btnClearLists.Enabled = True 'Enables the clear lists button
        btnShowLists.Enabled = False 'Disables the show lists button
    End Sub

    'Clears the listboxes 
    Private Sub btnClearLists_Click(sender As Object, e As EventArgs) Handles btnClearLists.Click
        lstPerfectSquares.Items.Clear() 'Clears the perfect squares listbox
        lstPrimeNumbers.Items.Clear() 'Clears the prime numbers listbox
        lstFactorials.Items.Clear() 'Clears the factorials listbox
        btnComputePerfectSquares.Enabled = True 'Enables the perfect squares button 
        btnComputePrimeNumbers.Enabled = True 'Enables the prime numbers button
        btnComputeFactorials.Enabled = True 'Enables the factorials button
        btnClearLists.Enabled = False 'Disables the show lists button 
        perfectSquaresCalculated = False
        primeNumbersCalculated = False
        factorialsCalculated = False
        underflowError = False
        overflowError = False
        factorialOverflowError = False
    End Sub

    'Exits the application from File --> Menu
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ApplicationHub.Show()
        Me.Close()
    End Sub
End Class
