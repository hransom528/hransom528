<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicationHub
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPong = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnQuadForm = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblGames = New System.Windows.Forms.Label()
        Me.btnFactorCalc = New System.Windows.Forms.Button()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.btnPasswordGen = New System.Windows.Forms.Button()
        Me.btnTextAdventure = New System.Windows.Forms.Button()
        Me.btnSpaceInvaders = New System.Windows.Forms.Button()
        Me.btnTextEditor = New System.Windows.Forms.Button()
        Me.btnMouseDebug = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.btnPerfectSquares = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(201, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Application Hub"
        '
        'btnPong
        '
        Me.btnPong.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPong.CausesValidation = False
        Me.btnPong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPong.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPong.Location = New System.Drawing.Point(282, 146)
        Me.btnPong.Name = "btnPong"
        Me.btnPong.Size = New System.Drawing.Size(99, 50)
        Me.btnPong.TabIndex = 1
        Me.btnPong.Text = "PONG"
        Me.btnPong.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnCalc.CausesValidation = False
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalc.Location = New System.Drawing.Point(69, 146)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(99, 50)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculator"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnQuadForm
        '
        Me.btnQuadForm.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnQuadForm.CausesValidation = False
        Me.btnQuadForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuadForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnQuadForm.Location = New System.Drawing.Point(69, 202)
        Me.btnQuadForm.Name = "btnQuadForm"
        Me.btnQuadForm.Size = New System.Drawing.Size(99, 50)
        Me.btnQuadForm.TabIndex = 8
        Me.btnQuadForm.Text = "Quadratic Formula"
        Me.btnQuadForm.UseVisualStyleBackColor = False
        '
        'btnFactorial
        '
        Me.btnFactorial.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnFactorial.CausesValidation = False
        Me.btnFactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFactorial.Location = New System.Drawing.Point(69, 258)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(99, 50)
        Me.btnFactorial.TabIndex = 9
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescription.Location = New System.Drawing.Point(112, 55)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(421, 18)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "A bunch of useful applications and games you can use."
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMath.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMath.Location = New System.Drawing.Point(78, 95)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(69, 48)
        Me.lblMath.TabIndex = 10
        Me.lblMath.Text = "MATH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGames
        '
        Me.lblGames.AutoSize = True
        Me.lblGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGames.Location = New System.Drawing.Point(281, 95)
        Me.lblGames.Name = "lblGames"
        Me.lblGames.Size = New System.Drawing.Size(93, 25)
        Me.lblGames.TabIndex = 11
        Me.lblGames.Text = "GAMES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnFactorCalc
        '
        Me.btnFactorCalc.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnFactorCalc.CausesValidation = False
        Me.btnFactorCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFactorCalc.Location = New System.Drawing.Point(69, 314)
        Me.btnFactorCalc.Name = "btnFactorCalc"
        Me.btnFactorCalc.Size = New System.Drawing.Size(99, 50)
        Me.btnFactorCalc.TabIndex = 12
        Me.btnFactorCalc.Text = "Factor Calculator"
        Me.btnFactorCalc.UseVisualStyleBackColor = False
        '
        'lblMisc
        '
        Me.lblMisc.AutoSize = True
        Me.lblMisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMisc.Location = New System.Drawing.Point(484, 95)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Size = New System.Drawing.Size(75, 25)
        Me.lblMisc.TabIndex = 14
        Me.lblMisc.Text = "MISC."
        '
        'btnPasswordGen
        '
        Me.btnPasswordGen.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPasswordGen.CausesValidation = False
        Me.btnPasswordGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPasswordGen.Location = New System.Drawing.Point(478, 148)
        Me.btnPasswordGen.Name = "btnPasswordGen"
        Me.btnPasswordGen.Size = New System.Drawing.Size(99, 50)
        Me.btnPasswordGen.TabIndex = 15
        Me.btnPasswordGen.Text = "Password Generator"
        Me.btnPasswordGen.UseVisualStyleBackColor = False
        '
        'btnTextAdventure
        '
        Me.btnTextAdventure.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnTextAdventure.CausesValidation = False
        Me.btnTextAdventure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextAdventure.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTextAdventure.Location = New System.Drawing.Point(282, 258)
        Me.btnTextAdventure.Name = "btnTextAdventure"
        Me.btnTextAdventure.Size = New System.Drawing.Size(99, 50)
        Me.btnTextAdventure.TabIndex = 17
        Me.btnTextAdventure.Text = "Text Adventure"
        Me.btnTextAdventure.UseVisualStyleBackColor = False
        '
        'btnSpaceInvaders
        '
        Me.btnSpaceInvaders.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSpaceInvaders.CausesValidation = False
        Me.btnSpaceInvaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpaceInvaders.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSpaceInvaders.Location = New System.Drawing.Point(282, 202)
        Me.btnSpaceInvaders.Name = "btnSpaceInvaders"
        Me.btnSpaceInvaders.Size = New System.Drawing.Size(99, 50)
        Me.btnSpaceInvaders.TabIndex = 18
        Me.btnSpaceInvaders.Text = "Space Invaders"
        Me.btnSpaceInvaders.UseVisualStyleBackColor = False
        '
        'btnTextEditor
        '
        Me.btnTextEditor.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnTextEditor.CausesValidation = False
        Me.btnTextEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextEditor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTextEditor.Location = New System.Drawing.Point(478, 202)
        Me.btnTextEditor.Name = "btnTextEditor"
        Me.btnTextEditor.Size = New System.Drawing.Size(99, 50)
        Me.btnTextEditor.TabIndex = 19
        Me.btnTextEditor.Text = "Text Editor"
        Me.btnTextEditor.UseVisualStyleBackColor = False
        '
        'btnMouseDebug
        '
        Me.btnMouseDebug.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnMouseDebug.CausesValidation = False
        Me.btnMouseDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMouseDebug.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMouseDebug.Location = New System.Drawing.Point(478, 258)
        Me.btnMouseDebug.Name = "btnMouseDebug"
        Me.btnMouseDebug.Size = New System.Drawing.Size(99, 50)
        Me.btnMouseDebug.TabIndex = 20
        Me.btnMouseDebug.Text = "Mouse Debugger"
        Me.btnMouseDebug.UseVisualStyleBackColor = False
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Location = New System.Drawing.Point(461, 472)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(179, 18)
        Me.lblDateTime.TabIndex = 21
        Me.lblDateTime.Text = "00/00/0000 0:00:00 AM"
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        '
        'btnPerfectSquares
        '
        Me.btnPerfectSquares.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPerfectSquares.CausesValidation = False
        Me.btnPerfectSquares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfectSquares.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPerfectSquares.Location = New System.Drawing.Point(69, 370)
        Me.btnPerfectSquares.Name = "btnPerfectSquares"
        Me.btnPerfectSquares.Size = New System.Drawing.Size(99, 50)
        Me.btnPerfectSquares.TabIndex = 23
        Me.btnPerfectSquares.Text = "Perfect Squares"
        Me.btnPerfectSquares.UseVisualStyleBackColor = False
        '
        'ApplicationHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(666, 499)
        Me.Controls.Add(Me.btnPerfectSquares)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnMouseDebug)
        Me.Controls.Add(Me.btnTextEditor)
        Me.Controls.Add(Me.btnSpaceInvaders)
        Me.Controls.Add(Me.btnTextAdventure)
        Me.Controls.Add(Me.btnPasswordGen)
        Me.Controls.Add(Me.lblMisc)
        Me.Controls.Add(Me.btnFactorCalc)
        Me.Controls.Add(Me.lblGames)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnQuadForm)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnPong)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "ApplicationHub"
        Me.Text = "Application Hub"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPong As Button
    Friend WithEvents btnHeartHealthy As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnQuadForm As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblMath As Label
    Friend WithEvents lblGames As Label
    Friend WithEvents btnFactorCalc As Button
    Friend WithEvents lblMisc As Label
    Friend WithEvents btnPasswordGen As Button
    Friend WithEvents btnTextAdventure As Button
    Friend WithEvents btnSpaceInvaders As Button
    Friend WithEvents btnTextEditor As Button
    Friend WithEvents btnMouseDebug As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrClock As Timer
    Friend WithEvents btnPerfectSquares As Button
End Class
