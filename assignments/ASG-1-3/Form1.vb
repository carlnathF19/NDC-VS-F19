'Assignment: Asg1-3
'RCET0265
'Nathan Carlson
'Wisdom

Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub wisdomButton_Click(sender As Object, e As EventArgs) Handles UpdateLabelButton.Click
        Random()

    End Sub

    Private Sub TowelButton_Click(sender As Object, e As EventArgs) Handles towelButton.Click
        '"Don't Panic & Carry a Towel"
    End Sub

    Private Sub PennyButton_Click(sender As Object, e As EventArgs) Handles pennyButton.Click
        '"A Penny Saved is a Penny Earned"
    End Sub

    Private Sub BushButton_Click(sender As Object, e As EventArgs) Handles bushButton.Click
        '"A Bird in the Hand is worth Two in the Bush"
    End Sub
End Class
