'The help page for the Factor Calculator
Public Class Help
    'Goes back to the factor calculator 
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class