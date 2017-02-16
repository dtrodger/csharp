using System;

public class Program{

    public static void Main(){
        Add(4.0f, 5.2f);
    }

    public static void Add(int fn, int sn){
        Console.WriteLine("1 Sum {0}", fn + sn);
    }

    public static void Add(float fn, float sn, out int Sum){
        Console.WriteLine("2 Sum {0}", fn + sn);
    }
}