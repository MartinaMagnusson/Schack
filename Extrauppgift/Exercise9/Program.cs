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
            Registy registry = new Registy();
            
            var exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. Print entire registry");
                Console.WriteLine("4. Exit");

                Console.Write("Choice: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter first name: ");
                        var firstName = Console.ReadLine();
                        Console.Write("Enter last name: ");
                        var lastName = Console.ReadLine();
                        Console.Write("Enter ssn: ");
                        var ssn = Console.ReadLine();
                        Console.Write("Enter wage: ");
                        var wage = int.Parse(Console.ReadLine());
                        registry.AddNewEmployee(firstName, lastName, ssn, wage);
                        Console.WriteLine("{0} {1} was added\b\n", firstName, lastName);
                        Console.WriteLine("Pleace press enter.. ");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Enter ssn: ");
                        ssn = Console.ReadLine();
                        registry.RemoveNewEmployee(ssn);
                       
                        Console.WriteLine("This employee has been removed.\b\n");
                        Console.WriteLine("Pleace press enter.. ");
                        Console.ReadLine();
                        break;
                    case "3":
                        registry.PrintEmployee();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
