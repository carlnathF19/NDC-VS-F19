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
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(138, 72)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(138, 100)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SecondNumberTextBox.TabIndex = 2
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(138, 128)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ResultTextBox.TabIndex = 3
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(523, 335)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "EXIT"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.SecondNumberTextBox)
        Me.Controls.Add(Me.FirstNumberTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents exitButton As Button
End Class
