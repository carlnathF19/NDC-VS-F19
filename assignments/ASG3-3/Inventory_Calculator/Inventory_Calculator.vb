'Nathan Carlson
'RCET0265
'asg3-3
'Inventory Calculator
'

Option Explicit On
Option Strict On
Public Class Inventory_Calculator
    Dim startInv As Integer
    Dim endInv As Integer
    Dim costOfGoods As Double
    Dim avgInv As Double
    Dim turnover As double


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        startInv = Integer.Parse(beginningInventoryTextBox.Text)
        endInv = Integer.Parse(endingInventoryTextBox.Text)
        costOfGoods = Double.Parse(costOfGoodsTextBox.Text)
        avgInv = Convert.ToDouble(startInv + endInv)
        avgInv /= 2
        turnover = costOfGoods / avgInv
        avgInventoryTextBox.Text = avgInv.ToString("C")
        turnoverTextBox.Text = turnover.ToString("f1")


    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        beginningInventoryTextBox.Text = ""
        endingInventoryTextBox.Text = ""
        costOfGoodsTextBox.Text = ""
        avgInventoryTextBox.Text = ""
        turnoverTextBox.Text = ""
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub


End Class
