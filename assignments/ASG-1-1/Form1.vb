'Assignment: Asg1-1
'RCET0265
'Nathan Carlson
'Hello World Program

Public Class Form1
    Private Sub UpdateTitle(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = "My first windows form."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateLabelButton_Click(sender As Object, e As EventArgs) Handles UpdateLabelButton.Click
        If (RadioEng.Checked) Then
            Me.DisplayLabel.Text = "Hello World"
            Me.Text = "Hello World"
        End If
        If (RadioFr.Checked) Then
            Me.DisplayLabel.Text = "Bonjour tout le monde"
            Me.Text = "Bonjour tout le monde"
        End If
        If (RadioIt.Checked) Then
            Me.DisplayLabel.Text = "Ciao Mundo"
            Me.Text = "Ciao Mundo"
        End If
    End Sub
End Class
