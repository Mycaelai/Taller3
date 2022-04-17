using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Player
    {
        private string name;
        private int score;
        private float gamesWon;
        //Color de las piezas {true} = White || {false} = Black
        private bool color;

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }
        public float GamesWon { get => gamesWon; set => gamesWon = value; }
        public bool Color { get => color; set => color = value; }

        public Player(string name)
        {
            this.Name = name;
            Score = 0;
            GamesWon = 0;
        }

        public void Show()
        {
            Console.WriteLine("Player name:\t" + Name);
            Console.WriteLine("Score:\t" + Score);
            Console.WriteLine("Games Won:\t" + GamesWon);
        }

        public void SaveScore()
        {
            Score = Score + 100;
            GamesWon = GamesWon + 1;
            Console.WriteLine("Update\nPlayer name:\t" + Name);
            Console.WriteLine("New Score:\t" + Score);
            Console.WriteLine("Games Won:\t" + GamesWon);
        }

    }
}
