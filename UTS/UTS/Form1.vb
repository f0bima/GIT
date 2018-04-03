Public Class Form1
    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        hasil.Text = convsuhu(CDbl(input.Text), inputsh.Text, outputsh.Text)
    End Sub

End Class
