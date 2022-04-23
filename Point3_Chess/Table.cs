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
                
                //Column {0}, lane {1}
                    pieces[i] = new Pawn("", 2, i+1);
                if (i >= 8)                
                    pieces[i] = new Rook("", 1, 1);
                if (i >= 9)
                    pieces[i] = new Rook("", 1, 8);                   
                if (i >= 10)                
                    pieces[i] = new Knight("", 1, 2);
                if (i >= 11)
                    pieces[i] = new Knight("", 1, 7);                
                if (i >= 12)                
                    pieces[i] = new Pope("", 1, 3);
                if (i >= 13)
                    pieces[i] = new Pope("", 1, 6);               
                if (i >= 14)
                    pieces[i] = new Queen("", 1, 4);
                if (i >= 15)                
                    pieces[i] = new King("", 1, 5);
                if (i >= 16)
                    pieces[i] = new Pawn("", 7, (i-16) + 1);
                if (i >= 24)                
                    pieces[i] = new Rook("", 8, 1);
                if (i >= 25)
                    pieces[i] = new Rook("", 8, 8);                
                if (i >= 26)                
                    pieces[i] = new Knight("", 8, 2);
                if (i >= 27)
                    pieces[i] = new Knight("", 8, 7);                
                if (i >= 28)                
                    pieces[i] = new Pope("", 8, 3);
                if (i >= 29)
                    pieces[i] = new Pope("", 8, 6);
                if (i >= 30)
                    pieces[i] = new Queen("", 8, 4);
                if (i >= 31)
                    pieces[i] = new King("", 8, 5);



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
