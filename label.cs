using System;

class Program
{
    static void Main()
    {
        int checkoutPrice = 0;

        Start:

        Console.WriteLine("Enter a coffee size (1,2,3)");
        string userChoice = Console.ReadLine();
        int userChoiceNum;

        if (!Int32.TryParse(userChoice, out userChoiceNum))
        {
            Console.WriteLine("Please enter an integer");
            goto Start;
        }
        
        switch (userChoiceNum)
        {
            case 1:
                checkoutPrice += 1;
                break;
            case 2:
                checkoutPrice += 2;
                break;
            case 3:
                checkoutPrice += 3;
                break;
            default:
                Console.WriteLine("Invalid Choice");
                goto Start;
        }

        Console.WriteLine("Would you like to make another purchase?");
        string userDecision = Console.ReadLine();

        if (userDecision == "Yes")
        {
            goto Start;
        }

        Console.WriteLine(checkoutPrice);
    }
}