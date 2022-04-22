using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Knight : Piece
    {
        public Knight(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "Knight";
        }

        public override void Movement()
        {
            //Column {0}, lane {1}
        }
    }
}
