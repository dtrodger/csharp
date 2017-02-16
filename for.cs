using System;

class Program
{
    static void Main()
    {
        int[] Numbers = new int[3];
        
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        // for (int j = 0; j < Numbers.Length; j++)
        // {
        //     Console.WriteLine(Numbers[j]);
        // }

        foreach(int k in Numbers)
        {
            Console.WriteLine(k);
        }
    }
}