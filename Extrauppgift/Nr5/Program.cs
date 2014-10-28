using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[20, 20];
            Print(RandomNumber(array));
            Console.WriteLine(CountNeighbors(10, 10, array));


            Console.ReadKey();
        }
        public static void Print(int[,] array)
        {



            for (int y = 0; y <= 19; y++)
            {
                for (int x = 0; x <= 19; x++)
                {

                    if (array[y, x] > 0)
                    {
                        if (x == 19)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        if (x == 19)
                        {
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }


            }


        }
        public static int[,] RandomNumber(int[,] array)
        {

            Random rnd = new Random();
            int yRandom;
            int xRandom;
            for (int i = 0; i <= 49; i++)
            {
                do
                {
                    yRandom = rnd.Next(0, 19);
                    xRandom = rnd.Next(0, 19);
                }
                while (array[yRandom, xRandom] != 0);
                array[yRandom, xRandom] = rnd.Next(1, 50);
            }
            return array;
        }
        private static int CountNeighbors(int x, int y, int[,] array)
        {
            int count = 0;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x - 1, y - 1] > 0)
                count++;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x , y - 1] > 0)
                count++;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x + 1, y - 1] > 0)
                count++;


            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x - 1, y] > 0)
                count++;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x + 1, y] > 0)
                count++;

           
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x - 1, y + 1] > 0)
                count++;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x, y + 1] > 0)
                count++;
            if (x > 0 && y > 0 && x < 20 && y < 20 && array[x + 1, y + 1] > 0)
                count++;


            return count;
        }
    }
}
