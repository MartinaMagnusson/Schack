using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Martina ", "Magnusson, ", "921117, ", 1000);
            Employee employee2 = new Employee("921117");
            Console.WriteLine(employee.FullName);
            Console.ReadKey();
        }
    }
}
