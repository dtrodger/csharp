using System;


class Customer{

    string _firstName;
    string _lastName;

    // Constructor
    public Customer(string firstName = "Not Provided", string lastName = "Not Provided"){
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void FullName(){
        Console.WriteLine("{0}", this._firstName + " " + this._lastName);
    }

    // Destructors
    ~Customer(){
        // Clean up code
    }
}


class Program{

    static void Main(){
        Customer c1 = new Customer();
        c1.FullName();
    }
}