using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question2.Models
{
    /// <summary>
    /// Represents an employee
    /// </summary>
    public class Employee
    {
        #region fields

        protected int _salary;
        protected string _name;

        private List<Employee> _subordinates;

        #endregion

       

       
        #region constructor
        public Employee()
        {

        }

        public Employee(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Employee identifier
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the manager identifier
        /// </summary>
        public string ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the salary of the employee
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Gets or sets the budget of the employee
        /// </summary>
        public int Budget 
        {
            get 
            {
                return this.Salary + this.Subordinates.Sum(subordinate => subordinate.Budget);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the employee is the CEO
        /// </summary>
        public bool IsCeo { get; set; }

        public List<Employee> Subordinates
        {
            get
            {
                return _subordinates ?? (_subordinates= new List<Employee>());
            }
            set
            {
                _subordinates = value;
            }
        }

        #endregion
    }
}
