using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Pope : Piece
    {
        public Pope(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "POPE";
        }
    }
}
