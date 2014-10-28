using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._1
{
    public class Filter
    {
        public List<int> GetNumbersBeetween5and10(List<int> nums)
        {
            List<int> nummer = new List<int>();
            foreach (var item in nums)
            {
                if (item >= 5 && item <= 10)
                {
                    nummer.Add(item);
                }
            }
            return nummer;
        }
        public int GetMaxValue(List<int> nums)
        {
            var maxValue = 0;
            foreach (var item in nums)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
        public int GetSum(List<int> nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum;
        }
        public List<int> Position(List<int> nums)
        {
            List<int> lista = new List<int>();
            foreach (var item in nums)
            {
                if(nums.FindIndex <= 5)
                {
                    lista.
                }
            }
            return lista;
        }
    }
}
