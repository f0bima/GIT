<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Log = New System.Windows.Forms.Label()
        Me.suhu = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.waktu = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.RTBlog = New System.Windows.Forms.RichTextBox()
        Me.logheading = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Panelsuhu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panelsuhu.Location = New System.Drawing.Point(229, 12)
        Me.Panelsuhu.Name = "Panelsuhu"
        Me.Panelsuhu.Size = New System.Drawing.Size(480, 349)
        Me.Panelsuhu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.waktu)
        Me.Panel1.Controls.Add(Me.Log)
        Me.Panel1.Controls.Add(Me.suhu)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 349)
        Me.Panel1.TabIndex = 1
        '
        'Log
        '
        Me.Log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Log.Location = New System.Drawing.Point(68, 218)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.logheading)
        Me.Panel2.Controls.Add(Me.RTBlog)
        Me.Panel2.Location = New System.Drawing.Point(229, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 349)
        Me.Panel2.TabIndex = 7
        '
        'Timer1
        '
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
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.Location = New System.Drawing.Point(68, 319)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(39, 13)
        Me.tanggal.TabIndex = 3
        Me.tanggal.Text = "Label3"
        '
        'RTBlog
        '
        Me.RTBlog.Location = New System.Drawing.Point(16, 28)
        Me.RTBlog.Name = "RTBlog"
        Me.RTBlog.Size = New System.Drawing.Size(450, 304)
        Me.RTBlog.TabIndex = 0
        Me.RTBlog.Text = ""
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
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Location = New System.Drawing.Point(71, 262)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(52, 13)
        Me.Logout.TabIndex = 4
        Me.Logout.Text = "LOGOUT"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 373)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelsuhu)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panelsuhu.ResumeLayout(False)
        Me.Panelsuhu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
End Class
