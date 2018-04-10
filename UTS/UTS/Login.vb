Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public ujenis As Char
    Public userlogin As String
    Public FILE_NAME As String = "...\log.txt"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransparencyKey = BackColor
        Timer1.Enabled = True
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        Dim user, pass As String
        user = Username.Text
        pass = Password.Text
        If (user = "A" And pass = "A") Then
            MessageBox.Show("SELAMAT DATANG A")
            ujenis = "A"
            userlogin = "A"
            My.Settings.user = 1
        ElseIf (user = "B" And pass = "B") Then
            MessageBox.Show("SELAMAT DATANG B")
            ujenis = "B"
            userlogin = "B"
            My.Settings.user = 2
        ElseIf (user = "C" And pass = "C") Then
            MessageBox.Show("SELAMAT DATANG C")
            ujenis = "C"
            userlogin = "C"
            My.Settings.user = 3
        ElseIf Username.Text = String.Empty Then
            MessageBox.Show("SILAHKAN ISI USERNAME")
            ujenis = "f"
        ElseIf Password.Text = String.Empty Then
            MessageBox.Show("SILAHKAN ISI PASSWORD")
            ujenis = "f"
        Else
            MessageBox.Show("USER ATAU PASSWORD SALAH")
            ujenis = "f"
        End If
        If (ujenis <> "f") Then
            Home.Show()
            Me.Close()

            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
                objWriter.WriteLine("LOGIN : " + user + " " + Date.Now.ToString("dd-MM-yyyy hh:mm:ss"))
                objWriter.Close()
            Else
                Dim writeFile As IO.StreamWriter
                writeFile = IO.File.CreateText(FILE_NAME)
                writeFile.WriteLine("LOGIN : " + user + " " + Date.Now.ToString("dd-MM-yyyy hh:mm:ss"))
                writeFile.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

End Class
