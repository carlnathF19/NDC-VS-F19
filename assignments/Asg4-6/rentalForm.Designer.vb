<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rentalForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.zipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.beginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.endOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.daysTextBox = New System.Windows.Forms.TextBox()
        Me.OdometerGroupBox = New System.Windows.Forms.GroupBox()
        Me.kilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.milesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.seniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.aaaCheckBox = New System.Windows.Forms.CheckBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.milesDrivenLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mileChargeLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dayChargeLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.youOweLabel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.OdometerGroupBox.SuspendLayout()
        Me.DiscountGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer &Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C&ity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "&Beginning Odometer Reading"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "&Ending Odometer Reading"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 266)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "N&umber of Days"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(213, 20)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.nameTextBox.TabIndex = 1
        Me.nameTextBox.Text = "Nathan Carlson"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(213, 54)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(132, 22)
        Me.addressTextBox.TabIndex = 3
        Me.addressTextBox.Text = "Address"
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(213, 89)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(132, 22)
        Me.cityTextBox.TabIndex = 5
        Me.cityTextBox.Text = "City"
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(213, 123)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(132, 22)
        Me.stateTextBox.TabIndex = 7
        Me.stateTextBox.Text = "ID"
        '
        'zipCodeTextBox
        '
        Me.zipCodeTextBox.Location = New System.Drawing.Point(213, 158)
        Me.zipCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.zipCodeTextBox.Name = "zipCodeTextBox"
        Me.zipCodeTextBox.Size = New System.Drawing.Size(132, 22)
        Me.zipCodeTextBox.TabIndex = 9
        Me.zipCodeTextBox.Text = "83201"
        '
        'beginOdometerTextBox
        '
        Me.beginOdometerTextBox.Location = New System.Drawing.Point(213, 192)
        Me.beginOdometerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.beginOdometerTextBox.Name = "beginOdometerTextBox"
        Me.beginOdometerTextBox.Size = New System.Drawing.Size(132, 22)
        Me.beginOdometerTextBox.TabIndex = 11
        Me.beginOdometerTextBox.Text = "0"
        '
        'endOdometerTextBox
        '
        Me.endOdometerTextBox.Location = New System.Drawing.Point(213, 226)
        Me.endOdometerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.endOdometerTextBox.Name = "endOdometerTextBox"
        Me.endOdometerTextBox.Size = New System.Drawing.Size(132, 22)
        Me.endOdometerTextBox.TabIndex = 13
        Me.endOdometerTextBox.Text = "650"
        '
        'daysTextBox
        '
        Me.daysTextBox.Location = New System.Drawing.Point(213, 261)
        Me.daysTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.daysTextBox.Name = "daysTextBox"
        Me.daysTextBox.Size = New System.Drawing.Size(132, 22)
        Me.daysTextBox.TabIndex = 15
        Me.daysTextBox.Text = "3"
        '
        'OdometerGroupBox
        '
        Me.OdometerGroupBox.Controls.Add(Me.kilometersRadioButton)
        Me.OdometerGroupBox.Controls.Add(Me.milesRadioButton)
        Me.OdometerGroupBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OdometerGroupBox.Location = New System.Drawing.Point(11, 300)
        Me.OdometerGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OdometerGroupBox.Name = "OdometerGroupBox"
        Me.OdometerGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.OdometerGroupBox.Size = New System.Drawing.Size(416, 103)
        Me.OdometerGroupBox.TabIndex = 16
        Me.OdometerGroupBox.TabStop = False
        Me.OdometerGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        '
        'kilometersRadioButton
        '
        Me.kilometersRadioButton.AutoSize = True
        Me.kilometersRadioButton.Location = New System.Drawing.Point(27, 64)
        Me.kilometersRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.kilometersRadioButton.Name = "kilometersRadioButton"
        Me.kilometersRadioButton.Size = New System.Drawing.Size(130, 24)
        Me.kilometersRadioButton.TabIndex = 1
        Me.kilometersRadioButton.Text = "&Kilometers"
        Me.kilometersRadioButton.UseVisualStyleBackColor = True
        '
        'milesRadioButton
        '
        Me.milesRadioButton.AutoSize = True
        Me.milesRadioButton.Checked = True
        Me.milesRadioButton.Location = New System.Drawing.Point(27, 30)
        Me.milesRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.milesRadioButton.Name = "milesRadioButton"
        Me.milesRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.milesRadioButton.TabIndex = 0
        Me.milesRadioButton.TabStop = True
        Me.milesRadioButton.Text = "&Miles"
        Me.milesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupBox
        '
        Me.DiscountGroupBox.Controls.Add(Me.seniorCheckBox)
        Me.DiscountGroupBox.Controls.Add(Me.aaaCheckBox)
        Me.DiscountGroupBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountGroupBox.Location = New System.Drawing.Point(469, 300)
        Me.DiscountGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscountGroupBox.Name = "DiscountGroupBox"
        Me.DiscountGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.DiscountGroupBox.Size = New System.Drawing.Size(320, 103)
        Me.DiscountGroupBox.TabIndex = 17
        Me.DiscountGroupBox.TabStop = False
        Me.DiscountGroupBox.Text = "Enter Any Discounts"
        '
        'seniorCheckBox
        '
        Me.seniorCheckBox.AutoSize = True
        Me.seniorCheckBox.Location = New System.Drawing.Point(27, 69)
        Me.seniorCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.seniorCheckBox.Name = "seniorCheckBox"
        Me.seniorCheckBox.Size = New System.Drawing.Size(261, 24)
        Me.seniorCheckBox.TabIndex = 1
        Me.seniorCheckBox.Text = "Seni&or Citizen Discount"
        Me.seniorCheckBox.UseVisualStyleBackColor = True
        '
        'aaaCheckBox
        '
        Me.aaaCheckBox.AutoSize = True
        Me.aaaCheckBox.Location = New System.Drawing.Point(27, 34)
        Me.aaaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.aaaCheckBox.Name = "aaaCheckBox"
        Me.aaaCheckBox.Size = New System.Drawing.Size(221, 24)
        Me.aaaCheckBox.TabIndex = 0
        Me.aaaCheckBox.Text = "AAA Member &Discount"
        Me.aaaCheckBox.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(171, 468)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 28)
        Me.calculateButton.TabIndex = 18
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(293, 468)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 28)
        Me.clearButton.TabIndex = 19
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(544, 468)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 28)
        Me.exitButton.TabIndex = 20
        Me.exitButton.TabStop = False
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(389, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Distance Driven In Miles"
        '
        'milesDrivenLabel
        '
        Me.milesDrivenLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.milesDrivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.milesDrivenLabel.Location = New System.Drawing.Point(672, 20)
        Me.milesDrivenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.milesDrivenLabel.Name = "milesDrivenLabel"
        Me.milesDrivenLabel.Size = New System.Drawing.Size(170, 29)
        Me.milesDrivenLabel.TabIndex = 23
        Me.milesDrivenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 64)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Mileage Charge"
        '
        'mileChargeLabel
        '
        Me.mileChargeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mileChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mileChargeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mileChargeLabel.Location = New System.Drawing.Point(672, 59)
        Me.mileChargeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mileChargeLabel.Name = "mileChargeLabel"
        Me.mileChargeLabel.Size = New System.Drawing.Size(170, 29)
        Me.mileChargeLabel.TabIndex = 25
        Me.mileChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(389, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Day Charge"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(389, 143)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Minus Discount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(389, 182)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "You Owe"
        '
        'dayChargeLabel
        '
        Me.dayChargeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dayChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dayChargeLabel.Location = New System.Drawing.Point(672, 98)
        Me.dayChargeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dayChargeLabel.Name = "dayChargeLabel"
        Me.dayChargeLabel.Size = New System.Drawing.Size(170, 29)
        Me.dayChargeLabel.TabIndex = 27
        Me.dayChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'discountLabel
        '
        Me.discountLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Location = New System.Drawing.Point(672, 138)
        Me.discountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(170, 29)
        Me.discountLabel.TabIndex = 29
        Me.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'youOweLabel
        '
        Me.youOweLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.youOweLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.youOweLabel.Location = New System.Drawing.Point(672, 177)
        Me.youOweLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.youOweLabel.Name = "youOweLabel"
        Me.youOweLabel.Size = New System.Drawing.Size(170, 29)
        Me.youOweLabel.TabIndex = 31
        Me.youOweLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(363, 226)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(496, 4)
        Me.Label18.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(363, 5)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(4, 222)
        Me.Label19.TabIndex = 21
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(421, 468)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(100, 28)
        Me.summaryButton.TabIndex = 33
        Me.summaryButton.Text = "Summar&y"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'rentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 538)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.youOweLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.dayChargeLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mileChargeLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.milesDrivenLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.DiscountGroupBox)
        Me.Controls.Add(Me.OdometerGroupBox)
        Me.Controls.Add(Me.daysTextBox)
        Me.Controls.Add(Me.endOdometerTextBox)
        Me.Controls.Add(Me.beginOdometerTextBox)
        Me.Controls.Add(Me.zipCodeTextBox)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "rentalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Car Rental Service"
        Me.OdometerGroupBox.ResumeLayout(False)
        Me.OdometerGroupBox.PerformLayout()
        Me.DiscountGroupBox.ResumeLayout(False)
        Me.DiscountGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents beginOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents endOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents daysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OdometerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents kilometersRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents milesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DiscountGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents seniorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents aaaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents milesDrivenLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mileChargeLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dayChargeLabel As System.Windows.Forms.Label
    Friend WithEvents discountLabel As System.Windows.Forms.Label
    Friend WithEvents youOweLabel As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents summaryButton As System.Windows.Forms.Button
End Class
