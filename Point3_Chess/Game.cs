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
        string matchstartTime, matchTime;

        public string GameCode { get => gameCode; set => gameCode = value; }
        public string MatchTime { get => matchTime; set => matchTime = value; }

        public Game( Player[] players)
        {
            this.GameCode = gameCode;
            this.players = players;
            gameCode = "";

            players = new Player[2];

            Table table = new Table();
            this.table = table;
            table.CodeCreation();
        }

        public void Show()
        {
            Console.WriteLine("GAME: " + GameCode + "\nBetween");
            Console.WriteLine(players[0].Name + " vs " + players[1].Name);
            Console.WriteLine(players[0].Color + " vs " + players[1].Color);
            Console.Write("Table Code:\t");
            table.Show();
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

        public void PlayGame()
        {
            matchstartTime = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(matchstartTime);
        }


        //public void AddPlayers(Player player)
        //{
        //    int i = 0;
        //    if (i < players.Length)
        //    {
        //        for (i = 0; i < players.Length; i++)
        //        {
        //            players[i] = player;
        //            i++;
        //        }
        //    }
        //    else
        //        Console.WriteLine("Match alredy have enough players");
        //}

        public void GameTime()
        {
            int hour;
            int minute;
            Random random = new Random();
            hour = random.Next(00, 03);
            
            if(hour == 00)
            {
                minute = random.Next(15, 59);
                MatchTime = "0" + hour.ToString() + ":" + minute.ToString();
            }
            else
            {
                minute = random.Next(00, 59);
                if (minute < 10)
                {
                    MatchTime = "0" + hour.ToString() + ":0" + minute.ToString();
                }
                else
                MatchTime = "0" + hour.ToString() + ":" + minute.ToString();
            }
        }
    }
}
