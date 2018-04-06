Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jenis As Short
        jenis = LoginForm1.Ujenis
        Select Case jenis
            Case 0
                'kumpulan code yg sesuai dg hak/privelege user jenis I. admin
                StatusStrip1.Items.Add("Welcome, log in as Admin")
                'ubah posisi default
                MenuLogReport.Enabled = True
                MenuLogReport.Visible = True
                Dim menuMonitor As New ToolStripMenuItem() With {.Text = "Monitoring", .Name = "MenuMonitor"}
                Dim menuRT As New ToolStripMenuItem() With {.Text = "Real Time Monitoring", .Name = "MenuRealTime"}
                Dim btn1 As New System.Windows.Forms.Button
                AddHandler menuRT.Click, AddressOf menuRTdipilih 'beri event (click) handler , arahkan ke sub dg nama menuRTdipilih


                menuMonitor.DropDownItems.Add(menuRT) 'tambahkan menu real time sebagai sub menu dari monitoring
                MS.Items.Add(menuMonitor) 'tambahkan monitoring sbg item baru di menu strip

                btn1.Text = "Save"
                btn1.Name = "SaveButton"
                btn1.BackColor = Color.Green 'Change this to any color
                'btn1.Location = New Point(45, 45) 'This is the position of the button on the form
                btn1.Location = New Point(45, 45)
                btn1.Size = New Size(500, 500) 'This is the size of the form
                Me.Controls.Add(btn1)
                Panel2.Controls.Add(btn1)
                AddHandler btn1.Click, AddressOf Button_Click
            Case 1
                'kumpulan code yg sesuai dg hak/privelege user jenis II
                StatusStrip1.Items.Add("Welcome, log in as Supervisor")
        End Select
    End Sub

    Private Sub menuRTdipilih(sender As Object, e As EventArgs)
        'code yg dilakukan saat menu Real Time Monitoring di-klik
        MessageBox.Show("Anda memilih menu Real Time Monitoring")

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Ujenis = -1
        LoginForm1.Show()
        'catat log out ke log report
        'Me.Hide()  'jgn lupa kembalikan semua ke posisi default
        Me.Close()
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class
