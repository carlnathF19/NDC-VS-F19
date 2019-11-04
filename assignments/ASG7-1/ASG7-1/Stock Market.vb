Option Explicit On
Option Strict On

Public Class Form1
    Dim summary As New List(Of String)
    Dim endSummary As New List(Of String)

    'Private Function HorizontalBorder(length As Integer, characterSet As String) As String
    '    Dim tempstring As String = ""
    '    For i = 0 To length
    '        tempstring &= characterSet
    '    Next

    '    Return tempstring
    'End Function
    Private Function ColumnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String) As String
        'Description, Unit, Rate, Subtotal
        Dim columnWidth As Integer = 20
        firstColumn = "| " & firstColumn
        secondColumn = "| " & secondColumn
        thirdColumn = "| " & thirdColumn
        fourthColumn = "| " & fourthColumn

        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
         thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth - 1) & "|"

    End Function
    Private Sub clearData()
        ' []update to clear summary?
        stockCodeTextBox.Clear()
        mondayValMaskedTextBox.Clear()
        tuesdayValMaskedTextBox.Clear()
        wednesdayValMaskedTextBox.Clear()
        stockListBox.Items.Clear()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click,
        CalculateToolStripMenuItem1.Click
        'Validates code and returns messagebox with any fields that are invalid, selecting the first in the tab order.
        Dim errorSummary As String = ""
        Dim firstDayChange As Double
        Dim secondDayChange As Double
        Dim decision As String
        Static buyCount As Integer = 0
        Static sellCount As Integer = 0
        Static holdCount As Integer = 0


        Try
            Double.Parse(wednesdayValMaskedTextBox.Text)
        Catch ex As Exception
            errorSummary = "Please enter a valid Price in Wednesday." & vbNewLine & errorSummary
            wednesdayValMaskedTextBox.Select()
        End Try
        Try
            Double.Parse(tuesdayValMaskedTextBox.Text)
        Catch ex As Exception
            errorSummary = "Please enter a valid Price in Tuesday." & vbNewLine & errorSummary
            tuesdayValMaskedTextBox.Select()
        End Try
        Try
            Double.Parse(mondayValMaskedTextBox.Text)
        Catch ex As Exception
            errorSummary = "Please enter a valid Price in Monday." & vbNewLine & errorSummary
            mondayValMaskedTextBox.Select()
        End Try
        If stockCodeTextBox.Text = "" Then
            errorSummary = "Please enter the stock code you would like to calculate." _
                & vbNewLine & errorSummary
            stockCodeTextBox.Select()
        End If

        If errorSummary <> "" Then
            MessageBox.Show(errorSummary)
        End If

        If errorSummary = "" Then
            firstDayChange = Double.Parse(tuesdayValMaskedTextBox.Text) - Double.Parse(mondayValMaskedTextBox.Text)
            secondDayChange = Double.Parse(wednesdayValMaskedTextBox.Text) - Double.Parse(tuesdayValMaskedTextBox.Text)
            'HoldBuySell(firstDayChange, secondDayChange)
            decision = CStr(HoldBuySell(firstDayChange, secondDayChange))
            'Console.WriteLine(firstDayChange)
            'Console.WriteLine(secondDayChange)
            'Console.WriteLine(decision)
            Console.WriteLine(ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
            Select Case decision
                Case "Buy"
                    summary.Insert(0, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    stockListBox.Items.Insert(0, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    buyCount += 1


                Case "Sell"
                    summary.Insert(buyCount, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    stockListBox.Items.Insert(buyCount, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    sellCount += 1
                Case "Hold"
                    endSummary.Add(ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
                    stockListBox.Items.Insert((buyCount + sellCount), ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"), secondDayChange.ToString("C"), decision))
            End Select
            Console.WriteLine(summary)
            'clearData()


        End If

    End Sub
    Private Function HoldBuySell(firstDayChange As Double, secondDayChange As Double) As Object
        Dim result As String
        If firstDayChange > 0 And secondDayChange > firstDayChange Then
            result = "Buy"
        ElseIf firstDayChange < 0 And secondDayChange < firstDayChange Then
            result = "Sell"
        Else
            result = "Hold"
        End If



        Return result

    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click,
        ClearToolStripMenuItem1.Click
        clearData()

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click, SummaryToolStripMenuItem1.Click


    End Sub

End Class
