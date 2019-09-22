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
        Me.components = New System.ComponentModel.Container()
        Me.lbsTextBox = New System.Windows.Forms.TextBox()
        Me.ozTextBox = New System.Windows.Forms.TextBox()
        Me.shippingCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.shippingIdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.userInputGroupBox.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbsTextBox
        '
        Me.lbsTextBox.Location = New System.Drawing.Point(12, 229)
        Me.lbsTextBox.Name = "lbsTextBox"
        Me.lbsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.lbsTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lbsTextBox, "Enter the lbs as a whole number")
        '
        'ozTextBox
        '
        Me.ozTextBox.Location = New System.Drawing.Point(158, 229)
        Me.ozTextBox.Name = "ozTextBox"
        Me.ozTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ozTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ozTextBox, "Enter the ozs as a whole number")
        '
        'shippingCostTextBox
        '
        Me.shippingCostTextBox.Location = New System.Drawing.Point(23, 229)
        Me.shippingCostTextBox.Name = "shippingCostTextBox"
        Me.shippingCostTextBox.Size = New System.Drawing.Size(255, 22)
        Me.shippingCostTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.shippingCostTextBox, "Press Calculate to show the shipping cost")
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
        Me.userInputGroupBox.Controls.Add(Me.shippingIdTextBox)
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
        'shippingIdTextBox
        '
        Me.shippingIdTextBox.Location = New System.Drawing.Point(13, 63)
        Me.shippingIdTextBox.Mask = "&&&&&&"
        Me.shippingIdTextBox.Name = "shippingIdTextBox"
        Me.shippingIdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.shippingIdTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.shippingIdTextBox, "Please Enter the Shipping ID code")
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
        Me.ToolTip1.SetToolTip(Me.calculateButton, "Press Enter, Alt + C or Click here to calculate")
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(406, 280)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 98)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.clearButton, "Press Esc, Alt + C or click here to clear form")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(532, 280)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 98)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Press Alt + X or click here to Exit")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents shippingIdTextBox As MaskedTextBox
End Class
