''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Takuma Kaneko </author>
''' <date> 21/06/2019 </date>
Module Module1

    Sub Main()
        Dim UserResponse As Integer
        UserResponse = IntegerCheck(1, 10)
        Console.WriteLine("you entered the various number {0}", UserResponse)
        Console.ReadLine()
    End Sub



    Public Function IntegerCheck(LowNumber As Integer, HighNumber As Integer) As Integer
        'Housekeeping
        Dim UserResponse As Integer
        Const ErrorMassage As String = "Please try again"
        Dim ValidInput As Boolean = False
        Dim OutputMassage As String = String.Format("Please enter an integer between {0} and {1}", LowNumber, HighNumber)

        ' Ask user for a number and store it.
        While Not ValidInput

            Try
                Console.WriteLine("Please enter an integer between 1 and 10.")
                UserResponse = Console.ReadLine()
                If LowNumber <= UserResponse And HighNumber >= UserResponse Then
                    ValidInput = True
                End If
            Catch ex As Exception

                Console.WriteLine(ErrorMassage)

            End Try

        End While

        Return UserResponse

        ' Pause the program to view output.
        'Dim Output As String = String.Format("You entered this number {0}", UserResponse.ToString)
        'Console.WriteLine(Output)
        'Console.ReadLine()
    End Function
End Module
