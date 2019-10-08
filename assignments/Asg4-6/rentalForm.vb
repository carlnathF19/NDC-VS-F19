Option Strict On
Option Explicit On

Public Class rentalForm
    Dim cost As Double = 0
    Dim miles As Double
    Dim days As Integer
    Dim dayCharge As Integer
    Dim validValues As Boolean
    Private Sub ClearForm()

    End Sub
    Private Sub SetLabelForeColor()
        If validValues Then
            milesDrivenLabel.ForeColor = Color.White
            mileChargeLabel.ForeColor = Color.White
            dayChargeLabel.ForeColor = Color.White
            discountLabel.ForeColor = Color.White
            youOweLabel.ForeColor = Color.White
        Else
            milesDrivenLabel.ForeColor = Color.Black
            mileChargeLabel.ForeColor = Color.Black
            dayChargeLabel.ForeColor = Color.Black
            discountLabel.ForeColor = Color.Black
            youOweLabel.ForeColor = Color.Black
        End If

    End Sub
    Private Sub checkDiscount()
        Dim discountMultiplier As Double = 0
        Dim discountAmount As Double = 0
        If aaaCheckBox.Checked Then
            discountMultiplier += 0.05
        End If
        If seniorCheckBox.Checked Then
            discountMultiplier += 0.03
        End If
        discountAmount = discountMultiplier * cost
        discountLabel.Text = discountAmount.ToString("C")
        cost = (1 - discountMultiplier) * cost
    End Sub

    Private Sub ValidateFields()
        Dim summary As String

        summary = ""
        validValues = False
        Try
            days = Integer.Parse(daysTextBox.Text)
        Catch ex As Exception

        End Try
        '[review code]
        Try
            miles = Double.Parse(endOdometerTextBox.Text) - Double.Parse(beginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid odometer values")
            beginOdometerTextBox.Select()
        End Try

        If zipCodeTextBox.Text.Length() <> 5 Then
            summary = "Please enter a 5 digit zip code." & vbNewLine & summary
            zipCodeTextBox.Select()
        End If

        If stateTextBox.Text.Length() <> 2 Then
            summary = "Please enter a state abbreviation." & vbNewLine & summary
            stateTextBox.Select()
        End If

        If cityTextBox.Text.Length() = 0 Then
            summary = "Please enter a City." & vbNewLine & summary
            cityTextBox.Select()
        End If

        If addressTextBox.Text.Length() = 0 Then
            summary = "Please enter an Address." & vbNewLine & summary
            addressTextBox.Select()
        End If

        If nameTextBox.Text.Length() = 0 Then
            summary = "Please enter a Name." & vbNewLine & summary
            nameTextBox.Select()
        End If

        If summary <> "" Then
            MessageBox.Show(summary)
        Else validValues = True
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        ValidateFields()
        SetLabelForeColor()

        If validValues Then
            If miles > 0 Then

            Else
                MessageBox.Show("Please enter valid odometer values, end reading must be " &
                                "greater than beginning reading.")
                beginOdometerTextBox.Select()
            End If

            'If kilometers is checked then the same variable is used to convert to miles, the reading in km is stored
            'in the miles button and converted via *= .62 to miles
            If kilometersRadioButton.Checked = True Then
                miles *= 0.62
            End If
            milesDrivenLabel.Text = Convert.ToString(miles)
            If miles >= 201 And miles <= 500 Then
                cost = (miles - 200) * 0.12
            ElseIf miles > 500 Then
                'If miles > 500 then 300 of those miles (500-200) are at the .12 price
                cost = (miles - 500) * 0.1 + (300 * 0.12)
            End If

            'cost += days*15 did not work, so a local variable is declared, and then passed 
            'to cost.  Programattically, cost += should work, but it didn't?

            Dim costLocal As Double = cost

            mileChargeLabel.Text = cost.ToString("C")
            dayCharge = days * 15
            costLocal = cost + dayCharge
            cost = costLocal
            dayChargeLabel.Text = dayCharge.ToString("C")

            checkDiscount()

            youOweLabel.Text = cost.ToString("C")
            Console.WriteLine(cost)
        End If

    End Sub

    'Sub testValidateString()
    '    Dim mystring As String
    '    mystring = "Hello"
    '    Console.WriteLine(mystring)
    '    Console.WriteLine(mystring.GetType.Name)
    '    ValidateString(mystring, "String", isValid)
    'End Sub
    'Private Sub ValidateString(ByVal testString As String, ByVal testType As String, ByRef isValid As Boolean)
    '    'validate string to see if it is of type
    '    If testString.GetType.Name = testType Then
    '        isValid = True
    '    Else
    '        isValid = False
    '    End If
    'End Sub

    'Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
    '    testValidateString()
    'End Sub

End Class
