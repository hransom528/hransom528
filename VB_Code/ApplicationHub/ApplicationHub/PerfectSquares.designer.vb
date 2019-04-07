<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfectSquares
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
        Me.btnComputePerfectSquares = New System.Windows.Forms.Button()
        Me.btnComputePrimeNumbers = New System.Windows.Forms.Button()
        Me.btnShowLists = New System.Windows.Forms.Button()
        Me.btnClearLists = New System.Windows.Forms.Button()
        Me.lstPerfectSquares = New System.Windows.Forms.ListBox()
        Me.lstPrimeNumbers = New System.Windows.Forms.ListBox()
        Me.txtPerfectSquares = New System.Windows.Forms.TextBox()
        Me.txtPrimeNumbers = New System.Windows.Forms.TextBox()
        Me.lblHowMany = New System.Windows.Forms.Label()
        Me.lblOneTo = New System.Windows.Forms.Label()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFactorials = New System.Windows.Forms.ListBox()
        Me.lblFactorials = New System.Windows.Forms.Label()
        Me.txtFactorials = New System.Windows.Forms.TextBox()
        Me.btnComputeFactorials = New System.Windows.Forms.Button()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnComputePerfectSquares
        '
        Me.btnComputePerfectSquares.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComputePerfectSquares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputePerfectSquares.Location = New System.Drawing.Point(8, 29)
        Me.btnComputePerfectSquares.Name = "btnComputePerfectSquares"
        Me.btnComputePerfectSquares.Size = New System.Drawing.Size(112, 54)
        Me.btnComputePerfectSquares.TabIndex = 0
        Me.btnComputePerfectSquares.Text = "Compute Perfect Squares"
        Me.btnComputePerfectSquares.UseVisualStyleBackColor = False
        '
        'btnComputePrimeNumbers
        '
        Me.btnComputePrimeNumbers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComputePrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputePrimeNumbers.Location = New System.Drawing.Point(7, 93)
        Me.btnComputePrimeNumbers.Name = "btnComputePrimeNumbers"
        Me.btnComputePrimeNumbers.Size = New System.Drawing.Size(112, 54)
        Me.btnComputePrimeNumbers.TabIndex = 1
        Me.btnComputePrimeNumbers.Text = "Compute Prime Numbers"
        Me.btnComputePrimeNumbers.UseVisualStyleBackColor = False
        '
        'btnShowLists
        '
        Me.btnShowLists.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShowLists.Enabled = False
        Me.btnShowLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLists.Location = New System.Drawing.Point(12, 222)
        Me.btnShowLists.Name = "btnShowLists"
        Me.btnShowLists.Size = New System.Drawing.Size(193, 89)
        Me.btnShowLists.TabIndex = 2
        Me.btnShowLists.Text = "Show Lists"
        Me.btnShowLists.UseVisualStyleBackColor = False
        '
        'btnClearLists
        '
        Me.btnClearLists.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearLists.Enabled = False
        Me.btnClearLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLists.Location = New System.Drawing.Point(12, 317)
        Me.btnClearLists.Name = "btnClearLists"
        Me.btnClearLists.Size = New System.Drawing.Size(193, 89)
        Me.btnClearLists.TabIndex = 3
        Me.btnClearLists.Text = "Clear Lists"
        Me.btnClearLists.UseVisualStyleBackColor = False
        '
        'lstPerfectSquares
        '
        Me.lstPerfectSquares.FormattingEnabled = True
        Me.lstPerfectSquares.Location = New System.Drawing.Point(226, 27)
        Me.lstPerfectSquares.Name = "lstPerfectSquares"
        Me.lstPerfectSquares.Size = New System.Drawing.Size(228, 381)
        Me.lstPerfectSquares.TabIndex = 4
        '
        'lstPrimeNumbers
        '
        Me.lstPrimeNumbers.FormattingEnabled = True
        Me.lstPrimeNumbers.Location = New System.Drawing.Point(460, 27)
        Me.lstPrimeNumbers.Name = "lstPrimeNumbers"
        Me.lstPrimeNumbers.Size = New System.Drawing.Size(219, 381)
        Me.lstPrimeNumbers.TabIndex = 5
        '
        'txtPerfectSquares
        '
        Me.txtPerfectSquares.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerfectSquares.Location = New System.Drawing.Point(126, 57)
        Me.txtPerfectSquares.Name = "txtPerfectSquares"
        Me.txtPerfectSquares.Size = New System.Drawing.Size(74, 26)
        Me.txtPerfectSquares.TabIndex = 6
        '
        'txtPrimeNumbers
        '
        Me.txtPrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimeNumbers.Location = New System.Drawing.Point(126, 121)
        Me.txtPrimeNumbers.Name = "txtPrimeNumbers"
        Me.txtPrimeNumbers.Size = New System.Drawing.Size(74, 26)
        Me.txtPrimeNumbers.TabIndex = 7
        '
        'lblHowMany
        '
        Me.lblHowMany.AutoSize = True
        Me.lblHowMany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowMany.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHowMany.Location = New System.Drawing.Point(127, 29)
        Me.lblHowMany.Name = "lblHowMany"
        Me.lblHowMany.Size = New System.Drawing.Size(73, 13)
        Me.lblHowMany.TabIndex = 8
        Me.lblHowMany.Text = "How Many?"
        '
        'lblOneTo
        '
        Me.lblOneTo.AutoSize = True
        Me.lblOneTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOneTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOneTo.Location = New System.Drawing.Point(126, 102)
        Me.lblOneTo.Name = "lblOneTo"
        Me.lblOneTo.Size = New System.Drawing.Size(72, 13)
        Me.lblOneTo.TabIndex = 9
        Me.lblOneTo.Text = "From 1 to..."
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnuMenu.Size = New System.Drawing.Size(908, 24)
        Me.mnuMenu.TabIndex = 10
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'lstFactorials
        '
        Me.lstFactorials.FormattingEnabled = True
        Me.lstFactorials.Location = New System.Drawing.Point(683, 27)
        Me.lstFactorials.Name = "lstFactorials"
        Me.lstFactorials.Size = New System.Drawing.Size(219, 381)
        Me.lstFactorials.TabIndex = 11
        '
        'lblFactorials
        '
        Me.lblFactorials.AutoSize = True
        Me.lblFactorials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactorials.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFactorials.Location = New System.Drawing.Point(126, 171)
        Me.lblFactorials.Name = "lblFactorials"
        Me.lblFactorials.Size = New System.Drawing.Size(93, 13)
        Me.lblFactorials.TabIndex = 14
        Me.lblFactorials.Text = "Factorials to... "
        '
        'txtFactorials
        '
        Me.txtFactorials.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactorials.Location = New System.Drawing.Point(126, 190)
        Me.txtFactorials.Name = "txtFactorials"
        Me.txtFactorials.Size = New System.Drawing.Size(74, 26)
        Me.txtFactorials.TabIndex = 13
        '
        'btnComputeFactorials
        '
        Me.btnComputeFactorials.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComputeFactorials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeFactorials.Location = New System.Drawing.Point(7, 162)
        Me.btnComputeFactorials.Name = "btnComputeFactorials"
        Me.btnComputeFactorials.Size = New System.Drawing.Size(112, 54)
        Me.btnComputeFactorials.TabIndex = 12
        Me.btnComputeFactorials.Text = "Compute Factorials"
        Me.btnComputeFactorials.UseVisualStyleBackColor = False
        '
        'PerfectSquares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(908, 416)
        Me.Controls.Add(Me.lblFactorials)
        Me.Controls.Add(Me.txtFactorials)
        Me.Controls.Add(Me.btnComputeFactorials)
        Me.Controls.Add(Me.lstFactorials)
        Me.Controls.Add(Me.lblOneTo)
        Me.Controls.Add(Me.lblHowMany)
        Me.Controls.Add(Me.txtPrimeNumbers)
        Me.Controls.Add(Me.txtPerfectSquares)
        Me.Controls.Add(Me.lstPrimeNumbers)
        Me.Controls.Add(Me.lstPerfectSquares)
        Me.Controls.Add(Me.btnClearLists)
        Me.Controls.Add(Me.btnShowLists)
        Me.Controls.Add(Me.btnComputePrimeNumbers)
        Me.Controls.Add(Me.btnComputePerfectSquares)
        Me.Controls.Add(Me.mnuMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "PerfectSquares"
        Me.Text = "Form1"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComputePerfectSquares As Button
    Friend WithEvents btnComputePrimeNumbers As Button
    Friend WithEvents btnShowLists As Button
    Friend WithEvents btnClearLists As Button
    Friend WithEvents lstPerfectSquares As ListBox
    Friend WithEvents lstPrimeNumbers As ListBox
    Friend WithEvents txtPerfectSquares As TextBox
    Friend WithEvents txtPrimeNumbers As TextBox
    Friend WithEvents lblHowMany As Label
    Friend WithEvents lblOneTo As Label
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lstFactorials As ListBox
    Friend WithEvents lblFactorials As Label
    Friend WithEvents txtFactorials As TextBox
    Friend WithEvents btnComputeFactorials As Button
End Class
