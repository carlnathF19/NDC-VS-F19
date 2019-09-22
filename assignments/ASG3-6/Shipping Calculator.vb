'Nathan Carlson
'RCET0265
'asg3-6
'Shipping Calculator
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/ASG3-6

Option Strict On
Option Explicit On

Public Class Form1
    Dim weightLbs As Integer
    Dim weightOzs As Integer
    Dim totalWeightInOz As Integer
    Dim shippingCost As Double
    Dim idCode As String
    Dim errorMessage As String

    'Reads in the data, checks to see if the data meets the textbox requirements, and concatenates a message
    'if there are any errors.  Then checks the errormessage, and if it is empty runs the calculation.
    'If the errormessage has content, it shows a messagebox with the data that needs to be replaced,
    'and moves focus to the topmost box in the tab order.
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Static shippingRate As Double
        idCode = shippingIdTextBox.Text
        totalWeightInOz = 0
        errorMessage = ""
        shippingRate = 0.12
        Try
            weightOzs = Integer.Parse(ozTextBox.Text)
        Catch ex As Exception
            errorMessage = "Please enter a whole number in the ozs box" & vbNewLine & errorMessage
            ozTextBox.Select()
        End Try

        Try
            weightLbs = Integer.Parse(lbsTextBox.Text)
        Catch ex As Exception
            errorMessage = "Please enter a whole number in the lbs box" & vbNewLine & errorMessage
            lbsTextBox.Select()
        End Try

        If errorMessage = "" Then
            totalWeightInOz = weightLbs * 16 + weightOzs
            shippingCost = totalWeightInOz * shippingRate
            shippingCostTextBox.Text = shippingCost.ToString("C")
        End If

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage)
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        weightLbs = 0
        weightOzs = 0
        totalWeightInOz = 0
        shippingCost = 0
        idCode = ""
        errorMessage = ""
        lbsTextBox.Text = ""
        ozTextBox.Text = ""
        shippingIdTextBox.Text = ""
        shippingCostTextBox.Text = ""
    End Sub


End Class
