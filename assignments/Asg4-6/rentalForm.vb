'Nathan Carlson
'RCET0265
'asg4-6
'Rental Form
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/Asg4-6

Option Strict On
Option Explicit On

Public Class rentalForm
    Dim cost As Double = 0
    Dim miles As Double
    Dim days As Integer
    Dim totalMiles As Double '= 0
    Dim totalMileCharge As Double '= 0
    Dim totalDays As Integer '= 0
    Dim totalDayCharge As Double '= 0
    Dim totalDiscount As Double '= 0
    Dim totalPaid As Double '= 0
    Dim customers As Integer '= 0

    Dim validValues As Boolean
    'This Sub sets the label text color to a visible color if validation returns true, to same as
    'background color if false, so previous values aren't visible.
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
    'This subroutine checks to see if Discounts apply and modify the global variable cost.
    'Cost and miles each update a global variable passed to the summary subroutine.
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
        'Adds to totals summary
        totalDiscount += discountAmount
        discountLabel.Text = discountAmount.ToString("C")
        cost = (1 - discountMultiplier) * cost
    End Sub
    'This subroutine checks each value, starting with the last in the Tab Index and ending with the 
    'first, if any returns false, then the last one to return false takes focus.  Also uses tries
    'to see if values parse correctly.
    Private Sub ValidateFields()
        Dim summaryLocal As String
        Dim zipCodeValid As Boolean = True

        summaryLocal = ""
        validValues = False
        Try
            days = Integer.Parse(daysTextBox.Text)
            If days > 45 Or days < 1 Then
                MessageBox.Show("Please enter valid number of days, (0 to 45)")
                daysTextBox.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter valid number of days, (0 to 45)")
            daysTextBox.Select()
        End Try

        Try
            miles = Double.Parse(endOdometerTextBox.Text) - Double.Parse(beginOdometerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid odometer values")
            beginOdometerTextBox.Select()
        End Try

        Try
            Integer.Parse(zipCodeTextBox.Text)
        Catch ex As Exception
            zipCodeValid = False
        End Try

        If zipCodeTextBox.Text.Length() <> 5 Or zipCodeValid = False Then
            summaryLocal = "Please enter a 5 digit zip code." & vbNewLine & summaryLocal
            zipCodeTextBox.Select()
        End If

        If stateTextBox.Text.Length() <> 2 Then
            summaryLocal = "Please enter a state abbreviation." & vbNewLine & summaryLocal
            stateTextBox.Select()
        End If

        If cityTextBox.Text.Length() = 0 Then
            summaryLocal = "Please enter a City." & vbNewLine & summaryLocal
            cityTextBox.Select()
        End If

        If addressTextBox.Text.Length() = 0 Then
            summaryLocal = "Please enter an Address." & vbNewLine & summaryLocal
            addressTextBox.Select()
        End If

        If nameTextBox.Text.Length() = 0 Then
            summaryLocal = "Please enter a Name." & vbNewLine & summaryLocal
            nameTextBox.Select()
        End If

        If summaryLocal <> "" Then
            MessageBox.Show(summaryLocal)
        Else validValues = True
        End If
    End Sub
    'This subroutine exits if a yes no message box receives a yes click
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.YesNo) _
            = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim dayCharge As Integer
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
            'Adds the total miles to the summary sub through global variable.
            totalMiles += miles

            If miles >= 201 And miles <= 500 Then
                cost = (miles - 200) * 0.12
            ElseIf miles > 500 Then
                'If miles > 500 then 300 of those miles (500-200) are at the .12 price
                cost = (miles - 500) * 0.1 + (300 * 0.12)
            End If

            totalMileCharge += cost

            'cost += days*15 did not work, so a local variable is declared, and then passed 
            'to cost.  Programattically, cost += should work, but it didn't?

            Dim costLocal As Double = cost

            mileChargeLabel.Text = cost.ToString("C")
            dayCharge = days * 15
            'Adds to totals summary
            totalDays += days
            totalDayCharge += dayCharge
            costLocal = cost + dayCharge
            cost = costLocal
            dayChargeLabel.Text = dayCharge.ToString("C")

            checkDiscount()
            'Adds to totals summary
            totalPaid += cost
            customers += 1
            youOweLabel.Text = cost.ToString("C")
            Console.WriteLine(cost)
            summaryButton.Enabled = True
        End If

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        Dim totalsSummary As String
        totalsSummary = "Distance Driven = " & totalMiles & vbNewLine &
            "Mileage Charge = " & totalMileCharge.ToString("C") & vbNewLine &
            "Total Days Rented = " & totalDays & vbNewLine &
            "Total Day Charge = " & totalDayCharge.ToString("C") & vbNewLine &
            "Total Discounts = " & totalDiscount.ToString("C") & vbNewLine &
            "Total Paid = " & totalPaid.ToString("C") & vbNewLine &
            "Customers = " & customers
        MessageBox.Show(totalsSummary)

    End Sub

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        summaryButton.Enabled = False
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipCodeTextBox.Clear()
        beginOdometerTextBox.Clear()
        endOdometerTextBox.Clear()
        daysTextBox.Clear()
    End Sub

End Class
