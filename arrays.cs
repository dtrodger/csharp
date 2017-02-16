using System;

class Program
{
    static void Main()
    {
        int userNumber = int.Parse(Console.ReadLine());
        
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 0;
        evenNumbers[1] = 2;
        evenNumbers[2] = 3;

        Console.WriteLine(evenNumbers[1]);
    }
}