using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extrauppgift
{
    class Time
    {
        private double seconds;
        //public double Hours
        //{
        //    get
        //    {
        //        return seconds / 3600;
        //    }
        //    set
        //    {
        //        if (seconds < 0)
        //        {
        //            seconds = 0;
        //        }
        //        else
        //        {
        //            seconds = value * 3600;
        //        }
        //    }
        public double Hours { get; set; } //private och piblic går att skriva in i get, set
        public void DoStuff()
        { Hours = Hours + 1; }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Hours = 12;
            Console.WriteLine(time.Hours);
            //string[] array = new string[] { "Hello", "Max", "Hi", "Hello" };
            //Console.WriteLine(CountHello(array));


            //string str = "     Hej!     ";
            //Console.WriteLine("'{0}'", str.Trim());
            //Console.WriteLine("'{0}'", str.TrimStart());
            //Console.WriteLine("'{0}'", str.TrimEnd());

            //string str1 = "   A B C D E F   ".Replace(" ", "");
            //Console.WriteLine("'{0}'", str1);
            //string str2 = "   A B C D E F   ".Replace(" ", ", ");
            //Console.WriteLine("'{0}'", str2);
            //string str3 = "   Hi Hi Hi Hi   ".Replace("Hi", "Ha");
            //Console.WriteLine("'{0}'", str3);

            //string input = "1,2,3.4:5";
            //string[] nummer = input.Split(new char[] { ',',':','.' });
            //foreach (var ny in nummer)
            //{
            //    Console.WriteLine(ny);
            //}
            //string nummer1 = String.Join(",", input);
            //foreach (var ny in nummer1)
            //{
            //    Console.WriteLine(ny);
            //}

            //double kr = 50;
            //Console.WriteLine("Du har {0:C}", kr);
            //Console.ReadLine();

            //1
            //var input = Console.ReadLine();

            //char num1 = input[0];
            //char num2 = input[1];



            //if (input.IndexOf("(") < input.IndexOf(")"))
            //    {
            //        Console.WriteLine("Ok");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }


            //2

            //string inläst = Console.ReadLine();
            //var nummer = inläst.Replace("+46", "") + inläst.Replace(".", "");
            //Console.WriteLine(nummer);

            //string tal = Console.ReadLine();
            //var nummer2 = tal.Replace(".", "");
            //Console.WriteLine(nummer2);

            //string nums = "1,2,3,-4,-5";
            //string[] numarr = nums.Split(new char[] { ',' });
            //for (int i = 0; i < numarr.Length; i++)
            //{
            //    string num = numarr[i];
            //    string fix = "";
            //    if (int.Parse(num)>= 0)
            //    {
            //        numarr[i] = "";
            //        fix = fix + num + ",";
            //    }

            //}
            //string newNums = string.Join(",", numarr);
            //Console.WriteLine(newNums);

            //foreach (var num in numarr)
            //{
            //    Console.WriteLine(num);
            //}



            //var str = new StringBuilder();
            //str.Append("Hej ");
            //str.Append("!!");
            //str.Insert(5, ",");
            //str.Replace("!!", "!");
            ////str.Remove("");
            //str.AppendLine("HejHej");
            //Console.WriteLine(str);

            //Console.Write("Skriv in ditt namn: ");
            //var name = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();
            //sb.AppendFormat("Hej {0}!", name);

            //Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }



        //static int CountHello(string[] hellos)
        //{
        //    int a = 0;
        //    foreach (var h in hellos)
        //    {
        //        if (h == "Hello")
        //        {
        //            a++;
        //        }
        //    }
        //    return a;
        //}
    }
}
