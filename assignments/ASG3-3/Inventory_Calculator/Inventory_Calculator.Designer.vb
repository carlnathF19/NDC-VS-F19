<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Calculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.beginningInventoryTextBox = New System.Windows.Forms.TextBox()
        Me.endingInventoryTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.costOfGoodsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.avgInventoryTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.turnoverTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.userInputGroupBox.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beginning Inventory"
        '
        'beginningInventoryTextBox
        '
        Me.beginningInventoryTextBox.Location = New System.Drawing.Point(21, 52)
        Me.beginningInventoryTextBox.Name = "beginningInventoryTextBox"
        Me.beginningInventoryTextBox.Size = New System.Drawing.Size(252, 22)
        Me.beginningInventoryTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.beginningInventoryTextBox, "Enter Beginning Inventory as a whole number")
        '
        'endingInventoryTextBox
        '
        Me.endingInventoryTextBox.Location = New System.Drawing.Point(21, 105)
        Me.endingInventoryTextBox.Name = "endingInventoryTextBox"
        Me.endingInventoryTextBox.Size = New System.Drawing.Size(252, 22)
        Me.endingInventoryTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.endingInventoryTextBox, "Enter Ending Inventory as a whole number")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ending Inventory"
        '
        'costOfGoodsTextBox
        '
        Me.costOfGoodsTextBox.Location = New System.Drawing.Point(21, 154)
        Me.costOfGoodsTextBox.Name = "costOfGoodsTextBox"
        Me.costOfGoodsTextBox.Size = New System.Drawing.Size(252, 22)
        Me.costOfGoodsTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.costOfGoodsTextBox, "Enter Cost of Goods Sold with no $")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Costs of Goods Sold"
        '
        'avgInventoryTextBox
        '
        Me.avgInventoryTextBox.Location = New System.Drawing.Point(16, 52)
        Me.avgInventoryTextBox.Name = "avgInventoryTextBox"
        Me.avgInventoryTextBox.Size = New System.Drawing.Size(252, 22)
        Me.avgInventoryTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.avgInventoryTextBox, "Press Calculate to display Average Inventory")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Average Inventory"
        '
        'turnoverTextBox
        '
        Me.turnoverTextBox.Location = New System.Drawing.Point(16, 105)
        Me.turnoverTextBox.Name = "turnoverTextBox"
        Me.turnoverTextBox.Size = New System.Drawing.Size(252, 22)
        Me.turnoverTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.turnoverTextBox, "Press Calculate to display Turnover")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Turnover"
        '
        'userInputGroupBox
        '
        Me.userInputGroupBox.Controls.Add(Me.beginningInventoryTextBox)
        Me.userInputGroupBox.Controls.Add(Me.Label1)
        Me.userInputGroupBox.Controls.Add(Me.Label2)
        Me.userInputGroupBox.Controls.Add(Me.endingInventoryTextBox)
        Me.userInputGroupBox.Controls.Add(Me.Label3)
        Me.userInputGroupBox.Controls.Add(Me.costOfGoodsTextBox)
        Me.userInputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.userInputGroupBox.Name = "userInputGroupBox"
        Me.userInputGroupBox.Size = New System.Drawing.Size(292, 244)
        Me.userInputGroupBox.TabIndex = 10
        Me.userInputGroupBox.TabStop = False
        '
        'outputGroupBox
        '
        Me.outputGroupBox.Controls.Add(Me.turnoverTextBox)
        Me.outputGroupBox.Controls.Add(Me.Label4)
        Me.outputGroupBox.Controls.Add(Me.avgInventoryTextBox)
        Me.outputGroupBox.Controls.Add(Me.Label5)
        Me.outputGroupBox.Location = New System.Drawing.Point(310, 12)
        Me.outputGroupBox.Name = "outputGroupBox"
        Me.outputGroupBox.Size = New System.Drawing.Size(292, 244)
        Me.outputGroupBox.TabIndex = 11
        Me.outputGroupBox.TabStop = False
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(12, 262)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(347, 100)
        Me.calculateButton.TabIndex = 12
        Me.calculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.calculateButton, "To calculate, click here, press Enter, or Alt+C")
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(367, 262)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(114, 100)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.clearButton, "To clear form, click here, press Esc, or Alt+L")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(487, 262)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(115, 100)
        Me.exitButton.TabIndex = 14
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "To Exit, click here, or press Alt+X")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
        '
        'Inventory_Calculator
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(617, 373)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.outputGroupBox)
        Me.Controls.Add(Me.userInputGroupBox)
        Me.Name = "Inventory_Calculator"
        Me.Text = "Inventory Calculator"
        Me.userInputGroupBox.ResumeLayout(False)
        Me.userInputGroupBox.PerformLayout()
        Me.outputGroupBox.ResumeLayout(False)
        Me.outputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents beginningInventoryTextBox As TextBox
    Friend WithEvents endingInventoryTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents costOfGoodsTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents avgInventoryTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents turnoverTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents userInputGroupBox As GroupBox
    Friend WithEvents outputGroupBox As GroupBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
