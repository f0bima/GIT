<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.input = New System.Windows.Forms.TextBox()
        Me.convert = New System.Windows.Forms.Button()
        Me.hasil = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelsuhu = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.outputsh = New System.Windows.Forms.ComboBox()
        Me.inputsh = New System.Windows.Forms.ComboBox()
        Me.kata2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logheading = New System.Windows.Forms.Label()
        Me.RTBlog = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.username = New System.Windows.Forms.Label()
        Me.keluar = New System.Windows.Forms.Label()
        Me.setting = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.waktu = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.Label()
        Me.suhu = New System.Windows.Forms.Label()
        Me.Panelsetting = New System.Windows.Forms.Panel()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usericon = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panelsuhu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelsetting.SuspendLayout()
        CType(Me.usericon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(110, 87)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(275, 42)
        Me.input.TabIndex = 0
        Me.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(197, 212)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(102, 34)
        Me.convert.TabIndex = 3
        Me.convert.Text = "Covert"
        Me.convert.UseVisualStyleBackColor = True
        '
        'hasil
        '
        Me.hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasil.Location = New System.Drawing.Point(0, 288)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(511, 60)
        Me.hasil.TabIndex = 2
        Me.hasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "JENIS SUHU AWAL "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CONVERT KE "
        '
        'Panelsuhu
        '
        Me.Panelsuhu.Controls.Add(Me.Label6)
        Me.Panelsuhu.Controls.Add(Me.Label5)
        Me.Panelsuhu.Controls.Add(Me.outputsh)
        Me.Panelsuhu.Controls.Add(Me.inputsh)
        Me.Panelsuhu.Controls.Add(Me.kata2)
        Me.Panelsuhu.Controls.Add(Me.convert)
        Me.Panelsuhu.Controls.Add(Me.hasil)
        Me.Panelsuhu.Controls.Add(Me.Label2)
        Me.Panelsuhu.Controls.Add(Me.input)
        Me.Panelsuhu.Controls.Add(Me.Label1)
        Me.Panelsuhu.Location = New System.Drawing.Point(211, 0)
        Me.Panelsuhu.Name = "Panelsuhu"
        Me.Panelsuhu.Size = New System.Drawing.Size(510, 373)
        Me.Panelsuhu.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(476, 55)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SUHU CONVERTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SUHU AWAL"
        '
        'outputsh
        '
        Me.outputsh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.outputsh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.outputsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.outputsh.FormattingEnabled = True
        Me.outputsh.Items.AddRange(New Object() {"Celcius", "Farenheit", "Reamur", "Kelvin"})
        Me.outputsh.Location = New System.Drawing.Point(264, 176)
        Me.outputsh.Name = "outputsh"
        Me.outputsh.Size = New System.Drawing.Size(121, 21)
        Me.outputsh.TabIndex = 2
        Me.outputsh.Text = "Celcius"
        '
        'inputsh
        '
        Me.inputsh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.inputsh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.inputsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inputsh.FormattingEnabled = True
        Me.inputsh.Items.AddRange(New Object() {"Celcius", "Farenheit", "Reamur", "Kelvin"})
        Me.inputsh.Location = New System.Drawing.Point(110, 176)
        Me.inputsh.Name = "inputsh"
        Me.inputsh.Size = New System.Drawing.Size(121, 21)
        Me.inputsh.TabIndex = 1
        Me.inputsh.Text = "Celcius"
        '
        'kata2
        '
        Me.kata2.Location = New System.Drawing.Point(0, 249)
        Me.kata2.Name = "kata2"
        Me.kata2.Size = New System.Drawing.Size(510, 44)
        Me.kata2.TabIndex = 7
        Me.kata2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.logheading)
        Me.Panel2.Controls.Add(Me.RTBlog)
        Me.Panel2.Location = New System.Drawing.Point(211, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 373)
        Me.Panel2.TabIndex = 7
        '
        'logheading
        '
        Me.logheading.AutoSize = True
        Me.logheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logheading.Location = New System.Drawing.Point(192, 9)
        Me.logheading.Name = "logheading"
        Me.logheading.Size = New System.Drawing.Size(140, 25)
        Me.logheading.TabIndex = 1
        Me.logheading.Text = "LOG HISTOY"
        '
        'RTBlog
        '
        Me.RTBlog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBlog.Location = New System.Drawing.Point(16, 41)
        Me.RTBlog.Name = "RTBlog"
        Me.RTBlog.Size = New System.Drawing.Size(475, 276)
        Me.RTBlog.TabIndex = 0
        Me.RTBlog.Text = ""
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.usericon)
        Me.Panel1.Controls.Add(Me.keluar)
        Me.Panel1.Controls.Add(Me.setting)
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.waktu)
        Me.Panel1.Controls.Add(Me.Log)
        Me.Panel1.Controls.Add(Me.suhu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 373)
        Me.Panel1.TabIndex = 1
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.Yellow
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(0, 105)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(212, 23)
        Me.username.TabIndex = 8
        Me.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'keluar
        '
        Me.keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keluar.Location = New System.Drawing.Point(3, 278)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(206, 31)
        Me.keluar.TabIndex = 6
        Me.keluar.Text = "EXIT"
        Me.keluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'setting
        '
        Me.setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.setting.Location = New System.Drawing.Point(3, 216)
        Me.setting.Name = "setting"
        Me.setting.Size = New System.Drawing.Size(206, 31)
        Me.setting.TabIndex = 5
        Me.setting.Text = "SETTING"
        Me.setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.White
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Location = New System.Drawing.Point(3, 247)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(206, 31)
        Me.Logout.TabIndex = 4
        Me.Logout.Text = "LOGOUT"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tanggal
        '
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(0, 320)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(212, 28)
        Me.tanggal.TabIndex = 3
        Me.tanggal.Text = "TANGGAL"
        Me.tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'waktu
        '
        Me.waktu.BackColor = System.Drawing.SystemColors.Control
        Me.waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu.Location = New System.Drawing.Point(0, 348)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(212, 25)
        Me.waktu.TabIndex = 2
        Me.waktu.Text = "WAKTU"
        Me.waktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Log
        '
        Me.Log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Log.Location = New System.Drawing.Point(3, 124)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(206, 29)
        Me.Log.TabIndex = 1
        Me.Log.Text = "LOG"
        Me.Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'suhu
        '
        Me.suhu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suhu.Location = New System.Drawing.Point(3, 182)
        Me.suhu.Name = "suhu"
        Me.suhu.Size = New System.Drawing.Size(206, 34)
        Me.suhu.TabIndex = 0
        Me.suhu.Text = "SUHU"
        Me.suhu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panelsetting
        '
        Me.Panelsetting.Controls.Add(Me.RadioButton4)
        Me.Panelsetting.Controls.Add(Me.RadioButton3)
        Me.Panelsetting.Controls.Add(Me.RadioButton2)
        Me.Panelsetting.Controls.Add(Me.RadioButton1)
        Me.Panelsetting.Controls.Add(Me.Label3)
        Me.Panelsetting.Controls.Add(Me.PictureBox4)
        Me.Panelsetting.Controls.Add(Me.PictureBox3)
        Me.Panelsetting.Controls.Add(Me.PictureBox2)
        Me.Panelsetting.Controls.Add(Me.PictureBox1)
        Me.Panelsetting.Location = New System.Drawing.Point(211, 0)
        Me.Panelsetting.Name = "Panelsetting"
        Me.Panelsetting.Size = New System.Drawing.Size(510, 373)
        Me.Panelsetting.TabIndex = 1
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(401, 338)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(275, 339)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(146, 339)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(23, 339)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "THEME"
        '
        'usericon
        '
        Me.usericon.BackColor = System.Drawing.Color.Transparent
        Me.usericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.usericon.Location = New System.Drawing.Point(69, 6)
        Me.usericon.Name = "usericon"
        Me.usericon.Size = New System.Drawing.Size(72, 67)
        Me.usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usericon.TabIndex = 7
        Me.usericon.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.UTS.My.Resources.Resources.bg4
        Me.PictureBox4.Location = New System.Drawing.Point(389, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(109, 280)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.UTS.My.Resources.Resources.bg3
        Me.PictureBox3.Location = New System.Drawing.Point(264, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 280)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UTS.My.Resources.Resources.bg2
        Me.PictureBox2.Location = New System.Drawing.Point(137, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 280)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UTS.My.Resources.Resources.bg1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(78, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ABOUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 372)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelsuhu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panelsetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(737, 414)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panelsuhu.ResumeLayout(False)
        Me.Panelsuhu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panelsetting.ResumeLayout(False)
        Me.Panelsetting.PerformLayout()
        CType(Me.usericon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents convert As Button
    Friend WithEvents hasil As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panelsuhu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents suhu As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Log As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents waktu As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents logheading As Label
    Friend WithEvents RTBlog As RichTextBox
    Friend WithEvents Logout As Label
    Friend WithEvents setting As Label
    Friend WithEvents Panelsetting As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents outputsh As ComboBox
    Friend WithEvents inputsh As ComboBox
    Friend WithEvents kata2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents keluar As Label
    Friend WithEvents usericon As PictureBox
    Friend WithEvents username As Label
    Friend WithEvents Button1 As Button
End Class
