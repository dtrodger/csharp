// Passing by value vs passing by reference
// reference points to the same memory location

using System;

class Program{



    // Parameters by Value

    // public static void Main(){
    //     int i = 0;

    //     SimpleMethod(i);

    //     Console.WriteLine(i);
    // }

    // public static void SimpleMethod(int j){
    //     j = 101;
    // }




    // Parameters by reference

    // public static void Main(){
    //     int i = 0;

    //     SimpleMethod(i);

    //     Console.WriteLine(i);
    // }

    // public static void SimpleMethod(int j){
    //     j = 101;
    // }




    // Output Parameters

    // public static void Main(){
    //     int? sum = null;
    //     int? product = null;

    //     Calculate(10, 20, out sum, out product);

    //     Console.WriteLine("Sum = {0} Product = {1}", sum, product);
    // }

    // public static void Calculate(int num1, int num2, out int? sum, out int? product){
    //     sum = num1 + num2;
    //     product = num1 * num2;
    // }

    public static void Main(){
        int[] nums = new int[100];

        for (int num = 0; num < 100; num++){
            nums[num] = num;
        }
        
        ArrayInfo();
        ArrayInfo(1,2,3,4,5,6);
        ArrayInfo(nums);
    }

    // params keyword makes params optional
    // params must be defined first
    // cannot have multiple parameter arrays
    public static void ArrayInfo(params int[] numbers){
        Console.WriteLine("There are {0} items in the input array.", numbers.Length);

        foreach(int num in numbers){
            Console.WriteLine(num);
        }
    }
}