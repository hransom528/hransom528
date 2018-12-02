'Harris Ransom
'File Manager Application
'Created 11/8/18


'Declares imports
Imports FileManager
Imports System
Imports System.IO
Public Class Form1
    'Declares instances and variables
    Dim fw As StreamWriter
    Dim fr As StreamReader
    Dim fileName As String

    'Reads a specified file
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        fileName = CStr(txtFileName.Text)
        fr = New StreamReader(fileName)
    End Sub

    'Writes to a specified files
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

    End Sub
End Class
