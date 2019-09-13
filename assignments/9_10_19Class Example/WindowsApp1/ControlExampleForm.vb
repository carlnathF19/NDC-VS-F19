Public Class ControlExampleForm

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        'Enables Button1
        LoadImage.Enabled = True


        If RadioButton1.Checked = True Then
            Console.WriteLine("Radio 1")
            Console.WriteLine(PictureBox1.Image)
            'Method 1 doesn't work on other computers PictureBox1.ImageLocation = "C:\Users\carri\source\repos\Class example 9_10_19\kittenrescue.jpg"
            PictureBox1.Image = My.Resources.kittenrescue
        ElseIf RadioButton2.Checked = True Then
            Console.WriteLine("Radio 2")
            'PictureBox1.Visible = False
            'Method 2 shows picture on any by creating a resource file to compile with the program.
            PictureBox1.Image = My.Resources.KittenManila
        ElseIf RadioButton3.Checked = True Then
            Console.WriteLine("Radio 3")
            PictureBox1.Image = My.Resources.kitten_report
            'PictureBox1.Visible = True
        End If
    End Sub

    Private Sub ControlExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Disables Button1 on load
        LoadImage.Enabled = False
        PictureBox1.Visible = False

    End Sub

    Private Sub LoadImage1(sender As Object, e As EventArgs) Handles LoadImage.Click
        PictureBox1.Visible = True
    End Sub
End Class
