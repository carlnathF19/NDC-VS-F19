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
    Dim costOfGoods As Double
    Dim avgInv As Double
    Dim turnover As Double
    Dim errorMessage As String





    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        errorMessage = ""
        Try
            costOfGoods = Double.Parse(costOfGoodsTextBox.Text)
        Catch ex As Exception
            costOfGoodsTextBox.Text = "Please enter currency with no $"
            costOfGoodsTextBox.Select()
            errorMessage = "Please enter currency with no $" & vbNewLine & errorMessage

        End Try
        Try
            endInv = Integer.Parse(endingInventoryTextBox.Text)
        Catch ex As Exception
            endingInventoryTextBox.Text = "Please enter only Whole Numbers in Ending Inventory"
            endingInventoryTextBox.Select()
            errorMessage = "Please enter only Whole Numbers" & vbNewLine & errorMessage
        End Try
        Try
            startInv = Integer.Parse(beginningInventoryTextBox.Text)
        Catch ex As Exception
            beginningInventoryTextBox.Text = "Please enter only Whole Numbers in Beginning Inventory"
            beginningInventoryTextBox.Select()
            errorMessage = "Please enter only Whole Numbers" & vbNewLine & errorMessage
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage)

        End If
        If errorMessage = "" Then
            avgInv = Convert.ToDouble(startInv + endInv)
            avgInv /= 2
            turnover = costOfGoods / avgInv
            avgInventoryTextBox.Text = avgInv.ToString("C")
            turnoverTextBox.Text = turnover.ToString("F1")
        End If




    End Sub

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
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub BeginningInventoryTextBox_TextChanged(sender As Object, e As EventArgs) Handles beginningInventoryTextBox.TextChanged

    End Sub

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
