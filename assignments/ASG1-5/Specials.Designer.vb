<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Specials
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
        Me.soupDayButton = New System.Windows.Forms.Button()
        Me.chefSpecButton = New System.Windows.Forms.Button()
        Me.fishButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.dinerName = New System.Windows.Forms.Label()
        Me.special = New System.Windows.Forms.Label()
        Me.signature = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'soupDayButton
        '
        Me.soupDayButton.Font = New System.Drawing.Font("Brush Script MT", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soupDayButton.Location = New System.Drawing.Point(109, 199)
        Me.soupDayButton.Name = "soupDayButton"
        Me.soupDayButton.Size = New System.Drawing.Size(221, 39)
        Me.soupDayButton.TabIndex = 0
        Me.soupDayButton.Text = "Soup of the Day"
        Me.soupDayButton.UseVisualStyleBackColor = True
        '
        'chefSpecButton
        '
        Me.chefSpecButton.Font = New System.Drawing.Font("Brush Script MT", 13.8!, System.Drawing.FontStyle.Italic)
        Me.chefSpecButton.Location = New System.Drawing.Point(109, 244)
        Me.chefSpecButton.Name = "chefSpecButton"
        Me.chefSpecButton.Size = New System.Drawing.Size(221, 39)
        Me.chefSpecButton.TabIndex = 1
        Me.chefSpecButton.Text = "Chef's Special"
        Me.chefSpecButton.UseVisualStyleBackColor = True
        '
        'fishButton
        '
        Me.fishButton.Font = New System.Drawing.Font("Brush Script MT", 13.8!, System.Drawing.FontStyle.Italic)
        Me.fishButton.Location = New System.Drawing.Point(109, 289)
        Me.fishButton.Name = "fishButton"
        Me.fishButton.Size = New System.Drawing.Size(221, 39)
        Me.fishButton.TabIndex = 2
        Me.fishButton.Text = "Daily Fish"
        Me.fishButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Brush Script MT", 13.8!, System.Drawing.FontStyle.Italic)
        Me.exitButton.Location = New System.Drawing.Point(737, 499)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(221, 39)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'dinerName
        '
        Me.dinerName.AutoSize = True
        Me.dinerName.Font = New System.Drawing.Font("Brush Script MT", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dinerName.Location = New System.Drawing.Point(32, 22)
        Me.dinerName.Name = "dinerName"
        Me.dinerName.Size = New System.Drawing.Size(352, 40)
        Me.dinerName.TabIndex = 4
        Me.dinerName.Text = "Nathan's Spaghetti && Toastery"
        '
        'special
        '
        Me.special.AutoSize = True
        Me.special.Font = New System.Drawing.Font("Brush Script MT", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.special.Location = New System.Drawing.Point(443, 199)
        Me.special.Name = "special"
        Me.special.Size = New System.Drawing.Size(198, 40)
        Me.special.TabIndex = 5
        Me.special.Text = "Select a Special"
        '
        'signature
        '
        Me.signature.AutoSize = True
        Me.signature.Font = New System.Drawing.Font("Brush Script MT", 19.8!, System.Drawing.FontStyle.Italic)
        Me.signature.Location = New System.Drawing.Point(730, 561)
        Me.signature.Name = "signature"
        Me.signature.Size = New System.Drawing.Size(186, 40)
        Me.signature.TabIndex = 6
        Me.signature.Text = "Nathan Carlson"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 619)
        Me.Controls.Add(Me.signature)
        Me.Controls.Add(Me.special)
        Me.Controls.Add(Me.dinerName)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.fishButton)
        Me.Controls.Add(Me.chefSpecButton)
        Me.Controls.Add(Me.soupDayButton)
        Me.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Nathan's Spaghetti & Toastery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents soupDayButton As Button
    Friend WithEvents chefSpecButton As Button
    Friend WithEvents fishButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents dinerName As Label
    Friend WithEvents special As Label
    Friend WithEvents signature As Label
End Class
