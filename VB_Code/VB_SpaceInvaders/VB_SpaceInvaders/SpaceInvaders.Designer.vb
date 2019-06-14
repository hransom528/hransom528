<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpaceInvaders
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAliens = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAlienRandShoot = New System.Windows.Forms.Timer(Me.components)
        Me.lblgameScreen = New System.Windows.Forms.Label()
        Me.picLife3 = New System.Windows.Forms.PictureBox()
        Me.picLife2 = New System.Windows.Forms.PictureBox()
        Me.picLife1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLife3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Lime
        Me.lblTitle.Location = New System.Drawing.Point(254, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SPACE INVADERS"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Location = New System.Drawing.Point(30, 19)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(86, 20)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score:  0"
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 25
        '
        'tmrAliens
        '
        Me.tmrAliens.Enabled = True
        Me.tmrAliens.Interval = 1000
        '
        'tmrAlienRandShoot
        '
        Me.tmrAlienRandShoot.Enabled = True
        Me.tmrAlienRandShoot.Interval = 2500
        '
        'lblgameScreen
        '
        Me.lblgameScreen.AutoSize = True
        Me.lblgameScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblgameScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgameScreen.ForeColor = System.Drawing.Color.Lime
        Me.lblgameScreen.Location = New System.Drawing.Point(323, 286)
        Me.lblgameScreen.Name = "lblgameScreen"
        Me.lblgameScreen.Size = New System.Drawing.Size(186, 31)
        Me.lblgameScreen.TabIndex = 6
        Me.lblgameScreen.Text = "GAME OVER"
        Me.lblgameScreen.Visible = False
        '
        'picLife3
        '
        Me.picLife3.Image = Global.VB_SpaceInvaders.My.Resources.Resources.ship
        Me.picLife3.Location = New System.Drawing.Point(692, 8)
        Me.picLife3.Name = "picLife3"
        Me.picLife3.Size = New System.Drawing.Size(50, 38)
        Me.picLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife3.TabIndex = 4
        Me.picLife3.TabStop = False
        '
        'picLife2
        '
        Me.picLife2.Image = Global.VB_SpaceInvaders.My.Resources.Resources.ship
        Me.picLife2.Location = New System.Drawing.Point(636, 8)
        Me.picLife2.Name = "picLife2"
        Me.picLife2.Size = New System.Drawing.Size(50, 38)
        Me.picLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife2.TabIndex = 3
        Me.picLife2.TabStop = False
        '
        'picLife1
        '
        Me.picLife1.Image = Global.VB_SpaceInvaders.My.Resources.Resources.ship
        Me.picLife1.Location = New System.Drawing.Point(580, 8)
        Me.picLife1.Name = "picLife1"
        Me.picLife1.Size = New System.Drawing.Size(50, 38)
        Me.picLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife1.TabIndex = 2
        Me.picLife1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.lblgameScreen)
        Me.Controls.Add(Me.picLife3)
        Me.Controls.Add(Me.picLife2)
        Me.Controls.Add(Me.picLife1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLife3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents picLife1 As PictureBox
    Friend WithEvents picLife2 As PictureBox
    Friend WithEvents picLife3 As PictureBox
    Friend WithEvents tmrAliens As Timer
    Friend WithEvents tmrAlienRandShoot As Timer
    Friend WithEvents lblgameScreen As Label
End Class
