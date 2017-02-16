using System;
using ObjectAndClasses.TestClass;

class Program
{
    private static void TestClass()
    {
        TestClass class1 = new TestClass();
        TestClass class2 = new TestClass();

        class1.CustomerID = "BBBBBBB";
        class2.CustomerID = "CCCCCCC";

        Console.WriteLine(class1.CustomerID);

        class1.DisplayID();
    }
}