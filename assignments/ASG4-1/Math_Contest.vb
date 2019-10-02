'Nathan Carlson
'RCET0265
'asg4-1
'Math Contest
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/ASG4-1

Option Strict On
Option Explicit On

Public Class Math_Contest
    Dim age As Integer
    Dim grade As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim result As Double
    Dim totalCorrect As Integer
    Dim totalIncorrect As Integer
    Dim resultstorage As Double
    'Clearfields function to blank all fields when called
    Private Sub ClearFields()
        studentNameTextBox.Text = ""
        ageMaskedTextBox.Text = ""
        gradeMaskedTextBox.Text = ""
        firstNumberTextBox.Text = ""
        secondNumberTextBox.Text = ""
        studentAnswerTextBox.Text = ""
        studentNameTextBox.Select()
    End Sub
    'Disablefields disables all fields to facilitate entry of the Student information, setting focus
    'on the only true field.
    Private Sub DisableFields()
        ageMaskedTextBox.Enabled = False
        gradeMaskedTextBox.Enabled = False
        addRadioButton.Enabled = False
        subtractRadioButton.Enabled = False
        multiplyRadioButton.Enabled = False
        divideRadioButton.Enabled = False
        studentAnswerTextBox.Enabled = False
        studentNameTextBox.Enabled = True
        submitButton.Enabled = False
        clearButton.Enabled = False
        summaryButton.Enabled = False
        exitButton.Enabled = True
    End Sub
    'Enables teacher access to problem type selection
    Private Sub EnableTeacher()
        addRadioButton.Enabled = True
        subtractRadioButton.Enabled = True
        multiplyRadioButton.Enabled = True
        divideRadioButton.Enabled = True
    End Sub
    'Enables student access to the functions the student uses.
    Private Sub EnableStudent()
        addRadioButton.Enabled = False
        subtractRadioButton.Enabled = False
        multiplyRadioButton.Enabled = False
        divideRadioButton.Enabled = False
        studentNameTextBox.Enabled = False
        ageMaskedTextBox.Enabled = False
        gradeMaskedTextBox.Enabled = False
        studentAnswerTextBox.Enabled = True
        submitButton.Enabled = True
        clearButton.Enabled = True
        summaryButton.Enabled = True
        studentAnswerTextBox.Select()
        GenerateNumber()
    End Sub
    'Generates a random number, A more complex version could ensure only whole number division results
    'and no negative numbers, but was not specified in the requirements.
    Private Sub GenerateNumber()
        firstNumber = Convert.ToInt16(Rnd() * 9 + 1)
        secondNumber = Convert.ToInt16(Rnd() * 9 + 1)
        firstNumberTextBox.Text() = Convert.ToString(firstNumber)
        secondNumberTextBox.Text() = Convert.ToString(secondNumber)
    End Sub
    'When the studentname box is empty requires this field to be focus, and an entry made.  Else enables
    'the next field
    Private Sub studentNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentNameTextBox.TextChanged
        DisableFields()
        If studentNameTextBox.Text = "" Then
            MessageBox.Show("Please enter Student Name")
            studentNameTextBox.Select()
        Else
            ageMaskedTextBox.Enabled = True
        End If
    End Sub
    'Checks to see if the age is in the range 7 to 11, if not sends message that student is inelligible, and
    'resets program to enter new student.  Else enables grade field.
    Private Sub ageMaskedTextBox_LostFocus(sender As Object, e As EventArgs) Handles ageMaskedTextBox.LostFocus
        Try
            age = Integer.Parse(ageMaskedTextBox.Text)
        Catch ex As Exception

        End Try

        If age > 6 And age < 12 And ageMaskedTextBox.Text <> "" Then
            gradeMaskedTextBox.Enabled = True
            gradeMaskedTextBox.Select()
        ElseIf (age < 7 Or age > 11) And ageMaskedTextBox.Text <> "" Then
            MessageBox.Show("Student inelligible to compete.")
            ClearFields()
        End If
    End Sub

    'Checks to see if the grade is in the range 1 to 4, if not sends message that student is inelligible, and
    'resets program to enter new student.  Else enables teacher fields, and selects add.
    Private Sub gradeMaskedTextBox_LostFocus(sender As Object, e As EventArgs) Handles gradeMaskedTextBox.LostFocus
        Try
            grade = Integer.Parse(gradeMaskedTextBox.Text)
        Catch ex As Exception

        End Try
        If grade > 0 And grade < 5 And gradeMaskedTextBox.Text <> "" Then
            EnableTeacher()
            addRadioButton.Select()
        ElseIf grade < 1 Or grade > 4 And gradeMaskedTextBox.Text <> "" Then
            MessageBox.Show("Student inelligible to compete.")
            ClearFields()

        End If
    End Sub
    'Exits the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    'The following four run the enablestudent, which enables student fields and disables teacher fields
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles addRadioButton.CheckedChanged
        EnableStudent()

    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles subtractRadioButton.CheckedChanged
        EnableStudent()

    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles multiplyRadioButton.CheckedChanged
        EnableStudent()

    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles divideRadioButton.CheckedChanged
        EnableStudent()

    End Sub
    'Submit Button checks which radio button is true, and sets result to that operation type.
    'Then displays either correct, or incorrect, and adds to the totals of correct or incorrect.
    'Then enables the teacher to choose a new operation, and generates new number.
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Select Case True

            Case addRadioButton.Checked
                result = firstNumber + secondNumber
            Case subtractRadioButton.Checked
                result = firstNumber - secondNumber
            Case multiplyRadioButton.Checked
                result = firstNumber * secondNumber
            Case divideRadioButton.Checked
                result = firstNumber / secondNumber
        End Select
        Try
            resultstorage = Double.Parse(studentAnswerTextBox.Text)
        Catch ex As Exception
            resultstorage = 0
        End Try
        If result = resultstorage Then
            MessageBox.Show("Congratulations, you are correct")
            totalCorrect += 1
        Else
            MessageBox.Show("The correct answer is " & result & ".")
            totalIncorrect += 1
        End If
        EnableTeacher()
        GenerateNumber()
    End Sub
    'Displays a summary of the student's current score, and then enables the exit button and clears fields
    'also resets the score totals to zero
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        MessageBox.Show(studentNameTextBox.Text & " had " & totalCorrect & " correct, and " & totalIncorrect _
                        & " incorrect.")
        totalCorrect = 0
        totalIncorrect = 0
        exitButton.Enabled = True
        DisableFields()
        ClearFields()
    End Sub
    'Clears all fields, resets score totals, and selects add.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        totalCorrect = 0
        totalIncorrect = 0
        addRadioButton.Select()
        ClearFields()
        DisableFields()
    End Sub
End Class
