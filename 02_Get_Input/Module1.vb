Module Module1
    ''' <summary>
    '''     This program will show you how to get input from the user.
    ''' </summary>
    ''' <author> Takuma Kaneko </author>
    ''' <date> 20/06/2019 </date>
    ''' 
    Sub Main()
        ' Housekeeping
        Dim UserName, OutMassage As String
        Dim FirstNumber, SecondNumber, Sum, Product As Integer

        ' Ask for user name
        Console.WriteLine("Please enter your name")
        UserName = Console.ReadLine()


        ' Ask user for two numbers
        Console.WriteLine("Please enter your favorite number")
        FirstNumber = Console.ReadLine()
        Console.WriteLine("Please enter next your favorite number")
        SecondNumber = Console.ReadLine()

        ' Add numbers together
        Sum = FirstNumber + SecondNumber

        ' Multiply numbers together
        Product = FirstNumber * SecondNumber


        ' Greet user and display maths
        OutMassage = String.Format("Hello, {0}, The Sum of your number is {1} Also, The Product of your number is {2} ", UserName, Sum, Product)
        Console.WriteLine(OutMassage)
        Console.ReadLine()


    End Sub

End Module
