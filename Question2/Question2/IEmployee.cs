using System.Collections;

namespace Question2
{
    /// <summary>
    /// Represents an interface of the employee
    /// </summary>
    public interface IEmployee
    {
        int getSalary();
        int getSalaries();
        string getName();
        bool isLeaf();
        void add(IEmployee emp);
        IEnumerator getSubordinates();
        IEmployee getChild();
    }
}
