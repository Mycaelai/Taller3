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
        int[] position;
        bool state;

        public Piece(string color, int[] position)
        {
            pieceCode = "";
            this.color = color;
            this.position = position;
            size = "2 Inchs";
            position = new int[2];
        }

        public void CodeCreation()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new char[8];
            Random random = new Random();

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }
            String resultCode = new String(code);
            pieceCode = resultCode;
        }

        public abstract void Movement();
    }
}
