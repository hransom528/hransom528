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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtTextToWrite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(218, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(68, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "File Manager"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(162, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close File"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 318)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(116, 127)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 3
        Me.btnWrite.Text = "File Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(116, 98)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "File Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(199, 55)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtFileName.TabIndex = 5
        '
        'txtTextToWrite
        '
        Me.txtTextToWrite.Location = New System.Drawing.Point(348, 155)
        Me.txtTextToWrite.Name = "txtTextToWrite"
        Me.txtTextToWrite.Size = New System.Drawing.Size(100, 20)
        Me.txtTextToWrite.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTextToWrite)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents txtTextToWrite As TextBox
End Class
