<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.input = New System.Windows.Forms.TextBox()
        Me.convert = New System.Windows.Forms.Button()
        Me.hasil = New System.Windows.Forms.Label()
        Me.inputsh = New System.Windows.Forms.TextBox()
        Me.outputsh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(33, 52)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(100, 20)
        Me.input.TabIndex = 0
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(178, 52)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(75, 23)
        Me.convert.TabIndex = 1
        Me.convert.Text = "Button1"
        Me.convert.UseVisualStyleBackColor = True
        '
        'hasil
        '
        Me.hasil.AutoSize = True
        Me.hasil.Location = New System.Drawing.Point(30, 149)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(39, 13)
        Me.hasil.TabIndex = 2
        Me.hasil.Text = "Label1"
        '
        'inputsh
        '
        Me.inputsh.Location = New System.Drawing.Point(33, 91)
        Me.inputsh.Name = "inputsh"
        Me.inputsh.Size = New System.Drawing.Size(100, 20)
        Me.inputsh.TabIndex = 3
        '
        'outputsh
        '
        Me.outputsh.Location = New System.Drawing.Point(33, 117)
        Me.outputsh.Name = "outputsh"
        Me.outputsh.Size = New System.Drawing.Size(100, 20)
        Me.outputsh.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INPUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "OUTPUT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outputsh)
        Me.Controls.Add(Me.inputsh)
        Me.Controls.Add(Me.hasil)
        Me.Controls.Add(Me.convert)
        Me.Controls.Add(Me.input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents convert As Button
    Friend WithEvents hasil As Label
    Friend WithEvents inputsh As TextBox
    Friend WithEvents outputsh As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
