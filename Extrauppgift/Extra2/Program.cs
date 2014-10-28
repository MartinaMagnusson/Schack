using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = " Hello H e l s i n g b o r g !";
            Console.WriteLine(RemoveSpaces(array));
            Console.ReadKey();
        }
        static string RemoveSpaces(string input)
        {
            string s = "";

            foreach (var remove in input)
            {
                if (remove != ' ')
                {
                    s+=remove; 
                }

            }
            return s;
        }

    }
}
