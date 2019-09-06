'Assignment: Asg1-5
'RCET0265
'Nathan Carlson
'Wisdom
Public Class Specials
    'Displays Soup of the day when clicked
    Private Sub SoupDayButton_Click(sender As Object, e As EventArgs) Handles soupDayButton.Click
        special.Text = "Tomato Bisque with toasted Croutons"
    End Sub
    'Displays Chef's Special when clicked
    Private Sub ChefSpecButton_Click(sender As Object, e As EventArgs) Handles chefSpecButton.Click
        special.Text = "Texas Toast with Italian Meatballs and Spaghetti"
    End Sub
    'Displays Daily Fish when clicked
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles fishButton.Click
        special.Text = "Salangidae fish sashimi on leaf"
    End Sub
    'Closes the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
