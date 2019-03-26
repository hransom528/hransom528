'Harris Ransom
'Text Editor v1.0
Imports System.Drawing.Text
Imports System.IO

Public Class TextEditor
#Region "Main Editor and Timer"
    'Timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblCharCount.Text = "Characters in the current document: " & Document.TextLength.ToString()
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

    'Bold
    Private Sub tbBold_Click(sender As Object, e As EventArgs) Handles tbBold.Click
        Dim bfont As New Font(Document.Font, FontStyle.Bold)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Bold Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = bfont
        End If
    End Sub

    'Italic
    Private Sub tbItalic_Click(sender As Object, e As EventArgs) Handles tbItalic.Click
        Dim ifont As New Font(Document.Font, FontStyle.Italic)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Bold Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = ifont
        End If
    End Sub

    'Underline
    Private Sub tbUnderline_Click(sender As Object, e As EventArgs) Handles tbUnderline.Click
        Dim ufont As New Font(Document.Font, FontStyle.Underline)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Bold Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = ufont
        End If
    End Sub

    'Strikethrough
    Private Sub tbStrike_Click(sender As Object, e As EventArgs) Handles tbStrike.Click
        Dim sfont As New Font(Document.Font, FontStyle.Strikeout)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)
        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Bold Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = sfont
        End If
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

    'Font selector
    Private Sub tbSelectFont_Click(sender As Object, e As EventArgs) Handles tbSelectFont.Click
        Dim fonts As New InstalledFontCollection()
        For fntFamily As Integer = 0 To fonts.Families.Length - 1
            tbSelectFont.Items.Add(fonts.Families(fntFamily).Name)
        Next
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
        'Size selector
        For fontSize = 10 To 75
            tbSelectSize.Items.Add(fontSize)
        Next

        'Adds text to features
        tbSelectFont.Text = "Fonts:"
        tbSelectSize.Text = "Size:"
        lblCharCount.Text = "Characters in the current document: 0"
    End Sub

    'SelectedIndexChange event for the SelectFont drop-down
    Private Sub tbSelectFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbSelectFont.SelectedIndexChanged
        Dim ComboFonts As System.Drawing.Font
        Try
            ComboFonts = Document.SelectionFont
            Document.SelectionFont = New System.Drawing.Font(tbSelectFont.Text,
            Document.SelectionFont.Size, Document.SelectionFont.Style)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'SelectedIndexChange event for the SelectSize drop-down
    Private Sub tbSelectSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbSelectSize.SelectedIndexChanged
        Document.SelectionFont = New Font(tbSelectSize.SelectedItem.ToString, CInt(tbSelectSize.SelectedItem.ToString), Document.SelectionFont.Style)
    End Sub
#End Region
End Class