using Question2.Services;
using System.IO;
using System;
using Question2.Models;
using System.Collections.Generic;
using System.Linq;


namespace Question2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine($"Reading the the file {args[0]}..... \n \n");
                string filetext = File.ReadAllText(args[0]);
                Employees employeesRecords = new Employees(filetext);
                
                Console.WriteLine($"Listing the employees from the file {args[0]}....");
                foreach(string employeeRecordDump in employeesRecords.EmployeesRecordsDump)
                {
                    Console.WriteLine(employeeRecordDump);
                }
                Console.WriteLine("Listing Complete. \n");

                Console.WriteLine("Adding the employee subordinates...\n");
                List<Employee> employees = employeesRecords.GetEmployees(employeesRecords.EmployeesRecordsDump);
                employees = employeesRecords.AddEmployeesSubordinates(employees);
                Console.WriteLine("Adding employee subordinates completed\n");

                Console.WriteLine($"Calculating the budget for employee by the identification {args[1]}\n");
                EmployeeBudgetViewModel employeeBudget = employeesRecords.GetEmployeeBudget(employees.Find(employee => employee.EmployeeId == args[1]));

                Console.WriteLine($"Calculation completed.");
                Console.WriteLine($"Selected employee: {employeeBudget.SelectedEmployee}");
                Console.WriteLine($"Employee budget: {employeeBudget.Budget}");
            }
            else 
            {
                Console.WriteLine("The program expects two arguments:");
                Console.WriteLine("\t 1. The file path to read employee records.");
                Console.WriteLine("\t 2. The employee to calculate the budget for");
            }
        }
    }
}
