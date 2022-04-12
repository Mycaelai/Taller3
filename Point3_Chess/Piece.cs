using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    abstract class Piece
    {
        string pieceCode;
        string color;
        static string size;
        //Arreglo de dos posiciones en el cual el primer digito representa la fila y el segundo la columna
        int[] position = new int[2] { 0, 0 };
        bool state;

        public Piece(string color, int[] position)
        {
            this.color = color;
            this.position = position;
        }

        public abstract void Movement();
    }
}
