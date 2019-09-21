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
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.lbsTextBox = New System.Windows.Forms.TextBox()
        Me.ozTextBox = New System.Windows.Forms.TextBox()
        Me.shippingCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.userInputGroupBox.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(13, 63)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.idTextBox.TabIndex = 0
        '
        'lbsTextBox
        '
        Me.lbsTextBox.Location = New System.Drawing.Point(12, 229)
        Me.lbsTextBox.Name = "lbsTextBox"
        Me.lbsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.lbsTextBox.TabIndex = 1
        '
        'ozTextBox
        '
        Me.ozTextBox.Location = New System.Drawing.Point(158, 229)
        Me.ozTextBox.Name = "ozTextBox"
        Me.ozTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ozTextBox.TabIndex = 2
        '
        'shippingCostTextBox
        '
        Me.shippingCostTextBox.Location = New System.Drawing.Point(23, 229)
        Me.shippingCostTextBox.Name = "shippingCostTextBox"
        Me.shippingCostTextBox.Size = New System.Drawing.Size(255, 22)
        Me.shippingCostTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "6 Digit ID Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Package Shipping Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ".lbs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ".oz"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Shipping Cost"
        '
        'userInputGroupBox
        '
        Me.userInputGroupBox.Controls.Add(Me.idTextBox)
        Me.userInputGroupBox.Controls.Add(Me.lbsTextBox)
        Me.userInputGroupBox.Controls.Add(Me.ozTextBox)
        Me.userInputGroupBox.Controls.Add(Me.Label4)
        Me.userInputGroupBox.Controls.Add(Me.Label1)
        Me.userInputGroupBox.Controls.Add(Me.Label3)
        Me.userInputGroupBox.Controls.Add(Me.Label2)
        Me.userInputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.userInputGroupBox.Name = "userInputGroupBox"
        Me.userInputGroupBox.Size = New System.Drawing.Size(317, 262)
        Me.userInputGroupBox.TabIndex = 9
        Me.userInputGroupBox.TabStop = False
        '
        'outputGroupBox
        '
        Me.outputGroupBox.Controls.Add(Me.Label5)
        Me.outputGroupBox.Controls.Add(Me.shippingCostTextBox)
        Me.outputGroupBox.Location = New System.Drawing.Point(335, 12)
        Me.outputGroupBox.Name = "outputGroupBox"
        Me.outputGroupBox.Size = New System.Drawing.Size(317, 262)
        Me.outputGroupBox.TabIndex = 10
        Me.outputGroupBox.TabStop = False
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(12, 280)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(388, 98)
        Me.calculateButton.TabIndex = 11
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(406, 280)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 98)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(532, 280)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 98)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(664, 389)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.outputGroupBox)
        Me.Controls.Add(Me.userInputGroupBox)
        Me.Name = "Form1"
        Me.Text = "Shipping Calculator"
        Me.userInputGroupBox.ResumeLayout(False)
        Me.userInputGroupBox.PerformLayout()
        Me.outputGroupBox.ResumeLayout(False)
        Me.outputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents idTextBox As TextBox
    Friend WithEvents lbsTextBox As TextBox
    Friend WithEvents ozTextBox As TextBox
    Friend WithEvents shippingCostTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents userInputGroupBox As GroupBox
    Friend WithEvents outputGroupBox As GroupBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
