'Nathan Carlson
'RCET0265
'asg2-5
'Address label display program
'

Public Class AddressLabel

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click
        AddrLabelLine1.Text = FirstName.Text & " " & LastName.Text
        AddrLabelLine2.Text = StreetAddr.Text
        AddrLabelLine3.Text = City.Text & ", " & State.Text & " " & ZipCode.Text
    End Sub

    Private Sub ClearForm_Click(sender As Object, e As EventArgs) Handles ClearForm.Click
        AddrLabelLine1.Text = "Your Name"
        AddrLabelLine2.Text = "Your Street Address"
        AddrLabelLine3.Text = "City, State && Zip Code"
        FirstName.Text = ""
        LastName.Text = ""
        StreetAddr.Text = ""
        City.Text = ""
        State.Text = ""
        ZipCode.Text = ""
    End Sub
End Class
