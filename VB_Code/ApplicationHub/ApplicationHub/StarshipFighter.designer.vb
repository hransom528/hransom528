<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StarshipFighter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNumberOfStarships = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIncreaseStarships = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDecreaseStarships = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNumberOfStars = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIncreaseStars = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDecreaseStars = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEasyDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMediumDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHardDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScoresOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearHighScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowHighScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.tmrSecondsLeft = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblGameScreen = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblEnemiesLeft = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 10
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOptions})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(102, 22)
        Me.mnuFileReset.Text = "Reset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNumberOfStarships, Me.mnuNumberOfStars, Me.mnuDifficultyOptions, Me.mnuScoresOptions})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuNumberOfStarships
        '
        Me.mnuNumberOfStarships.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIncreaseStarships, Me.mnuDecreaseStarships})
        Me.mnuNumberOfStarships.Name = "mnuNumberOfStarships"
        Me.mnuNumberOfStarships.Size = New System.Drawing.Size(182, 22)
        Me.mnuNumberOfStarships.Text = "Number of Starships"
        '
        'mnuIncreaseStarships
        '
        Me.mnuIncreaseStarships.Name = "mnuIncreaseStarships"
        Me.mnuIncreaseStarships.Size = New System.Drawing.Size(121, 22)
        Me.mnuIncreaseStarships.Text = "Increase"
        '
        'mnuDecreaseStarships
        '
        Me.mnuDecreaseStarships.Name = "mnuDecreaseStarships"
        Me.mnuDecreaseStarships.Size = New System.Drawing.Size(121, 22)
        Me.mnuDecreaseStarships.Text = "Decrease"
        '
        'mnuNumberOfStars
        '
        Me.mnuNumberOfStars.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIncreaseStars, Me.mnuDecreaseStars})
        Me.mnuNumberOfStars.Name = "mnuNumberOfStars"
        Me.mnuNumberOfStars.Size = New System.Drawing.Size(182, 22)
        Me.mnuNumberOfStars.Text = "Number of Stars"
        '
        'mnuIncreaseStars
        '
        Me.mnuIncreaseStars.Name = "mnuIncreaseStars"
        Me.mnuIncreaseStars.Size = New System.Drawing.Size(121, 22)
        Me.mnuIncreaseStars.Text = "Increase"
        '
        'mnuDecreaseStars
        '
        Me.mnuDecreaseStars.Name = "mnuDecreaseStars"
        Me.mnuDecreaseStars.Size = New System.Drawing.Size(121, 22)
        Me.mnuDecreaseStars.Text = "Decrease"
        '
        'mnuDifficultyOptions
        '
        Me.mnuDifficultyOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEasyDifficulty, Me.mnuMediumDifficulty, Me.mnuHardDifficulty})
        Me.mnuDifficultyOptions.Name = "mnuDifficultyOptions"
        Me.mnuDifficultyOptions.Size = New System.Drawing.Size(182, 22)
        Me.mnuDifficultyOptions.Text = "Difficulty"
        '
        'mnuEasyDifficulty
        '
        Me.mnuEasyDifficulty.Name = "mnuEasyDifficulty"
        Me.mnuEasyDifficulty.Size = New System.Drawing.Size(119, 22)
        Me.mnuEasyDifficulty.Text = "Easy"
        '
        'mnuMediumDifficulty
        '
        Me.mnuMediumDifficulty.Name = "mnuMediumDifficulty"
        Me.mnuMediumDifficulty.Size = New System.Drawing.Size(119, 22)
        Me.mnuMediumDifficulty.Text = "Medium"
        '
        'mnuHardDifficulty
        '
        Me.mnuHardDifficulty.Name = "mnuHardDifficulty"
        Me.mnuHardDifficulty.Size = New System.Drawing.Size(119, 22)
        Me.mnuHardDifficulty.Text = "Hard"
        '
        'mnuScoresOptions
        '
        Me.mnuScoresOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClearHighScores, Me.mnuShowHighScores})
        Me.mnuScoresOptions.Name = "mnuScoresOptions"
        Me.mnuScoresOptions.Size = New System.Drawing.Size(182, 22)
        Me.mnuScoresOptions.Text = "Scores"
        '
        'mnuClearHighScores
        '
        Me.mnuClearHighScores.Name = "mnuClearHighScores"
        Me.mnuClearHighScores.Size = New System.Drawing.Size(169, 22)
        Me.mnuClearHighScores.Text = "Clear High Scores"
        '
        'mnuShowHighScores
        '
        Me.mnuShowHighScores.Name = "mnuShowHighScores"
        Me.mnuShowHighScores.Size = New System.Drawing.Size(169, 22)
        Me.mnuShowHighScores.Text = "Show High Scores"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimeLeft.Location = New System.Drawing.Point(560, 407)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(178, 20)
        Me.lblTimeLeft.TabIndex = 1
        Me.lblTimeLeft.Text = "SECONDS LEFT:  60"
        '
        'tmrSecondsLeft
        '
        Me.tmrSecondsLeft.Enabled = True
        Me.tmrSecondsLeft.Interval = 1000
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(12, 407)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(91, 20)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "SCORE: 0"
        '
        'lblGameScreen
        '
        Me.lblGameScreen.AutoSize = True
        Me.lblGameScreen.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblGameScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGameScreen.Location = New System.Drawing.Point(267, 187)
        Me.lblGameScreen.Name = "lblGameScreen"
        Me.lblGameScreen.Size = New System.Drawing.Size(219, 37)
        Me.lblGameScreen.TabIndex = 3
        Me.lblGameScreen.Text = "GAME OVER"
        Me.lblGameScreen.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReset.Location = New System.Drawing.Point(311, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 39)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'lblEnemiesLeft
        '
        Me.lblEnemiesLeft.AutoSize = True
        Me.lblEnemiesLeft.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblEnemiesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemiesLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEnemiesLeft.Location = New System.Drawing.Point(283, 407)
        Me.lblEnemiesLeft.Name = "lblEnemiesLeft"
        Me.lblEnemiesLeft.Size = New System.Drawing.Size(167, 20)
        Me.lblEnemiesLeft.TabIndex = 5
        Me.lblEnemiesLeft.Text = "ENEMIES LEFT: 25"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHighScore.Location = New System.Drawing.Point(251, 294)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(219, 37)
        Me.lblHighScore.TabIndex = 6
        Me.lblHighScore.Text = "GAME OVER"
        Me.lblHighScore.Visible = False
        '
        'StarshipFighter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(734, 436)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblEnemiesLeft)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblGameScreen)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximumSize = New System.Drawing.Size(750, 475)
        Me.MinimumSize = New System.Drawing.Size(750, 475)
        Me.Name = "StarshipFighter"
        Me.Text = "Click the Starships!"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrTimer As Timer
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuNumberOfStarships As ToolStripMenuItem
    Friend WithEvents mnuIncreaseStarships As ToolStripMenuItem
    Friend WithEvents mnuDecreaseStarships As ToolStripMenuItem
    Friend WithEvents mnuNumberOfStars As ToolStripMenuItem
    Friend WithEvents mnuIncreaseStars As ToolStripMenuItem
    Friend WithEvents mnuDecreaseStars As ToolStripMenuItem
    Friend WithEvents mnuDifficultyOptions As ToolStripMenuItem
    Friend WithEvents mnuEasyDifficulty As ToolStripMenuItem
    Friend WithEvents mnuMediumDifficulty As ToolStripMenuItem
    Friend WithEvents mnuHardDifficulty As ToolStripMenuItem
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents tmrSecondsLeft As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblGameScreen As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblEnemiesLeft As Label
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents lblHighScore As Label
    Friend WithEvents mnuScoresOptions As ToolStripMenuItem
    Friend WithEvents mnuClearHighScores As ToolStripMenuItem
    Friend WithEvents mnuShowHighScores As ToolStripMenuItem
End Class
