Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public Ujenis As Short

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim uname, pass As String

        uname = TBUname.Text
        pass = TBPass.Text
        'periksa jenis user
        If uname = "dhidhi" And pass = "pam" Then
            'user jenis I. Admin
            MessageBox.Show("Selamat datang, Dhidhi Pambudi")
            'set jenis user
            Ujenis = 0
        ElseIf uname = "daffa" And pass = "ilyas" Then
            'user jenis II. Spv
            MessageBox.Show("Selamat datang, Daffa")
            'set jenis user
            Ujenis = 1
        Else
            MessageBox.Show("Maaf, username dan password salah atau tidak dikenal")
            Ujenis = -1
        End If

        If Ujenis <> -1 Then
            'catat log in ke log report
            'bawa ke main form
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
End Class
