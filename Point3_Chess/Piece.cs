using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
     class Piece 
    {
        string tag, pieceCode, color;
        static string size;
        //Arreglo de dos posiciones en el cual el primer digito representa la fila y el segundo la columna
        int position;
        //State in game of the pieces {true} = Alive || {false} = Death
        bool state;

        public string Color { get => color; set => color = value; }

        public Piece(string color, int position)
        {
            tag = "none";
            pieceCode = "";
            CodeCreation();

            this.Color = color;
            size = "3 cm";

            this.position = position;

            state = true;
        }

        public void Show()
        {
            Console.Write("Code: " + pieceCode + $" Color: {Color}\t");
        }

        public void CodeCreation()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new char[2];
            Random random = new Random();

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }
            String resultCode = new String(code);
            pieceCode = resultCode;
        }

        public virtual void Movement()
        {

        }
    }
}
