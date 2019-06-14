<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMDeselectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.tools = New System.Windows.Forms.ToolStrip()
        Me.tbNew = New System.Windows.Forms.ToolStripButton()
        Me.tbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbCut = New System.Windows.Forms.ToolStripButton()
        Me.tbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.tbAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.tbAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbZoom = New System.Windows.Forms.ToolStripButton()
        Me.tbZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.rcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.rcUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.rcSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.rcDeselectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.lblCharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.openWork = New System.Windows.Forms.OpenFileDialog()
        Me.saveWork = New System.Windows.Forms.SaveFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.openFonts = New System.Windows.Forms.FontDialog()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.mainMenu.SuspendLayout()
        Me.tools.SuspendLayout()
        Me.rcMenu.SuspendLayout()
        Me.status.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(779, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMNew, Me.mMOpen, Me.toolStripSeparator, Me.mMSave, Me.mnuFilePrint, Me.toolStripSeparator2, Me.mMExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mMNew
        '
        Me.mMNew.Image = CType(resources.GetObject("mMNew.Image"), System.Drawing.Image)
        Me.mMNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMNew.Name = "mMNew"
        Me.mMNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMNew.Size = New System.Drawing.Size(146, 22)
        Me.mMNew.Text = "&New"
        '
        'mMOpen
        '
        Me.mMOpen.Image = CType(resources.GetObject("mMOpen.Image"), System.Drawing.Image)
        Me.mMOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMOpen.Name = "mMOpen"
        Me.mMOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mMOpen.Size = New System.Drawing.Size(146, 22)
        Me.mMOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'mMSave
        '
        Me.mMSave.Image = CType(resources.GetObject("mMSave.Image"), System.Drawing.Image)
        Me.mMSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMSave.Name = "mMSave"
        Me.mMSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMSave.Size = New System.Drawing.Size(146, 22)
        Me.mMSave.Text = "&Save"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Image = Global.ApplicationHub.My.Resources.Resources.printIcon
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(146, 22)
        Me.mnuFilePrint.Text = "Print"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'mMExit
        '
        Me.mMExit.Name = "mMExit"
        Me.mMExit.Size = New System.Drawing.Size(146, 22)
        Me.mMExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMUndo, Me.mMRedo, Me.toolStripSeparator3, Me.mMCut, Me.mMCopy, Me.mMPaste, Me.toolStripSeparator4, Me.mMSelectAll, Me.mMDeselectAll})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mMUndo
        '
        Me.mMUndo.Name = "mMUndo"
        Me.mMUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mMUndo.Size = New System.Drawing.Size(144, 22)
        Me.mMUndo.Text = "&Undo"
        '
        'mMRedo
        '
        Me.mMRedo.Name = "mMRedo"
        Me.mMRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mMRedo.Size = New System.Drawing.Size(144, 22)
        Me.mMRedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'mMCut
        '
        Me.mMCut.Image = CType(resources.GetObject("mMCut.Image"), System.Drawing.Image)
        Me.mMCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCut.Name = "mMCut"
        Me.mMCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mMCut.Size = New System.Drawing.Size(144, 22)
        Me.mMCut.Text = "Cu&t"
        '
        'mMCopy
        '
        Me.mMCopy.Image = CType(resources.GetObject("mMCopy.Image"), System.Drawing.Image)
        Me.mMCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCopy.Name = "mMCopy"
        Me.mMCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mMCopy.Size = New System.Drawing.Size(144, 22)
        Me.mMCopy.Text = "&Copy"
        '
        'mMPaste
        '
        Me.mMPaste.Image = CType(resources.GetObject("mMPaste.Image"), System.Drawing.Image)
        Me.mMPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMPaste.Name = "mMPaste"
        Me.mMPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mMPaste.Size = New System.Drawing.Size(144, 22)
        Me.mMPaste.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'mMSelectAll
        '
        Me.mMSelectAll.Name = "mMSelectAll"
        Me.mMSelectAll.Size = New System.Drawing.Size(144, 22)
        Me.mMSelectAll.Text = "Select &All"
        '
        'mMDeselectAll
        '
        Me.mMDeselectAll.Name = "mMDeselectAll"
        Me.mMDeselectAll.Size = New System.Drawing.Size(144, 22)
        Me.mMDeselectAll.Text = "Deselect All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMCustomize})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'mMCustomize
        '
        Me.mMCustomize.Name = "mMCustomize"
        Me.mMCustomize.Size = New System.Drawing.Size(130, 22)
        Me.mMCustomize.Text = "&Customize"
        '
        'tools
        '
        Me.tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbNew, Me.tbOpen, Me.tbSave, Me.toolStripSeparator5, Me.tbCut, Me.tbCopy, Me.tbPaste, Me.ToolStripSeparator7, Me.tbAlignLeft, Me.tbAlignCenter, Me.tbAlignRight, Me.ToolStripSeparator8, Me.tbZoom, Me.tbZoomOut, Me.ToolStripSeparator10, Me.btnChangeFont})
        Me.tools.Location = New System.Drawing.Point(0, 24)
        Me.tools.Name = "tools"
        Me.tools.Size = New System.Drawing.Size(779, 25)
        Me.tools.TabIndex = 1
        Me.tools.Text = "ToolStrip1"
        '
        'tbNew
        '
        Me.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbNew.Image = CType(resources.GetObject("tbNew.Image"), System.Drawing.Image)
        Me.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbNew.Name = "tbNew"
        Me.tbNew.Size = New System.Drawing.Size(23, 22)
        Me.tbNew.Text = "&New"
        '
        'tbOpen
        '
        Me.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbOpen.Image = CType(resources.GetObject("tbOpen.Image"), System.Drawing.Image)
        Me.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbOpen.Name = "tbOpen"
        Me.tbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tbOpen.Text = "&Open"
        '
        'tbSave
        '
        Me.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbSave.Image = CType(resources.GetObject("tbSave.Image"), System.Drawing.Image)
        Me.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(23, 22)
        Me.tbSave.Text = "&Save"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tbCut
        '
        Me.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCut.Image = CType(resources.GetObject("tbCut.Image"), System.Drawing.Image)
        Me.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCut.Name = "tbCut"
        Me.tbCut.Size = New System.Drawing.Size(23, 22)
        Me.tbCut.Text = "C&ut"
        '
        'tbCopy
        '
        Me.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCopy.Image = CType(resources.GetObject("tbCopy.Image"), System.Drawing.Image)
        Me.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCopy.Name = "tbCopy"
        Me.tbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tbCopy.Text = "&Copy"
        '
        'tbPaste
        '
        Me.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPaste.Image = CType(resources.GetObject("tbPaste.Image"), System.Drawing.Image)
        Me.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPaste.Name = "tbPaste"
        Me.tbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tbPaste.Text = "&Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tbAlignLeft
        '
        Me.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignLeft.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignLeft.Image = CType(resources.GetObject("tbAlignLeft.Image"), System.Drawing.Image)
        Me.tbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignLeft.Name = "tbAlignLeft"
        Me.tbAlignLeft.Size = New System.Drawing.Size(23, 22)
        Me.tbAlignLeft.Text = "L"
        '
        'tbAlignCenter
        '
        Me.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignCenter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignCenter.Image = CType(resources.GetObject("tbAlignCenter.Image"), System.Drawing.Image)
        Me.tbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignCenter.Name = "tbAlignCenter"
        Me.tbAlignCenter.Size = New System.Drawing.Size(23, 22)
        Me.tbAlignCenter.Text = "C"
        '
        'tbAlignRight
        '
        Me.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAlignRight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlignRight.Image = CType(resources.GetObject("tbAlignRight.Image"), System.Drawing.Image)
        Me.tbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAlignRight.Name = "tbAlignRight"
        Me.tbAlignRight.Size = New System.Drawing.Size(23, 22)
        Me.tbAlignRight.Text = "R"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tbZoom
        '
        Me.tbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZoom.Image = CType(resources.GetObject("tbZoom.Image"), System.Drawing.Image)
        Me.tbZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoom.Name = "tbZoom"
        Me.tbZoom.Size = New System.Drawing.Size(23, 22)
        Me.tbZoom.Text = "+"
        '
        'tbZoomOut
        '
        Me.tbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoomOut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZoomOut.Image = CType(resources.GetObject("tbZoomOut.Image"), System.Drawing.Image)
        Me.tbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoomOut.Name = "tbZoomOut"
        Me.tbZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.tbZoomOut.Text = "-"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'btnChangeFont
        '
        Me.btnChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnChangeFont.Image = CType(resources.GetObject("btnChangeFont.Image"), System.Drawing.Image)
        Me.btnChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeFont.Name = "btnChangeFont"
        Me.btnChangeFont.Size = New System.Drawing.Size(79, 22)
        Me.btnChangeFont.Text = "Change Font"
        '
        'Document
        '
        Me.Document.AcceptsTab = True
        Me.Document.ContextMenuStrip = Me.rcMenu
        Me.Document.EnableAutoDragDrop = True
        Me.Document.Location = New System.Drawing.Point(0, 65)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(779, 373)
        Me.Document.TabIndex = 2
        Me.Document.Text = ""
        '
        'rcMenu
        '
        Me.rcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rcUndo, Me.rcRedo, Me.rcCut, Me.rcCopy, Me.rcPaste, Me.ToolStripSeparator11, Me.rcSelectAll, Me.rcDeselectAll})
        Me.rcMenu.Name = "ContextMenuStrip1"
        Me.rcMenu.Size = New System.Drawing.Size(136, 164)
        '
        'rcUndo
        '
        Me.rcUndo.Name = "rcUndo"
        Me.rcUndo.Size = New System.Drawing.Size(135, 22)
        Me.rcUndo.Text = "Undo"
        '
        'rcRedo
        '
        Me.rcRedo.Name = "rcRedo"
        Me.rcRedo.Size = New System.Drawing.Size(135, 22)
        Me.rcRedo.Text = "Redo"
        '
        'rcCut
        '
        Me.rcCut.Name = "rcCut"
        Me.rcCut.Size = New System.Drawing.Size(135, 22)
        Me.rcCut.Text = "Cut"
        '
        'rcCopy
        '
        Me.rcCopy.Name = "rcCopy"
        Me.rcCopy.Size = New System.Drawing.Size(135, 22)
        Me.rcCopy.Text = "Copy"
        '
        'rcPaste
        '
        Me.rcPaste.Name = "rcPaste"
        Me.rcPaste.Size = New System.Drawing.Size(135, 22)
        Me.rcPaste.Text = "Paste"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(132, 6)
        '
        'rcSelectAll
        '
        Me.rcSelectAll.Name = "rcSelectAll"
        Me.rcSelectAll.Size = New System.Drawing.Size(135, 22)
        Me.rcSelectAll.Text = "Select All"
        '
        'rcDeselectAll
        '
        Me.rcDeselectAll.Name = "rcDeselectAll"
        Me.rcDeselectAll.Size = New System.Drawing.Size(135, 22)
        Me.rcDeselectAll.Text = "Deselect All"
        '
        'status
        '
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharCount, Me.ToolStripStatusLabel1, Me.lblWordCount, Me.ToolStripStatusLabel2, Me.lblZoom})
        Me.status.Location = New System.Drawing.Point(0, 428)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(779, 22)
        Me.status.TabIndex = 3
        Me.status.Text = "StatusStrip1"
        '
        'lblCharCount
        '
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(13, 17)
        Me.lblCharCount.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(349, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'lblWordCount
        '
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.Size = New System.Drawing.Size(13, 17)
        Me.lblWordCount.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(349, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'lblZoom
        '
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(39, 17)
        Me.lblZoom.Text = "Zoom"
        '
        'openWork
        '
        Me.openWork.Filter = "Text Files |*.txt|RTF Files|*.rtf"
        Me.openWork.Title = "Open Work"
        '
        'saveWork
        '
        Me.saveWork.Filter = "Text Files |*.txt|RTF Files|*.rtf"
        Me.saveWork.Title = "Save Work"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'printDialog
        '
        Me.printDialog.AllowSomePages = True
        Me.printDialog.UseEXDialog = True
        '
        'printDoc
        '
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 450)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Document)
        Me.Controls.Add(Me.tools)
        Me.Controls.Add(Me.mainMenu)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.mainMenu
        Me.MinimumSize = New System.Drawing.Size(795, 489)
        Me.Name = "TextEditor"
        Me.ShowIcon = False
        Me.Text = "Text Editor"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.tools.ResumeLayout(False)
        Me.tools.PerformLayout()
        Me.rcMenu.ResumeLayout(False)
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents tools As ToolStrip
    Friend WithEvents Document As RichTextBox
    Friend WithEvents status As StatusStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mMNew As ToolStripMenuItem
    Friend WithEvents mMOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents mMSave As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mMExit As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mMUndo As ToolStripMenuItem
    Friend WithEvents mMRedo As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mMCut As ToolStripMenuItem
    Friend WithEvents mMCopy As ToolStripMenuItem
    Friend WithEvents mMPaste As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mMSelectAll As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mMCustomize As ToolStripMenuItem
    Friend WithEvents openWork As OpenFileDialog
    Friend WithEvents saveWork As SaveFileDialog
    Friend WithEvents rcMenu As ContextMenuStrip
    Friend WithEvents Timer As Timer
    Friend WithEvents tbNew As ToolStripButton
    Friend WithEvents tbOpen As ToolStripButton
    Friend WithEvents tbSave As ToolStripButton
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tbCut As ToolStripButton
    Friend WithEvents tbCopy As ToolStripButton
    Friend WithEvents tbPaste As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tbAlignLeft As ToolStripButton
    Friend WithEvents tbAlignCenter As ToolStripButton
    Friend WithEvents tbAlignRight As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tbZoom As ToolStripButton
    Friend WithEvents tbZoomOut As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents lblZoom As ToolStripStatusLabel
    Friend WithEvents rcUndo As ToolStripMenuItem
    Friend WithEvents rcRedo As ToolStripMenuItem
    Friend WithEvents rcCut As ToolStripMenuItem
    Friend WithEvents rcCopy As ToolStripMenuItem
    Friend WithEvents rcPaste As ToolStripMenuItem
    Friend WithEvents mMDeselectAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents rcSelectAll As ToolStripMenuItem
    Friend WithEvents rcDeselectAll As ToolStripMenuItem
    Friend WithEvents btnChangeFont As ToolStripButton
    Friend WithEvents openFonts As FontDialog
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblCharCount As ToolStripStatusLabel
    Friend WithEvents lblWordCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents mnuFilePrint As ToolStripMenuItem
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents printDoc As Printing.PrintDocument
End Class
