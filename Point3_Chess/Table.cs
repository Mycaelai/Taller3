using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Table
    {
        private string tableCode;
        Piece[] pieces;

        public Table()
        {
            //Se crea el arreglo que contiene la 32 piezas
            pieces = new Piece [32];

            //En este espacio se deben de agregar todos las piezas restantes, do momento solo funciona para agregar instacias normales, se recomienda un switch o distintos ciclos
            for(int i = 0; i < pieces.Length; i++)
            {
                pieces[i] = new Piece("none", 0);
                //Las primeras 16 piezas anexadas son Blancas y las restantes Negras
                if (i < 16)
                    pieces[i].Color = "White";
                else
                    pieces[i].Color = "Black";
            }
        }

        public void Show()
        {
            //Metodo Show visualiza el codigo de la mesa
            Console.WriteLine(tableCode);
        }

        public void ViewPieces()
        {
            //Visualizacion de las piezas
            Console.Write("Pieces codes:\n");
            for (int i = 0; i < pieces.Length; i++)
            {
                pieces[i].Show();
                if ((i + 1) % 4 == 0) //Colocamos 4 elementos por línea
                    Console.WriteLine();
            }
        }

        public void CodeCreation()
        {
            //Generador de Codigos de la mesa, el codigo esta en formato Hexadecimal
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new char[8];
            Random random = new Random();

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }
            String resultCode = new String(code);
            tableCode = resultCode;
        }
    }
}
