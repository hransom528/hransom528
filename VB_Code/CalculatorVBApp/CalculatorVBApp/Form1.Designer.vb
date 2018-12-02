<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnModulo = New System.Windows.Forms.Button()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOperatios = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDivision.Location = New System.Drawing.Point(40, 133)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 23)
        Me.btnDivision.TabIndex = 13
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnMultiplication
        '
        Me.btnMultiplication.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMultiplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMultiplication.Location = New System.Drawing.Point(40, 162)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplication.TabIndex = 14
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = False
        '
        'btnAddition
        '
        Me.btnAddition.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddition.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddition.Location = New System.Drawing.Point(40, 220)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(75, 23)
        Me.btnAddition.TabIndex = 16
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = False
        '
        'btnSubtraction
        '
        Me.btnSubtraction.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSubtraction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubtraction.Location = New System.Drawing.Point(40, 191)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtraction.TabIndex = 15
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Location = New System.Drawing.Point(236, 263)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(158, 29)
        Me.btnCompute.TabIndex = 17
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnExponent
        '
        Me.btnExponent.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExponent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExponent.Location = New System.Drawing.Point(40, 249)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(75, 23)
        Me.btnExponent.TabIndex = 18
        Me.btnExponent.Text = "^"
        Me.btnExponent.UseVisualStyleBackColor = False
        '
        'btnModulo
        '
        Me.btnModulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModulo.Location = New System.Drawing.Point(40, 279)
        Me.btnModulo.Name = "btnModulo"
        Me.btnModulo.Size = New System.Drawing.Size(75, 23)
        Me.btnModulo.TabIndex = 19
        Me.btnModulo.Text = "Mod"
        Me.btnModulo.UseVisualStyleBackColor = False
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(294, 119)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(81, 20)
        Me.txtNumber1.TabIndex = 20
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(299, 219)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(76, 20)
        Me.txtNumber2.TabIndex = 21
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOperator.Location = New System.Drawing.Point(212, 167)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(71, 18)
        Me.lblOperator.TabIndex = 22
        Me.lblOperator.Text = "Operator:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(232, 308)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(74, 24)
        Me.lblResult.TabIndex = 23
        Me.lblResult.Text = "Result:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(171, 373)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 37)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(236, 373)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 37)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(108, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(208, 31)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "CALCULATOR"
        '
        'lblOperatios
        '
        Me.lblOperatios.AutoSize = True
        Me.lblOperatios.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOperatios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblOperatios.Location = New System.Drawing.Point(30, 104)
        Me.lblOperatios.Name = "lblOperatios"
        Me.lblOperatios.Size = New System.Drawing.Size(85, 18)
        Me.lblOperatios.TabIndex = 27
        Me.lblOperatios.Text = "Operations:"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNum1.Location = New System.Drawing.Point(186, 117)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(102, 18)
        Me.lblNum1.TabIndex = 28
        Me.lblNum1.Text = "First Operand:"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumber2.Location = New System.Drawing.Point(168, 219)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(124, 18)
        Me.lblNumber2.TabIndex = 29
        Me.lblNumber2.Text = "Second Operand:"
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSquareRoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSquareRoot.Location = New System.Drawing.Point(40, 308)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(75, 23)
        Me.btnSquareRoot.TabIndex = 30
        Me.btnSquareRoot.Text = "√"
        Me.btnSquareRoot.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblInstructions.Location = New System.Drawing.Point(12, 41)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(397, 63)
        Me.lblInstructions.TabIndex = 31
        Me.lblInstructions.Text = "Please type in the first operand, second operand, and click on the appropriate oe" &
    "prator. If the operator is the square root function, put the number being rooted" &
    " into the second operand box."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(420, 445)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lblOperatios)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.btnModulo)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnExponent As Button
    Friend WithEvents btnModulo As Button
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOperatios As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents lblInstructions As Label
End Class
