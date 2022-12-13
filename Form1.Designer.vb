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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sentence1 = New System.Windows.Forms.TextBox()
        Me.sentence2 = New System.Windows.Forms.TextBox()
        Me.sentence3 = New System.Windows.Forms.TextBox()
        Me.resultss = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Sentence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Second Sentence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Third Sentence"
        '
        'sentence1
        '
        Me.sentence1.Location = New System.Drawing.Point(56, 46)
        Me.sentence1.Name = "sentence1"
        Me.sentence1.Size = New System.Drawing.Size(238, 20)
        Me.sentence1.TabIndex = 3
        '
        'sentence2
        '
        Me.sentence2.Location = New System.Drawing.Point(56, 102)
        Me.sentence2.Name = "sentence2"
        Me.sentence2.Size = New System.Drawing.Size(238, 20)
        Me.sentence2.TabIndex = 4
        '
        'sentence3
        '
        Me.sentence3.Location = New System.Drawing.Point(56, 162)
        Me.sentence3.Name = "sentence3"
        Me.sentence3.Size = New System.Drawing.Size(238, 20)
        Me.sentence3.TabIndex = 5
        '
        'resultss
        '
        Me.resultss.AutoSize = True
        Me.resultss.Location = New System.Drawing.Point(12, 237)
        Me.resultss.Name = "resultss"
        Me.resultss.Size = New System.Drawing.Size(10, 13)
        Me.resultss.TabIndex = 6
        Me.resultss.Text = ":"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 304)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resultss)
        Me.Controls.Add(Me.sentence3)
        Me.Controls.Add(Me.sentence2)
        Me.Controls.Add(Me.sentence1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "vbpMod12_AverageLength"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sentence1 As TextBox
    Friend WithEvents sentence2 As TextBox
    Friend WithEvents sentence3 As TextBox
    Friend WithEvents resultss As Label
    Friend WithEvents Button1 As Button
End Class
