using System;

class Program
{
    static void Main()
    {
        // float f = 234.54F;
        // int i = Convert.ToInt32(f);
        // Console.WriteLine(i);

        // string strNumber = "100";
        // int the = int.Parse(strNumber);
        // Console.Write(the);

        string strNum = "100";
        int result = 0;
        bool isConversionSuccessful = int.TryParse(strNum, out result);

        if (isConversionSuccessful)
        {
            Console.Write(result);
        }
    }
}