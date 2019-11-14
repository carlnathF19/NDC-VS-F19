Option Explicit On
Option Strict On

Public Class Form1
    Dim summary As New List(Of String)

    Private Function ColumnHeaders(firstColumn As String, secondColumn As String,
                    thirdColumn As String, fourthColumn As String) As String
        'Updates the formatting of the stock picks.
        'Description, Unit, Rate, Subtotal
        Dim columnWidth As Integer = 20
        firstColumn = "|" & firstColumn
        secondColumn = "|" & secondColumn
        thirdColumn = "|" & thirdColumn
        fourthColumn = "|" & fourthColumn '& "|"

        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
         thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth - 1) & "|"

    End Function
    Private Sub clearData()
        'Clears Data
        stockCodeTextBox.Clear()
        mondayValMaskedTextBox.Clear()
        tuesdayValMaskedTextBox.Clear()
        wednesdayValMaskedTextBox.Clear()
        stockListBox.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles CalculateToolStripMenuItem.Click, CalculateToolStripMenuItem1.Click
        'Validates data entered and returns messagebox with any fields that are invalid, 
        'selecting the first in the tab order.
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

        'errorSummary is updated only in catch statements, and if it is a summary is shown in the 
        'Message Box
        If errorSummary <> "" Then
            MessageBox.Show(errorSummary)
        End If

        'If errorSummary was blank then the calculations are performed and added to the listbox.
        'The function HoldBuySell() checks the decision, and chooses the case to run.
        If errorSummary = "" Then
            firstDayChange = Double.Parse(tuesdayValMaskedTextBox.Text) -
                Double.Parse(mondayValMaskedTextBox.Text)
            secondDayChange = Double.Parse(wednesdayValMaskedTextBox.Text) -
                Double.Parse(tuesdayValMaskedTextBox.Text)
            'HoldBuySell(firstDayChange, secondDayChange)
            decision = CStr(HoldBuySell(firstDayChange, secondDayChange))

            Select Case decision
                Case "Buy"
                    'Inserts at the top of the Buy section of the columns, with ColumnHeaders
                    'formatting the output.
                    summary.Insert(0, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                secondDayChange.ToString("C"), decision))
                    'inserts the current value in the first place
                    stockListBox.Items.Insert(0, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                secondDayChange.ToString("C"), decision))
                    'Increments a count to tell the Sell case where to insert.
                    buyCount += 1


                Case "Sell"
                    'Inserts at the top of the Sell section of the columns, with ColumnHeaders
                    'formatting the output.
                    summary.Insert(buyCount, ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                secondDayChange.ToString("C"), decision))
                    'Inserts the Sell at the end of the Buy column
                    stockListBox.Items.Insert(buyCount,
                                ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                secondDayChange.ToString("C"), decision))
                    'Increments a count to tell the Hold case where to insert.
                    sellCount += 1
                Case "Hold"
                    'Inserts at the top of the Hold section of the columns, with ColumnHeaders
                    'formatting the output.  It does this by adding both counts together to set the
                    'insert point.
                    summary.Insert((buyCount + sellCount),
                                    ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                                  secondDayChange.ToString("C"), decision))
                    stockListBox.Items.Insert((buyCount + sellCount),
                                    ColumnHeaders(stockCodeTextBox.Text, firstDayChange.ToString("C"),
                                                  secondDayChange.ToString("C"), decision))
            End Select

        End If

    End Sub
    Private Function HoldBuySell(firstDayChange As Double, secondDayChange As Double) As Object
        'reads in the firstday to secondday change from calculate and returns buy or sell if the value
        'has changed according to Justine's Algorithm.  Otherwise returns hold.

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

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        'Inserts at the top of the Sell section of the columns, with ColumnHeaders
        'formatting the output.
        clearData()
        stockListBox.Items.Clear()
        summary.Clear()

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles SummaryToolStripMenuItem.Click, SummaryToolStripMenuItem1.Click
        'Loops through and adds all stock prices calculated to a String, then uses a message box to
        'show a summary.
        Dim msgSummary As String =
            "*************************************************************************" & vbNewLine &
            "**************************Justine's Stock Picks**************************" & vbNewLine &
            "*************************************************************************" & vbNewLine
        For i = 0 To (summary.Count - 1)
            'Console.WriteLine(summary(i))
            msgSummary &= summary(i) & vbNewLine
        Next
        MessageBox.Show(msgSummary)
    End Sub

End Class
