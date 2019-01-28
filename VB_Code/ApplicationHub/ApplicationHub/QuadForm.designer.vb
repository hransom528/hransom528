<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuadForm
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblSolutions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInstructions.Location = New System.Drawing.Point(25, 28)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(443, 24)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Enter the coefficients of the quadratic equation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtA.Location = New System.Drawing.Point(31, 74)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(36, 20)
        Me.txtA.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtB.Location = New System.Drawing.Point(122, 74)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(36, 20)
        Me.txtB.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtC.Location = New System.Drawing.Point(198, 74)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(42, 20)
        Me.txtC.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(122, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(29, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Location = New System.Drawing.Point(29, 115)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(190, 28)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblSolutions
        '
        Me.lblSolutions.AutoSize = True
        Me.lblSolutions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSolutions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolutions.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSolutions.Location = New System.Drawing.Point(26, 158)
        Me.lblSolutions.Name = "lblSolutions"
        Me.lblSolutions.Size = New System.Drawing.Size(109, 20)
        Me.lblSolutions.TabIndex = 7
        Me.lblSolutions.Text = "Solutions:  ?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(73, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "x^2 +"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblX.Location = New System.Drawing.Point(164, 76)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(28, 18)
        Me.lblX.TabIndex = 9
        Me.lblX.Text = "x +"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(215, 194)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back to Hub"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'QuadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(480, 231)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSolutions)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "QuadForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblSolutions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblX As Label
    Friend WithEvents btnBack As Button
End Class
