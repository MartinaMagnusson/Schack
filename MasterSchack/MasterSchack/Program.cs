using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSchack
{
    class Program
    {
        static void Main(string[] args)
        {
            var chessboard = new string[8, 8];

            //Black start position
            chessboard[0, 0] = "RB1 ";
            chessboard[0, 1] = "KnB1";
            chessboard[0, 2] = "BB1 ";
            chessboard[0, 3] = "QB  ";
            chessboard[0, 4] = "KB  ";
            chessboard[0, 5] = "BB2 ";
            chessboard[0, 6] = "KnB2";
            chessboard[0, 7] = "RB2 ";

            chessboard[1, 0] = "PB1 ";
            chessboard[1, 1] = "PB2 ";
            chessboard[1, 2] = "PB3 ";
            chessboard[1, 3] = "PB4 ";
            chessboard[1, 4] = "PB5 ";
            chessboard[1, 5] = "PB6 ";
            chessboard[1, 6] = "PB7 ";
            chessboard[1, 7] = "PB8 ";

            //White start position
            chessboard[7, 0] = "Rw1 ";
            chessboard[7, 1] = "KnW1";
            chessboard[7, 2] = "BW1 ";
            chessboard[7, 3] = "QW  ";
            chessboard[7, 4] = "KW  ";
            chessboard[7, 5] = "BW2 ";
            chessboard[7, 6] = "KnW2";
            chessboard[7, 7] = "RW2 ";

            chessboard[6, 0] = "PW1 ";
            chessboard[6, 1] = "PW2 ";
            chessboard[6, 2] = "PW3 ";
            chessboard[6, 3] = "PW4 ";
            chessboard[6, 4] = "PW5 ";
            chessboard[6, 5] = "PW6 ";
            chessboard[6, 6] = "PW7 ";
            chessboard[6, 7] = "PW8 ";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(chessboard[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
