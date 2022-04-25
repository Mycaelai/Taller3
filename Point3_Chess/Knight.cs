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
            tag = "KNIGHT";
        }

        public override void Movement()
        {
            //Column {0}, lane {1}
            Console.WriteLine("The knight can move in an L shape, with 3 squares to any non diagonal side and another square in a perpendicular direction, it can jump over pieces");
        }
    }
}
