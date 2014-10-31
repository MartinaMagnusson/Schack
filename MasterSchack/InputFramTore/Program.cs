using System;
 
public class Class1
{
            public Class1()
            {
 
 
                var Player1 = new Player();
                var Player2 = new Player();
 
                    DrawoBoard(Player1, Player2);
 
                while (true)
                {
 
                    var mymove = Player1.MakeMove(Player2.GetPieces());
 
            string[] board=  DrawoBoard(Player1, Player2);
                    PrintBoard(board)
                       
 
                    var mymove2 = Player2.MakeMove(Player1);
            DrawoBoard(Player1, Player2);
 
 
 
                }
 
            }
 
 
    public class Player
    {
       
        private List<Piece> pjäser =new List<Piece>();
 
 
        public Player()
        {
            /pjäser.Add(ny bonde);
            /pjäser.Add(ny bonde);
            /pjäser.Add(ny bonde);
            /pjäser.Add(ny bonde);
            /pjäser.Add(ny bonde);
            /pjäser.Add(ny drotting);
            /pjäser.Add(ny kung;
 
 
        }
 
 
        public bool DoIHavePieceAtPostiion(x , y )
        {
           
        }
 
        public bool EnemyPieceAtPostiion(x , y )
        {
           
        }
 
 
 
        public List<Piece> GetPieces()
        {
            return pjäser;
        }
 
 
        public void MOve()
        {
           
        }
 
        public Kill()
        {
           
        }
    }
 
 
 
    public class Piece
    {
       
        public override void GetPosition()
        {}
 
        //SetPosition(...)
 
 
        public override string GetSymbol()
        {
           
        }
    }
 
    public class Bonde : Piece
    {
       
    }
}