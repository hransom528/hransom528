<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHelpInfo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(312, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(67, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Help "
        '
        'lblHelpInfo
        '
        Me.lblHelpInfo.AutoSize = True
        Me.lblHelpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHelpInfo.Location = New System.Drawing.Point(12, 51)
        Me.lblHelpInfo.Name = "lblHelpInfo"
        Me.lblHelpInfo.Size = New System.Drawing.Size(665, 80)
        Me.lblHelpInfo.TabIndex = 1
        Me.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text")
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(480, 125)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(197, 32)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Factor Calculator"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(670, 157)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHelpInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHelpInfo As Label
    Friend WithEvents btnBack As Button
End Class
