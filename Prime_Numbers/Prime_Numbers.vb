Module Module1

    Sub Main()

        Console.WriteLine("Integer")
        Dim num As String
        Dim var As String
        var = 0


        Do
            If Integer.TryParse(var / 2, True) OrElse
                Integer.TryParse(var / 3, True) OrElse
                Integer.TryParse(var / 5, True) OrElse
                Integer.TryParse(var / 7, True) OrElse
                Integer.TryParse(var / 11, True) OrElse
                Integer.TryParse(var / 13, True) Then Console.WriteLine(var & " Is NOT Prime") Else Console.WriteLine(var & " Is Prime")

            var = num + 1
            num = var
        Loop Until num = 1000
        Console.WriteLine("more?")
    End Sub
End Module