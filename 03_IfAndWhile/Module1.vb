''' <summary>
'''     This exercise will introduce you to if statements and while loops.
''' </summary>
''' <author> Takuma Kaneko </author>
''' <date> 20/06/2019 </date>
''' 
Module Module1

    Sub Main()
        ' Housekeeping
        Dim UserResponse As String
        Dim Keepgoing As String = ""

        ' Ask user if they like coffee and record their answer.
        While Keepgoing = ""

            Console.WriteLine("Do you like coffee?")
            UserResponse = Console.ReadLine().ToLower()

        ' Check input and respond
        If UserResponse = "yes" Or UserResponse = "y" Then
                Console.WriteLine("I Like coffee too")
            ElseIf UserResponse = "no" Or UserResponse = "n" Then
                Console.WriteLine("Go back to your home")
            Else
                Console.WriteLine("your life must be empty")
            End If

            ' Pause program to let the user read 
            Console.WriteLine("Press q followed by <enter> to quit")
            Keepgoing = Console.ReadLine()

        End While
    End Sub

End Module
