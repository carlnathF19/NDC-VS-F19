<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGrocery
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.inventoryListBox = New System.Windows.Forms.ListBox()
        Me.InventoryComboBox = New System.Windows.Forms.ComboBox()
        Me.lookupTextBox = New System.Windows.Forms.TextBox()
        Me.TextboxInventorySearchLabel = New System.Windows.Forms.Label()
        Me.searchTextBoxButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(560, 380)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(228, 58)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Press Alt+X or click here to exit")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'inventoryListBox
        '
        Me.inventoryListBox.FormattingEnabled = True
        Me.inventoryListBox.ItemHeight = 16
        Me.inventoryListBox.Location = New System.Drawing.Point(215, 91)
        Me.inventoryListBox.Name = "inventoryListBox"
        Me.inventoryListBox.Size = New System.Drawing.Size(583, 260)
        Me.inventoryListBox.TabIndex = 1
        '
        'InventoryComboBox
        '
        Me.InventoryComboBox.FormattingEnabled = True
        Me.InventoryComboBox.Location = New System.Drawing.Point(12, 170)
        Me.InventoryComboBox.Name = "InventoryComboBox"
        Me.InventoryComboBox.Size = New System.Drawing.Size(197, 24)
        Me.InventoryComboBox.TabIndex = 2
        '
        'lookupTextBox
        '
        Me.lookupTextBox.Location = New System.Drawing.Point(389, 63)
        Me.lookupTextBox.Name = "lookupTextBox"
        Me.lookupTextBox.Size = New System.Drawing.Size(197, 22)
        Me.lookupTextBox.TabIndex = 3
        '
        'TextboxInventorySearchLabel
        '
        Me.TextboxInventorySearchLabel.Location = New System.Drawing.Point(12, 91)
        Me.TextboxInventorySearchLabel.Name = "TextboxInventorySearchLabel"
        Me.TextboxInventorySearchLabel.Size = New System.Drawing.Size(197, 76)
        Me.TextboxInventorySearchLabel.TabIndex = 4
        Me.TextboxInventorySearchLabel.Text = "Groceries can also be selected in the drop down box, or the list box to the right" &
    "."
        '
        'searchTextBoxButton
        '
        Me.searchTextBoxButton.Location = New System.Drawing.Point(592, 63)
        Me.searchTextBoxButton.Name = "searchTextBoxButton"
        Me.searchTextBoxButton.Size = New System.Drawing.Size(75, 23)
        Me.searchTextBoxButton.TabIndex = 5
        Me.searchTextBoxButton.Text = "&Search"
        Me.searchTextBoxButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "What are you looking for?"
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchTextBoxButton)
        Me.Controls.Add(Me.TextboxInventorySearchLabel)
        Me.Controls.Add(Me.lookupTextBox)
        Me.Controls.Add(Me.InventoryComboBox)
        Me.Controls.Add(Me.inventoryListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "StansGrocery"
        Me.Text = "Stans Grocery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents inventoryListBox As ListBox
    Friend WithEvents InventoryComboBox As ComboBox
    Friend WithEvents lookupTextBox As TextBox
    Friend WithEvents TextboxInventorySearchLabel As Label
    Friend WithEvents searchTextBoxButton As Button
    Friend WithEvents Label1 As Label
End Class
