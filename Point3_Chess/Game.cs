using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Game
    {
        int winer;
        string gameCode;
        Player[] players;
        Table table;
        string matchstartTime, matchTime;

        public string GameCode { get => gameCode; set => gameCode = value; }
        public string MatchTime { get => matchTime; set => matchTime = value; }
        internal Player[] Players { get => players; set => players = value; }

        public Game( Player[] players)
        {
            //Se asigana el codigo de la partida y se llama al metodo para crearlo
            this.GameCode = gameCode;
            CodeCreation();

            //Se crean los espacios para los jugadores, en este caso los jugadores se asignan por medio del constructor de la partida
            this.players = players;
            players = new Player[2];

            //Se crea la instancia de la partida y se llama y metodo que crea el codigo de la mesa
            Table table = new Table();
            this.table = table;
            table.CodeCreation();
        }

        public void Show()
        {
            //Metodo Show Que debe mostrar los codigos de mesa y tabla, tambien el nombre de los jugadores
            Console.WriteLine("\nGAME CODE: " + GameCode + "\n...");
            Console.WriteLine(players[0].Name + " vs " + players[1].Name);
            //Confirmacion de que los jugadores tienen respectivas piezas distintas
            if(players[0].Color == true && players[1].Color == false)
            Console.WriteLine("White Player vs Black Player");
            //Se llama al Metodo Show de la mesa para visualizar el codigo
            Console.Write("TABLE CODE:\t");
            table.Show();
            Console.WriteLine();
        }

        public void Results()
        {
            Console.WriteLine("Start hour of the game\t" + matchstartTime);
            Console.WriteLine("Duration of the game:\t" + MatchTime);
            if (winer == 1)
                Console.WriteLine("WHITE PLAYER HAS WON");
            else                
                Console.WriteLine("BLACK PLAYER HAS WON");
        }

        public void ShowName()
        {
            Console.WriteLine("\t" + players[0].Name + " vs " + players[1].Name);
        }

        private void CodeCreation()
        {
            //Generador de Codigos de la partida, el codigo esta en formato Hexadecimal
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
            //Aca se le da el Color a cada uno de los jugadores
            players[0].Color = true;
            players[1].Color = false;
            Show();
            //Linea que establece la hora de inicio de la partida
            matchstartTime = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine("Start hour of the game\t" + matchstartTime);
            //Se llama a la duracion de tiempo de la partida
            GameTime();
            Console.WriteLine("Duration of the game:\t" + MatchTime);
            Console.WriteLine();
            //Aca se crea la varible para definir al ganadador
            int winer;
            //Se asigna el aleatorio
            Random random = new Random();
            winer = random.Next(1, 3);
            //Se crean los casos para el jugador de Blancas y Negras
            if(winer == 1)
            {
                Console.WriteLine("WHITE PLAYER HAS WON");
                players[0].SaveScore();
            }
            else
            {
                Console.WriteLine("BLACK PLAYER HAS WON");
                players[1].SaveScore();
            }
            Console.WriteLine();
        }

        public void ReferenceT()
        {
            //Llama al mtedo para poder visualizar las piezas de table
            table.ViewPieces();
        }

        private void GameTime()
        {
            //Metodo que genera la duracion de la partida, partida va desde 0:15 h:m a 3:59 h:m
            int hour;
            int minute;
            Random random = new Random();
            hour = random.Next(00, 03);
            
            if(hour == 00)
            {
                minute = random.Next(15, 59);
                MatchTime = "0" + hour.ToString() + "hh:" + minute.ToString() + "mm";
            }
            else
            {
                minute = random.Next(00, 59);
                if (minute < 10)
                {
                    MatchTime = "0" + hour.ToString() + "hh:0" + minute.ToString() + "mm";
                }
                else
                MatchTime = "0" + hour.ToString() + "hh:" + minute.ToString() + "mm";
            }
        }
    }
}
