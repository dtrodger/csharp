using System;


public class BaseClass{

    public virtual void Print(){
        Console.WriteLine("I am the Base class.");
    }
}

public class DerivedClass : BaseClass{

    // public new void Print(){
    public override void Print(){
        Console.WriteLine("I am a Derived class print method");
    }
}

public class Program{

    static void Main(){
        BaseClass b = new DerivedClass();
        b.Print();

        DerivedClass d = new DerivedClass();
        d.Print();
    }
}
