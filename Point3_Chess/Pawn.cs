using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Pawn : Piece
    {
        public Pawn(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "PAWN  ";
        }

        public override void Movement()
        {
            //Column {0}, lane {1}
            position[0] = +1;
        }
    }
}
