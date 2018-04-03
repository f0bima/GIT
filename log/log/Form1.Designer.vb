<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.inp = New System.Windows.Forms.TextBox()
        Me.tambah = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.readtext = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'inp
        '
        Me.inp.Location = New System.Drawing.Point(12, 50)
        Me.inp.Name = "inp"
        Me.inp.Size = New System.Drawing.Size(260, 20)
        Me.inp.TabIndex = 0
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(12, 94)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(75, 23)
        Me.tambah.TabIndex = 1
        Me.tambah.Text = "Write"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'readtext
        '
        Me.readtext.Location = New System.Drawing.Point(12, 143)
        Me.readtext.Name = "readtext"
        Me.readtext.Size = New System.Drawing.Size(260, 96)
        Me.readtext.TabIndex = 3
        Me.readtext.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 262)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(260, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.readtext)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.inp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inp As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents readtext As RichTextBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
