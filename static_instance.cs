using System;

class Circle{

    static float _pi;
    int _radius;

    static Circle(){
        Console.WriteLine("Static constructor run.");
        Circle._pi = 3.141F;
    }

    public Circle(int radius){
        Console.WriteLine("Instance constructor run.");
        this._radius = radius;
    }

    public static void Print(){
        Console.WriteLine("Static method");
    }

    public float CalculateArea(){
        return _pi * this._radius * this._radius;
    }
}

class Program{

    public static void Main(){
        Circle c1 = new Circle(5);
        float area1 = c1.CalculateArea();
        Console.WriteLine(area1);

        Circle c2 = new Circle(6);
        float area2 = c2.CalculateArea();
        Console.WriteLine(area2);
    }
}