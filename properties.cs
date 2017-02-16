using System;

public class Student{

    private int _id;
    private string _name;
    private int _passMark;

    public void SetId(int id){
        if(id <= 0){
            throw new Exception("Student ID cannot be negative.")
        }
    }
}

public class Program{

    public static void Main(){
        Student s = new Student();
        s.id = -1;
        Console.WriteLine(s.id);
    }
}
