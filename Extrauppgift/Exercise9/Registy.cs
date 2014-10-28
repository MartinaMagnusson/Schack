using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Registy
    {

        private List<Employee> employeeList = new List<Employee>();
        public void AddNewEmployee(string newFirstName, string newLastName, string newBorn, int newHourlyWage)
        {
            Employee employee = new Employee(newFirstName, newLastName, newBorn, newHourlyWage);
            employeeList.Add(employee);
        }
        public void RemoveNewEmployee(string newBorn)
        {
            Employee employeeToRemove = null;
            Logger logger = new Logger();
            foreach (var employee in employeeList)
            {
                if (newBorn == employee.born)
                {
                    employeeToRemove = employee;
                }
            }
            logger.Log(employeeToRemove.FullName + " has been removed!");
            employeeList.Remove(employeeToRemove);
            
        }
        public void PrintEmployee()
        {           
            foreach (var item in employeeList)
            {
                Console.WriteLine(item.FullName);
            }
            Console.ReadLine();
        }
    }
}
