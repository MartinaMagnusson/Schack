using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___5
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            int[,] arr = new int[20, 20];
            //Add some random values to the array
            Random R = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                arr[x, y] = 1;
            }
            while (true)
            {
                Console.Clear();
                game.Print(arr);
     
                //Process the array and get a modified array back
                arr = game.ProcessGame(arr);

               // Console.ReadKey();
            }

            int xx = 0;
            int yy = 0;

            if (xx > 0 && yy > 0 && arr[xx - 1, yy - 1] > 0) Console.WriteLine("Hej");

            arr[4, 4] = 1;
            arr[4, 3] = 1;
            arr[4, 2] = 1;

            Random Rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = Rnd.Next(20);
                int y = Rnd.Next(20);
                arr[x, y] = 1;
            }

            game.Print(arr);

            int result = game.CountNeighbors(10, 10, arr);
            Console.WriteLine(result);


        }

       
    }
    public class Game
    {
        public int[,] ProcessGame(int[,] arr)
        {
            //int count = 0;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if(arr[x,y] > 0 && CountNeighbors(x, y, arr) < 2)
                    {
                        arr[x, y] = 0;
                    }
                    if (arr[x, y] > 0 && CountNeighbors(x, y, arr) > 3)
                    {
                        arr[x, y] = 0;
                    }
                    if (arr[x, y] > 0 && CountNeighbors(x, y, arr) == 2 || CountNeighbors(x, y, arr) == 3)
                    {
                        arr[x, y] = 1;
                    }
                    if (arr[x, y] == 0 && CountNeighbors(x, y, arr) == 3)
                    {
                        arr[x, y] = 1;
                    }
                }
                
            }
            return arr;
        }
        public int CountNeighbors(int x, int y, int[,] arr)
        {
            int count = 0;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y - 1] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y + 1] > 0) count++;

            return count;
        }

        public void Print(int[,] arr)
        {

            for (int y = 19; y >= 0; y--)
            {

                for (int x = 0; x < 20; x++)
                {
                    int num = arr[x, y];

                    if (num > 0)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                System.Threading.Thread.Sleep(200);

                Console.WriteLine();
            }
        }

    }
}
