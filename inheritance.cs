using System;


public class Employee{

    public string firstName;
    public string lastName;
    public string email;

    public Employee(){
        Console.WriteLine("Employee constructor run");
    }

    public Employee(string message){
        Console.WriteLine(message);
        Console.WriteLine("Employee constructor run");
    }

    public void PrintFullName(){
        Console.WriteLine("{0} {1}", firstName, lastName);
    }
    
}


public class FullTimeEmployee : Employee{
    
    public float annualSalary;

    public FullTimeEmployee() : base("Message sent"){
        Console.WriteLine("FullTimeEmployee constructor run");
    }
}


public class PartTimeEmployee : Employee{
    
    public float hourlyRate;
}


class Program{
    public static void Main(){
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.firstName = "Dave";
        fte.lastName = "Rodgers";
        fte.annualSalary = 55000.50F;
        fte.PrintFullName();
    }
}