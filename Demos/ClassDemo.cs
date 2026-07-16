using System;

namespace Demos
{
    class ClassDemo
    {
        static void Main(string[] args)
        {
            // Student student = new Student();
            Student student = new Student();
            student.firstName = "John";
            student.lastName = "Doe";
            Console.WriteLine("First Name: " + student.firstName + " \nLast Name: " + student.lastName + "\n\n***Bang Bang****");
            Console.ReadLine();
        }
    }

// Class - in this case we are creating a template for creating objects
    public class Person
    {
        // Properties
        public string? firstName { get; set; }
        
        // added ? to make it nullable = allows the property to be null -> This will be an issue if you are using C# 8.0 or later with nullable reference types enabled. It indicates that the property can hold a null value.
        public string? lastName{ get; set; }

    }

// Class Inheritance - here we are using the (template) Person class as a base class and creating a derived class called Student. The Student class inherits the properties of the Person class, allowing it to access and use those properties.
    public class Student : Person
    {
        // public Student()
        // {            
        //     firstName = "John";
        //     lastName = "Doe";
        // }

        // public string fName = "John";
        // public string lName = "Doe";
    }


// There are a few different ways to populate the properties of a class in C#. Here are some common approaches:
// 1. Using a Constructor: You can define a constructor in your class that takes parameters and initializes the properties when an object is created. This allows you to set the values of the properties at the time of object creation.       
// 2. Using Object Initializers: C# provides a convenient syntax called object initializers that allows you to set the properties of an object directly after its creation. This approach is often used when you want to initialize multiple properties at once.    
// 3. Using Methods: You can create methods within your class that allow you to set the values of the properties. This approach is useful when you want to encapsulate the logic for setting the properties or perform additional validation before assigning values.   
// 4. Using Property Setters: If your properties have public setters, you can directly assign values to them after creating an object. This approach is straightforward and allows you to modify the properties at any time.    

}