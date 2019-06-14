<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordGen
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
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtSpecial = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnGetPass = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblNums = New System.Windows.Forms.Label()
        Me.lblSpecial = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblRequirements = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(50, 111)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 0
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(50, 137)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        '
        'txtSpecial
        '
        Me.txtSpecial.Location = New System.Drawing.Point(50, 163)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(100, 20)
        Me.txtSpecial.TabIndex = 2
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(50, 85)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(35, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 33)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Password Generator"
        '
        'btnGetPass
        '
        Me.btnGetPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGetPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPass.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGetPass.Location = New System.Drawing.Point(51, 196)
        Me.btnGetPass.Name = "btnGetPass"
        Me.btnGetPass.Size = New System.Drawing.Size(113, 43)
        Me.btnGetPass.TabIndex = 5
        Me.btnGetPass.Text = "Get Random Password"
        Me.btnGetPass.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblResult.Location = New System.Drawing.Point(109, 261)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(80, 16)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Password:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLength.Location = New System.Drawing.Point(156, 89)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(54, 16)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "Length"
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapital.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCapital.Location = New System.Drawing.Point(156, 115)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(57, 16)
        Me.lblCapital.TabIndex = 8
        Me.lblCapital.Text = "Capital"
        '
        'lblNums
        '
        Me.lblNums.AutoSize = True
        Me.lblNums.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNums.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNums.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNums.Location = New System.Drawing.Point(156, 141)
        Me.lblNums.Name = "lblNums"
        Me.lblNums.Size = New System.Drawing.Size(47, 16)
        Me.lblNums.TabIndex = 9
        Me.lblNums.Text = "Nums"
        '
        'lblSpecial
        '
        Me.lblSpecial.AutoSize = True
        Me.lblSpecial.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecial.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSpecial.Location = New System.Drawing.Point(156, 164)
        Me.lblSpecial.Name = "lblSpecial"
        Me.lblSpecial.Size = New System.Drawing.Size(61, 16)
        Me.lblSpecial.TabIndex = 10
        Me.lblSpecial.Text = "Special"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReset.Location = New System.Drawing.Point(170, 196)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 43)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblRequirements
        '
        Me.lblRequirements.AutoSize = True
        Me.lblRequirements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequirements.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRequirements.Location = New System.Drawing.Point(48, 57)
        Me.lblRequirements.Name = "lblRequirements"
        Me.lblRequirements.Size = New System.Drawing.Size(108, 16)
        Me.lblRequirements.TabIndex = 12
        Me.lblRequirements.Text = "Requirements:"
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCopy.Enabled = False
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCopy.Location = New System.Drawing.Point(94, 290)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(109, 43)
        Me.btnCopy.TabIndex = 13
        Me.btnCopy.Text = "Copy To Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnExit.CausesValidation = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(273, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 29)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PasswordGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(347, 355)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lblRequirements)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblSpecial)
        Me.Controls.Add(Me.lblNums)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnGetPass)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtSpecial)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtCapital)
        Me.DoubleBuffered = True
        Me.Name = "PasswordGen"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtSpecial As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnGetPass As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblNums As Label
    Friend WithEvents lblSpecial As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblRequirements As Label
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnExit As Button
End Class
