'Nathan Carlson
'RCET0265
'asg2-5
'State Flag Viewer Program
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/ASG2-6
Public Class State_Flag_Viewer
    'Each Button when clicked changes the resource that the Picture box points to.
    Private Sub AlaskaButton_Click(sender As Object, e As EventArgs) Handles AlaskaButton.Click
        PictureBox1.Image = My.Resources.Flag_of_Alaska
    End Sub
    'Each Button when clicked changes the resource that the Picture box points to.
    Private Sub IndianaButton_Click(sender As Object, e As EventArgs) Handles IndianaButton.Click
        PictureBox1.Image = My.Resources.Flag_of_Indiana
    End Sub
    'Each Button when clicked changes the resource that the Picture box points to.
    Private Sub UtahButton_Click(sender As Object, e As EventArgs) Handles UtahButton.Click
        PictureBox1.Image = My.Resources.Flag_of_Utah
    End Sub
    'Each Button when clicked changes the resource that the Picture box points to.
    Private Sub VermontButton_Click(sender As Object, e As EventArgs) Handles VermontButton.Click
        PictureBox1.Image = My.Resources.Flag_of_Vermont
    End Sub
    'Exits the Program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
