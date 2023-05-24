<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.Legenda = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Legenda
        '
        Me.Legenda.AutoSize = True
        Me.Legenda.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Legenda.Location = New System.Drawing.Point(193, 44)
        Me.Legenda.Name = "Legenda"
        Me.Legenda.Size = New System.Drawing.Size(394, 51)
        Me.Legenda.TabIndex = 0
        Me.Legenda.Text = "ISTO E UMA LEGENDA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(394, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "a) Esconder a legenda"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(394, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "b) Mostrar legenda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(394, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "c) Mudar cor de fundo da legenda"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(193, 361)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(394, 40)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "b) Mudar cor de fundo do formulário"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(193, 407)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(394, 78)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "e) Escrever na legenda um nº aleatório entre 1 e 100"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 599)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Legenda)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Legenda As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
