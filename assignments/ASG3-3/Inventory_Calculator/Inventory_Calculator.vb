'Nathan Carlson
'RCET0265
'asg3-3
'Inventory Calculator
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/ASG3-3/Inventory_Calculator

Option Explicit On
Option Strict On
Public Class Inventory_Calculator
    Dim startInv As Integer
    Dim endInv As Integer
    'costOfGoods, avgInv, and turnover must be declared as double.  Currency is a double unit; avgInv, and turnover
    'are results of division.  CostofGoods being static allows another Sub to change textbox format.
    Dim costOfGoods As Double
    Dim avgInv As Double
    Dim turnover As Double
    Dim errorMessage As String

    'When calculate is clicked a series of codes execute to calculate avgInv and turnover while catching
    'invalid user input.
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'sets errorMessage to empty
        errorMessage = ""

        'attempts to parse cost of goods text into a double, if it fails it puts a message with desired text 
        'in the box, displays an errormessage and adds the bottommost line of the variable passed to the 
        'messagebox.  Also selects the bottommost box if input is invalid
        Try
            costOfGoods = Double.Parse(costOfGoodsTextBox.Text)
            costOfGoodsTextBox.Text = costOfGoods.ToString("C")
        Catch ex As Exception


            costOfGoodsTextBox.Text = "Please enter currency with no $"
                costOfGoodsTextBox.Select()
                errorMessage = "Please enter currency with no $" & vbNewLine & errorMessage

        End Try
        'each of these has the same function for their individual textbox as described in the previous comment 
        'but selects the current box, by running the bottommost box first, and the code execution from top
        'to bottom this results in the focus on the highest box with an error.
        Try
            endInv = Integer.Parse(endingInventoryTextBox.Text)
        Catch ex As Exception
            endingInventoryTextBox.Text = "Please enter only Whole Numbers in Ending Inventory"
            endingInventoryTextBox.Select()
            errorMessage = "Please enter only Whole Numbers" & vbNewLine & errorMessage
        End Try
        'each of these has the same function for their individual textbox as described in the previous comment
        Try
            startInv = Integer.Parse(beginningInventoryTextBox.Text)
        Catch ex As Exception
            beginningInventoryTextBox.Text = "Please enter only Whole Numbers in Beginning Inventory"
            beginningInventoryTextBox.Select()
            errorMessage = "Please enter only Whole Numbers" & vbNewLine & errorMessage
        End Try

        'if errorMessage is not empty, a messagebox is shown from the concatenated Catch statements.
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage)

        End If

        'If errorMessage is empty then no Try's failed.  The calculations are then performed, and output written.
        'This ensures that if invalid data is entered calculations will not output invalid data based on the data
        'it does receive.
        If errorMessage = "" Then
            avgInv = Convert.ToDouble(startInv + endInv)
            avgInv /= 2
            turnover = costOfGoods / avgInv
            avgInventoryTextBox.Text = avgInv.ToString("C")
            turnoverTextBox.Text = turnover.ToString("F1")
        End If
    End Sub

    'This sub clears all fields and values for a new user calculation
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        beginningInventoryTextBox.Text = ""
        endingInventoryTextBox.Text = ""
        costOfGoodsTextBox.Text = ""
        avgInventoryTextBox.Text = ""
        turnoverTextBox.Text = ""
        startInv = 0
        endInv = 0
        costOfGoods = 0
        avgInv = 0
        turnover = 0
    End Sub

    'Closes the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    'The next 3 subs check to see if the textbox text has been set in a previous Catch, if it has when the user
    'clicks on the textbox, the textbox will clear for new data.  If the data was valid though, the content of the
    'textbox is unchanged.

    Private Sub beginningInventoryTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles beginningInventoryTextBox.MouseDown
        If (beginningInventoryTextBox.Text = "Please enter only Whole Numbers in Beginning Inventory") Then
            beginningInventoryTextBox.Text = ""
        End If
    End Sub

    Private Sub endingInventoryTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles endingInventoryTextBox.MouseDown
        If (endingInventoryTextBox.Text = "Please enter only Whole Numbers in Ending Inventory") Then
            endingInventoryTextBox.Text = ""
        End If
    End Sub

    Private Sub CostOfGoodsTextBox_MouseDown(sender As Object, e As EventArgs) Handles costOfGoodsTextBox.MouseDown
        If (costOfGoodsTextBox.Text = "Please enter currency with no $") Then
            costOfGoodsTextBox.Text = ""
        End If
    End Sub


End Class
