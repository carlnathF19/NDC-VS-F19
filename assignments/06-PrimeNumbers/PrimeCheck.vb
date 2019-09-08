'Assignment: Section 2-6
'RCET0265
'Nathan Carlson
'Prime Numbers

'Reference Codes and resources
'https://www.smartickmethod.com/blog/math/operations-and-algebraic-thinking/divisibility/prime-numbers-sieve-eratosthenes/
'https://stackoverflow.com/questions/21826904/how-to-check-for-prime-numbers
'https://github.com/pogakuofie/VB.NET-Prime-Number-With-Sieve-Of-Eratosthenes/blob/master/Sieve%20Of%20Eratosthenes.txt
Module PrimeCheck

    Dim CurrentNum As Integer
    Dim i As Integer
    Dim isPrime As Boolean


    Sub Main()
        ' Writes 1, as 1 will be skipped as 1/2 has a mod <> 0
        Console.Write("1, ")
        'For each number the program will check the prime condition using the contents of this loop, and then step to the next number
        For CurrentNum = 2 To 1000
            'Sets a Boolean value that assumes the number is prime, on following steps, if the previous number was not prime, reset from
            'False to True.
            isPrime = True
            'Using the Sieve of Eratosthenes the largest number that can be multiplied by itself to get a target prime number is the largest
            'divisor that could be prime.  So Math.Sqrt(CurrentNum) tells us where we can stop.  It steps through each  number
            For i = 2 To Math.Sqrt(CurrentNum)
                'If the Currentnum divided by the iterator i returns a remainder of 0 it is divisible by other numbers besides 1 which we 
                'skip, or another number between 2 and sqrt of the current number.  This If sets the is Prime to false.
                If CurrentNum Mod i = 0 Then
                    isPrime = False
                End If
            Next
            'If isPrime is true then a Console.WriteLine with a comma occurs otherwise the For loop steps to the next currentnum value 
            If isPrime Then

                Console.WriteLine(CurrentNum & ",")

            End If

        Next
    End Sub


    'OTHER ATTEMPTS LEFT TO SHOW PREVIOUS ATTEMPTS:  Previous attempts were faulty, had to study others code to understand process.

    'Dim result As Integer
    'Dim isPrime As Boolean
    'isPrime = False
    'Sub Main()
    '   Console.Write("1, ")
    'For currentnum As Integer = 2 To 100
    'For i As Integer = 2 To currentnum
    'If (currentnum Mod i = 0 AndAlso i <> currentnum AndAlso currentnum <> 1) Then
    'Exit For
    'Else
    '               Console.Write(currentnum & ", ")
    'End If
    'Next
    '
    'Next
    'End Sub


    'Do While (iteration < 1000)
    'iteration = iteration + 1
    'Do While (currentnum < 1000)
    'currentnum = currentnum + 1
    'result = currentnum Mod iteration
    'If (result = 0 And currentnum <> iteration) Then
    'Console.Write(currentnum & ", ")
    'End If
    '
    '
    '
    'Loop

    'Loop



End Module
