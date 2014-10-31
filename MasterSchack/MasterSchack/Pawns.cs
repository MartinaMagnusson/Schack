using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSchack
{
    class Pawns
    {
        /*
         * Kan ta två steg första rundan
         * Annars ett steg
         * Atakerat diagonalt frammåt 
         */

        public XY position;
        public string name = "Bonde";
        public string boardName = "B   ";

        public Pawns(int x, int y)
        {
            position = new XY();
            position.x = x;
            position.y = y;
        }


    }

    public class XY
    {
        public int x;
        public int y;

    }
}
