Module Module1

    Sub Main()
        Dim product As String
        Dim iteration As Integer
        Dim Multiplier As Integer
        Multiplier = 1
        iteration = 0
        Do While (Multiplier < 13)
            Do While (iteration < 13)
                product = Multiplier * iteration
                Console.Write(product.PadLeft(3) & " |")
                iteration = iteration + 1

            Loop
            Console.WriteLine()
            iteration = 0
            Multiplier = Multiplier + 1
        Loop


    End Sub

End Module
