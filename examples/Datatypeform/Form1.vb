Public Class Form1

    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim result As Integer
    'Dim userInput As String
    Sub Numbers()
        firstNumber = Convert.ToDecimal(FirstNumberTextBox.Text)
        secondNumber = Convert.ToDecimal(SecondNumberTextBox.Text)
        'userInput = Convert.ToDecimal(userInput)
        result = firstNumber + secondNumber
        ResultTextBox.Text = result
        Console.WriteLine(result)


    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Numbers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
