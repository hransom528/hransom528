'Harris Ransom
'Pong Main Menu
Public Class PongMainMenu

    'Takes user back to pong
    Private Sub btnPong_Click(sender As Object, e As EventArgs) Handles btnPong.Click
        Me.Hide()
        VB_Pong.Show()
    End Sub

    'Exits application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class