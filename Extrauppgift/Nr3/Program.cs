using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Value value = new Value();
            var array = new int[] { 10, 50, 60, 70, 20, 10, 30, 40, 53, 12 };

            value.CalculateAverageValueFromArray(array);
            Console.WriteLine(value.GetMaxValueFromArra(array));
            Console.WriteLine(value.GetMinValueFromArray(array));
            Console.WriteLine(value.CalculateAverageValueFromArray(array));
            Console.ReadKey();
        }
        public class Value
        {
            public int GetMaxValueFromArra(int[] array)
            {
                int maxValue = int.MinValue;
                foreach (var max in array)
                {
                    if (maxValue < max)
                    {
                        maxValue = max;
                    }
                }
                return maxValue;
            }
            public int GetMinValueFromArray(int[] array)
            {
                int minValue = array[0];
                foreach (var min in array)
                {
                    if (minValue > min)
                    {
                        minValue = min;
                    }

                }
                return minValue;
            }
            public int CalculateAverageValueFromArray(int[] array)
            {
                if (array.Length == 0)
                    return 0;

                int calculate = array[0];
                var sum = 0;

                for (int i = 0; i < array.Length; i++)
                {

                    sum += array[i];
                    calculate = sum / array.Length;

                }
                return calculate;
            }

        }
    }
}
