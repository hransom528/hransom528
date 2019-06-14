<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MouseDebugger
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
        Me.lblCoordinates = New System.Windows.Forms.Label()
        Me.lstLogger = New System.Windows.Forms.ListBox()
        Me.btnClearLogger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordinates.Location = New System.Drawing.Point(34, 13)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(168, 31)
        Me.lblCoordinates.TabIndex = 1
        Me.lblCoordinates.Text = "Placeholder"
        '
        'lstLogger
        '
        Me.lstLogger.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogger.FormattingEnabled = True
        Me.lstLogger.ItemHeight = 24
        Me.lstLogger.Location = New System.Drawing.Point(463, -1)
        Me.lstLogger.Name = "lstLogger"
        Me.lstLogger.Size = New System.Drawing.Size(235, 436)
        Me.lstLogger.TabIndex = 2
        '
        'btnClearLogger
        '
        Me.btnClearLogger.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClearLogger.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLogger.Location = New System.Drawing.Point(339, -1)
        Me.btnClearLogger.Name = "btnClearLogger"
        Me.btnClearLogger.Size = New System.Drawing.Size(118, 32)
        Me.btnClearLogger.TabIndex = 3
        Me.btnClearLogger.Text = "Clear Logger"
        Me.btnClearLogger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearLogger.UseVisualStyleBackColor = False
        '
        'MouseDebugger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 411)
        Me.Controls.Add(Me.btnClearLogger)
        Me.Controls.Add(Me.lstLogger)
        Me.Controls.Add(Me.lblCoordinates)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "MouseDebugger"
        Me.Text = "Mouse Debugger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCoordinates As Label
    Friend WithEvents lstLogger As ListBox
    Friend WithEvents btnClearLogger As Button
End Class
