<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOperations = New System.Windows.Forms.Label()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnModulo = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.lblOperand1 = New System.Windows.Forms.Label()
        Me.lblOperand2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(155, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Advanced Functions"
        '
        'btnForm1
        '
        Me.btnForm1.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnForm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForm1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnForm1.Location = New System.Drawing.Point(456, 407)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(85, 31)
        Me.btnForm1.TabIndex = 1
        Me.btnForm1.Text = "Calculator"
        Me.btnForm1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(365, 407)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(274, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblOperations
        '
        Me.lblOperations.AutoSize = True
        Me.lblOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperations.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperations.Location = New System.Drawing.Point(32, 143)
        Me.lblOperations.Name = "lblOperations"
        Me.lblOperations.Size = New System.Drawing.Size(96, 18)
        Me.lblOperations.TabIndex = 4
        Me.lblOperations.Text = "Operations:"
        '
        'btnSin
        '
        Me.btnSin.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSin.Location = New System.Drawing.Point(35, 251)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(75, 23)
        Me.btnSin.TabIndex = 5
        Me.btnSin.Text = "Sin"
        Me.btnSin.UseVisualStyleBackColor = False
        '
        'btnCos
        '
        Me.btnCos.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCos.Location = New System.Drawing.Point(35, 280)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(75, 23)
        Me.btnCos.TabIndex = 6
        Me.btnCos.Text = "Cos"
        Me.btnCos.UseVisualStyleBackColor = False
        '
        'btnTan
        '
        Me.btnTan.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnTan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTan.Location = New System.Drawing.Point(35, 310)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(75, 23)
        Me.btnTan.TabIndex = 7
        Me.btnTan.Text = "Tan"
        Me.btnTan.UseVisualStyleBackColor = False
        '
        'btnPi
        '
        Me.btnPi.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPi.Location = New System.Drawing.Point(35, 340)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(75, 23)
        Me.btnPi.TabIndex = 8
        Me.btnPi.Text = "Pi"
        Me.btnPi.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInstructions.Location = New System.Drawing.Point(12, 37)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(598, 90)
        Me.lblInstructions.TabIndex = 10
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(235, 162)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 11
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(235, 277)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 12
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperator.Location = New System.Drawing.Point(234, 213)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(95, 20)
        Me.lblOperator.TabIndex = 13
        Me.lblOperator.Text = "Operator: "
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(235, 310)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(128, 44)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(234, 372)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(69, 20)
        Me.lblResult.TabIndex = 15
        Me.lblResult.Text = "Result:"
        Me.lblResult.Visible = False
        '
        'btnExponent
        '
        Me.btnExponent.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnExponent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExponent.Location = New System.Drawing.Point(35, 164)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(75, 23)
        Me.btnExponent.TabIndex = 16
        Me.btnExponent.Text = "^"
        Me.btnExponent.UseVisualStyleBackColor = False
        '
        'btnModulo
        '
        Me.btnModulo.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnModulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModulo.Location = New System.Drawing.Point(35, 193)
        Me.btnModulo.Name = "btnModulo"
        Me.btnModulo.Size = New System.Drawing.Size(75, 23)
        Me.btnModulo.TabIndex = 17
        Me.btnModulo.Text = "Mod"
        Me.btnModulo.UseVisualStyleBackColor = False
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSquareRoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSquareRoot.Location = New System.Drawing.Point(35, 222)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(75, 23)
        Me.btnSquareRoot.TabIndex = 18
        Me.btnSquareRoot.Text = "√"
        Me.btnSquareRoot.UseVisualStyleBackColor = False
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperand1.Location = New System.Drawing.Point(235, 145)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(80, 16)
        Me.lblOperand1.TabIndex = 19
        Me.lblOperand1.Text = "Operand 1"
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperand2.Location = New System.Drawing.Point(235, 258)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(80, 16)
        Me.lblOperand2.TabIndex = 20
        Me.lblOperand2.Text = "Operand 2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(622, 450)
        Me.Controls.Add(Me.lblOperand2)
        Me.Controls.Add(Me.lblOperand1)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnModulo)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.lblOperations)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForm1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnForm1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblOperations As Label
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lblOperator As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExponent As Button
    Friend WithEvents btnModulo As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents lblOperand1 As Label
    Friend WithEvents lblOperand2 As Label
End Class
