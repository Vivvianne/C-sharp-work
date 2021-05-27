using System.Collections;
using System.Collections.Generic;

namespace Question2.Models
{
    /// <summary>
    /// Represents a manager
    /// </summary>
    public class Manager : Employee
    {        

        public Manager(string employeeId, int salary) : base(employeeId, salary)
        {
            this.EmployeeId = employeeId;
            this.Salary = salary;
        }

    //     public override void addSubordinates(List<Employee> emps)
    //     {
    //         foreach (var emp in emps)
    //         {
    //             _subordinates.Add(emp);
    //         }            
    //     }

    //     public override int getSalaries()
    //     {
    //         int sum;
    //         Employee esub;
    //         //get the salaries of the manager and subordinates
    //         sum = getSalary();
    //         IEnumerator enumSub = _subordinates.GetEnumerator();
    //         while (enumSub.MoveNext())
    //         {
    //             esub = (Employee)enumSub.Current;
    //             sum += esub.getSalaries();
    //         }
    //         return sum;
    //     }
     }
}
