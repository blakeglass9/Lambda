using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a list of 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Sam", LastName = "Green" },
                new Employee { Id = 6, FirstName = "Chris", LastName = "Blue" },
                new Employee { Id = 7, FirstName = "Emma", LastName = "White" },
                new Employee { Id = 8, FirstName = "Mike", LastName = "Black" },
                new Employee { Id = 9, FirstName = "Sara", LastName = "Yellow" },
                new Employee { Id = 10, FirstName = "Tom", LastName = "Purple" }
            };

            // Step 2: Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joeEmployeesForeach = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeEmployeesForeach.Add(employee); // Add employee to new list if the first name is "Joe"
                }
            }

            // Display the results
            Console.WriteLine("Employees with the first name 'Joe' (using foreach):");
            foreach (Employee joe in joeEmployeesForeach)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Step 3: Using a lambda expression to create a list of all employees with the first name "Joe"
            List<Employee> joeEmployeesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display the results
            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda):");
            foreach (Employee joe in joeEmployeesLambda)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Step 4: Using a lambda expression to create a list of employees with an ID greater than 5
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Display the results
            Console.WriteLine("\nEmployees with ID greater than 5:");
            foreach (Employee emp in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Pause the console so the user can read the output
            Console.ReadKey();
        }
    }
}
