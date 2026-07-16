using System;

namespace Demos
{
    class ClassDemo
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.firstName);
            Console.ReadLine();
        }
    }

// Class
    public class Person
    {
        public string? firstName { get; set; }
        //public string lastName{ get; set; }

    }

// Class Inheritance
    public class Student : Person
    {
        public Student()
        {
            firstName = "\n John Wick **Bang Bang**";
        }
    }
}s