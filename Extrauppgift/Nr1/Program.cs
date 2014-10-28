using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            int[] numbers = new int[3];
                 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Skriv in ett tal: ");
                }
                else
                {
                    Console.Write("Skriv in ett nytt tal: ");
                }
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Största talet är {0} oc minsta är {1}", number.GetMaxValue(numbers), number.GetMinValue(numbers));
            Console.ReadKey();



        }
    }
    public class Numbers
    {
        public int GetMaxValue(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
               if(numbers[0] > numbers[1] && numbers[0] > numbers[2])
               {
                   max = numbers[0];
               }
                else if(numbers[1] > numbers[0] && numbers[1] > numbers[2])
               {
                   max = numbers[1];
               }
                else
               {
                    max = numbers[2];
                }
            }
            return max;
        }
        public int GetMinValue(int[] numbers)
        {
            int min = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[0] < numbers[1] && numbers[0] < numbers[2])
                {
                    min = numbers[0];
                }
                else if (numbers[1] < numbers[0] && numbers[1] < numbers[2])
                {
                    min = numbers[1];
                }
                else
                {
                    min = numbers[2];
                }
            }
            return min;
        }
    }
}
