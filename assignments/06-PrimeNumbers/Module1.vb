Module Module1


    Dim Prime As Integer()
    Dim currentnum As Integer = 1

    Sub Main()
        Do While (currentnum < 10)
            currentnum = currentnum + 1
            'If () Then
            Array.Resize(Prime, Prime.Length + 1)
            Prime.Append(currentnum)



        Loop
        Console.Write(Prime(currentnum - 1))
    End Sub

End Module
