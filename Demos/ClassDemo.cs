using System;

namespace Demos
{
    class ClassDemo
    {
        static void Main(string[] args)
        {
            // Demo 1: Class Creation
            EmptyClass emptyClass = new EmptyClass();
            Console.WriteLine("Class object created: " + emptyClass.GetType().Name);

            // Demo 2: Class Inheritance
            Student student = new Student();
            Console.WriteLine("Class object created: " + student.GetType().Name);

            // Demo 3: Class Properties
            Animal Dog = new Animal();
            Dog.Name = "Rover";
            Dog.DisplayName();
            
            //The End
            Console.ReadLine();


        }
    }
    

// Demo 1: Class Creation
    public class EmptyClass
    {
        //Empty Class
    }



// Demo 2: Class inheritance
    // Person class is the base class, and Student class is the derived class that inherits from Person.
    public class Person{
        private string? _firstName;
        private string? _lastName;

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
    }
    // student class inherits the properties and methods of the Person class, allowing it to access and use those members.
    public class Student : Person
    {
        // this class demonstrates inheritance, where the Student class inherits
        // the properties and methods of the Person class, allowing it to access and use those members.

    }


// Demo 3: Class properties 
    public class Animal 
    {
        string? _name;
        public string Name
        {
            //properties are used to encapsulate the private field _name and provide controlled access to it.
            get { return this._name; }
            set { this._name = value; }
        }

        //functionality to return the property value.
        public void DisplayName()
        {
            Console.WriteLine("Animal Name: " + this._name);
        }
    }


// Demo 4: Class methods
    public class Parser 
    {
        string ? _input;
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        //Method
        public void ParseInput()
        {
            Console.WriteLine("Parsing Input: " + this._input);
        }
    }


// Demo 5: Class constructors




// Demo 6: Class encapsulation
// Demo 7: Class polymorphism
// Demo 8: Class abstraction
// Demo 9: Class interfaces
// Demo 10: Class access modifiers
// Demo 11: Class static members
// Demo 12: Class nested classes
// Demo 13: Class partial classes
// Demo 14: Class generics
// Demo 15: Class events and delegates
// Demo 16: Class attributes and reflection
// Demo 17: Class serialization and deserialization
// Demo 18: Class exception handling
// Demo 19: Class design patterns
// Demo 20: Class best practices