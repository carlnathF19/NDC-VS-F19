<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class State_Flag_Viewer
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlaskaButton = New System.Windows.Forms.Button()
        Me.IndianaButton = New System.Windows.Forms.Button()
        Me.UtahButton = New System.Windows.Forms.Button()
        Me.VermontButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.State_Flag_Viewer_Program.My.Resources.Resources.Flag_of_Alaska
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(578, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AlaskaButton
        '
        Me.AlaskaButton.Location = New System.Drawing.Point(6, 365)
        Me.AlaskaButton.Name = "AlaskaButton"
        Me.AlaskaButton.Size = New System.Drawing.Size(140, 107)
        Me.AlaskaButton.TabIndex = 1
        Me.AlaskaButton.Text = "&Alaska"
        Me.ToolTip1.SetToolTip(Me.AlaskaButton, "To display Alaska's Flag press Alt+A, or click here")
        Me.AlaskaButton.UseVisualStyleBackColor = True
        '
        'IndianaButton
        '
        Me.IndianaButton.Location = New System.Drawing.Point(152, 365)
        Me.IndianaButton.Name = "IndianaButton"
        Me.IndianaButton.Size = New System.Drawing.Size(140, 107)
        Me.IndianaButton.TabIndex = 2
        Me.IndianaButton.Text = "&Indiana"
        Me.ToolTip1.SetToolTip(Me.IndianaButton, "To display Indiana's Flag press Alt+I, or click here")
        Me.IndianaButton.UseVisualStyleBackColor = True
        '
        'UtahButton
        '
        Me.UtahButton.Location = New System.Drawing.Point(298, 365)
        Me.UtahButton.Name = "UtahButton"
        Me.UtahButton.Size = New System.Drawing.Size(140, 107)
        Me.UtahButton.TabIndex = 3
        Me.UtahButton.Text = "&Utah"
        Me.ToolTip1.SetToolTip(Me.UtahButton, "To display Utah's Flag press Alt+U, or click here")
        Me.UtahButton.UseVisualStyleBackColor = True
        '
        'VermontButton
        '
        Me.VermontButton.Location = New System.Drawing.Point(444, 365)
        Me.VermontButton.Name = "VermontButton"
        Me.VermontButton.Size = New System.Drawing.Size(140, 107)
        Me.VermontButton.TabIndex = 4
        Me.VermontButton.Text = "&Vermont"
        Me.ToolTip1.SetToolTip(Me.VermontButton, "To display Vermont's Flag press Alt+V, or click here")
        Me.VermontButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(6, 478)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(578, 107)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "To Exit press Alt+X, or click here")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'State_Flag_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(591, 592)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.VermontButton)
        Me.Controls.Add(Me.UtahButton)
        Me.Controls.Add(Me.IndianaButton)
        Me.Controls.Add(Me.AlaskaButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "State_Flag_Viewer"
        Me.Tag = ""
        Me.Text = "State Flag Viewer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AlaskaButton As Button
    Friend WithEvents IndianaButton As Button
    Friend WithEvents UtahButton As Button
    Friend WithEvents VermontButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ExitButton As Button
End Class
