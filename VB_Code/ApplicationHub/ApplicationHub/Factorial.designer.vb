<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factorial
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHub = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(406, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Enter A Number (0-12) To Find A Factorial"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(148, 50)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(55, 26)
        Me.txtNumber.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(219, 46)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 35)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(127, 99)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(122, 24)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Placeholder"
        Me.lblResult.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(219, 46)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 35)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'btnHub
        '
        Me.btnHub.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHub.Location = New System.Drawing.Point(300, 46)
        Me.btnHub.Name = "btnHub"
        Me.btnHub.Size = New System.Drawing.Size(75, 35)
        Me.btnHub.TabIndex = 5
        Me.btnHub.Text = "Hub"
        Me.btnHub.UseVisualStyleBackColor = False
        '
        'Factorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(442, 146)
        Me.Controls.Add(Me.btnHub)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Factorial"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnHub As Button
End Class
