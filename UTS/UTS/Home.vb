Public Class Home
    Dim user = Login.userlogin
    Dim FILE_MON As String = "...\Monitoring.txt"
    Dim LabMon As New System.Windows.Forms.Label With {.Name = "LbMonitoring"}

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabMon.Text = "MONITORING"
        LabMon.BackColor = Color.White
        LabMon.Cursor = Cursors.Hand
        LabMon.TextAlign = ContentAlignment.MiddleCenter
        LabMon.BackColor = Color.FromArgb(200, Color.White)

        Panelsuhu.BringToFront()
        Timer1.Enabled = True
        Select Case My.Settings.background
            Case 1
                Panel1.BackgroundImage = My.Resources.bg1
            Case 2
                Panel1.BackgroundImage = My.Resources.bg2
            Case 3
                Panel1.BackgroundImage = My.Resources.bg3
            Case 4
                Panel1.BackgroundImage = My.Resources.bg4
            Case Else
                Panel1.BackgroundImage = My.Resources.bg1
        End Select

        Select Case My.Settings.user
            Case 1
                tampilmonitor()
                usericon.Image = My.Resources.user1
                user = "A"
            Case 2
                Log.Visible = False
                tampilmonitor()
                usericon.Image = My.Resources.user2
                user = "B"
            Case 3
                Log.Visible = False
                usericon.Image = My.Resources.user3
                user = "C"
            Case Else
                My.Settings.user = 0
                Login.Show()
                Me.Close()
        End Select
        username.Text = user

        suhu.BackColor = Color.FromArgb(200, Color.White)
        Log.BackColor = Color.FromArgb(200, Color.White)
        setting.BackColor = Color.FromArgb(200, Color.White)
        Logout.BackColor = Color.FromArgb(200, Color.White)
        tanggal.BackColor = Color.FromArgb(200, Color.White)
        waktu.BackColor = Color.FromArgb(200, Color.White)
        keluar.BackColor = Color.FromArgb(200, Color.White)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        waktu.Text = Date.Now.ToString("HH:mm:ss")
        tanggal.Text = Date.Now.ToString("dd-MMMM-yyyy")
    End Sub

    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        If Not IsNumeric(input.Text) Then
            MessageBox.Show("MASUKAN ANGKA")
            input.Focus()
            input.Clear()
            hasil.Text = "MASUKAN ANGKA"
        Else
            hasil.Text = CStr(convsuhu(CDbl(input.Text), inputsh.Text, outputsh.Text)) + " " + outputsh.Text
            kata2.Text = "HASIL KONVERSI " + input.Text + " " + inputsh.Text + " ke " + outputsh.Text + " adalah"
        End If

        Dim objWriter As New System.IO.StreamWriter(FILE_MON, IO.FileMode.Append)
        objWriter.WriteLine("USER : " + user + " " + Date.Now.ToString("dd-MM-yyyy hh:mm:ss"))
        objWriter.WriteLine("      SUHU  : " + input.Text)
        objWriter.WriteLine("      From  : " + inputsh.Text + " To " + outputsh.Text)
        objWriter.WriteLine("      Hasil : " + hasil.Text)
        objWriter.Close()
    End Sub

    Private Sub suhu_Click(sender As Object, e As EventArgs) Handles suhu.Click
        Panelsuhu.BringToFront()
    End Sub

    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        Dim sr As New IO.StreamReader(Login.FILE_NAME)
        RTBlog.Text = sr.ReadToEnd
        sr.Close()
        logheading.Text = "LOG HISTORY"
        Panel2.BringToFront()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim objWriter As New System.IO.StreamWriter(Login.FILE_NAME, IO.FileMode.Append)
        objWriter.WriteLine("LOGOUT : " + user + " " + Date.Now.ToString("dd-MM-yyyy hh:mm:ss"))
        objWriter.Close()
        My.Settings.user = 0
        Login.Show()
        Me.Close()
    End Sub

    Private Sub setting_Click(sender As Object, e As EventArgs) Handles setting.Click
        Panelsetting.BringToFront()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.BackgroundImage = My.Resources.bg1
        My.Settings.background = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Panel1.BackgroundImage = My.Resources.bg2
        My.Settings.background = 2
    End Sub
    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Panel1.BackgroundImage = My.Resources.bg3
        My.Settings.background = 3
    End Sub
    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Panel1.BackgroundImage = My.Resources.bg4
        My.Settings.background = 4
    End Sub

    Private Sub Monitor_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim sr As New IO.StreamReader(FILE_MON)
        RTBlog.Text = sr.ReadToEnd
        sr.Close()
        logheading.Text = "MONITORING"
        Panel2.BringToFront()
    End Sub

    Private Sub Monitor_Hover(ByVal sender As Object, ByVal e As EventArgs)
        LabMon.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub Monitor_Leave(ByVal sender As Object, ByVal e As EventArgs)
        LabMon.BackColor = Color.FromArgb(200, Color.White)
    End Sub

    Private Sub suhu_MouseHover(sender As Object, e As EventArgs) Handles suhu.MouseHover
        suhu.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub suhu_MouseLeave(sender As Object, e As EventArgs) Handles suhu.MouseLeave
        suhu.BackColor = Color.FromArgb(200, Color.White)
    End Sub

    Private Sub Log_MouseHover(sender As Object, e As EventArgs) Handles Log.MouseHover
        Log.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub Log_MouseLeave(sender As Object, e As EventArgs) Handles Log.MouseLeave
        Log.BackColor = Color.FromArgb(200, Color.White)
    End Sub

    Private Sub setting_MouseHover(sender As Object, e As EventArgs) Handles setting.MouseHover
        setting.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub setting_MouseLeave(sender As Object, e As EventArgs) Handles setting.MouseLeave
        setting.BackColor = Color.FromArgb(200, Color.White)
    End Sub

    Private Sub Logout_MouseHover(sender As Object, e As EventArgs) Handles Logout.MouseHover
        Logout.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub Logout_MouseLeave(sender As Object, e As EventArgs) Handles Logout.MouseLeave
        Logout.BackColor = Color.FromArgb(200, Color.White)
    End Sub
    Private Sub keluar_MouseHover(sender As Object, e As EventArgs) Handles keluar.MouseHover
        keluar.BackColor = Color.FromArgb(200, Color.LightGray)
    End Sub

    Private Sub keluar_MouseLeave(sender As Object, e As EventArgs) Handles keluar.MouseLeave
        keluar.BackColor = Color.FromArgb(200, Color.White)
    End Sub
    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub
    Private Sub inputsh_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles inputsh.Validating
        If inputsh.Items.Contains(inputsh.Text) = False Then
            MessageBox.Show("JENIS INPUT SALAH")
            hasil.Text = ("JENIS INPUT SALAH")
        End If

    End Sub
    Private Sub outputsh_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles outputsh.Validating
        If outputsh.Items.Contains(outputsh.Text) = False Then
            MessageBox.Show("JENIS OUTPUT SALAH")
            hasil.Text = ("JENIS OUTPUT SALAH")
        End If
    End Sub

    'Private Sub input_Validated(sender As Object, e As EventArgs) Handles input.Validated
    'If Not IsNumeric(input.Text) Then
    '       MessageBox.Show("INPUTAN HARUS ANGKA")
    '      input.Clear()
    'End If
    'End Sub
    Public Sub tampilmonitor()
        LabMon.Location = New Point(3, 153)
        LabMon.Size = New Size(206, 29)
        AddHandler LabMon.Click, AddressOf Monitor_Click
        AddHandler LabMon.MouseHover, AddressOf Monitor_Hover
        AddHandler LabMon.MouseLeave, AddressOf Monitor_Leave
        Panel1.Controls.Add(LabMon)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Hide()
        about.Show()
        Me.Enabled = False
    End Sub
End Class
