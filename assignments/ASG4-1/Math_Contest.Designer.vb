<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Math_Contest
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
        Me.submitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ageMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.gradeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.addRadioButton = New System.Windows.Forms.RadioButton()
        Me.subtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.divideRadioButton = New System.Windows.Forms.RadioButton()
        Me.multiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.studentNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.secondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.studentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'submitButton
        '
        Me.submitButton.Enabled = False
        Me.submitButton.Location = New System.Drawing.Point(6, 28)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(151, 64)
        Me.submitButton.TabIndex = 8
        Me.submitButton.Text = "&Submit"
        Me.ToolTip1.SetToolTip(Me.submitButton, "Click here to Submit Answer, or press Alt+S or Enter")
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Enabled = False
        Me.clearButton.Location = New System.Drawing.Point(6, 103)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(151, 64)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.clearButton, "Click here to Clear fields, or press Alt+C or Escape")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Enabled = False
        Me.summaryButton.Location = New System.Drawing.Point(6, 177)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(151, 64)
        Me.summaryButton.TabIndex = 10
        Me.summaryButton.Text = "Su&mmary"
        Me.ToolTip1.SetToolTip(Me.summaryButton, "Click here to get a Summary, or press Alt+m")
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Enabled = False
        Me.exitButton.Location = New System.Drawing.Point(6, 255)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(151, 64)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Click here to Exit the program, or press Alt+x")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ageMaskedTextBox
        '
        Me.ageMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ageMaskedTextBox.Enabled = False
        Me.ageMaskedTextBox.Location = New System.Drawing.Point(297, 53)
        Me.ageMaskedTextBox.Mask = "99"
        Me.ageMaskedTextBox.Name = "ageMaskedTextBox"
        Me.ageMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ageMaskedTextBox.Size = New System.Drawing.Size(30, 22)
        Me.ageMaskedTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ageMaskedTextBox, "Enter the students age")
        '
        'gradeMaskedTextBox
        '
        Me.gradeMaskedTextBox.Enabled = False
        Me.gradeMaskedTextBox.Location = New System.Drawing.Point(333, 53)
        Me.gradeMaskedTextBox.Mask = "0"
        Me.gradeMaskedTextBox.Name = "gradeMaskedTextBox"
        Me.gradeMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.gradeMaskedTextBox.Size = New System.Drawing.Size(30, 22)
        Me.gradeMaskedTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.gradeMaskedTextBox, "Enter the student's Grade level")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grade"
        '
        'addRadioButton
        '
        Me.addRadioButton.AutoSize = True
        Me.addRadioButton.Enabled = False
        Me.addRadioButton.Location = New System.Drawing.Point(66, 68)
        Me.addRadioButton.Name = "addRadioButton"
        Me.addRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.addRadioButton.TabIndex = 3
        Me.addRadioButton.TabStop = True
        Me.addRadioButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.addRadioButton, "Select for addition problem")
        Me.addRadioButton.UseVisualStyleBackColor = True
        '
        'subtractRadioButton
        '
        Me.subtractRadioButton.AutoSize = True
        Me.subtractRadioButton.Enabled = False
        Me.subtractRadioButton.Location = New System.Drawing.Point(66, 95)
        Me.subtractRadioButton.Name = "subtractRadioButton"
        Me.subtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.subtractRadioButton.TabIndex = 4
        Me.subtractRadioButton.TabStop = True
        Me.subtractRadioButton.Text = "Subtract"
        Me.ToolTip1.SetToolTip(Me.subtractRadioButton, "Select for subtraction problem")
        Me.subtractRadioButton.UseVisualStyleBackColor = True
        '
        'divideRadioButton
        '
        Me.divideRadioButton.AutoSize = True
        Me.divideRadioButton.Enabled = False
        Me.divideRadioButton.Location = New System.Drawing.Point(66, 149)
        Me.divideRadioButton.Name = "divideRadioButton"
        Me.divideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.divideRadioButton.TabIndex = 6
        Me.divideRadioButton.TabStop = True
        Me.divideRadioButton.Text = "Divide"
        Me.ToolTip1.SetToolTip(Me.divideRadioButton, "Select for division problem")
        Me.divideRadioButton.UseVisualStyleBackColor = True
        '
        'multiplyRadioButton
        '
        Me.multiplyRadioButton.AutoSize = True
        Me.multiplyRadioButton.Enabled = False
        Me.multiplyRadioButton.Location = New System.Drawing.Point(66, 122)
        Me.multiplyRadioButton.Name = "multiplyRadioButton"
        Me.multiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.multiplyRadioButton.TabIndex = 5
        Me.multiplyRadioButton.TabStop = True
        Me.multiplyRadioButton.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.multiplyRadioButton, "Select for multiplication problem")
        Me.multiplyRadioButton.UseVisualStyleBackColor = True
        '
        'studentNameTextBox
        '
        Me.studentNameTextBox.Location = New System.Drawing.Point(45, 53)
        Me.studentNameTextBox.Name = "studentNameTextBox"
        Me.studentNameTextBox.Size = New System.Drawing.Size(246, 22)
        Me.studentNameTextBox.TabIndex = 0
        '
        'firstNumberTextBox
        '
        Me.firstNumberTextBox.Enabled = False
        Me.firstNumberTextBox.Location = New System.Drawing.Point(45, 66)
        Me.firstNumberTextBox.Name = "firstNumberTextBox"
        Me.firstNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.firstNumberTextBox.TabIndex = 12
        '
        'secondNumberTextBox
        '
        Me.secondNumberTextBox.Enabled = False
        Me.secondNumberTextBox.Location = New System.Drawing.Point(45, 119)
        Me.secondNumberTextBox.Name = "secondNumberTextBox"
        Me.secondNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.secondNumberTextBox.TabIndex = 13
        '
        'studentAnswerTextBox
        '
        Me.studentAnswerTextBox.Enabled = False
        Me.studentAnswerTextBox.Location = New System.Drawing.Point(45, 177)
        Me.studentAnswerTextBox.Name = "studentAnswerTextBox"
        Me.studentAnswerTextBox.Size = New System.Drawing.Size(100, 22)
        Me.studentAnswerTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "1st Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "2nd Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Student Answer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ageMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.gradeMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.studentNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.firstNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.secondNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.studentAnswerTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 219)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Math Problem"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.addRadioButton)
        Me.GroupBox3.Controls.Add(Me.subtractRadioButton)
        Me.GroupBox3.Controls.Add(Me.multiplyRadioButton)
        Me.GroupBox3.Controls.Add(Me.divideRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(243, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 219)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Math Problem Type"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.submitButton)
        Me.GroupBox4.Controls.Add(Me.clearButton)
        Me.GroupBox4.Controls.Add(Me.summaryButton)
        Me.GroupBox4.Controls.Add(Me.exitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(449, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(163, 330)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'Math_Contest
        '
        Me.AcceptButton = Me.submitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Math_Contest"
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents submitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ageMaskedTextBox As MaskedTextBox
    Friend WithEvents gradeMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addRadioButton As RadioButton
    Friend WithEvents subtractRadioButton As RadioButton
    Friend WithEvents divideRadioButton As RadioButton
    Friend WithEvents multiplyRadioButton As RadioButton
    Friend WithEvents studentNameTextBox As TextBox
    Friend WithEvents firstNumberTextBox As TextBox
    Friend WithEvents secondNumberTextBox As TextBox
    Friend WithEvents studentAnswerTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
