using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Table
    {
        string tableCode;
        Piece[] pieces;

        public Table()
        {
            tableCode = "";
            pieces = new Piece [36];
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
            tableCode = resultCode;
        }
    }
}
