'Assignment: Asg1-3
'RCET0265
'Nathan Carlson
'Specials
Public Class Wisdom
    'Changes the Form Label to default
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Words to Live By"
    End Sub
    'Exit Form Procedure
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    'Towel Button changes saying to "Don't Panic && Carry a Towel"
    Private Sub TowelButton_Click(sender As Object, e As EventArgs) Handles towelButton.Click
        '"Don't Panic & Carry a Towel"
        Me.Sayings.Text = "Don't Panic && Carry a Towel"
    End Sub
    'Penny Button changes saying to "A Penny Saved is a Penny Earned"
    Private Sub PennyButton_Click(sender As Object, e As EventArgs) Handles pennyButton.Click
        Me.Sayings.Text = "A Penny Saved is a Penny Earned"
    End Sub
    'Bush Button changes saying to "A Bird in the Hand is worth Two in the Bush"
    Private Sub BushButton_Click(sender As Object, e As EventArgs) Handles bushButton.Click
        Me.Sayings.Text = "A Bird in the Hand is worth Two in the Bush"
    End Sub

    'Debt Button changes saying to "Use it Up, Wear it Out, Make it Do, or Do Without"

    Private Sub DebtButton_Click(sender As Object, e As EventArgs) Handles debtButton.Click
        Me.Sayings.Text = "Use it Up, Wear it Out, Make it Do, or Do Without"
    End Sub
End Class
