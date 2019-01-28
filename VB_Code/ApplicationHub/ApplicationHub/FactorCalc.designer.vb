<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactorCalc
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
        Me.txtNumberToFactor = New System.Windows.Forms.TextBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNumToFactor = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.btnHub = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(67, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(193, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Factor Calculator"
        '
        'txtNumberToFactor
        '
        Me.txtNumberToFactor.Location = New System.Drawing.Point(41, 92)
        Me.txtNumberToFactor.Name = "txtNumberToFactor"
        Me.txtNumberToFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberToFactor.TabIndex = 1
        '
        'txtFactor
        '
        Me.txtFactor.Location = New System.Drawing.Point(179, 92)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtFactor.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(114, 220)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(97, 18)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Placeholder"
        Me.lblResult.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(99, 141)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(126, 53)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(64, 278)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblNumToFactor
        '
        Me.lblNumToFactor.AutoSize = True
        Me.lblNumToFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumToFactor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNumToFactor.Location = New System.Drawing.Point(12, 71)
        Me.lblNumToFactor.Name = "lblNumToFactor"
        Me.lblNumToFactor.Size = New System.Drawing.Size(146, 18)
        Me.lblNumToFactor.TabIndex = 7
        Me.lblNumToFactor.Text = "Number to Factor:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFactor.Location = New System.Drawing.Point(198, 71)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(62, 18)
        Me.lblFactor.TabIndex = 8
        Me.lblFactor.Text = "Factor:"
        '
        'btnHub
        '
        Me.btnHub.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHub.ForeColor = System.Drawing.Color.White
        Me.btnHub.Location = New System.Drawing.Point(179, 278)
        Me.btnHub.Name = "btnHub"
        Me.btnHub.Size = New System.Drawing.Size(94, 37)
        Me.btnHub.TabIndex = 9
        Me.btnHub.Text = "Hub"
        Me.btnHub.UseVisualStyleBackColor = False
        '
        'FactorCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(346, 327)
        Me.Controls.Add(Me.btnHub)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumToFactor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtNumberToFactor)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FactorCalc"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtNumberToFactor As TextBox
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNumToFactor As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents btnHub As Button
End Class
