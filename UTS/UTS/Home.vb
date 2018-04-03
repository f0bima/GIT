Public Class Home
    Dim user = Login.userlogin
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = Login.userlogin
        Timer1.Enabled = True

    End Sub
    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        hasil.Text = convsuhu(CDbl(input.Text), inputsh.Text, outputsh.Text)
    End Sub

    Private Sub suhu_Click(sender As Object, e As EventArgs) Handles suhu.Click
        Panelsuhu.BringToFront()
    End Sub

    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        Dim sr As New IO.StreamReader(Login.FILE_NAME)
        RTBlog.Text = sr.ReadToEnd
        sr.Close()
        Panel2.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        waktu.Text = Date.Now.ToString("hh:mm:ss")
        tanggal.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim objWriter As New System.IO.StreamWriter(Login.FILE_NAME, IO.FileMode.Append)
        objWriter.WriteLine("LOGOUT : " + user + " " + Date.Now.ToString("dd-MM-yyyy hh:mm:ss"))
        objWriter.Close()
        Login.Show()
        Me.Close()
    End Sub
End Class
