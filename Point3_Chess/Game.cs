using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Game
    {
        string gameCode;
        Player[] players;
        Table table;
        string MatchTime, MatchstartTime;

        public string GameCode { get => gameCode; set => gameCode = value; }

        public Game( Player[] players)
        {
            this.GameCode = gameCode;
            this.players = players;
            gameCode = "";
        }

        public void Show()
        {
            Console.WriteLine(GameCode);
        }

        public void PlayGame()
        {
            MatchstartTime = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(MatchstartTime);
        }

        public void CodeCreation()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char [] code = new char[8];
            Random random = new Random();

            for(int i = 0; i < code.Length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }
            String resultCode = new String(code);
            gameCode = resultCode;
        }
    }
}
