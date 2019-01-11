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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPong = New System.Windows.Forms.Button()
        Me.btnHeartHealthy = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(250, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Useful Applications"
        '
        'btnPong
        '
        Me.btnPong.Location = New System.Drawing.Point(170, 157)
        Me.btnPong.Name = "btnPong"
        Me.btnPong.Size = New System.Drawing.Size(75, 23)
        Me.btnPong.TabIndex = 1
        Me.btnPong.Text = "PONG"
        Me.btnPong.UseVisualStyleBackColor = True
        '
        'btnHeartHealthy
        '
        Me.btnHeartHealthy.Location = New System.Drawing.Point(445, 156)
        Me.btnHeartHealthy.Name = "btnHeartHealthy"
        Me.btnHeartHealthy.Size = New System.Drawing.Size(160, 23)
        Me.btnHeartHealthy.TabIndex = 2
        Me.btnHeartHealthy.Text = "Heart Healthy Calculator"
        Me.btnHeartHealthy.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(328, 156)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescription.Location = New System.Drawing.Point(184, 56)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(421, 18)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "A bunch of useful applications and games you can use."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnHeartHealthy)
        Me.Controls.Add(Me.btnPong)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPong As Button
    Friend WithEvents btnHeartHealthy As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblDescription As Label
End Class
