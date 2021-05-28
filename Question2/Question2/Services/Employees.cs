using System;
using System.Collections.Generic;
using System.Linq;
using Question2.Models;

namespace Question2.Services
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
        public string[] EmployeesRecordsDump { get; set; }

        #region Methods

        public Employee GetEmployeeFromDumpRecord(string employeeRecord)
        {
            Employee newEmployee = new Employee();

            if(employeeRecord != string.Empty)
            {
                string[] employeeProperties = employeeRecord.Split(',');

                newEmployee = new Employee()
                {
                    EmployeeId = employeeProperties[0],
                    ManagerId = employeeProperties[1],
                    Salary = Convert.ToInt32(employeeProperties[2]),
                    IsCeo = employeeProperties[1] == string.Empty ? true : false
                };
            }
            return newEmployee;
        }

        public List<Employee> GetEmployees(string[] employeesRecordsDump)
        {
            List<Employee> companyEmployees = new List<Employee>();
            
            foreach(string employeeRecord in employeesRecordsDump)
            {
                Employee newEmployee = this.GetEmployeeFromDumpRecord(employeeRecord);
                if(companyEmployees.Find(employee => employee.EmployeeId == newEmployee.EmployeeId) == null)
                {
                    companyEmployees.Add(newEmployee);
                }  
            }

            return companyEmployees;
        }

        public List<Employee> AddEmployeesSubordinates(List<Employee> employees)
        {
            foreach(Employee currentEmployee in employees)
            {
                if(currentEmployee.ManagerId != string.Empty)
                {
                    Employee manager = employees.Find(employee => employee.EmployeeId == currentEmployee.ManagerId);
                    manager.Subordinates.Add(currentEmployee);
                } 
            }

            return employees;
        }

        public EmployeeBudgetViewModel GetEmployeeBudget(Employee employee)
        {
            return new EmployeeBudgetViewModel()
            {
                SelectedEmployee = employee.EmployeeId,
                Budget = employee.Budget
            };
        }

        #endregion
    }
}
