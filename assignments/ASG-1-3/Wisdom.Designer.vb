<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wisdom
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
        Me.Sayings = New System.Windows.Forms.Label()
        Me.bushButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.pennyButton = New System.Windows.Forms.Button()
        Me.towelButton = New System.Windows.Forms.Button()
        Me.debtButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Sayings
        '
        Me.Sayings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sayings.Location = New System.Drawing.Point(12, 9)
        Me.Sayings.Name = "Sayings"
        Me.Sayings.Size = New System.Drawing.Size(776, 228)
        Me.Sayings.TabIndex = 0
        Me.Sayings.Text = "Don't Panic && Carry a Towel"
        Me.Sayings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bushButton
        '
        Me.bushButton.Location = New System.Drawing.Point(15, 240)
        Me.bushButton.Name = "bushButton"
        Me.bushButton.Size = New System.Drawing.Size(91, 23)
        Me.bushButton.TabIndex = 1
        Me.bushButton.Text = "Bush"
        Me.bushButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(697, 240)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(91, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'pennyButton
        '
        Me.pennyButton.Location = New System.Drawing.Point(112, 240)
        Me.pennyButton.Name = "pennyButton"
        Me.pennyButton.Size = New System.Drawing.Size(91, 23)
        Me.pennyButton.TabIndex = 3
        Me.pennyButton.Text = "Penny"
        Me.pennyButton.UseVisualStyleBackColor = True
        '
        'towelButton
        '
        Me.towelButton.Location = New System.Drawing.Point(209, 240)
        Me.towelButton.Name = "towelButton"
        Me.towelButton.Size = New System.Drawing.Size(91, 23)
        Me.towelButton.TabIndex = 4
        Me.towelButton.Text = "Towel"
        Me.towelButton.UseVisualStyleBackColor = True
        '
        'debtButton
        '
        Me.debtButton.Location = New System.Drawing.Point(306, 240)
        Me.debtButton.Name = "debtButton"
        Me.debtButton.Size = New System.Drawing.Size(91, 23)
        Me.debtButton.TabIndex = 5
        Me.debtButton.Text = "Debt"
        Me.debtButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(608, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nathan Carlson"
        '
        'Wisdom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.debtButton)
        Me.Controls.Add(Me.towelButton)
        Me.Controls.Add(Me.pennyButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.bushButton)
        Me.Controls.Add(Me.Sayings)
        Me.Name = "Wisdom"
        Me.Text = "Words to Live By"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sayings As Label
    Friend WithEvents bushButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents pennyButton As Button
    Friend WithEvents towelButton As Button
    Friend WithEvents debtButton As Button
    Friend WithEvents Label1 As Label
End Class
