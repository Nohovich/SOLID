using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        // any new functionality should be implemented by adding new classes, attributes and methods, 
        // instead of changing the current ones or existing ones.
        // Bertrand Meyer is generally credited for having originated the term open/closed principle,
        // and This Principle is considered by Bob Martin as "the most important principle of object-oriented design".
        // The simplest way to apply OCP is to implement the new functionality on new derived (sub) classes that inherit the original class implementation.
        // Another way is to allow client to access the original class with an abstract interface.
        // So, at any given point of time when there is a requirement change instead of touching the existing functionality it’s always suggested to create new classes and leave the original implementation untouched.
        static void Main(string[] args)
        {
            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empJason.ToString(),
              empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
