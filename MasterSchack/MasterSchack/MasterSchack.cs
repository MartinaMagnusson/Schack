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
            var chessboard = new string[9, 9];

            Pawns pawns = new Pawns();
            

            //Black start position
            chessboard[0, 1] = pawns.Pawn("RB1 ");
            chessboard[0, 2] = "KnB1";
            chessboard[0, 3] = "BB1 ";
            chessboard[0, 4] = "QB  ";
            chessboard[0, 5] = "KB  ";
            chessboard[0, 6] = "BB2 ";
            chessboard[0, 7] = "KnB2";
            chessboard[0, 8] = "RB2 ";

            chessboard[1, 1] = pawns.Pawn( "P1  ");
            chessboard[1, 2] = pawns.Pawn("P2  ");
            chessboard[1, 3] = pawns.Pawn("PB3 ");
            chessboard[1, 4] = pawns.Pawn("PB4 ");
            chessboard[1, 5] = pawns.Pawn("PB5 ");
            chessboard[1, 6] = pawns.Pawn("PB6 ");
            chessboard[1, 7] = pawns.Pawn("PB7 ");
            chessboard[1, 8] = pawns.Pawn("PB8 ");

            //White start position
            chessboard[7, 1] = "Rw1 ";
            chessboard[7, 2] = "KnW1";
            chessboard[7, 3] = "BW1 ";
            chessboard[7, 4] = "QW  ";
            chessboard[7, 5] = "KW  ";
            chessboard[7, 6] = "BW2 ";
            chessboard[7, 7] = "KnW2";
            chessboard[7, 8] = "RW2 ";

            chessboard[6, 1] = "PW1 ";
            chessboard[6, 2] = "PW2 ";
            chessboard[6, 3] = "PW3 ";
            chessboard[6, 4] = "PW4 ";
            chessboard[6, 5] = "PW5 ";
            chessboard[6, 6] = "PW6 ";
            chessboard[6, 7] = "PW7 ";
            chessboard[6, 8] = "PW8 ";

            chessboard[0,0] = "8";
            chessboard[1,0] = "7";
            chessboard[2,0] = "6";
            chessboard[3,0] = "5";
            chessboard[4,0] = "4";
            chessboard[5,0] = "3";
            chessboard[6,0] = "2";
            chessboard[7,0] = "1";

            chessboard[8, 1] = " A  ";
            chessboard[8, 2] = " B  ";
            chessboard[8, 3] = " C  ";
            chessboard[8, 4] = " D  ";
            chessboard[8, 5] = " E  ";
            chessboard[8, 6] = " F  ";
            chessboard[8, 7] = " G  ";
            chessboard[8, 8] = " H  ";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(chessboard[i,j] + " ");
                }
                Console.WriteLine("\n\b");
            }
            Console.ReadKey();
        }
    }
}
