<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.StreetAddr = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.FirstNameLab = New System.Windows.Forms.Label()
        Me.LastNameLab = New System.Windows.Forms.Label()
        Me.StreetAddrLab = New System.Windows.Forms.Label()
        Me.CityLab = New System.Windows.Forms.Label()
        Me.StateLab = New System.Windows.Forms.Label()
        Me.ZipLab = New System.Windows.Forms.Label()
        Me.AddrLabel = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.MaskedTextBox()
        Me.ZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.DisplayLabel = New System.Windows.Forms.Button()
        Me.ClearForm = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(140, 54)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(248, 22)
        Me.FirstName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstName, "Pleaser Enter First Name")
        Me.FirstName.UseWaitCursor = True
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(140, 82)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(248, 22)
        Me.LastName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastName, "Please Enter Last Name")
        '
        'StreetAddr
        '
        Me.StreetAddr.Location = New System.Drawing.Point(140, 110)
        Me.StreetAddr.Name = "StreetAddr"
        Me.StreetAddr.Size = New System.Drawing.Size(248, 22)
        Me.StreetAddr.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.StreetAddr, "Please enter street address")
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(140, 138)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(248, 22)
        Me.City.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.City, "Please enter your City")
        '
        'FirstNameLab
        '
        Me.FirstNameLab.AutoSize = True
        Me.FirstNameLab.Location = New System.Drawing.Point(34, 57)
        Me.FirstNameLab.Name = "FirstNameLab"
        Me.FirstNameLab.Size = New System.Drawing.Size(76, 17)
        Me.FirstNameLab.TabIndex = 6
        Me.FirstNameLab.Text = "First Name"
        '
        'LastNameLab
        '
        Me.LastNameLab.AutoSize = True
        Me.LastNameLab.Location = New System.Drawing.Point(34, 85)
        Me.LastNameLab.Name = "LastNameLab"
        Me.LastNameLab.Size = New System.Drawing.Size(76, 17)
        Me.LastNameLab.TabIndex = 7
        Me.LastNameLab.Text = "Last Name"
        '
        'StreetAddrLab
        '
        Me.StreetAddrLab.AutoSize = True
        Me.StreetAddrLab.Location = New System.Drawing.Point(34, 113)
        Me.StreetAddrLab.Name = "StreetAddrLab"
        Me.StreetAddrLab.Size = New System.Drawing.Size(102, 17)
        Me.StreetAddrLab.TabIndex = 8
        Me.StreetAddrLab.Text = "Street Address"
        '
        'CityLab
        '
        Me.CityLab.AutoSize = True
        Me.CityLab.Location = New System.Drawing.Point(34, 141)
        Me.CityLab.Name = "CityLab"
        Me.CityLab.Size = New System.Drawing.Size(31, 17)
        Me.CityLab.TabIndex = 9
        Me.CityLab.Text = "City"
        '
        'StateLab
        '
        Me.StateLab.AutoSize = True
        Me.StateLab.Location = New System.Drawing.Point(34, 169)
        Me.StateLab.Name = "StateLab"
        Me.StateLab.Size = New System.Drawing.Size(41, 17)
        Me.StateLab.TabIndex = 10
        Me.StateLab.Text = "State"
        '
        'ZipLab
        '
        Me.ZipLab.AutoSize = True
        Me.ZipLab.Location = New System.Drawing.Point(34, 197)
        Me.ZipLab.Name = "ZipLab"
        Me.ZipLab.Size = New System.Drawing.Size(65, 17)
        Me.ZipLab.TabIndex = 11
        Me.ZipLab.Text = "Zip Code"
        '
        'AddrLabel
        '
        Me.AddrLabel.Location = New System.Drawing.Point(27, 42)
        Me.AddrLabel.Name = "AddrLabel"
        Me.AddrLabel.Size = New System.Drawing.Size(601, 170)
        Me.AddrLabel.TabIndex = 12
        Me.AddrLabel.Text = "Your Name"
        Me.ToolTip1.SetToolTip(Me.AddrLabel, "Displays your Address Label")
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(140, 166)
        Me.State.Mask = "AA"
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(248, 22)
        Me.State.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.State, "Please enter State abbreviation")
        '
        'ZipCode
        '
        Me.ZipCode.Location = New System.Drawing.Point(140, 194)
        Me.ZipCode.Mask = "00000"
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.Size = New System.Drawing.Size(248, 22)
        Me.ZipCode.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ZipCode, "Please enter Zip Code")
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(839, 391)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(132, 81)
        Me.DisplayLabel.TabIndex = 7
        Me.DisplayLabel.Text = "Display &Label"
        Me.ToolTip1.SetToolTip(Me.DisplayLabel, "To Display label Press Enter, Alt + L, or click here")
        Me.DisplayLabel.UseVisualStyleBackColor = True
        '
        'ClearForm
        '
        Me.ClearForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearForm.Location = New System.Drawing.Point(977, 391)
        Me.ClearForm.Name = "ClearForm"
        Me.ClearForm.Size = New System.Drawing.Size(132, 81)
        Me.ClearForm.TabIndex = 8
        Me.ClearForm.Text = "&Clear Form"
        Me.ToolTip1.SetToolTip(Me.ClearForm, "To Clear Form Press Esc, Alt + C, or click here")
        Me.ClearForm.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(1115, 391)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(132, 81)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "To Exit press Alt + X, and click here")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ZipCode)
        Me.GroupBox1.Controls.Add(Me.State)
        Me.GroupBox1.Controls.Add(Me.ZipLab)
        Me.GroupBox1.Controls.Add(Me.StateLab)
        Me.GroupBox1.Controls.Add(Me.CityLab)
        Me.GroupBox1.Controls.Add(Me.StreetAddrLab)
        Me.GroupBox1.Controls.Add(Me.LastNameLab)
        Me.GroupBox1.Controls.Add(Me.FirstNameLab)
        Me.GroupBox1.Controls.Add(Me.City)
        Me.GroupBox1.Controls.Add(Me.StreetAddr)
        Me.GroupBox1.Controls.Add(Me.LastName)
        Me.GroupBox1.Controls.Add(Me.FirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AddrLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(589, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 277)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'AddressLabel
        '
        Me.AcceptButton = Me.DisplayLabel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearForm
        Me.ClientSize = New System.Drawing.Size(1365, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearForm)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Name = "AddressLabel"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents StreetAddr As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents FirstNameLab As Label
    Friend WithEvents LastNameLab As Label
    Friend WithEvents StreetAddrLab As Label
    Friend WithEvents CityLab As Label
    Friend WithEvents StateLab As Label
    Friend WithEvents ZipLab As Label
    Friend WithEvents AddrLabel As Label
    Friend WithEvents State As MaskedTextBox
    Friend WithEvents ZipCode As MaskedTextBox
    Friend WithEvents DisplayLabel As Button
    Friend WithEvents ClearForm As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
