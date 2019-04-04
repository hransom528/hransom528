'Harris Ransom
'Created 3/26/19
Public Class MusicPlayer
    Dim loadedLocation As String = Nothing
    'Loads the selected music file
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        lstFiles.Items.Clear()
        loadedLocation = txtLocation.Text

        'Loads every music file in the selected location
        If Not (Location = Nothing) Then
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(loadedLocation)
                    If (foundFile.ToLower().EndsWith(".mp3")) Or (foundFile.ToLower().EndsWith(".wav")) Then
                        lstFiles.Items.Add(foundFile.Split("\")(foundFile.Split("\").Count() - 1))
                    End If
                Next
            End If

        loadedLocation = txtLocation.Text
    End Sub

    'Plays a selected music file
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Plays the selected item
        If (Not (lstFiles.SelectedItem = Nothing)) Then
            mediaPlayer.URL = lstFiles.SelectedItem
        End If
    End Sub

    'Opens the directory again
    Private Sub btnOpenDirectory_Click(sender As Object, e As EventArgs) Handles btnOpenDirectory.Click
        Diagnostics.Process.Start(loadedLocation)
    End Sub

    'Exits back to the hub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ApplicationHub.Show()
        Me.Close()
    End Sub
End Class