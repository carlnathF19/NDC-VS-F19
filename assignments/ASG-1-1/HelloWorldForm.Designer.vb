<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldForm
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
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateLabelButton = New System.Windows.Forms.Button()
        Me.RadioEng = New System.Windows.Forms.RadioButton()
        Me.RadioFr = New System.Windows.Forms.RadioButton()
        Me.RadioIt = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(77, 46)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(661, 113)
        Me.DisplayLabel.TabIndex = 1
        Me.DisplayLabel.Text = "Hello World"
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(411, 302)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(117, 72)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateLabelButton
        '
        Me.UpdateLabelButton.Location = New System.Drawing.Point(207, 302)
        Me.UpdateLabelButton.Name = "UpdateLabelButton"
        Me.UpdateLabelButton.Size = New System.Drawing.Size(117, 72)
        Me.UpdateLabelButton.TabIndex = 3
        Me.UpdateLabelButton.Text = "Update &Language"
        Me.UpdateLabelButton.UseVisualStyleBackColor = True
        '
        'RadioEng
        '
        Me.RadioEng.AutoSize = True
        Me.RadioEng.Location = New System.Drawing.Point(330, 302)
        Me.RadioEng.Name = "RadioEng"
        Me.RadioEng.Size = New System.Drawing.Size(75, 21)
        Me.RadioEng.TabIndex = 4
        Me.RadioEng.TabStop = True
        Me.RadioEng.Text = "English"
        Me.RadioEng.UseVisualStyleBackColor = True
        '
        'RadioFr
        '
        Me.RadioFr.AutoSize = True
        Me.RadioFr.Location = New System.Drawing.Point(330, 328)
        Me.RadioFr.Name = "RadioFr"
        Me.RadioFr.Size = New System.Drawing.Size(73, 21)
        Me.RadioFr.TabIndex = 5
        Me.RadioFr.TabStop = True
        Me.RadioFr.Text = "French"
        Me.RadioFr.UseVisualStyleBackColor = True
        '
        'RadioIt
        '
        Me.RadioIt.AutoSize = True
        Me.RadioIt.Location = New System.Drawing.Point(330, 353)
        Me.RadioIt.Name = "RadioIt"
        Me.RadioIt.Size = New System.Drawing.Size(66, 21)
        Me.RadioIt.TabIndex = 6
        Me.RadioIt.TabStop = True
        Me.RadioIt.Text = "Italian"
        Me.RadioIt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 422)
        Me.Controls.Add(Me.RadioIt)
        Me.Controls.Add(Me.RadioFr)
        Me.Controls.Add(Me.RadioEng)
        Me.Controls.Add(Me.UpdateLabelButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateLabelButton As Button
    Friend WithEvents RadioEng As RadioButton
    Friend WithEvents RadioFr As RadioButton
    Friend WithEvents RadioIt As RadioButton
End Class
