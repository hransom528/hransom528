'Harris Ransom
'Class 8
'Lab08-01_PerfectSquares

Public Class PerfectSquares
    Dim perfectSquares() As Integer 'Perfect squares array
    Dim primeNumbers() As Integer 'Prime numbers array
    Dim primeNumbersSize As Integer 'Size of the prime numbers array
    Dim underflowError As Boolean 'For an underflow error
    Dim overflowError As Boolean 'For an overflow error 
    Dim perfectSquaresCalculated As Boolean 'For when the perfect squares button is pressed
    Dim primeNumbersCalculated As Boolean 'For when the prime numbers button is pressed

    'Computes the perfect squares
    Private Sub btnComputePerfectSquares_Click(sender As Object, e As EventArgs) Handles btnComputePerfectSquares.Click
        Dim perfectSquaresSize As Integer 'Size of the perfect squares array
        perfectSquaresSize = Val(txtPerfectSquares.Text) 'Gets the size
        ReDim perfectSquares(perfectSquaresSize) 'Allocates space for the array


        'Computes the perfect squares and stores them in the array if no errors occur
        errorChecker(perfectSquaresSize)
        If (underflowError = False) And (overflowError = False) Then
            For i = 0 To (perfectSquaresSize)
                perfectSquares(i) = (i + 1) * (i + 1)
            Next

            btnComputePerfectSquares.Enabled = False
            perfectSquaresCalculated = True

            If (perfectSquaresCalculated) And (primeNumbersCalculated) Then
                btnShowLists.Enabled = True
            End If
        ElseIf (underflowError) Then
            MsgBox("Underflow error!", MsgBoxStyle.Critical)
        ElseIf (overflowError) Then
            MsgBox("Overflow error!", MsgBoxStyle.Critical)
        End If
    End Sub

    'Computes the prime numbers
    Private Sub btnComputePrimeNumbers_Click(sender As Object, e As EventArgs) Handles btnComputePrimeNumbers.Click
        Dim isPrime As Boolean = True 'Boolean for whether the number is prime or not
        Dim currentNum As Integer = 2 'Number being tested
        primeNumbersSize = Val(txtPrimeNumbers.Text) 'Gets the size of the array
        ReDim primeNumbers(primeNumbersSize) 'Allocates space for the array

        'Computes the prime numbers and stores them in the array if no errors occured
        errorChecker(primeNumbersSize)
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
            MsgBox("Underflow error!", MsgBoxStyle.Critical)
        ElseIf (overflowError) Then
            MsgBox("Overflow error!", MsgBoxStyle.Critical)
        End If

        'Checks to see if both buttons sucessfully calculated 
        If (perfectSquaresCalculated) And (primeNumbersCalculated) Then
            btnShowLists.Enabled = True
        End If
    End Sub

    'Exits the application from File --> Menu
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ApplicationHub.Show()
        Me.Close()
    End Sub

    'Clears the listboxes 
    Private Sub btnClearLists_Click(sender As Object, e As EventArgs) Handles btnClearLists.Click
        lstPerfectSquares.Items.Clear() 'Clears the perfect squares listbox
        lstPrimeNumbers.Items.Clear() 'Clears the prime numbers listbox
        btnComputePerfectSquares.Enabled = True 'Enables the perfect squares button 
        btnComputePrimeNumbers.Enabled = True 'Enables the prime numbers button
        btnClearLists.Enabled = False 'Disables the show lists button 
        perfectSquaresCalculated = False
        primeNumbersCalculated = False
        underflowError = False
        overflowError = False
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

        'Removes the zeroes from the prime numbers list 
        While (lstPrimeNumbers.Items.Contains(0))
            lstPrimeNumbers.Items.RemoveAt(lstPrimeNumbers.Items.IndexOf(0))
        End While

        btnClearLists.Enabled = True 'Enables the clear lists button
        btnShowLists.Enabled = False 'Disables the show lists button
    End Sub


    'Gets any errors
    Public Sub errorChecker(data As Integer)
        'Checks if the prime numbers size underflows 
        If (data <= 1) Then
            underflowError = True
        Else
            underflowError = False
        End If

        'Checks if the prime numbers size overflows
        If (data >= 2147483647) Then
            overflowError = True
        Else
            underflowError = False
        End If
    End Sub
End Class
