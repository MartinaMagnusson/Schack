using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Employee
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string fullName { get; set; }
        private string born { get; set; }
        private double hourlyWage { get; set; }


        public Employee(string newFirstName, string newLastName, string newBorn, double newHourlyWage)
        {
            firstName = newFirstName;
            lastName = newLastName;
            born = newBorn;
            hourlyWage = newHourlyWage;
        }
        public Employee(string newBorn)
        {
            born = newBorn;
        }

        public string FullName
        {
            get { return fullName = firstName + " " + lastName; }
        }

    }
}
