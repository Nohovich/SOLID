using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        // Derived types must be completely substitutable for their base types More formally,
        // the Liskov substitution principle(LSP) is a particular definition of a subtyping relation, called(strong) behavioral subtyping
        // This Principle is introduced by Barbara Liskov in 1987 during her conference address on Data abstraction and hierarchy
        // This principle is just an extension of the Open Close Principle.
        // No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
        // We should also ensure that Clients should not know which specific subtype they are calling, nor should they need to know that.The client should behave the same regardless of the subtype instance that it is given.
        // And last but not the least, New derived classes just extend without replacing the functionality of old classes
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}
