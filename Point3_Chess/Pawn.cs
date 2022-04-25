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
            Console.WriteLine("The pawn can move only one square forward.");
            position[0] = +1;
        }
    }
}
