using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class King : Piece
    {
        public King(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "KING  ";
        }

        public override void Movement()
        {
            
        }
    }
}
