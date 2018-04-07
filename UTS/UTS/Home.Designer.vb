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
        Me.inputsh = New System.Windows.Forms.TextBox()
        Me.outputsh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelsuhu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logheading = New System.Windows.Forms.Label()
        Me.RTBlog = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelsuhu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelsetting.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(79, 77)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(100, 20)
        Me.input.TabIndex = 0
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(244, 75)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(75, 23)
        Me.convert.TabIndex = 1
        Me.convert.Text = "Button1"
        Me.convert.UseVisualStyleBackColor = True
        '
        'hasil
        '
        Me.hasil.AutoSize = True
        Me.hasil.Location = New System.Drawing.Point(201, 283)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(39, 13)
        Me.hasil.TabIndex = 2
        Me.hasil.Text = "Label1"
        '
        'inputsh
        '
        Me.inputsh.Location = New System.Drawing.Point(79, 130)
        Me.inputsh.Name = "inputsh"
        Me.inputsh.Size = New System.Drawing.Size(100, 20)
        Me.inputsh.TabIndex = 3
        '
        'outputsh
        '
        Me.outputsh.Location = New System.Drawing.Point(79, 186)
        Me.outputsh.Name = "outputsh"
        Me.outputsh.Size = New System.Drawing.Size(100, 20)
        Me.outputsh.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INPUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "OUTPUT"
        '
        'Panelsuhu
        '
        Me.Panelsuhu.Controls.Add(Me.convert)
        Me.Panelsuhu.Controls.Add(Me.hasil)
        Me.Panelsuhu.Controls.Add(Me.Label2)
        Me.Panelsuhu.Controls.Add(Me.input)
        Me.Panelsuhu.Controls.Add(Me.Label1)
        Me.Panelsuhu.Controls.Add(Me.inputsh)
        Me.Panelsuhu.Controls.Add(Me.outputsh)
        Me.Panelsuhu.Location = New System.Drawing.Point(211, 0)
        Me.Panelsuhu.Name = "Panelsuhu"
        Me.Panelsuhu.Size = New System.Drawing.Size(510, 373)
        Me.Panelsuhu.TabIndex = 0
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
        Me.logheading.Location = New System.Drawing.Point(204, 9)
        Me.logheading.Name = "logheading"
        Me.logheading.Size = New System.Drawing.Size(72, 13)
        Me.logheading.TabIndex = 1
        Me.logheading.Text = "LOG HISTOY"
        '
        'RTBlog
        '
        Me.RTBlog.Location = New System.Drawing.Point(16, 28)
        Me.RTBlog.Name = "RTBlog"
        Me.RTBlog.Size = New System.Drawing.Size(450, 304)
        Me.RTBlog.TabIndex = 0
        Me.RTBlog.Text = ""
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'setting
        '
        Me.setting.AutoSize = True
        Me.setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.setting.Location = New System.Drawing.Point(69, 211)
        Me.setting.Name = "setting"
        Me.setting.Size = New System.Drawing.Size(40, 13)
        Me.setting.TabIndex = 5
        Me.setting.Text = "Setting"
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Location = New System.Drawing.Point(68, 242)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(52, 13)
        Me.Logout.TabIndex = 4
        Me.Logout.Text = "LOGOUT"
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.Location = New System.Drawing.Point(68, 319)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(39, 13)
        Me.tanggal.TabIndex = 3
        Me.tanggal.Text = "Label3"
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.Location = New System.Drawing.Point(68, 294)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(39, 13)
        Me.waktu.TabIndex = 2
        Me.waktu.Text = "Label3"
        '
        'Log
        '
        Me.Log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Log.Location = New System.Drawing.Point(71, 100)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(39, 15)
        Me.Log.TabIndex = 1
        Me.Log.Text = "LOG"
        '
        'suhu
        '
        Me.suhu.AutoSize = True
        Me.suhu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suhu.Location = New System.Drawing.Point(69, 52)
        Me.suhu.Name = "suhu"
        Me.suhu.Size = New System.Drawing.Size(38, 13)
        Me.suhu.TabIndex = 0
        Me.suhu.Text = "SUHU"
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
        Me.Label3.Location = New System.Drawing.Point(244, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "THEME"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.UTS.My.Resources.Resources.bg4
        Me.PictureBox4.Location = New System.Drawing.Point(389, 31)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(109, 286)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.UTS.My.Resources.Resources.bg3
        Me.PictureBox3.Location = New System.Drawing.Point(264, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 286)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UTS.My.Resources.Resources.bg2
        Me.PictureBox2.Location = New System.Drawing.Point(137, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 286)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UTS.My.Resources.Resources.bg1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 475)
        Me.Controls.Add(Me.Panelsetting)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelsuhu)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panelsuhu.ResumeLayout(False)
        Me.Panelsuhu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panelsetting.ResumeLayout(False)
        Me.Panelsetting.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents convert As Button
    Friend WithEvents hasil As Label
    Friend WithEvents inputsh As TextBox
    Friend WithEvents outputsh As TextBox
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
End Class
