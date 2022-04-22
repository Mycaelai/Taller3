using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
     class Piece 
    {
        protected string tag, pieceCode, color;
        protected static string size = "3 cm";
        //Arreglo de dos posiciones en el cual el primer digito representa la fila y el segundo la columna
        protected int [] position = new int[2];
        //State in game of the pieces {true} = Alive || {false} = Death
        protected bool state;

        public string Color { get => color; set => color = value; }
        public string Tag { get => tag; set => tag = value; }

        public Piece(string color, int colunm, int line)
        {
            CodeCreation();
            this.Color = color;
            position = new[] {colunm,line};
            state = true;
            tag = "none";
        }

        public void Show()
        {
            Console.Write("Code: " + pieceCode + $" Color: {Color}\t" + "Position: " + position[0] + ":" + position[1] + " Tag: " + tag + " ");
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
