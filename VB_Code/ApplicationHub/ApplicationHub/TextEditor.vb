'Harris Ransom
'Text Editor v1.0
Imports System.Drawing.Text
Imports System.IO
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class TextEditor
#Region "Main Editor and Timer"
    'Timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblCharCount.Text = "Characters in the current document: " & Document.TextLength.ToString()
        ToolStripStatusLabel1.Text = "Words in the current document: " & getWordCount()
        lblZoom.Text = Document.ZoomFactor.ToString()
    End Sub
#End Region

#Region "Main Menu"
#Region "File"
    'Open button
    Private Sub mMOpen_Click(sender As Object, e As EventArgs) Handles mMOpen.Click
        open()
    End Sub

    'Save button
    Private Sub mMSave_Click(sender As Object, e As EventArgs) Handles mMSave.Click
        save()
    End Sub

    'Exit button
    Private Sub mMExit_Click(sender As Object, e As EventArgs) Handles mMExit.Click
        ApplicationHub.Show()
        Me.Close()
    End Sub

    'New button
    Private Sub mMNew_Click(sender As Object, e As EventArgs) Handles mMNew.Click
        NewDocument()
    End Sub

    'Opens the print dialog
    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        Dim printDlg As New PrintDialog()
        printDoc.DocumentName = "Print Document"
        printDlg.Document = printDoc
        printDlg.AllowSelection = True
        printDlg.AllowSomePages = True
        If (printDlg.ShowDialog() = DialogResult.OK) Then
            printDoc.Print()
        End If
    End Sub
#End Region

#Region "Edit"
    'Undo button
    Private Sub mMUndo_Click(sender As Object, e As EventArgs) Handles mMUndo.Click
        undo()
    End Sub

    'Redo button
    Private Sub mMRedo_Click(sender As Object, e As EventArgs) Handles mMRedo.Click
        redo()
    End Sub

    'Cut button
    Private Sub mMCut_Click(sender As Object, e As EventArgs) Handles mMCut.Click
        cut()
    End Sub

    'Copy button
    Private Sub mMCopy_Click(sender As Object, e As EventArgs) Handles mMCopy.Click
        copy()
    End Sub

    'Paste button
    Private Sub mMPaste_Click(sender As Object, e As EventArgs) Handles mMPaste.Click
        paste()
    End Sub

    'Select All button
    Private Sub mMSelectAll_Click(sender As Object, e As EventArgs) Handles mMSelectAll.Click
        selectAll()
    End Sub

    'Deselect all button
    Private Sub mMDeselectAll_Click(sender As Object, e As EventArgs) Handles mMDeselectAll.Click
        deselectAll()
    End Sub
#End Region

#Region "Tools"
    'Customzie button
    Private Sub mMCustomize_Click(sender As Object, e As EventArgs) Handles mMCustomize.Click
        customize()
    End Sub
#End Region
#End Region

#Region "Toolbar"
    'New file
    Private Sub tbNew_Click(sender As Object, e As EventArgs) Handles tbNew.Click
        NewDocument()
    End Sub

    'Open file
    Private Sub tbOpen_Click(sender As Object, e As EventArgs) Handles tbOpen.Click
        open()
    End Sub

    'Save work
    Private Sub tbSave_Click(sender As Object, e As EventArgs) Handles tbSave.Click
        save()
    End Sub

    'Cut
    Private Sub tbCut_Click(sender As Object, e As EventArgs) Handles tbCut.Click
        cut()
    End Sub

    'Copy
    Private Sub tbCopy_Click(sender As Object, e As EventArgs) Handles tbCopy.Click
        copy()
    End Sub

    'Paste
    Private Sub tbPaste_Click(sender As Object, e As EventArgs) Handles tbPaste.Click
        paste()
    End Sub

    'Align left
    Private Sub tbAlignLeft_Click(sender As Object, e As EventArgs) Handles tbAlignLeft.Click
        Document.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    'Align center
    Private Sub tbAlignCenter_Click(sender As Object, e As EventArgs) Handles tbAlignCenter.Click
        Document.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    'Align right
    Private Sub tbAlignRight_Click(sender As Object, e As EventArgs) Handles tbAlignRight.Click
        Document.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    'Zoom in
    Private Sub tbZoom_Click(sender As Object, e As EventArgs) Handles tbZoom.Click
        If Document.ZoomFactor = 63 Then
            Exit Sub
        Else
            Document.ZoomFactor = Document.ZoomFactor + 1
        End If
    End Sub

    'Zoom out
    Private Sub tbZoomOut_Click(sender As Object, e As EventArgs) Handles tbZoomOut.Click
        If Document.ZoomFactor = 1 Then
            Exit Sub
        Else
            Document.ZoomFactor = Document.ZoomFactor - 1
        End If
    End Sub

    'Changes the text editor font
    Private Sub btnChangeFont_Click(sender As Object, e As EventArgs) Handles btnChangeFont.Click
        If openFonts.ShowDialog = Windows.Forms.DialogResult.OK Then
            Document.Font = openFonts.Font()
        End If
    End Sub
#End Region

#Region "Methods"
    'Clears the RTB, makes a new file
    Private Sub NewDocument()
        Document.Clear()
    End Sub

    'Opens work as a plain text file
    Public Sub open()
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Saves file as plain text 
    Public Sub save()
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Exit form
    Public Sub exitEditor()
        Me.Close()
        ApplicationHub.Show()
    End Sub

    'Undo
    Public Sub undo()
        Document.Undo()
    End Sub

    'Redo
    Public Sub redo()
        Document.Redo()
    End Sub

    'Cut
    Public Sub cut()
        Document.Cut()
    End Sub

    'Copy
    Public Sub copy()
        Document.Copy()
    End Sub

    'Paste
    Public Sub paste()
        Document.Paste()
    End Sub

    'Select All
    Public Sub selectAll()
        Document.SelectAll()
    End Sub

    'Deselect All
    Public Sub deselectAll()
        Document.DeselectAll()
    End Sub

    'Customize method
    Public Sub customize()
        Dim colorPicker As New ColorDialog()
        colorPicker.AllowFullOpen = True
        colorPicker.FullOpen = True
        colorPicker.AnyColor = True

        If (colorPicker.ShowDialog = Windows.Forms.DialogResult.OK) Then
            mainMenu.BackColor = colorPicker.Color
            tools.BackColor = colorPicker.Color
            status.BackColor = colorPicker.Color
        End If
    End Sub

    'Gets word count in document
    Public Function getWordCount()
        Dim text As String = Document.Text
        Dim wordCount As Integer = 0

        For i = 0 To text.Length() - 1
            If (text(i) = " ") Or (text(i) = vbCr) Or (text(i) = vbCrLf) Then
                wordCount += 1
            End If
        Next

        Return wordCount
    End Function
#End Region

#Region "Right Click Context Menu"
    'Undo
    Private Sub rcUndo_Click(sender As Object, e As EventArgs) Handles rcUndo.Click
        undo()
    End Sub

    'Redo
    Private Sub rcRedo_Click(sender As Object, e As EventArgs) Handles rcRedo.Click
        redo()
    End Sub

    'Cut
    Private Sub rcCut_Click(sender As Object, e As EventArgs) Handles rcCut.Click
        cut()
    End Sub

    'Copy
    Private Sub rcCopy_Click(sender As Object, e As EventArgs) Handles rcCopy.Click
        copy()
    End Sub

    'Paste
    Private Sub rcPaste_Click(sender As Object, e As EventArgs) Handles rcPaste.Click
        paste()
    End Sub

    'Select all
    Private Sub rcSelectAll_Click(sender As Object, e As EventArgs) Handles rcSelectAll.Click
        selectAll()
    End Sub

    'Deselect all
    Private Sub rcDeselectAll_Click(sender As Object, e As EventArgs) Handles rcDeselectAll.Click
        deselectAll()
    End Sub
#End Region

#Region "Events"
    'Load method
    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Resets character and word count
        lblCharCount.Text = "Characters in the current document: 0"
        ToolStripStatusLabel1.Text = "Words in the current document: 0"
    End Sub

    'PrintDoc method
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        e.Graphics.DrawString(Document.Text, Document.Font, Brushes.Black, 0, 0)
    End Sub

    'Resize method
    Private Sub TextEditor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Document.Width = Me.Width
        Document.Height = Me.Height - 30
    End Sub
#End Region

End Class