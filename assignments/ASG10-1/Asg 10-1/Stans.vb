'Nathan Carlson
'RCET0265
'asg 10-1   
'Stans
'https://github.com/carlnathF19/NDC-VS-F19/tree/master/assignments/Asg8-1

'Option Explicit On
'Option Strict On is turned off because it disallows late binding, which would require declaration of variables to store current selected items
'it is more efficient to allow the late binding and only turn Option Strict On when troubleshooting code.


Public Class StansGrocery
    'Dimensions a 3 X 5 Aisle, Item array to store inventory
    Dim Food$(2, 4)
    Private Sub ReadFile(ByVal fileName As String, ByRef recordData() As String)
        'Reads in a file with the first argument being it's location, and the second an array.  The  functions FileOpen, and Input use the filename to 
        'identify the file location, and filenumber, which is set by freefile, to identify the file. 
        Dim currentRecord As String
        Dim fileData As String
        Dim fileNumber As Integer = FreeFile()

        Try
            'Attempts to read in the file, looping through each line until it reaches the End of File, EOF.  Filedata is read into currentRecord
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do While Not EOF(fileNumber)
                Input(fileNumber, currentRecord)
                fileData &= currentRecord
            Loop
        Catch ex As Exception
            'If the file does not exist displays an error message.
            Console.WriteLine(ex.Message)
        Finally
            'Closes the file, necessary to keep memory free.  If fileNumber is not specified closes all files.  If Append or Output was the openmode, 
            'the remaining data is written to the file.
            FileClose(fileNumber)
        End Try
        'using the split command to record information into the recordData array, splitting into a new item at each $$.
        recordData = Split(fileData, "$$")

    End Sub

    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load reads in the file with ReadFile Sub.  
        Dim originalFileName As String = "C:\Users\carri\Documents\GitHub\NDC-VS-F19\assignments\ASG10-1\Asg 10-1\grocery.txt"
        Dim inventoryIn() As String
        'The first read in information is an empty string, so by Dimensioning i at 1 the first blank is always skipped, and also resets with each load.
        Dim i As Integer = 1

        ReadFile(originalFileName, inventoryIn)

        For aisle = 0 To 2
            For item = 0 To 4

                Food(aisle, item) = inventoryIn(i)
                InventoryComboBox.Items.Add(inventoryIn(i))
                inventoryListBox.Items.Add(inventoryIn(i))
                i += 1
            Next
        Next


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub inventoryListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inventoryListBox.SelectedIndexChanged
        'Loops through each array position and checks to see if the item is equal to the Listbox selected item.  In order to check that
        'both values are equal, tolower is used to compare each in it's lower case state.  More complex coding could identify if a plural is used.
        'Each check will use tolower.  Then this sub shows item aisle and number, by adding one to it's array index row and column.  
        'If it is found it displays a message with the location.
        For aisle = 0 To 2
            For item = 0 To 4
                If Food(aisle, item).ToLower = inventoryListBox.SelectedItem.tolower Then
                    MessageBox.Show("You will find " & inventoryListBox.SelectedItem & "s on aisle #" & aisle + 1 & ", item # " & item + 1)
                End If
            Next
        Next


    End Sub

    Private Sub InventoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InventoryComboBox.SelectedIndexChanged
        'Loops through each array position and checks to see if the item is equal to the Combo box selected item.  Then shows its aisle and number,
        'by adding one to it's array index row and column.  If it is found it displays a message with the location.
        For aisle = 0 To 2
            For item = 0 To 4
                If Food(aisle, item).ToLower = InventoryComboBox.SelectedItem.tolower Then
                    MessageBox.Show("You will find " & Food(aisle, item) & "s on aisle #" & aisle + 1 & ", item # " & item + 1)
                End If
            Next
        Next
        'Console.WriteLine(InventoryComboBox.SelectedItem)
    End Sub

    Private Sub searchTextBoxButton_Click(sender As Object, e As EventArgs) Handles searchTextBoxButton.Click
        'Initiaties a search, and sets isFound to it's default "Item not found" message.
        Dim isFound As String = "The item you are searching for is not in the store"
        'Checks to see if search is zzz, then closes if true, else ignores.
        If lookupTextBox.Text = "zzz" Then
            Me.Close()
        End If

        'Loops through each array position and checks to see if the item is equal to the read in text.  
        'Then shows its aisle and number, by adding one to it's array index row and column.  If it is found it displays a message with the location.
        For aisle = 0 To 2
            For Item = 0 To 4
                If Food(aisle, Item).ToLower = lookupTextBox.Text.ToLower Then
                    'updates isFound if the item is found.
                    isFound = "You will find " & Food(aisle, Item) & "s on aisle #" & aisle + 1 & ", item #" & Item + 1
                End If
            Next
        Next
        'Displays the location of the item, or the "Item not found message.
        MessageBox.Show(isFound)

    End Sub
End Class
