using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            P.SetFirstName("Kalle");
            P.SetLastName("Vessman");
            string fullName = P.GetFullName(); 
            Console.WriteLine(fullName);
            Console.ReadKey();
        }

        public class Person
        {
            private string firstName;
            private string lastName;
            public void SetFirstName(string newfirstName)
            {
                firstName = newfirstName;
            }
            public void SetLastName(string newlastName)
            {
                lastName = newlastName;
            }
            public string GetFullName()
            {
                return firstName + " " + lastName;
            }
 
        }

    }
}
