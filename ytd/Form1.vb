Imports System.IO
Imports VideoLibrary
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If gatto.Checked = True Then
            Dim filePath As String = "ytdcache.ytd"
            ' Creare o sovrascrivere il file di testo
            Using writer As New StreamWriter(filePath)
                ' Scrivere il contenuto nel file
                writer.WriteLine(link.Text)
            End Using
            Process.Start("ytdhosta.exe")
        Else
            Dim filePath As String = "ytdcache.ytd"
            ' Creare o sovrascrivere il file di testo
            Using writer As New StreamWriter(filePath)
                ' Scrivere il contenuto nel file
                writer.WriteLine(link.Text)
            End Using
            Process.Start("ytdhostv.exe")
        End If
    End Sub

    Private Sub link_TextChanged(sender As Object, e As EventArgs) Handles link.TextChanged

    End Sub
End Class
