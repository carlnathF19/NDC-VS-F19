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
        Me.bushButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.pennyButton = New System.Windows.Forms.Button()
        Me.towelButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 228)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'bushButton
        '
        Me.bushButton.Location = New System.Drawing.Point(15, 415)
        Me.bushButton.Name = "bushButton"
        Me.bushButton.Size = New System.Drawing.Size(91, 23)
        Me.bushButton.TabIndex = 1
        Me.bushButton.Text = "Bush"
        Me.bushButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(697, 415)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(91, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'pennyButton
        '
        Me.pennyButton.Location = New System.Drawing.Point(112, 415)
        Me.pennyButton.Name = "pennyButton"
        Me.pennyButton.Size = New System.Drawing.Size(91, 23)
        Me.pennyButton.TabIndex = 3
        Me.pennyButton.Text = "Penny"
        Me.pennyButton.UseVisualStyleBackColor = True
        '
        'towelButton
        '
        Me.towelButton.Location = New System.Drawing.Point(209, 415)
        Me.towelButton.Name = "towelButton"
        Me.towelButton.Size = New System.Drawing.Size(91, 23)
        Me.towelButton.TabIndex = 4
        Me.towelButton.Text = "Towel"
        Me.towelButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Ye Wisdom"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.towelButton)
        Me.Controls.Add(Me.pennyButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.bushButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bushButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents pennyButton As Button
    Friend WithEvents towelButton As Button
    Friend WithEvents Button3 As Button
End Class
