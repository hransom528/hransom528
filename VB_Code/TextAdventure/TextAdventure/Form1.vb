'Harris Ransom
'Created 1/29/19
Public Class Form1
    Dim command As String = ""
    Dim health As Integer = 100
    Dim round As Integer = 1
    Dim beingAttacked As Boolean = False
    Dim attacker As String = ""
    'User enters command
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        command = CStr(txtInput.Text)

        'Determines what to do
        If (round = 1) And (command = "right") Then
            lblOutput.Text = "You are attacked by Zorks! What do you do?"
            attacker = "Zorks"
            round += 1
            beingAttacked = True
        ElseIf (round = 1) And (command = "left") Then
            lblOutput.Text = "You continue on your way until you arrive at Zepheros. YOU WIN!"
            round += 1
        End If

        If (round < 3) And (command = "attack") And (beingAttacked) And (attacker = "Zorks") Then
            lblOutput.Text = "Try as you might, you cannot win against them. GAME OGRE"
        ElseIf (command = "run") And (round < 3) And (attacker = "Zorks") Then
            lblOutput.Text = "You get away from the Zorks and are able to get to Zepheros. YOU WIN!"
            beingAttacked = False
            round += 1
        End If
    End Sub


    'Resets the game
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        round = 1
        attacker = ""
        beingAttacked = False
        command = ""
        txtInput.Text = ""
        lblOutput.Text = "You beign your adventure on a trail to Zepheros..."
    End Sub
End Class
