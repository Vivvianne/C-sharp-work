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

        #endregion
    }
}
