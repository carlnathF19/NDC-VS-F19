'Nathan Carlson
'RCET0265
'asg8-1
'Random Number generator
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/Asg8-1

Option Explicit On
Option Strict On

Public Class RandomNumGenerator
    Public Function createRandom() As Integer
        'creates a Random number between 1 and 20 and offsets it by -10 which gives a random number
        'between -10 and 10
        Dim randomNum As Integer
        randomNum = Convert.ToInt16(Rnd() * 20 - 10)
        'initializes randomizer
        Randomize(DateAndTime.Now.Millisecond)
        Return randomNum
    End Function
    Private Function format(temparray() As Integer, index As Integer) As String
        Dim tempSummary As String

        If temparray(index) = 10 Or temparray(index) = -10 Then
            tempSummary &= temparray(index).ToString.PadLeft(4) & " |"
        Else
            tempSummary &= temparray(index).ToString.PadLeft(5) & " |"
        End If

        Return tempSummary
    End Function
    Private Sub GenerateNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles GenerateNumbersToolStripMenuItem.Click, GenerateNumbersToolStripMenuItem1.Click,
        genRandNumButton.Click
        'Dims a randomArray which is dynamic but has a set number of elements.
        Dim randomArray(10) As Integer
        Dim columnWidth As Integer = 0
        Static summary As String
        '''clears the list box of previous random numbers
        ''randomNumListBox.Items.Clear()

        'loops through 10 times and calls createRandom to fill the array.
        For i = 0 To 9
            randomArray(i) = createRandom()
            summary &= format(randomArray, i)

        Next
        randomNumListBox.Items.Add(summary)
        summary = ""

    End Sub


End Class
