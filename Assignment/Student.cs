using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        internal Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        internal void Introduce()
        {
            Console.WriteLine($"Hello, I am {name}, {age} years old, and I am majoring in {major}.");
        }
    }

}
