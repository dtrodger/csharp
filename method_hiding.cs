using System;

public class Employee{

    public string firstName;
    public string lastName;

    public void PrintFullName(){
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class PartTimeEmployee : Employee{
    public new void PrintFullName(){
        base.PrintFullName();
        // Console.WriteLine("Part Time Employee - " + firstName + " " + lastName);
    }
}

public class FullTimeEmployee : Employee{
    public new void PrintFullName(){
        Console.WriteLine("Full Time Employee - " + firstName + " " + lastName);
    }
}

public class Program{

    public static void Main(){
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.firstName = "Dave";
        fte.lastName = "Rodgers";
        fte.PrintFullName();

        PartTimeEmployee pte = new PartTimeEmployee();
        pte.firstName = "Mike";
        pte.lastName = "Kaysen";
        pte.PrintFullName();
    }
}