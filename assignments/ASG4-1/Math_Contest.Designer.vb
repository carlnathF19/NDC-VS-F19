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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ageMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.gradeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(669, 36)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(78, 30)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "&Submit"
        Me.ToolTip1.SetToolTip(Me.submitButton, "Click here to Submit Answer, or press Alt+S or Enter")
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(669, 65)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(78, 30)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click here to Clear fields, or press Alt+C or Escape")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(669, 94)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(78, 30)
        Me.summaryButton.TabIndex = 2
        Me.summaryButton.Text = "Su&mmary"
        Me.ToolTip1.SetToolTip(Me.summaryButton, "Click here to get a Summary, or press Alt+m")
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(669, 123)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(78, 30)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Click here to Exit the program, or press Alt+x")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ageMaskedTextBox
        '
        Me.ageMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ageMaskedTextBox.Location = New System.Drawing.Point(451, 56)
        Me.ageMaskedTextBox.Mask = "00"
        Me.ageMaskedTextBox.Name = "ageMaskedTextBox"
        Me.ageMaskedTextBox.Size = New System.Drawing.Size(30, 22)
        Me.ageMaskedTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ageMaskedTextBox, "Enter the students age")
        '
        'gradeMaskedTextBox
        '
        Me.gradeMaskedTextBox.Location = New System.Drawing.Point(505, 56)
        Me.gradeMaskedTextBox.Mask = "0"
        Me.gradeMaskedTextBox.Name = "gradeMaskedTextBox"
        Me.gradeMaskedTextBox.Size = New System.Drawing.Size(30, 22)
        Me.gradeMaskedTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.gradeMaskedTextBox, "Enter the student's Grade level")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(448, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gradeMaskedTextBox)
        Me.Controls.Add(Me.ageMaskedTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.submitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ageMaskedTextBox As MaskedTextBox
    Friend WithEvents gradeMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
