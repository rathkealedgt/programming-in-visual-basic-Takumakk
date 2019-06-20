''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Takuma Kaneko </author>
''' <date> 21/06/2019 </date>
Module Module1

    Sub Main()
        'Housekeeping
        Dim UserResponse As Integer
        Const ErrorMassage As String = "Please try again"
        Dim ValidInput As Boolean = False

        ' Ask user for a number and store it.
        While Not ValidInput

            Try
                Console.WriteLine("Please enter an integer between 1 and 10.")
                UserResponse = Console.ReadLine()
                ValidInput = True
            Catch ex As Exception

                Console.WriteLine(ErrorMassage)

            End Try

        End While
        ' Pause the program to view output.
        Dim Output As String = String.Format("You entered this number {0}", UserResponse.ToString)
        Console.WriteLine(Output)
        Console.ReadLine()
    End Sub

End Module
