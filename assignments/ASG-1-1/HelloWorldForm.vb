'Assignment: Asg1-1
'RCET0265
'Nathan Carlson
'Hello World Program

Public Class HelloWorldForm
    'Procedure for Exiting form.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'Defines the actions taken if the Update Label Button is clicked
    Private Sub UpdateLabelButton_Click(sender As Object, e As EventArgs) Handles UpdateLabelButton.Click
        'If the RadioEng button is selected the DisplayLabel and Form Label are changed to English
        If (RadioEng.Checked) Then
            Me.DisplayLabel.Text = "Hello World"
            Me.Text = "Hello World"
        End If
        'If the RadioFr button is selected the DisplayLabel and Form Label are changed to French
        If (RadioFr.Checked) Then
            Me.DisplayLabel.Text = "Bonjour tout le monde"
            Me.Text = "Bonjour tout le monde"
        End If
        'If the RadioIt button is selected the DisplayLabel and Form Label are changed to Italian
        If (RadioIt.Checked) Then
            Me.DisplayLabel.Text = "Ciao Mundo"
            Me.Text = "Ciao Mundo"
        End If
    End Sub
End Class
