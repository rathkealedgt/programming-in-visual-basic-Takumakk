''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Mr M </author>
''' <date> 13Jun19 </date>
Module Module1

    Sub Main()
        'Housekeeping
        Dim UserResponse As Integer

        ' Ask user for a number and store it.
        Console.WriteLine("Please enter an integer between 1 and 10.")
        UserResponse = Console.ReadLine()

        ' Pause the program to view output.
        Console.ReadLine()

    End Sub

End Module
