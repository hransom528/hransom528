'Harris Ransom
'Mouse Debugger 


Public Class MouseDebugger
#Region "Declaration Statements"
    'Rectangles
    Dim leftClick As Rectangle
    Dim rightClick As Rectangle
    Dim middleClick As Rectangle
    Dim mouseBase As Rectangle

    'Actions
    Dim scrollingUp As Boolean = False
    Dim scrollingDown As Boolean = False
    Dim mouseX As Double
    Dim mouseY As Double
    Dim output As String = " "

    'Colors
    Dim regularColor As Brush = Brushes.Blue
    Dim activeColor As Brush = Brushes.Navy
    Dim leftColor As Brush = regularColor
    Dim rightColor As Brush = regularColor
    Dim middleColor As Brush = regularColor
#End Region

#Region "Methods"
    'Method to update the logger
    Public Sub updateLogger(text As String)
        If (lstLogger.Items.Count) > 16 Then
            lstLogger.Items.RemoveAt(0)
        End If
        lstLogger.Items.Add(text)
    End Sub

    'Clears the logger
    Private Sub btnClearLogger_Click(sender As Object, e As EventArgs) Handles btnClearLogger.Click
        lstLogger.Items.Clear()
        lstLogger.Items.Add("Logger Initialized...")
    End Sub

    'MouseMove method
    Private Sub MouseDebugger_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        mouseX = e.X
        mouseY = e.Y
        lblCoordinates.Text = "X: " + CStr(mouseX) + " Y: " + CStr(mouseY)
        Me.Refresh()
    End Sub

    'Paint method
    Private Sub MouseDebugger_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        leftClick = New Rectangle(244, 117, 56, 87)
        rightClick = New Rectangle(324, 117, 56, 87)
        middleClick = New Rectangle(306, 116, 12, 87)
        mouseBase = New Rectangle(244, 196, 136, 98)
        e.Graphics.FillRectangle(leftColor, leftClick)
        e.Graphics.FillRectangle(rightColor, rightClick)
        e.Graphics.FillRectangle(middleColor, middleClick)
        e.Graphics.FillRectangle(Brushes.LightGray, mouseBase)
    End Sub

    'MouseDown method
    Private Sub MouseDebugger_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        'If the left button is down
        If (e.Button = MouseButtons.Left) Then
            leftColor = activeColor
            updateLogger("Left button pressed")
        End If

        'If the right button is down
        If (e.Button = MouseButtons.Right) Then
            rightColor = activeColor
            updateLogger("Right button pressed")
        End If

        'If the middle button is down
        If (e.Button = MouseButtons.Middle) Then
            middleColor = activeColor
            updateLogger("Middle button pressed")
        End If

        Me.Refresh()
    End Sub

    'MouseUp
    Private Sub MouseDebugger_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        'If the left button is released
        If (e.Button = MouseButtons.Left) Then
            leftColor = regularColor
            updateLogger("Left button released")
        End If

        'If right button is released
        If (e.Button = MouseButtons.Right) Then
            rightColor = regularColor
            updateLogger("Right button released")
        End If

        'If the middle button is released
        If (e.Button = MouseButtons.Middle) Then
            middleColor = regularColor
            updateLogger("Middle button released")
        End If

        Me.Refresh()
    End Sub

    'MouseWheel
    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Dim delta As Double = e.Delta

        'Determines whether the user is scrolling up or down
        If (e.Delta > 0) Then
            updateLogger("Scrolling Up...")
        ElseIf (e.Delta < 0) Then
            updateLogger("Scrolling Down...")
        End If
        Me.Refresh()
    End Sub

    'Load method
    Private Sub MouseDebugger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCoordinates.Text = "X:  Y:  "
        lstLogger.Items.Add("Logger Initialized...")
    End Sub

    'KeyDown method
    Private Sub MouseDebugger_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Closes out the debugger if the user presses the escape key
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            ApplicationHub.Show()
        End If
    End Sub


#End Region
End Class