<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 25
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(340, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(116, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PONG"
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPause.Location = New System.Drawing.Point(318, 51)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(165, 39)
        Me.lblPause.TabIndex = 4
        Me.lblPause.Text = "PAUSED"
        Me.lblPause.Visible = False
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.lblScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore1.Location = New System.Drawing.Point(118, 68)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(124, 18)
        Me.lblScore1.TabIndex = 5
        Me.lblScore1.Text = "Player 1 Score:"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.lblScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore2.Location = New System.Drawing.Point(560, 68)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(124, 18)
        Me.lblScore2.TabIndex = 6
        Me.lblScore2.Text = "Player 2 Score:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPause As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore2 As Label
End Class
