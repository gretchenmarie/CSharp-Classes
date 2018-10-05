using System;
using System.Collections.Generic;
using classes;

namespace classes
{
    // Create a custom type for Employee. An employee has the following properties.
    public class Employee
    {
        // First name (string)
        public string firstName { get; set; }
        // Last name (string)
        public string lastName { get; set; }
        // Title (string)
        public string title { get; set; }
        // Start date (DateTime)
        public DateTime startDate { get; set; }
    }

    // Create a custom type for Company. A company has the following properties.
    public class Company
    {
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        // Date founded (DateTime)
        public DateTime Founded { get; set; }
        // Company name (string)
        public string companyName { get; set; }

        // Employees (List<Employee>)
        // Create a public property for holding a list of current employees
        public List<Employee> currentEmployee = new List<Employee>();


    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
         public Company (string name, DateTime founded){
             Name = name;
             Founded = founded;
         }


    }

}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
          Company UrbanFood = new Company("UrbanFood",DateTime.Now);


        // Create three employees
          Employee Maxwell = new Employee()
            {
                firstName = "Maxwell",
                lastName = "Nutter",
                title = "food delivery",
                startDate = DateTime.Now
            };

            Employee Wyatt = new Employee()
            {
                firstName = "Wyatt",
                lastName = "Nutter",
                title = "Cook",
                startDate = DateTime.Now
            };

            Employee Andrew = new Employee()
            {
                firstName = "Andrew",
                lastName = "Nutter",
                title = "Manager",
                startDate = DateTime.Now
            };

        // Assign the employees to the company
        UrbanFood.currentEmployee.Add(Maxwell);
        UrbanFood.currentEmployee.Add(Wyatt);
        UrbanFood.currentEmployee.Add(Andrew);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        foreach (var employee in UrbanFood.currentEmployee)
        {
          Console.WriteLine($"{employee.firstName}{employee.lastName} works for Urban Food as {employee.title} since {employee.startDate}");
        }
    }
}

