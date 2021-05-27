using System;
using System.Collections.Generic;
using System.Linq;
using Question2.Models;

namespace Question2
{
    /// <summary>
    /// Represents the employees
    /// </summary>
    public class Employees
    {
        public Employees(string records)
        {
            this.EmployeesRecordsDump = records.Split('\n');           
            

        }

        /// <summary>
        /// Gets or sets the employees
        /// </summary>
        public List<Employee> EmployeesList { get; set; }
        public string[] EmployeesRecordsDump { get; set; }

        /// <summary>
        /// Gets or sets the managers
        /// </summary>
        public List<Manager> Managers { get; set; }

        #region Methods

        // private bool FoundCeo()
        // {
        //     bool foundCeo = false;
        //     foreach(var employee in EmployeesList)
        //     {
        //         if (employee.ManagerName == string.Empty)
        //         {
        //             if (foundCeo == false)
        //             {
        //                 var ceo = new Manager(employee.EmployeeName, employee.Salary);
        //                 ceo.IsCeo = true;
        //                 Managers.Add(ceo);
        //                 foundCeo = true;
        //                 return foundCeo;
        //             }
        //             EmployeesList.Remove(employee);
        //         }                
        //     }
        //     return foundCeo;
        // }

        private void GetEmployees(string[] lines)
        {
            foreach (var line in lines)
            {
                if (line != string.Empty)
                {
                    var values = line.Split(',');

                    var employee = new Employee()
                    {
                        EmployeeId = values[0].ToString(),
                        ManagerId = values[1].ToString(),
                        Salary = Convert.ToInt32(values[2])
                    };
                    this.EmployeesList.Add(employee);
                }                
            }
        }

        public Employee GetEmployeeFromDumpRecord(string employeeRecord)
        {
            if(employeeRecord != string.Empty)

            {
                string[] employeeProperties = employeeRecord.Split(',');
                
            
                return new Employee()
                {
                    EmployeeId = employeeProperties[0],
                    ManagerId = employeeProperties[1],
                    Salary = Convert.ToInt32(employeeProperties[2]),
                    IsCeo = employeeProperties[1] == string.Empty ? true : false

                };


            }
            return new Employee();
            
           

        }



        // private void GetManagers(List<Employee> employees)
        // {
        //     FoundCeo();
        //     foreach (var employee in employees)
        //     {
        //         foreach (var emp in employees)
        //         {
        //             if(emp.EmployeeName == employee.ManagerName)
        //             {
        //                 var manager = new Manager(emp.EmployeeName, emp.Salary);
        //                 bool exists = false;
        //                 foreach(var boss in Managers)
        //                 {
        //                     if (boss.EmployeeName == manager.EmployeeName)
        //                         exists = true;
        //                 }
        //                 if (exists == false)
        //                 {
        //                     Managers.Add(manager);
        //                 }
        //             }
        //         }
        //     }
        // }

        // private void AddSubordinates(List<Employee> employees, List<Manager> managers)
        // {
        //     var subordinates = new List<Employee>();
        //     foreach (var manager in managers)
        //     {                
        //         Console.WriteLine("Manager: {0}", manager.EmployeeName);
        //         if (manager.IsCeo)
        //         {
        //             manager.addSubordinates(employees);
        //         }
        //         else
        //         {
        //             foreach(var employee in employees)
        //             {
        //                 if (manager.EmployeeName == employee.ManagerName)
        //                 {
        //                     subordinates.Add(employee);
        //                 }
        //             }
        //             manager.addSubordinates(subordinates);
        //         }

        //         foreach (var sub in manager._subordinates)
        //         {
        //             Console.WriteLine("sub: {0} - {1}", sub.EmployeeName, sub.Salary);
        //         }
        //     }

        // }

        #endregion
    }
}
