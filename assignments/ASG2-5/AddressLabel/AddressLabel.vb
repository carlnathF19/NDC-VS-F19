'Nathan Carlson
'RCET0265
'asg2-5
'Address label display program
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/ASG2-5

Public Class AddressLabel
    'This Sub exits the form.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'Display Label on Click builds the label address into AddrLabel.
    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click
        AddrLabel.Text = FirstName.Text & " " & LastName.Text & vbNewLine & StreetAddr.Text & vbNewLine &
        City.Text & ", " & State.Text & " " & ZipCode.Text
    End Sub
    'Clears form Resets the AddrLabel to default, and blanks out the form fields.
    Private Sub ClearForm_Click(sender As Object, e As EventArgs) Handles ClearForm.Click
        AddrLabel.Text = "Your Name" & vbNewLine & "Your Street Address" & vbNewLine & "City, State && Zip Code"
        FirstName.Text = ""
        LastName.Text = ""
        StreetAddr.Text = ""
        City.Text = ""
        State.Text = ""
        ZipCode.Text = ""
    End Sub

    Private Sub AddressLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddrLabel.Text = "Your Name" & vbNewLine & "Your Street Address" & vbNewLine & "City, State && Zip Code"
    End Sub
End Class
