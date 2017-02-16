// Class


// Template for an object
// Classes are created by constructors which create an instance of the class or an object
// System.IO.FileInfo fi = new SYstem.IO.FileInfo("fjdsklf")

// new keyword creates a new instance of the type and hands you back a reference
// code inside the class is caled a constructors
// code inside class that runs as class is created is caled the constructors
// class can have multiple constructors

// static vs instance 
// statis members work with all instances of the class
// Directory.CreateDirectory does not require an instance - service provided by class

// instance members work only with a specific instance
// example FileInfo.Length is an instance member: requires a specifi file to work

// FileInfo and DirectoryInfo refer to a specific file/directory
// File and Directory work with all files/directories

// object represents a thing
// things have properties, methods and events

// Static Vs. Instance

// class SomeClass {
//     public int InstanceMethod() { return 1; }
//     public static int StaticMethod() { return 42; }
// }
// In order to call InstanceMethod, you need an instance of the class:

// SomeClass instance = new SomeClass();
// instance.InstanceMethod();   //Fine
// instance.StaticMethod();     //Won't compile

// SomeClass.InstanceMethod();  //Won't compile
// SomeClass.StaticMethod(); 


// Assembly

// An assembly is the compiled output of your code, typically a DLL, but your EXE is also an assembly. It's the smallest unit of deployment for any .NET project.

// The assembly typically contains .NET code in MSIL (Microsoft Intermediate language) that will be compiled to native code ("JITted" - compiled by the Just-In-Time compiler) the first time it is executed on a given machine. That compiled code will also be stored in the assembly and reused on subsequent calls.

// The assembly can also contain resources like icons, bitmaps, string tables and so on. Furthermore, the assembly also contains metadata in the assembly manifest - information like version number, strong name, culture, referenced assemblies and so forth.

// In 99% of your cases, one assembly equals a physical file on disk - the case of a multi-file assembly (one assembly, distributed across more than a single file) appears to be a rather odd-ball edge case which I've never encountered so far in my 5+ years of .NET development.

// In a multifile assembly there would still be only one assembly manifest in a DLL or EXE and the MSIL code in multiple netmodule files.

// Public, private, protected

// public
// The type or member can be accessed by any other code in the same assembly or another assembly that references it.

// private
// The type or member can only be accessed by code in the same class or struct.

// protected
// The type or member can only be accessed by code in the same class or struct, or in a derived class.

// internal
// The type or member can be accessed by any code in the same assembly, but not from another assembly.

// protected internal
// The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly.

// void

// R f(void) - Function parameters are absent
// void f(P) - Return value is absent
// void *p - Type of what is pointed to is absent
// (void) p - Usage of value is absent

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAndClasses
{
    public class TestClass
    {
        ///<summary>
        /// Customer ID value
        ///</summary>
        public string CustomerID = null;

        /// <summary>
        /// Display the CustomerID
        /// </summary>
        public void DisplayID()
        {
            Console.WriteLine(this.CustomerID);
        }

        public void DisplayID(string Text)
        {
            Console.WriteLine(Text + ": " + this.CustomerID);
        }

    }


    public class Program
    {
        static void Main()
        {
            TestClass some = new TestClass();

            some.CustomerID = "AAAAAA";
            Console.WriteLine(some.CustomerID);
            some.DisplayID();
            some.DisplayID("HI THERE");
        }
    }
}
