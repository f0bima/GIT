Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Coral
        TransparencyKey = BackColor
        Timer1.Enabled = True
    End Sub
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progress = progress + 10
        Progressbar.Width = progress
        If progress = 380 Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class