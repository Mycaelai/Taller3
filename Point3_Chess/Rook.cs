using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Rook : Piece
    {
        public Rook(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "ROOK  ";
        }

        public override void Movement()
        {
            Console.WriteLine("The rook can move in any direction excluding diagonal movement, it cannot jump over other pieces");
        }
    }
}
