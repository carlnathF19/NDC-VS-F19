<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomNumGenerator
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
        Me.randomNumListBox = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerateNumbersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.genRandNumButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'randomNumListBox
        '
        Me.randomNumListBox.FormattingEnabled = True
        Me.randomNumListBox.ItemHeight = 16
        Me.randomNumListBox.Location = New System.Drawing.Point(0, 31)
        Me.randomNumListBox.Name = "randomNumListBox"
        Me.randomNumListBox.Size = New System.Drawing.Size(576, 340)
        Me.randomNumListBox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateNumbersToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 28)
        '
        'GenerateNumbersToolStripMenuItem1
        '
        Me.GenerateNumbersToolStripMenuItem1.Name = "GenerateNumbersToolStripMenuItem1"
        Me.GenerateNumbersToolStripMenuItem1.Size = New System.Drawing.Size(202, 24)
        Me.GenerateNumbersToolStripMenuItem1.Text = "&Generate Numbers"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(575, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateNumbersToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'GenerateNumbersToolStripMenuItem
        '
        Me.GenerateNumbersToolStripMenuItem.Name = "GenerateNumbersToolStripMenuItem"
        Me.GenerateNumbersToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.GenerateNumbersToolStripMenuItem.Text = "&Generate Numbers"
        '
        'genRandNumButton
        '
        Me.genRandNumButton.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genRandNumButton.Location = New System.Drawing.Point(171, 377)
        Me.genRandNumButton.Name = "genRandNumButton"
        Me.genRandNumButton.Size = New System.Drawing.Size(245, 61)
        Me.genRandNumButton.TabIndex = 3
        Me.genRandNumButton.Text = "Generate &Random Numbers"
        Me.genRandNumButton.UseVisualStyleBackColor = True
        '
        'RandomNumGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 450)
        Me.Controls.Add(Me.genRandNumButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.randomNumListBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RandomNumGenerator"
        Me.Text = "Random Number Generator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents randomNumListBox As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateNumbersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents genRandNumButton As Button
End Class
