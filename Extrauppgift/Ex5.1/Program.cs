using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nums2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Filter filter = new Filter();
            var hej = filter.GetNumbersBeetween5and10(nums1);
            foreach (var item in hej)
            {
                Console.WriteLine(item);
            }
            var hejdå = filter.GetNumbersBeetween5and10(nums2);
            foreach (var item in hejdå)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            Console.WriteLine(filter.GetMaxValue(nums1));
            Console.WriteLine(filter.GetMaxValue(nums2));

            Console.WriteLine();

            Console.WriteLine(filter.GetSum(nums1));
            Console.WriteLine(filter.GetSum(nums2));

            Console.ReadLine();
        }
    }
}
