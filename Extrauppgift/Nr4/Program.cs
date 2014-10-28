using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5; 
            int y = 3; 
            int z = 199; 
            bool flag = false;
            //should return TRUE

            Console.WriteLine(CheckCondition(x, y, z, flag));
            x = 4; 
            //Lets make the condition false
            //should return FALSE
            Console.WriteLine(CheckCondition(x, y, z, flag));
            Console.ReadKey();
            
        }
        public static bool CheckCondition(int x, int y, int z, bool flag)
        {
            if (z > 10 && z < 20 && flag == true)
            { 
                return true; 
            }
            else if (y>10 && y < 20 && z == 0 && flag == true)
            {
                return true; 
            }
            else if (x == 5 && y == 3 && z >= 99 && flag == false)
            {
                return true;
            }
            return false; 
        }
    }
}
