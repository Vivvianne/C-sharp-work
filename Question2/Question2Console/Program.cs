using Question2;
using System.IO;
using System;
using Question2.Models;
using System.Collections.Generic;

namespace Question2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string filetext = File.ReadAllText("employeelist.csv");
            Employees employees = new Employees(filetext);
            List<Employee> companyEmployees = new List<Employee>();
            foreach(string employeeRecord in employees.EmployeesRecordsDump)
            {
                Employee newEmployee = employees.GetEmployeeFromDumpRecord(employeeRecord);
                if(companyEmployees.Find(employee => employee.EmployeeId == newEmployee.EmployeeId) == null)
                {
                    companyEmployees.Add(newEmployee);

                }
                
                
            }

            foreach(Employee companyEmployee in companyEmployees)
            {
                if(companyEmployee.ManagerId != string.Empty)
                {
                    Employee manager = companyEmployees.Find(employee => employee.EmployeeId == companyEmployee.ManagerId);
                    manager.Subordinates.Add(companyEmployee);

                }
                
            }
            Employee employee1 = companyEmployees.Find(employee => employee.EmployeeId == "Employee1");
            Console.WriteLine(employee1.IsCeo);
            Console.WriteLine(employee1.Subordinates.Count);

            
           

        }
    }
}
