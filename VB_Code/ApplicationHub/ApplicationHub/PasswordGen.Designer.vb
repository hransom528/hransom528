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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(80, 99)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 0
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(80, 125)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        '
        'txtSpecial
        '
        Me.txtSpecial.Location = New System.Drawing.Point(80, 151)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(100, 20)
        Me.txtSpecial.TabIndex = 2
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(80, 73)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(260, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(103, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Password Generator"
        '
        'btnGetPass
        '
        Me.btnGetPass.Location = New System.Drawing.Point(245, 200)
        Me.btnGetPass.Name = "btnGetPass"
        Me.btnGetPass.Size = New System.Drawing.Size(75, 23)
        Me.btnGetPass.TabIndex = 5
        Me.btnGetPass.Text = "Button1"
        Me.btnGetPass.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(245, 248)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(39, 13)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Capital"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nums"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Special"
        '
        'PasswordGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnGetPass)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtSpecial)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtCapital)
        Me.Name = "PasswordGen"
        Me.Text = "PasswordGen"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
