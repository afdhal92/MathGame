// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

class Program
{
    static List<string> GameHistory = new List<string>();
    static void Main(string[] args)
    {
        var time = System.Diagnostics.Stopwatch.StartNew();
        Console.WriteLine("Welcome to the Math Game!");

        bool continuePlay =true;

        while(continuePlay)
        {
            Console.WriteLine("Please select option below ");
            Console.WriteLine("1 - Addition ");
            Console.WriteLine("2 - Sub ");
            Console.WriteLine("3 - Multilply ");
            Console.WriteLine("4 -  Divide");
            Console.WriteLine("5 - History Game");
            Console.WriteLine("6 - Exit Game");

            Console.Write("Enter you choice : ");
            string choice = Console.ReadLine(); 

            switch(choice)
            {
                case"1":
                // Add logic for your math game here
                PerformAction("AddMethod" , AddMethod);
                break;

                case"2":
                PerformAction("MinusMethod" , MinusMethod); 
                break;

                case"3":
                 PerformAction("MultilplyMethod" , MultilplyMethod); 
                break;

                case"4":
                PerformAction("DivideMethod" , DivideMethod); 
                break;

                case"5":
                ViewGameHistory(); 
                break;

                case"6":
                continuePlay =false;
                Console.WriteLine("Thank you for play");
                break;

                default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
            }

            time.Stop();
            Console.WriteLine("Total time is"+ time);

        }
    }

    public static void PerformAction(string operation , Func<int , int, int> operations)
    {
        Console.WriteLine("Yuor Operation is :" + operation );

        Console.Write("Please Enter First Number :" );
        int num = int.Parse(Console.ReadLine());

        Console.Write("Please Enter Second Number :" );
        int num2 = int.Parse(Console.ReadLine());

        int result = operations(num, num2);
        Console.Write("Total result is :" + result );

        string resultText = "The result is" + result;
        Console.Write("Total result is :" + resultText );

        GameHistory.Add(resultText);

    }


    public static int AddMethod(int a, int b )
    {
        return (a + b);     
    }

    public static int MinusMethod(int a, int b )
    {
        return (a - b);
    }

     public static int MultilplyMethod(int a, int b )
    {
        return (a * b);
    }

     public static int DivideMethod(int a, int b )
    {
        return (a / b);
    }

    public static void ViewGameHistory()
    {   
        Console.WriteLine("View Game History");

        if (GameHistory.Count == 0)
        {
            Console.WriteLine("No Game Has play before ");
        }
        else
        {
            foreach (string game in GameHistory)
            {
                Console.WriteLine("Total game is" + game);
            }

        }


    }
}

