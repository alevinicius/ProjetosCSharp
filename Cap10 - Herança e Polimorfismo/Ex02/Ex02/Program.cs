using System;
using System.Globalization;
using System.Collections.Generic;
using Ex02.Entities;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                Employee employee;

                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string outsourced = (Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                }
                else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }
                employees.Add(employee);
                Console.WriteLine();
            }

            Console.WriteLine();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
