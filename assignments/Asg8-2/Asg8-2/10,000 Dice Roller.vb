'Nathan Carlson
'RCET0265
'asg8-1
'10,000 Dice Roller
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/Asg8-2

Option Explicit On
Option Strict On

Public Class Form1

    Public Function createRandom() As Integer
        'creates a Random number between 1 and 6 to simulate a dice roll
        Dim randomNum As Integer
        'Note that Rnd() * 6 gives 0,1,2,3,4,5,6 and 1-6 is desired, Rnd()*5 + 1 gives that value.
        randomNum = Convert.ToInt16(Rnd() * 5 + 1)
        'initializes randomizer
        Randomize(DateAndTime.Now.Millisecond)
        Return randomNum
    End Function


    Private Sub RollDiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RollDiceToolStripMenuItem.Click, RollDiceToolStripMenuItem1.Click, RollDiceButton.Click
        Dim countArray(10) As Integer
        Dim diceSum As Integer
        'Clears the previous random rolls from the list box.
        diceRollListBox.Items.Clear()

        For i = 0 To 9999
            'Sums two random numbers, and then for each case increments the array of the appropriate 
            'value.
            diceSum = createRandom() + createRandom()
            Select Case diceSum
                Case 2
                    countArray(0) += 1
                Case 3
                    countArray(1) += 1
                Case 4
                    countArray(2) += 1
                Case 5
                    countArray(3) += 1
                Case 6
                    countArray(4) += 1
                Case 7
                    countArray(5) += 1
                Case 8
                    countArray(6) += 1
                Case 9
                    countArray(7) += 1
                Case 10
                    countArray(8) += 1
                Case 11
                    countArray(9) += 1
                Case 12
                    countArray(10) += 1
            End Select

        Next
        'Adds a heading to the list box.
        diceRollListBox.Items.Add("Number of times dice rolled")
        diceRollListBox.Items.Add("")
        'loops through the array and prints the current array position with 2 added to it, which
        'ends up being the corresponding dice result number.  Then prints after it the sum of the
        'increments from the cases.  Both are padded right.
        For printArray = 0 To 10
            diceRollListBox.Items.Add((printArray + 2 & ": ").ToString.PadRight(10) _
                                      & countArray(printArray).ToString.PadRight(5))

        Next

    End Sub


End Class
