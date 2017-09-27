<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
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
        Me.bn_next = New System.Windows.Forms.Button()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tb_index = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bn_next
        '
        Me.bn_next.Location = New System.Drawing.Point(144, 226)
        Me.bn_next.Name = "bn_next"
        Me.bn_next.Size = New System.Drawing.Size(75, 23)
        Me.bn_next.TabIndex = 0
        Me.bn_next.Text = "Next"
        Me.bn_next.UseVisualStyleBackColor = True
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(80, 38)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(100, 20)
        Me.fname.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(63, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Prev"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_index
        '
        Me.tb_index.Location = New System.Drawing.Point(80, 10)
        Me.tb_index.Name = "tb_index"
        Me.tb_index.Size = New System.Drawing.Size(58, 20)
        Me.tb_index.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "current index"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "first name"
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_index)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.bn_next)
        Me.Name = "ContactForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bn_next As Button
    Friend WithEvents fname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_index As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
