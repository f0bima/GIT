Public Class Form1
    Dim FILE_NAME As String = "...\log.txt"
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.WriteLine(inp.Text)
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME)
            writeFile.WriteLine(inp.Text)
            writeFile.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sr As New IO.StreamReader(FILE_NAME)
        readtext.Text = sr.ReadToEnd
        sr.Close()
    End Sub
End Class
